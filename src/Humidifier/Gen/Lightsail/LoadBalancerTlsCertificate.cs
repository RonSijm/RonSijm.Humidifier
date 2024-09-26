namespace Humidifier.Lightsail
{
    using System.Collections.Generic;

    public class LoadBalancerTlsCertificate : Humidifier.Base.BaseResource, IHaveCertificateName, IHaveLoadBalancerName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LoadBalancerTlsCertificateArn =  "LoadBalancerTlsCertificateArn" ;
        }

        public override string AWSTypeName { get => AWS.Lightsail.LoadBalancerTlsCertificate; }

        /// <summary>
        /// LoadBalancerName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-loadbalancertlscertificate.html#cfn-lightsail-loadbalancertlscertificate-loadbalancername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LoadBalancerName { get; set; }

        /// <summary>
        /// CertificateDomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-loadbalancertlscertificate.html#cfn-lightsail-loadbalancertlscertificate-certificatedomainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CertificateDomainName { get; set; }
        /// <summary>
        /// IsAttached
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-loadbalancertlscertificate.html#cfn-lightsail-loadbalancertlscertificate-isattached
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic IsAttached { get; set; }
        /// <summary>
        /// CertificateAlternativeNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-loadbalancertlscertificate.html#cfn-lightsail-loadbalancertlscertificate-certificatealternativenames
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic CertificateAlternativeNames { get; set; }
        /// <summary>
        /// HttpsRedirectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-loadbalancertlscertificate.html#cfn-lightsail-loadbalancertlscertificate-httpsredirectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic HttpsRedirectionEnabled { get; set; }

        /// <summary>
        /// CertificateName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-loadbalancertlscertificate.html#cfn-lightsail-loadbalancertlscertificate-certificatename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CertificateName { get; set; }
    }
}