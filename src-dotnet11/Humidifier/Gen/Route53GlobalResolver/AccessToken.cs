namespace Humidifier.Route53GlobalResolver
{
    using global::System.Collections.Generic;

    public class AccessToken : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDnsViewId, IHaveExpiresAt, IHaveClientToken, IHaveName
    {
        public class Attributes
        {
            public static string AccessTokenId =  "AccessTokenId" ;
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Value =  "Value" ;
            public static string GlobalResolverId =  "GlobalResolverId" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Route53GlobalResolver.AccessToken; }

        /// <summary>
        /// DnsViewId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-accesstoken.html#cfn-route53globalresolver-accesstoken-dnsviewid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DnsViewId { get; set; }
        /// <summary>
        /// ExpiresAt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-accesstoken.html#cfn-route53globalresolver-accesstoken-expiresat
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExpiresAt { get; set; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-accesstoken.html#cfn-route53globalresolver-accesstoken-clienttoken
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientToken { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-accesstoken.html#cfn-route53globalresolver-accesstoken-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}