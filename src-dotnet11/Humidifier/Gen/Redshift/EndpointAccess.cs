namespace Humidifier.Redshift
{
    using global::System.Collections.Generic;
    using EndpointAccessTypes;

    public class EndpointAccess : Humidifier.Base.BaseResource, IHaveEndpointName, IHaveStringListOfVpcSecurityGroupIds, IHaveResourceOwner, IHaveSubnetGroupName, IHaveClusterIdentifier
    {
        public class Attributes
        {
            public static string EndpointStatus =  "EndpointStatus" ;
            public static string VpcEndpoint =  "VpcEndpoint" ;
            public static string Address =  "Address" ;
            public static string Port =  "Port" ;
            public static string EndpointCreateTime =  "EndpointCreateTime" ;
            public static string VpcSecurityGroups =  "VpcSecurityGroups" ;
        }

        public override string AWSTypeName { get => AWS.Redshift.EndpointAccess; }

        /// <summary>
        /// EndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-endpointaccess.html#cfn-redshift-endpointaccess-endpointname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EndpointName { get; set; }

        /// <summary>
        /// VpcSecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-endpointaccess.html#cfn-redshift-endpointaccess-vpcsecuritygroupids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VpcSecurityGroupIds { get; set; }
        /// <summary>
        /// ResourceOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-endpointaccess.html#cfn-redshift-endpointaccess-resourceowner
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceOwner { get; set; }

        /// <summary>
        /// SubnetGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-endpointaccess.html#cfn-redshift-endpointaccess-subnetgroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SubnetGroupName { get; set; }

        /// <summary>
        /// ClusterIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-endpointaccess.html#cfn-redshift-endpointaccess-clusteridentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterIdentifier { get; set; }
    }

    namespace EndpointAccessTypes
    {
        public class NetworkInterface : Humidifier.Base.BaseSubResource, IHavePrivateIpAddress, IHaveAvailabilityZone, IHaveSubnetId, IHaveNetworkInterfaceId
        {
            /// <summary>
            /// PrivateIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-endpointaccess-networkinterface.html#cfn-redshift-endpointaccess-networkinterface-privateipaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateIpAddress { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-endpointaccess-networkinterface.html#cfn-redshift-endpointaccess-networkinterface-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-endpointaccess-networkinterface.html#cfn-redshift-endpointaccess-networkinterface-subnetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
            /// <summary>
            /// NetworkInterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-endpointaccess-networkinterface.html#cfn-redshift-endpointaccess-networkinterface-networkinterfaceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkInterfaceId { get; set; }
        }

        public class VpcEndpoint : Humidifier.Base.BaseSubResource, IHaveVpcId, IHaveListOfRedshiftEndpointAccessTypesNetworkInterfaceNetworkInterfaces, IHaveVpcEndpointId
        {
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-endpointaccess-vpcendpoint.html#cfn-redshift-endpointaccess-vpcendpoint-vpcid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
            /// <summary>
            /// NetworkInterfaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-endpointaccess-vpcendpoint.html#cfn-redshift-endpointaccess-vpcendpoint-networkinterfaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NetworkInterface
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Redshift.EndpointAccessTypes.NetworkInterface>, IReadOnlyList<Union<Humidifier.Redshift.EndpointAccessTypes.NetworkInterface, BaseFunction>>, BaseFunction>? NetworkInterfaces { get; set; }
            /// <summary>
            /// VpcEndpointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-endpointaccess-vpcendpoint.html#cfn-redshift-endpointaccess-vpcendpoint-vpcendpointid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcEndpointId { get; set; }
        }

        public class VpcSecurityGroup : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveVpcSecurityGroupId
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-endpointaccess-vpcsecuritygroup.html#cfn-redshift-endpointaccess-vpcsecuritygroup-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// VpcSecurityGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-endpointaccess-vpcsecuritygroup.html#cfn-redshift-endpointaccess-vpcsecuritygroup-vpcsecuritygroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcSecurityGroupId { get; set; }
        }
    }
}