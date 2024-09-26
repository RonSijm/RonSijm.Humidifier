namespace Humidifier.WAF
{
    using System.Collections.Generic;
    using XssMatchSetTypes;

    public class XssMatchSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName
    {
        public override string AWSTypeName { get => AWS.WAF.XssMatchSet; }
        public dynamic Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// XssMatchTuples
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-xssmatchset.html#cfn-waf-xssmatchset-xssmatchtuples
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: XssMatchTuple
        /// </summary>
        [Required]
        public List<Humidifier.WAF.XssMatchSetTypes.XssMatchTuple> XssMatchTuples { get; set; }
    }

    namespace XssMatchSetTypes
    {
        public class FieldToMatch : Humidifier.Base.BaseSubResource, IHaveType, IHaveData
        {
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-xssmatchset-xssmatchtuple-fieldtomatch.html#cfn-waf-xssmatchset-xssmatchtuple-fieldtomatch-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Data { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-xssmatchset-xssmatchtuple-fieldtomatch.html#cfn-waf-xssmatchset-xssmatchtuple-fieldtomatch-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class XssMatchTuple : Humidifier.Base.BaseSubResource, IHaveTextTransformation
        {
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-xssmatchset-xssmatchtuple.html#cfn-waf-xssmatchset-xssmatchtuple-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Humidifier.WAF.XssMatchSetTypes.FieldToMatch FieldToMatch { get; set; }
            /// <summary>
            /// TextTransformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-xssmatchset-xssmatchtuple.html#cfn-waf-xssmatchset-xssmatchtuple-texttransformation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TextTransformation { get; set; }
        }
    }
}