namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using TransitGatewayPolicyTableEntryTypes;

    public class TransitGatewayPolicyTableEntry : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string State =  "State" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGatewayPolicyTableEntry; }

        /// <summary>
        /// PolicyRule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypolicytableentry.html#cfn-ec2-transitgatewaypolicytableentry-policyrule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TransitGatewayPolicyRule
        /// </summary>
        [Required]
        public Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule PolicyRule { get; set; }

        /// <summary>
        /// PolicyRuleNumber
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypolicytableentry.html#cfn-ec2-transitgatewaypolicytableentry-policyrulenumber
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PolicyRuleNumber { get; set; }

        /// <summary>
        /// TransitGatewayPolicyTableId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypolicytableentry.html#cfn-ec2-transitgatewaypolicytableentry-transitgatewaypolicytableid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TransitGatewayPolicyTableId { get; set; }

        /// <summary>
        /// TargetRouteTableId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypolicytableentry.html#cfn-ec2-transitgatewaypolicytableentry-targetroutetableid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TargetRouteTableId { get; set; }
    }

    namespace TransitGatewayPolicyTableEntryTypes
    {
        public class TransitGatewayPolicyRule : Humidifier.Base.BaseSubResource, IHaveProtocol, IHaveDestinationCidrBlock
        {
            /// <summary>
            /// DestinationPortRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewaypolicytableentry-transitgatewaypolicyrule.html#cfn-ec2-transitgatewaypolicytableentry-transitgatewaypolicyrule-destinationportrange
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationPortRange { get; set; }
            /// <summary>
            /// SourcePortRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewaypolicytableentry-transitgatewaypolicyrule.html#cfn-ec2-transitgatewaypolicytableentry-transitgatewaypolicyrule-sourceportrange
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourcePortRange { get; set; }
            /// <summary>
            /// SourceCidrBlock
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewaypolicytableentry-transitgatewaypolicyrule.html#cfn-ec2-transitgatewaypolicytableentry-transitgatewaypolicyrule-sourcecidrblock
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceCidrBlock { get; set; }
            /// <summary>
            /// DestinationCidrBlock
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewaypolicytableentry-transitgatewaypolicyrule.html#cfn-ec2-transitgatewaypolicytableentry-transitgatewaypolicyrule-destinationcidrblock
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationCidrBlock { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewaypolicytableentry-transitgatewaypolicyrule.html#cfn-ec2-transitgatewaypolicytableentry-transitgatewaypolicyrule-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
        }
    }
}