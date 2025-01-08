namespace Humidifier.Backup
{
    using System.Collections.Generic;
    using BackupSelectionTypes;

    public class BackupSelection : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string BackupPlanId =  "BackupPlanId" ;
            public static string Id =  "Id" ;
            public static string SelectionId =  "SelectionId" ;
        }

        public override string AWSTypeName { get => AWS.Backup.BackupSelection; }

        /// <summary>
        /// BackupSelection_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupselection.html#cfn-backup-backupselection-backupselection
        /// Required: True
        /// UpdateType: Immutable
        /// Type: BackupSelectionResourceType
        /// </summary>
        [Required]
        public Humidifier.Backup.BackupSelectionTypes.BackupSelectionResourceType BackupSelection_ { get; set; }

        /// <summary>
        /// BackupPlanId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupselection.html#cfn-backup-backupselection-backupplanid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic BackupPlanId { get; set; }
    }

    namespace BackupSelectionTypes
    {
        public class BackupSelectionResourceType : Humidifier.Base.BaseSubResource, IHaveIamRoleArn, IHaveResources
        {
            /// <summary>
            /// ListOfTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-backupselectionresourcetype.html#cfn-backup-backupselection-backupselectionresourcetype-listoftags
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ConditionResourceType
            /// </summary>
            public List<Humidifier.Backup.BackupSelectionTypes.ConditionResourceType> ListOfTags { get; set; }
            /// <summary>
            /// NotResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-backupselectionresourcetype.html#cfn-backup-backupselection-backupselectionresourcetype-notresources
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic NotResources { get; set; }
            /// <summary>
            /// SelectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-backupselectionresourcetype.html#cfn-backup-backupselection-backupselectionresourcetype-selectionname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectionName { get; set; }
            /// <summary>
            /// IamRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-backupselectionresourcetype.html#cfn-backup-backupselection-backupselectionresourcetype-iamrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IamRoleArn { get; set; }
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-backupselectionresourcetype.html#cfn-backup-backupselection-backupselectionresourcetype-resources
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Resources { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-backupselectionresourcetype.html#cfn-backup-backupselection-backupselectionresourcetype-conditions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Conditions
            /// </summary>
            public Humidifier.Backup.BackupSelectionTypes.Conditions Conditions { get; set; }
        }

        public class ConditionParameter : Humidifier.Base.BaseSubResource, IHaveConditionValue, IHaveConditionKey
        {
            /// <summary>
            /// ConditionValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-conditionparameter.html#cfn-backup-backupselection-conditionparameter-conditionvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConditionValue { get; set; }
            /// <summary>
            /// ConditionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-conditionparameter.html#cfn-backup-backupselection-conditionparameter-conditionkey
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConditionKey { get; set; }
        }

        public class ConditionResourceType : Humidifier.Base.BaseSubResource, IHaveConditionValue, IHaveConditionKey
        {
            /// <summary>
            /// ConditionValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-conditionresourcetype.html#cfn-backup-backupselection-conditionresourcetype-conditionvalue
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConditionValue { get; set; }
            /// <summary>
            /// ConditionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-conditionresourcetype.html#cfn-backup-backupselection-conditionresourcetype-conditionkey
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConditionKey { get; set; }
            /// <summary>
            /// ConditionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-conditionresourcetype.html#cfn-backup-backupselection-conditionresourcetype-conditiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConditionType { get; set; }
        }

        public class Conditions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StringEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-conditions.html#cfn-backup-backupselection-conditions-stringequals
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ConditionParameter
            /// </summary>
            public List<Humidifier.Backup.BackupSelectionTypes.ConditionParameter> StringEquals { get; set; }
            /// <summary>
            /// StringNotLike
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-conditions.html#cfn-backup-backupselection-conditions-stringnotlike
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ConditionParameter
            /// </summary>
            public List<Humidifier.Backup.BackupSelectionTypes.ConditionParameter> StringNotLike { get; set; }
            /// <summary>
            /// StringLike
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-conditions.html#cfn-backup-backupselection-conditions-stringlike
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ConditionParameter
            /// </summary>
            public List<Humidifier.Backup.BackupSelectionTypes.ConditionParameter> StringLike { get; set; }
            /// <summary>
            /// StringNotEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-conditions.html#cfn-backup-backupselection-conditions-stringnotequals
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ConditionParameter
            /// </summary>
            public List<Humidifier.Backup.BackupSelectionTypes.ConditionParameter> StringNotEquals { get; set; }
        }
    }
}