namespace Humidifier.AppRunner
{
    using global::System.Collections.Generic;
    using ServiceTypes;

    public class Service : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAppRunnerServiceTypesHealthCheckConfigurationHealthCheckConfiguration, IHaveAppRunnerServiceTypesInstanceConfigurationInstanceConfiguration, IHaveAppRunnerServiceTypesEncryptionConfigurationEncryptionConfiguration, IHaveServiceName, IHaveAppRunnerServiceTypesServiceObservabilityConfigurationObservabilityConfiguration, IHaveAppRunnerServiceTypesSourceConfigurationSourceConfiguration, IHaveAutoScalingConfigurationArn, IHaveAppRunnerServiceTypesNetworkConfigurationNetworkConfiguration
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ServiceUrl =  "ServiceUrl" ;
            public static string ServiceArn =  "ServiceArn" ;
            public static string ServiceId =  "ServiceId" ;
        }

        public override string AWSTypeName { get => AWS.AppRunner.Service; }
        /// <summary>
        /// HealthCheckConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-service.html#cfn-apprunner-service-healthcheckconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HealthCheckConfiguration
        /// </summary>
        public Union<Humidifier.AppRunner.ServiceTypes.HealthCheckConfiguration, BaseFunction>? HealthCheckConfiguration { get; set; }
        /// <summary>
        /// InstanceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-service.html#cfn-apprunner-service-instanceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InstanceConfiguration
        /// </summary>
        public Union<Humidifier.AppRunner.ServiceTypes.InstanceConfiguration, BaseFunction>? InstanceConfiguration { get; set; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-service.html#cfn-apprunner-service-encryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Union<Humidifier.AppRunner.ServiceTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        public Union<string, BaseFunction>? ServiceName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ObservabilityConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-service.html#cfn-apprunner-service-observabilityconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ServiceObservabilityConfiguration
        /// </summary>
        public Union<Humidifier.AppRunner.ServiceTypes.ServiceObservabilityConfiguration, BaseFunction>? ObservabilityConfiguration { get; set; }

        /// <summary>
        /// SourceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-service.html#cfn-apprunner-service-sourceconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: SourceConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.AppRunner.ServiceTypes.SourceConfiguration, BaseFunction>? SourceConfiguration { get; set; }
        /// <summary>
        /// AutoScalingConfigurationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-service.html#cfn-apprunner-service-autoscalingconfigurationarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AutoScalingConfigurationArn { get; set; }
        /// <summary>
        /// NetworkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-service.html#cfn-apprunner-service-networkconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NetworkConfiguration
        /// </summary>
        public Union<Humidifier.AppRunner.ServiceTypes.NetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-service.html#cfn-apprunner-service-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ServiceTypes
    {
        public class AuthenticationConfiguration : Humidifier.Base.BaseSubResource, IHaveAccessRoleArn, IHaveConnectionArn
        {
            /// <summary>
            /// AccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-authenticationconfiguration.html#cfn-apprunner-service-authenticationconfiguration-accessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessRoleArn { get; set; }
            /// <summary>
            /// ConnectionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-authenticationconfiguration.html#cfn-apprunner-service-authenticationconfiguration-connectionarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionArn { get; set; }
        }

        public class CodeConfiguration : Humidifier.Base.BaseSubResource, IHaveConfigurationSource, IHaveAppRunnerServiceTypesCodeConfigurationValuesCodeConfigurationValues
        {
            /// <summary>
            /// ConfigurationSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-codeconfiguration.html#cfn-apprunner-service-codeconfiguration-configurationsource
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfigurationSource { get; set; }
            /// <summary>
            /// CodeConfigurationValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-codeconfiguration.html#cfn-apprunner-service-codeconfiguration-codeconfigurationvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CodeConfigurationValues
            /// </summary>
            public Union<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues, BaseFunction>? CodeConfigurationValues { get; set; }
        }

        public class CodeConfigurationValues : Humidifier.Base.BaseSubResource, IHaveListOfAppRunnerServiceTypesKeyValuePairRuntimeEnvironmentSecrets, IHaveRuntime, IHaveStartCommand, IHaveListOfAppRunnerServiceTypesKeyValuePairRuntimeEnvironmentVariables, IHavePort, IHaveBuildCommand
        {
            /// <summary>
            /// RuntimeEnvironmentSecrets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-codeconfigurationvalues.html#cfn-apprunner-service-codeconfigurationvalues-runtimeenvironmentsecrets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValuePair
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppRunner.ServiceTypes.KeyValuePair>, IReadOnlyList<Union<Humidifier.AppRunner.ServiceTypes.KeyValuePair, BaseFunction>>, BaseFunction>? RuntimeEnvironmentSecrets { get; set; }
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-codeconfigurationvalues.html#cfn-apprunner-service-codeconfigurationvalues-runtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Runtime { get; set; }
            /// <summary>
            /// StartCommand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-codeconfigurationvalues.html#cfn-apprunner-service-codeconfigurationvalues-startcommand
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartCommand { get; set; }
            /// <summary>
            /// RuntimeEnvironmentVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-codeconfigurationvalues.html#cfn-apprunner-service-codeconfigurationvalues-runtimeenvironmentvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValuePair
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppRunner.ServiceTypes.KeyValuePair>, IReadOnlyList<Union<Humidifier.AppRunner.ServiceTypes.KeyValuePair, BaseFunction>>, BaseFunction>? RuntimeEnvironmentVariables { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-codeconfigurationvalues.html#cfn-apprunner-service-codeconfigurationvalues-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Port { get; set; }
            /// <summary>
            /// BuildCommand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-codeconfigurationvalues.html#cfn-apprunner-service-codeconfigurationvalues-buildcommand
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BuildCommand { get; set; }
        }

        public class CodeRepository : Humidifier.Base.BaseSubResource, IHaveAppRunnerServiceTypesSourceCodeVersionSourceCodeVersion, IHaveAppRunnerServiceTypesCodeConfigurationCodeConfiguration, IHaveSourceDirectory, IHaveRepositoryUrl
        {
            /// <summary>
            /// SourceCodeVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-coderepository.html#cfn-apprunner-service-coderepository-sourcecodeversion
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SourceCodeVersion
            /// </summary>
            public Union<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion, BaseFunction>? SourceCodeVersion { get; set; }
            /// <summary>
            /// CodeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-coderepository.html#cfn-apprunner-service-coderepository-codeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CodeConfiguration
            /// </summary>
            public Union<Humidifier.AppRunner.ServiceTypes.CodeConfiguration, BaseFunction>? CodeConfiguration { get; set; }
            /// <summary>
            /// SourceDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-coderepository.html#cfn-apprunner-service-coderepository-sourcedirectory
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceDirectory { get; set; }
            /// <summary>
            /// RepositoryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-coderepository.html#cfn-apprunner-service-coderepository-repositoryurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RepositoryUrl { get; set; }
        }

        public class EgressConfiguration : Humidifier.Base.BaseSubResource, IHaveVpcConnectorArn, IHaveEgressType
        {
            /// <summary>
            /// VpcConnectorArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-egressconfiguration.html#cfn-apprunner-service-egressconfiguration-vpcconnectorarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcConnectorArn { get; set; }
            /// <summary>
            /// EgressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-egressconfiguration.html#cfn-apprunner-service-egressconfiguration-egresstype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EgressType { get; set; }
        }

        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKey
        {
            /// <summary>
            /// KmsKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-encryptionconfiguration.html#cfn-apprunner-service-encryptionconfiguration-kmskey
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKey { get; set; }
        }

        public class HealthCheckConfiguration : Humidifier.Base.BaseSubResource, IHavePath, IHaveUnhealthyThreshold_Integer, IHaveTimeout_Integer, IHaveHealthyThreshold_Integer, IHaveProtocol, IHaveInterval_Integer
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-healthcheckconfiguration.html#cfn-apprunner-service-healthcheckconfiguration-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// UnhealthyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-healthcheckconfiguration.html#cfn-apprunner-service-healthcheckconfiguration-unhealthythreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UnhealthyThreshold { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-healthcheckconfiguration.html#cfn-apprunner-service-healthcheckconfiguration-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Timeout { get; set; }
            /// <summary>
            /// HealthyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-healthcheckconfiguration.html#cfn-apprunner-service-healthcheckconfiguration-healthythreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HealthyThreshold { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-healthcheckconfiguration.html#cfn-apprunner-service-healthcheckconfiguration-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-healthcheckconfiguration.html#cfn-apprunner-service-healthcheckconfiguration-interval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Interval { get; set; }
        }

        public class ImageConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfAppRunnerServiceTypesKeyValuePairRuntimeEnvironmentSecrets, IHaveStartCommand, IHaveListOfAppRunnerServiceTypesKeyValuePairRuntimeEnvironmentVariables, IHavePort
        {
            /// <summary>
            /// RuntimeEnvironmentSecrets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-imageconfiguration.html#cfn-apprunner-service-imageconfiguration-runtimeenvironmentsecrets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValuePair
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppRunner.ServiceTypes.KeyValuePair>, IReadOnlyList<Union<Humidifier.AppRunner.ServiceTypes.KeyValuePair, BaseFunction>>, BaseFunction>? RuntimeEnvironmentSecrets { get; set; }
            /// <summary>
            /// StartCommand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-imageconfiguration.html#cfn-apprunner-service-imageconfiguration-startcommand
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartCommand { get; set; }
            /// <summary>
            /// RuntimeEnvironmentVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-imageconfiguration.html#cfn-apprunner-service-imageconfiguration-runtimeenvironmentvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValuePair
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppRunner.ServiceTypes.KeyValuePair>, IReadOnlyList<Union<Humidifier.AppRunner.ServiceTypes.KeyValuePair, BaseFunction>>, BaseFunction>? RuntimeEnvironmentVariables { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-imageconfiguration.html#cfn-apprunner-service-imageconfiguration-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Port { get; set; }
        }

        public class ImageRepository : Humidifier.Base.BaseSubResource, IHaveImageIdentifier, IHaveAppRunnerServiceTypesImageConfigurationImageConfiguration, IHaveImageRepositoryType
        {
            /// <summary>
            /// ImageIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-imagerepository.html#cfn-apprunner-service-imagerepository-imageidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageIdentifier { get; set; }
            /// <summary>
            /// ImageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-imagerepository.html#cfn-apprunner-service-imagerepository-imageconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageConfiguration
            /// </summary>
            public Union<Humidifier.AppRunner.ServiceTypes.ImageConfiguration, BaseFunction>? ImageConfiguration { get; set; }
            /// <summary>
            /// ImageRepositoryType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-imagerepository.html#cfn-apprunner-service-imagerepository-imagerepositorytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageRepositoryType { get; set; }
        }

        public class IngressConfiguration : Humidifier.Base.BaseSubResource, IHaveIsPubliclyAccessible_Boolean
        {
            /// <summary>
            /// IsPubliclyAccessible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-ingressconfiguration.html#cfn-apprunner-service-ingressconfiguration-ispubliclyaccessible
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsPubliclyAccessible { get; set; }
        }

        public class InstanceConfiguration : Humidifier.Base.BaseSubResource, IHaveInstanceRoleArn, IHaveMemory, IHaveCpu
        {
            /// <summary>
            /// InstanceRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-instanceconfiguration.html#cfn-apprunner-service-instanceconfiguration-instancerolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceRoleArn { get; set; }
            /// <summary>
            /// Memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-instanceconfiguration.html#cfn-apprunner-service-instanceconfiguration-memory
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Memory { get; set; }
            /// <summary>
            /// Cpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-instanceconfiguration.html#cfn-apprunner-service-instanceconfiguration-cpu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cpu { get; set; }
        }

        public class KeyValuePair : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-keyvaluepair.html#cfn-apprunner-service-keyvaluepair-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-keyvaluepair.html#cfn-apprunner-service-keyvaluepair-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveIpAddressType, IHaveAppRunnerServiceTypesEgressConfigurationEgressConfiguration, IHaveAppRunnerServiceTypesIngressConfigurationIngressConfiguration
        {
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-networkconfiguration.html#cfn-apprunner-service-networkconfiguration-ipaddresstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddressType { get; set; }
            /// <summary>
            /// EgressConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-networkconfiguration.html#cfn-apprunner-service-networkconfiguration-egressconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EgressConfiguration
            /// </summary>
            public Union<Humidifier.AppRunner.ServiceTypes.EgressConfiguration, BaseFunction>? EgressConfiguration { get; set; }
            /// <summary>
            /// IngressConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-networkconfiguration.html#cfn-apprunner-service-networkconfiguration-ingressconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IngressConfiguration
            /// </summary>
            public Union<Humidifier.AppRunner.ServiceTypes.IngressConfiguration, BaseFunction>? IngressConfiguration { get; set; }
        }

        public class ServiceObservabilityConfiguration : Humidifier.Base.BaseSubResource, IHaveObservabilityEnabled_Boolean, IHaveObservabilityConfigurationArn
        {
            /// <summary>
            /// ObservabilityEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-serviceobservabilityconfiguration.html#cfn-apprunner-service-serviceobservabilityconfiguration-observabilityenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ObservabilityEnabled { get; set; }
            /// <summary>
            /// ObservabilityConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-serviceobservabilityconfiguration.html#cfn-apprunner-service-serviceobservabilityconfiguration-observabilityconfigurationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObservabilityConfigurationArn { get; set; }
        }

        public class SourceCodeVersion : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-sourcecodeversion.html#cfn-apprunner-service-sourcecodeversion-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-sourcecodeversion.html#cfn-apprunner-service-sourcecodeversion-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class SourceConfiguration : Humidifier.Base.BaseSubResource, IHaveAppRunnerServiceTypesAuthenticationConfigurationAuthenticationConfiguration, IHaveAppRunnerServiceTypesCodeRepositoryCodeRepository, IHaveAppRunnerServiceTypesImageRepositoryImageRepository, IHaveAutoDeploymentsEnabled_Boolean
        {
            /// <summary>
            /// AuthenticationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-sourceconfiguration.html#cfn-apprunner-service-sourceconfiguration-authenticationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthenticationConfiguration
            /// </summary>
            public Union<Humidifier.AppRunner.ServiceTypes.AuthenticationConfiguration, BaseFunction>? AuthenticationConfiguration { get; set; }
            /// <summary>
            /// CodeRepository
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-sourceconfiguration.html#cfn-apprunner-service-sourceconfiguration-coderepository
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CodeRepository
            /// </summary>
            public Union<Humidifier.AppRunner.ServiceTypes.CodeRepository, BaseFunction>? CodeRepository { get; set; }
            /// <summary>
            /// ImageRepository
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-sourceconfiguration.html#cfn-apprunner-service-sourceconfiguration-imagerepository
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageRepository
            /// </summary>
            public Union<Humidifier.AppRunner.ServiceTypes.ImageRepository, BaseFunction>? ImageRepository { get; set; }
            /// <summary>
            /// AutoDeploymentsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-sourceconfiguration.html#cfn-apprunner-service-sourceconfiguration-autodeploymentsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutoDeploymentsEnabled { get; set; }
        }
    }
}