namespace Humidifier.ApiGateway
{
    using global::System.Collections.Generic;
    using DeploymentTypes;

    public class Deployment : Humidifier.Base.BaseResource, IHaveDescription, IHaveApiGatewayDeploymentTypesStageDescriptionStageDescription, IHaveStageName, IHaveRestApiId, IHaveApiGatewayDeploymentTypesDeploymentCanarySettingsDeploymentCanarySettings
    {
        public class Attributes
        {
            public static string DeploymentId =  "DeploymentId" ;
        }

        public override string AWSTypeName { get => AWS.ApiGateway.Deployment; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-deployment.html#cfn-apigateway-deployment-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// StageDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-deployment.html#cfn-apigateway-deployment-stagedescription
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StageDescription
        /// </summary>
        public Union<Humidifier.ApiGateway.DeploymentTypes.StageDescription, BaseFunction>? StageDescription { get; set; }
        /// <summary>
        /// StageName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-deployment.html#cfn-apigateway-deployment-stagename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StageName { get; set; }

        /// <summary>
        /// RestApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-deployment.html#cfn-apigateway-deployment-restapiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RestApiId { get; set; }
        /// <summary>
        /// DeploymentCanarySettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-deployment.html#cfn-apigateway-deployment-deploymentcanarysettings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DeploymentCanarySettings
        /// </summary>
        public Union<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings, BaseFunction>? DeploymentCanarySettings { get; set; }
    }

    namespace DeploymentTypes
    {
        public class AccessLogSetting : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveDestinationArn
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-accesslogsetting.html#cfn-apigateway-deployment-accesslogsetting-format
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// DestinationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-accesslogsetting.html#cfn-apigateway-deployment-accesslogsetting-destinationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationArn { get; set; }
        }

        public class CanarySetting : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfStageVariableOverrides, IHavePercentTraffic_Double, IHaveUseStageCache_Boolean
        {
            /// <summary>
            /// StageVariableOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-canarysetting.html#cfn-apigateway-deployment-canarysetting-stagevariableoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? StageVariableOverrides { get; set; }
            /// <summary>
            /// PercentTraffic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-canarysetting.html#cfn-apigateway-deployment-canarysetting-percenttraffic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? PercentTraffic { get; set; }
            /// <summary>
            /// UseStageCache
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-canarysetting.html#cfn-apigateway-deployment-canarysetting-usestagecache
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseStageCache { get; set; }
        }

        public class DeploymentCanarySettings : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfStageVariableOverrides, IHavePercentTraffic_Double, IHaveUseStageCache_Boolean
        {
            /// <summary>
            /// StageVariableOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-deploymentcanarysettings.html#cfn-apigateway-deployment-deploymentcanarysettings-stagevariableoverrides
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? StageVariableOverrides { get; set; }
            /// <summary>
            /// PercentTraffic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-deploymentcanarysettings.html#cfn-apigateway-deployment-deploymentcanarysettings-percenttraffic
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? PercentTraffic { get; set; }
            /// <summary>
            /// UseStageCache
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-deploymentcanarysettings.html#cfn-apigateway-deployment-deploymentcanarysettings-usestagecache
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseStageCache { get; set; }
        }

        public class MethodSetting : Humidifier.Base.BaseSubResource, IHaveCacheTtlInSeconds_Integer, IHaveLoggingLevel, IHaveResourcePath, IHaveCacheDataEncrypted_Boolean, IHaveDataTraceEnabled_Boolean, IHaveThrottlingBurstLimit_Integer, IHaveCachingEnabled_Boolean, IHaveMetricsEnabled_Boolean, IHaveHttpMethod, IHaveThrottlingRateLimit_Double
        {
            /// <summary>
            /// CacheTtlInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-methodsetting.html#cfn-apigateway-deployment-methodsetting-cachettlinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CacheTtlInSeconds { get; set; }
            /// <summary>
            /// LoggingLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-methodsetting.html#cfn-apigateway-deployment-methodsetting-logginglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LoggingLevel { get; set; }
            /// <summary>
            /// ResourcePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-methodsetting.html#cfn-apigateway-deployment-methodsetting-resourcepath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourcePath { get; set; }
            /// <summary>
            /// CacheDataEncrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-methodsetting.html#cfn-apigateway-deployment-methodsetting-cachedataencrypted
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CacheDataEncrypted { get; set; }
            /// <summary>
            /// DataTraceEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-methodsetting.html#cfn-apigateway-deployment-methodsetting-datatraceenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DataTraceEnabled { get; set; }
            /// <summary>
            /// ThrottlingBurstLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-methodsetting.html#cfn-apigateway-deployment-methodsetting-throttlingburstlimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThrottlingBurstLimit { get; set; }
            /// <summary>
            /// CachingEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-methodsetting.html#cfn-apigateway-deployment-methodsetting-cachingenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CachingEnabled { get; set; }
            /// <summary>
            /// MetricsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-methodsetting.html#cfn-apigateway-deployment-methodsetting-metricsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MetricsEnabled { get; set; }
            /// <summary>
            /// HttpMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-methodsetting.html#cfn-apigateway-deployment-methodsetting-httpmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpMethod { get; set; }
            /// <summary>
            /// ThrottlingRateLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-methodsetting.html#cfn-apigateway-deployment-methodsetting-throttlingratelimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ThrottlingRateLimit { get; set; }
        }

        public class StageDescription : Humidifier.Base.BaseSubResource, IHaveTags, IHaveCacheTtlInSeconds_Integer, IHaveDescription, IHaveLoggingLevel, IHaveApiGatewayDeploymentTypesCanarySettingCanarySetting, IHaveThrottlingRateLimit_Double, IHaveClientCertificateId, IHaveStringDictionaryOfVariables, IHaveDocumentationVersion, IHaveCacheDataEncrypted_Boolean, IHaveDataTraceEnabled_Boolean, IHaveThrottlingBurstLimit_Integer, IHaveCachingEnabled_Boolean, IHaveTracingEnabled_Boolean, IHaveListOfApiGatewayDeploymentTypesMethodSettingMethodSettings, IHaveApiGatewayDeploymentTypesAccessLogSettingAccessLogSetting, IHaveCacheClusterSize, IHaveMetricsEnabled_Boolean, IHaveCacheClusterEnabled_Boolean
        {
            /// <summary>
            /// CacheTtlInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-cachettlinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CacheTtlInSeconds { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// LoggingLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-logginglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LoggingLevel { get; set; }
            /// <summary>
            /// CanarySetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-canarysetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CanarySetting
            /// </summary>
            public Union<Humidifier.ApiGateway.DeploymentTypes.CanarySetting, BaseFunction>? CanarySetting { get; set; }
            /// <summary>
            /// ThrottlingRateLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-throttlingratelimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ThrottlingRateLimit { get; set; }
            /// <summary>
            /// ClientCertificateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-clientcertificateid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientCertificateId { get; set; }
            /// <summary>
            /// Variables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-variables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Variables { get; set; }
            /// <summary>
            /// DocumentationVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-documentationversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentationVersion { get; set; }
            /// <summary>
            /// CacheDataEncrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-cachedataencrypted
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CacheDataEncrypted { get; set; }
            /// <summary>
            /// DataTraceEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-datatraceenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DataTraceEnabled { get; set; }
            /// <summary>
            /// ThrottlingBurstLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-throttlingburstlimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThrottlingBurstLimit { get; set; }
            /// <summary>
            /// CachingEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-cachingenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CachingEnabled { get; set; }
            /// <summary>
            /// TracingEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-tracingenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? TracingEnabled { get; set; }
            /// <summary>
            /// MethodSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-methodsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MethodSetting
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApiGateway.DeploymentTypes.MethodSetting>, IReadOnlyList<Union<Humidifier.ApiGateway.DeploymentTypes.MethodSetting, BaseFunction>>, BaseFunction>? MethodSettings { get; set; }
            /// <summary>
            /// AccessLogSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-accesslogsetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AccessLogSetting
            /// </summary>
            public Union<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting, BaseFunction>? AccessLogSetting { get; set; }
            /// <summary>
            /// CacheClusterSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-cacheclustersize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CacheClusterSize { get; set; }
            /// <summary>
            /// MetricsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-metricsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MetricsEnabled { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// CacheClusterEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-cacheclusterenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CacheClusterEnabled { get; set; }
        }
    }
}