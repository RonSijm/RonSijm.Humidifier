namespace Humidifier.S3Express
{
    using global::System.Collections.Generic;

    public class BucketPolicy : Humidifier.Base.BaseResource, IHaveBucket, IHavePolicyDocument_Json
    {
        public override string AWSTypeName { get => AWS.S3Express.BucketPolicy; }

        /// <summary>
        /// Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3express-bucketpolicy.html#cfn-s3express-bucketpolicy-bucket
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Bucket { get; set; }

        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3express-bucketpolicy.html#cfn-s3express-bucketpolicy-policydocument
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? PolicyDocument { get; set; }
    }
}