namespace Humidifier.CloudFront
{
    using System.Collections.Generic;
    using AnycastIpListTypes;

    public class AnycastIpList : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName
    {
        public class Attributes
        {
            public static string AnycastIpList =  "AnycastIpList" ;
            public static string ETag =  "ETag" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.AnycastIpList; }

        /// <summary>
        /// IpCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-anycastiplist.html#cfn-cloudfront-anycastiplist-ipcount
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic IpCount { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-anycastiplist.html#cfn-cloudfront-anycastiplist-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Tags
        /// </summary>
        public Humidifier.CloudFront.AnycastIpListTypes.Tags Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace AnycastIpListTypes
    {
        public class AnycastIpList : Humidifier.Base.BaseSubResource, IHaveName, IHaveStatus, IHaveId, IHaveArn
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-anycastiplist.html#cfn-cloudfront-anycastiplist-anycastiplist-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// IpCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-anycastiplist.html#cfn-cloudfront-anycastiplist-anycastiplist-ipcount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IpCount { get; set; }
            /// <summary>
            /// AnycastIps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-anycastiplist.html#cfn-cloudfront-anycastiplist-anycastiplist-anycastips
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AnycastIps { get; set; }
            /// <summary>
            /// LastModifiedTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-anycastiplist.html#cfn-cloudfront-anycastiplist-anycastiplist-lastmodifiedtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LastModifiedTime { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-anycastiplist.html#cfn-cloudfront-anycastiplist-anycastiplist-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-anycastiplist.html#cfn-cloudfront-anycastiplist-anycastiplist-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-anycastiplist.html#cfn-cloudfront-anycastiplist-anycastiplist-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class Tags : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-tags.html#cfn-cloudfront-anycastiplist-tags-items
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Tag> Items { get; set; }
        }
    }
}