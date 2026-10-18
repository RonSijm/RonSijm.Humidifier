namespace Humidifier.ODB
{
    using global::System.Collections.Generic;
    using CloudVmClusterTypes;

    public class CloudVmCluster : Humidifier.Base.BaseResource, IHaveTags, IHaveCloudExadataInfrastructureId, IHaveODBCloudVmClusterTypesDataCollectionOptionsDataCollectionOptions, IHaveLicenseModel, IHaveListOfODBCloudVmClusterTypesIamRoleIamRoles, IHaveMemorySizeInGBs_Integer, IHaveCpuCoreCount_Integer, IHaveStringListOfSshPublicKeys, IHaveHostname, IHaveSystemVersion, IHaveDataStorageSizeInTBs_Double, IHaveIsLocalBackupEnabled_Boolean, IHaveStringListOfDbServers, IHaveListOfODBCloudVmClusterTypesDbNodeDbNodes, IHaveTimeZone, IHaveIsSparseDiskgroupEnabled_Boolean, IHaveGiVersion, IHaveOdbNetworkId, IHaveDbNodeStorageSizeInGBs_Integer, IHaveDisplayName, IHaveClusterName, IHaveScanListenerPortTcp_Integer
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
        public Union<string, BaseFunction>? CloudExadataInfrastructureId { get; set; }
        /// <summary>
        /// DataCollectionOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-datacollectionoptions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DataCollectionOptions
        /// </summary>
        public Union<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions, BaseFunction>? DataCollectionOptions { get; set; }
        /// <summary>
        /// LicenseModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-licensemodel
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LicenseModel { get; set; }
        /// <summary>
        /// IamRoles
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-iamroles
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IamRole
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ODB.CloudVmClusterTypes.IamRole>, IReadOnlyList<Union<Humidifier.ODB.CloudVmClusterTypes.IamRole, BaseFunction>>, BaseFunction>? IamRoles { get; set; }
        /// <summary>
        /// MemorySizeInGBs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-memorysizeingbs
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MemorySizeInGBs { get; set; }
        /// <summary>
        /// CpuCoreCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-cpucorecount
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? CpuCoreCount { get; set; }
        /// <summary>
        /// SshPublicKeys
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-sshpublickeys
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SshPublicKeys { get; set; }
        /// <summary>
        /// Hostname
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-hostname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Hostname { get; set; }
        /// <summary>
        /// SystemVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-systemversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SystemVersion { get; set; }
        /// <summary>
        /// DataStorageSizeInTBs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-datastoragesizeintbs
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? DataStorageSizeInTBs { get; set; }
        /// <summary>
        /// IsLocalBackupEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-islocalbackupenabled
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IsLocalBackupEnabled { get; set; }
        /// <summary>
        /// DbServers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-dbservers
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DbServers { get; set; }
        /// <summary>
        /// DbNodes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-dbnodes
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: DbNode
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ODB.CloudVmClusterTypes.DbNode>, IReadOnlyList<Union<Humidifier.ODB.CloudVmClusterTypes.DbNode, BaseFunction>>, BaseFunction>? DbNodes { get; set; }
        /// <summary>
        /// TimeZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-timezone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TimeZone { get; set; }
        /// <summary>
        /// IsSparseDiskgroupEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-issparsediskgroupenabled
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IsSparseDiskgroupEnabled { get; set; }
        /// <summary>
        /// GiVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-giversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GiVersion { get; set; }
        /// <summary>
        /// OdbNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-odbnetworkid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OdbNetworkId { get; set; }
        /// <summary>
        /// DbNodeStorageSizeInGBs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-dbnodestoragesizeingbs
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? DbNodeStorageSizeInGBs { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-displayname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-clustername
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClusterName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// ScanListenerPortTcp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudvmcluster.html#cfn-odb-cloudvmcluster-scanlistenerporttcp
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ScanListenerPortTcp { get; set; }
    }

    namespace CloudVmClusterTypes
    {
        public class DataCollectionOptions : Humidifier.Base.BaseSubResource, IHaveIsIncidentLogsEnabled_Boolean, IHaveIsDiagnosticsEventsEnabled_Boolean, IHaveIsHealthMonitoringEnabled_Boolean
        {
            /// <summary>
            /// IsIncidentLogsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-datacollectionoptions.html#cfn-odb-cloudvmcluster-datacollectionoptions-isincidentlogsenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsIncidentLogsEnabled { get; set; }
            /// <summary>
            /// IsDiagnosticsEventsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-datacollectionoptions.html#cfn-odb-cloudvmcluster-datacollectionoptions-isdiagnosticseventsenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsDiagnosticsEventsEnabled { get; set; }
            /// <summary>
            /// IsHealthMonitoringEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-datacollectionoptions.html#cfn-odb-cloudvmcluster-datacollectionoptions-ishealthmonitoringenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsHealthMonitoringEnabled { get; set; }
        }

        public class DbNode : Humidifier.Base.BaseSubResource, IHaveTags, IHaveStatus, IHaveHostIpId, IHaveMemorySizeInGBs_Integer, IHaveCpuCoreCount_Integer, IHaveBackupIpId, IHaveHostname, IHaveOcid, IHaveDbNodeId, IHaveVnicId, IHaveDbNodeStorageSizeInGBs_Integer, IHaveVnic2Id, IHaveDbNodeArn, IHaveDbServerId, IHaveBackupVnic2Id, IHaveDbSystemId
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-status
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// HostIpId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-hostipid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostIpId { get; set; }
            /// <summary>
            /// MemorySizeInGBs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-memorysizeingbs
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MemorySizeInGBs { get; set; }
            /// <summary>
            /// CpuCoreCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-cpucorecount
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CpuCoreCount { get; set; }
            /// <summary>
            /// BackupIpId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-backupipid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BackupIpId { get; set; }
            /// <summary>
            /// Hostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-hostname
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Hostname { get; set; }
            /// <summary>
            /// Ocid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-ocid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ocid { get; set; }
            /// <summary>
            /// DbNodeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-dbnodeid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DbNodeId { get; set; }
            /// <summary>
            /// VnicId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-vnicid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VnicId { get; set; }
            /// <summary>
            /// DbNodeStorageSizeInGBs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-dbnodestoragesizeingbs
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DbNodeStorageSizeInGBs { get; set; }
            /// <summary>
            /// Vnic2Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-vnic2id
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Vnic2Id { get; set; }
            /// <summary>
            /// DbNodeArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-dbnodearn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DbNodeArn { get; set; }
            /// <summary>
            /// DbServerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-dbserverid
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DbServerId { get; set; }
            /// <summary>
            /// BackupVnic2Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-backupvnic2id
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BackupVnic2Id { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-tags
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// DbSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-dbnode.html#cfn-odb-cloudvmcluster-dbnode-dbsystemid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DbSystemId { get; set; }
        }

        public class IamRole : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveIamRoleArn, IHaveAwsIntegration
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-iamrole.html#cfn-odb-cloudvmcluster-iamrole-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// IamRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-iamrole.html#cfn-odb-cloudvmcluster-iamrole-iamrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IamRoleArn { get; set; }
            /// <summary>
            /// AwsIntegration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudvmcluster-iamrole.html#cfn-odb-cloudvmcluster-iamrole-awsintegration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsIntegration { get; set; }
        }
    }
}