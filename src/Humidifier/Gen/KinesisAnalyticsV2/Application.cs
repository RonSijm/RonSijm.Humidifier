namespace Humidifier.KinesisAnalyticsV2
{
    using System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveApplicationName, IHaveApplicationDescription, IHaveDescription
    {
        public override string AWSTypeName { get => AWS.KinesisAnalyticsV2.Application; }
        public dynamic ApplicationName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// RuntimeEnvironment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html#cfn-kinesisanalyticsv2-application-runtimeenvironment
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RuntimeEnvironment { get; set; }
        /// <summary>
        /// RunConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html#cfn-kinesisanalyticsv2-application-runconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RunConfiguration
        /// </summary>
        public Humidifier.KinesisAnalyticsV2.ApplicationTypes.RunConfiguration RunConfiguration { get; set; }
        /// <summary>
        /// ApplicationMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html#cfn-kinesisanalyticsv2-application-applicationmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationMode { get; set; }
        /// <summary>
        /// ApplicationMaintenanceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html#cfn-kinesisanalyticsv2-application-applicationmaintenanceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ApplicationMaintenanceConfiguration
        /// </summary>
        public Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationMaintenanceConfiguration ApplicationMaintenanceConfiguration { get; set; }
        /// <summary>
        /// ApplicationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html#cfn-kinesisanalyticsv2-application-applicationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ApplicationConfiguration
        /// </summary>
        public Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationConfiguration ApplicationConfiguration { get; set; }
        /// <summary>
        /// ApplicationDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html#cfn-kinesisanalyticsv2-application-applicationdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationDescription { get; set; }

        [Ignore]
        public dynamic Description { get => ApplicationDescription; set => ApplicationDescription = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html#cfn-kinesisanalyticsv2-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// ServiceExecutionRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html#cfn-kinesisanalyticsv2-application-serviceexecutionrole
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ServiceExecutionRole { get; set; }
    }

    namespace ApplicationTypes
    {
        public class ApplicationCodeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CodeContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationcodeconfiguration.html#cfn-kinesisanalyticsv2-application-applicationcodeconfiguration-codecontenttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CodeContentType { get; set; }
            /// <summary>
            /// CodeContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationcodeconfiguration.html#cfn-kinesisanalyticsv2-application-applicationcodeconfiguration-codecontent
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CodeContent
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent CodeContent { get; set; }
        }

        public class ApplicationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ApplicationCodeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationconfiguration.html#cfn-kinesisanalyticsv2-application-applicationconfiguration-applicationcodeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApplicationCodeConfiguration
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationCodeConfiguration ApplicationCodeConfiguration { get; set; }
            /// <summary>
            /// EnvironmentProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationconfiguration.html#cfn-kinesisanalyticsv2-application-applicationconfiguration-environmentproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EnvironmentProperties
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.EnvironmentProperties EnvironmentProperties { get; set; }
            /// <summary>
            /// FlinkApplicationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationconfiguration.html#cfn-kinesisanalyticsv2-application-applicationconfiguration-flinkapplicationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlinkApplicationConfiguration
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.FlinkApplicationConfiguration FlinkApplicationConfiguration { get; set; }
            /// <summary>
            /// SqlApplicationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationconfiguration.html#cfn-kinesisanalyticsv2-application-applicationconfiguration-sqlapplicationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SqlApplicationConfiguration
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.SqlApplicationConfiguration SqlApplicationConfiguration { get; set; }
            /// <summary>
            /// ZeppelinApplicationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationconfiguration.html#cfn-kinesisanalyticsv2-application-applicationconfiguration-zeppelinapplicationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ZeppelinApplicationConfiguration
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.ZeppelinApplicationConfiguration ZeppelinApplicationConfiguration { get; set; }
            /// <summary>
            /// VpcConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationconfiguration.html#cfn-kinesisanalyticsv2-application-applicationconfiguration-vpcconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VpcConfiguration
            /// </summary>
            public List<Humidifier.KinesisAnalyticsV2.ApplicationTypes.VpcConfiguration> VpcConfigurations { get; set; }
            /// <summary>
            /// ApplicationSnapshotConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationconfiguration.html#cfn-kinesisanalyticsv2-application-applicationconfiguration-applicationsnapshotconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApplicationSnapshotConfiguration
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationSnapshotConfiguration ApplicationSnapshotConfiguration { get; set; }
            /// <summary>
            /// ApplicationSystemRollbackConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationconfiguration.html#cfn-kinesisanalyticsv2-application-applicationconfiguration-applicationsystemrollbackconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApplicationSystemRollbackConfiguration
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationSystemRollbackConfiguration ApplicationSystemRollbackConfiguration { get; set; }
        }

        public class ApplicationMaintenanceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ApplicationMaintenanceWindowStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationmaintenanceconfiguration.html#cfn-kinesisanalyticsv2-application-applicationmaintenanceconfiguration-applicationmaintenancewindowstarttime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationMaintenanceWindowStartTime { get; set; }
        }

        public class ApplicationRestoreConfiguration : Humidifier.Base.BaseSubResource, IHaveSnapshotName
        {
            /// <summary>
            /// SnapshotName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationrestoreconfiguration.html#cfn-kinesisanalyticsv2-application-applicationrestoreconfiguration-snapshotname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnapshotName { get; set; }
            /// <summary>
            /// ApplicationRestoreType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationrestoreconfiguration.html#cfn-kinesisanalyticsv2-application-applicationrestoreconfiguration-applicationrestoretype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationRestoreType { get; set; }
        }

        public class ApplicationSnapshotConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SnapshotsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationsnapshotconfiguration.html#cfn-kinesisanalyticsv2-application-applicationsnapshotconfiguration-snapshotsenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SnapshotsEnabled { get; set; }
        }

        public class ApplicationSystemRollbackConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RollbackEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationsystemrollbackconfiguration.html#cfn-kinesisanalyticsv2-application-applicationsystemrollbackconfiguration-rollbackenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RollbackEnabled { get; set; }
        }

        public class CSVMappingParameters : Humidifier.Base.BaseSubResource, IHaveRecordRowDelimiter, IHaveRecordColumnDelimiter
        {
            /// <summary>
            /// RecordRowDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-csvmappingparameters.html#cfn-kinesisanalyticsv2-application-csvmappingparameters-recordrowdelimiter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordRowDelimiter { get; set; }
            /// <summary>
            /// RecordColumnDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-csvmappingparameters.html#cfn-kinesisanalyticsv2-application-csvmappingparameters-recordcolumndelimiter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordColumnDelimiter { get; set; }
        }

        public class CatalogConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GlueDataCatalogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-catalogconfiguration.html#cfn-kinesisanalyticsv2-application-catalogconfiguration-gluedatacatalogconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlueDataCatalogConfiguration
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration GlueDataCatalogConfiguration { get; set; }
        }

        public class CheckpointConfiguration : Humidifier.Base.BaseSubResource, IHaveConfigurationType
        {
            /// <summary>
            /// ConfigurationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-checkpointconfiguration.html#cfn-kinesisanalyticsv2-application-checkpointconfiguration-configurationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConfigurationType { get; set; }
            /// <summary>
            /// CheckpointInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-checkpointconfiguration.html#cfn-kinesisanalyticsv2-application-checkpointconfiguration-checkpointinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CheckpointInterval { get; set; }
            /// <summary>
            /// MinPauseBetweenCheckpoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-checkpointconfiguration.html#cfn-kinesisanalyticsv2-application-checkpointconfiguration-minpausebetweencheckpoints
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinPauseBetweenCheckpoints { get; set; }
            /// <summary>
            /// CheckpointingEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-checkpointconfiguration.html#cfn-kinesisanalyticsv2-application-checkpointconfiguration-checkpointingenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CheckpointingEnabled { get; set; }
        }

        public class CodeContent : Humidifier.Base.BaseSubResource, IHaveKinesisAnalyticsV2ApplicationTypesS3ContentLocationS3ContentLocation
        {
            /// <summary>
            /// ZipFileContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-codecontent.html#cfn-kinesisanalyticsv2-application-codecontent-zipfilecontent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ZipFileContent { get; set; }
            /// <summary>
            /// S3ContentLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-codecontent.html#cfn-kinesisanalyticsv2-application-codecontent-s3contentlocation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3ContentLocation
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation S3ContentLocation { get; set; }
            /// <summary>
            /// TextContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-codecontent.html#cfn-kinesisanalyticsv2-application-codecontent-textcontent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TextContent { get; set; }
        }

        public class CustomArtifactConfiguration : Humidifier.Base.BaseSubResource, IHaveKinesisAnalyticsV2ApplicationTypesS3ContentLocationS3ContentLocation
        {
            /// <summary>
            /// MavenReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-customartifactconfiguration.html#cfn-kinesisanalyticsv2-application-customartifactconfiguration-mavenreference
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MavenReference
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.MavenReference MavenReference { get; set; }
            /// <summary>
            /// S3ContentLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-customartifactconfiguration.html#cfn-kinesisanalyticsv2-application-customartifactconfiguration-s3contentlocation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3ContentLocation
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation S3ContentLocation { get; set; }
            /// <summary>
            /// ArtifactType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-customartifactconfiguration.html#cfn-kinesisanalyticsv2-application-customartifactconfiguration-artifacttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ArtifactType { get; set; }
        }

        public class DeployAsApplicationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3ContentLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-deployasapplicationconfiguration.html#cfn-kinesisanalyticsv2-application-deployasapplicationconfiguration-s3contentlocation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3ContentBaseLocation
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation S3ContentLocation { get; set; }
        }

        public class EnvironmentProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PropertyGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-environmentproperties.html#cfn-kinesisanalyticsv2-application-environmentproperties-propertygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PropertyGroup
            /// </summary>
            public List<Humidifier.KinesisAnalyticsV2.ApplicationTypes.PropertyGroup> PropertyGroups { get; set; }
        }

        public class FlinkApplicationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CheckpointConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-flinkapplicationconfiguration.html#cfn-kinesisanalyticsv2-application-flinkapplicationconfiguration-checkpointconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CheckpointConfiguration
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.CheckpointConfiguration CheckpointConfiguration { get; set; }
            /// <summary>
            /// ParallelismConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-flinkapplicationconfiguration.html#cfn-kinesisanalyticsv2-application-flinkapplicationconfiguration-parallelismconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParallelismConfiguration
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.ParallelismConfiguration ParallelismConfiguration { get; set; }
            /// <summary>
            /// MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-flinkapplicationconfiguration.html#cfn-kinesisanalyticsv2-application-flinkapplicationconfiguration-monitoringconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MonitoringConfiguration
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.MonitoringConfiguration MonitoringConfiguration { get; set; }
        }

        public class FlinkRunConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AllowNonRestoredState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-flinkrunconfiguration.html#cfn-kinesisanalyticsv2-application-flinkrunconfiguration-allownonrestoredstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowNonRestoredState { get; set; }
        }

        public class GlueDataCatalogConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DatabaseARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-gluedatacatalogconfiguration.html#cfn-kinesisanalyticsv2-application-gluedatacatalogconfiguration-databasearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseARN { get; set; }
        }

        public class Input : Humidifier.Base.BaseSubResource, IHaveNamePrefix
        {
            /// <summary>
            /// NamePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-input.html#cfn-kinesisanalyticsv2-application-input-nameprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NamePrefix { get; set; }
            /// <summary>
            /// InputSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-input.html#cfn-kinesisanalyticsv2-application-input-inputschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InputSchema
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.InputSchema InputSchema { get; set; }
            /// <summary>
            /// KinesisStreamsInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-input.html#cfn-kinesisanalyticsv2-application-input-kinesisstreamsinput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisStreamsInput
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.KinesisStreamsInput KinesisStreamsInput { get; set; }
            /// <summary>
            /// KinesisFirehoseInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-input.html#cfn-kinesisanalyticsv2-application-input-kinesisfirehoseinput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisFirehoseInput
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.KinesisFirehoseInput KinesisFirehoseInput { get; set; }
            /// <summary>
            /// InputProcessingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-input.html#cfn-kinesisanalyticsv2-application-input-inputprocessingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputProcessingConfiguration
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.InputProcessingConfiguration InputProcessingConfiguration { get; set; }
            /// <summary>
            /// InputParallelism
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-input.html#cfn-kinesisanalyticsv2-application-input-inputparallelism
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputParallelism
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.InputParallelism InputParallelism { get; set; }
        }

        public class InputLambdaProcessor : Humidifier.Base.BaseSubResource, IHaveResourceARN
        {
            /// <summary>
            /// ResourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-inputlambdaprocessor.html#cfn-kinesisanalyticsv2-application-inputlambdaprocessor-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceARN { get; set; }
        }

        public class InputParallelism : Humidifier.Base.BaseSubResource, IHaveCount
        {
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-inputparallelism.html#cfn-kinesisanalyticsv2-application-inputparallelism-count
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Count { get; set; }
        }

        public class InputProcessingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InputLambdaProcessor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-inputprocessingconfiguration.html#cfn-kinesisanalyticsv2-application-inputprocessingconfiguration-inputlambdaprocessor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLambdaProcessor
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.InputLambdaProcessor InputLambdaProcessor { get; set; }
        }

        public class InputSchema : Humidifier.Base.BaseSubResource, IHaveRecordEncoding
        {
            /// <summary>
            /// RecordEncoding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-inputschema.html#cfn-kinesisanalyticsv2-application-inputschema-recordencoding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordEncoding { get; set; }
            /// <summary>
            /// RecordColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-inputschema.html#cfn-kinesisanalyticsv2-application-inputschema-recordcolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RecordColumn
            /// </summary>
            public List<Humidifier.KinesisAnalyticsV2.ApplicationTypes.RecordColumn> RecordColumns { get; set; }
            /// <summary>
            /// RecordFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-inputschema.html#cfn-kinesisanalyticsv2-application-inputschema-recordformat
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RecordFormat
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.RecordFormat RecordFormat { get; set; }
        }

        public class JSONMappingParameters : Humidifier.Base.BaseSubResource, IHaveRecordRowPath
        {
            /// <summary>
            /// RecordRowPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-jsonmappingparameters.html#cfn-kinesisanalyticsv2-application-jsonmappingparameters-recordrowpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordRowPath { get; set; }
        }

        public class KinesisFirehoseInput : Humidifier.Base.BaseSubResource, IHaveResourceARN
        {
            /// <summary>
            /// ResourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-kinesisfirehoseinput.html#cfn-kinesisanalyticsv2-application-kinesisfirehoseinput-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceARN { get; set; }
        }

        public class KinesisStreamsInput : Humidifier.Base.BaseSubResource, IHaveResourceARN
        {
            /// <summary>
            /// ResourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-kinesisstreamsinput.html#cfn-kinesisanalyticsv2-application-kinesisstreamsinput-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceARN { get; set; }
        }

        public class MappingParameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// JSONMappingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-mappingparameters.html#cfn-kinesisanalyticsv2-application-mappingparameters-jsonmappingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JSONMappingParameters
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.JSONMappingParameters JSONMappingParameters { get; set; }
            /// <summary>
            /// CSVMappingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-mappingparameters.html#cfn-kinesisanalyticsv2-application-mappingparameters-csvmappingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CSVMappingParameters
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.CSVMappingParameters CSVMappingParameters { get; set; }
        }

        public class MavenReference : Humidifier.Base.BaseSubResource, IHaveVersion, IHaveGroupId
        {
            /// <summary>
            /// ArtifactId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-mavenreference.html#cfn-kinesisanalyticsv2-application-mavenreference-artifactid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ArtifactId { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-mavenreference.html#cfn-kinesisanalyticsv2-application-mavenreference-version
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Version { get; set; }
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-mavenreference.html#cfn-kinesisanalyticsv2-application-mavenreference-groupid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupId { get; set; }
        }

        public class MonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveLogLevel, IHaveConfigurationType
        {
            /// <summary>
            /// ConfigurationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-monitoringconfiguration.html#cfn-kinesisanalyticsv2-application-monitoringconfiguration-configurationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConfigurationType { get; set; }
            /// <summary>
            /// MetricsLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-monitoringconfiguration.html#cfn-kinesisanalyticsv2-application-monitoringconfiguration-metricslevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricsLevel { get; set; }
            /// <summary>
            /// LogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-monitoringconfiguration.html#cfn-kinesisanalyticsv2-application-monitoringconfiguration-loglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogLevel { get; set; }
        }

        public class ParallelismConfiguration : Humidifier.Base.BaseSubResource, IHaveConfigurationType
        {
            /// <summary>
            /// ConfigurationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-parallelismconfiguration.html#cfn-kinesisanalyticsv2-application-parallelismconfiguration-configurationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConfigurationType { get; set; }
            /// <summary>
            /// ParallelismPerKPU
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-parallelismconfiguration.html#cfn-kinesisanalyticsv2-application-parallelismconfiguration-parallelismperkpu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ParallelismPerKPU { get; set; }
            /// <summary>
            /// AutoScalingEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-parallelismconfiguration.html#cfn-kinesisanalyticsv2-application-parallelismconfiguration-autoscalingenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AutoScalingEnabled { get; set; }
            /// <summary>
            /// Parallelism
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-parallelismconfiguration.html#cfn-kinesisanalyticsv2-application-parallelismconfiguration-parallelism
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Parallelism { get; set; }
        }

        public class PropertyGroup : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PropertyMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-propertygroup.html#cfn-kinesisanalyticsv2-application-propertygroup-propertymap
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> PropertyMap { get; set; }
            /// <summary>
            /// PropertyGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-propertygroup.html#cfn-kinesisanalyticsv2-application-propertygroup-propertygroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PropertyGroupId { get; set; }
        }

        public class RecordColumn : Humidifier.Base.BaseSubResource, IHaveName, IHaveMapping, IHaveSqlType
        {
            /// <summary>
            /// Mapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-recordcolumn.html#cfn-kinesisanalyticsv2-application-recordcolumn-mapping
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mapping { get; set; }
            /// <summary>
            /// SqlType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-recordcolumn.html#cfn-kinesisanalyticsv2-application-recordcolumn-sqltype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SqlType { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-recordcolumn.html#cfn-kinesisanalyticsv2-application-recordcolumn-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RecordFormat : Humidifier.Base.BaseSubResource, IHaveRecordFormatType
        {
            /// <summary>
            /// MappingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-recordformat.html#cfn-kinesisanalyticsv2-application-recordformat-mappingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MappingParameters
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.MappingParameters MappingParameters { get; set; }
            /// <summary>
            /// RecordFormatType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-recordformat.html#cfn-kinesisanalyticsv2-application-recordformat-recordformattype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordFormatType { get; set; }
        }

        public class RunConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FlinkRunConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-runconfiguration.html#cfn-kinesisanalyticsv2-application-runconfiguration-flinkrunconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlinkRunConfiguration
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.FlinkRunConfiguration FlinkRunConfiguration { get; set; }
            /// <summary>
            /// ApplicationRestoreConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-runconfiguration.html#cfn-kinesisanalyticsv2-application-runconfiguration-applicationrestoreconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApplicationRestoreConfiguration
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationRestoreConfiguration ApplicationRestoreConfiguration { get; set; }
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
            public dynamic BucketARN { get; set; }
            /// <summary>
            /// BasePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-s3contentbaselocation.html#cfn-kinesisanalyticsv2-application-s3contentbaselocation-basepath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BasePath { get; set; }
        }

        public class S3ContentLocation : Humidifier.Base.BaseSubResource, IHaveObjectVersion, IHaveBucketARN, IHaveFileKey
        {
            /// <summary>
            /// BucketARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-s3contentlocation.html#cfn-kinesisanalyticsv2-application-s3contentlocation-bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketARN { get; set; }
            /// <summary>
            /// FileKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-s3contentlocation.html#cfn-kinesisanalyticsv2-application-s3contentlocation-filekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileKey { get; set; }
            /// <summary>
            /// ObjectVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-s3contentlocation.html#cfn-kinesisanalyticsv2-application-s3contentlocation-objectversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectVersion { get; set; }
        }

        public class SqlApplicationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Inputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-sqlapplicationconfiguration.html#cfn-kinesisanalyticsv2-application-sqlapplicationconfiguration-inputs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Input
            /// </summary>
            public List<Humidifier.KinesisAnalyticsV2.ApplicationTypes.Input> Inputs { get; set; }
        }

        public class VpcConfiguration : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds
        {
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-vpcconfiguration.html#cfn-kinesisanalyticsv2-application-vpcconfiguration-securitygroupids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-vpcconfiguration.html#cfn-kinesisanalyticsv2-application-vpcconfiguration-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
        }

        public class ZeppelinApplicationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CatalogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-zeppelinapplicationconfiguration.html#cfn-kinesisanalyticsv2-application-zeppelinapplicationconfiguration-catalogconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CatalogConfiguration
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.CatalogConfiguration CatalogConfiguration { get; set; }
            /// <summary>
            /// MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-zeppelinapplicationconfiguration.html#cfn-kinesisanalyticsv2-application-zeppelinapplicationconfiguration-monitoringconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ZeppelinMonitoringConfiguration
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.ZeppelinMonitoringConfiguration MonitoringConfiguration { get; set; }
            /// <summary>
            /// DeployAsApplicationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-zeppelinapplicationconfiguration.html#cfn-kinesisanalyticsv2-application-zeppelinapplicationconfiguration-deployasapplicationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeployAsApplicationConfiguration
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationTypes.DeployAsApplicationConfiguration DeployAsApplicationConfiguration { get; set; }
            /// <summary>
            /// CustomArtifactsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-zeppelinapplicationconfiguration.html#cfn-kinesisanalyticsv2-application-zeppelinapplicationconfiguration-customartifactsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomArtifactConfiguration
            /// </summary>
            public List<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CustomArtifactConfiguration> CustomArtifactsConfiguration { get; set; }
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
            public dynamic LogLevel { get; set; }
        }
    }
}