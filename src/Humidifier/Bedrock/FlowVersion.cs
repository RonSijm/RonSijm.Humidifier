namespace Humidifier.Bedrock
{
    using System.Collections.Generic;
    using FlowVersionTypes;

    public class FlowVersion : Humidifier.Resource, IHaveDescription
    {
        public class Attributes
        {
            public static string FlowId =  "FlowId" ;
            public static string Status =  "Status" ;
            public static string ExecutionRoleArn =  "ExecutionRoleArn" ;
            public static string Version =  "Version" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Definition =  "Definition" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Bedrock::FlowVersion";
            }
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flowversion.html#cfn-bedrock-flowversion-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// FlowArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flowversion.html#cfn-bedrock-flowversion-flowarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FlowArn { get; set; }
    }

    namespace FlowVersionTypes
    {
        public class ConditionFlowNodeConfiguration
        {
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-conditionflownodeconfiguration.html#cfn-bedrock-flowversion-conditionflownodeconfiguration-conditions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowCondition
            /// </summary>
            public List<FlowCondition> Conditions { get; set; }
        }

        public class FlowCondition
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowcondition.html#cfn-bedrock-flowversion-flowcondition-expression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowcondition.html#cfn-bedrock-flowversion-flowcondition-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class FlowConditionalConnectionConfiguration
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowconditionalconnectionconfiguration.html#cfn-bedrock-flowversion-flowconditionalconnectionconfiguration-condition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Condition { get; set; }
        }

        public class FlowConnection
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowconnection.html#cfn-bedrock-flowversion-flowconnection-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowconnection.html#cfn-bedrock-flowversion-flowconnection-target
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Target { get; set; }
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowconnection.html#cfn-bedrock-flowversion-flowconnection-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowConnectionConfiguration
            /// </summary>
            public FlowConnectionConfiguration Configuration { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowconnection.html#cfn-bedrock-flowversion-flowconnection-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowconnection.html#cfn-bedrock-flowversion-flowconnection-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class FlowConnectionConfiguration
        {
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowconnectionconfiguration.html#cfn-bedrock-flowversion-flowconnectionconfiguration-data
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowDataConnectionConfiguration
            /// </summary>
            public FlowDataConnectionConfiguration Data { get; set; }
            /// <summary>
            /// Conditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowconnectionconfiguration.html#cfn-bedrock-flowversion-flowconnectionconfiguration-conditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowConditionalConnectionConfiguration
            /// </summary>
            public FlowConditionalConnectionConfiguration Conditional { get; set; }
        }

        public class FlowDataConnectionConfiguration
        {
            /// <summary>
            /// SourceOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowdataconnectionconfiguration.html#cfn-bedrock-flowversion-flowdataconnectionconfiguration-sourceoutput
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceOutput { get; set; }
            /// <summary>
            /// TargetInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowdataconnectionconfiguration.html#cfn-bedrock-flowversion-flowdataconnectionconfiguration-targetinput
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetInput { get; set; }
        }

        public class FlowDefinition
        {
            /// <summary>
            /// Connections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowdefinition.html#cfn-bedrock-flowversion-flowdefinition-connections
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowConnection
            /// </summary>
            public List<FlowConnection> Connections { get; set; }
            /// <summary>
            /// Nodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flowdefinition.html#cfn-bedrock-flowversion-flowdefinition-nodes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowNode
            /// </summary>
            public List<FlowNode> Nodes { get; set; }
        }

        public class FlowNode
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownode.html#cfn-bedrock-flowversion-flownode-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownode.html#cfn-bedrock-flowversion-flownode-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowNodeConfiguration
            /// </summary>
            public FlowNodeConfiguration Configuration { get; set; }
            /// <summary>
            /// Outputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownode.html#cfn-bedrock-flowversion-flownode-outputs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowNodeOutput
            /// </summary>
            public List<FlowNodeOutput> Outputs { get; set; }
            /// <summary>
            /// Inputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownode.html#cfn-bedrock-flowversion-flownode-inputs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowNodeInput
            /// </summary>
            public List<FlowNodeInput> Inputs { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownode.html#cfn-bedrock-flowversion-flownode-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class FlowNodeConfiguration
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-condition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionFlowNodeConfiguration
            /// </summary>
            public ConditionFlowNodeConfiguration Condition { get; set; }
            /// <summary>
            /// Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-input
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Input { get; set; }
            /// <summary>
            /// KnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-knowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseFlowNodeConfiguration
            /// </summary>
            public KnowledgeBaseFlowNodeConfiguration KnowledgeBase { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-output
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Output { get; set; }
            /// <summary>
            /// Prompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-prompt
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptFlowNodeConfiguration
            /// </summary>
            public PromptFlowNodeConfiguration Prompt { get; set; }
            /// <summary>
            /// LambdaFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-lambdafunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaFunctionFlowNodeConfiguration
            /// </summary>
            public LambdaFunctionFlowNodeConfiguration LambdaFunction { get; set; }
            /// <summary>
            /// Lex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeconfiguration.html#cfn-bedrock-flowversion-flownodeconfiguration-lex
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LexFlowNodeConfiguration
            /// </summary>
            public LexFlowNodeConfiguration Lex { get; set; }
        }

        public class FlowNodeInput
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeinput.html#cfn-bedrock-flowversion-flownodeinput-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeinput.html#cfn-bedrock-flowversion-flownodeinput-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeinput.html#cfn-bedrock-flowversion-flownodeinput-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class FlowNodeOutput
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeoutput.html#cfn-bedrock-flowversion-flownodeoutput-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-flownodeoutput.html#cfn-bedrock-flowversion-flownodeoutput-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class KnowledgeBaseFlowNodeConfiguration
        {
            /// <summary>
            /// KnowledgeBaseId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flowversion-knowledgebaseflownodeconfiguration-knowledgebaseid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KnowledgeBaseId { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flowversion-knowledgebaseflownodeconfiguration-modelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class LambdaFunctionFlowNodeConfiguration
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-lambdafunctionflownodeconfiguration.html#cfn-bedrock-flowversion-lambdafunctionflownodeconfiguration-lambdaarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaArn { get; set; }
        }

        public class LexFlowNodeConfiguration
        {
            /// <summary>
            /// BotAliasArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-lexflownodeconfiguration.html#cfn-bedrock-flowversion-lexflownodeconfiguration-botaliasarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BotAliasArn { get; set; }
            /// <summary>
            /// LocaleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-lexflownodeconfiguration.html#cfn-bedrock-flowversion-lexflownodeconfiguration-localeid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocaleId { get; set; }
        }

        public class PromptFlowNodeConfiguration
        {
            /// <summary>
            /// SourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptflownodeconfiguration.html#cfn-bedrock-flowversion-promptflownodeconfiguration-sourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptFlowNodeSourceConfiguration
            /// </summary>
            public PromptFlowNodeSourceConfiguration SourceConfiguration { get; set; }
        }

        public class PromptFlowNodeInlineConfiguration
        {
            /// <summary>
            /// InferenceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptflownodeinlineconfiguration.html#cfn-bedrock-flowversion-promptflownodeinlineconfiguration-inferenceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptInferenceConfiguration
            /// </summary>
            public PromptInferenceConfiguration InferenceConfiguration { get; set; }
            /// <summary>
            /// TemplateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptflownodeinlineconfiguration.html#cfn-bedrock-flowversion-promptflownodeinlineconfiguration-templateconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptTemplateConfiguration
            /// </summary>
            public PromptTemplateConfiguration TemplateConfiguration { get; set; }
            /// <summary>
            /// TemplateType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptflownodeinlineconfiguration.html#cfn-bedrock-flowversion-promptflownodeinlineconfiguration-templatetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TemplateType { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptflownodeinlineconfiguration.html#cfn-bedrock-flowversion-promptflownodeinlineconfiguration-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class PromptFlowNodeResourceConfiguration
        {
            /// <summary>
            /// PromptArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptflownoderesourceconfiguration.html#cfn-bedrock-flowversion-promptflownoderesourceconfiguration-promptarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PromptArn { get; set; }
        }

        public class PromptFlowNodeSourceConfiguration
        {
            /// <summary>
            /// Resource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptflownodesourceconfiguration.html#cfn-bedrock-flowversion-promptflownodesourceconfiguration-resource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptFlowNodeResourceConfiguration
            /// </summary>
            public PromptFlowNodeResourceConfiguration Resource { get; set; }
            /// <summary>
            /// Inline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptflownodesourceconfiguration.html#cfn-bedrock-flowversion-promptflownodesourceconfiguration-inline
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptFlowNodeInlineConfiguration
            /// </summary>
            public PromptFlowNodeInlineConfiguration Inline { get; set; }
        }

        public class PromptInferenceConfiguration
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptinferenceconfiguration.html#cfn-bedrock-flowversion-promptinferenceconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptModelInferenceConfiguration
            /// </summary>
            public PromptModelInferenceConfiguration Text { get; set; }
        }

        public class PromptInputVariable
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptinputvariable.html#cfn-bedrock-flowversion-promptinputvariable-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class PromptModelInferenceConfiguration
        {
            /// <summary>
            /// TopK
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptmodelinferenceconfiguration.html#cfn-bedrock-flowversion-promptmodelinferenceconfiguration-topk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TopK { get; set; }
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptmodelinferenceconfiguration.html#cfn-bedrock-flowversion-promptmodelinferenceconfiguration-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Temperature { get; set; }
            /// <summary>
            /// StopSequences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptmodelinferenceconfiguration.html#cfn-bedrock-flowversion-promptmodelinferenceconfiguration-stopsequences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StopSequences { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptmodelinferenceconfiguration.html#cfn-bedrock-flowversion-promptmodelinferenceconfiguration-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxTokens { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-promptmodelinferenceconfiguration.html#cfn-bedrock-flowversion-promptmodelinferenceconfiguration-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TopP { get; set; }
        }

        public class PromptTemplateConfiguration
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-prompttemplateconfiguration.html#cfn-bedrock-flowversion-prompttemplateconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TextPromptTemplateConfiguration
            /// </summary>
            public TextPromptTemplateConfiguration Text { get; set; }
        }

        public class TextPromptTemplateConfiguration
        {
            /// <summary>
            /// InputVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-textprompttemplateconfiguration.html#cfn-bedrock-flowversion-textprompttemplateconfiguration-inputvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PromptInputVariable
            /// </summary>
            public List<PromptInputVariable> InputVariables { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flowversion-textprompttemplateconfiguration.html#cfn-bedrock-flowversion-textprompttemplateconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
        }
    }
}