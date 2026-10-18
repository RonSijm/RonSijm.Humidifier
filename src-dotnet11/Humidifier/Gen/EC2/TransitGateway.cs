namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class TransitGateway : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveAssociationDefaultRouteTableId, IHaveAutoAcceptSharedAttachments, IHaveDefaultRouteTablePropagation, IHaveStringListOfTransitGatewayCidrBlocks, IHavePropagationDefaultRouteTableId, IHaveDefaultRouteTableAssociation, IHaveVpnEcmpSupport, IHaveSecurityGroupReferencingSupport, IHaveDnsSupport, IHaveMulticastSupport, IHaveAmazonSideAsn_Long, IHaveEncryptionSupport
    {
        public class Attributes
        {
            public static string EncryptionSupportState =  "EncryptionSupportState" ;
            public static string TransitGatewayArn =  "TransitGatewayArn" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGateway; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// AssociationDefaultRouteTableId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-associationdefaultroutetableid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AssociationDefaultRouteTableId { get; set; }
        /// <summary>
        /// AutoAcceptSharedAttachments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-autoacceptsharedattachments
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AutoAcceptSharedAttachments { get; set; }
        /// <summary>
        /// DefaultRouteTablePropagation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-defaultroutetablepropagation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultRouteTablePropagation { get; set; }
        /// <summary>
        /// TransitGatewayCidrBlocks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-transitgatewaycidrblocks
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TransitGatewayCidrBlocks { get; set; }
        /// <summary>
        /// PropagationDefaultRouteTableId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-propagationdefaultroutetableid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PropagationDefaultRouteTableId { get; set; }
        /// <summary>
        /// DefaultRouteTableAssociation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-defaultroutetableassociation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultRouteTableAssociation { get; set; }
        /// <summary>
        /// VpnEcmpSupport
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-vpnecmpsupport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpnEcmpSupport { get; set; }
        /// <summary>
        /// SecurityGroupReferencingSupport
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-securitygroupreferencingsupport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SecurityGroupReferencingSupport { get; set; }
        /// <summary>
        /// DnsSupport
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-dnssupport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DnsSupport { get; set; }
        /// <summary>
        /// MulticastSupport
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-multicastsupport
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MulticastSupport { get; set; }
        /// <summary>
        /// AmazonSideAsn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-amazonsideasn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Long
        /// </summary>
        public Union<long, BaseFunction>? AmazonSideAsn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// EncryptionSupport
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-encryptionsupport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EncryptionSupport { get; set; }
    }
}