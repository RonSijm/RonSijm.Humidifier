namespace Humidifier.Backup
{
    using global::System.Collections.Generic;
    using RestoreTestingPlanTypes;

    public class RestoreTestingPlan : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveScheduleExpression, IHaveStartWindowHours_Integer, IHaveBackupRestoreTestingPlanTypesRestoreTestingRecoveryPointSelectionRecoveryPointSelection, IHaveRestoreTestingPlanName, IHaveScheduleExpressionTimezone
    {
        public class Attributes
        {
            public static string RestoreTestingPlanArn =  "RestoreTestingPlanArn" ;
        }

        public override string AWSTypeName { get => AWS.Backup.RestoreTestingPlan; }

        /// <summary>
        /// ScheduleExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingplan.html#cfn-backup-restoretestingplan-scheduleexpression
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ScheduleExpression { get; set; }
        /// <summary>
        /// StartWindowHours
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingplan.html#cfn-backup-restoretestingplan-startwindowhours
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? StartWindowHours { get; set; }

        /// <summary>
        /// RecoveryPointSelection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingplan.html#cfn-backup-restoretestingplan-recoverypointselection
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RestoreTestingRecoveryPointSelection
        /// </summary>
        [Required]
        public Union<Humidifier.Backup.RestoreTestingPlanTypes.RestoreTestingRecoveryPointSelection, BaseFunction>? RecoveryPointSelection { get; set; }
        public Union<string, BaseFunction>? RestoreTestingPlanName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ScheduleExpressionTimezone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingplan.html#cfn-backup-restoretestingplan-scheduleexpressiontimezone
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ScheduleExpressionTimezone { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingplan.html#cfn-backup-restoretestingplan-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace RestoreTestingPlanTypes
    {
        public class RestoreTestingRecoveryPointSelection : Humidifier.Base.BaseSubResource, IHaveSelectionWindowDays_Integer, IHaveStringListOfRecoveryPointTypes, IHaveStringListOfIncludeVaults, IHaveStringListOfExcludeVaults, IHaveAlgorithm
        {
            /// <summary>
            /// SelectionWindowDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-restoretestingplan-restoretestingrecoverypointselection.html#cfn-backup-restoretestingplan-restoretestingrecoverypointselection-selectionwindowdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SelectionWindowDays { get; set; }
            /// <summary>
            /// RecoveryPointTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-restoretestingplan-restoretestingrecoverypointselection.html#cfn-backup-restoretestingplan-restoretestingrecoverypointselection-recoverypointtypes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RecoveryPointTypes { get; set; }
            /// <summary>
            /// IncludeVaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-restoretestingplan-restoretestingrecoverypointselection.html#cfn-backup-restoretestingplan-restoretestingrecoverypointselection-includevaults
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IncludeVaults { get; set; }
            /// <summary>
            /// ExcludeVaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-restoretestingplan-restoretestingrecoverypointselection.html#cfn-backup-restoretestingplan-restoretestingrecoverypointselection-excludevaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludeVaults { get; set; }
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-restoretestingplan-restoretestingrecoverypointselection.html#cfn-backup-restoretestingplan-restoretestingrecoverypointselection-algorithm
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Algorithm { get; set; }
        }
    }
}