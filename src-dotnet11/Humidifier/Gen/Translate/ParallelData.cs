namespace Humidifier.Translate
{
    using global::System.Collections.Generic;
    using ParallelDataTypes;

    public class ParallelData : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveTranslateParallelDataTypesEncryptionKeyEncryptionKey, IHaveTranslateParallelDataTypesParallelDataConfigParallelDataConfig, IHaveListOfTranslateParallelDataTypesTagsItemsTags, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string FailedRecordCount =  "FailedRecordCount" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string ImportedDataSize =  "ImportedDataSize" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ImportedRecordCount =  "ImportedRecordCount" ;
            public static string Arn =  "Arn" ;
            public static string TargetLanguageCodes =  "TargetLanguageCodes" ;
            public static string SkippedRecordCount =  "SkippedRecordCount" ;
            public static string SourceLanguageCode =  "SourceLanguageCode" ;
        }

        public override string AWSTypeName { get => AWS.Translate.ParallelData; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-translate-paralleldata.html#cfn-translate-paralleldata-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// EncryptionKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-translate-paralleldata.html#cfn-translate-paralleldata-encryptionkey
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionKey
        /// </summary>
        public Union<Humidifier.Translate.ParallelDataTypes.EncryptionKey, BaseFunction>? EncryptionKey { get; set; }

        /// <summary>
        /// ParallelDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-translate-paralleldata.html#cfn-translate-paralleldata-paralleldataconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ParallelDataConfig
        /// </summary>
        [Required]
        public Union<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig, BaseFunction>? ParallelDataConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-translate-paralleldata.html#cfn-translate-paralleldata-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Translate.ParallelDataTypes.TagsItems>, IReadOnlyList<Union<Humidifier.Translate.ParallelDataTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ParallelDataTypes
    {
        public class EncryptionKey : Humidifier.Base.BaseSubResource, IHaveType, IHaveId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-paralleldata-encryptionkey.html#cfn-translate-paralleldata-encryptionkey-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-paralleldata-encryptionkey.html#cfn-translate-paralleldata-encryptionkey-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class ParallelDataConfig : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveS3Uri
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-paralleldata-paralleldataconfig.html#cfn-translate-paralleldata-paralleldataconfig-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-paralleldata-paralleldataconfig.html#cfn-translate-paralleldata-paralleldataconfig-s3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-paralleldata-tagsitems.html#cfn-translate-paralleldata-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-paralleldata-tagsitems.html#cfn-translate-paralleldata-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}