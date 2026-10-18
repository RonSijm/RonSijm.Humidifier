namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class CapacityManagerDataExport : Humidifier.Base.BaseResource, IHaveTags, IHaveS3BucketPrefix, IHaveSchedule, IHaveOutputFormat, IHaveS3BucketName
    {
        public class Attributes
        {
            public static string CapacityManagerDataExportId =  "CapacityManagerDataExportId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.CapacityManagerDataExport; }
        /// <summary>
        /// S3BucketPrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacitymanagerdataexport.html#cfn-ec2-capacitymanagerdataexport-s3bucketprefix
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? S3BucketPrefix { get; set; }

        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacitymanagerdataexport.html#cfn-ec2-capacitymanagerdataexport-schedule
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Schedule { get; set; }

        /// <summary>
        /// OutputFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacitymanagerdataexport.html#cfn-ec2-capacitymanagerdataexport-outputformat
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OutputFormat { get; set; }

        /// <summary>
        /// S3BucketName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacitymanagerdataexport.html#cfn-ec2-capacitymanagerdataexport-s3bucketname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? S3BucketName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacitymanagerdataexport.html#cfn-ec2-capacitymanagerdataexport-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}