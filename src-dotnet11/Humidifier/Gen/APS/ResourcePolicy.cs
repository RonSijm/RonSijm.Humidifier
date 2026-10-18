namespace Humidifier.APS
{
    using global::System.Collections.Generic;

    public class ResourcePolicy : Humidifier.Base.BaseResource, IHaveWorkspaceArn, IHavePolicyDocument
    {
        public override string AWSTypeName { get => AWS.APS.ResourcePolicy; }

        /// <summary>
        /// WorkspaceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-resourcepolicy.html#cfn-aps-resourcepolicy-workspacearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? WorkspaceArn { get; set; }

        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-resourcepolicy.html#cfn-aps-resourcepolicy-policydocument
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PolicyDocument { get; set; }
    }
}