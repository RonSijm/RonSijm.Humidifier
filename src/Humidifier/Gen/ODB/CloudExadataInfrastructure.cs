namespace Humidifier.ODB
{
    using global::System.Collections.Generic;
    using CloudExadataInfrastructureTypes;

    public class CloudExadataInfrastructure : Humidifier.Base.BaseResource, IHaveTags, IHaveDisplayName, IHaveAvailabilityZone, IHaveShape, IHaveAvailabilityZoneId
    {
        public class Attributes
        {
            public static string CloudExadataInfrastructureId =  "CloudExadataInfrastructureId" ;
            public static string MemorySizeInGBs =  "MemorySizeInGBs" ;
            public static string CloudExadataInfrastructureArn =  "CloudExadataInfrastructureArn" ;
            public static string MaxDbNodeStorageSizeInGBs =  "MaxDbNodeStorageSizeInGBs" ;
            public static string TotalStorageSizeInGBs =  "TotalStorageSizeInGBs" ;
            public static string OciUrl =  "OciUrl" ;
            public static string Ocid =  "Ocid" ;
            public static string MaxMemoryInGBs =  "MaxMemoryInGBs" ;
            public static string StorageServerVersion =  "StorageServerVersion" ;
            public static string DataStorageSizeInTBs =  "DataStorageSizeInTBs" ;
            public static string MaxCpuCount =  "MaxCpuCount" ;
            public static string MaxDataStorageInTBs =  "MaxDataStorageInTBs" ;
            public static string DbServerVersion =  "DbServerVersion" ;
            public static string AdditionalStorageCount =  "AdditionalStorageCount" ;
            public static string CpuCount =  "CpuCount" ;
            public static string OciResourceAnchorName =  "OciResourceAnchorName" ;
            public static string ComputeModel =  "ComputeModel" ;
            public static string DbNodeStorageSizeInGBs =  "DbNodeStorageSizeInGBs" ;
            public static string ActivatedStorageCount =  "ActivatedStorageCount" ;
            public static string DbServerIds =  "DbServerIds" ;
            public static string AvailableStorageSizeInGBs =  "AvailableStorageSizeInGBs" ;
        }

        public override string AWSTypeName { get => AWS.ODB.CloudExadataInfrastructure; }
        /// <summary>
        /// StorageServerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudexadatainfrastructure.html#cfn-odb-cloudexadatainfrastructure-storageservertype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StorageServerType { get; set; }
        /// <summary>
        /// DatabaseServerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudexadatainfrastructure.html#cfn-odb-cloudexadatainfrastructure-databaseservertype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DatabaseServerType { get; set; }
        /// <summary>
        /// Shape
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudexadatainfrastructure.html#cfn-odb-cloudexadatainfrastructure-shape
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Shape { get; set; }
        /// <summary>
        /// StorageCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudexadatainfrastructure.html#cfn-odb-cloudexadatainfrastructure-storagecount
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic StorageCount { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudexadatainfrastructure.html#cfn-odb-cloudexadatainfrastructure-displayname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// AvailabilityZoneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudexadatainfrastructure.html#cfn-odb-cloudexadatainfrastructure-availabilityzoneid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AvailabilityZoneId { get; set; }
        /// <summary>
        /// CustomerContactsToSendToOCI
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudexadatainfrastructure.html#cfn-odb-cloudexadatainfrastructure-customercontactstosendtooci
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: CustomerContact
        /// </summary>
        public List<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact> CustomerContactsToSendToOCI { get; set; }
        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudexadatainfrastructure.html#cfn-odb-cloudexadatainfrastructure-availabilityzone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AvailabilityZone { get; set; }
        /// <summary>
        /// MaintenanceWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudexadatainfrastructure.html#cfn-odb-cloudexadatainfrastructure-maintenancewindow
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MaintenanceWindow
        /// </summary>
        public Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow MaintenanceWindow { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudexadatainfrastructure.html#cfn-odb-cloudexadatainfrastructure-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// ComputeCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-cloudexadatainfrastructure.html#cfn-odb-cloudexadatainfrastructure-computecount
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ComputeCount { get; set; }
    }

    namespace CloudExadataInfrastructureTypes
    {
        public class CustomerContact : Humidifier.Base.BaseSubResource, IHaveEmail
        {
            /// <summary>
            /// Email
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudexadatainfrastructure-customercontact.html#cfn-odb-cloudexadatainfrastructure-customercontact-email
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Email { get; set; }
        }

        public class MaintenanceWindow : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomActionTimeoutInMins
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudexadatainfrastructure-maintenancewindow.html#cfn-odb-cloudexadatainfrastructure-maintenancewindow-customactiontimeoutinmins
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CustomActionTimeoutInMins { get; set; }
            /// <summary>
            /// DaysOfWeek
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudexadatainfrastructure-maintenancewindow.html#cfn-odb-cloudexadatainfrastructure-maintenancewindow-daysofweek
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DaysOfWeek { get; set; }
            /// <summary>
            /// Preference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudexadatainfrastructure-maintenancewindow.html#cfn-odb-cloudexadatainfrastructure-maintenancewindow-preference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Preference { get; set; }
            /// <summary>
            /// LeadTimeInWeeks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudexadatainfrastructure-maintenancewindow.html#cfn-odb-cloudexadatainfrastructure-maintenancewindow-leadtimeinweeks
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic LeadTimeInWeeks { get; set; }
            /// <summary>
            /// Months
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudexadatainfrastructure-maintenancewindow.html#cfn-odb-cloudexadatainfrastructure-maintenancewindow-months
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Months { get; set; }
            /// <summary>
            /// PatchingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudexadatainfrastructure-maintenancewindow.html#cfn-odb-cloudexadatainfrastructure-maintenancewindow-patchingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PatchingMode { get; set; }
            /// <summary>
            /// WeeksOfMonth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudexadatainfrastructure-maintenancewindow.html#cfn-odb-cloudexadatainfrastructure-maintenancewindow-weeksofmonth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> WeeksOfMonth { get; set; }
            /// <summary>
            /// IsCustomActionTimeoutEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudexadatainfrastructure-maintenancewindow.html#cfn-odb-cloudexadatainfrastructure-maintenancewindow-iscustomactiontimeoutenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsCustomActionTimeoutEnabled { get; set; }
            /// <summary>
            /// HoursOfDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-cloudexadatainfrastructure-maintenancewindow.html#cfn-odb-cloudexadatainfrastructure-maintenancewindow-hoursofday
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> HoursOfDay { get; set; }
        }
    }
}