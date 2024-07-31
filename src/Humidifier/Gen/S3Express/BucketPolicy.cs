namespace Humidifier.S3Express
{
    using System.Collections.Generic;

    public class BucketPolicy : Humidifier.Base.BaseResource, IHavePolicyDocument
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::S3Express::BucketPolicy";
            }
        }

        /// <summary>
        /// Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3express-bucketpolicy.html#cfn-s3express-bucketpolicy-bucket
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Bucket { get; set; }

        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3express-bucketpolicy.html#cfn-s3express-bucketpolicy-policydocument
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public dynamic PolicyDocument { get; set; }
    }
}