namespace Humidifier.WAF
{
    using global::System.Collections.Generic;
    using XssMatchSetTypes;

    public class XssMatchSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveListOfWAFXssMatchSetTypesXssMatchTupleXssMatchTuples
    {
        public override string AWSTypeName { get => AWS.WAF.XssMatchSet; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// XssMatchTuples
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-xssmatchset.html#cfn-waf-xssmatchset-xssmatchtuples
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: XssMatchTuple
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.WAF.XssMatchSetTypes.XssMatchTuple>, IReadOnlyList<Union<Humidifier.WAF.XssMatchSetTypes.XssMatchTuple, BaseFunction>>, BaseFunction>? XssMatchTuples { get; set; }
    }

    namespace XssMatchSetTypes
    {
        public class FieldToMatch : Humidifier.Base.BaseSubResource, IHaveData, IHaveType
        {
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-xssmatchset-xssmatchtuple-fieldtomatch.html#cfn-waf-xssmatchset-xssmatchtuple-fieldtomatch-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Data { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-xssmatchset-xssmatchtuple-fieldtomatch.html#cfn-waf-xssmatchset-xssmatchtuple-fieldtomatch-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class XssMatchTuple : Humidifier.Base.BaseSubResource, IHaveWAFXssMatchSetTypesFieldToMatchFieldToMatch, IHaveTextTransformation
        {
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-xssmatchset-xssmatchtuple.html#cfn-waf-xssmatchset-xssmatchtuple-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAF.XssMatchSetTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
            /// <summary>
            /// TextTransformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-xssmatchset-xssmatchtuple.html#cfn-waf-xssmatchset-xssmatchtuple-texttransformation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextTransformation { get; set; }
        }
    }
}