namespace Humidifier.Wisdom
{
    using global::System.Collections.Generic;

    public class Content : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveOverrideLinkOutUri, IHaveStringDictionaryOfMetadata, IHaveKnowledgeBaseId, IHaveTitle, IHaveUploadId, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ContentArn =  "ContentArn" ;
            public static string ContentType =  "ContentType" ;
            public static string LinkOutUri =  "LinkOutUri" ;
            public static string KnowledgeBaseArn =  "KnowledgeBaseArn" ;
            public static string ContentId =  "ContentId" ;
            public static string RevisionId =  "RevisionId" ;
        }

        public override string AWSTypeName { get => AWS.Wisdom.Content; }
        /// <summary>
        /// OverrideLinkOutUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-content.html#cfn-wisdom-content-overridelinkouturi
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OverrideLinkOutUri { get; set; }
        /// <summary>
        /// Metadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-content.html#cfn-wisdom-content-metadata
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Metadata { get; set; }

        /// <summary>
        /// KnowledgeBaseId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-content.html#cfn-wisdom-content-knowledgebaseid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? KnowledgeBaseId { get; set; }
        /// <summary>
        /// Title
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-content.html#cfn-wisdom-content-title
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Title { get; set; }
        /// <summary>
        /// UploadId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-content.html#cfn-wisdom-content-uploadid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UploadId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-content.html#cfn-wisdom-content-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}