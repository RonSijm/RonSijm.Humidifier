namespace Humidifier.DataZone
{
    using System.Collections.Generic;
    using DataSourceTypes;

    public class DataSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveType, IHaveDomainIdentifier, IHaveEnvironmentIdentifier, IHaveProjectIdentifier
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

        public override string AWSTypeName { get => AWS.DataZone.DataSource; }

        /// <summary>
        /// ProjectIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-projectidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
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
        [Required]
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
        [Required]
        public dynamic EnvironmentIdentifier { get; set; }
        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-configuration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSourceConfigurationInput
        /// </summary>
        public Humidifier.DataZone.DataSourceTypes.DataSourceConfigurationInput Configuration { get; set; }
        /// <summary>
        /// AssetFormsInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-assetformsinput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FormInput
        /// </summary>
        public List<Humidifier.DataZone.DataSourceTypes.FormInput> AssetFormsInput { get; set; }
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
        public Humidifier.DataZone.DataSourceTypes.ScheduleConfiguration Schedule { get; set; }
        /// <summary>
        /// Recommendation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-recommendation
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RecommendationConfiguration
        /// </summary>
        public Humidifier.DataZone.DataSourceTypes.RecommendationConfiguration Recommendation { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainIdentifier { get; set; }
    }

    namespace DataSourceTypes
    {
        public class DataSourceConfigurationInput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RedshiftRunConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-datasourceconfigurationinput.html#cfn-datazone-datasource-datasourceconfigurationinput-redshiftrunconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftRunConfigurationInput
            /// </summary>
            public Humidifier.DataZone.DataSourceTypes.RedshiftRunConfigurationInput RedshiftRunConfiguration { get; set; }
            /// <summary>
            /// GlueRunConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-datasourceconfigurationinput.html#cfn-datazone-datasource-datasourceconfigurationinput-gluerunconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlueRunConfigurationInput
            /// </summary>
            public Humidifier.DataZone.DataSourceTypes.GlueRunConfigurationInput GlueRunConfiguration { get; set; }
            /// <summary>
            /// SageMakerRunConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-datasourceconfigurationinput.html#cfn-datazone-datasource-datasourceconfigurationinput-sagemakerrunconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SageMakerRunConfigurationInput
            /// </summary>
            public Humidifier.DataZone.DataSourceTypes.SageMakerRunConfigurationInput SageMakerRunConfiguration { get; set; }
        }

        public class FilterExpression : Humidifier.Base.BaseSubResource, IHaveType, IHaveExpression
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

        public class FormInput : Humidifier.Base.BaseSubResource, IHaveContent
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

        public class GlueRunConfigurationInput : Humidifier.Base.BaseSubResource
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
            public List<Humidifier.DataZone.DataSourceTypes.RelationalFilterConfiguration> RelationalFilterConfigurations { get; set; }
        }

        public class RecommendationConfiguration : Humidifier.Base.BaseSubResource
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

        public class RedshiftClusterStorage : Humidifier.Base.BaseSubResource, IHaveClusterName
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

        public class RedshiftCredentialConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretManagerArn
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

        public class RedshiftRunConfigurationInput : Humidifier.Base.BaseSubResource
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
            public List<Humidifier.DataZone.DataSourceTypes.RelationalFilterConfiguration> RelationalFilterConfigurations { get; set; }
            /// <summary>
            /// RedshiftCredentialConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftrunconfigurationinput.html#cfn-datazone-datasource-redshiftrunconfigurationinput-redshiftcredentialconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RedshiftCredentialConfiguration
            /// </summary>
            public Humidifier.DataZone.DataSourceTypes.RedshiftCredentialConfiguration RedshiftCredentialConfiguration { get; set; }
            /// <summary>
            /// RedshiftStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftrunconfigurationinput.html#cfn-datazone-datasource-redshiftrunconfigurationinput-redshiftstorage
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RedshiftStorage
            /// </summary>
            public Humidifier.DataZone.DataSourceTypes.RedshiftStorage RedshiftStorage { get; set; }
        }

        public class RedshiftServerlessStorage : Humidifier.Base.BaseSubResource, IHaveWorkgroupName
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

        public class RedshiftStorage : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RedshiftClusterSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftstorage.html#cfn-datazone-datasource-redshiftstorage-redshiftclustersource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftClusterStorage
            /// </summary>
            public Humidifier.DataZone.DataSourceTypes.RedshiftClusterStorage RedshiftClusterSource { get; set; }
            /// <summary>
            /// RedshiftServerlessSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftstorage.html#cfn-datazone-datasource-redshiftstorage-redshiftserverlesssource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftServerlessStorage
            /// </summary>
            public Humidifier.DataZone.DataSourceTypes.RedshiftServerlessStorage RedshiftServerlessSource { get; set; }
        }

        public class RelationalFilterConfiguration : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveSchemaName
        {
            /// <summary>
            /// FilterExpressions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-relationalfilterconfiguration.html#cfn-datazone-datasource-relationalfilterconfiguration-filterexpressions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterExpression
            /// </summary>
            public List<Humidifier.DataZone.DataSourceTypes.FilterExpression> FilterExpressions { get; set; }
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

        public class SageMakerRunConfigurationInput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TrackingAssets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-sagemakerrunconfigurationinput.html#cfn-datazone-datasource-sagemakerrunconfigurationinput-trackingassets
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic TrackingAssets { get; set; }
        }

        public class ScheduleConfiguration : Humidifier.Base.BaseSubResource, IHaveTimezone, IHaveSchedule
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