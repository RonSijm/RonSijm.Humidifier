namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using ModelCardTypes;

    public class ModelCard : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSageMakerModelCardTypesUserContextLastModifiedBy, IHaveModelCardName, IHaveModelCardStatus, IHaveSageMakerModelCardTypesUserContextCreatedBy, IHaveSageMakerModelCardTypesSecurityConfigSecurityConfig, IHaveSageMakerModelCardTypesContentContent
    {
        public class Attributes
        {
            public static string ModelCardArn =  "ModelCardArn" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string ModelCardVersion =  "ModelCardVersion" ;
            public static string ModelCardProcessingStatus =  "ModelCardProcessingStatus" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.ModelCard; }
        /// <summary>
        /// LastModifiedBy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelcard.html#cfn-sagemaker-modelcard-lastmodifiedby
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UserContext
        /// </summary>
        public Union<Humidifier.SageMaker.ModelCardTypes.UserContext, BaseFunction>? LastModifiedBy { get; set; }
        public Union<string, BaseFunction>? ModelCardName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ModelCardStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelcard.html#cfn-sagemaker-modelcard-modelcardstatus
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ModelCardStatus { get; set; }
        /// <summary>
        /// CreatedBy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelcard.html#cfn-sagemaker-modelcard-createdby
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UserContext
        /// </summary>
        public Union<Humidifier.SageMaker.ModelCardTypes.UserContext, BaseFunction>? CreatedBy { get; set; }
        /// <summary>
        /// SecurityConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelcard.html#cfn-sagemaker-modelcard-securityconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SecurityConfig
        /// </summary>
        public Union<Humidifier.SageMaker.ModelCardTypes.SecurityConfig, BaseFunction>? SecurityConfig { get; set; }

        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelcard.html#cfn-sagemaker-modelcard-content
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Content
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.ModelCardTypes.Content, BaseFunction>? Content { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelcard.html#cfn-sagemaker-modelcard-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ModelCardTypes
    {
        public class AdditionalInformation : Humidifier.Base.BaseSubResource, IHaveEthicalConsiderations, IHaveCaveatsAndRecommendations, IHaveStringDictionaryOfCustomDetails
        {
            /// <summary>
            /// EthicalConsiderations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-additionalinformation.html#cfn-sagemaker-modelcard-additionalinformation-ethicalconsiderations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EthicalConsiderations { get; set; }
            /// <summary>
            /// CaveatsAndRecommendations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-additionalinformation.html#cfn-sagemaker-modelcard-additionalinformation-caveatsandrecommendations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CaveatsAndRecommendations { get; set; }
            /// <summary>
            /// CustomDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-additionalinformation.html#cfn-sagemaker-modelcard-additionalinformation-customdetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? CustomDetails { get; set; }
        }

        public class BusinessDetails : Humidifier.Base.BaseSubResource, IHaveBusinessStakeholders, IHaveLineOfBusiness, IHaveBusinessProblem
        {
            /// <summary>
            /// BusinessStakeholders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-businessdetails.html#cfn-sagemaker-modelcard-businessdetails-businessstakeholders
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BusinessStakeholders { get; set; }
            /// <summary>
            /// LineOfBusiness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-businessdetails.html#cfn-sagemaker-modelcard-businessdetails-lineofbusiness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LineOfBusiness { get; set; }
            /// <summary>
            /// BusinessProblem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-businessdetails.html#cfn-sagemaker-modelcard-businessdetails-businessproblem
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BusinessProblem { get; set; }
        }

        public class Container : Humidifier.Base.BaseSubResource, IHaveNearestModelName, IHaveModelDataUrl, IHaveImage
        {
            /// <summary>
            /// NearestModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-container.html#cfn-sagemaker-modelcard-container-nearestmodelname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NearestModelName { get; set; }
            /// <summary>
            /// ModelDataUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-container.html#cfn-sagemaker-modelcard-container-modeldataurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelDataUrl { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-container.html#cfn-sagemaker-modelcard-container-image
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Image { get; set; }
        }

        public class Content : Humidifier.Base.BaseSubResource, IHaveSageMakerModelCardTypesIntendedUsesIntendedUses, IHaveSageMakerModelCardTypesAdditionalInformationAdditionalInformation, IHaveSageMakerModelCardTypesModelOverviewModelOverview, IHaveSageMakerModelCardTypesTrainingDetailsTrainingDetails, IHaveListOfSageMakerModelCardTypesEvaluationDetailEvaluationDetails, IHaveSageMakerModelCardTypesModelPackageDetailsModelPackageDetails, IHaveSageMakerModelCardTypesBusinessDetailsBusinessDetails
        {
            /// <summary>
            /// IntendedUses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-content.html#cfn-sagemaker-modelcard-content-intendeduses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntendedUses
            /// </summary>
            public Union<Humidifier.SageMaker.ModelCardTypes.IntendedUses, BaseFunction>? IntendedUses { get; set; }
            /// <summary>
            /// AdditionalInformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-content.html#cfn-sagemaker-modelcard-content-additionalinformation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdditionalInformation
            /// </summary>
            public Union<Humidifier.SageMaker.ModelCardTypes.AdditionalInformation, BaseFunction>? AdditionalInformation { get; set; }
            /// <summary>
            /// ModelOverview
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-content.html#cfn-sagemaker-modelcard-content-modeloverview
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModelOverview
            /// </summary>
            public Union<Humidifier.SageMaker.ModelCardTypes.ModelOverview, BaseFunction>? ModelOverview { get; set; }
            /// <summary>
            /// TrainingDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-content.html#cfn-sagemaker-modelcard-content-trainingdetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrainingDetails
            /// </summary>
            public Union<Humidifier.SageMaker.ModelCardTypes.TrainingDetails, BaseFunction>? TrainingDetails { get; set; }
            /// <summary>
            /// EvaluationDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-content.html#cfn-sagemaker-modelcard-content-evaluationdetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationDetail
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ModelCardTypes.EvaluationDetail>, IReadOnlyList<Union<Humidifier.SageMaker.ModelCardTypes.EvaluationDetail, BaseFunction>>, BaseFunction>? EvaluationDetails { get; set; }
            /// <summary>
            /// ModelPackageDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-content.html#cfn-sagemaker-modelcard-content-modelpackagedetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModelPackageDetails
            /// </summary>
            public Union<Humidifier.SageMaker.ModelCardTypes.ModelPackageDetails, BaseFunction>? ModelPackageDetails { get; set; }
            /// <summary>
            /// BusinessDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-content.html#cfn-sagemaker-modelcard-content-businessdetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BusinessDetails
            /// </summary>
            public Union<Humidifier.SageMaker.ModelCardTypes.BusinessDetails, BaseFunction>? BusinessDetails { get; set; }
        }

        public class EvaluationDetail : Humidifier.Base.BaseSubResource, IHaveStringListOfDatasets, IHaveEvaluationObservation, IHaveListOfSageMakerModelCardTypesMetricGroupMetricGroups, IHaveStringDictionaryOfMetadata, IHaveEvaluationJobArn, IHaveName
        {
            /// <summary>
            /// Datasets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-evaluationdetail.html#cfn-sagemaker-modelcard-evaluationdetail-datasets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Datasets { get; set; }
            /// <summary>
            /// EvaluationObservation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-evaluationdetail.html#cfn-sagemaker-modelcard-evaluationdetail-evaluationobservation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EvaluationObservation { get; set; }
            /// <summary>
            /// MetricGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-evaluationdetail.html#cfn-sagemaker-modelcard-evaluationdetail-metricgroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ModelCardTypes.MetricGroup>, IReadOnlyList<Union<Humidifier.SageMaker.ModelCardTypes.MetricGroup, BaseFunction>>, BaseFunction>? MetricGroups { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-evaluationdetail.html#cfn-sagemaker-modelcard-evaluationdetail-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Metadata { get; set; }
            /// <summary>
            /// EvaluationJobArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-evaluationdetail.html#cfn-sagemaker-modelcard-evaluationdetail-evaluationjobarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EvaluationJobArn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-evaluationdetail.html#cfn-sagemaker-modelcard-evaluationdetail-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Function : Humidifier.Base.BaseSubResource, IHaveCondition, IHaveFunction_, IHaveFacet
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-function.html#cfn-sagemaker-modelcard-function-condition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// Function_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-function.html#cfn-sagemaker-modelcard-function-function
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Function_ { get; set; }
            /// <summary>
            /// Facet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-function.html#cfn-sagemaker-modelcard-function-facet
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Facet { get; set; }
        }

        public class InferenceEnvironment : Humidifier.Base.BaseSubResource, IHaveStringListOfContainerImage
        {
            /// <summary>
            /// ContainerImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-inferenceenvironment.html#cfn-sagemaker-modelcard-inferenceenvironment-containerimage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContainerImage { get; set; }
        }

        public class InferenceSpecification : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerModelCardTypesContainerContainers
        {
            /// <summary>
            /// Containers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-inferencespecification.html#cfn-sagemaker-modelcard-inferencespecification-containers
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Container
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ModelCardTypes.Container>, IReadOnlyList<Union<Humidifier.SageMaker.ModelCardTypes.Container, BaseFunction>>, BaseFunction>? Containers { get; set; }
        }

        public class IntendedUses : Humidifier.Base.BaseSubResource, IHaveIntendedUses_, IHaveFactorsAffectingModelEfficiency, IHavePurposeOfModel, IHaveRiskRating, IHaveExplanationsForRiskRating
        {
            /// <summary>
            /// IntendedUses_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-intendeduses.html#cfn-sagemaker-modelcard-intendeduses-intendeduses
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntendedUses_ { get; set; }
            /// <summary>
            /// FactorsAffectingModelEfficiency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-intendeduses.html#cfn-sagemaker-modelcard-intendeduses-factorsaffectingmodelefficiency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FactorsAffectingModelEfficiency { get; set; }
            /// <summary>
            /// PurposeOfModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-intendeduses.html#cfn-sagemaker-modelcard-intendeduses-purposeofmodel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PurposeOfModel { get; set; }
            /// <summary>
            /// RiskRating
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-intendeduses.html#cfn-sagemaker-modelcard-intendeduses-riskrating
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RiskRating { get; set; }
            /// <summary>
            /// ExplanationsForRiskRating
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-intendeduses.html#cfn-sagemaker-modelcard-intendeduses-explanationsforriskrating
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExplanationsForRiskRating { get; set; }
        }

        public class MetricDataItems : Humidifier.Base.BaseSubResource, IHaveStringListOfXAxisName, IHaveType, IHaveValue_Json, IHaveStringListOfYAxisName, IHaveNotes, IHaveName
        {
            /// <summary>
            /// XAxisName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-metricdataitems.html#cfn-sagemaker-modelcard-metricdataitems-xaxisname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? XAxisName { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-metricdataitems.html#cfn-sagemaker-modelcard-metricdataitems-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-metricdataitems.html#cfn-sagemaker-modelcard-metricdataitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Value { get; set; }
            /// <summary>
            /// YAxisName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-metricdataitems.html#cfn-sagemaker-modelcard-metricdataitems-yaxisname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? YAxisName { get; set; }
            /// <summary>
            /// Notes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-metricdataitems.html#cfn-sagemaker-modelcard-metricdataitems-notes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Notes { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-metricdataitems.html#cfn-sagemaker-modelcard-metricdataitems-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class MetricGroup : Humidifier.Base.BaseSubResource, IHaveName, IHaveListOfSageMakerModelCardTypesMetricDataItemsMetricData
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-metricgroup.html#cfn-sagemaker-modelcard-metricgroup-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// MetricData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-metricgroup.html#cfn-sagemaker-modelcard-metricgroup-metricdata
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDataItems
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ModelCardTypes.MetricDataItems>, IReadOnlyList<Union<Humidifier.SageMaker.ModelCardTypes.MetricDataItems, BaseFunction>>, BaseFunction>? MetricData { get; set; }
        }

        public class ModelOverview : Humidifier.Base.BaseSubResource, IHaveModelOwner, IHaveStringListOfModelArtifact, IHaveAlgorithmType, IHaveModelName, IHaveSageMakerModelCardTypesInferenceEnvironmentInferenceEnvironment, IHaveProblemType, IHaveModelDescription, IHaveModelVersion_Double, IHaveModelCreator, IHaveModelId
        {
            /// <summary>
            /// ModelOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modeloverview.html#cfn-sagemaker-modelcard-modeloverview-modelowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelOwner { get; set; }
            /// <summary>
            /// ModelArtifact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modeloverview.html#cfn-sagemaker-modelcard-modeloverview-modelartifact
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ModelArtifact { get; set; }
            /// <summary>
            /// AlgorithmType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modeloverview.html#cfn-sagemaker-modelcard-modeloverview-algorithmtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlgorithmType { get; set; }
            /// <summary>
            /// ModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modeloverview.html#cfn-sagemaker-modelcard-modeloverview-modelname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelName { get; set; }
            /// <summary>
            /// InferenceEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modeloverview.html#cfn-sagemaker-modelcard-modeloverview-inferenceenvironment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceEnvironment
            /// </summary>
            public Union<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment, BaseFunction>? InferenceEnvironment { get; set; }
            /// <summary>
            /// ProblemType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modeloverview.html#cfn-sagemaker-modelcard-modeloverview-problemtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProblemType { get; set; }
            /// <summary>
            /// ModelDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modeloverview.html#cfn-sagemaker-modelcard-modeloverview-modeldescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelDescription { get; set; }
            /// <summary>
            /// ModelVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modeloverview.html#cfn-sagemaker-modelcard-modeloverview-modelversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ModelVersion { get; set; }
            /// <summary>
            /// ModelCreator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modeloverview.html#cfn-sagemaker-modelcard-modeloverview-modelcreator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelCreator { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modeloverview.html#cfn-sagemaker-modelcard-modeloverview-modelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class ModelPackageCreator : Humidifier.Base.BaseSubResource, IHaveUserProfileName
        {
            /// <summary>
            /// UserProfileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modelpackagecreator.html#cfn-sagemaker-modelcard-modelpackagecreator-userprofilename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserProfileName { get; set; }
        }

        public class ModelPackageDetails : Humidifier.Base.BaseSubResource, IHaveModelPackageGroupName, IHaveTask, IHaveSageMakerModelCardTypesModelPackageCreatorCreatedBy, IHaveApprovalDescription, IHaveModelApprovalStatus, IHaveModelPackageVersion_Double, IHaveModelPackageDescription, IHaveModelPackageName, IHaveModelPackageStatus, IHaveListOfSageMakerModelCardTypesSourceAlgorithmSourceAlgorithms, IHaveSageMakerModelCardTypesInferenceSpecificationInferenceSpecification, IHaveModelPackageArn, IHaveDomain
        {
            /// <summary>
            /// ModelPackageGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modelpackagedetails.html#cfn-sagemaker-modelcard-modelpackagedetails-modelpackagegroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelPackageGroupName { get; set; }
            /// <summary>
            /// Task
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modelpackagedetails.html#cfn-sagemaker-modelcard-modelpackagedetails-task
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Task { get; set; }
            /// <summary>
            /// CreatedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modelpackagedetails.html#cfn-sagemaker-modelcard-modelpackagedetails-createdby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModelPackageCreator
            /// </summary>
            public Union<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator, BaseFunction>? CreatedBy { get; set; }
            /// <summary>
            /// ApprovalDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modelpackagedetails.html#cfn-sagemaker-modelcard-modelpackagedetails-approvaldescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApprovalDescription { get; set; }
            /// <summary>
            /// ModelApprovalStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modelpackagedetails.html#cfn-sagemaker-modelcard-modelpackagedetails-modelapprovalstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelApprovalStatus { get; set; }
            /// <summary>
            /// ModelPackageVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modelpackagedetails.html#cfn-sagemaker-modelcard-modelpackagedetails-modelpackageversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ModelPackageVersion { get; set; }
            /// <summary>
            /// ModelPackageDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modelpackagedetails.html#cfn-sagemaker-modelcard-modelpackagedetails-modelpackagedescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelPackageDescription { get; set; }
            /// <summary>
            /// ModelPackageName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modelpackagedetails.html#cfn-sagemaker-modelcard-modelpackagedetails-modelpackagename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelPackageName { get; set; }
            /// <summary>
            /// ModelPackageStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modelpackagedetails.html#cfn-sagemaker-modelcard-modelpackagedetails-modelpackagestatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelPackageStatus { get; set; }
            /// <summary>
            /// SourceAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modelpackagedetails.html#cfn-sagemaker-modelcard-modelpackagedetails-sourcealgorithms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SourceAlgorithm
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ModelCardTypes.SourceAlgorithm>, IReadOnlyList<Union<Humidifier.SageMaker.ModelCardTypes.SourceAlgorithm, BaseFunction>>, BaseFunction>? SourceAlgorithms { get; set; }
            /// <summary>
            /// InferenceSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modelpackagedetails.html#cfn-sagemaker-modelcard-modelpackagedetails-inferencespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceSpecification
            /// </summary>
            public Union<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification, BaseFunction>? InferenceSpecification { get; set; }
            /// <summary>
            /// ModelPackageArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modelpackagedetails.html#cfn-sagemaker-modelcard-modelpackagedetails-modelpackagearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelPackageArn { get; set; }
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-modelpackagedetails.html#cfn-sagemaker-modelcard-modelpackagedetails-domain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Domain { get; set; }
        }

        public class ObjectiveFunction : Humidifier.Base.BaseSubResource, IHaveSageMakerModelCardTypesFunctionFunction, IHaveNotes
        {
            /// <summary>
            /// Function
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-objectivefunction.html#cfn-sagemaker-modelcard-objectivefunction-function
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Function
            /// </summary>
            public Union<Humidifier.SageMaker.ModelCardTypes.Function, BaseFunction>? Function { get; set; }
            /// <summary>
            /// Notes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-objectivefunction.html#cfn-sagemaker-modelcard-objectivefunction-notes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Notes { get; set; }
        }

        public class SecurityConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-securityconfig.html#cfn-sagemaker-modelcard-securityconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
        }

        public class SourceAlgorithm : Humidifier.Base.BaseSubResource, IHaveModelDataUrl, IHaveAlgorithmName
        {
            /// <summary>
            /// ModelDataUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-sourcealgorithm.html#cfn-sagemaker-modelcard-sourcealgorithm-modeldataurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelDataUrl { get; set; }
            /// <summary>
            /// AlgorithmName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-sourcealgorithm.html#cfn-sagemaker-modelcard-sourcealgorithm-algorithmname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlgorithmName { get; set; }
        }

        public class TrainingDetails : Humidifier.Base.BaseSubResource, IHaveSageMakerModelCardTypesObjectiveFunctionObjectiveFunction, IHaveTrainingObservations, IHaveSageMakerModelCardTypesTrainingJobDetailsTrainingJobDetails
        {
            /// <summary>
            /// ObjectiveFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-trainingdetails.html#cfn-sagemaker-modelcard-trainingdetails-objectivefunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ObjectiveFunction
            /// </summary>
            public Union<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction, BaseFunction>? ObjectiveFunction { get; set; }
            /// <summary>
            /// TrainingObservations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-trainingdetails.html#cfn-sagemaker-modelcard-trainingdetails-trainingobservations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrainingObservations { get; set; }
            /// <summary>
            /// TrainingJobDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-trainingdetails.html#cfn-sagemaker-modelcard-trainingdetails-trainingjobdetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrainingJobDetails
            /// </summary>
            public Union<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails, BaseFunction>? TrainingJobDetails { get; set; }
        }

        public class TrainingEnvironment : Humidifier.Base.BaseSubResource, IHaveStringListOfContainerImage
        {
            /// <summary>
            /// ContainerImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-trainingenvironment.html#cfn-sagemaker-modelcard-trainingenvironment-containerimage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContainerImage { get; set; }
        }

        public class TrainingHyperParameter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-traininghyperparameter.html#cfn-sagemaker-modelcard-traininghyperparameter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-traininghyperparameter.html#cfn-sagemaker-modelcard-traininghyperparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class TrainingJobDetails : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerModelCardTypesTrainingMetricTrainingMetrics, IHaveListOfSageMakerModelCardTypesTrainingHyperParameterHyperParameters, IHaveTrainingArn, IHaveListOfSageMakerModelCardTypesTrainingMetricUserProvidedTrainingMetrics, IHaveSageMakerModelCardTypesTrainingEnvironmentTrainingEnvironment, IHaveStringListOfTrainingDatasets, IHaveListOfSageMakerModelCardTypesTrainingHyperParameterUserProvidedHyperParameters
        {
            /// <summary>
            /// TrainingMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-trainingjobdetails.html#cfn-sagemaker-modelcard-trainingjobdetails-trainingmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TrainingMetric
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ModelCardTypes.TrainingMetric>, IReadOnlyList<Union<Humidifier.SageMaker.ModelCardTypes.TrainingMetric, BaseFunction>>, BaseFunction>? TrainingMetrics { get; set; }
            /// <summary>
            /// HyperParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-trainingjobdetails.html#cfn-sagemaker-modelcard-trainingjobdetails-hyperparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TrainingHyperParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ModelCardTypes.TrainingHyperParameter>, IReadOnlyList<Union<Humidifier.SageMaker.ModelCardTypes.TrainingHyperParameter, BaseFunction>>, BaseFunction>? HyperParameters { get; set; }
            /// <summary>
            /// TrainingArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-trainingjobdetails.html#cfn-sagemaker-modelcard-trainingjobdetails-trainingarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrainingArn { get; set; }
            /// <summary>
            /// UserProvidedTrainingMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-trainingjobdetails.html#cfn-sagemaker-modelcard-trainingjobdetails-userprovidedtrainingmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TrainingMetric
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ModelCardTypes.TrainingMetric>, IReadOnlyList<Union<Humidifier.SageMaker.ModelCardTypes.TrainingMetric, BaseFunction>>, BaseFunction>? UserProvidedTrainingMetrics { get; set; }
            /// <summary>
            /// TrainingEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-trainingjobdetails.html#cfn-sagemaker-modelcard-trainingjobdetails-trainingenvironment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrainingEnvironment
            /// </summary>
            public Union<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment, BaseFunction>? TrainingEnvironment { get; set; }
            /// <summary>
            /// TrainingDatasets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-trainingjobdetails.html#cfn-sagemaker-modelcard-trainingjobdetails-trainingdatasets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TrainingDatasets { get; set; }
            /// <summary>
            /// UserProvidedHyperParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-trainingjobdetails.html#cfn-sagemaker-modelcard-trainingjobdetails-userprovidedhyperparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TrainingHyperParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ModelCardTypes.TrainingHyperParameter>, IReadOnlyList<Union<Humidifier.SageMaker.ModelCardTypes.TrainingHyperParameter, BaseFunction>>, BaseFunction>? UserProvidedHyperParameters { get; set; }
        }

        public class TrainingMetric : Humidifier.Base.BaseSubResource, IHaveValue_Double, IHaveNotes, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-trainingmetric.html#cfn-sagemaker-modelcard-trainingmetric-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Notes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-trainingmetric.html#cfn-sagemaker-modelcard-trainingmetric-notes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Notes { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-trainingmetric.html#cfn-sagemaker-modelcard-trainingmetric-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class UserContext : Humidifier.Base.BaseSubResource, IHaveUserProfileArn, IHaveUserProfileName, IHaveDomainId
        {
            /// <summary>
            /// UserProfileArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-usercontext.html#cfn-sagemaker-modelcard-usercontext-userprofilearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserProfileArn { get; set; }
            /// <summary>
            /// UserProfileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-usercontext.html#cfn-sagemaker-modelcard-usercontext-userprofilename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserProfileName { get; set; }
            /// <summary>
            /// DomainId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcard-usercontext.html#cfn-sagemaker-modelcard-usercontext-domainid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainId { get; set; }
        }
    }
}