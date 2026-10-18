namespace Humidifier.AppSync
{
    using global::System.Collections.Generic;
    using ResolverTypes;

    public class Resolver : Humidifier.Base.BaseResource, IHaveTypeName, IHaveAppSyncResolverTypesPipelineConfigPipelineConfig, IHaveRequestMappingTemplate, IHaveResponseMappingTemplate, IHaveMaxBatchSize_Integer, IHaveAppSyncResolverTypesSyncConfigSyncConfig, IHaveCode, IHaveMetricsConfig, IHaveResponseMappingTemplateS3Location, IHaveAppSyncResolverTypesAppSyncRuntimeRuntime, IHaveCodeS3Location, IHaveDataSourceName, IHaveKind, IHaveAppSyncResolverTypesCachingConfigCachingConfig, IHaveRequestMappingTemplateS3Location, IHaveApiId, IHaveFieldName
    {
        public class Attributes
        {
            public static string TypeName =  "TypeName" ;
            public static string ResolverArn =  "ResolverArn" ;
            public static string FieldName =  "FieldName" ;
        }

        public override string AWSTypeName { get => AWS.AppSync.Resolver; }

        /// <summary>
        /// TypeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-typename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TypeName { get; set; }
        /// <summary>
        /// PipelineConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-pipelineconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PipelineConfig
        /// </summary>
        public Union<Humidifier.AppSync.ResolverTypes.PipelineConfig, BaseFunction>? PipelineConfig { get; set; }
        /// <summary>
        /// RequestMappingTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-requestmappingtemplate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RequestMappingTemplate { get; set; }
        /// <summary>
        /// ResponseMappingTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-responsemappingtemplate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResponseMappingTemplate { get; set; }
        /// <summary>
        /// MaxBatchSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-maxbatchsize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxBatchSize { get; set; }
        /// <summary>
        /// SyncConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-syncconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SyncConfig
        /// </summary>
        public Union<Humidifier.AppSync.ResolverTypes.SyncConfig, BaseFunction>? SyncConfig { get; set; }
        /// <summary>
        /// Code
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-code
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Code { get; set; }
        /// <summary>
        /// MetricsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-metricsconfig
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MetricsConfig { get; set; }
        /// <summary>
        /// ResponseMappingTemplateS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-responsemappingtemplates3location
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResponseMappingTemplateS3Location { get; set; }
        /// <summary>
        /// Runtime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-runtime
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AppSyncRuntime
        /// </summary>
        public Union<Humidifier.AppSync.ResolverTypes.AppSyncRuntime, BaseFunction>? Runtime { get; set; }
        /// <summary>
        /// CodeS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-codes3location
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CodeS3Location { get; set; }
        /// <summary>
        /// DataSourceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-datasourcename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DataSourceName { get; set; }
        /// <summary>
        /// Kind
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-kind
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Kind { get; set; }
        /// <summary>
        /// CachingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-cachingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CachingConfig
        /// </summary>
        public Union<Humidifier.AppSync.ResolverTypes.CachingConfig, BaseFunction>? CachingConfig { get; set; }
        /// <summary>
        /// RequestMappingTemplateS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-requestmappingtemplates3location
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RequestMappingTemplateS3Location { get; set; }

        /// <summary>
        /// ApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-apiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApiId { get; set; }

        /// <summary>
        /// FieldName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-fieldname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FieldName { get; set; }
    }

    namespace ResolverTypes
    {
        public class AppSyncRuntime : Humidifier.Base.BaseSubResource, IHaveRuntimeVersion, IHaveName
        {
            /// <summary>
            /// RuntimeVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-appsyncruntime.html#cfn-appsync-resolver-appsyncruntime-runtimeversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuntimeVersion { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-appsyncruntime.html#cfn-appsync-resolver-appsyncruntime-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class CachingConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfCachingKeys, IHaveTtl_Double
        {
            /// <summary>
            /// CachingKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-cachingconfig.html#cfn-appsync-resolver-cachingconfig-cachingkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CachingKeys { get; set; }
            /// <summary>
            /// Ttl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-cachingconfig.html#cfn-appsync-resolver-cachingconfig-ttl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Ttl { get; set; }
        }

        public class LambdaConflictHandlerConfig : Humidifier.Base.BaseSubResource, IHaveLambdaConflictHandlerArn
        {
            /// <summary>
            /// LambdaConflictHandlerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-lambdaconflicthandlerconfig.html#cfn-appsync-resolver-lambdaconflicthandlerconfig-lambdaconflicthandlerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaConflictHandlerArn { get; set; }
        }

        public class PipelineConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfFunctions
        {
            /// <summary>
            /// Functions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-pipelineconfig.html#cfn-appsync-resolver-pipelineconfig-functions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Functions { get; set; }
        }

        public class SyncConfig : Humidifier.Base.BaseSubResource, IHaveConflictHandler, IHaveConflictDetection, IHaveAppSyncResolverTypesLambdaConflictHandlerConfigLambdaConflictHandlerConfig
        {
            /// <summary>
            /// ConflictHandler
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-syncconfig.html#cfn-appsync-resolver-syncconfig-conflicthandler
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConflictHandler { get; set; }
            /// <summary>
            /// ConflictDetection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-syncconfig.html#cfn-appsync-resolver-syncconfig-conflictdetection
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConflictDetection { get; set; }
            /// <summary>
            /// LambdaConflictHandlerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-syncconfig.html#cfn-appsync-resolver-syncconfig-lambdaconflicthandlerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaConflictHandlerConfig
            /// </summary>
            public Union<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig, BaseFunction>? LambdaConflictHandlerConfig { get; set; }
        }
    }
}