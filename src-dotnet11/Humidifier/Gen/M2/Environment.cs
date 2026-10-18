namespace Humidifier.M2
{
    using global::System.Collections.Generic;
    using EnvironmentTypes;

    public class Environment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveEngineVersion, IHaveKmsKeyId, IHaveM2EnvironmentTypesHighAvailabilityConfigHighAvailabilityConfig, IHavePreferredMaintenanceWindow, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds, IHaveName, IHaveNetworkType, IHaveEngineType, IHavePubliclyAccessible_Boolean, IHaveInstanceType, IHaveListOfM2EnvironmentTypesStorageConfigurationStorageConfigurations, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string EnvironmentId =  "EnvironmentId" ;
            public static string EnvironmentArn =  "EnvironmentArn" ;
        }

        public override string AWSTypeName { get => AWS.M2.Environment; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-m2-environment.html#cfn-m2-environment-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// EngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-m2-environment.html#cfn-m2-environment-engineversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EngineVersion { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-m2-environment.html#cfn-m2-environment-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// HighAvailabilityConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-m2-environment.html#cfn-m2-environment-highavailabilityconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HighAvailabilityConfig
        /// </summary>
        public Union<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig, BaseFunction>? HighAvailabilityConfig { get; set; }
        /// <summary>
        /// PreferredMaintenanceWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-m2-environment.html#cfn-m2-environment-preferredmaintenancewindow
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PreferredMaintenanceWindow { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-m2-environment.html#cfn-m2-environment-securitygroupids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-m2-environment.html#cfn-m2-environment-subnetids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// NetworkType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-m2-environment.html#cfn-m2-environment-networktype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkType { get; set; }

        /// <summary>
        /// EngineType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-m2-environment.html#cfn-m2-environment-enginetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EngineType { get; set; }
        /// <summary>
        /// PubliclyAccessible
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-m2-environment.html#cfn-m2-environment-publiclyaccessible
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PubliclyAccessible { get; set; }

        /// <summary>
        /// InstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-m2-environment.html#cfn-m2-environment-instancetype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceType { get; set; }
        /// <summary>
        /// StorageConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-m2-environment.html#cfn-m2-environment-storageconfigurations
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: StorageConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.M2.EnvironmentTypes.StorageConfiguration>, IReadOnlyList<Union<Humidifier.M2.EnvironmentTypes.StorageConfiguration, BaseFunction>>, BaseFunction>? StorageConfigurations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-m2-environment.html#cfn-m2-environment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace EnvironmentTypes
    {
        public class EfsStorageConfiguration : Humidifier.Base.BaseSubResource, IHaveMountPoint, IHaveFileSystemId
        {
            /// <summary>
            /// MountPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-m2-environment-efsstorageconfiguration.html#cfn-m2-environment-efsstorageconfiguration-mountpoint
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MountPoint { get; set; }
            /// <summary>
            /// FileSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-m2-environment-efsstorageconfiguration.html#cfn-m2-environment-efsstorageconfiguration-filesystemid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemId { get; set; }
        }

        public class FsxStorageConfiguration : Humidifier.Base.BaseSubResource, IHaveMountPoint, IHaveFileSystemId
        {
            /// <summary>
            /// MountPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-m2-environment-fsxstorageconfiguration.html#cfn-m2-environment-fsxstorageconfiguration-mountpoint
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MountPoint { get; set; }
            /// <summary>
            /// FileSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-m2-environment-fsxstorageconfiguration.html#cfn-m2-environment-fsxstorageconfiguration-filesystemid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemId { get; set; }
        }

        public class HighAvailabilityConfig : Humidifier.Base.BaseSubResource, IHaveDesiredCapacity_Integer
        {
            /// <summary>
            /// DesiredCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-m2-environment-highavailabilityconfig.html#cfn-m2-environment-highavailabilityconfig-desiredcapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DesiredCapacity { get; set; }
        }

        public class StorageConfiguration : Humidifier.Base.BaseSubResource, IHaveM2EnvironmentTypesEfsStorageConfigurationEfs, IHaveM2EnvironmentTypesFsxStorageConfigurationFsx
        {
            /// <summary>
            /// Efs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-m2-environment-storageconfiguration.html#cfn-m2-environment-storageconfiguration-efs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EfsStorageConfiguration
            /// </summary>
            public Union<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration, BaseFunction>? Efs { get; set; }
            /// <summary>
            /// Fsx
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-m2-environment-storageconfiguration.html#cfn-m2-environment-storageconfiguration-fsx
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FsxStorageConfiguration
            /// </summary>
            public Union<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration, BaseFunction>? Fsx { get; set; }
        }
    }
}