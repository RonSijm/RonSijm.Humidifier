namespace Humidifier.Bedrock
{
    using System.Collections.Generic;
    using AgentTypes;

    public class Agent : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveCustomerEncryptionKeyArn, IHaveSkipResourceInUseCheckOnDelete, IHaveIdleSessionTTLInSeconds, IHaveAgentName
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
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// SkipResourceInUseCheckOnDelete
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-skipresourceinusecheckondelete
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic SkipResourceInUseCheckOnDelete { get; set; }
        /// <summary>
        /// GuardrailConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-guardrailconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GuardrailConfiguration
        /// </summary>
        public Humidifier.Bedrock.AgentTypes.GuardrailConfiguration GuardrailConfiguration { get; set; }
        /// <summary>
        /// PromptOverrideConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-promptoverrideconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PromptOverrideConfiguration
        /// </summary>
        public Humidifier.Bedrock.AgentTypes.PromptOverrideConfiguration PromptOverrideConfiguration { get; set; }
        /// <summary>
        /// Instruction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-instruction
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Instruction { get; set; }
        /// <summary>
        /// TestAliasTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-testaliastags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> TestAliasTags { get; set; }
        /// <summary>
        /// AgentResourceRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-agentresourcerolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AgentResourceRoleArn { get; set; }
        /// <summary>
        /// FoundationModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-foundationmodel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FoundationModel { get; set; }
        /// <summary>
        /// IdleSessionTTLInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-idlesessionttlinseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic IdleSessionTTLInSeconds { get; set; }
        /// <summary>
        /// CustomerEncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-customerencryptionkeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CustomerEncryptionKeyArn { get; set; }
        public dynamic AgentName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// KnowledgeBases
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-knowledgebases
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AgentKnowledgeBase
        /// </summary>
        public List<Humidifier.Bedrock.AgentTypes.AgentKnowledgeBase> KnowledgeBases { get; set; }
        /// <summary>
        /// ActionGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-actiongroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AgentActionGroup
        /// </summary>
        public List<Humidifier.Bedrock.AgentTypes.AgentActionGroup> ActionGroups { get; set; }
        /// <summary>
        /// AutoPrepare
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-autoprepare
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AutoPrepare { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-agent.html#cfn-bedrock-agent-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }

    namespace AgentTypes
    {
        public class APISchema : Humidifier.Base.BaseSubResource, IHavePayload
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-apischema.html#cfn-bedrock-agent-apischema-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Identifier
            /// </summary>
            public Humidifier.Bedrock.AgentTypes.S3Identifier S3 { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-apischema.html#cfn-bedrock-agent-apischema-payload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Payload { get; set; }
        }

        public class ActionGroupExecutor : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-actiongroupexecutor.html#cfn-bedrock-agent-actiongroupexecutor-customcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomControl { get; set; }
            /// <summary>
            /// Lambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-actiongroupexecutor.html#cfn-bedrock-agent-actiongroupexecutor-lambda
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Lambda { get; set; }
        }

        public class AgentActionGroup : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveSkipResourceInUseCheckOnDelete
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentactiongroup.html#cfn-bedrock-agent-agentactiongroup-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// ApiSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentactiongroup.html#cfn-bedrock-agent-agentactiongroup-apischema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: APISchema
            /// </summary>
            public Humidifier.Bedrock.AgentTypes.APISchema ApiSchema { get; set; }
            /// <summary>
            /// FunctionSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentactiongroup.html#cfn-bedrock-agent-agentactiongroup-functionschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunctionSchema
            /// </summary>
            public Humidifier.Bedrock.AgentTypes.FunctionSchema FunctionSchema { get; set; }
            /// <summary>
            /// SkipResourceInUseCheckOnDelete
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentactiongroup.html#cfn-bedrock-agent-agentactiongroup-skipresourceinusecheckondelete
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SkipResourceInUseCheckOnDelete { get; set; }
            /// <summary>
            /// ParentActionGroupSignature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentactiongroup.html#cfn-bedrock-agent-agentactiongroup-parentactiongroupsignature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParentActionGroupSignature { get; set; }
            /// <summary>
            /// ActionGroupExecutor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentactiongroup.html#cfn-bedrock-agent-agentactiongroup-actiongroupexecutor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ActionGroupExecutor
            /// </summary>
            public Humidifier.Bedrock.AgentTypes.ActionGroupExecutor ActionGroupExecutor { get; set; }
            /// <summary>
            /// ActionGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentactiongroup.html#cfn-bedrock-agent-agentactiongroup-actiongroupname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionGroupName { get; set; }
            /// <summary>
            /// ActionGroupState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentactiongroup.html#cfn-bedrock-agent-agentactiongroup-actiongroupstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionGroupState { get; set; }
        }

        public class AgentKnowledgeBase : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveKnowledgeBaseId
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentknowledgebase.html#cfn-bedrock-agent-agentknowledgebase-description
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// KnowledgeBaseState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentknowledgebase.html#cfn-bedrock-agent-agentknowledgebase-knowledgebasestate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KnowledgeBaseState { get; set; }
            /// <summary>
            /// KnowledgeBaseId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-agentknowledgebase.html#cfn-bedrock-agent-agentknowledgebase-knowledgebaseid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KnowledgeBaseId { get; set; }
        }

        public class Function : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-function.html#cfn-bedrock-agent-function-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-function.html#cfn-bedrock-agent-function-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: ParameterDetail
            /// </summary>
            public Dictionary<string, Humidifier.Bedrock.AgentTypes.ParameterDetail> Parameters { get; set; }
            /// <summary>
            /// RequireConfirmation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-function.html#cfn-bedrock-agent-function-requireconfirmation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RequireConfirmation { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-function.html#cfn-bedrock-agent-function-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class FunctionSchema : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Functions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-functionschema.html#cfn-bedrock-agent-functionschema-functions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Function
            /// </summary>
            public List<Humidifier.Bedrock.AgentTypes.Function> Functions { get; set; }
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
            public dynamic GuardrailIdentifier { get; set; }
            /// <summary>
            /// GuardrailVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-guardrailconfiguration.html#cfn-bedrock-agent-guardrailconfiguration-guardrailversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GuardrailVersion { get; set; }
        }

        public class InferenceConfiguration : Humidifier.Base.BaseSubResource, IHaveTemperature, IHaveStopSequences, IHaveTopP, IHaveMaximumLength
        {
            /// <summary>
            /// TopK
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-inferenceconfiguration.html#cfn-bedrock-agent-inferenceconfiguration-topk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TopK { get; set; }
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-inferenceconfiguration.html#cfn-bedrock-agent-inferenceconfiguration-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Temperature { get; set; }
            /// <summary>
            /// MaximumLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-inferenceconfiguration.html#cfn-bedrock-agent-inferenceconfiguration-maximumlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaximumLength { get; set; }
            /// <summary>
            /// StopSequences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-inferenceconfiguration.html#cfn-bedrock-agent-inferenceconfiguration-stopsequences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StopSequences { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-inferenceconfiguration.html#cfn-bedrock-agent-inferenceconfiguration-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TopP { get; set; }
        }

        public class ParameterDetail : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveType, IHaveRequired
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-parameterdetail.html#cfn-bedrock-agent-parameterdetail-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-parameterdetail.html#cfn-bedrock-agent-parameterdetail-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-parameterdetail.html#cfn-bedrock-agent-parameterdetail-required
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Required { get; set; }
        }

        public class PromptConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PromptType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptconfiguration.html#cfn-bedrock-agent-promptconfiguration-prompttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PromptType { get; set; }
            /// <summary>
            /// PromptState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptconfiguration.html#cfn-bedrock-agent-promptconfiguration-promptstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PromptState { get; set; }
            /// <summary>
            /// BasePromptTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptconfiguration.html#cfn-bedrock-agent-promptconfiguration-baseprompttemplate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BasePromptTemplate { get; set; }
            /// <summary>
            /// InferenceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptconfiguration.html#cfn-bedrock-agent-promptconfiguration-inferenceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceConfiguration
            /// </summary>
            public Humidifier.Bedrock.AgentTypes.InferenceConfiguration InferenceConfiguration { get; set; }
            /// <summary>
            /// PromptCreationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptconfiguration.html#cfn-bedrock-agent-promptconfiguration-promptcreationmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PromptCreationMode { get; set; }
            /// <summary>
            /// ParserMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptconfiguration.html#cfn-bedrock-agent-promptconfiguration-parsermode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParserMode { get; set; }
        }

        public class PromptOverrideConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PromptConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptoverrideconfiguration.html#cfn-bedrock-agent-promptoverrideconfiguration-promptconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PromptConfiguration
            /// </summary>
            public List<Humidifier.Bedrock.AgentTypes.PromptConfiguration> PromptConfigurations { get; set; }
            /// <summary>
            /// OverrideLambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-promptoverrideconfiguration.html#cfn-bedrock-agent-promptoverrideconfiguration-overridelambda
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OverrideLambda { get; set; }
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
            public dynamic S3BucketName { get; set; }
            /// <summary>
            /// S3ObjectKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-agent-s3identifier.html#cfn-bedrock-agent-s3identifier-s3objectkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3ObjectKey { get; set; }
        }
    }
}