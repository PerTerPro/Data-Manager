// GABIZ.Base Statistics Library
// The GABIZ.Base.NET Framework
// http://GABIZ.Base-net.origo.ethz.ch
//
// Copyright © César Souza, 2009-2011
// cesarsouza at gmail.com
// http://www.crsouza.com
//

namespace GABIZ.Base.Statistics.Models.Regression.Linear
{
    using System;

    /// <summary>
    ///   Common interface for Linear Regression Models.
    /// </summary>
    /// 
    public interface ILinearRegression
    {
        /// <summary>
        ///   Computes the model output for a given input.
        /// </summary>
        double[] Compute(double[] inputs);
    }
}
