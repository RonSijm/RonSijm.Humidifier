namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class VolumeAttachment : Humidifier.Base.BaseResource, IHaveVolumeId, IHaveInstanceId, IHaveDevice, IHaveEbsCardIndex_Integer
    {
        public override string AWSTypeName { get => AWS.EC2.VolumeAttachment; }

        /// <summary>
        /// VolumeId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-volumeattachment.html#cfn-ec2-volumeattachment-volumeid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VolumeId { get; set; }

        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-volumeattachment.html#cfn-ec2-volumeattachment-instanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceId { get; set; }
        /// <summary>
        /// Device
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-volumeattachment.html#cfn-ec2-volumeattachment-device
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Device { get; set; }
        /// <summary>
        /// EbsCardIndex
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-volumeattachment.html#cfn-ec2-volumeattachment-ebscardindex
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? EbsCardIndex { get; set; }
    }
}