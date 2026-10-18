namespace Humidifier.WAF
{
    using global::System.Collections.Generic;
    using ByteMatchSetTypes;

    public class ByteMatchSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfWAFByteMatchSetTypesByteMatchTupleByteMatchTuples, IHaveName
    {
        public override string AWSTypeName { get => AWS.WAF.ByteMatchSet; }
        /// <summary>
        /// ByteMatchTuples
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-bytematchset.html#cfn-waf-bytematchset-bytematchtuples
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ByteMatchTuple
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WAF.ByteMatchSetTypes.ByteMatchTuple>, IReadOnlyList<Union<Humidifier.WAF.ByteMatchSetTypes.ByteMatchTuple, BaseFunction>>, BaseFunction>? ByteMatchTuples { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ByteMatchSetTypes
    {
        public class ByteMatchTuple : Humidifier.Base.BaseSubResource, IHaveWAFByteMatchSetTypesFieldToMatchFieldToMatch, IHavePositionalConstraint, IHaveTargetString, IHaveTargetStringBase64, IHaveTextTransformation
        {
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples.html#cfn-waf-bytematchset-bytematchtuples-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
            /// <summary>
            /// PositionalConstraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples.html#cfn-waf-bytematchset-bytematchtuples-positionalconstraint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PositionalConstraint { get; set; }
            /// <summary>
            /// TargetString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples.html#cfn-waf-bytematchset-bytematchtuples-targetstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetString { get; set; }
            /// <summary>
            /// TargetStringBase64
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples.html#cfn-waf-bytematchset-bytematchtuples-targetstringbase64
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetStringBase64 { get; set; }
            /// <summary>
            /// TextTransformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples.html#cfn-waf-bytematchset-bytematchtuples-texttransformation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextTransformation { get; set; }
        }

        public class FieldToMatch : Humidifier.Base.BaseSubResource, IHaveData, IHaveType
        {
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples-fieldtomatch.html#cfn-waf-bytematchset-bytematchtuples-fieldtomatch-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Data { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples-fieldtomatch.html#cfn-waf-bytematchset-bytematchtuples-fieldtomatch-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }
    }
}