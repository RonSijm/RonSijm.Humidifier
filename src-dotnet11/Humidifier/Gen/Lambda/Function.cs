namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using FunctionTypes;

    public class Function : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveLambdaFunctionTypesFunctionScalingConfigFunctionScalingConfig, IHaveDescription, IHaveLambdaFunctionTypesTracingConfigTracingConfig, IHaveLambdaFunctionTypesVpcConfigVpcConfig, IHaveLambdaFunctionTypesRuntimeManagementConfigRuntimeManagementConfig, IHaveLambdaFunctionTypesDurableConfigDurableConfig, IHaveReservedConcurrentExecutions_Integer, IHaveLambdaFunctionTypesSnapStartSnapStart, IHaveListOfLambdaFunctionTypesFileSystemConfigFileSystemConfigs, IHaveFunctionName, IHaveRuntime, IHaveKmsKeyArn, IHavePublishToLatestPublished_Boolean, IHavePackageType, IHaveCodeSigningConfigArn, IHaveStringListOfLayers, IHaveLambdaFunctionTypesTenancyConfigTenancyConfig, IHaveLambdaFunctionTypesImageConfigImageConfig, IHaveMemorySize_Integer, IHaveLambdaFunctionTypesDeadLetterConfigDeadLetterConfig, IHaveTimeout_Integer, IHaveLambdaFunctionTypesCapacityProviderConfigCapacityProviderConfig, IHaveHandler, IHaveLambdaFunctionTypesCodeCode, IHaveRole, IHaveLambdaFunctionTypesLoggingConfigLoggingConfig, IHaveRecursiveLoop, IHaveLambdaFunctionTypesEnvironmentEnvironment, IHaveLambdaFunctionTypesEphemeralStorageEphemeralStorage, IHaveStringListOfArchitectures
    {
        public class Attributes
        {
            public static string SnapStartResponse =  "SnapStartResponse" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Lambda.Function; }
        /// <summary>
        /// FunctionScalingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-functionscalingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FunctionScalingConfig
        /// </summary>
        public Union<Humidifier.Lambda.FunctionTypes.FunctionScalingConfig, BaseFunction>? FunctionScalingConfig { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// TracingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-tracingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TracingConfig
        /// </summary>
        public Union<Humidifier.Lambda.FunctionTypes.TracingConfig, BaseFunction>? TracingConfig { get; set; }
        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-vpcconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcConfig
        /// </summary>
        public Union<Humidifier.Lambda.FunctionTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
        /// <summary>
        /// RuntimeManagementConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-runtimemanagementconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RuntimeManagementConfig
        /// </summary>
        public Union<Humidifier.Lambda.FunctionTypes.RuntimeManagementConfig, BaseFunction>? RuntimeManagementConfig { get; set; }
        /// <summary>
        /// DurableConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-durableconfig
        /// Required: False
        /// UpdateType: Conditional
        /// Type: DurableConfig
        /// </summary>
        public Union<Humidifier.Lambda.FunctionTypes.DurableConfig, BaseFunction>? DurableConfig { get; set; }
        /// <summary>
        /// ReservedConcurrentExecutions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-reservedconcurrentexecutions
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ReservedConcurrentExecutions { get; set; }
        /// <summary>
        /// SnapStart
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-snapstart
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SnapStart
        /// </summary>
        public Union<Humidifier.Lambda.FunctionTypes.SnapStart, BaseFunction>? SnapStart { get; set; }
        /// <summary>
        /// FileSystemConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-filesystemconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FileSystemConfig
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Lambda.FunctionTypes.FileSystemConfig>, IReadOnlyList<Union<Humidifier.Lambda.FunctionTypes.FileSystemConfig, BaseFunction>>, BaseFunction>? FileSystemConfigs { get; set; }
        public Union<string, BaseFunction>? FunctionName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Runtime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-runtime
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Runtime { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        /// <summary>
        /// PublishToLatestPublished
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-publishtolatestpublished
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PublishToLatestPublished { get; set; }
        /// <summary>
        /// PackageType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-packagetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PackageType { get; set; }
        /// <summary>
        /// CodeSigningConfigArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-codesigningconfigarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CodeSigningConfigArn { get; set; }
        /// <summary>
        /// Layers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-layers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Layers { get; set; }
        /// <summary>
        /// TenancyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-tenancyconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: TenancyConfig
        /// </summary>
        public Union<Humidifier.Lambda.FunctionTypes.TenancyConfig, BaseFunction>? TenancyConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// ImageConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-imageconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ImageConfig
        /// </summary>
        public Union<Humidifier.Lambda.FunctionTypes.ImageConfig, BaseFunction>? ImageConfig { get; set; }
        /// <summary>
        /// MemorySize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-memorysize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MemorySize { get; set; }
        /// <summary>
        /// DeadLetterConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-deadletterconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeadLetterConfig
        /// </summary>
        public Union<Humidifier.Lambda.FunctionTypes.DeadLetterConfig, BaseFunction>? DeadLetterConfig { get; set; }
        /// <summary>
        /// Timeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-timeout
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Timeout { get; set; }
        /// <summary>
        /// CapacityProviderConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-capacityproviderconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapacityProviderConfig
        /// </summary>
        public Union<Humidifier.Lambda.FunctionTypes.CapacityProviderConfig, BaseFunction>? CapacityProviderConfig { get; set; }
        /// <summary>
        /// Handler
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-handler
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Handler { get; set; }

        /// <summary>
        /// Code
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-code
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Code
        /// </summary>
        [Required]
        public Union<Humidifier.Lambda.FunctionTypes.Code, BaseFunction>? Code { get; set; }

        /// <summary>
        /// Role
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-role
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Role { get; set; }
        /// <summary>
        /// LoggingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-loggingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoggingConfig
        /// </summary>
        public Union<Humidifier.Lambda.FunctionTypes.LoggingConfig, BaseFunction>? LoggingConfig { get; set; }
        /// <summary>
        /// RecursiveLoop
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-recursiveloop
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RecursiveLoop { get; set; }
        /// <summary>
        /// Environment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-environment
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Environment
        /// </summary>
        public Union<Humidifier.Lambda.FunctionTypes.Environment, BaseFunction>? Environment { get; set; }
        /// <summary>
        /// EphemeralStorage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-ephemeralstorage
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EphemeralStorage
        /// </summary>
        public Union<Humidifier.Lambda.FunctionTypes.EphemeralStorage, BaseFunction>? EphemeralStorage { get; set; }
        /// <summary>
        /// Architectures
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-architectures
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Architectures { get; set; }
    }

    namespace FunctionTypes
    {
        public class CapacityProviderConfig : Humidifier.Base.BaseSubResource, IHaveLambdaFunctionTypesLambdaManagedInstancesCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig
        {
            /// <summary>
            /// LambdaManagedInstancesCapacityProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-capacityproviderconfig.html#cfn-lambda-function-capacityproviderconfig-lambdamanagedinstancescapacityproviderconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LambdaManagedInstancesCapacityProviderConfig
            /// </summary>
            public Union<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig, BaseFunction>? LambdaManagedInstancesCapacityProviderConfig { get; set; }
        }

        public class Code : Humidifier.Base.BaseSubResource, IHaveSourceKMSKeyArn, IHaveS3ObjectVersion, IHaveS3Bucket, IHaveZipFile, IHaveS3Key, IHaveS3ObjectStorageMode, IHaveImageUri
        {
            /// <summary>
            /// SourceKMSKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-code.html#cfn-lambda-function-code-sourcekmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceKMSKeyArn { get; set; }
            /// <summary>
            /// S3ObjectVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-code.html#cfn-lambda-function-code-s3objectversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3ObjectVersion { get; set; }
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-code.html#cfn-lambda-function-code-s3bucket
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// ZipFile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-code.html#cfn-lambda-function-code-zipfile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ZipFile { get; set; }
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-code.html#cfn-lambda-function-code-s3key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Key { get; set; }
            /// <summary>
            /// S3ObjectStorageMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-code.html#cfn-lambda-function-code-s3objectstoragemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3ObjectStorageMode { get; set; }
            /// <summary>
            /// ImageUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-code.html#cfn-lambda-function-code-imageuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageUri { get; set; }
        }

        public class DeadLetterConfig : Humidifier.Base.BaseSubResource, IHaveTargetArn
        {
            /// <summary>
            /// TargetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-deadletterconfig.html#cfn-lambda-function-deadletterconfig-targetarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetArn { get; set; }
        }

        public class DurableConfig : Humidifier.Base.BaseSubResource, IHaveKMSKeyArn, IHaveExecutionTimeout_Integer, IHaveRetentionPeriodInDays_Integer
        {
            /// <summary>
            /// KMSKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-durableconfig.html#cfn-lambda-function-durableconfig-kmskeyarn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KMSKeyArn { get; set; }
            /// <summary>
            /// ExecutionTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-durableconfig.html#cfn-lambda-function-durableconfig-executiontimeout
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ExecutionTimeout { get; set; }
            /// <summary>
            /// RetentionPeriodInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-durableconfig.html#cfn-lambda-function-durableconfig-retentionperiodindays
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RetentionPeriodInDays { get; set; }
        }

        public class Environment : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfVariables
        {
            /// <summary>
            /// Variables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-environment.html#cfn-lambda-function-environment-variables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Variables { get; set; }
        }

        public class EphemeralStorage : Humidifier.Base.BaseSubResource, IHaveSize_Integer
        {
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-ephemeralstorage.html#cfn-lambda-function-ephemeralstorage-size
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Size { get; set; }
        }

        public class FileSystemConfig : Humidifier.Base.BaseSubResource, IHaveLambdaFunctionTypesS3FilesConfigS3FilesConfig, IHaveArn, IHaveLocalMountPath
        {
            /// <summary>
            /// S3FilesConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-filesystemconfig.html#cfn-lambda-function-filesystemconfig-s3filesconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3FilesConfig
            /// </summary>
            public Union<Humidifier.Lambda.FunctionTypes.S3FilesConfig, BaseFunction>? S3FilesConfig { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-filesystemconfig.html#cfn-lambda-function-filesystemconfig-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// LocalMountPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-filesystemconfig.html#cfn-lambda-function-filesystemconfig-localmountpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalMountPath { get; set; }
        }

        public class FunctionScalingConfig : Humidifier.Base.BaseSubResource, IHaveMinExecutionEnvironments_Integer, IHaveMaxExecutionEnvironments_Integer
        {
            /// <summary>
            /// MinExecutionEnvironments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-functionscalingconfig.html#cfn-lambda-function-functionscalingconfig-minexecutionenvironments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinExecutionEnvironments { get; set; }
            /// <summary>
            /// MaxExecutionEnvironments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-functionscalingconfig.html#cfn-lambda-function-functionscalingconfig-maxexecutionenvironments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxExecutionEnvironments { get; set; }
        }

        public class ImageConfig : Humidifier.Base.BaseSubResource, IHaveWorkingDirectory, IHaveStringListOfCommand, IHaveStringListOfEntryPoint
        {
            /// <summary>
            /// WorkingDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-imageconfig.html#cfn-lambda-function-imageconfig-workingdirectory
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkingDirectory { get; set; }
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-imageconfig.html#cfn-lambda-function-imageconfig-command
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Command { get; set; }
            /// <summary>
            /// EntryPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-imageconfig.html#cfn-lambda-function-imageconfig-entrypoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EntryPoint { get; set; }
        }

        public class LambdaManagedInstancesCapacityProviderConfig : Humidifier.Base.BaseSubResource, IHaveExecutionEnvironmentMemoryGiBPerVCpu_Double, IHaveCapacityProviderArn, IHavePerExecutionEnvironmentMaxConcurrency_Integer
        {
            /// <summary>
            /// ExecutionEnvironmentMemoryGiBPerVCpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-lambdamanagedinstancescapacityproviderconfig.html#cfn-lambda-function-lambdamanagedinstancescapacityproviderconfig-executionenvironmentmemorygibpervcpu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ExecutionEnvironmentMemoryGiBPerVCpu { get; set; }
            /// <summary>
            /// CapacityProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-lambdamanagedinstancescapacityproviderconfig.html#cfn-lambda-function-lambdamanagedinstancescapacityproviderconfig-capacityproviderarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityProviderArn { get; set; }
            /// <summary>
            /// PerExecutionEnvironmentMaxConcurrency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-lambdamanagedinstancescapacityproviderconfig.html#cfn-lambda-function-lambdamanagedinstancescapacityproviderconfig-perexecutionenvironmentmaxconcurrency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PerExecutionEnvironmentMaxConcurrency { get; set; }
        }

        public class LoggingConfig : Humidifier.Base.BaseSubResource, IHaveLogFormat, IHaveApplicationLogLevel, IHaveLogGroup, IHaveSystemLogLevel
        {
            /// <summary>
            /// LogFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-loggingconfig.html#cfn-lambda-function-loggingconfig-logformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogFormat { get; set; }
            /// <summary>
            /// ApplicationLogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-loggingconfig.html#cfn-lambda-function-loggingconfig-applicationloglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationLogLevel { get; set; }
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-loggingconfig.html#cfn-lambda-function-loggingconfig-loggroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroup { get; set; }
            /// <summary>
            /// SystemLogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-loggingconfig.html#cfn-lambda-function-loggingconfig-systemloglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SystemLogLevel { get; set; }
        }

        public class RuntimeManagementConfig : Humidifier.Base.BaseSubResource, IHaveUpdateRuntimeOn, IHaveRuntimeVersionArn
        {
            /// <summary>
            /// UpdateRuntimeOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-runtimemanagementconfig.html#cfn-lambda-function-runtimemanagementconfig-updateruntimeon
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateRuntimeOn { get; set; }
            /// <summary>
            /// RuntimeVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-runtimemanagementconfig.html#cfn-lambda-function-runtimemanagementconfig-runtimeversionarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuntimeVersionArn { get; set; }
        }

        public class S3FilesConfig : Humidifier.Base.BaseSubResource, IHaveDirectS3Read
        {
            /// <summary>
            /// DirectS3Read
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-s3filesconfig.html#cfn-lambda-function-s3filesconfig-directs3read
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DirectS3Read { get; set; }
        }

        public class SnapStart : Humidifier.Base.BaseSubResource, IHaveApplyOn
        {
            /// <summary>
            /// ApplyOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-snapstart.html#cfn-lambda-function-snapstart-applyon
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplyOn { get; set; }
        }

        public class SnapStartResponse : Humidifier.Base.BaseSubResource, IHaveOptimizationStatus, IHaveApplyOn
        {
            /// <summary>
            /// OptimizationStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-snapstartresponse.html#cfn-lambda-function-snapstartresponse-optimizationstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OptimizationStatus { get; set; }
            /// <summary>
            /// ApplyOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-snapstartresponse.html#cfn-lambda-function-snapstartresponse-applyon
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplyOn { get; set; }
        }

        public class TenancyConfig : Humidifier.Base.BaseSubResource, IHaveTenantIsolationMode
        {
            /// <summary>
            /// TenantIsolationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-tenancyconfig.html#cfn-lambda-function-tenancyconfig-tenantisolationmode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TenantIsolationMode { get; set; }
        }

        public class TracingConfig : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-tracingconfig.html#cfn-lambda-function-tracingconfig-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveIpv6AllowedForDualStack_Boolean, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// Ipv6AllowedForDualStack
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-vpcconfig.html#cfn-lambda-function-vpcconfig-ipv6allowedfordualstack
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Ipv6AllowedForDualStack { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-vpcconfig.html#cfn-lambda-function-vpcconfig-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-vpcconfig.html#cfn-lambda-function-vpcconfig-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }
    }
}