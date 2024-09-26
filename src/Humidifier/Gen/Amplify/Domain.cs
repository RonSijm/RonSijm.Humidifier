namespace Humidifier.Amplify
{
    using System.Collections.Generic;
    using DomainTypes;

    public class Domain : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDomainName, IHaveAppId
    {
        public class Attributes
        {
            public static string UpdateStatus =  "UpdateStatus" ;
            public static string DomainName =  "DomainName" ;
            public static string StatusReason =  "StatusReason" ;
            public static string AutoSubDomainCreationPatterns =  "AutoSubDomainCreationPatterns" ;
            public static string CertificateRecord =  "CertificateRecord" ;
            public static string AutoSubDomainIAMRole =  "AutoSubDomainIAMRole" ;
            public static string EnableAutoSubDomain =  "EnableAutoSubDomain" ;
            public static string Arn =  "Arn" ;
            public static string DomainStatus =  "DomainStatus" ;
            public static string Certificate =  "Certificate" ;
        }

        public override string AWSTypeName { get => AWS.Amplify.Domain; }

        /// <summary>
        /// SubDomainSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-domain.html#cfn-amplify-domain-subdomainsettings
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SubDomainSetting
        /// </summary>
        [Required]
        public List<Humidifier.Amplify.DomainTypes.SubDomainSetting> SubDomainSettings { get; set; }

        /// <summary>
        /// AppId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-domain.html#cfn-amplify-domain-appid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AppId { get; set; }
        /// <summary>
        /// AutoSubDomainIAMRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-domain.html#cfn-amplify-domain-autosubdomainiamrole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AutoSubDomainIAMRole { get; set; }
        public dynamic DomainName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// CertificateSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-domain.html#cfn-amplify-domain-certificatesettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CertificateSettings
        /// </summary>
        public Humidifier.Amplify.DomainTypes.CertificateSettings CertificateSettings { get; set; }
        /// <summary>
        /// EnableAutoSubDomain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-domain.html#cfn-amplify-domain-enableautosubdomain
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableAutoSubDomain { get; set; }
        /// <summary>
        /// AutoSubDomainCreationPatterns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-domain.html#cfn-amplify-domain-autosubdomaincreationpatterns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic AutoSubDomainCreationPatterns { get; set; }
    }

    namespace DomainTypes
    {
        public class Certificate : Humidifier.Base.BaseSubResource, IHaveCertificateArn, IHaveCertificateType
        {
            /// <summary>
            /// CertificateType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-domain-certificate.html#cfn-amplify-domain-certificate-certificatetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateType { get; set; }
            /// <summary>
            /// CertificateVerificationDNSRecord
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-domain-certificate.html#cfn-amplify-domain-certificate-certificateverificationdnsrecord
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateVerificationDNSRecord { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-domain-certificate.html#cfn-amplify-domain-certificate-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
        }

        public class CertificateSettings : Humidifier.Base.BaseSubResource, IHaveCertificateType
        {
            /// <summary>
            /// CertificateType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-domain-certificatesettings.html#cfn-amplify-domain-certificatesettings-certificatetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateType { get; set; }
            /// <summary>
            /// CustomCertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-domain-certificatesettings.html#cfn-amplify-domain-certificatesettings-customcertificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomCertificateArn { get; set; }
        }

        public class SubDomainSetting : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveBranchName
        {
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-domain-subdomainsetting.html#cfn-amplify-domain-subdomainsetting-prefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// BranchName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-domain-subdomainsetting.html#cfn-amplify-domain-subdomainsetting-branchname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BranchName { get; set; }
        }
    }
}