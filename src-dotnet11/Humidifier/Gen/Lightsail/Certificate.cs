namespace Humidifier.Lightsail
{
    using global::System.Collections.Generic;

    public class Certificate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDomainName, IHaveStringListOfSubjectAlternativeNames, IHaveCertificateName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CertificateArn =  "CertificateArn" ;
        }

        public override string AWSTypeName { get => AWS.Lightsail.Certificate; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-certificate.html#cfn-lightsail-certificate-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainName { get; set; }
        /// <summary>
        /// SubjectAlternativeNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-certificate.html#cfn-lightsail-certificate-subjectalternativenames
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubjectAlternativeNames { get; set; }
        public Union<string, BaseFunction>? CertificateName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-certificate.html#cfn-lightsail-certificate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}