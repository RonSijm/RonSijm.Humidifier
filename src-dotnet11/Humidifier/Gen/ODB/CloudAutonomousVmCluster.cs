namespace Humidifier.ODB
{
    using global::System.Collections.Generic;
    using CloudAutonomousVmClusterTypes;

    public class CloudAutonomousVmCluster : Humidifier.Base.BaseResource, IHaveTags, IHaveCloudExadataInfrastructureId, IHaveLicenseModel, IHaveListOfODBCloudAutonomousVmClusterTypesIamRoleIamRoles, IHaveDescription, IHaveCpuCoreCountPerNode_Integer, IHaveMemoryPerOracleComputeUnitInGBs_Integer, IHaveStringListOfDbServers, IHaveTotalContainerDatabases_Integer, IHaveTimeZone, IHaveAutonomousDataStorageSizeInTBs_Double, IHaveScanListenerPortNonTls_Integer, IHaveOdbNetworkId, IHaveIsMtlsEnabledVmCluster_Boolean, IHaveDisplayName, IHaveScanListenerPortTls_Integer, IHaveODBCloudAutonomousVmClusterTypesMaintenanceWindowMaintenanceWindow
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
        public Union<string, BaseFunction>? CloudExadataInfrastructureId { get; set; }
        /// <summary>
        /// LicenseModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-licensemodel
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LicenseModel { get; set; }
        /// <summary>
        /// IamRoles
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-iamroles
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IamRole
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole>, IReadOnlyList<Union<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole, BaseFunction>>, BaseFunction>? IamRoles { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// CpuCoreCountPerNode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-cpucorecountpernode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? CpuCoreCountPerNode { get; set; }
        /// <summary>
        /// MemoryPerOracleComputeUnitInGBs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-memoryperoraclecomputeunitingbs
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MemoryPerOracleComputeUnitInGBs { get; set; }
        /// <summary>
        /// DbServers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-dbservers
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DbServers { get; set; }
        /// <summary>
        /// TotalContainerDatabases
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-totalcontainerdatabases
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? TotalContainerDatabases { get; set; }
        /// <summary>
        /// TimeZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-timezone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TimeZone { get; set; }
        /// <summary>
        /// AutonomousDataStorageSizeInTBs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-autonomousdatastoragesizeintbs
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? AutonomousDataStorageSizeInTBs { get; set; }
        /// <summary>
        /// ScanListenerPortNonTls
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-scanlistenerportnontls
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ScanListenerPortNonTls { get; set; }
        /// <summary>
        /// OdbNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-odbnetworkid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OdbNetworkId { get; set; }
        /// <summary>
        /// IsMtlsEnabledVmCluster
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-ismtlsenabledvmcluster
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IsMtlsEnabledVmCluster { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-displayname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// ScanListenerPortTls
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-scanlistenerporttls
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ScanListenerPortTls { get; set; }
        /// <summary>
        /// MaintenanceWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-maintenancewindow
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MaintenanceWindow
        /// </summary>
        public Union<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow, BaseFunction>? MaintenanceWindow { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudautonomousvmcluster.html#cfn-odb-cloudautonomousvmcluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace CloudAutonomousVmClusterTypes
    {
        public class IamRole : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveIamRoleArn, IHaveAwsIntegration
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-iamrole.html#cfn-odb-cloudautonomousvmcluster-iamrole-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// IamRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-iamrole.html#cfn-odb-cloudautonomousvmcluster-iamrole-iamrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IamRoleArn { get; set; }
            /// <summary>
            /// AwsIntegration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-iamrole.html#cfn-odb-cloudautonomousvmcluster-iamrole-awsintegration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsIntegration { get; set; }
        }

        public class MaintenanceWindow : Humidifier.Base.BaseSubResource, IHaveStringListOfDaysOfWeek, IHavePreference, IHaveLeadTimeInWeeks_Integer, IHaveStringListOfMonths, IHaveIntegerListOfWeeksOfMonth, IHaveIntegerListOfHoursOfDay
        {
            /// <summary>
            /// DaysOfWeek
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-maintenancewindow.html#cfn-odb-cloudautonomousvmcluster-maintenancewindow-daysofweek
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DaysOfWeek { get; set; }
            /// <summary>
            /// Preference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-maintenancewindow.html#cfn-odb-cloudautonomousvmcluster-maintenancewindow-preference
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Preference { get; set; }
            /// <summary>
            /// LeadTimeInWeeks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-maintenancewindow.html#cfn-odb-cloudautonomousvmcluster-maintenancewindow-leadtimeinweeks
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LeadTimeInWeeks { get; set; }
            /// <summary>
            /// Months
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-maintenancewindow.html#cfn-odb-cloudautonomousvmcluster-maintenancewindow-months
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Months { get; set; }
            /// <summary>
            /// WeeksOfMonth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-maintenancewindow.html#cfn-odb-cloudautonomousvmcluster-maintenancewindow-weeksofmonth
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? WeeksOfMonth { get; set; }
            /// <summary>
            /// HoursOfDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudautonomousvmcluster-maintenancewindow.html#cfn-odb-cloudautonomousvmcluster-maintenancewindow-hoursofday
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? HoursOfDay { get; set; }
        }
    }
}