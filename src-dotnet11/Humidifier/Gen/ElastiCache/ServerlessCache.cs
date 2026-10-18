namespace Humidifier.ElastiCache
{
    using global::System.Collections.Generic;
    using ServerlessCacheTypes;

    public class ServerlessCache : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveKmsKeyId, IHaveConnectionType, IHaveFinalSnapshotName, IHaveUserGroupId, IHaveElastiCacheServerlessCacheTypesCacheUsageLimitsCacheUsageLimits, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSnapshotArnsToRestore, IHaveStringListOfSubnetIds, IHaveDailySnapshotTime, IHaveElastiCacheServerlessCacheTypesEndpointReaderEndpoint, IHaveSnapshotRetentionLimit_Integer, IHaveElastiCacheServerlessCacheTypesEndpointEndpoint, IHaveNetworkType, IHaveServerlessCacheName, IHaveMajorEngineVersion, IHaveEngine
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string FullEngineVersion =  "FullEngineVersion" ;
            public static string CreateTime =  "CreateTime" ;
            public static string ARN =  "ARN" ;
        }

        public override string AWSTypeName { get => AWS.ElastiCache.ServerlessCache; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscache.html#cfn-elasticache-serverlesscache-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscache.html#cfn-elasticache-serverlesscache-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// ConnectionType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscache.html#cfn-elasticache-serverlesscache-connectiontype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConnectionType { get; set; }
        /// <summary>
        /// FinalSnapshotName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscache.html#cfn-elasticache-serverlesscache-finalsnapshotname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FinalSnapshotName { get; set; }
        /// <summary>
        /// UserGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscache.html#cfn-elasticache-serverlesscache-usergroupid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UserGroupId { get; set; }
        /// <summary>
        /// CacheUsageLimits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscache.html#cfn-elasticache-serverlesscache-cacheusagelimits
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CacheUsageLimits
        /// </summary>
        public Union<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits, BaseFunction>? CacheUsageLimits { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscache.html#cfn-elasticache-serverlesscache-securitygroupids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        /// <summary>
        /// SnapshotArnsToRestore
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscache.html#cfn-elasticache-serverlesscache-snapshotarnstorestore
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SnapshotArnsToRestore { get; set; }
        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscache.html#cfn-elasticache-serverlesscache-subnetids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        /// <summary>
        /// DailySnapshotTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscache.html#cfn-elasticache-serverlesscache-dailysnapshottime
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DailySnapshotTime { get; set; }
        /// <summary>
        /// ReaderEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscache.html#cfn-elasticache-serverlesscache-readerendpoint
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Endpoint
        /// </summary>
        public Union<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint, BaseFunction>? ReaderEndpoint { get; set; }
        /// <summary>
        /// SnapshotRetentionLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscache.html#cfn-elasticache-serverlesscache-snapshotretentionlimit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? SnapshotRetentionLimit { get; set; }
        /// <summary>
        /// Endpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscache.html#cfn-elasticache-serverlesscache-endpoint
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Endpoint
        /// </summary>
        public Union<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint, BaseFunction>? Endpoint { get; set; }
        /// <summary>
        /// NetworkType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscache.html#cfn-elasticache-serverlesscache-networktype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkType { get; set; }
        public Union<string, BaseFunction>? ServerlessCacheName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// MajorEngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscache.html#cfn-elasticache-serverlesscache-majorengineversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MajorEngineVersion { get; set; }

        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscache.html#cfn-elasticache-serverlesscache-engine
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Engine { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscache.html#cfn-elasticache-serverlesscache-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ServerlessCacheTypes
    {
        public class CacheUsageLimits : Humidifier.Base.BaseSubResource, IHaveElastiCacheServerlessCacheTypesDataStorageDataStorage, IHaveElastiCacheServerlessCacheTypesECPUPerSecondECPUPerSecond
        {
            /// <summary>
            /// DataStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-serverlesscache-cacheusagelimits.html#cfn-elasticache-serverlesscache-cacheusagelimits-datastorage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataStorage
            /// </summary>
            public Union<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage, BaseFunction>? DataStorage { get; set; }
            /// <summary>
            /// ECPUPerSecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-serverlesscache-cacheusagelimits.html#cfn-elasticache-serverlesscache-cacheusagelimits-ecpupersecond
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ECPUPerSecond
            /// </summary>
            public Union<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond, BaseFunction>? ECPUPerSecond { get; set; }
        }

        public class DataStorage : Humidifier.Base.BaseSubResource, IHaveMinimum_Integer, IHaveMaximum_Integer, IHaveUnit
        {
            /// <summary>
            /// Minimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-serverlesscache-datastorage.html#cfn-elasticache-serverlesscache-datastorage-minimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Minimum { get; set; }
            /// <summary>
            /// Maximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-serverlesscache-datastorage.html#cfn-elasticache-serverlesscache-datastorage-maximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Maximum { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-serverlesscache-datastorage.html#cfn-elasticache-serverlesscache-datastorage-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class ECPUPerSecond : Humidifier.Base.BaseSubResource, IHaveMinimum_Integer, IHaveMaximum_Integer
        {
            /// <summary>
            /// Minimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-serverlesscache-ecpupersecond.html#cfn-elasticache-serverlesscache-ecpupersecond-minimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Minimum { get; set; }
            /// <summary>
            /// Maximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-serverlesscache-ecpupersecond.html#cfn-elasticache-serverlesscache-ecpupersecond-maximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Maximum { get; set; }
        }

        public class Endpoint : Humidifier.Base.BaseSubResource, IHaveAddress, IHavePort
        {
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-serverlesscache-endpoint.html#cfn-elasticache-serverlesscache-endpoint-address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Address { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-serverlesscache-endpoint.html#cfn-elasticache-serverlesscache-endpoint-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Port { get; set; }
        }
    }
}