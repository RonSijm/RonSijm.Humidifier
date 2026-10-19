namespace Humidifier.Polly
{
    using global::System.Collections.Generic;

    public class Lexicon : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveContent, IHaveName
    {
        public class Attributes
        {
            public static string Alphabet =  "Alphabet" ;
            public static string LastModified =  "LastModified" ;
            public static string LanguageCode =  "LanguageCode" ;
            public static string LexemesCount =  "LexemesCount" ;
            public static string Size =  "Size" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Polly.Lexicon; }

        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-polly-lexicon.html#cfn-polly-lexicon-content
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Content { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}