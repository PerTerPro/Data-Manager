﻿// GABIZ.Base Statistics Library
// The GABIZ.Base.NET Framework
// http://GABIZ.Base-net.origo.ethz.ch
//
// Copyright © César Souza, 2009-2011
// cesarsouza at gmail.com
// http://www.crsouza.com
//

namespace GABIZ.Base.Statistics.Kernels
{
    using System;

    /// <summary>
    ///   Generalized T-Student Kernel.
    /// </summary>
    /// <remarks>
    ///   The Generalized T-Student Kernel is a Mercel Kernel and thus forms
    ///   a positive semi-definite Kernel matrix (Boughorbel, 2004). It has
    ///   a similar form to the <see cref="Multiquadric">Inverse Multiquadric Kernel.</see>
    /// </remarks>
    /// 
    [Serializable]
    public sealed class TStudent : IKernel
    {

        private int degree;

        /// <summary>
        ///   Gets or sets the degree of this kernel.
        /// </summary>
        public int Degree
        {
            get { return degree; }
            set { degree = value; }
        }

        /// <summary>
        ///   Constructs a new Generalized T-Student Kernel.
        /// </summary>
        /// <param name="degree">The kernel's degree.</param>
        public TStudent(int degree)
        {
            this.degree = degree;
        }

        /// <summary>
        ///   Generalized T-Student Kernel function.
        /// </summary>
        /// <param name="x">Vector <c>x</c> in input space.</param>
        /// <param name="y">Vector <c>y</c> in input space.</param>
        /// <returns>Dot product in feature (kernel) space.</returns>
        public double Function(double[] x, double[] y)
        {
            double norm = 0.0;
            for (int i = 0; i < x.Length; i++)
            {
                double d = x[i] - y[i];
                norm += d * d;
            }
            norm = System.Math.Sqrt(norm);

            return 1.0 / (1.0 + System.Math.Pow(norm, degree));
        }

    }
}
