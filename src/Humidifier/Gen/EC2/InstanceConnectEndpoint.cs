namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using InstanceConnectEndpointTypes;

    public class InstanceConnectEndpoint : Humidifier.Base.BaseResource, IHaveTags, IHaveSecurityGroupIds, IHaveSubnetId, IHaveClientToken
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string AvailabilityZoneId =  "AvailabilityZoneId" ;
            public static string AvailabilityZone =  "AvailabilityZone" ;
            public static string NetworkInterfaceIds =  "NetworkInterfaceIds" ;
            public static string OwnerId =  "OwnerId" ;
            public static string VpcId =  "VpcId" ;
            public static string InstanceConnectEndpointArn =  "InstanceConnectEndpointArn" ;
            public static string State =  "State" ;
            public static string Id =  "Id" ;
            public static string StateMessage =  "StateMessage" ;
            public static string PublicDnsNames =  "PublicDnsNames" ;
        }

        public override string AWSTypeName { get => AWS.EC2.InstanceConnectEndpoint; }
        /// <summary>
        /// PreserveClientIp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instanceconnectendpoint.html#cfn-ec2-instanceconnectendpoint-preserveclientip
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic PreserveClientIp { get; set; }

        /// <summary>
        /// SubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instanceconnectendpoint.html#cfn-ec2-instanceconnectendpoint-subnetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SubnetId { get; set; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instanceconnectendpoint.html#cfn-ec2-instanceconnectendpoint-clienttoken
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClientToken { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instanceconnectendpoint.html#cfn-ec2-instanceconnectendpoint-securitygroupids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SecurityGroupIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instanceconnectendpoint.html#cfn-ec2-instanceconnectendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace InstanceConnectEndpointTypes
    {
        public class InstanceConnectEndpointDnsNames : Humidifier.Base.BaseSubResource, IHaveDnsName
        {
            /// <summary>
            /// FipsDnsName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instanceconnectendpoint-instanceconnectendpointdnsnames.html#cfn-ec2-instanceconnectendpoint-instanceconnectendpointdnsnames-fipsdnsname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FipsDnsName { get; set; }
            /// <summary>
            /// DnsName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instanceconnectendpoint-instanceconnectendpointdnsnames.html#cfn-ec2-instanceconnectendpoint-instanceconnectendpointdnsnames-dnsname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DnsName { get; set; }
        }

        public class InstanceConnectEndpointPublicDnsNames : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Dualstack
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instanceconnectendpoint-instanceconnectendpointpublicdnsnames.html#cfn-ec2-instanceconnectendpoint-instanceconnectendpointpublicdnsnames-dualstack
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InstanceConnectEndpointDnsNames
            /// </summary>
            public Humidifier.EC2.InstanceConnectEndpointTypes.InstanceConnectEndpointDnsNames Dualstack { get; set; }
            /// <summary>
            /// Ipv4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instanceconnectendpoint-instanceconnectendpointpublicdnsnames.html#cfn-ec2-instanceconnectendpoint-instanceconnectendpointpublicdnsnames-ipv4
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InstanceConnectEndpointDnsNames
            /// </summary>
            public Humidifier.EC2.InstanceConnectEndpointTypes.InstanceConnectEndpointDnsNames Ipv4 { get; set; }
        }
    }
}