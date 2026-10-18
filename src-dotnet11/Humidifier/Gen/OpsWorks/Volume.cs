namespace Humidifier.OpsWorks
{
    using global::System.Collections.Generic;

    public class Volume : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveEc2VolumeId, IHaveMountPoint, IHaveName, IHaveStackId
    {
        public override string AWSTypeName { get => AWS.OpsWorks.Volume; }

        /// <summary>
        /// Ec2VolumeId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-volume.html#cfn-opsworks-volume-ec2volumeid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Ec2VolumeId { get; set; }
        /// <summary>
        /// MountPoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-volume.html#cfn-opsworks-volume-mountpoint
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MountPoint { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// StackId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-volume.html#cfn-opsworks-volume-stackid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StackId { get; set; }
    }
}