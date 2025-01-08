namespace Humidifier.NetworkManager
{
    using System.Collections.Generic;
    using ConnectAttachmentTypes;

    public class ConnectAttachment : Humidifier.Base.BaseResource, IHaveTags, IHaveNetworkFunctionGroupName, IHaveCoreNetworkId, IHaveEdgeLocation
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
            public static string AttachmentPolicyRuleNumber =  "AttachmentPolicyRuleNumber" ;
        }

        public override string AWSTypeName { get => AWS.NetworkManager.ConnectAttachment; }
        /// <summary>
        /// ProposedSegmentChange
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectattachment.html#cfn-networkmanager-connectattachment-proposedsegmentchange
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProposedSegmentChange
        /// </summary>
        public Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange ProposedSegmentChange { get; set; }

        /// <summary>
        /// Options
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectattachment.html#cfn-networkmanager-connectattachment-options
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ConnectAttachmentOptions
        /// </summary>
        [Required]
        public Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions Options { get; set; }

        /// <summary>
        /// TransportAttachmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectattachment.html#cfn-networkmanager-connectattachment-transportattachmentid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TransportAttachmentId { get; set; }

        /// <summary>
        /// CoreNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectattachment.html#cfn-networkmanager-connectattachment-corenetworkid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CoreNetworkId { get; set; }
        /// <summary>
        /// ProposedNetworkFunctionGroupChange
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectattachment.html#cfn-networkmanager-connectattachment-proposednetworkfunctiongroupchange
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProposedNetworkFunctionGroupChange
        /// </summary>
        public Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange ProposedNetworkFunctionGroupChange { get; set; }
        /// <summary>
        /// NetworkFunctionGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectattachment.html#cfn-networkmanager-connectattachment-networkfunctiongroupname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NetworkFunctionGroupName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectattachment.html#cfn-networkmanager-connectattachment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// EdgeLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectattachment.html#cfn-networkmanager-connectattachment-edgelocation
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EdgeLocation { get; set; }
    }

    namespace ConnectAttachmentTypes
    {
        public class ConnectAttachmentOptions : Humidifier.Base.BaseSubResource, IHaveProtocol
        {
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectattachment-connectattachmentoptions.html#cfn-networkmanager-connectattachment-connectattachmentoptions-protocol
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
        }

        public class ProposedNetworkFunctionGroupChange : Humidifier.Base.BaseSubResource, IHaveTags, IHaveAttachmentPolicyRuleNumber, IHaveNetworkFunctionGroupName
        {
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-connectattachment-proposednetworkfunctiongroupchange-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Tag> Tags { get; set; }
            /// <summary>
            /// NetworkFunctionGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-connectattachment-proposednetworkfunctiongroupchange-networkfunctiongroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NetworkFunctionGroupName { get; set; }
            /// <summary>
            /// AttachmentPolicyRuleNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-connectattachment-proposednetworkfunctiongroupchange-attachmentpolicyrulenumber
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectattachment-proposedsegmentchange.html#cfn-networkmanager-connectattachment-proposedsegmentchange-segmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SegmentName { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectattachment-proposedsegmentchange.html#cfn-networkmanager-connectattachment-proposedsegmentchange-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Tag> Tags { get; set; }
            /// <summary>
            /// AttachmentPolicyRuleNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectattachment-proposedsegmentchange.html#cfn-networkmanager-connectattachment-proposedsegmentchange-attachmentpolicyrulenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AttachmentPolicyRuleNumber { get; set; }
        }
    }
}