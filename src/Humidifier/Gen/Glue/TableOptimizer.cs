namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using TableOptimizerTypes;

    public class TableOptimizer : Humidifier.Base.BaseResource, IHaveType, IHaveDatabaseName, IHaveTableName, IHaveCatalogId
    {
        public override string AWSTypeName { get => AWS.Glue.TableOptimizer; }

        /// <summary>
        /// TableName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-tableoptimizer.html#cfn-glue-tableoptimizer-tablename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TableName { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-tableoptimizer.html#cfn-glue-tableoptimizer-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }

        /// <summary>
        /// DatabaseName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-tableoptimizer.html#cfn-glue-tableoptimizer-databasename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DatabaseName { get; set; }

        /// <summary>
        /// TableOptimizerConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-tableoptimizer.html#cfn-glue-tableoptimizer-tableoptimizerconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TableOptimizerConfiguration
        /// </summary>
        [Required]
        public Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration TableOptimizerConfiguration { get; set; }

        /// <summary>
        /// CatalogId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-tableoptimizer.html#cfn-glue-tableoptimizer-catalogid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CatalogId { get; set; }
    }

    namespace TableOptimizerTypes
    {
        public class CompactionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IcebergConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-compactionconfiguration.html#cfn-glue-tableoptimizer-compactionconfiguration-icebergconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IcebergCompactionConfiguration
            /// </summary>
            public Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration IcebergConfiguration { get; set; }
        }

        public class IcebergCompactionConfiguration : Humidifier.Base.BaseSubResource, IHaveStrategy
        {
            /// <summary>
            /// MinInputFiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-icebergcompactionconfiguration.html#cfn-glue-tableoptimizer-icebergcompactionconfiguration-mininputfiles
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinInputFiles { get; set; }
            /// <summary>
            /// DeleteFileThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-icebergcompactionconfiguration.html#cfn-glue-tableoptimizer-icebergcompactionconfiguration-deletefilethreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DeleteFileThreshold { get; set; }
            /// <summary>
            /// Strategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-icebergcompactionconfiguration.html#cfn-glue-tableoptimizer-icebergcompactionconfiguration-strategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Strategy { get; set; }
        }

        public class IcebergConfiguration : Humidifier.Base.BaseSubResource, IHaveLocation
        {
            /// <summary>
            /// OrphanFileRetentionPeriodInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-icebergconfiguration.html#cfn-glue-tableoptimizer-icebergconfiguration-orphanfileretentionperiodindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic OrphanFileRetentionPeriodInDays { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-icebergconfiguration.html#cfn-glue-tableoptimizer-icebergconfiguration-location
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Location { get; set; }
        }

        public class IcebergRetentionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CleanExpiredFiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-icebergretentionconfiguration.html#cfn-glue-tableoptimizer-icebergretentionconfiguration-cleanexpiredfiles
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CleanExpiredFiles { get; set; }
            /// <summary>
            /// SnapshotRetentionPeriodInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-icebergretentionconfiguration.html#cfn-glue-tableoptimizer-icebergretentionconfiguration-snapshotretentionperiodindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SnapshotRetentionPeriodInDays { get; set; }
            /// <summary>
            /// NumberOfSnapshotsToRetain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-icebergretentionconfiguration.html#cfn-glue-tableoptimizer-icebergretentionconfiguration-numberofsnapshotstoretain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfSnapshotsToRetain { get; set; }
        }

        public class OrphanFileDeletionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IcebergConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-orphanfiledeletionconfiguration.html#cfn-glue-tableoptimizer-orphanfiledeletionconfiguration-icebergconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IcebergConfiguration
            /// </summary>
            public Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration IcebergConfiguration { get; set; }
        }

        public class RetentionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IcebergConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-retentionconfiguration.html#cfn-glue-tableoptimizer-retentionconfiguration-icebergconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IcebergRetentionConfiguration
            /// </summary>
            public Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration IcebergConfiguration { get; set; }
        }

        public class TableOptimizerConfiguration : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveEnabled
        {
            /// <summary>
            /// RetentionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-tableoptimizerconfiguration.html#cfn-glue-tableoptimizer-tableoptimizerconfiguration-retentionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetentionConfiguration
            /// </summary>
            public Humidifier.Glue.TableOptimizerTypes.RetentionConfiguration RetentionConfiguration { get; set; }
            /// <summary>
            /// OrphanFileDeletionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-tableoptimizerconfiguration.html#cfn-glue-tableoptimizer-tableoptimizerconfiguration-orphanfiledeletionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OrphanFileDeletionConfiguration
            /// </summary>
            public Humidifier.Glue.TableOptimizerTypes.OrphanFileDeletionConfiguration OrphanFileDeletionConfiguration { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-tableoptimizerconfiguration.html#cfn-glue-tableoptimizer-tableoptimizerconfiguration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// VpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-tableoptimizerconfiguration.html#cfn-glue-tableoptimizer-tableoptimizerconfiguration-vpcconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcConfiguration
            /// </summary>
            public Humidifier.Glue.TableOptimizerTypes.VpcConfiguration VpcConfiguration { get; set; }
            /// <summary>
            /// CompactionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-tableoptimizerconfiguration.html#cfn-glue-tableoptimizer-tableoptimizerconfiguration-compactionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CompactionConfiguration
            /// </summary>
            public Humidifier.Glue.TableOptimizerTypes.CompactionConfiguration CompactionConfiguration { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-tableoptimizerconfiguration.html#cfn-glue-tableoptimizer-tableoptimizerconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class VpcConfiguration : Humidifier.Base.BaseSubResource, IHaveGlueConnectionName
        {
            /// <summary>
            /// GlueConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-tableoptimizer-vpcconfiguration.html#cfn-glue-tableoptimizer-vpcconfiguration-glueconnectionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GlueConnectionName { get; set; }
        }
    }
}