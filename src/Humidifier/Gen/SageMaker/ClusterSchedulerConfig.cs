namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using ClusterSchedulerConfigTypes;

    public class ClusterSchedulerConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveClusterArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ClusterSchedulerConfigVersion =  "ClusterSchedulerConfigVersion" ;
            public static string CreationTime =  "CreationTime" ;
            public static string ClusterSchedulerConfigArn =  "ClusterSchedulerConfigArn" ;
            public static string ClusterSchedulerConfigId =  "ClusterSchedulerConfigId" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.ClusterSchedulerConfig; }

        /// <summary>
        /// ClusterArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-clusterschedulerconfig.html#cfn-sagemaker-clusterschedulerconfig-clusterarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ClusterArn { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-clusterschedulerconfig.html#cfn-sagemaker-clusterschedulerconfig-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// SchedulerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-clusterschedulerconfig.html#cfn-sagemaker-clusterschedulerconfig-schedulerconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: SchedulerConfig
        /// </summary>
        [Required]
        public Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig SchedulerConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-clusterschedulerconfig.html#cfn-sagemaker-clusterschedulerconfig-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ClusterSchedulerConfigTypes
    {
        public class PriorityClass : Humidifier.Base.BaseSubResource, IHaveName, IHaveWeight
        {
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-clusterschedulerconfig-priorityclass.html#cfn-sagemaker-clusterschedulerconfig-priorityclass-weight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Weight { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-clusterschedulerconfig-priorityclass.html#cfn-sagemaker-clusterschedulerconfig-priorityclass-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SchedulerConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PriorityClasses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-clusterschedulerconfig-schedulerconfig.html#cfn-sagemaker-clusterschedulerconfig-schedulerconfig-priorityclasses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PriorityClass
            /// </summary>
            public List<Humidifier.SageMaker.ClusterSchedulerConfigTypes.PriorityClass> PriorityClasses { get; set; }
            /// <summary>
            /// FairShare
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-clusterschedulerconfig-schedulerconfig.html#cfn-sagemaker-clusterschedulerconfig-schedulerconfig-fairshare
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FairShare { get; set; }
            /// <summary>
            /// IdleResourceSharing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-clusterschedulerconfig-schedulerconfig.html#cfn-sagemaker-clusterschedulerconfig-schedulerconfig-idleresourcesharing
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdleResourceSharing { get; set; }
        }
    }
}