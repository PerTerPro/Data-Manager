// GABIZ.Base Statistics Library
// The GABIZ.Base.NET Framework
// http://GABIZ.Base-net.origo.ethz.ch
//
// Copyright © César Souza, 2009-2011
// cesarsouza at gmail.com
// http://www.crsouza.com
//

namespace GABIZ.Base.Statistics.Models.Fields.Learning
{

    /// <summary>
    ///   Common interface for Conditional Random Fields learning algorithms.
    /// </summary>
    /// 
    public interface IConditionalRandomFieldLearning
    {
        /// <summary>
        ///   Runs the learning algorithm with the specified input
        ///   training observations and corresponding output labels.
        /// </summary>
        /// <param name="observations">The training observations.</param>
        /// <param name="labels">The observation's labels.</param>
        double Run(int[][] observations, int[][] labels);
    }
}
