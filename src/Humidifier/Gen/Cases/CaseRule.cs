namespace Humidifier.Cases
{
    using global::System.Collections.Generic;
    using CaseRuleTypes;

    public class CaseRule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveDomainId
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string CaseRuleId =  "CaseRuleId" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string CaseRuleArn =  "CaseRuleArn" ;
        }

        public override string AWSTypeName { get => AWS.Cases.CaseRule; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-caserule.html#cfn-cases-caserule-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// DomainId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-caserule.html#cfn-cases-caserule-domainid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DomainId { get; set; }

        /// <summary>
        /// Rule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-caserule.html#cfn-cases-caserule-rule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CaseRuleDetails
        /// </summary>
        [Required]
        public Humidifier.Cases.CaseRuleTypes.CaseRuleDetails Rule { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-caserule.html#cfn-cases-caserule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace CaseRuleTypes
    {
        public class BooleanCondition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NotEqualTo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-caserule-booleancondition.html#cfn-cases-caserule-booleancondition-notequalto
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BooleanOperands
            /// </summary>
            public Humidifier.Cases.CaseRuleTypes.BooleanOperands NotEqualTo { get; set; }
            /// <summary>
            /// EqualTo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-caserule-booleancondition.html#cfn-cases-caserule-booleancondition-equalto
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BooleanOperands
            /// </summary>
            public Humidifier.Cases.CaseRuleTypes.BooleanOperands EqualTo { get; set; }
        }

        public class BooleanOperands : Humidifier.Base.BaseSubResource, IHaveResult
        {
            /// <summary>
            /// OperandTwo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-caserule-booleanoperands.html#cfn-cases-caserule-booleanoperands-operandtwo
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OperandTwo
            /// </summary>
            public Humidifier.Cases.CaseRuleTypes.OperandTwo OperandTwo { get; set; }
            /// <summary>
            /// OperandOne
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-caserule-booleanoperands.html#cfn-cases-caserule-booleanoperands-operandone
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OperandOne
            /// </summary>
            public Humidifier.Cases.CaseRuleTypes.OperandOne OperandOne { get; set; }
            /// <summary>
            /// Result
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-caserule-booleanoperands.html#cfn-cases-caserule-booleanoperands-result
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Result { get; set; }
        }

        public class CaseRuleDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-caserule-caseruledetails.html#cfn-cases-caserule-caseruledetails-required
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RequiredCaseRule
            /// </summary>
            public Humidifier.Cases.CaseRuleTypes.RequiredCaseRule Required { get; set; }
            /// <summary>
            /// Hidden
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-caserule-caseruledetails.html#cfn-cases-caserule-caseruledetails-hidden
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HiddenCaseRule
            /// </summary>
            public Humidifier.Cases.CaseRuleTypes.HiddenCaseRule Hidden { get; set; }
        }

        public class HiddenCaseRule : Humidifier.Base.BaseSubResource, IHaveDefaultValue
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-caserule-hiddencaserule.html#cfn-cases-caserule-hiddencaserule-defaultvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DefaultValue { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-caserule-hiddencaserule.html#cfn-cases-caserule-hiddencaserule-conditions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BooleanCondition
            /// </summary>
            public List<Humidifier.Cases.CaseRuleTypes.BooleanCondition> Conditions { get; set; }
        }

        public class OperandOne : Humidifier.Base.BaseSubResource, IHaveFieldId
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-caserule-operandone.html#cfn-cases-caserule-operandone-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class OperandTwo : Humidifier.Base.BaseSubResource, IHaveStringValue, IHaveDoubleValue, IHaveBooleanValue
        {
            /// <summary>
            /// DoubleValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-caserule-operandtwo.html#cfn-cases-caserule-operandtwo-doublevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DoubleValue { get; set; }
            /// <summary>
            /// BooleanValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-caserule-operandtwo.html#cfn-cases-caserule-operandtwo-booleanvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic BooleanValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-caserule-operandtwo.html#cfn-cases-caserule-operandtwo-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StringValue { get; set; }
            /// <summary>
            /// EmptyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-caserule-operandtwo.html#cfn-cases-caserule-operandtwo-emptyvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic EmptyValue { get; set; }
        }

        public class RequiredCaseRule : Humidifier.Base.BaseSubResource, IHaveDefaultValue
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-caserule-requiredcaserule.html#cfn-cases-caserule-requiredcaserule-defaultvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DefaultValue { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-caserule-requiredcaserule.html#cfn-cases-caserule-requiredcaserule-conditions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BooleanCondition
            /// </summary>
            public List<Humidifier.Cases.CaseRuleTypes.BooleanCondition> Conditions { get; set; }
        }
    }
}