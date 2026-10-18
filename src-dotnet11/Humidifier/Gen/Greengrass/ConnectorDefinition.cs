namespace Humidifier.Greengrass
{
    using global::System.Collections.Generic;
    using ConnectorDefinitionTypes;

    public class ConnectorDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveGreengrassConnectorDefinitionTypesConnectorDefinitionVersionInitialVersion, IHaveTags_Json, IHaveName
    {
        public class Attributes
        {
            public static string LatestVersionArn =  "LatestVersionArn" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Greengrass.ConnectorDefinition; }
        /// <summary>
        /// InitialVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-connectordefinition.html#cfn-greengrass-connectordefinition-initialversion
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ConnectorDefinitionVersion
        /// </summary>
        public Union<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion, BaseFunction>? InitialVersion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-connectordefinition.html#cfn-greengrass-connectordefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConnectorDefinitionTypes
    {
        public class Connector : Humidifier.Base.BaseSubResource, IHaveConnectorArn, IHaveParameters_Json, IHaveId
        {
            /// <summary>
            /// ConnectorArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-connectordefinition-connector.html#cfn-greengrass-connectordefinition-connector-connectorarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectorArn { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-connectordefinition-connector.html#cfn-greengrass-connectordefinition-connector-parameters
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-connectordefinition-connector.html#cfn-greengrass-connectordefinition-connector-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class ConnectorDefinitionVersion : Humidifier.Base.BaseSubResource, IHaveListOfGreengrassConnectorDefinitionTypesConnectorConnectors
        {
            /// <summary>
            /// Connectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-connectordefinition-connectordefinitionversion.html#cfn-greengrass-connectordefinition-connectordefinitionversion-connectors
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Connector
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector>, IReadOnlyList<Union<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector, BaseFunction>>, BaseFunction>? Connectors { get; set; }
        }
    }
}