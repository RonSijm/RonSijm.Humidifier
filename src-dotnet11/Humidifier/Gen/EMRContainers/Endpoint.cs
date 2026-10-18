namespace Humidifier.EMRContainers
{
    using global::System.Collections.Generic;
    using EndpointTypes;

    public class Endpoint : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSessionIdleTimeoutInMinutes_Integer, IHaveExecutionRoleArn, IHaveType, IHaveEMRContainersEndpointTypesConfigurationOverridesConfigurationOverrides, IHaveVirtualClusterId, IHaveReleaseLabel, IHaveName
    {
        public class Attributes
        {
            public static string ServerUrl =  "ServerUrl" ;
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string FailureReason =  "FailureReason" ;
            public static string StateDetails =  "StateDetails" ;
            public static string CertificateAuthority =  "CertificateAuthority" ;
            public static string Id =  "Id" ;
            public static string SecurityGroup =  "SecurityGroup" ;
            public static string Arn =  "Arn" ;
            public static string AuthProxyUrl =  "AuthProxyUrl" ;
        }

        public override string AWSTypeName { get => AWS.EMRContainers.Endpoint; }
        /// <summary>
        /// SessionIdleTimeoutInMinutes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-endpoint.html#cfn-emrcontainers-endpoint-sessionidletimeoutinminutes
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? SessionIdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-endpoint.html#cfn-emrcontainers-endpoint-executionrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-endpoint.html#cfn-emrcontainers-endpoint-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// ConfigurationOverrides
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-endpoint.html#cfn-emrcontainers-endpoint-configurationoverrides
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ConfigurationOverrides
        /// </summary>
        public Union<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides, BaseFunction>? ConfigurationOverrides { get; set; }

        /// <summary>
        /// VirtualClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-endpoint.html#cfn-emrcontainers-endpoint-virtualclusterid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VirtualClusterId { get; set; }

        /// <summary>
        /// ReleaseLabel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-endpoint.html#cfn-emrcontainers-endpoint-releaselabel
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ReleaseLabel { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-endpoint.html#cfn-emrcontainers-endpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace EndpointTypes
    {
        public class Certificate : Humidifier.Base.BaseSubResource, IHaveCertificateData, IHaveCertificateArn
        {
            /// <summary>
            /// CertificateData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-endpoint-certificate.html#cfn-emrcontainers-endpoint-certificate-certificatedata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateData { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-endpoint-certificate.html#cfn-emrcontainers-endpoint-certificate-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class CloudWatchMonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveLogStreamNamePrefix, IHaveLogGroupName
        {
            /// <summary>
            /// LogStreamNamePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-endpoint-cloudwatchmonitoringconfiguration.html#cfn-emrcontainers-endpoint-cloudwatchmonitoringconfiguration-logstreamnameprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogStreamNamePrefix { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-endpoint-cloudwatchmonitoringconfiguration.html#cfn-emrcontainers-endpoint-cloudwatchmonitoringconfiguration-loggroupname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupName { get; set; }
        }

        public class ConfigurationOverrides : Humidifier.Base.BaseSubResource, IHaveEMRContainersEndpointTypesMonitoringConfigurationMonitoringConfiguration, IHaveListOfEMRContainersEndpointTypesEMREKSConfigurationApplicationConfiguration
        {
            /// <summary>
            /// MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-endpoint-configurationoverrides.html#cfn-emrcontainers-endpoint-configurationoverrides-monitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MonitoringConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.EndpointTypes.MonitoringConfiguration, BaseFunction>? MonitoringConfiguration { get; set; }
            /// <summary>
            /// ApplicationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-endpoint-configurationoverrides.html#cfn-emrcontainers-endpoint-configurationoverrides-applicationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: EMREKSConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMRContainers.EndpointTypes.EMREKSConfiguration>, IReadOnlyList<Union<Humidifier.EMRContainers.EndpointTypes.EMREKSConfiguration, BaseFunction>>, BaseFunction>? ApplicationConfiguration { get; set; }
        }

        public class ContainerLogRotationConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxFilesToKeep_Integer, IHaveRotationSize
        {
            /// <summary>
            /// MaxFilesToKeep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-endpoint-containerlogrotationconfiguration.html#cfn-emrcontainers-endpoint-containerlogrotationconfiguration-maxfilestokeep
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxFilesToKeep { get; set; }
            /// <summary>
            /// RotationSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-endpoint-containerlogrotationconfiguration.html#cfn-emrcontainers-endpoint-containerlogrotationconfiguration-rotationsize
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RotationSize { get; set; }
        }

        public class EMREKSConfiguration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfProperties, IHaveListOfEMRContainersEndpointTypesEMREKSConfigurationConfigurations, IHaveClassification
        {
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-endpoint-emreksconfiguration.html#cfn-emrcontainers-endpoint-emreksconfiguration-properties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Properties { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-endpoint-emreksconfiguration.html#cfn-emrcontainers-endpoint-emreksconfiguration-configurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: EMREKSConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMRContainers.EndpointTypes.EMREKSConfiguration>, IReadOnlyList<Union<Humidifier.EMRContainers.EndpointTypes.EMREKSConfiguration, BaseFunction>>, BaseFunction>? Configurations { get; set; }
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-endpoint-emreksconfiguration.html#cfn-emrcontainers-endpoint-emreksconfiguration-classification
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Classification { get; set; }
        }

        public class MonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveEMRContainersEndpointTypesS3MonitoringConfigurationS3MonitoringConfiguration, IHaveEMRContainersEndpointTypesContainerLogRotationConfigurationContainerLogRotationConfiguration, IHaveEMRContainersEndpointTypesCloudWatchMonitoringConfigurationCloudWatchMonitoringConfiguration, IHavePersistentAppUI
        {
            /// <summary>
            /// S3MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-endpoint-monitoringconfiguration.html#cfn-emrcontainers-endpoint-monitoringconfiguration-s3monitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3MonitoringConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.EndpointTypes.S3MonitoringConfiguration, BaseFunction>? S3MonitoringConfiguration { get; set; }
            /// <summary>
            /// ContainerLogRotationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-endpoint-monitoringconfiguration.html#cfn-emrcontainers-endpoint-monitoringconfiguration-containerlogrotationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ContainerLogRotationConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.EndpointTypes.ContainerLogRotationConfiguration, BaseFunction>? ContainerLogRotationConfiguration { get; set; }
            /// <summary>
            /// CloudWatchMonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-endpoint-monitoringconfiguration.html#cfn-emrcontainers-endpoint-monitoringconfiguration-cloudwatchmonitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CloudWatchMonitoringConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.EndpointTypes.CloudWatchMonitoringConfiguration, BaseFunction>? CloudWatchMonitoringConfiguration { get; set; }
            /// <summary>
            /// PersistentAppUI
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-endpoint-monitoringconfiguration.html#cfn-emrcontainers-endpoint-monitoringconfiguration-persistentappui
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PersistentAppUI { get; set; }
        }

        public class S3MonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveLogUri
        {
            /// <summary>
            /// LogUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-endpoint-s3monitoringconfiguration.html#cfn-emrcontainers-endpoint-s3monitoringconfiguration-loguri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogUri { get; set; }
        }
    }
}