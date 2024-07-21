namespace Humidifier.Connect
{
    using System.Collections.Generic;
    using EvaluationFormTypes;

    public class EvaluationForm : Humidifier.Resource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string EvaluationFormArn =  "EvaluationFormArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Connect::EvaluationForm";
            }
        }

        /// <summary>
        /// ScoringStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-scoringstrategy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ScoringStrategy
        /// </summary>
        public ScoringStrategy ScoringStrategy { get; set; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-status
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Status { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-instancearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceArn { get; set; }
        /// <summary>
        /// Title
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-title
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Title { get; set; }
        /// <summary>
        /// Items
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-items
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EvaluationFormBaseItem
        /// </summary>
        public List<EvaluationFormBaseItem> Items { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace EvaluationFormTypes
    {
        public class EvaluationFormBaseItem
        {
            /// <summary>
            /// Section
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformbaseitem.html#cfn-connect-evaluationform-evaluationformbaseitem-section
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EvaluationFormSection
            /// </summary>
            public EvaluationFormSection Section { get; set; }
        }

        public class EvaluationFormItem
        {
            /// <summary>
            /// Question
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitem.html#cfn-connect-evaluationform-evaluationformitem-question
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormQuestion
            /// </summary>
            public EvaluationFormQuestion Question { get; set; }
            /// <summary>
            /// Section
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitem.html#cfn-connect-evaluationform-evaluationformitem-section
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormSection
            /// </summary>
            public EvaluationFormSection Section { get; set; }
        }

        public class EvaluationFormNumericQuestionAutomation
        {
            /// <summary>
            /// PropertyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionautomation.html#cfn-connect-evaluationform-evaluationformnumericquestionautomation-propertyvalue
            /// Required: True
            /// UpdateType: Mutable
            /// Type: NumericQuestionPropertyValueAutomation
            /// </summary>
            public NumericQuestionPropertyValueAutomation PropertyValue { get; set; }
        }

        public class EvaluationFormNumericQuestionOption
        {
            /// <summary>
            /// Score
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionoption.html#cfn-connect-evaluationform-evaluationformnumericquestionoption-score
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Score { get; set; }
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionoption.html#cfn-connect-evaluationform-evaluationformnumericquestionoption-minvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinValue { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionoption.html#cfn-connect-evaluationform-evaluationformnumericquestionoption-maxvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxValue { get; set; }
            /// <summary>
            /// AutomaticFail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionoption.html#cfn-connect-evaluationform-evaluationformnumericquestionoption-automaticfail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AutomaticFail { get; set; }
        }

        public class EvaluationFormNumericQuestionProperties
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionproperties.html#cfn-connect-evaluationform-evaluationformnumericquestionproperties-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormNumericQuestionOption
            /// </summary>
            public List<EvaluationFormNumericQuestionOption> Options { get; set; }
            /// <summary>
            /// Automation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionproperties.html#cfn-connect-evaluationform-evaluationformnumericquestionproperties-automation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormNumericQuestionAutomation
            /// </summary>
            public EvaluationFormNumericQuestionAutomation Automation { get; set; }
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionproperties.html#cfn-connect-evaluationform-evaluationformnumericquestionproperties-minvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinValue { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionproperties.html#cfn-connect-evaluationform-evaluationformnumericquestionproperties-maxvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxValue { get; set; }
        }

        public class EvaluationFormQuestion
        {
            /// <summary>
            /// NotApplicableEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-notapplicableenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic NotApplicableEnabled { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// QuestionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-questiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QuestionType { get; set; }
            /// <summary>
            /// Instructions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-instructions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Instructions { get; set; }
            /// <summary>
            /// RefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-refid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RefId { get; set; }
            /// <summary>
            /// QuestionTypeProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-questiontypeproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormQuestionTypeProperties
            /// </summary>
            public EvaluationFormQuestionTypeProperties QuestionTypeProperties { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Weight { get; set; }
        }

        public class EvaluationFormQuestionTypeProperties
        {
            /// <summary>
            /// Numeric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestiontypeproperties.html#cfn-connect-evaluationform-evaluationformquestiontypeproperties-numeric
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormNumericQuestionProperties
            /// </summary>
            public EvaluationFormNumericQuestionProperties Numeric { get; set; }
            /// <summary>
            /// SingleSelect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestiontypeproperties.html#cfn-connect-evaluationform-evaluationformquestiontypeproperties-singleselect
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormSingleSelectQuestionProperties
            /// </summary>
            public EvaluationFormSingleSelectQuestionProperties SingleSelect { get; set; }
        }

        public class EvaluationFormSection
        {
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsection.html#cfn-connect-evaluationform-evaluationformsection-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// Instructions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsection.html#cfn-connect-evaluationform-evaluationformsection-instructions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Instructions { get; set; }
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsection.html#cfn-connect-evaluationform-evaluationformsection-items
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormItem
            /// </summary>
            public List<EvaluationFormItem> Items { get; set; }
            /// <summary>
            /// RefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsection.html#cfn-connect-evaluationform-evaluationformsection-refid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RefId { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsection.html#cfn-connect-evaluationform-evaluationformsection-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Weight { get; set; }
        }

        public class EvaluationFormSingleSelectQuestionAutomation
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionautomation.html#cfn-connect-evaluationform-evaluationformsingleselectquestionautomation-options
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormSingleSelectQuestionAutomationOption
            /// </summary>
            public List<EvaluationFormSingleSelectQuestionAutomationOption> Options { get; set; }
            /// <summary>
            /// DefaultOptionRefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionautomation.html#cfn-connect-evaluationform-evaluationformsingleselectquestionautomation-defaultoptionrefid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultOptionRefId { get; set; }
        }

        public class EvaluationFormSingleSelectQuestionAutomationOption
        {
            /// <summary>
            /// RuleCategory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionautomationoption.html#cfn-connect-evaluationform-evaluationformsingleselectquestionautomationoption-rulecategory
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SingleSelectQuestionRuleCategoryAutomation
            /// </summary>
            public SingleSelectQuestionRuleCategoryAutomation RuleCategory { get; set; }
        }

        public class EvaluationFormSingleSelectQuestionOption
        {
            /// <summary>
            /// Score
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionoption.html#cfn-connect-evaluationform-evaluationformsingleselectquestionoption-score
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Score { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionoption.html#cfn-connect-evaluationform-evaluationformsingleselectquestionoption-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
            /// <summary>
            /// RefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionoption.html#cfn-connect-evaluationform-evaluationformsingleselectquestionoption-refid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RefId { get; set; }
            /// <summary>
            /// AutomaticFail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionoption.html#cfn-connect-evaluationform-evaluationformsingleselectquestionoption-automaticfail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AutomaticFail { get; set; }
        }

        public class EvaluationFormSingleSelectQuestionProperties
        {
            /// <summary>
            /// DisplayAs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionproperties.html#cfn-connect-evaluationform-evaluationformsingleselectquestionproperties-displayas
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DisplayAs { get; set; }
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionproperties.html#cfn-connect-evaluationform-evaluationformsingleselectquestionproperties-options
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormSingleSelectQuestionOption
            /// </summary>
            public List<EvaluationFormSingleSelectQuestionOption> Options { get; set; }
            /// <summary>
            /// Automation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionproperties.html#cfn-connect-evaluationform-evaluationformsingleselectquestionproperties-automation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormSingleSelectQuestionAutomation
            /// </summary>
            public EvaluationFormSingleSelectQuestionAutomation Automation { get; set; }
        }

        public class NumericQuestionPropertyValueAutomation
        {
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-numericquestionpropertyvalueautomation.html#cfn-connect-evaluationform-numericquestionpropertyvalueautomation-label
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Label { get; set; }
        }

        public class ScoringStrategy
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-scoringstrategy.html#cfn-connect-evaluationform-scoringstrategy-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-scoringstrategy.html#cfn-connect-evaluationform-scoringstrategy-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
        }

        public class SingleSelectQuestionRuleCategoryAutomation
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-singleselectquestionrulecategoryautomation.html#cfn-connect-evaluationform-singleselectquestionrulecategoryautomation-condition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Condition { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-singleselectquestionrulecategoryautomation.html#cfn-connect-evaluationform-singleselectquestionrulecategoryautomation-category
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Category { get; set; }
            /// <summary>
            /// OptionRefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-singleselectquestionrulecategoryautomation.html#cfn-connect-evaluationform-singleselectquestionrulecategoryautomation-optionrefid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OptionRefId { get; set; }
        }
    }
}