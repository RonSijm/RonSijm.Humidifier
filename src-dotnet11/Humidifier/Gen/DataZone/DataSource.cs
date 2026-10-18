namespace Humidifier.DataZone
{
    using global::System.Collections.Generic;
    using DataSourceTypes;

    public class DataSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveProjectIdentifier, IHavePublishOnImport_Boolean, IHaveDescription, IHaveEnvironmentIdentifier, IHaveDataZoneDataSourceTypesDataSourceConfigurationInputConfiguration, IHaveListOfDataZoneDataSourceTypesFormInputAssetFormsInput, IHaveDataZoneDataSourceTypesRecommendationConfigurationRecommendation, IHaveName, IHaveType, IHaveEnableSetting, IHaveConnectionIdentifier, IHaveDataZoneDataSourceTypesScheduleConfigurationSchedule, IHaveDomainIdentifier
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ConnectionId =  "ConnectionId" ;
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
        public Union<string, BaseFunction>? ProjectIdentifier { get; set; }
        /// <summary>
        /// PublishOnImport
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-publishonimport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PublishOnImport { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// EnvironmentIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-environmentidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentIdentifier { get; set; }
        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-configuration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSourceConfigurationInput
        /// </summary>
        public Union<Humidifier.DataZone.DataSourceTypes.DataSourceConfigurationInput, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// AssetFormsInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-assetformsinput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FormInput
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataZone.DataSourceTypes.FormInput>, IReadOnlyList<Union<Humidifier.DataZone.DataSourceTypes.FormInput, BaseFunction>>, BaseFunction>? AssetFormsInput { get; set; }
        /// <summary>
        /// Recommendation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-recommendation
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RecommendationConfiguration
        /// </summary>
        public Union<Humidifier.DataZone.DataSourceTypes.RecommendationConfiguration, BaseFunction>? Recommendation { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// EnableSetting
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-enablesetting
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnableSetting { get; set; }
        /// <summary>
        /// ConnectionIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-connectionidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConnectionIdentifier { get; set; }
        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-schedule
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ScheduleConfiguration
        /// </summary>
        public Union<Humidifier.DataZone.DataSourceTypes.ScheduleConfiguration, BaseFunction>? Schedule { get; set; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-datasource.html#cfn-datazone-datasource-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainIdentifier { get; set; }
    }

    namespace DataSourceTypes
    {
        public class DataSourceConfigurationInput : Humidifier.Base.BaseSubResource, IHaveDataZoneDataSourceTypesRedshiftRunConfigurationInputRedshiftRunConfiguration, IHaveDataZoneDataSourceTypesGlueRunConfigurationInputGlueRunConfiguration, IHaveDataZoneDataSourceTypesSageMakerRunConfigurationInputSageMakerRunConfiguration
        {
            /// <summary>
            /// RedshiftRunConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-datasourceconfigurationinput.html#cfn-datazone-datasource-datasourceconfigurationinput-redshiftrunconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftRunConfigurationInput
            /// </summary>
            public Union<Humidifier.DataZone.DataSourceTypes.RedshiftRunConfigurationInput, BaseFunction>? RedshiftRunConfiguration { get; set; }
            /// <summary>
            /// GlueRunConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-datasourceconfigurationinput.html#cfn-datazone-datasource-datasourceconfigurationinput-gluerunconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlueRunConfigurationInput
            /// </summary>
            public Union<Humidifier.DataZone.DataSourceTypes.GlueRunConfigurationInput, BaseFunction>? GlueRunConfiguration { get; set; }
            /// <summary>
            /// SageMakerRunConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-datasourceconfigurationinput.html#cfn-datazone-datasource-datasourceconfigurationinput-sagemakerrunconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SageMakerRunConfigurationInput
            /// </summary>
            public Union<Humidifier.DataZone.DataSourceTypes.SageMakerRunConfigurationInput, BaseFunction>? SageMakerRunConfiguration { get; set; }
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
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-filterexpression.html#cfn-datazone-datasource-filterexpression-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
        }

        public class FormInput : Humidifier.Base.BaseSubResource, IHaveTypeIdentifier, IHaveTypeRevision, IHaveContent, IHaveFormName
        {
            /// <summary>
            /// TypeIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-forminput.html#cfn-datazone-datasource-forminput-typeidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TypeIdentifier { get; set; }
            /// <summary>
            /// TypeRevision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-forminput.html#cfn-datazone-datasource-forminput-typerevision
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TypeRevision { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-forminput.html#cfn-datazone-datasource-forminput-content
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Content { get; set; }
            /// <summary>
            /// FormName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-forminput.html#cfn-datazone-datasource-forminput-formname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FormName { get; set; }
        }

        public class GlueRunConfigurationInput : Humidifier.Base.BaseSubResource, IHaveDataAccessRole, IHaveAutoImportDataQualityResult_Boolean, IHaveListOfDataZoneDataSourceTypesRelationalFilterConfigurationRelationalFilterConfigurations, IHaveCatalogName
        {
            /// <summary>
            /// DataAccessRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-gluerunconfigurationinput.html#cfn-datazone-datasource-gluerunconfigurationinput-dataaccessrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataAccessRole { get; set; }
            /// <summary>
            /// AutoImportDataQualityResult
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-gluerunconfigurationinput.html#cfn-datazone-datasource-gluerunconfigurationinput-autoimportdataqualityresult
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutoImportDataQualityResult { get; set; }
            /// <summary>
            /// RelationalFilterConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-gluerunconfigurationinput.html#cfn-datazone-datasource-gluerunconfigurationinput-relationalfilterconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RelationalFilterConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataZone.DataSourceTypes.RelationalFilterConfiguration>, IReadOnlyList<Union<Humidifier.DataZone.DataSourceTypes.RelationalFilterConfiguration, BaseFunction>>, BaseFunction>? RelationalFilterConfigurations { get; set; }
            /// <summary>
            /// CatalogName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-gluerunconfigurationinput.html#cfn-datazone-datasource-gluerunconfigurationinput-catalogname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogName { get; set; }
        }

        public class RecommendationConfiguration : Humidifier.Base.BaseSubResource, IHaveEnableBusinessNameGeneration_Boolean
        {
            /// <summary>
            /// EnableBusinessNameGeneration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-recommendationconfiguration.html#cfn-datazone-datasource-recommendationconfiguration-enablebusinessnamegeneration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableBusinessNameGeneration { get; set; }
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
            public Union<string, BaseFunction>? ClusterName { get; set; }
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
            public Union<string, BaseFunction>? SecretManagerArn { get; set; }
        }

        public class RedshiftRunConfigurationInput : Humidifier.Base.BaseSubResource, IHaveDataAccessRole, IHaveListOfDataZoneDataSourceTypesRelationalFilterConfigurationRelationalFilterConfigurations, IHaveDataZoneDataSourceTypesRedshiftCredentialConfigurationRedshiftCredentialConfiguration, IHaveDataZoneDataSourceTypesRedshiftStorageRedshiftStorage
        {
            /// <summary>
            /// DataAccessRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftrunconfigurationinput.html#cfn-datazone-datasource-redshiftrunconfigurationinput-dataaccessrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataAccessRole { get; set; }
            /// <summary>
            /// RelationalFilterConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftrunconfigurationinput.html#cfn-datazone-datasource-redshiftrunconfigurationinput-relationalfilterconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RelationalFilterConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataZone.DataSourceTypes.RelationalFilterConfiguration>, IReadOnlyList<Union<Humidifier.DataZone.DataSourceTypes.RelationalFilterConfiguration, BaseFunction>>, BaseFunction>? RelationalFilterConfigurations { get; set; }
            /// <summary>
            /// RedshiftCredentialConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftrunconfigurationinput.html#cfn-datazone-datasource-redshiftrunconfigurationinput-redshiftcredentialconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftCredentialConfiguration
            /// </summary>
            public Union<Humidifier.DataZone.DataSourceTypes.RedshiftCredentialConfiguration, BaseFunction>? RedshiftCredentialConfiguration { get; set; }
            /// <summary>
            /// RedshiftStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftrunconfigurationinput.html#cfn-datazone-datasource-redshiftrunconfigurationinput-redshiftstorage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftStorage
            /// </summary>
            public Union<Humidifier.DataZone.DataSourceTypes.RedshiftStorage, BaseFunction>? RedshiftStorage { get; set; }
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
            public Union<string, BaseFunction>? WorkgroupName { get; set; }
        }

        public class RedshiftStorage : Humidifier.Base.BaseSubResource, IHaveDataZoneDataSourceTypesRedshiftClusterStorageRedshiftClusterSource, IHaveDataZoneDataSourceTypesRedshiftServerlessStorageRedshiftServerlessSource
        {
            /// <summary>
            /// RedshiftClusterSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftstorage.html#cfn-datazone-datasource-redshiftstorage-redshiftclustersource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftClusterStorage
            /// </summary>
            public Union<Humidifier.DataZone.DataSourceTypes.RedshiftClusterStorage, BaseFunction>? RedshiftClusterSource { get; set; }
            /// <summary>
            /// RedshiftServerlessSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-redshiftstorage.html#cfn-datazone-datasource-redshiftstorage-redshiftserverlesssource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftServerlessStorage
            /// </summary>
            public Union<Humidifier.DataZone.DataSourceTypes.RedshiftServerlessStorage, BaseFunction>? RedshiftServerlessSource { get; set; }
        }

        public class RelationalFilterConfiguration : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveSchemaName, IHaveListOfDataZoneDataSourceTypesFilterExpressionFilterExpressions
        {
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-relationalfilterconfiguration.html#cfn-datazone-datasource-relationalfilterconfiguration-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// SchemaName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-relationalfilterconfiguration.html#cfn-datazone-datasource-relationalfilterconfiguration-schemaname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SchemaName { get; set; }
            /// <summary>
            /// FilterExpressions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-relationalfilterconfiguration.html#cfn-datazone-datasource-relationalfilterconfiguration-filterexpressions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterExpression
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataZone.DataSourceTypes.FilterExpression>, IReadOnlyList<Union<Humidifier.DataZone.DataSourceTypes.FilterExpression, BaseFunction>>, BaseFunction>? FilterExpressions { get; set; }
        }

        public class SageMakerRunConfigurationInput : Humidifier.Base.BaseSubResource, IHaveTrackingAssets_Json
        {
            /// <summary>
            /// TrackingAssets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-sagemakerrunconfigurationinput.html#cfn-datazone-datasource-sagemakerrunconfigurationinput-trackingassets
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? TrackingAssets { get; set; }
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
            public Union<string, BaseFunction>? Timezone { get; set; }
            /// <summary>
            /// Schedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-datasource-scheduleconfiguration.html#cfn-datazone-datasource-scheduleconfiguration-schedule
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Schedule { get; set; }
        }
    }
}