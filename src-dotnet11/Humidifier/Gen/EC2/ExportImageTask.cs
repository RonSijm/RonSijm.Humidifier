namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using ExportImageTaskTypes;

    public class ExportImageTask : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveImageId, IHaveEC2ExportImageTaskTypesS3ExportLocationS3ExportLocation
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ExportImageTaskId =  "ExportImageTaskId" ;
            public static string Progress =  "Progress" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.ExportImageTask; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-exportimagetask.html#cfn-ec2-exportimagetask-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ImageId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-exportimagetask.html#cfn-ec2-exportimagetask-imageid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ImageId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-exportimagetask.html#cfn-ec2-exportimagetask-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// S3ExportLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-exportimagetask.html#cfn-ec2-exportimagetask-s3exportlocation
        /// Required: True
        /// UpdateType: Immutable
        /// Type: S3ExportLocation
        /// </summary>
        [Required]
        public Union<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation, BaseFunction>? S3ExportLocation { get; set; }
    }

    namespace ExportImageTaskTypes
    {
        public class S3ExportLocation : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveS3Prefix
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-exportimagetask-s3exportlocation.html#cfn-ec2-exportimagetask-s3exportlocation-s3bucket
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// S3Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-exportimagetask-s3exportlocation.html#cfn-ec2-exportimagetask-s3exportlocation-s3prefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Prefix { get; set; }
        }
    }
}