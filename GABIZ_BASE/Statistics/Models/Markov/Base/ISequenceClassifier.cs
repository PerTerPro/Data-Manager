﻿// GABIZ.Base Statistics Library
// The GABIZ.Base.NET Framework
// http://GABIZ.Base-net.origo.ethz.ch
//
// Copyright © César Souza, 2009-2011
// cesarsouza at gmail.com
// http://www.crsouza.com
//

namespace GABIZ.Base.Statistics.Models.Markov
{
    using System;

    /// <summary>
    ///   Common interface for sequence classifiers using <see cref="IHiddenMarkovModel">
    ///   hidden Markov models</see>.
    /// </summary>
    public interface ISequenceClassifier
    {
        /// <summary>
        ///   Computes the most likely class for a given sequence.
        /// </summary>
        int Compute(Array sequence, out double[] likelihoods);

        /// <summary>
        ///   Gets the number of classes which can be recognized by this classifier.
        /// </summary>
        int Classes { get; }
    }
}
