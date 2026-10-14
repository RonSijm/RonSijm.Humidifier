namespace Humidifier.Connect
{
    using global::System.Collections.Generic;

    public class Vocabulary : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveContent, IHaveInstanceId, IHaveLanguageCode
    {
        public class Attributes
        {
            public static string VocabularyId =  "VocabularyId" ;
            public static string State =  "State" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Connect.Vocabulary; }

        /// <summary>
        /// LanguageCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-vocabulary.html#cfn-connect-vocabulary-languagecode
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LanguageCode { get; set; }
        public dynamic VocabularyName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-vocabulary.html#cfn-connect-vocabulary-instanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceId { get; set; }

        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-vocabulary.html#cfn-connect-vocabulary-content
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Content { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-vocabulary.html#cfn-connect-vocabulary-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}