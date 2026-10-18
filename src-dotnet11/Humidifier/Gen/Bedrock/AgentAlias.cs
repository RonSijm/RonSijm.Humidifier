namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using AgentAliasTypes;

    public class AgentAlias : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveAgentAliasName, IHaveDescription, IHaveListOfBedrockAgentAliasTypesAgentAliasRoutingConfigurationListItemRoutingConfiguration, IHaveAgentId, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string AgentAliasStatus =  "AgentAliasStatus" ;
            public static string AgentAliasArn =  "AgentAliasArn" ;
            public static string AgentAliasHistoryEvents =  "AgentAliasHistoryEvents" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string AgentAliasId =  "AgentAliasId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.AgentAlias; }
        public Union<string, BaseFunction>? AgentAliasName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agentalias.html#cfn-bedrock-agentalias-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// RoutingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agentalias.html#cfn-bedrock-agentalias-routingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AgentAliasRoutingConfigurationListItem
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem>, IReadOnlyList<Union<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem, BaseFunction>>, BaseFunction>? RoutingConfiguration { get; set; }

        /// <summary>
        /// AgentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agentalias.html#cfn-bedrock-agentalias-agentid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AgentId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agentalias.html#cfn-bedrock-agentalias-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace AgentAliasTypes
    {
        public class AgentAliasHistoryEvent : Humidifier.Base.BaseSubResource, IHaveStartDate, IHaveListOfBedrockAgentAliasTypesAgentAliasRoutingConfigurationListItemRoutingConfiguration, IHaveEndDate
        {
            /// <summary>
            /// StartDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agentalias-agentaliashistoryevent.html#cfn-bedrock-agentalias-agentaliashistoryevent-startdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartDate { get; set; }
            /// <summary>
            /// RoutingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agentalias-agentaliashistoryevent.html#cfn-bedrock-agentalias-agentaliashistoryevent-routingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AgentAliasRoutingConfigurationListItem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem>, IReadOnlyList<Union<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem, BaseFunction>>, BaseFunction>? RoutingConfiguration { get; set; }
            /// <summary>
            /// EndDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agentalias-agentaliashistoryevent.html#cfn-bedrock-agentalias-agentaliashistoryevent-enddate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndDate { get; set; }
        }

        public class AgentAliasRoutingConfigurationListItem : Humidifier.Base.BaseSubResource, IHaveAgentVersion
        {
            /// <summary>
            /// AgentVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agentalias-agentaliasroutingconfigurationlistitem.html#cfn-bedrock-agentalias-agentaliasroutingconfigurationlistitem-agentversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AgentVersion { get; set; }
        }
    }
}