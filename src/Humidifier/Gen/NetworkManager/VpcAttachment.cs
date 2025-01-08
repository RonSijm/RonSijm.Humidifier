namespace Humidifier.NetworkManager
{
    using System.Collections.Generic;
    using VpcAttachmentTypes;

    public class VpcAttachment : Humidifier.Base.BaseResource, IHaveTags, IHaveCoreNetworkId, IHaveSubnetArns
    {
        public class Attributes
        {
            public static string ResourceArn =  "ResourceArn" ;
            public static string AttachmentType =  "AttachmentType" ;
            public static string SegmentName =  "SegmentName" ;
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string OwnerAccountId =  "OwnerAccountId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string AttachmentId =  "AttachmentId" ;
            public static string NetworkFunctionGroupName =  "NetworkFunctionGroupName" ;
            public static string CoreNetworkArn =  "CoreNetworkArn" ;
            public static string EdgeLocation =  "EdgeLocation" ;
            public static string AttachmentPolicyRuleNumber =  "AttachmentPolicyRuleNumber" ;
        }

        public override string AWSTypeName { get => AWS.NetworkManager.VpcAttachment; }
        /// <summary>
        /// ProposedSegmentChange
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-proposedsegmentchange
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProposedSegmentChange
        /// </summary>
        public Humidifier.NetworkManager.VpcAttachmentTypes.ProposedSegmentChange ProposedSegmentChange { get; set; }

        /// <summary>
        /// SubnetArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-subnetarns
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic SubnetArns { get; set; }
        /// <summary>
        /// Options
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-options
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcOptions
        /// </summary>
        public Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions Options { get; set; }

        /// <summary>
        /// CoreNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-corenetworkid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CoreNetworkId { get; set; }
        /// <summary>
        /// ProposedNetworkFunctionGroupChange
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-proposednetworkfunctiongroupchange
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProposedNetworkFunctionGroupChange
        /// </summary>
        public Humidifier.NetworkManager.VpcAttachmentTypes.ProposedNetworkFunctionGroupChange ProposedNetworkFunctionGroupChange { get; set; }

        /// <summary>
        /// VpcArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-vpcarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic VpcArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace VpcAttachmentTypes
    {
        public class ProposedNetworkFunctionGroupChange : Humidifier.Base.BaseSubResource, IHaveTags, IHaveAttachmentPolicyRuleNumber, IHaveNetworkFunctionGroupName
        {
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-vpcattachment-proposednetworkfunctiongroupchange-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Tag> Tags { get; set; }
            /// <summary>
            /// NetworkFunctionGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-vpcattachment-proposednetworkfunctiongroupchange-networkfunctiongroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NetworkFunctionGroupName { get; set; }
            /// <summary>
            /// AttachmentPolicyRuleNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-vpcattachment-proposednetworkfunctiongroupchange-attachmentpolicyrulenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AttachmentPolicyRuleNumber { get; set; }
        }

        public class ProposedSegmentChange : Humidifier.Base.BaseSubResource, IHaveTags, IHaveAttachmentPolicyRuleNumber, IHaveSegmentName
        {
            /// <summary>
            /// SegmentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-proposedsegmentchange.html#cfn-networkmanager-vpcattachment-proposedsegmentchange-segmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SegmentName { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-proposedsegmentchange.html#cfn-networkmanager-vpcattachment-proposedsegmentchange-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Tag> Tags { get; set; }
            /// <summary>
            /// AttachmentPolicyRuleNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-proposedsegmentchange.html#cfn-networkmanager-vpcattachment-proposedsegmentchange-attachmentpolicyrulenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AttachmentPolicyRuleNumber { get; set; }
        }

        public class VpcOptions : Humidifier.Base.BaseSubResource, IHaveIpv6Support, IHaveApplianceModeSupport
        {
            /// <summary>
            /// Ipv6Support
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-vpcoptions.html#cfn-networkmanager-vpcattachment-vpcoptions-ipv6support
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Ipv6Support { get; set; }
            /// <summary>
            /// ApplianceModeSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-vpcattachment-vpcoptions.html#cfn-networkmanager-vpcattachment-vpcoptions-appliancemodesupport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ApplianceModeSupport { get; set; }
        }
    }
}