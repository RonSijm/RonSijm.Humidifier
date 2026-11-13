namespace Humidifier.WellArchitected
{
    using global::System.Collections.Generic;

    public class AgentProfilePolicy : Humidifier.Base.BaseResource, IHavePolicy
    {
        public override string AWSTypeName { get => AWS.WellArchitected.AgentProfilePolicy; }

        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentprofilepolicy.html#cfn-wellarchitected-agentprofilepolicy-policy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Policy { get; set; }

        /// <summary>
        /// ProfileArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentprofilepolicy.html#cfn-wellarchitected-agentprofilepolicy-profilearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ProfileArn { get; set; }
    }
}