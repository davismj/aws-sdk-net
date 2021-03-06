/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the SubmitJob operation.
    /// Submits an AWS Batch job from a job definition. Parameters specified during <a>SubmitJob</a>
    /// override parameters defined in the job definition.
    /// </summary>
    public partial class SubmitJobRequest : AmazonBatchRequest
    {
        private ContainerOverrides _containerOverrides;
        private List<JobDependency> _dependsOn = new List<JobDependency>();
        private string _jobDefinition;
        private string _jobName;
        private string _jobQueue;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private RetryStrategy _retryStrategy;

        /// <summary>
        /// Gets and sets the property ContainerOverrides. 
        /// <para>
        /// A list of container overrides in JSON format that specify the name of a container
        /// in the specified job definition and the overrides it should receive. You can override
        /// the default command for a container (that is specified in the job definition or the
        /// Docker image) with a <code>command</code> override. You can also override existing
        /// environment variables (that are specified in the job definition or Docker image) on
        /// a container or add new environment variables to it with an <code>environment</code>
        /// override.
        /// </para>
        /// </summary>
        public ContainerOverrides ContainerOverrides
        {
            get { return this._containerOverrides; }
            set { this._containerOverrides = value; }
        }

        // Check to see if ContainerOverrides property is set
        internal bool IsSetContainerOverrides()
        {
            return this._containerOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// A list of job IDs on which this job depends. A job can depend upon a maximum of 100
        /// jobs. 
        /// </para>
        /// </summary>
        public List<JobDependency> DependsOn
        {
            get { return this._dependsOn; }
            set { this._dependsOn = value; }
        }

        // Check to see if DependsOn property is set
        internal bool IsSetDependsOn()
        {
            return this._dependsOn != null && this._dependsOn.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property JobDefinition. 
        /// <para>
        /// The job definition used by this job. This value can be either a <code>name:revision</code>
        /// or the Amazon Resource Name (ARN) for the job definition.
        /// </para>
        /// </summary>
        public string JobDefinition
        {
            get { return this._jobDefinition; }
            set { this._jobDefinition = value; }
        }

        // Check to see if JobDefinition property is set
        internal bool IsSetJobDefinition()
        {
            return this._jobDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job. A name must be 1 to 128 characters in length.
        /// </para>
        ///  
        /// <para>
        /// Pattern: ^[a-zA-Z0-9_]+$
        /// </para>
        /// </summary>
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobQueue. 
        /// <para>
        /// The job queue into which the job will be submitted. You can specify either the name
        /// or the Amazon Resource Name (ARN) of the queue. 
        /// </para>
        /// </summary>
        public string JobQueue
        {
            get { return this._jobQueue; }
            set { this._jobQueue = value; }
        }

        // Check to see if JobQueue property is set
        internal bool IsSetJobQueue()
        {
            return this._jobQueue != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Additional parameters passed to the job that replace parameter substitution placeholders
        /// that are set in the job definition. Parameters are specified as a key and value pair
        /// mapping. Parameters in a <code>SubmitJob</code> request override any corresponding
        /// parameter defaults from the job definition.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        /// The retry strategy to use for failed jobs from this <a>SubmitJob</a> operation. When
        /// a retry strategy is specified here, it overrides the retry strategy defined in the
        /// job definition.
        /// </para>
        /// </summary>
        public RetryStrategy RetryStrategy
        {
            get { return this._retryStrategy; }
            set { this._retryStrategy = value; }
        }

        // Check to see if RetryStrategy property is set
        internal bool IsSetRetryStrategy()
        {
            return this._retryStrategy != null;
        }

    }
}