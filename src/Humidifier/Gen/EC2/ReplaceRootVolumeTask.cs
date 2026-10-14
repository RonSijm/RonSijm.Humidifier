namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class ReplaceRootVolumeTask : Humidifier.Base.BaseResource, IHaveTags, IHaveInstanceId
    {
        public class Attributes
        {
            public static string SnapshotId =  "SnapshotId" ;
            public static string StartTime =  "StartTime" ;
            public static string Arn =  "Arn" ;
            public static string TaskState =  "TaskState" ;
            public static string CompleteTime =  "CompleteTime" ;
            public static string ReplaceRootVolumeTaskId =  "ReplaceRootVolumeTaskId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.ReplaceRootVolumeTask; }
        /// <summary>
        /// DeleteReplacedRootVolume
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-replacerootvolumetask.html#cfn-ec2-replacerootvolumetask-deletereplacedrootvolume
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DeleteReplacedRootVolume { get; set; }

        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-replacerootvolumetask.html#cfn-ec2-replacerootvolumetask-instanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-replacerootvolumetask.html#cfn-ec2-replacerootvolumetask-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}