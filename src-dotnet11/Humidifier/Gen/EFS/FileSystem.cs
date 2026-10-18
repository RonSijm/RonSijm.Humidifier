namespace Humidifier.EFS
{
    using global::System.Collections.Generic;
    using FileSystemTypes;

    public class FileSystem : Humidifier.Base.BaseResource, IHaveKmsKeyId, IHavePerformanceMode, IHaveEncrypted_Boolean, IHaveBypassPolicyLockoutSafetyCheck_Boolean, IHaveEFSFileSystemTypesFileSystemProtectionFileSystemProtection, IHaveListOfEFSFileSystemTypesLifecyclePolicyLifecyclePolicies, IHaveThroughputMode, IHaveListOfEFSFileSystemTypesElasticFileSystemTagFileSystemTags, IHaveProvisionedThroughputInMibps_Double, IHaveFileSystemPolicy_Json, IHaveAvailabilityZoneName, IHaveEFSFileSystemTypesReplicationConfigurationReplicationConfiguration, IHaveEFSFileSystemTypesBackupPolicyBackupPolicy
    {
        public class Attributes
        {
            public static string FileSystemId =  "FileSystemId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EFS.FileSystem; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-efs-filesystem-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// PerformanceMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-efs-filesystem-performancemode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PerformanceMode { get; set; }
        /// <summary>
        /// Encrypted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-efs-filesystem-encrypted
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Encrypted { get; set; }
        /// <summary>
        /// BypassPolicyLockoutSafetyCheck
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-efs-filesystem-bypasspolicylockoutsafetycheck
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? BypassPolicyLockoutSafetyCheck { get; set; }
        /// <summary>
        /// FileSystemProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-efs-filesystem-filesystemprotection
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FileSystemProtection
        /// </summary>
        public Union<Humidifier.EFS.FileSystemTypes.FileSystemProtection, BaseFunction>? FileSystemProtection { get; set; }
        /// <summary>
        /// LifecyclePolicies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-efs-filesystem-lifecyclepolicies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LifecyclePolicy
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EFS.FileSystemTypes.LifecyclePolicy>, IReadOnlyList<Union<Humidifier.EFS.FileSystemTypes.LifecyclePolicy, BaseFunction>>, BaseFunction>? LifecyclePolicies { get; set; }
        /// <summary>
        /// ThroughputMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-efs-filesystem-throughputmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ThroughputMode { get; set; }
        /// <summary>
        /// FileSystemTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-efs-filesystem-filesystemtags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ElasticFileSystemTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EFS.FileSystemTypes.ElasticFileSystemTag>, IReadOnlyList<Union<Humidifier.EFS.FileSystemTypes.ElasticFileSystemTag, BaseFunction>>, BaseFunction>? FileSystemTags { get; set; }
        /// <summary>
        /// ProvisionedThroughputInMibps
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-efs-filesystem-provisionedthroughputinmibps
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? ProvisionedThroughputInMibps { get; set; }
        /// <summary>
        /// FileSystemPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-efs-filesystem-filesystempolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? FileSystemPolicy { get; set; }
        /// <summary>
        /// AvailabilityZoneName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-efs-filesystem-availabilityzonename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZoneName { get; set; }
        /// <summary>
        /// ReplicationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-efs-filesystem-replicationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReplicationConfiguration
        /// </summary>
        public Union<Humidifier.EFS.FileSystemTypes.ReplicationConfiguration, BaseFunction>? ReplicationConfiguration { get; set; }
        /// <summary>
        /// BackupPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-efs-filesystem-backuppolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BackupPolicy
        /// </summary>
        public Union<Humidifier.EFS.FileSystemTypes.BackupPolicy, BaseFunction>? BackupPolicy { get; set; }
    }

    namespace FileSystemTypes
    {
        public class BackupPolicy : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-backuppolicy.html#cfn-efs-filesystem-backuppolicy-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
        }

        public class ElasticFileSystemTag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-elasticfilesystemtag.html#cfn-efs-filesystem-elasticfilesystemtag-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-elasticfilesystemtag.html#cfn-efs-filesystem-elasticfilesystemtag-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class FileSystemProtection : Humidifier.Base.BaseSubResource, IHaveReplicationOverwriteProtection
        {
            /// <summary>
            /// ReplicationOverwriteProtection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-filesystemprotection.html#cfn-efs-filesystem-filesystemprotection-replicationoverwriteprotection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReplicationOverwriteProtection { get; set; }
        }

        public class LifecyclePolicy : Humidifier.Base.BaseSubResource, IHaveTransitionToIA, IHaveTransitionToPrimaryStorageClass, IHaveTransitionToArchive
        {
            /// <summary>
            /// TransitionToIA
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-lifecyclepolicy.html#cfn-efs-filesystem-lifecyclepolicy-transitiontoia
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TransitionToIA { get; set; }
            /// <summary>
            /// TransitionToPrimaryStorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-lifecyclepolicy.html#cfn-efs-filesystem-lifecyclepolicy-transitiontoprimarystorageclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TransitionToPrimaryStorageClass { get; set; }
            /// <summary>
            /// TransitionToArchive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-lifecyclepolicy.html#cfn-efs-filesystem-lifecyclepolicy-transitiontoarchive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TransitionToArchive { get; set; }
        }

        public class ReplicationConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfEFSFileSystemTypesReplicationDestinationDestinations
        {
            /// <summary>
            /// Destinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-replicationconfiguration.html#cfn-efs-filesystem-replicationconfiguration-destinations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReplicationDestination
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EFS.FileSystemTypes.ReplicationDestination>, IReadOnlyList<Union<Humidifier.EFS.FileSystemTypes.ReplicationDestination, BaseFunction>>, BaseFunction>? Destinations { get; set; }
        }

        public class ReplicationDestination : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveKmsKeyId, IHaveAvailabilityZoneName, IHaveFileSystemId, IHaveRegion, IHaveRoleArn, IHaveStatusMessage
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-replicationdestination.html#cfn-efs-filesystem-replicationdestination-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-replicationdestination.html#cfn-efs-filesystem-replicationdestination-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// AvailabilityZoneName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-replicationdestination.html#cfn-efs-filesystem-replicationdestination-availabilityzonename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZoneName { get; set; }
            /// <summary>
            /// FileSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-replicationdestination.html#cfn-efs-filesystem-replicationdestination-filesystemid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemId { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-replicationdestination.html#cfn-efs-filesystem-replicationdestination-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-replicationdestination.html#cfn-efs-filesystem-replicationdestination-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// StatusMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-replicationdestination.html#cfn-efs-filesystem-replicationdestination-statusmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusMessage { get; set; }
        }
    }
}