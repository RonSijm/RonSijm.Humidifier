namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using NatGatewayTypes;

    public class NatGateway : Humidifier.Base.BaseResource, IHaveTags, IHaveStringListOfSecondaryAllocationIds, IHavePrivateIpAddress, IHaveSecondaryPrivateIpAddressCount_Integer, IHaveConnectivityType, IHaveStringListOfSecondaryPrivateIpAddresses, IHaveVpcId, IHaveListOfEC2NatGatewayTypesAvailabilityZoneAddressAvailabilityZoneAddresses, IHaveAvailabilityMode, IHaveAllocationId, IHaveSubnetId, IHaveMaxDrainDurationSeconds_Integer
    {
        public class Attributes
        {
            public static string RouteTableId =  "RouteTableId" ;
            public static string EniId =  "EniId" ;
            public static string AutoProvisionZones =  "AutoProvisionZones" ;
            public static string AutoScalingIps =  "AutoScalingIps" ;
            public static string NatGatewayId =  "NatGatewayId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.NatGateway; }
        /// <summary>
        /// SecondaryAllocationIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-natgateway.html#cfn-ec2-natgateway-secondaryallocationids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecondaryAllocationIds { get; set; }
        /// <summary>
        /// PrivateIpAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-natgateway.html#cfn-ec2-natgateway-privateipaddress
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PrivateIpAddress { get; set; }
        /// <summary>
        /// SecondaryPrivateIpAddressCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-natgateway.html#cfn-ec2-natgateway-secondaryprivateipaddresscount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? SecondaryPrivateIpAddressCount { get; set; }
        /// <summary>
        /// ConnectivityType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-natgateway.html#cfn-ec2-natgateway-connectivitytype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConnectivityType { get; set; }
        /// <summary>
        /// SecondaryPrivateIpAddresses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-natgateway.html#cfn-ec2-natgateway-secondaryprivateipaddresses
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecondaryPrivateIpAddresses { get; set; }
        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-natgateway.html#cfn-ec2-natgateway-vpcid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpcId { get; set; }
        /// <summary>
        /// AvailabilityZoneAddresses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-natgateway.html#cfn-ec2-natgateway-availabilityzoneaddresses
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AvailabilityZoneAddress
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress>, IReadOnlyList<Union<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress, BaseFunction>>, BaseFunction>? AvailabilityZoneAddresses { get; set; }
        /// <summary>
        /// AvailabilityMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-natgateway.html#cfn-ec2-natgateway-availabilitymode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityMode { get; set; }
        /// <summary>
        /// AllocationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-natgateway.html#cfn-ec2-natgateway-allocationid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AllocationId { get; set; }
        /// <summary>
        /// SubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-natgateway.html#cfn-ec2-natgateway-subnetid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SubnetId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-natgateway.html#cfn-ec2-natgateway-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// MaxDrainDurationSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-natgateway.html#cfn-ec2-natgateway-maxdraindurationseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxDrainDurationSeconds { get; set; }
    }

    namespace NatGatewayTypes
    {
        public class AvailabilityZoneAddress : Humidifier.Base.BaseSubResource, IHaveAvailabilityZoneId, IHaveAvailabilityZone, IHaveStringListOfAllocationIds
        {
            /// <summary>
            /// AvailabilityZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-natgateway-availabilityzoneaddress.html#cfn-ec2-natgateway-availabilityzoneaddress-availabilityzoneid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZoneId { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-natgateway-availabilityzoneaddress.html#cfn-ec2-natgateway-availabilityzoneaddress-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
            /// <summary>
            /// AllocationIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-natgateway-availabilityzoneaddress.html#cfn-ec2-natgateway-availabilityzoneaddress-allocationids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllocationIds { get; set; }
        }
    }
}