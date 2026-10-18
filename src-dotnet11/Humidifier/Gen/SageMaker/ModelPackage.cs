namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using ModelPackageTypes;

    public class ModelPackage : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSageMakerModelPackageTypesDriftCheckBaselinesDriftCheckBaselines, IHaveSageMakerModelPackageTypesModelMetricsModelMetrics, IHaveTask, IHaveStringDictionaryOfCustomerMetadataProperties, IHaveSourceUri, IHaveModelApprovalStatus, IHaveModelPackageVersion_Integer, IHaveSageMakerModelPackageTypesMetadataPropertiesMetadataProperties, IHaveSageMakerModelPackageTypesSourceAlgorithmSpecificationSourceAlgorithmSpecification, IHaveSageMakerModelPackageTypesModelPackageStatusDetailsModelPackageStatusDetails, IHaveModelPackageDescription, IHaveListOfSageMakerModelPackageTypesAdditionalInferenceSpecificationDefinitionAdditionalInferenceSpecificationsToAdd, IHaveSageMakerModelPackageTypesSecurityConfigSecurityConfig, IHaveSageMakerModelPackageTypesInferenceSpecificationInferenceSpecification, IHaveSamplePayloadUrl, IHaveCertifyForMarketplace_Boolean, IHaveModelPackageGroupName, IHaveApprovalDescription, IHaveSageMakerModelPackageTypesModelCardModelCard, IHaveSageMakerModelPackageTypesValidationSpecificationValidationSpecification, IHaveSkipModelValidation, IHaveModelPackageName, IHaveClientToken, IHaveDomain, IHaveListOfSageMakerModelPackageTypesAdditionalInferenceSpecificationDefinitionAdditionalInferenceSpecifications, IHaveDescription
    {
        public class Attributes
        {
            public static string ModelPackageStatus =  "ModelPackageStatus" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string ModelPackageArn =  "ModelPackageArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.ModelPackage; }
        /// <summary>
        /// DriftCheckBaselines
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-driftcheckbaselines
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DriftCheckBaselines
        /// </summary>
        public Union<Humidifier.SageMaker.ModelPackageTypes.DriftCheckBaselines, BaseFunction>? DriftCheckBaselines { get; set; }
        /// <summary>
        /// ModelMetrics
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-modelmetrics
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ModelMetrics
        /// </summary>
        public Union<Humidifier.SageMaker.ModelPackageTypes.ModelMetrics, BaseFunction>? ModelMetrics { get; set; }
        /// <summary>
        /// Task
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-task
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Task { get; set; }
        /// <summary>
        /// CustomerMetadataProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-customermetadataproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? CustomerMetadataProperties { get; set; }
        /// <summary>
        /// SourceUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-sourceuri
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceUri { get; set; }
        /// <summary>
        /// ModelApprovalStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-modelapprovalstatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ModelApprovalStatus { get; set; }
        /// <summary>
        /// ModelPackageVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-modelpackageversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ModelPackageVersion { get; set; }
        /// <summary>
        /// MetadataProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-metadataproperties
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MetadataProperties
        /// </summary>
        public Union<Humidifier.SageMaker.ModelPackageTypes.MetadataProperties, BaseFunction>? MetadataProperties { get; set; }
        /// <summary>
        /// SourceAlgorithmSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-sourcealgorithmspecification
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SourceAlgorithmSpecification
        /// </summary>
        public Union<Humidifier.SageMaker.ModelPackageTypes.SourceAlgorithmSpecification, BaseFunction>? SourceAlgorithmSpecification { get; set; }
        /// <summary>
        /// ModelPackageStatusDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-modelpackagestatusdetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ModelPackageStatusDetails
        /// </summary>
        public Union<Humidifier.SageMaker.ModelPackageTypes.ModelPackageStatusDetails, BaseFunction>? ModelPackageStatusDetails { get; set; }
        /// <summary>
        /// ModelPackageDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-modelpackagedescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ModelPackageDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => ModelPackageDescription; set => ModelPackageDescription = value; }
        /// <summary>
        /// AdditionalInferenceSpecificationsToAdd
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-additionalinferencespecificationstoadd
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AdditionalInferenceSpecificationDefinition
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SageMaker.ModelPackageTypes.AdditionalInferenceSpecificationDefinition>, IReadOnlyList<Union<Humidifier.SageMaker.ModelPackageTypes.AdditionalInferenceSpecificationDefinition, BaseFunction>>, BaseFunction>? AdditionalInferenceSpecificationsToAdd { get; set; }
        /// <summary>
        /// SecurityConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-securityconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SecurityConfig
        /// </summary>
        public Union<Humidifier.SageMaker.ModelPackageTypes.SecurityConfig, BaseFunction>? SecurityConfig { get; set; }
        /// <summary>
        /// InferenceSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-inferencespecification
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InferenceSpecification
        /// </summary>
        public Union<Humidifier.SageMaker.ModelPackageTypes.InferenceSpecification, BaseFunction>? InferenceSpecification { get; set; }
        /// <summary>
        /// SamplePayloadUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-samplepayloadurl
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SamplePayloadUrl { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// CertifyForMarketplace
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-certifyformarketplace
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? CertifyForMarketplace { get; set; }
        /// <summary>
        /// ModelPackageGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-modelpackagegroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ModelPackageGroupName { get; set; }
        /// <summary>
        /// ApprovalDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-approvaldescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ApprovalDescription { get; set; }
        /// <summary>
        /// ModelCard
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-modelcard
        /// Required: False
        /// UpdateType: Conditional
        /// Type: ModelCard
        /// </summary>
        public Union<Humidifier.SageMaker.ModelPackageTypes.ModelCard, BaseFunction>? ModelCard { get; set; }
        /// <summary>
        /// ValidationSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-validationspecification
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ValidationSpecification
        /// </summary>
        public Union<Humidifier.SageMaker.ModelPackageTypes.ValidationSpecification, BaseFunction>? ValidationSpecification { get; set; }
        /// <summary>
        /// SkipModelValidation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-skipmodelvalidation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SkipModelValidation { get; set; }
        public Union<string, BaseFunction>? ModelPackageName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-clienttoken
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientToken { get; set; }
        /// <summary>
        /// Domain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-domain
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Domain { get; set; }
        /// <summary>
        /// AdditionalInferenceSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-additionalinferencespecifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AdditionalInferenceSpecificationDefinition
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SageMaker.ModelPackageTypes.AdditionalInferenceSpecificationDefinition>, IReadOnlyList<Union<Humidifier.SageMaker.ModelPackageTypes.AdditionalInferenceSpecificationDefinition, BaseFunction>>, BaseFunction>? AdditionalInferenceSpecifications { get; set; }
    }

    namespace ModelPackageTypes
    {
        public class AdditionalInferenceSpecificationDefinition : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveStringListOfSupportedContentTypes, IHaveStringListOfSupportedRealtimeInferenceInstanceTypes, IHaveListOfSageMakerModelPackageTypesModelPackageContainerDefinitionContainers, IHaveStringListOfSupportedTransformInstanceTypes, IHaveName, IHaveStringListOfSupportedResponseMIMETypes
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-additionalinferencespecificationdefinition.html#cfn-sagemaker-modelpackage-additionalinferencespecificationdefinition-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// SupportedContentTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-additionalinferencespecificationdefinition.html#cfn-sagemaker-modelpackage-additionalinferencespecificationdefinition-supportedcontenttypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedContentTypes { get; set; }
            /// <summary>
            /// SupportedRealtimeInferenceInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-additionalinferencespecificationdefinition.html#cfn-sagemaker-modelpackage-additionalinferencespecificationdefinition-supportedrealtimeinferenceinstancetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedRealtimeInferenceInstanceTypes { get; set; }
            /// <summary>
            /// Containers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-additionalinferencespecificationdefinition.html#cfn-sagemaker-modelpackage-additionalinferencespecificationdefinition-containers
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ModelPackageContainerDefinition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ModelPackageTypes.ModelPackageContainerDefinition>, IReadOnlyList<Union<Humidifier.SageMaker.ModelPackageTypes.ModelPackageContainerDefinition, BaseFunction>>, BaseFunction>? Containers { get; set; }
            /// <summary>
            /// SupportedTransformInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-additionalinferencespecificationdefinition.html#cfn-sagemaker-modelpackage-additionalinferencespecificationdefinition-supportedtransforminstancetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedTransformInstanceTypes { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-additionalinferencespecificationdefinition.html#cfn-sagemaker-modelpackage-additionalinferencespecificationdefinition-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// SupportedResponseMIMETypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-additionalinferencespecificationdefinition.html#cfn-sagemaker-modelpackage-additionalinferencespecificationdefinition-supportedresponsemimetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedResponseMIMETypes { get; set; }
        }

        public class Bias : Humidifier.Base.BaseSubResource, IHaveSageMakerModelPackageTypesMetricsSourceReport, IHaveSageMakerModelPackageTypesMetricsSourcePreTrainingReport, IHaveSageMakerModelPackageTypesMetricsSourcePostTrainingReport
        {
            /// <summary>
            /// Report
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-bias.html#cfn-sagemaker-modelpackage-bias-report
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.MetricsSource, BaseFunction>? Report { get; set; }
            /// <summary>
            /// PreTrainingReport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-bias.html#cfn-sagemaker-modelpackage-bias-pretrainingreport
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.MetricsSource, BaseFunction>? PreTrainingReport { get; set; }
            /// <summary>
            /// PostTrainingReport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-bias.html#cfn-sagemaker-modelpackage-bias-posttrainingreport
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.MetricsSource, BaseFunction>? PostTrainingReport { get; set; }
        }

        public class DataSource : Humidifier.Base.BaseSubResource, IHaveSageMakerModelPackageTypesS3DataSourceS3DataSource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-datasource.html#cfn-sagemaker-modelpackage-datasource-s3datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.S3DataSource, BaseFunction>? S3DataSource { get; set; }
        }

        public class DriftCheckBaselines : Humidifier.Base.BaseSubResource, IHaveSageMakerModelPackageTypesDriftCheckModelDataQualityModelDataQuality, IHaveSageMakerModelPackageTypesDriftCheckBiasBias, IHaveSageMakerModelPackageTypesDriftCheckModelQualityModelQuality, IHaveSageMakerModelPackageTypesDriftCheckExplainabilityExplainability
        {
            /// <summary>
            /// ModelDataQuality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckbaselines.html#cfn-sagemaker-modelpackage-driftcheckbaselines-modeldataquality
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DriftCheckModelDataQuality
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.DriftCheckModelDataQuality, BaseFunction>? ModelDataQuality { get; set; }
            /// <summary>
            /// Bias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckbaselines.html#cfn-sagemaker-modelpackage-driftcheckbaselines-bias
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DriftCheckBias
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.DriftCheckBias, BaseFunction>? Bias { get; set; }
            /// <summary>
            /// ModelQuality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckbaselines.html#cfn-sagemaker-modelpackage-driftcheckbaselines-modelquality
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DriftCheckModelQuality
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.DriftCheckModelQuality, BaseFunction>? ModelQuality { get; set; }
            /// <summary>
            /// Explainability
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckbaselines.html#cfn-sagemaker-modelpackage-driftcheckbaselines-explainability
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DriftCheckExplainability
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.DriftCheckExplainability, BaseFunction>? Explainability { get; set; }
        }

        public class DriftCheckBias : Humidifier.Base.BaseSubResource, IHaveSageMakerModelPackageTypesMetricsSourcePreTrainingConstraints, IHaveSageMakerModelPackageTypesFileSourceConfigFile, IHaveSageMakerModelPackageTypesMetricsSourcePostTrainingConstraints
        {
            /// <summary>
            /// PreTrainingConstraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckbias.html#cfn-sagemaker-modelpackage-driftcheckbias-pretrainingconstraints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.MetricsSource, BaseFunction>? PreTrainingConstraints { get; set; }
            /// <summary>
            /// ConfigFile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckbias.html#cfn-sagemaker-modelpackage-driftcheckbias-configfile
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FileSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.FileSource, BaseFunction>? ConfigFile { get; set; }
            /// <summary>
            /// PostTrainingConstraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckbias.html#cfn-sagemaker-modelpackage-driftcheckbias-posttrainingconstraints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.MetricsSource, BaseFunction>? PostTrainingConstraints { get; set; }
        }

        public class DriftCheckExplainability : Humidifier.Base.BaseSubResource, IHaveSageMakerModelPackageTypesMetricsSourceConstraints, IHaveSageMakerModelPackageTypesFileSourceConfigFile
        {
            /// <summary>
            /// Constraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckexplainability.html#cfn-sagemaker-modelpackage-driftcheckexplainability-constraints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.MetricsSource, BaseFunction>? Constraints { get; set; }
            /// <summary>
            /// ConfigFile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckexplainability.html#cfn-sagemaker-modelpackage-driftcheckexplainability-configfile
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FileSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.FileSource, BaseFunction>? ConfigFile { get; set; }
        }

        public class DriftCheckModelDataQuality : Humidifier.Base.BaseSubResource, IHaveSageMakerModelPackageTypesMetricsSourceConstraints, IHaveSageMakerModelPackageTypesMetricsSourceStatistics
        {
            /// <summary>
            /// Constraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckmodeldataquality.html#cfn-sagemaker-modelpackage-driftcheckmodeldataquality-constraints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.MetricsSource, BaseFunction>? Constraints { get; set; }
            /// <summary>
            /// Statistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckmodeldataquality.html#cfn-sagemaker-modelpackage-driftcheckmodeldataquality-statistics
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.MetricsSource, BaseFunction>? Statistics { get; set; }
        }

        public class DriftCheckModelQuality : Humidifier.Base.BaseSubResource, IHaveSageMakerModelPackageTypesMetricsSourceConstraints, IHaveSageMakerModelPackageTypesMetricsSourceStatistics
        {
            /// <summary>
            /// Constraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckmodelquality.html#cfn-sagemaker-modelpackage-driftcheckmodelquality-constraints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.MetricsSource, BaseFunction>? Constraints { get; set; }
            /// <summary>
            /// Statistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckmodelquality.html#cfn-sagemaker-modelpackage-driftcheckmodelquality-statistics
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.MetricsSource, BaseFunction>? Statistics { get; set; }
        }

        public class Explainability : Humidifier.Base.BaseSubResource, IHaveSageMakerModelPackageTypesMetricsSourceReport
        {
            /// <summary>
            /// Report
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-explainability.html#cfn-sagemaker-modelpackage-explainability-report
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.MetricsSource, BaseFunction>? Report { get; set; }
        }

        public class FileSource : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveS3Uri, IHaveContentDigest
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-filesource.html#cfn-sagemaker-modelpackage-filesource-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-filesource.html#cfn-sagemaker-modelpackage-filesource-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// ContentDigest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-filesource.html#cfn-sagemaker-modelpackage-filesource-contentdigest
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentDigest { get; set; }
        }

        public class InferenceSpecification : Humidifier.Base.BaseSubResource, IHaveStringListOfSupportedContentTypes, IHaveStringListOfSupportedRealtimeInferenceInstanceTypes, IHaveListOfSageMakerModelPackageTypesModelPackageContainerDefinitionContainers, IHaveStringListOfSupportedTransformInstanceTypes, IHaveStringListOfSupportedResponseMIMETypes
        {
            /// <summary>
            /// SupportedContentTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-inferencespecification.html#cfn-sagemaker-modelpackage-inferencespecification-supportedcontenttypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedContentTypes { get; set; }
            /// <summary>
            /// SupportedRealtimeInferenceInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-inferencespecification.html#cfn-sagemaker-modelpackage-inferencespecification-supportedrealtimeinferenceinstancetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedRealtimeInferenceInstanceTypes { get; set; }
            /// <summary>
            /// Containers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-inferencespecification.html#cfn-sagemaker-modelpackage-inferencespecification-containers
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ModelPackageContainerDefinition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ModelPackageTypes.ModelPackageContainerDefinition>, IReadOnlyList<Union<Humidifier.SageMaker.ModelPackageTypes.ModelPackageContainerDefinition, BaseFunction>>, BaseFunction>? Containers { get; set; }
            /// <summary>
            /// SupportedTransformInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-inferencespecification.html#cfn-sagemaker-modelpackage-inferencespecification-supportedtransforminstancetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedTransformInstanceTypes { get; set; }
            /// <summary>
            /// SupportedResponseMIMETypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-inferencespecification.html#cfn-sagemaker-modelpackage-inferencespecification-supportedresponsemimetypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedResponseMIMETypes { get; set; }
        }

        public class MetadataProperties : Humidifier.Base.BaseSubResource, IHaveGeneratedBy, IHaveRepository, IHaveCommitId, IHaveProjectId
        {
            /// <summary>
            /// GeneratedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-metadataproperties.html#cfn-sagemaker-modelpackage-metadataproperties-generatedby
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GeneratedBy { get; set; }
            /// <summary>
            /// Repository
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-metadataproperties.html#cfn-sagemaker-modelpackage-metadataproperties-repository
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Repository { get; set; }
            /// <summary>
            /// CommitId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-metadataproperties.html#cfn-sagemaker-modelpackage-metadataproperties-commitid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CommitId { get; set; }
            /// <summary>
            /// ProjectId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-metadataproperties.html#cfn-sagemaker-modelpackage-metadataproperties-projectid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProjectId { get; set; }
        }

        public class MetricsSource : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveS3Uri, IHaveContentDigest
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-metricssource.html#cfn-sagemaker-modelpackage-metricssource-contenttype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-metricssource.html#cfn-sagemaker-modelpackage-metricssource-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// ContentDigest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-metricssource.html#cfn-sagemaker-modelpackage-metricssource-contentdigest
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentDigest { get; set; }
        }

        public class ModelAccessConfig : Humidifier.Base.BaseSubResource, IHaveAcceptEula_Boolean
        {
            /// <summary>
            /// AcceptEula
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelaccessconfig.html#cfn-sagemaker-modelpackage-modelaccessconfig-accepteula
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AcceptEula { get; set; }
        }

        public class ModelCard : Humidifier.Base.BaseSubResource, IHaveModelCardStatus, IHaveModelCardContent
        {
            /// <summary>
            /// ModelCardStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelcard.html#cfn-sagemaker-modelpackage-modelcard-modelcardstatus
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelCardStatus { get; set; }
            /// <summary>
            /// ModelCardContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelcard.html#cfn-sagemaker-modelpackage-modelcard-modelcardcontent
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelCardContent { get; set; }
        }

        public class ModelDataQuality : Humidifier.Base.BaseSubResource, IHaveSageMakerModelPackageTypesMetricsSourceConstraints, IHaveSageMakerModelPackageTypesMetricsSourceStatistics
        {
            /// <summary>
            /// Constraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modeldataquality.html#cfn-sagemaker-modelpackage-modeldataquality-constraints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.MetricsSource, BaseFunction>? Constraints { get; set; }
            /// <summary>
            /// Statistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modeldataquality.html#cfn-sagemaker-modelpackage-modeldataquality-statistics
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.MetricsSource, BaseFunction>? Statistics { get; set; }
        }

        public class ModelDataSource : Humidifier.Base.BaseSubResource, IHaveSageMakerModelPackageTypesS3ModelDataSourceS3DataSource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modeldatasource.html#cfn-sagemaker-modelpackage-modeldatasource-s3datasource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3ModelDataSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.S3ModelDataSource, BaseFunction>? S3DataSource { get; set; }
        }

        public class ModelInput : Humidifier.Base.BaseSubResource, IHaveDataInputConfig
        {
            /// <summary>
            /// DataInputConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelinput.html#cfn-sagemaker-modelpackage-modelinput-datainputconfig
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataInputConfig { get; set; }
        }

        public class ModelMetrics : Humidifier.Base.BaseSubResource, IHaveSageMakerModelPackageTypesModelDataQualityModelDataQuality, IHaveSageMakerModelPackageTypesBiasBias, IHaveSageMakerModelPackageTypesModelQualityModelQuality, IHaveSageMakerModelPackageTypesExplainabilityExplainability
        {
            /// <summary>
            /// ModelDataQuality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelmetrics.html#cfn-sagemaker-modelpackage-modelmetrics-modeldataquality
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelDataQuality
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.ModelDataQuality, BaseFunction>? ModelDataQuality { get; set; }
            /// <summary>
            /// Bias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelmetrics.html#cfn-sagemaker-modelpackage-modelmetrics-bias
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Bias
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.Bias, BaseFunction>? Bias { get; set; }
            /// <summary>
            /// ModelQuality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelmetrics.html#cfn-sagemaker-modelpackage-modelmetrics-modelquality
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelQuality
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.ModelQuality, BaseFunction>? ModelQuality { get; set; }
            /// <summary>
            /// Explainability
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelmetrics.html#cfn-sagemaker-modelpackage-modelmetrics-explainability
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Explainability
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.Explainability, BaseFunction>? Explainability { get; set; }
        }

        public class ModelPackageContainerDefinition : Humidifier.Base.BaseSubResource, IHaveSageMakerModelPackageTypesModelInputModelInput, IHaveNearestModelName, IHaveContainerHostname, IHaveImageDigest, IHaveFrameworkVersion, IHaveStringDictionaryOfEnvironment, IHaveModelDataUrl, IHaveImage, IHaveSageMakerModelPackageTypesModelDataSourceModelDataSource, IHaveFramework
        {
            /// <summary>
            /// ModelInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-modelinput
            /// Required: False
            /// UpdateType: Conditional
            /// Type: ModelInput
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.ModelInput, BaseFunction>? ModelInput { get; set; }
            /// <summary>
            /// NearestModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-nearestmodelname
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NearestModelName { get; set; }
            /// <summary>
            /// ContainerHostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-containerhostname
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerHostname { get; set; }
            /// <summary>
            /// ImageDigest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-imagedigest
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageDigest { get; set; }
            /// <summary>
            /// FrameworkVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-frameworkversion
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FrameworkVersion { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-environment
            /// Required: False
            /// UpdateType: Conditional
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Environment { get; set; }
            /// <summary>
            /// ModelDataUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-modeldataurl
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelDataUrl { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-image
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Image { get; set; }
            /// <summary>
            /// ModelDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-modeldatasource
            /// Required: False
            /// UpdateType: Conditional
            /// Type: ModelDataSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.ModelDataSource, BaseFunction>? ModelDataSource { get; set; }
            /// <summary>
            /// Framework
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-framework
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Framework { get; set; }
        }

        public class ModelPackageStatusDetails : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerModelPackageTypesModelPackageStatusItemValidationStatuses
        {
            /// <summary>
            /// ValidationStatuses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagestatusdetails.html#cfn-sagemaker-modelpackage-modelpackagestatusdetails-validationstatuses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ModelPackageStatusItem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ModelPackageTypes.ModelPackageStatusItem>, IReadOnlyList<Union<Humidifier.SageMaker.ModelPackageTypes.ModelPackageStatusItem, BaseFunction>>, BaseFunction>? ValidationStatuses { get; set; }
        }

        public class ModelPackageStatusItem : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveFailureReason, IHaveName
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagestatusitem.html#cfn-sagemaker-modelpackage-modelpackagestatusitem-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// FailureReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagestatusitem.html#cfn-sagemaker-modelpackage-modelpackagestatusitem-failurereason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FailureReason { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagestatusitem.html#cfn-sagemaker-modelpackage-modelpackagestatusitem-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ModelQuality : Humidifier.Base.BaseSubResource, IHaveSageMakerModelPackageTypesMetricsSourceConstraints, IHaveSageMakerModelPackageTypesMetricsSourceStatistics
        {
            /// <summary>
            /// Constraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelquality.html#cfn-sagemaker-modelpackage-modelquality-constraints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.MetricsSource, BaseFunction>? Constraints { get; set; }
            /// <summary>
            /// Statistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelquality.html#cfn-sagemaker-modelpackage-modelquality-statistics
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.MetricsSource, BaseFunction>? Statistics { get; set; }
        }

        public class S3DataSource : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveS3DataType
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-s3datasource.html#cfn-sagemaker-modelpackage-s3datasource-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// S3DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-s3datasource.html#cfn-sagemaker-modelpackage-s3datasource-s3datatype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataType { get; set; }
        }

        public class S3ModelDataSource : Humidifier.Base.BaseSubResource, IHaveSageMakerModelPackageTypesModelAccessConfigModelAccessConfig, IHaveS3Uri, IHaveS3DataType, IHaveCompressionType
        {
            /// <summary>
            /// ModelAccessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-s3modeldatasource.html#cfn-sagemaker-modelpackage-s3modeldatasource-modelaccessconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModelAccessConfig
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.ModelAccessConfig, BaseFunction>? ModelAccessConfig { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-s3modeldatasource.html#cfn-sagemaker-modelpackage-s3modeldatasource-s3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// S3DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-s3modeldatasource.html#cfn-sagemaker-modelpackage-s3modeldatasource-s3datatype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataType { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-s3modeldatasource.html#cfn-sagemaker-modelpackage-s3modeldatasource-compressiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CompressionType { get; set; }
        }

        public class SecurityConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-securityconfig.html#cfn-sagemaker-modelpackage-securityconfig-kmskeyid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
        }

        public class SourceAlgorithm : Humidifier.Base.BaseSubResource, IHaveModelDataUrl, IHaveAlgorithmName
        {
            /// <summary>
            /// ModelDataUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-sourcealgorithm.html#cfn-sagemaker-modelpackage-sourcealgorithm-modeldataurl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelDataUrl { get; set; }
            /// <summary>
            /// AlgorithmName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-sourcealgorithm.html#cfn-sagemaker-modelpackage-sourcealgorithm-algorithmname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlgorithmName { get; set; }
        }

        public class SourceAlgorithmSpecification : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerModelPackageTypesSourceAlgorithmSourceAlgorithms
        {
            /// <summary>
            /// SourceAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-sourcealgorithmspecification.html#cfn-sagemaker-modelpackage-sourcealgorithmspecification-sourcealgorithms
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SourceAlgorithm
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ModelPackageTypes.SourceAlgorithm>, IReadOnlyList<Union<Humidifier.SageMaker.ModelPackageTypes.SourceAlgorithm, BaseFunction>>, BaseFunction>? SourceAlgorithms { get; set; }
        }

        public class TransformInput : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveSplitType, IHaveCompressionType, IHaveSageMakerModelPackageTypesDataSourceDataSource
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transforminput.html#cfn-sagemaker-modelpackage-transforminput-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// SplitType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transforminput.html#cfn-sagemaker-modelpackage-transforminput-splittype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SplitType { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transforminput.html#cfn-sagemaker-modelpackage-transforminput-compressiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CompressionType { get; set; }
            /// <summary>
            /// DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transforminput.html#cfn-sagemaker-modelpackage-transforminput-datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DataSource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.DataSource, BaseFunction>? DataSource { get; set; }
        }

        public class TransformJobDefinition : Humidifier.Base.BaseSubResource, IHaveSageMakerModelPackageTypesTransformResourcesTransformResources, IHaveMaxConcurrentTransforms_Integer, IHaveMaxPayloadInMB_Integer, IHaveSageMakerModelPackageTypesTransformOutputTransformOutput, IHaveStringDictionaryOfEnvironment, IHaveSageMakerModelPackageTypesTransformInputTransformInput, IHaveBatchStrategy
        {
            /// <summary>
            /// TransformResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformjobdefinition.html#cfn-sagemaker-modelpackage-transformjobdefinition-transformresources
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TransformResources
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.TransformResources, BaseFunction>? TransformResources { get; set; }
            /// <summary>
            /// MaxConcurrentTransforms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformjobdefinition.html#cfn-sagemaker-modelpackage-transformjobdefinition-maxconcurrenttransforms
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxConcurrentTransforms { get; set; }
            /// <summary>
            /// MaxPayloadInMB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformjobdefinition.html#cfn-sagemaker-modelpackage-transformjobdefinition-maxpayloadinmb
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxPayloadInMB { get; set; }
            /// <summary>
            /// TransformOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformjobdefinition.html#cfn-sagemaker-modelpackage-transformjobdefinition-transformoutput
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TransformOutput
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.TransformOutput, BaseFunction>? TransformOutput { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformjobdefinition.html#cfn-sagemaker-modelpackage-transformjobdefinition-environment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Environment { get; set; }
            /// <summary>
            /// TransformInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformjobdefinition.html#cfn-sagemaker-modelpackage-transformjobdefinition-transforminput
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TransformInput
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.TransformInput, BaseFunction>? TransformInput { get; set; }
            /// <summary>
            /// BatchStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformjobdefinition.html#cfn-sagemaker-modelpackage-transformjobdefinition-batchstrategy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BatchStrategy { get; set; }
        }

        public class TransformOutput : Humidifier.Base.BaseSubResource, IHaveAssembleWith, IHaveAccept, IHaveKmsKeyId, IHaveS3OutputPath
        {
            /// <summary>
            /// AssembleWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformoutput.html#cfn-sagemaker-modelpackage-transformoutput-assemblewith
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssembleWith { get; set; }
            /// <summary>
            /// Accept
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformoutput.html#cfn-sagemaker-modelpackage-transformoutput-accept
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Accept { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformoutput.html#cfn-sagemaker-modelpackage-transformoutput-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformoutput.html#cfn-sagemaker-modelpackage-transformoutput-s3outputpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3OutputPath { get; set; }
        }

        public class TransformResources : Humidifier.Base.BaseSubResource, IHaveInstanceCount_Integer, IHaveVolumeKmsKeyId, IHaveInstanceType
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformresources.html#cfn-sagemaker-modelpackage-transformresources-instancecount
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstanceCount { get; set; }
            /// <summary>
            /// VolumeKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformresources.html#cfn-sagemaker-modelpackage-transformresources-volumekmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeKmsKeyId { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformresources.html#cfn-sagemaker-modelpackage-transformresources-instancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class ValidationProfile : Humidifier.Base.BaseSubResource, IHaveProfileName, IHaveSageMakerModelPackageTypesTransformJobDefinitionTransformJobDefinition
        {
            /// <summary>
            /// ProfileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-validationprofile.html#cfn-sagemaker-modelpackage-validationprofile-profilename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProfileName { get; set; }
            /// <summary>
            /// TransformJobDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-validationprofile.html#cfn-sagemaker-modelpackage-validationprofile-transformjobdefinition
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TransformJobDefinition
            /// </summary>
            public Union<Humidifier.SageMaker.ModelPackageTypes.TransformJobDefinition, BaseFunction>? TransformJobDefinition { get; set; }
        }

        public class ValidationSpecification : Humidifier.Base.BaseSubResource, IHaveValidationRole, IHaveListOfSageMakerModelPackageTypesValidationProfileValidationProfiles
        {
            /// <summary>
            /// ValidationRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-validationspecification.html#cfn-sagemaker-modelpackage-validationspecification-validationrole
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValidationRole { get; set; }
            /// <summary>
            /// ValidationProfiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-validationspecification.html#cfn-sagemaker-modelpackage-validationspecification-validationprofiles
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ValidationProfile
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ModelPackageTypes.ValidationProfile>, IReadOnlyList<Union<Humidifier.SageMaker.ModelPackageTypes.ValidationProfile, BaseFunction>>, BaseFunction>? ValidationProfiles { get; set; }
        }
    }
}