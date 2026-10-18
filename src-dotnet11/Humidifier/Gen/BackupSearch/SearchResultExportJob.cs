namespace Humidifier.BackupSearch
{
    using global::System.Collections.Generic;
    using SearchResultExportJobTypes;

    public class SearchResultExportJob : Humidifier.Base.BaseResource, IHaveBackupSearchSearchResultExportJobTypesExportSpecificationExportSpecification, IHaveListOfBackupSearchSearchResultExportJobTypesTagsItemsTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ExportJobIdentifier =  "ExportJobIdentifier" ;
            public static string SearchJobArn =  "SearchJobArn" ;
            public static string ExportJobArn =  "ExportJobArn" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.BackupSearch.SearchResultExportJob; }
        /// <summary>
        /// ExportSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backupsearch-searchresultexportjob.html#cfn-backupsearch-searchresultexportjob-exportspecification
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ExportSpecification
        /// </summary>
        public Union<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification, BaseFunction>? ExportSpecification { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backupsearch-searchresultexportjob.html#cfn-backupsearch-searchresultexportjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems>, IReadOnlyList<Union<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace SearchResultExportJobTypes
    {
        public class ExportSpecification : Humidifier.Base.BaseSubResource, IHaveBackupSearchSearchResultExportJobTypesS3ExportSpecificationS3ExportSpecification
        {
            /// <summary>
            /// S3ExportSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupsearch-searchresultexportjob-exportspecification.html#cfn-backupsearch-searchresultexportjob-exportspecification-s3exportspecification
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3ExportSpecification
            /// </summary>
            public Union<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification, BaseFunction>? S3ExportSpecification { get; set; }
        }

        public class S3ExportSpecification : Humidifier.Base.BaseSubResource, IHaveDestinationBucket, IHaveDestinationPrefix
        {
            /// <summary>
            /// DestinationBucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupsearch-searchresultexportjob-s3exportspecification.html#cfn-backupsearch-searchresultexportjob-s3exportspecification-destinationbucket
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationBucket { get; set; }
            /// <summary>
            /// DestinationPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupsearch-searchresultexportjob-s3exportspecification.html#cfn-backupsearch-searchresultexportjob-s3exportspecification-destinationprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationPrefix { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupsearch-searchresultexportjob-tagsitems.html#cfn-backupsearch-searchresultexportjob-tagsitems-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupsearch-searchresultexportjob-tagsitems.html#cfn-backupsearch-searchresultexportjob-tagsitems-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}