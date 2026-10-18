namespace Humidifier.CertificateManager
{
    using global::System.Collections.Generic;
    using CertificateTypes;

    public class Certificate : Humidifier.Base.BaseResource, IHaveTags, IHaveCertificateAuthorityArn, IHaveCertificateExport, IHaveListOfCertificateManagerCertificateTypesDomainValidationOptionDomainValidationOptions, IHaveCertificateTransparencyLoggingPreference, IHaveDomainName, IHaveValidationMethod, IHaveStringListOfSubjectAlternativeNames, IHaveKeyAlgorithm
    {
        public class Attributes
        {
            public static string CertificateArn =  "CertificateArn" ;
        }

        public override string AWSTypeName { get => AWS.CertificateManager.Certificate; }
        /// <summary>
        /// CertificateAuthorityArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html#cfn-certificatemanager-certificate-certificateauthorityarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CertificateAuthorityArn { get; set; }
        /// <summary>
        /// CertificateExport
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html#cfn-certificatemanager-certificate-certificateexport
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CertificateExport { get; set; }
        /// <summary>
        /// DomainValidationOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html#cfn-certificatemanager-certificate-domainvalidationoptions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: DomainValidationOption
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption>, IReadOnlyList<Union<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption, BaseFunction>>, BaseFunction>? DomainValidationOptions { get; set; }
        /// <summary>
        /// CertificateTransparencyLoggingPreference
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html#cfn-certificatemanager-certificate-certificatetransparencyloggingpreference
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CertificateTransparencyLoggingPreference { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html#cfn-certificatemanager-certificate-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainName { get; set; }
        /// <summary>
        /// ValidationMethod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html#cfn-certificatemanager-certificate-validationmethod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ValidationMethod { get; set; }
        /// <summary>
        /// SubjectAlternativeNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html#cfn-certificatemanager-certificate-subjectalternativenames
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubjectAlternativeNames { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html#cfn-certificatemanager-certificate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// KeyAlgorithm
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html#cfn-certificatemanager-certificate-keyalgorithm
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KeyAlgorithm { get; set; }
    }

    namespace CertificateTypes
    {
        public class DomainValidationOption : Humidifier.Base.BaseSubResource, IHaveDomainName, IHaveHostedZoneId, IHaveValidationDomain
        {
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-certificate-domainvalidationoption.html#cfn-certificatemanager-certificate-domainvalidationoption-domainname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainName { get; set; }
            /// <summary>
            /// HostedZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-certificate-domainvalidationoption.html#cfn-certificatemanager-certificate-domainvalidationoption-hostedzoneid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostedZoneId { get; set; }
            /// <summary>
            /// ValidationDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-certificate-domainvalidationoption.html#cfn-certificatemanager-certificate-domainvalidationoption-validationdomain
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValidationDomain { get; set; }
        }
    }
}