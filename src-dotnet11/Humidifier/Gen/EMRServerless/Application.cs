namespace Humidifier.EMRServerless
{
    using global::System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveEMRServerlessApplicationTypesAutoStartConfigurationAutoStartConfiguration, IHaveArchitecture, IHaveMapOfEMRServerlessApplicationTypesWorkerTypeSpecificationInputWorkerTypeSpecifications, IHaveEMRServerlessApplicationTypesMonitoringConfigurationMonitoringConfiguration, IHaveEMRServerlessApplicationTypesMaximumAllowedResourcesMaximumCapacity, IHaveEMRServerlessApplicationTypesAutoStopConfigurationAutoStopConfiguration, IHaveListOfEMRServerlessApplicationTypesConfigurationObjectRuntimeConfiguration, IHaveName, IHaveType, IHaveEMRServerlessApplicationTypesSchedulerConfigurationSchedulerConfiguration, IHaveListOfEMRServerlessApplicationTypesInitialCapacityConfigKeyValuePairInitialCapacity, IHaveEMRServerlessApplicationTypesInteractiveConfigurationInteractiveConfiguration, IHaveEMRServerlessApplicationTypesImageConfigurationInputImageConfiguration, IHaveEMRServerlessApplicationTypesNetworkConfigurationNetworkConfiguration, IHaveReleaseLabel, IHaveEMRServerlessApplicationTypesIdentityCenterConfigurationIdentityCenterConfiguration
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string ApplicationId =  "ApplicationId" ;
        }

        public override string AWSTypeName { get => AWS.EMRServerless.Application; }
        /// <summary>
        /// AutoStartConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-autostartconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: AutoStartConfiguration
        /// </summary>
        public Union<Humidifier.EMRServerless.ApplicationTypes.AutoStartConfiguration, BaseFunction>? AutoStartConfiguration { get; set; }
        /// <summary>
        /// Architecture
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-architecture
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Architecture { get; set; }
        /// <summary>
        /// WorkerTypeSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-workertypespecifications
        /// Required: False
        /// UpdateType: Conditional
        /// Type: Map
        /// ItemType: WorkerTypeSpecificationInput
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.EMRServerless.ApplicationTypes.WorkerTypeSpecificationInput>, IReadOnlyDictionary<string, Union<Humidifier.EMRServerless.ApplicationTypes.WorkerTypeSpecificationInput, BaseFunction>>, BaseFunction>? WorkerTypeSpecifications { get; set; }
        /// <summary>
        /// MonitoringConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-monitoringconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: MonitoringConfiguration
        /// </summary>
        public Union<Humidifier.EMRServerless.ApplicationTypes.MonitoringConfiguration, BaseFunction>? MonitoringConfiguration { get; set; }
        /// <summary>
        /// MaximumCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-maximumcapacity
        /// Required: False
        /// UpdateType: Conditional
        /// Type: MaximumAllowedResources
        /// </summary>
        public Union<Humidifier.EMRServerless.ApplicationTypes.MaximumAllowedResources, BaseFunction>? MaximumCapacity { get; set; }
        /// <summary>
        /// AutoStopConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-autostopconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: AutoStopConfiguration
        /// </summary>
        public Union<Humidifier.EMRServerless.ApplicationTypes.AutoStopConfiguration, BaseFunction>? AutoStopConfiguration { get; set; }
        /// <summary>
        /// RuntimeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-runtimeconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: ConfigurationObject
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EMRServerless.ApplicationTypes.ConfigurationObject>, IReadOnlyList<Union<Humidifier.EMRServerless.ApplicationTypes.ConfigurationObject, BaseFunction>>, BaseFunction>? RuntimeConfiguration { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// SchedulerConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-schedulerconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: SchedulerConfiguration
        /// </summary>
        public Union<Humidifier.EMRServerless.ApplicationTypes.SchedulerConfiguration, BaseFunction>? SchedulerConfiguration { get; set; }
        /// <summary>
        /// InitialCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-initialcapacity
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: InitialCapacityConfigKeyValuePair
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfigKeyValuePair>, IReadOnlyList<Union<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfigKeyValuePair, BaseFunction>>, BaseFunction>? InitialCapacity { get; set; }
        /// <summary>
        /// InteractiveConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-interactiveconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: InteractiveConfiguration
        /// </summary>
        public Union<Humidifier.EMRServerless.ApplicationTypes.InteractiveConfiguration, BaseFunction>? InteractiveConfiguration { get; set; }
        /// <summary>
        /// ImageConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-imageconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: ImageConfigurationInput
        /// </summary>
        public Union<Humidifier.EMRServerless.ApplicationTypes.ImageConfigurationInput, BaseFunction>? ImageConfiguration { get; set; }
        /// <summary>
        /// NetworkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-networkconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: NetworkConfiguration
        /// </summary>
        public Union<Humidifier.EMRServerless.ApplicationTypes.NetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }

        /// <summary>
        /// ReleaseLabel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-releaselabel
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ReleaseLabel { get; set; }
        /// <summary>
        /// IdentityCenterConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-identitycenterconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IdentityCenterConfiguration
        /// </summary>
        public Union<Humidifier.EMRServerless.ApplicationTypes.IdentityCenterConfiguration, BaseFunction>? IdentityCenterConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ApplicationTypes
    {
        public class AutoStartConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-autostartconfiguration.html#cfn-emrserverless-application-autostartconfiguration-enabled
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class AutoStopConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveIdleTimeoutMinutes_Integer
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-autostopconfiguration.html#cfn-emrserverless-application-autostopconfiguration-enabled
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// IdleTimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-autostopconfiguration.html#cfn-emrserverless-application-autostopconfiguration-idletimeoutminutes
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IdleTimeoutMinutes { get; set; }
        }

        public class CloudWatchLoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveEncryptionKeyArn, IHaveEnabled_Boolean, IHaveLogStreamNamePrefix, IHaveLogGroupName, IHaveListOfEMRServerlessApplicationTypesLogTypeMapKeyValuePairLogTypeMap
        {
            /// <summary>
            /// EncryptionKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-cloudwatchloggingconfiguration.html#cfn-emrserverless-application-cloudwatchloggingconfiguration-encryptionkeyarn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKeyArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-cloudwatchloggingconfiguration.html#cfn-emrserverless-application-cloudwatchloggingconfiguration-enabled
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// LogStreamNamePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-cloudwatchloggingconfiguration.html#cfn-emrserverless-application-cloudwatchloggingconfiguration-logstreamnameprefix
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogStreamNamePrefix { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-cloudwatchloggingconfiguration.html#cfn-emrserverless-application-cloudwatchloggingconfiguration-loggroupname
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupName { get; set; }
            /// <summary>
            /// LogTypeMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-cloudwatchloggingconfiguration.html#cfn-emrserverless-application-cloudwatchloggingconfiguration-logtypemap
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: LogTypeMapKeyValuePair
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMRServerless.ApplicationTypes.LogTypeMapKeyValuePair>, IReadOnlyList<Union<Humidifier.EMRServerless.ApplicationTypes.LogTypeMapKeyValuePair, BaseFunction>>, BaseFunction>? LogTypeMap { get; set; }
        }

        public class ConfigurationObject : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfProperties, IHaveListOfEMRServerlessApplicationTypesConfigurationObjectConfigurations, IHaveClassification
        {
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-configurationobject.html#cfn-emrserverless-application-configurationobject-properties
            /// Required: False
            /// UpdateType: Conditional
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Properties { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-configurationobject.html#cfn-emrserverless-application-configurationobject-configurations
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: ConfigurationObject
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMRServerless.ApplicationTypes.ConfigurationObject>, IReadOnlyList<Union<Humidifier.EMRServerless.ApplicationTypes.ConfigurationObject, BaseFunction>>, BaseFunction>? Configurations { get; set; }
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-configurationobject.html#cfn-emrserverless-application-configurationobject-classification
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Classification { get; set; }
        }

        public class IdentityCenterConfiguration : Humidifier.Base.BaseSubResource, IHaveIdentityCenterInstanceArn
        {
            /// <summary>
            /// IdentityCenterInstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-identitycenterconfiguration.html#cfn-emrserverless-application-identitycenterconfiguration-identitycenterinstancearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdentityCenterInstanceArn { get; set; }
        }

        public class ImageConfigurationInput : Humidifier.Base.BaseSubResource, IHaveImageUri
        {
            /// <summary>
            /// ImageUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-imageconfigurationinput.html#cfn-emrserverless-application-imageconfigurationinput-imageuri
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageUri { get; set; }
        }

        public class InitialCapacityConfig : Humidifier.Base.BaseSubResource, IHaveEMRServerlessApplicationTypesWorkerConfigurationWorkerConfiguration, IHaveWorkerCount_Long
        {
            /// <summary>
            /// WorkerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-initialcapacityconfig.html#cfn-emrserverless-application-initialcapacityconfig-workerconfiguration
            /// Required: True
            /// UpdateType: Conditional
            /// Type: WorkerConfiguration
            /// </summary>
            public Union<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration, BaseFunction>? WorkerConfiguration { get; set; }
            /// <summary>
            /// WorkerCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-initialcapacityconfig.html#cfn-emrserverless-application-initialcapacityconfig-workercount
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? WorkerCount { get; set; }
        }

        public class InitialCapacityConfigKeyValuePair : Humidifier.Base.BaseSubResource, IHaveEMRServerlessApplicationTypesInitialCapacityConfigValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-initialcapacityconfigkeyvaluepair.html#cfn-emrserverless-application-initialcapacityconfigkeyvaluepair-value
            /// Required: True
            /// UpdateType: Conditional
            /// Type: InitialCapacityConfig
            /// </summary>
            public Union<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-initialcapacityconfigkeyvaluepair.html#cfn-emrserverless-application-initialcapacityconfigkeyvaluepair-key
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class InteractiveConfiguration : Humidifier.Base.BaseSubResource, IHaveSessionEnabled_Boolean, IHaveStudioEnabled_Boolean, IHaveLivyEndpointEnabled_Boolean
        {
            /// <summary>
            /// SessionEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-interactiveconfiguration.html#cfn-emrserverless-application-interactiveconfiguration-sessionenabled
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SessionEnabled { get; set; }
            /// <summary>
            /// StudioEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-interactiveconfiguration.html#cfn-emrserverless-application-interactiveconfiguration-studioenabled
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? StudioEnabled { get; set; }
            /// <summary>
            /// LivyEndpointEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-interactiveconfiguration.html#cfn-emrserverless-application-interactiveconfiguration-livyendpointenabled
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? LivyEndpointEnabled { get; set; }
        }

        public class LogTypeMapKeyValuePair : Humidifier.Base.BaseSubResource, IHaveStringListOfValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-logtypemapkeyvaluepair.html#cfn-emrserverless-application-logtypemapkeyvaluepair-value
            /// Required: True
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-logtypemapkeyvaluepair.html#cfn-emrserverless-application-logtypemapkeyvaluepair-key
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class ManagedPersistenceMonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveEncryptionKeyArn, IHaveEnabled_Boolean
        {
            /// <summary>
            /// EncryptionKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-managedpersistencemonitoringconfiguration.html#cfn-emrserverless-application-managedpersistencemonitoringconfiguration-encryptionkeyarn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKeyArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-managedpersistencemonitoringconfiguration.html#cfn-emrserverless-application-managedpersistencemonitoringconfiguration-enabled
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class MaximumAllowedResources : Humidifier.Base.BaseSubResource, IHaveMemory, IHaveCpu, IHaveDisk
        {
            /// <summary>
            /// Memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-maximumallowedresources.html#cfn-emrserverless-application-maximumallowedresources-memory
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Memory { get; set; }
            /// <summary>
            /// Cpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-maximumallowedresources.html#cfn-emrserverless-application-maximumallowedresources-cpu
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cpu { get; set; }
            /// <summary>
            /// Disk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-maximumallowedresources.html#cfn-emrserverless-application-maximumallowedresources-disk
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Disk { get; set; }
        }

        public class MonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveEMRServerlessApplicationTypesS3MonitoringConfigurationS3MonitoringConfiguration, IHaveEMRServerlessApplicationTypesPrometheusMonitoringConfigurationPrometheusMonitoringConfiguration, IHaveEMRServerlessApplicationTypesManagedPersistenceMonitoringConfigurationManagedPersistenceMonitoringConfiguration, IHaveEMRServerlessApplicationTypesCloudWatchLoggingConfigurationCloudWatchLoggingConfiguration
        {
            /// <summary>
            /// S3MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-monitoringconfiguration.html#cfn-emrserverless-application-monitoringconfiguration-s3monitoringconfiguration
            /// Required: False
            /// UpdateType: Conditional
            /// Type: S3MonitoringConfiguration
            /// </summary>
            public Union<Humidifier.EMRServerless.ApplicationTypes.S3MonitoringConfiguration, BaseFunction>? S3MonitoringConfiguration { get; set; }
            /// <summary>
            /// PrometheusMonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-monitoringconfiguration.html#cfn-emrserverless-application-monitoringconfiguration-prometheusmonitoringconfiguration
            /// Required: False
            /// UpdateType: Conditional
            /// Type: PrometheusMonitoringConfiguration
            /// </summary>
            public Union<Humidifier.EMRServerless.ApplicationTypes.PrometheusMonitoringConfiguration, BaseFunction>? PrometheusMonitoringConfiguration { get; set; }
            /// <summary>
            /// ManagedPersistenceMonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-monitoringconfiguration.html#cfn-emrserverless-application-monitoringconfiguration-managedpersistencemonitoringconfiguration
            /// Required: False
            /// UpdateType: Conditional
            /// Type: ManagedPersistenceMonitoringConfiguration
            /// </summary>
            public Union<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration, BaseFunction>? ManagedPersistenceMonitoringConfiguration { get; set; }
            /// <summary>
            /// CloudWatchLoggingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-monitoringconfiguration.html#cfn-emrserverless-application-monitoringconfiguration-cloudwatchloggingconfiguration
            /// Required: False
            /// UpdateType: Conditional
            /// Type: CloudWatchLoggingConfiguration
            /// </summary>
            public Union<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration, BaseFunction>? CloudWatchLoggingConfiguration { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-networkconfiguration.html#cfn-emrserverless-application-networkconfiguration-subnetids
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-networkconfiguration.html#cfn-emrserverless-application-networkconfiguration-securitygroupids
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }

        public class PrometheusMonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveRemoteWriteUrl
        {
            /// <summary>
            /// RemoteWriteUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-prometheusmonitoringconfiguration.html#cfn-emrserverless-application-prometheusmonitoringconfiguration-remotewriteurl
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RemoteWriteUrl { get; set; }
        }

        public class S3MonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveLogUri, IHaveEncryptionKeyArn
        {
            /// <summary>
            /// LogUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-s3monitoringconfiguration.html#cfn-emrserverless-application-s3monitoringconfiguration-loguri
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogUri { get; set; }
            /// <summary>
            /// EncryptionKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-s3monitoringconfiguration.html#cfn-emrserverless-application-s3monitoringconfiguration-encryptionkeyarn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKeyArn { get; set; }
        }

        public class SchedulerConfiguration : Humidifier.Base.BaseSubResource, IHaveQueueTimeoutMinutes_Integer, IHaveMaxConcurrentRuns_Integer
        {
            /// <summary>
            /// QueueTimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-schedulerconfiguration.html#cfn-emrserverless-application-schedulerconfiguration-queuetimeoutminutes
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? QueueTimeoutMinutes { get; set; }
            /// <summary>
            /// MaxConcurrentRuns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-schedulerconfiguration.html#cfn-emrserverless-application-schedulerconfiguration-maxconcurrentruns
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxConcurrentRuns { get; set; }
        }

        public class WorkerConfiguration : Humidifier.Base.BaseSubResource, IHaveDiskType, IHaveMemory, IHaveCpu, IHaveDisk
        {
            /// <summary>
            /// DiskType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-workerconfiguration.html#cfn-emrserverless-application-workerconfiguration-disktype
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DiskType { get; set; }
            /// <summary>
            /// Memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-workerconfiguration.html#cfn-emrserverless-application-workerconfiguration-memory
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Memory { get; set; }
            /// <summary>
            /// Cpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-workerconfiguration.html#cfn-emrserverless-application-workerconfiguration-cpu
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cpu { get; set; }
            /// <summary>
            /// Disk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-workerconfiguration.html#cfn-emrserverless-application-workerconfiguration-disk
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Disk { get; set; }
        }

        public class WorkerTypeSpecificationInput : Humidifier.Base.BaseSubResource, IHaveEMRServerlessApplicationTypesImageConfigurationInputImageConfiguration
        {
            /// <summary>
            /// ImageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-workertypespecificationinput.html#cfn-emrserverless-application-workertypespecificationinput-imageconfiguration
            /// Required: False
            /// UpdateType: Conditional
            /// Type: ImageConfigurationInput
            /// </summary>
            public Union<Humidifier.EMRServerless.ApplicationTypes.ImageConfigurationInput, BaseFunction>? ImageConfiguration { get; set; }
        }
    }
}