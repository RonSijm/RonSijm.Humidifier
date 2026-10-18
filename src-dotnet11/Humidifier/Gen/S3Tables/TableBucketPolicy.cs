namespace Humidifier.S3Tables
{
    using global::System.Collections.Generic;

    public class TableBucketPolicy : Humidifier.Base.BaseResource, IHaveTableBucketARN, IHaveResourcePolicy_Json
    {
        public override string AWSTypeName { get => AWS.S3Tables.TableBucketPolicy; }

        /// <summary>
        /// TableBucketARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-tablebucketpolicy.html#cfn-s3tables-tablebucketpolicy-tablebucketarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TableBucketARN { get; set; }

        /// <summary>
        /// ResourcePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-tablebucketpolicy.html#cfn-s3tables-tablebucketpolicy-resourcepolicy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? ResourcePolicy { get; set; }
    }
}