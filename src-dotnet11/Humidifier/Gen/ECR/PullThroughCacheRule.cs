namespace Humidifier.ECR
{
    using global::System.Collections.Generic;

    public class PullThroughCacheRule : Humidifier.Base.BaseResource, IHaveUpstreamRegistryUrl, IHaveCustomRoleArn, IHaveUpstreamRepositoryPrefix, IHaveUpstreamRegistry, IHaveCredentialArn, IHaveEcrRepositoryPrefix
    {
        public override string AWSTypeName { get => AWS.ECR.PullThroughCacheRule; }
        /// <summary>
        /// UpstreamRegistryUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-pullthroughcacherule.html#cfn-ecr-pullthroughcacherule-upstreamregistryurl
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UpstreamRegistryUrl { get; set; }
        /// <summary>
        /// CustomRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-pullthroughcacherule.html#cfn-ecr-pullthroughcacherule-customrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CustomRoleArn { get; set; }
        /// <summary>
        /// UpstreamRepositoryPrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-pullthroughcacherule.html#cfn-ecr-pullthroughcacherule-upstreamrepositoryprefix
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UpstreamRepositoryPrefix { get; set; }
        /// <summary>
        /// UpstreamRegistry
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-pullthroughcacherule.html#cfn-ecr-pullthroughcacherule-upstreamregistry
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UpstreamRegistry { get; set; }
        /// <summary>
        /// CredentialArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-pullthroughcacherule.html#cfn-ecr-pullthroughcacherule-credentialarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CredentialArn { get; set; }
        /// <summary>
        /// EcrRepositoryPrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-pullthroughcacherule.html#cfn-ecr-pullthroughcacherule-ecrrepositoryprefix
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EcrRepositoryPrefix { get; set; }
    }
}