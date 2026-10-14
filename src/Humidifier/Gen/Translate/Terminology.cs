namespace Humidifier.Translate
{
    using global::System.Collections.Generic;
    using TerminologyTypes;

    public class Terminology : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription
    {
        public class Attributes
        {
            public static string Directionality =  "Directionality" ;
            public static string Format =  "Format" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string TermCount =  "TermCount" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string SizeBytes =  "SizeBytes" ;
            public static string TargetLanguageCodes =  "TargetLanguageCodes" ;
            public static string SourceLanguageCode =  "SourceLanguageCode" ;
        }

        public override string AWSTypeName { get => AWS.Translate.Terminology; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-translate-terminology.html#cfn-translate-terminology-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// MergeStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-translate-terminology.html#cfn-translate-terminology-mergestrategy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MergeStrategy { get; set; }
        /// <summary>
        /// EncryptionKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-translate-terminology.html#cfn-translate-terminology-encryptionkey
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionKey
        /// </summary>
        public Humidifier.Translate.TerminologyTypes.EncryptionKey EncryptionKey { get; set; }
        /// <summary>
        /// TerminologyData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-translate-terminology.html#cfn-translate-terminology-terminologydata
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TerminologyData
        /// </summary>
        public Humidifier.Translate.TerminologyTypes.TerminologyData TerminologyData { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-translate-terminology.html#cfn-translate-terminology-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public List<Humidifier.Translate.TerminologyTypes.TagsItems> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace TerminologyTypes
    {
        public class EncryptionKey : Humidifier.Base.BaseSubResource, IHaveType, IHaveId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-terminology-encryptionkey.html#cfn-translate-terminology-encryptionkey-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-terminology-encryptionkey.html#cfn-translate-terminology-encryptionkey-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-terminology-tagsitems.html#cfn-translate-terminology-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-terminology-tagsitems.html#cfn-translate-terminology-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class TerminologyData : Humidifier.Base.BaseSubResource, IHaveFormat
        {
            /// <summary>
            /// Directionality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-terminology-terminologydata.html#cfn-translate-terminology-terminologydata-directionality
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Directionality { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-terminology-terminologydata.html#cfn-translate-terminology-terminologydata-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-terminology-terminologydata.html#cfn-translate-terminology-terminologydata-file
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic File { get; set; }
        }
    }
}