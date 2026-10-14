namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using ImageTypes;

    public class Image : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string ImageOwnerAlias =  "ImageOwnerAlias" ;
            public static string CreationDate =  "CreationDate" ;
            public static string Description =  "Description" ;
            public static string RootDeviceName =  "RootDeviceName" ;
            public static string Platform =  "Platform" ;
            public static string PlatformDetails =  "PlatformDetails" ;
            public static string EnaSupport =  "EnaSupport" ;
            public static string BootMode =  "BootMode" ;
            public static string BlockDeviceMappings =  "BlockDeviceMappings" ;
            public static string KernelId =  "KernelId" ;
            public static string SourceInstanceId =  "SourceInstanceId" ;
            public static string ImageLocation =  "ImageLocation" ;
            public static string Name =  "Name" ;
            public static string ImageType =  "ImageType" ;
            public static string ImageAllowed =  "ImageAllowed" ;
            public static string SourceImageRegion =  "SourceImageRegion" ;
            public static string OwnerId =  "OwnerId" ;
            public static string ImageId =  "ImageId" ;
            public static string DeprecationTime =  "DeprecationTime" ;
            public static string Tags =  "Tags" ;
            public static string ProductCodes =  "ProductCodes" ;
            public static string Architecture =  "Architecture" ;
            public static string Hypervisor =  "Hypervisor" ;
            public static string VirtualizationType =  "VirtualizationType" ;
            public static string PublicSsmParameterName =  "PublicSsmParameterName" ;
            public static string SriovNetSupport =  "SriovNetSupport" ;
            public static string TpmSupport =  "TpmSupport" ;
            public static string Public =  "Public" ;
            public static string SourceImageId =  "SourceImageId" ;
            public static string RamdiskId =  "RamdiskId" ;
            public static string RootDeviceType =  "RootDeviceType" ;
            public static string DeregistrationProtection =  "DeregistrationProtection" ;
            public static string ImdsSupport =  "ImdsSupport" ;
            public static string FreeTierEligible =  "FreeTierEligible" ;
            public static string State =  "State" ;
            public static string LastLaunchedTime =  "LastLaunchedTime" ;
            public static string ImageWatermarks =  "ImageWatermarks" ;
            public static string Arn =  "Arn" ;
            public static string UsageOperation =  "UsageOperation" ;
        }

        public override string AWSTypeName { get => AWS.EC2.Image; }
    }

    namespace ImageTypes
    {
        public class BlockDeviceMapping : Humidifier.Base.BaseSubResource, IHaveDeviceName, IHaveNoDevice, IHaveVirtualName
        {
            /// <summary>
            /// Ebs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-blockdevicemapping.html#cfn-ec2-image-blockdevicemapping-ebs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EbsBlockDevice
            /// </summary>
            public Humidifier.EC2.ImageTypes.EbsBlockDevice Ebs { get; set; }
            /// <summary>
            /// NoDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-blockdevicemapping.html#cfn-ec2-image-blockdevicemapping-nodevice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NoDevice { get; set; }
            /// <summary>
            /// VirtualName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-blockdevicemapping.html#cfn-ec2-image-blockdevicemapping-virtualname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VirtualName { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-blockdevicemapping.html#cfn-ec2-image-blockdevicemapping-devicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceName { get; set; }
        }

        public class EbsBlockDevice : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveAvailabilityZone, IHaveIops, IHaveVolumeType, IHaveEncrypted, IHaveDeleteOnTermination, IHaveThroughput, IHaveVolumeSize, IHaveSnapshotId, IHaveOutpostArn, IHaveAvailabilityZoneId
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-ebsblockdevice.html#cfn-ec2-image-ebsblockdevice-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-ebsblockdevice.html#cfn-ec2-image-ebsblockdevice-encrypted
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Encrypted { get; set; }
            /// <summary>
            /// EbsCardIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-ebsblockdevice.html#cfn-ec2-image-ebsblockdevice-ebscardindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EbsCardIndex { get; set; }
            /// <summary>
            /// OutpostArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-ebsblockdevice.html#cfn-ec2-image-ebsblockdevice-outpostarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutpostArn { get; set; }
            /// <summary>
            /// AvailabilityZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-ebsblockdevice.html#cfn-ec2-image-ebsblockdevice-availabilityzoneid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityZoneId { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-ebsblockdevice.html#cfn-ec2-image-ebsblockdevice-throughput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Throughput { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-ebsblockdevice.html#cfn-ec2-image-ebsblockdevice-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityZone { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-ebsblockdevice.html#cfn-ec2-image-ebsblockdevice-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Iops { get; set; }
            /// <summary>
            /// VolumeInitializationRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-ebsblockdevice.html#cfn-ec2-image-ebsblockdevice-volumeinitializationrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeInitializationRate { get; set; }
            /// <summary>
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-ebsblockdevice.html#cfn-ec2-image-ebsblockdevice-snapshotid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnapshotId { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-ebsblockdevice.html#cfn-ec2-image-ebsblockdevice-volumetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeType { get; set; }
            /// <summary>
            /// VolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-ebsblockdevice.html#cfn-ec2-image-ebsblockdevice-volumesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeSize { get; set; }
            /// <summary>
            /// DeleteOnTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-ebsblockdevice.html#cfn-ec2-image-ebsblockdevice-deleteontermination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DeleteOnTermination { get; set; }
        }

        public class ImageWatermark : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceImageRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-imagewatermark.html#cfn-ec2-image-imagewatermark-sourceimageregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceImageRegion { get; set; }
            /// <summary>
            /// SourceImageCreationTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-imagewatermark.html#cfn-ec2-image-imagewatermark-sourceimagecreationtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceImageCreationTime { get; set; }
            /// <summary>
            /// WatermarkKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-imagewatermark.html#cfn-ec2-image-imagewatermark-watermarkkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WatermarkKey { get; set; }
            /// <summary>
            /// SourceImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-imagewatermark.html#cfn-ec2-image-imagewatermark-sourceimageid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceImageId { get; set; }
            /// <summary>
            /// WatermarkCreationTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-imagewatermark.html#cfn-ec2-image-imagewatermark-watermarkcreationtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WatermarkCreationTime { get; set; }
        }

        public class ProductCode : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProductCodeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-productcode.html#cfn-ec2-image-productcode-productcodetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProductCodeType { get; set; }
            /// <summary>
            /// ProductCodeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-image-productcode.html#cfn-ec2-image-productcode-productcodeid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProductCodeId { get; set; }
        }
    }
}