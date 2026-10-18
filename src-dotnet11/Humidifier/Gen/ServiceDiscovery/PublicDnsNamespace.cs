namespace Humidifier.ServiceDiscovery
{
    using global::System.Collections.Generic;
    using PublicDnsNamespaceTypes;

    public class PublicDnsNamespace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveServiceDiscoveryPublicDnsNamespaceTypesPropertiesProperties, IHaveName
    {
        public class Attributes
        {
            public static string HostedZoneId =  "HostedZoneId" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ServiceDiscovery.PublicDnsNamespace; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-publicdnsnamespace.html#cfn-servicediscovery-publicdnsnamespace-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Properties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-publicdnsnamespace.html#cfn-servicediscovery-publicdnsnamespace-properties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Properties
        /// </summary>
        public Union<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties, BaseFunction>? Properties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-publicdnsnamespace.html#cfn-servicediscovery-publicdnsnamespace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace PublicDnsNamespaceTypes
    {
        public class Properties : Humidifier.Base.BaseSubResource, IHaveServiceDiscoveryPublicDnsNamespaceTypesPublicDnsPropertiesMutableDnsProperties
        {
            /// <summary>
            /// DnsProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-publicdnsnamespace-properties.html#cfn-servicediscovery-publicdnsnamespace-properties-dnsproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PublicDnsPropertiesMutable
            /// </summary>
            public Union<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable, BaseFunction>? DnsProperties { get; set; }
        }

        public class PublicDnsPropertiesMutable : Humidifier.Base.BaseSubResource, IHaveServiceDiscoveryPublicDnsNamespaceTypesSOASOA
        {
            /// <summary>
            /// SOA
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-publicdnsnamespace-publicdnspropertiesmutable.html#cfn-servicediscovery-publicdnsnamespace-publicdnspropertiesmutable-soa
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SOA
            /// </summary>
            public Union<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA, BaseFunction>? SOA { get; set; }
        }

        public class SOA : Humidifier.Base.BaseSubResource, IHaveTTL_Double
        {
            /// <summary>
            /// TTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-publicdnsnamespace-soa.html#cfn-servicediscovery-publicdnsnamespace-soa-ttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TTL { get; set; }
        }
    }
}