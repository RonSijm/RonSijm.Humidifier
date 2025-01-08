namespace Humidifier.VpcLattice
{
    using System.Collections.Generic;
    using ServiceNetworkServiceAssociationTypes;

    public class ServiceNetworkServiceAssociation : Humidifier.Base.BaseResource, IHaveTags, IHaveServiceIdentifier, IHaveServiceNetworkIdentifier
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ServiceNetworkId =  "ServiceNetworkId" ;
            public static string ServiceName =  "ServiceName" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ServiceNetworkName =  "ServiceNetworkName" ;
            public static string ServiceArn =  "ServiceArn" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string ServiceNetworkArn =  "ServiceNetworkArn" ;
            public static string ServiceId =  "ServiceId" ;
        }

        public override string AWSTypeName { get => AWS.VpcLattice.ServiceNetworkServiceAssociation; }
        /// <summary>
        /// ServiceNetworkIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkserviceassociation.html#cfn-vpclattice-servicenetworkserviceassociation-servicenetworkidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServiceNetworkIdentifier { get; set; }
        /// <summary>
        /// DnsEntry
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkserviceassociation.html#cfn-vpclattice-servicenetworkserviceassociation-dnsentry
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DnsEntry
        /// </summary>
        public Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry DnsEntry { get; set; }
        /// <summary>
        /// ServiceIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkserviceassociation.html#cfn-vpclattice-servicenetworkserviceassociation-serviceidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServiceIdentifier { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkserviceassociation.html#cfn-vpclattice-servicenetworkserviceassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ServiceNetworkServiceAssociationTypes
    {
        public class DnsEntry : Humidifier.Base.BaseSubResource, IHaveDomainName, IHaveHostedZoneId
        {
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-servicenetworkserviceassociation-dnsentry.html#cfn-vpclattice-servicenetworkserviceassociation-dnsentry-domainname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DomainName { get; set; }
            /// <summary>
            /// HostedZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-servicenetworkserviceassociation-dnsentry.html#cfn-vpclattice-servicenetworkserviceassociation-dnsentry-hostedzoneid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostedZoneId { get; set; }
        }
    }
}