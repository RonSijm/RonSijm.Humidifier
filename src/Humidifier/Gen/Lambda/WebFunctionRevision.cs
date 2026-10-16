namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using WebFunctionRevisionTypes;

    public class WebFunctionRevision : Humidifier.Base.BaseResource, IHaveDescription, IHaveKmsKeyArn, IHaveFunctionName
    {
        public class Attributes
        {
            public static string FunctionArn =  "FunctionArn" ;
            public static string State =  "State" ;
            public static string StateReason =  "StateReason" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string RevisionArn =  "RevisionArn" ;
            public static string RevisionId =  "RevisionId" ;
        }

        public override string AWSTypeName { get => AWS.Lambda.WebFunctionRevision; }

        /// <summary>
        /// FunctionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionrevision.html#cfn-lambda-webfunctionrevision-functionname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FunctionName { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionrevision.html#cfn-lambda-webfunctionrevision-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionrevision.html#cfn-lambda-webfunctionrevision-kmskeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyArn { get; set; }

        /// <summary>
        /// ServiceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionrevision.html#cfn-lambda-webfunctionrevision-serviceconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ServiceConfig
        /// </summary>
        [Required]
        public Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig ServiceConfig { get; set; }

        /// <summary>
        /// BuildConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionrevision.html#cfn-lambda-webfunctionrevision-buildconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: BuildConfig
        /// </summary>
        [Required]
        public Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig BuildConfig { get; set; }
    }

    namespace WebFunctionRevisionTypes
    {
        public class BuildConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RuntimeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionrevision-buildconfig.html#cfn-lambda-webfunctionrevision-buildconfig-runtimeconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: RuntimeConfig
            /// </summary>
            public Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig RuntimeConfig { get; set; }
            /// <summary>
            /// CodeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionrevision-buildconfig.html#cfn-lambda-webfunctionrevision-buildconfig-codeconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CodeConfig
            /// </summary>
            public Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig CodeConfig { get; set; }
        }

        public class CodeConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionrevision-codeconfig.html#cfn-lambda-webfunctionrevision-codeconfig-s3object
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3Object
            /// </summary>
            public Humidifier.Lambda.WebFunctionRevisionTypes.S3Object S3Object { get; set; }
        }

        public class LoggingConfig : Humidifier.Base.BaseSubResource, IHaveLogGroup
        {
            /// <summary>
            /// ApplicationLogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionrevision-loggingconfig.html#cfn-lambda-webfunctionrevision-loggingconfig-applicationloglevel
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationLogLevel { get; set; }
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionrevision-loggingconfig.html#cfn-lambda-webfunctionrevision-loggingconfig-loggroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroup { get; set; }
            /// <summary>
            /// SystemLogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionrevision-loggingconfig.html#cfn-lambda-webfunctionrevision-loggingconfig-systemloglevel
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SystemLogLevel { get; set; }
        }

        public class RuntimeConfig : Humidifier.Base.BaseSubResource, IHaveRuntime
        {
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionrevision-runtimeconfig.html#cfn-lambda-webfunctionrevision-runtimeconfig-runtime
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Runtime { get; set; }
        }

        public class S3Object : Humidifier.Base.BaseSubResource, IHaveKey, IHaveBucket, IHaveVersionId
        {
            /// <summary>
            /// VersionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionrevision-s3object.html#cfn-lambda-webfunctionrevision-s3object-versionid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VersionId { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionrevision-s3object.html#cfn-lambda-webfunctionrevision-s3object-bucket
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionrevision-s3object.html#cfn-lambda-webfunctionrevision-s3object-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class ServiceConfig : Humidifier.Base.BaseSubResource, IHaveExecutionRoleArn, IHaveTimeoutSeconds
        {
            /// <summary>
            /// TimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionrevision-serviceconfig.html#cfn-lambda-webfunctionrevision-serviceconfig-timeoutseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutSeconds { get; set; }
            /// <summary>
            /// ExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionrevision-serviceconfig.html#cfn-lambda-webfunctionrevision-serviceconfig-executionrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionRoleArn { get; set; }
            /// <summary>
            /// MaxConcurrencyPerEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionrevision-serviceconfig.html#cfn-lambda-webfunctionrevision-serviceconfig-maxconcurrencyperenvironment
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxConcurrencyPerEnvironment { get; set; }
            /// <summary>
            /// EnvironmentVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionrevision-serviceconfig.html#cfn-lambda-webfunctionrevision-serviceconfig-environmentvariables
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> EnvironmentVariables { get; set; }
            /// <summary>
            /// EgressNetworkConnectorArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionrevision-serviceconfig.html#cfn-lambda-webfunctionrevision-serviceconfig-egressnetworkconnectorarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EgressNetworkConnectorArn { get; set; }
            /// <summary>
            /// TelemetryConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionrevision-serviceconfig.html#cfn-lambda-webfunctionrevision-serviceconfig-telemetryconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TelemetryConfig
            /// </summary>
            public Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig TelemetryConfig { get; set; }
        }

        public class TelemetryConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LoggingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionrevision-telemetryconfig.html#cfn-lambda-webfunctionrevision-telemetryconfig-loggingconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LoggingConfig
            /// </summary>
            public Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig LoggingConfig { get; set; }
        }
    }
}