namespace Humidifier.S3Files
{
    using global::System.Collections.Generic;

    public class MountTarget : Humidifier.Base.BaseResource, IHaveIpAddressType, IHaveStringListOfSecurityGroups, IHaveFileSystemId, IHaveSubnetId, IHaveIpv6Address, IHaveIpv4Address
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string OwnerId =  "OwnerId" ;
            public static string VpcId =  "VpcId" ;
            public static string AvailabilityZoneId =  "AvailabilityZoneId" ;
            public static string MountTargetId =  "MountTargetId" ;
            public static string NetworkInterfaceId =  "NetworkInterfaceId" ;
            public static string StatusMessage =  "StatusMessage" ;
        }

        public override string AWSTypeName { get => AWS.S3Files.MountTarget; }
        /// <summary>
        /// IpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-mounttarget.html#cfn-s3files-mounttarget-ipaddresstype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpAddressType { get; set; }
        /// <summary>
        /// SecurityGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-mounttarget.html#cfn-s3files-mounttarget-securitygroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }

        /// <summary>
        /// FileSystemId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-mounttarget.html#cfn-s3files-mounttarget-filesystemid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FileSystemId { get; set; }

        /// <summary>
        /// SubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-mounttarget.html#cfn-s3files-mounttarget-subnetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SubnetId { get; set; }
        /// <summary>
        /// Ipv6Address
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-mounttarget.html#cfn-s3files-mounttarget-ipv6address
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Ipv6Address { get; set; }
        /// <summary>
        /// Ipv4Address
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-mounttarget.html#cfn-s3files-mounttarget-ipv4address
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Ipv4Address { get; set; }
    }
}