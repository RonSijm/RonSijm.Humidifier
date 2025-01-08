namespace Humidifier.Backup
{
    using System.Collections.Generic;
    using RestoreTestingSelectionTypes;

    public class RestoreTestingSelection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveIamRoleArn, IHaveRestoreTestingPlanName
    {
        public override string AWSTypeName { get => AWS.Backup.RestoreTestingSelection; }
        /// <summary>
        /// ProtectedResourceConditions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingselection.html#cfn-backup-restoretestingselection-protectedresourceconditions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProtectedResourceConditions
        /// </summary>
        public Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions ProtectedResourceConditions { get; set; }

        /// <summary>
        /// ProtectedResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingselection.html#cfn-backup-restoretestingselection-protectedresourcetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ProtectedResourceType { get; set; }
        /// <summary>
        /// RestoreMetadataOverrides
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingselection.html#cfn-backup-restoretestingselection-restoremetadataoverrides
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> RestoreMetadataOverrides { get; set; }
        public dynamic RestoreTestingSelectionName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ProtectedResourceArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingselection.html#cfn-backup-restoretestingselection-protectedresourcearns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic ProtectedResourceArns { get; set; }

        /// <summary>
        /// RestoreTestingPlanName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingselection.html#cfn-backup-restoretestingselection-restoretestingplanname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RestoreTestingPlanName { get; set; }

        /// <summary>
        /// IamRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingselection.html#cfn-backup-restoretestingselection-iamrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IamRoleArn { get; set; }
        /// <summary>
        /// ValidationWindowHours
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-restoretestingselection.html#cfn-backup-restoretestingselection-validationwindowhours
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ValidationWindowHours { get; set; }
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
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-restoretestingselection-keyvalue.html#cfn-backup-restoretestingselection-keyvalue-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class ProtectedResourceConditions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StringEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-restoretestingselection-protectedresourceconditions.html#cfn-backup-restoretestingselection-protectedresourceconditions-stringequals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValue
            /// </summary>
            public List<Humidifier.Backup.RestoreTestingSelectionTypes.KeyValue> StringEquals { get; set; }
            /// <summary>
            /// StringNotEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-restoretestingselection-protectedresourceconditions.html#cfn-backup-restoretestingselection-protectedresourceconditions-stringnotequals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValue
            /// </summary>
            public List<Humidifier.Backup.RestoreTestingSelectionTypes.KeyValue> StringNotEquals { get; set; }
        }
    }
}