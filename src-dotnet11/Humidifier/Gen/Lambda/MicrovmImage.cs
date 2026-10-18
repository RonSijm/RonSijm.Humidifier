namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using MicrovmImageTypes;

    public class MicrovmImage : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveLambdaMicrovmImageTypesLoggingLogging, IHaveDescription, IHaveListOfLambdaMicrovmImageTypesCpuConfigurationCpuConfigurations, IHaveLambdaMicrovmImageTypesCodeArtifactCodeArtifact, IHaveName, IHaveListOfLambdaMicrovmImageTypesEnvironmentVariableEnvironmentVariables, IHaveBaseImageVersion, IHaveBuildRoleArn, IHaveStringListOfAdditionalOsCapabilities, IHaveLambdaMicrovmImageTypesHooksHooks, IHaveListOfLambdaMicrovmImageTypesResourcesResources, IHaveBaseImageArn, IHaveStringListOfEgressNetworkConnectors
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string LatestActiveImageVersion =  "LatestActiveImageVersion" ;
            public static string LatestFailedImageVersion =  "LatestFailedImageVersion" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string ImageArn =  "ImageArn" ;
        }

        public override string AWSTypeName { get => AWS.Lambda.MicrovmImage; }

        /// <summary>
        /// Logging
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-logging
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Logging
        /// </summary>
        [Required]
        public Union<Humidifier.Lambda.MicrovmImageTypes.Logging, BaseFunction>? Logging { get; set; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// CpuConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-cpuconfigurations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CpuConfiguration
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Lambda.MicrovmImageTypes.CpuConfiguration>, IReadOnlyList<Union<Humidifier.Lambda.MicrovmImageTypes.CpuConfiguration, BaseFunction>>, BaseFunction>? CpuConfigurations { get; set; }

        /// <summary>
        /// CodeArtifact
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-codeartifact
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CodeArtifact
        /// </summary>
        [Required]
        public Union<Humidifier.Lambda.MicrovmImageTypes.CodeArtifact, BaseFunction>? CodeArtifact { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// EnvironmentVariables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-environmentvariables
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EnvironmentVariable
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Lambda.MicrovmImageTypes.EnvironmentVariable>, IReadOnlyList<Union<Humidifier.Lambda.MicrovmImageTypes.EnvironmentVariable, BaseFunction>>, BaseFunction>? EnvironmentVariables { get; set; }

        /// <summary>
        /// BaseImageVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-baseimageversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BaseImageVersion { get; set; }

        /// <summary>
        /// BuildRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-buildrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BuildRoleArn { get; set; }

        /// <summary>
        /// AdditionalOsCapabilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-additionaloscapabilities
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdditionalOsCapabilities { get; set; }

        /// <summary>
        /// Hooks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-hooks
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Hooks
        /// </summary>
        [Required]
        public Union<Humidifier.Lambda.MicrovmImageTypes.Hooks, BaseFunction>? Hooks { get; set; }

        /// <summary>
        /// Resources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-resources
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Resources
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Lambda.MicrovmImageTypes.Resources>, IReadOnlyList<Union<Humidifier.Lambda.MicrovmImageTypes.Resources, BaseFunction>>, BaseFunction>? Resources { get; set; }

        /// <summary>
        /// BaseImageArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-baseimagearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BaseImageArn { get; set; }

        /// <summary>
        /// EgressNetworkConnectors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-egressnetworkconnectors
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EgressNetworkConnectors { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace MicrovmImageTypes
    {
        public class CloudWatchLogging : Humidifier.Base.BaseSubResource, IHaveLogGroup, IHaveLogStream
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-cloudwatchlogging.html#cfn-lambda-microvmimage-cloudwatchlogging-loggroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroup { get; set; }
            /// <summary>
            /// LogStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-cloudwatchlogging.html#cfn-lambda-microvmimage-cloudwatchlogging-logstream
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogStream { get; set; }
        }

        public class CodeArtifact : Humidifier.Base.BaseSubResource, IHaveUri
        {
            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-codeartifact.html#cfn-lambda-microvmimage-codeartifact-uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Uri { get; set; }
        }

        public class CpuConfiguration : Humidifier.Base.BaseSubResource, IHaveArchitecture
        {
            /// <summary>
            /// Architecture
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-cpuconfiguration.html#cfn-lambda-microvmimage-cpuconfiguration-architecture
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Architecture { get; set; }
        }

        public class EnvironmentVariable : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-environmentvariable.html#cfn-lambda-microvmimage-environmentvariable-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-environmentvariable.html#cfn-lambda-microvmimage-environmentvariable-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class Hooks : Humidifier.Base.BaseSubResource, IHavePort_Integer, IHaveLambdaMicrovmImageTypesMicrovmImageHooksMicrovmImageHooks, IHaveLambdaMicrovmImageTypesMicrovmHooksMicrovmHooks
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-hooks.html#cfn-lambda-microvmimage-hooks-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// MicrovmImageHooks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-hooks.html#cfn-lambda-microvmimage-hooks-microvmimagehooks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MicrovmImageHooks
            /// </summary>
            public Union<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks, BaseFunction>? MicrovmImageHooks { get; set; }
            /// <summary>
            /// MicrovmHooks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-hooks.html#cfn-lambda-microvmimage-hooks-microvmhooks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MicrovmHooks
            /// </summary>
            public Union<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks, BaseFunction>? MicrovmHooks { get; set; }
        }

        public class Logging : Humidifier.Base.BaseSubResource, IHaveLambdaMicrovmImageTypesCloudWatchLoggingCloudWatch, IHaveDisabled_Boolean
        {
            /// <summary>
            /// CloudWatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-logging.html#cfn-lambda-microvmimage-logging-cloudwatch
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogging
            /// </summary>
            public Union<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging, BaseFunction>? CloudWatch { get; set; }
            /// <summary>
            /// Disabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-logging.html#cfn-lambda-microvmimage-logging-disabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Disabled { get; set; }
        }

        public class MicrovmHooks : Humidifier.Base.BaseSubResource, IHaveRunTimeoutInSeconds_Integer, IHaveSuspendTimeoutInSeconds_Integer, IHaveTerminateTimeoutInSeconds_Integer, IHaveSuspend, IHaveRun, IHaveResumeTimeoutInSeconds_Integer, IHaveTerminate, IHaveResume
        {
            /// <summary>
            /// RunTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmhooks.html#cfn-lambda-microvmimage-microvmhooks-runtimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RunTimeoutInSeconds { get; set; }
            /// <summary>
            /// SuspendTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmhooks.html#cfn-lambda-microvmimage-microvmhooks-suspendtimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SuspendTimeoutInSeconds { get; set; }
            /// <summary>
            /// TerminateTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmhooks.html#cfn-lambda-microvmimage-microvmhooks-terminatetimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TerminateTimeoutInSeconds { get; set; }
            /// <summary>
            /// Suspend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmhooks.html#cfn-lambda-microvmimage-microvmhooks-suspend
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Suspend { get; set; }
            /// <summary>
            /// Run
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmhooks.html#cfn-lambda-microvmimage-microvmhooks-run
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Run { get; set; }
            /// <summary>
            /// ResumeTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmhooks.html#cfn-lambda-microvmimage-microvmhooks-resumetimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ResumeTimeoutInSeconds { get; set; }
            /// <summary>
            /// Terminate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmhooks.html#cfn-lambda-microvmimage-microvmhooks-terminate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Terminate { get; set; }
            /// <summary>
            /// Resume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmhooks.html#cfn-lambda-microvmimage-microvmhooks-resume
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Resume { get; set; }
        }

        public class MicrovmImageHooks : Humidifier.Base.BaseSubResource, IHaveReady, IHaveValidate, IHaveValidateTimeoutInSeconds_Integer, IHaveReadyTimeoutInSeconds_Integer
        {
            /// <summary>
            /// Ready
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmimagehooks.html#cfn-lambda-microvmimage-microvmimagehooks-ready
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ready { get; set; }
            /// <summary>
            /// Validate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmimagehooks.html#cfn-lambda-microvmimage-microvmimagehooks-validate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Validate { get; set; }
            /// <summary>
            /// ValidateTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmimagehooks.html#cfn-lambda-microvmimage-microvmimagehooks-validatetimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ValidateTimeoutInSeconds { get; set; }
            /// <summary>
            /// ReadyTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmimagehooks.html#cfn-lambda-microvmimage-microvmimagehooks-readytimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ReadyTimeoutInSeconds { get; set; }
        }

        public class Resources : Humidifier.Base.BaseSubResource, IHaveMinimumMemoryInMiB_Integer
        {
            /// <summary>
            /// MinimumMemoryInMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-resources.html#cfn-lambda-microvmimage-resources-minimummemoryinmib
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumMemoryInMiB { get; set; }
        }
    }
}