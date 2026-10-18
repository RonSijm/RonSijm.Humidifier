namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using InferenceExperimentTypes;

    public class InferenceExperiment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSageMakerInferenceExperimentTypesDataStorageConfigDataStorageConfig, IHaveDescription, IHaveStatusReason, IHaveListOfSageMakerInferenceExperimentTypesModelVariantConfigModelVariants, IHaveSageMakerInferenceExperimentTypesShadowModeConfigShadowModeConfig, IHaveRoleArn, IHaveName, IHaveType, IHaveEndpointName, IHaveDesiredState, IHaveSageMakerInferenceExperimentTypesInferenceExperimentScheduleSchedule, IHaveKmsKey
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Arn =  "Arn" ;
            public static string EndpointMetadata =  "EndpointMetadata" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.InferenceExperiment; }
        /// <summary>
        /// DataStorageConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferenceexperiment.html#cfn-sagemaker-inferenceexperiment-datastorageconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataStorageConfig
        /// </summary>
        public Union<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig, BaseFunction>? DataStorageConfig { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferenceexperiment.html#cfn-sagemaker-inferenceexperiment-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// StatusReason
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferenceexperiment.html#cfn-sagemaker-inferenceexperiment-statusreason
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StatusReason { get; set; }

        /// <summary>
        /// ModelVariants
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferenceexperiment.html#cfn-sagemaker-inferenceexperiment-modelvariants
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ModelVariantConfig
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig>, IReadOnlyList<Union<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig, BaseFunction>>, BaseFunction>? ModelVariants { get; set; }
        /// <summary>
        /// ShadowModeConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferenceexperiment.html#cfn-sagemaker-inferenceexperiment-shadowmodeconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ShadowModeConfig
        /// </summary>
        public Union<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig, BaseFunction>? ShadowModeConfig { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferenceexperiment.html#cfn-sagemaker-inferenceexperiment-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferenceexperiment.html#cfn-sagemaker-inferenceexperiment-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }

        /// <summary>
        /// EndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferenceexperiment.html#cfn-sagemaker-inferenceexperiment-endpointname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EndpointName { get; set; }
        /// <summary>
        /// DesiredState
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferenceexperiment.html#cfn-sagemaker-inferenceexperiment-desiredstate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DesiredState { get; set; }
        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferenceexperiment.html#cfn-sagemaker-inferenceexperiment-schedule
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InferenceExperimentSchedule
        /// </summary>
        public Union<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule, BaseFunction>? Schedule { get; set; }
        /// <summary>
        /// KmsKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferenceexperiment.html#cfn-sagemaker-inferenceexperiment-kmskey
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKey { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferenceexperiment.html#cfn-sagemaker-inferenceexperiment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace InferenceExperimentTypes
    {
        public class CaptureContentTypeHeader : Humidifier.Base.BaseSubResource, IHaveStringListOfJsonContentTypes, IHaveStringListOfCsvContentTypes
        {
            /// <summary>
            /// JsonContentTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-capturecontenttypeheader.html#cfn-sagemaker-inferenceexperiment-capturecontenttypeheader-jsoncontenttypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? JsonContentTypes { get; set; }
            /// <summary>
            /// CsvContentTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-capturecontenttypeheader.html#cfn-sagemaker-inferenceexperiment-capturecontenttypeheader-csvcontenttypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CsvContentTypes { get; set; }
        }

        public class DataStorageConfig : Humidifier.Base.BaseSubResource, IHaveDestination, IHaveSageMakerInferenceExperimentTypesCaptureContentTypeHeaderContentType, IHaveKmsKey
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-datastorageconfig.html#cfn-sagemaker-inferenceexperiment-datastorageconfig-destination
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-datastorageconfig.html#cfn-sagemaker-inferenceexperiment-datastorageconfig-contenttype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaptureContentTypeHeader
            /// </summary>
            public Union<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// KmsKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-datastorageconfig.html#cfn-sagemaker-inferenceexperiment-datastorageconfig-kmskey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKey { get; set; }
        }

        public class EndpointMetadata : Humidifier.Base.BaseSubResource, IHaveEndpointStatus, IHaveEndpointName, IHaveEndpointConfigName
        {
            /// <summary>
            /// EndpointStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-endpointmetadata.html#cfn-sagemaker-inferenceexperiment-endpointmetadata-endpointstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointStatus { get; set; }
            /// <summary>
            /// EndpointName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-endpointmetadata.html#cfn-sagemaker-inferenceexperiment-endpointmetadata-endpointname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointName { get; set; }
            /// <summary>
            /// EndpointConfigName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-endpointmetadata.html#cfn-sagemaker-inferenceexperiment-endpointmetadata-endpointconfigname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointConfigName { get; set; }
        }

        public class InferenceExperimentSchedule : Humidifier.Base.BaseSubResource, IHaveEndTime, IHaveStartTime
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-inferenceexperimentschedule.html#cfn-sagemaker-inferenceexperiment-inferenceexperimentschedule-endtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-inferenceexperimentschedule.html#cfn-sagemaker-inferenceexperiment-inferenceexperimentschedule-starttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
        }

        public class ModelInfrastructureConfig : Humidifier.Base.BaseSubResource, IHaveInfrastructureType, IHaveSageMakerInferenceExperimentTypesRealTimeInferenceConfigRealTimeInferenceConfig
        {
            /// <summary>
            /// InfrastructureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-modelinfrastructureconfig.html#cfn-sagemaker-inferenceexperiment-modelinfrastructureconfig-infrastructuretype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InfrastructureType { get; set; }
            /// <summary>
            /// RealTimeInferenceConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-modelinfrastructureconfig.html#cfn-sagemaker-inferenceexperiment-modelinfrastructureconfig-realtimeinferenceconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RealTimeInferenceConfig
            /// </summary>
            public Union<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig, BaseFunction>? RealTimeInferenceConfig { get; set; }
        }

        public class ModelVariantConfig : Humidifier.Base.BaseSubResource, IHaveModelName, IHaveVariantName, IHaveSageMakerInferenceExperimentTypesModelInfrastructureConfigInfrastructureConfig
        {
            /// <summary>
            /// ModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-modelvariantconfig.html#cfn-sagemaker-inferenceexperiment-modelvariantconfig-modelname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelName { get; set; }
            /// <summary>
            /// VariantName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-modelvariantconfig.html#cfn-sagemaker-inferenceexperiment-modelvariantconfig-variantname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VariantName { get; set; }
            /// <summary>
            /// InfrastructureConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-modelvariantconfig.html#cfn-sagemaker-inferenceexperiment-modelvariantconfig-infrastructureconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ModelInfrastructureConfig
            /// </summary>
            public Union<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig, BaseFunction>? InfrastructureConfig { get; set; }
        }

        public class RealTimeInferenceConfig : Humidifier.Base.BaseSubResource, IHaveInstanceCount_Integer, IHaveInstanceType
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-realtimeinferenceconfig.html#cfn-sagemaker-inferenceexperiment-realtimeinferenceconfig-instancecount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstanceCount { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-realtimeinferenceconfig.html#cfn-sagemaker-inferenceexperiment-realtimeinferenceconfig-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class ShadowModeConfig : Humidifier.Base.BaseSubResource, IHaveSourceModelVariantName, IHaveListOfSageMakerInferenceExperimentTypesShadowModelVariantConfigShadowModelVariants
        {
            /// <summary>
            /// SourceModelVariantName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-shadowmodeconfig.html#cfn-sagemaker-inferenceexperiment-shadowmodeconfig-sourcemodelvariantname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceModelVariantName { get; set; }
            /// <summary>
            /// ShadowModelVariants
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-shadowmodeconfig.html#cfn-sagemaker-inferenceexperiment-shadowmodeconfig-shadowmodelvariants
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ShadowModelVariantConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModelVariantConfig>, IReadOnlyList<Union<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModelVariantConfig, BaseFunction>>, BaseFunction>? ShadowModelVariants { get; set; }
        }

        public class ShadowModelVariantConfig : Humidifier.Base.BaseSubResource, IHaveShadowModelVariantName, IHaveSamplingPercentage_Integer
        {
            /// <summary>
            /// ShadowModelVariantName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-shadowmodelvariantconfig.html#cfn-sagemaker-inferenceexperiment-shadowmodelvariantconfig-shadowmodelvariantname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShadowModelVariantName { get; set; }
            /// <summary>
            /// SamplingPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferenceexperiment-shadowmodelvariantconfig.html#cfn-sagemaker-inferenceexperiment-shadowmodelvariantconfig-samplingpercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SamplingPercentage { get; set; }
        }
    }
}