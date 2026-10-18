namespace Humidifier.ConnectCampaigns
{
    using global::System.Collections.Generic;
    using CampaignTypes;

    public class Campaign : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveConnectCampaignsCampaignTypesOutboundCallConfigOutboundCallConfig, IHaveConnectInstanceArn, IHaveConnectCampaignsCampaignTypesDialerConfigDialerConfig, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ConnectCampaigns.Campaign; }

        /// <summary>
        /// OutboundCallConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaigns-campaign.html#cfn-connectcampaigns-campaign-outboundcallconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: OutboundCallConfig
        /// </summary>
        [Required]
        public Union<Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig, BaseFunction>? OutboundCallConfig { get; set; }

        /// <summary>
        /// ConnectInstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaigns-campaign.html#cfn-connectcampaigns-campaign-connectinstancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConnectInstanceArn { get; set; }

        /// <summary>
        /// DialerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaigns-campaign.html#cfn-connectcampaigns-campaign-dialerconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DialerConfig
        /// </summary>
        [Required]
        public Union<Humidifier.ConnectCampaigns.CampaignTypes.DialerConfig, BaseFunction>? DialerConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaigns-campaign.html#cfn-connectcampaigns-campaign-tags
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
        public class AgentlessDialerConfig : Humidifier.Base.BaseSubResource, IHaveDialingCapacity_Double
        {
            /// <summary>
            /// DialingCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-agentlessdialerconfig.html#cfn-connectcampaigns-campaign-agentlessdialerconfig-dialingcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DialingCapacity { get; set; }
        }

        public class AnswerMachineDetectionConfig : Humidifier.Base.BaseSubResource, IHaveEnableAnswerMachineDetection_Boolean, IHaveAwaitAnswerMachinePrompt_Boolean
        {
            /// <summary>
            /// EnableAnswerMachineDetection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-answermachinedetectionconfig.html#cfn-connectcampaigns-campaign-answermachinedetectionconfig-enableanswermachinedetection
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableAnswerMachineDetection { get; set; }
            /// <summary>
            /// AwaitAnswerMachinePrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-answermachinedetectionconfig.html#cfn-connectcampaigns-campaign-answermachinedetectionconfig-awaitanswermachineprompt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AwaitAnswerMachinePrompt { get; set; }
        }

        public class DialerConfig : Humidifier.Base.BaseSubResource, IHaveConnectCampaignsCampaignTypesAgentlessDialerConfigAgentlessDialerConfig, IHaveConnectCampaignsCampaignTypesPredictiveDialerConfigPredictiveDialerConfig, IHaveConnectCampaignsCampaignTypesProgressiveDialerConfigProgressiveDialerConfig
        {
            /// <summary>
            /// AgentlessDialerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-dialerconfig.html#cfn-connectcampaigns-campaign-dialerconfig-agentlessdialerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AgentlessDialerConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaigns.CampaignTypes.AgentlessDialerConfig, BaseFunction>? AgentlessDialerConfig { get; set; }
            /// <summary>
            /// PredictiveDialerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-dialerconfig.html#cfn-connectcampaigns-campaign-dialerconfig-predictivedialerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveDialerConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaigns.CampaignTypes.PredictiveDialerConfig, BaseFunction>? PredictiveDialerConfig { get; set; }
            /// <summary>
            /// ProgressiveDialerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-dialerconfig.html#cfn-connectcampaigns-campaign-dialerconfig-progressivedialerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProgressiveDialerConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaigns.CampaignTypes.ProgressiveDialerConfig, BaseFunction>? ProgressiveDialerConfig { get; set; }
        }

        public class OutboundCallConfig : Humidifier.Base.BaseSubResource, IHaveConnectContactFlowArn, IHaveConnectQueueArn, IHaveConnectCampaignsCampaignTypesAnswerMachineDetectionConfigAnswerMachineDetectionConfig, IHaveConnectSourcePhoneNumber
        {
            /// <summary>
            /// ConnectContactFlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-outboundcallconfig.html#cfn-connectcampaigns-campaign-outboundcallconfig-connectcontactflowarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectContactFlowArn { get; set; }
            /// <summary>
            /// ConnectQueueArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-outboundcallconfig.html#cfn-connectcampaigns-campaign-outboundcallconfig-connectqueuearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectQueueArn { get; set; }
            /// <summary>
            /// AnswerMachineDetectionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-outboundcallconfig.html#cfn-connectcampaigns-campaign-outboundcallconfig-answermachinedetectionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnswerMachineDetectionConfig
            /// </summary>
            public Union<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig, BaseFunction>? AnswerMachineDetectionConfig { get; set; }
            /// <summary>
            /// ConnectSourcePhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-outboundcallconfig.html#cfn-connectcampaigns-campaign-outboundcallconfig-connectsourcephonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectSourcePhoneNumber { get; set; }
        }

        public class PredictiveDialerConfig : Humidifier.Base.BaseSubResource, IHaveDialingCapacity_Double, IHaveBandwidthAllocation_Double
        {
            /// <summary>
            /// DialingCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-predictivedialerconfig.html#cfn-connectcampaigns-campaign-predictivedialerconfig-dialingcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DialingCapacity { get; set; }
            /// <summary>
            /// BandwidthAllocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-predictivedialerconfig.html#cfn-connectcampaigns-campaign-predictivedialerconfig-bandwidthallocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? BandwidthAllocation { get; set; }
        }

        public class ProgressiveDialerConfig : Humidifier.Base.BaseSubResource, IHaveDialingCapacity_Double, IHaveBandwidthAllocation_Double
        {
            /// <summary>
            /// DialingCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-progressivedialerconfig.html#cfn-connectcampaigns-campaign-progressivedialerconfig-dialingcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DialingCapacity { get; set; }
            /// <summary>
            /// BandwidthAllocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-progressivedialerconfig.html#cfn-connectcampaigns-campaign-progressivedialerconfig-bandwidthallocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? BandwidthAllocation { get; set; }
        }
    }
}