namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using HarnessTypes;

    public class Harness : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveExecutionRoleArn, IHaveMaxTokens, IHaveTimeoutSeconds
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
        public dynamic AllowedTools { get; set; }
        /// <summary>
        /// Memory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-memory
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HarnessMemoryConfiguration
        /// </summary>
        public Humidifier.BedrockAgentCore.HarnessTypes.HarnessMemoryConfiguration Memory { get; set; }
        /// <summary>
        /// MaxTokens
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-maxtokens
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaxTokens { get; set; }
        /// <summary>
        /// Tools
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-tools
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HarnessTool
        /// </summary>
        public List<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTool> Tools { get; set; }
        /// <summary>
        /// MaxIterations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-maxiterations
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaxIterations { get; set; }
        /// <summary>
        /// Truncation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-truncation
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HarnessTruncationConfiguration
        /// </summary>
        public Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationConfiguration Truncation { get; set; }
        /// <summary>
        /// TimeoutSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-timeoutseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic TimeoutSeconds { get; set; }

        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-executionrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ExecutionRoleArn { get; set; }
        /// <summary>
        /// EnvironmentVariables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-environmentvariables
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> EnvironmentVariables { get; set; }
        /// <summary>
        /// Skills
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-skills
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HarnessSkill
        /// </summary>
        public List<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkill> Skills { get; set; }
        public dynamic HarnessName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// EnvironmentArtifact
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-environmentartifact
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HarnessEnvironmentArtifact
        /// </summary>
        public Humidifier.BedrockAgentCore.HarnessTypes.HarnessEnvironmentArtifact EnvironmentArtifact { get; set; }

        /// <summary>
        /// Model
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-model
        /// Required: True
        /// UpdateType: Mutable
        /// Type: HarnessModelConfiguration
        /// </summary>
        [Required]
        public Humidifier.BedrockAgentCore.HarnessTypes.HarnessModelConfiguration Model { get; set; }
        /// <summary>
        /// Environment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-environment
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HarnessEnvironmentProvider
        /// </summary>
        public Humidifier.BedrockAgentCore.HarnessTypes.HarnessEnvironmentProvider Environment { get; set; }
        /// <summary>
        /// Hooks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-hooks
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HarnessHook
        /// </summary>
        public List<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHook> Hooks { get; set; }
        /// <summary>
        /// SystemPrompt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-systemprompt
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HarnessSystemContentBlock
        /// </summary>
        public List<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSystemContentBlock> SystemPrompt { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// AuthorizerConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harness.html#cfn-bedrockagentcore-harness-authorizerconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AuthorizerConfiguration
        /// </summary>
        public Humidifier.BedrockAgentCore.HarnessTypes.AuthorizerConfiguration AuthorizerConfiguration { get; set; }
    }

    namespace HarnessTypes
    {
        public class AuthorizerConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomJWTAuthorizer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-authorizerconfiguration.html#cfn-bedrockagentcore-harness-authorizerconfiguration-customjwtauthorizer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomJWTAuthorizerConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration CustomJWTAuthorizer { get; set; }
        }

        public class AuthorizingClaimMatchValueType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ClaimMatchValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-authorizingclaimmatchvaluetype.html#cfn-bedrockagentcore-harness-authorizingclaimmatchvaluetype-claimmatchvalue
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ClaimMatchValueType
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.ClaimMatchValueType ClaimMatchValue { get; set; }
            /// <summary>
            /// ClaimMatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-authorizingclaimmatchvaluetype.html#cfn-bedrockagentcore-harness-authorizingclaimmatchvaluetype-claimmatchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClaimMatchOperator { get; set; }
        }

        public class ClaimMatchValueType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MatchValueString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-claimmatchvaluetype.html#cfn-bedrockagentcore-harness-claimmatchvaluetype-matchvaluestring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchValueString { get; set; }
            /// <summary>
            /// MatchValueStringList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-claimmatchvaluetype.html#cfn-bedrockagentcore-harness-claimmatchvaluetype-matchvaluestringlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchValueStringList { get; set; }
        }

        public class ContainerConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContainerUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-containerconfiguration.html#cfn-bedrockagentcore-harness-containerconfiguration-containeruri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerUri { get; set; }
        }

        public class CustomClaimValidationType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuthorizingClaimMatchValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customclaimvalidationtype.html#cfn-bedrockagentcore-harness-customclaimvalidationtype-authorizingclaimmatchvalue
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AuthorizingClaimMatchValueType
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.AuthorizingClaimMatchValueType AuthorizingClaimMatchValue { get; set; }
            /// <summary>
            /// InboundTokenClaimName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customclaimvalidationtype.html#cfn-bedrockagentcore-harness-customclaimvalidationtype-inboundtokenclaimname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InboundTokenClaimName { get; set; }
            /// <summary>
            /// InboundTokenClaimValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customclaimvalidationtype.html#cfn-bedrockagentcore-harness-customclaimvalidationtype-inboundtokenclaimvaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InboundTokenClaimValueType { get; set; }
        }

        public class CustomJWTAuthorizerConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PrivateEndpointOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-harness-customjwtauthorizerconfiguration-privateendpointoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PrivateEndpointOverride
            /// </summary>
            public List<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpointOverride> PrivateEndpointOverrides { get; set; }
            /// <summary>
            /// DiscoveryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-harness-customjwtauthorizerconfiguration-discoveryurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DiscoveryUrl { get; set; }
            /// <summary>
            /// AllowedAudience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-harness-customjwtauthorizerconfiguration-allowedaudience
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedAudience { get; set; }
            /// <summary>
            /// CustomClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-harness-customjwtauthorizerconfiguration-customclaims
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomClaimValidationType
            /// </summary>
            public List<Humidifier.BedrockAgentCore.HarnessTypes.CustomClaimValidationType> CustomClaims { get; set; }
            /// <summary>
            /// PrivateEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-harness-customjwtauthorizerconfiguration-privateendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrivateEndpoint
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint PrivateEndpoint { get; set; }
            /// <summary>
            /// AllowedClients
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-harness-customjwtauthorizerconfiguration-allowedclients
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedClients { get; set; }
            /// <summary>
            /// AllowedScopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-harness-customjwtauthorizerconfiguration-allowedscopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedScopes { get; set; }
        }

        public class EfsAccessPointConfiguration : Humidifier.Base.BaseSubResource, IHaveAccessPointArn, IHaveMountPath
        {
            /// <summary>
            /// MountPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-efsaccesspointconfiguration.html#cfn-bedrockagentcore-harness-efsaccesspointconfiguration-mountpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MountPath { get; set; }
            /// <summary>
            /// AccessPointArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-efsaccesspointconfiguration.html#cfn-bedrockagentcore-harness-efsaccesspointconfiguration-accesspointarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccessPointArn { get; set; }
        }

        public class FilesystemConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3FilesAccessPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-filesystemconfiguration.html#cfn-bedrockagentcore-harness-filesystemconfiguration-s3filesaccesspoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3FilesAccessPointConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.S3FilesAccessPointConfiguration S3FilesAccessPoint { get; set; }
            /// <summary>
            /// SessionStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-filesystemconfiguration.html#cfn-bedrockagentcore-harness-filesystemconfiguration-sessionstorage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SessionStorageConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.SessionStorageConfiguration SessionStorage { get; set; }
            /// <summary>
            /// EfsAccessPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-filesystemconfiguration.html#cfn-bedrockagentcore-harness-filesystemconfiguration-efsaccesspoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EfsAccessPointConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.EfsAccessPointConfiguration EfsAccessPoint { get; set; }
        }

        public class HarnessAfterInvocationHook : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessafterinvocationhook.html#cfn-bedrockagentcore-harness-harnessafterinvocationhook-target
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HarnessHookTarget
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget Target { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessafterinvocationhook.html#cfn-bedrockagentcore-harness-harnessafterinvocationhook-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class HarnessAfterToolCallHook : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessaftertoolcallhook.html#cfn-bedrockagentcore-harness-harnessaftertoolcallhook-target
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HarnessHookTarget
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget Target { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessaftertoolcallhook.html#cfn-bedrockagentcore-harness-harnessaftertoolcallhook-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class HarnessAgentCoreBrowserConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BrowserArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorebrowserconfig.html#cfn-bedrockagentcore-harness-harnessagentcorebrowserconfig-browserarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BrowserArn { get; set; }
        }

        public class HarnessAgentCoreCodeInterpreterConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CodeInterpreterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorecodeinterpreterconfig.html#cfn-bedrockagentcore-harness-harnessagentcorecodeinterpreterconfig-codeinterpreterarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CodeInterpreterArn { get; set; }
        }

        public class HarnessAgentCoreGatewayConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GatewayArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcoregatewayconfig.html#cfn-bedrockagentcore-harness-harnessagentcoregatewayconfig-gatewayarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GatewayArn { get; set; }
            /// <summary>
            /// OutboundAuth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcoregatewayconfig.html#cfn-bedrockagentcore-harness-harnessagentcoregatewayconfig-outboundauth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessGatewayOutboundAuth
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth OutboundAuth { get; set; }
        }

        public class HarnessAgentCoreMemoryConfiguration : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// MessagesCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorememoryconfiguration.html#cfn-bedrockagentcore-harness-harnessagentcorememoryconfiguration-messagescount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MessagesCount { get; set; }
            /// <summary>
            /// RetrievalConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorememoryconfiguration.html#cfn-bedrockagentcore-harness-harnessagentcorememoryconfiguration-retrievalconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: HarnessAgentCoreMemoryRetrievalConfig
            /// </summary>
            public Dictionary<string, Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreMemoryRetrievalConfig> RetrievalConfig { get; set; }
            /// <summary>
            /// ActorId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorememoryconfiguration.html#cfn-bedrockagentcore-harness-harnessagentcorememoryconfiguration-actorid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActorId { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorememoryconfiguration.html#cfn-bedrockagentcore-harness-harnessagentcorememoryconfiguration-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class HarnessAgentCoreMemoryRetrievalConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TopK
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorememoryretrievalconfig.html#cfn-bedrockagentcore-harness-harnessagentcorememoryretrievalconfig-topk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TopK { get; set; }
            /// <summary>
            /// StrategyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorememoryretrievalconfig.html#cfn-bedrockagentcore-harness-harnessagentcorememoryretrievalconfig-strategyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StrategyId { get; set; }
            /// <summary>
            /// RelevanceScore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcorememoryretrievalconfig.html#cfn-bedrockagentcore-harness-harnessagentcorememoryretrievalconfig-relevancescore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RelevanceScore { get; set; }
        }

        public class HarnessAgentCoreRuntimeEnvironment : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AgentRuntimeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcoreruntimeenvironment.html#cfn-bedrockagentcore-harness-harnessagentcoreruntimeenvironment-agentruntimeid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AgentRuntimeId { get; set; }
            /// <summary>
            /// FilesystemConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcoreruntimeenvironment.html#cfn-bedrockagentcore-harness-harnessagentcoreruntimeenvironment-filesystemconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilesystemConfiguration
            /// </summary>
            public List<Humidifier.BedrockAgentCore.HarnessTypes.FilesystemConfiguration> FilesystemConfigurations { get; set; }
            /// <summary>
            /// LifecycleConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcoreruntimeenvironment.html#cfn-bedrockagentcore-harness-harnessagentcoreruntimeenvironment-lifecycleconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifecycleConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.LifecycleConfiguration LifecycleConfiguration { get; set; }
            /// <summary>
            /// NetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcoreruntimeenvironment.html#cfn-bedrockagentcore-harness-harnessagentcoreruntimeenvironment-networkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.NetworkConfiguration NetworkConfiguration { get; set; }
            /// <summary>
            /// AgentRuntimeArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcoreruntimeenvironment.html#cfn-bedrockagentcore-harness-harnessagentcoreruntimeenvironment-agentruntimearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AgentRuntimeArn { get; set; }
            /// <summary>
            /// AgentRuntimeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessagentcoreruntimeenvironment.html#cfn-bedrockagentcore-harness-harnessagentcoreruntimeenvironment-agentruntimename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AgentRuntimeName { get; set; }
        }

        public class HarnessBedrockModelConfig : Humidifier.Base.BaseSubResource, IHaveMaxTokens, IHaveModelId, IHaveTemperature, IHaveTopP
        {
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbedrockmodelconfig.html#cfn-bedrockagentcore-harness-harnessbedrockmodelconfig-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Temperature { get; set; }
            /// <summary>
            /// AdditionalParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbedrockmodelconfig.html#cfn-bedrockagentcore-harness-harnessbedrockmodelconfig-additionalparams
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AdditionalParams { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbedrockmodelconfig.html#cfn-bedrockagentcore-harness-harnessbedrockmodelconfig-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxTokens { get; set; }
            /// <summary>
            /// ApiFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbedrockmodelconfig.html#cfn-bedrockagentcore-harness-harnessbedrockmodelconfig-apiformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiFormat { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbedrockmodelconfig.html#cfn-bedrockagentcore-harness-harnessbedrockmodelconfig-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TopP { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbedrockmodelconfig.html#cfn-bedrockagentcore-harness-harnessbedrockmodelconfig-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class HarnessBeforeInvocationHook : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbeforeinvocationhook.html#cfn-bedrockagentcore-harness-harnessbeforeinvocationhook-target
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HarnessHookTarget
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget Target { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbeforeinvocationhook.html#cfn-bedrockagentcore-harness-harnessbeforeinvocationhook-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class HarnessBeforeToolCallHook : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbeforetoolcallhook.html#cfn-bedrockagentcore-harness-harnessbeforetoolcallhook-target
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HarnessHookTarget
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget Target { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessbeforetoolcallhook.html#cfn-bedrockagentcore-harness-harnessbeforetoolcallhook-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class HarnessEnvironmentArtifact : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContainerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessenvironmentartifact.html#cfn-bedrockagentcore-harness-harnessenvironmentartifact-containerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContainerConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration ContainerConfiguration { get; set; }
        }

        public class HarnessEnvironmentProvider : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AgentCoreRuntimeEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessenvironmentprovider.html#cfn-bedrockagentcore-harness-harnessenvironmentprovider-agentcoreruntimeenvironment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessAgentCoreRuntimeEnvironment
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreRuntimeEnvironment AgentCoreRuntimeEnvironment { get; set; }
        }

        public class HarnessGatewayOutboundAuth : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Oauth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgatewayoutboundauth.html#cfn-bedrockagentcore-harness-harnessgatewayoutboundauth-oauth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuthCredentialProvider
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider Oauth { get; set; }
            /// <summary>
            /// AwsIam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgatewayoutboundauth.html#cfn-bedrockagentcore-harness-harnessgatewayoutboundauth-awsiam
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AwsIam { get; set; }
            /// <summary>
            /// None
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgatewayoutboundauth.html#cfn-bedrockagentcore-harness-harnessgatewayoutboundauth-none
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic None { get; set; }
        }

        public class HarnessGeminiModelConfig : Humidifier.Base.BaseSubResource, IHaveMaxTokens, IHaveModelId, IHaveTemperature, IHaveTopP
        {
            /// <summary>
            /// TopK
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgeminimodelconfig.html#cfn-bedrockagentcore-harness-harnessgeminimodelconfig-topk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TopK { get; set; }
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgeminimodelconfig.html#cfn-bedrockagentcore-harness-harnessgeminimodelconfig-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Temperature { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgeminimodelconfig.html#cfn-bedrockagentcore-harness-harnessgeminimodelconfig-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxTokens { get; set; }
            /// <summary>
            /// ApiKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgeminimodelconfig.html#cfn-bedrockagentcore-harness-harnessgeminimodelconfig-apikeyarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKeyArn { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgeminimodelconfig.html#cfn-bedrockagentcore-harness-harnessgeminimodelconfig-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TopP { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessgeminimodelconfig.html#cfn-bedrockagentcore-harness-harnessgeminimodelconfig-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class HarnessHook : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AfterToolCall
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshook.html#cfn-bedrockagentcore-harness-harnesshook-aftertoolcall
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessAfterToolCallHook
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessAfterToolCallHook AfterToolCall { get; set; }
            /// <summary>
            /// BeforeToolCall
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshook.html#cfn-bedrockagentcore-harness-harnesshook-beforetoolcall
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessBeforeToolCallHook
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessBeforeToolCallHook BeforeToolCall { get; set; }
            /// <summary>
            /// AfterInvocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshook.html#cfn-bedrockagentcore-harness-harnesshook-afterinvocation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessAfterInvocationHook
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessAfterInvocationHook AfterInvocation { get; set; }
            /// <summary>
            /// BeforeInvocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshook.html#cfn-bedrockagentcore-harness-harnesshook-beforeinvocation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessBeforeInvocationHook
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessBeforeInvocationHook BeforeInvocation { get; set; }
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
            public dynamic Arn { get; set; }
        }

        public class HarnessHookLambdaTarget : Humidifier.Base.BaseSubResource, IHaveArn, IHaveTimeoutSeconds, IHaveFailureMode
        {
            /// <summary>
            /// TimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshooklambdatarget.html#cfn-bedrockagentcore-harness-harnesshooklambdatarget-timeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutSeconds { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshooklambdatarget.html#cfn-bedrockagentcore-harness-harnesshooklambdatarget-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// FailureMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshooklambdatarget.html#cfn-bedrockagentcore-harness-harnesshooklambdatarget-failuremode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FailureMode { get; set; }
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
            public dynamic Arn { get; set; }
        }

        public class HarnessHookTarget : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Sns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshooktarget.html#cfn-bedrockagentcore-harness-harnesshooktarget-sns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessHookSnsTarget
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookSnsTarget Sns { get; set; }
            /// <summary>
            /// Lambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshooktarget.html#cfn-bedrockagentcore-harness-harnesshooktarget-lambda
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessHookLambdaTarget
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookLambdaTarget Lambda { get; set; }
            /// <summary>
            /// EventBridge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesshooktarget.html#cfn-bedrockagentcore-harness-harnesshooktarget-eventbridge
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessHookEventBridgeTarget
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookEventBridgeTarget EventBridge { get; set; }
        }

        public class HarnessInlineFunctionConfig : Humidifier.Base.BaseSubResource, IHaveDescription
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessinlinefunctionconfig.html#cfn-bedrockagentcore-harness-harnessinlinefunctionconfig-description
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// InputSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessinlinefunctionconfig.html#cfn-bedrockagentcore-harness-harnessinlinefunctionconfig-inputschema
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic InputSchema { get; set; }
        }

        public class HarnessLiteLlmModelConfig : Humidifier.Base.BaseSubResource, IHaveMaxTokens, IHaveModelId, IHaveTemperature, IHaveTopP
        {
            /// <summary>
            /// ApiBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesslitellmmodelconfig.html#cfn-bedrockagentcore-harness-harnesslitellmmodelconfig-apibase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiBase { get; set; }
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesslitellmmodelconfig.html#cfn-bedrockagentcore-harness-harnesslitellmmodelconfig-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Temperature { get; set; }
            /// <summary>
            /// AdditionalParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesslitellmmodelconfig.html#cfn-bedrockagentcore-harness-harnesslitellmmodelconfig-additionalparams
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AdditionalParams { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesslitellmmodelconfig.html#cfn-bedrockagentcore-harness-harnesslitellmmodelconfig-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxTokens { get; set; }
            /// <summary>
            /// ApiKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesslitellmmodelconfig.html#cfn-bedrockagentcore-harness-harnesslitellmmodelconfig-apikeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKeyArn { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesslitellmmodelconfig.html#cfn-bedrockagentcore-harness-harnesslitellmmodelconfig-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TopP { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesslitellmmodelconfig.html#cfn-bedrockagentcore-harness-harnesslitellmmodelconfig-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class HarnessManagedMemoryConfiguration : Humidifier.Base.BaseSubResource, IHaveArn, IHaveEncryptionKeyArn
        {
            /// <summary>
            /// EncryptionKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmanagedmemoryconfiguration.html#cfn-bedrockagentcore-harness-harnessmanagedmemoryconfiguration-encryptionkeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionKeyArn { get; set; }
            /// <summary>
            /// Strategies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmanagedmemoryconfiguration.html#cfn-bedrockagentcore-harness-harnessmanagedmemoryconfiguration-strategies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Strategies { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmanagedmemoryconfiguration.html#cfn-bedrockagentcore-harness-harnessmanagedmemoryconfiguration-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// EventExpiryDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmanagedmemoryconfiguration.html#cfn-bedrockagentcore-harness-harnessmanagedmemoryconfiguration-eventexpiryduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EventExpiryDuration { get; set; }
        }

        public class HarnessMemoryConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ManagedMemoryConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmemoryconfiguration.html#cfn-bedrockagentcore-harness-harnessmemoryconfiguration-managedmemoryconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessManagedMemoryConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessManagedMemoryConfiguration ManagedMemoryConfiguration { get; set; }
            /// <summary>
            /// Disabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmemoryconfiguration.html#cfn-bedrockagentcore-harness-harnessmemoryconfiguration-disabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Disabled { get; set; }
            /// <summary>
            /// AgentCoreMemoryConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmemoryconfiguration.html#cfn-bedrockagentcore-harness-harnessmemoryconfiguration-agentcorememoryconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessAgentCoreMemoryConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreMemoryConfiguration AgentCoreMemoryConfiguration { get; set; }
        }

        public class HarnessModelConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LiteLlmModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmodelconfiguration.html#cfn-bedrockagentcore-harness-harnessmodelconfiguration-litellmmodelconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessLiteLlmModelConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessLiteLlmModelConfig LiteLlmModelConfig { get; set; }
            /// <summary>
            /// BedrockModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmodelconfiguration.html#cfn-bedrockagentcore-harness-harnessmodelconfiguration-bedrockmodelconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessBedrockModelConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessBedrockModelConfig BedrockModelConfig { get; set; }
            /// <summary>
            /// GeminiModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmodelconfiguration.html#cfn-bedrockagentcore-harness-harnessmodelconfiguration-geminimodelconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessGeminiModelConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessGeminiModelConfig GeminiModelConfig { get; set; }
            /// <summary>
            /// OpenAiModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessmodelconfiguration.html#cfn-bedrockagentcore-harness-harnessmodelconfiguration-openaimodelconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessOpenAiModelConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessOpenAiModelConfig OpenAiModelConfig { get; set; }
        }

        public class HarnessOpenAiModelConfig : Humidifier.Base.BaseSubResource, IHaveMaxTokens, IHaveModelId, IHaveTemperature, IHaveTopP
        {
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessopenaimodelconfig.html#cfn-bedrockagentcore-harness-harnessopenaimodelconfig-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Temperature { get; set; }
            /// <summary>
            /// AdditionalParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessopenaimodelconfig.html#cfn-bedrockagentcore-harness-harnessopenaimodelconfig-additionalparams
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AdditionalParams { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessopenaimodelconfig.html#cfn-bedrockagentcore-harness-harnessopenaimodelconfig-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxTokens { get; set; }
            /// <summary>
            /// ApiFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessopenaimodelconfig.html#cfn-bedrockagentcore-harness-harnessopenaimodelconfig-apiformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiFormat { get; set; }
            /// <summary>
            /// ApiKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessopenaimodelconfig.html#cfn-bedrockagentcore-harness-harnessopenaimodelconfig-apikeyarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKeyArn { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessopenaimodelconfig.html#cfn-bedrockagentcore-harness-harnessopenaimodelconfig-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TopP { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessopenaimodelconfig.html#cfn-bedrockagentcore-harness-harnessopenaimodelconfig-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class HarnessRemoteMcpConfig : Humidifier.Base.BaseSubResource, IHaveUrl
        {
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessremotemcpconfig.html#cfn-bedrockagentcore-harness-harnessremotemcpconfig-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Headers { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessremotemcpconfig.html#cfn-bedrockagentcore-harness-harnessremotemcpconfig-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }

        public class HarnessSkill : Humidifier.Base.BaseSubResource, IHavePath
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskill.html#cfn-bedrockagentcore-harness-harnessskill-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskill.html#cfn-bedrockagentcore-harness-harnessskill-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessSkillS3Source
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillS3Source S3 { get; set; }
            /// <summary>
            /// Git
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskill.html#cfn-bedrockagentcore-harness-harnessskill-git
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessSkillGitSource
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitSource Git { get; set; }
            /// <summary>
            /// AwsSkills
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskill.html#cfn-bedrockagentcore-harness-harnessskill-awsskills
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessSkillAwsSkillsSource
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillAwsSkillsSource AwsSkills { get; set; }
        }

        public class HarnessSkillAwsSkillsSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Paths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskillawsskillssource.html#cfn-bedrockagentcore-harness-harnessskillawsskillssource-paths
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Paths { get; set; }
        }

        public class HarnessSkillGitAuth : Humidifier.Base.BaseSubResource, IHaveUsername
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskillgitauth.html#cfn-bedrockagentcore-harness-harnessskillgitauth-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Username { get; set; }
            /// <summary>
            /// CredentialArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskillgitauth.html#cfn-bedrockagentcore-harness-harnessskillgitauth-credentialarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialArn { get; set; }
        }

        public class HarnessSkillGitSource : Humidifier.Base.BaseSubResource, IHavePath, IHaveUrl
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskillgitsource.html#cfn-bedrockagentcore-harness-harnessskillgitsource-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// Auth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskillgitsource.html#cfn-bedrockagentcore-harness-harnessskillgitsource-auth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessSkillGitAuth
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth Auth { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessskillgitsource.html#cfn-bedrockagentcore-harness-harnessskillgitsource-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
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
            public dynamic Uri { get; set; }
        }

        public class HarnessSlidingWindowConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MessagesCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnessslidingwindowconfiguration.html#cfn-bedrockagentcore-harness-harnessslidingwindowconfiguration-messagescount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MessagesCount { get; set; }
        }

        public class HarnessSummarizationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SummarizationSystemPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesssummarizationconfiguration.html#cfn-bedrockagentcore-harness-harnesssummarizationconfiguration-summarizationsystemprompt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SummarizationSystemPrompt { get; set; }
            /// <summary>
            /// PreserveRecentMessages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesssummarizationconfiguration.html#cfn-bedrockagentcore-harness-harnesssummarizationconfiguration-preserverecentmessages
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PreserveRecentMessages { get; set; }
            /// <summary>
            /// SummaryRatio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesssummarizationconfiguration.html#cfn-bedrockagentcore-harness-harnesssummarizationconfiguration-summaryratio
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic SummaryRatio { get; set; }
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
            public dynamic Text { get; set; }
        }

        public class HarnessTool : Humidifier.Base.BaseSubResource, IHaveName, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstool.html#cfn-bedrockagentcore-harness-harnesstool-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Config
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstool.html#cfn-bedrockagentcore-harness-harnesstool-config
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessToolConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessToolConfiguration Config { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstool.html#cfn-bedrockagentcore-harness-harnesstool-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class HarnessToolConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RemoteMcp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstoolconfiguration.html#cfn-bedrockagentcore-harness-harnesstoolconfiguration-remotemcp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessRemoteMcpConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessRemoteMcpConfig RemoteMcp { get; set; }
            /// <summary>
            /// AgentCoreCodeInterpreter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstoolconfiguration.html#cfn-bedrockagentcore-harness-harnesstoolconfiguration-agentcorecodeinterpreter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessAgentCoreCodeInterpreterConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreCodeInterpreterConfig AgentCoreCodeInterpreter { get; set; }
            /// <summary>
            /// AgentCoreGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstoolconfiguration.html#cfn-bedrockagentcore-harness-harnesstoolconfiguration-agentcoregateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessAgentCoreGatewayConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreGatewayConfig AgentCoreGateway { get; set; }
            /// <summary>
            /// InlineFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstoolconfiguration.html#cfn-bedrockagentcore-harness-harnesstoolconfiguration-inlinefunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessInlineFunctionConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessInlineFunctionConfig InlineFunction { get; set; }
            /// <summary>
            /// AgentCoreBrowser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstoolconfiguration.html#cfn-bedrockagentcore-harness-harnesstoolconfiguration-agentcorebrowser
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessAgentCoreBrowserConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreBrowserConfig AgentCoreBrowser { get; set; }
        }

        public class HarnessTruncationConfiguration : Humidifier.Base.BaseSubResource, IHaveStrategy
        {
            /// <summary>
            /// Config
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstruncationconfiguration.html#cfn-bedrockagentcore-harness-harnesstruncationconfiguration-config
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessTruncationStrategyConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationStrategyConfiguration Config { get; set; }
            /// <summary>
            /// Strategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstruncationconfiguration.html#cfn-bedrockagentcore-harness-harnesstruncationconfiguration-strategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Strategy { get; set; }
        }

        public class HarnessTruncationStrategyConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SlidingWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstruncationstrategyconfiguration.html#cfn-bedrockagentcore-harness-harnesstruncationstrategyconfiguration-slidingwindow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessSlidingWindowConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessSlidingWindowConfiguration SlidingWindow { get; set; }
            /// <summary>
            /// Summarization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-harnesstruncationstrategyconfiguration.html#cfn-bedrockagentcore-harness-harnesstruncationstrategyconfiguration-summarization
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HarnessSummarizationConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.HarnessSummarizationConfiguration Summarization { get; set; }
        }

        public class LifecycleConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxLifetime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-lifecycleconfiguration.html#cfn-bedrockagentcore-harness-lifecycleconfiguration-maxlifetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxLifetime { get; set; }
            /// <summary>
            /// IdleRuntimeSessionTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-lifecycleconfiguration.html#cfn-bedrockagentcore-harness-lifecycleconfiguration-idleruntimesessiontimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IdleRuntimeSessionTimeout { get; set; }
        }

        public class ManagedVpcResource : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds, IHaveVpcIdentifier
        {
            /// <summary>
            /// RoutingDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-managedvpcresource.html#cfn-bedrockagentcore-harness-managedvpcresource-routingdomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoutingDomain { get; set; }
            /// <summary>
            /// VpcIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-managedvpcresource.html#cfn-bedrockagentcore-harness-managedvpcresource-vpcidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcIdentifier { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-managedvpcresource.html#cfn-bedrockagentcore-harness-managedvpcresource-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
            /// <summary>
            /// EndpointIpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-managedvpcresource.html#cfn-bedrockagentcore-harness-managedvpcresource-endpointipaddresstype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndpointIpAddressType { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-managedvpcresource.html#cfn-bedrockagentcore-harness-managedvpcresource-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-managedvpcresource.html#cfn-bedrockagentcore-harness-managedvpcresource-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Tags { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NetworkModeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-networkconfiguration.html#cfn-bedrockagentcore-harness-networkconfiguration-networkmodeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig NetworkModeConfig { get; set; }
            /// <summary>
            /// NetworkMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-networkconfiguration.html#cfn-bedrockagentcore-harness-networkconfiguration-networkmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NetworkMode { get; set; }
        }

        public class OAuthCredentialProvider : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultReturnUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-oauthcredentialprovider.html#cfn-bedrockagentcore-harness-oauthcredentialprovider-defaultreturnurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultReturnUrl { get; set; }
            /// <summary>
            /// ProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-oauthcredentialprovider.html#cfn-bedrockagentcore-harness-oauthcredentialprovider-providerarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProviderArn { get; set; }
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-oauthcredentialprovider.html#cfn-bedrockagentcore-harness-oauthcredentialprovider-scopes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Scopes { get; set; }
            /// <summary>
            /// GrantType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-oauthcredentialprovider.html#cfn-bedrockagentcore-harness-oauthcredentialprovider-granttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GrantType { get; set; }
            /// <summary>
            /// CustomParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-oauthcredentialprovider.html#cfn-bedrockagentcore-harness-oauthcredentialprovider-customparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> CustomParameters { get; set; }
        }

        public class PrivateEndpoint : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SelfManagedLatticeResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-privateendpoint.html#cfn-bedrockagentcore-harness-privateendpoint-selfmanagedlatticeresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelfManagedLatticeResource
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.SelfManagedLatticeResource SelfManagedLatticeResource { get; set; }
            /// <summary>
            /// ManagedVpcResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-privateendpoint.html#cfn-bedrockagentcore-harness-privateendpoint-managedvpcresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedVpcResource
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.ManagedVpcResource ManagedVpcResource { get; set; }
        }

        public class PrivateEndpointOverride : Humidifier.Base.BaseSubResource, IHaveDomain
        {
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-privateendpointoverride.html#cfn-bedrockagentcore-harness-privateendpointoverride-domain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Domain { get; set; }
            /// <summary>
            /// PrivateEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-privateendpointoverride.html#cfn-bedrockagentcore-harness-privateendpointoverride-privateendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrivateEndpoint
            /// </summary>
            public Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint PrivateEndpoint { get; set; }
        }

        public class S3FilesAccessPointConfiguration : Humidifier.Base.BaseSubResource, IHaveAccessPointArn, IHaveMountPath
        {
            /// <summary>
            /// MountPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-s3filesaccesspointconfiguration.html#cfn-bedrockagentcore-harness-s3filesaccesspointconfiguration-mountpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MountPath { get; set; }
            /// <summary>
            /// AccessPointArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-s3filesaccesspointconfiguration.html#cfn-bedrockagentcore-harness-s3filesaccesspointconfiguration-accesspointarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccessPointArn { get; set; }
        }

        public class SelfManagedLatticeResource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResourceConfigurationIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-selfmanagedlatticeresource.html#cfn-bedrockagentcore-harness-selfmanagedlatticeresource-resourceconfigurationidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceConfigurationIdentifier { get; set; }
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
            public dynamic MountPath { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveSubnets, IHaveSecurityGroups
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-vpcconfig.html#cfn-bedrockagentcore-harness-vpcconfig-securitygroups
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-harness-vpcconfig.html#cfn-bedrockagentcore-harness-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets { get; set; }
        }
    }
}