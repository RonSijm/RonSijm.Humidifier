namespace Humidifier.CertificateManager
{
    using System.Collections.Generic;
    using CertificateTypes;

    public class Certificate : Humidifier.Base.BaseResource, IHaveTags, IHaveDomainName, IHaveCertificateAuthorityArn, IHaveKeyAlgorithm, IHaveSubjectAlternativeNames
    {
        public override string AWSTypeName { get => AWS.CertificateManager.Certificate; }
        /// <summary>
        /// CertificateAuthorityArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html#cfn-certificatemanager-certificate-certificateauthorityarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CertificateAuthorityArn { get; set; }
        /// <summary>
        /// CertificateTransparencyLoggingPreference
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html#cfn-certificatemanager-certificate-certificatetransparencyloggingpreference
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CertificateTransparencyLoggingPreference { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html#cfn-certificatemanager-certificate-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainName { get; set; }
        /// <summary>
        /// DomainValidationOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html#cfn-certificatemanager-certificate-domainvalidationoptions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: DomainValidationOption
        /// </summary>
        public List<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption> DomainValidationOptions { get; set; }
        /// <summary>
        /// KeyAlgorithm
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html#cfn-certificatemanager-certificate-keyalgorithm
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KeyAlgorithm { get; set; }
        /// <summary>
        /// SubjectAlternativeNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html#cfn-certificatemanager-certificate-subjectalternativenames
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SubjectAlternativeNames { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html#cfn-certificatemanager-certificate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// ValidationMethod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html#cfn-certificatemanager-certificate-validationmethod
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ValidationMethod { get; set; }
    }

    namespace CertificateTypes
    {
        public class DomainValidationOption : Humidifier.Base.BaseSubResource, IHaveDomainName, IHaveHostedZoneId
        {
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-certificate-domainvalidationoption.html#cfn-certificatemanager-certificate-domainvalidationoptions-domainname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DomainName { get; set; }
            /// <summary>
            /// HostedZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-certificate-domainvalidationoption.html#cfn-certificatemanager-certificate-domainvalidationoption-hostedzoneid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostedZoneId { get; set; }
            /// <summary>
            /// ValidationDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-certificate-domainvalidationoption.html#cfn-certificatemanager-certificate-domainvalidationoption-validationdomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValidationDomain { get; set; }
        }
    }
}