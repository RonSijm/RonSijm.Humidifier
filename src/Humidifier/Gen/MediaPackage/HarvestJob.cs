namespace Humidifier.MediaPackage
{
    using global::System.Collections.Generic;
    using HarvestJobTypes;

    public class HarvestJob : Humidifier.Base.BaseResource, IHaveId, IHaveStartTime, IHaveEndTime
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string ChannelId =  "ChannelId" ;
        }

        public override string AWSTypeName { get => AWS.MediaPackage.HarvestJob; }

        /// <summary>
        /// S3Destination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-harvestjob.html#cfn-mediapackage-harvestjob-s3destination
        /// Required: True
        /// UpdateType: Immutable
        /// Type: S3Destination
        /// </summary>
        [Required]
        public Humidifier.MediaPackage.HarvestJobTypes.S3Destination S3Destination { get; set; }

        /// <summary>
        /// EndTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-harvestjob.html#cfn-mediapackage-harvestjob-endtime
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EndTime { get; set; }

        /// <summary>
        /// OriginEndpointId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-harvestjob.html#cfn-mediapackage-harvestjob-originendpointid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic OriginEndpointId { get; set; }

        /// <summary>
        /// StartTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-harvestjob.html#cfn-mediapackage-harvestjob-starttime
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic StartTime { get; set; }

        /// <summary>
        /// Id
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-harvestjob.html#cfn-mediapackage-harvestjob-id
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Id { get; set; }
    }

    namespace HarvestJobTypes
    {
        public class S3Destination : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveBucketName
        {
            /// <summary>
            /// ManifestKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-harvestjob-s3destination.html#cfn-mediapackage-harvestjob-s3destination-manifestkey
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestKey { get; set; }
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-harvestjob-s3destination.html#cfn-mediapackage-harvestjob-s3destination-bucketname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-harvestjob-s3destination.html#cfn-mediapackage-harvestjob-s3destination-rolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }
    }
}