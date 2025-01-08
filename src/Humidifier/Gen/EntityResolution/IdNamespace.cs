namespace Humidifier.EntityResolution
{
    using System.Collections.Generic;
    using IdNamespaceTypes;

    public class IdNamespace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveType, IHaveRoleArn
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string IdNamespaceArn =  "IdNamespaceArn" ;
        }

        public override string AWSTypeName { get => AWS.EntityResolution.IdNamespace; }
        public dynamic IdNamespaceName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idnamespace.html#cfn-entityresolution-idnamespace-type
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idnamespace.html#cfn-entityresolution-idnamespace-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// InputSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idnamespace.html#cfn-entityresolution-idnamespace-inputsourceconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IdNamespaceInputSource
        /// </summary>
        public List<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource> InputSourceConfig { get; set; }
        /// <summary>
        /// IdMappingWorkflowProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idnamespace.html#cfn-entityresolution-idnamespace-idmappingworkflowproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IdNamespaceIdMappingWorkflowProperties
        /// </summary>
        public List<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties> IdMappingWorkflowProperties { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idnamespace.html#cfn-entityresolution-idnamespace-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-idnamespace.html#cfn-entityresolution-idnamespace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace IdNamespaceTypes
    {
        public class IdNamespaceIdMappingWorkflowProperties : Humidifier.Base.BaseSubResource, IHaveIdMappingType
        {
            /// <summary>
            /// RuleBasedProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-idnamespaceidmappingworkflowproperties.html#cfn-entityresolution-idnamespace-idnamespaceidmappingworkflowproperties-rulebasedproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NamespaceRuleBasedProperties
            /// </summary>
            public Humidifier.EntityResolution.IdNamespaceTypes.NamespaceRuleBasedProperties RuleBasedProperties { get; set; }
            /// <summary>
            /// ProviderProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-idnamespaceidmappingworkflowproperties.html#cfn-entityresolution-idnamespace-idnamespaceidmappingworkflowproperties-providerproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NamespaceProviderProperties
            /// </summary>
            public Humidifier.EntityResolution.IdNamespaceTypes.NamespaceProviderProperties ProviderProperties { get; set; }
            /// <summary>
            /// IdMappingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-idnamespaceidmappingworkflowproperties.html#cfn-entityresolution-idnamespace-idnamespaceidmappingworkflowproperties-idmappingtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdMappingType { get; set; }
        }

        public class IdNamespaceInputSource : Humidifier.Base.BaseSubResource, IHaveSchemaName, IHaveInputSourceARN
        {
            /// <summary>
            /// InputSourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-idnamespaceinputsource.html#cfn-entityresolution-idnamespace-idnamespaceinputsource-inputsourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputSourceARN { get; set; }
            /// <summary>
            /// SchemaName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-idnamespaceinputsource.html#cfn-entityresolution-idnamespace-idnamespaceinputsource-schemaname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SchemaName { get; set; }
        }

        public class NamespaceProviderProperties : Humidifier.Base.BaseSubResource, IHaveProviderServiceArn
        {
            /// <summary>
            /// ProviderServiceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-namespaceproviderproperties.html#cfn-entityresolution-idnamespace-namespaceproviderproperties-providerservicearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProviderServiceArn { get; set; }
            /// <summary>
            /// ProviderConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-namespaceproviderproperties.html#cfn-entityresolution-idnamespace-namespaceproviderproperties-providerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> ProviderConfiguration { get; set; }
        }

        public class NamespaceRuleBasedProperties : Humidifier.Base.BaseSubResource, IHaveAttributeMatchingModel
        {
            /// <summary>
            /// AttributeMatchingModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-namespacerulebasedproperties.html#cfn-entityresolution-idnamespace-namespacerulebasedproperties-attributematchingmodel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeMatchingModel { get; set; }
            /// <summary>
            /// RuleDefinitionTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-namespacerulebasedproperties.html#cfn-entityresolution-idnamespace-namespacerulebasedproperties-ruledefinitiontypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic RuleDefinitionTypes { get; set; }
            /// <summary>
            /// RecordMatchingModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-namespacerulebasedproperties.html#cfn-entityresolution-idnamespace-namespacerulebasedproperties-recordmatchingmodels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic RecordMatchingModels { get; set; }
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-namespacerulebasedproperties.html#cfn-entityresolution-idnamespace-namespacerulebasedproperties-rules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Rule
            /// </summary>
            public List<Humidifier.EntityResolution.IdNamespaceTypes.Rule> Rules { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveRuleName, IHaveMatchingKeys
        {
            /// <summary>
            /// MatchingKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-rule.html#cfn-entityresolution-idnamespace-rule-matchingkeys
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchingKeys { get; set; }
            /// <summary>
            /// RuleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-idnamespace-rule.html#cfn-entityresolution-idnamespace-rule-rulename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleName { get; set; }
        }
    }
}