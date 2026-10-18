namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using PolicyGenerationTypes;

    public class PolicyGeneration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHavePolicyEngineId, IHaveBedrockAgentCorePolicyGenerationTypesResourceResource, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string StatusReasons =  "StatusReasons" ;
            public static string PolicyGenerationArn =  "PolicyGenerationArn" ;
            public static string PolicyGenerationId =  "PolicyGenerationId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.PolicyGeneration; }

        /// <summary>
        /// PolicyEngineId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-policygeneration.html#cfn-bedrockagentcore-policygeneration-policyengineid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PolicyEngineId { get; set; }

        /// <summary>
        /// Resource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-policygeneration.html#cfn-bedrockagentcore-policygeneration-resource
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Resource
        /// </summary>
        [Required]
        public Union<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource, BaseFunction>? Resource { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace PolicyGenerationTypes
    {
        public class Resource : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-policygeneration-resource.html#cfn-bedrockagentcore-policygeneration-resource-arn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }
    }
}