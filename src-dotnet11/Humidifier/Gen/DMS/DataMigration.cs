namespace Humidifier.DMS
{
    using global::System.Collections.Generic;
    using DataMigrationTypes;

    public class DataMigration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDataMigrationType, IHaveDMSDataMigrationTypesDataMigrationSettingsDataMigrationSettings, IHaveDataMigrationName, IHaveMigrationProjectIdentifier, IHaveListOfDMSDataMigrationTypesSourceDataSettingsSourceDataSettings, IHaveServiceAccessRoleArn
    {
        public class Attributes
        {
            public static string DataMigrationArn =  "DataMigrationArn" ;
            public static string DataMigrationCreateTime =  "DataMigrationCreateTime" ;
        }

        public override string AWSTypeName { get => AWS.DMS.DataMigration; }

        /// <summary>
        /// DataMigrationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-datamigration.html#cfn-dms-datamigration-datamigrationtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataMigrationType { get; set; }
        /// <summary>
        /// DataMigrationSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-datamigration.html#cfn-dms-datamigration-datamigrationsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataMigrationSettings
        /// </summary>
        public Union<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings, BaseFunction>? DataMigrationSettings { get; set; }
        public Union<string, BaseFunction>? DataMigrationName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// MigrationProjectIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-datamigration.html#cfn-dms-datamigration-migrationprojectidentifier
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MigrationProjectIdentifier { get; set; }
        /// <summary>
        /// SourceDataSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-datamigration.html#cfn-dms-datamigration-sourcedatasettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SourceDataSettings
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DMS.DataMigrationTypes.SourceDataSettings>, IReadOnlyList<Union<Humidifier.DMS.DataMigrationTypes.SourceDataSettings, BaseFunction>>, BaseFunction>? SourceDataSettings { get; set; }

        /// <summary>
        /// ServiceAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-datamigration.html#cfn-dms-datamigration-serviceaccessrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceAccessRoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-datamigration.html#cfn-dms-datamigration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DataMigrationTypes
    {
        public class DataMigrationSettings : Humidifier.Base.BaseSubResource, IHaveSelectionRules, IHaveCloudwatchLogsEnabled_Boolean, IHaveNumberOfJobs_Integer
        {
            /// <summary>
            /// SelectionRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-datamigration-datamigrationsettings.html#cfn-dms-datamigration-datamigrationsettings-selectionrules
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SelectionRules { get; set; }
            /// <summary>
            /// CloudwatchLogsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-datamigration-datamigrationsettings.html#cfn-dms-datamigration-datamigrationsettings-cloudwatchlogsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CloudwatchLogsEnabled { get; set; }
            /// <summary>
            /// NumberOfJobs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-datamigration-datamigrationsettings.html#cfn-dms-datamigration-datamigrationsettings-numberofjobs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfJobs { get; set; }
        }

        public class SourceDataSettings : Humidifier.Base.BaseSubResource, IHaveCDCStartTime, IHaveCDCStopTime, IHaveSlotName, IHaveCDCStartPosition
        {
            /// <summary>
            /// CDCStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-datamigration-sourcedatasettings.html#cfn-dms-datamigration-sourcedatasettings-cdcstarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CDCStartTime { get; set; }
            /// <summary>
            /// CDCStopTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-datamigration-sourcedatasettings.html#cfn-dms-datamigration-sourcedatasettings-cdcstoptime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CDCStopTime { get; set; }
            /// <summary>
            /// SlotName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-datamigration-sourcedatasettings.html#cfn-dms-datamigration-sourcedatasettings-slotname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SlotName { get; set; }
            /// <summary>
            /// CDCStartPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-datamigration-sourcedatasettings.html#cfn-dms-datamigration-sourcedatasettings-cdcstartposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CDCStartPosition { get; set; }
        }
    }
}