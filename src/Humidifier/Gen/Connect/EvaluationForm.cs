namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
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
        /// ReviewConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-reviewconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EvaluationReviewConfiguration
        /// </summary>
        public Humidifier.Connect.EvaluationFormTypes.EvaluationReviewConfiguration ReviewConfiguration { get; set; }
        /// <summary>
        /// AutoEvaluationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-autoevaluationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AutoEvaluationConfiguration
        /// </summary>
        public Humidifier.Connect.EvaluationFormTypes.AutoEvaluationConfiguration AutoEvaluationConfiguration { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// TargetConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-targetconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EvaluationFormTargetConfiguration
        /// </summary>
        public Humidifier.Connect.EvaluationFormTypes.EvaluationFormTargetConfiguration TargetConfiguration { get; set; }
        /// <summary>
        /// AIVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-aiversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AIVersion { get; set; }

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
        /// LanguageConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-languageconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EvaluationFormLanguageConfiguration
        /// </summary>
        public Humidifier.Connect.EvaluationFormTypes.EvaluationFormLanguageConfiguration LanguageConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace EvaluationFormTypes
    {
        public class AutoEvaluationConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-autoevaluationconfiguration.html#cfn-connect-evaluationform-autoevaluationconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class AutomaticFailConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetSection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-automaticfailconfiguration.html#cfn-connect-evaluationform-automaticfailconfiguration-targetsection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetSection { get; set; }
        }

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

        public class EvaluationFormItemEnablementCondition : Humidifier.Base.BaseSubResource, IHaveOperator
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementcondition.html#cfn-connect-evaluationform-evaluationformitemenablementcondition-operator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Operands
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementcondition.html#cfn-connect-evaluationform-evaluationformitemenablementcondition-operands
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormItemEnablementConditionOperand
            /// </summary>
            public List<Humidifier.Connect.EvaluationFormTypes.EvaluationFormItemEnablementConditionOperand> Operands { get; set; }
        }

        public class EvaluationFormItemEnablementConditionOperand : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementconditionoperand.html#cfn-connect-evaluationform-evaluationformitemenablementconditionoperand-expression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormItemEnablementExpression
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormItemEnablementExpression Expression { get; set; }
        }

        public class EvaluationFormItemEnablementConfiguration : Humidifier.Base.BaseSubResource, IHaveAction, IHaveDefaultAction
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementconfiguration.html#cfn-connect-evaluationform-evaluationformitemenablementconfiguration-condition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EvaluationFormItemEnablementCondition
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormItemEnablementCondition Condition { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementconfiguration.html#cfn-connect-evaluationform-evaluationformitemenablementconfiguration-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// DefaultAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementconfiguration.html#cfn-connect-evaluationform-evaluationformitemenablementconfiguration-defaultaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultAction { get; set; }
        }

        public class EvaluationFormItemEnablementExpression : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementexpression.html#cfn-connect-evaluationform-evaluationformitemenablementexpression-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormItemEnablementSourceValue
            /// </summary>
            public List<Humidifier.Connect.EvaluationFormTypes.EvaluationFormItemEnablementSourceValue> Values { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementexpression.html#cfn-connect-evaluationform-evaluationformitemenablementexpression-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EvaluationFormItemEnablementSource
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormItemEnablementSource Source { get; set; }
            /// <summary>
            /// Comparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementexpression.html#cfn-connect-evaluationform-evaluationformitemenablementexpression-comparator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comparator { get; set; }
        }

        public class EvaluationFormItemEnablementSource : Humidifier.Base.BaseSubResource, IHaveType, IHaveRefId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementsource.html#cfn-connect-evaluationform-evaluationformitemenablementsource-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// RefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementsource.html#cfn-connect-evaluationform-evaluationformitemenablementsource-refid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RefId { get; set; }
        }

        public class EvaluationFormItemEnablementSourceValue : Humidifier.Base.BaseSubResource, IHaveType, IHaveRefId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementsourcevalue.html#cfn-connect-evaluationform-evaluationformitemenablementsourcevalue-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// RefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementsourcevalue.html#cfn-connect-evaluationform-evaluationformitemenablementsourcevalue-refid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RefId { get; set; }
        }

        public class EvaluationFormLanguageConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FormLanguage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformlanguageconfiguration.html#cfn-connect-evaluationform-evaluationformlanguageconfiguration-formlanguage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FormLanguage { get; set; }
        }

        public class EvaluationFormMetricConfiguration : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveMetricType
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmetricconfiguration.html#cfn-connect-evaluationform-evaluationformmetricconfiguration-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricName { get; set; }
            /// <summary>
            /// MetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmetricconfiguration.html#cfn-connect-evaluationform-evaluationformmetricconfiguration-metrictype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricType { get; set; }
        }

        public class EvaluationFormMultiSelectQuestionAutomation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionautomation.html#cfn-connect-evaluationform-evaluationformmultiselectquestionautomation-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormMultiSelectQuestionAutomationOption
            /// </summary>
            public List<Humidifier.Connect.EvaluationFormTypes.EvaluationFormMultiSelectQuestionAutomationOption> Options { get; set; }
            /// <summary>
            /// AnswerSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionautomation.html#cfn-connect-evaluationform-evaluationformmultiselectquestionautomation-answersource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormQuestionAutomationAnswerSource
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormQuestionAutomationAnswerSource AnswerSource { get; set; }
            /// <summary>
            /// DefaultOptionRefIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionautomation.html#cfn-connect-evaluationform-evaluationformmultiselectquestionautomation-defaultoptionrefids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DefaultOptionRefIds { get; set; }
        }

        public class EvaluationFormMultiSelectQuestionAutomationOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RuleCategory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionautomationoption.html#cfn-connect-evaluationform-evaluationformmultiselectquestionautomationoption-rulecategory
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MultiSelectQuestionRuleCategoryAutomation
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.MultiSelectQuestionRuleCategoryAutomation RuleCategory { get; set; }
        }

        public class EvaluationFormMultiSelectQuestionOption : Humidifier.Base.BaseSubResource, IHaveText, IHaveRefId, IHaveScore, IHaveAutomaticFail
        {
            /// <summary>
            /// Score
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionoption.html#cfn-connect-evaluationform-evaluationformmultiselectquestionoption-score
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Score { get; set; }
            /// <summary>
            /// AutomaticFailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionoption.html#cfn-connect-evaluationform-evaluationformmultiselectquestionoption-automaticfailconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutomaticFailConfiguration
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.AutomaticFailConfiguration AutomaticFailConfiguration { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionoption.html#cfn-connect-evaluationform-evaluationformmultiselectquestionoption-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
            /// <summary>
            /// PointsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionoption.html#cfn-connect-evaluationform-evaluationformmultiselectquestionoption-pointsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QuestionOptionPointsConfiguration
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.QuestionOptionPointsConfiguration PointsConfiguration { get; set; }
            /// <summary>
            /// RefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionoption.html#cfn-connect-evaluationform-evaluationformmultiselectquestionoption-refid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RefId { get; set; }
            /// <summary>
            /// AutomaticFail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionoption.html#cfn-connect-evaluationform-evaluationformmultiselectquestionoption-automaticfail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AutomaticFail { get; set; }
        }

        public class EvaluationFormMultiSelectQuestionProperties : Humidifier.Base.BaseSubResource, IHaveDisplayAs
        {
            /// <summary>
            /// DisplayAs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionproperties.html#cfn-connect-evaluationform-evaluationformmultiselectquestionproperties-displayas
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DisplayAs { get; set; }
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionproperties.html#cfn-connect-evaluationform-evaluationformmultiselectquestionproperties-options
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormMultiSelectQuestionOption
            /// </summary>
            public List<Humidifier.Connect.EvaluationFormTypes.EvaluationFormMultiSelectQuestionOption> Options { get; set; }
            /// <summary>
            /// Automation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionproperties.html#cfn-connect-evaluationform-evaluationformmultiselectquestionproperties-automation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormMultiSelectQuestionAutomation
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormMultiSelectQuestionAutomation Automation { get; set; }
        }

        public class EvaluationFormNumericQuestionAutomation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AnswerSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionautomation.html#cfn-connect-evaluationform-evaluationformnumericquestionautomation-answersource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormQuestionAutomationAnswerSource
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormQuestionAutomationAnswerSource AnswerSource { get; set; }
            /// <summary>
            /// PropertyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionautomation.html#cfn-connect-evaluationform-evaluationformnumericquestionautomation-propertyvalue
            /// Required: False
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
            /// AutomaticFailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionoption.html#cfn-connect-evaluationform-evaluationformnumericquestionoption-automaticfailconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutomaticFailConfiguration
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.AutomaticFailConfiguration AutomaticFailConfiguration { get; set; }
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionoption.html#cfn-connect-evaluationform-evaluationformnumericquestionoption-minvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinValue { get; set; }
            /// <summary>
            /// PointsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionoption.html#cfn-connect-evaluationform-evaluationformnumericquestionoption-pointsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QuestionOptionPointsConfiguration
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.QuestionOptionPointsConfiguration PointsConfiguration { get; set; }
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
            /// Enablement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-enablement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormItemEnablementConfiguration
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormItemEnablementConfiguration Enablement { get; set; }
            /// <summary>
            /// MetricConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-metricconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormMetricConfiguration
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormMetricConfiguration MetricConfiguration { get; set; }
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
            /// ScoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-scoringconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormQuestionScoringConfiguration
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormQuestionScoringConfiguration ScoringConfiguration { get; set; }
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

        public class EvaluationFormQuestionAutomationAnswerSource : Humidifier.Base.BaseSubResource, IHaveSourceType
        {
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestionautomationanswersource.html#cfn-connect-evaluationform-evaluationformquestionautomationanswersource-sourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceType { get; set; }
        }

        public class EvaluationFormQuestionScoringConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScoreThresholds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestionscoringconfiguration.html#cfn-connect-evaluationform-evaluationformquestionscoringconfiguration-scorethresholds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormScoreThreshold
            /// </summary>
            public List<Humidifier.Connect.EvaluationFormTypes.EvaluationFormScoreThreshold> ScoreThresholds { get; set; }
            /// <summary>
            /// PointsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestionscoringconfiguration.html#cfn-connect-evaluationform-evaluationformquestionscoringconfiguration-pointsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QuestionPointsConfiguration
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.QuestionPointsConfiguration PointsConfiguration { get; set; }
            /// <summary>
            /// IsExcludedFromScoring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestionscoringconfiguration.html#cfn-connect-evaluationform-evaluationformquestionscoringconfiguration-isexcludedfromscoring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsExcludedFromScoring { get; set; }
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
            /// <summary>
            /// MultiSelect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestiontypeproperties.html#cfn-connect-evaluationform-evaluationformquestiontypeproperties-multiselect
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormMultiSelectQuestionProperties
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormMultiSelectQuestionProperties MultiSelect { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestiontypeproperties.html#cfn-connect-evaluationform-evaluationformquestiontypeproperties-text
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormTextQuestionProperties
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormTextQuestionProperties Text { get; set; }
        }

        public class EvaluationFormScoreThreshold : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxScorePercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformscorethreshold.html#cfn-connect-evaluationform-evaluationformscorethreshold-maxscorepercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxScorePercentage { get; set; }
            /// <summary>
            /// MinScorePercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformscorethreshold.html#cfn-connect-evaluationform-evaluationformscorethreshold-minscorepercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinScorePercentage { get; set; }
            /// <summary>
            /// PerformanceCategory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformscorethreshold.html#cfn-connect-evaluationform-evaluationformscorethreshold-performancecategory
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PerformanceCategory { get; set; }
        }

        public class EvaluationFormSection : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveWeight, IHaveRefId, IHaveInstructions
        {
            /// <summary>
            /// ScoreThresholds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsection.html#cfn-connect-evaluationform-evaluationformsection-scorethresholds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormScoreThreshold
            /// </summary>
            public List<Humidifier.Connect.EvaluationFormTypes.EvaluationFormScoreThreshold> ScoreThresholds { get; set; }
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
            /// IsExcludedFromScoring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsection.html#cfn-connect-evaluationform-evaluationformsection-isexcludedfromscoring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsExcludedFromScoring { get; set; }
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
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormSingleSelectQuestionAutomationOption
            /// </summary>
            public List<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSingleSelectQuestionAutomationOption> Options { get; set; }
            /// <summary>
            /// AnswerSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionautomation.html#cfn-connect-evaluationform-evaluationformsingleselectquestionautomation-answersource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormQuestionAutomationAnswerSource
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormQuestionAutomationAnswerSource AnswerSource { get; set; }
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
            /// AutomaticFailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionoption.html#cfn-connect-evaluationform-evaluationformsingleselectquestionoption-automaticfailconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutomaticFailConfiguration
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.AutomaticFailConfiguration AutomaticFailConfiguration { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionoption.html#cfn-connect-evaluationform-evaluationformsingleselectquestionoption-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
            /// <summary>
            /// PointsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionoption.html#cfn-connect-evaluationform-evaluationformsingleselectquestionoption-pointsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QuestionOptionPointsConfiguration
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.QuestionOptionPointsConfiguration PointsConfiguration { get; set; }
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

        public class EvaluationFormTargetConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContactInteractionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformtargetconfiguration.html#cfn-connect-evaluationform-evaluationformtargetconfiguration-contactinteractiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContactInteractionType { get; set; }
        }

        public class EvaluationFormTextQuestionAutomation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AnswerSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformtextquestionautomation.html#cfn-connect-evaluationform-evaluationformtextquestionautomation-answersource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormQuestionAutomationAnswerSource
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormQuestionAutomationAnswerSource AnswerSource { get; set; }
        }

        public class EvaluationFormTextQuestionProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Automation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformtextquestionproperties.html#cfn-connect-evaluationform-evaluationformtextquestionproperties-automation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormTextQuestionAutomation
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationFormTextQuestionAutomation Automation { get; set; }
        }

        public class EvaluationReviewConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ReviewNotificationRecipients
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationreviewconfiguration.html#cfn-connect-evaluationform-evaluationreviewconfiguration-reviewnotificationrecipients
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationReviewNotificationRecipient
            /// </summary>
            public List<Humidifier.Connect.EvaluationFormTypes.EvaluationReviewNotificationRecipient> ReviewNotificationRecipients { get; set; }
            /// <summary>
            /// EligibilityDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationreviewconfiguration.html#cfn-connect-evaluationform-evaluationreviewconfiguration-eligibilitydays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EligibilityDays { get; set; }
        }

        public class EvaluationReviewNotificationRecipient : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationreviewnotificationrecipient.html#cfn-connect-evaluationform-evaluationreviewnotificationrecipient-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationreviewnotificationrecipient.html#cfn-connect-evaluationform-evaluationreviewnotificationrecipient-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EvaluationReviewNotificationRecipientValue
            /// </summary>
            public Humidifier.Connect.EvaluationFormTypes.EvaluationReviewNotificationRecipientValue Value { get; set; }
        }

        public class EvaluationReviewNotificationRecipientValue : Humidifier.Base.BaseSubResource, IHaveUserId
        {
            /// <summary>
            /// UserId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationreviewnotificationrecipientvalue.html#cfn-connect-evaluationform-evaluationreviewnotificationrecipientvalue-userid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserId { get; set; }
        }

        public class MultiSelectQuestionRuleCategoryAutomation : Humidifier.Base.BaseSubResource, IHaveCondition, IHaveCategory
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-multiselectquestionrulecategoryautomation.html#cfn-connect-evaluationform-multiselectquestionrulecategoryautomation-condition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Condition { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-multiselectquestionrulecategoryautomation.html#cfn-connect-evaluationform-multiselectquestionrulecategoryautomation-category
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Category { get; set; }
            /// <summary>
            /// OptionRefIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-multiselectquestionrulecategoryautomation.html#cfn-connect-evaluationform-multiselectquestionrulecategoryautomation-optionrefids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic OptionRefIds { get; set; }
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

        public class QuestionOptionPointsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PointValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-questionoptionpointsconfiguration.html#cfn-connect-evaluationform-questionoptionpointsconfiguration-pointvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PointValue { get; set; }
            /// <summary>
            /// IsBonus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-questionoptionpointsconfiguration.html#cfn-connect-evaluationform-questionoptionpointsconfiguration-isbonus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsBonus { get; set; }
        }

        public class QuestionPointsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxPointValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-questionpointsconfiguration.html#cfn-connect-evaluationform-questionpointsconfiguration-maxpointvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxPointValue { get; set; }
            /// <summary>
            /// MinPointValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-questionpointsconfiguration.html#cfn-connect-evaluationform-questionpointsconfiguration-minpointvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinPointValue { get; set; }
            /// <summary>
            /// IsBonus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-questionpointsconfiguration.html#cfn-connect-evaluationform-questionpointsconfiguration-isbonus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsBonus { get; set; }
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
            /// ScoreThresholds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-scoringstrategy.html#cfn-connect-evaluationform-scoringstrategy-scorethresholds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormScoreThreshold
            /// </summary>
            public List<Humidifier.Connect.EvaluationFormTypes.EvaluationFormScoreThreshold> ScoreThresholds { get; set; }
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