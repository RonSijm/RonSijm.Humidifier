namespace Humidifier.Backup
{
    using global::System.Collections.Generic;
    using TieringConfigurationTypes;

    public class TieringConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveBackupVaultName
    {
        public class Attributes
        {
            public static string TieringConfigurationArn =  "TieringConfigurationArn" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
        }

        public override string AWSTypeName { get => AWS.Backup.TieringConfiguration; }
        public dynamic TieringConfigurationName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// BackupVaultName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-tieringconfiguration.html#cfn-backup-tieringconfiguration-backupvaultname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic BackupVaultName { get; set; }
        /// <summary>
        /// TieringConfigurationTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-tieringconfiguration.html#cfn-backup-tieringconfiguration-tieringconfigurationtags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> TieringConfigurationTags { get; set; }

        /// <summary>
        /// ResourceSelection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-tieringconfiguration.html#cfn-backup-tieringconfiguration-resourceselection
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceSelection
        /// </summary>
        [Required]
        public List<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection> ResourceSelection { get; set; }
    }

    namespace TieringConfigurationTypes
    {
        public class ResourceSelection : Humidifier.Base.BaseSubResource, IHaveResourceType, IHaveResources
        {
            /// <summary>
            /// TieringDownSettingsInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-tieringconfiguration-resourceselection.html#cfn-backup-tieringconfiguration-resourceselection-tieringdownsettingsindays
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TieringDownSettingsInDays { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-tieringconfiguration-resourceselection.html#cfn-backup-tieringconfiguration-resourceselection-resourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceType { get; set; }
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-tieringconfiguration-resourceselection.html#cfn-backup-tieringconfiguration-resourceselection-resources
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Resources { get; set; }
        }
    }
}