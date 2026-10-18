namespace Humidifier.NetworkManager
{
    using global::System.Collections.Generic;
    using TransitGatewayRouteTableAttachmentTypes;

    public class TransitGatewayRouteTableAttachment : Humidifier.Base.BaseResource, IHaveTags, IHaveTransitGatewayRouteTableArn, IHavePeeringId, IHaveRoutingPolicyLabel, IHaveNetworkFunctionGroupName
    {
        public class Attributes
        {
            public static string ProposedSegmentChange =  "ProposedSegmentChange" ;
            public static string CoreNetworkId =  "CoreNetworkId" ;
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
            public static string EdgeLocation =  "EdgeLocation" ;
            public static string AttachmentPolicyRuleNumber =  "AttachmentPolicyRuleNumber" ;
        }

        public override string AWSTypeName { get => AWS.NetworkManager.TransitGatewayRouteTableAttachment; }

        /// <summary>
        /// TransitGatewayRouteTableArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-transitgatewayroutetableattachment.html#cfn-networkmanager-transitgatewayroutetableattachment-transitgatewayroutetablearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TransitGatewayRouteTableArn { get; set; }

        /// <summary>
        /// PeeringId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-transitgatewayroutetableattachment.html#cfn-networkmanager-transitgatewayroutetableattachment-peeringid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PeeringId { get; set; }
        /// <summary>
        /// RoutingPolicyLabel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-transitgatewayroutetableattachment.html#cfn-networkmanager-transitgatewayroutetableattachment-routingpolicylabel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoutingPolicyLabel { get; set; }
        /// <summary>
        /// NetworkFunctionGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-transitgatewayroutetableattachment.html#cfn-networkmanager-transitgatewayroutetableattachment-networkfunctiongroupname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkFunctionGroupName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-transitgatewayroutetableattachment.html#cfn-networkmanager-transitgatewayroutetableattachment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TransitGatewayRouteTableAttachmentTypes
    {
        public class ProposedNetworkFunctionGroupChange : Humidifier.Base.BaseSubResource, IHaveTags, IHaveNetworkFunctionGroupName, IHaveAttachmentPolicyRuleNumber_Integer
        {
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-transitgatewayroutetableattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-transitgatewayroutetableattachment-proposednetworkfunctiongroupchange-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// NetworkFunctionGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-transitgatewayroutetableattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-transitgatewayroutetableattachment-proposednetworkfunctiongroupchange-networkfunctiongroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkFunctionGroupName { get; set; }
            /// <summary>
            /// AttachmentPolicyRuleNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-transitgatewayroutetableattachment-proposednetworkfunctiongroupchange.html#cfn-networkmanager-transitgatewayroutetableattachment-proposednetworkfunctiongroupchange-attachmentpolicyrulenumber
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-transitgatewayroutetableattachment-proposedsegmentchange.html#cfn-networkmanager-transitgatewayroutetableattachment-proposedsegmentchange-segmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentName { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-transitgatewayroutetableattachment-proposedsegmentchange.html#cfn-networkmanager-transitgatewayroutetableattachment-proposedsegmentchange-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// AttachmentPolicyRuleNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-transitgatewayroutetableattachment-proposedsegmentchange.html#cfn-networkmanager-transitgatewayroutetableattachment-proposedsegmentchange-attachmentpolicyrulenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AttachmentPolicyRuleNumber { get; set; }
        }
    }
}