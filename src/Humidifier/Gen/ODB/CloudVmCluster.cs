namespace Humidifier.ODB
{
    using global::System.Collections.Generic;
    using CloudVmClusterTypes;

    public class CloudVmCluster : Humidifier.Base.BaseResource, IHaveTags, IHaveDisplayName, IHaveClusterName, IHaveTimeZone, IHaveHostname
    {
        public class Attributes
        {
            public static string ListenerPort =  "ListenerPort" ;
            public static string Shape =  "Shape" ;
            public static string NodeCount =  "NodeCount" ;
            public static string ScanDnsName =  "ScanDnsName" ;
            public static string VipIds =  "VipIds" ;
            public static string OciUrl =  "OciUrl" ;
            public static string Ocid =  "Ocid" ;
            public static string StorageSizeInGBs =  "StorageSizeInGBs" ;
            public static string CloudVmClusterArn =  "CloudVmClusterArn" ;
            public static string CloudVmClusterId =  "CloudVmClusterId" ;
            public static string OciResourceAnchorName =  "OciResourceAnchorName" ;
            public static string ComputeModel =  "ComputeModel" ;
            public static string DiskRedundancy =  "DiskRedundancy" ;
            public static string ScanIpIds =  "ScanIpIds" ;
            public static string Domain =  "Domain" ;
        }

        public override string AWSTypeName { get => AWS.ODB.CloudVmCluster; }
        /// <summary>
        /// CloudExadataInfrastructureId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-cloudexadatainfrastructureid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CloudExadataInfrastructureId { get; set; }
        /// <summary>
        /// DataCollectionOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-datacollectionoptions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DataCollectionOptions
        /// </summary>
        public Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions DataCollectionOptions { get; set; }
        /// <summary>
        /// LicenseModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-licensemodel
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LicenseModel { get; set; }
        /// <summary>
        /// IamRoles
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-iamroles
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IamRole
        /// </summary>
        public List<Humidifier.ODB.CloudVmClusterTypes.IamRole> IamRoles { get; set; }
        /// <summary>
        /// MemorySizeInGBs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-memorysizeingbs
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MemorySizeInGBs { get; set; }
        /// <summary>
        /// CpuCoreCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-cpucorecount
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic CpuCoreCount { get; set; }
        /// <summary>
        /// SshPublicKeys
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-sshpublickeys
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SshPublicKeys { get; set; }
        /// <summary>
        /// Hostname
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-hostname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Hostname { get; set; }
        /// <summary>
        /// SystemVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-systemversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SystemVersion { get; set; }
        /// <summary>
        /// DataStorageSizeInTBs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-datastoragesizeintbs
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic DataStorageSizeInTBs { get; set; }
        /// <summary>
        /// IsLocalBackupEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-islocalbackupenabled
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic IsLocalBackupEnabled { get; set; }
        /// <summary>
        /// DbServers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-dbservers
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic DbServers { get; set; }
        /// <summary>
        /// DbNodes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-dbnodes
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: DbNode
        /// </summary>
        public List<Humidifier.ODB.CloudVmClusterTypes.DbNode> DbNodes { get; set; }
        /// <summary>
        /// TimeZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-timezone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TimeZone { get; set; }
        /// <summary>
        /// IsSparseDiskgroupEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-issparsediskgroupenabled
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic IsSparseDiskgroupEnabled { get; set; }
        /// <summary>
        /// GiVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-giversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GiVersion { get; set; }
        /// <summary>
        /// OdbNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-odbnetworkid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OdbNetworkId { get; set; }
        /// <summary>
        /// DbNodeStorageSizeInGBs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-dbnodestoragesizeingbs
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic DbNodeStorageSizeInGBs { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-displayname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-clustername
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClusterName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// ScanListenerPortTcp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-scanlistenerporttcp
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ScanListenerPortTcp { get; set; }
    }

    namespace CloudVmClusterTypes
    {
        public class DataCollectionOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IsIncidentLogsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-datacollectionoptions.html#cfn-odb-cloudvmcluster-datacollectionoptions-isincidentlogsenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsIncidentLogsEnabled { get; set; }
            /// <summary>
            /// IsDiagnosticsEventsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-datacollectionoptions.html#cfn-odb-cloudvmcluster-datacollectionoptions-isdiagnosticseventsenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsDiagnosticsEventsEnabled { get; set; }
            /// <summary>
            /// IsHealthMonitoringEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-datacollectionoptions.html#cfn-odb-cloudvmcluster-datacollectionoptions-ishealthmonitoringenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsHealthMonitoringEnabled { get; set; }
        }

        public class DbNode : Humidifier.Base.BaseSubResource, IHaveTags, IHaveStatus, IHaveHostname
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-status
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// HostIpId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-hostipid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostIpId { get; set; }
            /// <summary>
            /// MemorySizeInGBs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-memorysizeingbs
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MemorySizeInGBs { get; set; }
            /// <summary>
            /// CpuCoreCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-cpucorecount
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CpuCoreCount { get; set; }
            /// <summary>
            /// BackupIpId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-backupipid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic BackupIpId { get; set; }
            /// <summary>
            /// Hostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-hostname
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic Hostname { get; set; }
            /// <summary>
            /// Ocid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-ocid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ocid { get; set; }
            /// <summary>
            /// DbNodeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-dbnodeid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic DbNodeId { get; set; }
            /// <summary>
            /// VnicId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-vnicid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic VnicId { get; set; }
            /// <summary>
            /// DbNodeStorageSizeInGBs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-dbnodestoragesizeingbs
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DbNodeStorageSizeInGBs { get; set; }
            /// <summary>
            /// Vnic2Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-vnic2id
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic Vnic2Id { get; set; }
            /// <summary>
            /// DbNodeArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-dbnodearn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic DbNodeArn { get; set; }
            /// <summary>
            /// DbServerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-dbserverid
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic DbServerId { get; set; }
            /// <summary>
            /// BackupVnic2Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-backupvnic2id
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic BackupVnic2Id { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-tags
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Humidifier.Tag> Tags { get; set; }
            /// <summary>
            /// DbSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-dbsystemid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic DbSystemId { get; set; }
        }

        public class IamRole : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveIamRoleArn
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-iamrole.html#cfn-odb-cloudvmcluster-iamrole-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// IamRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-iamrole.html#cfn-odb-cloudvmcluster-iamrole-iamrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IamRoleArn { get; set; }
            /// <summary>
            /// AwsIntegration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-iamrole.html#cfn-odb-cloudvmcluster-iamrole-awsintegration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AwsIntegration { get; set; }
        }
    }
}