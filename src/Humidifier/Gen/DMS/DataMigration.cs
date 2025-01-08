namespace Humidifier.DMS
{
    using System.Collections.Generic;
    using DataMigrationTypes;

    public class DataMigration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveServiceAccessRoleArn, IHaveMigrationProjectIdentifier
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
        public dynamic DataMigrationType { get; set; }
        /// <summary>
        /// DataMigrationSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-datamigration.html#cfn-dms-datamigration-datamigrationsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataMigrationSettings
        /// </summary>
        public Humidifier.DMS.DataMigrationTypes.DataMigrationSettings DataMigrationSettings { get; set; }
        public dynamic DataMigrationName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// MigrationProjectIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-datamigration.html#cfn-dms-datamigration-migrationprojectidentifier
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic MigrationProjectIdentifier { get; set; }
        /// <summary>
        /// SourceDataSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-datamigration.html#cfn-dms-datamigration-sourcedatasettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SourceDataSettings
        /// </summary>
        public List<Humidifier.DMS.DataMigrationTypes.SourceDataSettings> SourceDataSettings { get; set; }

        /// <summary>
        /// ServiceAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-datamigration.html#cfn-dms-datamigration-serviceaccessrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ServiceAccessRoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-datamigration.html#cfn-dms-datamigration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// DataMigrationIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-datamigration.html#cfn-dms-datamigration-datamigrationidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DataMigrationIdentifier { get; set; }
    }

    namespace DataMigrationTypes
    {
        public class DataMigrationSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SelectionRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-datamigration-datamigrationsettings.html#cfn-dms-datamigration-datamigrationsettings-selectionrules
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectionRules { get; set; }
            /// <summary>
            /// CloudwatchLogsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-datamigration-datamigrationsettings.html#cfn-dms-datamigration-datamigrationsettings-cloudwatchlogsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CloudwatchLogsEnabled { get; set; }
            /// <summary>
            /// NumberOfJobs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-datamigration-datamigrationsettings.html#cfn-dms-datamigration-datamigrationsettings-numberofjobs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfJobs { get; set; }
        }

        public class SourceDataSettings : Humidifier.Base.BaseSubResource, IHaveSlotName
        {
            /// <summary>
            /// CDCStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-datamigration-sourcedatasettings.html#cfn-dms-datamigration-sourcedatasettings-cdcstarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CDCStartTime { get; set; }
            /// <summary>
            /// CDCStopTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-datamigration-sourcedatasettings.html#cfn-dms-datamigration-sourcedatasettings-cdcstoptime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CDCStopTime { get; set; }
            /// <summary>
            /// SlotName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-datamigration-sourcedatasettings.html#cfn-dms-datamigration-sourcedatasettings-slotname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SlotName { get; set; }
            /// <summary>
            /// CDCStartPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-datamigration-sourcedatasettings.html#cfn-dms-datamigration-sourcedatasettings-cdcstartposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CDCStartPosition { get; set; }
        }
    }
}