namespace Humidifier.Backup
{
    using global::System.Collections.Generic;
    using TieringConfigurationTypes;

    public class TieringConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTieringConfigurationName, IHaveBackupVaultName, IHaveStringDictionaryOfTieringConfigurationTags, IHaveListOfBackupTieringConfigurationTypesResourceSelectionResourceSelection
    {
        public class Attributes
        {
            public static string TieringConfigurationArn =  "TieringConfigurationArn" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
        }

        public override string AWSTypeName { get => AWS.Backup.TieringConfiguration; }
        public Union<string, BaseFunction>? TieringConfigurationName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// BackupVaultName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-tieringconfiguration.html#cfn-backup-tieringconfiguration-backupvaultname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BackupVaultName { get; set; }
        /// <summary>
        /// TieringConfigurationTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-tieringconfiguration.html#cfn-backup-tieringconfiguration-tieringconfigurationtags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? TieringConfigurationTags { get; set; }

        /// <summary>
        /// ResourceSelection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-tieringconfiguration.html#cfn-backup-tieringconfiguration-resourceselection
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceSelection
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection>, IReadOnlyList<Union<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection, BaseFunction>>, BaseFunction>? ResourceSelection { get; set; }
    }

    namespace TieringConfigurationTypes
    {
        public class ResourceSelection : Humidifier.Base.BaseSubResource, IHaveTieringDownSettingsInDays_Integer, IHaveResourceType, IHaveStringListOfResources
        {
            /// <summary>
            /// TieringDownSettingsInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-tieringconfiguration-resourceselection.html#cfn-backup-tieringconfiguration-resourceselection-tieringdownsettingsindays
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TieringDownSettingsInDays { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-tieringconfiguration-resourceselection.html#cfn-backup-tieringconfiguration-resourceselection-resourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-tieringconfiguration-resourceselection.html#cfn-backup-tieringconfiguration-resourceselection-resources
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Resources { get; set; }
        }
    }
}