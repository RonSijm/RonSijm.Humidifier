namespace Humidifier.Transcribe
{
    using global::System.Collections.Generic;

    public class VocabularyFilter : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveLanguageCode, IHaveDataAccessRoleArn, IHaveVocabularyFilterName, IHaveVocabularyFilterFileUri, IHaveStringListOfWords
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Transcribe.VocabularyFilter; }

        /// <summary>
        /// LanguageCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-vocabularyfilter.html#cfn-transcribe-vocabularyfilter-languagecode
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LanguageCode { get; set; }
        /// <summary>
        /// DataAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-vocabularyfilter.html#cfn-transcribe-vocabularyfilter-dataaccessrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DataAccessRoleArn { get; set; }
        public Union<string, BaseFunction>? VocabularyFilterName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// VocabularyFilterFileUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-vocabularyfilter.html#cfn-transcribe-vocabularyfilter-vocabularyfilterfileuri
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VocabularyFilterFileUri { get; set; }
        /// <summary>
        /// Words
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-vocabularyfilter.html#cfn-transcribe-vocabularyfilter-words
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Words { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-vocabularyfilter.html#cfn-transcribe-vocabularyfilter-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}