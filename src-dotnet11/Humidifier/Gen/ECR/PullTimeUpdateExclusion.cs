namespace Humidifier.ECR
{
    using global::System.Collections.Generic;

    public class PullTimeUpdateExclusion : Humidifier.Base.BaseResource, IHavePrincipalArn
    {
        public override string AWSTypeName { get => AWS.ECR.PullTimeUpdateExclusion; }

        /// <summary>
        /// PrincipalArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-pulltimeupdateexclusion.html#cfn-ecr-pulltimeupdateexclusion-principalarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PrincipalArn { get; set; }
    }
}