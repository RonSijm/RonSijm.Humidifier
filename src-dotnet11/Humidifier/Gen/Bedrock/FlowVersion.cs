namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using FlowVersionTypes;

    public class FlowVersion : Humidifier.Base.BaseResource, IHaveDescription, IHaveFlowArn
    {
        public class Attributes
        {
            public static string FlowId =  "FlowId" ;
            public static string Status =  "Status" ;
            public static string ExecutionRoleArn =  "ExecutionRoleArn" ;
            public static string Version =  "Version" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Definition =  "Definition" ;
            public static string CustomerEncryptionKeyArn =  "CustomerEncryptionKeyArn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.FlowVersion; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flowversion.html#cfn-bedrock-flowversion-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// FlowArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flowversion.html#cfn-bedrock-flowversion-flowarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FlowArn { get; set; }
    }

    namespace FlowVersionTypes
    {
        public class AgentFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveAgentAliasArn
        {
            /// <summary>
            /// AgentAliasArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-agentflownodeconfiguration.html#cfn-bedrock-flowversion-agentflownodeconfiguration-agentaliasarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AgentAliasArn { get; set; }
        }

        public class ConditionFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockFlowVersionTypesFlowConditionConditions
        {
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-conditionflownodeconfiguration.html#cfn-bedrock-flowversion-conditionflownodeconfiguration-conditions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.FlowVersionTypes.FlowCondition>, IReadOnlyList<Union<Humidifier.Bedrock.FlowVersionTypes.FlowCondition, BaseFunction>>, BaseFunction>? Conditions { get; set; }
        }

        public class FieldForReranking : Humidifier.Base.BaseSubResource, IHaveFieldName
        {
            /// <summary>
            /// FieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-fieldforreranking.html#cfn-bedrock-flowversion-fieldforreranking-fieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldName { get; set; }
        }

        public class FlowCondition : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveName
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowcondition.html#cfn-bedrock-flowversion-flowcondition-expression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowcondition.html#cfn-bedrock-flowversion-flowcondition-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class FlowConditionalConnectionConfiguration : Humidifier.Base.BaseSubResource, IHaveCondition
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowconditionalconnectionconfiguration.html#cfn-bedrock-flowversion-flowconditionalconnectionconfiguration-condition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Condition { get; set; }
        }

        public class FlowConnection : Humidifier.Base.BaseSubResource, IHaveType, IHaveTarget, IHaveBedrockFlowVersionTypesFlowConnectionConfigurationConfiguration, IHaveSource, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowconnection.html#cfn-bedrock-flowversion-flowconnection-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowconnection.html#cfn-bedrock-flowversion-flowconnection-target
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Target { get; set; }
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowconnection.html#cfn-bedrock-flowversion-flowconnection-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowConnectionConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.FlowConnectionConfiguration, BaseFunction>? Configuration { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowconnection.html#cfn-bedrock-flowversion-flowconnection-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowconnection.html#cfn-bedrock-flowversion-flowconnection-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class FlowConnectionConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowVersionTypesFlowDataConnectionConfigurationData, IHaveBedrockFlowVersionTypesFlowConditionalConnectionConfigurationConditional
        {
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowconnectionconfiguration.html#cfn-bedrock-flowversion-flowconnectionconfiguration-data
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowDataConnectionConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.FlowDataConnectionConfiguration, BaseFunction>? Data { get; set; }
            /// <summary>
            /// Conditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowconnectionconfiguration.html#cfn-bedrock-flowversion-flowconnectionconfiguration-conditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowConditionalConnectionConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.FlowConditionalConnectionConfiguration, BaseFunction>? Conditional { get; set; }
        }

        public class FlowDataConnectionConfiguration : Humidifier.Base.BaseSubResource, IHaveSourceOutput, IHaveTargetInput
        {
            /// <summary>
            /// SourceOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowdataconnectionconfiguration.html#cfn-bedrock-flowversion-flowdataconnectionconfiguration-sourceoutput
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceOutput { get; set; }
            /// <summary>
            /// TargetInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowdataconnectionconfiguration.html#cfn-bedrock-flowversion-flowdataconnectionconfiguration-targetinput
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetInput { get; set; }
        }

        public class FlowDefinition : Humidifier.Base.BaseSubResource, IHaveListOfBedrockFlowVersionTypesFlowConnectionConnections, IHaveListOfBedrockFlowVersionTypesFlowNodeNodes
        {
            /// <summary>
            /// Connections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowdefinition.html#cfn-bedrock-flowversion-flowdefinition-connections
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowConnection
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.FlowVersionTypes.FlowConnection>, IReadOnlyList<Union<Humidifier.Bedrock.FlowVersionTypes.FlowConnection, BaseFunction>>, BaseFunction>? Connections { get; set; }
            /// <summary>
            /// Nodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowdefinition.html#cfn-bedrock-flowversion-flowdefinition-nodes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowNode
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.FlowVersionTypes.FlowNode>, IReadOnlyList<Union<Humidifier.Bedrock.FlowVersionTypes.FlowNode, BaseFunction>>, BaseFunction>? Nodes { get; set; }
        }

        public class FlowNode : Humidifier.Base.BaseSubResource, IHaveType, IHaveBedrockFlowVersionTypesFlowNodeConfigurationConfiguration, IHaveListOfBedrockFlowVersionTypesFlowNodeOutputOutputs, IHaveListOfBedrockFlowVersionTypesFlowNodeInputInputs, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownode.html#cfn-bedrock-flowversion-flownode-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownode.html#cfn-bedrock-flowversion-flownode-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.FlowNodeConfiguration, BaseFunction>? Configuration { get; set; }
            /// <summary>
            /// Outputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownode.html#cfn-bedrock-flowversion-flownode-outputs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowNodeOutput
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.FlowVersionTypes.FlowNodeOutput>, IReadOnlyList<Union<Humidifier.Bedrock.FlowVersionTypes.FlowNodeOutput, BaseFunction>>, BaseFunction>? Outputs { get; set; }
            /// <summary>
            /// Inputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownode.html#cfn-bedrock-flowversion-flownode-inputs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowNodeInput
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.FlowVersionTypes.FlowNodeInput>, IReadOnlyList<Union<Humidifier.Bedrock.FlowVersionTypes.FlowNodeInput, BaseFunction>>, BaseFunction>? Inputs { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownode.html#cfn-bedrock-flowversion-flownode-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class FlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowVersionTypesConditionFlowNodeConfigurationCondition, IHaveBedrockFlowVersionTypesRetrievalFlowNodeConfigurationRetrieval, IHaveBedrockFlowVersionTypesLoopFlowNodeConfigurationLoop, IHaveBedrockFlowVersionTypesAgentFlowNodeConfigurationAgent, IHaveBedrockFlowVersionTypesLambdaFunctionFlowNodeConfigurationLambdaFunction, IHaveBedrockFlowVersionTypesInlineCodeFlowNodeConfigurationInlineCode, IHaveBedrockFlowVersionTypesLoopControllerFlowNodeConfigurationLoopController, IHaveInput_Json, IHaveBedrockFlowVersionTypesStorageFlowNodeConfigurationStorage, IHaveBedrockFlowVersionTypesKnowledgeBaseFlowNodeConfigurationKnowledgeBase, IHaveOutput_Json, IHaveIterator_Json, IHaveCollector_Json, IHaveLoopInput_Json, IHaveBedrockFlowVersionTypesPromptFlowNodeConfigurationPrompt, IHaveBedrockFlowVersionTypesLexFlowNodeConfigurationLex
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-condition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.ConditionFlowNodeConfiguration, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// Retrieval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-retrieval
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetrievalFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.RetrievalFlowNodeConfiguration, BaseFunction>? Retrieval { get; set; }
            /// <summary>
            /// Loop
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-loop
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoopFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.LoopFlowNodeConfiguration, BaseFunction>? Loop { get; set; }
            /// <summary>
            /// Agent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-agent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AgentFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.AgentFlowNodeConfiguration, BaseFunction>? Agent { get; set; }
            /// <summary>
            /// LambdaFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-lambdafunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaFunctionFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.LambdaFunctionFlowNodeConfiguration, BaseFunction>? LambdaFunction { get; set; }
            /// <summary>
            /// InlineCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-inlinecode
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InlineCodeFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.InlineCodeFlowNodeConfiguration, BaseFunction>? InlineCode { get; set; }
            /// <summary>
            /// LoopController
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-loopcontroller
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoopControllerFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.LoopControllerFlowNodeConfiguration, BaseFunction>? LoopController { get; set; }
            /// <summary>
            /// Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-input
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Input { get; set; }
            /// <summary>
            /// Storage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-storage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StorageFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.StorageFlowNodeConfiguration, BaseFunction>? Storage { get; set; }
            /// <summary>
            /// KnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-knowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.KnowledgeBaseFlowNodeConfiguration, BaseFunction>? KnowledgeBase { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-output
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Output { get; set; }
            /// <summary>
            /// Iterator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-iterator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Iterator { get; set; }
            /// <summary>
            /// Collector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-collector
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Collector { get; set; }
            /// <summary>
            /// LoopInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-loopinput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? LoopInput { get; set; }
            /// <summary>
            /// Prompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-prompt
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.PromptFlowNodeConfiguration, BaseFunction>? Prompt { get; set; }
            /// <summary>
            /// Lex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-lex
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LexFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.LexFlowNodeConfiguration, BaseFunction>? Lex { get; set; }
        }

        public class FlowNodeInput : Humidifier.Base.BaseSubResource, IHaveType, IHaveExpression, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeinput.html#cfn-bedrock-flowversion-flownodeinput-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeinput.html#cfn-bedrock-flowversion-flownodeinput-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeinput.html#cfn-bedrock-flowversion-flownodeinput-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class FlowNodeOutput : Humidifier.Base.BaseSubResource, IHaveType, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeoutput.html#cfn-bedrock-flowversion-flownodeoutput-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeoutput.html#cfn-bedrock-flowversion-flownodeoutput-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class GuardrailConfiguration : Humidifier.Base.BaseSubResource, IHaveGuardrailIdentifier, IHaveGuardrailVersion
        {
            /// <summary>
            /// GuardrailIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-guardrailconfiguration.html#cfn-bedrock-flowversion-guardrailconfiguration-guardrailidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GuardrailIdentifier { get; set; }
            /// <summary>
            /// GuardrailVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-guardrailconfiguration.html#cfn-bedrock-flowversion-guardrailconfiguration-guardrailversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GuardrailVersion { get; set; }
        }

        public class InlineCodeFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveLanguage, IHaveCode
        {
            /// <summary>
            /// Language
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-inlinecodeflownodeconfiguration.html#cfn-bedrock-flowversion-inlinecodeflownodeconfiguration-language
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Language { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-inlinecodeflownodeconfiguration.html#cfn-bedrock-flowversion-inlinecodeflownodeconfiguration-code
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Code { get; set; }
        }

        public class KnowledgeBaseFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowVersionTypesKnowledgeBaseOrchestrationConfigurationOrchestrationConfiguration, IHaveBedrockFlowVersionTypesGuardrailConfigurationGuardrailConfiguration, IHaveBedrockFlowVersionTypesPromptInferenceConfigurationInferenceConfiguration, IHaveKnowledgeBaseId, IHaveBedrockFlowVersionTypesKnowledgeBasePromptTemplatePromptTemplate, IHaveBedrockFlowVersionTypesVectorSearchRerankingConfigurationRerankingConfiguration, IHaveNumberOfResults_Double, IHaveModelId
        {
            /// <summary>
            /// OrchestrationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flowversion-knowledgebaseflownodeconfiguration-orchestrationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseOrchestrationConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.KnowledgeBaseOrchestrationConfiguration, BaseFunction>? OrchestrationConfiguration { get; set; }
            /// <summary>
            /// GuardrailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flowversion-knowledgebaseflownodeconfiguration-guardrailconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GuardrailConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.GuardrailConfiguration, BaseFunction>? GuardrailConfiguration { get; set; }
            /// <summary>
            /// InferenceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flowversion-knowledgebaseflownodeconfiguration-inferenceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptInferenceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.PromptInferenceConfiguration, BaseFunction>? InferenceConfiguration { get; set; }
            /// <summary>
            /// KnowledgeBaseId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flowversion-knowledgebaseflownodeconfiguration-knowledgebaseid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KnowledgeBaseId { get; set; }
            /// <summary>
            /// PromptTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flowversion-knowledgebaseflownodeconfiguration-prompttemplate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KnowledgeBasePromptTemplate
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.KnowledgeBasePromptTemplate, BaseFunction>? PromptTemplate { get; set; }
            /// <summary>
            /// RerankingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flowversion-knowledgebaseflownodeconfiguration-rerankingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VectorSearchRerankingConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.VectorSearchRerankingConfiguration, BaseFunction>? RerankingConfiguration { get; set; }
            /// <summary>
            /// NumberOfResults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flowversion-knowledgebaseflownodeconfiguration-numberofresults
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? NumberOfResults { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flowversion-knowledgebaseflownodeconfiguration-modelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class KnowledgeBaseOrchestrationConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowVersionTypesPromptInferenceConfigurationInferenceConfig, IHaveAdditionalModelRequestFields_Json, IHaveBedrockFlowVersionTypesPerformanceConfigurationPerformanceConfig, IHaveBedrockFlowVersionTypesKnowledgeBasePromptTemplatePromptTemplate
        {
            /// <summary>
            /// InferenceConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-knowledgebaseorchestrationconfiguration.html#cfn-bedrock-flowversion-knowledgebaseorchestrationconfiguration-inferenceconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptInferenceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.PromptInferenceConfiguration, BaseFunction>? InferenceConfig { get; set; }
            /// <summary>
            /// AdditionalModelRequestFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-knowledgebaseorchestrationconfiguration.html#cfn-bedrock-flowversion-knowledgebaseorchestrationconfiguration-additionalmodelrequestfields
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AdditionalModelRequestFields { get; set; }
            /// <summary>
            /// PerformanceConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-knowledgebaseorchestrationconfiguration.html#cfn-bedrock-flowversion-knowledgebaseorchestrationconfiguration-performanceconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PerformanceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.PerformanceConfiguration, BaseFunction>? PerformanceConfig { get; set; }
            /// <summary>
            /// PromptTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-knowledgebaseorchestrationconfiguration.html#cfn-bedrock-flowversion-knowledgebaseorchestrationconfiguration-prompttemplate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KnowledgeBasePromptTemplate
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.KnowledgeBasePromptTemplate, BaseFunction>? PromptTemplate { get; set; }
        }

        public class KnowledgeBasePromptTemplate : Humidifier.Base.BaseSubResource, IHaveTextPromptTemplate
        {
            /// <summary>
            /// TextPromptTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-knowledgebaseprompttemplate.html#cfn-bedrock-flowversion-knowledgebaseprompttemplate-textprompttemplate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextPromptTemplate { get; set; }
        }

        public class LambdaFunctionFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveLambdaArn
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-lambdafunctionflownodeconfiguration.html#cfn-bedrock-flowversion-lambdafunctionflownodeconfiguration-lambdaarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaArn { get; set; }
        }

        public class LexFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveBotAliasArn, IHaveLocaleId
        {
            /// <summary>
            /// BotAliasArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-lexflownodeconfiguration.html#cfn-bedrock-flowversion-lexflownodeconfiguration-botaliasarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BotAliasArn { get; set; }
            /// <summary>
            /// LocaleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-lexflownodeconfiguration.html#cfn-bedrock-flowversion-lexflownodeconfiguration-localeid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocaleId { get; set; }
        }

        public class LoopControllerFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowVersionTypesFlowConditionContinueCondition, IHaveMaxIterations_Double
        {
            /// <summary>
            /// ContinueCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-loopcontrollerflownodeconfiguration.html#cfn-bedrock-flowversion-loopcontrollerflownodeconfiguration-continuecondition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FlowCondition
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.FlowCondition, BaseFunction>? ContinueCondition { get; set; }
            /// <summary>
            /// MaxIterations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-loopcontrollerflownodeconfiguration.html#cfn-bedrock-flowversion-loopcontrollerflownodeconfiguration-maxiterations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxIterations { get; set; }
        }

        public class LoopFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowVersionTypesFlowDefinitionDefinition
        {
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-loopflownodeconfiguration.html#cfn-bedrock-flowversion-loopflownodeconfiguration-definition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FlowDefinition
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.FlowDefinition, BaseFunction>? Definition { get; set; }
        }

        public class MetadataConfigurationForReranking : Humidifier.Base.BaseSubResource, IHaveBedrockFlowVersionTypesRerankingMetadataSelectiveModeConfigurationSelectiveModeConfiguration, IHaveSelectionMode
        {
            /// <summary>
            /// SelectiveModeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-metadataconfigurationforreranking.html#cfn-bedrock-flowversion-metadataconfigurationforreranking-selectivemodeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RerankingMetadataSelectiveModeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.RerankingMetadataSelectiveModeConfiguration, BaseFunction>? SelectiveModeConfiguration { get; set; }
            /// <summary>
            /// SelectionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-metadataconfigurationforreranking.html#cfn-bedrock-flowversion-metadataconfigurationforreranking-selectionmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SelectionMode { get; set; }
        }

        public class PerformanceConfiguration : Humidifier.Base.BaseSubResource, IHaveLatency
        {
            /// <summary>
            /// Latency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-performanceconfiguration.html#cfn-bedrock-flowversion-performanceconfiguration-latency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Latency { get; set; }
        }

        public class PromptFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowVersionTypesGuardrailConfigurationGuardrailConfiguration, IHaveBedrockFlowVersionTypesPromptFlowNodeSourceConfigurationSourceConfiguration
        {
            /// <summary>
            /// GuardrailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptflownodeconfiguration.html#cfn-bedrock-flowversion-promptflownodeconfiguration-guardrailconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GuardrailConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.GuardrailConfiguration, BaseFunction>? GuardrailConfiguration { get; set; }
            /// <summary>
            /// SourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptflownodeconfiguration.html#cfn-bedrock-flowversion-promptflownodeconfiguration-sourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptFlowNodeSourceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.PromptFlowNodeSourceConfiguration, BaseFunction>? SourceConfiguration { get; set; }
        }

        public class PromptFlowNodeInlineConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowVersionTypesPromptInferenceConfigurationInferenceConfiguration, IHaveBedrockFlowVersionTypesPromptTemplateConfigurationTemplateConfiguration, IHaveTemplateType, IHaveModelId
        {
            /// <summary>
            /// InferenceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptflownodeinlineconfiguration.html#cfn-bedrock-flowversion-promptflownodeinlineconfiguration-inferenceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptInferenceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.PromptInferenceConfiguration, BaseFunction>? InferenceConfiguration { get; set; }
            /// <summary>
            /// TemplateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptflownodeinlineconfiguration.html#cfn-bedrock-flowversion-promptflownodeinlineconfiguration-templateconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptTemplateConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.PromptTemplateConfiguration, BaseFunction>? TemplateConfiguration { get; set; }
            /// <summary>
            /// TemplateType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptflownodeinlineconfiguration.html#cfn-bedrock-flowversion-promptflownodeinlineconfiguration-templatetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemplateType { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptflownodeinlineconfiguration.html#cfn-bedrock-flowversion-promptflownodeinlineconfiguration-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class PromptFlowNodeResourceConfiguration : Humidifier.Base.BaseSubResource, IHavePromptArn
        {
            /// <summary>
            /// PromptArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptflownoderesourceconfiguration.html#cfn-bedrock-flowversion-promptflownoderesourceconfiguration-promptarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PromptArn { get; set; }
        }

        public class PromptFlowNodeSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowVersionTypesPromptFlowNodeResourceConfigurationResource, IHaveBedrockFlowVersionTypesPromptFlowNodeInlineConfigurationInline
        {
            /// <summary>
            /// Resource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptflownodesourceconfiguration.html#cfn-bedrock-flowversion-promptflownodesourceconfiguration-resource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptFlowNodeResourceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.PromptFlowNodeResourceConfiguration, BaseFunction>? Resource { get; set; }
            /// <summary>
            /// Inline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptflownodesourceconfiguration.html#cfn-bedrock-flowversion-promptflownodesourceconfiguration-inline
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptFlowNodeInlineConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.PromptFlowNodeInlineConfiguration, BaseFunction>? Inline { get; set; }
        }

        public class PromptInferenceConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowVersionTypesPromptModelInferenceConfigurationText
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptinferenceconfiguration.html#cfn-bedrock-flowversion-promptinferenceconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptModelInferenceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.PromptModelInferenceConfiguration, BaseFunction>? Text { get; set; }
        }

        public class PromptInputVariable : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptinputvariable.html#cfn-bedrock-flowversion-promptinputvariable-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class PromptModelInferenceConfiguration : Humidifier.Base.BaseSubResource, IHaveTemperature_Double, IHaveStringListOfStopSequences, IHaveMaxTokens_Double, IHaveTopP_Double
        {
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptmodelinferenceconfiguration.html#cfn-bedrock-flowversion-promptmodelinferenceconfiguration-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Temperature { get; set; }
            /// <summary>
            /// StopSequences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptmodelinferenceconfiguration.html#cfn-bedrock-flowversion-promptmodelinferenceconfiguration-stopsequences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StopSequences { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptmodelinferenceconfiguration.html#cfn-bedrock-flowversion-promptmodelinferenceconfiguration-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxTokens { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptmodelinferenceconfiguration.html#cfn-bedrock-flowversion-promptmodelinferenceconfiguration-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TopP { get; set; }
        }

        public class PromptTemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowVersionTypesTextPromptTemplateConfigurationText
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-prompttemplateconfiguration.html#cfn-bedrock-flowversion-prompttemplateconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TextPromptTemplateConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.TextPromptTemplateConfiguration, BaseFunction>? Text { get; set; }
        }

        public class RerankingMetadataSelectiveModeConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockFlowVersionTypesFieldForRerankingFieldsToInclude, IHaveListOfBedrockFlowVersionTypesFieldForRerankingFieldsToExclude
        {
            /// <summary>
            /// FieldsToInclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-rerankingmetadataselectivemodeconfiguration.html#cfn-bedrock-flowversion-rerankingmetadataselectivemodeconfiguration-fieldstoinclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldForReranking
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.FlowVersionTypes.FieldForReranking>, IReadOnlyList<Union<Humidifier.Bedrock.FlowVersionTypes.FieldForReranking, BaseFunction>>, BaseFunction>? FieldsToInclude { get; set; }
            /// <summary>
            /// FieldsToExclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-rerankingmetadataselectivemodeconfiguration.html#cfn-bedrock-flowversion-rerankingmetadataselectivemodeconfiguration-fieldstoexclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldForReranking
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.FlowVersionTypes.FieldForReranking>, IReadOnlyList<Union<Humidifier.Bedrock.FlowVersionTypes.FieldForReranking, BaseFunction>>, BaseFunction>? FieldsToExclude { get; set; }
        }

        public class RetrievalFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowVersionTypesRetrievalFlowNodeServiceConfigurationServiceConfiguration
        {
            /// <summary>
            /// ServiceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-retrievalflownodeconfiguration.html#cfn-bedrock-flowversion-retrievalflownodeconfiguration-serviceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RetrievalFlowNodeServiceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.RetrievalFlowNodeServiceConfiguration, BaseFunction>? ServiceConfiguration { get; set; }
        }

        public class RetrievalFlowNodeS3Configuration : Humidifier.Base.BaseSubResource, IHaveBucketName
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-retrievalflownodes3configuration.html#cfn-bedrock-flowversion-retrievalflownodes3configuration-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
        }

        public class RetrievalFlowNodeServiceConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowVersionTypesRetrievalFlowNodeS3ConfigurationS3
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-retrievalflownodeserviceconfiguration.html#cfn-bedrock-flowversion-retrievalflownodeserviceconfiguration-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetrievalFlowNodeS3Configuration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.RetrievalFlowNodeS3Configuration, BaseFunction>? S3 { get; set; }
        }

        public class StorageFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowVersionTypesStorageFlowNodeServiceConfigurationServiceConfiguration
        {
            /// <summary>
            /// ServiceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-storageflownodeconfiguration.html#cfn-bedrock-flowversion-storageflownodeconfiguration-serviceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: StorageFlowNodeServiceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.StorageFlowNodeServiceConfiguration, BaseFunction>? ServiceConfiguration { get; set; }
        }

        public class StorageFlowNodeS3Configuration : Humidifier.Base.BaseSubResource, IHaveBucketName
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-storageflownodes3configuration.html#cfn-bedrock-flowversion-storageflownodes3configuration-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
        }

        public class StorageFlowNodeServiceConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowVersionTypesStorageFlowNodeS3ConfigurationS3
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-storageflownodeserviceconfiguration.html#cfn-bedrock-flowversion-storageflownodeserviceconfiguration-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StorageFlowNodeS3Configuration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.StorageFlowNodeS3Configuration, BaseFunction>? S3 { get; set; }
        }

        public class TextPromptTemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockFlowVersionTypesPromptInputVariableInputVariables, IHaveText
        {
            /// <summary>
            /// InputVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-textprompttemplateconfiguration.html#cfn-bedrock-flowversion-textprompttemplateconfiguration-inputvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PromptInputVariable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.FlowVersionTypes.PromptInputVariable>, IReadOnlyList<Union<Humidifier.Bedrock.FlowVersionTypes.PromptInputVariable, BaseFunction>>, BaseFunction>? InputVariables { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-textprompttemplateconfiguration.html#cfn-bedrock-flowversion-textprompttemplateconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }

        public class VectorSearchBedrockRerankingConfiguration : Humidifier.Base.BaseSubResource, IHaveNumberOfRerankedResults_Double, IHaveBedrockFlowVersionTypesMetadataConfigurationForRerankingMetadataConfiguration, IHaveBedrockFlowVersionTypesVectorSearchBedrockRerankingModelConfigurationModelConfiguration
        {
            /// <summary>
            /// NumberOfRerankedResults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-vectorsearchbedrockrerankingconfiguration.html#cfn-bedrock-flowversion-vectorsearchbedrockrerankingconfiguration-numberofrerankedresults
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? NumberOfRerankedResults { get; set; }
            /// <summary>
            /// MetadataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-vectorsearchbedrockrerankingconfiguration.html#cfn-bedrock-flowversion-vectorsearchbedrockrerankingconfiguration-metadataconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetadataConfigurationForReranking
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.MetadataConfigurationForReranking, BaseFunction>? MetadataConfiguration { get; set; }
            /// <summary>
            /// ModelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-vectorsearchbedrockrerankingconfiguration.html#cfn-bedrock-flowversion-vectorsearchbedrockrerankingconfiguration-modelconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VectorSearchBedrockRerankingModelConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.VectorSearchBedrockRerankingModelConfiguration, BaseFunction>? ModelConfiguration { get; set; }
        }

        public class VectorSearchBedrockRerankingModelConfiguration : Humidifier.Base.BaseSubResource, IHaveModelArn, IHaveAdditionalModelRequestFields_Json
        {
            /// <summary>
            /// ModelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-vectorsearchbedrockrerankingmodelconfiguration.html#cfn-bedrock-flowversion-vectorsearchbedrockrerankingmodelconfiguration-modelarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelArn { get; set; }
            /// <summary>
            /// AdditionalModelRequestFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-vectorsearchbedrockrerankingmodelconfiguration.html#cfn-bedrock-flowversion-vectorsearchbedrockrerankingmodelconfiguration-additionalmodelrequestfields
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AdditionalModelRequestFields { get; set; }
        }

        public class VectorSearchRerankingConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveBedrockFlowVersionTypesVectorSearchBedrockRerankingConfigurationBedrockRerankingConfiguration
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-vectorsearchrerankingconfiguration.html#cfn-bedrock-flowversion-vectorsearchrerankingconfiguration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// BedrockRerankingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-vectorsearchrerankingconfiguration.html#cfn-bedrock-flowversion-vectorsearchrerankingconfiguration-bedrockrerankingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VectorSearchBedrockRerankingConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowVersionTypes.VectorSearchBedrockRerankingConfiguration, BaseFunction>? BedrockRerankingConfiguration { get; set; }
        }
    }
}