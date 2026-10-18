namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using FlowTypes;

    public class Flow : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveStringDictionaryOfTestAliasTags, IHaveExecutionRoleArn, IHaveDescription, IHaveDefinitionString, IHaveBedrockFlowTypesFlowDefinitionDefinition, IHaveJsonDictionaryOfDefinitionSubstitutions, IHaveCustomerEncryptionKeyArn, IHaveBedrockFlowTypesS3LocationDefinitionS3Location, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Validations =  "Validations" ;
            public static string Version =  "Version" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.Flow; }
        /// <summary>
        /// TestAliasTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flow.html#cfn-bedrock-flow-testaliastags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? TestAliasTags { get; set; }

        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flow.html#cfn-bedrock-flow-executionrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flow.html#cfn-bedrock-flow-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// DefinitionString
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flow.html#cfn-bedrock-flow-definitionstring
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefinitionString { get; set; }
        /// <summary>
        /// Definition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flow.html#cfn-bedrock-flow-definition
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FlowDefinition
        /// </summary>
        public Union<Humidifier.Bedrock.FlowTypes.FlowDefinition, BaseFunction>? Definition { get; set; }
        /// <summary>
        /// DefinitionSubstitutions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flow.html#cfn-bedrock-flow-definitionsubstitutions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: Json
        /// </summary>
        public Union<IReadOnlyDictionary<string, object>, IReadOnlyDictionary<string, Union<object, BaseFunction>>, BaseFunction>? DefinitionSubstitutions { get; set; }
        /// <summary>
        /// CustomerEncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flow.html#cfn-bedrock-flow-customerencryptionkeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CustomerEncryptionKeyArn { get; set; }
        /// <summary>
        /// DefinitionS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flow.html#cfn-bedrock-flow-definitions3location
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3Location
        /// </summary>
        public Union<Humidifier.Bedrock.FlowTypes.S3Location, BaseFunction>? DefinitionS3Location { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flow.html#cfn-bedrock-flow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace FlowTypes
    {
        public class AgentFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveAgentAliasArn
        {
            /// <summary>
            /// AgentAliasArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-agentflownodeconfiguration.html#cfn-bedrock-flow-agentflownodeconfiguration-agentaliasarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AgentAliasArn { get; set; }
        }

        public class ConditionFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockFlowTypesFlowConditionConditions
        {
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-conditionflownodeconfiguration.html#cfn-bedrock-flow-conditionflownodeconfiguration-conditions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.FlowTypes.FlowCondition>, IReadOnlyList<Union<Humidifier.Bedrock.FlowTypes.FlowCondition, BaseFunction>>, BaseFunction>? Conditions { get; set; }
        }

        public class FieldForReranking : Humidifier.Base.BaseSubResource, IHaveFieldName
        {
            /// <summary>
            /// FieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-fieldforreranking.html#cfn-bedrock-flow-fieldforreranking-fieldname
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowcondition.html#cfn-bedrock-flow-flowcondition-expression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowcondition.html#cfn-bedrock-flow-flowcondition-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowconditionalconnectionconfiguration.html#cfn-bedrock-flow-flowconditionalconnectionconfiguration-condition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Condition { get; set; }
        }

        public class FlowConnection : Humidifier.Base.BaseSubResource, IHaveType, IHaveTarget, IHaveBedrockFlowTypesFlowConnectionConfigurationConfiguration, IHaveSource, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowconnection.html#cfn-bedrock-flow-flowconnection-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowconnection.html#cfn-bedrock-flow-flowconnection-target
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Target { get; set; }
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowconnection.html#cfn-bedrock-flow-flowconnection-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowConnectionConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.FlowConnectionConfiguration, BaseFunction>? Configuration { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowconnection.html#cfn-bedrock-flow-flowconnection-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowconnection.html#cfn-bedrock-flow-flowconnection-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class FlowConnectionConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowTypesFlowDataConnectionConfigurationData, IHaveBedrockFlowTypesFlowConditionalConnectionConfigurationConditional
        {
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowconnectionconfiguration.html#cfn-bedrock-flow-flowconnectionconfiguration-data
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowDataConnectionConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.FlowDataConnectionConfiguration, BaseFunction>? Data { get; set; }
            /// <summary>
            /// Conditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowconnectionconfiguration.html#cfn-bedrock-flow-flowconnectionconfiguration-conditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowConditionalConnectionConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.FlowConditionalConnectionConfiguration, BaseFunction>? Conditional { get; set; }
        }

        public class FlowDataConnectionConfiguration : Humidifier.Base.BaseSubResource, IHaveSourceOutput, IHaveTargetInput
        {
            /// <summary>
            /// SourceOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowdataconnectionconfiguration.html#cfn-bedrock-flow-flowdataconnectionconfiguration-sourceoutput
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceOutput { get; set; }
            /// <summary>
            /// TargetInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowdataconnectionconfiguration.html#cfn-bedrock-flow-flowdataconnectionconfiguration-targetinput
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetInput { get; set; }
        }

        public class FlowDefinition : Humidifier.Base.BaseSubResource, IHaveListOfBedrockFlowTypesFlowConnectionConnections, IHaveListOfBedrockFlowTypesFlowNodeNodes
        {
            /// <summary>
            /// Connections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowdefinition.html#cfn-bedrock-flow-flowdefinition-connections
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowConnection
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.FlowTypes.FlowConnection>, IReadOnlyList<Union<Humidifier.Bedrock.FlowTypes.FlowConnection, BaseFunction>>, BaseFunction>? Connections { get; set; }
            /// <summary>
            /// Nodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowdefinition.html#cfn-bedrock-flow-flowdefinition-nodes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowNode
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.FlowTypes.FlowNode>, IReadOnlyList<Union<Humidifier.Bedrock.FlowTypes.FlowNode, BaseFunction>>, BaseFunction>? Nodes { get; set; }
        }

        public class FlowNode : Humidifier.Base.BaseSubResource, IHaveType, IHaveBedrockFlowTypesFlowNodeConfigurationConfiguration, IHaveListOfBedrockFlowTypesFlowNodeOutputOutputs, IHaveListOfBedrockFlowTypesFlowNodeInputInputs, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownode.html#cfn-bedrock-flow-flownode-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownode.html#cfn-bedrock-flow-flownode-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.FlowNodeConfiguration, BaseFunction>? Configuration { get; set; }
            /// <summary>
            /// Outputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownode.html#cfn-bedrock-flow-flownode-outputs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowNodeOutput
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.FlowTypes.FlowNodeOutput>, IReadOnlyList<Union<Humidifier.Bedrock.FlowTypes.FlowNodeOutput, BaseFunction>>, BaseFunction>? Outputs { get; set; }
            /// <summary>
            /// Inputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownode.html#cfn-bedrock-flow-flownode-inputs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowNodeInput
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.FlowTypes.FlowNodeInput>, IReadOnlyList<Union<Humidifier.Bedrock.FlowTypes.FlowNodeInput, BaseFunction>>, BaseFunction>? Inputs { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownode.html#cfn-bedrock-flow-flownode-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class FlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowTypesConditionFlowNodeConfigurationCondition, IHaveBedrockFlowTypesRetrievalFlowNodeConfigurationRetrieval, IHaveBedrockFlowTypesLoopFlowNodeConfigurationLoop, IHaveBedrockFlowTypesAgentFlowNodeConfigurationAgent, IHaveBedrockFlowTypesLambdaFunctionFlowNodeConfigurationLambdaFunction, IHaveBedrockFlowTypesInlineCodeFlowNodeConfigurationInlineCode, IHaveBedrockFlowTypesLoopControllerFlowNodeConfigurationLoopController, IHaveInput_Json, IHaveBedrockFlowTypesStorageFlowNodeConfigurationStorage, IHaveBedrockFlowTypesKnowledgeBaseFlowNodeConfigurationKnowledgeBase, IHaveOutput_Json, IHaveIterator_Json, IHaveCollector_Json, IHaveLoopInput_Json, IHaveBedrockFlowTypesPromptFlowNodeConfigurationPrompt, IHaveBedrockFlowTypesLexFlowNodeConfigurationLex
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-condition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.ConditionFlowNodeConfiguration, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// Retrieval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-retrieval
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetrievalFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.RetrievalFlowNodeConfiguration, BaseFunction>? Retrieval { get; set; }
            /// <summary>
            /// Loop
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-loop
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoopFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.LoopFlowNodeConfiguration, BaseFunction>? Loop { get; set; }
            /// <summary>
            /// Agent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-agent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AgentFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.AgentFlowNodeConfiguration, BaseFunction>? Agent { get; set; }
            /// <summary>
            /// LambdaFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-lambdafunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaFunctionFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.LambdaFunctionFlowNodeConfiguration, BaseFunction>? LambdaFunction { get; set; }
            /// <summary>
            /// InlineCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-inlinecode
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InlineCodeFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.InlineCodeFlowNodeConfiguration, BaseFunction>? InlineCode { get; set; }
            /// <summary>
            /// LoopController
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-loopcontroller
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoopControllerFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.LoopControllerFlowNodeConfiguration, BaseFunction>? LoopController { get; set; }
            /// <summary>
            /// Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-input
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Input { get; set; }
            /// <summary>
            /// Storage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-storage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StorageFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.StorageFlowNodeConfiguration, BaseFunction>? Storage { get; set; }
            /// <summary>
            /// KnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-knowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.KnowledgeBaseFlowNodeConfiguration, BaseFunction>? KnowledgeBase { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-output
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Output { get; set; }
            /// <summary>
            /// Iterator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-iterator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Iterator { get; set; }
            /// <summary>
            /// Collector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-collector
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Collector { get; set; }
            /// <summary>
            /// LoopInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-loopinput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? LoopInput { get; set; }
            /// <summary>
            /// Prompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-prompt
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.PromptFlowNodeConfiguration, BaseFunction>? Prompt { get; set; }
            /// <summary>
            /// Lex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-lex
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LexFlowNodeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.LexFlowNodeConfiguration, BaseFunction>? Lex { get; set; }
        }

        public class FlowNodeInput : Humidifier.Base.BaseSubResource, IHaveType, IHaveCategory, IHaveExpression, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeinput.html#cfn-bedrock-flow-flownodeinput-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeinput.html#cfn-bedrock-flow-flownodeinput-category
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Category { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeinput.html#cfn-bedrock-flow-flownodeinput-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeinput.html#cfn-bedrock-flow-flownodeinput-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeoutput.html#cfn-bedrock-flow-flownodeoutput-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeoutput.html#cfn-bedrock-flow-flownodeoutput-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class FlowValidation : Humidifier.Base.BaseSubResource, IHaveMessage
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowvalidation.html#cfn-bedrock-flow-flowvalidation-message
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
        }

        public class GuardrailConfiguration : Humidifier.Base.BaseSubResource, IHaveGuardrailIdentifier, IHaveGuardrailVersion
        {
            /// <summary>
            /// GuardrailIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-guardrailconfiguration.html#cfn-bedrock-flow-guardrailconfiguration-guardrailidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GuardrailIdentifier { get; set; }
            /// <summary>
            /// GuardrailVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-guardrailconfiguration.html#cfn-bedrock-flow-guardrailconfiguration-guardrailversion
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-inlinecodeflownodeconfiguration.html#cfn-bedrock-flow-inlinecodeflownodeconfiguration-language
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Language { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-inlinecodeflownodeconfiguration.html#cfn-bedrock-flow-inlinecodeflownodeconfiguration-code
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Code { get; set; }
        }

        public class KnowledgeBaseFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowTypesKnowledgeBaseOrchestrationConfigurationOrchestrationConfiguration, IHaveBedrockFlowTypesGuardrailConfigurationGuardrailConfiguration, IHaveBedrockFlowTypesPromptInferenceConfigurationInferenceConfiguration, IHaveKnowledgeBaseId, IHaveBedrockFlowTypesKnowledgeBasePromptTemplatePromptTemplate, IHaveBedrockFlowTypesVectorSearchRerankingConfigurationRerankingConfiguration, IHaveNumberOfResults_Double, IHaveModelId
        {
            /// <summary>
            /// OrchestrationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flow-knowledgebaseflownodeconfiguration-orchestrationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseOrchestrationConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.KnowledgeBaseOrchestrationConfiguration, BaseFunction>? OrchestrationConfiguration { get; set; }
            /// <summary>
            /// GuardrailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flow-knowledgebaseflownodeconfiguration-guardrailconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GuardrailConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.GuardrailConfiguration, BaseFunction>? GuardrailConfiguration { get; set; }
            /// <summary>
            /// InferenceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flow-knowledgebaseflownodeconfiguration-inferenceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptInferenceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.PromptInferenceConfiguration, BaseFunction>? InferenceConfiguration { get; set; }
            /// <summary>
            /// KnowledgeBaseId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flow-knowledgebaseflownodeconfiguration-knowledgebaseid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KnowledgeBaseId { get; set; }
            /// <summary>
            /// PromptTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flow-knowledgebaseflownodeconfiguration-prompttemplate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KnowledgeBasePromptTemplate
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.KnowledgeBasePromptTemplate, BaseFunction>? PromptTemplate { get; set; }
            /// <summary>
            /// RerankingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flow-knowledgebaseflownodeconfiguration-rerankingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VectorSearchRerankingConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.VectorSearchRerankingConfiguration, BaseFunction>? RerankingConfiguration { get; set; }
            /// <summary>
            /// NumberOfResults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flow-knowledgebaseflownodeconfiguration-numberofresults
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? NumberOfResults { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flow-knowledgebaseflownodeconfiguration-modelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class KnowledgeBaseOrchestrationConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowTypesPromptInferenceConfigurationInferenceConfig, IHaveAdditionalModelRequestFields_Json, IHaveBedrockFlowTypesPerformanceConfigurationPerformanceConfig, IHaveBedrockFlowTypesKnowledgeBasePromptTemplatePromptTemplate
        {
            /// <summary>
            /// InferenceConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-knowledgebaseorchestrationconfiguration.html#cfn-bedrock-flow-knowledgebaseorchestrationconfiguration-inferenceconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptInferenceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.PromptInferenceConfiguration, BaseFunction>? InferenceConfig { get; set; }
            /// <summary>
            /// AdditionalModelRequestFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-knowledgebaseorchestrationconfiguration.html#cfn-bedrock-flow-knowledgebaseorchestrationconfiguration-additionalmodelrequestfields
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AdditionalModelRequestFields { get; set; }
            /// <summary>
            /// PerformanceConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-knowledgebaseorchestrationconfiguration.html#cfn-bedrock-flow-knowledgebaseorchestrationconfiguration-performanceconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PerformanceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.PerformanceConfiguration, BaseFunction>? PerformanceConfig { get; set; }
            /// <summary>
            /// PromptTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-knowledgebaseorchestrationconfiguration.html#cfn-bedrock-flow-knowledgebaseorchestrationconfiguration-prompttemplate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KnowledgeBasePromptTemplate
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.KnowledgeBasePromptTemplate, BaseFunction>? PromptTemplate { get; set; }
        }

        public class KnowledgeBasePromptTemplate : Humidifier.Base.BaseSubResource, IHaveTextPromptTemplate
        {
            /// <summary>
            /// TextPromptTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-knowledgebaseprompttemplate.html#cfn-bedrock-flow-knowledgebaseprompttemplate-textprompttemplate
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-lambdafunctionflownodeconfiguration.html#cfn-bedrock-flow-lambdafunctionflownodeconfiguration-lambdaarn
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-lexflownodeconfiguration.html#cfn-bedrock-flow-lexflownodeconfiguration-botaliasarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BotAliasArn { get; set; }
            /// <summary>
            /// LocaleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-lexflownodeconfiguration.html#cfn-bedrock-flow-lexflownodeconfiguration-localeid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocaleId { get; set; }
        }

        public class LoopControllerFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowTypesFlowConditionContinueCondition, IHaveMaxIterations_Double
        {
            /// <summary>
            /// ContinueCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-loopcontrollerflownodeconfiguration.html#cfn-bedrock-flow-loopcontrollerflownodeconfiguration-continuecondition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FlowCondition
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.FlowCondition, BaseFunction>? ContinueCondition { get; set; }
            /// <summary>
            /// MaxIterations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-loopcontrollerflownodeconfiguration.html#cfn-bedrock-flow-loopcontrollerflownodeconfiguration-maxiterations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxIterations { get; set; }
        }

        public class LoopFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowTypesFlowDefinitionDefinition
        {
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-loopflownodeconfiguration.html#cfn-bedrock-flow-loopflownodeconfiguration-definition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FlowDefinition
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.FlowDefinition, BaseFunction>? Definition { get; set; }
        }

        public class MetadataConfigurationForReranking : Humidifier.Base.BaseSubResource, IHaveBedrockFlowTypesRerankingMetadataSelectiveModeConfigurationSelectiveModeConfiguration, IHaveSelectionMode
        {
            /// <summary>
            /// SelectiveModeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-metadataconfigurationforreranking.html#cfn-bedrock-flow-metadataconfigurationforreranking-selectivemodeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RerankingMetadataSelectiveModeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.RerankingMetadataSelectiveModeConfiguration, BaseFunction>? SelectiveModeConfiguration { get; set; }
            /// <summary>
            /// SelectionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-metadataconfigurationforreranking.html#cfn-bedrock-flow-metadataconfigurationforreranking-selectionmode
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-performanceconfiguration.html#cfn-bedrock-flow-performanceconfiguration-latency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Latency { get; set; }
        }

        public class PromptFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowTypesGuardrailConfigurationGuardrailConfiguration, IHaveBedrockFlowTypesPromptFlowNodeSourceConfigurationSourceConfiguration
        {
            /// <summary>
            /// GuardrailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptflownodeconfiguration.html#cfn-bedrock-flow-promptflownodeconfiguration-guardrailconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GuardrailConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.GuardrailConfiguration, BaseFunction>? GuardrailConfiguration { get; set; }
            /// <summary>
            /// SourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptflownodeconfiguration.html#cfn-bedrock-flow-promptflownodeconfiguration-sourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptFlowNodeSourceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.PromptFlowNodeSourceConfiguration, BaseFunction>? SourceConfiguration { get; set; }
        }

        public class PromptFlowNodeInlineConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowTypesPromptInferenceConfigurationInferenceConfiguration, IHaveBedrockFlowTypesPromptTemplateConfigurationTemplateConfiguration, IHaveTemplateType, IHaveModelId
        {
            /// <summary>
            /// InferenceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptflownodeinlineconfiguration.html#cfn-bedrock-flow-promptflownodeinlineconfiguration-inferenceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptInferenceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.PromptInferenceConfiguration, BaseFunction>? InferenceConfiguration { get; set; }
            /// <summary>
            /// TemplateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptflownodeinlineconfiguration.html#cfn-bedrock-flow-promptflownodeinlineconfiguration-templateconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptTemplateConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.PromptTemplateConfiguration, BaseFunction>? TemplateConfiguration { get; set; }
            /// <summary>
            /// TemplateType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptflownodeinlineconfiguration.html#cfn-bedrock-flow-promptflownodeinlineconfiguration-templatetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemplateType { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptflownodeinlineconfiguration.html#cfn-bedrock-flow-promptflownodeinlineconfiguration-modelid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptflownoderesourceconfiguration.html#cfn-bedrock-flow-promptflownoderesourceconfiguration-promptarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PromptArn { get; set; }
        }

        public class PromptFlowNodeSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowTypesPromptFlowNodeResourceConfigurationResource, IHaveBedrockFlowTypesPromptFlowNodeInlineConfigurationInline
        {
            /// <summary>
            /// Resource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptflownodesourceconfiguration.html#cfn-bedrock-flow-promptflownodesourceconfiguration-resource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptFlowNodeResourceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.PromptFlowNodeResourceConfiguration, BaseFunction>? Resource { get; set; }
            /// <summary>
            /// Inline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptflownodesourceconfiguration.html#cfn-bedrock-flow-promptflownodesourceconfiguration-inline
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptFlowNodeInlineConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.PromptFlowNodeInlineConfiguration, BaseFunction>? Inline { get; set; }
        }

        public class PromptInferenceConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowTypesPromptModelInferenceConfigurationText
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptinferenceconfiguration.html#cfn-bedrock-flow-promptinferenceconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptModelInferenceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.PromptModelInferenceConfiguration, BaseFunction>? Text { get; set; }
        }

        public class PromptInputVariable : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptinputvariable.html#cfn-bedrock-flow-promptinputvariable-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptmodelinferenceconfiguration.html#cfn-bedrock-flow-promptmodelinferenceconfiguration-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Temperature { get; set; }
            /// <summary>
            /// StopSequences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptmodelinferenceconfiguration.html#cfn-bedrock-flow-promptmodelinferenceconfiguration-stopsequences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StopSequences { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptmodelinferenceconfiguration.html#cfn-bedrock-flow-promptmodelinferenceconfiguration-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxTokens { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptmodelinferenceconfiguration.html#cfn-bedrock-flow-promptmodelinferenceconfiguration-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TopP { get; set; }
        }

        public class PromptTemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowTypesTextPromptTemplateConfigurationText
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-prompttemplateconfiguration.html#cfn-bedrock-flow-prompttemplateconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TextPromptTemplateConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.TextPromptTemplateConfiguration, BaseFunction>? Text { get; set; }
        }

        public class RerankingMetadataSelectiveModeConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockFlowTypesFieldForRerankingFieldsToInclude, IHaveListOfBedrockFlowTypesFieldForRerankingFieldsToExclude
        {
            /// <summary>
            /// FieldsToInclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-rerankingmetadataselectivemodeconfiguration.html#cfn-bedrock-flow-rerankingmetadataselectivemodeconfiguration-fieldstoinclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldForReranking
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.FlowTypes.FieldForReranking>, IReadOnlyList<Union<Humidifier.Bedrock.FlowTypes.FieldForReranking, BaseFunction>>, BaseFunction>? FieldsToInclude { get; set; }
            /// <summary>
            /// FieldsToExclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-rerankingmetadataselectivemodeconfiguration.html#cfn-bedrock-flow-rerankingmetadataselectivemodeconfiguration-fieldstoexclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldForReranking
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.FlowTypes.FieldForReranking>, IReadOnlyList<Union<Humidifier.Bedrock.FlowTypes.FieldForReranking, BaseFunction>>, BaseFunction>? FieldsToExclude { get; set; }
        }

        public class RetrievalFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowTypesRetrievalFlowNodeServiceConfigurationServiceConfiguration
        {
            /// <summary>
            /// ServiceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-retrievalflownodeconfiguration.html#cfn-bedrock-flow-retrievalflownodeconfiguration-serviceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RetrievalFlowNodeServiceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.RetrievalFlowNodeServiceConfiguration, BaseFunction>? ServiceConfiguration { get; set; }
        }

        public class RetrievalFlowNodeS3Configuration : Humidifier.Base.BaseSubResource, IHaveBucketName
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-retrievalflownodes3configuration.html#cfn-bedrock-flow-retrievalflownodes3configuration-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
        }

        public class RetrievalFlowNodeServiceConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowTypesRetrievalFlowNodeS3ConfigurationS3
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-retrievalflownodeserviceconfiguration.html#cfn-bedrock-flow-retrievalflownodeserviceconfiguration-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetrievalFlowNodeS3Configuration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.RetrievalFlowNodeS3Configuration, BaseFunction>? S3 { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveVersion, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-s3location.html#cfn-bedrock-flow-s3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-s3location.html#cfn-bedrock-flow-s3location-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-s3location.html#cfn-bedrock-flow-s3location-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class StorageFlowNodeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowTypesStorageFlowNodeServiceConfigurationServiceConfiguration
        {
            /// <summary>
            /// ServiceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-storageflownodeconfiguration.html#cfn-bedrock-flow-storageflownodeconfiguration-serviceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: StorageFlowNodeServiceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.StorageFlowNodeServiceConfiguration, BaseFunction>? ServiceConfiguration { get; set; }
        }

        public class StorageFlowNodeS3Configuration : Humidifier.Base.BaseSubResource, IHaveBucketName
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-storageflownodes3configuration.html#cfn-bedrock-flow-storageflownodes3configuration-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
        }

        public class StorageFlowNodeServiceConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockFlowTypesStorageFlowNodeS3ConfigurationS3
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-storageflownodeserviceconfiguration.html#cfn-bedrock-flow-storageflownodeserviceconfiguration-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StorageFlowNodeS3Configuration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.StorageFlowNodeS3Configuration, BaseFunction>? S3 { get; set; }
        }

        public class TextPromptTemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockFlowTypesPromptInputVariableInputVariables, IHaveText
        {
            /// <summary>
            /// InputVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-textprompttemplateconfiguration.html#cfn-bedrock-flow-textprompttemplateconfiguration-inputvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PromptInputVariable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.FlowTypes.PromptInputVariable>, IReadOnlyList<Union<Humidifier.Bedrock.FlowTypes.PromptInputVariable, BaseFunction>>, BaseFunction>? InputVariables { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-textprompttemplateconfiguration.html#cfn-bedrock-flow-textprompttemplateconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }

        public class VectorSearchBedrockRerankingConfiguration : Humidifier.Base.BaseSubResource, IHaveNumberOfRerankedResults_Double, IHaveBedrockFlowTypesMetadataConfigurationForRerankingMetadataConfiguration, IHaveBedrockFlowTypesVectorSearchBedrockRerankingModelConfigurationModelConfiguration
        {
            /// <summary>
            /// NumberOfRerankedResults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-vectorsearchbedrockrerankingconfiguration.html#cfn-bedrock-flow-vectorsearchbedrockrerankingconfiguration-numberofrerankedresults
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? NumberOfRerankedResults { get; set; }
            /// <summary>
            /// MetadataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-vectorsearchbedrockrerankingconfiguration.html#cfn-bedrock-flow-vectorsearchbedrockrerankingconfiguration-metadataconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetadataConfigurationForReranking
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.MetadataConfigurationForReranking, BaseFunction>? MetadataConfiguration { get; set; }
            /// <summary>
            /// ModelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-vectorsearchbedrockrerankingconfiguration.html#cfn-bedrock-flow-vectorsearchbedrockrerankingconfiguration-modelconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VectorSearchBedrockRerankingModelConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.VectorSearchBedrockRerankingModelConfiguration, BaseFunction>? ModelConfiguration { get; set; }
        }

        public class VectorSearchBedrockRerankingModelConfiguration : Humidifier.Base.BaseSubResource, IHaveModelArn, IHaveAdditionalModelRequestFields_Json
        {
            /// <summary>
            /// ModelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-vectorsearchbedrockrerankingmodelconfiguration.html#cfn-bedrock-flow-vectorsearchbedrockrerankingmodelconfiguration-modelarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelArn { get; set; }
            /// <summary>
            /// AdditionalModelRequestFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-vectorsearchbedrockrerankingmodelconfiguration.html#cfn-bedrock-flow-vectorsearchbedrockrerankingmodelconfiguration-additionalmodelrequestfields
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AdditionalModelRequestFields { get; set; }
        }

        public class VectorSearchRerankingConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveBedrockFlowTypesVectorSearchBedrockRerankingConfigurationBedrockRerankingConfiguration
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-vectorsearchrerankingconfiguration.html#cfn-bedrock-flow-vectorsearchrerankingconfiguration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// BedrockRerankingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-vectorsearchrerankingconfiguration.html#cfn-bedrock-flow-vectorsearchrerankingconfiguration-bedrockrerankingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VectorSearchBedrockRerankingConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.FlowTypes.VectorSearchBedrockRerankingConfiguration, BaseFunction>? BedrockRerankingConfiguration { get; set; }
        }
    }
}