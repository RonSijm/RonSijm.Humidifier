namespace Humidifier.ElementalInference
{
    using global::System.Collections.Generic;

    public class Dictionary : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveLanguage, IHaveEntries, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ElementalInference.Dictionary; }

        /// <summary>
        /// Language
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elementalinference-dictionary.html#cfn-elementalinference-dictionary-language
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Language { get; set; }
        /// <summary>
        /// Entries
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elementalinference-dictionary.html#cfn-elementalinference-dictionary-entries
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Entries { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elementalinference-dictionary.html#cfn-elementalinference-dictionary-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}