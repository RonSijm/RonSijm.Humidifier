namespace Humidifier.S3Vectors
{
    using global::System.Collections.Generic;

    public class VectorBucketPolicy : Humidifier.Base.BaseResource, IHavePolicy_Json, IHaveVectorBucketArn, IHaveVectorBucketName
    {
        public override string AWSTypeName { get => AWS.S3Vectors.VectorBucketPolicy; }

        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3vectors-vectorbucketpolicy.html#cfn-s3vectors-vectorbucketpolicy-policy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? Policy { get; set; }
        /// <summary>
        /// VectorBucketArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3vectors-vectorbucketpolicy.html#cfn-s3vectors-vectorbucketpolicy-vectorbucketarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VectorBucketArn { get; set; }
        /// <summary>
        /// VectorBucketName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3vectors-vectorbucketpolicy.html#cfn-s3vectors-vectorbucketpolicy-vectorbucketname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VectorBucketName { get; set; }
    }
}