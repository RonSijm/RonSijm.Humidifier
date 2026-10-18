namespace Humidifier.NetworkManager
{
    using global::System.Collections.Generic;
    using DirectConnectGatewayAttachmentTypes;

    public class DirectConnectGatewayAttachment : Humidifier.Base.BaseResource, IHaveTags, IHaveCoreNetworkId, IHaveStringListOfEdgeLocations, IHaveDirectConnectGatewayArn, IHaveRoutingPolicyLabel
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
            public static string AttachmentPolicyRuleNumber =  "AttachmentPolicyRuleNumber" ;
        }

        public override string AWSTypeName { get => AWS.NetworkManager.DirectConnectGatewayAttachment; }

        /// <summary>
        /// CoreNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-directconnectgatewayattachment.html#cfn-networkmanager-directconnectgatewayattachment-corenetworkid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CoreNetworkId { get; set; }

        /// <summary>
        /// EdgeLocations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-directconnectgatewayattachment.html#cfn-networkmanager-directconnectgatewayattachment-edgelocations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EdgeLocations { get; set; }

        /// <summary>
        /// DirectConnectGatewayArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-directconnectgatewayattachment.html#cfn-networkmanager-directconnectgatewayattachment-directconnectgatewayarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DirectConnectGatewayArn { get; set; }
        /// <summary>
        /// RoutingPolicyLabel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-directconnectgatewayattachment.html#cfn-networkmanager-directconnectgatewayattachment-routingpolicylabel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoutingPolicyLabel { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-directconnectgatewayattachment.html#cfn-networkmanager-directconnectgatewayattachment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DirectConnectGatewayAttachmentTypes
    {
        public class ProposedNetworkFunctionGroupChange : Humidifier.Base.BaseSubResource, IHaveTags, IHaveNetworkFunctionGroupName, IHaveAttachmentPolicyRuleNumber_Integer
        {
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-directconnectgatewayattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-directconnectgatewayattachment-proposednetworkfunctiongroupchange-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// NetworkFunctionGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-directconnectgatewayattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-directconnectgatewayattachment-proposednetworkfunctiongroupchange-networkfunctiongroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkFunctionGroupName { get; set; }
            /// <summary>
            /// AttachmentPolicyRuleNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-directconnectgatewayattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-directconnectgatewayattachment-proposednetworkfunctiongroupchange-attachmentpolicyrulenumber
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-directconnectgatewayattachment-proposedsegmentchange.html#cfn-networkmanager-directconnectgatewayattachment-proposedsegmentchange-segmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentName { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-directconnectgatewayattachment-proposedsegmentchange.html#cfn-networkmanager-directconnectgatewayattachment-proposedsegmentchange-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// AttachmentPolicyRuleNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-directconnectgatewayattachment-proposedsegmentchange.html#cfn-networkmanager-directconnectgatewayattachment-proposedsegmentchange-attachmentpolicyrulenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AttachmentPolicyRuleNumber { get; set; }
        }
    }
}