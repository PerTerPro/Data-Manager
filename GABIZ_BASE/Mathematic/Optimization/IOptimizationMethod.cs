// GABIZ.Base Math Library
// The GABIZ.Base.NET Framework
// http://GABIZ.Base-net.origo.ethz.ch
//
// Copyright © César Souza, 2009-2011
// cesarsouza at gmail.com
// http://www.crsouza.com
//

namespace GABIZ.Base.Mathematic.Optimization
{
    /// <summary>
    ///   Common interface for function optimization methods.
    /// </summary>
    /// 
    /// <seealso cref="LbfgsOptimization"/>
    /// 
    public interface IOptimizationMethod
    {

        /// <summary>
        ///   Optimizes the defined function. 
        /// </summary>
        /// 
        /// <param name="values">The initial guess values for the parameters.</param>
        /// 
        double Optimize(double[] values);

        /// <summary>
        ///   Gets the solution found, the values of the parameters which
        ///   optimizes the function.
        /// </summary>
        double[] Solution { get; }

    }
}
