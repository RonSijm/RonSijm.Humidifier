namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using NetworkAclEntryTypes;

    public class NetworkAclEntry : Humidifier.Base.BaseResource, IHaveEC2NetworkAclEntryTypesPortRangePortRange, IHaveNetworkAclId, IHaveRuleAction, IHaveCidrBlock, IHaveEgress_Boolean, IHaveRuleNumber_Integer, IHaveIpv6CidrBlock, IHaveProtocol_Integer, IHaveEC2NetworkAclEntryTypesIcmpIcmp
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.EC2.NetworkAclEntry; }
        /// <summary>
        /// PortRange
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkaclentry.html#cfn-ec2-networkaclentry-portrange
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PortRange
        /// </summary>
        public Union<Humidifier.EC2.NetworkAclEntryTypes.PortRange, BaseFunction>? PortRange { get; set; }

        /// <summary>
        /// NetworkAclId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkaclentry.html#cfn-ec2-networkaclentry-networkaclid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? NetworkAclId { get; set; }

        /// <summary>
        /// RuleAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkaclentry.html#cfn-ec2-networkaclentry-ruleaction
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuleAction { get; set; }
        /// <summary>
        /// CidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkaclentry.html#cfn-ec2-networkaclentry-cidrblock
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CidrBlock { get; set; }
        /// <summary>
        /// Egress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkaclentry.html#cfn-ec2-networkaclentry-egress
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Egress { get; set; }

        /// <summary>
        /// RuleNumber
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkaclentry.html#cfn-ec2-networkaclentry-rulenumber
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? RuleNumber { get; set; }
        /// <summary>
        /// Ipv6CidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkaclentry.html#cfn-ec2-networkaclentry-ipv6cidrblock
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Ipv6CidrBlock { get; set; }

        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkaclentry.html#cfn-ec2-networkaclentry-protocol
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Protocol { get; set; }
        /// <summary>
        /// Icmp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkaclentry.html#cfn-ec2-networkaclentry-icmp
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Icmp
        /// </summary>
        public Union<Humidifier.EC2.NetworkAclEntryTypes.Icmp, BaseFunction>? Icmp { get; set; }
    }

    namespace NetworkAclEntryTypes
    {
        public class Icmp : Humidifier.Base.BaseSubResource, IHaveType_Integer, IHaveCode_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkaclentry-icmp.html#cfn-ec2-networkaclentry-icmp-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkaclentry-icmp.html#cfn-ec2-networkaclentry-icmp-code
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Code { get; set; }
        }

        public class PortRange : Humidifier.Base.BaseSubResource, IHaveFrom_Integer, IHaveTo_Integer
        {
            /// <summary>
            /// From
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkaclentry-portrange.html#cfn-ec2-networkaclentry-portrange-from
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? From { get; set; }
            /// <summary>
            /// To
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkaclentry-portrange.html#cfn-ec2-networkaclentry-portrange-to
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? To { get; set; }
        }
    }
}