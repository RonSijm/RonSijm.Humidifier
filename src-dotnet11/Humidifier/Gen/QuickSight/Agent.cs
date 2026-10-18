namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using AgentTypes;

    public class Agent : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveAgentLifecycle, IHaveDescription, IHaveStringListOfStarterPrompts, IHaveStringListOfSpaces, IHaveAwsAccountId, IHaveQuickSightAgentTypesCustomPromptInputCustomPromptInput, IHaveAgentId, IHaveIconId, IHaveWelcomeMessage, IHaveStringListOfActionConnectors, IHaveListOfQuickSightAgentTypesAgentTagTags, IHaveName
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string Creator =  "Creator" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string CustomPromptInterface =  "CustomPromptInterface" ;
            public static string AgentStatus =  "AgentStatus" ;
            public static string Arn =  "Arn" ;
            public static string ErrorMessage =  "ErrorMessage" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.Agent; }
        /// <summary>
        /// AgentLifecycle
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-agent.html#cfn-quicksight-agent-agentlifecycle
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AgentLifecycle { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-agent.html#cfn-quicksight-agent-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// StarterPrompts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-agent.html#cfn-quicksight-agent-starterprompts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StarterPrompts { get; set; }
        /// <summary>
        /// Spaces
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-agent.html#cfn-quicksight-agent-spaces
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Spaces { get; set; }

        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-agent.html#cfn-quicksight-agent-awsaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AwsAccountId { get; set; }
        /// <summary>
        /// CustomPromptInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-agent.html#cfn-quicksight-agent-custompromptinput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomPromptInput
        /// </summary>
        public Union<Humidifier.QuickSight.AgentTypes.CustomPromptInput, BaseFunction>? CustomPromptInput { get; set; }

        /// <summary>
        /// AgentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-agent.html#cfn-quicksight-agent-agentid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AgentId { get; set; }
        /// <summary>
        /// IconId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-agent.html#cfn-quicksight-agent-iconid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IconId { get; set; }
        /// <summary>
        /// WelcomeMessage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-agent.html#cfn-quicksight-agent-welcomemessage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WelcomeMessage { get; set; }
        /// <summary>
        /// ActionConnectors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-agent.html#cfn-quicksight-agent-actionconnectors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ActionConnectors { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-agent.html#cfn-quicksight-agent-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AgentTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QuickSight.AgentTypes.AgentTag>, IReadOnlyList<Union<Humidifier.QuickSight.AgentTypes.AgentTag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AgentTypes
    {
        public class AgentTag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-agenttag.html#cfn-quicksight-agent-agenttag-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-agenttag.html#cfn-quicksight-agent-agenttag-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class CustomPromptInput : Humidifier.Base.BaseSubResource, IHaveQuickSightAgentTypesCustomPromptInputParametersNewPrompt, IHaveQuickSightAgentTypesCustomPromptProfileExistingPrompt
        {
            /// <summary>
            /// NewPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptinput.html#cfn-quicksight-agent-custompromptinput-newprompt
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomPromptInputParameters
            /// </summary>
            public Union<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters, BaseFunction>? NewPrompt { get; set; }
            /// <summary>
            /// ExistingPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptinput.html#cfn-quicksight-agent-custompromptinput-existingprompt
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomPromptProfile
            /// </summary>
            public Union<Humidifier.QuickSight.AgentTypes.CustomPromptProfile, BaseFunction>? ExistingPrompt { get; set; }
        }

        public class CustomPromptInputParameters : Humidifier.Base.BaseSubResource, IHaveResponseLength, IHaveCustomInstructions, IHaveTone, IHaveIdentity, IHaveOutputStyle
        {
            /// <summary>
            /// ResponseLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptinputparameters.html#cfn-quicksight-agent-custompromptinputparameters-responselength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResponseLength { get; set; }
            /// <summary>
            /// CustomInstructions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptinputparameters.html#cfn-quicksight-agent-custompromptinputparameters-custominstructions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomInstructions { get; set; }
            /// <summary>
            /// Tone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptinputparameters.html#cfn-quicksight-agent-custompromptinputparameters-tone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Tone { get; set; }
            /// <summary>
            /// Identity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptinputparameters.html#cfn-quicksight-agent-custompromptinputparameters-identity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Identity { get; set; }
            /// <summary>
            /// OutputStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptinputparameters.html#cfn-quicksight-agent-custompromptinputparameters-outputstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputStyle { get; set; }
        }

        public class CustomPromptInterface : Humidifier.Base.BaseSubResource, IHaveResponseLength, IHaveCustomInstructions, IHaveSubscriptionId, IHaveTone, IHavePromptSummary, IHaveIdentity, IHaveOutputStyle, IHaveModelProfileId, IHaveQbsAwsAccountId
        {
            /// <summary>
            /// ResponseLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptinterface.html#cfn-quicksight-agent-custompromptinterface-responselength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResponseLength { get; set; }
            /// <summary>
            /// CustomInstructions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptinterface.html#cfn-quicksight-agent-custompromptinterface-custominstructions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomInstructions { get; set; }
            /// <summary>
            /// SubscriptionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptinterface.html#cfn-quicksight-agent-custompromptinterface-subscriptionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubscriptionId { get; set; }
            /// <summary>
            /// Tone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptinterface.html#cfn-quicksight-agent-custompromptinterface-tone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Tone { get; set; }
            /// <summary>
            /// PromptSummary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptinterface.html#cfn-quicksight-agent-custompromptinterface-promptsummary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PromptSummary { get; set; }
            /// <summary>
            /// Identity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptinterface.html#cfn-quicksight-agent-custompromptinterface-identity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Identity { get; set; }
            /// <summary>
            /// OutputStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptinterface.html#cfn-quicksight-agent-custompromptinterface-outputstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputStyle { get; set; }
            /// <summary>
            /// ModelProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptinterface.html#cfn-quicksight-agent-custompromptinterface-modelprofileid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelProfileId { get; set; }
            /// <summary>
            /// QbsAwsAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptinterface.html#cfn-quicksight-agent-custompromptinterface-qbsawsaccountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QbsAwsAccountId { get; set; }
        }

        public class CustomPromptProfile : Humidifier.Base.BaseSubResource, IHaveSubscriptionId, IHaveModelProfileId, IHaveQbsAwsAccountId
        {
            /// <summary>
            /// SubscriptionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptprofile.html#cfn-quicksight-agent-custompromptprofile-subscriptionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubscriptionId { get; set; }
            /// <summary>
            /// ModelProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptprofile.html#cfn-quicksight-agent-custompromptprofile-modelprofileid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelProfileId { get; set; }
            /// <summary>
            /// QbsAwsAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-agent-custompromptprofile.html#cfn-quicksight-agent-custompromptprofile-qbsawsaccountid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QbsAwsAccountId { get; set; }
        }
    }
}