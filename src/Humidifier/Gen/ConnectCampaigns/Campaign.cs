namespace Humidifier.ConnectCampaigns
{
    using System.Collections.Generic;
    using CampaignTypes;

    public class Campaign : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
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
        public Humidifier.ConnectCampaigns.CampaignTypes.OutboundCallConfig OutboundCallConfig { get; set; }

        /// <summary>
        /// ConnectInstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaigns-campaign.html#cfn-connectcampaigns-campaign-connectinstancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ConnectInstanceArn { get; set; }

        /// <summary>
        /// DialerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaigns-campaign.html#cfn-connectcampaigns-campaign-dialerconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DialerConfig
        /// </summary>
        [Required]
        public Humidifier.ConnectCampaigns.CampaignTypes.DialerConfig DialerConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaigns-campaign.html#cfn-connectcampaigns-campaign-tags
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
        public class AgentlessDialerConfig : Humidifier.Base.BaseSubResource, IHaveDialingCapacity
        {
            /// <summary>
            /// DialingCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-agentlessdialerconfig.html#cfn-connectcampaigns-campaign-agentlessdialerconfig-dialingcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DialingCapacity { get; set; }
        }

        public class AnswerMachineDetectionConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EnableAnswerMachineDetection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-answermachinedetectionconfig.html#cfn-connectcampaigns-campaign-answermachinedetectionconfig-enableanswermachinedetection
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableAnswerMachineDetection { get; set; }
            /// <summary>
            /// AwaitAnswerMachinePrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-answermachinedetectionconfig.html#cfn-connectcampaigns-campaign-answermachinedetectionconfig-awaitanswermachineprompt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AwaitAnswerMachinePrompt { get; set; }
        }

        public class DialerConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AgentlessDialerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-dialerconfig.html#cfn-connectcampaigns-campaign-dialerconfig-agentlessdialerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AgentlessDialerConfig
            /// </summary>
            public Humidifier.ConnectCampaigns.CampaignTypes.AgentlessDialerConfig AgentlessDialerConfig { get; set; }
            /// <summary>
            /// PredictiveDialerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-dialerconfig.html#cfn-connectcampaigns-campaign-dialerconfig-predictivedialerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveDialerConfig
            /// </summary>
            public Humidifier.ConnectCampaigns.CampaignTypes.PredictiveDialerConfig PredictiveDialerConfig { get; set; }
            /// <summary>
            /// ProgressiveDialerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-dialerconfig.html#cfn-connectcampaigns-campaign-dialerconfig-progressivedialerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProgressiveDialerConfig
            /// </summary>
            public Humidifier.ConnectCampaigns.CampaignTypes.ProgressiveDialerConfig ProgressiveDialerConfig { get; set; }
        }

        public class OutboundCallConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConnectContactFlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-outboundcallconfig.html#cfn-connectcampaigns-campaign-outboundcallconfig-connectcontactflowarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectContactFlowArn { get; set; }
            /// <summary>
            /// ConnectQueueArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-outboundcallconfig.html#cfn-connectcampaigns-campaign-outboundcallconfig-connectqueuearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectQueueArn { get; set; }
            /// <summary>
            /// AnswerMachineDetectionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-outboundcallconfig.html#cfn-connectcampaigns-campaign-outboundcallconfig-answermachinedetectionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnswerMachineDetectionConfig
            /// </summary>
            public Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig AnswerMachineDetectionConfig { get; set; }
            /// <summary>
            /// ConnectSourcePhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-outboundcallconfig.html#cfn-connectcampaigns-campaign-outboundcallconfig-connectsourcephonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectSourcePhoneNumber { get; set; }
        }

        public class PredictiveDialerConfig : Humidifier.Base.BaseSubResource, IHaveDialingCapacity
        {
            /// <summary>
            /// DialingCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-predictivedialerconfig.html#cfn-connectcampaigns-campaign-predictivedialerconfig-dialingcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DialingCapacity { get; set; }
            /// <summary>
            /// BandwidthAllocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-predictivedialerconfig.html#cfn-connectcampaigns-campaign-predictivedialerconfig-bandwidthallocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic BandwidthAllocation { get; set; }
        }

        public class ProgressiveDialerConfig : Humidifier.Base.BaseSubResource, IHaveDialingCapacity
        {
            /// <summary>
            /// DialingCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-progressivedialerconfig.html#cfn-connectcampaigns-campaign-progressivedialerconfig-dialingcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DialingCapacity { get; set; }
            /// <summary>
            /// BandwidthAllocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-progressivedialerconfig.html#cfn-connectcampaigns-campaign-progressivedialerconfig-bandwidthallocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic BandwidthAllocation { get; set; }
        }
    }
}