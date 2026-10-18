namespace Humidifier.Greengrass
{
    using global::System.Collections.Generic;
    using ConnectorDefinitionVersionTypes;

    public class ConnectorDefinitionVersion : Humidifier.Base.BaseResource, IHaveListOfGreengrassConnectorDefinitionVersionTypesConnectorConnectors, IHaveConnectorDefinitionId
    {
        public override string AWSTypeName { get => AWS.Greengrass.ConnectorDefinitionVersion; }

        /// <summary>
        /// Connectors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-connectordefinitionversion.html#cfn-greengrass-connectordefinitionversion-connectors
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Connector
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector>, IReadOnlyList<Union<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector, BaseFunction>>, BaseFunction>? Connectors { get; set; }

        /// <summary>
        /// ConnectorDefinitionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-connectordefinitionversion.html#cfn-greengrass-connectordefinitionversion-connectordefinitionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConnectorDefinitionId { get; set; }
    }

    namespace ConnectorDefinitionVersionTypes
    {
        public class Connector : Humidifier.Base.BaseSubResource, IHaveConnectorArn, IHaveParameters_Json, IHaveId
        {
            /// <summary>
            /// ConnectorArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-connectordefinitionversion-connector.html#cfn-greengrass-connectordefinitionversion-connector-connectorarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectorArn { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-connectordefinitionversion-connector.html#cfn-greengrass-connectordefinitionversion-connector-parameters
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-connectordefinitionversion-connector.html#cfn-greengrass-connectordefinitionversion-connector-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }
    }
}