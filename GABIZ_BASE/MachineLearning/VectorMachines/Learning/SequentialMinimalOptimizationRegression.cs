﻿namespace GABIZ.Base.MachineLearning.VectorMachines.Learning
{
    using System;
    using System.Collections.Generic;
    using GABIZ.Base.Statistics.Kernels;

    /// <summary>
    ///   Sequential Minimal Optimization (SMO) Algorithm for Regression
    /// </summary>
    /// <remarks>
    /// <para>
    ///   The SMO algorithm is an algorithm for solving large quadratic programming (QP)
    ///   optimization problems, widely used for the training of support vector machines.
    ///   First developed by John C. Platt in 1998, SMO breaks up large QP problems into
    ///   a series of smallest possible QP problems, which are then solved analytically.</para>
    /// <para>
    ///   This class incorporates modifications in the original SMO algorithm to solve
    ///   regression problems as suggested by Alex J. Smola and Bernhard Scholkopf and
    ///   further modifications for better performance by Shevade et al.</para> 
    ///   
    /// <para>
    ///   References:
    ///   <list type="bullet">
    ///     <item><description>
    ///      A. J. Smola and B. Scholkopf. A Tutorial on Support Vector Regression. NeuroCOLT2
    ///      Technical Report Series, 1998. Available on: <a href="http://www.kernel-machines.org/publications/SmoSch98c">
    ///      http://www.kernel-machines.org/publications/SmoSch98c</a></description></item>
    ///     <item><description>
    ///      S.K. Shevade et al. Improvements to SMO Algorithm for SVM Regression, 1999. Available
    ///      on: <a href="http://drona.csa.iisc.ernet.in/~chiru/papers/ieee_smo_reg.ps.gz">
    ///      http://drona.csa.iisc.ernet.in/~chiru/papers/ieee_smo_reg.ps.gz</a></description></item>
    ///     <item><description>
    ///      G. W. Flake, S. Lawrence. Efficient SVM Regression Training with SMO.
    ///      Available on: <a href="http://www.keerthis.com/smoreg_ieee_shevade_00.pdf">
    ///      http://www.keerthis.com/smoreg_ieee_shevade_00.pdf</a></description></item>
    ///   </list></para>
    /// </remarks>
    /// 
    public class SequentialMinimalOptimizationRegression : ISupportVectorMachineLearning
    {

        // Training data
        private double[][] inputs;
        private double[] outputs;

        // Learning algorithm parameters
        private double c = 1.0;
        private double tolerance = 1e-3;
        private double epsilon = 1e-3;
        private double roundingEpsilon = 1e-12;

        // Support Vector Machine parameters
        private SupportVectorMachine machine;
        private IKernel kernel;
        private double[] alpha_a;
        private double[] alpha_b;


        // Improvements on the original SMO algorithm
        //  for better performance and efficiency:
        //  - Multiple thresholds
        private double biasLower;
        private double biasUpper;
        private int biasLowerIndex;
        private int biasUpperIndex;

        //  - Sets of indices
        private HashSet<int> set1;
        private HashSet<int> set2;
        private HashSet<int> set3;
        private HashSet<int> set4;

        // Error cache to speed up computations
        private double[] errors;



        /// <summary>
        ///   Initializes a new instance of a Sequential Minimal Optimization (SMO) algorithm.
        /// </summary>
        /// <param name="machine">A Support Vector Machine.</param>
        /// <param name="inputs">The input data points as row vectors.</param>
        /// <param name="outputs">The classification label for each data point.</param>
        public SequentialMinimalOptimizationRegression(SupportVectorMachine machine,
            double[][] inputs, double[] outputs)
        {

            // Initial argument checking
            if (machine == null) 
                throw new ArgumentNullException("machine");

            if (inputs == null)
                throw new ArgumentNullException("inputs");

            if (outputs == null)
                throw new ArgumentNullException("outputs");

            if (inputs.Length != outputs.Length)
                throw new ArgumentException("The number of inputs and outputs does not match.", "outputs");

            if (machine.Inputs > 0)
            {
                // This machine has a fixed input vector size
                for (int i = 0; i < inputs.Length; i++)
                    if (inputs[i].Length != machine.Inputs)
                        throw new ArgumentException("The size of the input vectors does not match the expected number of inputs of the machine");
            }


            // Machine
            this.machine = machine;

            // Kernel (if applicable)
            KernelSupportVectorMachine ksvm = machine as KernelSupportVectorMachine;
            this.kernel = (ksvm != null) ? ksvm.Kernel : new Linear();


            // Learning data
            this.inputs = inputs;
            this.outputs = outputs;

        }


        //---------------------------------------------


        #region Properties
        /// <summary>
        ///   Complexity (cost) parameter C. Increasing the value of C forces the creation
        ///   of a more accurate model that may not generalize well. Default value is 1.
        /// </summary>
        /// <remarks>
        ///   The cost parameter C controls the trade off between allowing training
        ///   errors and forcing rigid margins. It creates a soft margin that permits
        ///   some misclassifications. Increasing the value of C increases the cost of
        ///   misclassifying points and forces the creation of a more accurate model
        ///   that may not generalize well.
        /// </remarks>
        public double Complexity
        {
            get { return this.c; }
            set { this.c = value; }
        }

        /// <summary>
        ///   Insensitivity zone ε. Increasing the value of ε can result in fewer support
        ///   vectors in the created model. Default value is 1e-3.
        /// </summary>
        /// <remarks>
        ///   Parameter ε controls the width of the ε-insensitive zone, used to fit the training
        ///   data. The value of ε can affect the number of support vectors used to construct the
        ///   regression function. The bigger ε, the fewer support vectors are selected. On the
        ///   other hand, bigger ε-values results in more flat estimates.
        /// </remarks>
        public double Epsilon
        {
            get { return this.epsilon; }
            set { this.epsilon = value; }
        }

        /// <summary>
        ///   Convergence tolerance. Default value is 1e-3.
        /// </summary>
        /// <remarks>
        ///   The criterion for completing the model training process. The default is 0.001.
        /// </remarks>
        public double Tolerance
        {
            get { return this.tolerance; }
            set { this.tolerance = value; }
        }
        #endregion


        //---------------------------------------------


        /// <summary>
        ///   Runs the SMO algorithm.
        /// </summary>
        /// <param name="computeError">
        ///   True to compute error after the training
        ///   process completes, false otherwise. Default is true.
        /// </param>
        /// <returns>
        ///   The sum of squares error rate for
        ///   the resulting support vector machine.
        /// </returns>
        public double Run(bool computeError)
        {

            // The SMO algorithm chooses to solve the smallest possible optimization problem
            // at every step. At every step, SMO chooses two Lagrange multipliers to jointly
            // optimize, finds the optimal values for these multipliers, and updates the SVM
            // to reflect the new optimal values
            //
            // References:
            //   - http://research.microsoft.com/en-us/um/people/jplatt/smoTR.pdf
            //   - http://www.kernel-machines.org/publications/SmoSch98c
            //   - http://drona.csa.iisc.ernet.in/~chiru/papers/ieee_smo_reg.ps.gz


            // Initialize variables
            int N = inputs.Length;

            // Lagrange multipliers
            this.alpha_a = new double[N];
            this.alpha_b = new double[N];

            // Error cache
            this.errors = new double[N];

            // Indices sets
            this.set1 = new HashSet<int>();
            this.set2 = new HashSet<int>();
            this.set3 = new HashSet<int>();
            this.set4 = new HashSet<int>();

            // Set the second set of indices to contain all inputs
            for (int i = 0; i < N; i++) this.set2.Add(i);

            // Choose any example from the training set as starting bias
            this.biasUpperIndex = 0; // any example, such as 0
            this.biasLowerIndex = 0;
            this.biasUpper = outputs[0] + epsilon;
            this.biasLower = outputs[0] - epsilon;


            // Algorithm:
            int numChanged = 0;
            bool examineAll = true;
            while (numChanged > 0 || examineAll)
            {
                numChanged = 0;
                if (examineAll)
                {
                    // loop over all examples
                    for (int i = 0; i < N; i++)
                        numChanged += examineExample(i);
                }
                else
                {
                    // loop over all examples where a and a*
                    //  are greater than 0 and less than C.
                    for (int i = 0; i < N; i++)
                    {
                        if ((0 < alpha_a[i] && alpha_a[i] < c) ||
                            (0 < alpha_b[i] && alpha_b[i] < c))
                        {
                            numChanged += examineExample(i);

                            if (biasUpper > biasLower - 2.0 * tolerance)
                            {
                                numChanged = 0;
                                break;
                            }
                        }
                    }
                }

                if (examineAll)
                    examineAll = false;
                else if (numChanged == 0)
                    examineAll = true;
            }
            // end.


            // Store Support Vectors in the SV Machine. Only vectors which have lagrange multipliers
            // greater than zero will be stored as only those are actually required during evaluation.
            List<int> indices = new List<int>();
            for (int i = 0; i < N; i++)
            {
                // Only store vectors with multipliers > 0
                if (alpha_a[i] > 0 || alpha_b[i] > 0) indices.Add(i);
            }

            int vectors = indices.Count;
            machine.SupportVectors = new double[vectors][];
            machine.Weights = new double[vectors];
            for (int i = 0; i < vectors; i++)
            {
                int j = indices[i];
                machine.SupportVectors[i] = inputs[j];
                machine.Weights[i] = alpha_a[j] - alpha_b[j];
            }
            machine.Threshold = (biasLower + biasUpper) / 2.0;


            // Compute error if required.
            return (computeError) ? ComputeError(inputs, outputs) : 0.0;
        }

        /// <summary>
        ///   Runs the SMO algorithm.
        /// </summary>
        /// <returns>
        ///   The sum of squares error rate for
        ///   the resulting support vector machine.
        /// </returns>
        public double Run()
        {
            return Run(true);
        }

        /// <summary>
        ///   Computes the error ratio for a given set of input and outputs.
        /// </summary>
        public double ComputeError(double[][] inputs, double[] expectedOutputs)
        {
            // Compute errors
            double sum = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                double s = machine.Compute(inputs[i]) - expectedOutputs[i];
                sum += s * s;
            }

            // Return error sum of squares
            return sum;
        }


        //---------------------------------------------


        /// <summary>
        ///  Chooses which multipliers to optimize using heuristics.
        /// </summary>
        private int examineExample(int i2)
        {

            double alpha2a = alpha_a[i2]; // Lagrange multiplier a  for i2
            double alpha2b = alpha_b[i2]; // Lagrange multiplier a* for i2 


            #region Compute example error
            double e2 = 0.0;
            if (set1.Contains(i2))
            {
                // Value is cached
                e2 = errors[i2];
            }
            else
            {
                // Value is not cached and should be computed
                errors[i2] = e2 = outputs[i2] - compute(inputs[i2]);

                // Update thresholds
                if (set2.Contains(i2))
                {
                    if (e2 + epsilon < biasUpper)
                    {
                        biasUpper = e2 + epsilon;
                        biasUpperIndex = i2;
                    }
                    else if (e2 - epsilon > biasLower)
                    {
                        biasLower = e2 - epsilon;
                        biasLowerIndex = i2;
                    }
                }
                else if (set3.Contains(i2) && (e2 + epsilon > biasLower))
                {
                    biasLower = e2 + epsilon;
                    biasLowerIndex = i2;
                }
                else if (set4.Contains(i2) && (e2 - epsilon < biasUpper))
                {
                    biasUpper = e2 - epsilon;
                    biasUpperIndex = i2;
                }
            }
            #endregion


            #region Check optimality using current thresholds
            // Check optimality using current thresholds then select
            //   the best i1 to joint optimize when appropriate.

            int i1 = 0;
            bool optimal = true;


            // In case i2 is in the first set of indices:
            if (set1.Contains(i2))
            {
                if (0 < alpha2a && alpha2a < c)
                {
                    if (biasLower - (e2 - epsilon) > 2.0 * tolerance)
                    {
                        optimal = false;

                        i1 = biasLowerIndex;
                        if ((e2 - epsilon) - biasUpper > biasLower - (e2 - epsilon))
                            i1 = biasUpperIndex;
                    }
                    else if ((e2 - epsilon) - biasUpper > 2.0 * tolerance)
                    {
                        optimal = false;

                        i1 = biasUpperIndex;
                        if (biasLower - (e2 - epsilon) > (e2 - epsilon) - biasUpper)
                            i1 = biasLowerIndex;
                    }
                }

                else if (0 < alpha2b && alpha2b < c)
                {
                    if (biasLower - (e2 + epsilon) > 2.0 * tolerance)
                    {
                        optimal = false;

                        i1 = biasLowerIndex;
                        if ((e2 + epsilon) - biasUpper > biasLower - (e2 + epsilon))
                            i1 = biasUpperIndex;
                    }
                    else if ((e2 + epsilon) - biasUpper > 2.0 * tolerance)
                    {
                        optimal = false;

                        i1 = biasUpperIndex;
                        if (biasLower - (e2 + epsilon) > (e2 + epsilon) - biasUpper)
                            i1 = biasLowerIndex;
                    }
                }
            }

            // In case i2 is in the second set of indices:
            else if (set2.Contains(i2))
            {
                if (biasLower - (e2 + epsilon) > 2.0 * tolerance)
                {
                    optimal = false;

                    i1 = biasLowerIndex;
                    if ((e2 + epsilon) - biasUpper > biasLower - (e2 + epsilon))
                        i1 = biasUpperIndex;
                }
                else if ((e2 - epsilon) - biasUpper > 2.0 * tolerance)
                {
                    optimal = false;

                    i1 = biasUpperIndex;
                    if (biasLower - (e2 - epsilon) > (e2 - epsilon) - biasUpper)
                        i1 = biasLowerIndex;
                }
            }

            // In case i2 is in the third set of indices:
            else if (set3.Contains(i2))
            {
                if ((e2 + epsilon) - biasUpper > 2.0 * tolerance)
                {
                    optimal = false;
                    i1 = biasUpperIndex;
                }
            }

            // In case i2 is in the fourth set of indices:
            else if (set4.Contains(i2))
            {
                if (biasLower - (e2 - epsilon) > 2.0 * tolerance)
                {
                    optimal = false;
                    i1 = biasLowerIndex;
                }
            }
            #endregion


            if (optimal)
            {
                // The examples are already optimal.
                return 0;//  No need to optimize.
            }
            else
            {
                // Optimize i1 and i2
                if (takeStep(i1, i2)) return 1;
            }

            return 0;
        }

        /// <summary>
        ///   Analytically solves the optimization problem for two Lagrange multipliers.
        /// </summary>
        private bool takeStep(int i1, int i2)
        {
            if (i1 == i2) return false;

            // Lagrange multipliers
            double alpha1a = alpha_a[i1];
            double alpha1b = alpha_b[i1];
            double alpha2a = alpha_a[i2];
            double alpha2b = alpha_b[i2];

            // Errors
            double e1 = errors[i1];
            double e2 = errors[i2];
            double delta = e1 - e2;

            // Kernel evaluation
            double k11 = kernel.Function(inputs[i1], inputs[i1]);
            double k12 = kernel.Function(inputs[i1], inputs[i2]);
            double k22 = kernel.Function(inputs[i2], inputs[i2]);
            double eta = -2.0 * k12 + k11 + k22;
            double gamma = alpha1a - alpha1b + alpha2a - alpha2b;

            // Assume the kernel is positive definite.
            if (eta < 0) eta = 0;



            #region Optimize
            bool case1 = false;
            bool case2 = false;
            bool case3 = false;
            bool case4 = false;

            bool changed = false;
            bool finished = false;

            double L, H, a1, a2;

            while (!finished)
            {

                if (!case1
                         && (alpha1a > 0 || (alpha1b == 0 && delta > 0))
                         && (alpha2a > 0 || (alpha2b == 0 && delta < 0)))
                {
                    // Compute L and H (wrt alpha1, alpha2)
                    L = System.Math.Max(0, gamma - this.c);
                    H = System.Math.Min(this.c, gamma);

                    if (L < H)
                    {
                        if (eta > 0)
                        {
                            a2 = alpha2a - (delta / eta);

                            if (a2 > H) a2 = H;
                            else if (a2 < L) a2 = L;
                        }
                        else
                        {
                            double Lobj = -L * delta;
                            double Hobj = -H * delta;

                            if (Lobj > Hobj) a2 = L;
                            else a2 = H;
                        }

                        a1 = alpha1a - (a2 - alpha2a);

                        // Update alpha1, alpha2 if change is larger than some epsilon
                        if (System.Math.Abs(a1 - alpha1a) > roundingEpsilon ||
                            System.Math.Abs(a2 - alpha2a) > roundingEpsilon)
                        {
                            alpha1a = a1;
                            alpha2a = a2;
                            changed = true;
                        }
                    }
                    else finished = true;

                    case1 = true;
                }

                else if (!case2
                         && (alpha1a > 0 || (alpha1b == 0 && delta > 2 * epsilon))
                         && (alpha2b > 0 || (alpha2a == 0 && delta > 2 * epsilon)))
                {
                    // Compute L and H  (wrt alpha1, alpha2*)
                    L = System.Math.Max(0, -gamma);
                    H = System.Math.Min(this.c, -gamma + this.c);

                    if (L < H)
                    {
                        if (eta > 0)
                        {
                            a2 = alpha2b + ((delta - 2 * epsilon) / eta);

                            if (a2 > H) a2 = H;
                            else if (a2 < L) a2 = L;
                        }
                        else
                        {
                            double Lobj = L * (-2 * epsilon + delta);
                            double Hobj = H * (-2 * epsilon + delta);

                            if (Lobj > Hobj) a2 = L;
                            else a2 = H;
                        }
                        a1 = alpha1a + (a2 - alpha2b);

                        // Update alpha1, alpha2* if change is larger than some epsilon
                        if (System.Math.Abs(a1 - alpha1a) > roundingEpsilon ||
                            System.Math.Abs(a2 - alpha2b) > roundingEpsilon)
                        {
                            alpha1a = a1;
                            alpha2b = a2;
                            changed = true;
                        }
                    }
                    else finished = true;

                    case2 = true;
                }

                else if (!case3
                      && (alpha1b > 0 || (alpha1a == 0 && delta < -2 * epsilon))
                      && (alpha2a > 0 || (alpha2b == 0 && delta < -2 * epsilon)))
                {
                    // Compute L and H (wrt alpha1*, alpha2)
                    L = System.Math.Max(0, gamma);
                    H = System.Math.Min(this.c, this.c + gamma);

                    if (L < H)
                    {
                        if (eta > 0)
                        {
                            a2 = alpha2a - ((delta + 2 * epsilon) / eta);

                            if (a2 > H) a2 = H;
                            else if (a2 < L) a2 = L;
                        }
                        else
                        {
                            double Lobj = -L * (2 * epsilon + delta);
                            double Hobj = -H * (2 * epsilon + delta);

                            if (Lobj > Hobj) a2 = L;
                            else a2 = H;
                        }
                        a1 = alpha1b + (a2 - alpha2a);

                        // Update alpha1*, alpha2 if change is larger than some epsilon
                        if (System.Math.Abs(a1 - alpha1b) > roundingEpsilon ||
                            System.Math.Abs(a2 - alpha2a) > roundingEpsilon)
                        {
                            alpha1b = a1;
                            alpha2a = a2;
                            changed = true;
                        }
                    }
                    else finished = true;

                    case3 = true;
                }

                else if (!case4
                      && (alpha1b > 0 || (alpha1a == 0 && delta < 0))
                      && (alpha2b > 0 || (alpha2a == 0 && delta > 0)))
                {
                    // Compute L and H (wrt alpha1*, alpha2*)
                    L = System.Math.Max(0, -gamma - this.c);
                    H = System.Math.Min(this.c, -gamma);

                    if (L < H)
                    {
                        if (eta > 0)
                        {
                            a2 = alpha2b + delta / eta;

                            if (a2 > H) a2 = H;
                            else if (a2 < L) a2 = L;
                        }
                        else
                        {
                            double Lobj = L * delta;
                            double Hobj = H * delta;

                            if (Lobj > Hobj) a2 = L;
                            else a2 = H;
                        }

                        a1 = alpha1b - (a2 - alpha2b);

                        // Update alpha1*, alpha2* if change is larger than some epsilon
                        if (System.Math.Abs(a1 - alpha1b) > roundingEpsilon ||
                            System.Math.Abs(a2 - alpha2b) > roundingEpsilon)
                        {
                            alpha1b = a1;
                            alpha2b = a2;
                            changed = true;
                        }
                    }
                    else finished = true;

                    case4 = true;
                }

                else finished = true;

                // Update the delta
                delta += eta * ((alpha2a - alpha2b) - (alpha_a[i2] - alpha_b[i2]));
            }


            // If nothing has changed, return false.
            if (!changed) return false;
            #endregion



            #region Update error cache
            // Update error cache using new Lagrange multipliers
            foreach (int i in set1)
            {
                if (i != i1 && i != i2)
                {
                    // Update all in set i0 except i1 and i2 (because we have the kernel function cached for them)
                    errors[i] += ((alpha_a[i1] - alpha_b[i1]) - (alpha1a - alpha1b)) * kernel.Function(inputs[i1], inputs[i])
                               + ((alpha_a[i2] - alpha_b[i2]) - (alpha2a - alpha2b)) * kernel.Function(inputs[i2], inputs[i]);
                }
            }

            // Update error cache using new Lagrange multipliers for i1 and i2
            errors[i1] += ((alpha_a[i1] - alpha_b[i1]) - (alpha1a - alpha1b)) * k11
                        + ((alpha_a[i2] - alpha_b[i2]) - (alpha2a - alpha2b)) * k12;
            errors[i2] += ((alpha_a[i1] - alpha_b[i1]) - (alpha1a - alpha1b)) * k12
                        + ((alpha_a[i2] - alpha_b[i2]) - (alpha2a - alpha2b)) * k22;
            #endregion


            #region Store the new Lagrange multipliers
            // Store the changes in the alpha, alpha* arrays
            alpha_a[i1] = alpha1a;
            alpha_b[i1] = alpha1b;
            alpha_a[i2] = alpha2a;
            alpha_b[i2] = alpha2b;
            #endregion


            #region Update the sets of indices
            // Update the sets of indices (for i1)
            if ((0 < alpha1a && alpha1a < this.c) || (0 < alpha1b && alpha1b < this.c))
                set1.Add(i1);
            else set1.Remove(i1);

            if ((alpha1a == 0 && alpha1b == 0))
                set2.Add(i1);
            else set2.Remove(i1);

            if ((alpha1a == 0 && alpha1b == this.c))
                set3.Add(i1);
            else set3.Remove(i1);

            if ((alpha1a == this.c && alpha1b == 0))
                set4.Add(i1);
            else set4.Remove(i1);

            // Update the sets of indices (for i2)
            if ((0 < alpha2a && alpha2a < this.c) || (0 < alpha2b && alpha2b < this.c))
                set1.Add(i2);
            else set1.Remove(i2);

            if ((alpha2a == 0 && alpha2b == 0))
                set2.Add(i2);
            else set2.Remove(i2);

            if ((alpha2a == 0 && alpha2b == this.c))
                set3.Add(i2);
            else set3.Remove(i2);

            if ((alpha2a == this.c && alpha2b == 0))
                set4.Add(i2);
            else set4.Remove(i2);
            #endregion


            #region Compute the new thresholds
            biasLower = Double.MinValue;
            biasUpper = Double.MaxValue;

            foreach (int i in set1)
            {
                if (0 < alpha_b[i] && alpha_b[i] < this.c
                    && errors[i] + epsilon > biasLower)
                {
                    biasLower = errors[i] + epsilon;
                    biasLowerIndex = i;
                }
                else if (0 < alpha_a[i] && alpha_a[i] < this.c
                    && errors[i] - epsilon > biasLower)
                {
                    biasLower = errors[i] - epsilon;
                    biasLowerIndex = i;
                }
                if (0 < alpha_a[i] && alpha_a[i] < this.c
                    && errors[i] - epsilon < biasUpper)
                {
                    biasUpper = errors[i] - epsilon;
                    biasUpperIndex = i;
                }
                else if (0 < alpha_b[i] && alpha_b[i] < this.c
                    && errors[i] + epsilon < biasUpper)
                {
                    biasUpper = errors[i] + epsilon;
                    biasUpperIndex = i;
                }
            }

            if (!set1.Contains(i1))
            {
                if (set3.Contains(i1) && errors[i1] + epsilon > biasLower)
                {
                    biasLower = errors[i1] + epsilon;
                    biasLowerIndex = i1;
                }
                else if (set2.Contains(i1) && errors[i1] - epsilon > biasLower)
                {
                    biasLower = errors[i1] - epsilon;
                    biasLowerIndex = i1;
                }

                if (set4.Contains(i1) && errors[i1] - epsilon < biasUpper)
                {
                    biasUpper = errors[i1] - epsilon;
                    biasUpperIndex = i1;
                }
                else if (set2.Contains(i1) && errors[i1] + epsilon < biasUpper)
                {
                    biasUpper = errors[i1] + epsilon;
                    biasUpperIndex = i1;
                }
            }

            if (!set1.Contains(i2))
            {
                if (set3.Contains(i2) && errors[i2] + epsilon > biasLower)
                {
                    biasLower = errors[i2] + epsilon;
                    biasLowerIndex = i2;
                }
                else if (set2.Contains(i2) && errors[i2] - epsilon > biasLower)
                {
                    biasLower = errors[i2] - epsilon;
                    biasLowerIndex = i2;
                }

                if (set4.Contains(i2) && errors[i2] - epsilon < biasUpper)
                {
                    biasUpper = errors[i2] - epsilon;
                    biasUpperIndex = i2;
                }
                else if (set2.Contains(i2) && errors[i2] + epsilon < biasUpper)
                {
                    biasUpper = errors[i2] + epsilon;
                    biasUpperIndex = i2;
                }
            }
            #endregion


            // Success.
            return true;
        }

        /// <summary>
        ///   Computes the SVM output for a given point.
        /// </summary>
        private double compute(double[] point)
        {
            double sum = 0;
            for (int j = 0; j < alpha_a.Length; j++)
                sum += (alpha_a[j] - alpha_b[j]) * kernel.Function(point, inputs[j]);
            return sum;
        }

    }
}
