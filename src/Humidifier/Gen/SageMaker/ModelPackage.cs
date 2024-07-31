namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using ModelPackageTypes;

    public class ModelPackage : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string ModelPackageStatus =  "ModelPackageStatus" ;
            public static string CreationTime =  "CreationTime" ;
            public static string ModelPackageArn =  "ModelPackageArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SageMaker::ModelPackage";
            }
        }

        /// <summary>
        /// DriftCheckBaselines
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-driftcheckbaselines
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DriftCheckBaselines
        /// </summary>
        public ModelPackageTypes.DriftCheckBaselines DriftCheckBaselines { get; set; }
        /// <summary>
        /// ModelPackageGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-modelpackagegroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ModelPackageGroupName { get; set; }
        /// <summary>
        /// ModelMetrics
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-modelmetrics
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ModelMetrics
        /// </summary>
        public ModelPackageTypes.ModelMetrics ModelMetrics { get; set; }
        /// <summary>
        /// Task
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-task
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Task { get; set; }
        /// <summary>
        /// CustomerMetadataProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-customermetadataproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> CustomerMetadataProperties { get; set; }
        /// <summary>
        /// ApprovalDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-approvaldescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApprovalDescription { get; set; }
        /// <summary>
        /// ModelApprovalStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-modelapprovalstatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ModelApprovalStatus { get; set; }
        /// <summary>
        /// ModelPackageVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-modelpackageversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ModelPackageVersion { get; set; }
        /// <summary>
        /// MetadataProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-metadataproperties
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MetadataProperties
        /// </summary>
        public ModelPackageTypes.MetadataProperties MetadataProperties { get; set; }
        /// <summary>
        /// ValidationSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-validationspecification
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ValidationSpecification
        /// </summary>
        public ModelPackageTypes.ValidationSpecification ValidationSpecification { get; set; }
        /// <summary>
        /// SourceAlgorithmSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-sourcealgorithmspecification
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SourceAlgorithmSpecification
        /// </summary>
        public ModelPackageTypes.SourceAlgorithmSpecification SourceAlgorithmSpecification { get; set; }
        /// <summary>
        /// ModelPackageStatusDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-modelpackagestatusdetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ModelPackageStatusDetails
        /// </summary>
        public ModelPackageTypes.ModelPackageStatusDetails ModelPackageStatusDetails { get; set; }
        /// <summary>
        /// SkipModelValidation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-skipmodelvalidation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SkipModelValidation { get; set; }
        /// <summary>
        /// ModelPackageDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-modelpackagedescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ModelPackageDescription { get; set; }

        [Ignore]
        public dynamic Description { get => ModelPackageDescription; set => ModelPackageDescription = value; }
        /// <summary>
        /// AdditionalInferenceSpecificationsToAdd
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-additionalinferencespecificationstoadd
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AdditionalInferenceSpecificationDefinition
        /// </summary>
        public List<ModelPackageTypes.AdditionalInferenceSpecificationDefinition> AdditionalInferenceSpecificationsToAdd { get; set; }
        public dynamic ModelPackageName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// InferenceSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-inferencespecification
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InferenceSpecification
        /// </summary>
        public ModelPackageTypes.InferenceSpecification InferenceSpecification { get; set; }
        /// <summary>
        /// SamplePayloadUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-samplepayloadurl
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SamplePayloadUrl { get; set; }
        /// <summary>
        /// LastModifiedTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-lastmodifiedtime
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LastModifiedTime { get; set; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-clienttoken
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClientToken { get; set; }
        /// <summary>
        /// Domain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-domain
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Domain { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// CertifyForMarketplace
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-certifyformarketplace
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic CertifyForMarketplace { get; set; }
        /// <summary>
        /// AdditionalInferenceSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackage.html#cfn-sagemaker-modelpackage-additionalinferencespecifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AdditionalInferenceSpecificationDefinition
        /// </summary>
        public List<ModelPackageTypes.AdditionalInferenceSpecificationDefinition> AdditionalInferenceSpecifications { get; set; }
    }

    namespace ModelPackageTypes
    {
        public class AdditionalInferenceSpecificationDefinition : Humidifier.Base.BaseSubResource, IHaveDescription
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-additionalinferencespecificationdefinition.html#cfn-sagemaker-modelpackage-additionalinferencespecificationdefinition-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// SupportedContentTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-additionalinferencespecificationdefinition.html#cfn-sagemaker-modelpackage-additionalinferencespecificationdefinition-supportedcontenttypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupportedContentTypes { get; set; }
            /// <summary>
            /// SupportedRealtimeInferenceInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-additionalinferencespecificationdefinition.html#cfn-sagemaker-modelpackage-additionalinferencespecificationdefinition-supportedrealtimeinferenceinstancetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupportedRealtimeInferenceInstanceTypes { get; set; }
            /// <summary>
            /// Containers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-additionalinferencespecificationdefinition.html#cfn-sagemaker-modelpackage-additionalinferencespecificationdefinition-containers
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ModelPackageContainerDefinition
            /// </summary>
            public List<ModelPackageTypes.ModelPackageContainerDefinition> Containers { get; set; }
            /// <summary>
            /// SupportedTransformInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-additionalinferencespecificationdefinition.html#cfn-sagemaker-modelpackage-additionalinferencespecificationdefinition-supportedtransforminstancetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupportedTransformInstanceTypes { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-additionalinferencespecificationdefinition.html#cfn-sagemaker-modelpackage-additionalinferencespecificationdefinition-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// SupportedResponseMIMETypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-additionalinferencespecificationdefinition.html#cfn-sagemaker-modelpackage-additionalinferencespecificationdefinition-supportedresponsemimetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupportedResponseMIMETypes { get; set; }
        }

        public class Bias : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Report
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-bias.html#cfn-sagemaker-modelpackage-bias-report
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public ModelPackageTypes.MetricsSource Report { get; set; }
            /// <summary>
            /// PreTrainingReport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-bias.html#cfn-sagemaker-modelpackage-bias-pretrainingreport
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public ModelPackageTypes.MetricsSource PreTrainingReport { get; set; }
            /// <summary>
            /// PostTrainingReport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-bias.html#cfn-sagemaker-modelpackage-bias-posttrainingreport
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public ModelPackageTypes.MetricsSource PostTrainingReport { get; set; }
        }

        public class DataSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-datasource.html#cfn-sagemaker-modelpackage-datasource-s3datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataSource
            /// </summary>
            public ModelPackageTypes.S3DataSource S3DataSource { get; set; }
        }

        public class DriftCheckBaselines : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ModelDataQuality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckbaselines.html#cfn-sagemaker-modelpackage-driftcheckbaselines-modeldataquality
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DriftCheckModelDataQuality
            /// </summary>
            public ModelPackageTypes.DriftCheckModelDataQuality ModelDataQuality { get; set; }
            /// <summary>
            /// Bias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckbaselines.html#cfn-sagemaker-modelpackage-driftcheckbaselines-bias
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DriftCheckBias
            /// </summary>
            public ModelPackageTypes.DriftCheckBias Bias { get; set; }
            /// <summary>
            /// ModelQuality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckbaselines.html#cfn-sagemaker-modelpackage-driftcheckbaselines-modelquality
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DriftCheckModelQuality
            /// </summary>
            public ModelPackageTypes.DriftCheckModelQuality ModelQuality { get; set; }
            /// <summary>
            /// Explainability
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckbaselines.html#cfn-sagemaker-modelpackage-driftcheckbaselines-explainability
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DriftCheckExplainability
            /// </summary>
            public ModelPackageTypes.DriftCheckExplainability Explainability { get; set; }
        }

        public class DriftCheckBias : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PreTrainingConstraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckbias.html#cfn-sagemaker-modelpackage-driftcheckbias-pretrainingconstraints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public ModelPackageTypes.MetricsSource PreTrainingConstraints { get; set; }
            /// <summary>
            /// ConfigFile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckbias.html#cfn-sagemaker-modelpackage-driftcheckbias-configfile
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FileSource
            /// </summary>
            public ModelPackageTypes.FileSource ConfigFile { get; set; }
            /// <summary>
            /// PostTrainingConstraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckbias.html#cfn-sagemaker-modelpackage-driftcheckbias-posttrainingconstraints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public ModelPackageTypes.MetricsSource PostTrainingConstraints { get; set; }
        }

        public class DriftCheckExplainability : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Constraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckexplainability.html#cfn-sagemaker-modelpackage-driftcheckexplainability-constraints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public ModelPackageTypes.MetricsSource Constraints { get; set; }
            /// <summary>
            /// ConfigFile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckexplainability.html#cfn-sagemaker-modelpackage-driftcheckexplainability-configfile
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FileSource
            /// </summary>
            public ModelPackageTypes.FileSource ConfigFile { get; set; }
        }

        public class DriftCheckModelDataQuality : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Constraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckmodeldataquality.html#cfn-sagemaker-modelpackage-driftcheckmodeldataquality-constraints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public ModelPackageTypes.MetricsSource Constraints { get; set; }
            /// <summary>
            /// Statistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckmodeldataquality.html#cfn-sagemaker-modelpackage-driftcheckmodeldataquality-statistics
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public ModelPackageTypes.MetricsSource Statistics { get; set; }
        }

        public class DriftCheckModelQuality : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Constraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckmodelquality.html#cfn-sagemaker-modelpackage-driftcheckmodelquality-constraints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public ModelPackageTypes.MetricsSource Constraints { get; set; }
            /// <summary>
            /// Statistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-driftcheckmodelquality.html#cfn-sagemaker-modelpackage-driftcheckmodelquality-statistics
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public ModelPackageTypes.MetricsSource Statistics { get; set; }
        }

        public class Explainability : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Report
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-explainability.html#cfn-sagemaker-modelpackage-explainability-report
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public ModelPackageTypes.MetricsSource Report { get; set; }
        }

        public class FileSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-filesource.html#cfn-sagemaker-modelpackage-filesource-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-filesource.html#cfn-sagemaker-modelpackage-filesource-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
            /// <summary>
            /// ContentDigest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-filesource.html#cfn-sagemaker-modelpackage-filesource-contentdigest
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentDigest { get; set; }
        }

        public class InferenceSpecification : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SupportedContentTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-inferencespecification.html#cfn-sagemaker-modelpackage-inferencespecification-supportedcontenttypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupportedContentTypes { get; set; }
            /// <summary>
            /// SupportedRealtimeInferenceInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-inferencespecification.html#cfn-sagemaker-modelpackage-inferencespecification-supportedrealtimeinferenceinstancetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupportedRealtimeInferenceInstanceTypes { get; set; }
            /// <summary>
            /// Containers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-inferencespecification.html#cfn-sagemaker-modelpackage-inferencespecification-containers
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ModelPackageContainerDefinition
            /// </summary>
            public List<ModelPackageTypes.ModelPackageContainerDefinition> Containers { get; set; }
            /// <summary>
            /// SupportedTransformInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-inferencespecification.html#cfn-sagemaker-modelpackage-inferencespecification-supportedtransforminstancetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupportedTransformInstanceTypes { get; set; }
            /// <summary>
            /// SupportedResponseMIMETypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-inferencespecification.html#cfn-sagemaker-modelpackage-inferencespecification-supportedresponsemimetypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupportedResponseMIMETypes { get; set; }
        }

        public class MetadataProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GeneratedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-metadataproperties.html#cfn-sagemaker-modelpackage-metadataproperties-generatedby
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GeneratedBy { get; set; }
            /// <summary>
            /// Repository
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-metadataproperties.html#cfn-sagemaker-modelpackage-metadataproperties-repository
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Repository { get; set; }
            /// <summary>
            /// CommitId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-metadataproperties.html#cfn-sagemaker-modelpackage-metadataproperties-commitid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitId { get; set; }
            /// <summary>
            /// ProjectId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-metadataproperties.html#cfn-sagemaker-modelpackage-metadataproperties-projectid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProjectId { get; set; }
        }

        public class MetricsSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-metricssource.html#cfn-sagemaker-modelpackage-metricssource-contenttype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-metricssource.html#cfn-sagemaker-modelpackage-metricssource-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
            /// <summary>
            /// ContentDigest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-metricssource.html#cfn-sagemaker-modelpackage-metricssource-contentdigest
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentDigest { get; set; }
        }

        public class ModelDataQuality : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Constraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modeldataquality.html#cfn-sagemaker-modelpackage-modeldataquality-constraints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public ModelPackageTypes.MetricsSource Constraints { get; set; }
            /// <summary>
            /// Statistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modeldataquality.html#cfn-sagemaker-modelpackage-modeldataquality-statistics
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public ModelPackageTypes.MetricsSource Statistics { get; set; }
        }

        public class ModelInput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DataInputConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelinput.html#cfn-sagemaker-modelpackage-modelinput-datainputconfig
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataInputConfig { get; set; }
        }

        public class ModelMetrics : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ModelDataQuality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelmetrics.html#cfn-sagemaker-modelpackage-modelmetrics-modeldataquality
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelDataQuality
            /// </summary>
            public ModelPackageTypes.ModelDataQuality ModelDataQuality { get; set; }
            /// <summary>
            /// Bias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelmetrics.html#cfn-sagemaker-modelpackage-modelmetrics-bias
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Bias
            /// </summary>
            public ModelPackageTypes.Bias Bias { get; set; }
            /// <summary>
            /// ModelQuality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelmetrics.html#cfn-sagemaker-modelpackage-modelmetrics-modelquality
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelQuality
            /// </summary>
            public ModelPackageTypes.ModelQuality ModelQuality { get; set; }
            /// <summary>
            /// Explainability
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelmetrics.html#cfn-sagemaker-modelpackage-modelmetrics-explainability
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Explainability
            /// </summary>
            public ModelPackageTypes.Explainability Explainability { get; set; }
        }

        public class ModelPackageContainerDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ModelInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-modelinput
            /// Required: False
            /// UpdateType: Conditional
            /// Type: ModelInput
            /// </summary>
            public ModelPackageTypes.ModelInput ModelInput { get; set; }
            /// <summary>
            /// NearestModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-nearestmodelname
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic NearestModelName { get; set; }
            /// <summary>
            /// ContainerHostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-containerhostname
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerHostname { get; set; }
            /// <summary>
            /// ImageDigest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-imagedigest
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageDigest { get; set; }
            /// <summary>
            /// FrameworkVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-frameworkversion
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic FrameworkVersion { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-environment
            /// Required: False
            /// UpdateType: Conditional
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Environment { get; set; }
            /// <summary>
            /// ModelDataUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-modeldataurl
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelDataUrl { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-image
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image { get; set; }
            /// <summary>
            /// Framework
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagecontainerdefinition.html#cfn-sagemaker-modelpackage-modelpackagecontainerdefinition-framework
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic Framework { get; set; }
        }

        public class ModelPackageStatusDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ValidationStatuses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagestatusdetails.html#cfn-sagemaker-modelpackage-modelpackagestatusdetails-validationstatuses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ModelPackageStatusItem
            /// </summary>
            public List<ModelPackageTypes.ModelPackageStatusItem> ValidationStatuses { get; set; }
        }

        public class ModelPackageStatusItem : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagestatusitem.html#cfn-sagemaker-modelpackage-modelpackagestatusitem-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// FailureReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagestatusitem.html#cfn-sagemaker-modelpackage-modelpackagestatusitem-failurereason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FailureReason { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelpackagestatusitem.html#cfn-sagemaker-modelpackage-modelpackagestatusitem-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ModelQuality : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Constraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelquality.html#cfn-sagemaker-modelpackage-modelquality-constraints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public ModelPackageTypes.MetricsSource Constraints { get; set; }
            /// <summary>
            /// Statistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-modelquality.html#cfn-sagemaker-modelpackage-modelquality-statistics
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsSource
            /// </summary>
            public ModelPackageTypes.MetricsSource Statistics { get; set; }
        }

        public class S3DataSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-s3datasource.html#cfn-sagemaker-modelpackage-s3datasource-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
            /// <summary>
            /// S3DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-s3datasource.html#cfn-sagemaker-modelpackage-s3datasource-s3datatype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3DataType { get; set; }
        }

        public class SourceAlgorithm : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ModelDataUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-sourcealgorithm.html#cfn-sagemaker-modelpackage-sourcealgorithm-modeldataurl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelDataUrl { get; set; }
            /// <summary>
            /// AlgorithmName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-sourcealgorithm.html#cfn-sagemaker-modelpackage-sourcealgorithm-algorithmname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlgorithmName { get; set; }
        }

        public class SourceAlgorithmSpecification : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-sourcealgorithmspecification.html#cfn-sagemaker-modelpackage-sourcealgorithmspecification-sourcealgorithms
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SourceAlgorithm
            /// </summary>
            public List<ModelPackageTypes.SourceAlgorithm> SourceAlgorithms { get; set; }
        }

        public class TransformInput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transforminput.html#cfn-sagemaker-modelpackage-transforminput-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// SplitType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transforminput.html#cfn-sagemaker-modelpackage-transforminput-splittype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SplitType { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transforminput.html#cfn-sagemaker-modelpackage-transforminput-compressiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CompressionType { get; set; }
            /// <summary>
            /// DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transforminput.html#cfn-sagemaker-modelpackage-transforminput-datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DataSource
            /// </summary>
            public ModelPackageTypes.DataSource DataSource { get; set; }
        }

        public class TransformJobDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TransformResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformjobdefinition.html#cfn-sagemaker-modelpackage-transformjobdefinition-transformresources
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TransformResources
            /// </summary>
            public ModelPackageTypes.TransformResources TransformResources { get; set; }
            /// <summary>
            /// MaxConcurrentTransforms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformjobdefinition.html#cfn-sagemaker-modelpackage-transformjobdefinition-maxconcurrenttransforms
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxConcurrentTransforms { get; set; }
            /// <summary>
            /// MaxPayloadInMB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformjobdefinition.html#cfn-sagemaker-modelpackage-transformjobdefinition-maxpayloadinmb
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxPayloadInMB { get; set; }
            /// <summary>
            /// TransformOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformjobdefinition.html#cfn-sagemaker-modelpackage-transformjobdefinition-transformoutput
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TransformOutput
            /// </summary>
            public ModelPackageTypes.TransformOutput TransformOutput { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformjobdefinition.html#cfn-sagemaker-modelpackage-transformjobdefinition-environment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Environment { get; set; }
            /// <summary>
            /// TransformInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformjobdefinition.html#cfn-sagemaker-modelpackage-transformjobdefinition-transforminput
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TransformInput
            /// </summary>
            public ModelPackageTypes.TransformInput TransformInput { get; set; }
            /// <summary>
            /// BatchStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformjobdefinition.html#cfn-sagemaker-modelpackage-transformjobdefinition-batchstrategy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BatchStrategy { get; set; }
        }

        public class TransformOutput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AssembleWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformoutput.html#cfn-sagemaker-modelpackage-transformoutput-assemblewith
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AssembleWith { get; set; }
            /// <summary>
            /// Accept
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformoutput.html#cfn-sagemaker-modelpackage-transformoutput-accept
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Accept { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformoutput.html#cfn-sagemaker-modelpackage-transformoutput-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformoutput.html#cfn-sagemaker-modelpackage-transformoutput-s3outputpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3OutputPath { get; set; }
        }

        public class TransformResources : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformresources.html#cfn-sagemaker-modelpackage-transformresources-instancecount
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InstanceCount { get; set; }
            /// <summary>
            /// VolumeKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformresources.html#cfn-sagemaker-modelpackage-transformresources-volumekmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeKmsKeyId { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-transformresources.html#cfn-sagemaker-modelpackage-transformresources-instancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
        }

        public class ValidationProfile : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProfileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-validationprofile.html#cfn-sagemaker-modelpackage-validationprofile-profilename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProfileName { get; set; }
            /// <summary>
            /// TransformJobDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-validationprofile.html#cfn-sagemaker-modelpackage-validationprofile-transformjobdefinition
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TransformJobDefinition
            /// </summary>
            public ModelPackageTypes.TransformJobDefinition TransformJobDefinition { get; set; }
        }

        public class ValidationSpecification : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ValidationRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-validationspecification.html#cfn-sagemaker-modelpackage-validationspecification-validationrole
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValidationRole { get; set; }
            /// <summary>
            /// ValidationProfiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelpackage-validationspecification.html#cfn-sagemaker-modelpackage-validationspecification-validationprofiles
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ValidationProfile
            /// </summary>
            public List<ModelPackageTypes.ValidationProfile> ValidationProfiles { get; set; }
        }
    }
}