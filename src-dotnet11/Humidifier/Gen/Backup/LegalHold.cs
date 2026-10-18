namespace Humidifier.Backup
{
    using global::System.Collections.Generic;
    using LegalHoldTypes;

    public class LegalHold : Humidifier.Base.BaseResource, IHaveDescription, IHaveBackupLegalHoldTypesRecoveryPointSelectionRecoveryPointSelection, IHaveTitle, IHaveListOfBackupLegalHoldTypesTagsItemsTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationDate =  "CreationDate" ;
            public static string LegalHoldId =  "LegalHoldId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Backup.LegalHold; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-legalhold.html#cfn-backup-legalhold-description
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// RecoveryPointSelection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-legalhold.html#cfn-backup-legalhold-recoverypointselection
        /// Required: True
        /// UpdateType: Immutable
        /// Type: RecoveryPointSelection
        /// </summary>
        [Required]
        public Union<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection, BaseFunction>? RecoveryPointSelection { get; set; }

        /// <summary>
        /// Title
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-legalhold.html#cfn-backup-legalhold-title
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Title { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-legalhold.html#cfn-backup-legalhold-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Backup.LegalHoldTypes.TagsItems>, IReadOnlyList<Union<Humidifier.Backup.LegalHoldTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace LegalHoldTypes
    {
        public class DateRange : Humidifier.Base.BaseSubResource, IHaveFromDate, IHaveToDate
        {
            /// <summary>
            /// FromDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-legalhold-daterange.html#cfn-backup-legalhold-daterange-fromdate
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FromDate { get; set; }
            /// <summary>
            /// ToDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-legalhold-daterange.html#cfn-backup-legalhold-daterange-todate
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ToDate { get; set; }
        }

        public class RecoveryPointSelection : Humidifier.Base.BaseSubResource, IHaveBackupLegalHoldTypesDateRangeDateRange, IHaveStringListOfVaultNames, IHaveStringListOfResourceIdentifiers
        {
            /// <summary>
            /// DateRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-legalhold-recoverypointselection.html#cfn-backup-legalhold-recoverypointselection-daterange
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DateRange
            /// </summary>
            public Union<Humidifier.Backup.LegalHoldTypes.DateRange, BaseFunction>? DateRange { get; set; }
            /// <summary>
            /// VaultNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-legalhold-recoverypointselection.html#cfn-backup-legalhold-recoverypointselection-vaultnames
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VaultNames { get; set; }
            /// <summary>
            /// ResourceIdentifiers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-legalhold-recoverypointselection.html#cfn-backup-legalhold-recoverypointselection-resourceidentifiers
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceIdentifiers { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-legalhold-tagsitems.html#cfn-backup-legalhold-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-legalhold-tagsitems.html#cfn-backup-legalhold-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}