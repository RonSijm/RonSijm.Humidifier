namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using EndpointConfigTypes;

    public class EndpointConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfSageMakerEndpointConfigTypesProductionVariantShadowProductionVariants, IHaveSageMakerEndpointConfigTypesDataCaptureConfigDataCaptureConfig, IHaveExecutionRoleArn, IHaveEnableNetworkIsolation_Boolean, IHaveListOfSageMakerEndpointConfigTypesProductionVariantProductionVariants, IHaveKmsKeyId, IHaveSageMakerEndpointConfigTypesAsyncInferenceConfigAsyncInferenceConfig, IHaveSageMakerEndpointConfigTypesVpcConfigVpcConfig, IHaveEndpointConfigName, IHaveSageMakerEndpointConfigTypesExplainerConfigExplainerConfig, IHaveSageMakerEndpointConfigTypesMetricsConfigMetricsConfig
    {
        public class Attributes
        {
            public static string EndpointConfigName =  "EndpointConfigName" ;
            public static string EndpointConfigArn =  "EndpointConfigArn" ;
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
        public Union<IReadOnlyList<Humidifier.SageMaker.EndpointConfigTypes.ProductionVariant>, IReadOnlyList<Union<Humidifier.SageMaker.EndpointConfigTypes.ProductionVariant, BaseFunction>>, BaseFunction>? ShadowProductionVariants { get; set; }
        /// <summary>
        /// DataCaptureConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DataCaptureConfig
        /// </summary>
        public Union<Humidifier.SageMaker.EndpointConfigTypes.DataCaptureConfig, BaseFunction>? DataCaptureConfig { get; set; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-executionrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
        /// <summary>
        /// EnableNetworkIsolation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-enablenetworkisolation
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableNetworkIsolation { get; set; }

        /// <summary>
        /// ProductionVariants
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-productionvariants
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ProductionVariant
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.SageMaker.EndpointConfigTypes.ProductionVariant>, IReadOnlyList<Union<Humidifier.SageMaker.EndpointConfigTypes.ProductionVariant, BaseFunction>>, BaseFunction>? ProductionVariants { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// AsyncInferenceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-asyncinferenceconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AsyncInferenceConfig
        /// </summary>
        public Union<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceConfig, BaseFunction>? AsyncInferenceConfig { get; set; }
        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-vpcconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcConfig
        /// </summary>
        public Union<Humidifier.SageMaker.EndpointConfigTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
        public Union<string, BaseFunction>? EndpointConfigName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ExplainerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-explainerconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ExplainerConfig
        /// </summary>
        public Union<Humidifier.SageMaker.EndpointConfigTypes.ExplainerConfig, BaseFunction>? ExplainerConfig { get; set; }
        /// <summary>
        /// MetricsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-metricsconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MetricsConfig
        /// </summary>
        public Union<Humidifier.SageMaker.EndpointConfigTypes.MetricsConfig, BaseFunction>? MetricsConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace EndpointConfigTypes
    {
        public class AsyncInferenceClientConfig : Humidifier.Base.BaseSubResource, IHaveMaxConcurrentInvocationsPerInstance_Integer
        {
            /// <summary>
            /// MaxConcurrentInvocationsPerInstance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferenceclientconfig.html#cfn-sagemaker-endpointconfig-asyncinferenceclientconfig-maxconcurrentinvocationsperinstance
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxConcurrentInvocationsPerInstance { get; set; }
        }

        public class AsyncInferenceConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerEndpointConfigTypesAsyncInferenceOutputConfigOutputConfig, IHaveSageMakerEndpointConfigTypesAsyncInferenceClientConfigClientConfig
        {
            /// <summary>
            /// OutputConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferenceconfig.html#cfn-sagemaker-endpointconfig-asyncinferenceconfig-outputconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AsyncInferenceOutputConfig
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceOutputConfig, BaseFunction>? OutputConfig { get; set; }
            /// <summary>
            /// ClientConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferenceconfig.html#cfn-sagemaker-endpointconfig-asyncinferenceconfig-clientconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AsyncInferenceClientConfig
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceClientConfig, BaseFunction>? ClientConfig { get; set; }
        }

        public class AsyncInferenceNotificationConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfIncludeInferenceResponseIn, IHaveSuccessTopic, IHaveErrorTopic
        {
            /// <summary>
            /// IncludeInferenceResponseIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferencenotificationconfig.html#cfn-sagemaker-endpointconfig-asyncinferencenotificationconfig-includeinferenceresponsein
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IncludeInferenceResponseIn { get; set; }
            /// <summary>
            /// SuccessTopic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferencenotificationconfig.html#cfn-sagemaker-endpointconfig-asyncinferencenotificationconfig-successtopic
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SuccessTopic { get; set; }
            /// <summary>
            /// ErrorTopic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferencenotificationconfig.html#cfn-sagemaker-endpointconfig-asyncinferencenotificationconfig-errortopic
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ErrorTopic { get; set; }
        }

        public class AsyncInferenceOutputConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveSageMakerEndpointConfigTypesAsyncInferenceNotificationConfigNotificationConfig, IHaveS3OutputPath, IHaveS3FailurePath
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferenceoutputconfig.html#cfn-sagemaker-endpointconfig-asyncinferenceoutputconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// NotificationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferenceoutputconfig.html#cfn-sagemaker-endpointconfig-asyncinferenceoutputconfig-notificationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AsyncInferenceNotificationConfig
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig, BaseFunction>? NotificationConfig { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferenceoutputconfig.html#cfn-sagemaker-endpointconfig-asyncinferenceoutputconfig-s3outputpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3OutputPath { get; set; }
            /// <summary>
            /// S3FailurePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferenceoutputconfig.html#cfn-sagemaker-endpointconfig-asyncinferenceoutputconfig-s3failurepath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3FailurePath { get; set; }
        }

        public class CapacityReservationConfig : Humidifier.Base.BaseSubResource, IHaveMlReservationArn, IHaveCapacityReservationPreference
        {
            /// <summary>
            /// MlReservationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-capacityreservationconfig.html#cfn-sagemaker-endpointconfig-capacityreservationconfig-mlreservationarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MlReservationArn { get; set; }
            /// <summary>
            /// CapacityReservationPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-capacityreservationconfig.html#cfn-sagemaker-endpointconfig-capacityreservationconfig-capacityreservationpreference
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationPreference { get; set; }
        }

        public class CaptureContentTypeHeader : Humidifier.Base.BaseSubResource, IHaveStringListOfJsonContentTypes, IHaveStringListOfCsvContentTypes
        {
            /// <summary>
            /// JsonContentTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-capturecontenttypeheader.html#cfn-sagemaker-endpointconfig-capturecontenttypeheader-jsoncontenttypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? JsonContentTypes { get; set; }
            /// <summary>
            /// CsvContentTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-capturecontenttypeheader.html#cfn-sagemaker-endpointconfig-capturecontenttypeheader-csvcontenttypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CsvContentTypes { get; set; }
        }

        public class CaptureOption : Humidifier.Base.BaseSubResource, IHaveCaptureMode
        {
            /// <summary>
            /// CaptureMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-captureoption.html#cfn-sagemaker-endpointconfig-captureoption-capturemode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CaptureMode { get; set; }
        }

        public class ClarifyExplainerConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerEndpointConfigTypesClarifyInferenceConfigInferenceConfig, IHaveEnableExplanations, IHaveSageMakerEndpointConfigTypesClarifyShapConfigShapConfig
        {
            /// <summary>
            /// InferenceConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyexplainerconfig.html#cfn-sagemaker-endpointconfig-clarifyexplainerconfig-inferenceconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ClarifyInferenceConfig
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointConfigTypes.ClarifyInferenceConfig, BaseFunction>? InferenceConfig { get; set; }
            /// <summary>
            /// EnableExplanations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyexplainerconfig.html#cfn-sagemaker-endpointconfig-clarifyexplainerconfig-enableexplanations
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EnableExplanations { get; set; }
            /// <summary>
            /// ShapConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyexplainerconfig.html#cfn-sagemaker-endpointconfig-clarifyexplainerconfig-shapconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ClarifyShapConfig
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointConfigTypes.ClarifyShapConfig, BaseFunction>? ShapConfig { get; set; }
        }

        public class ClarifyInferenceConfig : Humidifier.Base.BaseSubResource, IHaveContentTemplate, IHaveStringListOfLabelHeaders, IHaveMaxPayloadInMB_Integer, IHaveProbabilityIndex_Integer, IHaveLabelAttribute, IHaveStringListOfFeatureTypes, IHaveStringListOfFeatureHeaders, IHaveLabelIndex_Integer, IHaveProbabilityAttribute, IHaveFeaturesAttribute, IHaveMaxRecordCount_Integer
        {
            /// <summary>
            /// ContentTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-contenttemplate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentTemplate { get; set; }
            /// <summary>
            /// LabelHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-labelheaders
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LabelHeaders { get; set; }
            /// <summary>
            /// MaxPayloadInMB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-maxpayloadinmb
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxPayloadInMB { get; set; }
            /// <summary>
            /// ProbabilityIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-probabilityindex
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProbabilityIndex { get; set; }
            /// <summary>
            /// LabelAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-labelattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LabelAttribute { get; set; }
            /// <summary>
            /// FeatureTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-featuretypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FeatureTypes { get; set; }
            /// <summary>
            /// FeatureHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-featureheaders
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FeatureHeaders { get; set; }
            /// <summary>
            /// LabelIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-labelindex
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LabelIndex { get; set; }
            /// <summary>
            /// ProbabilityAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-probabilityattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProbabilityAttribute { get; set; }
            /// <summary>
            /// FeaturesAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-featuresattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FeaturesAttribute { get; set; }
            /// <summary>
            /// MaxRecordCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyinferenceconfig.html#cfn-sagemaker-endpointconfig-clarifyinferenceconfig-maxrecordcount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRecordCount { get; set; }
        }

        public class ClarifyShapBaselineConfig : Humidifier.Base.BaseSubResource, IHaveShapBaseline, IHaveShapBaselineUri, IHaveMimeType
        {
            /// <summary>
            /// ShapBaseline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyshapbaselineconfig.html#cfn-sagemaker-endpointconfig-clarifyshapbaselineconfig-shapbaseline
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShapBaseline { get; set; }
            /// <summary>
            /// ShapBaselineUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyshapbaselineconfig.html#cfn-sagemaker-endpointconfig-clarifyshapbaselineconfig-shapbaselineuri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShapBaselineUri { get; set; }
            /// <summary>
            /// MimeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyshapbaselineconfig.html#cfn-sagemaker-endpointconfig-clarifyshapbaselineconfig-mimetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MimeType { get; set; }
        }

        public class ClarifyShapConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerEndpointConfigTypesClarifyTextConfigTextConfig, IHaveUseLogit_Boolean, IHaveSeed_Integer, IHaveSageMakerEndpointConfigTypesClarifyShapBaselineConfigShapBaselineConfig, IHaveNumberOfSamples_Integer
        {
            /// <summary>
            /// TextConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyshapconfig.html#cfn-sagemaker-endpointconfig-clarifyshapconfig-textconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ClarifyTextConfig
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointConfigTypes.ClarifyTextConfig, BaseFunction>? TextConfig { get; set; }
            /// <summary>
            /// UseLogit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyshapconfig.html#cfn-sagemaker-endpointconfig-clarifyshapconfig-uselogit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseLogit { get; set; }
            /// <summary>
            /// Seed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyshapconfig.html#cfn-sagemaker-endpointconfig-clarifyshapconfig-seed
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Seed { get; set; }
            /// <summary>
            /// ShapBaselineConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyshapconfig.html#cfn-sagemaker-endpointconfig-clarifyshapconfig-shapbaselineconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ClarifyShapBaselineConfig
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointConfigTypes.ClarifyShapBaselineConfig, BaseFunction>? ShapBaselineConfig { get; set; }
            /// <summary>
            /// NumberOfSamples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifyshapconfig.html#cfn-sagemaker-endpointconfig-clarifyshapconfig-numberofsamples
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfSamples { get; set; }
        }

        public class ClarifyTextConfig : Humidifier.Base.BaseSubResource, IHaveLanguage, IHaveGranularity
        {
            /// <summary>
            /// Language
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifytextconfig.html#cfn-sagemaker-endpointconfig-clarifytextconfig-language
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Language { get; set; }
            /// <summary>
            /// Granularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-clarifytextconfig.html#cfn-sagemaker-endpointconfig-clarifytextconfig-granularity
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Granularity { get; set; }
        }

        public class CoreDumpConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveDestinationS3Uri
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-coredumpconfig.html#cfn-sagemaker-endpointconfig-coredumpconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// DestinationS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-coredumpconfig.html#cfn-sagemaker-endpointconfig-coredumpconfig-destinations3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationS3Uri { get; set; }
        }

        public class DataCaptureConfig : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerEndpointConfigTypesCaptureOptionCaptureOptions, IHaveKmsKeyId, IHaveDestinationS3Uri, IHaveInitialSamplingPercentage_Integer, IHaveSageMakerEndpointConfigTypesCaptureContentTypeHeaderCaptureContentTypeHeader, IHaveEnableCapture_Boolean
        {
            /// <summary>
            /// CaptureOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-captureoptions
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: CaptureOption
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.EndpointConfigTypes.CaptureOption>, IReadOnlyList<Union<Humidifier.SageMaker.EndpointConfigTypes.CaptureOption, BaseFunction>>, BaseFunction>? CaptureOptions { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// DestinationS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-destinations3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationS3Uri { get; set; }
            /// <summary>
            /// InitialSamplingPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-initialsamplingpercentage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InitialSamplingPercentage { get; set; }
            /// <summary>
            /// CaptureContentTypeHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-capturecontenttypeheader
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CaptureContentTypeHeader
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader, BaseFunction>? CaptureContentTypeHeader { get; set; }
            /// <summary>
            /// EnableCapture
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-enablecapture
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableCapture { get; set; }
        }

        public class ExplainerConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerEndpointConfigTypesClarifyExplainerConfigClarifyExplainerConfig
        {
            /// <summary>
            /// ClarifyExplainerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-explainerconfig.html#cfn-sagemaker-endpointconfig-explainerconfig-clarifyexplainerconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ClarifyExplainerConfig
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointConfigTypes.ClarifyExplainerConfig, BaseFunction>? ClarifyExplainerConfig { get; set; }
        }

        public class InstancePool : Humidifier.Base.BaseSubResource, IHaveModelNameOverride, IHavePriority_Integer, IHaveInstanceType
        {
            /// <summary>
            /// ModelNameOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-instancepool.html#cfn-sagemaker-endpointconfig-instancepool-modelnameoverride
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelNameOverride { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-instancepool.html#cfn-sagemaker-endpointconfig-instancepool-priority
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-instancepool.html#cfn-sagemaker-endpointconfig-instancepool-instancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class ManagedInstanceScaling : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveMaxInstanceCount_Integer, IHaveSageMakerEndpointConfigTypesScaleInPolicyScaleInPolicy, IHaveMinInstanceCount_Integer
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-managedinstancescaling.html#cfn-sagemaker-endpointconfig-managedinstancescaling-status
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// MaxInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-managedinstancescaling.html#cfn-sagemaker-endpointconfig-managedinstancescaling-maxinstancecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxInstanceCount { get; set; }
            /// <summary>
            /// ScaleInPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-managedinstancescaling.html#cfn-sagemaker-endpointconfig-managedinstancescaling-scaleinpolicy
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ScaleInPolicy
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy, BaseFunction>? ScaleInPolicy { get; set; }
            /// <summary>
            /// MinInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-managedinstancescaling.html#cfn-sagemaker-endpointconfig-managedinstancescaling-mininstancecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinInstanceCount { get; set; }
        }

        public class MetricsConfig : Humidifier.Base.BaseSubResource, IHaveEnableEnhancedMetrics_Boolean, IHaveEnableDetailedObservability_Boolean, IHaveMetricPublishFrequencyInSeconds_Integer
        {
            /// <summary>
            /// EnableEnhancedMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-metricsconfig.html#cfn-sagemaker-endpointconfig-metricsconfig-enableenhancedmetrics
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableEnhancedMetrics { get; set; }
            /// <summary>
            /// EnableDetailedObservability
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-metricsconfig.html#cfn-sagemaker-endpointconfig-metricsconfig-enabledetailedobservability
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableDetailedObservability { get; set; }
            /// <summary>
            /// MetricPublishFrequencyInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-metricsconfig.html#cfn-sagemaker-endpointconfig-metricsconfig-metricpublishfrequencyinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MetricPublishFrequencyInSeconds { get; set; }
        }

        public class PrefixAwareRoutingConfig : Humidifier.Base.BaseSubResource, IHaveConcurrencyThreshold_Integer, IHavePrefixLength_Integer
        {
            /// <summary>
            /// ConcurrencyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-prefixawareroutingconfig.html#cfn-sagemaker-endpointconfig-prefixawareroutingconfig-concurrencythreshold
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConcurrencyThreshold { get; set; }
            /// <summary>
            /// PrefixLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-prefixawareroutingconfig.html#cfn-sagemaker-endpointconfig-prefixawareroutingconfig-prefixlength
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PrefixLength { get; set; }
        }

        public class ProductionVariant : Humidifier.Base.BaseSubResource, IHaveSageMakerEndpointConfigTypesManagedInstanceScalingManagedInstanceScaling, IHaveListOfSageMakerEndpointConfigTypesInstancePoolInstancePools, IHaveModelName, IHaveVolumeSizeInGB_Integer, IHaveEnableSSMAccess_Boolean, IHaveVariantName, IHaveInitialInstanceCount_Integer, IHaveVariantInstanceProvisionTimeoutInSeconds_Integer, IHaveSageMakerEndpointConfigTypesRoutingConfigRoutingConfig, IHaveSageMakerEndpointConfigTypesCoreDumpConfigCoreDumpConfig, IHaveInitialVariantWeight_Double, IHaveModelDataDownloadTimeoutInSeconds_Integer, IHaveSageMakerEndpointConfigTypesCapacityReservationConfigCapacityReservationConfig, IHaveInferenceAmiVersion, IHaveContainerStartupHealthCheckTimeoutInSeconds_Integer, IHaveSageMakerEndpointConfigTypesServerlessConfigServerlessConfig, IHaveInstanceType
        {
            /// <summary>
            /// ManagedInstanceScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-managedinstancescaling
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ManagedInstanceScaling
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointConfigTypes.ManagedInstanceScaling, BaseFunction>? ManagedInstanceScaling { get; set; }
            /// <summary>
            /// InstancePools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-instancepools
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: InstancePool
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.EndpointConfigTypes.InstancePool>, IReadOnlyList<Union<Humidifier.SageMaker.EndpointConfigTypes.InstancePool, BaseFunction>>, BaseFunction>? InstancePools { get; set; }
            /// <summary>
            /// ModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-modelname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelName { get; set; }
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-volumesizeingb
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSizeInGB { get; set; }
            /// <summary>
            /// EnableSSMAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-enablessmaccess
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableSSMAccess { get; set; }
            /// <summary>
            /// VariantName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-variantname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VariantName { get; set; }
            /// <summary>
            /// InitialInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-initialinstancecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InitialInstanceCount { get; set; }
            /// <summary>
            /// VariantInstanceProvisionTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-variantinstanceprovisiontimeoutinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VariantInstanceProvisionTimeoutInSeconds { get; set; }
            /// <summary>
            /// RoutingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-routingconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RoutingConfig
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointConfigTypes.RoutingConfig, BaseFunction>? RoutingConfig { get; set; }
            /// <summary>
            /// CoreDumpConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-coredumpconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CoreDumpConfig
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointConfigTypes.CoreDumpConfig, BaseFunction>? CoreDumpConfig { get; set; }
            /// <summary>
            /// InitialVariantWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-initialvariantweight
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? InitialVariantWeight { get; set; }
            /// <summary>
            /// ModelDataDownloadTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-modeldatadownloadtimeoutinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ModelDataDownloadTimeoutInSeconds { get; set; }
            /// <summary>
            /// CapacityReservationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-capacityreservationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CapacityReservationConfig
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointConfigTypes.CapacityReservationConfig, BaseFunction>? CapacityReservationConfig { get; set; }
            /// <summary>
            /// InferenceAmiVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-inferenceamiversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InferenceAmiVersion { get; set; }
            /// <summary>
            /// ContainerStartupHealthCheckTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-containerstartuphealthchecktimeoutinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }
            /// <summary>
            /// ServerlessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-serverlessconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ServerlessConfig
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointConfigTypes.ServerlessConfig, BaseFunction>? ServerlessConfig { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-instancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class RoutingConfig : Humidifier.Base.BaseSubResource, IHaveRoutingStrategy, IHaveSageMakerEndpointConfigTypesPrefixAwareRoutingConfigPrefixAwareRoutingConfig
        {
            /// <summary>
            /// RoutingStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-routingconfig.html#cfn-sagemaker-endpointconfig-routingconfig-routingstrategy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoutingStrategy { get; set; }
            /// <summary>
            /// PrefixAwareRoutingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-routingconfig.html#cfn-sagemaker-endpointconfig-routingconfig-prefixawareroutingconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PrefixAwareRoutingConfig
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig, BaseFunction>? PrefixAwareRoutingConfig { get; set; }
        }

        public class ScaleInPolicy : Humidifier.Base.BaseSubResource, IHaveStrategy, IHaveCooldownInMinutes_Integer, IHaveMaximumStepSize_Integer
        {
            /// <summary>
            /// Strategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-scaleinpolicy.html#cfn-sagemaker-endpointconfig-scaleinpolicy-strategy
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Strategy { get; set; }
            /// <summary>
            /// CooldownInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-scaleinpolicy.html#cfn-sagemaker-endpointconfig-scaleinpolicy-cooldowninminutes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CooldownInMinutes { get; set; }
            /// <summary>
            /// MaximumStepSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-scaleinpolicy.html#cfn-sagemaker-endpointconfig-scaleinpolicy-maximumstepsize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumStepSize { get; set; }
        }

        public class ServerlessConfig : Humidifier.Base.BaseSubResource, IHaveMaxConcurrency_Integer, IHaveMemorySizeInMB_Integer, IHaveProvisionedConcurrency_Integer
        {
            /// <summary>
            /// MaxConcurrency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-serverlessconfig.html#cfn-sagemaker-endpointconfig-serverlessconfig-maxconcurrency
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxConcurrency { get; set; }
            /// <summary>
            /// MemorySizeInMB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-serverlessconfig.html#cfn-sagemaker-endpointconfig-serverlessconfig-memorysizeinmb
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MemorySizeInMB { get; set; }
            /// <summary>
            /// ProvisionedConcurrency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-serverlessconfig.html#cfn-sagemaker-endpointconfig-serverlessconfig-provisionedconcurrency
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProvisionedConcurrency { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnets, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-vpcconfig.html#cfn-sagemaker-endpointconfig-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-vpcconfig.html#cfn-sagemaker-endpointconfig-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}