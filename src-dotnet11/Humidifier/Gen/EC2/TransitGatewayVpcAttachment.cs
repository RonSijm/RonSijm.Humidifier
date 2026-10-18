namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using TransitGatewayVpcAttachmentTypes;

    public class TransitGatewayVpcAttachment : Humidifier.Base.BaseResource, IHaveTags, IHaveEC2TransitGatewayVpcAttachmentTypesOptionsOptions, IHaveTransitGatewayId, IHaveVpcId, IHaveStringListOfRemoveSubnetIds, IHaveStringListOfSubnetIds, IHaveStringListOfAddSubnetIds
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGatewayVpcAttachment; }
        /// <summary>
        /// Options
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayvpcattachment.html#cfn-ec2-transitgatewayvpcattachment-options
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Options
        /// </summary>
        public Union<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options, BaseFunction>? Options { get; set; }

        /// <summary>
        /// TransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayvpcattachment.html#cfn-ec2-transitgatewayvpcattachment-transitgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TransitGatewayId { get; set; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayvpcattachment.html#cfn-ec2-transitgatewayvpcattachment-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpcId { get; set; }
        /// <summary>
        /// RemoveSubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayvpcattachment.html#cfn-ec2-transitgatewayvpcattachment-removesubnetids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RemoveSubnetIds { get; set; }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayvpcattachment.html#cfn-ec2-transitgatewayvpcattachment-subnetids
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        /// <summary>
        /// AddSubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayvpcattachment.html#cfn-ec2-transitgatewayvpcattachment-addsubnetids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AddSubnetIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayvpcattachment.html#cfn-ec2-transitgatewayvpcattachment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TransitGatewayVpcAttachmentTypes
    {
        public class Options : Humidifier.Base.BaseSubResource, IHaveIpv6Support, IHaveApplianceModeSupport, IHaveSecurityGroupReferencingSupport, IHaveDnsSupport
        {
            /// <summary>
            /// Ipv6Support
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayvpcattachment-options.html#cfn-ec2-transitgatewayvpcattachment-options-ipv6support
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ipv6Support { get; set; }
            /// <summary>
            /// ApplianceModeSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayvpcattachment-options.html#cfn-ec2-transitgatewayvpcattachment-options-appliancemodesupport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplianceModeSupport { get; set; }
            /// <summary>
            /// SecurityGroupReferencingSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayvpcattachment-options.html#cfn-ec2-transitgatewayvpcattachment-options-securitygroupreferencingsupport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecurityGroupReferencingSupport { get; set; }
            /// <summary>
            /// DnsSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayvpcattachment-options.html#cfn-ec2-transitgatewayvpcattachment-options-dnssupport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DnsSupport { get; set; }
        }
    }
}