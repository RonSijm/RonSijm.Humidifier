namespace Humidifier.BackupSearch
{
    using global::System.Collections.Generic;
    using SearchJobTypes;

    public class SearchJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveBackupSearchSearchJobTypesSearchScopeSearchScope, IHaveListOfBackupSearchSearchJobTypesTagsItemsTags, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string SearchJobIdentifier =  "SearchJobIdentifier" ;
            public static string SearchJobArn =  "SearchJobArn" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.BackupSearch.SearchJob; }

        /// <summary>
        /// SearchScope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backupsearch-searchjob.html#cfn-backupsearch-searchjob-searchscope
        /// Required: True
        /// UpdateType: Immutable
        /// Type: SearchScope
        /// </summary>
        [Required]
        public Union<Humidifier.BackupSearch.SearchJobTypes.SearchScope, BaseFunction>? SearchScope { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backupsearch-searchjob.html#cfn-backupsearch-searchjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BackupSearch.SearchJobTypes.TagsItems>, IReadOnlyList<Union<Humidifier.BackupSearch.SearchJobTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SearchJobTypes
    {
        public class SearchScope : Humidifier.Base.BaseSubResource, IHaveStringListOfBackupResourceTypes
        {
            /// <summary>
            /// BackupResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupsearch-searchjob-searchscope.html#cfn-backupsearch-searchjob-searchscope-backupresourcetypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? BackupResourceTypes { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupsearch-searchjob-tagsitems.html#cfn-backupsearch-searchjob-tagsitems-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupsearch-searchjob-tagsitems.html#cfn-backupsearch-searchjob-tagsitems-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}