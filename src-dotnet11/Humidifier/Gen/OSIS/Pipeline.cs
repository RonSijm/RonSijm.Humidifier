namespace Humidifier.OSIS
{
    using global::System.Collections.Generic;
    using PipelineTypes;

    public class Pipeline : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePipelineConfigurationBody, IHaveOSISPipelineTypesBufferOptionsBufferOptions, IHavePipelineRoleArn, IHaveMinUnits_Integer, IHavePipelineName, IHaveOSISPipelineTypesVpcOptionsVpcOptions, IHaveMaxUnits_Integer, IHaveOSISPipelineTypesLogPublishingOptionsLogPublishingOptions, IHaveOSISPipelineTypesResourcePolicyResourcePolicy, IHaveOSISPipelineTypesEncryptionAtRestOptionsEncryptionAtRestOptions
    {
        public class Attributes
        {
            public static string PipelineArn =  "PipelineArn" ;
            public static string VpcEndpoints =  "VpcEndpoints" ;
            public static string IngestEndpointUrls =  "IngestEndpointUrls" ;
            public static string VpcEndpointService =  "VpcEndpointService" ;
        }

        public override string AWSTypeName { get => AWS.OSIS.Pipeline; }

        /// <summary>
        /// PipelineConfigurationBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipeline.html#cfn-osis-pipeline-pipelineconfigurationbody
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PipelineConfigurationBody { get; set; }
        /// <summary>
        /// BufferOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipeline.html#cfn-osis-pipeline-bufferoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BufferOptions
        /// </summary>
        public Union<Humidifier.OSIS.PipelineTypes.BufferOptions, BaseFunction>? BufferOptions { get; set; }
        /// <summary>
        /// PipelineRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipeline.html#cfn-osis-pipeline-pipelinerolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PipelineRoleArn { get; set; }

        /// <summary>
        /// MinUnits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipeline.html#cfn-osis-pipeline-minunits
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? MinUnits { get; set; }
        public Union<string, BaseFunction>? PipelineName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// VpcOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipeline.html#cfn-osis-pipeline-vpcoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcOptions
        /// </summary>
        public Union<Humidifier.OSIS.PipelineTypes.VpcOptions, BaseFunction>? VpcOptions { get; set; }

        /// <summary>
        /// MaxUnits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipeline.html#cfn-osis-pipeline-maxunits
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? MaxUnits { get; set; }
        /// <summary>
        /// LogPublishingOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipeline.html#cfn-osis-pipeline-logpublishingoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogPublishingOptions
        /// </summary>
        public Union<Humidifier.OSIS.PipelineTypes.LogPublishingOptions, BaseFunction>? LogPublishingOptions { get; set; }
        /// <summary>
        /// ResourcePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipeline.html#cfn-osis-pipeline-resourcepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ResourcePolicy
        /// </summary>
        public Union<Humidifier.OSIS.PipelineTypes.ResourcePolicy, BaseFunction>? ResourcePolicy { get; set; }
        /// <summary>
        /// EncryptionAtRestOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipeline.html#cfn-osis-pipeline-encryptionatrestoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncryptionAtRestOptions
        /// </summary>
        public Union<Humidifier.OSIS.PipelineTypes.EncryptionAtRestOptions, BaseFunction>? EncryptionAtRestOptions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipeline.html#cfn-osis-pipeline-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PipelineTypes
    {
        public class BufferOptions : Humidifier.Base.BaseSubResource, IHavePersistentBufferEnabled_Boolean
        {
            /// <summary>
            /// PersistentBufferEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-bufferoptions.html#cfn-osis-pipeline-bufferoptions-persistentbufferenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PersistentBufferEnabled { get; set; }
        }

        public class CloudWatchLogDestination : Humidifier.Base.BaseSubResource, IHaveLogGroup
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-cloudwatchlogdestination.html#cfn-osis-pipeline-cloudwatchlogdestination-loggroup
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroup { get; set; }
        }

        public class EncryptionAtRestOptions : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-encryptionatrestoptions.html#cfn-osis-pipeline-encryptionatrestoptions-kmskeyarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        }

        public class LogPublishingOptions : Humidifier.Base.BaseSubResource, IHaveOSISPipelineTypesCloudWatchLogDestinationCloudWatchLogDestination, IHaveIsLoggingEnabled_Boolean
        {
            /// <summary>
            /// CloudWatchLogDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-logpublishingoptions.html#cfn-osis-pipeline-logpublishingoptions-cloudwatchlogdestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogDestination
            /// </summary>
            public Union<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination, BaseFunction>? CloudWatchLogDestination { get; set; }
            /// <summary>
            /// IsLoggingEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-logpublishingoptions.html#cfn-osis-pipeline-logpublishingoptions-isloggingenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsLoggingEnabled { get; set; }
        }

        public class ResourcePolicy : Humidifier.Base.BaseSubResource, IHavePolicy_Json
        {
            /// <summary>
            /// Policy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-resourcepolicy.html#cfn-osis-pipeline-resourcepolicy-policy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Policy { get; set; }
        }

        public class VpcAttachmentOptions : Humidifier.Base.BaseSubResource, IHaveAttachToVpc_Boolean, IHaveCidrBlock
        {
            /// <summary>
            /// AttachToVpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcattachmentoptions.html#cfn-osis-pipeline-vpcattachmentoptions-attachtovpc
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AttachToVpc { get; set; }
            /// <summary>
            /// CidrBlock
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcattachmentoptions.html#cfn-osis-pipeline-vpcattachmentoptions-cidrblock
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CidrBlock { get; set; }
        }

        public class VpcEndpoint : Humidifier.Base.BaseSubResource, IHaveVpcId, IHaveOSISPipelineTypesVpcOptionsVpcOptions, IHaveVpcEndpointId
        {
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcendpoint.html#cfn-osis-pipeline-vpcendpoint-vpcid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
            /// <summary>
            /// VpcOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcendpoint.html#cfn-osis-pipeline-vpcendpoint-vpcoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcOptions
            /// </summary>
            public Union<Humidifier.OSIS.PipelineTypes.VpcOptions, BaseFunction>? VpcOptions { get; set; }
            /// <summary>
            /// VpcEndpointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcendpoint.html#cfn-osis-pipeline-vpcendpoint-vpcendpointid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcEndpointId { get; set; }
        }

        public class VpcOptions : Humidifier.Base.BaseSubResource, IHaveOSISPipelineTypesVpcAttachmentOptionsVpcAttachmentOptions, IHaveVpcEndpointManagement, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// VpcAttachmentOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcoptions.html#cfn-osis-pipeline-vpcoptions-vpcattachmentoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcAttachmentOptions
            /// </summary>
            public Union<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions, BaseFunction>? VpcAttachmentOptions { get; set; }
            /// <summary>
            /// VpcEndpointManagement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcoptions.html#cfn-osis-pipeline-vpcoptions-vpcendpointmanagement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcEndpointManagement { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcoptions.html#cfn-osis-pipeline-vpcoptions-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcoptions.html#cfn-osis-pipeline-vpcoptions-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }
    }
}