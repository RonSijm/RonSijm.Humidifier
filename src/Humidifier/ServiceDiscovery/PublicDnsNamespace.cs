namespace Humidifier.ServiceDiscovery
{
    using System.Collections.Generic;
    using PublicDnsNamespaceTypes;

    public class PublicDnsNamespace : Humidifier.Resource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string HostedZoneId =  "HostedZoneId" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::ServiceDiscovery::PublicDnsNamespace";
            }
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-publicdnsnamespace.html#cfn-servicediscovery-publicdnsnamespace-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Properties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-publicdnsnamespace.html#cfn-servicediscovery-publicdnsnamespace-properties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Properties
        /// </summary>
        public Properties Properties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-publicdnsnamespace.html#cfn-servicediscovery-publicdnsnamespace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-publicdnsnamespace.html#cfn-servicediscovery-publicdnsnamespace-name
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace PublicDnsNamespaceTypes
    {
        public class Properties
        {
            /// <summary>
            /// DnsProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-publicdnsnamespace-properties.html#cfn-servicediscovery-publicdnsnamespace-properties-dnsproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PublicDnsPropertiesMutable
            /// </summary>
            public PublicDnsPropertiesMutable DnsProperties { get; set; }
        }

        public class PublicDnsPropertiesMutable
        {
            /// <summary>
            /// SOA
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-publicdnsnamespace-publicdnspropertiesmutable.html#cfn-servicediscovery-publicdnsnamespace-publicdnspropertiesmutable-soa
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SOA
            /// </summary>
            public SOA SOA { get; set; }
        }

        public class SOA
        {
            /// <summary>
            /// TTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-publicdnsnamespace-soa.html#cfn-servicediscovery-publicdnsnamespace-soa-ttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TTL { get; set; }
        }
    }
}