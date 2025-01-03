namespace Humidifier.OpenSearchService
{
    using System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveEndpoint
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.OpenSearchService.Application; }
        /// <summary>
        /// DataSources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-application.html#cfn-opensearchservice-application-datasources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DataSource
        /// </summary>
        public List<Humidifier.OpenSearchService.ApplicationTypes.DataSource> DataSources { get; set; }
        /// <summary>
        /// AppConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-application.html#cfn-opensearchservice-application-appconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AppConfig
        /// </summary>
        public List<Humidifier.OpenSearchService.ApplicationTypes.AppConfig> AppConfigs { get; set; }
        /// <summary>
        /// Endpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-application.html#cfn-opensearchservice-application-endpoint
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Endpoint { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-application.html#cfn-opensearchservice-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// IamIdentityCenterOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-application.html#cfn-opensearchservice-application-iamidentitycenteroptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IamIdentityCenterOptions
        /// </summary>
        public Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions IamIdentityCenterOptions { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ApplicationTypes
    {
        public class AppConfig : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-application-appconfig.html#cfn-opensearchservice-application-appconfig-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-application-appconfig.html#cfn-opensearchservice-application-appconfig-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class DataSource : Humidifier.Base.BaseSubResource, IHaveDataSourceArn
        {
            /// <summary>
            /// DataSourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-application-datasource.html#cfn-opensearchservice-application-datasource-datasourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSourceArn { get; set; }
            /// <summary>
            /// DataSourceDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-application-datasource.html#cfn-opensearchservice-application-datasource-datasourcedescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSourceDescription { get; set; }
        }

        public class IamIdentityCenterOptions : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// IamIdentityCenterInstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-application-iamidentitycenteroptions.html#cfn-opensearchservice-application-iamidentitycenteroptions-iamidentitycenterinstancearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IamIdentityCenterInstanceArn { get; set; }
            /// <summary>
            /// IamRoleForIdentityCenterApplicationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-application-iamidentitycenteroptions.html#cfn-opensearchservice-application-iamidentitycenteroptions-iamroleforidentitycenterapplicationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IamRoleForIdentityCenterApplicationArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-application-iamidentitycenteroptions.html#cfn-opensearchservice-application-iamidentitycenteroptions-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }
    }
}