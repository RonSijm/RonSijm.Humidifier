namespace Humidifier.FSx
{
    using global::System.Collections.Generic;
    using FileCacheTypes;

    public class FileCache : Humidifier.Base.BaseResource, IHaveTags, IHaveKmsKeyId, IHaveSecurityGroupIds, IHaveSubnetIds, IHaveStorageCapacity
    {
        public class Attributes
        {
            public static string Lifecycle =  "Lifecycle" ;
            public static string FileCacheId =  "FileCacheId" ;
            public static string NetworkInterfaceIds =  "NetworkInterfaceIds" ;
            public static string DNSName =  "DNSName" ;
            public static string DataRepositoryAssociationIds =  "DataRepositoryAssociationIds" ;
            public static string ResourceARN =  "ResourceARN" ;
            public static string VpcId =  "VpcId" ;
            public static string OwnerId =  "OwnerId" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.FSx.FileCache; }
        /// <summary>
        /// DataRepositoryAssociations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-datarepositoryassociations
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: DataRepositoryAssociation
        /// </summary>
        public List<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation> DataRepositoryAssociations { get; set; }

        /// <summary>
        /// StorageCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-storagecapacity
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic StorageCapacity { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyId { get; set; }
        /// <summary>
        /// CopyTagsToDataRepositoryAssociations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-copytagstodatarepositoryassociations
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic CopyTagsToDataRepositoryAssociations { get; set; }

        /// <summary>
        /// FileCacheTypeVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-filecachetypeversion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FileCacheTypeVersion { get; set; }
        /// <summary>
        /// LustreConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-lustreconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LustreConfiguration
        /// </summary>
        public Humidifier.FSx.FileCacheTypes.LustreConfiguration LustreConfiguration { get; set; }

        /// <summary>
        /// FileCacheType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-filecachetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FileCacheType { get; set; }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-subnetids
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic SubnetIds { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-securitygroupids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SecurityGroupIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace FileCacheTypes
    {
        public class DataRepositoryAssociation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DataRepositoryPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-datarepositoryassociation.html#cfn-fsx-filecache-datarepositoryassociation-datarepositorypath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataRepositoryPath { get; set; }
            /// <summary>
            /// FileCachePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-datarepositoryassociation.html#cfn-fsx-filecache-datarepositoryassociation-filecachepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileCachePath { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveDestination, IHaveLevel
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-logconfiguration.html#cfn-fsx-filecache-logconfiguration-destination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Destination { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-logconfiguration.html#cfn-fsx-filecache-logconfiguration-level
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Level { get; set; }
        }

        public class LustreConfiguration : Humidifier.Base.BaseSubResource, IHaveDeploymentType, IHaveWeeklyMaintenanceStartTime
        {
            /// <summary>
            /// WeeklyMaintenanceStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-lustreconfiguration.html#cfn-fsx-filecache-lustreconfiguration-weeklymaintenancestarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WeeklyMaintenanceStartTime { get; set; }
            /// <summary>
            /// MetadataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-lustreconfiguration.html#cfn-fsx-filecache-lustreconfiguration-metadataconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: MetadataConfiguration
            /// </summary>
            public Humidifier.FSx.FileCacheTypes.MetadataConfiguration MetadataConfiguration { get; set; }
            /// <summary>
            /// MountName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-lustreconfiguration.html#cfn-fsx-filecache-lustreconfiguration-mountname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MountName { get; set; }
            /// <summary>
            /// DeploymentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-lustreconfiguration.html#cfn-fsx-filecache-lustreconfiguration-deploymenttype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeploymentType { get; set; }
            /// <summary>
            /// LogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-lustreconfiguration.html#cfn-fsx-filecache-lustreconfiguration-logconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LogConfiguration
            /// </summary>
            public Humidifier.FSx.FileCacheTypes.LogConfiguration LogConfiguration { get; set; }
            /// <summary>
            /// PerUnitStorageThroughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-lustreconfiguration.html#cfn-fsx-filecache-lustreconfiguration-perunitstoragethroughput
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PerUnitStorageThroughput { get; set; }
        }

        public class MetadataConfiguration : Humidifier.Base.BaseSubResource, IHaveStorageCapacity
        {
            /// <summary>
            /// StorageCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-metadataconfiguration.html#cfn-fsx-filecache-metadataconfiguration-storagecapacity
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StorageCapacity { get; set; }
        }
    }
}