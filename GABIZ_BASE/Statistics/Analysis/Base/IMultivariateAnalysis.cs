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
    ///   Common interface for multivariate statistical analysis.
    /// </summary>
    /// 
    public interface IMultivariateAnalysis : IAnalysis
    {

        /// <summary>
        ///   Source data used in the analysis.
        /// </summary>
        /// 
        double[,] Source { get; }
        
    }

}
