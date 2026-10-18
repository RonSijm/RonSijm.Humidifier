namespace Humidifier.Cases
{
    using global::System.Collections.Generic;
    using RelatedItemTypes;

    public class RelatedItem : Humidifier.Base.BaseResource, IHaveTags, IHaveType, IHaveDomainId, IHaveCasesRelatedItemTypesRelatedItemContentContent, IHaveCaseId
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
        public Union<string, BaseFunction>? Type { get; set; }

        /// <summary>
        /// DomainId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-relateditem.html#cfn-cases-relateditem-domainid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainId { get; set; }

        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-relateditem.html#cfn-cases-relateditem-content
        /// Required: True
        /// UpdateType: Immutable
        /// Type: RelatedItemContent
        /// </summary>
        [Required]
        public Union<Humidifier.Cases.RelatedItemTypes.RelatedItemContent, BaseFunction>? Content { get; set; }

        /// <summary>
        /// CaseId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-relateditem.html#cfn-cases-relateditem-caseid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CaseId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-relateditem.html#cfn-cases-relateditem-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
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
            public Union<string, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-relateditem-commentcontent.html#cfn-cases-relateditem-commentcontent-body
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Body { get; set; }
        }

        public class RelatedItemContent : Humidifier.Base.BaseSubResource, IHaveCasesRelatedItemTypesCommentContentComment
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-relateditem-relateditemcontent.html#cfn-cases-relateditem-relateditemcontent-comment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CommentContent
            /// </summary>
            public Union<Humidifier.Cases.RelatedItemTypes.CommentContent, BaseFunction>? Comment { get; set; }
        }
    }
}