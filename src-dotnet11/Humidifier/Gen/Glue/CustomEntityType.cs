namespace Humidifier.Glue
{
    using global::System.Collections.Generic;

    public class CustomEntityType : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveStringListOfContextWords, IHaveRegexString, IHaveTags_Json, IHaveName
    {
        public override string AWSTypeName { get => AWS.Glue.CustomEntityType; }
        /// <summary>
        /// ContextWords
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-customentitytype.html#cfn-glue-customentitytype-contextwords
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContextWords { get; set; }
        /// <summary>
        /// RegexString
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-customentitytype.html#cfn-glue-customentitytype-regexstring
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RegexString { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-customentitytype.html#cfn-glue-customentitytype-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}