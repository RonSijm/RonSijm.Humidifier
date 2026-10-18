namespace Humidifier.NetworkFirewall
{
    using global::System.Collections.Generic;
    using TLSInspectionConfigurationTypes;

    public class TLSInspectionConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveTLSInspectionConfigurationName, IHaveNetworkFirewallTLSInspectionConfigurationTypesTLSInspectionConfigurationTLSInspectionConfiguration_
    {
        public class Attributes
        {
            public static string TLSInspectionConfigurationId =  "TLSInspectionConfigurationId" ;
            public static string TLSInspectionConfigurationArn =  "TLSInspectionConfigurationArn" ;
        }

        public override string AWSTypeName { get => AWS.NetworkFirewall.TLSInspectionConfiguration; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-tlsinspectionconfiguration.html#cfn-networkfirewall-tlsinspectionconfiguration-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        public Union<string, BaseFunction>? TLSInspectionConfigurationName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-tlsinspectionconfiguration.html#cfn-networkfirewall-tlsinspectionconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// TLSInspectionConfiguration_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-tlsinspectionconfiguration.html#cfn-networkfirewall-tlsinspectionconfiguration-tlsinspectionconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TLSInspectionConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration, BaseFunction>? TLSInspectionConfiguration_ { get; set; }
    }

    namespace TLSInspectionConfigurationTypes
    {
        public class Address : Humidifier.Base.BaseSubResource, IHaveAddressDefinition
        {
            /// <summary>
            /// AddressDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-address.html#cfn-networkfirewall-tlsinspectionconfiguration-address-addressdefinition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AddressDefinition { get; set; }
        }

        public class CheckCertificateRevocationStatus : Humidifier.Base.BaseSubResource, IHaveUnknownStatusAction, IHaveRevokedStatusAction
        {
            /// <summary>
            /// UnknownStatusAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-checkcertificaterevocationstatus.html#cfn-networkfirewall-tlsinspectionconfiguration-checkcertificaterevocationstatus-unknownstatusaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnknownStatusAction { get; set; }
            /// <summary>
            /// RevokedStatusAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-checkcertificaterevocationstatus.html#cfn-networkfirewall-tlsinspectionconfiguration-checkcertificaterevocationstatus-revokedstatusaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RevokedStatusAction { get; set; }
        }

        public class PortRange : Humidifier.Base.BaseSubResource, IHaveToPort_Integer, IHaveFromPort_Integer
        {
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-portrange.html#cfn-networkfirewall-tlsinspectionconfiguration-portrange-toport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ToPort { get; set; }
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-portrange.html#cfn-networkfirewall-tlsinspectionconfiguration-portrange-fromport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FromPort { get; set; }
        }

        public class ServerCertificate : Humidifier.Base.BaseSubResource, IHaveResourceArn
        {
            /// <summary>
            /// ResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificate.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificate-resourcearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceArn { get; set; }
        }

        public class ServerCertificateConfiguration : Humidifier.Base.BaseSubResource, IHaveCertificateAuthorityArn, IHaveNetworkFirewallTLSInspectionConfigurationTypesCheckCertificateRevocationStatusCheckCertificateRevocationStatus, IHaveListOfNetworkFirewallTLSInspectionConfigurationTypesServerCertificateScopeScopes, IHaveListOfNetworkFirewallTLSInspectionConfigurationTypesServerCertificateServerCertificates
        {
            /// <summary>
            /// CertificateAuthorityArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificateconfiguration.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificateconfiguration-certificateauthorityarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateAuthorityArn { get; set; }
            /// <summary>
            /// CheckCertificateRevocationStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificateconfiguration.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificateconfiguration-checkcertificaterevocationstatus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CheckCertificateRevocationStatus
            /// </summary>
            public Union<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus, BaseFunction>? CheckCertificateRevocationStatus { get; set; }
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificateconfiguration.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificateconfiguration-scopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServerCertificateScope
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateScope>, IReadOnlyList<Union<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateScope, BaseFunction>>, BaseFunction>? Scopes { get; set; }
            /// <summary>
            /// ServerCertificates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificateconfiguration.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificateconfiguration-servercertificates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServerCertificate
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificate>, IReadOnlyList<Union<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificate, BaseFunction>>, BaseFunction>? ServerCertificates { get; set; }
        }

        public class ServerCertificateScope : Humidifier.Base.BaseSubResource, IHaveIntegerListOfProtocols, IHaveListOfNetworkFirewallTLSInspectionConfigurationTypesPortRangeDestinationPorts, IHaveListOfNetworkFirewallTLSInspectionConfigurationTypesAddressDestinations, IHaveListOfNetworkFirewallTLSInspectionConfigurationTypesAddressSources, IHaveListOfNetworkFirewallTLSInspectionConfigurationTypesPortRangeSourcePorts
        {
            /// <summary>
            /// Protocols
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificatescope.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificatescope-protocols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? Protocols { get; set; }
            /// <summary>
            /// DestinationPorts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificatescope.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificatescope-destinationports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRange
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.PortRange>, IReadOnlyList<Union<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.PortRange, BaseFunction>>, BaseFunction>? DestinationPorts { get; set; }
            /// <summary>
            /// Destinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificatescope.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificatescope-destinations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Address
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.Address>, IReadOnlyList<Union<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.Address, BaseFunction>>, BaseFunction>? Destinations { get; set; }
            /// <summary>
            /// Sources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificatescope.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificatescope-sources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Address
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.Address>, IReadOnlyList<Union<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.Address, BaseFunction>>, BaseFunction>? Sources { get; set; }
            /// <summary>
            /// SourcePorts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificatescope.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificatescope-sourceports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRange
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.PortRange>, IReadOnlyList<Union<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.PortRange, BaseFunction>>, BaseFunction>? SourcePorts { get; set; }
        }

        public class TLSInspectionConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfNetworkFirewallTLSInspectionConfigurationTypesServerCertificateConfigurationServerCertificateConfigurations
        {
            /// <summary>
            /// ServerCertificateConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-tlsinspectionconfiguration.html#cfn-networkfirewall-tlsinspectionconfiguration-tlsinspectionconfiguration-servercertificateconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServerCertificateConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration>, IReadOnlyList<Union<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration, BaseFunction>>, BaseFunction>? ServerCertificateConfigurations { get; set; }
        }
    }
}