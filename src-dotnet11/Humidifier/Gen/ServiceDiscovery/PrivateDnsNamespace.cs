namespace Humidifier.ServiceDiscovery
{
    using global::System.Collections.Generic;
    using PrivateDnsNamespaceTypes;

    public class PrivateDnsNamespace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveVpc, IHaveServiceDiscoveryPrivateDnsNamespaceTypesPropertiesProperties, IHaveName
    {
        public class Attributes
        {
            public static string HostedZoneId =  "HostedZoneId" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ServiceDiscovery.PrivateDnsNamespace; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-privatednsnamespace.html#cfn-servicediscovery-privatednsnamespace-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Vpc
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-privatednsnamespace.html#cfn-servicediscovery-privatednsnamespace-vpc
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Vpc { get; set; }
        /// <summary>
        /// Properties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-privatednsnamespace.html#cfn-servicediscovery-privatednsnamespace-properties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Properties
        /// </summary>
        public Union<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties, BaseFunction>? Properties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-privatednsnamespace.html#cfn-servicediscovery-privatednsnamespace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace PrivateDnsNamespaceTypes
    {
        public class PrivateDnsPropertiesMutable : Humidifier.Base.BaseSubResource, IHaveServiceDiscoveryPrivateDnsNamespaceTypesSOASOA
        {
            /// <summary>
            /// SOA
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-privatednsnamespace-privatednspropertiesmutable.html#cfn-servicediscovery-privatednsnamespace-privatednspropertiesmutable-soa
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SOA
            /// </summary>
            public Union<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA, BaseFunction>? SOA { get; set; }
        }

        public class Properties : Humidifier.Base.BaseSubResource, IHaveServiceDiscoveryPrivateDnsNamespaceTypesPrivateDnsPropertiesMutableDnsProperties
        {
            /// <summary>
            /// DnsProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-privatednsnamespace-properties.html#cfn-servicediscovery-privatednsnamespace-properties-dnsproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrivateDnsPropertiesMutable
            /// </summary>
            public Union<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable, BaseFunction>? DnsProperties { get; set; }
        }

        public class SOA : Humidifier.Base.BaseSubResource, IHaveTTL_Double
        {
            /// <summary>
            /// TTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-privatednsnamespace-soa.html#cfn-servicediscovery-privatednsnamespace-soa-ttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TTL { get; set; }
        }
    }
}