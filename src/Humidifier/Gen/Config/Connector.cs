namespace Humidifier.Config
{
    using global::System.Collections.Generic;
    using ConnectorTypes;

    public class Connector : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Config.Connector; }

        /// <summary>
        /// ConnectorConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-connector.html#cfn-config-connector-connectorconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ConnectorConfiguration
        /// </summary>
        [Required]
        public Humidifier.Config.ConnectorTypes.ConnectorConfiguration ConnectorConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-connector.html#cfn-config-connector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ConnectorTypes
    {
        public class AzureConnectorConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TenantIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-connector-azureconnectorconfiguration.html#cfn-config-connector-azureconnectorconfiguration-tenantidentifier
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TenantIdentifier { get; set; }
            /// <summary>
            /// ClientIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-connector-azureconnectorconfiguration.html#cfn-config-connector-azureconnectorconfiguration-clientidentifier
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientIdentifier { get; set; }
        }

        public class ConnectorConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Azure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-connector-connectorconfiguration.html#cfn-config-connector-connectorconfiguration-azure
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AzureConnectorConfiguration
            /// </summary>
            public Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration Azure { get; set; }
        }
    }
}