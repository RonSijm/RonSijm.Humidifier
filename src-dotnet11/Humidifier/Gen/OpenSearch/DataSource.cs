namespace Humidifier.OpenSearch
{
    using global::System.Collections.Generic;
    using DataSourceTypes;

    public class DataSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveDomainName, IHaveOpenSearchDataSourceTypesDataSourceTypeDataSourceType, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.OpenSearch.DataSource; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearch-datasource.html#cfn-opensearch-datasource-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearch-datasource.html#cfn-opensearch-datasource-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainName { get; set; }

        /// <summary>
        /// DataSourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearch-datasource.html#cfn-opensearch-datasource-datasourcetype
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataSourceType
        /// </summary>
        [Required]
        public Union<Humidifier.OpenSearch.DataSourceTypes.DataSourceType, BaseFunction>? DataSourceType { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DataSourceTypes
    {
        public class DataSourceType : Humidifier.Base.BaseSubResource, IHaveOpenSearchDataSourceTypesS3GlueDataCatalogS3GlueDataCatalog
        {
            /// <summary>
            /// S3GlueDataCatalog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearch-datasource-datasourcetype.html#cfn-opensearch-datasource-datasourcetype-s3gluedatacatalog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3GlueDataCatalog
            /// </summary>
            public Union<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog, BaseFunction>? S3GlueDataCatalog { get; set; }
        }

        public class S3GlueDataCatalog : Humidifier.Base.BaseSubResource, IHaveRoleArn
        {
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearch-datasource-s3gluedatacatalog.html#cfn-opensearch-datasource-s3gluedatacatalog-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }
    }
}