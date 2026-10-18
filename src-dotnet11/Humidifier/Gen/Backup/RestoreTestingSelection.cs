namespace Humidifier.Backup
{
    using global::System.Collections.Generic;
    using RestoreTestingSelectionTypes;

    public class RestoreTestingSelection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveBackupRestoreTestingSelectionTypesProtectedResourceConditionsProtectedResourceConditions, IHaveProtectedResourceType, IHaveStringDictionaryOfRestoreMetadataOverrides, IHaveRestoreTestingSelectionName, IHaveStringListOfProtectedResourceArns, IHaveRestoreTestingPlanName, IHaveIamRoleArn, IHaveValidationWindowHours_Integer
    {
        public override string AWSTypeName { get => AWS.Backup.RestoreTestingSelection; }
        /// <summary>
        /// ProtectedResourceConditions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingselection.html#cfn-backup-restoretestingselection-protectedresourceconditions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProtectedResourceConditions
        /// </summary>
        public Union<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions, BaseFunction>? ProtectedResourceConditions { get; set; }

        /// <summary>
        /// ProtectedResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingselection.html#cfn-backup-restoretestingselection-protectedresourcetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProtectedResourceType { get; set; }
        /// <summary>
        /// RestoreMetadataOverrides
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingselection.html#cfn-backup-restoretestingselection-restoremetadataoverrides
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? RestoreMetadataOverrides { get; set; }
        public Union<string, BaseFunction>? RestoreTestingSelectionName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ProtectedResourceArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingselection.html#cfn-backup-restoretestingselection-protectedresourcearns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ProtectedResourceArns { get; set; }

        /// <summary>
        /// RestoreTestingPlanName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingselection.html#cfn-backup-restoretestingselection-restoretestingplanname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RestoreTestingPlanName { get; set; }

        /// <summary>
        /// IamRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingselection.html#cfn-backup-restoretestingselection-iamrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IamRoleArn { get; set; }
        /// <summary>
        /// ValidationWindowHours
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingselection.html#cfn-backup-restoretestingselection-validationwindowhours
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ValidationWindowHours { get; set; }
    }

    namespace RestoreTestingSelectionTypes
    {
        public class KeyValue : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-restoretestingselection-keyvalue.html#cfn-backup-restoretestingselection-keyvalue-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-restoretestingselection-keyvalue.html#cfn-backup-restoretestingselection-keyvalue-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class ProtectedResourceConditions : Humidifier.Base.BaseSubResource, IHaveListOfBackupRestoreTestingSelectionTypesKeyValueStringEquals, IHaveListOfBackupRestoreTestingSelectionTypesKeyValueStringNotEquals
        {
            /// <summary>
            /// StringEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-restoretestingselection-protectedresourceconditions.html#cfn-backup-restoretestingselection-protectedresourceconditions-stringequals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Backup.RestoreTestingSelectionTypes.KeyValue>, IReadOnlyList<Union<Humidifier.Backup.RestoreTestingSelectionTypes.KeyValue, BaseFunction>>, BaseFunction>? StringEquals { get; set; }
            /// <summary>
            /// StringNotEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-restoretestingselection-protectedresourceconditions.html#cfn-backup-restoretestingselection-protectedresourceconditions-stringnotequals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Backup.RestoreTestingSelectionTypes.KeyValue>, IReadOnlyList<Union<Humidifier.Backup.RestoreTestingSelectionTypes.KeyValue, BaseFunction>>, BaseFunction>? StringNotEquals { get; set; }
        }
    }
}