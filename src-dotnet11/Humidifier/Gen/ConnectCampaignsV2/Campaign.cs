namespace Humidifier.ConnectCampaignsV2
{
    using global::System.Collections.Generic;
    using CampaignTypes;

    public class Campaign : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveConnectCampaignsV2CampaignTypesCommunicationLimitsConfigCommunicationLimitsOverride, IHaveType, IHaveConnectCampaignsV2CampaignTypesChannelSubtypeConfigChannelSubtypeConfig, IHaveConnectCampaignsV2CampaignTypesEntryLimitsConfigEntryLimitsConfig, IHaveConnectCampaignFlowArn, IHaveConnectCampaignsV2CampaignTypesScheduleSchedule, IHaveConnectCampaignsV2CampaignTypesCommunicationTimeConfigCommunicationTimeConfig, IHaveConnectInstanceId, IHaveConnectCampaignsV2CampaignTypesSourceSource, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ConnectCampaignsV2.Campaign; }
        /// <summary>
        /// CommunicationLimitsOverride
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaignsv2-campaign.html#cfn-connectcampaignsv2-campaign-communicationlimitsoverride
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CommunicationLimitsConfig
        /// </summary>
        public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimitsConfig, BaseFunction>? CommunicationLimitsOverride { get; set; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaignsv2-campaign.html#cfn-connectcampaignsv2-campaign-type
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// ChannelSubtypeConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaignsv2-campaign.html#cfn-connectcampaignsv2-campaign-channelsubtypeconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ChannelSubtypeConfig
        /// </summary>
        public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.ChannelSubtypeConfig, BaseFunction>? ChannelSubtypeConfig { get; set; }
        /// <summary>
        /// EntryLimitsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaignsv2-campaign.html#cfn-connectcampaignsv2-campaign-entrylimitsconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EntryLimitsConfig
        /// </summary>
        public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.EntryLimitsConfig, BaseFunction>? EntryLimitsConfig { get; set; }
        /// <summary>
        /// ConnectCampaignFlowArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaignsv2-campaign.html#cfn-connectcampaignsv2-campaign-connectcampaignflowarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConnectCampaignFlowArn { get; set; }
        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaignsv2-campaign.html#cfn-connectcampaignsv2-campaign-schedule
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Schedule
        /// </summary>
        public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.Schedule, BaseFunction>? Schedule { get; set; }
        /// <summary>
        /// CommunicationTimeConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaignsv2-campaign.html#cfn-connectcampaignsv2-campaign-communicationtimeconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CommunicationTimeConfig
        /// </summary>
        public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationTimeConfig, BaseFunction>? CommunicationTimeConfig { get; set; }

        /// <summary>
        /// ConnectInstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaignsv2-campaign.html#cfn-connectcampaignsv2-campaign-connectinstanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConnectInstanceId { get; set; }
        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaignsv2-campaign.html#cfn-connectcampaignsv2-campaign-source
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Source
        /// </summary>
        public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.Source, BaseFunction>? Source { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaignsv2-campaign.html#cfn-connectcampaignsv2-campaign-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace CampaignTypes
    {
        public class AnswerMachineDetectionConfig : Humidifier.Base.BaseSubResource, IHaveEnableAnswerMachineDetection_Boolean, IHaveAwaitAnswerMachinePrompt_Boolean
        {
            /// <summary>
            /// EnableAnswerMachineDetection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-answermachinedetectionconfig.html#cfn-connectcampaignsv2-campaign-answermachinedetectionconfig-enableanswermachinedetection
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableAnswerMachineDetection { get; set; }
            /// <summary>
            /// AwaitAnswerMachinePrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-answermachinedetectionconfig.html#cfn-connectcampaignsv2-campaign-answermachinedetectionconfig-awaitanswermachineprompt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AwaitAnswerMachinePrompt { get; set; }
        }

        public class ChannelSubtypeConfig : Humidifier.Base.BaseSubResource, IHaveConnectCampaignsV2CampaignTypesEmailChannelSubtypeConfigEmail, IHaveConnectCampaignsV2CampaignTypesTelephonyChannelSubtypeConfigTelephony, IHaveConnectCampaignsV2CampaignTypesSmsChannelSubtypeConfigSms, IHaveConnectCampaignsV2CampaignTypesWhatsAppChannelSubtypeConfigWhatsApp
        {
            /// <summary>
            /// Email
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-channelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-channelsubtypeconfig-email
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmailChannelSubtypeConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.EmailChannelSubtypeConfig, BaseFunction>? Email { get; set; }
            /// <summary>
            /// Telephony
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-channelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-channelsubtypeconfig-telephony
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TelephonyChannelSubtypeConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyChannelSubtypeConfig, BaseFunction>? Telephony { get; set; }
            /// <summary>
            /// Sms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-channelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-channelsubtypeconfig-sms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmsChannelSubtypeConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.SmsChannelSubtypeConfig, BaseFunction>? Sms { get; set; }
            /// <summary>
            /// WhatsApp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-channelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-channelsubtypeconfig-whatsapp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WhatsAppChannelSubtypeConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.WhatsAppChannelSubtypeConfig, BaseFunction>? WhatsApp { get; set; }
        }

        public class CommunicationLimit : Humidifier.Base.BaseSubResource, IHaveFrequency_Integer, IHaveMaxCountPerRecipient_Integer, IHaveUnit
        {
            /// <summary>
            /// Frequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationlimit.html#cfn-connectcampaignsv2-campaign-communicationlimit-frequency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Frequency { get; set; }
            /// <summary>
            /// MaxCountPerRecipient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationlimit.html#cfn-connectcampaignsv2-campaign-communicationlimit-maxcountperrecipient
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCountPerRecipient { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationlimit.html#cfn-connectcampaignsv2-campaign-communicationlimit-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class CommunicationLimits : Humidifier.Base.BaseSubResource, IHaveListOfConnectCampaignsV2CampaignTypesCommunicationLimitCommunicationLimitList
        {
            /// <summary>
            /// CommunicationLimitList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationlimits.html#cfn-connectcampaignsv2-campaign-communicationlimits-communicationlimitlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CommunicationLimit
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimit>, IReadOnlyList<Union<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimit, BaseFunction>>, BaseFunction>? CommunicationLimitList { get; set; }
        }

        public class CommunicationLimitsConfig : Humidifier.Base.BaseSubResource, IHaveConnectCampaignsV2CampaignTypesCommunicationLimitsAllChannelsSubtypes, IHaveInstanceLimitsHandling
        {
            /// <summary>
            /// AllChannelsSubtypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationlimitsconfig.html#cfn-connectcampaignsv2-campaign-communicationlimitsconfig-allchannelssubtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CommunicationLimits
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits, BaseFunction>? AllChannelsSubtypes { get; set; }
            /// <summary>
            /// InstanceLimitsHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationlimitsconfig.html#cfn-connectcampaignsv2-campaign-communicationlimitsconfig-instancelimitshandling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceLimitsHandling { get; set; }
        }

        public class CommunicationTimeConfig : Humidifier.Base.BaseSubResource, IHaveConnectCampaignsV2CampaignTypesLocalTimeZoneConfigLocalTimeZoneConfig, IHaveConnectCampaignsV2CampaignTypesTimeWindowEmail, IHaveConnectCampaignsV2CampaignTypesTimeWindowTelephony, IHaveConnectCampaignsV2CampaignTypesTimeWindowSms, IHaveConnectCampaignsV2CampaignTypesTimeWindowWhatsApp
        {
            /// <summary>
            /// LocalTimeZoneConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationtimeconfig.html#cfn-connectcampaignsv2-campaign-communicationtimeconfig-localtimezoneconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LocalTimeZoneConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.LocalTimeZoneConfig, BaseFunction>? LocalTimeZoneConfig { get; set; }
            /// <summary>
            /// Email
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationtimeconfig.html#cfn-connectcampaignsv2-campaign-communicationtimeconfig-email
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeWindow
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeWindow, BaseFunction>? Email { get; set; }
            /// <summary>
            /// Telephony
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationtimeconfig.html#cfn-connectcampaignsv2-campaign-communicationtimeconfig-telephony
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeWindow
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeWindow, BaseFunction>? Telephony { get; set; }
            /// <summary>
            /// Sms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationtimeconfig.html#cfn-connectcampaignsv2-campaign-communicationtimeconfig-sms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeWindow
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeWindow, BaseFunction>? Sms { get; set; }
            /// <summary>
            /// WhatsApp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationtimeconfig.html#cfn-connectcampaignsv2-campaign-communicationtimeconfig-whatsapp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeWindow
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeWindow, BaseFunction>? WhatsApp { get; set; }
        }

        public class DailyHour : Humidifier.Base.BaseSubResource, IHaveListOfConnectCampaignsV2CampaignTypesTimeRangeValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-dailyhour.html#cfn-connectcampaignsv2-campaign-dailyhour-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TimeRange
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeRange>, IReadOnlyList<Union<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeRange, BaseFunction>>, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-dailyhour.html#cfn-connectcampaignsv2-campaign-dailyhour-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class EmailChannelSubtypeConfig : Humidifier.Base.BaseSubResource, IHaveConnectCampaignsV2CampaignTypesEmailOutboundModeOutboundMode, IHaveCapacity_Double, IHaveConnectCampaignsV2CampaignTypesEmailOutboundConfigDefaultOutboundConfig
        {
            /// <summary>
            /// OutboundMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-emailchannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-emailchannelsubtypeconfig-outboundmode
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EmailOutboundMode
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.EmailOutboundMode, BaseFunction>? OutboundMode { get; set; }
            /// <summary>
            /// Capacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-emailchannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-emailchannelsubtypeconfig-capacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Capacity { get; set; }
            /// <summary>
            /// DefaultOutboundConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-emailchannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-emailchannelsubtypeconfig-defaultoutboundconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EmailOutboundConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.EmailOutboundConfig, BaseFunction>? DefaultOutboundConfig { get; set; }
        }

        public class EmailOutboundConfig : Humidifier.Base.BaseSubResource, IHaveConnectSourceEmailAddress, IHaveSourceEmailAddressDisplayName, IHaveWisdomTemplateArn
        {
            /// <summary>
            /// ConnectSourceEmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-emailoutboundconfig.html#cfn-connectcampaignsv2-campaign-emailoutboundconfig-connectsourceemailaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectSourceEmailAddress { get; set; }
            /// <summary>
            /// SourceEmailAddressDisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-emailoutboundconfig.html#cfn-connectcampaignsv2-campaign-emailoutboundconfig-sourceemailaddressdisplayname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceEmailAddressDisplayName { get; set; }
            /// <summary>
            /// WisdomTemplateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-emailoutboundconfig.html#cfn-connectcampaignsv2-campaign-emailoutboundconfig-wisdomtemplatearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WisdomTemplateArn { get; set; }
        }

        public class EmailOutboundMode : Humidifier.Base.BaseSubResource, IHaveAgentlessConfig_Json
        {
            /// <summary>
            /// AgentlessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-emailoutboundmode.html#cfn-connectcampaignsv2-campaign-emailoutboundmode-agentlessconfig
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AgentlessConfig { get; set; }
        }

        public class EntryLimitsConfig : Humidifier.Base.BaseSubResource, IHaveMaxEntryCount_Integer, IHaveMinEntryInterval
        {
            /// <summary>
            /// MaxEntryCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-entrylimitsconfig.html#cfn-connectcampaignsv2-campaign-entrylimitsconfig-maxentrycount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxEntryCount { get; set; }
            /// <summary>
            /// MinEntryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-entrylimitsconfig.html#cfn-connectcampaignsv2-campaign-entrylimitsconfig-minentryinterval
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MinEntryInterval { get; set; }
        }

        public class EventTrigger : Humidifier.Base.BaseSubResource, IHaveCustomerProfilesDomainArn
        {
            /// <summary>
            /// CustomerProfilesDomainArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-eventtrigger.html#cfn-connectcampaignsv2-campaign-eventtrigger-customerprofilesdomainarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomerProfilesDomainArn { get; set; }
        }

        public class LocalTimeZoneConfig : Humidifier.Base.BaseSubResource, IHaveDefaultTimeZone, IHaveStringListOfLocalTimeZoneDetection, IHaveLocalTimeZoneDetectionScope
        {
            /// <summary>
            /// DefaultTimeZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-localtimezoneconfig.html#cfn-connectcampaignsv2-campaign-localtimezoneconfig-defaulttimezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultTimeZone { get; set; }
            /// <summary>
            /// LocalTimeZoneDetection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-localtimezoneconfig.html#cfn-connectcampaignsv2-campaign-localtimezoneconfig-localtimezonedetection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LocalTimeZoneDetection { get; set; }
            /// <summary>
            /// LocalTimeZoneDetectionScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-localtimezoneconfig.html#cfn-connectcampaignsv2-campaign-localtimezoneconfig-localtimezonedetectionscope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalTimeZoneDetectionScope { get; set; }
        }

        public class OpenHours : Humidifier.Base.BaseSubResource, IHaveListOfConnectCampaignsV2CampaignTypesDailyHourDailyHours
        {
            /// <summary>
            /// DailyHours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-openhours.html#cfn-connectcampaignsv2-campaign-openhours-dailyhours
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DailyHour
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ConnectCampaignsV2.CampaignTypes.DailyHour>, IReadOnlyList<Union<Humidifier.ConnectCampaignsV2.CampaignTypes.DailyHour, BaseFunction>>, BaseFunction>? DailyHours { get; set; }
        }

        public class PredictiveConfig : Humidifier.Base.BaseSubResource, IHaveBandwidthAllocation_Double
        {
            /// <summary>
            /// BandwidthAllocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-predictiveconfig.html#cfn-connectcampaignsv2-campaign-predictiveconfig-bandwidthallocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? BandwidthAllocation { get; set; }
        }

        public class PreviewConfig : Humidifier.Base.BaseSubResource, IHaveConnectCampaignsV2CampaignTypesTimeoutConfigTimeoutConfig, IHaveStringListOfAgentActions, IHaveBandwidthAllocation_Double
        {
            /// <summary>
            /// TimeoutConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-previewconfig.html#cfn-connectcampaignsv2-campaign-previewconfig-timeoutconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TimeoutConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig, BaseFunction>? TimeoutConfig { get; set; }
            /// <summary>
            /// AgentActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-previewconfig.html#cfn-connectcampaignsv2-campaign-previewconfig-agentactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AgentActions { get; set; }
            /// <summary>
            /// BandwidthAllocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-previewconfig.html#cfn-connectcampaignsv2-campaign-previewconfig-bandwidthallocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? BandwidthAllocation { get; set; }
        }

        public class ProgressiveConfig : Humidifier.Base.BaseSubResource, IHaveBandwidthAllocation_Double
        {
            /// <summary>
            /// BandwidthAllocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-progressiveconfig.html#cfn-connectcampaignsv2-campaign-progressiveconfig-bandwidthallocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? BandwidthAllocation { get; set; }
        }

        public class RestrictedPeriod : Humidifier.Base.BaseSubResource, IHaveStartDate, IHaveEndDate, IHaveName
        {
            /// <summary>
            /// StartDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-restrictedperiod.html#cfn-connectcampaignsv2-campaign-restrictedperiod-startdate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartDate { get; set; }
            /// <summary>
            /// EndDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-restrictedperiod.html#cfn-connectcampaignsv2-campaign-restrictedperiod-enddate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndDate { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-restrictedperiod.html#cfn-connectcampaignsv2-campaign-restrictedperiod-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RestrictedPeriods : Humidifier.Base.BaseSubResource, IHaveListOfConnectCampaignsV2CampaignTypesRestrictedPeriodRestrictedPeriodList
        {
            /// <summary>
            /// RestrictedPeriodList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-restrictedperiods.html#cfn-connectcampaignsv2-campaign-restrictedperiods-restrictedperiodlist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RestrictedPeriod
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriod>, IReadOnlyList<Union<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriod, BaseFunction>>, BaseFunction>? RestrictedPeriodList { get; set; }
        }

        public class Schedule : Humidifier.Base.BaseSubResource, IHaveEndTime, IHaveStartTime, IHaveRefreshFrequency
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-schedule.html#cfn-connectcampaignsv2-campaign-schedule-endtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-schedule.html#cfn-connectcampaignsv2-campaign-schedule-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
            /// <summary>
            /// RefreshFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-schedule.html#cfn-connectcampaignsv2-campaign-schedule-refreshfrequency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefreshFrequency { get; set; }
        }

        public class SmsChannelSubtypeConfig : Humidifier.Base.BaseSubResource, IHaveConnectCampaignsV2CampaignTypesSmsOutboundModeOutboundMode, IHaveCapacity_Double, IHaveConnectCampaignsV2CampaignTypesSmsOutboundConfigDefaultOutboundConfig
        {
            /// <summary>
            /// OutboundMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-smschannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-smschannelsubtypeconfig-outboundmode
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SmsOutboundMode
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.SmsOutboundMode, BaseFunction>? OutboundMode { get; set; }
            /// <summary>
            /// Capacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-smschannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-smschannelsubtypeconfig-capacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Capacity { get; set; }
            /// <summary>
            /// DefaultOutboundConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-smschannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-smschannelsubtypeconfig-defaultoutboundconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SmsOutboundConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.SmsOutboundConfig, BaseFunction>? DefaultOutboundConfig { get; set; }
        }

        public class SmsOutboundConfig : Humidifier.Base.BaseSubResource, IHaveConnectSourcePhoneNumberArn, IHaveWisdomTemplateArn
        {
            /// <summary>
            /// ConnectSourcePhoneNumberArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-smsoutboundconfig.html#cfn-connectcampaignsv2-campaign-smsoutboundconfig-connectsourcephonenumberarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectSourcePhoneNumberArn { get; set; }
            /// <summary>
            /// WisdomTemplateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-smsoutboundconfig.html#cfn-connectcampaignsv2-campaign-smsoutboundconfig-wisdomtemplatearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WisdomTemplateArn { get; set; }
        }

        public class SmsOutboundMode : Humidifier.Base.BaseSubResource, IHaveAgentlessConfig_Json
        {
            /// <summary>
            /// AgentlessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-smsoutboundmode.html#cfn-connectcampaignsv2-campaign-smsoutboundmode-agentlessconfig
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AgentlessConfig { get; set; }
        }

        public class Source : Humidifier.Base.BaseSubResource, IHaveCustomerProfilesSegmentArn, IHaveConnectCampaignsV2CampaignTypesEventTriggerEventTrigger
        {
            /// <summary>
            /// CustomerProfilesSegmentArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-source.html#cfn-connectcampaignsv2-campaign-source-customerprofilessegmentarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomerProfilesSegmentArn { get; set; }
            /// <summary>
            /// EventTrigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-source.html#cfn-connectcampaignsv2-campaign-source-eventtrigger
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventTrigger
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger, BaseFunction>? EventTrigger { get; set; }
        }

        public class TelephonyChannelSubtypeConfig : Humidifier.Base.BaseSubResource, IHaveConnectCampaignsV2CampaignTypesTelephonyOutboundModeOutboundMode, IHaveCapacity_Double, IHaveConnectQueueId, IHaveConnectCampaignsV2CampaignTypesTelephonyOutboundConfigDefaultOutboundConfig
        {
            /// <summary>
            /// OutboundMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonychannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-telephonychannelsubtypeconfig-outboundmode
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TelephonyOutboundMode
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyOutboundMode, BaseFunction>? OutboundMode { get; set; }
            /// <summary>
            /// Capacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonychannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-telephonychannelsubtypeconfig-capacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Capacity { get; set; }
            /// <summary>
            /// ConnectQueueId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonychannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-telephonychannelsubtypeconfig-connectqueueid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectQueueId { get; set; }
            /// <summary>
            /// DefaultOutboundConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonychannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-telephonychannelsubtypeconfig-defaultoutboundconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TelephonyOutboundConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyOutboundConfig, BaseFunction>? DefaultOutboundConfig { get; set; }
        }

        public class TelephonyOutboundConfig : Humidifier.Base.BaseSubResource, IHaveConnectContactFlowId, IHaveRingTimeout_Integer, IHaveConnectCampaignsV2CampaignTypesAnswerMachineDetectionConfigAnswerMachineDetectionConfig, IHaveConnectSourcePhoneNumber
        {
            /// <summary>
            /// ConnectContactFlowId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonyoutboundconfig.html#cfn-connectcampaignsv2-campaign-telephonyoutboundconfig-connectcontactflowid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectContactFlowId { get; set; }
            /// <summary>
            /// RingTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonyoutboundconfig.html#cfn-connectcampaignsv2-campaign-telephonyoutboundconfig-ringtimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RingTimeout { get; set; }
            /// <summary>
            /// AnswerMachineDetectionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonyoutboundconfig.html#cfn-connectcampaignsv2-campaign-telephonyoutboundconfig-answermachinedetectionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnswerMachineDetectionConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig, BaseFunction>? AnswerMachineDetectionConfig { get; set; }
            /// <summary>
            /// ConnectSourcePhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonyoutboundconfig.html#cfn-connectcampaignsv2-campaign-telephonyoutboundconfig-connectsourcephonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectSourcePhoneNumber { get; set; }
        }

        public class TelephonyOutboundMode : Humidifier.Base.BaseSubResource, IHaveConnectCampaignsV2CampaignTypesProgressiveConfigProgressiveConfig, IHaveConnectCampaignsV2CampaignTypesPredictiveConfigPredictiveConfig, IHaveAgentlessConfig_Json, IHaveConnectCampaignsV2CampaignTypesPreviewConfigPreviewConfig
        {
            /// <summary>
            /// ProgressiveConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonyoutboundmode.html#cfn-connectcampaignsv2-campaign-telephonyoutboundmode-progressiveconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProgressiveConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig, BaseFunction>? ProgressiveConfig { get; set; }
            /// <summary>
            /// PredictiveConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonyoutboundmode.html#cfn-connectcampaignsv2-campaign-telephonyoutboundmode-predictiveconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig, BaseFunction>? PredictiveConfig { get; set; }
            /// <summary>
            /// AgentlessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonyoutboundmode.html#cfn-connectcampaignsv2-campaign-telephonyoutboundmode-agentlessconfig
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AgentlessConfig { get; set; }
            /// <summary>
            /// PreviewConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonyoutboundmode.html#cfn-connectcampaignsv2-campaign-telephonyoutboundmode-previewconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PreviewConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.PreviewConfig, BaseFunction>? PreviewConfig { get; set; }
        }

        public class TimeRange : Humidifier.Base.BaseSubResource, IHaveEndTime, IHaveStartTime
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-timerange.html#cfn-connectcampaignsv2-campaign-timerange-endtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-timerange.html#cfn-connectcampaignsv2-campaign-timerange-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
        }

        public class TimeWindow : Humidifier.Base.BaseSubResource, IHaveConnectCampaignsV2CampaignTypesOpenHoursOpenHours, IHaveConnectCampaignsV2CampaignTypesRestrictedPeriodsRestrictedPeriods
        {
            /// <summary>
            /// OpenHours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-timewindow.html#cfn-connectcampaignsv2-campaign-timewindow-openhours
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OpenHours
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours, BaseFunction>? OpenHours { get; set; }
            /// <summary>
            /// RestrictedPeriods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-timewindow.html#cfn-connectcampaignsv2-campaign-timewindow-restrictedperiods
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RestrictedPeriods
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods, BaseFunction>? RestrictedPeriods { get; set; }
        }

        public class TimeoutConfig : Humidifier.Base.BaseSubResource, IHaveDurationInSeconds_Integer
        {
            /// <summary>
            /// DurationInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-timeoutconfig.html#cfn-connectcampaignsv2-campaign-timeoutconfig-durationinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DurationInSeconds { get; set; }
        }

        public class WhatsAppChannelSubtypeConfig : Humidifier.Base.BaseSubResource, IHaveConnectCampaignsV2CampaignTypesWhatsAppOutboundModeOutboundMode, IHaveCapacity_Double, IHaveConnectCampaignsV2CampaignTypesWhatsAppOutboundConfigDefaultOutboundConfig
        {
            /// <summary>
            /// OutboundMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-whatsappchannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-whatsappchannelsubtypeconfig-outboundmode
            /// Required: True
            /// UpdateType: Mutable
            /// Type: WhatsAppOutboundMode
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.WhatsAppOutboundMode, BaseFunction>? OutboundMode { get; set; }
            /// <summary>
            /// Capacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-whatsappchannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-whatsappchannelsubtypeconfig-capacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Capacity { get; set; }
            /// <summary>
            /// DefaultOutboundConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-whatsappchannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-whatsappchannelsubtypeconfig-defaultoutboundconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: WhatsAppOutboundConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaignsV2.CampaignTypes.WhatsAppOutboundConfig, BaseFunction>? DefaultOutboundConfig { get; set; }
        }

        public class WhatsAppOutboundConfig : Humidifier.Base.BaseSubResource, IHaveConnectSourcePhoneNumberArn, IHaveWisdomTemplateArn
        {
            /// <summary>
            /// ConnectSourcePhoneNumberArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-whatsappoutboundconfig.html#cfn-connectcampaignsv2-campaign-whatsappoutboundconfig-connectsourcephonenumberarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectSourcePhoneNumberArn { get; set; }
            /// <summary>
            /// WisdomTemplateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-whatsappoutboundconfig.html#cfn-connectcampaignsv2-campaign-whatsappoutboundconfig-wisdomtemplatearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WisdomTemplateArn { get; set; }
        }

        public class WhatsAppOutboundMode : Humidifier.Base.BaseSubResource, IHaveAgentlessConfig_Json
        {
            /// <summary>
            /// AgentlessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-whatsappoutboundmode.html#cfn-connectcampaignsv2-campaign-whatsappoutboundmode-agentlessconfig
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AgentlessConfig { get; set; }
        }
    }
}