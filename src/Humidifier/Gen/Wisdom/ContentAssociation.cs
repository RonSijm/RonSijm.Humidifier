namespace Humidifier.Wisdom
{
    using global::System.Collections.Generic;
    using ContentAssociationTypes;

    public class ContentAssociation : Humidifier.Base.BaseResource, IHaveTags, IHaveKnowledgeBaseId, IHaveAssociationType
    {
        public class Attributes
        {
            public static string ContentArn =  "ContentArn" ;
            public static string KnowledgeBaseArn =  "KnowledgeBaseArn" ;
            public static string ContentAssociationId =  "ContentAssociationId" ;
            public static string ContentAssociationArn =  "ContentAssociationArn" ;
        }

        public override string AWSTypeName { get => AWS.Wisdom.ContentAssociation; }

        /// <summary>
        /// Association
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-contentassociation.html#cfn-wisdom-contentassociation-association
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ContentAssociationContents
        /// </summary>
        [Required]
        public Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents Association { get; set; }

        /// <summary>
        /// AssociationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-contentassociation.html#cfn-wisdom-contentassociation-associationtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AssociationType { get; set; }

        /// <summary>
        /// KnowledgeBaseId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-contentassociation.html#cfn-wisdom-contentassociation-knowledgebaseid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic KnowledgeBaseId { get; set; }

        /// <summary>
        /// ContentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-contentassociation.html#cfn-wisdom-contentassociation-contentid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ContentId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-contentassociation.html#cfn-wisdom-contentassociation-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ContentAssociationTypes
    {
        public class AmazonConnectGuideAssociationData : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FlowId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-contentassociation-amazonconnectguideassociationdata.html#cfn-wisdom-contentassociation-amazonconnectguideassociationdata-flowid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FlowId { get; set; }
        }

        public class ContentAssociationContents : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AmazonConnectGuideAssociation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-contentassociation-contentassociationcontents.html#cfn-wisdom-contentassociation-contentassociationcontents-amazonconnectguideassociation
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AmazonConnectGuideAssociationData
            /// </summary>
            public Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData AmazonConnectGuideAssociation { get; set; }
        }
    }
}