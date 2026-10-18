namespace Humidifier.OpenSearchService
{
    using global::System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfOpenSearchServiceApplicationTypesDataSourceDataSources, IHaveListOfOpenSearchServiceApplicationTypesAppConfigAppConfigs, IHaveEndpoint, IHaveKmsKeyArn, IHaveOpenSearchServiceApplicationTypesIamIdentityCenterOptionsIamIdentityCenterOptions, IHaveName
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
        public Union<IReadOnlyList<Humidifier.OpenSearchService.ApplicationTypes.DataSource>, IReadOnlyList<Union<Humidifier.OpenSearchService.ApplicationTypes.DataSource, BaseFunction>>, BaseFunction>? DataSources { get; set; }
        /// <summary>
        /// AppConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-application.html#cfn-opensearchservice-application-appconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AppConfig
        /// </summary>
        public Union<IReadOnlyList<Humidifier.OpenSearchService.ApplicationTypes.AppConfig>, IReadOnlyList<Union<Humidifier.OpenSearchService.ApplicationTypes.AppConfig, BaseFunction>>, BaseFunction>? AppConfigs { get; set; }
        /// <summary>
        /// Endpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-application.html#cfn-opensearchservice-application-endpoint
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Endpoint { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-application.html#cfn-opensearchservice-application-kmskeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-application.html#cfn-opensearchservice-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// IamIdentityCenterOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-application.html#cfn-opensearchservice-application-iamidentitycenteroptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IamIdentityCenterOptions
        /// </summary>
        public Union<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions, BaseFunction>? IamIdentityCenterOptions { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
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
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-application-appconfig.html#cfn-opensearchservice-application-appconfig-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class DataSource : Humidifier.Base.BaseSubResource, IHaveDataSourceArn, IHaveDataSourceDescription
        {
            /// <summary>
            /// DataSourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-application-datasource.html#cfn-opensearchservice-application-datasource-datasourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSourceArn { get; set; }
            /// <summary>
            /// DataSourceDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-application-datasource.html#cfn-opensearchservice-application-datasource-datasourcedescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSourceDescription { get; set; }
        }

        public class IamIdentityCenterOptions : Humidifier.Base.BaseSubResource, IHaveIamIdentityCenterInstanceArn, IHaveIamRoleForIdentityCenterApplicationArn, IHaveEnabled_Boolean
        {
            /// <summary>
            /// IamIdentityCenterInstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-application-iamidentitycenteroptions.html#cfn-opensearchservice-application-iamidentitycenteroptions-iamidentitycenterinstancearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IamIdentityCenterInstanceArn { get; set; }
            /// <summary>
            /// IamRoleForIdentityCenterApplicationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-application-iamidentitycenteroptions.html#cfn-opensearchservice-application-iamidentitycenteroptions-iamroleforidentitycenterapplicationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IamRoleForIdentityCenterApplicationArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-application-iamidentitycenteroptions.html#cfn-opensearchservice-application-iamidentitycenteroptions-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }
    }
}