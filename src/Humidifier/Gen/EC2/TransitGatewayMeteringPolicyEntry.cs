namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class TransitGatewayMeteringPolicyEntry : Humidifier.Base.BaseResource, IHaveProtocol, IHaveDestinationCidrBlock
    {
        public class Attributes
        {
            public static string UpdateEffectiveAt =  "UpdateEffectiveAt" ;
            public static string State =  "State" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGatewayMeteringPolicyEntry; }
        /// <summary>
        /// DestinationPortRange
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymeteringpolicyentry.html#cfn-ec2-transitgatewaymeteringpolicyentry-destinationportrange
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DestinationPortRange { get; set; }
        /// <summary>
        /// DestinationTransitGatewayAttachmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymeteringpolicyentry.html#cfn-ec2-transitgatewaymeteringpolicyentry-destinationtransitgatewayattachmentid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DestinationTransitGatewayAttachmentId { get; set; }

        /// <summary>
        /// MeteredAccount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymeteringpolicyentry.html#cfn-ec2-transitgatewaymeteringpolicyentry-meteredaccount
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic MeteredAccount { get; set; }
        /// <summary>
        /// SourcePortRange
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymeteringpolicyentry.html#cfn-ec2-transitgatewaymeteringpolicyentry-sourceportrange
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SourcePortRange { get; set; }

        /// <summary>
        /// PolicyRuleNumber
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymeteringpolicyentry.html#cfn-ec2-transitgatewaymeteringpolicyentry-policyrulenumber
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic PolicyRuleNumber { get; set; }
        /// <summary>
        /// DestinationTransitGatewayAttachmentType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymeteringpolicyentry.html#cfn-ec2-transitgatewaymeteringpolicyentry-destinationtransitgatewayattachmenttype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DestinationTransitGatewayAttachmentType { get; set; }
        /// <summary>
        /// SourceCidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymeteringpolicyentry.html#cfn-ec2-transitgatewaymeteringpolicyentry-sourcecidrblock
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SourceCidrBlock { get; set; }
        /// <summary>
        /// DestinationCidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymeteringpolicyentry.html#cfn-ec2-transitgatewaymeteringpolicyentry-destinationcidrblock
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DestinationCidrBlock { get; set; }
        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymeteringpolicyentry.html#cfn-ec2-transitgatewaymeteringpolicyentry-protocol
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Protocol { get; set; }

        /// <summary>
        /// TransitGatewayMeteringPolicyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymeteringpolicyentry.html#cfn-ec2-transitgatewaymeteringpolicyentry-transitgatewaymeteringpolicyid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TransitGatewayMeteringPolicyId { get; set; }
        /// <summary>
        /// SourceTransitGatewayAttachmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymeteringpolicyentry.html#cfn-ec2-transitgatewaymeteringpolicyentry-sourcetransitgatewayattachmentid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SourceTransitGatewayAttachmentId { get; set; }
        /// <summary>
        /// SourceTransitGatewayAttachmentType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymeteringpolicyentry.html#cfn-ec2-transitgatewaymeteringpolicyentry-sourcetransitgatewayattachmenttype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SourceTransitGatewayAttachmentType { get; set; }
    }
}