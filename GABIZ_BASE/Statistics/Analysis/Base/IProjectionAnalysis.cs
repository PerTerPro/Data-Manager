// GABIZ.Base Statistics Library
// The GABIZ.Base.NET Framework
// http://GABIZ.Base-net.origo.ethz.ch
//
// Copyright © César Souza, 2009-2011
// cesarsouza at gmail.com
// http://www.crsouza.com
//

namespace GABIZ.Base.Statistics.Analysis
{

    /// <summary>
    ///   Common interface for projective statistical analysis.
    /// </summary>
    /// 
    public interface IProjectionAnalysis : IMultivariateAnalysis
    {
        /// <summary>
        ///   Projects new data into latent space.
        /// </summary>
        /// 
        double[,] Transform(double[,] data);

        /// <summary>
        ///   Projects new data into latent space with
        ///   given number of dimensions.
        /// </summary>
        /// 
        double[,] Transform(double[,] data, int dimensions);

    }
}
