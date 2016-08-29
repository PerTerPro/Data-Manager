// GABIZ.Base Machine Learning Library
// The GABIZ.Base.NET Framework
// http://GABIZ.Base-net.origo.ethz.ch
//
// Copyright © Nextcom, 2009-2011
// staff@nextcom.net.vn
// http://www.crsouza.com
//

namespace GABIZ.Base.MachineLearning.VectorMachines.Learning
{
    /// <summary>
    ///   Common interface for Support Machine Vector learning algorithms.
    /// </summary>
    public interface ISupportVectorMachineLearning
    {
        /// <summary>
        ///   Runs the SMO algorithm.
        /// </summary>
        double Run();

        /// <summary>
        ///   Runs the SMO algorithm.
        /// </summary>
        /// <param name="computeError">
        ///   True to compute error after the training
        ///   process completes, false otherwise.
        /// </param>
        double Run(bool computeError);
    }
}
