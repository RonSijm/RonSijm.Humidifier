namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using AIBenchmarkJobTypes;

    public class AIBenchmarkJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSageMakerAIBenchmarkJobTypesAIBenchmarkOutputConfigOutputConfig, IHaveAIBenchmarkJobName, IHaveAIWorkloadConfigIdentifier, IHaveSageMakerAIBenchmarkJobTypesAIBenchmarkNetworkConfigNetworkConfig, IHaveRoleArn, IHaveSageMakerAIBenchmarkJobTypesAIBenchmarkTargetBenchmarkTarget
    {
        public class Attributes
        {
            public static string EndTime =  "EndTime" ;
            public static string AIBenchmarkJobStatus =  "AIBenchmarkJobStatus" ;
            public static string CreationTime =  "CreationTime" ;
            public static string AIBenchmarkJobArn =  "AIBenchmarkJobArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.AIBenchmarkJob; }

        /// <summary>
        /// OutputConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-aibenchmarkjob.html#cfn-sagemaker-aibenchmarkjob-outputconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: AIBenchmarkOutputConfig
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkOutputConfig, BaseFunction>? OutputConfig { get; set; }
        public Union<string, BaseFunction>? AIBenchmarkJobName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// AIWorkloadConfigIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-aibenchmarkjob.html#cfn-sagemaker-aibenchmarkjob-aiworkloadconfigidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AIWorkloadConfigIdentifier { get; set; }
        /// <summary>
        /// NetworkConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-aibenchmarkjob.html#cfn-sagemaker-aibenchmarkjob-networkconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AIBenchmarkNetworkConfig
        /// </summary>
        public Union<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkNetworkConfig, BaseFunction>? NetworkConfig { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-aibenchmarkjob.html#cfn-sagemaker-aibenchmarkjob-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-aibenchmarkjob.html#cfn-sagemaker-aibenchmarkjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// BenchmarkTarget
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-aibenchmarkjob.html#cfn-sagemaker-aibenchmarkjob-benchmarktarget
        /// Required: True
        /// UpdateType: Immutable
        /// Type: AIBenchmarkTarget
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkTarget, BaseFunction>? BenchmarkTarget { get; set; }
    }

    namespace AIBenchmarkJobTypes
    {
        public class AIBenchmarkEndpoint : Humidifier.Base.BaseSubResource, IHaveIdentifier, IHaveTargetContainerHostname, IHaveListOfSageMakerAIBenchmarkJobTypesAIBenchmarkInferenceComponentInferenceComponents
        {
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aibenchmarkjob-aibenchmarkendpoint.html#cfn-sagemaker-aibenchmarkjob-aibenchmarkendpoint-identifier
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Identifier { get; set; }
            /// <summary>
            /// TargetContainerHostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aibenchmarkjob-aibenchmarkendpoint.html#cfn-sagemaker-aibenchmarkjob-aibenchmarkendpoint-targetcontainerhostname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetContainerHostname { get; set; }
            /// <summary>
            /// InferenceComponents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aibenchmarkjob-aibenchmarkendpoint.html#cfn-sagemaker-aibenchmarkjob-aibenchmarkendpoint-inferencecomponents
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AIBenchmarkInferenceComponent
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkInferenceComponent>, IReadOnlyList<Union<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkInferenceComponent, BaseFunction>>, BaseFunction>? InferenceComponents { get; set; }
        }

        public class AIBenchmarkInferenceComponent : Humidifier.Base.BaseSubResource, IHaveIdentifier
        {
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aibenchmarkjob-aibenchmarkinferencecomponent.html#cfn-sagemaker-aibenchmarkjob-aibenchmarkinferencecomponent-identifier
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Identifier { get; set; }
        }

        public class AIBenchmarkNetworkConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerAIBenchmarkJobTypesVpcConfigVpcConfig
        {
            /// <summary>
            /// VpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aibenchmarkjob-aibenchmarknetworkconfig.html#cfn-sagemaker-aibenchmarkjob-aibenchmarknetworkconfig-vpcconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcConfig
            /// </summary>
            public Union<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
        }

        public class AIBenchmarkOutputConfig : Humidifier.Base.BaseSubResource, IHaveS3OutputLocation
        {
            /// <summary>
            /// S3OutputLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aibenchmarkjob-aibenchmarkoutputconfig.html#cfn-sagemaker-aibenchmarkjob-aibenchmarkoutputconfig-s3outputlocation
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3OutputLocation { get; set; }
        }

        public class AIBenchmarkTarget : Humidifier.Base.BaseSubResource, IHaveSageMakerAIBenchmarkJobTypesAIBenchmarkEndpointEndpoint
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aibenchmarkjob-aibenchmarktarget.html#cfn-sagemaker-aibenchmarkjob-aibenchmarktarget-endpoint
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AIBenchmarkEndpoint
            /// </summary>
            public Union<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint, BaseFunction>? Endpoint { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnets, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aibenchmarkjob-vpcconfig.html#cfn-sagemaker-aibenchmarkjob-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aibenchmarkjob-vpcconfig.html#cfn-sagemaker-aibenchmarkjob-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}