namespace Humidifier.Kendra
{
    using global::System.Collections.Generic;
    using QuerySuggestionsBlockListTypes;

    public class QuerySuggestionsBlockList : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIndexId, IHaveDescription, IHaveKendraQuerySuggestionsBlockListTypesS3PathSourceS3Path, IHaveRoleArn, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Kendra.QuerySuggestionsBlockList; }

        /// <summary>
        /// IndexId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-querysuggestionsblocklist.html#cfn-kendra-querysuggestionsblocklist-indexid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IndexId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-querysuggestionsblocklist.html#cfn-kendra-querysuggestionsblocklist-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// SourceS3Path
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-querysuggestionsblocklist.html#cfn-kendra-querysuggestionsblocklist-sources3path
        /// Required: True
        /// UpdateType: Mutable
        /// Type: S3Path
        /// </summary>
        [Required]
        public Union<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path, BaseFunction>? SourceS3Path { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-querysuggestionsblocklist.html#cfn-kendra-querysuggestionsblocklist-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-querysuggestionsblocklist.html#cfn-kendra-querysuggestionsblocklist-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace QuerySuggestionsBlockListTypes
    {
        public class S3Path : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-querysuggestionsblocklist-s3path.html#cfn-kendra-querysuggestionsblocklist-s3path-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-querysuggestionsblocklist-s3path.html#cfn-kendra-querysuggestionsblocklist-s3path-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}