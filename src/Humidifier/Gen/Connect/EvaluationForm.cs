namespace Humidifier.Connect
{
    using System.Collections.Generic;
    using EvaluationFormTypes;

    public class EvaluationForm : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveStatus, IHaveTitle, IHaveInstanceArn
    {
        public class Attributes
        {
            public static string EvaluationFormArn =  "EvaluationFormArn" ;
        }

        public override string AWSTypeName { get => AWS.Connect.EvaluationForm; }
        /// <summary>
        /// ScoringStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-scoringstrategy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ScoringStrategy
        /// </summary>
        public Humidifier.Connect.EvaluationFormTypes.ScoringStrategy ScoringStrategy { get; set; }

        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-status
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
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
        [Required]
        public dynamic InstanceArn { get; set; }

        /// <summary>
        /// Title
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-title
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Title { get; set; }

        /// <summary>
        /// Items
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-items
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EvaluationFormBaseItem
        /// </summary>
        [Required]
        public List<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem> Items { get; set; }
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
        public class EvaluationFormBaseItem : Humidifier.Base.BaseSubResource, IHaveConnectEvaluationFormTypesEvaluationFormSectionSection
        {
            /// <summary>
            /// Section
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformbaseitem.html#cfn-connect-evaluationform-evaluationformbaseitem-section
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EvaluationFormSection
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection Section { get; set; }
        }

        public class EvaluationFormItem : Humidifier.Base.BaseSubResource, IHaveConnectEvaluationFormTypesEvaluationFormSectionSection
        {
            /// <summary>
            /// Question
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitem.html#cfn-connect-evaluationform-evaluationformitem-question
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormQuestion
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormQuestion Question { get; set; }
            /// <summary>
            /// Section
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitem.html#cfn-connect-evaluationform-evaluationformitem-section
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormSection
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection Section { get; set; }
        }

        public class EvaluationFormNumericQuestionAutomation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PropertyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionautomation.html#cfn-connect-evaluationform-evaluationformnumericquestionautomation-propertyvalue
            /// Required: True
            /// UpdateType: Mutable
            /// Type: NumericQuestionPropertyValueAutomation
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.NumericQuestionPropertyValueAutomation PropertyValue { get; set; }
        }

        public class EvaluationFormNumericQuestionOption : Humidifier.Base.BaseSubResource, IHaveMaxValue, IHaveMinValue, IHaveScore, IHaveAutomaticFail
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

        public class EvaluationFormNumericQuestionProperties : Humidifier.Base.BaseSubResource, IHaveMaxValue, IHaveMinValue
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionproperties.html#cfn-connect-evaluationform-evaluationformnumericquestionproperties-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormNumericQuestionOption
            /// </summary>
            public List<Humidifier.Connect.EvaluationFormTypes.EvaluationFormNumericQuestionOption> Options { get; set; }
            /// <summary>
            /// Automation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionproperties.html#cfn-connect-evaluationform-evaluationformnumericquestionproperties-automation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormNumericQuestionAutomation
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormNumericQuestionAutomation Automation { get; set; }
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

        public class EvaluationFormQuestion : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveWeight, IHaveRefId, IHaveInstructions
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
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormQuestionTypeProperties QuestionTypeProperties { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Weight { get; set; }
        }

        public class EvaluationFormQuestionTypeProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Numeric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestiontypeproperties.html#cfn-connect-evaluationform-evaluationformquestiontypeproperties-numeric
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormNumericQuestionProperties
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormNumericQuestionProperties Numeric { get; set; }
            /// <summary>
            /// SingleSelect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestiontypeproperties.html#cfn-connect-evaluationform-evaluationformquestiontypeproperties-singleselect
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormSingleSelectQuestionProperties
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormSingleSelectQuestionProperties SingleSelect { get; set; }
        }

        public class EvaluationFormSection : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveWeight, IHaveRefId, IHaveInstructions
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
            public List<Humidifier.Connect.EvaluationFormTypes.EvaluationFormItem> Items { get; set; }
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

        public class EvaluationFormSingleSelectQuestionAutomation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionautomation.html#cfn-connect-evaluationform-evaluationformsingleselectquestionautomation-options
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormSingleSelectQuestionAutomationOption
            /// </summary>
            public List<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSingleSelectQuestionAutomationOption> Options { get; set; }
            /// <summary>
            /// DefaultOptionRefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionautomation.html#cfn-connect-evaluationform-evaluationformsingleselectquestionautomation-defaultoptionrefid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultOptionRefId { get; set; }
        }

        public class EvaluationFormSingleSelectQuestionAutomationOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RuleCategory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionautomationoption.html#cfn-connect-evaluationform-evaluationformsingleselectquestionautomationoption-rulecategory
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SingleSelectQuestionRuleCategoryAutomation
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.SingleSelectQuestionRuleCategoryAutomation RuleCategory { get; set; }
        }

        public class EvaluationFormSingleSelectQuestionOption : Humidifier.Base.BaseSubResource, IHaveText, IHaveRefId, IHaveScore, IHaveAutomaticFail
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

        public class EvaluationFormSingleSelectQuestionProperties : Humidifier.Base.BaseSubResource, IHaveDisplayAs
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
            public List<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSingleSelectQuestionOption> Options { get; set; }
            /// <summary>
            /// Automation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionproperties.html#cfn-connect-evaluationform-evaluationformsingleselectquestionproperties-automation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormSingleSelectQuestionAutomation
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormSingleSelectQuestionAutomation Automation { get; set; }
        }

        public class NumericQuestionPropertyValueAutomation : Humidifier.Base.BaseSubResource, IHaveLabel
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

        public class ScoringStrategy : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveMode
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

        public class SingleSelectQuestionRuleCategoryAutomation : Humidifier.Base.BaseSubResource, IHaveCondition, IHaveCategory
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