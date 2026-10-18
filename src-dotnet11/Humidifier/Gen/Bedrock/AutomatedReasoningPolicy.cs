namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using AutomatedReasoningPolicyTypes;

    public class AutomatedReasoningPolicy : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveKmsKeyId, IHaveBedrockAutomatedReasoningPolicyTypesPolicyDefinitionPolicyDefinition, IHaveForceDelete_Boolean, IHaveName
    {
        public class Attributes
        {
            public static string DefinitionHash =  "DefinitionHash" ;
            public static string KmsKeyArn =  "KmsKeyArn" ;
            public static string PolicyArn =  "PolicyArn" ;
            public static string Version =  "Version" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string PolicyId =  "PolicyId" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.AutomatedReasoningPolicy; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-automatedreasoningpolicy.html#cfn-bedrock-automatedreasoningpolicy-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-automatedreasoningpolicy.html#cfn-bedrock-automatedreasoningpolicy-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// PolicyDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-automatedreasoningpolicy.html#cfn-bedrock-automatedreasoningpolicy-policydefinition
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PolicyDefinition
        /// </summary>
        public Union<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition, BaseFunction>? PolicyDefinition { get; set; }
        /// <summary>
        /// ForceDelete
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-automatedreasoningpolicy.html#cfn-bedrock-automatedreasoningpolicy-forcedelete
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ForceDelete { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-automatedreasoningpolicy.html#cfn-bedrock-automatedreasoningpolicy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AutomatedReasoningPolicyTypes
    {
        public class PolicyDefinition : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAutomatedReasoningPolicyTypesPolicyDefinitionVariableVariables, IHaveListOfBedrockAutomatedReasoningPolicyTypesPolicyDefinitionTypeTypes, IHaveVersion, IHaveListOfBedrockAutomatedReasoningPolicyTypesPolicyDefinitionRuleRules
        {
            /// <summary>
            /// Variables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinition.html#cfn-bedrock-automatedreasoningpolicy-policydefinition-variables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PolicyDefinitionVariable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinitionVariable>, IReadOnlyList<Union<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinitionVariable, BaseFunction>>, BaseFunction>? Variables { get; set; }
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinition.html#cfn-bedrock-automatedreasoningpolicy-policydefinition-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PolicyDefinitionType
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinitionType>, IReadOnlyList<Union<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinitionType, BaseFunction>>, BaseFunction>? Types { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinition.html#cfn-bedrock-automatedreasoningpolicy-policydefinition-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinition.html#cfn-bedrock-automatedreasoningpolicy-policydefinition-rules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PolicyDefinitionRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinitionRule>, IReadOnlyList<Union<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinitionRule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        }

        public class PolicyDefinitionRule : Humidifier.Base.BaseSubResource, IHaveAlternateExpression, IHaveExpression, IHaveId
        {
            /// <summary>
            /// AlternateExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitionrule.html#cfn-bedrock-automatedreasoningpolicy-policydefinitionrule-alternateexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlternateExpression { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitionrule.html#cfn-bedrock-automatedreasoningpolicy-policydefinitionrule-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitionrule.html#cfn-bedrock-automatedreasoningpolicy-policydefinitionrule-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class PolicyDefinitionType : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveListOfBedrockAutomatedReasoningPolicyTypesPolicyDefinitionTypeValueValues, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitiontype.html#cfn-bedrock-automatedreasoningpolicy-policydefinitiontype-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitiontype.html#cfn-bedrock-automatedreasoningpolicy-policydefinitiontype-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PolicyDefinitionTypeValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinitionTypeValue>, IReadOnlyList<Union<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinitionTypeValue, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitiontype.html#cfn-bedrock-automatedreasoningpolicy-policydefinitiontype-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class PolicyDefinitionTypeValue : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveValue
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitiontypevalue.html#cfn-bedrock-automatedreasoningpolicy-policydefinitiontypevalue-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitiontypevalue.html#cfn-bedrock-automatedreasoningpolicy-policydefinitiontypevalue-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class PolicyDefinitionVariable : Humidifier.Base.BaseSubResource, IHaveType, IHaveDescription, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitionvariable.html#cfn-bedrock-automatedreasoningpolicy-policydefinitionvariable-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitionvariable.html#cfn-bedrock-automatedreasoningpolicy-policydefinitionvariable-description
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitionvariable.html#cfn-bedrock-automatedreasoningpolicy-policydefinitionvariable-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}