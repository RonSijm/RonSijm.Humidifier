namespace Humidifier.AppSync
{
    using global::System.Collections.Generic;

    public class DomainName : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveDomainName_, IHaveCertificateArn
    {
        public class Attributes
        {
            public static string AppSyncDomainName =  "AppSyncDomainName" ;
            public static string DomainName =  "DomainName" ;
            public static string HostedZoneId =  "HostedZoneId" ;
            public static string DomainNameArn =  "DomainNameArn" ;
        }

        public override string AWSTypeName { get => AWS.AppSync.DomainName; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-domainname.html#cfn-appsync-domainname-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// DomainName_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-domainname.html#cfn-appsync-domainname-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainName_ { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-domainname.html#cfn-appsync-domainname-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// CertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-domainname.html#cfn-appsync-domainname-certificatearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CertificateArn { get; set; }
    }
}