namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using TransitGatewayAttachmentNatConfigurationTypes;

    public class TransitGatewayAttachmentNatConfiguration : Humidifier.Base.BaseResource, IHaveNatGatewaySupport, IHaveListOfEC2TransitGatewayAttachmentNatConfigurationTypesNatRuleNatGatewayRules, IHaveTransitGatewayAttachmentId, IHaveNatSystemRouteSupport
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
        public Union<string, BaseFunction>? NatGatewaySupport { get; set; }

        /// <summary>
        /// NatGatewayRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachmentnatconfiguration.html#cfn-ec2-transitgatewayattachmentnatconfiguration-natgatewayrules
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: NatRule
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule>, IReadOnlyList<Union<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule, BaseFunction>>, BaseFunction>? NatGatewayRules { get; set; }

        /// <summary>
        /// TransitGatewayAttachmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachmentnatconfiguration.html#cfn-ec2-transitgatewayattachmentnatconfiguration-transitgatewayattachmentid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TransitGatewayAttachmentId { get; set; }
        /// <summary>
        /// NatSystemRouteSupport
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachmentnatconfiguration.html#cfn-ec2-transitgatewayattachmentnatconfiguration-natsystemroutesupport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NatSystemRouteSupport { get; set; }
    }

    namespace TransitGatewayAttachmentNatConfigurationTypes
    {
        public class NatRule : Humidifier.Base.BaseSubResource, IHaveMatchSourceCidr, IHaveRuleNumber_Integer, IHaveNatCidr
        {
            /// <summary>
            /// MatchSourceCidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayattachmentnatconfiguration-natrule.html#cfn-ec2-transitgatewayattachmentnatconfiguration-natrule-matchsourcecidr
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchSourceCidr { get; set; }
            /// <summary>
            /// RuleNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayattachmentnatconfiguration-natrule.html#cfn-ec2-transitgatewayattachmentnatconfiguration-natrule-rulenumber
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RuleNumber { get; set; }
            /// <summary>
            /// NatCidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayattachmentnatconfiguration-natrule.html#cfn-ec2-transitgatewayattachmentnatconfiguration-natrule-natcidr
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NatCidr { get; set; }
        }
    }
}