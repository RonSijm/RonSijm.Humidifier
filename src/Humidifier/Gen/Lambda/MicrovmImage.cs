namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using MicrovmImageTypes;

    public class MicrovmImage : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
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
        public Humidifier.Lambda.MicrovmImageTypes.Logging Logging { get; set; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Description { get; set; }

        /// <summary>
        /// CpuConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-cpuconfigurations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CpuConfiguration
        /// </summary>
        [Required]
        public List<Humidifier.Lambda.MicrovmImageTypes.CpuConfiguration> CpuConfigurations { get; set; }

        /// <summary>
        /// CodeArtifact
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-codeartifact
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CodeArtifact
        /// </summary>
        [Required]
        public Humidifier.Lambda.MicrovmImageTypes.CodeArtifact CodeArtifact { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// EnvironmentVariables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-environmentvariables
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EnvironmentVariable
        /// </summary>
        [Required]
        public List<Humidifier.Lambda.MicrovmImageTypes.EnvironmentVariable> EnvironmentVariables { get; set; }

        /// <summary>
        /// BaseImageVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-baseimageversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic BaseImageVersion { get; set; }

        /// <summary>
        /// BuildRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-buildrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic BuildRoleArn { get; set; }

        /// <summary>
        /// AdditionalOsCapabilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-additionaloscapabilities
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic AdditionalOsCapabilities { get; set; }

        /// <summary>
        /// Hooks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-hooks
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Hooks
        /// </summary>
        [Required]
        public Humidifier.Lambda.MicrovmImageTypes.Hooks Hooks { get; set; }

        /// <summary>
        /// Resources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-resources
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Resources
        /// </summary>
        [Required]
        public List<Humidifier.Lambda.MicrovmImageTypes.Resources> Resources { get; set; }

        /// <summary>
        /// BaseImageArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-baseimagearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic BaseImageArn { get; set; }

        /// <summary>
        /// EgressNetworkConnectors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-egressnetworkconnectors
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic EgressNetworkConnectors { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-microvmimage.html#cfn-lambda-microvmimage-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace MicrovmImageTypes
    {
        public class CloudWatchLogging : Humidifier.Base.BaseSubResource, IHaveLogGroup
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-cloudwatchlogging.html#cfn-lambda-microvmimage-cloudwatchlogging-loggroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroup { get; set; }
            /// <summary>
            /// LogStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-cloudwatchlogging.html#cfn-lambda-microvmimage-cloudwatchlogging-logstream
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogStream { get; set; }
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
            public dynamic Uri { get; set; }
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
            public dynamic Architecture { get; set; }
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
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-environmentvariable.html#cfn-lambda-microvmimage-environmentvariable-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class Hooks : Humidifier.Base.BaseSubResource, IHavePort
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-hooks.html#cfn-lambda-microvmimage-hooks-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// MicrovmImageHooks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-hooks.html#cfn-lambda-microvmimage-hooks-microvmimagehooks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MicrovmImageHooks
            /// </summary>
            public Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks MicrovmImageHooks { get; set; }
            /// <summary>
            /// MicrovmHooks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-hooks.html#cfn-lambda-microvmimage-hooks-microvmhooks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MicrovmHooks
            /// </summary>
            public Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks MicrovmHooks { get; set; }
        }

        public class Logging : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CloudWatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-logging.html#cfn-lambda-microvmimage-logging-cloudwatch
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogging
            /// </summary>
            public Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging CloudWatch { get; set; }
            /// <summary>
            /// Disabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-logging.html#cfn-lambda-microvmimage-logging-disabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Disabled { get; set; }
        }

        public class MicrovmHooks : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RunTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmhooks.html#cfn-lambda-microvmimage-microvmhooks-runtimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RunTimeoutInSeconds { get; set; }
            /// <summary>
            /// SuspendTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmhooks.html#cfn-lambda-microvmimage-microvmhooks-suspendtimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SuspendTimeoutInSeconds { get; set; }
            /// <summary>
            /// TerminateTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmhooks.html#cfn-lambda-microvmimage-microvmhooks-terminatetimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TerminateTimeoutInSeconds { get; set; }
            /// <summary>
            /// Suspend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmhooks.html#cfn-lambda-microvmimage-microvmhooks-suspend
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Suspend { get; set; }
            /// <summary>
            /// Run
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmhooks.html#cfn-lambda-microvmimage-microvmhooks-run
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Run { get; set; }
            /// <summary>
            /// ResumeTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmhooks.html#cfn-lambda-microvmimage-microvmhooks-resumetimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ResumeTimeoutInSeconds { get; set; }
            /// <summary>
            /// Terminate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmhooks.html#cfn-lambda-microvmimage-microvmhooks-terminate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Terminate { get; set; }
            /// <summary>
            /// Resume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmhooks.html#cfn-lambda-microvmimage-microvmhooks-resume
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Resume { get; set; }
        }

        public class MicrovmImageHooks : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Ready
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmimagehooks.html#cfn-lambda-microvmimage-microvmimagehooks-ready
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ready { get; set; }
            /// <summary>
            /// Validate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmimagehooks.html#cfn-lambda-microvmimage-microvmimagehooks-validate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Validate { get; set; }
            /// <summary>
            /// ValidateTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmimagehooks.html#cfn-lambda-microvmimage-microvmimagehooks-validatetimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ValidateTimeoutInSeconds { get; set; }
            /// <summary>
            /// ReadyTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-microvmimagehooks.html#cfn-lambda-microvmimage-microvmimagehooks-readytimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ReadyTimeoutInSeconds { get; set; }
        }

        public class Resources : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MinimumMemoryInMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-microvmimage-resources.html#cfn-lambda-microvmimage-resources-minimummemoryinmib
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumMemoryInMiB { get; set; }
        }
    }
}