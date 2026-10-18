namespace Humidifier.FSx
{
    using global::System.Collections.Generic;
    using FileCacheTypes;

    public class FileCache : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfFSxFileCacheTypesDataRepositoryAssociationDataRepositoryAssociations, IHaveStorageCapacity_Integer, IHaveKmsKeyId, IHaveCopyTagsToDataRepositoryAssociations_Boolean, IHaveFileCacheTypeVersion, IHaveFSxFileCacheTypesLustreConfigurationLustreConfiguration, IHaveFileCacheType, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds
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
        public Union<IReadOnlyList<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation>, IReadOnlyList<Union<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation, BaseFunction>>, BaseFunction>? DataRepositoryAssociations { get; set; }

        /// <summary>
        /// StorageCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-storagecapacity
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? StorageCapacity { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// CopyTagsToDataRepositoryAssociations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-copytagstodatarepositoryassociations
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? CopyTagsToDataRepositoryAssociations { get; set; }

        /// <summary>
        /// FileCacheTypeVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-filecachetypeversion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FileCacheTypeVersion { get; set; }
        /// <summary>
        /// LustreConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-lustreconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LustreConfiguration
        /// </summary>
        public Union<Humidifier.FSx.FileCacheTypes.LustreConfiguration, BaseFunction>? LustreConfiguration { get; set; }

        /// <summary>
        /// FileCacheType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-filecachetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FileCacheType { get; set; }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-subnetids
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-securitygroupids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filecache.html#cfn-fsx-filecache-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace FileCacheTypes
    {
        public class DataRepositoryAssociation : Humidifier.Base.BaseSubResource, IHaveDataRepositoryPath, IHaveFileCachePath
        {
            /// <summary>
            /// DataRepositoryPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-datarepositoryassociation.html#cfn-fsx-filecache-datarepositoryassociation-datarepositorypath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataRepositoryPath { get; set; }
            /// <summary>
            /// FileCachePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-datarepositoryassociation.html#cfn-fsx-filecache-datarepositoryassociation-filecachepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileCachePath { get; set; }
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
            public Union<string, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-logconfiguration.html#cfn-fsx-filecache-logconfiguration-level
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Level { get; set; }
        }

        public class LustreConfiguration : Humidifier.Base.BaseSubResource, IHaveWeeklyMaintenanceStartTime, IHaveFSxFileCacheTypesMetadataConfigurationMetadataConfiguration, IHaveMountName, IHaveDeploymentType, IHaveFSxFileCacheTypesLogConfigurationLogConfiguration, IHavePerUnitStorageThroughput_Integer
        {
            /// <summary>
            /// WeeklyMaintenanceStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-lustreconfiguration.html#cfn-fsx-filecache-lustreconfiguration-weeklymaintenancestarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WeeklyMaintenanceStartTime { get; set; }
            /// <summary>
            /// MetadataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-lustreconfiguration.html#cfn-fsx-filecache-lustreconfiguration-metadataconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: MetadataConfiguration
            /// </summary>
            public Union<Humidifier.FSx.FileCacheTypes.MetadataConfiguration, BaseFunction>? MetadataConfiguration { get; set; }
            /// <summary>
            /// MountName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-lustreconfiguration.html#cfn-fsx-filecache-lustreconfiguration-mountname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MountName { get; set; }
            /// <summary>
            /// DeploymentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-lustreconfiguration.html#cfn-fsx-filecache-lustreconfiguration-deploymenttype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeploymentType { get; set; }
            /// <summary>
            /// LogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-lustreconfiguration.html#cfn-fsx-filecache-lustreconfiguration-logconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LogConfiguration
            /// </summary>
            public Union<Humidifier.FSx.FileCacheTypes.LogConfiguration, BaseFunction>? LogConfiguration { get; set; }
            /// <summary>
            /// PerUnitStorageThroughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-lustreconfiguration.html#cfn-fsx-filecache-lustreconfiguration-perunitstoragethroughput
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PerUnitStorageThroughput { get; set; }
        }

        public class MetadataConfiguration : Humidifier.Base.BaseSubResource, IHaveStorageCapacity_Integer
        {
            /// <summary>
            /// StorageCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filecache-metadataconfiguration.html#cfn-fsx-filecache-metadataconfiguration-storagecapacity
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageCapacity { get; set; }
        }
    }
}