namespace Humidifier.NetworkManager
{
    using System.Collections.Generic;
    using VpcAttachmentTypes;

    public class VpcAttachment : Humidifier.Resource, IHaveTags
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
            public static string CoreNetworkArn =  "CoreNetworkArn" ;
            public static string EdgeLocation =  "EdgeLocation" ;
            public static string AttachmentPolicyRuleNumber =  "AttachmentPolicyRuleNumber" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::NetworkManager::VpcAttachment";
            }
        }

        /// <summary>
        /// ProposedSegmentChange
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-proposedsegmentchange
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProposedSegmentChange
        /// </summary>
        public ProposedSegmentChange ProposedSegmentChange { get; set; }
        /// <summary>
        /// SubnetArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-subnetarns
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SubnetArns { get; set; }
        /// <summary>
        /// Options
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-options
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcOptions
        /// </summary>
        public VpcOptions Options { get; set; }
        /// <summary>
        /// CoreNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-corenetworkid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CoreNetworkId { get; set; }
        /// <summary>
        /// VpcArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-vpcattachment.html#cfn-networkmanager-vpcattachment-vpcarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
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
        public class ProposedSegmentChange
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

        public class VpcOptions
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