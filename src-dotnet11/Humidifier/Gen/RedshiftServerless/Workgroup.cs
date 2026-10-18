namespace Humidifier.RedshiftServerless
{
    using global::System.Collections.Generic;
    using WorkgroupTypes;

    public class Workgroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSnapshotArn, IHaveSnapshotOwnerAccount, IHavePort_Integer, IHaveRecoveryPointId, IHaveWorkgroupName, IHaveBaseCapacity_Integer, IHaveEnhancedVpcRouting_Boolean, IHaveRedshiftServerlessWorkgroupTypesWorkgroupWorkgroup_, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds, IHaveSnapshotName, IHaveNamespaceName, IHaveListOfRedshiftServerlessWorkgroupTypesConfigParameterConfigParameters, IHaveTrackName, IHavePubliclyAccessible_Boolean, IHaveRedshiftServerlessWorkgroupTypesPerformanceTargetPricePerformanceTarget, IHaveMaxCapacity_Integer
    {
        public class Attributes
        {
        }

        public override string AWSTypeName { get => AWS.RedshiftServerless.Workgroup; }
        /// <summary>
        /// SnapshotArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-workgroup.html#cfn-redshiftserverless-workgroup-snapshotarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SnapshotArn { get; set; }
        /// <summary>
        /// SnapshotOwnerAccount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-workgroup.html#cfn-redshiftserverless-workgroup-snapshotowneraccount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SnapshotOwnerAccount { get; set; }
        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-workgroup.html#cfn-redshiftserverless-workgroup-port
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Port { get; set; }
        /// <summary>
        /// RecoveryPointId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-workgroup.html#cfn-redshiftserverless-workgroup-recoverypointid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RecoveryPointId { get; set; }
        public Union<string, BaseFunction>? WorkgroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// BaseCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-workgroup.html#cfn-redshiftserverless-workgroup-basecapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? BaseCapacity { get; set; }
        /// <summary>
        /// EnhancedVpcRouting
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-workgroup.html#cfn-redshiftserverless-workgroup-enhancedvpcrouting
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnhancedVpcRouting { get; set; }
        /// <summary>
        /// Workgroup_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-workgroup.html#cfn-redshiftserverless-workgroup-workgroup
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Workgroup
        /// </summary>
        public Union<Humidifier.RedshiftServerless.WorkgroupTypes.Workgroup, BaseFunction>? Workgroup_ { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-workgroup.html#cfn-redshiftserverless-workgroup-securitygroupids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-workgroup.html#cfn-redshiftserverless-workgroup-subnetids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        /// <summary>
        /// SnapshotName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-workgroup.html#cfn-redshiftserverless-workgroup-snapshotname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SnapshotName { get; set; }
        /// <summary>
        /// NamespaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-workgroup.html#cfn-redshiftserverless-workgroup-namespacename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NamespaceName { get; set; }
        /// <summary>
        /// ConfigParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-workgroup.html#cfn-redshiftserverless-workgroup-configparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ConfigParameter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter>, IReadOnlyList<Union<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter, BaseFunction>>, BaseFunction>? ConfigParameters { get; set; }
        /// <summary>
        /// TrackName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-workgroup.html#cfn-redshiftserverless-workgroup-trackname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TrackName { get; set; }
        /// <summary>
        /// PubliclyAccessible
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-workgroup.html#cfn-redshiftserverless-workgroup-publiclyaccessible
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PubliclyAccessible { get; set; }
        /// <summary>
        /// PricePerformanceTarget
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-workgroup.html#cfn-redshiftserverless-workgroup-priceperformancetarget
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PerformanceTarget
        /// </summary>
        public Union<Humidifier.RedshiftServerless.WorkgroupTypes.PerformanceTarget, BaseFunction>? PricePerformanceTarget { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-workgroup.html#cfn-redshiftserverless-workgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// MaxCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-workgroup.html#cfn-redshiftserverless-workgroup-maxcapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxCapacity { get; set; }
    }

    namespace WorkgroupTypes
    {
        public class ConfigParameter : Humidifier.Base.BaseSubResource, IHaveParameterValue, IHaveParameterKey
        {
            /// <summary>
            /// ParameterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-configparameter.html#cfn-redshiftserverless-workgroup-configparameter-parametervalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterValue { get; set; }
            /// <summary>
            /// ParameterKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-configparameter.html#cfn-redshiftserverless-workgroup-configparameter-parameterkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterKey { get; set; }
        }

        public class Endpoint : Humidifier.Base.BaseSubResource, IHaveAddress, IHaveListOfRedshiftServerlessWorkgroupTypesVpcEndpointVpcEndpoints, IHavePort_Integer
        {
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-endpoint.html#cfn-redshiftserverless-workgroup-endpoint-address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Address { get; set; }
            /// <summary>
            /// VpcEndpoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-endpoint.html#cfn-redshiftserverless-workgroup-endpoint-vpcendpoints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VpcEndpoint
            /// </summary>
            public Union<IReadOnlyList<Humidifier.RedshiftServerless.WorkgroupTypes.VpcEndpoint>, IReadOnlyList<Union<Humidifier.RedshiftServerless.WorkgroupTypes.VpcEndpoint, BaseFunction>>, BaseFunction>? VpcEndpoints { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-endpoint.html#cfn-redshiftserverless-workgroup-endpoint-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
        }

        public class NetworkInterface : Humidifier.Base.BaseSubResource, IHavePrivateIpAddress, IHaveAvailabilityZone, IHaveSubnetId, IHaveNetworkInterfaceId
        {
            /// <summary>
            /// PrivateIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-networkinterface.html#cfn-redshiftserverless-workgroup-networkinterface-privateipaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateIpAddress { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-networkinterface.html#cfn-redshiftserverless-workgroup-networkinterface-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-networkinterface.html#cfn-redshiftserverless-workgroup-networkinterface-subnetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
            /// <summary>
            /// NetworkInterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-networkinterface.html#cfn-redshiftserverless-workgroup-networkinterface-networkinterfaceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkInterfaceId { get; set; }
        }

        public class PerformanceTarget : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveLevel_Integer
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-performancetarget.html#cfn-redshiftserverless-workgroup-performancetarget-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-performancetarget.html#cfn-redshiftserverless-workgroup-performancetarget-level
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Level { get; set; }
        }

        public class VpcEndpoint : Humidifier.Base.BaseSubResource, IHaveVpcId, IHaveListOfRedshiftServerlessWorkgroupTypesNetworkInterfaceNetworkInterfaces, IHaveVpcEndpointId
        {
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-vpcendpoint.html#cfn-redshiftserverless-workgroup-vpcendpoint-vpcid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
            /// <summary>
            /// NetworkInterfaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-vpcendpoint.html#cfn-redshiftserverless-workgroup-vpcendpoint-networkinterfaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NetworkInterface
            /// </summary>
            public Union<IReadOnlyList<Humidifier.RedshiftServerless.WorkgroupTypes.NetworkInterface>, IReadOnlyList<Union<Humidifier.RedshiftServerless.WorkgroupTypes.NetworkInterface, BaseFunction>>, BaseFunction>? NetworkInterfaces { get; set; }
            /// <summary>
            /// VpcEndpointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-vpcendpoint.html#cfn-redshiftserverless-workgroup-vpcendpoint-vpcendpointid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcEndpointId { get; set; }
        }

        public class Workgroup : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveCreationDate, IHaveWorkgroupName, IHaveWorkgroupArn, IHaveBaseCapacity_Integer, IHaveEnhancedVpcRouting_Boolean, IHaveWorkgroupId, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds, IHaveNamespaceName, IHaveRedshiftServerlessWorkgroupTypesEndpointEndpoint, IHaveListOfRedshiftServerlessWorkgroupTypesConfigParameterConfigParameters, IHaveTrackName, IHavePubliclyAccessible_Boolean, IHaveRedshiftServerlessWorkgroupTypesPerformanceTargetPricePerformanceTarget, IHaveMaxCapacity_Integer
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-workgroup.html#cfn-redshiftserverless-workgroup-workgroup-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// CreationDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-workgroup.html#cfn-redshiftserverless-workgroup-workgroup-creationdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreationDate { get; set; }
            /// <summary>
            /// WorkgroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-workgroup.html#cfn-redshiftserverless-workgroup-workgroup-workgroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkgroupName { get; set; }
            /// <summary>
            /// WorkgroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-workgroup.html#cfn-redshiftserverless-workgroup-workgroup-workgrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkgroupArn { get; set; }
            /// <summary>
            /// BaseCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-workgroup.html#cfn-redshiftserverless-workgroup-workgroup-basecapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BaseCapacity { get; set; }
            /// <summary>
            /// EnhancedVpcRouting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-workgroup.html#cfn-redshiftserverless-workgroup-workgroup-enhancedvpcrouting
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnhancedVpcRouting { get; set; }
            /// <summary>
            /// WorkgroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-workgroup.html#cfn-redshiftserverless-workgroup-workgroup-workgroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkgroupId { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-workgroup.html#cfn-redshiftserverless-workgroup-workgroup-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-workgroup.html#cfn-redshiftserverless-workgroup-workgroup-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// NamespaceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-workgroup.html#cfn-redshiftserverless-workgroup-workgroup-namespacename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NamespaceName { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-workgroup.html#cfn-redshiftserverless-workgroup-workgroup-endpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Endpoint
            /// </summary>
            public Union<Humidifier.RedshiftServerless.WorkgroupTypes.Endpoint, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// ConfigParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-workgroup.html#cfn-redshiftserverless-workgroup-workgroup-configparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ConfigParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter>, IReadOnlyList<Union<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter, BaseFunction>>, BaseFunction>? ConfigParameters { get; set; }
            /// <summary>
            /// TrackName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-workgroup.html#cfn-redshiftserverless-workgroup-workgroup-trackname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrackName { get; set; }
            /// <summary>
            /// PubliclyAccessible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-workgroup.html#cfn-redshiftserverless-workgroup-workgroup-publiclyaccessible
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PubliclyAccessible { get; set; }
            /// <summary>
            /// PricePerformanceTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-workgroup.html#cfn-redshiftserverless-workgroup-workgroup-priceperformancetarget
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PerformanceTarget
            /// </summary>
            public Union<Humidifier.RedshiftServerless.WorkgroupTypes.PerformanceTarget, BaseFunction>? PricePerformanceTarget { get; set; }
            /// <summary>
            /// MaxCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-workgroup-workgroup.html#cfn-redshiftserverless-workgroup-workgroup-maxcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCapacity { get; set; }
        }
    }
}