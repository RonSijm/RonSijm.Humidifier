namespace Humidifier.VpcLattice
{
    using System.Collections.Generic;
    using ResourceConfigurationTypes;

    public class ResourceConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveProtocolType
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.VpcLattice.ResourceConfiguration; }
        /// <summary>
        /// AllowAssociationToSharableServiceNetwork
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-allowassociationtosharableservicenetwork
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AllowAssociationToSharableServiceNetwork { get; set; }
        /// <summary>
        /// ProtocolType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-protocoltype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProtocolType { get; set; }
        /// <summary>
        /// ResourceConfigurationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-resourceconfigurationtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceConfigurationType { get; set; }
        /// <summary>
        /// PortRanges
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-portranges
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic PortRanges { get; set; }
        /// <summary>
        /// ResourceConfigurationDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-resourceconfigurationdefinition
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ResourceConfigurationDefinition
        /// </summary>
        public Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition ResourceConfigurationDefinition { get; set; }
        /// <summary>
        /// ResourceGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-resourcegatewayid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceGatewayId { get; set; }
        /// <summary>
        /// ResourceConfigurationAuthType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-resourceconfigurationauthtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceConfigurationAuthType { get; set; }
        /// <summary>
        /// ResourceConfigurationGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-resourceconfigurationgroupid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceConfigurationGroupId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ResourceConfigurationTypes
    {
        public class DnsResource : Humidifier.Base.BaseSubResource, IHaveDomainName, IHaveIpAddressType
        {
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-resourceconfiguration-dnsresource.html#cfn-vpclattice-resourceconfiguration-dnsresource-ipaddresstype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IpAddressType { get; set; }
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-resourceconfiguration-dnsresource.html#cfn-vpclattice-resourceconfiguration-dnsresource-domainname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DomainName { get; set; }
        }

        public class ResourceConfigurationDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IpResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-resourceconfiguration-resourceconfigurationdefinition.html#cfn-vpclattice-resourceconfiguration-resourceconfigurationdefinition-ipresource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IpResource { get; set; }
            /// <summary>
            /// DnsResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-resourceconfiguration-resourceconfigurationdefinition.html#cfn-vpclattice-resourceconfiguration-resourceconfigurationdefinition-dnsresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DnsResource
            /// </summary>
            public Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource DnsResource { get; set; }
            /// <summary>
            /// ArnResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-resourceconfiguration-resourceconfigurationdefinition.html#cfn-vpclattice-resourceconfiguration-resourceconfigurationdefinition-arnresource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ArnResource { get; set; }
        }
    }
}