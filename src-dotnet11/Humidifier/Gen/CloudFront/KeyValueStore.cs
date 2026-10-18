namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using KeyValueStoreTypes;

    public class KeyValueStore : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveComment, IHaveCloudFrontKeyValueStoreTypesImportSourceImportSource, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.KeyValueStore; }
        /// <summary>
        /// Comment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-keyvaluestore.html#cfn-cloudfront-keyvaluestore-comment
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Comment { get; set; }
        /// <summary>
        /// ImportSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-keyvaluestore.html#cfn-cloudfront-keyvaluestore-importsource
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ImportSource
        /// </summary>
        public Union<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource, BaseFunction>? ImportSource { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-keyvaluestore.html#cfn-cloudfront-keyvaluestore-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace KeyValueStoreTypes
    {
        public class ImportSource : Humidifier.Base.BaseSubResource, IHaveSourceArn, IHaveSourceType
        {
            /// <summary>
            /// SourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-keyvaluestore-importsource.html#cfn-cloudfront-keyvaluestore-importsource-sourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceArn { get; set; }
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-keyvaluestore-importsource.html#cfn-cloudfront-keyvaluestore-importsource-sourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceType { get; set; }
        }
    }
}