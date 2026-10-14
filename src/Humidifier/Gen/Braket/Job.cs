namespace Humidifier.Braket
{
    using global::System.Collections.Generic;
    using JobTypes;

    public class Job : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRoleArn, IHaveJobName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string JobArn =  "JobArn" ;
            public static string CreatedAt =  "CreatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Braket.Job; }
        /// <summary>
        /// HyperParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-job.html#cfn-braket-job-hyperparameters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> HyperParameters { get; set; }

        /// <summary>
        /// AlgorithmSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-job.html#cfn-braket-job-algorithmspecification
        /// Required: True
        /// UpdateType: Immutable
        /// Type: AlgorithmSpecification
        /// </summary>
        [Required]
        public Humidifier.Braket.JobTypes.AlgorithmSpecification AlgorithmSpecification { get; set; }

        /// <summary>
        /// InstanceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-job.html#cfn-braket-job-instanceconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: InstanceConfig
        /// </summary>
        [Required]
        public Humidifier.Braket.JobTypes.InstanceConfig InstanceConfig { get; set; }
        /// <summary>
        /// StoppingCondition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-job.html#cfn-braket-job-stoppingcondition
        /// Required: False
        /// UpdateType: Immutable
        /// Type: JobStoppingCondition
        /// </summary>
        public Humidifier.Braket.JobTypes.JobStoppingCondition StoppingCondition { get; set; }

        /// <summary>
        /// OutputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-job.html#cfn-braket-job-outputdataconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: JobOutputDataConfig
        /// </summary>
        [Required]
        public Humidifier.Braket.JobTypes.JobOutputDataConfig OutputDataConfig { get; set; }
        /// <summary>
        /// CheckpointConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-job.html#cfn-braket-job-checkpointconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: JobCheckpointConfig
        /// </summary>
        public Humidifier.Braket.JobTypes.JobCheckpointConfig CheckpointConfig { get; set; }
        public dynamic JobName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// DeviceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-job.html#cfn-braket-job-deviceconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: DeviceConfig
        /// </summary>
        [Required]
        public Humidifier.Braket.JobTypes.DeviceConfig DeviceConfig { get; set; }
        /// <summary>
        /// InputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-job.html#cfn-braket-job-inputdataconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: InputFileConfig
        /// </summary>
        public List<Humidifier.Braket.JobTypes.InputFileConfig> InputDataConfig { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-job.html#cfn-braket-job-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-job.html#cfn-braket-job-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace JobTypes
    {
        public class AlgorithmSpecification : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScriptModeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-job-algorithmspecification.html#cfn-braket-job-algorithmspecification-scriptmodeconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ScriptModeConfig
            /// </summary>
            public Humidifier.Braket.JobTypes.ScriptModeConfig ScriptModeConfig { get; set; }
        }

        public class DataSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-job-datasource.html#cfn-braket-job-datasource-s3datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataSource
            /// </summary>
            public Humidifier.Braket.JobTypes.S3DataSource S3DataSource { get; set; }
        }

        public class DeviceConfig : Humidifier.Base.BaseSubResource, IHaveDevice
        {
            /// <summary>
            /// Device
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-job-deviceconfig.html#cfn-braket-job-deviceconfig-device
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Device { get; set; }
        }

        public class InputFileConfig : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveChannelName
        {
            /// <summary>
            /// ChannelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-job-inputfileconfig.html#cfn-braket-job-inputfileconfig-channelname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChannelName { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-job-inputfileconfig.html#cfn-braket-job-inputfileconfig-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-job-inputfileconfig.html#cfn-braket-job-inputfileconfig-datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DataSource
            /// </summary>
            public Humidifier.Braket.JobTypes.DataSource DataSource { get; set; }
        }

        public class InstanceConfig : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHaveInstanceCount
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-job-instanceconfig.html#cfn-braket-job-instanceconfig-instancecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InstanceCount { get; set; }
            /// <summary>
            /// VolumeSizeInGb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-job-instanceconfig.html#cfn-braket-job-instanceconfig-volumesizeingb
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeSizeInGb { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-job-instanceconfig.html#cfn-braket-job-instanceconfig-instancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
        }

        public class JobCheckpointConfig : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveLocalPath
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-job-jobcheckpointconfig.html#cfn-braket-job-jobcheckpointconfig-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-job-jobcheckpointconfig.html#cfn-braket-job-jobcheckpointconfig-localpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocalPath { get; set; }
        }

        public class JobOutputDataConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-job-joboutputdataconfig.html#cfn-braket-job-joboutputdataconfig-s3path
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Path { get; set; }
        }

        public class JobStoppingCondition : Humidifier.Base.BaseSubResource, IHaveMaxRuntimeInSeconds
        {
            /// <summary>
            /// MaxRuntimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-job-jobstoppingcondition.html#cfn-braket-job-jobstoppingcondition-maxruntimeinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRuntimeInSeconds { get; set; }
        }

        public class S3DataSource : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-job-s3datasource.html#cfn-braket-job-s3datasource-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
        }

        public class ScriptModeConfig : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveCompressionType, IHaveEntryPoint
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-job-scriptmodeconfig.html#cfn-braket-job-scriptmodeconfig-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
            /// <summary>
            /// EntryPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-job-scriptmodeconfig.html#cfn-braket-job-scriptmodeconfig-entrypoint
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntryPoint { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-job-scriptmodeconfig.html#cfn-braket-job-scriptmodeconfig-compressiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CompressionType { get; set; }
        }
    }
}