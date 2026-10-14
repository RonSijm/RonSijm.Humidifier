namespace Humidifier.OpenSearch
{
    using global::System.Collections.Generic;
    using DataSourceTypes;

    public class DataSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveDomainName
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
        public dynamic Description { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearch-datasource.html#cfn-opensearch-datasource-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainName { get; set; }

        /// <summary>
        /// DataSourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearch-datasource.html#cfn-opensearch-datasource-datasourcetype
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataSourceType
        /// </summary>
        [Required]
        public Humidifier.OpenSearch.DataSourceTypes.DataSourceType DataSourceType { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace DataSourceTypes
    {
        public class DataSourceType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3GlueDataCatalog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearch-datasource-datasourcetype.html#cfn-opensearch-datasource-datasourcetype-s3gluedatacatalog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3GlueDataCatalog
            /// </summary>
            public Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog S3GlueDataCatalog { get; set; }
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
            public dynamic RoleArn { get; set; }
        }
    }
}