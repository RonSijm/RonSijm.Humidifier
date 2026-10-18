namespace Humidifier.ServiceDiscovery
{
    using global::System.Collections.Generic;
    using ServiceTypes;

    public class Service : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveType, IHaveDescription, IHaveServiceDiscoveryServiceTypesHealthCheckCustomConfigHealthCheckCustomConfig, IHaveServiceDiscoveryServiceTypesDnsConfigDnsConfig, IHaveStringDictionaryOfServiceAttributes, IHaveNamespaceId, IHaveServiceDiscoveryServiceTypesHealthCheckConfigHealthCheckConfig, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.ServiceDiscovery.Service; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-service.html#cfn-servicediscovery-service-type
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-service.html#cfn-servicediscovery-service-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// HealthCheckCustomConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-service.html#cfn-servicediscovery-service-healthcheckcustomconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: HealthCheckCustomConfig
        /// </summary>
        public Union<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig, BaseFunction>? HealthCheckCustomConfig { get; set; }
        /// <summary>
        /// DnsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-service.html#cfn-servicediscovery-service-dnsconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DnsConfig
        /// </summary>
        public Union<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig, BaseFunction>? DnsConfig { get; set; }
        /// <summary>
        /// ServiceAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-service.html#cfn-servicediscovery-service-serviceattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ServiceAttributes { get; set; }
        /// <summary>
        /// NamespaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-service.html#cfn-servicediscovery-service-namespaceid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NamespaceId { get; set; }
        /// <summary>
        /// HealthCheckConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-service.html#cfn-servicediscovery-service-healthcheckconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HealthCheckConfig
        /// </summary>
        public Union<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig, BaseFunction>? HealthCheckConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-service.html#cfn-servicediscovery-service-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ServiceTypes
    {
        public class DnsConfig : Humidifier.Base.BaseSubResource, IHaveListOfServiceDiscoveryServiceTypesDnsRecordDnsRecords, IHaveRoutingPolicy, IHaveNamespaceId
        {
            /// <summary>
            /// DnsRecords
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-dnsconfig.html#cfn-servicediscovery-service-dnsconfig-dnsrecords
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DnsRecord
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ServiceDiscovery.ServiceTypes.DnsRecord>, IReadOnlyList<Union<Humidifier.ServiceDiscovery.ServiceTypes.DnsRecord, BaseFunction>>, BaseFunction>? DnsRecords { get; set; }
            /// <summary>
            /// RoutingPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-dnsconfig.html#cfn-servicediscovery-service-dnsconfig-routingpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoutingPolicy { get; set; }
            /// <summary>
            /// NamespaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-dnsconfig.html#cfn-servicediscovery-service-dnsconfig-namespaceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NamespaceId { get; set; }
        }

        public class DnsRecord : Humidifier.Base.BaseSubResource, IHaveType, IHaveTTL_Double
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-dnsrecord.html#cfn-servicediscovery-service-dnsrecord-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// TTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-dnsrecord.html#cfn-servicediscovery-service-dnsrecord-ttl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TTL { get; set; }
        }

        public class HealthCheckConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveResourcePath, IHaveFailureThreshold_Double
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-healthcheckconfig.html#cfn-servicediscovery-service-healthcheckconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// ResourcePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-healthcheckconfig.html#cfn-servicediscovery-service-healthcheckconfig-resourcepath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourcePath { get; set; }
            /// <summary>
            /// FailureThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-healthcheckconfig.html#cfn-servicediscovery-service-healthcheckconfig-failurethreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? FailureThreshold { get; set; }
        }

        public class HealthCheckCustomConfig : Humidifier.Base.BaseSubResource, IHaveFailureThreshold_Double
        {
            /// <summary>
            /// FailureThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-healthcheckcustomconfig.html#cfn-servicediscovery-service-healthcheckcustomconfig-failurethreshold
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? FailureThreshold { get; set; }
        }
    }
}