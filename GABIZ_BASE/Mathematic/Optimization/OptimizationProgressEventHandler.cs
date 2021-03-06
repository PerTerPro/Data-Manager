﻿// GABIZ.Base Math Library
// The GABIZ.Base.NET Framework
// http://GABIZ.Base-net.origo.ethz.ch
//
// Copyright © César Souza, 2009-2011
// cesarsouza at gmail.com
// http://www.crsouza.com
//

namespace GABIZ.Base.Mathematic.Optimization
{
    using System;

    /// <summary>
    ///   Optimization progress event arguments.
    /// </summary>
    public class OptimizationProgressEventArgs : EventArgs
    {
        /// <summary>
        ///   Gets the current iteration of the method.
        /// </summary>
        public int Iteration { get; private set; }

        /// <summary>
        ///   Gets the number of function evaluations performed.
        /// </summary>
        public int Evaluations { get; private set; }

        /// <summary>
        ///   Gets the current gradient of the function being optimized.
        /// </summary>
        public double[] Gradient { get; private set; }

        /// <summary>
        ///   Gets the norm of the current <see cref="Gradient"/>.
        /// </summary>
        public double Norm { get; private set; }

        /// <summary>
        ///   Gets the current solution parameters for the problem.
        /// </summary>
        public double[] Solution { get; private set; }

        /// <summary>
        ///   Gets the value of the function to be optimized
        ///   at the current proposed <see cref="Solution"/>.
        /// </summary>
        public double Value { get; private set; }

        /// <summary>
        ///   Gets the current step size.
        /// </summary>
        public double Step { get; private set; }


        /// <summary>
        ///   Gets or sets a value indicating whether the
        ///   optimization process is about to terminate.
        /// </summary>
        /// <value><c>true</c> if finished; otherwise, <c>false</c>.</value>
        public bool Finished { get; private set; }

        /// <summary>
        ///   Initializes a new instance of the <see cref="OptimizationProgressEventArgs"/> class.
        /// </summary>
        /// <param name="iteration">The current iteration of the optimization method.</param>
        /// <param name="evaluations">The number of function evaluations performed.</param>
        /// <param name="gradient">The current gradient of the function.</param>
        /// <param name="norm">The norm of the current gradient.</param>
        /// <param name="solution">The current solution parameters.</param>
        /// <param name="value">The value of the function evaluated at the current solution.</param>
        /// <param name="stp">The current step size.</param>
        /// <param name="finished"><c>True</c> if the method is about to terminate, <c>false</c> otherwise.</param>
        public OptimizationProgressEventArgs(
            int iteration, int evaluations,
            double[] gradient, double norm,
            double[] solution, double value,
            double stp, bool finished)
        {
            this.Gradient = (double[])gradient.Clone();
            this.Solution = (double[])solution.Clone();
            this.Value = value;
            this.Norm = norm;

            this.Iteration = iteration;
            this.Evaluations = evaluations;
            
            this.Finished = finished;
            this.Step = stp;
        }
    }
}
