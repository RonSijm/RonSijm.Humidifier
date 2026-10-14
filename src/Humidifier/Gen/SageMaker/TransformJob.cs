namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using TransformJobTypes;

    public class TransformJob : Humidifier.Base.BaseResource, IHaveModelName, IHaveMaxPayloadInMB
    {
        public class Attributes
        {
            public static string TransformStartTime =  "TransformStartTime" ;
            public static string CreationTime =  "CreationTime" ;
            public static string TransformJobArn =  "TransformJobArn" ;
            public static string TransformJobStatus =  "TransformJobStatus" ;
            public static string TransformJobName =  "TransformJobName" ;
            public static string TransformEndTime =  "TransformEndTime" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.TransformJob; }

        /// <summary>
        /// ModelName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-transformjob.html#cfn-sagemaker-transformjob-modelname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ModelName { get; set; }
        /// <summary>
        /// MaxPayloadInMB
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-transformjob.html#cfn-sagemaker-transformjob-maxpayloadinmb
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaxPayloadInMB { get; set; }

        /// <summary>
        /// TransformOutput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-transformjob.html#cfn-sagemaker-transformjob-transformoutput
        /// Required: True
        /// UpdateType: Immutable
        /// Type: TransformOutput
        /// </summary>
        [Required]
        public Humidifier.SageMaker.TransformJobTypes.TransformOutput TransformOutput { get; set; }

        /// <summary>
        /// TransformInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-transformjob.html#cfn-sagemaker-transformjob-transforminput
        /// Required: True
        /// UpdateType: Immutable
        /// Type: TransformInput
        /// </summary>
        [Required]
        public Humidifier.SageMaker.TransformJobTypes.TransformInput TransformInput { get; set; }
        /// <summary>
        /// DataProcessing
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-transformjob.html#cfn-sagemaker-transformjob-dataprocessing
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DataProcessing
        /// </summary>
        public Humidifier.SageMaker.TransformJobTypes.DataProcessing DataProcessing { get; set; }
        /// <summary>
        /// DataCaptureConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-transformjob.html#cfn-sagemaker-transformjob-datacaptureconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DataCaptureConfig
        /// </summary>
        public Humidifier.SageMaker.TransformJobTypes.DataCaptureConfig DataCaptureConfig { get; set; }

        /// <summary>
        /// TransformResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-transformjob.html#cfn-sagemaker-transformjob-transformresources
        /// Required: True
        /// UpdateType: Immutable
        /// Type: TransformResources
        /// </summary>
        [Required]
        public Humidifier.SageMaker.TransformJobTypes.TransformResources TransformResources { get; set; }
        /// <summary>
        /// MaxConcurrentTransforms
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-transformjob.html#cfn-sagemaker-transformjob-maxconcurrenttransforms
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaxConcurrentTransforms { get; set; }
        /// <summary>
        /// ModelClientConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-transformjob.html#cfn-sagemaker-transformjob-modelclientconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ModelClientConfig
        /// </summary>
        public Humidifier.SageMaker.TransformJobTypes.ModelClientConfig ModelClientConfig { get; set; }
        /// <summary>
        /// ExperimentConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-transformjob.html#cfn-sagemaker-transformjob-experimentconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ExperimentConfig
        /// </summary>
        public Humidifier.SageMaker.TransformJobTypes.ExperimentConfig ExperimentConfig { get; set; }
        /// <summary>
        /// Environment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-transformjob.html#cfn-sagemaker-transformjob-environment
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Environment { get; set; }
        /// <summary>
        /// BatchStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-transformjob.html#cfn-sagemaker-transformjob-batchstrategy
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BatchStrategy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-transformjob.html#cfn-sagemaker-transformjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public List<Humidifier.SageMaker.TransformJobTypes.TagsItems> Tags { get; set; }
    }

    namespace TransformJobTypes
    {
        public class DataCaptureConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-datacaptureconfig.html#cfn-sagemaker-transformjob-datacaptureconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// GenerateInferenceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-datacaptureconfig.html#cfn-sagemaker-transformjob-datacaptureconfig-generateinferenceid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic GenerateInferenceId { get; set; }
            /// <summary>
            /// DestinationS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-datacaptureconfig.html#cfn-sagemaker-transformjob-datacaptureconfig-destinations3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationS3Uri { get; set; }
        }

        public class DataProcessing : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OutputFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-dataprocessing.html#cfn-sagemaker-transformjob-dataprocessing-outputfilter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputFilter { get; set; }
            /// <summary>
            /// JoinSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-dataprocessing.html#cfn-sagemaker-transformjob-dataprocessing-joinsource
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JoinSource { get; set; }
            /// <summary>
            /// InputFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-dataprocessing.html#cfn-sagemaker-transformjob-dataprocessing-inputfilter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputFilter { get; set; }
        }

        public class DataSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-datasource.html#cfn-sagemaker-transformjob-datasource-s3datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataSource
            /// </summary>
            public Humidifier.SageMaker.TransformJobTypes.S3DataSource S3DataSource { get; set; }
        }

        public class ExperimentConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TrialName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-experimentconfig.html#cfn-sagemaker-transformjob-experimentconfig-trialname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TrialName { get; set; }
            /// <summary>
            /// ExperimentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-experimentconfig.html#cfn-sagemaker-transformjob-experimentconfig-experimentname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExperimentName { get; set; }
            /// <summary>
            /// TrialComponentDisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-experimentconfig.html#cfn-sagemaker-transformjob-experimentconfig-trialcomponentdisplayname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TrialComponentDisplayName { get; set; }
        }

        public class ModelClientConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InvocationsMaxRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-modelclientconfig.html#cfn-sagemaker-transformjob-modelclientconfig-invocationsmaxretries
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InvocationsMaxRetries { get; set; }
            /// <summary>
            /// InvocationsTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-modelclientconfig.html#cfn-sagemaker-transformjob-modelclientconfig-invocationstimeoutinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InvocationsTimeoutInSeconds { get; set; }
        }

        public class S3DataSource : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveS3DataType
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-s3datasource.html#cfn-sagemaker-transformjob-s3datasource-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
            /// <summary>
            /// S3DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-s3datasource.html#cfn-sagemaker-transformjob-s3datasource-s3datatype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3DataType { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-tagsitems.html#cfn-sagemaker-transformjob-tagsitems-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-tagsitems.html#cfn-sagemaker-transformjob-tagsitems-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class TransformInput : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveCompressionType
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-transforminput.html#cfn-sagemaker-transformjob-transforminput-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// SplitType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-transforminput.html#cfn-sagemaker-transformjob-transforminput-splittype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SplitType { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-transforminput.html#cfn-sagemaker-transformjob-transforminput-compressiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CompressionType { get; set; }
            /// <summary>
            /// DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-transforminput.html#cfn-sagemaker-transformjob-transforminput-datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DataSource
            /// </summary>
            public Humidifier.SageMaker.TransformJobTypes.DataSource DataSource { get; set; }
        }

        public class TransformOutput : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveS3OutputPath
        {
            /// <summary>
            /// AssembleWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-transformoutput.html#cfn-sagemaker-transformjob-transformoutput-assemblewith
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AssembleWith { get; set; }
            /// <summary>
            /// Accept
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-transformoutput.html#cfn-sagemaker-transformjob-transformoutput-accept
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Accept { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-transformoutput.html#cfn-sagemaker-transformjob-transformoutput-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-transformoutput.html#cfn-sagemaker-transformjob-transformoutput-s3outputpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3OutputPath { get; set; }
        }

        public class TransformResources : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHaveInstanceCount, IHaveVolumeKmsKeyId
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-transformresources.html#cfn-sagemaker-transformjob-transformresources-instancecount
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InstanceCount { get; set; }
            /// <summary>
            /// VolumeKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-transformresources.html#cfn-sagemaker-transformjob-transformresources-volumekmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeKmsKeyId { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-transformjob-transformresources.html#cfn-sagemaker-transformjob-transformresources-instancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
        }
    }
}