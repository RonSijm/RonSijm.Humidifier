namespace Humidifier.KinesisAnalyticsV2
{
    using global::System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveApplicationName, IHaveRuntimeEnvironment, IHaveKinesisAnalyticsV2ApplicationTypesRunConfigurationRunConfiguration, IHaveApplicationMode, IHaveKinesisAnalyticsV2ApplicationTypesApplicationMaintenanceConfigurationApplicationMaintenanceConfiguration, IHaveKinesisAnalyticsV2ApplicationTypesApplicationConfigurationApplicationConfiguration, IHaveApplicationDescription, IHaveServiceExecutionRole, IHaveDescription
    {
        public override string AWSTypeName { get => AWS.KinesisAnalyticsV2.Application; }
        public Union<string, BaseFunction>? ApplicationName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// RuntimeEnvironment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html#cfn-kinesisanalyticsv2-application-runtimeenvironment
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuntimeEnvironment { get; set; }
        /// <summary>
        /// RunConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html#cfn-kinesisanalyticsv2-application-runconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RunConfiguration
        /// </summary>
        public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.RunConfiguration, BaseFunction>? RunConfiguration { get; set; }
        /// <summary>
        /// ApplicationMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html#cfn-kinesisanalyticsv2-application-applicationmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ApplicationMode { get; set; }
        /// <summary>
        /// ApplicationMaintenanceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html#cfn-kinesisanalyticsv2-application-applicationmaintenanceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ApplicationMaintenanceConfiguration
        /// </summary>
        public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationMaintenanceConfiguration, BaseFunction>? ApplicationMaintenanceConfiguration { get; set; }
        /// <summary>
        /// ApplicationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html#cfn-kinesisanalyticsv2-application-applicationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ApplicationConfiguration
        /// </summary>
        public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationConfiguration, BaseFunction>? ApplicationConfiguration { get; set; }
        /// <summary>
        /// ApplicationDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html#cfn-kinesisanalyticsv2-application-applicationdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ApplicationDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => ApplicationDescription; set => ApplicationDescription = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html#cfn-kinesisanalyticsv2-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// ServiceExecutionRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html#cfn-kinesisanalyticsv2-application-serviceexecutionrole
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceExecutionRole { get; set; }
    }

    namespace ApplicationTypes
    {
        public class ApplicationCodeConfiguration : Humidifier.Base.BaseSubResource, IHaveCodeContentType, IHaveKinesisAnalyticsV2ApplicationTypesCodeContentCodeContent
        {
            /// <summary>
            /// CodeContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationcodeconfiguration.html#cfn-kinesisanalyticsv2-application-applicationcodeconfiguration-codecontenttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CodeContentType { get; set; }
            /// <summary>
            /// CodeContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationcodeconfiguration.html#cfn-kinesisanalyticsv2-application-applicationcodeconfiguration-codecontent
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CodeContent
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent, BaseFunction>? CodeContent { get; set; }
        }

        public class ApplicationConfiguration : Humidifier.Base.BaseSubResource, IHaveKinesisAnalyticsV2ApplicationTypesApplicationCodeConfigurationApplicationCodeConfiguration, IHaveKinesisAnalyticsV2ApplicationTypesApplicationEncryptionConfigurationApplicationEncryptionConfiguration, IHaveKinesisAnalyticsV2ApplicationTypesEnvironmentPropertiesEnvironmentProperties, IHaveKinesisAnalyticsV2ApplicationTypesFlinkApplicationConfigurationFlinkApplicationConfiguration, IHaveKinesisAnalyticsV2ApplicationTypesZeppelinApplicationConfigurationZeppelinApplicationConfiguration, IHaveListOfKinesisAnalyticsV2ApplicationTypesVpcConfigurationVpcConfigurations, IHaveKinesisAnalyticsV2ApplicationTypesApplicationSnapshotConfigurationApplicationSnapshotConfiguration, IHaveKinesisAnalyticsV2ApplicationTypesApplicationSystemRollbackConfigurationApplicationSystemRollbackConfiguration
        {
            /// <summary>
            /// ApplicationCodeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationconfiguration.html#cfn-kinesisanalyticsv2-application-applicationconfiguration-applicationcodeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApplicationCodeConfiguration
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationCodeConfiguration, BaseFunction>? ApplicationCodeConfiguration { get; set; }
            /// <summary>
            /// ApplicationEncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationconfiguration.html#cfn-kinesisanalyticsv2-application-applicationconfiguration-applicationencryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApplicationEncryptionConfiguration
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationEncryptionConfiguration, BaseFunction>? ApplicationEncryptionConfiguration { get; set; }
            /// <summary>
            /// EnvironmentProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationconfiguration.html#cfn-kinesisanalyticsv2-application-applicationconfiguration-environmentproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EnvironmentProperties
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.EnvironmentProperties, BaseFunction>? EnvironmentProperties { get; set; }
            /// <summary>
            /// FlinkApplicationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationconfiguration.html#cfn-kinesisanalyticsv2-application-applicationconfiguration-flinkapplicationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlinkApplicationConfiguration
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.FlinkApplicationConfiguration, BaseFunction>? FlinkApplicationConfiguration { get; set; }
            /// <summary>
            /// ZeppelinApplicationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationconfiguration.html#cfn-kinesisanalyticsv2-application-applicationconfiguration-zeppelinapplicationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ZeppelinApplicationConfiguration
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ZeppelinApplicationConfiguration, BaseFunction>? ZeppelinApplicationConfiguration { get; set; }
            /// <summary>
            /// VpcConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationconfiguration.html#cfn-kinesisanalyticsv2-application-applicationconfiguration-vpcconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VpcConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.KinesisAnalyticsV2.ApplicationTypes.VpcConfiguration>, IReadOnlyList<Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.VpcConfiguration, BaseFunction>>, BaseFunction>? VpcConfigurations { get; set; }
            /// <summary>
            /// ApplicationSnapshotConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationconfiguration.html#cfn-kinesisanalyticsv2-application-applicationconfiguration-applicationsnapshotconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApplicationSnapshotConfiguration
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationSnapshotConfiguration, BaseFunction>? ApplicationSnapshotConfiguration { get; set; }
            /// <summary>
            /// ApplicationSystemRollbackConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationconfiguration.html#cfn-kinesisanalyticsv2-application-applicationconfiguration-applicationsystemrollbackconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApplicationSystemRollbackConfiguration
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationSystemRollbackConfiguration, BaseFunction>? ApplicationSystemRollbackConfiguration { get; set; }
        }

        public class ApplicationEncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKeyType, IHaveKeyId
        {
            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationencryptionconfiguration.html#cfn-kinesisanalyticsv2-application-applicationencryptionconfiguration-keytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyType { get; set; }
            /// <summary>
            /// KeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationencryptionconfiguration.html#cfn-kinesisanalyticsv2-application-applicationencryptionconfiguration-keyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyId { get; set; }
        }

        public class ApplicationMaintenanceConfiguration : Humidifier.Base.BaseSubResource, IHaveApplicationMaintenanceWindowStartTime
        {
            /// <summary>
            /// ApplicationMaintenanceWindowStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationmaintenanceconfiguration.html#cfn-kinesisanalyticsv2-application-applicationmaintenanceconfiguration-applicationmaintenancewindowstarttime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationMaintenanceWindowStartTime { get; set; }
        }

        public class ApplicationRestoreConfiguration : Humidifier.Base.BaseSubResource, IHaveSnapshotArn, IHaveSnapshotName, IHaveApplicationRestoreType
        {
            /// <summary>
            /// SnapshotArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationrestoreconfiguration.html#cfn-kinesisanalyticsv2-application-applicationrestoreconfiguration-snapshotarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotArn { get; set; }
            /// <summary>
            /// SnapshotName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationrestoreconfiguration.html#cfn-kinesisanalyticsv2-application-applicationrestoreconfiguration-snapshotname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotName { get; set; }
            /// <summary>
            /// ApplicationRestoreType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationrestoreconfiguration.html#cfn-kinesisanalyticsv2-application-applicationrestoreconfiguration-applicationrestoretype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationRestoreType { get; set; }
        }

        public class ApplicationSnapshotConfiguration : Humidifier.Base.BaseSubResource, IHaveSnapshotMode, IHaveSnapshotsEnabled_Boolean
        {
            /// <summary>
            /// SnapshotMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationsnapshotconfiguration.html#cfn-kinesisanalyticsv2-application-applicationsnapshotconfiguration-snapshotmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotMode { get; set; }
            /// <summary>
            /// SnapshotsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationsnapshotconfiguration.html#cfn-kinesisanalyticsv2-application-applicationsnapshotconfiguration-snapshotsenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SnapshotsEnabled { get; set; }
        }

        public class ApplicationSystemRollbackConfiguration : Humidifier.Base.BaseSubResource, IHaveRollbackEnabled_Boolean
        {
            /// <summary>
            /// RollbackEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationsystemrollbackconfiguration.html#cfn-kinesisanalyticsv2-application-applicationsystemrollbackconfiguration-rollbackenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RollbackEnabled { get; set; }
        }

        public class CatalogConfiguration : Humidifier.Base.BaseSubResource, IHaveKinesisAnalyticsV2ApplicationTypesGlueDataCatalogConfigurationGlueDataCatalogConfiguration
        {
            /// <summary>
            /// GlueDataCatalogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-catalogconfiguration.html#cfn-kinesisanalyticsv2-application-catalogconfiguration-gluedatacatalogconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlueDataCatalogConfiguration
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration, BaseFunction>? GlueDataCatalogConfiguration { get; set; }
        }

        public class CheckpointConfiguration : Humidifier.Base.BaseSubResource, IHaveConfigurationType, IHaveCheckpointInterval_Long, IHaveMinPauseBetweenCheckpoints_Long, IHaveCheckpointingEnabled_Boolean
        {
            /// <summary>
            /// ConfigurationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-checkpointconfiguration.html#cfn-kinesisanalyticsv2-application-checkpointconfiguration-configurationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfigurationType { get; set; }
            /// <summary>
            /// CheckpointInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-checkpointconfiguration.html#cfn-kinesisanalyticsv2-application-checkpointconfiguration-checkpointinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? CheckpointInterval { get; set; }
            /// <summary>
            /// MinPauseBetweenCheckpoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-checkpointconfiguration.html#cfn-kinesisanalyticsv2-application-checkpointconfiguration-minpausebetweencheckpoints
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? MinPauseBetweenCheckpoints { get; set; }
            /// <summary>
            /// CheckpointingEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-checkpointconfiguration.html#cfn-kinesisanalyticsv2-application-checkpointconfiguration-checkpointingenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CheckpointingEnabled { get; set; }
        }

        public class CodeContent : Humidifier.Base.BaseSubResource, IHaveZipFileContent, IHaveKinesisAnalyticsV2ApplicationTypesS3ContentLocationS3ContentLocation, IHaveTextContent
        {
            /// <summary>
            /// ZipFileContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-codecontent.html#cfn-kinesisanalyticsv2-application-codecontent-zipfilecontent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ZipFileContent { get; set; }
            /// <summary>
            /// S3ContentLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-codecontent.html#cfn-kinesisanalyticsv2-application-codecontent-s3contentlocation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3ContentLocation
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation, BaseFunction>? S3ContentLocation { get; set; }
            /// <summary>
            /// TextContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-codecontent.html#cfn-kinesisanalyticsv2-application-codecontent-textcontent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextContent { get; set; }
        }

        public class CustomArtifactConfiguration : Humidifier.Base.BaseSubResource, IHaveKinesisAnalyticsV2ApplicationTypesMavenReferenceMavenReference, IHaveKinesisAnalyticsV2ApplicationTypesS3ContentLocationS3ContentLocation, IHaveArtifactType
        {
            /// <summary>
            /// MavenReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-customartifactconfiguration.html#cfn-kinesisanalyticsv2-application-customartifactconfiguration-mavenreference
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MavenReference
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.MavenReference, BaseFunction>? MavenReference { get; set; }
            /// <summary>
            /// S3ContentLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-customartifactconfiguration.html#cfn-kinesisanalyticsv2-application-customartifactconfiguration-s3contentlocation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3ContentLocation
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation, BaseFunction>? S3ContentLocation { get; set; }
            /// <summary>
            /// ArtifactType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-customartifactconfiguration.html#cfn-kinesisanalyticsv2-application-customartifactconfiguration-artifacttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ArtifactType { get; set; }
        }

        public class DeployAsApplicationConfiguration : Humidifier.Base.BaseSubResource, IHaveKinesisAnalyticsV2ApplicationTypesS3ContentBaseLocationS3ContentLocation
        {
            /// <summary>
            /// S3ContentLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-deployasapplicationconfiguration.html#cfn-kinesisanalyticsv2-application-deployasapplicationconfiguration-s3contentlocation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3ContentBaseLocation
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation, BaseFunction>? S3ContentLocation { get; set; }
        }

        public class EnvironmentProperties : Humidifier.Base.BaseSubResource, IHaveListOfKinesisAnalyticsV2ApplicationTypesPropertyGroupPropertyGroups
        {
            /// <summary>
            /// PropertyGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-environmentproperties.html#cfn-kinesisanalyticsv2-application-environmentproperties-propertygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PropertyGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.KinesisAnalyticsV2.ApplicationTypes.PropertyGroup>, IReadOnlyList<Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.PropertyGroup, BaseFunction>>, BaseFunction>? PropertyGroups { get; set; }
        }

        public class FlinkApplicationConfiguration : Humidifier.Base.BaseSubResource, IHaveKinesisAnalyticsV2ApplicationTypesCheckpointConfigurationCheckpointConfiguration, IHaveKinesisAnalyticsV2ApplicationTypesParallelismConfigurationParallelismConfiguration, IHaveKinesisAnalyticsV2ApplicationTypesMonitoringConfigurationMonitoringConfiguration
        {
            /// <summary>
            /// CheckpointConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-flinkapplicationconfiguration.html#cfn-kinesisanalyticsv2-application-flinkapplicationconfiguration-checkpointconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CheckpointConfiguration
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CheckpointConfiguration, BaseFunction>? CheckpointConfiguration { get; set; }
            /// <summary>
            /// ParallelismConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-flinkapplicationconfiguration.html#cfn-kinesisanalyticsv2-application-flinkapplicationconfiguration-parallelismconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParallelismConfiguration
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ParallelismConfiguration, BaseFunction>? ParallelismConfiguration { get; set; }
            /// <summary>
            /// MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-flinkapplicationconfiguration.html#cfn-kinesisanalyticsv2-application-flinkapplicationconfiguration-monitoringconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MonitoringConfiguration
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.MonitoringConfiguration, BaseFunction>? MonitoringConfiguration { get; set; }
        }

        public class FlinkRunConfiguration : Humidifier.Base.BaseSubResource, IHaveAllowNonRestoredState_Boolean
        {
            /// <summary>
            /// AllowNonRestoredState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-flinkrunconfiguration.html#cfn-kinesisanalyticsv2-application-flinkrunconfiguration-allownonrestoredstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowNonRestoredState { get; set; }
        }

        public class GlueDataCatalogConfiguration : Humidifier.Base.BaseSubResource, IHaveDatabaseARN
        {
            /// <summary>
            /// DatabaseARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-gluedatacatalogconfiguration.html#cfn-kinesisanalyticsv2-application-gluedatacatalogconfiguration-databasearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseARN { get; set; }
        }

        public class MavenReference : Humidifier.Base.BaseSubResource, IHaveArtifactId, IHaveVersion, IHaveGroupId
        {
            /// <summary>
            /// ArtifactId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-mavenreference.html#cfn-kinesisanalyticsv2-application-mavenreference-artifactid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ArtifactId { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-mavenreference.html#cfn-kinesisanalyticsv2-application-mavenreference-version
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-mavenreference.html#cfn-kinesisanalyticsv2-application-mavenreference-groupid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupId { get; set; }
        }

        public class MonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveConfigurationType, IHaveMetricsLevel, IHaveLogLevel
        {
            /// <summary>
            /// ConfigurationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-monitoringconfiguration.html#cfn-kinesisanalyticsv2-application-monitoringconfiguration-configurationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfigurationType { get; set; }
            /// <summary>
            /// MetricsLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-monitoringconfiguration.html#cfn-kinesisanalyticsv2-application-monitoringconfiguration-metricslevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricsLevel { get; set; }
            /// <summary>
            /// LogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-monitoringconfiguration.html#cfn-kinesisanalyticsv2-application-monitoringconfiguration-loglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogLevel { get; set; }
        }

        public class ParallelismConfiguration : Humidifier.Base.BaseSubResource, IHaveConfigurationType, IHaveParallelismPerKPU_Integer, IHaveAutoScalingEnabled_Boolean, IHaveParallelism_Integer
        {
            /// <summary>
            /// ConfigurationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-parallelismconfiguration.html#cfn-kinesisanalyticsv2-application-parallelismconfiguration-configurationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfigurationType { get; set; }
            /// <summary>
            /// ParallelismPerKPU
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-parallelismconfiguration.html#cfn-kinesisanalyticsv2-application-parallelismconfiguration-parallelismperkpu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ParallelismPerKPU { get; set; }
            /// <summary>
            /// AutoScalingEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-parallelismconfiguration.html#cfn-kinesisanalyticsv2-application-parallelismconfiguration-autoscalingenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutoScalingEnabled { get; set; }
            /// <summary>
            /// Parallelism
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-parallelismconfiguration.html#cfn-kinesisanalyticsv2-application-parallelismconfiguration-parallelism
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Parallelism { get; set; }
        }

        public class PropertyGroup : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfPropertyMap, IHavePropertyGroupId
        {
            /// <summary>
            /// PropertyMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-propertygroup.html#cfn-kinesisanalyticsv2-application-propertygroup-propertymap
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? PropertyMap { get; set; }
            /// <summary>
            /// PropertyGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-propertygroup.html#cfn-kinesisanalyticsv2-application-propertygroup-propertygroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyGroupId { get; set; }
        }

        public class RunConfiguration : Humidifier.Base.BaseSubResource, IHaveKinesisAnalyticsV2ApplicationTypesFlinkRunConfigurationFlinkRunConfiguration, IHaveKinesisAnalyticsV2ApplicationTypesApplicationRestoreConfigurationApplicationRestoreConfiguration
        {
            /// <summary>
            /// FlinkRunConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-runconfiguration.html#cfn-kinesisanalyticsv2-application-runconfiguration-flinkrunconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlinkRunConfiguration
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.FlinkRunConfiguration, BaseFunction>? FlinkRunConfiguration { get; set; }
            /// <summary>
            /// ApplicationRestoreConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-runconfiguration.html#cfn-kinesisanalyticsv2-application-runconfiguration-applicationrestoreconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApplicationRestoreConfiguration
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationRestoreConfiguration, BaseFunction>? ApplicationRestoreConfiguration { get; set; }
        }

        public class S3ContentBaseLocation : Humidifier.Base.BaseSubResource, IHaveBucketARN, IHaveBasePath
        {
            /// <summary>
            /// BucketARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-s3contentbaselocation.html#cfn-kinesisanalyticsv2-application-s3contentbaselocation-bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketARN { get; set; }
            /// <summary>
            /// BasePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-s3contentbaselocation.html#cfn-kinesisanalyticsv2-application-s3contentbaselocation-basepath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BasePath { get; set; }
        }

        public class S3ContentLocation : Humidifier.Base.BaseSubResource, IHaveBucketARN, IHaveFileKey, IHaveObjectVersion
        {
            /// <summary>
            /// BucketARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-s3contentlocation.html#cfn-kinesisanalyticsv2-application-s3contentlocation-bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketARN { get; set; }
            /// <summary>
            /// FileKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-s3contentlocation.html#cfn-kinesisanalyticsv2-application-s3contentlocation-filekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileKey { get; set; }
            /// <summary>
            /// ObjectVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-s3contentlocation.html#cfn-kinesisanalyticsv2-application-s3contentlocation-objectversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectVersion { get; set; }
        }

        public class VpcConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-vpcconfiguration.html#cfn-kinesisanalyticsv2-application-vpcconfiguration-securitygroupids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-vpcconfiguration.html#cfn-kinesisanalyticsv2-application-vpcconfiguration-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }

        public class ZeppelinApplicationConfiguration : Humidifier.Base.BaseSubResource, IHaveKinesisAnalyticsV2ApplicationTypesCatalogConfigurationCatalogConfiguration, IHaveKinesisAnalyticsV2ApplicationTypesZeppelinMonitoringConfigurationMonitoringConfiguration, IHaveKinesisAnalyticsV2ApplicationTypesDeployAsApplicationConfigurationDeployAsApplicationConfiguration, IHaveListOfKinesisAnalyticsV2ApplicationTypesCustomArtifactConfigurationCustomArtifactsConfiguration
        {
            /// <summary>
            /// CatalogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-zeppelinapplicationconfiguration.html#cfn-kinesisanalyticsv2-application-zeppelinapplicationconfiguration-catalogconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CatalogConfiguration
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CatalogConfiguration, BaseFunction>? CatalogConfiguration { get; set; }
            /// <summary>
            /// MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-zeppelinapplicationconfiguration.html#cfn-kinesisanalyticsv2-application-zeppelinapplicationconfiguration-monitoringconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ZeppelinMonitoringConfiguration
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ZeppelinMonitoringConfiguration, BaseFunction>? MonitoringConfiguration { get; set; }
            /// <summary>
            /// DeployAsApplicationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-zeppelinapplicationconfiguration.html#cfn-kinesisanalyticsv2-application-zeppelinapplicationconfiguration-deployasapplicationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeployAsApplicationConfiguration
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.DeployAsApplicationConfiguration, BaseFunction>? DeployAsApplicationConfiguration { get; set; }
            /// <summary>
            /// CustomArtifactsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-zeppelinapplicationconfiguration.html#cfn-kinesisanalyticsv2-application-zeppelinapplicationconfiguration-customartifactsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomArtifactConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CustomArtifactConfiguration>, IReadOnlyList<Union<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CustomArtifactConfiguration, BaseFunction>>, BaseFunction>? CustomArtifactsConfiguration { get; set; }
        }

        public class ZeppelinMonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveLogLevel
        {
            /// <summary>
            /// LogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-zeppelinmonitoringconfiguration.html#cfn-kinesisanalyticsv2-application-zeppelinmonitoringconfiguration-loglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogLevel { get; set; }
        }
    }
}