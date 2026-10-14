namespace Humidifier.Translate
{
    using global::System.Collections.Generic;
    using ParallelDataTypes;

    public class ParallelData : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription
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
        public dynamic Description { get; set; }
        /// <summary>
        /// EncryptionKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-translate-paralleldata.html#cfn-translate-paralleldata-encryptionkey
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionKey
        /// </summary>
        public Humidifier.Translate.ParallelDataTypes.EncryptionKey EncryptionKey { get; set; }

        /// <summary>
        /// ParallelDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-translate-paralleldata.html#cfn-translate-paralleldata-paralleldataconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ParallelDataConfig
        /// </summary>
        [Required]
        public Humidifier.Translate.ParallelDataTypes.ParallelDataConfig ParallelDataConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-translate-paralleldata.html#cfn-translate-paralleldata-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public List<Humidifier.Translate.ParallelDataTypes.TagsItems> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
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
            public dynamic Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-paralleldata-encryptionkey.html#cfn-translate-paralleldata-encryptionkey-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }

        public class ParallelDataConfig : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveFormat
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-paralleldata-paralleldataconfig.html#cfn-translate-paralleldata-paralleldataconfig-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-paralleldata-paralleldataconfig.html#cfn-translate-paralleldata-paralleldataconfig-s3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
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
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-paralleldata-tagsitems.html#cfn-translate-paralleldata-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}