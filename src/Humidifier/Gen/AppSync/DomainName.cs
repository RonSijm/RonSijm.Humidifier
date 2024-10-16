namespace Humidifier.AppSync
{
    using System.Collections.Generic;

    public class DomainName : Humidifier.Base.BaseResource, IHaveDescription, IHaveCertificateArn, IHaveDomainName_
    {
        public class Attributes
        {
            public static string AppSyncDomainName =  "AppSyncDomainName" ;
            public static string DomainName =  "DomainName" ;
            public static string HostedZoneId =  "HostedZoneId" ;
        }

        public override string AWSTypeName { get => AWS.AppSync.DomainName; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-domainname.html#cfn-appsync-domainname-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// DomainName_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-domainname.html#cfn-appsync-domainname-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainName_ { get; set; }

        /// <summary>
        /// CertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-domainname.html#cfn-appsync-domainname-certificatearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CertificateArn { get; set; }
    }
}