namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using HarnessTypes;

    public class Harness : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStringListOfAllowedTools, IHaveBedrockAgentCoreHarnessTypesHarnessMemoryConfigurationMemory, IHaveMaxTokens_Integer, IHaveListOfBedrockAgentCoreHarnessTypesHarnessToolTools, IHaveMaxIterations_Integer, IHaveBedrockAgentCoreHarnessTypesHarnessTruncationConfigurationTruncation, IHaveTimeoutSeconds_Integer, IHaveExecutionRoleArn, IHaveStringDictionaryOfEnvironmentVariables, IHaveListOfBedrockAgentCoreHarnessTypesHarnessSkillSkills, IHaveHarnessName, IHaveBedrockAgentCoreHarnessTypesHarnessEnvironmentArtifactEnvironmentArtifact, IHaveBedrockAgentCoreHarnessTypesHarnessModelConfigurationModel, IHaveBedrockAgentCoreHarnessTypesHarnessEnvironmentProviderEnvironment, IHaveListOfBedrockAgentCoreHarnessTypesHarnessHookHooks, IHaveListOfBedrockAgentCoreHarnessTypesHarnessSystemContentBlockSystemPrompt, IHaveBedrockAgentCoreHarnessTypesAuthorizerConfigurationAuthorizerConfiguration
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Version =  "Version" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string HarnessId =  "HarnessId" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.Harness; }
        /// <summary>
        /// AllowedTools
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-allowedtools
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedTools { get; set; }
        /// <summary>
        /// Memory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-memory
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HarnessMemoryConfiguration
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessMemoryConfiguration, BaseFunction>? Memory { get; set; }
        /// <summary>
        /// MaxTokens
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-maxtokens
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxTokens { get; set; }
        /// <summary>
        /// Tools
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-tools
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HarnessTool
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTool>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTool, BaseFunction>>, BaseFunction>? Tools { get; set; }
        /// <summary>
        /// MaxIterations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-maxiterations
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxIterations { get; set; }
        /// <summary>
        /// Truncation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-truncation
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HarnessTruncationConfiguration
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationConfiguration, BaseFunction>? Truncation { get; set; }
        /// <summary>
        /// TimeoutSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-timeoutseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? TimeoutSeconds { get; set; }

        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-executionrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
        /// <summary>
        /// EnvironmentVariables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-environmentvariables
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? EnvironmentVariables { get; set; }
        /// <summary>
        /// Skills
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-skills
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HarnessSkill
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkill>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkill, BaseFunction>>, BaseFunction>? Skills { get; set; }
        public Union<string, BaseFunction>? HarnessName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// EnvironmentArtifact
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-environmentartifact
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HarnessEnvironmentArtifact
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessEnvironmentArtifact, BaseFunction>? EnvironmentArtifact { get; set; }

        /// <summary>
        /// Model
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-model
        /// Required: True
        /// UpdateType: Mutable
        /// Type: HarnessModelConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessModelConfiguration, BaseFunction>? Model { get; set; }
        /// <summary>
        /// Environment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-environment
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HarnessEnvironmentProvider
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessEnvironmentProvider, BaseFunction>? Environment { get; set; }
        /// <summary>
        /// Hooks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-hooks
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HarnessHook
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHook>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHook, BaseFunction>>, BaseFunction>? Hooks { get; set; }
        /// <summary>
        /// SystemPrompt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-systemprompt
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HarnessSystemContentBlock
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSystemContentBlock>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSystemContentBlock, BaseFunction>>, BaseFunction>? SystemPrompt { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AuthorizerConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-authorizerconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AuthorizerConfiguration
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.HarnessTypes.AuthorizerConfiguration, BaseFunction>? AuthorizerConfiguration { get; set; }
    }

    namespace HarnessTypes
    {
        public class AuthorizerConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesCustomJWTAuthorizerConfigurationCustomJWTAuthorizer
        {
            /// <summary>
            /// CustomJWTAuthorizer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-authorizerconfiguration.html#cfn-bedrockagentcore-harness-authorizerconfiguration-customjwtauthorizer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomJWTAuthorizerConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration, BaseFunction>? CustomJWTAuthorizer { get; set; }
        }

        public class AuthorizingClaimMatchValueType : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesClaimMatchValueTypeClaimMatchValue, IHaveClaimMatchOperator
        {
            /// <summary>
            /// ClaimMatchValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-authorizingclaimmatchvaluetype.html#cfn-bedrockagentcore-harness-authorizingclaimmatchvaluetype-claimmatchvalue
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ClaimMatchValueType
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.ClaimMatchValueType, BaseFunction>? ClaimMatchValue { get; set; }
            /// <summary>
            /// ClaimMatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-authorizingclaimmatchvaluetype.html#cfn-bedrockagentcore-harness-authorizingclaimmatchvaluetype-claimmatchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClaimMatchOperator { get; set; }
        }

        public class ClaimMatchValueType : Humidifier.Base.BaseSubResource, IHaveMatchValueString, IHaveStringListOfMatchValueStringList
        {
            /// <summary>
            /// MatchValueString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-claimmatchvaluetype.html#cfn-bedrockagentcore-harness-claimmatchvaluetype-matchvaluestring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchValueString { get; set; }
            /// <summary>
            /// MatchValueStringList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-claimmatchvaluetype.html#cfn-bedrockagentcore-harness-claimmatchvaluetype-matchvaluestringlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchValueStringList { get; set; }
        }

        public class ContainerConfiguration : Humidifier.Base.BaseSubResource, IHaveContainerUri
        {
            /// <summary>
            /// ContainerUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-containerconfiguration.html#cfn-bedrockagentcore-harness-containerconfiguration-containeruri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerUri { get; set; }
        }

        public class CustomClaimValidationType : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesAuthorizingClaimMatchValueTypeAuthorizingClaimMatchValue, IHaveInboundTokenClaimName, IHaveInboundTokenClaimValueType
        {
            /// <summary>
            /// AuthorizingClaimMatchValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customclaimvalidationtype.html#cfn-bedrockagentcore-harness-customclaimvalidationtype-authorizingclaimmatchvalue
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AuthorizingClaimMatchValueType
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.AuthorizingClaimMatchValueType, BaseFunction>? AuthorizingClaimMatchValue { get; set; }
            /// <summary>
            /// InboundTokenClaimName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customclaimvalidationtype.html#cfn-bedrockagentcore-harness-customclaimvalidationtype-inboundtokenclaimname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InboundTokenClaimName { get; set; }
            /// <summary>
            /// InboundTokenClaimValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customclaimvalidationtype.html#cfn-bedrockagentcore-harness-customclaimvalidationtype-inboundtokenclaimvaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InboundTokenClaimValueType { get; set; }
        }

        public class CustomJWTAuthorizerConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentCoreHarnessTypesPrivateEndpointOverridePrivateEndpointOverrides, IHaveDiscoveryUrl, IHaveStringListOfAllowedAudience, IHaveListOfBedrockAgentCoreHarnessTypesCustomClaimValidationTypeCustomClaims, IHaveBedrockAgentCoreHarnessTypesPrivateEndpointPrivateEndpoint, IHaveStringListOfAllowedClients, IHaveStringListOfAllowedScopes
        {
            /// <summary>
            /// PrivateEndpointOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-harness-customjwtauthorizerconfiguration-privateendpointoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PrivateEndpointOverride
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpointOverride>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpointOverride, BaseFunction>>, BaseFunction>? PrivateEndpointOverrides { get; set; }
            /// <summary>
            /// DiscoveryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-harness-customjwtauthorizerconfiguration-discoveryurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DiscoveryUrl { get; set; }
            /// <summary>
            /// AllowedAudience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-harness-customjwtauthorizerconfiguration-allowedaudience
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedAudience { get; set; }
            /// <summary>
            /// CustomClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-harness-customjwtauthorizerconfiguration-customclaims
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomClaimValidationType
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.HarnessTypes.CustomClaimValidationType>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.HarnessTypes.CustomClaimValidationType, BaseFunction>>, BaseFunction>? CustomClaims { get; set; }
            /// <summary>
            /// PrivateEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-harness-customjwtauthorizerconfiguration-privateendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrivateEndpoint
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint, BaseFunction>? PrivateEndpoint { get; set; }
            /// <summary>
            /// AllowedClients
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-harness-customjwtauthorizerconfiguration-allowedclients
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedClients { get; set; }
            /// <summary>
            /// AllowedScopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-harness-customjwtauthorizerconfiguration-allowedscopes
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-efsaccesspointconfiguration.html#cfn-bedrockagentcore-harness-efsaccesspointconfiguration-mountpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MountPath { get; set; }
            /// <summary>
            /// AccessPointArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-efsaccesspointconfiguration.html#cfn-bedrockagentcore-harness-efsaccesspointconfiguration-accesspointarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessPointArn { get; set; }
        }

        public class FilesystemConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesS3FilesAccessPointConfigurationS3FilesAccessPoint, IHaveBedrockAgentCoreHarnessTypesSessionStorageConfigurationSessionStorage, IHaveBedrockAgentCoreHarnessTypesEfsAccessPointConfigurationEfsAccessPoint
        {
            /// <summary>
            /// S3FilesAccessPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-filesystemconfiguration.html#cfn-bedrockagentcore-harness-filesystemconfiguration-s3filesaccesspoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3FilesAccessPointConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.S3FilesAccessPointConfiguration, BaseFunction>? S3FilesAccessPoint { get; set; }
            /// <summary>
            /// SessionStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-filesystemconfiguration.html#cfn-bedrockagentcore-harness-filesystemconfiguration-sessionstorage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SessionStorageConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.SessionStorageConfiguration, BaseFunction>? SessionStorage { get; set; }
            /// <summary>
            /// EfsAccessPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-filesystemconfiguration.html#cfn-bedrockagentcore-harness-filesystemconfiguration-efsaccesspoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EfsAccessPointConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.EfsAccessPointConfiguration, BaseFunction>? EfsAccessPoint { get; set; }
        }

        public class HarnessAfterInvocationHook : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesHarnessHookTargetTarget, IHaveName
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessafterinvocationhook.html#cfn-bedrockagentcore-harness-harnessafterinvocationhook-target
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HarnessHookTarget
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget, BaseFunction>? Target { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessafterinvocationhook.html#cfn-bedrockagentcore-harness-harnessafterinvocationhook-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class HarnessAfterToolCallHook : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesHarnessHookTargetTarget, IHaveName
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessaftertoolcallhook.html#cfn-bedrockagentcore-harness-harnessaftertoolcallhook-target
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HarnessHookTarget
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget, BaseFunction>? Target { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessaftertoolcallhook.html#cfn-bedrockagentcore-harness-harnessaftertoolcallhook-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class HarnessAgentCoreBrowserConfig : Humidifier.Base.BaseSubResource, IHaveBrowserArn
        {
            /// <summary>
            /// BrowserArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorebrowserconfig.html#cfn-bedrockagentcore-harness-harnessagentcorebrowserconfig-browserarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BrowserArn { get; set; }
        }

        public class HarnessAgentCoreCodeInterpreterConfig : Humidifier.Base.BaseSubResource, IHaveCodeInterpreterArn
        {
            /// <summary>
            /// CodeInterpreterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorecodeinterpreterconfig.html#cfn-bedrockagentcore-harness-harnessagentcorecodeinterpreterconfig-codeinterpreterarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CodeInterpreterArn { get; set; }
        }

        public class HarnessAgentCoreGatewayConfig : Humidifier.Base.BaseSubResource, IHaveGatewayArn, IHaveBedrockAgentCoreHarnessTypesHarnessGatewayOutboundAuthOutboundAuth
        {
            /// <summary>
            /// GatewayArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcoregatewayconfig.html#cfn-bedrockagentcore-harness-harnessagentcoregatewayconfig-gatewayarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GatewayArn { get; set; }
            /// <summary>
            /// OutboundAuth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcoregatewayconfig.html#cfn-bedrockagentcore-harness-harnessagentcoregatewayconfig-outboundauth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessGatewayOutboundAuth
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth, BaseFunction>? OutboundAuth { get; set; }
        }

        public class HarnessAgentCoreMemoryConfiguration : Humidifier.Base.BaseSubResource, IHaveMessagesCount_Integer, IHaveMapOfBedrockAgentCoreHarnessTypesHarnessAgentCoreMemoryRetrievalConfigRetrievalConfig, IHaveActorId, IHaveArn
        {
            /// <summary>
            /// MessagesCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorememoryconfiguration.html#cfn-bedrockagentcore-harness-harnessagentcorememoryconfiguration-messagescount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MessagesCount { get; set; }
            /// <summary>
            /// RetrievalConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorememoryconfiguration.html#cfn-bedrockagentcore-harness-harnessagentcorememoryconfiguration-retrievalconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: HarnessAgentCoreMemoryRetrievalConfig
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreMemoryRetrievalConfig>, IReadOnlyDictionary<string, Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreMemoryRetrievalConfig, BaseFunction>>, BaseFunction>? RetrievalConfig { get; set; }
            /// <summary>
            /// ActorId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorememoryconfiguration.html#cfn-bedrockagentcore-harness-harnessagentcorememoryconfiguration-actorid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActorId { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorememoryconfiguration.html#cfn-bedrockagentcore-harness-harnessagentcorememoryconfiguration-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class HarnessAgentCoreMemoryRetrievalConfig : Humidifier.Base.BaseSubResource, IHaveTopK, IHaveStrategyId, IHaveRelevanceScore
        {
            /// <summary>
            /// TopK
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorememoryretrievalconfig.html#cfn-bedrockagentcore-harness-harnessagentcorememoryretrievalconfig-topk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TopK { get; set; }
            /// <summary>
            /// StrategyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorememoryretrievalconfig.html#cfn-bedrockagentcore-harness-harnessagentcorememoryretrievalconfig-strategyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StrategyId { get; set; }
            /// <summary>
            /// RelevanceScore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorememoryretrievalconfig.html#cfn-bedrockagentcore-harness-harnessagentcorememoryretrievalconfig-relevancescore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RelevanceScore { get; set; }
        }

        public class HarnessAgentCoreRuntimeEnvironment : Humidifier.Base.BaseSubResource, IHaveAgentRuntimeId, IHaveListOfBedrockAgentCoreHarnessTypesFilesystemConfigurationFilesystemConfigurations, IHaveBedrockAgentCoreHarnessTypesLifecycleConfigurationLifecycleConfiguration, IHaveBedrockAgentCoreHarnessTypesNetworkConfigurationNetworkConfiguration, IHaveAgentRuntimeArn, IHaveAgentRuntimeName
        {
            /// <summary>
            /// AgentRuntimeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcoreruntimeenvironment.html#cfn-bedrockagentcore-harness-harnessagentcoreruntimeenvironment-agentruntimeid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AgentRuntimeId { get; set; }
            /// <summary>
            /// FilesystemConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcoreruntimeenvironment.html#cfn-bedrockagentcore-harness-harnessagentcoreruntimeenvironment-filesystemconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilesystemConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.HarnessTypes.FilesystemConfiguration>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.HarnessTypes.FilesystemConfiguration, BaseFunction>>, BaseFunction>? FilesystemConfigurations { get; set; }
            /// <summary>
            /// LifecycleConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcoreruntimeenvironment.html#cfn-bedrockagentcore-harness-harnessagentcoreruntimeenvironment-lifecycleconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifecycleConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.LifecycleConfiguration, BaseFunction>? LifecycleConfiguration { get; set; }
            /// <summary>
            /// NetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcoreruntimeenvironment.html#cfn-bedrockagentcore-harness-harnessagentcoreruntimeenvironment-networkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.NetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
            /// <summary>
            /// AgentRuntimeArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcoreruntimeenvironment.html#cfn-bedrockagentcore-harness-harnessagentcoreruntimeenvironment-agentruntimearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AgentRuntimeArn { get; set; }
            /// <summary>
            /// AgentRuntimeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcoreruntimeenvironment.html#cfn-bedrockagentcore-harness-harnessagentcoreruntimeenvironment-agentruntimename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AgentRuntimeName { get; set; }
        }

        public class HarnessBedrockModelConfig : Humidifier.Base.BaseSubResource, IHaveTemperature_Double, IHaveAdditionalParams_Json, IHaveMaxTokens_Integer, IHaveApiFormat, IHaveTopP_Double, IHaveModelId
        {
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbedrockmodelconfig.html#cfn-bedrockagentcore-harness-harnessbedrockmodelconfig-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Temperature { get; set; }
            /// <summary>
            /// AdditionalParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbedrockmodelconfig.html#cfn-bedrockagentcore-harness-harnessbedrockmodelconfig-additionalparams
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AdditionalParams { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbedrockmodelconfig.html#cfn-bedrockagentcore-harness-harnessbedrockmodelconfig-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxTokens { get; set; }
            /// <summary>
            /// ApiFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbedrockmodelconfig.html#cfn-bedrockagentcore-harness-harnessbedrockmodelconfig-apiformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiFormat { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbedrockmodelconfig.html#cfn-bedrockagentcore-harness-harnessbedrockmodelconfig-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TopP { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbedrockmodelconfig.html#cfn-bedrockagentcore-harness-harnessbedrockmodelconfig-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class HarnessBeforeInvocationHook : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesHarnessHookTargetTarget, IHaveName
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbeforeinvocationhook.html#cfn-bedrockagentcore-harness-harnessbeforeinvocationhook-target
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HarnessHookTarget
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget, BaseFunction>? Target { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbeforeinvocationhook.html#cfn-bedrockagentcore-harness-harnessbeforeinvocationhook-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class HarnessBeforeToolCallHook : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesHarnessHookTargetTarget, IHaveName
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbeforetoolcallhook.html#cfn-bedrockagentcore-harness-harnessbeforetoolcallhook-target
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HarnessHookTarget
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget, BaseFunction>? Target { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbeforetoolcallhook.html#cfn-bedrockagentcore-harness-harnessbeforetoolcallhook-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class HarnessEnvironmentArtifact : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesContainerConfigurationContainerConfiguration
        {
            /// <summary>
            /// ContainerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessenvironmentartifact.html#cfn-bedrockagentcore-harness-harnessenvironmentartifact-containerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContainerConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration, BaseFunction>? ContainerConfiguration { get; set; }
        }

        public class HarnessEnvironmentProvider : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesHarnessAgentCoreRuntimeEnvironmentAgentCoreRuntimeEnvironment
        {
            /// <summary>
            /// AgentCoreRuntimeEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessenvironmentprovider.html#cfn-bedrockagentcore-harness-harnessenvironmentprovider-agentcoreruntimeenvironment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessAgentCoreRuntimeEnvironment
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreRuntimeEnvironment, BaseFunction>? AgentCoreRuntimeEnvironment { get; set; }
        }

        public class HarnessGatewayOutboundAuth : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesOAuthCredentialProviderOauth, IHaveAwsIam_Json, IHaveNone_Json
        {
            /// <summary>
            /// Oauth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgatewayoutboundauth.html#cfn-bedrockagentcore-harness-harnessgatewayoutboundauth-oauth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuthCredentialProvider
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider, BaseFunction>? Oauth { get; set; }
            /// <summary>
            /// AwsIam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgatewayoutboundauth.html#cfn-bedrockagentcore-harness-harnessgatewayoutboundauth-awsiam
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AwsIam { get; set; }
            /// <summary>
            /// None
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgatewayoutboundauth.html#cfn-bedrockagentcore-harness-harnessgatewayoutboundauth-none
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? None { get; set; }
        }

        public class HarnessGeminiModelConfig : Humidifier.Base.BaseSubResource, IHaveTopK_Integer, IHaveTemperature_Double, IHaveMaxTokens_Integer, IHaveApiKeyArn, IHaveTopP_Double, IHaveModelId
        {
            /// <summary>
            /// TopK
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgeminimodelconfig.html#cfn-bedrockagentcore-harness-harnessgeminimodelconfig-topk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TopK { get; set; }
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgeminimodelconfig.html#cfn-bedrockagentcore-harness-harnessgeminimodelconfig-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Temperature { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgeminimodelconfig.html#cfn-bedrockagentcore-harness-harnessgeminimodelconfig-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxTokens { get; set; }
            /// <summary>
            /// ApiKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgeminimodelconfig.html#cfn-bedrockagentcore-harness-harnessgeminimodelconfig-apikeyarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKeyArn { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgeminimodelconfig.html#cfn-bedrockagentcore-harness-harnessgeminimodelconfig-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TopP { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgeminimodelconfig.html#cfn-bedrockagentcore-harness-harnessgeminimodelconfig-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class HarnessHook : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesHarnessAfterToolCallHookAfterToolCall, IHaveBedrockAgentCoreHarnessTypesHarnessBeforeToolCallHookBeforeToolCall, IHaveBedrockAgentCoreHarnessTypesHarnessAfterInvocationHookAfterInvocation, IHaveBedrockAgentCoreHarnessTypesHarnessBeforeInvocationHookBeforeInvocation
        {
            /// <summary>
            /// AfterToolCall
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshook.html#cfn-bedrockagentcore-harness-harnesshook-aftertoolcall
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessAfterToolCallHook
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAfterToolCallHook, BaseFunction>? AfterToolCall { get; set; }
            /// <summary>
            /// BeforeToolCall
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshook.html#cfn-bedrockagentcore-harness-harnesshook-beforetoolcall
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessBeforeToolCallHook
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessBeforeToolCallHook, BaseFunction>? BeforeToolCall { get; set; }
            /// <summary>
            /// AfterInvocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshook.html#cfn-bedrockagentcore-harness-harnesshook-afterinvocation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessAfterInvocationHook
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAfterInvocationHook, BaseFunction>? AfterInvocation { get; set; }
            /// <summary>
            /// BeforeInvocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshook.html#cfn-bedrockagentcore-harness-harnesshook-beforeinvocation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessBeforeInvocationHook
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessBeforeInvocationHook, BaseFunction>? BeforeInvocation { get; set; }
        }

        public class HarnessHookEventBridgeTarget : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshookeventbridgetarget.html#cfn-bedrockagentcore-harness-harnesshookeventbridgetarget-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class HarnessHookLambdaTarget : Humidifier.Base.BaseSubResource, IHaveTimeoutSeconds_Integer, IHaveArn, IHaveFailureMode
        {
            /// <summary>
            /// TimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshooklambdatarget.html#cfn-bedrockagentcore-harness-harnesshooklambdatarget-timeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutSeconds { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshooklambdatarget.html#cfn-bedrockagentcore-harness-harnesshooklambdatarget-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// FailureMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshooklambdatarget.html#cfn-bedrockagentcore-harness-harnesshooklambdatarget-failuremode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FailureMode { get; set; }
        }

        public class HarnessHookSnsTarget : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshooksnstarget.html#cfn-bedrockagentcore-harness-harnesshooksnstarget-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class HarnessHookTarget : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesHarnessHookSnsTargetSns, IHaveBedrockAgentCoreHarnessTypesHarnessHookLambdaTargetLambda, IHaveBedrockAgentCoreHarnessTypesHarnessHookEventBridgeTargetEventBridge
        {
            /// <summary>
            /// Sns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshooktarget.html#cfn-bedrockagentcore-harness-harnesshooktarget-sns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessHookSnsTarget
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookSnsTarget, BaseFunction>? Sns { get; set; }
            /// <summary>
            /// Lambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshooktarget.html#cfn-bedrockagentcore-harness-harnesshooktarget-lambda
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessHookLambdaTarget
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookLambdaTarget, BaseFunction>? Lambda { get; set; }
            /// <summary>
            /// EventBridge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshooktarget.html#cfn-bedrockagentcore-harness-harnesshooktarget-eventbridge
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessHookEventBridgeTarget
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookEventBridgeTarget, BaseFunction>? EventBridge { get; set; }
        }

        public class HarnessInlineFunctionConfig : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveInputSchema_Json
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessinlinefunctionconfig.html#cfn-bedrockagentcore-harness-harnessinlinefunctionconfig-description
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// InputSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessinlinefunctionconfig.html#cfn-bedrockagentcore-harness-harnessinlinefunctionconfig-inputschema
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? InputSchema { get; set; }
        }

        public class HarnessLiteLlmModelConfig : Humidifier.Base.BaseSubResource, IHaveApiBase, IHaveTemperature_Double, IHaveAdditionalParams_Json, IHaveMaxTokens_Integer, IHaveApiKeyArn, IHaveTopP_Double, IHaveModelId
        {
            /// <summary>
            /// ApiBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesslitellmmodelconfig.html#cfn-bedrockagentcore-harness-harnesslitellmmodelconfig-apibase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiBase { get; set; }
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesslitellmmodelconfig.html#cfn-bedrockagentcore-harness-harnesslitellmmodelconfig-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Temperature { get; set; }
            /// <summary>
            /// AdditionalParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesslitellmmodelconfig.html#cfn-bedrockagentcore-harness-harnesslitellmmodelconfig-additionalparams
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AdditionalParams { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesslitellmmodelconfig.html#cfn-bedrockagentcore-harness-harnesslitellmmodelconfig-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxTokens { get; set; }
            /// <summary>
            /// ApiKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesslitellmmodelconfig.html#cfn-bedrockagentcore-harness-harnesslitellmmodelconfig-apikeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKeyArn { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesslitellmmodelconfig.html#cfn-bedrockagentcore-harness-harnesslitellmmodelconfig-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TopP { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesslitellmmodelconfig.html#cfn-bedrockagentcore-harness-harnesslitellmmodelconfig-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class HarnessManagedMemoryConfiguration : Humidifier.Base.BaseSubResource, IHaveEncryptionKeyArn, IHaveStringListOfStrategies, IHaveArn, IHaveEventExpiryDuration_Integer
        {
            /// <summary>
            /// EncryptionKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmanagedmemoryconfiguration.html#cfn-bedrockagentcore-harness-harnessmanagedmemoryconfiguration-encryptionkeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKeyArn { get; set; }
            /// <summary>
            /// Strategies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmanagedmemoryconfiguration.html#cfn-bedrockagentcore-harness-harnessmanagedmemoryconfiguration-strategies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Strategies { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmanagedmemoryconfiguration.html#cfn-bedrockagentcore-harness-harnessmanagedmemoryconfiguration-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// EventExpiryDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmanagedmemoryconfiguration.html#cfn-bedrockagentcore-harness-harnessmanagedmemoryconfiguration-eventexpiryduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EventExpiryDuration { get; set; }
        }

        public class HarnessMemoryConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesHarnessManagedMemoryConfigurationManagedMemoryConfiguration, IHaveDisabled_Json, IHaveBedrockAgentCoreHarnessTypesHarnessAgentCoreMemoryConfigurationAgentCoreMemoryConfiguration
        {
            /// <summary>
            /// ManagedMemoryConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmemoryconfiguration.html#cfn-bedrockagentcore-harness-harnessmemoryconfiguration-managedmemoryconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessManagedMemoryConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessManagedMemoryConfiguration, BaseFunction>? ManagedMemoryConfiguration { get; set; }
            /// <summary>
            /// Disabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmemoryconfiguration.html#cfn-bedrockagentcore-harness-harnessmemoryconfiguration-disabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Disabled { get; set; }
            /// <summary>
            /// AgentCoreMemoryConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmemoryconfiguration.html#cfn-bedrockagentcore-harness-harnessmemoryconfiguration-agentcorememoryconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessAgentCoreMemoryConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreMemoryConfiguration, BaseFunction>? AgentCoreMemoryConfiguration { get; set; }
        }

        public class HarnessModelConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesHarnessLiteLlmModelConfigLiteLlmModelConfig, IHaveBedrockAgentCoreHarnessTypesHarnessBedrockModelConfigBedrockModelConfig, IHaveBedrockAgentCoreHarnessTypesHarnessGeminiModelConfigGeminiModelConfig, IHaveBedrockAgentCoreHarnessTypesHarnessOpenAiModelConfigOpenAiModelConfig
        {
            /// <summary>
            /// LiteLlmModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmodelconfiguration.html#cfn-bedrockagentcore-harness-harnessmodelconfiguration-litellmmodelconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessLiteLlmModelConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessLiteLlmModelConfig, BaseFunction>? LiteLlmModelConfig { get; set; }
            /// <summary>
            /// BedrockModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmodelconfiguration.html#cfn-bedrockagentcore-harness-harnessmodelconfiguration-bedrockmodelconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessBedrockModelConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessBedrockModelConfig, BaseFunction>? BedrockModelConfig { get; set; }
            /// <summary>
            /// GeminiModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmodelconfiguration.html#cfn-bedrockagentcore-harness-harnessmodelconfiguration-geminimodelconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessGeminiModelConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGeminiModelConfig, BaseFunction>? GeminiModelConfig { get; set; }
            /// <summary>
            /// OpenAiModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmodelconfiguration.html#cfn-bedrockagentcore-harness-harnessmodelconfiguration-openaimodelconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessOpenAiModelConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessOpenAiModelConfig, BaseFunction>? OpenAiModelConfig { get; set; }
        }

        public class HarnessOpenAiModelConfig : Humidifier.Base.BaseSubResource, IHaveTemperature_Double, IHaveAdditionalParams_Json, IHaveMaxTokens_Integer, IHaveApiFormat, IHaveApiKeyArn, IHaveTopP_Double, IHaveModelId
        {
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessopenaimodelconfig.html#cfn-bedrockagentcore-harness-harnessopenaimodelconfig-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Temperature { get; set; }
            /// <summary>
            /// AdditionalParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessopenaimodelconfig.html#cfn-bedrockagentcore-harness-harnessopenaimodelconfig-additionalparams
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AdditionalParams { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessopenaimodelconfig.html#cfn-bedrockagentcore-harness-harnessopenaimodelconfig-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxTokens { get; set; }
            /// <summary>
            /// ApiFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessopenaimodelconfig.html#cfn-bedrockagentcore-harness-harnessopenaimodelconfig-apiformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiFormat { get; set; }
            /// <summary>
            /// ApiKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessopenaimodelconfig.html#cfn-bedrockagentcore-harness-harnessopenaimodelconfig-apikeyarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKeyArn { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessopenaimodelconfig.html#cfn-bedrockagentcore-harness-harnessopenaimodelconfig-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TopP { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessopenaimodelconfig.html#cfn-bedrockagentcore-harness-harnessopenaimodelconfig-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class HarnessRemoteMcpConfig : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfHeaders, IHaveUrl
        {
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessremotemcpconfig.html#cfn-bedrockagentcore-harness-harnessremotemcpconfig-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Headers { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessremotemcpconfig.html#cfn-bedrockagentcore-harness-harnessremotemcpconfig-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class HarnessSkill : Humidifier.Base.BaseSubResource, IHavePath, IHaveBedrockAgentCoreHarnessTypesHarnessSkillS3SourceS3, IHaveBedrockAgentCoreHarnessTypesHarnessSkillGitSourceGit, IHaveBedrockAgentCoreHarnessTypesHarnessSkillAwsSkillsSourceAwsSkills
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskill.html#cfn-bedrockagentcore-harness-harnessskill-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskill.html#cfn-bedrockagentcore-harness-harnessskill-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessSkillS3Source
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillS3Source, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// Git
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskill.html#cfn-bedrockagentcore-harness-harnessskill-git
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessSkillGitSource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitSource, BaseFunction>? Git { get; set; }
            /// <summary>
            /// AwsSkills
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskill.html#cfn-bedrockagentcore-harness-harnessskill-awsskills
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessSkillAwsSkillsSource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillAwsSkillsSource, BaseFunction>? AwsSkills { get; set; }
        }

        public class HarnessSkillAwsSkillsSource : Humidifier.Base.BaseSubResource, IHaveStringListOfPaths
        {
            /// <summary>
            /// Paths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskillawsskillssource.html#cfn-bedrockagentcore-harness-harnessskillawsskillssource-paths
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Paths { get; set; }
        }

        public class HarnessSkillGitAuth : Humidifier.Base.BaseSubResource, IHaveUsername, IHaveCredentialArn
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskillgitauth.html#cfn-bedrockagentcore-harness-harnessskillgitauth-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// CredentialArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskillgitauth.html#cfn-bedrockagentcore-harness-harnessskillgitauth-credentialarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialArn { get; set; }
        }

        public class HarnessSkillGitSource : Humidifier.Base.BaseSubResource, IHavePath, IHaveBedrockAgentCoreHarnessTypesHarnessSkillGitAuthAuth, IHaveUrl
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskillgitsource.html#cfn-bedrockagentcore-harness-harnessskillgitsource-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Auth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskillgitsource.html#cfn-bedrockagentcore-harness-harnessskillgitsource-auth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessSkillGitAuth
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth, BaseFunction>? Auth { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskillgitsource.html#cfn-bedrockagentcore-harness-harnessskillgitsource-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class HarnessSkillS3Source : Humidifier.Base.BaseSubResource, IHaveUri
        {
            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskills3source.html#cfn-bedrockagentcore-harness-harnessskills3source-uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Uri { get; set; }
        }

        public class HarnessSlidingWindowConfiguration : Humidifier.Base.BaseSubResource, IHaveMessagesCount_Integer
        {
            /// <summary>
            /// MessagesCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessslidingwindowconfiguration.html#cfn-bedrockagentcore-harness-harnessslidingwindowconfiguration-messagescount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MessagesCount { get; set; }
        }

        public class HarnessSummarizationConfiguration : Humidifier.Base.BaseSubResource, IHaveSummarizationSystemPrompt, IHavePreserveRecentMessages_Integer, IHaveSummaryRatio_Double
        {
            /// <summary>
            /// SummarizationSystemPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesssummarizationconfiguration.html#cfn-bedrockagentcore-harness-harnesssummarizationconfiguration-summarizationsystemprompt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SummarizationSystemPrompt { get; set; }
            /// <summary>
            /// PreserveRecentMessages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesssummarizationconfiguration.html#cfn-bedrockagentcore-harness-harnesssummarizationconfiguration-preserverecentmessages
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PreserveRecentMessages { get; set; }
            /// <summary>
            /// SummaryRatio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesssummarizationconfiguration.html#cfn-bedrockagentcore-harness-harnesssummarizationconfiguration-summaryratio
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? SummaryRatio { get; set; }
        }

        public class HarnessSystemContentBlock : Humidifier.Base.BaseSubResource, IHaveText
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesssystemcontentblock.html#cfn-bedrockagentcore-harness-harnesssystemcontentblock-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }

        public class HarnessTool : Humidifier.Base.BaseSubResource, IHaveType, IHaveBedrockAgentCoreHarnessTypesHarnessToolConfigurationConfig, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstool.html#cfn-bedrockagentcore-harness-harnesstool-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Config
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstool.html#cfn-bedrockagentcore-harness-harnesstool-config
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessToolConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessToolConfiguration, BaseFunction>? Config { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstool.html#cfn-bedrockagentcore-harness-harnesstool-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class HarnessToolConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesHarnessRemoteMcpConfigRemoteMcp, IHaveBedrockAgentCoreHarnessTypesHarnessAgentCoreCodeInterpreterConfigAgentCoreCodeInterpreter, IHaveBedrockAgentCoreHarnessTypesHarnessAgentCoreGatewayConfigAgentCoreGateway, IHaveBedrockAgentCoreHarnessTypesHarnessInlineFunctionConfigInlineFunction, IHaveBedrockAgentCoreHarnessTypesHarnessAgentCoreBrowserConfigAgentCoreBrowser
        {
            /// <summary>
            /// RemoteMcp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstoolconfiguration.html#cfn-bedrockagentcore-harness-harnesstoolconfiguration-remotemcp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessRemoteMcpConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessRemoteMcpConfig, BaseFunction>? RemoteMcp { get; set; }
            /// <summary>
            /// AgentCoreCodeInterpreter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstoolconfiguration.html#cfn-bedrockagentcore-harness-harnesstoolconfiguration-agentcorecodeinterpreter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessAgentCoreCodeInterpreterConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreCodeInterpreterConfig, BaseFunction>? AgentCoreCodeInterpreter { get; set; }
            /// <summary>
            /// AgentCoreGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstoolconfiguration.html#cfn-bedrockagentcore-harness-harnesstoolconfiguration-agentcoregateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessAgentCoreGatewayConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreGatewayConfig, BaseFunction>? AgentCoreGateway { get; set; }
            /// <summary>
            /// InlineFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstoolconfiguration.html#cfn-bedrockagentcore-harness-harnesstoolconfiguration-inlinefunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessInlineFunctionConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessInlineFunctionConfig, BaseFunction>? InlineFunction { get; set; }
            /// <summary>
            /// AgentCoreBrowser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstoolconfiguration.html#cfn-bedrockagentcore-harness-harnesstoolconfiguration-agentcorebrowser
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessAgentCoreBrowserConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreBrowserConfig, BaseFunction>? AgentCoreBrowser { get; set; }
        }

        public class HarnessTruncationConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesHarnessTruncationStrategyConfigurationConfig, IHaveStrategy
        {
            /// <summary>
            /// Config
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstruncationconfiguration.html#cfn-bedrockagentcore-harness-harnesstruncationconfiguration-config
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessTruncationStrategyConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationStrategyConfiguration, BaseFunction>? Config { get; set; }
            /// <summary>
            /// Strategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstruncationconfiguration.html#cfn-bedrockagentcore-harness-harnesstruncationconfiguration-strategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Strategy { get; set; }
        }

        public class HarnessTruncationStrategyConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesHarnessSlidingWindowConfigurationSlidingWindow, IHaveBedrockAgentCoreHarnessTypesHarnessSummarizationConfigurationSummarization
        {
            /// <summary>
            /// SlidingWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstruncationstrategyconfiguration.html#cfn-bedrockagentcore-harness-harnesstruncationstrategyconfiguration-slidingwindow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessSlidingWindowConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSlidingWindowConfiguration, BaseFunction>? SlidingWindow { get; set; }
            /// <summary>
            /// Summarization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstruncationstrategyconfiguration.html#cfn-bedrockagentcore-harness-harnesstruncationstrategyconfiguration-summarization
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessSummarizationConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSummarizationConfiguration, BaseFunction>? Summarization { get; set; }
        }

        public class LifecycleConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxLifetime_Integer, IHaveIdleRuntimeSessionTimeout_Integer
        {
            /// <summary>
            /// MaxLifetime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-lifecycleconfiguration.html#cfn-bedrockagentcore-harness-lifecycleconfiguration-maxlifetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxLifetime { get; set; }
            /// <summary>
            /// IdleRuntimeSessionTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-lifecycleconfiguration.html#cfn-bedrockagentcore-harness-lifecycleconfiguration-idleruntimesessiontimeout
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-managedvpcresource.html#cfn-bedrockagentcore-harness-managedvpcresource-routingdomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoutingDomain { get; set; }
            /// <summary>
            /// VpcIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-managedvpcresource.html#cfn-bedrockagentcore-harness-managedvpcresource-vpcidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcIdentifier { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-managedvpcresource.html#cfn-bedrockagentcore-harness-managedvpcresource-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// EndpointIpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-managedvpcresource.html#cfn-bedrockagentcore-harness-managedvpcresource-endpointipaddresstype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointIpAddressType { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-managedvpcresource.html#cfn-bedrockagentcore-harness-managedvpcresource-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-managedvpcresource.html#cfn-bedrockagentcore-harness-managedvpcresource-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesVpcConfigNetworkModeConfig, IHaveNetworkMode
        {
            /// <summary>
            /// NetworkModeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-networkconfiguration.html#cfn-bedrockagentcore-harness-networkconfiguration-networkmodeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig, BaseFunction>? NetworkModeConfig { get; set; }
            /// <summary>
            /// NetworkMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-networkconfiguration.html#cfn-bedrockagentcore-harness-networkconfiguration-networkmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkMode { get; set; }
        }

        public class OAuthCredentialProvider : Humidifier.Base.BaseSubResource, IHaveDefaultReturnUrl, IHaveProviderArn, IHaveStringListOfScopes, IHaveGrantType, IHaveStringDictionaryOfCustomParameters
        {
            /// <summary>
            /// DefaultReturnUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-oauthcredentialprovider.html#cfn-bedrockagentcore-harness-oauthcredentialprovider-defaultreturnurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultReturnUrl { get; set; }
            /// <summary>
            /// ProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-oauthcredentialprovider.html#cfn-bedrockagentcore-harness-oauthcredentialprovider-providerarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProviderArn { get; set; }
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-oauthcredentialprovider.html#cfn-bedrockagentcore-harness-oauthcredentialprovider-scopes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Scopes { get; set; }
            /// <summary>
            /// GrantType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-oauthcredentialprovider.html#cfn-bedrockagentcore-harness-oauthcredentialprovider-granttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GrantType { get; set; }
            /// <summary>
            /// CustomParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-oauthcredentialprovider.html#cfn-bedrockagentcore-harness-oauthcredentialprovider-customparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? CustomParameters { get; set; }
        }

        public class PrivateEndpoint : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreHarnessTypesSelfManagedLatticeResourceSelfManagedLatticeResource, IHaveBedrockAgentCoreHarnessTypesManagedVpcResourceManagedVpcResource
        {
            /// <summary>
            /// SelfManagedLatticeResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-privateendpoint.html#cfn-bedrockagentcore-harness-privateendpoint-selfmanagedlatticeresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelfManagedLatticeResource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.SelfManagedLatticeResource, BaseFunction>? SelfManagedLatticeResource { get; set; }
            /// <summary>
            /// ManagedVpcResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-privateendpoint.html#cfn-bedrockagentcore-harness-privateendpoint-managedvpcresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedVpcResource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.ManagedVpcResource, BaseFunction>? ManagedVpcResource { get; set; }
        }

        public class PrivateEndpointOverride : Humidifier.Base.BaseSubResource, IHaveDomain, IHaveBedrockAgentCoreHarnessTypesPrivateEndpointPrivateEndpoint
        {
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-privateendpointoverride.html#cfn-bedrockagentcore-harness-privateendpointoverride-domain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Domain { get; set; }
            /// <summary>
            /// PrivateEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-privateendpointoverride.html#cfn-bedrockagentcore-harness-privateendpointoverride-privateendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrivateEndpoint
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint, BaseFunction>? PrivateEndpoint { get; set; }
        }

        public class S3FilesAccessPointConfiguration : Humidifier.Base.BaseSubResource, IHaveMountPath, IHaveAccessPointArn
        {
            /// <summary>
            /// MountPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-s3filesaccesspointconfiguration.html#cfn-bedrockagentcore-harness-s3filesaccesspointconfiguration-mountpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MountPath { get; set; }
            /// <summary>
            /// AccessPointArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-s3filesaccesspointconfiguration.html#cfn-bedrockagentcore-harness-s3filesaccesspointconfiguration-accesspointarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessPointArn { get; set; }
        }

        public class SelfManagedLatticeResource : Humidifier.Base.BaseSubResource, IHaveResourceConfigurationIdentifier
        {
            /// <summary>
            /// ResourceConfigurationIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-selfmanagedlatticeresource.html#cfn-bedrockagentcore-harness-selfmanagedlatticeresource-resourceconfigurationidentifier
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-sessionstorageconfiguration.html#cfn-bedrockagentcore-harness-sessionstorageconfiguration-mountpath
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-vpcconfig.html#cfn-bedrockagentcore-harness-vpcconfig-securitygroups
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-vpcconfig.html#cfn-bedrockagentcore-harness-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
        }
    }
}