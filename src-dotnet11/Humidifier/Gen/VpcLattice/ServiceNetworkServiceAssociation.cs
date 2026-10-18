namespace Humidifier.VpcLattice
{
    using global::System.Collections.Generic;
    using ServiceNetworkServiceAssociationTypes;

    public class ServiceNetworkServiceAssociation : Humidifier.Base.BaseResource, IHaveTags, IHaveServiceNetworkIdentifier, IHaveVpcLatticeServiceNetworkServiceAssociationTypesDnsEntryDnsEntry, IHaveServiceIdentifier
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
        public Union<string, BaseFunction>? ServiceNetworkIdentifier { get; set; }
        /// <summary>
        /// DnsEntry
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkserviceassociation.html#cfn-vpclattice-servicenetworkserviceassociation-dnsentry
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DnsEntry
        /// </summary>
        public Union<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry, BaseFunction>? DnsEntry { get; set; }
        /// <summary>
        /// ServiceIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkserviceassociation.html#cfn-vpclattice-servicenetworkserviceassociation-serviceidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServiceIdentifier { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkserviceassociation.html#cfn-vpclattice-servicenetworkserviceassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
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
            public Union<string, BaseFunction>? DomainName { get; set; }
            /// <summary>
            /// HostedZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-servicenetworkserviceassociation-dnsentry.html#cfn-vpclattice-servicenetworkserviceassociation-dnsentry-hostedzoneid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostedZoneId { get; set; }
        }
    }
}