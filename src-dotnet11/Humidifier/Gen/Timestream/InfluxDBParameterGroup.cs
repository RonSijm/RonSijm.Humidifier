namespace Humidifier.Timestream
{
    using global::System.Collections.Generic;
    using InfluxDBParameterGroupTypes;

    public class InfluxDBParameterGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveTimestreamInfluxDBParameterGroupTypesParametersParameters, IHaveListOfTimestreamInfluxDBParameterGroupTypesTagsItemsTags, IHaveName
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
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbparametergroup.html#cfn-timestream-influxdbparametergroup-parameters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Parameters
        /// </summary>
        public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Parameters, BaseFunction>? Parameters { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbparametergroup.html#cfn-timestream-influxdbparametergroup-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems>, IReadOnlyList<Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace InfluxDBParameterGroupTypes
    {
        public class Duration : Humidifier.Base.BaseSubResource, IHaveDurationType, IHaveValue_Integer
        {
            /// <summary>
            /// DurationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-duration.html#cfn-timestream-influxdbparametergroup-duration-durationtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DurationType { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-duration.html#cfn-timestream-influxdbparametergroup-duration-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
        }

        public class InfluxDBv2Parameters : Humidifier.Base.BaseSubResource, IHaveQueryInitialMemoryBytes_Integer, IHaveTracingType, IHaveTimestreamInfluxDBParameterGroupTypesDurationHttpReadHeaderTimeout, IHaveStorageCacheSnapshotMemorySize_Integer, IHaveQueryMemoryBytes_Integer, IHaveInfluxqlMaxSelectBuckets_Integer, IHaveStorageSeriesFileMaxConcurrentSnapshotCompactions_Integer, IHaveLogLevel, IHaveTimestreamInfluxDBParameterGroupTypesDurationStorageWalMaxWriteDelay, IHaveTimestreamInfluxDBParameterGroupTypesDurationHttpWriteTimeout, IHaveStorageCompactThroughputBurst_Integer, IHaveMetricsDisabled_Boolean, IHaveTimestreamInfluxDBParameterGroupTypesDurationStorageRetentionCheckInterval, IHaveTimestreamInfluxDBParameterGroupTypesDurationStorageCacheSnapshotWriteColdDuration, IHavePprofDisabled_Boolean, IHaveQueryQueueSize_Integer, IHaveSessionLength_Integer, IHaveInfluxqlMaxSelectPoint_Integer, IHaveStorageCacheMaxMemorySize_Integer, IHaveStorageNoValidateFieldSize_Boolean, IHaveUiDisabled_Boolean, IHaveInfluxqlMaxSelectSeries_Integer, IHaveQueryMaxMemoryBytes_Integer, IHaveStorageMaxIndexLogFileSize_Integer, IHaveStorageSeriesIdSetCacheSize_Integer, IHaveFluxLogEnabled_Boolean, IHaveStorageWalMaxConcurrentWrites_Integer, IHaveQueryConcurrency_Integer, IHaveStorageMaxConcurrentCompactions_Integer, IHaveNoTasks_Boolean, IHaveTimestreamInfluxDBParameterGroupTypesDurationHttpReadTimeout, IHaveTimestreamInfluxDBParameterGroupTypesDurationHttpIdleTimeout, IHaveSessionRenewDisabled_Boolean, IHaveTimestreamInfluxDBParameterGroupTypesDurationStorageCompactFullWriteColdDuration
        {
            /// <summary>
            /// QueryInitialMemoryBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-queryinitialmemorybytes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? QueryInitialMemoryBytes { get; set; }
            /// <summary>
            /// TracingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-tracingtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TracingType { get; set; }
            /// <summary>
            /// HttpReadHeaderTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-httpreadheadertimeout
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? HttpReadHeaderTimeout { get; set; }
            /// <summary>
            /// StorageCacheSnapshotMemorySize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagecachesnapshotmemorysize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageCacheSnapshotMemorySize { get; set; }
            /// <summary>
            /// QueryMemoryBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-querymemorybytes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? QueryMemoryBytes { get; set; }
            /// <summary>
            /// InfluxqlMaxSelectBuckets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-influxqlmaxselectbuckets
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InfluxqlMaxSelectBuckets { get; set; }
            /// <summary>
            /// StorageSeriesFileMaxConcurrentSnapshotCompactions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storageseriesfilemaxconcurrentsnapshotcompactions
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageSeriesFileMaxConcurrentSnapshotCompactions { get; set; }
            /// <summary>
            /// LogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-loglevel
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogLevel { get; set; }
            /// <summary>
            /// StorageWalMaxWriteDelay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagewalmaxwritedelay
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? StorageWalMaxWriteDelay { get; set; }
            /// <summary>
            /// HttpWriteTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-httpwritetimeout
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? HttpWriteTimeout { get; set; }
            /// <summary>
            /// StorageCompactThroughputBurst
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagecompactthroughputburst
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageCompactThroughputBurst { get; set; }
            /// <summary>
            /// MetricsDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-metricsdisabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MetricsDisabled { get; set; }
            /// <summary>
            /// StorageRetentionCheckInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storageretentioncheckinterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? StorageRetentionCheckInterval { get; set; }
            /// <summary>
            /// StorageCacheSnapshotWriteColdDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagecachesnapshotwritecoldduration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? StorageCacheSnapshotWriteColdDuration { get; set; }
            /// <summary>
            /// PprofDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-pprofdisabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PprofDisabled { get; set; }
            /// <summary>
            /// QueryQueueSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-queryqueuesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? QueryQueueSize { get; set; }
            /// <summary>
            /// SessionLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-sessionlength
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SessionLength { get; set; }
            /// <summary>
            /// InfluxqlMaxSelectPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-influxqlmaxselectpoint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InfluxqlMaxSelectPoint { get; set; }
            /// <summary>
            /// StorageCacheMaxMemorySize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagecachemaxmemorysize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageCacheMaxMemorySize { get; set; }
            /// <summary>
            /// StorageNoValidateFieldSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagenovalidatefieldsize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? StorageNoValidateFieldSize { get; set; }
            /// <summary>
            /// UiDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-uidisabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UiDisabled { get; set; }
            /// <summary>
            /// InfluxqlMaxSelectSeries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-influxqlmaxselectseries
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InfluxqlMaxSelectSeries { get; set; }
            /// <summary>
            /// QueryMaxMemoryBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-querymaxmemorybytes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? QueryMaxMemoryBytes { get; set; }
            /// <summary>
            /// StorageMaxIndexLogFileSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagemaxindexlogfilesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageMaxIndexLogFileSize { get; set; }
            /// <summary>
            /// StorageSeriesIdSetCacheSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storageseriesidsetcachesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageSeriesIdSetCacheSize { get; set; }
            /// <summary>
            /// FluxLogEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-fluxlogenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? FluxLogEnabled { get; set; }
            /// <summary>
            /// StorageWalMaxConcurrentWrites
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagewalmaxconcurrentwrites
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageWalMaxConcurrentWrites { get; set; }
            /// <summary>
            /// QueryConcurrency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-queryconcurrency
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? QueryConcurrency { get; set; }
            /// <summary>
            /// StorageMaxConcurrentCompactions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagemaxconcurrentcompactions
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageMaxConcurrentCompactions { get; set; }
            /// <summary>
            /// NoTasks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-notasks
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? NoTasks { get; set; }
            /// <summary>
            /// HttpReadTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-httpreadtimeout
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? HttpReadTimeout { get; set; }
            /// <summary>
            /// HttpIdleTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-httpidletimeout
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? HttpIdleTimeout { get; set; }
            /// <summary>
            /// SessionRenewDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-sessionrenewdisabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SessionRenewDisabled { get; set; }
            /// <summary>
            /// StorageCompactFullWriteColdDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv2parameters.html#cfn-timestream-influxdbparametergroup-influxdbv2parameters-storagecompactfullwritecoldduration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? StorageCompactFullWriteColdDuration { get; set; }
        }

        public class InfluxDBv3CoreParameters : Humidifier.Base.BaseSubResource, IHaveTimestreamInfluxDBParameterGroupTypesDurationPreemptiveCacheAge, IHaveTimestreamInfluxDBParameterGroupTypesDurationLastCacheEvictionInterval, IHaveDataFusionRuntimeType, IHaveMaxHttpRequestSize_Integer, IHaveParquetMemCachePrunePercentage_Double, IHaveDataFusionMaxParquetFanout_Integer, IHaveQueryFileLimit_Integer, IHaveDataFusionNumThreads_Integer, IHaveDataFusionRuntimeGlobalQueueInterval_Integer, IHaveWalReplayFailOnError_Boolean, IHaveTimestreamInfluxDBParameterGroupTypesDurationParquetMemCachePruneInterval, IHaveWalReplayConcurrencyLimit_Integer, IHaveTimestreamInfluxDBParameterGroupTypesPercentOrAbsoluteLongParquetMemCacheSize, IHaveDataFusionRuntimeMaxBlockingThreads_Integer, IHaveDataFusionRuntimeEventInterval_Integer, IHaveLogFormat, IHaveTimestreamInfluxDBParameterGroupTypesPercentOrAbsoluteLongForceSnapshotMemThreshold, IHaveWalSnapshotSize_Integer, IHaveTimestreamInfluxDBParameterGroupTypesDurationHardDeleteDefaultDuration, IHaveDataFusionRuntimeThreadPriority_Integer, IHaveSnapshottedWalFilesToKeep_Integer, IHaveTableIndexCacheMaxEntries_Integer, IHaveDataFusionRuntimeDisableLifoSlot_Boolean, IHaveDataFusionRuntimeMaxIoEventsPerTick_Integer, IHaveTimestreamInfluxDBParameterGroupTypesDurationParquetMemCacheQueryPathDuration, IHaveTimestreamInfluxDBParameterGroupTypesDurationDataFusionRuntimeThreadKeepAlive, IHaveTimestreamInfluxDBParameterGroupTypesDurationGen1LookbackDuration, IHaveQueryLogSize_Integer, IHaveTimestreamInfluxDBParameterGroupTypesPercentOrAbsoluteLongExecMemPoolBytes, IHaveTimestreamInfluxDBParameterGroupTypesDurationGen1Duration, IHaveDataFusionConfig, IHaveTableIndexCacheConcurrencyLimit_Integer, IHaveTimestreamInfluxDBParameterGroupTypesDurationDistinctCacheEvictionInterval, IHaveWalMaxWriteBufferSize_Integer, IHaveDisableParquetMemCache_Boolean, IHaveTimestreamInfluxDBParameterGroupTypesDurationDeleteGracePeriod, IHaveTimestreamInfluxDBParameterGroupTypesDurationRetentionCheckInterval, IHaveLogFilter, IHaveDataFusionUseCachedParquetLoader_Boolean
        {
            /// <summary>
            /// PreemptiveCacheAge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-preemptivecacheage
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? PreemptiveCacheAge { get; set; }
            /// <summary>
            /// LastCacheEvictionInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-lastcacheevictioninterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? LastCacheEvictionInterval { get; set; }
            /// <summary>
            /// DataFusionRuntimeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionruntimetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataFusionRuntimeType { get; set; }
            /// <summary>
            /// MaxHttpRequestSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-maxhttprequestsize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxHttpRequestSize { get; set; }
            /// <summary>
            /// ParquetMemCachePrunePercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-parquetmemcacheprunepercentage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ParquetMemCachePrunePercentage { get; set; }
            /// <summary>
            /// DataFusionMaxParquetFanout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionmaxparquetfanout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFusionMaxParquetFanout { get; set; }
            /// <summary>
            /// QueryFileLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-queryfilelimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? QueryFileLimit { get; set; }
            /// <summary>
            /// DataFusionNumThreads
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionnumthreads
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFusionNumThreads { get; set; }
            /// <summary>
            /// DataFusionRuntimeGlobalQueueInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionruntimeglobalqueueinterval
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFusionRuntimeGlobalQueueInterval { get; set; }
            /// <summary>
            /// WalReplayFailOnError
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-walreplayfailonerror
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? WalReplayFailOnError { get; set; }
            /// <summary>
            /// ParquetMemCachePruneInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-parquetmemcachepruneinterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? ParquetMemCachePruneInterval { get; set; }
            /// <summary>
            /// WalReplayConcurrencyLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-walreplayconcurrencylimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WalReplayConcurrencyLimit { get; set; }
            /// <summary>
            /// ParquetMemCacheSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-parquetmemcachesize
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PercentOrAbsoluteLong
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.PercentOrAbsoluteLong, BaseFunction>? ParquetMemCacheSize { get; set; }
            /// <summary>
            /// DataFusionRuntimeMaxBlockingThreads
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionruntimemaxblockingthreads
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFusionRuntimeMaxBlockingThreads { get; set; }
            /// <summary>
            /// DataFusionRuntimeEventInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionruntimeeventinterval
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFusionRuntimeEventInterval { get; set; }
            /// <summary>
            /// LogFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-logformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogFormat { get; set; }
            /// <summary>
            /// ForceSnapshotMemThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-forcesnapshotmemthreshold
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PercentOrAbsoluteLong
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.PercentOrAbsoluteLong, BaseFunction>? ForceSnapshotMemThreshold { get; set; }
            /// <summary>
            /// WalSnapshotSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-walsnapshotsize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WalSnapshotSize { get; set; }
            /// <summary>
            /// HardDeleteDefaultDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-harddeletedefaultduration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? HardDeleteDefaultDuration { get; set; }
            /// <summary>
            /// DataFusionRuntimeThreadPriority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionruntimethreadpriority
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFusionRuntimeThreadPriority { get; set; }
            /// <summary>
            /// SnapshottedWalFilesToKeep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-snapshottedwalfilestokeep
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SnapshottedWalFilesToKeep { get; set; }
            /// <summary>
            /// TableIndexCacheMaxEntries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-tableindexcachemaxentries
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TableIndexCacheMaxEntries { get; set; }
            /// <summary>
            /// DataFusionRuntimeDisableLifoSlot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionruntimedisablelifoslot
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DataFusionRuntimeDisableLifoSlot { get; set; }
            /// <summary>
            /// DataFusionRuntimeMaxIoEventsPerTick
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionruntimemaxioeventspertick
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFusionRuntimeMaxIoEventsPerTick { get; set; }
            /// <summary>
            /// ParquetMemCacheQueryPathDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-parquetmemcachequerypathduration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? ParquetMemCacheQueryPathDuration { get; set; }
            /// <summary>
            /// DataFusionRuntimeThreadKeepAlive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionruntimethreadkeepalive
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? DataFusionRuntimeThreadKeepAlive { get; set; }
            /// <summary>
            /// Gen1LookbackDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-gen1lookbackduration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? Gen1LookbackDuration { get; set; }
            /// <summary>
            /// QueryLogSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-querylogsize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? QueryLogSize { get; set; }
            /// <summary>
            /// ExecMemPoolBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-execmempoolbytes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PercentOrAbsoluteLong
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.PercentOrAbsoluteLong, BaseFunction>? ExecMemPoolBytes { get; set; }
            /// <summary>
            /// Gen1Duration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-gen1duration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? Gen1Duration { get; set; }
            /// <summary>
            /// DataFusionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionconfig
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataFusionConfig { get; set; }
            /// <summary>
            /// TableIndexCacheConcurrencyLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-tableindexcacheconcurrencylimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TableIndexCacheConcurrencyLimit { get; set; }
            /// <summary>
            /// DistinctCacheEvictionInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-distinctcacheevictioninterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? DistinctCacheEvictionInterval { get; set; }
            /// <summary>
            /// WalMaxWriteBufferSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-walmaxwritebuffersize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WalMaxWriteBufferSize { get; set; }
            /// <summary>
            /// DisableParquetMemCache
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-disableparquetmemcache
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableParquetMemCache { get; set; }
            /// <summary>
            /// DeleteGracePeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-deletegraceperiod
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? DeleteGracePeriod { get; set; }
            /// <summary>
            /// RetentionCheckInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-retentioncheckinterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? RetentionCheckInterval { get; set; }
            /// <summary>
            /// LogFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-logfilter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogFilter { get; set; }
            /// <summary>
            /// DataFusionUseCachedParquetLoader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3coreparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3coreparameters-datafusionusecachedparquetloader
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DataFusionUseCachedParquetLoader { get; set; }
        }

        public class InfluxDBv3EnterpriseParameters : Humidifier.Base.BaseSubResource, IHaveParquetMemCachePrunePercentage_Double, IHaveTimestreamInfluxDBParameterGroupTypesDurationCatalogSyncInterval, IHaveDataFusionNumThreads_Integer, IHaveWalReplayFailOnError_Boolean, IHaveTimestreamInfluxDBParameterGroupTypesDurationCompactionGen2Duration, IHaveTimestreamInfluxDBParameterGroupTypesDurationParquetMemCachePruneInterval, IHaveDataFusionRuntimeMaxBlockingThreads_Integer, IHaveDistinctValueCacheDisableFromHistory_Boolean, IHaveTimestreamInfluxDBParameterGroupTypesPercentOrAbsoluteLongForceSnapshotMemThreshold, IHaveTimestreamInfluxDBParameterGroupTypesDurationHardDeleteDefaultDuration, IHaveDataFusionRuntimeThreadPriority_Integer, IHaveTimestreamInfluxDBParameterGroupTypesDurationCompactionCleanupWait, IHaveTableIndexCacheMaxEntries_Integer, IHaveDataFusionRuntimeDisableLifoSlot_Boolean, IHaveDataFusionRuntimeMaxIoEventsPerTick_Integer, IHaveTimestreamInfluxDBParameterGroupTypesDurationParquetMemCacheQueryPathDuration, IHaveTimestreamInfluxDBParameterGroupTypesDurationDataFusionRuntimeThreadKeepAlive, IHaveTimestreamInfluxDBParameterGroupTypesDurationGen1LookbackDuration, IHaveQueryLogSize_Integer, IHaveDataFusionConfig, IHaveLastValueCacheDisableFromHistory_Boolean, IHaveDisableParquetMemCache_Boolean, IHaveTimestreamInfluxDBParameterGroupTypesDurationDeleteGracePeriod, IHaveTimestreamInfluxDBParameterGroupTypesDurationRetentionCheckInterval, IHaveLogFilter, IHaveCompactionMultipliers, IHaveDataFusionUseCachedParquetLoader_Boolean, IHaveTimestreamInfluxDBParameterGroupTypesDurationPreemptiveCacheAge, IHaveTimestreamInfluxDBParameterGroupTypesDurationLastCacheEvictionInterval, IHaveDataFusionRuntimeType, IHaveMaxHttpRequestSize_Integer, IHaveDataFusionMaxParquetFanout_Integer, IHaveQueryFileLimit_Integer, IHaveDataFusionRuntimeGlobalQueueInterval_Integer, IHaveCompactionMaxNumFilesPerPlan_Integer, IHaveCompactionRowLimit_Integer, IHaveWalReplayConcurrencyLimit_Integer, IHaveTimestreamInfluxDBParameterGroupTypesPercentOrAbsoluteLongParquetMemCacheSize, IHaveTimestreamInfluxDBParameterGroupTypesDurationReplicationInterval, IHaveIngestQueryInstances_Integer, IHaveDataFusionRuntimeEventInterval_Integer, IHaveLogFormat, IHaveWalSnapshotSize_Integer, IHaveSnapshottedWalFilesToKeep_Integer, IHaveTimestreamInfluxDBParameterGroupTypesDurationCompactionCheckInterval, IHaveTimestreamInfluxDBParameterGroupTypesPercentOrAbsoluteLongExecMemPoolBytes, IHaveQueryOnlyInstances_Integer, IHaveTimestreamInfluxDBParameterGroupTypesDurationGen1Duration, IHaveTableIndexCacheConcurrencyLimit_Integer, IHaveTimestreamInfluxDBParameterGroupTypesDurationDistinctCacheEvictionInterval, IHaveWalMaxWriteBufferSize_Integer, IHaveDedicatedCompactor_Boolean
        {
            /// <summary>
            /// ParquetMemCachePrunePercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-parquetmemcacheprunepercentage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ParquetMemCachePrunePercentage { get; set; }
            /// <summary>
            /// CatalogSyncInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-catalogsyncinterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? CatalogSyncInterval { get; set; }
            /// <summary>
            /// DataFusionNumThreads
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionnumthreads
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFusionNumThreads { get; set; }
            /// <summary>
            /// WalReplayFailOnError
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-walreplayfailonerror
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? WalReplayFailOnError { get; set; }
            /// <summary>
            /// CompactionGen2Duration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-compactiongen2duration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? CompactionGen2Duration { get; set; }
            /// <summary>
            /// ParquetMemCachePruneInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-parquetmemcachepruneinterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? ParquetMemCachePruneInterval { get; set; }
            /// <summary>
            /// DataFusionRuntimeMaxBlockingThreads
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionruntimemaxblockingthreads
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFusionRuntimeMaxBlockingThreads { get; set; }
            /// <summary>
            /// DistinctValueCacheDisableFromHistory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-distinctvaluecachedisablefromhistory
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DistinctValueCacheDisableFromHistory { get; set; }
            /// <summary>
            /// ForceSnapshotMemThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-forcesnapshotmemthreshold
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PercentOrAbsoluteLong
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.PercentOrAbsoluteLong, BaseFunction>? ForceSnapshotMemThreshold { get; set; }
            /// <summary>
            /// HardDeleteDefaultDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-harddeletedefaultduration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? HardDeleteDefaultDuration { get; set; }
            /// <summary>
            /// DataFusionRuntimeThreadPriority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionruntimethreadpriority
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFusionRuntimeThreadPriority { get; set; }
            /// <summary>
            /// CompactionCleanupWait
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-compactioncleanupwait
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? CompactionCleanupWait { get; set; }
            /// <summary>
            /// TableIndexCacheMaxEntries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-tableindexcachemaxentries
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TableIndexCacheMaxEntries { get; set; }
            /// <summary>
            /// DataFusionRuntimeDisableLifoSlot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionruntimedisablelifoslot
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DataFusionRuntimeDisableLifoSlot { get; set; }
            /// <summary>
            /// DataFusionRuntimeMaxIoEventsPerTick
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionruntimemaxioeventspertick
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFusionRuntimeMaxIoEventsPerTick { get; set; }
            /// <summary>
            /// ParquetMemCacheQueryPathDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-parquetmemcachequerypathduration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? ParquetMemCacheQueryPathDuration { get; set; }
            /// <summary>
            /// DataFusionRuntimeThreadKeepAlive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionruntimethreadkeepalive
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? DataFusionRuntimeThreadKeepAlive { get; set; }
            /// <summary>
            /// Gen1LookbackDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-gen1lookbackduration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? Gen1LookbackDuration { get; set; }
            /// <summary>
            /// QueryLogSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-querylogsize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? QueryLogSize { get; set; }
            /// <summary>
            /// DataFusionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionconfig
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataFusionConfig { get; set; }
            /// <summary>
            /// LastValueCacheDisableFromHistory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-lastvaluecachedisablefromhistory
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? LastValueCacheDisableFromHistory { get; set; }
            /// <summary>
            /// DisableParquetMemCache
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-disableparquetmemcache
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableParquetMemCache { get; set; }
            /// <summary>
            /// DeleteGracePeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-deletegraceperiod
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? DeleteGracePeriod { get; set; }
            /// <summary>
            /// RetentionCheckInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-retentioncheckinterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? RetentionCheckInterval { get; set; }
            /// <summary>
            /// LogFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-logfilter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogFilter { get; set; }
            /// <summary>
            /// CompactionMultipliers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-compactionmultipliers
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CompactionMultipliers { get; set; }
            /// <summary>
            /// DataFusionUseCachedParquetLoader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionusecachedparquetloader
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DataFusionUseCachedParquetLoader { get; set; }
            /// <summary>
            /// PreemptiveCacheAge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-preemptivecacheage
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? PreemptiveCacheAge { get; set; }
            /// <summary>
            /// LastCacheEvictionInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-lastcacheevictioninterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? LastCacheEvictionInterval { get; set; }
            /// <summary>
            /// DataFusionRuntimeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionruntimetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataFusionRuntimeType { get; set; }
            /// <summary>
            /// MaxHttpRequestSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-maxhttprequestsize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxHttpRequestSize { get; set; }
            /// <summary>
            /// DataFusionMaxParquetFanout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionmaxparquetfanout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFusionMaxParquetFanout { get; set; }
            /// <summary>
            /// QueryFileLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-queryfilelimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? QueryFileLimit { get; set; }
            /// <summary>
            /// DataFusionRuntimeGlobalQueueInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionruntimeglobalqueueinterval
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFusionRuntimeGlobalQueueInterval { get; set; }
            /// <summary>
            /// CompactionMaxNumFilesPerPlan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-compactionmaxnumfilesperplan
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CompactionMaxNumFilesPerPlan { get; set; }
            /// <summary>
            /// CompactionRowLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-compactionrowlimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CompactionRowLimit { get; set; }
            /// <summary>
            /// WalReplayConcurrencyLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-walreplayconcurrencylimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WalReplayConcurrencyLimit { get; set; }
            /// <summary>
            /// ParquetMemCacheSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-parquetmemcachesize
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PercentOrAbsoluteLong
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.PercentOrAbsoluteLong, BaseFunction>? ParquetMemCacheSize { get; set; }
            /// <summary>
            /// ReplicationInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-replicationinterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? ReplicationInterval { get; set; }
            /// <summary>
            /// IngestQueryInstances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-ingestqueryinstances
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IngestQueryInstances { get; set; }
            /// <summary>
            /// DataFusionRuntimeEventInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-datafusionruntimeeventinterval
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFusionRuntimeEventInterval { get; set; }
            /// <summary>
            /// LogFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-logformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogFormat { get; set; }
            /// <summary>
            /// WalSnapshotSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-walsnapshotsize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WalSnapshotSize { get; set; }
            /// <summary>
            /// SnapshottedWalFilesToKeep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-snapshottedwalfilestokeep
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SnapshottedWalFilesToKeep { get; set; }
            /// <summary>
            /// CompactionCheckInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-compactioncheckinterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? CompactionCheckInterval { get; set; }
            /// <summary>
            /// ExecMemPoolBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-execmempoolbytes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PercentOrAbsoluteLong
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.PercentOrAbsoluteLong, BaseFunction>? ExecMemPoolBytes { get; set; }
            /// <summary>
            /// QueryOnlyInstances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-queryonlyinstances
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? QueryOnlyInstances { get; set; }
            /// <summary>
            /// Gen1Duration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-gen1duration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? Gen1Duration { get; set; }
            /// <summary>
            /// TableIndexCacheConcurrencyLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-tableindexcacheconcurrencylimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TableIndexCacheConcurrencyLimit { get; set; }
            /// <summary>
            /// DistinctCacheEvictionInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-distinctcacheevictioninterval
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration, BaseFunction>? DistinctCacheEvictionInterval { get; set; }
            /// <summary>
            /// WalMaxWriteBufferSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-walmaxwritebuffersize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WalMaxWriteBufferSize { get; set; }
            /// <summary>
            /// DedicatedCompactor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-influxdbv3enterpriseparameters.html#cfn-timestream-influxdbparametergroup-influxdbv3enterpriseparameters-dedicatedcompactor
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DedicatedCompactor { get; set; }
        }

        public class Parameters : Humidifier.Base.BaseSubResource, IHaveTimestreamInfluxDBParameterGroupTypesInfluxDBv3CoreParametersInfluxDBv3Core, IHaveTimestreamInfluxDBParameterGroupTypesInfluxDBv2ParametersInfluxDBv2, IHaveTimestreamInfluxDBParameterGroupTypesInfluxDBv3EnterpriseParametersInfluxDBv3Enterprise
        {
            /// <summary>
            /// InfluxDBv3Core
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-parameters.html#cfn-timestream-influxdbparametergroup-parameters-influxdbv3core
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InfluxDBv3CoreParameters
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.InfluxDBv3CoreParameters, BaseFunction>? InfluxDBv3Core { get; set; }
            /// <summary>
            /// InfluxDBv2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-parameters.html#cfn-timestream-influxdbparametergroup-parameters-influxdbv2
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InfluxDBv2Parameters
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.InfluxDBv2Parameters, BaseFunction>? InfluxDBv2 { get; set; }
            /// <summary>
            /// InfluxDBv3Enterprise
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-parameters.html#cfn-timestream-influxdbparametergroup-parameters-influxdbv3enterprise
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InfluxDBv3EnterpriseParameters
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBParameterGroupTypes.InfluxDBv3EnterpriseParameters, BaseFunction>? InfluxDBv3Enterprise { get; set; }
        }

        public class PercentOrAbsoluteLong : Humidifier.Base.BaseSubResource, IHaveAbsolute_Integer, IHavePercent
        {
            /// <summary>
            /// Absolute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-percentorabsolutelong.html#cfn-timestream-influxdbparametergroup-percentorabsolutelong-absolute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Absolute { get; set; }
            /// <summary>
            /// Percent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-percentorabsolutelong.html#cfn-timestream-influxdbparametergroup-percentorabsolutelong-percent
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Percent { get; set; }
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
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbparametergroup-tagsitems.html#cfn-timestream-influxdbparametergroup-tagsitems-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}