namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using NetworkInterfaceAttachmentTypes;

    public class NetworkInterfaceAttachment : Humidifier.Base.BaseResource, IHaveNetworkInterfaceId, IHaveInstanceId, IHaveDeleteOnTermination, IHaveDeviceIndex
    {
        public class Attributes
        {
            public static string AttachmentId =  "AttachmentId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.NetworkInterfaceAttachment; }
        /// <summary>
        /// EnaSrdSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterfaceattachment.html#cfn-ec2-networkinterfaceattachment-enasrdspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EnaSrdSpecification
        /// </summary>
        public Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification EnaSrdSpecification { get; set; }

        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterfaceattachment.html#cfn-ec2-networkinterfaceattachment-instanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceId { get; set; }

        /// <summary>
        /// DeviceIndex
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterfaceattachment.html#cfn-ec2-networkinterfaceattachment-deviceindex
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DeviceIndex { get; set; }

        /// <summary>
        /// NetworkInterfaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterfaceattachment.html#cfn-ec2-networkinterfaceattachment-networkinterfaceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic NetworkInterfaceId { get; set; }
        /// <summary>
        /// DeleteOnTermination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterfaceattachment.html#cfn-ec2-networkinterfaceattachment-deleteontermination
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DeleteOnTermination { get; set; }
    }

    namespace NetworkInterfaceAttachmentTypes
    {
        public class EnaSrdSpecification : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EnaSrdEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterfaceattachment-enasrdspecification.html#cfn-ec2-networkinterfaceattachment-enasrdspecification-enasrdenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnaSrdEnabled { get; set; }
            /// <summary>
            /// EnaSrdUdpSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterfaceattachment-enasrdspecification.html#cfn-ec2-networkinterfaceattachment-enasrdspecification-enasrdudpspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EnaSrdUdpSpecification
            /// </summary>
            public Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification EnaSrdUdpSpecification { get; set; }
        }

        public class EnaSrdUdpSpecification : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EnaSrdUdpEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterfaceattachment-enasrdudpspecification.html#cfn-ec2-networkinterfaceattachment-enasrdudpspecification-enasrdudpenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnaSrdUdpEnabled { get; set; }
        }
    }
}