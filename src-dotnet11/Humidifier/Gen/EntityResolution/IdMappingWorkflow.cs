namespace Humidifier.EntityResolution
{
    using global::System.Collections.Generic;
    using IdMappingWorkflowTypes;

    public class IdMappingWorkflow : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveListOfEntityResolutionIdMappingWorkflowTypesIdMappingWorkflowInputSourceInputSourceConfig, IHaveEntityResolutionIdMappingWorkflowTypesIdMappingTechniquesIdMappingTechniques, IHaveWorkflowName, IHaveListOfEntityResolutionIdMappingWorkflowTypesIdMappingWorkflowOutputSourceOutputSourceConfig, IHaveEntityResolutionIdMappingWorkflowTypesIdMappingIncrementalRunConfigIdMappingIncrementalRunConfig, IHaveRoleArn
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string WorkflowArn =  "WorkflowArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.EntityResolution.IdMappingWorkflow; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idmappingworkflow.html#cfn-entityresolution-idmappingworkflow-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// InputSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idmappingworkflow.html#cfn-entityresolution-idmappingworkflow-inputsourceconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IdMappingWorkflowInputSource
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource>, IReadOnlyList<Union<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource, BaseFunction>>, BaseFunction>? InputSourceConfig { get; set; }

        /// <summary>
        /// IdMappingTechniques
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idmappingworkflow.html#cfn-entityresolution-idmappingworkflow-idmappingtechniques
        /// Required: True
        /// UpdateType: Mutable
        /// Type: IdMappingTechniques
        /// </summary>
        [Required]
        public Union<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingTechniques, BaseFunction>? IdMappingTechniques { get; set; }

        /// <summary>
        /// WorkflowName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idmappingworkflow.html#cfn-entityresolution-idmappingworkflow-workflowname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? WorkflowName { get; set; }
        /// <summary>
        /// OutputSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idmappingworkflow.html#cfn-entityresolution-idmappingworkflow-outputsourceconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IdMappingWorkflowOutputSource
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource>, IReadOnlyList<Union<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource, BaseFunction>>, BaseFunction>? OutputSourceConfig { get; set; }
        /// <summary>
        /// IdMappingIncrementalRunConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idmappingworkflow.html#cfn-entityresolution-idmappingworkflow-idmappingincrementalrunconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IdMappingIncrementalRunConfig
        /// </summary>
        public Union<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingIncrementalRunConfig, BaseFunction>? IdMappingIncrementalRunConfig { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idmappingworkflow.html#cfn-entityresolution-idmappingworkflow-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idmappingworkflow.html#cfn-entityresolution-idmappingworkflow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace IdMappingWorkflowTypes
    {
        public class IdMappingIncrementalRunConfig : Humidifier.Base.BaseSubResource, IHaveIncrementalRunType
        {
            /// <summary>
            /// IncrementalRunType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingincrementalrunconfig.html#cfn-entityresolution-idmappingworkflow-idmappingincrementalrunconfig-incrementalruntype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IncrementalRunType { get; set; }
        }

        public class IdMappingRuleBasedProperties : Humidifier.Base.BaseSubResource, IHaveAttributeMatchingModel, IHaveRuleDefinitionType, IHaveListOfEntityResolutionIdMappingWorkflowTypesRuleRules, IHaveRecordMatchingModel
        {
            /// <summary>
            /// AttributeMatchingModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingrulebasedproperties.html#cfn-entityresolution-idmappingworkflow-idmappingrulebasedproperties-attributematchingmodel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeMatchingModel { get; set; }
            /// <summary>
            /// RuleDefinitionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingrulebasedproperties.html#cfn-entityresolution-idmappingworkflow-idmappingrulebasedproperties-ruledefinitiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleDefinitionType { get; set; }
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingrulebasedproperties.html#cfn-entityresolution-idmappingworkflow-idmappingrulebasedproperties-rules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Rule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EntityResolution.IdMappingWorkflowTypes.Rule>, IReadOnlyList<Union<Humidifier.EntityResolution.IdMappingWorkflowTypes.Rule, BaseFunction>>, BaseFunction>? Rules { get; set; }
            /// <summary>
            /// RecordMatchingModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingrulebasedproperties.html#cfn-entityresolution-idmappingworkflow-idmappingrulebasedproperties-recordmatchingmodel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordMatchingModel { get; set; }
        }

        public class IdMappingTechniques : Humidifier.Base.BaseSubResource, IHaveEntityResolutionIdMappingWorkflowTypesIdMappingRuleBasedPropertiesRuleBasedProperties, IHaveEntityResolutionIdMappingWorkflowTypesProviderPropertiesProviderProperties, IHaveIdMappingType, IHaveNormalizationVersion
        {
            /// <summary>
            /// RuleBasedProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingtechniques.html#cfn-entityresolution-idmappingworkflow-idmappingtechniques-rulebasedproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IdMappingRuleBasedProperties
            /// </summary>
            public Union<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingRuleBasedProperties, BaseFunction>? RuleBasedProperties { get; set; }
            /// <summary>
            /// ProviderProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingtechniques.html#cfn-entityresolution-idmappingworkflow-idmappingtechniques-providerproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProviderProperties
            /// </summary>
            public Union<Humidifier.EntityResolution.IdMappingWorkflowTypes.ProviderProperties, BaseFunction>? ProviderProperties { get; set; }
            /// <summary>
            /// IdMappingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingtechniques.html#cfn-entityresolution-idmappingworkflow-idmappingtechniques-idmappingtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdMappingType { get; set; }
            /// <summary>
            /// NormalizationVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingtechniques.html#cfn-entityresolution-idmappingworkflow-idmappingtechniques-normalizationversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NormalizationVersion { get; set; }
        }

        public class IdMappingWorkflowInputSource : Humidifier.Base.BaseSubResource, IHaveType, IHaveInputSourceARN, IHaveSchemaArn
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingworkflowinputsource.html#cfn-entityresolution-idmappingworkflow-idmappingworkflowinputsource-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// InputSourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingworkflowinputsource.html#cfn-entityresolution-idmappingworkflow-idmappingworkflowinputsource-inputsourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputSourceARN { get; set; }
            /// <summary>
            /// SchemaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingworkflowinputsource.html#cfn-entityresolution-idmappingworkflow-idmappingworkflowinputsource-schemaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SchemaArn { get; set; }
        }

        public class IdMappingWorkflowOutputSource : Humidifier.Base.BaseSubResource, IHaveKMSArn, IHaveOutputS3Path
        {
            /// <summary>
            /// KMSArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingworkflowoutputsource.html#cfn-entityresolution-idmappingworkflow-idmappingworkflowoutputsource-kmsarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KMSArn { get; set; }
            /// <summary>
            /// OutputS3Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingworkflowoutputsource.html#cfn-entityresolution-idmappingworkflow-idmappingworkflowoutputsource-outputs3path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputS3Path { get; set; }
        }

        public class IntermediateSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveIntermediateS3Path
        {
            /// <summary>
            /// IntermediateS3Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-intermediatesourceconfiguration.html#cfn-entityresolution-idmappingworkflow-intermediatesourceconfiguration-intermediates3path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntermediateS3Path { get; set; }
        }

        public class ProviderProperties : Humidifier.Base.BaseSubResource, IHaveEntityResolutionIdMappingWorkflowTypesIntermediateSourceConfigurationIntermediateSourceConfiguration, IHaveProviderServiceArn, IHaveStringDictionaryOfProviderConfiguration
        {
            /// <summary>
            /// IntermediateSourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-providerproperties.html#cfn-entityresolution-idmappingworkflow-providerproperties-intermediatesourceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntermediateSourceConfiguration
            /// </summary>
            public Union<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration, BaseFunction>? IntermediateSourceConfiguration { get; set; }
            /// <summary>
            /// ProviderServiceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-providerproperties.html#cfn-entityresolution-idmappingworkflow-providerproperties-providerservicearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProviderServiceArn { get; set; }
            /// <summary>
            /// ProviderConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-providerproperties.html#cfn-entityresolution-idmappingworkflow-providerproperties-providerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ProviderConfiguration { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveStringListOfMatchingKeys, IHaveRuleName
        {
            /// <summary>
            /// MatchingKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-rule.html#cfn-entityresolution-idmappingworkflow-rule-matchingkeys
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchingKeys { get; set; }
            /// <summary>
            /// RuleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-rule.html#cfn-entityresolution-idmappingworkflow-rule-rulename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleName { get; set; }
        }
    }
}