namespace Humidifier.WAFRegional
{
    using global::System.Collections.Generic;
    using SizeConstraintSetTypes;

    public class SizeConstraintSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfWAFRegionalSizeConstraintSetTypesSizeConstraintSizeConstraints, IHaveName
    {
        public override string AWSTypeName { get => AWS.WAFRegional.SizeConstraintSet; }
        /// <summary>
        /// SizeConstraints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-sizeconstraintset.html#cfn-wafregional-sizeconstraintset-sizeconstraints
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SizeConstraint
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WAFRegional.SizeConstraintSetTypes.SizeConstraint>, IReadOnlyList<Union<Humidifier.WAFRegional.SizeConstraintSetTypes.SizeConstraint, BaseFunction>>, BaseFunction>? SizeConstraints { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SizeConstraintSetTypes
    {
        public class FieldToMatch : Humidifier.Base.BaseSubResource, IHaveType, IHaveData
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-fieldtomatch.html#cfn-wafregional-sizeconstraintset-fieldtomatch-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-fieldtomatch.html#cfn-wafregional-sizeconstraintset-fieldtomatch-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Data { get; set; }
        }

        public class SizeConstraint : Humidifier.Base.BaseSubResource, IHaveComparisonOperator, IHaveSize_Integer, IHaveTextTransformation, IHaveWAFRegionalSizeConstraintSetTypesFieldToMatchFieldToMatch
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-sizeconstraint.html#cfn-wafregional-sizeconstraintset-sizeconstraint-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComparisonOperator { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-sizeconstraint.html#cfn-wafregional-sizeconstraintset-sizeconstraint-size
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Size { get; set; }
            /// <summary>
            /// TextTransformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-sizeconstraint.html#cfn-wafregional-sizeconstraintset-sizeconstraint-texttransformation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextTransformation { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-sizeconstraint.html#cfn-wafregional-sizeconstraintset-sizeconstraint-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
        }
    }
}