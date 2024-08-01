namespace Humidifier.ECR
{
    using System.Collections.Generic;

    public class PullThroughCacheRule : Humidifier.Base.BaseResource
    {
        public override string AWSTypeName { get => AWS.ECR.PullThroughCacheRule; }
        /// <summary>
        /// UpstreamRegistryUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-pullthroughcacherule.html#cfn-ecr-pullthroughcacherule-upstreamregistryurl
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UpstreamRegistryUrl { get; set; }
        /// <summary>
        /// UpstreamRegistry
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-pullthroughcacherule.html#cfn-ecr-pullthroughcacherule-upstreamregistry
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UpstreamRegistry { get; set; }
        /// <summary>
        /// CredentialArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-pullthroughcacherule.html#cfn-ecr-pullthroughcacherule-credentialarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CredentialArn { get; set; }
        /// <summary>
        /// EcrRepositoryPrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-pullthroughcacherule.html#cfn-ecr-pullthroughcacherule-ecrrepositoryprefix
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EcrRepositoryPrefix { get; set; }
    }
}