namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class EIPAssociation : Humidifier.Base.BaseResource, IHavePrivateIpAddress, IHaveInstanceId, IHaveAllocationId, IHaveNetworkInterfaceId
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.EC2.EIPAssociation; }
        /// <summary>
        /// PrivateIpAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-eipassociation.html#cfn-ec2-eipassociation-privateipaddress
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PrivateIpAddress { get; set; }
        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-eipassociation.html#cfn-ec2-eipassociation-instanceid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceId { get; set; }
        /// <summary>
        /// AllocationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-eipassociation.html#cfn-ec2-eipassociation-allocationid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AllocationId { get; set; }
        /// <summary>
        /// NetworkInterfaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-eipassociation.html#cfn-ec2-eipassociation-networkinterfaceid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkInterfaceId { get; set; }
    }
}