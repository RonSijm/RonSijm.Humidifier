namespace Humidifier.ACMPCA
{
    using System.Collections.Generic;
    using CertificateTypes;

    public class Certificate : Humidifier.Base.BaseResource, IHaveCertificateAuthorityArn, IHaveSigningAlgorithm, IHaveTemplateArn, IHaveCertificateSigningRequest
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
        public dynamic TemplateArn { get; set; }

        /// <summary>
        /// CertificateAuthorityArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificate.html#cfn-acmpca-certificate-certificateauthorityarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CertificateAuthorityArn { get; set; }

        /// <summary>
        /// Validity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificate.html#cfn-acmpca-certificate-validity
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Validity
        /// </summary>
        [Required]
        public Humidifier.ACMPCA.CertificateTypes.Validity Validity { get; set; }

        /// <summary>
        /// CertificateSigningRequest
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificate.html#cfn-acmpca-certificate-certificatesigningrequest
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CertificateSigningRequest { get; set; }

        /// <summary>
        /// SigningAlgorithm
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificate.html#cfn-acmpca-certificate-signingalgorithm
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SigningAlgorithm { get; set; }
        /// <summary>
        /// ApiPassthrough
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificate.html#cfn-acmpca-certificate-apipassthrough
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ApiPassthrough
        /// </summary>
        public Humidifier.ACMPCA.CertificateTypes.ApiPassthrough ApiPassthrough { get; set; }
        /// <summary>
        /// ValidityNotBefore
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificate.html#cfn-acmpca-certificate-validitynotbefore
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Validity
        /// </summary>
        public Humidifier.ACMPCA.CertificateTypes.Validity ValidityNotBefore { get; set; }
    }

    namespace CertificateTypes
    {
        public class ApiPassthrough : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Extensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-apipassthrough.html#cfn-acmpca-certificate-apipassthrough-extensions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Extensions
            /// </summary>
            public Humidifier.ACMPCA.CertificateTypes.Extensions Extensions { get; set; }
            /// <summary>
            /// Subject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-apipassthrough.html#cfn-acmpca-certificate-apipassthrough-subject
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Subject
            /// </summary>
            public Humidifier.ACMPCA.CertificateTypes.Subject Subject { get; set; }
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
            public dynamic Value { get; set; }
            /// <summary>
            /// ObjectIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-customattribute.html#cfn-acmpca-certificate-customattribute-objectidentifier
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectIdentifier { get; set; }
        }

        public class CustomExtension : Humidifier.Base.BaseSubResource, IHaveValue, IHaveObjectIdentifier, IHaveCritical
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-customextension.html#cfn-acmpca-certificate-customextension-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Critical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-customextension.html#cfn-acmpca-certificate-customextension-critical
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Critical { get; set; }
            /// <summary>
            /// ObjectIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-customextension.html#cfn-acmpca-certificate-customextension-objectidentifier
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectIdentifier { get; set; }
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
            public dynamic PartyName { get; set; }
            /// <summary>
            /// NameAssigner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-edipartyname.html#cfn-acmpca-certificate-edipartyname-nameassigner
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NameAssigner { get; set; }
        }

        public class ExtendedKeyUsage : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExtendedKeyUsageType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-extendedkeyusage.html#cfn-acmpca-certificate-extendedkeyusage-extendedkeyusagetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExtendedKeyUsageType { get; set; }
            /// <summary>
            /// ExtendedKeyUsageObjectIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-extendedkeyusage.html#cfn-acmpca-certificate-extendedkeyusage-extendedkeyusageobjectidentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExtendedKeyUsageObjectIdentifier { get; set; }
        }

        public class Extensions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomExtensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-extensions.html#cfn-acmpca-certificate-extensions-customextensions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: CustomExtension
            /// </summary>
            public List<Humidifier.ACMPCA.CertificateTypes.CustomExtension> CustomExtensions { get; set; }
            /// <summary>
            /// CertificatePolicies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-extensions.html#cfn-acmpca-certificate-extensions-certificatepolicies
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: PolicyInformation
            /// </summary>
            public List<Humidifier.ACMPCA.CertificateTypes.PolicyInformation> CertificatePolicies { get; set; }
            /// <summary>
            /// KeyUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-extensions.html#cfn-acmpca-certificate-extensions-keyusage
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KeyUsage
            /// </summary>
            public Humidifier.ACMPCA.CertificateTypes.KeyUsage KeyUsage { get; set; }
            /// <summary>
            /// SubjectAlternativeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-extensions.html#cfn-acmpca-certificate-extensions-subjectalternativenames
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: GeneralName
            /// </summary>
            public List<Humidifier.ACMPCA.CertificateTypes.GeneralName> SubjectAlternativeNames { get; set; }
            /// <summary>
            /// ExtendedKeyUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-extensions.html#cfn-acmpca-certificate-extensions-extendedkeyusage
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ExtendedKeyUsage
            /// </summary>
            public List<Humidifier.ACMPCA.CertificateTypes.ExtendedKeyUsage> ExtendedKeyUsage { get; set; }
        }

        public class GeneralName : Humidifier.Base.BaseSubResource, IHaveIpAddress, IHaveDnsName, IHaveUniformResourceIdentifier, IHaveRegisteredId, IHaveRfc822Name
        {
            /// <summary>
            /// UniformResourceIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-generalname.html#cfn-acmpca-certificate-generalname-uniformresourceidentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UniformResourceIdentifier { get; set; }
            /// <summary>
            /// DnsName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-generalname.html#cfn-acmpca-certificate-generalname-dnsname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DnsName { get; set; }
            /// <summary>
            /// EdiPartyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-generalname.html#cfn-acmpca-certificate-generalname-edipartyname
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EdiPartyName
            /// </summary>
            public Humidifier.ACMPCA.CertificateTypes.EdiPartyName EdiPartyName { get; set; }
            /// <summary>
            /// RegisteredId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-generalname.html#cfn-acmpca-certificate-generalname-registeredid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegisteredId { get; set; }
            /// <summary>
            /// Rfc822Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-generalname.html#cfn-acmpca-certificate-generalname-rfc822name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Rfc822Name { get; set; }
            /// <summary>
            /// OtherName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-generalname.html#cfn-acmpca-certificate-generalname-othername
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OtherName
            /// </summary>
            public Humidifier.ACMPCA.CertificateTypes.OtherName OtherName { get; set; }
            /// <summary>
            /// IpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-generalname.html#cfn-acmpca-certificate-generalname-ipaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IpAddress { get; set; }
            /// <summary>
            /// DirectoryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-generalname.html#cfn-acmpca-certificate-generalname-directoryname
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Subject
            /// </summary>
            public Humidifier.ACMPCA.CertificateTypes.Subject DirectoryName { get; set; }
        }

        public class KeyUsage : Humidifier.Base.BaseSubResource, IHaveKeyAgreement, IHaveKeyEncipherment, IHaveDataEncipherment, IHaveDigitalSignature, IHaveNonRepudiation, IHaveKeyCertSign, IHaveDecipherOnly, IHaveCRLSign, IHaveEncipherOnly
        {
            /// <summary>
            /// KeyEncipherment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-keyencipherment
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic KeyEncipherment { get; set; }
            /// <summary>
            /// DataEncipherment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-dataencipherment
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DataEncipherment { get; set; }
            /// <summary>
            /// DigitalSignature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-digitalsignature
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DigitalSignature { get; set; }
            /// <summary>
            /// KeyCertSign
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-keycertsign
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic KeyCertSign { get; set; }
            /// <summary>
            /// DecipherOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-decipheronly
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DecipherOnly { get; set; }
            /// <summary>
            /// KeyAgreement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-keyagreement
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic KeyAgreement { get; set; }
            /// <summary>
            /// NonRepudiation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-nonrepudiation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic NonRepudiation { get; set; }
            /// <summary>
            /// CRLSign
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-crlsign
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CRLSign { get; set; }
            /// <summary>
            /// EncipherOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-keyusage.html#cfn-acmpca-certificate-keyusage-encipheronly
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EncipherOnly { get; set; }
        }

        public class OtherName : Humidifier.Base.BaseSubResource, IHaveValue, IHaveTypeId
        {
            /// <summary>
            /// TypeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-othername.html#cfn-acmpca-certificate-othername-typeid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TypeId { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-othername.html#cfn-acmpca-certificate-othername-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class PolicyInformation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CertPolicyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-policyinformation.html#cfn-acmpca-certificate-policyinformation-certpolicyid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertPolicyId { get; set; }
            /// <summary>
            /// PolicyQualifiers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-policyinformation.html#cfn-acmpca-certificate-policyinformation-policyqualifiers
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: PolicyQualifierInfo
            /// </summary>
            public List<Humidifier.ACMPCA.CertificateTypes.PolicyQualifierInfo> PolicyQualifiers { get; set; }
        }

        public class PolicyQualifierInfo : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Qualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-policyqualifierinfo.html#cfn-acmpca-certificate-policyqualifierinfo-qualifier
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Qualifier
            /// </summary>
            public Humidifier.ACMPCA.CertificateTypes.Qualifier Qualifier { get; set; }
            /// <summary>
            /// PolicyQualifierId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-policyqualifierinfo.html#cfn-acmpca-certificate-policyqualifierinfo-policyqualifierid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PolicyQualifierId { get; set; }
        }

        public class Qualifier : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CpsUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-qualifier.html#cfn-acmpca-certificate-qualifier-cpsuri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CpsUri { get; set; }
        }

        public class Subject : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveState, IHaveSerialNumber, IHaveOrganization, IHaveCountry, IHaveCommonName, IHaveOrganizationalUnit, IHaveLocality, IHaveGivenName, IHaveGenerationQualifier, IHaveInitials, IHaveSurname, IHaveDistinguishedNameQualifier, IHavePseudonym
        {
            /// <summary>
            /// Organization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-organization
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Organization { get; set; }
            /// <summary>
            /// OrganizationalUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-organizationalunit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OrganizationalUnit { get; set; }
            /// <summary>
            /// Locality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-locality
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Locality { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-title
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// GivenName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-givenname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GivenName { get; set; }
            /// <summary>
            /// GenerationQualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-generationqualifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GenerationQualifier { get; set; }
            /// <summary>
            /// Initials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-initials
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Initials { get; set; }
            /// <summary>
            /// CustomAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-customattributes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: CustomAttribute
            /// </summary>
            public List<Humidifier.ACMPCA.CertificateTypes.CustomAttribute> CustomAttributes { get; set; }
            /// <summary>
            /// SerialNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-serialnumber
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SerialNumber { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-state
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// Country
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-country
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Country { get; set; }
            /// <summary>
            /// Surname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-surname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Surname { get; set; }
            /// <summary>
            /// DistinguishedNameQualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-distinguishednamequalifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DistinguishedNameQualifier { get; set; }
            /// <summary>
            /// CommonName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-commonname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommonName { get; set; }
            /// <summary>
            /// Pseudonym
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-subject.html#cfn-acmpca-certificate-subject-pseudonym
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Pseudonym { get; set; }
        }

        public class Validity : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-validity.html#cfn-acmpca-certificate-validity-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-validity.html#cfn-acmpca-certificate-validity-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
        }
    }
}