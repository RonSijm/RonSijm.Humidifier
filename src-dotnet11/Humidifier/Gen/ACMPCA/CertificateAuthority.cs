namespace Humidifier.ACMPCA
{
    using global::System.Collections.Generic;
    using CertificateAuthorityTypes;

    public class CertificateAuthority : Humidifier.Base.BaseResource, IHaveTags, IHaveACMPCACertificateAuthorityTypesCsrExtensionsCsrExtensions, IHaveType, IHaveACMPCACertificateAuthorityTypesRevocationConfigurationRevocationConfiguration, IHaveUsageMode, IHaveSigningAlgorithm, IHaveKeyStorageSecurityStandard, IHaveACMPCACertificateAuthorityTypesSubjectSubject, IHaveKeyAlgorithm
    {
        public class Attributes
        {
            public static string CertificateSigningRequest =  "CertificateSigningRequest" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ACMPCA.CertificateAuthority; }
        /// <summary>
        /// CsrExtensions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificateauthority.html#cfn-acmpca-certificateauthority-csrextensions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: CsrExtensions
        /// </summary>
        public Union<Humidifier.ACMPCA.CertificateAuthorityTypes.CsrExtensions, BaseFunction>? CsrExtensions { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificateauthority.html#cfn-acmpca-certificateauthority-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// RevocationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificateauthority.html#cfn-acmpca-certificateauthority-revocationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RevocationConfiguration
        /// </summary>
        public Union<Humidifier.ACMPCA.CertificateAuthorityTypes.RevocationConfiguration, BaseFunction>? RevocationConfiguration { get; set; }
        /// <summary>
        /// UsageMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificateauthority.html#cfn-acmpca-certificateauthority-usagemode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UsageMode { get; set; }

        /// <summary>
        /// SigningAlgorithm
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificateauthority.html#cfn-acmpca-certificateauthority-signingalgorithm
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SigningAlgorithm { get; set; }
        /// <summary>
        /// KeyStorageSecurityStandard
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificateauthority.html#cfn-acmpca-certificateauthority-keystoragesecuritystandard
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KeyStorageSecurityStandard { get; set; }

        /// <summary>
        /// Subject
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificateauthority.html#cfn-acmpca-certificateauthority-subject
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Subject
        /// </summary>
        [Required]
        public Union<Humidifier.ACMPCA.CertificateAuthorityTypes.Subject, BaseFunction>? Subject { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificateauthority.html#cfn-acmpca-certificateauthority-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// KeyAlgorithm
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificateauthority.html#cfn-acmpca-certificateauthority-keyalgorithm
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? KeyAlgorithm { get; set; }
    }

    namespace CertificateAuthorityTypes
    {
        public class AccessDescription : Humidifier.Base.BaseSubResource, IHaveACMPCACertificateAuthorityTypesAccessMethodAccessMethod, IHaveACMPCACertificateAuthorityTypesGeneralNameAccessLocation
        {
            /// <summary>
            /// AccessMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-accessdescription.html#cfn-acmpca-certificateauthority-accessdescription-accessmethod
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AccessMethod
            /// </summary>
            public Union<Humidifier.ACMPCA.CertificateAuthorityTypes.AccessMethod, BaseFunction>? AccessMethod { get; set; }
            /// <summary>
            /// AccessLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-accessdescription.html#cfn-acmpca-certificateauthority-accessdescription-accesslocation
            /// Required: True
            /// UpdateType: Immutable
            /// Type: GeneralName
            /// </summary>
            public Union<Humidifier.ACMPCA.CertificateAuthorityTypes.GeneralName, BaseFunction>? AccessLocation { get; set; }
        }

        public class AccessMethod : Humidifier.Base.BaseSubResource, IHaveCustomObjectIdentifier, IHaveAccessMethodType
        {
            /// <summary>
            /// CustomObjectIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-accessmethod.html#cfn-acmpca-certificateauthority-accessmethod-customobjectidentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomObjectIdentifier { get; set; }
            /// <summary>
            /// AccessMethodType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-accessmethod.html#cfn-acmpca-certificateauthority-accessmethod-accessmethodtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessMethodType { get; set; }
        }

        public class CrlConfiguration : Humidifier.Base.BaseSubResource, IHaveACMPCACertificateAuthorityTypesCrlDistributionPointExtensionConfigurationCrlDistributionPointExtensionConfiguration, IHaveCustomCname, IHaveS3ObjectAcl, IHaveCrlType, IHaveExpirationInDays_Integer, IHaveEnabled_Boolean, IHaveS3BucketName, IHaveCustomPath
        {
            /// <summary>
            /// CrlDistributionPointExtensionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-crlconfiguration.html#cfn-acmpca-certificateauthority-crlconfiguration-crldistributionpointextensionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CrlDistributionPointExtensionConfiguration
            /// </summary>
            public Union<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration, BaseFunction>? CrlDistributionPointExtensionConfiguration { get; set; }
            /// <summary>
            /// CustomCname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-crlconfiguration.html#cfn-acmpca-certificateauthority-crlconfiguration-customcname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomCname { get; set; }
            /// <summary>
            /// S3ObjectAcl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-crlconfiguration.html#cfn-acmpca-certificateauthority-crlconfiguration-s3objectacl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3ObjectAcl { get; set; }
            /// <summary>
            /// CrlType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-crlconfiguration.html#cfn-acmpca-certificateauthority-crlconfiguration-crltype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrlType { get; set; }
            /// <summary>
            /// ExpirationInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-crlconfiguration.html#cfn-acmpca-certificateauthority-crlconfiguration-expirationindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ExpirationInDays { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-crlconfiguration.html#cfn-acmpca-certificateauthority-crlconfiguration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-crlconfiguration.html#cfn-acmpca-certificateauthority-crlconfiguration-s3bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketName { get; set; }
            /// <summary>
            /// CustomPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-crlconfiguration.html#cfn-acmpca-certificateauthority-crlconfiguration-custompath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomPath { get; set; }
        }

        public class CrlDistributionPointExtensionConfiguration : Humidifier.Base.BaseSubResource, IHaveOmitExtension_Boolean
        {
            /// <summary>
            /// OmitExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-crldistributionpointextensionconfiguration.html#cfn-acmpca-certificateauthority-crldistributionpointextensionconfiguration-omitextension
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OmitExtension { get; set; }
        }

        public class CsrExtensions : Humidifier.Base.BaseSubResource, IHaveACMPCACertificateAuthorityTypesKeyUsageKeyUsage, IHaveListOfACMPCACertificateAuthorityTypesAccessDescriptionSubjectInformationAccess
        {
            /// <summary>
            /// KeyUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-csrextensions.html#cfn-acmpca-certificateauthority-csrextensions-keyusage
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KeyUsage
            /// </summary>
            public Union<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage, BaseFunction>? KeyUsage { get; set; }
            /// <summary>
            /// SubjectInformationAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-csrextensions.html#cfn-acmpca-certificateauthority-csrextensions-subjectinformationaccess
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AccessDescription
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ACMPCA.CertificateAuthorityTypes.AccessDescription>, IReadOnlyList<Union<Humidifier.ACMPCA.CertificateAuthorityTypes.AccessDescription, BaseFunction>>, BaseFunction>? SubjectInformationAccess { get; set; }
        }

        public class CustomAttribute : Humidifier.Base.BaseSubResource, IHaveValue, IHaveObjectIdentifier
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-customattribute.html#cfn-acmpca-certificateauthority-customattribute-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// ObjectIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-customattribute.html#cfn-acmpca-certificateauthority-customattribute-objectidentifier
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectIdentifier { get; set; }
        }

        public class EdiPartyName : Humidifier.Base.BaseSubResource, IHavePartyName, IHaveNameAssigner
        {
            /// <summary>
            /// PartyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-edipartyname.html#cfn-acmpca-certificateauthority-edipartyname-partyname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PartyName { get; set; }
            /// <summary>
            /// NameAssigner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-edipartyname.html#cfn-acmpca-certificateauthority-edipartyname-nameassigner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NameAssigner { get; set; }
        }

        public class GeneralName : Humidifier.Base.BaseSubResource, IHaveUniformResourceIdentifier, IHaveDnsName, IHaveACMPCACertificateAuthorityTypesEdiPartyNameEdiPartyName, IHaveRegisteredId, IHaveRfc822Name, IHaveACMPCACertificateAuthorityTypesOtherNameOtherName, IHaveIpAddress, IHaveACMPCACertificateAuthorityTypesSubjectDirectoryName
        {
            /// <summary>
            /// UniformResourceIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-generalname.html#cfn-acmpca-certificateauthority-generalname-uniformresourceidentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UniformResourceIdentifier { get; set; }
            /// <summary>
            /// DnsName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-generalname.html#cfn-acmpca-certificateauthority-generalname-dnsname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DnsName { get; set; }
            /// <summary>
            /// EdiPartyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-generalname.html#cfn-acmpca-certificateauthority-generalname-edipartyname
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EdiPartyName
            /// </summary>
            public Union<Humidifier.ACMPCA.CertificateAuthorityTypes.EdiPartyName, BaseFunction>? EdiPartyName { get; set; }
            /// <summary>
            /// RegisteredId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-generalname.html#cfn-acmpca-certificateauthority-generalname-registeredid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegisteredId { get; set; }
            /// <summary>
            /// Rfc822Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-generalname.html#cfn-acmpca-certificateauthority-generalname-rfc822name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Rfc822Name { get; set; }
            /// <summary>
            /// OtherName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-generalname.html#cfn-acmpca-certificateauthority-generalname-othername
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OtherName
            /// </summary>
            public Union<Humidifier.ACMPCA.CertificateAuthorityTypes.OtherName, BaseFunction>? OtherName { get; set; }
            /// <summary>
            /// IpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-generalname.html#cfn-acmpca-certificateauthority-generalname-ipaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddress { get; set; }
            /// <summary>
            /// DirectoryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-generalname.html#cfn-acmpca-certificateauthority-generalname-directoryname
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Subject
            /// </summary>
            public Union<Humidifier.ACMPCA.CertificateAuthorityTypes.Subject, BaseFunction>? DirectoryName { get; set; }
        }

        public class KeyUsage : Humidifier.Base.BaseSubResource, IHaveKeyEncipherment_Boolean, IHaveDataEncipherment_Boolean, IHaveDigitalSignature_Boolean, IHaveKeyCertSign_Boolean, IHaveDecipherOnly_Boolean, IHaveKeyAgreement_Boolean, IHaveNonRepudiation_Boolean, IHaveCRLSign_Boolean, IHaveEncipherOnly_Boolean
        {
            /// <summary>
            /// KeyEncipherment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-keyusage.html#cfn-acmpca-certificateauthority-keyusage-keyencipherment
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? KeyEncipherment { get; set; }
            /// <summary>
            /// DataEncipherment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-keyusage.html#cfn-acmpca-certificateauthority-keyusage-dataencipherment
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DataEncipherment { get; set; }
            /// <summary>
            /// DigitalSignature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-keyusage.html#cfn-acmpca-certificateauthority-keyusage-digitalsignature
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DigitalSignature { get; set; }
            /// <summary>
            /// KeyCertSign
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-keyusage.html#cfn-acmpca-certificateauthority-keyusage-keycertsign
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? KeyCertSign { get; set; }
            /// <summary>
            /// DecipherOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-keyusage.html#cfn-acmpca-certificateauthority-keyusage-decipheronly
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DecipherOnly { get; set; }
            /// <summary>
            /// KeyAgreement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-keyusage.html#cfn-acmpca-certificateauthority-keyusage-keyagreement
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? KeyAgreement { get; set; }
            /// <summary>
            /// NonRepudiation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-keyusage.html#cfn-acmpca-certificateauthority-keyusage-nonrepudiation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? NonRepudiation { get; set; }
            /// <summary>
            /// CRLSign
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-keyusage.html#cfn-acmpca-certificateauthority-keyusage-crlsign
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CRLSign { get; set; }
            /// <summary>
            /// EncipherOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-keyusage.html#cfn-acmpca-certificateauthority-keyusage-encipheronly
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EncipherOnly { get; set; }
        }

        public class OcspConfiguration : Humidifier.Base.BaseSubResource, IHaveOcspCustomCname, IHaveEnabled_Boolean
        {
            /// <summary>
            /// OcspCustomCname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-ocspconfiguration.html#cfn-acmpca-certificateauthority-ocspconfiguration-ocspcustomcname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OcspCustomCname { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-ocspconfiguration.html#cfn-acmpca-certificateauthority-ocspconfiguration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class OtherName : Humidifier.Base.BaseSubResource, IHaveTypeId, IHaveValue
        {
            /// <summary>
            /// TypeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-othername.html#cfn-acmpca-certificateauthority-othername-typeid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TypeId { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-othername.html#cfn-acmpca-certificateauthority-othername-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class RevocationConfiguration : Humidifier.Base.BaseSubResource, IHaveACMPCACertificateAuthorityTypesOcspConfigurationOcspConfiguration, IHaveACMPCACertificateAuthorityTypesCrlConfigurationCrlConfiguration
        {
            /// <summary>
            /// OcspConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-revocationconfiguration.html#cfn-acmpca-certificateauthority-revocationconfiguration-ocspconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OcspConfiguration
            /// </summary>
            public Union<Humidifier.ACMPCA.CertificateAuthorityTypes.OcspConfiguration, BaseFunction>? OcspConfiguration { get; set; }
            /// <summary>
            /// CrlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-revocationconfiguration.html#cfn-acmpca-certificateauthority-revocationconfiguration-crlconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CrlConfiguration
            /// </summary>
            public Union<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlConfiguration, BaseFunction>? CrlConfiguration { get; set; }
        }

        public class Subject : Humidifier.Base.BaseSubResource, IHaveOrganization, IHaveOrganizationalUnit, IHaveLocality, IHaveTitle, IHaveGivenName, IHaveGenerationQualifier, IHaveInitials, IHaveListOfACMPCACertificateAuthorityTypesCustomAttributeCustomAttributes, IHaveSerialNumber, IHaveState, IHaveCountry, IHaveSurname, IHaveDistinguishedNameQualifier, IHaveCommonName, IHavePseudonym
        {
            /// <summary>
            /// Organization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-subject.html#cfn-acmpca-certificateauthority-subject-organization
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Organization { get; set; }
            /// <summary>
            /// OrganizationalUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-subject.html#cfn-acmpca-certificateauthority-subject-organizationalunit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrganizationalUnit { get; set; }
            /// <summary>
            /// Locality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-subject.html#cfn-acmpca-certificateauthority-subject-locality
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Locality { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-subject.html#cfn-acmpca-certificateauthority-subject-title
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Title { get; set; }
            /// <summary>
            /// GivenName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-subject.html#cfn-acmpca-certificateauthority-subject-givenname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GivenName { get; set; }
            /// <summary>
            /// GenerationQualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-subject.html#cfn-acmpca-certificateauthority-subject-generationqualifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GenerationQualifier { get; set; }
            /// <summary>
            /// Initials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-subject.html#cfn-acmpca-certificateauthority-subject-initials
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Initials { get; set; }
            /// <summary>
            /// CustomAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-subject.html#cfn-acmpca-certificateauthority-subject-customattributes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: CustomAttribute
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ACMPCA.CertificateAuthorityTypes.CustomAttribute>, IReadOnlyList<Union<Humidifier.ACMPCA.CertificateAuthorityTypes.CustomAttribute, BaseFunction>>, BaseFunction>? CustomAttributes { get; set; }
            /// <summary>
            /// SerialNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-subject.html#cfn-acmpca-certificateauthority-subject-serialnumber
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SerialNumber { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-subject.html#cfn-acmpca-certificateauthority-subject-state
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// Country
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-subject.html#cfn-acmpca-certificateauthority-subject-country
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Country { get; set; }
            /// <summary>
            /// Surname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-subject.html#cfn-acmpca-certificateauthority-subject-surname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Surname { get; set; }
            /// <summary>
            /// DistinguishedNameQualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-subject.html#cfn-acmpca-certificateauthority-subject-distinguishednamequalifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DistinguishedNameQualifier { get; set; }
            /// <summary>
            /// CommonName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-subject.html#cfn-acmpca-certificateauthority-subject-commonname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CommonName { get; set; }
            /// <summary>
            /// Pseudonym
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-subject.html#cfn-acmpca-certificateauthority-subject-pseudonym
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Pseudonym { get; set; }
        }
    }
}