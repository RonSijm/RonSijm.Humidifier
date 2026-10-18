namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;

    public class ResourcePolicy : Humidifier.Base.BaseResource, IHavePolicy, IHaveResourceArn
    {
        public override string AWSTypeName { get => AWS.BedrockAgentCore.ResourcePolicy; }

        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-resourcepolicy.html#cfn-bedrockagentcore-resourcepolicy-policy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Policy { get; set; }

        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-resourcepolicy.html#cfn-bedrockagentcore-resourcepolicy-resourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceArn { get; set; }
    }
}