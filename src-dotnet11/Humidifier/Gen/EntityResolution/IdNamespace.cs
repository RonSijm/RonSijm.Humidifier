namespace Humidifier.EntityResolution
{
    using global::System.Collections.Generic;
    using IdNamespaceTypes;

    public class IdNamespace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIdNamespaceName, IHaveType, IHaveDescription, IHaveListOfEntityResolutionIdNamespaceTypesIdNamespaceInputSourceInputSourceConfig, IHaveListOfEntityResolutionIdNamespaceTypesIdNamespaceIdMappingWorkflowPropertiesIdMappingWorkflowProperties, IHaveRoleArn
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string IdNamespaceArn =  "IdNamespaceArn" ;
        }

        public override string AWSTypeName { get => AWS.EntityResolution.IdNamespace; }
        public Union<string, BaseFunction>? IdNamespaceName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idnamespace.html#cfn-entityresolution-idnamespace-type
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idnamespace.html#cfn-entityresolution-idnamespace-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// InputSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idnamespace.html#cfn-entityresolution-idnamespace-inputsourceconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IdNamespaceInputSource
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource>, IReadOnlyList<Union<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource, BaseFunction>>, BaseFunction>? InputSourceConfig { get; set; }
        /// <summary>
        /// IdMappingWorkflowProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idnamespace.html#cfn-entityresolution-idnamespace-idmappingworkflowproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IdNamespaceIdMappingWorkflowProperties
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties>, IReadOnlyList<Union<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties, BaseFunction>>, BaseFunction>? IdMappingWorkflowProperties { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idnamespace.html#cfn-entityresolution-idnamespace-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idnamespace.html#cfn-entityresolution-idnamespace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace IdNamespaceTypes
    {
        public class IdNamespaceIdMappingWorkflowProperties : Humidifier.Base.BaseSubResource, IHaveEntityResolutionIdNamespaceTypesNamespaceRuleBasedPropertiesRuleBasedProperties, IHaveEntityResolutionIdNamespaceTypesNamespaceProviderPropertiesProviderProperties, IHaveIdMappingType
        {
            /// <summary>
            /// RuleBasedProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-idnamespaceidmappingworkflowproperties.html#cfn-entityresolution-idnamespace-idnamespaceidmappingworkflowproperties-rulebasedproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NamespaceRuleBasedProperties
            /// </summary>
            public Union<Humidifier.EntityResolution.IdNamespaceTypes.NamespaceRuleBasedProperties, BaseFunction>? RuleBasedProperties { get; set; }
            /// <summary>
            /// ProviderProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-idnamespaceidmappingworkflowproperties.html#cfn-entityresolution-idnamespace-idnamespaceidmappingworkflowproperties-providerproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NamespaceProviderProperties
            /// </summary>
            public Union<Humidifier.EntityResolution.IdNamespaceTypes.NamespaceProviderProperties, BaseFunction>? ProviderProperties { get; set; }
            /// <summary>
            /// IdMappingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-idnamespaceidmappingworkflowproperties.html#cfn-entityresolution-idnamespace-idnamespaceidmappingworkflowproperties-idmappingtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdMappingType { get; set; }
        }

        public class IdNamespaceInputSource : Humidifier.Base.BaseSubResource, IHaveInputSourceARN, IHaveSchemaName
        {
            /// <summary>
            /// InputSourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-idnamespaceinputsource.html#cfn-entityresolution-idnamespace-idnamespaceinputsource-inputsourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputSourceARN { get; set; }
            /// <summary>
            /// SchemaName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-idnamespaceinputsource.html#cfn-entityresolution-idnamespace-idnamespaceinputsource-schemaname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SchemaName { get; set; }
        }

        public class NamespaceProviderProperties : Humidifier.Base.BaseSubResource, IHaveProviderServiceArn, IHaveStringDictionaryOfProviderConfiguration
        {
            /// <summary>
            /// ProviderServiceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-namespaceproviderproperties.html#cfn-entityresolution-idnamespace-namespaceproviderproperties-providerservicearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProviderServiceArn { get; set; }
            /// <summary>
            /// ProviderConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-namespaceproviderproperties.html#cfn-entityresolution-idnamespace-namespaceproviderproperties-providerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ProviderConfiguration { get; set; }
        }

        public class NamespaceRuleBasedProperties : Humidifier.Base.BaseSubResource, IHaveAttributeMatchingModel, IHaveStringListOfRuleDefinitionTypes, IHaveStringListOfRecordMatchingModels, IHaveListOfEntityResolutionIdNamespaceTypesRuleRules
        {
            /// <summary>
            /// AttributeMatchingModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-namespacerulebasedproperties.html#cfn-entityresolution-idnamespace-namespacerulebasedproperties-attributematchingmodel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeMatchingModel { get; set; }
            /// <summary>
            /// RuleDefinitionTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-namespacerulebasedproperties.html#cfn-entityresolution-idnamespace-namespacerulebasedproperties-ruledefinitiontypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RuleDefinitionTypes { get; set; }
            /// <summary>
            /// RecordMatchingModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-namespacerulebasedproperties.html#cfn-entityresolution-idnamespace-namespacerulebasedproperties-recordmatchingmodels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RecordMatchingModels { get; set; }
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-namespacerulebasedproperties.html#cfn-entityresolution-idnamespace-namespacerulebasedproperties-rules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Rule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EntityResolution.IdNamespaceTypes.Rule>, IReadOnlyList<Union<Humidifier.EntityResolution.IdNamespaceTypes.Rule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveStringListOfMatchingKeys, IHaveRuleName
        {
            /// <summary>
            /// MatchingKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-rule.html#cfn-entityresolution-idnamespace-rule-matchingkeys
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchingKeys { get; set; }
            /// <summary>
            /// RuleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-rule.html#cfn-entityresolution-idnamespace-rule-rulename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleName { get; set; }
        }
    }
}