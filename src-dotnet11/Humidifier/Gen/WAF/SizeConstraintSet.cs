namespace Humidifier.WAF
{
    using global::System.Collections.Generic;
    using SizeConstraintSetTypes;

    public class SizeConstraintSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveListOfWAFSizeConstraintSetTypesSizeConstraintSizeConstraints
    {
        public override string AWSTypeName { get => AWS.WAF.SizeConstraintSet; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// SizeConstraints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sizeconstraintset.html#cfn-waf-sizeconstraintset-sizeconstraints
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SizeConstraint
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.WAF.SizeConstraintSetTypes.SizeConstraint>, IReadOnlyList<Union<Humidifier.WAF.SizeConstraintSetTypes.SizeConstraint, BaseFunction>>, BaseFunction>? SizeConstraints { get; set; }
    }

    namespace SizeConstraintSetTypes
    {
        public class FieldToMatch : Humidifier.Base.BaseSubResource, IHaveData, IHaveType
        {
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-sizeconstraintset-sizeconstraint-fieldtomatch.html#cfn-waf-sizeconstraintset-sizeconstraint-fieldtomatch-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Data { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-sizeconstraintset-sizeconstraint-fieldtomatch.html#cfn-waf-sizeconstraintset-sizeconstraint-fieldtomatch-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class SizeConstraint : Humidifier.Base.BaseSubResource, IHaveComparisonOperator, IHaveWAFSizeConstraintSetTypesFieldToMatchFieldToMatch, IHaveSize_Integer, IHaveTextTransformation
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-sizeconstraintset-sizeconstraint.html#cfn-waf-sizeconstraintset-sizeconstraint-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComparisonOperator { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-sizeconstraintset-sizeconstraint.html#cfn-waf-sizeconstraintset-sizeconstraint-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAF.SizeConstraintSetTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-sizeconstraintset-sizeconstraint.html#cfn-waf-sizeconstraintset-sizeconstraint-size
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Size { get; set; }
            /// <summary>
            /// TextTransformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-sizeconstraintset-sizeconstraint.html#cfn-waf-sizeconstraintset-sizeconstraint-texttransformation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextTransformation { get; set; }
        }
    }
}