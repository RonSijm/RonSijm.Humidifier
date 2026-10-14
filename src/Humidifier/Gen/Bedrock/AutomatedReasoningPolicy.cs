namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using AutomatedReasoningPolicyTypes;

    public class AutomatedReasoningPolicy : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveKmsKeyId
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
        public dynamic Description { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-automatedreasoningpolicy.html#cfn-bedrock-automatedreasoningpolicy-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyId { get; set; }
        /// <summary>
        /// PolicyDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-automatedreasoningpolicy.html#cfn-bedrock-automatedreasoningpolicy-policydefinition
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PolicyDefinition
        /// </summary>
        public Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition PolicyDefinition { get; set; }
        /// <summary>
        /// ForceDelete
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-automatedreasoningpolicy.html#cfn-bedrock-automatedreasoningpolicy-forcedelete
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic ForceDelete { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-automatedreasoningpolicy.html#cfn-bedrock-automatedreasoningpolicy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace AutomatedReasoningPolicyTypes
    {
        public class PolicyDefinition : Humidifier.Base.BaseSubResource, IHaveVersion
        {
            /// <summary>
            /// Variables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinition.html#cfn-bedrock-automatedreasoningpolicy-policydefinition-variables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PolicyDefinitionVariable
            /// </summary>
            public List<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinitionVariable> Variables { get; set; }
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinition.html#cfn-bedrock-automatedreasoningpolicy-policydefinition-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PolicyDefinitionType
            /// </summary>
            public List<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinitionType> Types { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinition.html#cfn-bedrock-automatedreasoningpolicy-policydefinition-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Version { get; set; }
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinition.html#cfn-bedrock-automatedreasoningpolicy-policydefinition-rules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PolicyDefinitionRule
            /// </summary>
            public List<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinitionRule> Rules { get; set; }
        }

        public class PolicyDefinitionRule : Humidifier.Base.BaseSubResource, IHaveId, IHaveExpression
        {
            /// <summary>
            /// AlternateExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitionrule.html#cfn-bedrock-automatedreasoningpolicy-policydefinitionrule-alternateexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlternateExpression { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitionrule.html#cfn-bedrock-automatedreasoningpolicy-policydefinitionrule-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitionrule.html#cfn-bedrock-automatedreasoningpolicy-policydefinitionrule-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }

        public class PolicyDefinitionType : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitiontype.html#cfn-bedrock-automatedreasoningpolicy-policydefinitiontype-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitiontype.html#cfn-bedrock-automatedreasoningpolicy-policydefinitiontype-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PolicyDefinitionTypeValue
            /// </summary>
            public List<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinitionTypeValue> Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitiontype.html#cfn-bedrock-automatedreasoningpolicy-policydefinitiontype-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
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
            public dynamic Description { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitiontypevalue.html#cfn-bedrock-automatedreasoningpolicy-policydefinitiontypevalue-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class PolicyDefinitionVariable : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitionvariable.html#cfn-bedrock-automatedreasoningpolicy-policydefinitionvariable-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitionvariable.html#cfn-bedrock-automatedreasoningpolicy-policydefinitionvariable-description
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-automatedreasoningpolicy-policydefinitionvariable.html#cfn-bedrock-automatedreasoningpolicy-policydefinitionvariable-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}