namespace Humidifier.Batch
{
    using global::System.Collections.Generic;
    using JobQueueTypes;

    public class JobQueue : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfBatchJobQueueTypesComputeEnvironmentOrderComputeEnvironmentOrder, IHavePriority_Integer, IHaveState, IHaveJobQueueType, IHaveListOfBatchJobQueueTypesServiceEnvironmentOrderServiceEnvironmentOrder, IHaveSchedulingPolicyArn, IHaveListOfBatchJobQueueTypesJobStateTimeLimitActionJobStateTimeLimitActions, IHaveJobQueueName, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string JobQueueArn =  "JobQueueArn" ;
        }

        public override string AWSTypeName { get => AWS.Batch.JobQueue; }
        /// <summary>
        /// ComputeEnvironmentOrder
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html#cfn-batch-jobqueue-computeenvironmentorder
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ComputeEnvironmentOrder
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder>, IReadOnlyList<Union<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder, BaseFunction>>, BaseFunction>? ComputeEnvironmentOrder { get; set; }

        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html#cfn-batch-jobqueue-priority
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Priority { get; set; }
        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html#cfn-batch-jobqueue-state
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? State { get; set; }
        /// <summary>
        /// JobQueueType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html#cfn-batch-jobqueue-jobqueuetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobQueueType { get; set; }
        /// <summary>
        /// ServiceEnvironmentOrder
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html#cfn-batch-jobqueue-serviceenvironmentorder
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ServiceEnvironmentOrder
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Batch.JobQueueTypes.ServiceEnvironmentOrder>, IReadOnlyList<Union<Humidifier.Batch.JobQueueTypes.ServiceEnvironmentOrder, BaseFunction>>, BaseFunction>? ServiceEnvironmentOrder { get; set; }
        /// <summary>
        /// SchedulingPolicyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html#cfn-batch-jobqueue-schedulingpolicyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SchedulingPolicyArn { get; set; }
        /// <summary>
        /// JobStateTimeLimitActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html#cfn-batch-jobqueue-jobstatetimelimitactions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: JobStateTimeLimitAction
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction>, IReadOnlyList<Union<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction, BaseFunction>>, BaseFunction>? JobStateTimeLimitActions { get; set; }
        public Union<string, BaseFunction>? JobQueueName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html#cfn-batch-jobqueue-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace JobQueueTypes
    {
        public class ComputeEnvironmentOrder : Humidifier.Base.BaseSubResource, IHaveComputeEnvironment, IHaveOrder_Integer
        {
            /// <summary>
            /// ComputeEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobqueue-computeenvironmentorder.html#cfn-batch-jobqueue-computeenvironmentorder-computeenvironment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComputeEnvironment { get; set; }
            /// <summary>
            /// Order
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobqueue-computeenvironmentorder.html#cfn-batch-jobqueue-computeenvironmentorder-order
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Order { get; set; }
        }

        public class JobStateTimeLimitAction : Humidifier.Base.BaseSubResource, IHaveAction, IHaveMaxTimeSeconds_Integer, IHaveState, IHaveReason
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobqueue-jobstatetimelimitaction.html#cfn-batch-jobqueue-jobstatetimelimitaction-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// MaxTimeSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobqueue-jobstatetimelimitaction.html#cfn-batch-jobqueue-jobstatetimelimitaction-maxtimeseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxTimeSeconds { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobqueue-jobstatetimelimitaction.html#cfn-batch-jobqueue-jobstatetimelimitaction-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// Reason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobqueue-jobstatetimelimitaction.html#cfn-batch-jobqueue-jobstatetimelimitaction-reason
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Reason { get; set; }
        }

        public class ServiceEnvironmentOrder : Humidifier.Base.BaseSubResource, IHaveOrder_Integer, IHaveServiceEnvironment
        {
            /// <summary>
            /// Order
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobqueue-serviceenvironmentorder.html#cfn-batch-jobqueue-serviceenvironmentorder-order
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Order { get; set; }
            /// <summary>
            /// ServiceEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobqueue-serviceenvironmentorder.html#cfn-batch-jobqueue-serviceenvironmentorder-serviceenvironment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceEnvironment { get; set; }
        }
    }
}