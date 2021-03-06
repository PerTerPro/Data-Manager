﻿// GABIZ.Base Statistics Library
// The GABIZ.Base.NET Framework
// http://GABIZ.Base-net.origo.ethz.ch
//
// Copyright © César Souza, 2009-2011
// cesarsouza at gmail.com
// http://www.crsouza.com
//

namespace GABIZ.Base.Statistics.Kernels.Sparse
{
    using System;

    /// <summary>
    ///   Sparse Gaussian Kernel.
    /// </summary>
    /// <remarks>
    /// <para>
    ///   The Gaussian kernel requires tuning for the proper value of σ. Manual tuning or brute
    ///   force search are alternative approaches. An brute force technique could involve
    ///   stepping through a range of values for σ, perhaps in a gradient ascent optimization,
    ///   seeking optimal performance of a model with training data.</para>
    /// <para>
    ///   Regardless of the method utilized to find a proper value for σ, this type of model
    ///   validation is common and necessary when using the gaussian kernel. Although this 
    ///   approach is feasible with supervised learning, it is much more difficult to tune σ
    ///   for unsupervised learning methods.</para>
    ///    
    /// <para>
    ///   References:
    ///   <list type="bullet">
    ///     <item><description><a href="http://people.revoledu.com/kardi/tutorial/Regression/KernelRegression/Kernel.htm">
    ///        http://people.revoledu.com/kardi/tutorial/Regression/KernelRegression/Kernel.htm</a></description></item>
    ///    </list></para>
    /// </remarks>
    /// 
    [Serializable]
    public sealed class SparseGaussian
    {
        private double sigma;
        private double gamma;

        /// <summary>
        ///   Constructs a new Sparse Gaussian Kernel
        /// </summary>
        /// <param name="sigma">The standard deviation for the Gaussian distribution.</param>
        public SparseGaussian(double sigma)
        {
            this.Sigma = sigma;
        }

        /// <summary>
        ///   Gets or sets the sigma value for the kernel. When setting
        ///   sigma, gamma gets updated GABIZ.Baseingly (gamma = 0.5*/sigma^2).
        /// </summary>
        public double Sigma
        {
            get { return sigma; }
            set
            {
                sigma = value;
                gamma = 1.0 / (2.0 * sigma * sigma);
            }
        }

        /// <summary>
        ///   Gets or sets the gamma value for the kernel. When setting
        ///   gamma, sigma gets updated GABIZ.Baseingly (gamma = 0.5*/sigma^2).
        /// </summary>
        public double Gamma
        {
            get { return gamma; }
            set
            {
                gamma = value;
                sigma = System.Math.Sqrt(1.0 / (gamma * 2.0));
            }
        }

        /// <summary>
        /// Gaussian Kernel function.
        /// </summary>
        /// <param name="x">Vector <c>x</c> in input space.</param>
        /// <param name="y">Vector <c>y</c> in input space.</param>
        /// <returns>Dot product in feature (kernel) space.</returns>
        public  double Function(double[] x, double[] y)
        {
            // Optimization in case x and y are
            // exactly the same object reference.
            if (x == y) return 1.0;

            double norm = 0.0, d;

            int i = 0, j = 0;
            double posx, posy;

            while (i < x.Length || j < y.Length)
            {
                posx = x[i]; posy = y[j];

                if (posx == posy)
                {
                    d = x[i + 1] - y[j + 1];
                    norm += d * d;
                    i += 2; j += 2;
                }
                else if (posx < posy)
                {
                    d = x[j + 1];
                    norm += d * d;
                    i += 2;
                }
                else if (posx > posy)
                {
                    d = y[i + 1];
                    norm += d * d;
                    j += 2;
                }
            }

            return System.Math.Exp(norm * -Gamma);
        }

        /// <summary>
        /// Computes the distance in input space
        /// between two points given in feature space.
        /// </summary>
        /// <param name="x">Vector <c>x</c> in feature (kernel) space.</param>
        /// <param name="y">Vector <c>y</c> in feature (kernel) space.</param>
        /// <returns>
        /// Distance between <c>x</c> and <c>y</c> in input space.
        /// </returns>
        public  double Distance(double[] x, double[] y)
        {
            if (x == y) return 0.0;

            double norm = 0.0, d;

            int i = 0, j = 0;
            double posx, posy;

            while (i < x.Length || j < y.Length)
            {
                posx = x[i]; posy = y[j];

                if (posx == posy)
                {
                    d = x[i + 1] - y[j + 1];
                    norm += d * d;
                    i += 2; j += 2;
                }
                else if (posx < posy)
                {
                    d = x[j + 1];
                    norm += d * d;
                    i += 2;
                }
                else if (posx > posy)
                {
                    d = y[i + 1];
                    norm += d * d;
                    j += 2;
                }
            }

            // TODO: Verify the use of log1p instead
            return (1.0 / -Gamma) * System.Math.Log(1.0 - 0.5 * norm);
        }

    }
}
