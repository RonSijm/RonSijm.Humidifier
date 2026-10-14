namespace Humidifier.Timestream
{
    using global::System.Collections.Generic;
    using InfluxDBParameterGroupTypes;

    public class InfluxDBParameterGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Timestream.InfluxDBParameterGroup; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbparametergroup.html#cfn-timestream-influxdbparametergroup-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbparametergroup.html#cfn-timestream-influxdbparametergroup-parameters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Parameters
        /// </summary>
        public Humidifier.Timestream.InfluxDBParameterGroupTypes.Parameters Parameters { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbparametergroup.html#cfn-timestream-influxdbparametergroup-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public List<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace InfluxDBParameterGroupTypes
    {
        public class Duration : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// DurationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-duration.html#cfn-timestream-influxdbparametergroup-duration-durationtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DurationType { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-duration.html#cfn-timestream-influxdbparametergroup-duration-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class InfluxDBv2Parameters : Humidifier.Base.BaseSubResource, IHaveLogLevel
        {
            /// <summary>
            /// QueryInitialMemoryBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-queryinitialmemorybytes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic QueryInitialMemoryBytes { get; set; }
            /// <summary>
            /// TracingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-tracingtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TracingType { get; set; }
            /// <summary>
            /// HttpReadHeaderTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-httpreadheadertimeout
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration HttpReadHeaderTimeout { get; set; }
            /// <summary>
            /// StorageCacheSnapshotMemorySize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagecachesnapshotmemorysize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StorageCacheSnapshotMemorySize { get; set; }
            /// <summary>
            /// QueryMemoryBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-querymemorybytes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic QueryMemoryBytes { get; set; }
            /// <summary>
            /// InfluxqlMaxSelectBuckets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-influxqlmaxselectbuckets
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InfluxqlMaxSelectBuckets { get; set; }
            /// <summary>
            /// StorageSeriesFileMaxConcurrentSnapshotCompactions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storageseriesfilemaxconcurrentsnapshotcompactions
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StorageSeriesFileMaxConcurrentSnapshotCompactions { get; set; }
            /// <summary>
            /// LogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-loglevel
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogLevel { get; set; }
            /// <summary>
            /// StorageWalMaxWriteDelay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagewalmaxwritedelay
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration StorageWalMaxWriteDelay { get; set; }
            /// <summary>
            /// HttpWriteTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-httpwritetimeout
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration HttpWriteTimeout { get; set; }
            /// <summary>
            /// StorageCompactThroughputBurst
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagecompactthroughputburst
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StorageCompactThroughputBurst { get; set; }
            /// <summary>
            /// MetricsDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-metricsdisabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic MetricsDisabled { get; set; }
            /// <summary>
            /// StorageRetentionCheckInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storageretentioncheckinterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration StorageRetentionCheckInterval { get; set; }
            /// <summary>
            /// StorageCacheSnapshotWriteColdDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagecachesnapshotwritecoldduration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration StorageCacheSnapshotWriteColdDuration { get; set; }
            /// <summary>
            /// PprofDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-pprofdisabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic PprofDisabled { get; set; }
            /// <summary>
            /// QueryQueueSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-queryqueuesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic QueryQueueSize { get; set; }
            /// <summary>
            /// SessionLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-sessionlength
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SessionLength { get; set; }
            /// <summary>
            /// InfluxqlMaxSelectPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-influxqlmaxselectpoint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InfluxqlMaxSelectPoint { get; set; }
            /// <summary>
            /// StorageCacheMaxMemorySize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagecachemaxmemorysize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StorageCacheMaxMemorySize { get; set; }
            /// <summary>
            /// StorageNoValidateFieldSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagenovalidatefieldsize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic StorageNoValidateFieldSize { get; set; }
            /// <summary>
            /// UiDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-uidisabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic UiDisabled { get; set; }
            /// <summary>
            /// InfluxqlMaxSelectSeries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-influxqlmaxselectseries
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InfluxqlMaxSelectSeries { get; set; }
            /// <summary>
            /// QueryMaxMemoryBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-querymaxmemorybytes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic QueryMaxMemoryBytes { get; set; }
            /// <summary>
            /// StorageMaxIndexLogFileSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagemaxindexlogfilesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StorageMaxIndexLogFileSize { get; set; }
            /// <summary>
            /// StorageSeriesIdSetCacheSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storageseriesidsetcachesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StorageSeriesIdSetCacheSize { get; set; }
            /// <summary>
            /// FluxLogEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-fluxlogenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic FluxLogEnabled { get; set; }
            /// <summary>
            /// StorageWalMaxConcurrentWrites
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagewalmaxconcurrentwrites
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StorageWalMaxConcurrentWrites { get; set; }
            /// <summary>
            /// QueryConcurrency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-queryconcurrency
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic QueryConcurrency { get; set; }
            /// <summary>
            /// StorageMaxConcurrentCompactions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagemaxconcurrentcompactions
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StorageMaxConcurrentCompactions { get; set; }
            /// <summary>
            /// NoTasks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-notasks
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic NoTasks { get; set; }
            /// <summary>
            /// HttpReadTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-httpreadtimeout
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration HttpReadTimeout { get; set; }
            /// <summary>
            /// HttpIdleTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-httpidletimeout
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration HttpIdleTimeout { get; set; }
            /// <summary>
            /// SessionRenewDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-sessionrenewdisabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SessionRenewDisabled { get; set; }
            /// <summary>
            /// StorageCompactFullWriteColdDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagecompactfullwritecoldduration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration StorageCompactFullWriteColdDuration { get; set; }
        }

        public class InfluxDBv3CoreParameters : Humidifier.Base.BaseSubResource, IHaveLogFormat
        {
            /// <summary>
            /// PreemptiveCacheAge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-preemptivecacheage
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration PreemptiveCacheAge { get; set; }
            /// <summary>
            /// LastCacheEvictionInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-lastcacheevictioninterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration LastCacheEvictionInterval { get; set; }
            /// <summary>
            /// DataFusionRuntimeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionruntimetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataFusionRuntimeType { get; set; }
            /// <summary>
            /// MaxHttpRequestSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-maxhttprequestsize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxHttpRequestSize { get; set; }
            /// <summary>
            /// ParquetMemCachePrunePercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-parquetmemcacheprunepercentage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ParquetMemCachePrunePercentage { get; set; }
            /// <summary>
            /// DataFusionMaxParquetFanout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionmaxparquetfanout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFusionMaxParquetFanout { get; set; }
            /// <summary>
            /// QueryFileLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-queryfilelimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic QueryFileLimit { get; set; }
            /// <summary>
            /// DataFusionNumThreads
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionnumthreads
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFusionNumThreads { get; set; }
            /// <summary>
            /// DataFusionRuntimeGlobalQueueInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionruntimeglobalqueueinterval
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFusionRuntimeGlobalQueueInterval { get; set; }
            /// <summary>
            /// WalReplayFailOnError
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-walreplayfailonerror
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic WalReplayFailOnError { get; set; }
            /// <summary>
            /// ParquetMemCachePruneInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-parquetmemcachepruneinterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration ParquetMemCachePruneInterval { get; set; }
            /// <summary>
            /// WalReplayConcurrencyLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-walreplayconcurrencylimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WalReplayConcurrencyLimit { get; set; }
            /// <summary>
            /// ParquetMemCacheSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-parquetmemcachesize
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PercentOrAbsoluteLong
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.PercentOrAbsoluteLong ParquetMemCacheSize { get; set; }
            /// <summary>
            /// DataFusionRuntimeMaxBlockingThreads
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionruntimemaxblockingthreads
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFusionRuntimeMaxBlockingThreads { get; set; }
            /// <summary>
            /// DataFusionRuntimeEventInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionruntimeeventinterval
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFusionRuntimeEventInterval { get; set; }
            /// <summary>
            /// LogFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-logformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogFormat { get; set; }
            /// <summary>
            /// ForceSnapshotMemThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-forcesnapshotmemthreshold
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PercentOrAbsoluteLong
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.PercentOrAbsoluteLong ForceSnapshotMemThreshold { get; set; }
            /// <summary>
            /// WalSnapshotSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-walsnapshotsize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WalSnapshotSize { get; set; }
            /// <summary>
            /// HardDeleteDefaultDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-harddeletedefaultduration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration HardDeleteDefaultDuration { get; set; }
            /// <summary>
            /// DataFusionRuntimeThreadPriority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionruntimethreadpriority
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFusionRuntimeThreadPriority { get; set; }
            /// <summary>
            /// SnapshottedWalFilesToKeep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-snapshottedwalfilestokeep
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SnapshottedWalFilesToKeep { get; set; }
            /// <summary>
            /// TableIndexCacheMaxEntries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-tableindexcachemaxentries
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TableIndexCacheMaxEntries { get; set; }
            /// <summary>
            /// DataFusionRuntimeDisableLifoSlot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionruntimedisablelifoslot
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DataFusionRuntimeDisableLifoSlot { get; set; }
            /// <summary>
            /// DataFusionRuntimeMaxIoEventsPerTick
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionruntimemaxioeventspertick
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFusionRuntimeMaxIoEventsPerTick { get; set; }
            /// <summary>
            /// ParquetMemCacheQueryPathDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-parquetmemcachequerypathduration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration ParquetMemCacheQueryPathDuration { get; set; }
            /// <summary>
            /// DataFusionRuntimeThreadKeepAlive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionruntimethreadkeepalive
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration DataFusionRuntimeThreadKeepAlive { get; set; }
            /// <summary>
            /// Gen1LookbackDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-gen1lookbackduration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration Gen1LookbackDuration { get; set; }
            /// <summary>
            /// QueryLogSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-querylogsize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic QueryLogSize { get; set; }
            /// <summary>
            /// ExecMemPoolBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-execmempoolbytes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PercentOrAbsoluteLong
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.PercentOrAbsoluteLong ExecMemPoolBytes { get; set; }
            /// <summary>
            /// Gen1Duration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-gen1duration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration Gen1Duration { get; set; }
            /// <summary>
            /// DataFusionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionconfig
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataFusionConfig { get; set; }
            /// <summary>
            /// TableIndexCacheConcurrencyLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-tableindexcacheconcurrencylimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TableIndexCacheConcurrencyLimit { get; set; }
            /// <summary>
            /// DistinctCacheEvictionInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-distinctcacheevictioninterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration DistinctCacheEvictionInterval { get; set; }
            /// <summary>
            /// WalMaxWriteBufferSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-walmaxwritebuffersize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WalMaxWriteBufferSize { get; set; }
            /// <summary>
            /// DisableParquetMemCache
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-disableparquetmemcache
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DisableParquetMemCache { get; set; }
            /// <summary>
            /// DeleteGracePeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-deletegraceperiod
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration DeleteGracePeriod { get; set; }
            /// <summary>
            /// RetentionCheckInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-retentioncheckinterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration RetentionCheckInterval { get; set; }
            /// <summary>
            /// LogFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-logfilter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogFilter { get; set; }
            /// <summary>
            /// DataFusionUseCachedParquetLoader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionusecachedparquetloader
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DataFusionUseCachedParquetLoader { get; set; }
        }

        public class InfluxDBv3EnterpriseParameters : Humidifier.Base.BaseSubResource, IHaveLogFormat
        {
            /// <summary>
            /// ParquetMemCachePrunePercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-parquetmemcacheprunepercentage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ParquetMemCachePrunePercentage { get; set; }
            /// <summary>
            /// CatalogSyncInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-catalogsyncinterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration CatalogSyncInterval { get; set; }
            /// <summary>
            /// DataFusionNumThreads
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionnumthreads
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFusionNumThreads { get; set; }
            /// <summary>
            /// WalReplayFailOnError
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-walreplayfailonerror
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic WalReplayFailOnError { get; set; }
            /// <summary>
            /// CompactionGen2Duration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-compactiongen2duration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration CompactionGen2Duration { get; set; }
            /// <summary>
            /// ParquetMemCachePruneInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-parquetmemcachepruneinterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration ParquetMemCachePruneInterval { get; set; }
            /// <summary>
            /// DataFusionRuntimeMaxBlockingThreads
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionruntimemaxblockingthreads
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFusionRuntimeMaxBlockingThreads { get; set; }
            /// <summary>
            /// DistinctValueCacheDisableFromHistory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-distinctvaluecachedisablefromhistory
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DistinctValueCacheDisableFromHistory { get; set; }
            /// <summary>
            /// ForceSnapshotMemThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-forcesnapshotmemthreshold
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PercentOrAbsoluteLong
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.PercentOrAbsoluteLong ForceSnapshotMemThreshold { get; set; }
            /// <summary>
            /// HardDeleteDefaultDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-harddeletedefaultduration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration HardDeleteDefaultDuration { get; set; }
            /// <summary>
            /// DataFusionRuntimeThreadPriority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionruntimethreadpriority
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFusionRuntimeThreadPriority { get; set; }
            /// <summary>
            /// CompactionCleanupWait
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-compactioncleanupwait
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration CompactionCleanupWait { get; set; }
            /// <summary>
            /// TableIndexCacheMaxEntries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-tableindexcachemaxentries
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TableIndexCacheMaxEntries { get; set; }
            /// <summary>
            /// DataFusionRuntimeDisableLifoSlot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionruntimedisablelifoslot
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DataFusionRuntimeDisableLifoSlot { get; set; }
            /// <summary>
            /// DataFusionRuntimeMaxIoEventsPerTick
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionruntimemaxioeventspertick
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFusionRuntimeMaxIoEventsPerTick { get; set; }
            /// <summary>
            /// ParquetMemCacheQueryPathDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-parquetmemcachequerypathduration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration ParquetMemCacheQueryPathDuration { get; set; }
            /// <summary>
            /// DataFusionRuntimeThreadKeepAlive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionruntimethreadkeepalive
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration DataFusionRuntimeThreadKeepAlive { get; set; }
            /// <summary>
            /// Gen1LookbackDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-gen1lookbackduration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration Gen1LookbackDuration { get; set; }
            /// <summary>
            /// QueryLogSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-querylogsize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic QueryLogSize { get; set; }
            /// <summary>
            /// DataFusionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionconfig
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataFusionConfig { get; set; }
            /// <summary>
            /// LastValueCacheDisableFromHistory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-lastvaluecachedisablefromhistory
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic LastValueCacheDisableFromHistory { get; set; }
            /// <summary>
            /// DisableParquetMemCache
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-disableparquetmemcache
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DisableParquetMemCache { get; set; }
            /// <summary>
            /// DeleteGracePeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-deletegraceperiod
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration DeleteGracePeriod { get; set; }
            /// <summary>
            /// RetentionCheckInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-retentioncheckinterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration RetentionCheckInterval { get; set; }
            /// <summary>
            /// LogFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-logfilter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogFilter { get; set; }
            /// <summary>
            /// CompactionMultipliers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-compactionmultipliers
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CompactionMultipliers { get; set; }
            /// <summary>
            /// DataFusionUseCachedParquetLoader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionusecachedparquetloader
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DataFusionUseCachedParquetLoader { get; set; }
            /// <summary>
            /// PreemptiveCacheAge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-preemptivecacheage
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration PreemptiveCacheAge { get; set; }
            /// <summary>
            /// LastCacheEvictionInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-lastcacheevictioninterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration LastCacheEvictionInterval { get; set; }
            /// <summary>
            /// DataFusionRuntimeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionruntimetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataFusionRuntimeType { get; set; }
            /// <summary>
            /// MaxHttpRequestSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-maxhttprequestsize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxHttpRequestSize { get; set; }
            /// <summary>
            /// DataFusionMaxParquetFanout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionmaxparquetfanout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFusionMaxParquetFanout { get; set; }
            /// <summary>
            /// QueryFileLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-queryfilelimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic QueryFileLimit { get; set; }
            /// <summary>
            /// DataFusionRuntimeGlobalQueueInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionruntimeglobalqueueinterval
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFusionRuntimeGlobalQueueInterval { get; set; }
            /// <summary>
            /// CompactionMaxNumFilesPerPlan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-compactionmaxnumfilesperplan
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CompactionMaxNumFilesPerPlan { get; set; }
            /// <summary>
            /// CompactionRowLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-compactionrowlimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CompactionRowLimit { get; set; }
            /// <summary>
            /// WalReplayConcurrencyLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-walreplayconcurrencylimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WalReplayConcurrencyLimit { get; set; }
            /// <summary>
            /// ParquetMemCacheSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-parquetmemcachesize
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PercentOrAbsoluteLong
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.PercentOrAbsoluteLong ParquetMemCacheSize { get; set; }
            /// <summary>
            /// ReplicationInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-replicationinterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration ReplicationInterval { get; set; }
            /// <summary>
            /// IngestQueryInstances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-ingestqueryinstances
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IngestQueryInstances { get; set; }
            /// <summary>
            /// DataFusionRuntimeEventInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionruntimeeventinterval
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFusionRuntimeEventInterval { get; set; }
            /// <summary>
            /// LogFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-logformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogFormat { get; set; }
            /// <summary>
            /// WalSnapshotSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-walsnapshotsize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WalSnapshotSize { get; set; }
            /// <summary>
            /// SnapshottedWalFilesToKeep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-snapshottedwalfilestokeep
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SnapshottedWalFilesToKeep { get; set; }
            /// <summary>
            /// CompactionCheckInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-compactioncheckinterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration CompactionCheckInterval { get; set; }
            /// <summary>
            /// ExecMemPoolBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-execmempoolbytes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PercentOrAbsoluteLong
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.PercentOrAbsoluteLong ExecMemPoolBytes { get; set; }
            /// <summary>
            /// QueryOnlyInstances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-queryonlyinstances
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic QueryOnlyInstances { get; set; }
            /// <summary>
            /// Gen1Duration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-gen1duration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration Gen1Duration { get; set; }
            /// <summary>
            /// TableIndexCacheConcurrencyLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-tableindexcacheconcurrencylimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TableIndexCacheConcurrencyLimit { get; set; }
            /// <summary>
            /// DistinctCacheEvictionInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-distinctcacheevictioninterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration DistinctCacheEvictionInterval { get; set; }
            /// <summary>
            /// WalMaxWriteBufferSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-walmaxwritebuffersize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WalMaxWriteBufferSize { get; set; }
            /// <summary>
            /// DedicatedCompactor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-dedicatedcompactor
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DedicatedCompactor { get; set; }
        }

        public class Parameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InfluxDBv3Core
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-parameters.html#cfn-timestream-influxdbparametergroup-parameters-influxdbv3core
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InfluxDBv3CoreParameters
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.InfluxDBv3CoreParameters InfluxDBv3Core { get; set; }
            /// <summary>
            /// InfluxDBv2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-parameters.html#cfn-timestream-influxdbparametergroup-parameters-influxdbv2
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InfluxDBv2Parameters
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.InfluxDBv2Parameters InfluxDBv2 { get; set; }
            /// <summary>
            /// InfluxDBv3Enterprise
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-parameters.html#cfn-timestream-influxdbparametergroup-parameters-influxdbv3enterprise
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InfluxDBv3EnterpriseParameters
            /// </summary>
            public Humidifier.Timestream.InfluxDBParameterGroupTypes.InfluxDBv3EnterpriseParameters InfluxDBv3Enterprise { get; set; }
        }

        public class PercentOrAbsoluteLong : Humidifier.Base.BaseSubResource, IHaveAbsolute
        {
            /// <summary>
            /// Absolute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-percentorabsolutelong.html#cfn-timestream-influxdbparametergroup-percentorabsolutelong-absolute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Absolute { get; set; }
            /// <summary>
            /// Percent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-percentorabsolutelong.html#cfn-timestream-influxdbparametergroup-percentorabsolutelong-percent
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Percent { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-tagsitems.html#cfn-timestream-influxdbparametergroup-tagsitems-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-tagsitems.html#cfn-timestream-influxdbparametergroup-tagsitems-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}