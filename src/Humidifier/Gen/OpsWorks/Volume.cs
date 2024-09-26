namespace Humidifier.OpsWorks
{
    using System.Collections.Generic;

    public class Volume : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveMountPoint, IHaveStackId
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
        public dynamic Ec2VolumeId { get; set; }
        /// <summary>
        /// MountPoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-volume.html#cfn-opsworks-volume-mountpoint
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MountPoint { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// StackId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-volume.html#cfn-opsworks-volume-stackid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic StackId { get; set; }
    }
}