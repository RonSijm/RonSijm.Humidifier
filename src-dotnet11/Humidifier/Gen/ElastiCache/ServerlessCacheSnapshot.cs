namespace Humidifier.ElastiCache
{
    using global::System.Collections.Generic;
    using ServerlessCacheSnapshotTypes;

    public class ServerlessCacheSnapshot : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveServerlessCacheSnapshotName, IHaveKmsKeyId, IHaveServerlessCacheName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreateTime =  "CreateTime" ;
            public static string ServerlessCacheConfiguration =  "ServerlessCacheConfiguration" ;
            public static string SnapshotType =  "SnapshotType" ;
            public static string ARN =  "ARN" ;
            public static string BytesUsedForCache =  "BytesUsedForCache" ;
        }

        public override string AWSTypeName { get => AWS.ElastiCache.ServerlessCacheSnapshot; }
        public Union<string, BaseFunction>? ServerlessCacheSnapshotName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscachesnapshot.html#cfn-elasticache-serverlesscachesnapshot-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }

        /// <summary>
        /// ServerlessCacheName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscachesnapshot.html#cfn-elasticache-serverlesscachesnapshot-serverlesscachename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServerlessCacheName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-serverlesscachesnapshot.html#cfn-elasticache-serverlesscachesnapshot-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ServerlessCacheSnapshotTypes
    {
        public class ServerlessCacheConfiguration : Humidifier.Base.BaseSubResource, IHaveServerlessCacheName, IHaveMajorEngineVersion, IHaveEngine
        {
            /// <summary>
            /// ServerlessCacheName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-serverlesscachesnapshot-serverlesscacheconfiguration.html#cfn-elasticache-serverlesscachesnapshot-serverlesscacheconfiguration-serverlesscachename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerlessCacheName { get; set; }
            /// <summary>
            /// MajorEngineVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-serverlesscachesnapshot-serverlesscacheconfiguration.html#cfn-elasticache-serverlesscachesnapshot-serverlesscacheconfiguration-majorengineversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MajorEngineVersion { get; set; }
            /// <summary>
            /// Engine
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-serverlesscachesnapshot-serverlesscacheconfiguration.html#cfn-elasticache-serverlesscachesnapshot-serverlesscacheconfiguration-engine
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Engine { get; set; }
        }
    }
}