namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using InferenceComponentTypes;

    public class InferenceComponent : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveEndpointName, IHaveVariantName
    {
        public class Attributes
        {
            public static string InferenceComponentStatus =  "InferenceComponentStatus" ;
            public static string InferenceComponentArn =  "InferenceComponentArn" ;
            public static string FailureReason =  "FailureReason" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.InferenceComponent; }

        /// <summary>
        /// EndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferencecomponent.html#cfn-sagemaker-inferencecomponent-endpointname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EndpointName { get; set; }
        /// <summary>
        /// Specifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferencecomponent.html#cfn-sagemaker-inferencecomponent-specifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InferenceComponentSpecificationForInstanceType
        /// </summary>
        public List<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSpecificationForInstanceType> Specifications { get; set; }
        /// <summary>
        /// VariantName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferencecomponent.html#cfn-sagemaker-inferencecomponent-variantname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VariantName { get; set; }
        public dynamic InferenceComponentName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Specification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferencecomponent.html#cfn-sagemaker-inferencecomponent-specification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InferenceComponentSpecification
        /// </summary>
        public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSpecification Specification { get; set; }
        /// <summary>
        /// RuntimeConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferencecomponent.html#cfn-sagemaker-inferencecomponent-runtimeconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InferenceComponentRuntimeConfig
        /// </summary>
        public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig RuntimeConfig { get; set; }
        /// <summary>
        /// DeploymentConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferencecomponent.html#cfn-sagemaker-inferencecomponent-deploymentconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InferenceComponentDeploymentConfig
        /// </summary>
        public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentDeploymentConfig DeploymentConfig { get; set; }
        /// <summary>
        /// EndpointArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferencecomponent.html#cfn-sagemaker-inferencecomponent-endpointarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EndpointArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-inferencecomponent.html#cfn-sagemaker-inferencecomponent-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace InferenceComponentTypes
    {
        public class Alarm : Humidifier.Base.BaseSubResource, IHaveAlarmName
        {
            /// <summary>
            /// AlarmName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-alarm.html#cfn-sagemaker-inferencecomponent-alarm-alarmname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlarmName { get; set; }
        }

        public class AutoRollbackConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Alarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-autorollbackconfiguration.html#cfn-sagemaker-inferencecomponent-autorollbackconfiguration-alarms
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Alarm
            /// </summary>
            public List<Humidifier.SageMaker.InferenceComponentTypes.Alarm> Alarms { get; set; }
        }

        public class ContainerMetricsConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MetricsEndpoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-containermetricsconfig.html#cfn-sagemaker-inferencecomponent-containermetricsconfig-metricsendpoints
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricsEndpoint
            /// </summary>
            public List<Humidifier.SageMaker.InferenceComponentTypes.MetricsEndpoint> MetricsEndpoints { get; set; }
        }

        public class DeployedImage : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResolutionTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-deployedimage.html#cfn-sagemaker-inferencecomponent-deployedimage-resolutiontime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResolutionTime { get; set; }
            /// <summary>
            /// SpecifiedImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-deployedimage.html#cfn-sagemaker-inferencecomponent-deployedimage-specifiedimage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SpecifiedImage { get; set; }
            /// <summary>
            /// ResolvedImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-deployedimage.html#cfn-sagemaker-inferencecomponent-deployedimage-resolvedimage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResolvedImage { get; set; }
        }

        public class InferenceComponentAvailabilityZoneBalance : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EnforcementMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentavailabilityzonebalance.html#cfn-sagemaker-inferencecomponent-inferencecomponentavailabilityzonebalance-enforcementmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EnforcementMode { get; set; }
            /// <summary>
            /// MaxImbalance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentavailabilityzonebalance.html#cfn-sagemaker-inferencecomponent-inferencecomponentavailabilityzonebalance-maximbalance
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxImbalance { get; set; }
        }

        public class InferenceComponentCapacitySize : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentcapacitysize.html#cfn-sagemaker-inferencecomponent-inferencecomponentcapacitysize-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentcapacitysize.html#cfn-sagemaker-inferencecomponent-inferencecomponentcapacitysize-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class InferenceComponentComputeResourceRequirements : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NumberOfAcceleratorDevicesRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentcomputeresourcerequirements.html#cfn-sagemaker-inferencecomponent-inferencecomponentcomputeresourcerequirements-numberofacceleratordevicesrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic NumberOfAcceleratorDevicesRequired { get; set; }
            /// <summary>
            /// MaxMemoryRequiredInMb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentcomputeresourcerequirements.html#cfn-sagemaker-inferencecomponent-inferencecomponentcomputeresourcerequirements-maxmemoryrequiredinmb
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxMemoryRequiredInMb { get; set; }
            /// <summary>
            /// MinMemoryRequiredInMb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentcomputeresourcerequirements.html#cfn-sagemaker-inferencecomponent-inferencecomponentcomputeresourcerequirements-minmemoryrequiredinmb
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinMemoryRequiredInMb { get; set; }
            /// <summary>
            /// NumberOfCpuCoresRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentcomputeresourcerequirements.html#cfn-sagemaker-inferencecomponent-inferencecomponentcomputeresourcerequirements-numberofcpucoresrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic NumberOfCpuCoresRequired { get; set; }
        }

        public class InferenceComponentContainerSpecification : Humidifier.Base.BaseSubResource, IHaveImage
        {
            /// <summary>
            /// ArtifactUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentcontainerspecification.html#cfn-sagemaker-inferencecomponent-inferencecomponentcontainerspecification-artifacturl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ArtifactUrl { get; set; }
            /// <summary>
            /// ContainerMetricsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentcontainerspecification.html#cfn-sagemaker-inferencecomponent-inferencecomponentcontainerspecification-containermetricsconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContainerMetricsConfig
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig ContainerMetricsConfig { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentcontainerspecification.html#cfn-sagemaker-inferencecomponent-inferencecomponentcontainerspecification-environment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Environment { get; set; }
            /// <summary>
            /// DeployedImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentcontainerspecification.html#cfn-sagemaker-inferencecomponent-inferencecomponentcontainerspecification-deployedimage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeployedImage
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.DeployedImage DeployedImage { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentcontainerspecification.html#cfn-sagemaker-inferencecomponent-inferencecomponentcontainerspecification-image
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image { get; set; }
        }

        public class InferenceComponentContainerSpecificationForInstanceType : Humidifier.Base.BaseSubResource, IHaveImage
        {
            /// <summary>
            /// ArtifactUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentcontainerspecificationforinstancetype.html#cfn-sagemaker-inferencecomponent-inferencecomponentcontainerspecificationforinstancetype-artifacturl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ArtifactUrl { get; set; }
            /// <summary>
            /// ContainerMetricsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentcontainerspecificationforinstancetype.html#cfn-sagemaker-inferencecomponent-inferencecomponentcontainerspecificationforinstancetype-containermetricsconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContainerMetricsConfig
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig ContainerMetricsConfig { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentcontainerspecificationforinstancetype.html#cfn-sagemaker-inferencecomponent-inferencecomponentcontainerspecificationforinstancetype-environment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Environment { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentcontainerspecificationforinstancetype.html#cfn-sagemaker-inferencecomponent-inferencecomponentcontainerspecificationforinstancetype-image
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image { get; set; }
        }

        public class InferenceComponentDataCacheConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EnableCaching
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentdatacacheconfig.html#cfn-sagemaker-inferencecomponent-inferencecomponentdatacacheconfig-enablecaching
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableCaching { get; set; }
        }

        public class InferenceComponentDeploymentConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AutoRollbackConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentdeploymentconfig.html#cfn-sagemaker-inferencecomponent-inferencecomponentdeploymentconfig-autorollbackconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoRollbackConfiguration
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.AutoRollbackConfiguration AutoRollbackConfiguration { get; set; }
            /// <summary>
            /// RollingUpdatePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentdeploymentconfig.html#cfn-sagemaker-inferencecomponent-inferencecomponentdeploymentconfig-rollingupdatepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceComponentRollingUpdatePolicy
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRollingUpdatePolicy RollingUpdatePolicy { get; set; }
        }

        public class InferenceComponentPlacementStatus : Humidifier.Base.BaseSubResource, IHaveInstanceType
        {
            /// <summary>
            /// CurrentCopyCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentplacementstatus.html#cfn-sagemaker-inferencecomponent-inferencecomponentplacementstatus-currentcopycount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CurrentCopyCount { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentplacementstatus.html#cfn-sagemaker-inferencecomponent-inferencecomponentplacementstatus-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
        }

        public class InferenceComponentRollingUpdatePolicy : Humidifier.Base.BaseSubResource, IHaveMaximumExecutionTimeoutInSeconds, IHaveWaitIntervalInSeconds
        {
            /// <summary>
            /// MaximumExecutionTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentrollingupdatepolicy.html#cfn-sagemaker-inferencecomponent-inferencecomponentrollingupdatepolicy-maximumexecutiontimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumExecutionTimeoutInSeconds { get; set; }
            /// <summary>
            /// MaximumBatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentrollingupdatepolicy.html#cfn-sagemaker-inferencecomponent-inferencecomponentrollingupdatepolicy-maximumbatchsize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceComponentCapacitySize
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentCapacitySize MaximumBatchSize { get; set; }
            /// <summary>
            /// WaitIntervalInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentrollingupdatepolicy.html#cfn-sagemaker-inferencecomponent-inferencecomponentrollingupdatepolicy-waitintervalinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WaitIntervalInSeconds { get; set; }
            /// <summary>
            /// RollbackMaximumBatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentrollingupdatepolicy.html#cfn-sagemaker-inferencecomponent-inferencecomponentrollingupdatepolicy-rollbackmaximumbatchsize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceComponentCapacitySize
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentCapacitySize RollbackMaximumBatchSize { get; set; }
        }

        public class InferenceComponentRuntimeConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CurrentCopyCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentruntimeconfig.html#cfn-sagemaker-inferencecomponent-inferencecomponentruntimeconfig-currentcopycount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CurrentCopyCount { get; set; }
            /// <summary>
            /// PlacementStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentruntimeconfig.html#cfn-sagemaker-inferencecomponent-inferencecomponentruntimeconfig-placementstatus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InferenceComponentPlacementStatus
            /// </summary>
            public List<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentPlacementStatus> PlacementStatus { get; set; }
            /// <summary>
            /// DesiredCopyCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentruntimeconfig.html#cfn-sagemaker-inferencecomponent-inferencecomponentruntimeconfig-desiredcopycount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DesiredCopyCount { get; set; }
            /// <summary>
            /// CopyCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentruntimeconfig.html#cfn-sagemaker-inferencecomponent-inferencecomponentruntimeconfig-copycount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CopyCount { get; set; }
        }

        public class InferenceComponentSchedulingConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AvailabilityZoneBalance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentschedulingconfig.html#cfn-sagemaker-inferencecomponent-inferencecomponentschedulingconfig-availabilityzonebalance
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InferenceComponentAvailabilityZoneBalance
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance AvailabilityZoneBalance { get; set; }
            /// <summary>
            /// PlacementStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentschedulingconfig.html#cfn-sagemaker-inferencecomponent-inferencecomponentschedulingconfig-placementstrategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PlacementStrategy { get; set; }
        }

        public class InferenceComponentSpecification : Humidifier.Base.BaseSubResource, IHaveModelName
        {
            /// <summary>
            /// Container
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentspecification.html#cfn-sagemaker-inferencecomponent-inferencecomponentspecification-container
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceComponentContainerSpecification
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentContainerSpecification Container { get; set; }
            /// <summary>
            /// ModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentspecification.html#cfn-sagemaker-inferencecomponent-inferencecomponentspecification-modelname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelName { get; set; }
            /// <summary>
            /// DataCacheConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentspecification.html#cfn-sagemaker-inferencecomponent-inferencecomponentspecification-datacacheconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceComponentDataCacheConfig
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentDataCacheConfig DataCacheConfig { get; set; }
            /// <summary>
            /// ComputeResourceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentspecification.html#cfn-sagemaker-inferencecomponent-inferencecomponentspecification-computeresourcerequirements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceComponentComputeResourceRequirements
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentComputeResourceRequirements ComputeResourceRequirements { get; set; }
            /// <summary>
            /// CurrentDataCacheConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentspecification.html#cfn-sagemaker-inferencecomponent-inferencecomponentspecification-currentdatacacheconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceComponentDataCacheConfig
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentDataCacheConfig CurrentDataCacheConfig { get; set; }
            /// <summary>
            /// SchedulingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentspecification.html#cfn-sagemaker-inferencecomponent-inferencecomponentspecification-schedulingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceComponentSchedulingConfig
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSchedulingConfig SchedulingConfig { get; set; }
            /// <summary>
            /// BaseInferenceComponentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentspecification.html#cfn-sagemaker-inferencecomponent-inferencecomponentspecification-baseinferencecomponentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseInferenceComponentName { get; set; }
            /// <summary>
            /// StartupParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentspecification.html#cfn-sagemaker-inferencecomponent-inferencecomponentspecification-startupparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceComponentStartupParameters
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentStartupParameters StartupParameters { get; set; }
        }

        public class InferenceComponentSpecificationForInstanceType : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHaveModelName
        {
            /// <summary>
            /// Container
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentspecificationforinstancetype.html#cfn-sagemaker-inferencecomponent-inferencecomponentspecificationforinstancetype-container
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceComponentContainerSpecificationForInstanceType
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentContainerSpecificationForInstanceType Container { get; set; }
            /// <summary>
            /// ModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentspecificationforinstancetype.html#cfn-sagemaker-inferencecomponent-inferencecomponentspecificationforinstancetype-modelname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelName { get; set; }
            /// <summary>
            /// DataCacheConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentspecificationforinstancetype.html#cfn-sagemaker-inferencecomponent-inferencecomponentspecificationforinstancetype-datacacheconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceComponentDataCacheConfig
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentDataCacheConfig DataCacheConfig { get; set; }
            /// <summary>
            /// ComputeResourceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentspecificationforinstancetype.html#cfn-sagemaker-inferencecomponent-inferencecomponentspecificationforinstancetype-computeresourcerequirements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceComponentComputeResourceRequirements
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentComputeResourceRequirements ComputeResourceRequirements { get; set; }
            /// <summary>
            /// CurrentDataCacheConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentspecificationforinstancetype.html#cfn-sagemaker-inferencecomponent-inferencecomponentspecificationforinstancetype-currentdatacacheconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceComponentDataCacheConfig
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentDataCacheConfig CurrentDataCacheConfig { get; set; }
            /// <summary>
            /// SchedulingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentspecificationforinstancetype.html#cfn-sagemaker-inferencecomponent-inferencecomponentspecificationforinstancetype-schedulingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceComponentSchedulingConfig
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSchedulingConfig SchedulingConfig { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentspecificationforinstancetype.html#cfn-sagemaker-inferencecomponent-inferencecomponentspecificationforinstancetype-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
            /// <summary>
            /// StartupParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentspecificationforinstancetype.html#cfn-sagemaker-inferencecomponent-inferencecomponentspecificationforinstancetype-startupparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceComponentStartupParameters
            /// </summary>
            public Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentStartupParameters StartupParameters { get; set; }
        }

        public class InferenceComponentStartupParameters : Humidifier.Base.BaseSubResource, IHaveModelDataDownloadTimeoutInSeconds, IHaveContainerStartupHealthCheckTimeoutInSeconds
        {
            /// <summary>
            /// ModelDataDownloadTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentstartupparameters.html#cfn-sagemaker-inferencecomponent-inferencecomponentstartupparameters-modeldatadownloadtimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ModelDataDownloadTimeoutInSeconds { get; set; }
            /// <summary>
            /// ContainerStartupHealthCheckTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-inferencecomponentstartupparameters.html#cfn-sagemaker-inferencecomponent-inferencecomponentstartupparameters-containerstartuphealthchecktimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ContainerStartupHealthCheckTimeoutInSeconds { get; set; }
        }

        public class MetricsEndpoint : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MetricsEndpointPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-metricsendpoint.html#cfn-sagemaker-inferencecomponent-metricsendpoint-metricsendpointpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricsEndpointPath { get; set; }
            /// <summary>
            /// MetricPublishFrequencyInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-inferencecomponent-metricsendpoint.html#cfn-sagemaker-inferencecomponent-metricsendpoint-metricpublishfrequencyinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MetricPublishFrequencyInSeconds { get; set; }
        }
    }
}