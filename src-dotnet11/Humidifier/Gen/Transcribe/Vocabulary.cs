namespace Humidifier.Transcribe
{
    using global::System.Collections.Generic;

    public class Vocabulary : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveLanguageCode, IHaveVocabularyName, IHaveDataAccessRoleArn, IHaveStringListOfPhrases, IHaveVocabularyFileUri
    {
        public class Attributes
        {
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string VocabularyState =  "VocabularyState" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Transcribe.Vocabulary; }

        /// <summary>
        /// LanguageCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-vocabulary.html#cfn-transcribe-vocabulary-languagecode
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LanguageCode { get; set; }
        public Union<string, BaseFunction>? VocabularyName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DataAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-vocabulary.html#cfn-transcribe-vocabulary-dataaccessrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DataAccessRoleArn { get; set; }
        /// <summary>
        /// Phrases
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-vocabulary.html#cfn-transcribe-vocabulary-phrases
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Phrases { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-vocabulary.html#cfn-transcribe-vocabulary-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// VocabularyFileUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-vocabulary.html#cfn-transcribe-vocabulary-vocabularyfileuri
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VocabularyFileUri { get; set; }
    }
}