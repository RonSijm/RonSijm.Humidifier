namespace Humidifier.ApiGatewayV2
{
    using global::System.Collections.Generic;
    using StageTypes;

    public class Stage : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveClientCertificateId, IHaveDeploymentId, IHaveDescription, IHaveAutoDeploy_Boolean, IHaveApiGatewayV2StageTypesAccessLogSettingsAccessLogSettings, IHaveRouteSettings_Json, IHaveStageName, IHaveStageVariables_Json, IHaveApiId, IHaveApiGatewayV2StageTypesRouteSettingsDefaultRouteSettings, IHaveTags_Json
    {
        public override string AWSTypeName { get => AWS.ApiGatewayV2.Stage; }
        /// <summary>
        /// ClientCertificateId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-clientcertificateid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientCertificateId { get; set; }
        /// <summary>
        /// DeploymentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-deploymentid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeploymentId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// AutoDeploy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-autodeploy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AutoDeploy { get; set; }
        /// <summary>
        /// AccessLogSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-accesslogsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccessLogSettings
        /// </summary>
        public Union<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings, BaseFunction>? AccessLogSettings { get; set; }
        /// <summary>
        /// RouteSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-routesettings
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? RouteSettings { get; set; }
        public Union<string, BaseFunction>? StageName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// StageVariables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-stagevariables
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? StageVariables { get; set; }

        /// <summary>
        /// ApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-apiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApiId { get; set; }
        /// <summary>
        /// DefaultRouteSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-defaultroutesettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RouteSettings
        /// </summary>
        public Union<Humidifier.ApiGatewayV2.StageTypes.RouteSettings, BaseFunction>? DefaultRouteSettings { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
    }

    namespace StageTypes
    {
        public class AccessLogSettings : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveDestinationArn
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-stage-accesslogsettings.html#cfn-apigatewayv2-stage-accesslogsettings-format
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// DestinationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-stage-accesslogsettings.html#cfn-apigatewayv2-stage-accesslogsettings-destinationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationArn { get; set; }
        }

        public class RouteSettings : Humidifier.Base.BaseSubResource, IHaveLoggingLevel, IHaveDataTraceEnabled_Boolean, IHaveThrottlingBurstLimit_Integer, IHaveDetailedMetricsEnabled_Boolean, IHaveThrottlingRateLimit_Double
        {
            /// <summary>
            /// LoggingLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-stage-routesettings.html#cfn-apigatewayv2-stage-routesettings-logginglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LoggingLevel { get; set; }
            /// <summary>
            /// DataTraceEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-stage-routesettings.html#cfn-apigatewayv2-stage-routesettings-datatraceenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DataTraceEnabled { get; set; }
            /// <summary>
            /// ThrottlingBurstLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-stage-routesettings.html#cfn-apigatewayv2-stage-routesettings-throttlingburstlimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThrottlingBurstLimit { get; set; }
            /// <summary>
            /// DetailedMetricsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-stage-routesettings.html#cfn-apigatewayv2-stage-routesettings-detailedmetricsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DetailedMetricsEnabled { get; set; }
            /// <summary>
            /// ThrottlingRateLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-stage-routesettings.html#cfn-apigatewayv2-stage-routesettings-throttlingratelimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ThrottlingRateLimit { get; set; }
        }
    }
}