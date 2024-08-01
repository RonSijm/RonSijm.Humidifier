namespace Humidifier.Bedrock
{
    using System.Collections.Generic;
    using FlowTypes;

    public class Flow : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
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
        public Dictionary<string, dynamic> TestAliasTags { get; set; }

        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flow.html#cfn-bedrock-flow-executionrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ExecutionRoleArn { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flow.html#cfn-bedrock-flow-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// DefinitionString
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flow.html#cfn-bedrock-flow-definitionstring
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DefinitionString { get; set; }
        /// <summary>
        /// Definition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flow.html#cfn-bedrock-flow-definition
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FlowDefinition
        /// </summary>
        public FlowTypes.FlowDefinition Definition { get; set; }
        /// <summary>
        /// DefinitionSubstitutions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flow.html#cfn-bedrock-flow-definitionsubstitutions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: Json
        /// </summary>
        public dynamic DefinitionSubstitutions { get; set; }
        /// <summary>
        /// CustomerEncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flow.html#cfn-bedrock-flow-customerencryptionkeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CustomerEncryptionKeyArn { get; set; }
        /// <summary>
        /// DefinitionS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flow.html#cfn-bedrock-flow-definitions3location
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3Location
        /// </summary>
        public FlowTypes.S3Location DefinitionS3Location { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flow.html#cfn-bedrock-flow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace FlowTypes
    {
        public class ConditionFlowNodeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-conditionflownodeconfiguration.html#cfn-bedrock-flow-conditionflownodeconfiguration-conditions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowCondition
            /// </summary>
            public List<FlowTypes.FlowCondition> Conditions { get; set; }
        }

        public class FlowCondition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowcondition.html#cfn-bedrock-flow-flowcondition-expression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowcondition.html#cfn-bedrock-flow-flowcondition-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class FlowConditionalConnectionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowconditionalconnectionconfiguration.html#cfn-bedrock-flow-flowconditionalconnectionconfiguration-condition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Condition { get; set; }
        }

        public class FlowConnection : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowconnection.html#cfn-bedrock-flow-flowconnection-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowconnection.html#cfn-bedrock-flow-flowconnection-target
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Target { get; set; }
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowconnection.html#cfn-bedrock-flow-flowconnection-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowConnectionConfiguration
            /// </summary>
            public FlowTypes.FlowConnectionConfiguration Configuration { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowconnection.html#cfn-bedrock-flow-flowconnection-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowconnection.html#cfn-bedrock-flow-flowconnection-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class FlowConnectionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowconnectionconfiguration.html#cfn-bedrock-flow-flowconnectionconfiguration-data
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowDataConnectionConfiguration
            /// </summary>
            public FlowTypes.FlowDataConnectionConfiguration Data { get; set; }
            /// <summary>
            /// Conditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowconnectionconfiguration.html#cfn-bedrock-flow-flowconnectionconfiguration-conditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowConditionalConnectionConfiguration
            /// </summary>
            public FlowTypes.FlowConditionalConnectionConfiguration Conditional { get; set; }
        }

        public class FlowDataConnectionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowdataconnectionconfiguration.html#cfn-bedrock-flow-flowdataconnectionconfiguration-sourceoutput
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceOutput { get; set; }
            /// <summary>
            /// TargetInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowdataconnectionconfiguration.html#cfn-bedrock-flow-flowdataconnectionconfiguration-targetinput
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetInput { get; set; }
        }

        public class FlowDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Connections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowdefinition.html#cfn-bedrock-flow-flowdefinition-connections
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowConnection
            /// </summary>
            public List<FlowTypes.FlowConnection> Connections { get; set; }
            /// <summary>
            /// Nodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flowdefinition.html#cfn-bedrock-flow-flowdefinition-nodes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowNode
            /// </summary>
            public List<FlowTypes.FlowNode> Nodes { get; set; }
        }

        public class FlowNode : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownode.html#cfn-bedrock-flow-flownode-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownode.html#cfn-bedrock-flow-flownode-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowNodeConfiguration
            /// </summary>
            public FlowTypes.FlowNodeConfiguration Configuration { get; set; }
            /// <summary>
            /// Outputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownode.html#cfn-bedrock-flow-flownode-outputs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowNodeOutput
            /// </summary>
            public List<FlowTypes.FlowNodeOutput> Outputs { get; set; }
            /// <summary>
            /// Inputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownode.html#cfn-bedrock-flow-flownode-inputs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FlowNodeInput
            /// </summary>
            public List<FlowTypes.FlowNodeInput> Inputs { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownode.html#cfn-bedrock-flow-flownode-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class FlowNodeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-condition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionFlowNodeConfiguration
            /// </summary>
            public FlowTypes.ConditionFlowNodeConfiguration Condition { get; set; }
            /// <summary>
            /// Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-input
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Input { get; set; }
            /// <summary>
            /// KnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-knowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseFlowNodeConfiguration
            /// </summary>
            public FlowTypes.KnowledgeBaseFlowNodeConfiguration KnowledgeBase { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-output
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Output { get; set; }
            /// <summary>
            /// Prompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-prompt
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptFlowNodeConfiguration
            /// </summary>
            public FlowTypes.PromptFlowNodeConfiguration Prompt { get; set; }
            /// <summary>
            /// LambdaFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-lambdafunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaFunctionFlowNodeConfiguration
            /// </summary>
            public FlowTypes.LambdaFunctionFlowNodeConfiguration LambdaFunction { get; set; }
            /// <summary>
            /// Lex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeconfiguration.html#cfn-bedrock-flow-flownodeconfiguration-lex
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LexFlowNodeConfiguration
            /// </summary>
            public FlowTypes.LexFlowNodeConfiguration Lex { get; set; }
        }

        public class FlowNodeInput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeinput.html#cfn-bedrock-flow-flownodeinput-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeinput.html#cfn-bedrock-flow-flownodeinput-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeinput.html#cfn-bedrock-flow-flownodeinput-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class FlowNodeOutput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeoutput.html#cfn-bedrock-flow-flownodeoutput-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-flownodeoutput.html#cfn-bedrock-flow-flownodeoutput-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class KnowledgeBaseFlowNodeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KnowledgeBaseId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flow-knowledgebaseflownodeconfiguration-knowledgebaseid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KnowledgeBaseId { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-knowledgebaseflownodeconfiguration.html#cfn-bedrock-flow-knowledgebaseflownodeconfiguration-modelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class LambdaFunctionFlowNodeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-lambdafunctionflownodeconfiguration.html#cfn-bedrock-flow-lambdafunctionflownodeconfiguration-lambdaarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaArn { get; set; }
        }

        public class LexFlowNodeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BotAliasArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-lexflownodeconfiguration.html#cfn-bedrock-flow-lexflownodeconfiguration-botaliasarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BotAliasArn { get; set; }
            /// <summary>
            /// LocaleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-lexflownodeconfiguration.html#cfn-bedrock-flow-lexflownodeconfiguration-localeid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocaleId { get; set; }
        }

        public class PromptFlowNodeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptflownodeconfiguration.html#cfn-bedrock-flow-promptflownodeconfiguration-sourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptFlowNodeSourceConfiguration
            /// </summary>
            public FlowTypes.PromptFlowNodeSourceConfiguration SourceConfiguration { get; set; }
        }

        public class PromptFlowNodeInlineConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InferenceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptflownodeinlineconfiguration.html#cfn-bedrock-flow-promptflownodeinlineconfiguration-inferenceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptInferenceConfiguration
            /// </summary>
            public FlowTypes.PromptInferenceConfiguration InferenceConfiguration { get; set; }
            /// <summary>
            /// TemplateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptflownodeinlineconfiguration.html#cfn-bedrock-flow-promptflownodeinlineconfiguration-templateconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptTemplateConfiguration
            /// </summary>
            public FlowTypes.PromptTemplateConfiguration TemplateConfiguration { get; set; }
            /// <summary>
            /// TemplateType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptflownodeinlineconfiguration.html#cfn-bedrock-flow-promptflownodeinlineconfiguration-templatetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TemplateType { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptflownodeinlineconfiguration.html#cfn-bedrock-flow-promptflownodeinlineconfiguration-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class PromptFlowNodeResourceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PromptArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptflownoderesourceconfiguration.html#cfn-bedrock-flow-promptflownoderesourceconfiguration-promptarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PromptArn { get; set; }
        }

        public class PromptFlowNodeSourceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Resource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptflownodesourceconfiguration.html#cfn-bedrock-flow-promptflownodesourceconfiguration-resource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptFlowNodeResourceConfiguration
            /// </summary>
            public FlowTypes.PromptFlowNodeResourceConfiguration Resource { get; set; }
            /// <summary>
            /// Inline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptflownodesourceconfiguration.html#cfn-bedrock-flow-promptflownodesourceconfiguration-inline
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptFlowNodeInlineConfiguration
            /// </summary>
            public FlowTypes.PromptFlowNodeInlineConfiguration Inline { get; set; }
        }

        public class PromptInferenceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptinferenceconfiguration.html#cfn-bedrock-flow-promptinferenceconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptModelInferenceConfiguration
            /// </summary>
            public FlowTypes.PromptModelInferenceConfiguration Text { get; set; }
        }

        public class PromptInputVariable : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptinputvariable.html#cfn-bedrock-flow-promptinputvariable-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class PromptModelInferenceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TopK
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptmodelinferenceconfiguration.html#cfn-bedrock-flow-promptmodelinferenceconfiguration-topk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TopK { get; set; }
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptmodelinferenceconfiguration.html#cfn-bedrock-flow-promptmodelinferenceconfiguration-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Temperature { get; set; }
            /// <summary>
            /// StopSequences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptmodelinferenceconfiguration.html#cfn-bedrock-flow-promptmodelinferenceconfiguration-stopsequences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StopSequences { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptmodelinferenceconfiguration.html#cfn-bedrock-flow-promptmodelinferenceconfiguration-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxTokens { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-promptmodelinferenceconfiguration.html#cfn-bedrock-flow-promptmodelinferenceconfiguration-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TopP { get; set; }
        }

        public class PromptTemplateConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-prompttemplateconfiguration.html#cfn-bedrock-flow-prompttemplateconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TextPromptTemplateConfiguration
            /// </summary>
            public FlowTypes.TextPromptTemplateConfiguration Text { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-s3location.html#cfn-bedrock-flow-s3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-s3location.html#cfn-bedrock-flow-s3location-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Version { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-s3location.html#cfn-bedrock-flow-s3location-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class TextPromptTemplateConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InputVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-textprompttemplateconfiguration.html#cfn-bedrock-flow-textprompttemplateconfiguration-inputvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PromptInputVariable
            /// </summary>
            public List<FlowTypes.PromptInputVariable> InputVariables { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-flow-textprompttemplateconfiguration.html#cfn-bedrock-flow-textprompttemplateconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
        }
    }
}