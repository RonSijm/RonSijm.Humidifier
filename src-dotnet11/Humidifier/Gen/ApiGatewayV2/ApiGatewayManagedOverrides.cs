namespace Humidifier.ApiGatewayV2
{
    using global::System.Collections.Generic;
    using ApiGatewayManagedOverridesTypes;

    public class ApiGatewayManagedOverrides : Humidifier.Base.BaseResource, IHaveApiGatewayV2ApiGatewayManagedOverridesTypesIntegrationOverridesIntegration, IHaveApiGatewayV2ApiGatewayManagedOverridesTypesStageOverridesStage, IHaveApiId, IHaveApiGatewayV2ApiGatewayManagedOverridesTypesRouteOverridesRoute
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.ApiGatewayV2.ApiGatewayManagedOverrides; }
        /// <summary>
        /// Integration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-apigatewaymanagedoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-integration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IntegrationOverrides
        /// </summary>
        public Union<Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.IntegrationOverrides, BaseFunction>? Integration { get; set; }
        /// <summary>
        /// Stage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-apigatewaymanagedoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-stage
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StageOverrides
        /// </summary>
        public Union<Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.StageOverrides, BaseFunction>? Stage { get; set; }

        /// <summary>
        /// ApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-apigatewaymanagedoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-apiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApiId { get; set; }
        /// <summary>
        /// Route
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-apigatewaymanagedoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-route
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RouteOverrides
        /// </summary>
        public Union<Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.RouteOverrides, BaseFunction>? Route { get; set; }
    }

    namespace ApiGatewayManagedOverridesTypes
    {
        public class AccessLogSettings : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveDestinationArn
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-accesslogsettings.html#cfn-apigatewayv2-apigatewaymanagedoverrides-accesslogsettings-format
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// DestinationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-accesslogsettings.html#cfn-apigatewayv2-apigatewaymanagedoverrides-accesslogsettings-destinationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationArn { get; set; }
        }

        public class IntegrationOverrides : Humidifier.Base.BaseSubResource, IHaveDescription, IHavePayloadFormatVersion, IHaveTimeoutInMillis_Integer, IHaveIntegrationMethod
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-integrationoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-integrationoverrides-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// PayloadFormatVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-integrationoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-integrationoverrides-payloadformatversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PayloadFormatVersion { get; set; }
            /// <summary>
            /// TimeoutInMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-integrationoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-integrationoverrides-timeoutinmillis
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutInMillis { get; set; }
            /// <summary>
            /// IntegrationMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-integrationoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-integrationoverrides-integrationmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntegrationMethod { get; set; }
        }

        public class RouteOverrides : Humidifier.Base.BaseSubResource, IHaveTarget, IHaveAuthorizerId, IHaveOperationName, IHaveStringListOfAuthorizationScopes, IHaveAuthorizationType
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-routeoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-routeoverrides-target
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Target { get; set; }
            /// <summary>
            /// AuthorizerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-routeoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-routeoverrides-authorizerid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizerId { get; set; }
            /// <summary>
            /// OperationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-routeoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-routeoverrides-operationname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OperationName { get; set; }
            /// <summary>
            /// AuthorizationScopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-routeoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-routeoverrides-authorizationscopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AuthorizationScopes { get; set; }
            /// <summary>
            /// AuthorizationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-routeoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-routeoverrides-authorizationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationType { get; set; }
        }

        public class RouteSettings : Humidifier.Base.BaseSubResource, IHaveThrottlingBurstLimit_Integer, IHaveDetailedMetricsEnabled_Boolean, IHaveThrottlingRateLimit_Double
        {
            /// <summary>
            /// ThrottlingBurstLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-routesettings.html#cfn-apigatewayv2-apigatewaymanagedoverrides-routesettings-throttlingburstlimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThrottlingBurstLimit { get; set; }
            /// <summary>
            /// DetailedMetricsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-routesettings.html#cfn-apigatewayv2-apigatewaymanagedoverrides-routesettings-detailedmetricsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DetailedMetricsEnabled { get; set; }
            /// <summary>
            /// ThrottlingRateLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-routesettings.html#cfn-apigatewayv2-apigatewaymanagedoverrides-routesettings-throttlingratelimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ThrottlingRateLimit { get; set; }
        }

        public class StageOverrides : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveApiGatewayV2ApiGatewayManagedOverridesTypesAccessLogSettingsAccessLogSettings, IHaveAutoDeploy_Boolean, IHaveMapOfApiGatewayV2ApiGatewayManagedOverridesTypesRouteSettingsRouteSettings, IHaveStringDictionaryOfStageVariables, IHaveApiGatewayV2ApiGatewayManagedOverridesTypesRouteSettingsDefaultRouteSettings
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-stageoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-stageoverrides-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// AccessLogSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-stageoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-stageoverrides-accesslogsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AccessLogSettings
            /// </summary>
            public Union<Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.AccessLogSettings, BaseFunction>? AccessLogSettings { get; set; }
            /// <summary>
            /// AutoDeploy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-stageoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-stageoverrides-autodeploy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutoDeploy { get; set; }
            /// <summary>
            /// RouteSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-stageoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-stageoverrides-routesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: RouteSettings
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.RouteSettings>, IReadOnlyDictionary<string, Union<Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.RouteSettings, BaseFunction>>, BaseFunction>? RouteSettings { get; set; }
            /// <summary>
            /// StageVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-stageoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-stageoverrides-stagevariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? StageVariables { get; set; }
            /// <summary>
            /// DefaultRouteSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-stageoverrides.html#cfn-apigatewayv2-apigatewaymanagedoverrides-stageoverrides-defaultroutesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RouteSettings
            /// </summary>
            public Union<Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.RouteSettings, BaseFunction>? DefaultRouteSettings { get; set; }
        }
    }
}