namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using AgentTypes;

    public class Agent : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfBedrockAgentTypesAgentCollaboratorAgentCollaborators, IHaveDescription, IHaveSkipResourceInUseCheckOnDelete_Boolean, IHaveBedrockAgentTypesGuardrailConfigurationGuardrailConfiguration, IHaveBedrockAgentTypesPromptOverrideConfigurationPromptOverrideConfiguration, IHaveBedrockAgentTypesMemoryConfigurationMemoryConfiguration, IHaveAgentCollaboration, IHaveInstruction, IHaveBedrockAgentTypesCustomOrchestrationCustomOrchestration, IHaveStringDictionaryOfTestAliasTags, IHaveAgentResourceRoleArn, IHaveOrchestrationType, IHaveIdleSessionTTLInSeconds_Double, IHaveFoundationModel, IHaveCustomerEncryptionKeyArn, IHaveAgentName, IHaveListOfBedrockAgentTypesAgentKnowledgeBaseKnowledgeBases, IHaveListOfBedrockAgentTypesAgentActionGroupActionGroups, IHaveAutoPrepare_Boolean, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string AgentArn =  "AgentArn" ;
            public static string AgentStatus =  "AgentStatus" ;
            public static string AgentVersion =  "AgentVersion" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string PreparedAt =  "PreparedAt" ;
            public static string AgentId =  "AgentId" ;
            public static string FailureReasons =  "FailureReasons" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string RecommendedActions =  "RecommendedActions" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.Agent; }
        /// <summary>
        /// AgentCollaborators
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-agentcollaborators
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AgentCollaborator
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Bedrock.AgentTypes.AgentCollaborator>, IReadOnlyList<Union<Humidifier.Bedrock.AgentTypes.AgentCollaborator, BaseFunction>>, BaseFunction>? AgentCollaborators { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// SkipResourceInUseCheckOnDelete
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-skipresourceinusecheckondelete
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SkipResourceInUseCheckOnDelete { get; set; }
        /// <summary>
        /// GuardrailConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-guardrailconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GuardrailConfiguration
        /// </summary>
        public Union<Humidifier.Bedrock.AgentTypes.GuardrailConfiguration, BaseFunction>? GuardrailConfiguration { get; set; }
        /// <summary>
        /// PromptOverrideConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-promptoverrideconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PromptOverrideConfiguration
        /// </summary>
        public Union<Humidifier.Bedrock.AgentTypes.PromptOverrideConfiguration, BaseFunction>? PromptOverrideConfiguration { get; set; }
        /// <summary>
        /// MemoryConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-memoryconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MemoryConfiguration
        /// </summary>
        public Union<Humidifier.Bedrock.AgentTypes.MemoryConfiguration, BaseFunction>? MemoryConfiguration { get; set; }
        /// <summary>
        /// AgentCollaboration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-agentcollaboration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AgentCollaboration { get; set; }
        /// <summary>
        /// Instruction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-instruction
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Instruction { get; set; }
        /// <summary>
        /// CustomOrchestration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-customorchestration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomOrchestration
        /// </summary>
        public Union<Humidifier.Bedrock.AgentTypes.CustomOrchestration, BaseFunction>? CustomOrchestration { get; set; }
        /// <summary>
        /// TestAliasTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-testaliastags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? TestAliasTags { get; set; }
        /// <summary>
        /// AgentResourceRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-agentresourcerolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AgentResourceRoleArn { get; set; }
        /// <summary>
        /// OrchestrationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-orchestrationtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OrchestrationType { get; set; }
        /// <summary>
        /// IdleSessionTTLInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-idlesessionttlinseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? IdleSessionTTLInSeconds { get; set; }
        /// <summary>
        /// FoundationModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-foundationmodel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FoundationModel { get; set; }
        /// <summary>
        /// CustomerEncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-customerencryptionkeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CustomerEncryptionKeyArn { get; set; }
        public Union<string, BaseFunction>? AgentName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// KnowledgeBases
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-knowledgebases
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AgentKnowledgeBase
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Bedrock.AgentTypes.AgentKnowledgeBase>, IReadOnlyList<Union<Humidifier.Bedrock.AgentTypes.AgentKnowledgeBase, BaseFunction>>, BaseFunction>? KnowledgeBases { get; set; }
        /// <summary>
        /// ActionGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-actiongroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AgentActionGroup
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Bedrock.AgentTypes.AgentActionGroup>, IReadOnlyList<Union<Humidifier.Bedrock.AgentTypes.AgentActionGroup, BaseFunction>>, BaseFunction>? ActionGroups { get; set; }
        /// <summary>
        /// AutoPrepare
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-autoprepare
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AutoPrepare { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace AgentTypes
    {
        public class APISchema : Humidifier.Base.BaseSubResource, IHaveBedrockAgentTypesS3IdentifierS3, IHavePayload
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-apischema.html#cfn-bedrock-agent-apischema-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Identifier
            /// </summary>
            public Union<Humidifier.Bedrock.AgentTypes.S3Identifier, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-apischema.html#cfn-bedrock-agent-apischema-payload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Payload { get; set; }
        }

        public class ActionGroupExecutor : Humidifier.Base.BaseSubResource, IHaveCustomControl, IHaveLambda
        {
            /// <summary>
            /// CustomControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-actiongroupexecutor.html#cfn-bedrock-agent-actiongroupexecutor-customcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomControl { get; set; }
            /// <summary>
            /// Lambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-actiongroupexecutor.html#cfn-bedrock-agent-actiongroupexecutor-lambda
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Lambda { get; set; }
        }

        public class AgentActionGroup : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveBedrockAgentTypesAPISchemaApiSchema, IHaveBedrockAgentTypesFunctionSchemaFunctionSchema, IHaveSkipResourceInUseCheckOnDelete_Boolean, IHaveParentActionGroupSignature, IHaveBedrockAgentTypesActionGroupExecutorActionGroupExecutor, IHaveActionGroupName, IHaveActionGroupState
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentactiongroup.html#cfn-bedrock-agent-agentactiongroup-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// ApiSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentactiongroup.html#cfn-bedrock-agent-agentactiongroup-apischema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: APISchema
            /// </summary>
            public Union<Humidifier.Bedrock.AgentTypes.APISchema, BaseFunction>? ApiSchema { get; set; }
            /// <summary>
            /// FunctionSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentactiongroup.html#cfn-bedrock-agent-agentactiongroup-functionschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunctionSchema
            /// </summary>
            public Union<Humidifier.Bedrock.AgentTypes.FunctionSchema, BaseFunction>? FunctionSchema { get; set; }
            /// <summary>
            /// SkipResourceInUseCheckOnDelete
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentactiongroup.html#cfn-bedrock-agent-agentactiongroup-skipresourceinusecheckondelete
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SkipResourceInUseCheckOnDelete { get; set; }
            /// <summary>
            /// ParentActionGroupSignature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentactiongroup.html#cfn-bedrock-agent-agentactiongroup-parentactiongroupsignature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParentActionGroupSignature { get; set; }
            /// <summary>
            /// ActionGroupExecutor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentactiongroup.html#cfn-bedrock-agent-agentactiongroup-actiongroupexecutor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ActionGroupExecutor
            /// </summary>
            public Union<Humidifier.Bedrock.AgentTypes.ActionGroupExecutor, BaseFunction>? ActionGroupExecutor { get; set; }
            /// <summary>
            /// ActionGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentactiongroup.html#cfn-bedrock-agent-agentactiongroup-actiongroupname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionGroupName { get; set; }
            /// <summary>
            /// ActionGroupState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentactiongroup.html#cfn-bedrock-agent-agentactiongroup-actiongroupstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionGroupState { get; set; }
        }

        public class AgentCollaborator : Humidifier.Base.BaseSubResource, IHaveBedrockAgentTypesAgentDescriptorAgentDescriptor, IHaveCollaborationInstruction, IHaveRelayConversationHistory, IHaveCollaboratorName
        {
            /// <summary>
            /// AgentDescriptor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentcollaborator.html#cfn-bedrock-agent-agentcollaborator-agentdescriptor
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AgentDescriptor
            /// </summary>
            public Union<Humidifier.Bedrock.AgentTypes.AgentDescriptor, BaseFunction>? AgentDescriptor { get; set; }
            /// <summary>
            /// CollaborationInstruction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentcollaborator.html#cfn-bedrock-agent-agentcollaborator-collaborationinstruction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CollaborationInstruction { get; set; }
            /// <summary>
            /// RelayConversationHistory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentcollaborator.html#cfn-bedrock-agent-agentcollaborator-relayconversationhistory
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RelayConversationHistory { get; set; }
            /// <summary>
            /// CollaboratorName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentcollaborator.html#cfn-bedrock-agent-agentcollaborator-collaboratorname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CollaboratorName { get; set; }
        }

        public class AgentDescriptor : Humidifier.Base.BaseSubResource, IHaveAliasArn
        {
            /// <summary>
            /// AliasArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentdescriptor.html#cfn-bedrock-agent-agentdescriptor-aliasarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AliasArn { get; set; }
        }

        public class AgentKnowledgeBase : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveKnowledgeBaseState, IHaveKnowledgeBaseId
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentknowledgebase.html#cfn-bedrock-agent-agentknowledgebase-description
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// KnowledgeBaseState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentknowledgebase.html#cfn-bedrock-agent-agentknowledgebase-knowledgebasestate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KnowledgeBaseState { get; set; }
            /// <summary>
            /// KnowledgeBaseId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentknowledgebase.html#cfn-bedrock-agent-agentknowledgebase-knowledgebaseid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KnowledgeBaseId { get; set; }
        }

        public class CustomOrchestration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentTypesOrchestrationExecutorExecutor
        {
            /// <summary>
            /// Executor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-customorchestration.html#cfn-bedrock-agent-customorchestration-executor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OrchestrationExecutor
            /// </summary>
            public Union<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor, BaseFunction>? Executor { get; set; }
        }

        public class Function : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveMapOfBedrockAgentTypesParameterDetailParameters, IHaveRequireConfirmation, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-function.html#cfn-bedrock-agent-function-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-function.html#cfn-bedrock-agent-function-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: ParameterDetail
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.Bedrock.AgentTypes.ParameterDetail>, IReadOnlyDictionary<string, Union<Humidifier.Bedrock.AgentTypes.ParameterDetail, BaseFunction>>, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// RequireConfirmation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-function.html#cfn-bedrock-agent-function-requireconfirmation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RequireConfirmation { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-function.html#cfn-bedrock-agent-function-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class FunctionSchema : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentTypesFunctionFunctions
        {
            /// <summary>
            /// Functions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-functionschema.html#cfn-bedrock-agent-functionschema-functions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Function
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.AgentTypes.Function>, IReadOnlyList<Union<Humidifier.Bedrock.AgentTypes.Function, BaseFunction>>, BaseFunction>? Functions { get; set; }
        }

        public class GuardrailConfiguration : Humidifier.Base.BaseSubResource, IHaveGuardrailIdentifier, IHaveGuardrailVersion
        {
            /// <summary>
            /// GuardrailIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-guardrailconfiguration.html#cfn-bedrock-agent-guardrailconfiguration-guardrailidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GuardrailIdentifier { get; set; }
            /// <summary>
            /// GuardrailVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-guardrailconfiguration.html#cfn-bedrock-agent-guardrailconfiguration-guardrailversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GuardrailVersion { get; set; }
        }

        public class InferenceConfiguration : Humidifier.Base.BaseSubResource, IHaveTopK_Double, IHaveTemperature_Double, IHaveMaximumLength_Double, IHaveStringListOfStopSequences, IHaveTopP_Double
        {
            /// <summary>
            /// TopK
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-inferenceconfiguration.html#cfn-bedrock-agent-inferenceconfiguration-topk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TopK { get; set; }
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-inferenceconfiguration.html#cfn-bedrock-agent-inferenceconfiguration-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Temperature { get; set; }
            /// <summary>
            /// MaximumLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-inferenceconfiguration.html#cfn-bedrock-agent-inferenceconfiguration-maximumlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaximumLength { get; set; }
            /// <summary>
            /// StopSequences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-inferenceconfiguration.html#cfn-bedrock-agent-inferenceconfiguration-stopsequences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StopSequences { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-inferenceconfiguration.html#cfn-bedrock-agent-inferenceconfiguration-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TopP { get; set; }
        }

        public class MemoryConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentTypesSessionSummaryConfigurationSessionSummaryConfiguration, IHaveStringListOfEnabledMemoryTypes, IHaveStorageDays_Double
        {
            /// <summary>
            /// SessionSummaryConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-memoryconfiguration.html#cfn-bedrock-agent-memoryconfiguration-sessionsummaryconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SessionSummaryConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration, BaseFunction>? SessionSummaryConfiguration { get; set; }
            /// <summary>
            /// EnabledMemoryTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-memoryconfiguration.html#cfn-bedrock-agent-memoryconfiguration-enabledmemorytypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EnabledMemoryTypes { get; set; }
            /// <summary>
            /// StorageDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-memoryconfiguration.html#cfn-bedrock-agent-memoryconfiguration-storagedays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? StorageDays { get; set; }
        }

        public class OrchestrationExecutor : Humidifier.Base.BaseSubResource, IHaveLambda
        {
            /// <summary>
            /// Lambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-orchestrationexecutor.html#cfn-bedrock-agent-orchestrationexecutor-lambda
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Lambda { get; set; }
        }

        public class ParameterDetail : Humidifier.Base.BaseSubResource, IHaveType, IHaveDescription, IHaveRequired_Boolean
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-parameterdetail.html#cfn-bedrock-agent-parameterdetail-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-parameterdetail.html#cfn-bedrock-agent-parameterdetail-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-parameterdetail.html#cfn-bedrock-agent-parameterdetail-required
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Required { get; set; }
        }

        public class PromptConfiguration : Humidifier.Base.BaseSubResource, IHavePromptType, IHavePromptState, IHaveAdditionalModelRequestFields_Json, IHaveBasePromptTemplate, IHaveFoundationModel, IHaveBedrockAgentTypesInferenceConfigurationInferenceConfiguration, IHavePromptCreationMode, IHaveParserMode
        {
            /// <summary>
            /// PromptType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptconfiguration.html#cfn-bedrock-agent-promptconfiguration-prompttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PromptType { get; set; }
            /// <summary>
            /// PromptState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptconfiguration.html#cfn-bedrock-agent-promptconfiguration-promptstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PromptState { get; set; }
            /// <summary>
            /// AdditionalModelRequestFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptconfiguration.html#cfn-bedrock-agent-promptconfiguration-additionalmodelrequestfields
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AdditionalModelRequestFields { get; set; }
            /// <summary>
            /// BasePromptTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptconfiguration.html#cfn-bedrock-agent-promptconfiguration-baseprompttemplate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BasePromptTemplate { get; set; }
            /// <summary>
            /// FoundationModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptconfiguration.html#cfn-bedrock-agent-promptconfiguration-foundationmodel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FoundationModel { get; set; }
            /// <summary>
            /// InferenceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptconfiguration.html#cfn-bedrock-agent-promptconfiguration-inferenceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.AgentTypes.InferenceConfiguration, BaseFunction>? InferenceConfiguration { get; set; }
            /// <summary>
            /// PromptCreationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptconfiguration.html#cfn-bedrock-agent-promptconfiguration-promptcreationmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PromptCreationMode { get; set; }
            /// <summary>
            /// ParserMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptconfiguration.html#cfn-bedrock-agent-promptconfiguration-parsermode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParserMode { get; set; }
        }

        public class PromptOverrideConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentTypesPromptConfigurationPromptConfigurations, IHaveOverrideLambda
        {
            /// <summary>
            /// PromptConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptoverrideconfiguration.html#cfn-bedrock-agent-promptoverrideconfiguration-promptconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PromptConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.AgentTypes.PromptConfiguration>, IReadOnlyList<Union<Humidifier.Bedrock.AgentTypes.PromptConfiguration, BaseFunction>>, BaseFunction>? PromptConfigurations { get; set; }
            /// <summary>
            /// OverrideLambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptoverrideconfiguration.html#cfn-bedrock-agent-promptoverrideconfiguration-overridelambda
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OverrideLambda { get; set; }
        }

        public class S3Identifier : Humidifier.Base.BaseSubResource, IHaveS3BucketName, IHaveS3ObjectKey
        {
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-s3identifier.html#cfn-bedrock-agent-s3identifier-s3bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketName { get; set; }
            /// <summary>
            /// S3ObjectKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-s3identifier.html#cfn-bedrock-agent-s3identifier-s3objectkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3ObjectKey { get; set; }
        }

        public class SessionSummaryConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxRecentSessions_Double
        {
            /// <summary>
            /// MaxRecentSessions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-sessionsummaryconfiguration.html#cfn-bedrock-agent-sessionsummaryconfiguration-maxrecentsessions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxRecentSessions { get; set; }
        }
    }
}