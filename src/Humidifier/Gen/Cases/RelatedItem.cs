namespace Humidifier.Cases
{
    using global::System.Collections.Generic;
    using RelatedItemTypes;

    public class RelatedItem : Humidifier.Base.BaseResource, IHaveTags, IHaveType, IHaveDomainId
    {
        public class Attributes
        {
            public static string RelatedItemId =  "RelatedItemId" ;
            public static string RelatedItemArn =  "RelatedItemArn" ;
        }

        public override string AWSTypeName { get => AWS.Cases.RelatedItem; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-relateditem.html#cfn-cases-relateditem-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }

        /// <summary>
        /// DomainId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-relateditem.html#cfn-cases-relateditem-domainid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainId { get; set; }

        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-relateditem.html#cfn-cases-relateditem-content
        /// Required: True
        /// UpdateType: Immutable
        /// Type: RelatedItemContent
        /// </summary>
        [Required]
        public Humidifier.Cases.RelatedItemTypes.RelatedItemContent Content { get; set; }

        /// <summary>
        /// CaseId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-relateditem.html#cfn-cases-relateditem-caseid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CaseId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-relateditem.html#cfn-cases-relateditem-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace RelatedItemTypes
    {
        public class CommentContent : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveBody
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-relateditem-commentcontent.html#cfn-cases-relateditem-commentcontent-contenttype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-relateditem-commentcontent.html#cfn-cases-relateditem-commentcontent-body
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Body { get; set; }
        }

        public class RelatedItemContent : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-relateditem-relateditemcontent.html#cfn-cases-relateditem-relateditemcontent-comment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CommentContent
            /// </summary>
            public Humidifier.Cases.RelatedItemTypes.CommentContent Comment { get; set; }
        }
    }
}