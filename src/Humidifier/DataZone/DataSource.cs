namespace Humidifier.DataZone
{
    using System.Collections.Generic;
    using DataSourceTypes;

    public class DataSource : Humidifier.Resource, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string EnvironmentId =  "EnvironmentId" ;
            public static string DomainId =  "DomainId" ;
            public static string LastRunAssetCount =  "LastRunAssetCount" ;
            public static string LastRunAt =  "LastRunAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ProjectId =  "ProjectId" ;
            public static string LastRunStatus =  "LastRunStatus" ;
            public static string Id =  "Id" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::DataZone::DataSource";
            }
        }

        /// <summary>
        /// ProjectIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-projectidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProjectIdentifier { get; set; }
        /// <summary>
        /// PublishOnImport
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-publishonimport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic PublishOnImport { get; set; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// EnvironmentIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-environmentidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EnvironmentIdentifier { get; set; }
        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-configuration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSourceConfigurationInput
        /// </summary>
        public DataSourceConfigurationInput Configuration { get; set; }
        /// <summary>
        /// AssetFormsInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-assetformsinput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FormInput
        /// </summary>
        public List<FormInput> AssetFormsInput { get; set; }
        /// <summary>
        /// EnableSetting
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-enablesetting
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EnableSetting { get; set; }
        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-schedule
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ScheduleConfiguration
        /// </summary>
        public ScheduleConfiguration Schedule { get; set; }
        /// <summary>
        /// Recommendation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-recommendation
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RecommendationConfiguration
        /// </summary>
        public RecommendationConfiguration Recommendation { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-name
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DomainIdentifier { get; set; }
    }

    namespace DataSourceTypes
    {
        public class DataSourceConfigurationInput
        {
            /// <summary>
            /// RedshiftRunConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-datasourceconfigurationinput.html#cfn-datazone-datasource-datasourceconfigurationinput-redshiftrunconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftRunConfigurationInput
            /// </summary>
            public RedshiftRunConfigurationInput RedshiftRunConfiguration { get; set; }
            /// <summary>
            /// GlueRunConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-datasourceconfigurationinput.html#cfn-datazone-datasource-datasourceconfigurationinput-gluerunconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlueRunConfigurationInput
            /// </summary>
            public GlueRunConfigurationInput GlueRunConfiguration { get; set; }
        }

        public class FilterExpression
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-filterexpression.html#cfn-datazone-datasource-filterexpression-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-filterexpression.html#cfn-datazone-datasource-filterexpression-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
        }

        public class FormInput
        {
            /// <summary>
            /// TypeIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-forminput.html#cfn-datazone-datasource-forminput-typeidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TypeIdentifier { get; set; }
            /// <summary>
            /// TypeRevision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-forminput.html#cfn-datazone-datasource-forminput-typerevision
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TypeRevision { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-forminput.html#cfn-datazone-datasource-forminput-content
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Content { get; set; }
            /// <summary>
            /// FormName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-forminput.html#cfn-datazone-datasource-forminput-formname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FormName { get; set; }
        }

        public class GlueRunConfigurationInput
        {
            /// <summary>
            /// DataAccessRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-gluerunconfigurationinput.html#cfn-datazone-datasource-gluerunconfigurationinput-dataaccessrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataAccessRole { get; set; }
            /// <summary>
            /// AutoImportDataQualityResult
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-gluerunconfigurationinput.html#cfn-datazone-datasource-gluerunconfigurationinput-autoimportdataqualityresult
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AutoImportDataQualityResult { get; set; }
            /// <summary>
            /// RelationalFilterConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-gluerunconfigurationinput.html#cfn-datazone-datasource-gluerunconfigurationinput-relationalfilterconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RelationalFilterConfiguration
            /// </summary>
            public List<RelationalFilterConfiguration> RelationalFilterConfigurations { get; set; }
        }

        public class RecommendationConfiguration
        {
            /// <summary>
            /// EnableBusinessNameGeneration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-recommendationconfiguration.html#cfn-datazone-datasource-recommendationconfiguration-enablebusinessnamegeneration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableBusinessNameGeneration { get; set; }
        }

        public class RedshiftClusterStorage
        {
            /// <summary>
            /// ClusterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftclusterstorage.html#cfn-datazone-datasource-redshiftclusterstorage-clustername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClusterName { get; set; }
        }

        public class RedshiftCredentialConfiguration
        {
            /// <summary>
            /// SecretManagerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftcredentialconfiguration.html#cfn-datazone-datasource-redshiftcredentialconfiguration-secretmanagerarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretManagerArn { get; set; }
        }

        public class RedshiftRunConfigurationInput
        {
            /// <summary>
            /// DataAccessRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftrunconfigurationinput.html#cfn-datazone-datasource-redshiftrunconfigurationinput-dataaccessrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataAccessRole { get; set; }
            /// <summary>
            /// RelationalFilterConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftrunconfigurationinput.html#cfn-datazone-datasource-redshiftrunconfigurationinput-relationalfilterconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RelationalFilterConfiguration
            /// </summary>
            public List<RelationalFilterConfiguration> RelationalFilterConfigurations { get; set; }
            /// <summary>
            /// RedshiftCredentialConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftrunconfigurationinput.html#cfn-datazone-datasource-redshiftrunconfigurationinput-redshiftcredentialconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RedshiftCredentialConfiguration
            /// </summary>
            public RedshiftCredentialConfiguration RedshiftCredentialConfiguration { get; set; }
            /// <summary>
            /// RedshiftStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftrunconfigurationinput.html#cfn-datazone-datasource-redshiftrunconfigurationinput-redshiftstorage
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RedshiftStorage
            /// </summary>
            public RedshiftStorage RedshiftStorage { get; set; }
        }

        public class RedshiftServerlessStorage
        {
            /// <summary>
            /// WorkgroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftserverlessstorage.html#cfn-datazone-datasource-redshiftserverlessstorage-workgroupname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WorkgroupName { get; set; }
        }

        public class RedshiftStorage
        {
            /// <summary>
            /// RedshiftClusterSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftstorage.html#cfn-datazone-datasource-redshiftstorage-redshiftclustersource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftClusterStorage
            /// </summary>
            public RedshiftClusterStorage RedshiftClusterSource { get; set; }
            /// <summary>
            /// RedshiftServerlessSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftstorage.html#cfn-datazone-datasource-redshiftstorage-redshiftserverlesssource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftServerlessStorage
            /// </summary>
            public RedshiftServerlessStorage RedshiftServerlessSource { get; set; }
        }

        public class RelationalFilterConfiguration
        {
            /// <summary>
            /// FilterExpressions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-relationalfilterconfiguration.html#cfn-datazone-datasource-relationalfilterconfiguration-filterexpressions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterExpression
            /// </summary>
            public List<FilterExpression> FilterExpressions { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-relationalfilterconfiguration.html#cfn-datazone-datasource-relationalfilterconfiguration-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// SchemaName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-relationalfilterconfiguration.html#cfn-datazone-datasource-relationalfilterconfiguration-schemaname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SchemaName { get; set; }
        }

        public class ScheduleConfiguration
        {
            /// <summary>
            /// Timezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-scheduleconfiguration.html#cfn-datazone-datasource-scheduleconfiguration-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Timezone { get; set; }
            /// <summary>
            /// Schedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-scheduleconfiguration.html#cfn-datazone-datasource-scheduleconfiguration-schedule
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Schedule { get; set; }
        }
    }
}