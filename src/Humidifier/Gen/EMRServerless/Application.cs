namespace Humidifier.EMRServerless
{
    using System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveType, IHaveArchitecture, IHaveReleaseLabel, IHaveEMRServerlessApplicationTypesImageConfigurationInputImageConfiguration
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
        public Humidifier.EMRServerless.ApplicationTypes.AutoStartConfiguration AutoStartConfiguration { get; set; }
        /// <summary>
        /// Architecture
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-architecture
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic Architecture { get; set; }
        /// <summary>
        /// WorkerTypeSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-workertypespecifications
        /// Required: False
        /// UpdateType: Conditional
        /// Type: Map
        /// ItemType: WorkerTypeSpecificationInput
        /// </summary>
        public Dictionary<string, Humidifier.EMRServerless.ApplicationTypes.WorkerTypeSpecificationInput> WorkerTypeSpecifications { get; set; }
        /// <summary>
        /// MonitoringConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-monitoringconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: MonitoringConfiguration
        /// </summary>
        public Humidifier.EMRServerless.ApplicationTypes.MonitoringConfiguration MonitoringConfiguration { get; set; }
        /// <summary>
        /// MaximumCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-maximumcapacity
        /// Required: False
        /// UpdateType: Conditional
        /// Type: MaximumAllowedResources
        /// </summary>
        public Humidifier.EMRServerless.ApplicationTypes.MaximumAllowedResources MaximumCapacity { get; set; }
        /// <summary>
        /// AutoStopConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-autostopconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: AutoStopConfiguration
        /// </summary>
        public Humidifier.EMRServerless.ApplicationTypes.AutoStopConfiguration AutoStopConfiguration { get; set; }
        /// <summary>
        /// RuntimeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-runtimeconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: ConfigurationObject
        /// </summary>
        public List<Humidifier.EMRServerless.ApplicationTypes.ConfigurationObject> RuntimeConfiguration { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }
        /// <summary>
        /// SchedulerConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-schedulerconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: SchedulerConfiguration
        /// </summary>
        public Humidifier.EMRServerless.ApplicationTypes.SchedulerConfiguration SchedulerConfiguration { get; set; }
        /// <summary>
        /// InitialCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-initialcapacity
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: InitialCapacityConfigKeyValuePair
        /// </summary>
        public List<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfigKeyValuePair> InitialCapacity { get; set; }
        /// <summary>
        /// InteractiveConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-interactiveconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: InteractiveConfiguration
        /// </summary>
        public Humidifier.EMRServerless.ApplicationTypes.InteractiveConfiguration InteractiveConfiguration { get; set; }
        /// <summary>
        /// ImageConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-imageconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: ImageConfigurationInput
        /// </summary>
        public Humidifier.EMRServerless.ApplicationTypes.ImageConfigurationInput ImageConfiguration { get; set; }
        /// <summary>
        /// NetworkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-networkconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: NetworkConfiguration
        /// </summary>
        public Humidifier.EMRServerless.ApplicationTypes.NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// ReleaseLabel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-releaselabel
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ReleaseLabel { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-application.html#cfn-emrserverless-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ApplicationTypes
    {
        public class AutoStartConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-autostartconfiguration.html#cfn-emrserverless-application-autostartconfiguration-enabled
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class AutoStopConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-autostopconfiguration.html#cfn-emrserverless-application-autostopconfiguration-enabled
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// IdleTimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-autostopconfiguration.html#cfn-emrserverless-application-autostopconfiguration-idletimeoutminutes
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IdleTimeoutMinutes { get; set; }
        }

        public class CloudWatchLoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveLogGroupName, IHaveEncryptionKeyArn
        {
            /// <summary>
            /// EncryptionKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-cloudwatchloggingconfiguration.html#cfn-emrserverless-application-cloudwatchloggingconfiguration-encryptionkeyarn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionKeyArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-cloudwatchloggingconfiguration.html#cfn-emrserverless-application-cloudwatchloggingconfiguration-enabled
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// LogStreamNamePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-cloudwatchloggingconfiguration.html#cfn-emrserverless-application-cloudwatchloggingconfiguration-logstreamnameprefix
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogStreamNamePrefix { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-cloudwatchloggingconfiguration.html#cfn-emrserverless-application-cloudwatchloggingconfiguration-loggroupname
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroupName { get; set; }
            /// <summary>
            /// LogTypeMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-cloudwatchloggingconfiguration.html#cfn-emrserverless-application-cloudwatchloggingconfiguration-logtypemap
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: LogTypeMapKeyValuePair
            /// </summary>
            public List<Humidifier.EMRServerless.ApplicationTypes.LogTypeMapKeyValuePair> LogTypeMap { get; set; }
        }

        public class ConfigurationObject : Humidifier.Base.BaseSubResource, IHaveClassification
        {
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-configurationobject.html#cfn-emrserverless-application-configurationobject-classification
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic Classification { get; set; }
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-configurationobject.html#cfn-emrserverless-application-configurationobject-properties
            /// Required: False
            /// UpdateType: Conditional
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Properties { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-configurationobject.html#cfn-emrserverless-application-configurationobject-configurations
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: ConfigurationObject
            /// </summary>
            public List<Humidifier.EMRServerless.ApplicationTypes.ConfigurationObject> Configurations { get; set; }
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
            public dynamic ImageUri { get; set; }
        }

        public class InitialCapacityConfig : Humidifier.Base.BaseSubResource, IHaveWorkerCount
        {
            /// <summary>
            /// WorkerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-initialcapacityconfig.html#cfn-emrserverless-application-initialcapacityconfig-workerconfiguration
            /// Required: True
            /// UpdateType: Conditional
            /// Type: WorkerConfiguration
            /// </summary>
            public Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration WorkerConfiguration { get; set; }
            /// <summary>
            /// WorkerCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-initialcapacityconfig.html#cfn-emrserverless-application-initialcapacityconfig-workercount
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WorkerCount { get; set; }
        }

        public class InitialCapacityConfigKeyValuePair : Humidifier.Base.BaseSubResource, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-initialcapacityconfigkeyvaluepair.html#cfn-emrserverless-application-initialcapacityconfigkeyvaluepair-value
            /// Required: True
            /// UpdateType: Conditional
            /// Type: InitialCapacityConfig
            /// </summary>
            public Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-initialcapacityconfigkeyvaluepair.html#cfn-emrserverless-application-initialcapacityconfigkeyvaluepair-key
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class InteractiveConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StudioEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-interactiveconfiguration.html#cfn-emrserverless-application-interactiveconfiguration-studioenabled
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic StudioEnabled { get; set; }
            /// <summary>
            /// LivyEndpointEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-interactiveconfiguration.html#cfn-emrserverless-application-interactiveconfiguration-livyendpointenabled
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic LivyEndpointEnabled { get; set; }
        }

        public class LogTypeMapKeyValuePair : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-logtypemapkeyvaluepair.html#cfn-emrserverless-application-logtypemapkeyvaluepair-value
            /// Required: True
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-logtypemapkeyvaluepair.html#cfn-emrserverless-application-logtypemapkeyvaluepair-key
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class ManagedPersistenceMonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveEncryptionKeyArn
        {
            /// <summary>
            /// EncryptionKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-managedpersistencemonitoringconfiguration.html#cfn-emrserverless-application-managedpersistencemonitoringconfiguration-encryptionkeyarn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionKeyArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-managedpersistencemonitoringconfiguration.html#cfn-emrserverless-application-managedpersistencemonitoringconfiguration-enabled
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
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
            public dynamic Memory { get; set; }
            /// <summary>
            /// Cpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-maximumallowedresources.html#cfn-emrserverless-application-maximumallowedresources-cpu
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic Cpu { get; set; }
            /// <summary>
            /// Disk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-maximumallowedresources.html#cfn-emrserverless-application-maximumallowedresources-disk
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic Disk { get; set; }
        }

        public class MonitoringConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-monitoringconfiguration.html#cfn-emrserverless-application-monitoringconfiguration-s3monitoringconfiguration
            /// Required: False
            /// UpdateType: Conditional
            /// Type: S3MonitoringConfiguration
            /// </summary>
            public Humidifier.EMRServerless.ApplicationTypes.S3MonitoringConfiguration S3MonitoringConfiguration { get; set; }
            /// <summary>
            /// PrometheusMonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-monitoringconfiguration.html#cfn-emrserverless-application-monitoringconfiguration-prometheusmonitoringconfiguration
            /// Required: False
            /// UpdateType: Conditional
            /// Type: PrometheusMonitoringConfiguration
            /// </summary>
            public Humidifier.EMRServerless.ApplicationTypes.PrometheusMonitoringConfiguration PrometheusMonitoringConfiguration { get; set; }
            /// <summary>
            /// ManagedPersistenceMonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-monitoringconfiguration.html#cfn-emrserverless-application-monitoringconfiguration-managedpersistencemonitoringconfiguration
            /// Required: False
            /// UpdateType: Conditional
            /// Type: ManagedPersistenceMonitoringConfiguration
            /// </summary>
            public Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration ManagedPersistenceMonitoringConfiguration { get; set; }
            /// <summary>
            /// CloudWatchLoggingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-monitoringconfiguration.html#cfn-emrserverless-application-monitoringconfiguration-cloudwatchloggingconfiguration
            /// Required: False
            /// UpdateType: Conditional
            /// Type: CloudWatchLoggingConfiguration
            /// </summary>
            public Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration CloudWatchLoggingConfiguration { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds
        {
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-networkconfiguration.html#cfn-emrserverless-application-networkconfiguration-subnetids
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-networkconfiguration.html#cfn-emrserverless-application-networkconfiguration-securitygroupids
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }

        public class PrometheusMonitoringConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RemoteWriteUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-prometheusmonitoringconfiguration.html#cfn-emrserverless-application-prometheusmonitoringconfiguration-remotewriteurl
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic RemoteWriteUrl { get; set; }
        }

        public class S3MonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveEncryptionKeyArn, IHaveLogUri
        {
            /// <summary>
            /// LogUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-s3monitoringconfiguration.html#cfn-emrserverless-application-s3monitoringconfiguration-loguri
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogUri { get; set; }
            /// <summary>
            /// EncryptionKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-s3monitoringconfiguration.html#cfn-emrserverless-application-s3monitoringconfiguration-encryptionkeyarn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionKeyArn { get; set; }
        }

        public class SchedulerConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxConcurrentRuns
        {
            /// <summary>
            /// QueueTimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-schedulerconfiguration.html#cfn-emrserverless-application-schedulerconfiguration-queuetimeoutminutes
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic QueueTimeoutMinutes { get; set; }
            /// <summary>
            /// MaxConcurrentRuns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-schedulerconfiguration.html#cfn-emrserverless-application-schedulerconfiguration-maxconcurrentruns
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxConcurrentRuns { get; set; }
        }

        public class WorkerConfiguration : Humidifier.Base.BaseSubResource, IHaveMemory, IHaveCpu, IHaveDisk
        {
            /// <summary>
            /// DiskType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-workerconfiguration.html#cfn-emrserverless-application-workerconfiguration-disktype
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic DiskType { get; set; }
            /// <summary>
            /// Memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-workerconfiguration.html#cfn-emrserverless-application-workerconfiguration-memory
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic Memory { get; set; }
            /// <summary>
            /// Cpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-workerconfiguration.html#cfn-emrserverless-application-workerconfiguration-cpu
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic Cpu { get; set; }
            /// <summary>
            /// Disk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-application-workerconfiguration.html#cfn-emrserverless-application-workerconfiguration-disk
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic Disk { get; set; }
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
            public Humidifier.EMRServerless.ApplicationTypes.ImageConfigurationInput ImageConfiguration { get; set; }
        }
    }
}