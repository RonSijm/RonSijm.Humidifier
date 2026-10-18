namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using PolicyTypes;

    public class Policy : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHavePolicyEngineId, IHaveBedrockAgentCorePolicyTypesPolicyDefinitionDefinition, IHaveEnforcementMode, IHaveValidationMode, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string StatusReasons =  "StatusReasons" ;
            public static string PolicyArn =  "PolicyArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string PolicyId =  "PolicyId" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.Policy; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-policy.html#cfn-bedrockagentcore-policy-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// PolicyEngineId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-policy.html#cfn-bedrockagentcore-policy-policyengineid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PolicyEngineId { get; set; }

        /// <summary>
        /// Definition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-policy.html#cfn-bedrockagentcore-policy-definition
        /// Required: True
        /// UpdateType: Mutable
        /// Type: PolicyDefinition
        /// </summary>
        [Required]
        public Union<Humidifier.BedrockAgentCore.PolicyTypes.PolicyDefinition, BaseFunction>? Definition { get; set; }
        /// <summary>
        /// EnforcementMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-policy.html#cfn-bedrockagentcore-policy-enforcementmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnforcementMode { get; set; }
        /// <summary>
        /// ValidationMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-policy.html#cfn-bedrockagentcore-policy-validationmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ValidationMode { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace PolicyTypes
    {
        public class CedarPolicy : Humidifier.Base.BaseSubResource, IHaveStatement
        {
            /// <summary>
            /// Statement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-policy-cedarpolicy.html#cfn-bedrockagentcore-policy-cedarpolicy-statement
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Statement { get; set; }
        }

        public class PolicyDefinition : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCorePolicyTypesPolicyStatementPolicy, IHaveBedrockAgentCorePolicyTypesCedarPolicyCedar
        {
            /// <summary>
            /// Policy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-policy-policydefinition.html#cfn-bedrockagentcore-policy-policydefinition-policy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PolicyStatement
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement, BaseFunction>? Policy { get; set; }
            /// <summary>
            /// Cedar
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-policy-policydefinition.html#cfn-bedrockagentcore-policy-policydefinition-cedar
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CedarPolicy
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy, BaseFunction>? Cedar { get; set; }
        }

        public class PolicyStatement : Humidifier.Base.BaseSubResource, IHaveStatement
        {
            /// <summary>
            /// Statement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-policy-policystatement.html#cfn-bedrockagentcore-policy-policystatement-statement
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Statement { get; set; }
        }
    }
}