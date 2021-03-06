﻿// GABIZ.Base Math Library
// The GABIZ.Base.NET Framework
// http://GABIZ.Base-net.origo.ethz.ch
//
// Copyright © César Souza, 2009-2011
// cesarsouza at gmail.com
// http://www.crsouza.com
//

namespace GABIZ.Base.Mathematic
{
    using System;
    using GABIZ.Base.Mathematic.Decompositions;

    /// <summary>
    ///   Static class Norm. Defines a set of extension methods defining norms measures.
    /// </summary>
    /// 
    public static class Norm
    {
        /// <summary>
        ///   Returns the maximum column sum of the given matrix.
        /// </summary>
        public static double Norm1(double[,] a)
        {
            double[] columnSums = Matrix.Sum(a, 1);
            return Matrix.Max(columnSums);
        }

        /// <summary>
        ///   Returns the maximum singular value of the given matrix.
        /// </summary>
        public static double Norm2(double[,] a)
        {
            return new SingularValueDecomposition(a, false, false).TwoNorm;
        }

        /// <summary>
        ///   Gets the square root of the sum of squares for all elements in a matrix.
        /// </summary>
        public static double Frobenius(double[,] a)
        {
            if (a == null) 
                throw new ArgumentNullException("a");

            int rows = a.GetLength(0);
            int cols = a.GetLength(1);

            double norm = 0.0;
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    double v = a[i, j];
                    norm += v * v;
                }
            }

            return System.Math.Sqrt(norm);
        }

        /// <summary>
        ///   Gets the Squared Euclidean norm for a vector.
        /// </summary>
        public static float SquareEuclidean(float[] a)
        {
            float sum = 0.0f;
            for (int i = 0; i < a.Length; i++)
                sum += a[i] * a[i];
            return sum;
        }

        /// <summary>
        ///   Gets the Squared Euclidean norm for a vector.
        /// </summary>
        public static double SquareEuclidean(double[] a)
        {
            double sum = 0.0;
            for (int i = 0; i < a.Length; i++)
                sum += a[i] * a[i];
            return sum;
        }

        /// <summary>
        ///   Gets the Euclidean norm for a vector.
        /// </summary>
        public static float Euclidean(float[] a)
        {
            return (float)Math.Sqrt(SquareEuclidean(a));
        }

        /// <summary>
        ///   Gets the Euclidean norm for a vector.
        /// </summary>
        public static double Euclidean(double[] a)
        {
            return System.Math.Sqrt(SquareEuclidean(a));
        }

        /// <summary>
        ///   Gets the Squared Euclidean norm vector for a matrix.
        /// </summary>
        public static double[] SquareEuclidean(double[,] a)
        {
            return SquareEuclidean(a, 0);
        }

        /// <summary>
        ///   Gets the Squared Euclidean norm vector for a matrix.
        /// </summary>
        public static double[] SquareEuclidean(double[,] a, int dimension)
        {
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);
            
            double[] norm;

            if (dimension == 0)
            {
                norm = new double[cols];

                for (int j = 0; j < norm.Length; j++)
                {
                    double sum = 0.0;
                    for (int i = 0; i < rows; i++)
                    {
                        double v = a[i, j];
                        sum += v * v;
                    }
                    norm[j] = sum;
                }
            }
            else
            {
                norm = new double[rows];

                for (int i = 0; i < norm.Length; i++)
                {
                    double sum = 0.0;
                    for (int j = 0; j < cols; j++)
                    {
                        double v = a[i, j];
                        sum += v * v;
                    }
                    norm[i] = sum;
                }
            }

            return norm;
        }

        /// <summary>
        ///   Gets the Euclidean norm for a matrix.
        /// </summary>
        public static double[] Euclidean(double[,] a)
        {
            return Euclidean(a, 0);
        }

        /// <summary>
        ///   Gets the Euclidean norm for a matrix.
        /// </summary>
        public static double[] Euclidean(double[,] a, int dimension)
        {
            double[] norm = Norm.SquareEuclidean(a, dimension);

            for (int i = 0; i < norm.Length; i++)
                norm[i] = System.Math.Sqrt(norm[i]);

            return norm;
        }

        /// <summary>
        ///   Gets the Squared Euclidean norm vector for a matrix.
        /// </summary>
        public static float[] SquareEuclidean(float[,] a, int dimension)
        {
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);

            float[] norm;

            if (dimension == 0)
            {
                norm = new float[cols];

                for (int j = 0; j < norm.Length; j++)
                {
                    float sum = 0.0f;
                    for (int i = 0; i < rows; i++)
                    {
                        float v = a[i, j];
                        sum += v * v;
                    }
                    norm[j] = sum;
                }
            }
            else
            {
                norm = new float[rows];

                for (int i = 0; i < norm.Length; i++)
                {
                    float sum = 0.0f;
                    for (int j = 0; j < cols; j++)
                    {
                        float v = a[i, j];
                        sum += v * v;
                    }
                    norm[i] = sum;
                }
            }

            return norm;
        }

        /// <summary>
        ///   Gets the Euclidean norm for a matrix.
        /// </summary>
        public static float[] Euclidean(float[,] a)
        {
            return Euclidean(a, 0);
        }

        /// <summary>
        ///   Gets the Euclidean norm for a matrix.
        /// </summary>
        public static float[] Euclidean(float[,] a, int dimension)
        {
            float[] norm = Norm.SquareEuclidean(a, dimension);

            for (int i = 0; i < norm.Length; i++)
                norm[i] = (float)System.Math.Sqrt(norm[i]);

            return norm;
        }

    }
}
