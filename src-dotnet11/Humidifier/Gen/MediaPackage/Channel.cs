namespace Humidifier.MediaPackage
{
    using global::System.Collections.Generic;
    using ChannelTypes;

    public class Channel : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveMediaPackageChannelTypesLogConfigurationIngressAccessLogs, IHaveMediaPackageChannelTypesHlsIngestHlsIngest, IHaveId, IHaveMediaPackageChannelTypesLogConfigurationEgressAccessLogs
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaPackage.Channel; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-channel.html#cfn-mediapackage-channel-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// IngressAccessLogs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-channel.html#cfn-mediapackage-channel-ingressaccesslogs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogConfiguration
        /// </summary>
        public Union<Humidifier.MediaPackage.ChannelTypes.LogConfiguration, BaseFunction>? IngressAccessLogs { get; set; }
        /// <summary>
        /// HlsIngest
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-channel.html#cfn-mediapackage-channel-hlsingest
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HlsIngest
        /// </summary>
        public Union<Humidifier.MediaPackage.ChannelTypes.HlsIngest, BaseFunction>? HlsIngest { get; set; }

        /// <summary>
        /// Id
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-channel.html#cfn-mediapackage-channel-id
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Id { get; set; }
        /// <summary>
        /// EgressAccessLogs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-channel.html#cfn-mediapackage-channel-egressaccesslogs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogConfiguration
        /// </summary>
        public Union<Humidifier.MediaPackage.ChannelTypes.LogConfiguration, BaseFunction>? EgressAccessLogs { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-channel.html#cfn-mediapackage-channel-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ChannelTypes
    {
        public class HlsIngest : Humidifier.Base.BaseSubResource, IHaveListOfMediaPackageChannelTypesIngestEndpointingestEndpoints
        {
            /// <summary>
            /// ingestEndpoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-channel-hlsingest.html#cfn-mediapackage-channel-hlsingest-ingestendpoints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IngestEndpoint
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaPackage.ChannelTypes.IngestEndpoint>, IReadOnlyList<Union<Humidifier.MediaPackage.ChannelTypes.IngestEndpoint, BaseFunction>>, BaseFunction>? ingestEndpoints { get; set; }
        }

        public class IngestEndpoint : Humidifier.Base.BaseSubResource, IHaveUsername, IHaveId, IHaveUrl, IHavePassword
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-channel-ingestendpoint.html#cfn-mediapackage-channel-ingestendpoint-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-channel-ingestendpoint.html#cfn-mediapackage-channel-ingestendpoint-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-channel-ingestendpoint.html#cfn-mediapackage-channel-ingestendpoint-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-channel-ingestendpoint.html#cfn-mediapackage-channel-ingestendpoint-password
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveLogGroupName
        {
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-channel-logconfiguration.html#cfn-mediapackage-channel-logconfiguration-loggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupName { get; set; }
        }
    }
}