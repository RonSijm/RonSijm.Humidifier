namespace Humidifier.WAFRegional
{
    using System.Collections.Generic;
    using XssMatchSetTypes;

    public class XssMatchSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName
    {
        public override string AWSTypeName { get => AWS.WAFRegional.XssMatchSet; }
        /// <summary>
        /// XssMatchTuples
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-xssmatchset.html#cfn-wafregional-xssmatchset-xssmatchtuples
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: XssMatchTuple
        /// </summary>
        public List<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple> XssMatchTuples { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace XssMatchSetTypes
    {
        public class FieldToMatch : Humidifier.Base.BaseSubResource, IHaveType, IHaveData
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-fieldtomatch.html#cfn-wafregional-xssmatchset-fieldtomatch-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-fieldtomatch.html#cfn-wafregional-xssmatchset-fieldtomatch-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Data { get; set; }
        }

        public class XssMatchTuple : Humidifier.Base.BaseSubResource, IHaveTextTransformation
        {
            /// <summary>
            /// TextTransformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-xssmatchtuple.html#cfn-wafregional-xssmatchset-xssmatchtuple-texttransformation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TextTransformation { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-xssmatchtuple.html#cfn-wafregional-xssmatchset-xssmatchtuple-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch FieldToMatch { get; set; }
        }
    }
}