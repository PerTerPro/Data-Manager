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
    ///   Sparse Laplacian Kernel.
    /// </summary>
    /// 
    [Serializable]
    public sealed class SparseLaplacian : IKernel
    {
        private double sigma;

        /// <summary>
        ///   Constructs a new Sparse Laplacian Kernel
        /// </summary>
        /// <param name="sigma">The sigma slope value.</param>
        public SparseLaplacian(double sigma)
        {
            this.sigma = sigma;
        }

        /// <summary>
        ///   Gets or sets the sigma value for the kernel.
        /// </summary>
        public double Sigma
        {
            get { return sigma; }
            set { sigma = value; }
        }


        /// <summary>
        ///   Laplacian Kernel function.
        /// </summary>
        /// <param name="x">Vector <c>x</c> in input space.</param>
        /// <param name="y">Vector <c>y</c> in input space.</param>
        /// <returns>Dot product in feature (kernel) space.</returns>
        public double Function(double[] x, double[] y)
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

            return System.Math.Exp(-System.Math.Sqrt(norm) / Sigma);
        }

        /// <summary>
        ///   Computes the distance in input space
        ///   between two points given in feature space.
        /// </summary>
        /// <param name="x">Vector <c>x</c> in feature (kernel) space.</param>
        /// <param name="y">Vector <c>y</c> in feature (kernel) space.</param>
        /// <returns>Distance between <c>x</c> and <c>y</c> in input space.</returns>
        public double Distance(double[] x, double[] y)
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

            return Sigma * System.Math.Log(1.0 - 0.5 * System.Math.Sqrt(norm));
        }

    }
}
