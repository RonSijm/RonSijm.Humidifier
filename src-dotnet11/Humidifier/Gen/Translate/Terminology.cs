namespace Humidifier.Translate
{
    using global::System.Collections.Generic;
    using TerminologyTypes;

    public class Terminology : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveMergeStrategy, IHaveTranslateTerminologyTypesEncryptionKeyEncryptionKey, IHaveTranslateTerminologyTypesTerminologyDataTerminologyData, IHaveListOfTranslateTerminologyTypesTagsItemsTags, IHaveName
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
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// MergeStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-translate-terminology.html#cfn-translate-terminology-mergestrategy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MergeStrategy { get; set; }
        /// <summary>
        /// EncryptionKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-translate-terminology.html#cfn-translate-terminology-encryptionkey
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionKey
        /// </summary>
        public Union<Humidifier.Translate.TerminologyTypes.EncryptionKey, BaseFunction>? EncryptionKey { get; set; }
        /// <summary>
        /// TerminologyData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-translate-terminology.html#cfn-translate-terminology-terminologydata
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TerminologyData
        /// </summary>
        public Union<Humidifier.Translate.TerminologyTypes.TerminologyData, BaseFunction>? TerminologyData { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-translate-terminology.html#cfn-translate-terminology-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Translate.TerminologyTypes.TagsItems>, IReadOnlyList<Union<Humidifier.Translate.TerminologyTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
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
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-terminology-encryptionkey.html#cfn-translate-terminology-encryptionkey-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
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
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-terminology-tagsitems.html#cfn-translate-terminology-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class TerminologyData : Humidifier.Base.BaseSubResource, IHaveDirectionality, IHaveFormat, IHaveFile
        {
            /// <summary>
            /// Directionality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-terminology-terminologydata.html#cfn-translate-terminology-terminologydata-directionality
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Directionality { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-terminology-terminologydata.html#cfn-translate-terminology-terminologydata-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-translate-terminology-terminologydata.html#cfn-translate-terminology-terminologydata-file
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? File { get; set; }
        }
    }
}