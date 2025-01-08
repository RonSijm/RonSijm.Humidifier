namespace Humidifier.AppSync
{
    using System.Collections.Generic;
    using ResolverTypes;

    public class Resolver : Humidifier.Base.BaseResource, IHaveApiId, IHaveTypeName, IHaveCode, IHaveFieldName, IHaveCodeS3Location, IHaveMetricsConfig, IHaveRequestMappingTemplate, IHaveResponseMappingTemplate, IHaveMaxBatchSize, IHaveResponseMappingTemplateS3Location, IHaveDataSourceName, IHaveRequestMappingTemplateS3Location
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
        public dynamic TypeName { get; set; }
        /// <summary>
        /// PipelineConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-pipelineconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PipelineConfig
        /// </summary>
        public Humidifier.AppSync.ResolverTypes.PipelineConfig PipelineConfig { get; set; }
        /// <summary>
        /// RequestMappingTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-requestmappingtemplate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RequestMappingTemplate { get; set; }
        /// <summary>
        /// ResponseMappingTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-responsemappingtemplate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResponseMappingTemplate { get; set; }
        /// <summary>
        /// MaxBatchSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-maxbatchsize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaxBatchSize { get; set; }
        /// <summary>
        /// SyncConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-syncconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SyncConfig
        /// </summary>
        public Humidifier.AppSync.ResolverTypes.SyncConfig SyncConfig { get; set; }
        /// <summary>
        /// Code
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-code
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Code { get; set; }
        /// <summary>
        /// MetricsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-metricsconfig
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MetricsConfig { get; set; }
        /// <summary>
        /// ResponseMappingTemplateS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-responsemappingtemplates3location
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResponseMappingTemplateS3Location { get; set; }
        /// <summary>
        /// Runtime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-runtime
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AppSyncRuntime
        /// </summary>
        public Humidifier.AppSync.ResolverTypes.AppSyncRuntime Runtime { get; set; }
        /// <summary>
        /// CodeS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-codes3location
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CodeS3Location { get; set; }
        /// <summary>
        /// DataSourceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-datasourcename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DataSourceName { get; set; }
        /// <summary>
        /// Kind
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-kind
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Kind { get; set; }
        /// <summary>
        /// CachingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-cachingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CachingConfig
        /// </summary>
        public Humidifier.AppSync.ResolverTypes.CachingConfig CachingConfig { get; set; }
        /// <summary>
        /// RequestMappingTemplateS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-requestmappingtemplates3location
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RequestMappingTemplateS3Location { get; set; }

        /// <summary>
        /// ApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-apiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ApiId { get; set; }

        /// <summary>
        /// FieldName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-fieldname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FieldName { get; set; }
    }

    namespace ResolverTypes
    {
        public class AppSyncRuntime : Humidifier.Base.BaseSubResource, IHaveName, IHaveRuntimeVersion
        {
            /// <summary>
            /// RuntimeVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-appsyncruntime.html#cfn-appsync-resolver-appsyncruntime-runtimeversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuntimeVersion { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-appsyncruntime.html#cfn-appsync-resolver-appsyncruntime-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class CachingConfig : Humidifier.Base.BaseSubResource, IHaveTtl
        {
            /// <summary>
            /// CachingKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-cachingconfig.html#cfn-appsync-resolver-cachingconfig-cachingkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CachingKeys { get; set; }
            /// <summary>
            /// Ttl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-cachingconfig.html#cfn-appsync-resolver-cachingconfig-ttl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Ttl { get; set; }
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
            public dynamic LambdaConflictHandlerArn { get; set; }
        }

        public class PipelineConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Functions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-pipelineconfig.html#cfn-appsync-resolver-pipelineconfig-functions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Functions { get; set; }
        }

        public class SyncConfig : Humidifier.Base.BaseSubResource, IHaveConflictHandler, IHaveConflictDetection
        {
            /// <summary>
            /// ConflictHandler
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-syncconfig.html#cfn-appsync-resolver-syncconfig-conflicthandler
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConflictHandler { get; set; }
            /// <summary>
            /// ConflictDetection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-syncconfig.html#cfn-appsync-resolver-syncconfig-conflictdetection
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConflictDetection { get; set; }
            /// <summary>
            /// LambdaConflictHandlerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-syncconfig.html#cfn-appsync-resolver-syncconfig-lambdaconflicthandlerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaConflictHandlerConfig
            /// </summary>
            public Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig LambdaConflictHandlerConfig { get; set; }
        }
    }
}