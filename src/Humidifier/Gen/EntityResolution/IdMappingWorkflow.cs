namespace Humidifier.EntityResolution
{
    using System.Collections.Generic;
    using IdMappingWorkflowTypes;

    public class IdMappingWorkflow : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveRoleArn, IHaveWorkflowName
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
        public dynamic Description { get; set; }

        /// <summary>
        /// InputSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idmappingworkflow.html#cfn-entityresolution-idmappingworkflow-inputsourceconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IdMappingWorkflowInputSource
        /// </summary>
        [Required]
        public List<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource> InputSourceConfig { get; set; }

        /// <summary>
        /// IdMappingTechniques
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idmappingworkflow.html#cfn-entityresolution-idmappingworkflow-idmappingtechniques
        /// Required: True
        /// UpdateType: Mutable
        /// Type: IdMappingTechniques
        /// </summary>
        [Required]
        public Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingTechniques IdMappingTechniques { get; set; }

        /// <summary>
        /// WorkflowName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idmappingworkflow.html#cfn-entityresolution-idmappingworkflow-workflowname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic WorkflowName { get; set; }
        /// <summary>
        /// OutputSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idmappingworkflow.html#cfn-entityresolution-idmappingworkflow-outputsourceconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IdMappingWorkflowOutputSource
        /// </summary>
        public List<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource> OutputSourceConfig { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idmappingworkflow.html#cfn-entityresolution-idmappingworkflow-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idmappingworkflow.html#cfn-entityresolution-idmappingworkflow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace IdMappingWorkflowTypes
    {
        public class IdMappingRuleBasedProperties : Humidifier.Base.BaseSubResource, IHaveAttributeMatchingModel
        {
            /// <summary>
            /// AttributeMatchingModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingrulebasedproperties.html#cfn-entityresolution-idmappingworkflow-idmappingrulebasedproperties-attributematchingmodel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeMatchingModel { get; set; }
            /// <summary>
            /// RuleDefinitionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingrulebasedproperties.html#cfn-entityresolution-idmappingworkflow-idmappingrulebasedproperties-ruledefinitiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleDefinitionType { get; set; }
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingrulebasedproperties.html#cfn-entityresolution-idmappingworkflow-idmappingrulebasedproperties-rules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Rule
            /// </summary>
            public List<Humidifier.EntityResolution.IdMappingWorkflowTypes.Rule> Rules { get; set; }
            /// <summary>
            /// RecordMatchingModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingrulebasedproperties.html#cfn-entityresolution-idmappingworkflow-idmappingrulebasedproperties-recordmatchingmodel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordMatchingModel { get; set; }
        }

        public class IdMappingTechniques : Humidifier.Base.BaseSubResource, IHaveIdMappingType
        {
            /// <summary>
            /// RuleBasedProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingtechniques.html#cfn-entityresolution-idmappingworkflow-idmappingtechniques-rulebasedproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IdMappingRuleBasedProperties
            /// </summary>
            public Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingRuleBasedProperties RuleBasedProperties { get; set; }
            /// <summary>
            /// ProviderProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingtechniques.html#cfn-entityresolution-idmappingworkflow-idmappingtechniques-providerproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProviderProperties
            /// </summary>
            public Humidifier.EntityResolution.IdMappingWorkflowTypes.ProviderProperties ProviderProperties { get; set; }
            /// <summary>
            /// IdMappingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingtechniques.html#cfn-entityresolution-idmappingworkflow-idmappingtechniques-idmappingtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdMappingType { get; set; }
        }

        public class IdMappingWorkflowInputSource : Humidifier.Base.BaseSubResource, IHaveType, IHaveSchemaArn, IHaveInputSourceARN
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingworkflowinputsource.html#cfn-entityresolution-idmappingworkflow-idmappingworkflowinputsource-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// InputSourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingworkflowinputsource.html#cfn-entityresolution-idmappingworkflow-idmappingworkflowinputsource-inputsourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputSourceARN { get; set; }
            /// <summary>
            /// SchemaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingworkflowinputsource.html#cfn-entityresolution-idmappingworkflow-idmappingworkflowinputsource-schemaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SchemaArn { get; set; }
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
            public dynamic KMSArn { get; set; }
            /// <summary>
            /// OutputS3Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-idmappingworkflowoutputsource.html#cfn-entityresolution-idmappingworkflow-idmappingworkflowoutputsource-outputs3path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputS3Path { get; set; }
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
            public dynamic IntermediateS3Path { get; set; }
        }

        public class ProviderProperties : Humidifier.Base.BaseSubResource, IHaveProviderServiceArn
        {
            /// <summary>
            /// IntermediateSourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-providerproperties.html#cfn-entityresolution-idmappingworkflow-providerproperties-intermediatesourceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntermediateSourceConfiguration
            /// </summary>
            public Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration IntermediateSourceConfiguration { get; set; }
            /// <summary>
            /// ProviderServiceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-providerproperties.html#cfn-entityresolution-idmappingworkflow-providerproperties-providerservicearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProviderServiceArn { get; set; }
            /// <summary>
            /// ProviderConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-providerproperties.html#cfn-entityresolution-idmappingworkflow-providerproperties-providerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> ProviderConfiguration { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveRuleName, IHaveMatchingKeys
        {
            /// <summary>
            /// MatchingKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-rule.html#cfn-entityresolution-idmappingworkflow-rule-matchingkeys
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchingKeys { get; set; }
            /// <summary>
            /// RuleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idmappingworkflow-rule.html#cfn-entityresolution-idmappingworkflow-rule-rulename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleName { get; set; }
        }
    }
}