namespace Humidifier.Bedrock
{
    using System.Collections.Generic;
    using AgentAliasTypes;

    public class AgentAlias : Humidifier.Resource, IHaveDescription
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

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Bedrock::AgentAlias";
            }
        }

        /// <summary>
        /// AgentAliasName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agentalias.html#cfn-bedrock-agentalias-agentaliasname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AgentAliasName { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agentalias.html#cfn-bedrock-agentalias-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// RoutingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agentalias.html#cfn-bedrock-agentalias-routingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AgentAliasRoutingConfigurationListItem
        /// </summary>
        public List<AgentAliasRoutingConfigurationListItem> RoutingConfiguration { get; set; }
        /// <summary>
        /// AgentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agentalias.html#cfn-bedrock-agentalias-agentid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AgentId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agentalias.html#cfn-bedrock-agentalias-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }

    namespace AgentAliasTypes
    {
        public class AgentAliasHistoryEvent
        {
            /// <summary>
            /// StartDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agentalias-agentaliashistoryevent.html#cfn-bedrock-agentalias-agentaliashistoryevent-startdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartDate { get; set; }
            /// <summary>
            /// RoutingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agentalias-agentaliashistoryevent.html#cfn-bedrock-agentalias-agentaliashistoryevent-routingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AgentAliasRoutingConfigurationListItem
            /// </summary>
            public List<AgentAliasRoutingConfigurationListItem> RoutingConfiguration { get; set; }
            /// <summary>
            /// EndDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agentalias-agentaliashistoryevent.html#cfn-bedrock-agentalias-agentaliashistoryevent-enddate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndDate { get; set; }
        }

        public class AgentAliasRoutingConfigurationListItem
        {
            /// <summary>
            /// AgentVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agentalias-agentaliasroutingconfigurationlistitem.html#cfn-bedrock-agentalias-agentaliasroutingconfigurationlistitem-agentversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AgentVersion { get; set; }
        }
    }
}