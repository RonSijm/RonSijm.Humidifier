namespace Humidifier.Kendra
{
    using System.Collections.Generic;
    using DataSourceTypes;

    public class DataSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveType, IHaveRoleArn, IHaveLanguageCode, IHaveSchedule, IHaveIndexId
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Kendra.DataSource; }
        /// <summary>
        /// CustomDocumentEnrichmentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-customdocumentenrichmentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomDocumentEnrichmentConfiguration
        /// </summary>
        public Humidifier.Kendra.DataSourceTypes.CustomDocumentEnrichmentConfiguration CustomDocumentEnrichmentConfiguration { get; set; }

        /// <summary>
        /// IndexId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-indexid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IndexId { get; set; }
        /// <summary>
        /// LanguageCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-languagecode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LanguageCode { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-schedule
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Schedule { get; set; }
        /// <summary>
        /// DataSourceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-datasourceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSourceConfiguration
        /// </summary>
        public Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration DataSourceConfiguration { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace DataSourceTypes
    {
        public class AccessControlListConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KeyPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-accesscontrollistconfiguration.html#cfn-kendra-datasource-accesscontrollistconfiguration-keypath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyPath { get; set; }
        }

        public class AclConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AllowedGroupsColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-aclconfiguration.html#cfn-kendra-datasource-aclconfiguration-allowedgroupscolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AllowedGroupsColumnName { get; set; }
        }

        public class ColumnConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ChangeDetectingColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-columnconfiguration.html#cfn-kendra-datasource-columnconfiguration-changedetectingcolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ChangeDetectingColumns { get; set; }
            /// <summary>
            /// DocumentTitleColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-columnconfiguration.html#cfn-kendra-datasource-columnconfiguration-documenttitlecolumnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentTitleColumnName { get; set; }
            /// <summary>
            /// DocumentIdColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-columnconfiguration.html#cfn-kendra-datasource-columnconfiguration-documentidcolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentIdColumnName { get; set; }
            /// <summary>
            /// DocumentDataColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-columnconfiguration.html#cfn-kendra-datasource-columnconfiguration-documentdatacolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentDataColumnName { get; set; }
            /// <summary>
            /// FieldMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-columnconfiguration.html#cfn-kendra-datasource-columnconfiguration-fieldmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSourceToIndexFieldMapping
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.DataSourceToIndexFieldMapping> FieldMappings { get; set; }
        }

        public class ConfluenceAttachmentConfiguration : Humidifier.Base.BaseSubResource, IHaveCrawlAttachments
        {
            /// <summary>
            /// AttachmentFieldMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceattachmentconfiguration.html#cfn-kendra-datasource-confluenceattachmentconfiguration-attachmentfieldmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ConfluenceAttachmentToIndexFieldMapping
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.ConfluenceAttachmentToIndexFieldMapping> AttachmentFieldMappings { get; set; }
            /// <summary>
            /// CrawlAttachments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceattachmentconfiguration.html#cfn-kendra-datasource-confluenceattachmentconfiguration-crawlattachments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CrawlAttachments { get; set; }
        }

        public class ConfluenceAttachmentToIndexFieldMapping : Humidifier.Base.BaseSubResource, IHaveDateFieldFormat, IHaveIndexFieldName, IHaveDataSourceFieldName
        {
            /// <summary>
            /// DateFieldFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceattachmenttoindexfieldmapping.html#cfn-kendra-datasource-confluenceattachmenttoindexfieldmapping-datefieldformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateFieldFormat { get; set; }
            /// <summary>
            /// IndexFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceattachmenttoindexfieldmapping.html#cfn-kendra-datasource-confluenceattachmenttoindexfieldmapping-indexfieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexFieldName { get; set; }
            /// <summary>
            /// DataSourceFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceattachmenttoindexfieldmapping.html#cfn-kendra-datasource-confluenceattachmenttoindexfieldmapping-datasourcefieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSourceFieldName { get; set; }
        }

        public class ConfluenceBlogConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BlogFieldMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceblogconfiguration.html#cfn-kendra-datasource-confluenceblogconfiguration-blogfieldmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ConfluenceBlogToIndexFieldMapping
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.ConfluenceBlogToIndexFieldMapping> BlogFieldMappings { get; set; }
        }

        public class ConfluenceBlogToIndexFieldMapping : Humidifier.Base.BaseSubResource, IHaveDateFieldFormat, IHaveIndexFieldName, IHaveDataSourceFieldName
        {
            /// <summary>
            /// DateFieldFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceblogtoindexfieldmapping.html#cfn-kendra-datasource-confluenceblogtoindexfieldmapping-datefieldformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateFieldFormat { get; set; }
            /// <summary>
            /// IndexFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceblogtoindexfieldmapping.html#cfn-kendra-datasource-confluenceblogtoindexfieldmapping-indexfieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexFieldName { get; set; }
            /// <summary>
            /// DataSourceFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceblogtoindexfieldmapping.html#cfn-kendra-datasource-confluenceblogtoindexfieldmapping-datasourcefieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSourceFieldName { get; set; }
        }

        public class ConfluenceConfiguration : Humidifier.Base.BaseSubResource, IHaveVersion, IHaveSecretArn, IHaveInclusionPatterns, IHaveExclusionPatterns, IHaveServerUrl, IHaveKendraDataSourceTypesDataSourceVpcConfigurationVpcConfiguration
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceconfiguration.html#cfn-kendra-datasource-confluenceconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// AttachmentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceconfiguration.html#cfn-kendra-datasource-confluenceconfiguration-attachmentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfluenceAttachmentConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.ConfluenceAttachmentConfiguration AttachmentConfiguration { get; set; }
            /// <summary>
            /// ServerUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceconfiguration.html#cfn-kendra-datasource-confluenceconfiguration-serverurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerUrl { get; set; }
            /// <summary>
            /// PageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceconfiguration.html#cfn-kendra-datasource-confluenceconfiguration-pageconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfluencePageConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.ConfluencePageConfiguration PageConfiguration { get; set; }
            /// <summary>
            /// BlogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceconfiguration.html#cfn-kendra-datasource-confluenceconfiguration-blogconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfluenceBlogConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.ConfluenceBlogConfiguration BlogConfiguration { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceconfiguration.html#cfn-kendra-datasource-confluenceconfiguration-version
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Version { get; set; }
            /// <summary>
            /// VpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceconfiguration.html#cfn-kendra-datasource-confluenceconfiguration-vpcconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSourceVpcConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration VpcConfiguration { get; set; }
            /// <summary>
            /// InclusionPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceconfiguration.html#cfn-kendra-datasource-confluenceconfiguration-inclusionpatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InclusionPatterns { get; set; }
            /// <summary>
            /// ExclusionPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceconfiguration.html#cfn-kendra-datasource-confluenceconfiguration-exclusionpatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExclusionPatterns { get; set; }
            /// <summary>
            /// SpaceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceconfiguration.html#cfn-kendra-datasource-confluenceconfiguration-spaceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfluenceSpaceConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.ConfluenceSpaceConfiguration SpaceConfiguration { get; set; }
        }

        public class ConfluencePageConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PageFieldMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencepageconfiguration.html#cfn-kendra-datasource-confluencepageconfiguration-pagefieldmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ConfluencePageToIndexFieldMapping
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.ConfluencePageToIndexFieldMapping> PageFieldMappings { get; set; }
        }

        public class ConfluencePageToIndexFieldMapping : Humidifier.Base.BaseSubResource, IHaveDateFieldFormat, IHaveIndexFieldName, IHaveDataSourceFieldName
        {
            /// <summary>
            /// DateFieldFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencepagetoindexfieldmapping.html#cfn-kendra-datasource-confluencepagetoindexfieldmapping-datefieldformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateFieldFormat { get; set; }
            /// <summary>
            /// IndexFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencepagetoindexfieldmapping.html#cfn-kendra-datasource-confluencepagetoindexfieldmapping-indexfieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexFieldName { get; set; }
            /// <summary>
            /// DataSourceFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencepagetoindexfieldmapping.html#cfn-kendra-datasource-confluencepagetoindexfieldmapping-datasourcefieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSourceFieldName { get; set; }
        }

        public class ConfluenceSpaceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExcludeSpaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencespaceconfiguration.html#cfn-kendra-datasource-confluencespaceconfiguration-excludespaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludeSpaces { get; set; }
            /// <summary>
            /// SpaceFieldMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencespaceconfiguration.html#cfn-kendra-datasource-confluencespaceconfiguration-spacefieldmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ConfluenceSpaceToIndexFieldMapping
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.ConfluenceSpaceToIndexFieldMapping> SpaceFieldMappings { get; set; }
            /// <summary>
            /// CrawlPersonalSpaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencespaceconfiguration.html#cfn-kendra-datasource-confluencespaceconfiguration-crawlpersonalspaces
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CrawlPersonalSpaces { get; set; }
            /// <summary>
            /// CrawlArchivedSpaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencespaceconfiguration.html#cfn-kendra-datasource-confluencespaceconfiguration-crawlarchivedspaces
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CrawlArchivedSpaces { get; set; }
            /// <summary>
            /// IncludeSpaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencespaceconfiguration.html#cfn-kendra-datasource-confluencespaceconfiguration-includespaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludeSpaces { get; set; }
        }

        public class ConfluenceSpaceToIndexFieldMapping : Humidifier.Base.BaseSubResource, IHaveDateFieldFormat, IHaveIndexFieldName, IHaveDataSourceFieldName
        {
            /// <summary>
            /// DateFieldFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencespacetoindexfieldmapping.html#cfn-kendra-datasource-confluencespacetoindexfieldmapping-datefieldformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateFieldFormat { get; set; }
            /// <summary>
            /// IndexFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencespacetoindexfieldmapping.html#cfn-kendra-datasource-confluencespacetoindexfieldmapping-indexfieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexFieldName { get; set; }
            /// <summary>
            /// DataSourceFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencespacetoindexfieldmapping.html#cfn-kendra-datasource-confluencespacetoindexfieldmapping-datasourcefieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSourceFieldName { get; set; }
        }

        public class ConnectionConfiguration : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveTableName, IHaveSecretArn, IHaveDatabasePort, IHaveDatabaseHost
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-connectionconfiguration.html#cfn-kendra-datasource-connectionconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-connectionconfiguration.html#cfn-kendra-datasource-connectionconfiguration-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableName { get; set; }
            /// <summary>
            /// DatabasePort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-connectionconfiguration.html#cfn-kendra-datasource-connectionconfiguration-databaseport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DatabasePort { get; set; }
            /// <summary>
            /// DatabaseHost
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-connectionconfiguration.html#cfn-kendra-datasource-connectionconfiguration-databasehost
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseHost { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-connectionconfiguration.html#cfn-kendra-datasource-connectionconfiguration-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
        }

        public class CustomDocumentEnrichmentConfiguration : Humidifier.Base.BaseSubResource, IHaveRoleArn
        {
            /// <summary>
            /// InlineConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-customdocumentenrichmentconfiguration.html#cfn-kendra-datasource-customdocumentenrichmentconfiguration-inlineconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InlineCustomDocumentEnrichmentConfiguration
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.InlineCustomDocumentEnrichmentConfiguration> InlineConfigurations { get; set; }
            /// <summary>
            /// PreExtractionHookConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-customdocumentenrichmentconfiguration.html#cfn-kendra-datasource-customdocumentenrichmentconfiguration-preextractionhookconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HookConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.HookConfiguration PreExtractionHookConfiguration { get; set; }
            /// <summary>
            /// PostExtractionHookConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-customdocumentenrichmentconfiguration.html#cfn-kendra-datasource-customdocumentenrichmentconfiguration-postextractionhookconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HookConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.HookConfiguration PostExtractionHookConfiguration { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-customdocumentenrichmentconfiguration.html#cfn-kendra-datasource-customdocumentenrichmentconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class DataSourceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GoogleDriveConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourceconfiguration.html#cfn-kendra-datasource-datasourceconfiguration-googledriveconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GoogleDriveConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.GoogleDriveConfiguration GoogleDriveConfiguration { get; set; }
            /// <summary>
            /// WebCrawlerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourceconfiguration.html#cfn-kendra-datasource-datasourceconfiguration-webcrawlerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WebCrawlerConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.WebCrawlerConfiguration WebCrawlerConfiguration { get; set; }
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourceconfiguration.html#cfn-kendra-datasource-datasourceconfiguration-s3configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3DataSourceConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.S3DataSourceConfiguration S3Configuration { get; set; }
            /// <summary>
            /// SalesforceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourceconfiguration.html#cfn-kendra-datasource-datasourceconfiguration-salesforceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.SalesforceConfiguration SalesforceConfiguration { get; set; }
            /// <summary>
            /// DatabaseConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourceconfiguration.html#cfn-kendra-datasource-datasourceconfiguration-databaseconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatabaseConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.DatabaseConfiguration DatabaseConfiguration { get; set; }
            /// <summary>
            /// SharePointConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourceconfiguration.html#cfn-kendra-datasource-datasourceconfiguration-sharepointconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SharePointConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.SharePointConfiguration SharePointConfiguration { get; set; }
            /// <summary>
            /// ConfluenceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourceconfiguration.html#cfn-kendra-datasource-datasourceconfiguration-confluenceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfluenceConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.ConfluenceConfiguration ConfluenceConfiguration { get; set; }
            /// <summary>
            /// WorkDocsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourceconfiguration.html#cfn-kendra-datasource-datasourceconfiguration-workdocsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WorkDocsConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.WorkDocsConfiguration WorkDocsConfiguration { get; set; }
            /// <summary>
            /// OneDriveConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourceconfiguration.html#cfn-kendra-datasource-datasourceconfiguration-onedriveconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OneDriveConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.OneDriveConfiguration OneDriveConfiguration { get; set; }
            /// <summary>
            /// ServiceNowConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourceconfiguration.html#cfn-kendra-datasource-datasourceconfiguration-servicenowconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceNowConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.ServiceNowConfiguration ServiceNowConfiguration { get; set; }
        }

        public class DataSourceToIndexFieldMapping : Humidifier.Base.BaseSubResource, IHaveDateFieldFormat, IHaveIndexFieldName, IHaveDataSourceFieldName
        {
            /// <summary>
            /// DateFieldFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourcetoindexfieldmapping.html#cfn-kendra-datasource-datasourcetoindexfieldmapping-datefieldformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateFieldFormat { get; set; }
            /// <summary>
            /// IndexFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourcetoindexfieldmapping.html#cfn-kendra-datasource-datasourcetoindexfieldmapping-indexfieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexFieldName { get; set; }
            /// <summary>
            /// DataSourceFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourcetoindexfieldmapping.html#cfn-kendra-datasource-datasourcetoindexfieldmapping-datasourcefieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSourceFieldName { get; set; }
        }

        public class DataSourceVpcConfiguration : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds
        {
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourcevpcconfiguration.html#cfn-kendra-datasource-datasourcevpcconfiguration-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourcevpcconfiguration.html#cfn-kendra-datasource-datasourcevpcconfiguration-securitygroupids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }

        public class DatabaseConfiguration : Humidifier.Base.BaseSubResource, IHaveKendraDataSourceTypesDataSourceVpcConfigurationVpcConfiguration
        {
            /// <summary>
            /// SqlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-databaseconfiguration.html#cfn-kendra-datasource-databaseconfiguration-sqlconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SqlConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.SqlConfiguration SqlConfiguration { get; set; }
            /// <summary>
            /// DatabaseEngineType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-databaseconfiguration.html#cfn-kendra-datasource-databaseconfiguration-databaseenginetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseEngineType { get; set; }
            /// <summary>
            /// ConnectionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-databaseconfiguration.html#cfn-kendra-datasource-databaseconfiguration-connectionconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConnectionConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.ConnectionConfiguration ConnectionConfiguration { get; set; }
            /// <summary>
            /// ColumnConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-databaseconfiguration.html#cfn-kendra-datasource-databaseconfiguration-columnconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.ColumnConfiguration ColumnConfiguration { get; set; }
            /// <summary>
            /// VpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-databaseconfiguration.html#cfn-kendra-datasource-databaseconfiguration-vpcconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSourceVpcConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration VpcConfiguration { get; set; }
            /// <summary>
            /// AclConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-databaseconfiguration.html#cfn-kendra-datasource-databaseconfiguration-aclconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AclConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.AclConfiguration AclConfiguration { get; set; }
        }

        public class DocumentAttributeCondition : Humidifier.Base.BaseSubResource, IHaveOperator
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributecondition.html#cfn-kendra-datasource-documentattributecondition-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// ConditionDocumentAttributeKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributecondition.html#cfn-kendra-datasource-documentattributecondition-conditiondocumentattributekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConditionDocumentAttributeKey { get; set; }
            /// <summary>
            /// ConditionOnValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributecondition.html#cfn-kendra-datasource-documentattributecondition-conditiononvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeValue
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue ConditionOnValue { get; set; }
        }

        public class DocumentAttributeTarget : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetDocumentAttributeKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributetarget.html#cfn-kendra-datasource-documentattributetarget-targetdocumentattributekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetDocumentAttributeKey { get; set; }
            /// <summary>
            /// TargetDocumentAttributeValueDeletion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributetarget.html#cfn-kendra-datasource-documentattributetarget-targetdocumentattributevaluedeletion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic TargetDocumentAttributeValueDeletion { get; set; }
            /// <summary>
            /// TargetDocumentAttributeValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributetarget.html#cfn-kendra-datasource-documentattributetarget-targetdocumentattributevalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeValue
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue TargetDocumentAttributeValue { get; set; }
        }

        public class DocumentAttributeValue : Humidifier.Base.BaseSubResource, IHaveStringValue, IHaveLongValue
        {
            /// <summary>
            /// DateValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributevalue.html#cfn-kendra-datasource-documentattributevalue-datevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateValue { get; set; }
            /// <summary>
            /// LongValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributevalue.html#cfn-kendra-datasource-documentattributevalue-longvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic LongValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributevalue.html#cfn-kendra-datasource-documentattributevalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StringValue { get; set; }
            /// <summary>
            /// StringListValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributevalue.html#cfn-kendra-datasource-documentattributevalue-stringlistvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StringListValue { get; set; }
        }

        public class DocumentsMetadataConfiguration : Humidifier.Base.BaseSubResource, IHaveS3Prefix
        {
            /// <summary>
            /// S3Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentsmetadataconfiguration.html#cfn-kendra-datasource-documentsmetadataconfiguration-s3prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Prefix { get; set; }
        }

        public class GoogleDriveConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveInclusionPatterns, IHaveExclusionPatterns
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-googledriveconfiguration.html#cfn-kendra-datasource-googledriveconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// ExcludeSharedDrives
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-googledriveconfiguration.html#cfn-kendra-datasource-googledriveconfiguration-excludeshareddrives
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludeSharedDrives { get; set; }
            /// <summary>
            /// ExcludeUserAccounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-googledriveconfiguration.html#cfn-kendra-datasource-googledriveconfiguration-excludeuseraccounts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludeUserAccounts { get; set; }
            /// <summary>
            /// InclusionPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-googledriveconfiguration.html#cfn-kendra-datasource-googledriveconfiguration-inclusionpatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InclusionPatterns { get; set; }
            /// <summary>
            /// ExcludeMimeTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-googledriveconfiguration.html#cfn-kendra-datasource-googledriveconfiguration-excludemimetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludeMimeTypes { get; set; }
            /// <summary>
            /// FieldMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-googledriveconfiguration.html#cfn-kendra-datasource-googledriveconfiguration-fieldmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSourceToIndexFieldMapping
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.DataSourceToIndexFieldMapping> FieldMappings { get; set; }
            /// <summary>
            /// ExclusionPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-googledriveconfiguration.html#cfn-kendra-datasource-googledriveconfiguration-exclusionpatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExclusionPatterns { get; set; }
        }

        public class HookConfiguration : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveLambdaArn
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-hookconfiguration.html#cfn-kendra-datasource-hookconfiguration-s3bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Bucket { get; set; }
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-hookconfiguration.html#cfn-kendra-datasource-hookconfiguration-lambdaarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaArn { get; set; }
            /// <summary>
            /// InvocationCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-hookconfiguration.html#cfn-kendra-datasource-hookconfiguration-invocationcondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeCondition
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.DocumentAttributeCondition InvocationCondition { get; set; }
        }

        public class InlineCustomDocumentEnrichmentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-inlinecustomdocumentenrichmentconfiguration.html#cfn-kendra-datasource-inlinecustomdocumentenrichmentconfiguration-condition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeCondition
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.DocumentAttributeCondition Condition { get; set; }
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-inlinecustomdocumentenrichmentconfiguration.html#cfn-kendra-datasource-inlinecustomdocumentenrichmentconfiguration-target
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeTarget
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.DocumentAttributeTarget Target { get; set; }
            /// <summary>
            /// DocumentContentDeletion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-inlinecustomdocumentenrichmentconfiguration.html#cfn-kendra-datasource-inlinecustomdocumentenrichmentconfiguration-documentcontentdeletion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DocumentContentDeletion { get; set; }
        }

        public class OneDriveConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveInclusionPatterns, IHaveExclusionPatterns
        {
            /// <summary>
            /// TenantDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-onedriveconfiguration.html#cfn-kendra-datasource-onedriveconfiguration-tenantdomain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TenantDomain { get; set; }
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-onedriveconfiguration.html#cfn-kendra-datasource-onedriveconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// DisableLocalGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-onedriveconfiguration.html#cfn-kendra-datasource-onedriveconfiguration-disablelocalgroups
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DisableLocalGroups { get; set; }
            /// <summary>
            /// OneDriveUsers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-onedriveconfiguration.html#cfn-kendra-datasource-onedriveconfiguration-onedriveusers
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OneDriveUsers
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.OneDriveUsers OneDriveUsers { get; set; }
            /// <summary>
            /// InclusionPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-onedriveconfiguration.html#cfn-kendra-datasource-onedriveconfiguration-inclusionpatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InclusionPatterns { get; set; }
            /// <summary>
            /// FieldMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-onedriveconfiguration.html#cfn-kendra-datasource-onedriveconfiguration-fieldmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSourceToIndexFieldMapping
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.DataSourceToIndexFieldMapping> FieldMappings { get; set; }
            /// <summary>
            /// ExclusionPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-onedriveconfiguration.html#cfn-kendra-datasource-onedriveconfiguration-exclusionpatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExclusionPatterns { get; set; }
        }

        public class OneDriveUsers : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OneDriveUserList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-onedriveusers.html#cfn-kendra-datasource-onedriveusers-onedriveuserlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic OneDriveUserList { get; set; }
            /// <summary>
            /// OneDriveUserS3Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-onedriveusers.html#cfn-kendra-datasource-onedriveusers-onedriveusers3path
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Path
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.S3Path OneDriveUserS3Path { get; set; }
        }

        public class ProxyConfiguration : Humidifier.Base.BaseSubResource, IHavePort, IHaveHost, IHaveCredentials
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-proxyconfiguration.html#cfn-kendra-datasource-proxyconfiguration-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-proxyconfiguration.html#cfn-kendra-datasource-proxyconfiguration-host
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Host { get; set; }
            /// <summary>
            /// Credentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-proxyconfiguration.html#cfn-kendra-datasource-proxyconfiguration-credentials
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Credentials { get; set; }
        }

        public class S3DataSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveInclusionPatterns, IHaveExclusionPatterns
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-s3datasourceconfiguration.html#cfn-kendra-datasource-s3datasourceconfiguration-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// InclusionPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-s3datasourceconfiguration.html#cfn-kendra-datasource-s3datasourceconfiguration-inclusionpatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InclusionPatterns { get; set; }
            /// <summary>
            /// InclusionPrefixes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-s3datasourceconfiguration.html#cfn-kendra-datasource-s3datasourceconfiguration-inclusionprefixes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InclusionPrefixes { get; set; }
            /// <summary>
            /// AccessControlListConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-s3datasourceconfiguration.html#cfn-kendra-datasource-s3datasourceconfiguration-accesscontrollistconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AccessControlListConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.AccessControlListConfiguration AccessControlListConfiguration { get; set; }
            /// <summary>
            /// ExclusionPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-s3datasourceconfiguration.html#cfn-kendra-datasource-s3datasourceconfiguration-exclusionpatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExclusionPatterns { get; set; }
            /// <summary>
            /// DocumentsMetadataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-s3datasourceconfiguration.html#cfn-kendra-datasource-s3datasourceconfiguration-documentsmetadataconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentsMetadataConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.DocumentsMetadataConfiguration DocumentsMetadataConfiguration { get; set; }
        }

        public class S3Path : Humidifier.Base.BaseSubResource, IHaveKey, IHaveBucket
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-s3path.html#cfn-kendra-datasource-s3path-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-s3path.html#cfn-kendra-datasource-s3path-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class SalesforceChatterFeedConfiguration : Humidifier.Base.BaseSubResource, IHaveDocumentTitleFieldName, IHaveDocumentDataFieldName
        {
            /// <summary>
            /// DocumentTitleFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcechatterfeedconfiguration.html#cfn-kendra-datasource-salesforcechatterfeedconfiguration-documenttitlefieldname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentTitleFieldName { get; set; }
            /// <summary>
            /// IncludeFilterTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcechatterfeedconfiguration.html#cfn-kendra-datasource-salesforcechatterfeedconfiguration-includefiltertypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludeFilterTypes { get; set; }
            /// <summary>
            /// FieldMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcechatterfeedconfiguration.html#cfn-kendra-datasource-salesforcechatterfeedconfiguration-fieldmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSourceToIndexFieldMapping
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.DataSourceToIndexFieldMapping> FieldMappings { get; set; }
            /// <summary>
            /// DocumentDataFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcechatterfeedconfiguration.html#cfn-kendra-datasource-salesforcechatterfeedconfiguration-documentdatafieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentDataFieldName { get; set; }
        }

        public class SalesforceConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveCrawlAttachments, IHaveServerUrl, IHaveIncludeAttachmentFilePatterns, IHaveExcludeAttachmentFilePatterns
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// ServerUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-serverurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerUrl { get; set; }
            /// <summary>
            /// IncludeAttachmentFilePatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-includeattachmentfilepatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludeAttachmentFilePatterns { get; set; }
            /// <summary>
            /// StandardObjectConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-standardobjectconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SalesforceStandardObjectConfiguration
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.SalesforceStandardObjectConfiguration> StandardObjectConfigurations { get; set; }
            /// <summary>
            /// StandardObjectAttachmentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-standardobjectattachmentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceStandardObjectAttachmentConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.SalesforceStandardObjectAttachmentConfiguration StandardObjectAttachmentConfiguration { get; set; }
            /// <summary>
            /// ExcludeAttachmentFilePatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-excludeattachmentfilepatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludeAttachmentFilePatterns { get; set; }
            /// <summary>
            /// CrawlAttachments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-crawlattachments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CrawlAttachments { get; set; }
            /// <summary>
            /// ChatterFeedConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-chatterfeedconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceChatterFeedConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.SalesforceChatterFeedConfiguration ChatterFeedConfiguration { get; set; }
            /// <summary>
            /// KnowledgeArticleConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-knowledgearticleconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceKnowledgeArticleConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.SalesforceKnowledgeArticleConfiguration KnowledgeArticleConfiguration { get; set; }
        }

        public class SalesforceCustomKnowledgeArticleTypeConfiguration : Humidifier.Base.BaseSubResource, IHaveName, IHaveDocumentTitleFieldName, IHaveDocumentDataFieldName
        {
            /// <summary>
            /// DocumentTitleFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcecustomknowledgearticletypeconfiguration.html#cfn-kendra-datasource-salesforcecustomknowledgearticletypeconfiguration-documenttitlefieldname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentTitleFieldName { get; set; }
            /// <summary>
            /// FieldMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcecustomknowledgearticletypeconfiguration.html#cfn-kendra-datasource-salesforcecustomknowledgearticletypeconfiguration-fieldmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSourceToIndexFieldMapping
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.DataSourceToIndexFieldMapping> FieldMappings { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcecustomknowledgearticletypeconfiguration.html#cfn-kendra-datasource-salesforcecustomknowledgearticletypeconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// DocumentDataFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcecustomknowledgearticletypeconfiguration.html#cfn-kendra-datasource-salesforcecustomknowledgearticletypeconfiguration-documentdatafieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentDataFieldName { get; set; }
        }

        public class SalesforceKnowledgeArticleConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IncludedStates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceknowledgearticleconfiguration.html#cfn-kendra-datasource-salesforceknowledgearticleconfiguration-includedstates
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludedStates { get; set; }
            /// <summary>
            /// StandardKnowledgeArticleTypeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceknowledgearticleconfiguration.html#cfn-kendra-datasource-salesforceknowledgearticleconfiguration-standardknowledgearticletypeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceStandardKnowledgeArticleTypeConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration StandardKnowledgeArticleTypeConfiguration { get; set; }
            /// <summary>
            /// CustomKnowledgeArticleTypeConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceknowledgearticleconfiguration.html#cfn-kendra-datasource-salesforceknowledgearticleconfiguration-customknowledgearticletypeconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SalesforceCustomKnowledgeArticleTypeConfiguration
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.SalesforceCustomKnowledgeArticleTypeConfiguration> CustomKnowledgeArticleTypeConfigurations { get; set; }
        }

        public class SalesforceStandardKnowledgeArticleTypeConfiguration : Humidifier.Base.BaseSubResource, IHaveDocumentTitleFieldName, IHaveDocumentDataFieldName
        {
            /// <summary>
            /// DocumentTitleFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcestandardknowledgearticletypeconfiguration.html#cfn-kendra-datasource-salesforcestandardknowledgearticletypeconfiguration-documenttitlefieldname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentTitleFieldName { get; set; }
            /// <summary>
            /// FieldMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcestandardknowledgearticletypeconfiguration.html#cfn-kendra-datasource-salesforcestandardknowledgearticletypeconfiguration-fieldmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSourceToIndexFieldMapping
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.DataSourceToIndexFieldMapping> FieldMappings { get; set; }
            /// <summary>
            /// DocumentDataFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcestandardknowledgearticletypeconfiguration.html#cfn-kendra-datasource-salesforcestandardknowledgearticletypeconfiguration-documentdatafieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentDataFieldName { get; set; }
        }

        public class SalesforceStandardObjectAttachmentConfiguration : Humidifier.Base.BaseSubResource, IHaveDocumentTitleFieldName
        {
            /// <summary>
            /// DocumentTitleFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcestandardobjectattachmentconfiguration.html#cfn-kendra-datasource-salesforcestandardobjectattachmentconfiguration-documenttitlefieldname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentTitleFieldName { get; set; }
            /// <summary>
            /// FieldMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcestandardobjectattachmentconfiguration.html#cfn-kendra-datasource-salesforcestandardobjectattachmentconfiguration-fieldmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSourceToIndexFieldMapping
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.DataSourceToIndexFieldMapping> FieldMappings { get; set; }
        }

        public class SalesforceStandardObjectConfiguration : Humidifier.Base.BaseSubResource, IHaveName, IHaveDocumentTitleFieldName, IHaveDocumentDataFieldName
        {
            /// <summary>
            /// DocumentTitleFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcestandardobjectconfiguration.html#cfn-kendra-datasource-salesforcestandardobjectconfiguration-documenttitlefieldname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentTitleFieldName { get; set; }
            /// <summary>
            /// FieldMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcestandardobjectconfiguration.html#cfn-kendra-datasource-salesforcestandardobjectconfiguration-fieldmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSourceToIndexFieldMapping
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.DataSourceToIndexFieldMapping> FieldMappings { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcestandardobjectconfiguration.html#cfn-kendra-datasource-salesforcestandardobjectconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// DocumentDataFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcestandardobjectconfiguration.html#cfn-kendra-datasource-salesforcestandardobjectconfiguration-documentdatafieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentDataFieldName { get; set; }
        }

        public class ServiceNowConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveAuthenticationType
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowconfiguration.html#cfn-kendra-datasource-servicenowconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// HostUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowconfiguration.html#cfn-kendra-datasource-servicenowconfiguration-hosturl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostUrl { get; set; }
            /// <summary>
            /// ServiceCatalogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowconfiguration.html#cfn-kendra-datasource-servicenowconfiguration-servicecatalogconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceNowServiceCatalogConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.ServiceNowServiceCatalogConfiguration ServiceCatalogConfiguration { get; set; }
            /// <summary>
            /// ServiceNowBuildVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowconfiguration.html#cfn-kendra-datasource-servicenowconfiguration-servicenowbuildversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceNowBuildVersion { get; set; }
            /// <summary>
            /// KnowledgeArticleConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowconfiguration.html#cfn-kendra-datasource-servicenowconfiguration-knowledgearticleconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceNowKnowledgeArticleConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.ServiceNowKnowledgeArticleConfiguration KnowledgeArticleConfiguration { get; set; }
            /// <summary>
            /// AuthenticationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowconfiguration.html#cfn-kendra-datasource-servicenowconfiguration-authenticationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthenticationType { get; set; }
        }

        public class ServiceNowKnowledgeArticleConfiguration : Humidifier.Base.BaseSubResource, IHaveDocumentTitleFieldName, IHaveDocumentDataFieldName, IHaveCrawlAttachments, IHaveIncludeAttachmentFilePatterns, IHaveExcludeAttachmentFilePatterns
        {
            /// <summary>
            /// DocumentTitleFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowknowledgearticleconfiguration.html#cfn-kendra-datasource-servicenowknowledgearticleconfiguration-documenttitlefieldname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentTitleFieldName { get; set; }
            /// <summary>
            /// IncludeAttachmentFilePatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowknowledgearticleconfiguration.html#cfn-kendra-datasource-servicenowknowledgearticleconfiguration-includeattachmentfilepatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludeAttachmentFilePatterns { get; set; }
            /// <summary>
            /// ExcludeAttachmentFilePatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowknowledgearticleconfiguration.html#cfn-kendra-datasource-servicenowknowledgearticleconfiguration-excludeattachmentfilepatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludeAttachmentFilePatterns { get; set; }
            /// <summary>
            /// FilterQuery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowknowledgearticleconfiguration.html#cfn-kendra-datasource-servicenowknowledgearticleconfiguration-filterquery
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterQuery { get; set; }
            /// <summary>
            /// CrawlAttachments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowknowledgearticleconfiguration.html#cfn-kendra-datasource-servicenowknowledgearticleconfiguration-crawlattachments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CrawlAttachments { get; set; }
            /// <summary>
            /// FieldMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowknowledgearticleconfiguration.html#cfn-kendra-datasource-servicenowknowledgearticleconfiguration-fieldmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSourceToIndexFieldMapping
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.DataSourceToIndexFieldMapping> FieldMappings { get; set; }
            /// <summary>
            /// DocumentDataFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowknowledgearticleconfiguration.html#cfn-kendra-datasource-servicenowknowledgearticleconfiguration-documentdatafieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentDataFieldName { get; set; }
        }

        public class ServiceNowServiceCatalogConfiguration : Humidifier.Base.BaseSubResource, IHaveDocumentTitleFieldName, IHaveDocumentDataFieldName, IHaveCrawlAttachments, IHaveIncludeAttachmentFilePatterns, IHaveExcludeAttachmentFilePatterns
        {
            /// <summary>
            /// DocumentTitleFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowservicecatalogconfiguration.html#cfn-kendra-datasource-servicenowservicecatalogconfiguration-documenttitlefieldname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentTitleFieldName { get; set; }
            /// <summary>
            /// IncludeAttachmentFilePatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowservicecatalogconfiguration.html#cfn-kendra-datasource-servicenowservicecatalogconfiguration-includeattachmentfilepatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludeAttachmentFilePatterns { get; set; }
            /// <summary>
            /// ExcludeAttachmentFilePatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowservicecatalogconfiguration.html#cfn-kendra-datasource-servicenowservicecatalogconfiguration-excludeattachmentfilepatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludeAttachmentFilePatterns { get; set; }
            /// <summary>
            /// CrawlAttachments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowservicecatalogconfiguration.html#cfn-kendra-datasource-servicenowservicecatalogconfiguration-crawlattachments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CrawlAttachments { get; set; }
            /// <summary>
            /// FieldMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowservicecatalogconfiguration.html#cfn-kendra-datasource-servicenowservicecatalogconfiguration-fieldmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSourceToIndexFieldMapping
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.DataSourceToIndexFieldMapping> FieldMappings { get; set; }
            /// <summary>
            /// DocumentDataFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowservicecatalogconfiguration.html#cfn-kendra-datasource-servicenowservicecatalogconfiguration-documentdatafieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentDataFieldName { get; set; }
        }

        public class SharePointConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveDocumentTitleFieldName, IHaveInclusionPatterns, IHaveExclusionPatterns, IHaveCrawlAttachments, IHaveKendraDataSourceTypesDataSourceVpcConfigurationVpcConfiguration
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-sharepointconfiguration.html#cfn-kendra-datasource-sharepointconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// DocumentTitleFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-sharepointconfiguration.html#cfn-kendra-datasource-sharepointconfiguration-documenttitlefieldname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentTitleFieldName { get; set; }
            /// <summary>
            /// SslCertificateS3Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-sharepointconfiguration.html#cfn-kendra-datasource-sharepointconfiguration-sslcertificates3path
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Path
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.S3Path SslCertificateS3Path { get; set; }
            /// <summary>
            /// DisableLocalGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-sharepointconfiguration.html#cfn-kendra-datasource-sharepointconfiguration-disablelocalgroups
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DisableLocalGroups { get; set; }
            /// <summary>
            /// CrawlAttachments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-sharepointconfiguration.html#cfn-kendra-datasource-sharepointconfiguration-crawlattachments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CrawlAttachments { get; set; }
            /// <summary>
            /// InclusionPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-sharepointconfiguration.html#cfn-kendra-datasource-sharepointconfiguration-inclusionpatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InclusionPatterns { get; set; }
            /// <summary>
            /// VpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-sharepointconfiguration.html#cfn-kendra-datasource-sharepointconfiguration-vpcconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSourceVpcConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration VpcConfiguration { get; set; }
            /// <summary>
            /// Urls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-sharepointconfiguration.html#cfn-kendra-datasource-sharepointconfiguration-urls
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Urls { get; set; }
            /// <summary>
            /// UseChangeLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-sharepointconfiguration.html#cfn-kendra-datasource-sharepointconfiguration-usechangelog
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic UseChangeLog { get; set; }
            /// <summary>
            /// FieldMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-sharepointconfiguration.html#cfn-kendra-datasource-sharepointconfiguration-fieldmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSourceToIndexFieldMapping
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.DataSourceToIndexFieldMapping> FieldMappings { get; set; }
            /// <summary>
            /// ExclusionPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-sharepointconfiguration.html#cfn-kendra-datasource-sharepointconfiguration-exclusionpatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExclusionPatterns { get; set; }
            /// <summary>
            /// SharePointVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-sharepointconfiguration.html#cfn-kendra-datasource-sharepointconfiguration-sharepointversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SharePointVersion { get; set; }
        }

        public class SqlConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// QueryIdentifiersEnclosingOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-sqlconfiguration.html#cfn-kendra-datasource-sqlconfiguration-queryidentifiersenclosingoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueryIdentifiersEnclosingOption { get; set; }
        }

        public class WebCrawlerAuthenticationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BasicAuthentication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlerauthenticationconfiguration.html#cfn-kendra-datasource-webcrawlerauthenticationconfiguration-basicauthentication
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WebCrawlerBasicAuthentication
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.WebCrawlerBasicAuthentication> BasicAuthentication { get; set; }
        }

        public class WebCrawlerBasicAuthentication : Humidifier.Base.BaseSubResource, IHavePort, IHaveHost, IHaveCredentials
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlerbasicauthentication.html#cfn-kendra-datasource-webcrawlerbasicauthentication-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlerbasicauthentication.html#cfn-kendra-datasource-webcrawlerbasicauthentication-host
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Host { get; set; }
            /// <summary>
            /// Credentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlerbasicauthentication.html#cfn-kendra-datasource-webcrawlerbasicauthentication-credentials
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Credentials { get; set; }
        }

        public class WebCrawlerConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuthenticationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlerconfiguration.html#cfn-kendra-datasource-webcrawlerconfiguration-authenticationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WebCrawlerAuthenticationConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.WebCrawlerAuthenticationConfiguration AuthenticationConfiguration { get; set; }
            /// <summary>
            /// MaxLinksPerPage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlerconfiguration.html#cfn-kendra-datasource-webcrawlerconfiguration-maxlinksperpage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxLinksPerPage { get; set; }
            /// <summary>
            /// ProxyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlerconfiguration.html#cfn-kendra-datasource-webcrawlerconfiguration-proxyconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProxyConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.ProxyConfiguration ProxyConfiguration { get; set; }
            /// <summary>
            /// UrlExclusionPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlerconfiguration.html#cfn-kendra-datasource-webcrawlerconfiguration-urlexclusionpatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic UrlExclusionPatterns { get; set; }
            /// <summary>
            /// MaxUrlsPerMinuteCrawlRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlerconfiguration.html#cfn-kendra-datasource-webcrawlerconfiguration-maxurlsperminutecrawlrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxUrlsPerMinuteCrawlRate { get; set; }
            /// <summary>
            /// UrlInclusionPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlerconfiguration.html#cfn-kendra-datasource-webcrawlerconfiguration-urlinclusionpatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic UrlInclusionPatterns { get; set; }
            /// <summary>
            /// Urls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlerconfiguration.html#cfn-kendra-datasource-webcrawlerconfiguration-urls
            /// Required: True
            /// UpdateType: Mutable
            /// Type: WebCrawlerUrls
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.WebCrawlerUrls Urls { get; set; }
            /// <summary>
            /// MaxContentSizePerPageInMegaBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlerconfiguration.html#cfn-kendra-datasource-webcrawlerconfiguration-maxcontentsizeperpageinmegabytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxContentSizePerPageInMegaBytes { get; set; }
            /// <summary>
            /// CrawlDepth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlerconfiguration.html#cfn-kendra-datasource-webcrawlerconfiguration-crawldepth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CrawlDepth { get; set; }
        }

        public class WebCrawlerSeedUrlConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WebCrawlerMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlerseedurlconfiguration.html#cfn-kendra-datasource-webcrawlerseedurlconfiguration-webcrawlermode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WebCrawlerMode { get; set; }
            /// <summary>
            /// SeedUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlerseedurlconfiguration.html#cfn-kendra-datasource-webcrawlerseedurlconfiguration-seedurls
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SeedUrls { get; set; }
        }

        public class WebCrawlerSiteMapsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SiteMaps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlersitemapsconfiguration.html#cfn-kendra-datasource-webcrawlersitemapsconfiguration-sitemaps
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SiteMaps { get; set; }
        }

        public class WebCrawlerUrls : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SiteMapsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlerurls.html#cfn-kendra-datasource-webcrawlerurls-sitemapsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WebCrawlerSiteMapsConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.WebCrawlerSiteMapsConfiguration SiteMapsConfiguration { get; set; }
            /// <summary>
            /// SeedUrlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-webcrawlerurls.html#cfn-kendra-datasource-webcrawlerurls-seedurlconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WebCrawlerSeedUrlConfiguration
            /// </summary>
            public Humidifier.Kendra.DataSourceTypes.WebCrawlerSeedUrlConfiguration SeedUrlConfiguration { get; set; }
        }

        public class WorkDocsConfiguration : Humidifier.Base.BaseSubResource, IHaveInclusionPatterns, IHaveExclusionPatterns
        {
            /// <summary>
            /// CrawlComments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-workdocsconfiguration.html#cfn-kendra-datasource-workdocsconfiguration-crawlcomments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CrawlComments { get; set; }
            /// <summary>
            /// OrganizationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-workdocsconfiguration.html#cfn-kendra-datasource-workdocsconfiguration-organizationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OrganizationId { get; set; }
            /// <summary>
            /// InclusionPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-workdocsconfiguration.html#cfn-kendra-datasource-workdocsconfiguration-inclusionpatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InclusionPatterns { get; set; }
            /// <summary>
            /// UseChangeLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-workdocsconfiguration.html#cfn-kendra-datasource-workdocsconfiguration-usechangelog
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic UseChangeLog { get; set; }
            /// <summary>
            /// FieldMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-workdocsconfiguration.html#cfn-kendra-datasource-workdocsconfiguration-fieldmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSourceToIndexFieldMapping
            /// </summary>
            public List<Humidifier.Kendra.DataSourceTypes.DataSourceToIndexFieldMapping> FieldMappings { get; set; }
            /// <summary>
            /// ExclusionPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-workdocsconfiguration.html#cfn-kendra-datasource-workdocsconfiguration-exclusionpatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExclusionPatterns { get; set; }
        }
    }
}