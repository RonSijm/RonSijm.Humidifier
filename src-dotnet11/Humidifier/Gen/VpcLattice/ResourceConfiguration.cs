namespace Humidifier.VpcLattice
{
    using global::System.Collections.Generic;
    using ResourceConfigurationTypes;

    public class ResourceConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCustomDomainName, IHaveStringListOfPortRanges, IHaveVpcLatticeResourceConfigurationTypesResourceConfigurationDefinitionResourceConfigurationDefinition, IHaveGroupDomain, IHaveResourceConfigurationAuthType, IHaveResourceConfigurationGroupId, IHaveName, IHaveAllowAssociationToSharableServiceNetwork_Boolean, IHaveProtocolType, IHaveResourceConfigurationType, IHaveDomainVerificationId, IHaveResourceGatewayId
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.VpcLattice.ResourceConfiguration; }
        /// <summary>
        /// CustomDomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-customdomainname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CustomDomainName { get; set; }
        /// <summary>
        /// PortRanges
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-portranges
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PortRanges { get; set; }
        /// <summary>
        /// ResourceConfigurationDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-resourceconfigurationdefinition
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ResourceConfigurationDefinition
        /// </summary>
        public Union<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition, BaseFunction>? ResourceConfigurationDefinition { get; set; }
        /// <summary>
        /// GroupDomain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-groupdomain
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GroupDomain { get; set; }
        /// <summary>
        /// ResourceConfigurationAuthType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-resourceconfigurationauthtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceConfigurationAuthType { get; set; }
        /// <summary>
        /// ResourceConfigurationGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-resourceconfigurationgroupid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceConfigurationGroupId { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AllowAssociationToSharableServiceNetwork
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-allowassociationtosharableservicenetwork
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AllowAssociationToSharableServiceNetwork { get; set; }
        /// <summary>
        /// ProtocolType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-protocoltype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProtocolType { get; set; }

        /// <summary>
        /// ResourceConfigurationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-resourceconfigurationtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceConfigurationType { get; set; }
        /// <summary>
        /// DomainVerificationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-domainverificationid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DomainVerificationId { get; set; }
        /// <summary>
        /// ResourceGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-resourcegatewayid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceGatewayId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-resourceconfiguration.html#cfn-vpclattice-resourceconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ResourceConfigurationTypes
    {
        public class CidrResource : Humidifier.Base.BaseSubResource, IHaveStringListOfCidrRanges
        {
            /// <summary>
            /// CidrRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-resourceconfiguration-cidrresource.html#cfn-vpclattice-resourceconfiguration-cidrresource-cidrranges
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CidrRanges { get; set; }
        }

        public class DnsResource : Humidifier.Base.BaseSubResource, IHaveIpAddressType, IHaveDomainName
        {
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-resourceconfiguration-dnsresource.html#cfn-vpclattice-resourceconfiguration-dnsresource-ipaddresstype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddressType { get; set; }
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-resourceconfiguration-dnsresource.html#cfn-vpclattice-resourceconfiguration-dnsresource-domainname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainName { get; set; }
        }

        public class ResourceConfigurationDefinition : Humidifier.Base.BaseSubResource, IHaveIpResource, IHaveVpcLatticeResourceConfigurationTypesDnsResourceDnsResource, IHaveArnResource, IHaveVpcLatticeResourceConfigurationTypesCidrResourceCidrResource
        {
            /// <summary>
            /// IpResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-resourceconfiguration-resourceconfigurationdefinition.html#cfn-vpclattice-resourceconfiguration-resourceconfigurationdefinition-ipresource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpResource { get; set; }
            /// <summary>
            /// DnsResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-resourceconfiguration-resourceconfigurationdefinition.html#cfn-vpclattice-resourceconfiguration-resourceconfigurationdefinition-dnsresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DnsResource
            /// </summary>
            public Union<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource, BaseFunction>? DnsResource { get; set; }
            /// <summary>
            /// ArnResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-resourceconfiguration-resourceconfigurationdefinition.html#cfn-vpclattice-resourceconfiguration-resourceconfigurationdefinition-arnresource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ArnResource { get; set; }
            /// <summary>
            /// CidrResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-resourceconfiguration-resourceconfigurationdefinition.html#cfn-vpclattice-resourceconfiguration-resourceconfigurationdefinition-cidrresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CidrResource
            /// </summary>
            public Union<Humidifier.VpcLattice.ResourceConfigurationTypes.CidrResource, BaseFunction>? CidrResource { get; set; }
        }
    }
}