namespace Humidifier.EntityResolution
{
    using global::System.Collections.Generic;
    using MatchingWorkflowTypes;

    public class MatchingWorkflow : Humidifier.Base.BaseResource, IHaveTags, IHaveEntityResolutionMatchingWorkflowTypesResolutionTechniquesResolutionTechniques, IHaveDescription, IHaveListOfEntityResolutionMatchingWorkflowTypesInputSourceInputSourceConfig, IHaveWorkflowName, IHaveEntityResolutionMatchingWorkflowTypesIncrementalRunConfigIncrementalRunConfig, IHaveListOfEntityResolutionMatchingWorkflowTypesOutputSourceOutputSourceConfig, IHaveRoleArn
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string WorkflowArn =  "WorkflowArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.EntityResolution.MatchingWorkflow; }

        /// <summary>
        /// ResolutionTechniques
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-matchingworkflow.html#cfn-entityresolution-matchingworkflow-resolutiontechniques
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ResolutionTechniques
        /// </summary>
        [Required]
        public Union<Humidifier.EntityResolution.MatchingWorkflowTypes.ResolutionTechniques, BaseFunction>? ResolutionTechniques { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-matchingworkflow.html#cfn-entityresolution-matchingworkflow-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// InputSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-matchingworkflow.html#cfn-entityresolution-matchingworkflow-inputsourceconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InputSource
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.EntityResolution.MatchingWorkflowTypes.InputSource>, IReadOnlyList<Union<Humidifier.EntityResolution.MatchingWorkflowTypes.InputSource, BaseFunction>>, BaseFunction>? InputSourceConfig { get; set; }

        /// <summary>
        /// WorkflowName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-matchingworkflow.html#cfn-entityresolution-matchingworkflow-workflowname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? WorkflowName { get; set; }
        /// <summary>
        /// IncrementalRunConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-matchingworkflow.html#cfn-entityresolution-matchingworkflow-incrementalrunconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IncrementalRunConfig
        /// </summary>
        public Union<Humidifier.EntityResolution.MatchingWorkflowTypes.IncrementalRunConfig, BaseFunction>? IncrementalRunConfig { get; set; }

        /// <summary>
        /// OutputSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-matchingworkflow.html#cfn-entityresolution-matchingworkflow-outputsourceconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: OutputSource
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.EntityResolution.MatchingWorkflowTypes.OutputSource>, IReadOnlyList<Union<Humidifier.EntityResolution.MatchingWorkflowTypes.OutputSource, BaseFunction>>, BaseFunction>? OutputSourceConfig { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-matchingworkflow.html#cfn-entityresolution-matchingworkflow-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-matchingworkflow.html#cfn-entityresolution-matchingworkflow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace MatchingWorkflowTypes
    {
        public class CustomerProfilesIntegrationConfig : Humidifier.Base.BaseSubResource, IHaveDomainArn, IHaveObjectTypeArn
        {
            /// <summary>
            /// DomainArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-customerprofilesintegrationconfig.html#cfn-entityresolution-matchingworkflow-customerprofilesintegrationconfig-domainarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainArn { get; set; }
            /// <summary>
            /// ObjectTypeArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-customerprofilesintegrationconfig.html#cfn-entityresolution-matchingworkflow-customerprofilesintegrationconfig-objecttypearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectTypeArn { get; set; }
        }

        public class IncrementalRunConfig : Humidifier.Base.BaseSubResource, IHaveIncrementalRunType
        {
            /// <summary>
            /// IncrementalRunType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-incrementalrunconfig.html#cfn-entityresolution-matchingworkflow-incrementalrunconfig-incrementalruntype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IncrementalRunType { get; set; }
        }

        public class InputSource : Humidifier.Base.BaseSubResource, IHaveApplyNormalization_Boolean, IHaveInputSourceARN, IHaveSchemaArn
        {
            /// <summary>
            /// ApplyNormalization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-inputsource.html#cfn-entityresolution-matchingworkflow-inputsource-applynormalization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ApplyNormalization { get; set; }
            /// <summary>
            /// InputSourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-inputsource.html#cfn-entityresolution-matchingworkflow-inputsource-inputsourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputSourceARN { get; set; }
            /// <summary>
            /// SchemaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-inputsource.html#cfn-entityresolution-matchingworkflow-inputsource-schemaarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SchemaArn { get; set; }
        }

        public class IntermediateSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveIntermediateS3Path
        {
            /// <summary>
            /// IntermediateS3Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-intermediatesourceconfiguration.html#cfn-entityresolution-matchingworkflow-intermediatesourceconfiguration-intermediates3path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntermediateS3Path { get; set; }
        }

        public class MatchingConfig : Humidifier.Base.BaseSubResource, IHaveEnableTransitiveMatching_Boolean
        {
            /// <summary>
            /// EnableTransitiveMatching
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-matchingconfig.html#cfn-entityresolution-matchingworkflow-matchingconfig-enabletransitivematching
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableTransitiveMatching { get; set; }
        }

        public class OutputAttribute : Humidifier.Base.BaseSubResource, IHaveHashed_Boolean, IHaveName
        {
            /// <summary>
            /// Hashed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-outputattribute.html#cfn-entityresolution-matchingworkflow-outputattribute-hashed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Hashed { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-outputattribute.html#cfn-entityresolution-matchingworkflow-outputattribute-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class OutputSource : Humidifier.Base.BaseSubResource, IHaveKMSArn, IHaveOutputS3Path, IHaveListOfEntityResolutionMatchingWorkflowTypesOutputAttributeOutput, IHaveApplyNormalization_Boolean, IHaveEntityResolutionMatchingWorkflowTypesCustomerProfilesIntegrationConfigCustomerProfilesIntegrationConfig
        {
            /// <summary>
            /// KMSArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-outputsource.html#cfn-entityresolution-matchingworkflow-outputsource-kmsarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KMSArn { get; set; }
            /// <summary>
            /// OutputS3Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-outputsource.html#cfn-entityresolution-matchingworkflow-outputsource-outputs3path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputS3Path { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-outputsource.html#cfn-entityresolution-matchingworkflow-outputsource-output
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OutputAttribute
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EntityResolution.MatchingWorkflowTypes.OutputAttribute>, IReadOnlyList<Union<Humidifier.EntityResolution.MatchingWorkflowTypes.OutputAttribute, BaseFunction>>, BaseFunction>? Output { get; set; }
            /// <summary>
            /// ApplyNormalization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-outputsource.html#cfn-entityresolution-matchingworkflow-outputsource-applynormalization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ApplyNormalization { get; set; }
            /// <summary>
            /// CustomerProfilesIntegrationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-outputsource.html#cfn-entityresolution-matchingworkflow-outputsource-customerprofilesintegrationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomerProfilesIntegrationConfig
            /// </summary>
            public Union<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig, BaseFunction>? CustomerProfilesIntegrationConfig { get; set; }
        }

        public class ProviderProperties : Humidifier.Base.BaseSubResource, IHaveEntityResolutionMatchingWorkflowTypesIntermediateSourceConfigurationIntermediateSourceConfiguration, IHaveProviderServiceArn, IHaveStringDictionaryOfProviderConfiguration
        {
            /// <summary>
            /// IntermediateSourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-providerproperties.html#cfn-entityresolution-matchingworkflow-providerproperties-intermediatesourceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntermediateSourceConfiguration
            /// </summary>
            public Union<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration, BaseFunction>? IntermediateSourceConfiguration { get; set; }
            /// <summary>
            /// ProviderServiceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-providerproperties.html#cfn-entityresolution-matchingworkflow-providerproperties-providerservicearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProviderServiceArn { get; set; }
            /// <summary>
            /// ProviderConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-providerproperties.html#cfn-entityresolution-matchingworkflow-providerproperties-providerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ProviderConfiguration { get; set; }
        }

        public class ResolutionTechniques : Humidifier.Base.BaseSubResource, IHaveEntityResolutionMatchingWorkflowTypesRuleBasedPropertiesRuleBasedProperties, IHaveEntityResolutionMatchingWorkflowTypesProviderPropertiesProviderProperties, IHaveResolutionType, IHaveEntityResolutionMatchingWorkflowTypesRuleConditionPropertiesRuleConditionProperties, IHaveEnableRealTimeMatching_Boolean
        {
            /// <summary>
            /// RuleBasedProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-resolutiontechniques.html#cfn-entityresolution-matchingworkflow-resolutiontechniques-rulebasedproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleBasedProperties
            /// </summary>
            public Union<Humidifier.EntityResolution.MatchingWorkflowTypes.RuleBasedProperties, BaseFunction>? RuleBasedProperties { get; set; }
            /// <summary>
            /// ProviderProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-resolutiontechniques.html#cfn-entityresolution-matchingworkflow-resolutiontechniques-providerproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProviderProperties
            /// </summary>
            public Union<Humidifier.EntityResolution.MatchingWorkflowTypes.ProviderProperties, BaseFunction>? ProviderProperties { get; set; }
            /// <summary>
            /// ResolutionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-resolutiontechniques.html#cfn-entityresolution-matchingworkflow-resolutiontechniques-resolutiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResolutionType { get; set; }
            /// <summary>
            /// RuleConditionProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-resolutiontechniques.html#cfn-entityresolution-matchingworkflow-resolutiontechniques-ruleconditionproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleConditionProperties
            /// </summary>
            public Union<Humidifier.EntityResolution.MatchingWorkflowTypes.RuleConditionProperties, BaseFunction>? RuleConditionProperties { get; set; }
            /// <summary>
            /// EnableRealTimeMatching
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-resolutiontechniques.html#cfn-entityresolution-matchingworkflow-resolutiontechniques-enablerealtimematching
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableRealTimeMatching { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveStringListOfMatchingKeys, IHaveRuleName
        {
            /// <summary>
            /// MatchingKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-rule.html#cfn-entityresolution-matchingworkflow-rule-matchingkeys
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchingKeys { get; set; }
            /// <summary>
            /// RuleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-rule.html#cfn-entityresolution-matchingworkflow-rule-rulename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleName { get; set; }
        }

        public class RuleBasedProperties : Humidifier.Base.BaseSubResource, IHaveAttributeMatchingModel, IHaveMatchPurpose, IHaveListOfEntityResolutionMatchingWorkflowTypesRuleRules
        {
            /// <summary>
            /// AttributeMatchingModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-rulebasedproperties.html#cfn-entityresolution-matchingworkflow-rulebasedproperties-attributematchingmodel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeMatchingModel { get; set; }
            /// <summary>
            /// MatchPurpose
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-rulebasedproperties.html#cfn-entityresolution-matchingworkflow-rulebasedproperties-matchpurpose
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchPurpose { get; set; }
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-rulebasedproperties.html#cfn-entityresolution-matchingworkflow-rulebasedproperties-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Rule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EntityResolution.MatchingWorkflowTypes.Rule>, IReadOnlyList<Union<Humidifier.EntityResolution.MatchingWorkflowTypes.Rule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        }

        public class RuleCondition : Humidifier.Base.BaseSubResource, IHaveCondition, IHaveRuleName
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-rulecondition.html#cfn-entityresolution-matchingworkflow-rulecondition-condition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// RuleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-rulecondition.html#cfn-entityresolution-matchingworkflow-rulecondition-rulename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleName { get; set; }
        }

        public class RuleConditionProperties : Humidifier.Base.BaseSubResource, IHaveEntityResolutionMatchingWorkflowTypesMatchingConfigMatchingConfig, IHaveListOfEntityResolutionMatchingWorkflowTypesRuleConditionRules
        {
            /// <summary>
            /// MatchingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-ruleconditionproperties.html#cfn-entityresolution-matchingworkflow-ruleconditionproperties-matchingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchingConfig
            /// </summary>
            public Union<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig, BaseFunction>? MatchingConfig { get; set; }
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-matchingworkflow-ruleconditionproperties.html#cfn-entityresolution-matchingworkflow-ruleconditionproperties-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RuleCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EntityResolution.MatchingWorkflowTypes.RuleCondition>, IReadOnlyList<Union<Humidifier.EntityResolution.MatchingWorkflowTypes.RuleCondition, BaseFunction>>, BaseFunction>? Rules { get; set; }
        }
    }
}