namespace Humidifier.NetworkFirewall
{
    using System.Collections.Generic;
    using TLSInspectionConfigurationTypes;

    public class TLSInspectionConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription
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
        public dynamic Description { get; set; }
        public dynamic TLSInspectionConfigurationName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-tlsinspectionconfiguration.html#cfn-networkfirewall-tlsinspectionconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// TLSInspectionConfiguration_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-tlsinspectionconfiguration.html#cfn-networkfirewall-tlsinspectionconfiguration-tlsinspectionconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TLSInspectionConfiguration
        /// </summary>
        [Required]
        public Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration TLSInspectionConfiguration_ { get; set; }
    }

    namespace TLSInspectionConfigurationTypes
    {
        public class Address : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AddressDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-address.html#cfn-networkfirewall-tlsinspectionconfiguration-address-addressdefinition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AddressDefinition { get; set; }
        }

        public class CheckCertificateRevocationStatus : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UnknownStatusAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-checkcertificaterevocationstatus.html#cfn-networkfirewall-tlsinspectionconfiguration-checkcertificaterevocationstatus-unknownstatusaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UnknownStatusAction { get; set; }
            /// <summary>
            /// RevokedStatusAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-checkcertificaterevocationstatus.html#cfn-networkfirewall-tlsinspectionconfiguration-checkcertificaterevocationstatus-revokedstatusaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RevokedStatusAction { get; set; }
        }

        public class PortRange : Humidifier.Base.BaseSubResource, IHaveFromPort, IHaveToPort
        {
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-portrange.html#cfn-networkfirewall-tlsinspectionconfiguration-portrange-fromport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FromPort { get; set; }
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-portrange.html#cfn-networkfirewall-tlsinspectionconfiguration-portrange-toport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ToPort { get; set; }
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
            public dynamic ResourceArn { get; set; }
        }

        public class ServerCertificateConfiguration : Humidifier.Base.BaseSubResource, IHaveCertificateAuthorityArn
        {
            /// <summary>
            /// CertificateAuthorityArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificateconfiguration.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificateconfiguration-certificateauthorityarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateAuthorityArn { get; set; }
            /// <summary>
            /// CheckCertificateRevocationStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificateconfiguration.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificateconfiguration-checkcertificaterevocationstatus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CheckCertificateRevocationStatus
            /// </summary>
            public Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus CheckCertificateRevocationStatus { get; set; }
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificateconfiguration.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificateconfiguration-scopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServerCertificateScope
            /// </summary>
            public List<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateScope> Scopes { get; set; }
            /// <summary>
            /// ServerCertificates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificateconfiguration.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificateconfiguration-servercertificates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServerCertificate
            /// </summary>
            public List<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificate> ServerCertificates { get; set; }
        }

        public class ServerCertificateScope : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Protocols
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificatescope.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificatescope-protocols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> Protocols { get; set; }
            /// <summary>
            /// DestinationPorts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificatescope.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificatescope-destinationports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRange
            /// </summary>
            public List<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.PortRange> DestinationPorts { get; set; }
            /// <summary>
            /// Destinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificatescope.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificatescope-destinations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Address
            /// </summary>
            public List<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.Address> Destinations { get; set; }
            /// <summary>
            /// Sources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificatescope.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificatescope-sources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Address
            /// </summary>
            public List<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.Address> Sources { get; set; }
            /// <summary>
            /// SourcePorts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-servercertificatescope.html#cfn-networkfirewall-tlsinspectionconfiguration-servercertificatescope-sourceports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRange
            /// </summary>
            public List<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.PortRange> SourcePorts { get; set; }
        }

        public class TLSInspectionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ServerCertificateConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-tlsinspectionconfiguration-tlsinspectionconfiguration.html#cfn-networkfirewall-tlsinspectionconfiguration-tlsinspectionconfiguration-servercertificateconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServerCertificateConfiguration
            /// </summary>
            public List<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration> ServerCertificateConfigurations { get; set; }
        }
    }
}