namespace Humidifier.Wisdom
{
    using global::System.Collections.Generic;

    public class Content : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveTitle, IHaveKnowledgeBaseId
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
        public dynamic OverrideLinkOutUri { get; set; }
        /// <summary>
        /// Metadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-content.html#cfn-wisdom-content-metadata
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Metadata { get; set; }

        /// <summary>
        /// KnowledgeBaseId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-content.html#cfn-wisdom-content-knowledgebaseid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic KnowledgeBaseId { get; set; }
        /// <summary>
        /// Title
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-content.html#cfn-wisdom-content-title
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Title { get; set; }
        /// <summary>
        /// UploadId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-content.html#cfn-wisdom-content-uploadid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UploadId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-content.html#cfn-wisdom-content-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}