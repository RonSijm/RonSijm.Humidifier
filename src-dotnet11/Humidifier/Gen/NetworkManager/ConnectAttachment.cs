namespace Humidifier.NetworkManager
{
    using global::System.Collections.Generic;
    using ConnectAttachmentTypes;

    public class ConnectAttachment : Humidifier.Base.BaseResource, IHaveTags, IHaveNetworkManagerConnectAttachmentTypesConnectAttachmentOptionsOptions, IHaveTransportAttachmentId, IHaveCoreNetworkId, IHaveRoutingPolicyLabel, IHaveNetworkFunctionGroupName, IHaveEdgeLocation
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
            public static string CoreNetworkArn =  "CoreNetworkArn" ;
            public static string ResourceArn =  "ResourceArn" ;
            public static string State =  "State" ;
            public static string LastModificationErrors =  "LastModificationErrors" ;
            public static string OwnerAccountId =  "OwnerAccountId" ;
            public static string AttachmentPolicyRuleNumber =  "AttachmentPolicyRuleNumber" ;
        }

        public override string AWSTypeName { get => AWS.NetworkManager.ConnectAttachment; }

        /// <summary>
        /// Options
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectattachment.html#cfn-networkmanager-connectattachment-options
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ConnectAttachmentOptions
        /// </summary>
        [Required]
        public Union<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions, BaseFunction>? Options { get; set; }

        /// <summary>
        /// TransportAttachmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectattachment.html#cfn-networkmanager-connectattachment-transportattachmentid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TransportAttachmentId { get; set; }

        /// <summary>
        /// CoreNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectattachment.html#cfn-networkmanager-connectattachment-corenetworkid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CoreNetworkId { get; set; }
        /// <summary>
        /// RoutingPolicyLabel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectattachment.html#cfn-networkmanager-connectattachment-routingpolicylabel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoutingPolicyLabel { get; set; }
        /// <summary>
        /// NetworkFunctionGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectattachment.html#cfn-networkmanager-connectattachment-networkfunctiongroupname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkFunctionGroupName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectattachment.html#cfn-networkmanager-connectattachment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// EdgeLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectattachment.html#cfn-networkmanager-connectattachment-edgelocation
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EdgeLocation { get; set; }
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
            public Union<string, BaseFunction>? Protocol { get; set; }
        }

        public class ProposedNetworkFunctionGroupChange : Humidifier.Base.BaseSubResource, IHaveTags, IHaveNetworkFunctionGroupName, IHaveAttachmentPolicyRuleNumber_Integer
        {
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-connectattachment-proposednetworkfunctiongroupchange-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// NetworkFunctionGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-connectattachment-proposednetworkfunctiongroupchange-networkfunctiongroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkFunctionGroupName { get; set; }
            /// <summary>
            /// AttachmentPolicyRuleNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-connectattachment-proposednetworkfunctiongroupchange-attachmentpolicyrulenumber
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectattachment-proposedsegmentchange.html#cfn-networkmanager-connectattachment-proposedsegmentchange-segmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentName { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectattachment-proposedsegmentchange.html#cfn-networkmanager-connectattachment-proposedsegmentchange-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// AttachmentPolicyRuleNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectattachment-proposedsegmentchange.html#cfn-networkmanager-connectattachment-proposedsegmentchange-attachmentpolicyrulenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AttachmentPolicyRuleNumber { get; set; }
        }
    }
}