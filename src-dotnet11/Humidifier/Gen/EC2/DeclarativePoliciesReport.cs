namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class DeclarativePoliciesReport : Humidifier.Base.BaseResource, IHaveTags, IHaveS3Bucket, IHaveS3Prefix, IHaveTargetId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string EndTime =  "EndTime" ;
            public static string StartTime =  "StartTime" ;
            public static string ReportId =  "ReportId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.DeclarativePoliciesReport; }

        /// <summary>
        /// S3Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-declarativepoliciesreport.html#cfn-ec2-declarativepoliciesreport-s3bucket
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? S3Bucket { get; set; }
        /// <summary>
        /// S3Prefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-declarativepoliciesreport.html#cfn-ec2-declarativepoliciesreport-s3prefix
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? S3Prefix { get; set; }

        /// <summary>
        /// TargetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-declarativepoliciesreport.html#cfn-ec2-declarativepoliciesreport-targetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-declarativepoliciesreport.html#cfn-ec2-declarativepoliciesreport-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}