namespace Humidifier.MediaPackage
{
    using global::System.Collections.Generic;
    using HarvestJobTypes;

    public class HarvestJob : Humidifier.Base.BaseResource, IHaveMediaPackageHarvestJobTypesS3DestinationS3Destination, IHaveEndTime, IHaveOriginEndpointId, IHaveStartTime, IHaveId
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
        public Union<Humidifier.MediaPackage.HarvestJobTypes.S3Destination, BaseFunction>? S3Destination { get; set; }

        /// <summary>
        /// EndTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-harvestjob.html#cfn-mediapackage-harvestjob-endtime
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EndTime { get; set; }

        /// <summary>
        /// OriginEndpointId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-harvestjob.html#cfn-mediapackage-harvestjob-originendpointid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OriginEndpointId { get; set; }

        /// <summary>
        /// StartTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-harvestjob.html#cfn-mediapackage-harvestjob-starttime
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StartTime { get; set; }

        /// <summary>
        /// Id
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-harvestjob.html#cfn-mediapackage-harvestjob-id
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Id { get; set; }
    }

    namespace HarvestJobTypes
    {
        public class S3Destination : Humidifier.Base.BaseSubResource, IHaveManifestKey, IHaveBucketName, IHaveRoleArn
        {
            /// <summary>
            /// ManifestKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-harvestjob-s3destination.html#cfn-mediapackage-harvestjob-s3destination-manifestkey
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestKey { get; set; }
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-harvestjob-s3destination.html#cfn-mediapackage-harvestjob-s3destination-bucketname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-harvestjob-s3destination.html#cfn-mediapackage-harvestjob-s3destination-rolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }
    }
}