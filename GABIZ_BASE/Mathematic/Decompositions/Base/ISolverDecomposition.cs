﻿// GABIZ.Base Math Library
// The GABIZ.Base.NET Framework
// http://GABIZ.Base-net.origo.ethz.ch
//
// Copyright © César Souza, 2009-2011
// cesarsouza at gmail.com
// http://www.crsouza.com
//

namespace GABIZ.Base.Mathematic.Decompositions
{
    /// <summary>
    ///   Common interface for matrix decompositions which
    ///   can be used to solve linear systems of equations.
    /// </summary>
    /// 
    public interface ISolverDecomposition
    {
        /// <summary>Solves a set of equation systems of type <c>A * X = B</c>.</summary>
        double[,] Solve(double[,] value);

        /// <summary>Solves a set of equation systems of type <c>A * X = B</c>.</summary>
        double[] Solve(double[] value);
    }
}
