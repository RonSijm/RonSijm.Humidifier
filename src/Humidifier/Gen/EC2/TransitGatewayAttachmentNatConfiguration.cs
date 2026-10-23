namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using TransitGatewayAttachmentNatConfigurationTypes;

    public class TransitGatewayAttachmentNatConfiguration : Humidifier.Base.BaseResource, IHaveTransitGatewayAttachmentId
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGatewayAttachmentNatConfiguration; }

        /// <summary>
        /// NatGatewaySupport
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachmentnatconfiguration.html#cfn-ec2-transitgatewayattachmentnatconfiguration-natgatewaysupport
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic NatGatewaySupport { get; set; }

        /// <summary>
        /// NatGatewayRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachmentnatconfiguration.html#cfn-ec2-transitgatewayattachmentnatconfiguration-natgatewayrules
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: NatRule
        /// </summary>
        [Required]
        public List<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule> NatGatewayRules { get; set; }

        /// <summary>
        /// TransitGatewayAttachmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachmentnatconfiguration.html#cfn-ec2-transitgatewayattachmentnatconfiguration-transitgatewayattachmentid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TransitGatewayAttachmentId { get; set; }
        /// <summary>
        /// NatSystemRouteSupport
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachmentnatconfiguration.html#cfn-ec2-transitgatewayattachmentnatconfiguration-natsystemroutesupport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NatSystemRouteSupport { get; set; }
    }

    namespace TransitGatewayAttachmentNatConfigurationTypes
    {
        public class NatRule : Humidifier.Base.BaseSubResource, IHaveRuleNumber
        {
            /// <summary>
            /// MatchSourceCidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayattachmentnatconfiguration-natrule.html#cfn-ec2-transitgatewayattachmentnatconfiguration-natrule-matchsourcecidr
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchSourceCidr { get; set; }
            /// <summary>
            /// RuleNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayattachmentnatconfiguration-natrule.html#cfn-ec2-transitgatewayattachmentnatconfiguration-natrule-rulenumber
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RuleNumber { get; set; }
            /// <summary>
            /// NatCidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayattachmentnatconfiguration-natrule.html#cfn-ec2-transitgatewayattachmentnatconfiguration-natrule-natcidr
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NatCidr { get; set; }
        }
    }
}