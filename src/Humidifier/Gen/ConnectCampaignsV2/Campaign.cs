namespace Humidifier.ConnectCampaignsV2
{
    using System.Collections.Generic;
    using CampaignTypes;

    public class Campaign : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
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
        public Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimitsConfig CommunicationLimitsOverride { get; set; }

        /// <summary>
        /// ChannelSubtypeConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaignsv2-campaign.html#cfn-connectcampaignsv2-campaign-channelsubtypeconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ChannelSubtypeConfig
        /// </summary>
        [Required]
        public Humidifier.ConnectCampaignsV2.CampaignTypes.ChannelSubtypeConfig ChannelSubtypeConfig { get; set; }
        /// <summary>
        /// ConnectCampaignFlowArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaignsv2-campaign.html#cfn-connectcampaignsv2-campaign-connectcampaignflowarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ConnectCampaignFlowArn { get; set; }
        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaignsv2-campaign.html#cfn-connectcampaignsv2-campaign-schedule
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Schedule
        /// </summary>
        public Humidifier.ConnectCampaignsV2.CampaignTypes.Schedule Schedule { get; set; }
        /// <summary>
        /// CommunicationTimeConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaignsv2-campaign.html#cfn-connectcampaignsv2-campaign-communicationtimeconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CommunicationTimeConfig
        /// </summary>
        public Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationTimeConfig CommunicationTimeConfig { get; set; }

        /// <summary>
        /// ConnectInstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaignsv2-campaign.html#cfn-connectcampaignsv2-campaign-connectinstanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ConnectInstanceId { get; set; }
        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaignsv2-campaign.html#cfn-connectcampaignsv2-campaign-source
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Source
        /// </summary>
        public Humidifier.ConnectCampaignsV2.CampaignTypes.Source Source { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaignsv2-campaign.html#cfn-connectcampaignsv2-campaign-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace CampaignTypes
    {
        public class AnswerMachineDetectionConfig : Humidifier.Base.BaseSubResource, IHaveEnableAnswerMachineDetection, IHaveAwaitAnswerMachinePrompt
        {
            /// <summary>
            /// EnableAnswerMachineDetection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-answermachinedetectionconfig.html#cfn-connectcampaignsv2-campaign-answermachinedetectionconfig-enableanswermachinedetection
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableAnswerMachineDetection { get; set; }
            /// <summary>
            /// AwaitAnswerMachinePrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-answermachinedetectionconfig.html#cfn-connectcampaignsv2-campaign-answermachinedetectionconfig-awaitanswermachineprompt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AwaitAnswerMachinePrompt { get; set; }
        }

        public class ChannelSubtypeConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Email
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-channelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-channelsubtypeconfig-email
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmailChannelSubtypeConfig
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.EmailChannelSubtypeConfig Email { get; set; }
            /// <summary>
            /// Telephony
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-channelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-channelsubtypeconfig-telephony
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TelephonyChannelSubtypeConfig
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyChannelSubtypeConfig Telephony { get; set; }
            /// <summary>
            /// Sms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-channelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-channelsubtypeconfig-sms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmsChannelSubtypeConfig
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.SmsChannelSubtypeConfig Sms { get; set; }
        }

        public class CommunicationLimit : Humidifier.Base.BaseSubResource, IHaveUnit, IHaveFrequency
        {
            /// <summary>
            /// Frequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationlimit.html#cfn-connectcampaignsv2-campaign-communicationlimit-frequency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Frequency { get; set; }
            /// <summary>
            /// MaxCountPerRecipient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationlimit.html#cfn-connectcampaignsv2-campaign-communicationlimit-maxcountperrecipient
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxCountPerRecipient { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationlimit.html#cfn-connectcampaignsv2-campaign-communicationlimit-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }

        public class CommunicationLimits : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CommunicationLimitList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationlimits.html#cfn-connectcampaignsv2-campaign-communicationlimits-communicationlimitlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CommunicationLimit
            /// </summary>
            public List<Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimit> CommunicationLimitList { get; set; }
        }

        public class CommunicationLimitsConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AllChannelsSubtypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationlimitsconfig.html#cfn-connectcampaignsv2-campaign-communicationlimitsconfig-allchannelssubtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CommunicationLimits
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.CommunicationLimits AllChannelsSubtypes { get; set; }
        }

        public class CommunicationTimeConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LocalTimeZoneConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationtimeconfig.html#cfn-connectcampaignsv2-campaign-communicationtimeconfig-localtimezoneconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LocalTimeZoneConfig
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.LocalTimeZoneConfig LocalTimeZoneConfig { get; set; }
            /// <summary>
            /// Email
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationtimeconfig.html#cfn-connectcampaignsv2-campaign-communicationtimeconfig-email
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeWindow
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.TimeWindow Email { get; set; }
            /// <summary>
            /// Telephony
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationtimeconfig.html#cfn-connectcampaignsv2-campaign-communicationtimeconfig-telephony
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeWindow
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.TimeWindow Telephony { get; set; }
            /// <summary>
            /// Sms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-communicationtimeconfig.html#cfn-connectcampaignsv2-campaign-communicationtimeconfig-sms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeWindow
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.TimeWindow Sms { get; set; }
        }

        public class DailyHour : Humidifier.Base.BaseSubResource, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-dailyhour.html#cfn-connectcampaignsv2-campaign-dailyhour-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TimeRange
            /// </summary>
            public List<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeRange> Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-dailyhour.html#cfn-connectcampaignsv2-campaign-dailyhour-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class EmailChannelSubtypeConfig : Humidifier.Base.BaseSubResource, IHaveCapacity
        {
            /// <summary>
            /// OutboundMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-emailchannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-emailchannelsubtypeconfig-outboundmode
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EmailOutboundMode
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.EmailOutboundMode OutboundMode { get; set; }
            /// <summary>
            /// Capacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-emailchannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-emailchannelsubtypeconfig-capacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Capacity { get; set; }
            /// <summary>
            /// DefaultOutboundConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-emailchannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-emailchannelsubtypeconfig-defaultoutboundconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EmailOutboundConfig
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.EmailOutboundConfig DefaultOutboundConfig { get; set; }
        }

        public class EmailOutboundConfig : Humidifier.Base.BaseSubResource, IHaveWisdomTemplateArn
        {
            /// <summary>
            /// ConnectSourceEmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-emailoutboundconfig.html#cfn-connectcampaignsv2-campaign-emailoutboundconfig-connectsourceemailaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectSourceEmailAddress { get; set; }
            /// <summary>
            /// SourceEmailAddressDisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-emailoutboundconfig.html#cfn-connectcampaignsv2-campaign-emailoutboundconfig-sourceemailaddressdisplayname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceEmailAddressDisplayName { get; set; }
            /// <summary>
            /// WisdomTemplateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-emailoutboundconfig.html#cfn-connectcampaignsv2-campaign-emailoutboundconfig-wisdomtemplatearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WisdomTemplateArn { get; set; }
        }

        public class EmailOutboundMode : Humidifier.Base.BaseSubResource, IHaveAgentlessConfig
        {
            /// <summary>
            /// AgentlessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-emailoutboundmode.html#cfn-connectcampaignsv2-campaign-emailoutboundmode-agentlessconfig
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AgentlessConfig { get; set; }
        }

        public class EventTrigger : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomerProfilesDomainArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-eventtrigger.html#cfn-connectcampaignsv2-campaign-eventtrigger-customerprofilesdomainarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomerProfilesDomainArn { get; set; }
        }

        public class LocalTimeZoneConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultTimeZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-localtimezoneconfig.html#cfn-connectcampaignsv2-campaign-localtimezoneconfig-defaulttimezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultTimeZone { get; set; }
            /// <summary>
            /// LocalTimeZoneDetection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-localtimezoneconfig.html#cfn-connectcampaignsv2-campaign-localtimezoneconfig-localtimezonedetection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LocalTimeZoneDetection { get; set; }
        }

        public class OpenHours : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DailyHours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-openhours.html#cfn-connectcampaignsv2-campaign-openhours-dailyhours
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DailyHour
            /// </summary>
            public List<Humidifier.ConnectCampaignsV2.CampaignTypes.DailyHour> DailyHours { get; set; }
        }

        public class PredictiveConfig : Humidifier.Base.BaseSubResource, IHaveBandwidthAllocation
        {
            /// <summary>
            /// BandwidthAllocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-predictiveconfig.html#cfn-connectcampaignsv2-campaign-predictiveconfig-bandwidthallocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic BandwidthAllocation { get; set; }
        }

        public class ProgressiveConfig : Humidifier.Base.BaseSubResource, IHaveBandwidthAllocation
        {
            /// <summary>
            /// BandwidthAllocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-progressiveconfig.html#cfn-connectcampaignsv2-campaign-progressiveconfig-bandwidthallocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic BandwidthAllocation { get; set; }
        }

        public class RestrictedPeriod : Humidifier.Base.BaseSubResource, IHaveName, IHaveEndDate, IHaveStartDate
        {
            /// <summary>
            /// StartDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-restrictedperiod.html#cfn-connectcampaignsv2-campaign-restrictedperiod-startdate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartDate { get; set; }
            /// <summary>
            /// EndDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-restrictedperiod.html#cfn-connectcampaignsv2-campaign-restrictedperiod-enddate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndDate { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-restrictedperiod.html#cfn-connectcampaignsv2-campaign-restrictedperiod-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RestrictedPeriods : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RestrictedPeriodList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-restrictedperiods.html#cfn-connectcampaignsv2-campaign-restrictedperiods-restrictedperiodlist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RestrictedPeriod
            /// </summary>
            public List<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriod> RestrictedPeriodList { get; set; }
        }

        public class Schedule : Humidifier.Base.BaseSubResource, IHaveStartTime, IHaveEndTime
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-schedule.html#cfn-connectcampaignsv2-campaign-schedule-endtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-schedule.html#cfn-connectcampaignsv2-campaign-schedule-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartTime { get; set; }
            /// <summary>
            /// RefreshFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-schedule.html#cfn-connectcampaignsv2-campaign-schedule-refreshfrequency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RefreshFrequency { get; set; }
        }

        public class SmsChannelSubtypeConfig : Humidifier.Base.BaseSubResource, IHaveCapacity
        {
            /// <summary>
            /// OutboundMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-smschannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-smschannelsubtypeconfig-outboundmode
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SmsOutboundMode
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.SmsOutboundMode OutboundMode { get; set; }
            /// <summary>
            /// Capacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-smschannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-smschannelsubtypeconfig-capacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Capacity { get; set; }
            /// <summary>
            /// DefaultOutboundConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-smschannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-smschannelsubtypeconfig-defaultoutboundconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SmsOutboundConfig
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.SmsOutboundConfig DefaultOutboundConfig { get; set; }
        }

        public class SmsOutboundConfig : Humidifier.Base.BaseSubResource, IHaveWisdomTemplateArn
        {
            /// <summary>
            /// ConnectSourcePhoneNumberArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-smsoutboundconfig.html#cfn-connectcampaignsv2-campaign-smsoutboundconfig-connectsourcephonenumberarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectSourcePhoneNumberArn { get; set; }
            /// <summary>
            /// WisdomTemplateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-smsoutboundconfig.html#cfn-connectcampaignsv2-campaign-smsoutboundconfig-wisdomtemplatearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WisdomTemplateArn { get; set; }
        }

        public class SmsOutboundMode : Humidifier.Base.BaseSubResource, IHaveAgentlessConfig
        {
            /// <summary>
            /// AgentlessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-smsoutboundmode.html#cfn-connectcampaignsv2-campaign-smsoutboundmode-agentlessconfig
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AgentlessConfig { get; set; }
        }

        public class Source : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomerProfilesSegmentArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-source.html#cfn-connectcampaignsv2-campaign-source-customerprofilessegmentarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomerProfilesSegmentArn { get; set; }
            /// <summary>
            /// EventTrigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-source.html#cfn-connectcampaignsv2-campaign-source-eventtrigger
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventTrigger
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger EventTrigger { get; set; }
        }

        public class TelephonyChannelSubtypeConfig : Humidifier.Base.BaseSubResource, IHaveCapacity
        {
            /// <summary>
            /// OutboundMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonychannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-telephonychannelsubtypeconfig-outboundmode
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TelephonyOutboundMode
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyOutboundMode OutboundMode { get; set; }
            /// <summary>
            /// Capacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonychannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-telephonychannelsubtypeconfig-capacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Capacity { get; set; }
            /// <summary>
            /// ConnectQueueId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonychannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-telephonychannelsubtypeconfig-connectqueueid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectQueueId { get; set; }
            /// <summary>
            /// DefaultOutboundConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonychannelsubtypeconfig.html#cfn-connectcampaignsv2-campaign-telephonychannelsubtypeconfig-defaultoutboundconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TelephonyOutboundConfig
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.TelephonyOutboundConfig DefaultOutboundConfig { get; set; }
        }

        public class TelephonyOutboundConfig : Humidifier.Base.BaseSubResource, IHaveConnectSourcePhoneNumber
        {
            /// <summary>
            /// ConnectContactFlowId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonyoutboundconfig.html#cfn-connectcampaignsv2-campaign-telephonyoutboundconfig-connectcontactflowid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectContactFlowId { get; set; }
            /// <summary>
            /// AnswerMachineDetectionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonyoutboundconfig.html#cfn-connectcampaignsv2-campaign-telephonyoutboundconfig-answermachinedetectionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnswerMachineDetectionConfig
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig AnswerMachineDetectionConfig { get; set; }
            /// <summary>
            /// ConnectSourcePhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonyoutboundconfig.html#cfn-connectcampaignsv2-campaign-telephonyoutboundconfig-connectsourcephonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectSourcePhoneNumber { get; set; }
        }

        public class TelephonyOutboundMode : Humidifier.Base.BaseSubResource, IHaveAgentlessConfig
        {
            /// <summary>
            /// ProgressiveConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonyoutboundmode.html#cfn-connectcampaignsv2-campaign-telephonyoutboundmode-progressiveconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProgressiveConfig
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig ProgressiveConfig { get; set; }
            /// <summary>
            /// PredictiveConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonyoutboundmode.html#cfn-connectcampaignsv2-campaign-telephonyoutboundmode-predictiveconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveConfig
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig PredictiveConfig { get; set; }
            /// <summary>
            /// AgentlessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-telephonyoutboundmode.html#cfn-connectcampaignsv2-campaign-telephonyoutboundmode-agentlessconfig
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AgentlessConfig { get; set; }
        }

        public class TimeRange : Humidifier.Base.BaseSubResource, IHaveStartTime, IHaveEndTime
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-timerange.html#cfn-connectcampaignsv2-campaign-timerange-endtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-timerange.html#cfn-connectcampaignsv2-campaign-timerange-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartTime { get; set; }
        }

        public class TimeWindow : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OpenHours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-timewindow.html#cfn-connectcampaignsv2-campaign-timewindow-openhours
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OpenHours
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours OpenHours { get; set; }
            /// <summary>
            /// RestrictedPeriods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaignsv2-campaign-timewindow.html#cfn-connectcampaignsv2-campaign-timewindow-restrictedperiods
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RestrictedPeriods
            /// </summary>
            public Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods RestrictedPeriods { get; set; }
        }
    }
}