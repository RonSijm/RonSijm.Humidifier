namespace Humidifier.ServiceDiscovery
{
    using System.Collections.Generic;
    using PrivateDnsNamespaceTypes;

    public class PrivateDnsNamespace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription
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
                return @"AWS::ServiceDiscovery::PrivateDnsNamespace";
            }
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-privatednsnamespace.html#cfn-servicediscovery-privatednsnamespace-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Vpc
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-privatednsnamespace.html#cfn-servicediscovery-privatednsnamespace-vpc
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Vpc { get; set; }
        /// <summary>
        /// Properties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-privatednsnamespace.html#cfn-servicediscovery-privatednsnamespace-properties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Properties
        /// </summary>
        public PrivateDnsNamespaceTypes.Properties Properties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-privatednsnamespace.html#cfn-servicediscovery-privatednsnamespace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace PrivateDnsNamespaceTypes
    {
        public class PrivateDnsPropertiesMutable : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SOA
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-privatednsnamespace-privatednspropertiesmutable.html#cfn-servicediscovery-privatednsnamespace-privatednspropertiesmutable-soa
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SOA
            /// </summary>
            public PrivateDnsNamespaceTypes.SOA SOA { get; set; }
        }

        public class Properties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DnsProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-privatednsnamespace-properties.html#cfn-servicediscovery-privatednsnamespace-properties-dnsproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrivateDnsPropertiesMutable
            /// </summary>
            public PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable DnsProperties { get; set; }
        }

        public class SOA : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-privatednsnamespace-soa.html#cfn-servicediscovery-privatednsnamespace-soa-ttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TTL { get; set; }
        }
    }
}