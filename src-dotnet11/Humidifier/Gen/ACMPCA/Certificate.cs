namespace Humidifier.ACMPCA
{
    using global::System.Collections.Generic;
    using CertificateTypes;

    public class Certificate : Humidifier.Base.BaseResource, IHaveTemplateArn, IHaveCertificateAuthorityArn, IHaveACMPCACertificateTypesValidityValidity, IHaveCertificateSigningRequest, IHaveSigningAlgorithm, IHaveACMPCACertificateTypesApiPassthroughApiPassthrough, IHaveACMPCACertificateTypesValidityValidityNotBefore
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string Certificate =  "Certificate" ;
        }

        public override string AWSTypeName { get => AWS.ACMPCA.Certificate; }
        /// <summary>
        /// TemplateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificate.html#cfn-acmpca-certificate-templatearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TemplateArn { get; set; }

        /// <summary>
        /// CertificateAuthorityArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificate.html#cfn-acmpca-certificate-certificateauthorityarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CertificateAuthorityArn { get; set; }

        /// <summary>
        /// Validity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificate.html#cfn-acmpca-certificate-validity
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Validity
        /// </summary>
        [Required]
        public Union<Humidifier.ACMPCA.CertificateTypes.Validity, BaseFunction>? Validity { get; set; }

        /// <summary>
        /// CertificateSigningRequest
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificate.html#cfn-acmpca-certificate-certificatesigningrequest
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CertificateSigningRequest { get; set; }

        /// <summary>
        /// SigningAlgorithm
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificate.html#cfn-acmpca-certificate-signingalgorithm
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SigningAlgorithm { get; set; }
        /// <summary>
        /// ApiPassthrough
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificate.html#cfn-acmpca-certificate-apipassthrough
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ApiPassthrough
        /// </summary>
        public Union<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough, BaseFunction>? ApiPassthrough { get; set; }
        /// <summary>
        /// ValidityNotBefore
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificate.html#cfn-acmpca-certificate-validitynotbefore
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Validity
        /// </summary>
        public Union<Humidifier.ACMPCA.CertificateTypes.Validity, BaseFunction>? ValidityNotBefore { get; set; }
    }

    namespace CertificateTypes
    {
        public class ApiPassthrough : Humidifier.Base.BaseSubResource, IHaveACMPCACertificateTypesExtensionsExtensions, IHaveACMPCACertificateTypesSubjectSubject
        {
            /// <summary>
            /// Extensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-apipassthrough.html#cfn-acmpca-certificate-apipassthrough-extensions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Extensions
            /// </summary>
            public Union<Humidifier.ACMPCA.CertificateTypes.Extensions, BaseFunction>? Extensions { get; set; }
            /// <summary>
            /// Subject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-apipassthrough.html#cfn-acmpca-certificate-apipassthrough-subject
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Subject
            /// </summary>
            public Union<Humidifier.ACMPCA.CertificateTypes.Subject, BaseFunction>? Subject { get; set; }
        }

        public class CustomAttribute : Humidifier.Base.BaseSubResource, IHaveValue, IHaveObjectIdentifier
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-customattribute.html#cfn-acmpca-certificate-customattribute-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// ObjectIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-customattribute.html#cfn-acmpca-certificate-customattribute-objectidentifier
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectIdentifier { get; set; }
        }

        public class CustomExtension : Humidifier.Base.BaseSubResource, IHaveValue, IHaveCritical_Boolean, IHaveObjectIdentifier
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-customextension.html#cfn-acmpca-certificate-customextension-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Critical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-customextension.html#cfn-acmpca-certificate-customextension-critical
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Critical { get; set; }
            /// <summary>
            /// ObjectIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-customextension.html#cfn-acmpca-certificate-customextension-objectidentifier
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-edipartyname.html#cfn-acmpca-certificate-edipartyname-partyname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PartyName { get; set; }
            /// <summary>
            /// NameAssigner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-edipartyname.html#cfn-acmpca-certificate-edipartyname-nameassigner
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NameAssigner { get; set; }
        }

        public class ExtendedKeyUsage : Humidifier.Base.BaseSubResource, IHaveExtendedKeyUsageType, IHaveExtendedKeyUsageObjectIdentifier
        {
            /// <summary>
            /// ExtendedKeyUsageType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-extendedkeyusage.html#cfn-acmpca-certificate-extendedkeyusage-extendedkeyusagetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExtendedKeyUsageType { get; set; }
            /// <summary>
            /// ExtendedKeyUsageObjectIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-extendedkeyusage.html#cfn-acmpca-certificate-extendedkeyusage-extendedkeyusageobjectidentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExtendedKeyUsageObjectIdentifier { get; set; }
        }

        public class Extensions : Humidifier.Base.BaseSubResource, IHaveListOfACMPCACertificateTypesCustomExtensionCustomExtensions, IHaveListOfACMPCACertificateTypesPolicyInformationCertificatePolicies, IHaveACMPCACertificateTypesKeyUsageKeyUsage, IHaveListOfACMPCACertificateTypesGeneralNameSubjectAlternativeNames, IHaveListOfACMPCACertificateTypesExtendedKeyUsageExtendedKeyUsage
        {
            /// <summary>
            /// CustomExtensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-extensions.html#cfn-acmpca-certificate-extensions-customextensions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: CustomExtension
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ACMPCA.CertificateTypes.CustomExtension>, IReadOnlyList<Union<Humidifier.ACMPCA.CertificateTypes.CustomExtension, BaseFunction>>, BaseFunction>? CustomExtensions { get; set; }
            /// <summary>
            /// CertificatePolicies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-extensions.html#cfn-acmpca-certificate-extensions-certificatepolicies
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: PolicyInformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ACMPCA.CertificateTypes.PolicyInformation>, IReadOnlyList<Union<Humidifier.ACMPCA.CertificateTypes.PolicyInformation, BaseFunction>>, BaseFunction>? CertificatePolicies { get; set; }
            /// <summary>
            /// KeyUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-extensions.html#cfn-acmpca-certificate-extensions-keyusage
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KeyUsage
            /// </summary>
            public Union<Humidifier.ACMPCA.CertificateTypes.KeyUsage, BaseFunction>? KeyUsage { get; set; }
            /// <summary>
            /// SubjectAlternativeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-extensions.html#cfn-acmpca-certificate-extensions-subjectalternativenames
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: GeneralName
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ACMPCA.CertificateTypes.GeneralName>, IReadOnlyList<Union<Humidifier.ACMPCA.CertificateTypes.GeneralName, BaseFunction>>, BaseFunction>? SubjectAlternativeNames { get; set; }
            /// <summary>
            /// ExtendedKeyUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-extensions.html#cfn-acmpca-certificate-extensions-extendedkeyusage
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ExtendedKeyUsage
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ACMPCA.CertificateTypes.ExtendedKeyUsage>, IReadOnlyList<Union<Humidifier.ACMPCA.CertificateTypes.ExtendedKeyUsage, BaseFunction>>, BaseFunction>? ExtendedKeyUsage { get; set; }
        }

        public class GeneralName : Humidifier.Base.BaseSubResource, IHaveUniformResourceIdentifier, IHaveDnsName, IHaveACMPCACertificateTypesEdiPartyNameEdiPartyName, IHaveRegisteredId, IHaveRfc822Name, IHaveACMPCACertificateTypesOtherNameOtherName, IHaveIpAddress, IHaveACMPCACertificateTypesSubjectDirectoryName
        {
            /// <summary>
            /// UniformResourceIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-generalname.html#cfn-acmpca-certificate-generalname-uniformresourceidentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UniformResourceIdentifier { get; set; }
            /// <summary>
            /// DnsName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-generalname.html#cfn-acmpca-certificate-generalname-dnsname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DnsName { get; set; }
            /// <summary>
            /// EdiPartyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-generalname.html#cfn-acmpca-certificate-generalname-edipartyname
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EdiPartyName
            /// </summary>
            public Union<Humidifier.ACMPCA.CertificateTypes.EdiPartyName, BaseFunction>? EdiPartyName { get; set; }
            /// <summary>
            /// RegisteredId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-generalname.html#cfn-acmpca-certificate-generalname-registeredid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegisteredId { get; set; }
            /// <summary>
            /// Rfc822Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-generalname.html#cfn-acmpca-certificate-generalname-rfc822name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Rfc822Name { get; set; }
            /// <summary>
            /// OtherName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-generalname.html#cfn-acmpca-certificate-generalname-othername
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OtherName
            /// </summary>
            public Union<Humidifier.ACMPCA.CertificateTypes.OtherName, BaseFunction>? OtherName { get; set; }
            /// <summary>
            /// IpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-generalname.html#cfn-acmpca-certificate-generalname-ipaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddress { get; set; }
            /// <summary>
            /// DirectoryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-generalname.html#cfn-acmpca-certificate-generalname-directoryname
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Subject
            /// </summary>
            public Union<Humidifier.ACMPCA.CertificateTypes.Subject, BaseFunction>? DirectoryName { get; set; }
        }

        public class KeyUsage : Humidifier.Base.BaseSubResource, IHaveKeyEncipherment_Boolean, IHaveDataEncipherment_Boolean, IHaveDigitalSignature_Boolean, IHaveKeyCertSign_Boolean, IHaveDecipherOnly_Boolean, IHaveKeyAgreement_Boolean, IHaveNonRepudiation_Boolean, IHaveCRLSign_Boolean, IHaveEncipherOnly_Boolean
        {
            /// <summary>
            /// KeyEncipherment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-keyencipherment
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? KeyEncipherment { get; set; }
            /// <summary>
            /// DataEncipherment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-dataencipherment
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DataEncipherment { get; set; }
            /// <summary>
            /// DigitalSignature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-digitalsignature
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DigitalSignature { get; set; }
            /// <summary>
            /// KeyCertSign
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-keycertsign
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? KeyCertSign { get; set; }
            /// <summary>
            /// DecipherOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-decipheronly
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DecipherOnly { get; set; }
            /// <summary>
            /// KeyAgreement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-keyagreement
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? KeyAgreement { get; set; }
            /// <summary>
            /// NonRepudiation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-nonrepudiation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? NonRepudiation { get; set; }
            /// <summary>
            /// CRLSign
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-crlsign
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CRLSign { get; set; }
            /// <summary>
            /// EncipherOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-encipheronly
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EncipherOnly { get; set; }
        }

        public class OtherName : Humidifier.Base.BaseSubResource, IHaveTypeId, IHaveValue
        {
            /// <summary>
            /// TypeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-othername.html#cfn-acmpca-certificate-othername-typeid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TypeId { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-othername.html#cfn-acmpca-certificate-othername-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class PolicyInformation : Humidifier.Base.BaseSubResource, IHaveCertPolicyId, IHaveListOfACMPCACertificateTypesPolicyQualifierInfoPolicyQualifiers
        {
            /// <summary>
            /// CertPolicyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-policyinformation.html#cfn-acmpca-certificate-policyinformation-certpolicyid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertPolicyId { get; set; }
            /// <summary>
            /// PolicyQualifiers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-policyinformation.html#cfn-acmpca-certificate-policyinformation-policyqualifiers
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: PolicyQualifierInfo
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ACMPCA.CertificateTypes.PolicyQualifierInfo>, IReadOnlyList<Union<Humidifier.ACMPCA.CertificateTypes.PolicyQualifierInfo, BaseFunction>>, BaseFunction>? PolicyQualifiers { get; set; }
        }

        public class PolicyQualifierInfo : Humidifier.Base.BaseSubResource, IHaveACMPCACertificateTypesQualifierQualifier, IHavePolicyQualifierId
        {
            /// <summary>
            /// Qualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-policyqualifierinfo.html#cfn-acmpca-certificate-policyqualifierinfo-qualifier
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Qualifier
            /// </summary>
            public Union<Humidifier.ACMPCA.CertificateTypes.Qualifier, BaseFunction>? Qualifier { get; set; }
            /// <summary>
            /// PolicyQualifierId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-policyqualifierinfo.html#cfn-acmpca-certificate-policyqualifierinfo-policyqualifierid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyQualifierId { get; set; }
        }

        public class Qualifier : Humidifier.Base.BaseSubResource, IHaveCpsUri
        {
            /// <summary>
            /// CpsUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-qualifier.html#cfn-acmpca-certificate-qualifier-cpsuri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CpsUri { get; set; }
        }

        public class Subject : Humidifier.Base.BaseSubResource, IHaveOrganization, IHaveOrganizationalUnit, IHaveLocality, IHaveTitle, IHaveGivenName, IHaveGenerationQualifier, IHaveInitials, IHaveListOfACMPCACertificateTypesCustomAttributeCustomAttributes, IHaveSerialNumber, IHaveState, IHaveCountry, IHaveSurname, IHaveDistinguishedNameQualifier, IHaveCommonName, IHavePseudonym
        {
            /// <summary>
            /// Organization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-organization
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Organization { get; set; }
            /// <summary>
            /// OrganizationalUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-organizationalunit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrganizationalUnit { get; set; }
            /// <summary>
            /// Locality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-locality
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Locality { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-title
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Title { get; set; }
            /// <summary>
            /// GivenName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-givenname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GivenName { get; set; }
            /// <summary>
            /// GenerationQualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-generationqualifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GenerationQualifier { get; set; }
            /// <summary>
            /// Initials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-initials
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Initials { get; set; }
            /// <summary>
            /// CustomAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-customattributes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: CustomAttribute
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ACMPCA.CertificateTypes.CustomAttribute>, IReadOnlyList<Union<Humidifier.ACMPCA.CertificateTypes.CustomAttribute, BaseFunction>>, BaseFunction>? CustomAttributes { get; set; }
            /// <summary>
            /// SerialNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-serialnumber
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SerialNumber { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-state
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// Country
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-country
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Country { get; set; }
            /// <summary>
            /// Surname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-surname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Surname { get; set; }
            /// <summary>
            /// DistinguishedNameQualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-distinguishednamequalifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DistinguishedNameQualifier { get; set; }
            /// <summary>
            /// CommonName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-commonname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CommonName { get; set; }
            /// <summary>
            /// Pseudonym
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-pseudonym
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Pseudonym { get; set; }
        }

        public class Validity : Humidifier.Base.BaseSubResource, IHaveValue_Double, IHaveType
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-validity.html#cfn-acmpca-certificate-validity-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-validity.html#cfn-acmpca-certificate-validity-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }
    }
}