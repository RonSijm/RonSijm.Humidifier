namespace Humidifier.ApiGatewayV2
{
    using System.Collections.Generic;
    using StageTypes;

    public class Stage : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveDynamicTags, IHaveApiId, IHaveStageName, IHaveDeploymentId, IHaveClientCertificateId, IHaveAutoDeploy, IHaveRouteSettings, IHaveStageVariables
    {
        public override string AWSTypeName { get => AWS.ApiGatewayV2.Stage; }
        /// <summary>
        /// ClientCertificateId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-clientcertificateid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClientCertificateId { get; set; }
        /// <summary>
        /// DeploymentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-deploymentid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DeploymentId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// AccessLogSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-accesslogsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccessLogSettings
        /// </summary>
        public Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings AccessLogSettings { get; set; }
        /// <summary>
        /// AutoDeploy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-autodeploy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AutoDeploy { get; set; }
        /// <summary>
        /// RouteSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-routesettings
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic RouteSettings { get; set; }
        public dynamic StageName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// StageVariables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-stagevariables
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic StageVariables { get; set; }
        /// <summary>
        /// AccessPolicyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-accesspolicyid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AccessPolicyId { get; set; }

        /// <summary>
        /// ApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-apiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ApiId { get; set; }
        /// <summary>
        /// DefaultRouteSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-defaultroutesettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RouteSettings
        /// </summary>
        public Humidifier.ApiGatewayV2.StageTypes.RouteSettings DefaultRouteSettings { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Tags { get; set; }
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
            public dynamic Format { get; set; }
            /// <summary>
            /// DestinationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-stage-accesslogsettings.html#cfn-apigatewayv2-stage-accesslogsettings-destinationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationArn { get; set; }
        }

        public class RouteSettings : Humidifier.Base.BaseSubResource, IHaveLoggingLevel, IHaveDataTraceEnabled, IHaveThrottlingBurstLimit, IHaveThrottlingRateLimit, IHaveDetailedMetricsEnabled
        {
            /// <summary>
            /// LoggingLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-stage-routesettings.html#cfn-apigatewayv2-stage-routesettings-logginglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LoggingLevel { get; set; }
            /// <summary>
            /// DataTraceEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-stage-routesettings.html#cfn-apigatewayv2-stage-routesettings-datatraceenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DataTraceEnabled { get; set; }
            /// <summary>
            /// ThrottlingBurstLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-stage-routesettings.html#cfn-apigatewayv2-stage-routesettings-throttlingburstlimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ThrottlingBurstLimit { get; set; }
            /// <summary>
            /// DetailedMetricsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-stage-routesettings.html#cfn-apigatewayv2-stage-routesettings-detailedmetricsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DetailedMetricsEnabled { get; set; }
            /// <summary>
            /// ThrottlingRateLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-stage-routesettings.html#cfn-apigatewayv2-stage-routesettings-throttlingratelimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ThrottlingRateLimit { get; set; }
        }
    }
}