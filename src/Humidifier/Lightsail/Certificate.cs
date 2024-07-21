namespace Humidifier.Lightsail
{
    using System.Collections.Generic;

    public class Certificate : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CertificateArn =  "CertificateArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Lightsail::Certificate";
            }
        }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-certificate.html#cfn-lightsail-certificate-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DomainName { get; set; }
        /// <summary>
        /// SubjectAlternativeNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-certificate.html#cfn-lightsail-certificate-subjectalternativenames
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SubjectAlternativeNames { get; set; }
        /// <summary>
        /// CertificateName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-certificate.html#cfn-lightsail-certificate-certificatename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CertificateName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-certificate.html#cfn-lightsail-certificate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}