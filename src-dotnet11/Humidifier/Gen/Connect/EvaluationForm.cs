namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using EvaluationFormTypes;

    public class EvaluationForm : Humidifier.Base.BaseResource, IHaveTags, IHaveConnectEvaluationFormTypesScoringStrategyScoringStrategy, IHaveStatus, IHaveConnectEvaluationFormTypesEvaluationReviewConfigurationReviewConfiguration, IHaveConnectEvaluationFormTypesAutoEvaluationConfigurationAutoEvaluationConfiguration, IHaveDescription, IHaveConnectEvaluationFormTypesEvaluationFormTargetConfigurationTargetConfiguration, IHaveAIVersion, IHaveInstanceArn, IHaveTitle, IHaveListOfConnectEvaluationFormTypesEvaluationFormBaseItemItems, IHaveConnectEvaluationFormTypesEvaluationFormLanguageConfigurationLanguageConfiguration
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
        public Union<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy, BaseFunction>? ScoringStrategy { get; set; }

        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-status
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Status { get; set; }
        /// <summary>
        /// ReviewConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-reviewconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EvaluationReviewConfiguration
        /// </summary>
        public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationReviewConfiguration, BaseFunction>? ReviewConfiguration { get; set; }
        /// <summary>
        /// AutoEvaluationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-autoevaluationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AutoEvaluationConfiguration
        /// </summary>
        public Union<Humidifier.Connect.EvaluationFormTypes.AutoEvaluationConfiguration, BaseFunction>? AutoEvaluationConfiguration { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// TargetConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-targetconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EvaluationFormTargetConfiguration
        /// </summary>
        public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormTargetConfiguration, BaseFunction>? TargetConfiguration { get; set; }
        /// <summary>
        /// AIVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-aiversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AIVersion { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-instancearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }

        /// <summary>
        /// Title
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-title
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Title { get; set; }

        /// <summary>
        /// Items
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-items
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EvaluationFormBaseItem
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem>, IReadOnlyList<Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem, BaseFunction>>, BaseFunction>? Items { get; set; }
        /// <summary>
        /// LanguageConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-languageconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EvaluationFormLanguageConfiguration
        /// </summary>
        public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormLanguageConfiguration, BaseFunction>? LanguageConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-evaluationform.html#cfn-connect-evaluationform-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace EvaluationFormTypes
    {
        public class AutoEvaluationConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-autoevaluationconfiguration.html#cfn-connect-evaluationform-autoevaluationconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class AutomaticFailConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetSection
        {
            /// <summary>
            /// TargetSection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-automaticfailconfiguration.html#cfn-connect-evaluationform-automaticfailconfiguration-targetsection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetSection { get; set; }
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
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection, BaseFunction>? Section { get; set; }
        }

        public class EvaluationFormItem : Humidifier.Base.BaseSubResource, IHaveConnectEvaluationFormTypesEvaluationFormQuestionQuestion, IHaveConnectEvaluationFormTypesEvaluationFormSectionSection
        {
            /// <summary>
            /// Question
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitem.html#cfn-connect-evaluationform-evaluationformitem-question
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormQuestion
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormQuestion, BaseFunction>? Question { get; set; }
            /// <summary>
            /// Section
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitem.html#cfn-connect-evaluationform-evaluationformitem-section
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormSection
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection, BaseFunction>? Section { get; set; }
        }

        public class EvaluationFormItemEnablementCondition : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveListOfConnectEvaluationFormTypesEvaluationFormItemEnablementConditionOperandOperands
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementcondition.html#cfn-connect-evaluationform-evaluationformitemenablementcondition-operator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Operands
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementcondition.html#cfn-connect-evaluationform-evaluationformitemenablementcondition-operands
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormItemEnablementConditionOperand
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.EvaluationFormTypes.EvaluationFormItemEnablementConditionOperand>, IReadOnlyList<Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormItemEnablementConditionOperand, BaseFunction>>, BaseFunction>? Operands { get; set; }
        }

        public class EvaluationFormItemEnablementConditionOperand : Humidifier.Base.BaseSubResource, IHaveConnectEvaluationFormTypesEvaluationFormItemEnablementExpressionExpression
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementconditionoperand.html#cfn-connect-evaluationform-evaluationformitemenablementconditionoperand-expression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormItemEnablementExpression
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormItemEnablementExpression, BaseFunction>? Expression { get; set; }
        }

        public class EvaluationFormItemEnablementConfiguration : Humidifier.Base.BaseSubResource, IHaveConnectEvaluationFormTypesEvaluationFormItemEnablementConditionCondition, IHaveAction, IHaveDefaultAction
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementconfiguration.html#cfn-connect-evaluationform-evaluationformitemenablementconfiguration-condition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EvaluationFormItemEnablementCondition
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormItemEnablementCondition, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementconfiguration.html#cfn-connect-evaluationform-evaluationformitemenablementconfiguration-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// DefaultAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementconfiguration.html#cfn-connect-evaluationform-evaluationformitemenablementconfiguration-defaultaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultAction { get; set; }
        }

        public class EvaluationFormItemEnablementExpression : Humidifier.Base.BaseSubResource, IHaveListOfConnectEvaluationFormTypesEvaluationFormItemEnablementSourceValueValues, IHaveConnectEvaluationFormTypesEvaluationFormItemEnablementSourceSource, IHaveComparator
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementexpression.html#cfn-connect-evaluationform-evaluationformitemenablementexpression-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormItemEnablementSourceValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.EvaluationFormTypes.EvaluationFormItemEnablementSourceValue>, IReadOnlyList<Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormItemEnablementSourceValue, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementexpression.html#cfn-connect-evaluationform-evaluationformitemenablementexpression-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EvaluationFormItemEnablementSource
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormItemEnablementSource, BaseFunction>? Source { get; set; }
            /// <summary>
            /// Comparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementexpression.html#cfn-connect-evaluationform-evaluationformitemenablementexpression-comparator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comparator { get; set; }
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
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// RefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementsource.html#cfn-connect-evaluationform-evaluationformitemenablementsource-refid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefId { get; set; }
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
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// RefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformitemenablementsourcevalue.html#cfn-connect-evaluationform-evaluationformitemenablementsourcevalue-refid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefId { get; set; }
        }

        public class EvaluationFormLanguageConfiguration : Humidifier.Base.BaseSubResource, IHaveFormLanguage
        {
            /// <summary>
            /// FormLanguage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformlanguageconfiguration.html#cfn-connect-evaluationform-evaluationformlanguageconfiguration-formlanguage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FormLanguage { get; set; }
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
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// MetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmetricconfiguration.html#cfn-connect-evaluationform-evaluationformmetricconfiguration-metrictype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricType { get; set; }
        }

        public class EvaluationFormMultiSelectQuestionAutomation : Humidifier.Base.BaseSubResource, IHaveListOfConnectEvaluationFormTypesEvaluationFormMultiSelectQuestionAutomationOptionOptions, IHaveConnectEvaluationFormTypesEvaluationFormQuestionAutomationAnswerSourceAnswerSource, IHaveStringListOfDefaultOptionRefIds
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionautomation.html#cfn-connect-evaluationform-evaluationformmultiselectquestionautomation-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormMultiSelectQuestionAutomationOption
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.EvaluationFormTypes.EvaluationFormMultiSelectQuestionAutomationOption>, IReadOnlyList<Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormMultiSelectQuestionAutomationOption, BaseFunction>>, BaseFunction>? Options { get; set; }
            /// <summary>
            /// AnswerSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionautomation.html#cfn-connect-evaluationform-evaluationformmultiselectquestionautomation-answersource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormQuestionAutomationAnswerSource
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormQuestionAutomationAnswerSource, BaseFunction>? AnswerSource { get; set; }
            /// <summary>
            /// DefaultOptionRefIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionautomation.html#cfn-connect-evaluationform-evaluationformmultiselectquestionautomation-defaultoptionrefids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DefaultOptionRefIds { get; set; }
        }

        public class EvaluationFormMultiSelectQuestionAutomationOption : Humidifier.Base.BaseSubResource, IHaveConnectEvaluationFormTypesMultiSelectQuestionRuleCategoryAutomationRuleCategory
        {
            /// <summary>
            /// RuleCategory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionautomationoption.html#cfn-connect-evaluationform-evaluationformmultiselectquestionautomationoption-rulecategory
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MultiSelectQuestionRuleCategoryAutomation
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.MultiSelectQuestionRuleCategoryAutomation, BaseFunction>? RuleCategory { get; set; }
        }

        public class EvaluationFormMultiSelectQuestionOption : Humidifier.Base.BaseSubResource, IHaveScore_Integer, IHaveConnectEvaluationFormTypesAutomaticFailConfigurationAutomaticFailConfiguration, IHaveText, IHaveConnectEvaluationFormTypesQuestionOptionPointsConfigurationPointsConfiguration, IHaveRefId, IHaveAutomaticFail_Boolean
        {
            /// <summary>
            /// Score
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionoption.html#cfn-connect-evaluationform-evaluationformmultiselectquestionoption-score
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Score { get; set; }
            /// <summary>
            /// AutomaticFailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionoption.html#cfn-connect-evaluationform-evaluationformmultiselectquestionoption-automaticfailconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutomaticFailConfiguration
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.AutomaticFailConfiguration, BaseFunction>? AutomaticFailConfiguration { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionoption.html#cfn-connect-evaluationform-evaluationformmultiselectquestionoption-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
            /// <summary>
            /// PointsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionoption.html#cfn-connect-evaluationform-evaluationformmultiselectquestionoption-pointsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QuestionOptionPointsConfiguration
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.QuestionOptionPointsConfiguration, BaseFunction>? PointsConfiguration { get; set; }
            /// <summary>
            /// RefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionoption.html#cfn-connect-evaluationform-evaluationformmultiselectquestionoption-refid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefId { get; set; }
            /// <summary>
            /// AutomaticFail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionoption.html#cfn-connect-evaluationform-evaluationformmultiselectquestionoption-automaticfail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutomaticFail { get; set; }
        }

        public class EvaluationFormMultiSelectQuestionProperties : Humidifier.Base.BaseSubResource, IHaveDisplayAs, IHaveListOfConnectEvaluationFormTypesEvaluationFormMultiSelectQuestionOptionOptions, IHaveConnectEvaluationFormTypesEvaluationFormMultiSelectQuestionAutomationAutomation
        {
            /// <summary>
            /// DisplayAs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionproperties.html#cfn-connect-evaluationform-evaluationformmultiselectquestionproperties-displayas
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DisplayAs { get; set; }
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionproperties.html#cfn-connect-evaluationform-evaluationformmultiselectquestionproperties-options
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormMultiSelectQuestionOption
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.EvaluationFormTypes.EvaluationFormMultiSelectQuestionOption>, IReadOnlyList<Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormMultiSelectQuestionOption, BaseFunction>>, BaseFunction>? Options { get; set; }
            /// <summary>
            /// Automation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformmultiselectquestionproperties.html#cfn-connect-evaluationform-evaluationformmultiselectquestionproperties-automation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormMultiSelectQuestionAutomation
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormMultiSelectQuestionAutomation, BaseFunction>? Automation { get; set; }
        }

        public class EvaluationFormNumericQuestionAutomation : Humidifier.Base.BaseSubResource, IHaveConnectEvaluationFormTypesEvaluationFormQuestionAutomationAnswerSourceAnswerSource, IHaveConnectEvaluationFormTypesNumericQuestionPropertyValueAutomationPropertyValue
        {
            /// <summary>
            /// AnswerSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionautomation.html#cfn-connect-evaluationform-evaluationformnumericquestionautomation-answersource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormQuestionAutomationAnswerSource
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormQuestionAutomationAnswerSource, BaseFunction>? AnswerSource { get; set; }
            /// <summary>
            /// PropertyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionautomation.html#cfn-connect-evaluationform-evaluationformnumericquestionautomation-propertyvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericQuestionPropertyValueAutomation
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.NumericQuestionPropertyValueAutomation, BaseFunction>? PropertyValue { get; set; }
        }

        public class EvaluationFormNumericQuestionOption : Humidifier.Base.BaseSubResource, IHaveScore_Integer, IHaveConnectEvaluationFormTypesAutomaticFailConfigurationAutomaticFailConfiguration, IHaveMinValue_Integer, IHaveConnectEvaluationFormTypesQuestionOptionPointsConfigurationPointsConfiguration, IHaveMaxValue_Integer, IHaveAutomaticFail_Boolean
        {
            /// <summary>
            /// Score
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionoption.html#cfn-connect-evaluationform-evaluationformnumericquestionoption-score
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Score { get; set; }
            /// <summary>
            /// AutomaticFailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionoption.html#cfn-connect-evaluationform-evaluationformnumericquestionoption-automaticfailconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutomaticFailConfiguration
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.AutomaticFailConfiguration, BaseFunction>? AutomaticFailConfiguration { get; set; }
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionoption.html#cfn-connect-evaluationform-evaluationformnumericquestionoption-minvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinValue { get; set; }
            /// <summary>
            /// PointsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionoption.html#cfn-connect-evaluationform-evaluationformnumericquestionoption-pointsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QuestionOptionPointsConfiguration
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.QuestionOptionPointsConfiguration, BaseFunction>? PointsConfiguration { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionoption.html#cfn-connect-evaluationform-evaluationformnumericquestionoption-maxvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxValue { get; set; }
            /// <summary>
            /// AutomaticFail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionoption.html#cfn-connect-evaluationform-evaluationformnumericquestionoption-automaticfail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutomaticFail { get; set; }
        }

        public class EvaluationFormNumericQuestionProperties : Humidifier.Base.BaseSubResource, IHaveListOfConnectEvaluationFormTypesEvaluationFormNumericQuestionOptionOptions, IHaveConnectEvaluationFormTypesEvaluationFormNumericQuestionAutomationAutomation, IHaveMinValue_Integer, IHaveMaxValue_Integer
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionproperties.html#cfn-connect-evaluationform-evaluationformnumericquestionproperties-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormNumericQuestionOption
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.EvaluationFormTypes.EvaluationFormNumericQuestionOption>, IReadOnlyList<Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormNumericQuestionOption, BaseFunction>>, BaseFunction>? Options { get; set; }
            /// <summary>
            /// Automation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionproperties.html#cfn-connect-evaluationform-evaluationformnumericquestionproperties-automation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormNumericQuestionAutomation
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormNumericQuestionAutomation, BaseFunction>? Automation { get; set; }
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionproperties.html#cfn-connect-evaluationform-evaluationformnumericquestionproperties-minvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinValue { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformnumericquestionproperties.html#cfn-connect-evaluationform-evaluationformnumericquestionproperties-maxvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxValue { get; set; }
        }

        public class EvaluationFormQuestion : Humidifier.Base.BaseSubResource, IHaveNotApplicableEnabled_Boolean, IHaveConnectEvaluationFormTypesEvaluationFormItemEnablementConfigurationEnablement, IHaveConnectEvaluationFormTypesEvaluationFormMetricConfigurationMetricConfiguration, IHaveTitle, IHaveQuestionType, IHaveInstructions, IHaveConnectEvaluationFormTypesEvaluationFormQuestionScoringConfigurationScoringConfiguration, IHaveRefId, IHaveConnectEvaluationFormTypesEvaluationFormQuestionTypePropertiesQuestionTypeProperties, IHaveWeight_Double
        {
            /// <summary>
            /// NotApplicableEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-notapplicableenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? NotApplicableEnabled { get; set; }
            /// <summary>
            /// Enablement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-enablement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormItemEnablementConfiguration
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormItemEnablementConfiguration, BaseFunction>? Enablement { get; set; }
            /// <summary>
            /// MetricConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-metricconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormMetricConfiguration
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormMetricConfiguration, BaseFunction>? MetricConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Title { get; set; }
            /// <summary>
            /// QuestionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-questiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QuestionType { get; set; }
            /// <summary>
            /// Instructions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-instructions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Instructions { get; set; }
            /// <summary>
            /// ScoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-scoringconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormQuestionScoringConfiguration
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormQuestionScoringConfiguration, BaseFunction>? ScoringConfiguration { get; set; }
            /// <summary>
            /// RefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-refid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefId { get; set; }
            /// <summary>
            /// QuestionTypeProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-questiontypeproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormQuestionTypeProperties
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormQuestionTypeProperties, BaseFunction>? QuestionTypeProperties { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestion.html#cfn-connect-evaluationform-evaluationformquestion-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Weight { get; set; }
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
            public Union<string, BaseFunction>? SourceType { get; set; }
        }

        public class EvaluationFormQuestionScoringConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfConnectEvaluationFormTypesEvaluationFormScoreThresholdScoreThresholds, IHaveConnectEvaluationFormTypesQuestionPointsConfigurationPointsConfiguration, IHaveIsExcludedFromScoring_Boolean
        {
            /// <summary>
            /// ScoreThresholds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestionscoringconfiguration.html#cfn-connect-evaluationform-evaluationformquestionscoringconfiguration-scorethresholds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormScoreThreshold
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.EvaluationFormTypes.EvaluationFormScoreThreshold>, IReadOnlyList<Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormScoreThreshold, BaseFunction>>, BaseFunction>? ScoreThresholds { get; set; }
            /// <summary>
            /// PointsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestionscoringconfiguration.html#cfn-connect-evaluationform-evaluationformquestionscoringconfiguration-pointsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QuestionPointsConfiguration
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.QuestionPointsConfiguration, BaseFunction>? PointsConfiguration { get; set; }
            /// <summary>
            /// IsExcludedFromScoring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestionscoringconfiguration.html#cfn-connect-evaluationform-evaluationformquestionscoringconfiguration-isexcludedfromscoring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsExcludedFromScoring { get; set; }
        }

        public class EvaluationFormQuestionTypeProperties : Humidifier.Base.BaseSubResource, IHaveConnectEvaluationFormTypesEvaluationFormNumericQuestionPropertiesNumeric, IHaveConnectEvaluationFormTypesEvaluationFormSingleSelectQuestionPropertiesSingleSelect, IHaveConnectEvaluationFormTypesEvaluationFormMultiSelectQuestionPropertiesMultiSelect, IHaveConnectEvaluationFormTypesEvaluationFormTextQuestionPropertiesText
        {
            /// <summary>
            /// Numeric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestiontypeproperties.html#cfn-connect-evaluationform-evaluationformquestiontypeproperties-numeric
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormNumericQuestionProperties
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormNumericQuestionProperties, BaseFunction>? Numeric { get; set; }
            /// <summary>
            /// SingleSelect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestiontypeproperties.html#cfn-connect-evaluationform-evaluationformquestiontypeproperties-singleselect
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormSingleSelectQuestionProperties
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSingleSelectQuestionProperties, BaseFunction>? SingleSelect { get; set; }
            /// <summary>
            /// MultiSelect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestiontypeproperties.html#cfn-connect-evaluationform-evaluationformquestiontypeproperties-multiselect
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormMultiSelectQuestionProperties
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormMultiSelectQuestionProperties, BaseFunction>? MultiSelect { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformquestiontypeproperties.html#cfn-connect-evaluationform-evaluationformquestiontypeproperties-text
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormTextQuestionProperties
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormTextQuestionProperties, BaseFunction>? Text { get; set; }
        }

        public class EvaluationFormScoreThreshold : Humidifier.Base.BaseSubResource, IHaveMaxScorePercentage_Double, IHaveMinScorePercentage_Double, IHavePerformanceCategory
        {
            /// <summary>
            /// MaxScorePercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformscorethreshold.html#cfn-connect-evaluationform-evaluationformscorethreshold-maxscorepercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxScorePercentage { get; set; }
            /// <summary>
            /// MinScorePercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformscorethreshold.html#cfn-connect-evaluationform-evaluationformscorethreshold-minscorepercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinScorePercentage { get; set; }
            /// <summary>
            /// PerformanceCategory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformscorethreshold.html#cfn-connect-evaluationform-evaluationformscorethreshold-performancecategory
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PerformanceCategory { get; set; }
        }

        public class EvaluationFormSection : Humidifier.Base.BaseSubResource, IHaveListOfConnectEvaluationFormTypesEvaluationFormScoreThresholdScoreThresholds, IHaveTitle, IHaveInstructions, IHaveListOfConnectEvaluationFormTypesEvaluationFormItemItems, IHaveIsExcludedFromScoring_Boolean, IHaveRefId, IHaveWeight_Double
        {
            /// <summary>
            /// ScoreThresholds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsection.html#cfn-connect-evaluationform-evaluationformsection-scorethresholds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormScoreThreshold
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.EvaluationFormTypes.EvaluationFormScoreThreshold>, IReadOnlyList<Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormScoreThreshold, BaseFunction>>, BaseFunction>? ScoreThresholds { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsection.html#cfn-connect-evaluationform-evaluationformsection-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Title { get; set; }
            /// <summary>
            /// Instructions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsection.html#cfn-connect-evaluationform-evaluationformsection-instructions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Instructions { get; set; }
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsection.html#cfn-connect-evaluationform-evaluationformsection-items
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormItem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.EvaluationFormTypes.EvaluationFormItem>, IReadOnlyList<Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormItem, BaseFunction>>, BaseFunction>? Items { get; set; }
            /// <summary>
            /// IsExcludedFromScoring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsection.html#cfn-connect-evaluationform-evaluationformsection-isexcludedfromscoring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsExcludedFromScoring { get; set; }
            /// <summary>
            /// RefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsection.html#cfn-connect-evaluationform-evaluationformsection-refid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefId { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsection.html#cfn-connect-evaluationform-evaluationformsection-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Weight { get; set; }
        }

        public class EvaluationFormSingleSelectQuestionAutomation : Humidifier.Base.BaseSubResource, IHaveListOfConnectEvaluationFormTypesEvaluationFormSingleSelectQuestionAutomationOptionOptions, IHaveConnectEvaluationFormTypesEvaluationFormQuestionAutomationAnswerSourceAnswerSource, IHaveDefaultOptionRefId
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionautomation.html#cfn-connect-evaluationform-evaluationformsingleselectquestionautomation-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormSingleSelectQuestionAutomationOption
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSingleSelectQuestionAutomationOption>, IReadOnlyList<Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSingleSelectQuestionAutomationOption, BaseFunction>>, BaseFunction>? Options { get; set; }
            /// <summary>
            /// AnswerSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionautomation.html#cfn-connect-evaluationform-evaluationformsingleselectquestionautomation-answersource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormQuestionAutomationAnswerSource
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormQuestionAutomationAnswerSource, BaseFunction>? AnswerSource { get; set; }
            /// <summary>
            /// DefaultOptionRefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionautomation.html#cfn-connect-evaluationform-evaluationformsingleselectquestionautomation-defaultoptionrefid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultOptionRefId { get; set; }
        }

        public class EvaluationFormSingleSelectQuestionAutomationOption : Humidifier.Base.BaseSubResource, IHaveConnectEvaluationFormTypesSingleSelectQuestionRuleCategoryAutomationRuleCategory
        {
            /// <summary>
            /// RuleCategory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionautomationoption.html#cfn-connect-evaluationform-evaluationformsingleselectquestionautomationoption-rulecategory
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SingleSelectQuestionRuleCategoryAutomation
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.SingleSelectQuestionRuleCategoryAutomation, BaseFunction>? RuleCategory { get; set; }
        }

        public class EvaluationFormSingleSelectQuestionOption : Humidifier.Base.BaseSubResource, IHaveScore_Integer, IHaveConnectEvaluationFormTypesAutomaticFailConfigurationAutomaticFailConfiguration, IHaveText, IHaveConnectEvaluationFormTypesQuestionOptionPointsConfigurationPointsConfiguration, IHaveRefId, IHaveAutomaticFail_Boolean
        {
            /// <summary>
            /// Score
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionoption.html#cfn-connect-evaluationform-evaluationformsingleselectquestionoption-score
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Score { get; set; }
            /// <summary>
            /// AutomaticFailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionoption.html#cfn-connect-evaluationform-evaluationformsingleselectquestionoption-automaticfailconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutomaticFailConfiguration
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.AutomaticFailConfiguration, BaseFunction>? AutomaticFailConfiguration { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionoption.html#cfn-connect-evaluationform-evaluationformsingleselectquestionoption-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
            /// <summary>
            /// PointsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionoption.html#cfn-connect-evaluationform-evaluationformsingleselectquestionoption-pointsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QuestionOptionPointsConfiguration
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.QuestionOptionPointsConfiguration, BaseFunction>? PointsConfiguration { get; set; }
            /// <summary>
            /// RefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionoption.html#cfn-connect-evaluationform-evaluationformsingleselectquestionoption-refid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefId { get; set; }
            /// <summary>
            /// AutomaticFail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionoption.html#cfn-connect-evaluationform-evaluationformsingleselectquestionoption-automaticfail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutomaticFail { get; set; }
        }

        public class EvaluationFormSingleSelectQuestionProperties : Humidifier.Base.BaseSubResource, IHaveDisplayAs, IHaveListOfConnectEvaluationFormTypesEvaluationFormSingleSelectQuestionOptionOptions, IHaveConnectEvaluationFormTypesEvaluationFormSingleSelectQuestionAutomationAutomation
        {
            /// <summary>
            /// DisplayAs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionproperties.html#cfn-connect-evaluationform-evaluationformsingleselectquestionproperties-displayas
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DisplayAs { get; set; }
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionproperties.html#cfn-connect-evaluationform-evaluationformsingleselectquestionproperties-options
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormSingleSelectQuestionOption
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSingleSelectQuestionOption>, IReadOnlyList<Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSingleSelectQuestionOption, BaseFunction>>, BaseFunction>? Options { get; set; }
            /// <summary>
            /// Automation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformsingleselectquestionproperties.html#cfn-connect-evaluationform-evaluationformsingleselectquestionproperties-automation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormSingleSelectQuestionAutomation
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSingleSelectQuestionAutomation, BaseFunction>? Automation { get; set; }
        }

        public class EvaluationFormTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveContactInteractionType
        {
            /// <summary>
            /// ContactInteractionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformtargetconfiguration.html#cfn-connect-evaluationform-evaluationformtargetconfiguration-contactinteractiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContactInteractionType { get; set; }
        }

        public class EvaluationFormTextQuestionAutomation : Humidifier.Base.BaseSubResource, IHaveConnectEvaluationFormTypesEvaluationFormQuestionAutomationAnswerSourceAnswerSource
        {
            /// <summary>
            /// AnswerSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformtextquestionautomation.html#cfn-connect-evaluationform-evaluationformtextquestionautomation-answersource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormQuestionAutomationAnswerSource
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormQuestionAutomationAnswerSource, BaseFunction>? AnswerSource { get; set; }
        }

        public class EvaluationFormTextQuestionProperties : Humidifier.Base.BaseSubResource, IHaveConnectEvaluationFormTypesEvaluationFormTextQuestionAutomationAutomation
        {
            /// <summary>
            /// Automation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationformtextquestionproperties.html#cfn-connect-evaluationform-evaluationformtextquestionproperties-automation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationFormTextQuestionAutomation
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormTextQuestionAutomation, BaseFunction>? Automation { get; set; }
        }

        public class EvaluationReviewConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfConnectEvaluationFormTypesEvaluationReviewNotificationRecipientReviewNotificationRecipients, IHaveEligibilityDays_Integer
        {
            /// <summary>
            /// ReviewNotificationRecipients
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationreviewconfiguration.html#cfn-connect-evaluationform-evaluationreviewconfiguration-reviewnotificationrecipients
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationReviewNotificationRecipient
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.EvaluationFormTypes.EvaluationReviewNotificationRecipient>, IReadOnlyList<Union<Humidifier.Connect.EvaluationFormTypes.EvaluationReviewNotificationRecipient, BaseFunction>>, BaseFunction>? ReviewNotificationRecipients { get; set; }
            /// <summary>
            /// EligibilityDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationreviewconfiguration.html#cfn-connect-evaluationform-evaluationreviewconfiguration-eligibilitydays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EligibilityDays { get; set; }
        }

        public class EvaluationReviewNotificationRecipient : Humidifier.Base.BaseSubResource, IHaveType, IHaveConnectEvaluationFormTypesEvaluationReviewNotificationRecipientValueValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationreviewnotificationrecipient.html#cfn-connect-evaluationform-evaluationreviewnotificationrecipient-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-evaluationreviewnotificationrecipient.html#cfn-connect-evaluationform-evaluationreviewnotificationrecipient-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EvaluationReviewNotificationRecipientValue
            /// </summary>
            public Union<Humidifier.Connect.EvaluationFormTypes.EvaluationReviewNotificationRecipientValue, BaseFunction>? Value { get; set; }
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
            public Union<string, BaseFunction>? UserId { get; set; }
        }

        public class MultiSelectQuestionRuleCategoryAutomation : Humidifier.Base.BaseSubResource, IHaveCondition, IHaveCategory, IHaveStringListOfOptionRefIds
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-multiselectquestionrulecategoryautomation.html#cfn-connect-evaluationform-multiselectquestionrulecategoryautomation-condition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-multiselectquestionrulecategoryautomation.html#cfn-connect-evaluationform-multiselectquestionrulecategoryautomation-category
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Category { get; set; }
            /// <summary>
            /// OptionRefIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-multiselectquestionrulecategoryautomation.html#cfn-connect-evaluationform-multiselectquestionrulecategoryautomation-optionrefids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OptionRefIds { get; set; }
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
            public Union<string, BaseFunction>? Label { get; set; }
        }

        public class QuestionOptionPointsConfiguration : Humidifier.Base.BaseSubResource, IHavePointValue_Integer, IHaveIsBonus_Boolean
        {
            /// <summary>
            /// PointValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-questionoptionpointsconfiguration.html#cfn-connect-evaluationform-questionoptionpointsconfiguration-pointvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PointValue { get; set; }
            /// <summary>
            /// IsBonus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-questionoptionpointsconfiguration.html#cfn-connect-evaluationform-questionoptionpointsconfiguration-isbonus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsBonus { get; set; }
        }

        public class QuestionPointsConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxPointValue_Integer, IHaveMinPointValue_Integer, IHaveIsBonus_Boolean
        {
            /// <summary>
            /// MaxPointValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-questionpointsconfiguration.html#cfn-connect-evaluationform-questionpointsconfiguration-maxpointvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxPointValue { get; set; }
            /// <summary>
            /// MinPointValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-questionpointsconfiguration.html#cfn-connect-evaluationform-questionpointsconfiguration-minpointvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinPointValue { get; set; }
            /// <summary>
            /// IsBonus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-questionpointsconfiguration.html#cfn-connect-evaluationform-questionpointsconfiguration-isbonus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsBonus { get; set; }
        }

        public class ScoringStrategy : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveListOfConnectEvaluationFormTypesEvaluationFormScoreThresholdScoreThresholds, IHaveMode
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-scoringstrategy.html#cfn-connect-evaluationform-scoringstrategy-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// ScoreThresholds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-scoringstrategy.html#cfn-connect-evaluationform-scoringstrategy-scorethresholds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationFormScoreThreshold
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.EvaluationFormTypes.EvaluationFormScoreThreshold>, IReadOnlyList<Union<Humidifier.Connect.EvaluationFormTypes.EvaluationFormScoreThreshold, BaseFunction>>, BaseFunction>? ScoreThresholds { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-scoringstrategy.html#cfn-connect-evaluationform-scoringstrategy-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
        }

        public class SingleSelectQuestionRuleCategoryAutomation : Humidifier.Base.BaseSubResource, IHaveCondition, IHaveCategory, IHaveOptionRefId
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-singleselectquestionrulecategoryautomation.html#cfn-connect-evaluationform-singleselectquestionrulecategoryautomation-condition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-singleselectquestionrulecategoryautomation.html#cfn-connect-evaluationform-singleselectquestionrulecategoryautomation-category
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Category { get; set; }
            /// <summary>
            /// OptionRefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-evaluationform-singleselectquestionrulecategoryautomation.html#cfn-connect-evaluationform-singleselectquestionrulecategoryautomation-optionrefid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OptionRefId { get; set; }
        }
    }
}