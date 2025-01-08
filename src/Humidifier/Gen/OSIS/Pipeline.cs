namespace Humidifier.OSIS
{
    using System.Collections.Generic;
    using PipelineTypes;

    public class Pipeline : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePipelineName, IHaveOSISPipelineTypesVpcOptionsVpcOptions
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
        public dynamic PipelineConfigurationBody { get; set; }
        /// <summary>
        /// BufferOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipeline.html#cfn-osis-pipeline-bufferoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BufferOptions
        /// </summary>
        public Humidifier.OSIS.PipelineTypes.BufferOptions BufferOptions { get; set; }

        /// <summary>
        /// MinUnits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipeline.html#cfn-osis-pipeline-minunits
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic MinUnits { get; set; }
        public dynamic PipelineName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// VpcOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipeline.html#cfn-osis-pipeline-vpcoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcOptions
        /// </summary>
        public Humidifier.OSIS.PipelineTypes.VpcOptions VpcOptions { get; set; }

        /// <summary>
        /// MaxUnits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipeline.html#cfn-osis-pipeline-maxunits
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic MaxUnits { get; set; }
        /// <summary>
        /// LogPublishingOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipeline.html#cfn-osis-pipeline-logpublishingoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogPublishingOptions
        /// </summary>
        public Humidifier.OSIS.PipelineTypes.LogPublishingOptions LogPublishingOptions { get; set; }
        /// <summary>
        /// EncryptionAtRestOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipeline.html#cfn-osis-pipeline-encryptionatrestoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncryptionAtRestOptions
        /// </summary>
        public Humidifier.OSIS.PipelineTypes.EncryptionAtRestOptions EncryptionAtRestOptions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipeline.html#cfn-osis-pipeline-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace PipelineTypes
    {
        public class BufferOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PersistentBufferEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-bufferoptions.html#cfn-osis-pipeline-bufferoptions-persistentbufferenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic PersistentBufferEnabled { get; set; }
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
            public dynamic LogGroup { get; set; }
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
            public dynamic KmsKeyArn { get; set; }
        }

        public class LogPublishingOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CloudWatchLogDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-logpublishingoptions.html#cfn-osis-pipeline-logpublishingoptions-cloudwatchlogdestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogDestination
            /// </summary>
            public Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination CloudWatchLogDestination { get; set; }
            /// <summary>
            /// IsLoggingEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-logpublishingoptions.html#cfn-osis-pipeline-logpublishingoptions-isloggingenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsLoggingEnabled { get; set; }
        }

        public class VpcAttachmentOptions : Humidifier.Base.BaseSubResource, IHaveCidrBlock
        {
            /// <summary>
            /// AttachToVpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcattachmentoptions.html#cfn-osis-pipeline-vpcattachmentoptions-attachtovpc
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AttachToVpc { get; set; }
            /// <summary>
            /// CidrBlock
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcattachmentoptions.html#cfn-osis-pipeline-vpcattachmentoptions-cidrblock
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CidrBlock { get; set; }
        }

        public class VpcEndpoint : Humidifier.Base.BaseSubResource, IHaveVpcId, IHaveVpcEndpointId, IHaveOSISPipelineTypesVpcOptionsVpcOptions
        {
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcendpoint.html#cfn-osis-pipeline-vpcendpoint-vpcid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcId { get; set; }
            /// <summary>
            /// VpcOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcendpoint.html#cfn-osis-pipeline-vpcendpoint-vpcoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcOptions
            /// </summary>
            public Humidifier.OSIS.PipelineTypes.VpcOptions VpcOptions { get; set; }
            /// <summary>
            /// VpcEndpointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcendpoint.html#cfn-osis-pipeline-vpcendpoint-vpcendpointid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcEndpointId { get; set; }
        }

        public class VpcOptions : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds
        {
            /// <summary>
            /// VpcAttachmentOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcoptions.html#cfn-osis-pipeline-vpcoptions-vpcattachmentoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcAttachmentOptions
            /// </summary>
            public Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions VpcAttachmentOptions { get; set; }
            /// <summary>
            /// VpcEndpointManagement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcoptions.html#cfn-osis-pipeline-vpcoptions-vpcendpointmanagement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcEndpointManagement { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcoptions.html#cfn-osis-pipeline-vpcoptions-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipeline-vpcoptions.html#cfn-osis-pipeline-vpcoptions-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
        }
    }
}