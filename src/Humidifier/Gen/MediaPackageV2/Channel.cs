namespace Humidifier.MediaPackageV2
{
    using global::System.Collections.Generic;
    using ChannelTypes;

    public class Channel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveChannelName, IHaveChannelGroupName, IHaveInputType
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string IngestEndpoints =  "IngestEndpoints" ;
            public static string AttachedMultiviewChannels =  "AttachedMultiviewChannels" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string IngestEndpointUrls =  "IngestEndpointUrls" ;
        }

        public override string AWSTypeName { get => AWS.MediaPackageV2.Channel; }
        /// <summary>
        /// InputSwitchConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-channel.html#cfn-mediapackagev2-channel-inputswitchconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InputSwitchConfiguration
        /// </summary>
        public Humidifier.MediaPackageV2.ChannelTypes.InputSwitchConfiguration InputSwitchConfiguration { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-channel.html#cfn-mediapackagev2-channel-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        public dynamic ChannelName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// InputType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-channel.html#cfn-mediapackagev2-channel-inputtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InputType { get; set; }
        /// <summary>
        /// MultiviewConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-channel.html#cfn-mediapackagev2-channel-multiviewconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MultiviewConfiguration
        /// </summary>
        public Humidifier.MediaPackageV2.ChannelTypes.MultiviewConfiguration MultiviewConfiguration { get; set; }
        /// <summary>
        /// OutputHeaderConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-channel.html#cfn-mediapackagev2-channel-outputheaderconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OutputHeaderConfiguration
        /// </summary>
        public Humidifier.MediaPackageV2.ChannelTypes.OutputHeaderConfiguration OutputHeaderConfiguration { get; set; }
        /// <summary>
        /// OutputLockingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-channel.html#cfn-mediapackagev2-channel-outputlockingmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OutputLockingMode { get; set; }

        /// <summary>
        /// ChannelGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-channel.html#cfn-mediapackagev2-channel-channelgroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ChannelGroupName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-channel.html#cfn-mediapackagev2-channel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ChannelTypes
    {
        public class IngestEndpoint : Humidifier.Base.BaseSubResource, IHaveId, IHaveUrl
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-channel-ingestendpoint.html#cfn-mediapackagev2-channel-ingestendpoint-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-channel-ingestendpoint.html#cfn-mediapackagev2-channel-ingestendpoint-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }

        public class InputSwitchConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PreferredInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-channel-inputswitchconfiguration.html#cfn-mediapackagev2-channel-inputswitchconfiguration-preferredinput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PreferredInput { get; set; }
            /// <summary>
            /// MQCSInputSwitching
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-channel-inputswitchconfiguration.html#cfn-mediapackagev2-channel-inputswitchconfiguration-mqcsinputswitching
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic MQCSInputSwitching { get; set; }
        }

        public class MultiviewConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AvailableSources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-channel-multiviewconfiguration.html#cfn-mediapackagev2-channel-multiviewconfiguration-availablesources
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AvailableSources { get; set; }
            /// <summary>
            /// AvailableLayouts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-channel-multiviewconfiguration.html#cfn-mediapackagev2-channel-multiviewconfiguration-availablelayouts
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AvailableLayouts { get; set; }
        }

        public class OutputHeaderConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PublishMQCS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-channel-outputheaderconfiguration.html#cfn-mediapackagev2-channel-outputheaderconfiguration-publishmqcs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic PublishMQCS { get; set; }
        }
    }
}