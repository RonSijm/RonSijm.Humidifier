namespace Humidifier.MediaPackageV2
{
    using global::System.Collections.Generic;
    using ChannelTypes;

    public class Channel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMediaPackageV2ChannelTypesInputSwitchConfigurationInputSwitchConfiguration, IHaveDescription, IHaveChannelName, IHaveInputType, IHaveMediaPackageV2ChannelTypesMultiviewConfigurationMultiviewConfiguration, IHaveMediaPackageV2ChannelTypesOutputHeaderConfigurationOutputHeaderConfiguration, IHaveOutputLockingMode, IHaveChannelGroupName
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
        public Union<Humidifier.MediaPackageV2.ChannelTypes.InputSwitchConfiguration, BaseFunction>? InputSwitchConfiguration { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-channel.html#cfn-mediapackagev2-channel-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        public Union<string, BaseFunction>? ChannelName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// InputType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-channel.html#cfn-mediapackagev2-channel-inputtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InputType { get; set; }
        /// <summary>
        /// MultiviewConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-channel.html#cfn-mediapackagev2-channel-multiviewconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MultiviewConfiguration
        /// </summary>
        public Union<Humidifier.MediaPackageV2.ChannelTypes.MultiviewConfiguration, BaseFunction>? MultiviewConfiguration { get; set; }
        /// <summary>
        /// OutputHeaderConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-channel.html#cfn-mediapackagev2-channel-outputheaderconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OutputHeaderConfiguration
        /// </summary>
        public Union<Humidifier.MediaPackageV2.ChannelTypes.OutputHeaderConfiguration, BaseFunction>? OutputHeaderConfiguration { get; set; }
        /// <summary>
        /// OutputLockingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-channel.html#cfn-mediapackagev2-channel-outputlockingmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OutputLockingMode { get; set; }

        /// <summary>
        /// ChannelGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-channel.html#cfn-mediapackagev2-channel-channelgroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ChannelGroupName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-channel.html#cfn-mediapackagev2-channel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
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
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-channel-ingestendpoint.html#cfn-mediapackagev2-channel-ingestendpoint-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class InputSwitchConfiguration : Humidifier.Base.BaseSubResource, IHavePreferredInput_Integer, IHaveMQCSInputSwitching_Boolean
        {
            /// <summary>
            /// PreferredInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-channel-inputswitchconfiguration.html#cfn-mediapackagev2-channel-inputswitchconfiguration-preferredinput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PreferredInput { get; set; }
            /// <summary>
            /// MQCSInputSwitching
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-channel-inputswitchconfiguration.html#cfn-mediapackagev2-channel-inputswitchconfiguration-mqcsinputswitching
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MQCSInputSwitching { get; set; }
        }

        public class MultiviewConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfAvailableSources, IHaveStringListOfAvailableLayouts
        {
            /// <summary>
            /// AvailableSources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-channel-multiviewconfiguration.html#cfn-mediapackagev2-channel-multiviewconfiguration-availablesources
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AvailableSources { get; set; }
            /// <summary>
            /// AvailableLayouts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-channel-multiviewconfiguration.html#cfn-mediapackagev2-channel-multiviewconfiguration-availablelayouts
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AvailableLayouts { get; set; }
        }

        public class OutputHeaderConfiguration : Humidifier.Base.BaseSubResource, IHavePublishMQCS_Boolean
        {
            /// <summary>
            /// PublishMQCS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-channel-outputheaderconfiguration.html#cfn-mediapackagev2-channel-outputheaderconfiguration-publishmqcs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PublishMQCS { get; set; }
        }
    }
}