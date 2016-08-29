// GABIZ.Base Machine Learning Library
// The GABIZ.Base.NET Framework
// http://GABIZ.Base-net.origo.ethz.ch
//
// Copyright © Nextcom, 2009-2011
// staff@nextcom.net.vn
// http://www.crsouza.com
//

namespace GABIZ.Base.MachineLearning.VectorMachines
{
    /// <summary>
    ///   Common interface for Support Vector Machines
    /// </summary>
    public interface ISupportVectorMachine
    {
        /// <summary>
        ///   Computes the given input to produce the corresponding output.
        /// </summary>
        /// <param name="inputs">An input vector.</param>
        /// <returns>The output for the given input.</returns>
        double Compute(double[] inputs);
    }

}