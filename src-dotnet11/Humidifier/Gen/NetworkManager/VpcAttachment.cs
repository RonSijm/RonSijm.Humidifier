namespace Humidifier.NetworkManager
{
    using global::System.Collections.Generic;
    using VpcAttachmentTypes;

    public class VpcAttachment : Humidifier.Base.BaseResource, IHaveTags, IHaveStringListOfSubnetArns, IHaveNetworkManagerVpcAttachmentTypesVpcOptionsOptions, IHaveCoreNetworkId, IHaveRoutingPolicyLabel, IHaveVpcArn
    {
        public class Attributes
        {
            public static string ProposedSegmentChange =  "ProposedSegmentChange" ;
            public static string AttachmentType =  "AttachmentType" ;
            public static string ProposedNetworkFunctionGroupChange =  "ProposedNetworkFunctionGroupChange" ;
            public static string SegmentName =  "SegmentName" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string AttachmentId =  "AttachmentId" ;
            public static string NetworkFunctionGroupName =  "NetworkFunctionGroupName" ;
            public static string CoreNetworkArn =  "CoreNetworkArn" ;
            public static string ResourceArn =  "ResourceArn" ;
            public static string State =  "State" ;
            public static string LastModificationErrors =  "LastModificationErrors" ;
            public static string OwnerAccountId =  "OwnerAccountId" ;
            public static string EdgeLocation =  "EdgeLocation" ;
            public static string AttachmentPolicyRuleNumber =  "AttachmentPolicyRuleNumber" ;
        }

        public override string AWSTypeName { get => AWS.NetworkManager.VpcAttachment; }

        /// <summary>
        /// SubnetArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-subnetarns
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetArns { get; set; }
        /// <summary>
        /// Options
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-options
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcOptions
        /// </summary>
        public Union<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions, BaseFunction>? Options { get; set; }

        /// <summary>
        /// CoreNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-corenetworkid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CoreNetworkId { get; set; }
        /// <summary>
        /// RoutingPolicyLabel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-routingpolicylabel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoutingPolicyLabel { get; set; }

        /// <summary>
        /// VpcArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-vpcarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpcArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace VpcAttachmentTypes
    {
        public class ProposedNetworkFunctionGroupChange : Humidifier.Base.BaseSubResource, IHaveTags, IHaveNetworkFunctionGroupName, IHaveAttachmentPolicyRuleNumber_Integer
        {
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-vpcattachment-proposednetworkfunctiongroupchange-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// NetworkFunctionGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-vpcattachment-proposednetworkfunctiongroupchange-networkfunctiongroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkFunctionGroupName { get; set; }
            /// <summary>
            /// AttachmentPolicyRuleNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-vpcattachment-proposednetworkfunctiongroupchange-attachmentpolicyrulenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AttachmentPolicyRuleNumber { get; set; }
        }

        public class ProposedSegmentChange : Humidifier.Base.BaseSubResource, IHaveTags, IHaveSegmentName, IHaveAttachmentPolicyRuleNumber_Integer
        {
            /// <summary>
            /// SegmentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-proposedsegmentchange.html#cfn-networkmanager-vpcattachment-proposedsegmentchange-segmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentName { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-proposedsegmentchange.html#cfn-networkmanager-vpcattachment-proposedsegmentchange-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// AttachmentPolicyRuleNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-proposedsegmentchange.html#cfn-networkmanager-vpcattachment-proposedsegmentchange-attachmentpolicyrulenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AttachmentPolicyRuleNumber { get; set; }
        }

        public class VpcOptions : Humidifier.Base.BaseSubResource, IHaveIpv6Support_Boolean, IHaveApplianceModeSupport_Boolean, IHaveSecurityGroupReferencingSupport_Boolean, IHaveDnsSupport_Boolean
        {
            /// <summary>
            /// Ipv6Support
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-vpcoptions.html#cfn-networkmanager-vpcattachment-vpcoptions-ipv6support
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Ipv6Support { get; set; }
            /// <summary>
            /// ApplianceModeSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-vpcoptions.html#cfn-networkmanager-vpcattachment-vpcoptions-appliancemodesupport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ApplianceModeSupport { get; set; }
            /// <summary>
            /// SecurityGroupReferencingSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-vpcoptions.html#cfn-networkmanager-vpcattachment-vpcoptions-securitygroupreferencingsupport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SecurityGroupReferencingSupport { get; set; }
            /// <summary>
            /// DnsSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-vpcoptions.html#cfn-networkmanager-vpcattachment-vpcoptions-dnssupport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DnsSupport { get; set; }
        }
    }
}