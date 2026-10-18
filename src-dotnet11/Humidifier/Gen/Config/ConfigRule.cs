namespace Humidifier.Config
{
    using global::System.Collections.Generic;
    using ConfigRuleTypes;

    public class ConfigRule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfConfigConfigRuleTypesEvaluationModeConfigurationEvaluationModes, IHaveDescription, IHaveConfigConfigRuleTypesScopeScope, IHaveConfigConfigRuleTypesComplianceCompliance, IHaveConfigRuleName, IHaveMaximumExecutionFrequency, IHaveConfigConfigRuleTypesSourceSource, IHaveInputParameters_Json
    {
        public class Attributes
        {
            public static string ConfigRuleId =  "ConfigRuleId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Config.ConfigRule; }
        /// <summary>
        /// EvaluationModes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-evaluationmodes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EvaluationModeConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration>, IReadOnlyList<Union<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration, BaseFunction>>, BaseFunction>? EvaluationModes { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Scope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-scope
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Scope
        /// </summary>
        public Union<Humidifier.Config.ConfigRuleTypes.Scope, BaseFunction>? Scope { get; set; }
        /// <summary>
        /// Compliance
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-compliance
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Compliance
        /// </summary>
        public Union<Humidifier.Config.ConfigRuleTypes.Compliance, BaseFunction>? Compliance { get; set; }
        public Union<string, BaseFunction>? ConfigRuleName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// MaximumExecutionFrequency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-maximumexecutionfrequency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MaximumExecutionFrequency { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-source
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Source
        /// </summary>
        [Required]
        public Union<Humidifier.Config.ConfigRuleTypes.Source, BaseFunction>? Source { get; set; }
        /// <summary>
        /// InputParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-inputparameters
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? InputParameters { get; set; }
    }

    namespace ConfigRuleTypes
    {
        public class Compliance : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-compliance.html#cfn-config-configrule-compliance-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class CustomPolicyDetails : Humidifier.Base.BaseSubResource, IHaveEnableDebugLogDelivery_Boolean, IHavePolicyText, IHavePolicyRuntime
        {
            /// <summary>
            /// EnableDebugLogDelivery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-custompolicydetails.html#cfn-config-configrule-custompolicydetails-enabledebuglogdelivery
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableDebugLogDelivery { get; set; }
            /// <summary>
            /// PolicyText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-custompolicydetails.html#cfn-config-configrule-custompolicydetails-policytext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyText { get; set; }
            /// <summary>
            /// PolicyRuntime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-custompolicydetails.html#cfn-config-configrule-custompolicydetails-policyruntime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyRuntime { get; set; }
        }

        public class EvaluationModeConfiguration : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-evaluationmodeconfiguration.html#cfn-config-configrule-evaluationmodeconfiguration-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
        }

        public class Scope : Humidifier.Base.BaseSubResource, IHaveComplianceResourceId, IHaveTagKey, IHaveStringListOfComplianceResourceTypes, IHaveTagValue
        {
            /// <summary>
            /// ComplianceResourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-scope.html#cfn-config-configrule-scope-complianceresourceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComplianceResourceId { get; set; }
            /// <summary>
            /// TagKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-scope.html#cfn-config-configrule-scope-tagkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TagKey { get; set; }
            /// <summary>
            /// ComplianceResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-scope.html#cfn-config-configrule-scope-complianceresourcetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ComplianceResourceTypes { get; set; }
            /// <summary>
            /// TagValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-scope.html#cfn-config-configrule-scope-tagvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TagValue { get; set; }
        }

        public class Source : Humidifier.Base.BaseSubResource, IHaveOwner, IHaveConfigConfigRuleTypesCustomPolicyDetailsCustomPolicyDetails, IHaveSourceIdentifier, IHaveListOfConfigConfigRuleTypesSourceDetailSourceDetails
        {
            /// <summary>
            /// Owner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-source.html#cfn-config-configrule-source-owner
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Owner { get; set; }
            /// <summary>
            /// CustomPolicyDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-source.html#cfn-config-configrule-source-custompolicydetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomPolicyDetails
            /// </summary>
            public Union<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails, BaseFunction>? CustomPolicyDetails { get; set; }
            /// <summary>
            /// SourceIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-source.html#cfn-config-configrule-source-sourceidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceIdentifier { get; set; }
            /// <summary>
            /// SourceDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-source.html#cfn-config-configrule-source-sourcedetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SourceDetail
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Config.ConfigRuleTypes.SourceDetail>, IReadOnlyList<Union<Humidifier.Config.ConfigRuleTypes.SourceDetail, BaseFunction>>, BaseFunction>? SourceDetails { get; set; }
        }

        public class SourceDetail : Humidifier.Base.BaseSubResource, IHaveEventSource, IHaveMaximumExecutionFrequency, IHaveMessageType
        {
            /// <summary>
            /// EventSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-sourcedetail.html#cfn-config-configrule-sourcedetail-eventsource
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventSource { get; set; }
            /// <summary>
            /// MaximumExecutionFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-sourcedetail.html#cfn-config-configrule-sourcedetail-maximumexecutionfrequency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaximumExecutionFrequency { get; set; }
            /// <summary>
            /// MessageType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-sourcedetail.html#cfn-config-configrule-sourcedetail-messagetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageType { get; set; }
        }
    }
}