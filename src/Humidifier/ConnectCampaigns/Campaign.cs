namespace Humidifier.ConnectCampaigns
{
    using System.Collections.Generic;
    using CampaignTypes;

    public class Campaign : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::ConnectCampaigns::Campaign";
            }
        }

        /// <summary>
        /// OutboundCallConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaigns-campaign.html#cfn-connectcampaigns-campaign-outboundcallconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: OutboundCallConfig
        /// </summary>
        public OutboundCallConfig OutboundCallConfig { get; set; }
        /// <summary>
        /// ConnectInstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaigns-campaign.html#cfn-connectcampaigns-campaign-connectinstancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ConnectInstanceArn { get; set; }
        /// <summary>
        /// DialerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaigns-campaign.html#cfn-connectcampaigns-campaign-dialerconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DialerConfig
        /// </summary>
        public DialerConfig DialerConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaigns-campaign.html#cfn-connectcampaigns-campaign-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connectcampaigns-campaign.html#cfn-connectcampaigns-campaign-name
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace CampaignTypes
    {
        public class AgentlessDialerConfig
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

        public class AnswerMachineDetectionConfig
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

        public class DialerConfig
        {
            /// <summary>
            /// AgentlessDialerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-dialerconfig.html#cfn-connectcampaigns-campaign-dialerconfig-agentlessdialerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AgentlessDialerConfig
            /// </summary>
            public AgentlessDialerConfig AgentlessDialerConfig { get; set; }
            /// <summary>
            /// PredictiveDialerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-dialerconfig.html#cfn-connectcampaigns-campaign-dialerconfig-predictivedialerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveDialerConfig
            /// </summary>
            public PredictiveDialerConfig PredictiveDialerConfig { get; set; }
            /// <summary>
            /// ProgressiveDialerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-dialerconfig.html#cfn-connectcampaigns-campaign-dialerconfig-progressivedialerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProgressiveDialerConfig
            /// </summary>
            public ProgressiveDialerConfig ProgressiveDialerConfig { get; set; }
        }

        public class OutboundCallConfig
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
            public AnswerMachineDetectionConfig AnswerMachineDetectionConfig { get; set; }
            /// <summary>
            /// ConnectSourcePhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connectcampaigns-campaign-outboundcallconfig.html#cfn-connectcampaigns-campaign-outboundcallconfig-connectsourcephonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectSourcePhoneNumber { get; set; }
        }

        public class PredictiveDialerConfig
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

        public class ProgressiveDialerConfig
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