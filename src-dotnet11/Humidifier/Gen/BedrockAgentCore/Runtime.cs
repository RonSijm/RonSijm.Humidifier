namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using RuntimeTypes;

    public class Runtime : Humidifier.Base.BaseResource, IHavePlatformVersion, IHaveDescription, IHaveBedrockAgentCoreRuntimeTypesLifecycleConfigurationLifecycleConfiguration, IHaveBedrockAgentCoreRuntimeTypesAgentRuntimeArtifactAgentRuntimeArtifact, IHaveRoleArn, IHaveProtocolConfiguration, IHaveStringDictionaryOfEnvironmentVariables, IHaveBedrockAgentCoreRuntimeTypesRequestHeaderConfigurationRequestHeaderConfiguration, IHaveListOfBedrockAgentCoreRuntimeTypesFilesystemConfigurationFilesystemConfigurations, IHaveBedrockAgentCoreRuntimeTypesNetworkConfigurationNetworkConfiguration, IHaveAgentRuntimeName, IHaveBedrockAgentCoreRuntimeTypesCapacityProviderConfigurationCapacityProviderConfiguration, IHaveStringDictionaryOfTags, IHaveBedrockAgentCoreRuntimeTypesAuthorizerConfigurationAuthorizerConfiguration
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string AgentRuntimeId =  "AgentRuntimeId" ;
            public static string FailureReason =  "FailureReason" ;
            public static string AgentRuntimeVersion =  "AgentRuntimeVersion" ;
            public static string AgentRuntimeArn =  "AgentRuntimeArn" ;
            public static string WorkloadIdentityDetails =  "WorkloadIdentityDetails" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.Runtime; }
        /// <summary>
        /// PlatformVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-runtime.html#cfn-bedrockagentcore-runtime-platformversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PlatformVersion { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-runtime.html#cfn-bedrockagentcore-runtime-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// LifecycleConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-runtime.html#cfn-bedrockagentcore-runtime-lifecycleconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LifecycleConfiguration
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.RuntimeTypes.LifecycleConfiguration, BaseFunction>? LifecycleConfiguration { get; set; }

        /// <summary>
        /// AgentRuntimeArtifact
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-runtime.html#cfn-bedrockagentcore-runtime-agentruntimeartifact
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AgentRuntimeArtifact
        /// </summary>
        [Required]
        public Union<Humidifier.BedrockAgentCore.RuntimeTypes.AgentRuntimeArtifact, BaseFunction>? AgentRuntimeArtifact { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-runtime.html#cfn-bedrockagentcore-runtime-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// ProtocolConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-runtime.html#cfn-bedrockagentcore-runtime-protocolconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProtocolConfiguration { get; set; }
        /// <summary>
        /// EnvironmentVariables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-runtime.html#cfn-bedrockagentcore-runtime-environmentvariables
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? EnvironmentVariables { get; set; }
        /// <summary>
        /// RequestHeaderConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-runtime.html#cfn-bedrockagentcore-runtime-requestheaderconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RequestHeaderConfiguration
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.RuntimeTypes.RequestHeaderConfiguration, BaseFunction>? RequestHeaderConfiguration { get; set; }
        /// <summary>
        /// FilesystemConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-runtime.html#cfn-bedrockagentcore-runtime-filesystemconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FilesystemConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.RuntimeTypes.FilesystemConfiguration>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.RuntimeTypes.FilesystemConfiguration, BaseFunction>>, BaseFunction>? FilesystemConfigurations { get; set; }
        /// <summary>
        /// NetworkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-runtime.html#cfn-bedrockagentcore-runtime-networkconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NetworkConfiguration
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.RuntimeTypes.NetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }

        /// <summary>
        /// AgentRuntimeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-runtime.html#cfn-bedrockagentcore-runtime-agentruntimename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AgentRuntimeName { get; set; }
        /// <summary>
        /// CapacityProviderConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-runtime.html#cfn-bedrockagentcore-runtime-capacityproviderconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapacityProviderConfiguration
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.RuntimeTypes.CapacityProviderConfiguration, BaseFunction>? CapacityProviderConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-runtime.html#cfn-bedrockagentcore-runtime-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AuthorizerConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-runtime.html#cfn-bedrockagentcore-runtime-authorizerconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AuthorizerConfiguration
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.RuntimeTypes.AuthorizerConfiguration, BaseFunction>? AuthorizerConfiguration { get; set; }
    }

    namespace RuntimeTypes
    {
        public class AgentRuntimeArtifact : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreRuntimeTypesCodeConfigurationCodeConfiguration, IHaveBedrockAgentCoreRuntimeTypesContainerConfigurationContainerConfiguration
        {
            /// <summary>
            /// CodeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-agentruntimeartifact.html#cfn-bedrockagentcore-runtime-agentruntimeartifact-codeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CodeConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.RuntimeTypes.CodeConfiguration, BaseFunction>? CodeConfiguration { get; set; }
            /// <summary>
            /// ContainerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-agentruntimeartifact.html#cfn-bedrockagentcore-runtime-agentruntimeartifact-containerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContainerConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.RuntimeTypes.ContainerConfiguration, BaseFunction>? ContainerConfiguration { get; set; }
        }

        public class AllowedWorkloadConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentCoreRuntimeTypesHostingEnvironmentHostingEnvironments, IHaveStringListOfWorkloadIdentities
        {
            /// <summary>
            /// HostingEnvironments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-allowedworkloadconfiguration.html#cfn-bedrockagentcore-runtime-allowedworkloadconfiguration-hostingenvironments
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HostingEnvironment
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.RuntimeTypes.HostingEnvironment>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.RuntimeTypes.HostingEnvironment, BaseFunction>>, BaseFunction>? HostingEnvironments { get; set; }
            /// <summary>
            /// WorkloadIdentities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-allowedworkloadconfiguration.html#cfn-bedrockagentcore-runtime-allowedworkloadconfiguration-workloadidentities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? WorkloadIdentities { get; set; }
        }

        public class AuthorizerConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreRuntimeTypesCustomJWTAuthorizerConfigurationCustomJWTAuthorizer
        {
            /// <summary>
            /// CustomJWTAuthorizer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-authorizerconfiguration.html#cfn-bedrockagentcore-runtime-authorizerconfiguration-customjwtauthorizer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomJWTAuthorizerConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.RuntimeTypes.CustomJWTAuthorizerConfiguration, BaseFunction>? CustomJWTAuthorizer { get; set; }
        }

        public class AuthorizingClaimMatchValueType : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreRuntimeTypesClaimMatchValueTypeClaimMatchValue, IHaveClaimMatchOperator
        {
            /// <summary>
            /// ClaimMatchValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-authorizingclaimmatchvaluetype.html#cfn-bedrockagentcore-runtime-authorizingclaimmatchvaluetype-claimmatchvalue
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ClaimMatchValueType
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.RuntimeTypes.ClaimMatchValueType, BaseFunction>? ClaimMatchValue { get; set; }
            /// <summary>
            /// ClaimMatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-authorizingclaimmatchvaluetype.html#cfn-bedrockagentcore-runtime-authorizingclaimmatchvaluetype-claimmatchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClaimMatchOperator { get; set; }
        }

        public class CapacityProviderConfiguration : Humidifier.Base.BaseSubResource, IHaveCapacityProviderArn
        {
            /// <summary>
            /// CapacityProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-capacityproviderconfiguration.html#cfn-bedrockagentcore-runtime-capacityproviderconfiguration-capacityproviderarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityProviderArn { get; set; }
        }

        public class CapacityProviderVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveMountPath, IHaveVolumeName
        {
            /// <summary>
            /// MountPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-capacityprovidervolumeconfiguration.html#cfn-bedrockagentcore-runtime-capacityprovidervolumeconfiguration-mountpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MountPath { get; set; }
            /// <summary>
            /// VolumeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-capacityprovidervolumeconfiguration.html#cfn-bedrockagentcore-runtime-capacityprovidervolumeconfiguration-volumename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeName { get; set; }
        }

        public class ClaimMatchValueType : Humidifier.Base.BaseSubResource, IHaveMatchValueString, IHaveStringListOfMatchValueStringList
        {
            /// <summary>
            /// MatchValueString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-claimmatchvaluetype.html#cfn-bedrockagentcore-runtime-claimmatchvaluetype-matchvaluestring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchValueString { get; set; }
            /// <summary>
            /// MatchValueStringList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-claimmatchvaluetype.html#cfn-bedrockagentcore-runtime-claimmatchvaluetype-matchvaluestringlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchValueStringList { get; set; }
        }

        public class Code : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreRuntimeTypesS3LocationS3
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-code.html#cfn-bedrockagentcore-runtime-code-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location, BaseFunction>? S3 { get; set; }
        }

        public class CodeConfiguration : Humidifier.Base.BaseSubResource, IHaveRuntime, IHaveStringListOfEntryPoint, IHaveBedrockAgentCoreRuntimeTypesCodeCode
        {
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-codeconfiguration.html#cfn-bedrockagentcore-runtime-codeconfiguration-runtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Runtime { get; set; }
            /// <summary>
            /// EntryPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-codeconfiguration.html#cfn-bedrockagentcore-runtime-codeconfiguration-entrypoint
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EntryPoint { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-codeconfiguration.html#cfn-bedrockagentcore-runtime-codeconfiguration-code
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Code
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.RuntimeTypes.Code, BaseFunction>? Code { get; set; }
        }

        public class ContainerConfiguration : Humidifier.Base.BaseSubResource, IHaveContainerUri
        {
            /// <summary>
            /// ContainerUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-containerconfiguration.html#cfn-bedrockagentcore-runtime-containerconfiguration-containeruri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerUri { get; set; }
        }

        public class CustomClaimValidationType : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreRuntimeTypesAuthorizingClaimMatchValueTypeAuthorizingClaimMatchValue, IHaveInboundTokenClaimName, IHaveInboundTokenClaimValueType
        {
            /// <summary>
            /// AuthorizingClaimMatchValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-customclaimvalidationtype.html#cfn-bedrockagentcore-runtime-customclaimvalidationtype-authorizingclaimmatchvalue
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AuthorizingClaimMatchValueType
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.RuntimeTypes.AuthorizingClaimMatchValueType, BaseFunction>? AuthorizingClaimMatchValue { get; set; }
            /// <summary>
            /// InboundTokenClaimName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-customclaimvalidationtype.html#cfn-bedrockagentcore-runtime-customclaimvalidationtype-inboundtokenclaimname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InboundTokenClaimName { get; set; }
            /// <summary>
            /// InboundTokenClaimValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-customclaimvalidationtype.html#cfn-bedrockagentcore-runtime-customclaimvalidationtype-inboundtokenclaimvaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InboundTokenClaimValueType { get; set; }
        }

        public class CustomJWTAuthorizerConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentCoreRuntimeTypesPrivateEndpointOverridePrivateEndpointOverrides, IHaveDiscoveryUrl, IHaveStringListOfAllowedAudience, IHaveBedrockAgentCoreRuntimeTypesAllowedWorkloadConfigurationAllowedWorkloadConfiguration, IHaveListOfBedrockAgentCoreRuntimeTypesCustomClaimValidationTypeCustomClaims, IHaveBedrockAgentCoreRuntimeTypesPrivateEndpointPrivateEndpoint, IHaveStringListOfAllowedClients, IHaveStringListOfAllowedScopes
        {
            /// <summary>
            /// PrivateEndpointOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-runtime-customjwtauthorizerconfiguration-privateendpointoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PrivateEndpointOverride
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.RuntimeTypes.PrivateEndpointOverride>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.RuntimeTypes.PrivateEndpointOverride, BaseFunction>>, BaseFunction>? PrivateEndpointOverrides { get; set; }
            /// <summary>
            /// DiscoveryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-runtime-customjwtauthorizerconfiguration-discoveryurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DiscoveryUrl { get; set; }
            /// <summary>
            /// AllowedAudience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-runtime-customjwtauthorizerconfiguration-allowedaudience
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedAudience { get; set; }
            /// <summary>
            /// AllowedWorkloadConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-runtime-customjwtauthorizerconfiguration-allowedworkloadconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AllowedWorkloadConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.RuntimeTypes.AllowedWorkloadConfiguration, BaseFunction>? AllowedWorkloadConfiguration { get; set; }
            /// <summary>
            /// CustomClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-runtime-customjwtauthorizerconfiguration-customclaims
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomClaimValidationType
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.RuntimeTypes.CustomClaimValidationType>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.RuntimeTypes.CustomClaimValidationType, BaseFunction>>, BaseFunction>? CustomClaims { get; set; }
            /// <summary>
            /// PrivateEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-runtime-customjwtauthorizerconfiguration-privateendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrivateEndpoint
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.RuntimeTypes.PrivateEndpoint, BaseFunction>? PrivateEndpoint { get; set; }
            /// <summary>
            /// AllowedClients
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-runtime-customjwtauthorizerconfiguration-allowedclients
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedClients { get; set; }
            /// <summary>
            /// AllowedScopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-runtime-customjwtauthorizerconfiguration-allowedscopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedScopes { get; set; }
        }

        public class EfsAccessPointConfiguration : Humidifier.Base.BaseSubResource, IHaveMountPath, IHaveAccessPointArn
        {
            /// <summary>
            /// MountPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-efsaccesspointconfiguration.html#cfn-bedrockagentcore-runtime-efsaccesspointconfiguration-mountpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MountPath { get; set; }
            /// <summary>
            /// AccessPointArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-efsaccesspointconfiguration.html#cfn-bedrockagentcore-runtime-efsaccesspointconfiguration-accesspointarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessPointArn { get; set; }
        }

        public class FilesystemConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreRuntimeTypesCapacityProviderVolumeConfigurationCapacityProviderVolume, IHaveBedrockAgentCoreRuntimeTypesS3FilesAccessPointConfigurationS3FilesAccessPoint, IHaveBedrockAgentCoreRuntimeTypesSessionStorageConfigurationSessionStorage, IHaveBedrockAgentCoreRuntimeTypesEfsAccessPointConfigurationEfsAccessPoint
        {
            /// <summary>
            /// CapacityProviderVolume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-filesystemconfiguration.html#cfn-bedrockagentcore-runtime-filesystemconfiguration-capacityprovidervolume
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacityProviderVolumeConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.RuntimeTypes.CapacityProviderVolumeConfiguration, BaseFunction>? CapacityProviderVolume { get; set; }
            /// <summary>
            /// S3FilesAccessPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-filesystemconfiguration.html#cfn-bedrockagentcore-runtime-filesystemconfiguration-s3filesaccesspoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3FilesAccessPointConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.RuntimeTypes.S3FilesAccessPointConfiguration, BaseFunction>? S3FilesAccessPoint { get; set; }
            /// <summary>
            /// SessionStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-filesystemconfiguration.html#cfn-bedrockagentcore-runtime-filesystemconfiguration-sessionstorage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SessionStorageConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.RuntimeTypes.SessionStorageConfiguration, BaseFunction>? SessionStorage { get; set; }
            /// <summary>
            /// EfsAccessPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-filesystemconfiguration.html#cfn-bedrockagentcore-runtime-filesystemconfiguration-efsaccesspoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EfsAccessPointConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.RuntimeTypes.EfsAccessPointConfiguration, BaseFunction>? EfsAccessPoint { get; set; }
        }

        public class HostingEnvironment : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-hostingenvironment.html#cfn-bedrockagentcore-runtime-hostingenvironment-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class LifecycleConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxLifetime_Integer, IHaveIdleRuntimeSessionTimeout_Integer
        {
            /// <summary>
            /// MaxLifetime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-lifecycleconfiguration.html#cfn-bedrockagentcore-runtime-lifecycleconfiguration-maxlifetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxLifetime { get; set; }
            /// <summary>
            /// IdleRuntimeSessionTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-lifecycleconfiguration.html#cfn-bedrockagentcore-runtime-lifecycleconfiguration-idleruntimesessiontimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IdleRuntimeSessionTimeout { get; set; }
        }

        public class ManagedVpcResource : Humidifier.Base.BaseSubResource, IHaveRoutingDomain, IHaveVpcIdentifier, IHaveStringListOfSubnetIds, IHaveEndpointIpAddressType, IHaveStringListOfSecurityGroupIds, IHaveStringDictionaryOfTags
        {
            /// <summary>
            /// RoutingDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-managedvpcresource.html#cfn-bedrockagentcore-runtime-managedvpcresource-routingdomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoutingDomain { get; set; }
            /// <summary>
            /// VpcIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-managedvpcresource.html#cfn-bedrockagentcore-runtime-managedvpcresource-vpcidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcIdentifier { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-managedvpcresource.html#cfn-bedrockagentcore-runtime-managedvpcresource-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// EndpointIpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-managedvpcresource.html#cfn-bedrockagentcore-runtime-managedvpcresource-endpointipaddresstype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointIpAddressType { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-managedvpcresource.html#cfn-bedrockagentcore-runtime-managedvpcresource-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-managedvpcresource.html#cfn-bedrockagentcore-runtime-managedvpcresource-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreRuntimeTypesVpcConfigNetworkModeConfig, IHaveNetworkMode
        {
            /// <summary>
            /// NetworkModeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-networkconfiguration.html#cfn-bedrockagentcore-runtime-networkconfiguration-networkmodeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig, BaseFunction>? NetworkModeConfig { get; set; }
            /// <summary>
            /// NetworkMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-networkconfiguration.html#cfn-bedrockagentcore-runtime-networkconfiguration-networkmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkMode { get; set; }
        }

        public class PrivateEndpoint : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreRuntimeTypesSelfManagedLatticeResourceSelfManagedLatticeResource, IHaveBedrockAgentCoreRuntimeTypesManagedVpcResourceManagedVpcResource
        {
            /// <summary>
            /// SelfManagedLatticeResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-privateendpoint.html#cfn-bedrockagentcore-runtime-privateendpoint-selfmanagedlatticeresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelfManagedLatticeResource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.RuntimeTypes.SelfManagedLatticeResource, BaseFunction>? SelfManagedLatticeResource { get; set; }
            /// <summary>
            /// ManagedVpcResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-privateendpoint.html#cfn-bedrockagentcore-runtime-privateendpoint-managedvpcresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedVpcResource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.RuntimeTypes.ManagedVpcResource, BaseFunction>? ManagedVpcResource { get; set; }
        }

        public class PrivateEndpointOverride : Humidifier.Base.BaseSubResource, IHaveDomain, IHaveBedrockAgentCoreRuntimeTypesPrivateEndpointPrivateEndpoint
        {
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-privateendpointoverride.html#cfn-bedrockagentcore-runtime-privateendpointoverride-domain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Domain { get; set; }
            /// <summary>
            /// PrivateEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-privateendpointoverride.html#cfn-bedrockagentcore-runtime-privateendpointoverride-privateendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrivateEndpoint
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.RuntimeTypes.PrivateEndpoint, BaseFunction>? PrivateEndpoint { get; set; }
        }

        public class RequestHeaderConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfRequestHeaderAllowlist
        {
            /// <summary>
            /// RequestHeaderAllowlist
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-requestheaderconfiguration.html#cfn-bedrockagentcore-runtime-requestheaderconfiguration-requestheaderallowlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RequestHeaderAllowlist { get; set; }
        }

        public class S3FilesAccessPointConfiguration : Humidifier.Base.BaseSubResource, IHaveMountPath, IHaveAccessPointArn
        {
            /// <summary>
            /// MountPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-s3filesaccesspointconfiguration.html#cfn-bedrockagentcore-runtime-s3filesaccesspointconfiguration-mountpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MountPath { get; set; }
            /// <summary>
            /// AccessPointArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-s3filesaccesspointconfiguration.html#cfn-bedrockagentcore-runtime-s3filesaccesspointconfiguration-accesspointarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessPointArn { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveVersionId, IHaveBucket, IHavePrefix
        {
            /// <summary>
            /// VersionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-s3location.html#cfn-bedrockagentcore-runtime-s3location-versionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VersionId { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-s3location.html#cfn-bedrockagentcore-runtime-s3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-s3location.html#cfn-bedrockagentcore-runtime-s3location-prefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class SelfManagedLatticeResource : Humidifier.Base.BaseSubResource, IHaveResourceConfigurationIdentifier
        {
            /// <summary>
            /// ResourceConfigurationIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-selfmanagedlatticeresource.html#cfn-bedrockagentcore-runtime-selfmanagedlatticeresource-resourceconfigurationidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceConfigurationIdentifier { get; set; }
        }

        public class SessionStorageConfiguration : Humidifier.Base.BaseSubResource, IHaveMountPath
        {
            /// <summary>
            /// MountPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-sessionstorageconfiguration.html#cfn-bedrockagentcore-runtime-sessionstorageconfiguration-mountpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MountPath { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveStringListOfSubnets
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-vpcconfig.html#cfn-bedrockagentcore-runtime-vpcconfig-securitygroups
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-vpcconfig.html#cfn-bedrockagentcore-runtime-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
        }

        public class WorkloadIdentityDetails : Humidifier.Base.BaseSubResource, IHaveWorkloadIdentityArn
        {
            /// <summary>
            /// WorkloadIdentityArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-runtime-workloadidentitydetails.html#cfn-bedrockagentcore-runtime-workloadidentitydetails-workloadidentityarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkloadIdentityArn { get; set; }
        }
    }
}