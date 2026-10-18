namespace Humidifier.Pinpoint
{
    using global::System.Collections.Generic;
    using ApplicationSettingsTypes;

    public class ApplicationSettings : Humidifier.Base.BaseResource, IHavePinpointApplicationSettingsTypesQuietTimeQuietTime, IHavePinpointApplicationSettingsTypesLimitsLimits, IHaveApplicationId, IHavePinpointApplicationSettingsTypesCampaignHookCampaignHook, IHaveCloudWatchMetricsEnabled_Boolean
    {
        public override string AWSTypeName { get => AWS.Pinpoint.ApplicationSettings; }
        /// <summary>
        /// QuietTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-applicationsettings.html#cfn-pinpoint-applicationsettings-quiettime
        /// Required: False
        /// UpdateType: Mutable
        /// Type: QuietTime
        /// </summary>
        public Union<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime, BaseFunction>? QuietTime { get; set; }
        /// <summary>
        /// Limits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-applicationsettings.html#cfn-pinpoint-applicationsettings-limits
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Limits
        /// </summary>
        public Union<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits, BaseFunction>? Limits { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-applicationsettings.html#cfn-pinpoint-applicationsettings-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationId { get; set; }
        /// <summary>
        /// CampaignHook
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-applicationsettings.html#cfn-pinpoint-applicationsettings-campaignhook
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CampaignHook
        /// </summary>
        public Union<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook, BaseFunction>? CampaignHook { get; set; }
        /// <summary>
        /// CloudWatchMetricsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-applicationsettings.html#cfn-pinpoint-applicationsettings-cloudwatchmetricsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? CloudWatchMetricsEnabled { get; set; }
    }

    namespace ApplicationSettingsTypes
    {
        public class CampaignHook : Humidifier.Base.BaseSubResource, IHaveMode, IHaveWebUrl, IHaveLambdaFunctionName
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-campaignhook.html#cfn-pinpoint-applicationsettings-campaignhook-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// WebUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-campaignhook.html#cfn-pinpoint-applicationsettings-campaignhook-weburl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WebUrl { get; set; }
            /// <summary>
            /// LambdaFunctionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-campaignhook.html#cfn-pinpoint-applicationsettings-campaignhook-lambdafunctionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaFunctionName { get; set; }
        }

        public class Limits : Humidifier.Base.BaseSubResource, IHaveDaily_Integer, IHaveMaximumDuration_Integer, IHaveTotal_Integer, IHaveMessagesPerSecond_Integer
        {
            /// <summary>
            /// Daily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-limits.html#cfn-pinpoint-applicationsettings-limits-daily
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Daily { get; set; }
            /// <summary>
            /// MaximumDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-limits.html#cfn-pinpoint-applicationsettings-limits-maximumduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumDuration { get; set; }
            /// <summary>
            /// Total
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-limits.html#cfn-pinpoint-applicationsettings-limits-total
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Total { get; set; }
            /// <summary>
            /// MessagesPerSecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-limits.html#cfn-pinpoint-applicationsettings-limits-messagespersecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MessagesPerSecond { get; set; }
        }

        public class QuietTime : Humidifier.Base.BaseSubResource, IHaveStart, IHaveEnd
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-quiettime.html#cfn-pinpoint-applicationsettings-quiettime-start
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Start { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-quiettime.html#cfn-pinpoint-applicationsettings-quiettime-end
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? End { get; set; }
        }
    }
}