namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using FlowAliasTypes;

    public class FlowAlias : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveBedrockFlowAliasTypesFlowAliasConcurrencyConfigurationConcurrencyConfiguration, IHaveListOfBedrockFlowAliasTypesFlowAliasRoutingConfigurationListItemRoutingConfiguration, IHaveFlowArn, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string FlowId =  "FlowId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.FlowAlias; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flowalias.html#cfn-bedrock-flowalias-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ConcurrencyConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flowalias.html#cfn-bedrock-flowalias-concurrencyconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FlowAliasConcurrencyConfiguration
        /// </summary>
        public Union<Humidifier.Bedrock.FlowAliasTypes.FlowAliasConcurrencyConfiguration, BaseFunction>? ConcurrencyConfiguration { get; set; }

        /// <summary>
        /// RoutingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flowalias.html#cfn-bedrock-flowalias-routingconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FlowAliasRoutingConfigurationListItem
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem>, IReadOnlyList<Union<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem, BaseFunction>>, BaseFunction>? RoutingConfiguration { get; set; }

        /// <summary>
        /// FlowArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flowalias.html#cfn-bedrock-flowalias-flowarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FlowArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flowalias.html#cfn-bedrock-flowalias-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace FlowAliasTypes
    {
        public class FlowAliasConcurrencyConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveMaxConcurrency_Double
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowalias-flowaliasconcurrencyconfiguration.html#cfn-bedrock-flowalias-flowaliasconcurrencyconfiguration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// MaxConcurrency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowalias-flowaliasconcurrencyconfiguration.html#cfn-bedrock-flowalias-flowaliasconcurrencyconfiguration-maxconcurrency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxConcurrency { get; set; }
        }

        public class FlowAliasRoutingConfigurationListItem : Humidifier.Base.BaseSubResource, IHaveFlowVersion
        {
            /// <summary>
            /// FlowVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowalias-flowaliasroutingconfigurationlistitem.html#cfn-bedrock-flowalias-flowaliasroutingconfigurationlistitem-flowversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FlowVersion { get; set; }
        }
    }
}