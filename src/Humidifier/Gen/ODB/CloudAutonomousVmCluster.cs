namespace Humidifier.ODB
{
    using global::System.Collections.Generic;
    using CloudAutonomousVmClusterTypes;

    public class CloudAutonomousVmCluster : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveDisplayName, IHaveTimeZone
    {
        public class Attributes
        {
            public static string DataStorageSizeInGBs =  "DataStorageSizeInGBs" ;
            public static string Shape =  "Shape" ;
            public static string OciUrl =  "OciUrl" ;
            public static string MaxAcdsLowestScaledValue =  "MaxAcdsLowestScaledValue" ;
            public static string ReservedCpus =  "ReservedCpus" ;
            public static string NonProvisionableAutonomousContainerDatabases =  "NonProvisionableAutonomousContainerDatabases" ;
            public static string DataStorageSizeInTBs =  "DataStorageSizeInTBs" ;
            public static string ProvisionedCpus =  "ProvisionedCpus" ;
            public static string OciResourceAnchorName =  "OciResourceAnchorName" ;
            public static string ExadataStorageInTBsLowestScaledValue =  "ExadataStorageInTBsLowestScaledValue" ;
            public static string ProvisionedAutonomousContainerDatabases =  "ProvisionedAutonomousContainerDatabases" ;
            public static string AutonomousDataStoragePercentage =  "AutonomousDataStoragePercentage" ;
            public static string AvailableContainerDatabases =  "AvailableContainerDatabases" ;
            public static string CloudAutonomousVmClusterArn =  "CloudAutonomousVmClusterArn" ;
            public static string AvailableAutonomousDataStorageSizeInTBs =  "AvailableAutonomousDataStorageSizeInTBs" ;
            public static string MemorySizeInGBs =  "MemorySizeInGBs" ;
            public static string CpuCoreCount =  "CpuCoreCount" ;
            public static string NodeCount =  "NodeCount" ;
            public static string AvailableCpus =  "AvailableCpus" ;
            public static string Hostname =  "Hostname" ;
            public static string CpuPercentage =  "CpuPercentage" ;
            public static string Ocid =  "Ocid" ;
            public static string ReclaimableCpus =  "ReclaimableCpus" ;
            public static string ComputeModel =  "ComputeModel" ;
            public static string ProvisionableAutonomousContainerDatabases =  "ProvisionableAutonomousContainerDatabases" ;
            public static string DbNodeStorageSizeInGBs =  "DbNodeStorageSizeInGBs" ;
            public static string CloudAutonomousVmClusterId =  "CloudAutonomousVmClusterId" ;
            public static string Domain =  "Domain" ;
        }

        public override string AWSTypeName { get => AWS.ODB.CloudAutonomousVmCluster; }
        /// <summary>
        /// CloudExadataInfrastructureId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-cloudexadatainfrastructureid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CloudExadataInfrastructureId { get; set; }
        /// <summary>
        /// LicenseModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-licensemodel
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LicenseModel { get; set; }
        /// <summary>
        /// IamRoles
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-iamroles
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IamRole
        /// </summary>
        public List<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole> IamRoles { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// CpuCoreCountPerNode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-cpucorecountpernode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic CpuCoreCountPerNode { get; set; }
        /// <summary>
        /// MemoryPerOracleComputeUnitInGBs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-memoryperoraclecomputeunitingbs
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MemoryPerOracleComputeUnitInGBs { get; set; }
        /// <summary>
        /// DbServers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-dbservers
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic DbServers { get; set; }
        /// <summary>
        /// TotalContainerDatabases
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-totalcontainerdatabases
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic TotalContainerDatabases { get; set; }
        /// <summary>
        /// TimeZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-timezone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TimeZone { get; set; }
        /// <summary>
        /// AutonomousDataStorageSizeInTBs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-autonomousdatastoragesizeintbs
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic AutonomousDataStorageSizeInTBs { get; set; }
        /// <summary>
        /// ScanListenerPortNonTls
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-scanlistenerportnontls
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ScanListenerPortNonTls { get; set; }
        /// <summary>
        /// OdbNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-odbnetworkid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OdbNetworkId { get; set; }
        /// <summary>
        /// IsMtlsEnabledVmCluster
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-ismtlsenabledvmcluster
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic IsMtlsEnabledVmCluster { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-displayname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// ScanListenerPortTls
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-scanlistenerporttls
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ScanListenerPortTls { get; set; }
        /// <summary>
        /// MaintenanceWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-maintenancewindow
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MaintenanceWindow
        /// </summary>
        public Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow MaintenanceWindow { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace CloudAutonomousVmClusterTypes
    {
        public class IamRole : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveIamRoleArn
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-iamrole.html#cfn-odb-cloudautonomousvmcluster-iamrole-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// IamRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-iamrole.html#cfn-odb-cloudautonomousvmcluster-iamrole-iamrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IamRoleArn { get; set; }
            /// <summary>
            /// AwsIntegration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-iamrole.html#cfn-odb-cloudautonomousvmcluster-iamrole-awsintegration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AwsIntegration { get; set; }
        }

        public class MaintenanceWindow : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DaysOfWeek
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-maintenancewindow.html#cfn-odb-cloudautonomousvmcluster-maintenancewindow-daysofweek
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DaysOfWeek { get; set; }
            /// <summary>
            /// Preference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-maintenancewindow.html#cfn-odb-cloudautonomousvmcluster-maintenancewindow-preference
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Preference { get; set; }
            /// <summary>
            /// LeadTimeInWeeks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-maintenancewindow.html#cfn-odb-cloudautonomousvmcluster-maintenancewindow-leadtimeinweeks
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic LeadTimeInWeeks { get; set; }
            /// <summary>
            /// Months
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-maintenancewindow.html#cfn-odb-cloudautonomousvmcluster-maintenancewindow-months
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Months { get; set; }
            /// <summary>
            /// WeeksOfMonth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-maintenancewindow.html#cfn-odb-cloudautonomousvmcluster-maintenancewindow-weeksofmonth
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> WeeksOfMonth { get; set; }
            /// <summary>
            /// HoursOfDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-maintenancewindow.html#cfn-odb-cloudautonomousvmcluster-maintenancewindow-hoursofday
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> HoursOfDay { get; set; }
        }
    }
}