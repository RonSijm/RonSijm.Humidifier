namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;

    public class ConnectionGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIpv6Enabled_Boolean, IHaveAnycastIpListId, IHaveEnabled_Boolean, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string IsDefault =  "IsDefault" ;
            public static string RoutingEndpoint =  "RoutingEndpoint" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string ETag =  "ETag" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.ConnectionGroup; }
        /// <summary>
        /// Ipv6Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-connectiongroup.html#cfn-cloudfront-connectiongroup-ipv6enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Ipv6Enabled { get; set; }
        /// <summary>
        /// AnycastIpListId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-connectiongroup.html#cfn-cloudfront-connectiongroup-anycastiplistid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AnycastIpListId { get; set; }
        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-connectiongroup.html#cfn-cloudfront-connectiongroup-enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Enabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-connectiongroup.html#cfn-cloudfront-connectiongroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}