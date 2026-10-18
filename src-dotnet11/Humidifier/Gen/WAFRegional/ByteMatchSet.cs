namespace Humidifier.WAFRegional
{
    using global::System.Collections.Generic;
    using ByteMatchSetTypes;

    public class ByteMatchSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfWAFRegionalByteMatchSetTypesByteMatchTupleByteMatchTuples, IHaveName
    {
        public override string AWSTypeName { get => AWS.WAFRegional.ByteMatchSet; }
        /// <summary>
        /// ByteMatchTuples
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-bytematchset.html#cfn-wafregional-bytematchset-bytematchtuples
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ByteMatchTuple
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WAFRegional.ByteMatchSetTypes.ByteMatchTuple>, IReadOnlyList<Union<Humidifier.WAFRegional.ByteMatchSetTypes.ByteMatchTuple, BaseFunction>>, BaseFunction>? ByteMatchTuples { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ByteMatchSetTypes
    {
        public class ByteMatchTuple : Humidifier.Base.BaseSubResource, IHaveTargetString, IHaveTargetStringBase64, IHavePositionalConstraint, IHaveTextTransformation, IHaveWAFRegionalByteMatchSetTypesFieldToMatchFieldToMatch
        {
            /// <summary>
            /// TargetString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-targetstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetString { get; set; }
            /// <summary>
            /// TargetStringBase64
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-targetstringbase64
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetStringBase64 { get; set; }
            /// <summary>
            /// PositionalConstraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-positionalconstraint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PositionalConstraint { get; set; }
            /// <summary>
            /// TextTransformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-texttransformation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextTransformation { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAFRegional.ByteMatchSetTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
        }

        public class FieldToMatch : Humidifier.Base.BaseSubResource, IHaveType, IHaveData
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-fieldtomatch.html#cfn-wafregional-bytematchset-fieldtomatch-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-fieldtomatch.html#cfn-wafregional-bytematchset-fieldtomatch-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Data { get; set; }
        }
    }
}