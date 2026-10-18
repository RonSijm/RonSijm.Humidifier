namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using TransitGatewayAttachmentTypes;

    public class TransitGatewayAttachment : Humidifier.Base.BaseResource, IHaveTags, IHaveEC2TransitGatewayAttachmentTypesOptionsOptions, IHaveTransitGatewayId, IHaveVpcId, IHaveStringListOfSubnetIds
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGatewayAttachment; }
        /// <summary>
        /// Options
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachment.html#cfn-ec2-transitgatewayattachment-options
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Options
        /// </summary>
        public Union<Humidifier.EC2.TransitGatewayAttachmentTypes.Options, BaseFunction>? Options { get; set; }

        /// <summary>
        /// TransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachment.html#cfn-ec2-transitgatewayattachment-transitgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TransitGatewayId { get; set; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachment.html#cfn-ec2-transitgatewayattachment-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpcId { get; set; }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachment.html#cfn-ec2-transitgatewayattachment-subnetids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachment.html#cfn-ec2-transitgatewayattachment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TransitGatewayAttachmentTypes
    {
        public class Options : Humidifier.Base.BaseSubResource, IHaveIpv6Support, IHaveApplianceModeSupport, IHaveSecurityGroupReferencingSupport, IHaveDnsSupport
        {
            /// <summary>
            /// Ipv6Support
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayattachment-options.html#cfn-ec2-transitgatewayattachment-options-ipv6support
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ipv6Support { get; set; }
            /// <summary>
            /// ApplianceModeSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayattachment-options.html#cfn-ec2-transitgatewayattachment-options-appliancemodesupport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplianceModeSupport { get; set; }
            /// <summary>
            /// SecurityGroupReferencingSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayattachment-options.html#cfn-ec2-transitgatewayattachment-options-securitygroupreferencingsupport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecurityGroupReferencingSupport { get; set; }
            /// <summary>
            /// DnsSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayattachment-options.html#cfn-ec2-transitgatewayattachment-options-dnssupport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DnsSupport { get; set; }
        }
    }
}