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
    ///   Infinite Spline Kernel function.
    /// </summary>
    /// <remarks>
    ///   The Spline kernel is given as a piece-wise cubic
    ///   polynomial, as derived in the works by Gunn (1998).
    /// </remarks>
    /// 
    [Serializable]
    public sealed class Spline : IKernel
    {

        /// <summary>
        ///   Constructs a new Spline Kernel.
        /// </summary>
        public Spline()
        {
        }

        /// <summary>
        ///   Spline Kernel Function
        /// </summary>
        /// <param name="x">Vector <c>x</c> in input space.</param>
        /// <param name="y">Vector <c>y</c> in input space.</param>
        /// <returns>Dot product in feature (kernel) space.</returns>
        public double Function(double[] x, double[] y)
        {
            double k = 1;
            for (int i = 0; i < x.Length; i++)
            {
                double min = System.Math.Min(x[i], y[i]);
                double xy = x[i] * y[i];

                // prod{1}^d 1 + xy + xy*min - (x+y)/2 min² + min³/3} 
                k *= 1.0 + xy + xy * min - ((x[i] + y[i]) / 2.0) * min * min + (min * min * min) / 3.0;
            }

            return k;
        }

    }
}
