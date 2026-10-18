namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using TrafficMirrorFilterRuleTypes;

    public class TrafficMirrorFilterRule : Humidifier.Base.BaseResource, IHaveTags, IHaveEC2TrafficMirrorFilterRuleTypesTrafficMirrorPortRangeDestinationPortRange, IHaveDescription, IHaveEC2TrafficMirrorFilterRuleTypesTrafficMirrorPortRangeSourcePortRange, IHaveRuleAction, IHaveSourceCidrBlock, IHaveRuleNumber_Integer, IHaveDestinationCidrBlock, IHaveTrafficMirrorFilterId, IHaveTrafficDirection, IHaveProtocol_Integer
    {
        public class Attributes
        {
            public static string TrafficMirrorFilterRuleId =  "TrafficMirrorFilterRuleId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TrafficMirrorFilterRule; }
        /// <summary>
        /// DestinationPortRange
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-destinationportrange
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TrafficMirrorPortRange
        /// </summary>
        public Union<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange, BaseFunction>? DestinationPortRange { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// SourcePortRange
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-sourceportrange
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TrafficMirrorPortRange
        /// </summary>
        public Union<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange, BaseFunction>? SourcePortRange { get; set; }

        /// <summary>
        /// RuleAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-ruleaction
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuleAction { get; set; }

        /// <summary>
        /// SourceCidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-sourcecidrblock
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SourceCidrBlock { get; set; }

        /// <summary>
        /// RuleNumber
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-rulenumber
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? RuleNumber { get; set; }

        /// <summary>
        /// DestinationCidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-destinationcidrblock
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DestinationCidrBlock { get; set; }

        /// <summary>
        /// TrafficMirrorFilterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-trafficmirrorfilterid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TrafficMirrorFilterId { get; set; }

        /// <summary>
        /// TrafficDirection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-trafficdirection
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TrafficDirection { get; set; }
        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-protocol
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Protocol { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TrafficMirrorFilterRuleTypes
    {
        public class TrafficMirrorPortRange : Humidifier.Base.BaseSubResource, IHaveToPort_Integer, IHaveFromPort_Integer
        {
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-trafficmirrorfilterrule-trafficmirrorportrange.html#cfn-ec2-trafficmirrorfilterrule-trafficmirrorportrange-toport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ToPort { get; set; }
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-trafficmirrorfilterrule-trafficmirrorportrange.html#cfn-ec2-trafficmirrorfilterrule-trafficmirrorportrange-fromport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FromPort { get; set; }
        }
    }
}