namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using EndpointConfigTypes;

    public class EndpointConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveKmsKeyId, IHaveExecutionRoleArn, IHaveEnableNetworkIsolation, IHaveEndpointConfigName
    {
        public class Attributes
        {
            public static string EndpointConfigName =  "EndpointConfigName" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.EndpointConfig; }
        /// <summary>
        /// ShadowProductionVariants
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-shadowproductionvariants
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ProductionVariant
        /// </summary>
        public List<Humidifier.SageMaker.EndpointConfigTypes.ProductionVariant> ShadowProductionVariants { get; set; }
        /// <summary>
        /// DataCaptureConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DataCaptureConfig
        /// </summary>
        public Humidifier.SageMaker.EndpointConfigTypes.DataCaptureConfig DataCaptureConfig { get; set; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-executionrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExecutionRoleArn { get; set; }
        /// <summary>
        /// EnableNetworkIsolation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-enablenetworkisolation
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableNetworkIsolation { get; set; }

        /// <summary>
        /// ProductionVariants
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-productionvariants
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ProductionVariant
        /// </summary>
        [Required]
        public List<Humidifier.SageMaker.EndpointConfigTypes.ProductionVariant> ProductionVariants { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyId { get; set; }
        /// <summary>
        /// AsyncInferenceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-asyncinferenceconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AsyncInferenceConfig
        /// </summary>
        public Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceConfig AsyncInferenceConfig { get; set; }
        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-vpcconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcConfig
        /// </summary>
        public Humidifier.SageMaker.EndpointConfigTypes.VpcConfig VpcConfig { get; set; }
        public dynamic EndpointConfigName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ExplainerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-explainerconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ExplainerConfig
        /// </summary>
        public Humidifier.SageMaker.EndpointConfigTypes.ExplainerConfig ExplainerConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace EndpointConfigTypes
    {
        public class AsyncInferenceClientConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxConcurrentInvocationsPerInstance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferenceclientconfig.html#cfn-sagemaker-endpointconfig-asyncinferenceclientconfig-maxconcurrentinvocationsperinstance
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxConcurrentInvocationsPerInstance { get; set; }
        }

        public class AsyncInferenceConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OutputConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferenceconfig.html#cfn-sagemaker-endpointconfig-asyncinferenceconfig-outputconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AsyncInferenceOutputConfig
            /// </summary>
            public Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceOutputConfig OutputConfig { get; set; }
            /// <summary>
            /// ClientConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferenceconfig.html#cfn-sagemaker-endpointconfig-asyncinferenceconfig-clientconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AsyncInferenceClientConfig
            /// </summary>
            public Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceClientConfig ClientConfig { get; set; }
        }

        public class AsyncInferenceNotificationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IncludeInferenceResponseIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferencenotificationconfig.html#cfn-sagemaker-endpointconfig-asyncinferencenotificationconfig-includeinferenceresponsein
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludeInferenceResponseIn { get; set; }
            /// <summary>
            /// SuccessTopic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferencenotificationconfig.html#cfn-sagemaker-endpointconfig-asyncinferencenotificationconfig-successtopic
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SuccessTopic { get; set; }
            /// <summary>
            /// ErrorTopic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferencenotificationconfig.html#cfn-sagemaker-endpointconfig-asyncinferencenotificationconfig-errortopic
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ErrorTopic { get; set; }
        }

        public class AsyncInferenceOutputConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveS3OutputPath
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferenceoutputconfig.html#cfn-sagemaker-endpointconfig-asyncinferenceoutputconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// NotificationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferenceoutputconfig.html#cfn-sagemaker-endpointconfig-asyncinferenceoutputconfig-notificationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AsyncInferenceNotificationConfig
            /// </summary>
            public Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig NotificationConfig { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferenceoutputconfig.html#cfn-sagemaker-endpointconfig-asyncinferenceoutputconfig-s3outputpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3OutputPath { get; set; }
            /// <summary>
            /// S3FailurePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferenceoutputconfig.html#cfn-sagemaker-endpointconfig-asyncinferenceoutputconfig-s3failurepath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3FailurePath { get; set; }
        }

        public class CaptureContentTypeHeader : Humidifier.Base.BaseSubResource, IHaveJsonContentTypes, IHaveCsvContentTypes
        {
            /// <summary>
            /// JsonContentTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig-capturecontenttypeheader.html#cfn-sagemaker-endpointconfig-datacaptureconfig-capturecontenttypeheader-jsoncontenttypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic JsonContentTypes { get; set; }
            /// <summary>
            /// CsvContentTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig-capturecontenttypeheader.html#cfn-sagemaker-endpointconfig-datacaptureconfig-capturecontenttypeheader-csvcontenttypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CsvContentTypes { get; set; }
        }

        public class CaptureOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CaptureMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-captureoption.html#cfn-sagemaker-endpointconfig-captureoption-capturemode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CaptureMode { get; set; }
        }

        public class ClarifyExplainerConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InferenceConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyexplainerconfig.html#cfn-sagemaker-endpointconfig-clarifyexplainerconfig-inferenceconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ClarifyInferenceConfig
            /// </summary>
            public Humidifier.SageMaker.EndpointConfigTypes.ClarifyInferenceConfig InferenceConfig { get; set; }
            /// <summary>
            /// EnableExplanations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyexplainerconfig.html#cfn-sagemaker-endpointconfig-clarifyexplainerconfig-enableexplanations
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EnableExplanations { get; set; }
            /// <summary>
            /// ShapConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyexplainerconfig.html#cfn-sagemaker-endpointconfig-clarifyexplainerconfig-shapconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ClarifyShapConfig
            /// </summary>
            public Humidifier.SageMaker.EndpointConfigTypes.ClarifyShapConfig ShapConfig { get; set; }
        }

        public class ClarifyInferenceConfig : Humidifier.Base.BaseSubResource, IHaveProbabilityAttribute, IHaveFeaturesAttribute, IHaveMaxPayloadInMB
        {
            /// <summary>
            /// ContentTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-contenttemplate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentTemplate { get; set; }
            /// <summary>
            /// LabelHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-labelheaders
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ClarifyHeader
            /// </summary>
            public List<Humidifier.SageMaker.EndpointConfigTypes.ClarifyHeader> LabelHeaders { get; set; }
            /// <summary>
            /// MaxPayloadInMB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-maxpayloadinmb
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxPayloadInMB { get; set; }
            /// <summary>
            /// ProbabilityIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-probabilityindex
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ProbabilityIndex { get; set; }
            /// <summary>
            /// LabelAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-labelattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LabelAttribute { get; set; }
            /// <summary>
            /// FeatureTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-featuretypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ClarifyFeatureType
            /// </summary>
            public List<Humidifier.SageMaker.EndpointConfigTypes.ClarifyFeatureType> FeatureTypes { get; set; }
            /// <summary>
            /// FeatureHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-featureheaders
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ClarifyHeader
            /// </summary>
            public List<Humidifier.SageMaker.EndpointConfigTypes.ClarifyHeader> FeatureHeaders { get; set; }
            /// <summary>
            /// LabelIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-labelindex
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic LabelIndex { get; set; }
            /// <summary>
            /// ProbabilityAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-probabilityattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProbabilityAttribute { get; set; }
            /// <summary>
            /// FeaturesAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-featuresattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FeaturesAttribute { get; set; }
            /// <summary>
            /// MaxRecordCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-maxrecordcount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRecordCount { get; set; }
        }

        public class ClarifyShapBaselineConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ShapBaseline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyshapbaselineconfig.html#cfn-sagemaker-endpointconfig-clarifyshapbaselineconfig-shapbaseline
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShapBaseline { get; set; }
            /// <summary>
            /// ShapBaselineUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyshapbaselineconfig.html#cfn-sagemaker-endpointconfig-clarifyshapbaselineconfig-shapbaselineuri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShapBaselineUri { get; set; }
            /// <summary>
            /// MimeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyshapbaselineconfig.html#cfn-sagemaker-endpointconfig-clarifyshapbaselineconfig-mimetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MimeType { get; set; }
        }

        public class ClarifyShapConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TextConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyshapconfig.html#cfn-sagemaker-endpointconfig-clarifyshapconfig-textconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ClarifyTextConfig
            /// </summary>
            public Humidifier.SageMaker.EndpointConfigTypes.ClarifyTextConfig TextConfig { get; set; }
            /// <summary>
            /// UseLogit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyshapconfig.html#cfn-sagemaker-endpointconfig-clarifyshapconfig-uselogit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic UseLogit { get; set; }
            /// <summary>
            /// Seed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyshapconfig.html#cfn-sagemaker-endpointconfig-clarifyshapconfig-seed
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Seed { get; set; }
            /// <summary>
            /// ShapBaselineConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyshapconfig.html#cfn-sagemaker-endpointconfig-clarifyshapconfig-shapbaselineconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ClarifyShapBaselineConfig
            /// </summary>
            public Humidifier.SageMaker.EndpointConfigTypes.ClarifyShapBaselineConfig ShapBaselineConfig { get; set; }
            /// <summary>
            /// NumberOfSamples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyshapconfig.html#cfn-sagemaker-endpointconfig-clarifyshapconfig-numberofsamples
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfSamples { get; set; }
        }

        public class ClarifyTextConfig : Humidifier.Base.BaseSubResource, IHaveGranularity, IHaveLanguage
        {
            /// <summary>
            /// Language
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifytextconfig.html#cfn-sagemaker-endpointconfig-clarifytextconfig-language
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Language { get; set; }
            /// <summary>
            /// Granularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifytextconfig.html#cfn-sagemaker-endpointconfig-clarifytextconfig-granularity
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Granularity { get; set; }
        }

        public class DataCaptureConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId
        {
            /// <summary>
            /// CaptureOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-captureoptions
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: CaptureOption
            /// </summary>
            public List<Humidifier.SageMaker.EndpointConfigTypes.CaptureOption> CaptureOptions { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// DestinationS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-destinations3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationS3Uri { get; set; }
            /// <summary>
            /// InitialSamplingPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-initialsamplingpercentage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InitialSamplingPercentage { get; set; }
            /// <summary>
            /// CaptureContentTypeHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-capturecontenttypeheader
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CaptureContentTypeHeader
            /// </summary>
            public Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader CaptureContentTypeHeader { get; set; }
            /// <summary>
            /// EnableCapture
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-enablecapture
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableCapture { get; set; }
        }

        public class ExplainerConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ClarifyExplainerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-explainerconfig.html#cfn-sagemaker-endpointconfig-explainerconfig-clarifyexplainerconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ClarifyExplainerConfig
            /// </summary>
            public Humidifier.SageMaker.EndpointConfigTypes.ClarifyExplainerConfig ClarifyExplainerConfig { get; set; }
        }

        public class ManagedInstanceScaling : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveMaxInstanceCount, IHaveMinInstanceCount
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant-managedinstancescaling.html#cfn-sagemaker-endpointconfig-productionvariant-managedinstancescaling-status
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// MaxInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant-managedinstancescaling.html#cfn-sagemaker-endpointconfig-productionvariant-managedinstancescaling-maxinstancecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxInstanceCount { get; set; }
            /// <summary>
            /// MinInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant-managedinstancescaling.html#cfn-sagemaker-endpointconfig-productionvariant-managedinstancescaling-mininstancecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinInstanceCount { get; set; }
        }

        public class ProductionVariant : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHaveVolumeSizeInGB, IHaveModelName, IHaveVariantName, IHaveModelDataDownloadTimeoutInSeconds, IHaveContainerStartupHealthCheckTimeoutInSeconds
        {
            /// <summary>
            /// ManagedInstanceScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-managedinstancescaling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedInstanceScaling
            /// </summary>
            public Humidifier.SageMaker.EndpointConfigTypes.ManagedInstanceScaling ManagedInstanceScaling { get; set; }
            /// <summary>
            /// ModelDataDownloadTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-modeldatadownloadtimeoutinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ModelDataDownloadTimeoutInSeconds { get; set; }
            /// <summary>
            /// ModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-modelname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelName { get; set; }
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-volumesizeingb
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeSizeInGB { get; set; }
            /// <summary>
            /// EnableSSMAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-enablessmaccess
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableSSMAccess { get; set; }
            /// <summary>
            /// VariantName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-variantname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VariantName { get; set; }
            /// <summary>
            /// ContainerStartupHealthCheckTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-containerstartuphealthchecktimeoutinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ContainerStartupHealthCheckTimeoutInSeconds { get; set; }
            /// <summary>
            /// InitialInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-initialinstancecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InitialInstanceCount { get; set; }
            /// <summary>
            /// ServerlessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-serverlessconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServerlessConfig
            /// </summary>
            public Humidifier.SageMaker.EndpointConfigTypes.ServerlessConfig ServerlessConfig { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-instancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
            /// <summary>
            /// RoutingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-routingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RoutingConfig
            /// </summary>
            public Humidifier.SageMaker.EndpointConfigTypes.RoutingConfig RoutingConfig { get; set; }
            /// <summary>
            /// InitialVariantWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-initialvariantweight
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic InitialVariantWeight { get; set; }
        }

        public class RoutingConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RoutingStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant-routingconfig.html#cfn-sagemaker-endpointconfig-productionvariant-routingconfig-routingstrategy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoutingStrategy { get; set; }
        }

        public class ServerlessConfig : Humidifier.Base.BaseSubResource, IHaveMaxConcurrency
        {
            /// <summary>
            /// MaxConcurrency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant-serverlessconfig.html#cfn-sagemaker-endpointconfig-productionvariant-serverlessconfig-maxconcurrency
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxConcurrency { get; set; }
            /// <summary>
            /// MemorySizeInMB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant-serverlessconfig.html#cfn-sagemaker-endpointconfig-productionvariant-serverlessconfig-memorysizeinmb
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MemorySizeInMB { get; set; }
            /// <summary>
            /// ProvisionedConcurrency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant-serverlessconfig.html#cfn-sagemaker-endpointconfig-productionvariant-serverlessconfig-provisionedconcurrency
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ProvisionedConcurrency { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnets
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-vpcconfig.html#cfn-sagemaker-endpointconfig-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-vpcconfig.html#cfn-sagemaker-endpointconfig-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }
    }
}