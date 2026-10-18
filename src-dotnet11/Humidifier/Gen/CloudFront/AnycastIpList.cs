namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using AnycastIpListTypes;

    public class AnycastIpList : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveIpAddressType, IHaveIpCount_Integer, IHaveListOfCloudFrontAnycastIpListTypesIpamCidrConfigIpamCidrConfigs, IHaveCloudFrontAnycastIpListTypesTagsTags, IHaveName
    {
        public class Attributes
        {
            public static string IpamCidrConfigResults =  "IpamCidrConfigResults" ;
            public static string AnycastIpList =  "AnycastIpList" ;
            public static string ETag =  "ETag" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.AnycastIpList; }
        /// <summary>
        /// IpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-anycastiplist.html#cfn-cloudfront-anycastiplist-ipaddresstype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpAddressType { get; set; }

        /// <summary>
        /// IpCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-anycastiplist.html#cfn-cloudfront-anycastiplist-ipcount
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? IpCount { get; set; }
        /// <summary>
        /// IpamCidrConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-anycastiplist.html#cfn-cloudfront-anycastiplist-ipamcidrconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IpamCidrConfig
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudFront.AnycastIpListTypes.IpamCidrConfig>, IReadOnlyList<Union<Humidifier.CloudFront.AnycastIpListTypes.IpamCidrConfig, BaseFunction>>, BaseFunction>? IpamCidrConfigs { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-anycastiplist.html#cfn-cloudfront-anycastiplist-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Tags
        /// </summary>
        public Union<Humidifier.CloudFront.AnycastIpListTypes.Tags, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AnycastIpListTypes
    {
        public class AnycastIpList : Humidifier.Base.BaseSubResource, IHaveIpAddressType, IHaveStatus, IHaveIpCount_Integer, IHaveStringListOfAnycastIps, IHaveLastModifiedTime, IHaveId, IHaveArn, IHaveListOfCloudFrontAnycastIpListTypesIpamCidrConfigResultIpamCidrConfigResults, IHaveName
        {
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-anycastiplist.html#cfn-cloudfront-anycastiplist-anycastiplist-ipaddresstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddressType { get; set; }
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-anycastiplist.html#cfn-cloudfront-anycastiplist-anycastiplist-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// IpCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-anycastiplist.html#cfn-cloudfront-anycastiplist-anycastiplist-ipcount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IpCount { get; set; }
            /// <summary>
            /// AnycastIps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-anycastiplist.html#cfn-cloudfront-anycastiplist-anycastiplist-anycastips
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AnycastIps { get; set; }
            /// <summary>
            /// LastModifiedTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-anycastiplist.html#cfn-cloudfront-anycastiplist-anycastiplist-lastmodifiedtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LastModifiedTime { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-anycastiplist.html#cfn-cloudfront-anycastiplist-anycastiplist-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-anycastiplist.html#cfn-cloudfront-anycastiplist-anycastiplist-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// IpamCidrConfigResults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-anycastiplist.html#cfn-cloudfront-anycastiplist-anycastiplist-ipamcidrconfigresults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IpamCidrConfigResult
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFront.AnycastIpListTypes.IpamCidrConfigResult>, IReadOnlyList<Union<Humidifier.CloudFront.AnycastIpListTypes.IpamCidrConfigResult, BaseFunction>>, BaseFunction>? IpamCidrConfigResults { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-anycastiplist.html#cfn-cloudfront-anycastiplist-anycastiplist-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class IpamCidrConfig : Humidifier.Base.BaseSubResource, IHaveCidr, IHaveIpamPoolArn
        {
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-ipamcidrconfig.html#cfn-cloudfront-anycastiplist-ipamcidrconfig-cidr
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cidr { get; set; }
            /// <summary>
            /// IpamPoolArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-ipamcidrconfig.html#cfn-cloudfront-anycastiplist-ipamcidrconfig-ipampoolarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpamPoolArn { get; set; }
        }

        public class IpamCidrConfigResult : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveAnycastIp, IHaveCidr, IHaveIpamPoolArn
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-ipamcidrconfigresult.html#cfn-cloudfront-anycastiplist-ipamcidrconfigresult-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// AnycastIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-ipamcidrconfigresult.html#cfn-cloudfront-anycastiplist-ipamcidrconfigresult-anycastip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AnycastIp { get; set; }
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-ipamcidrconfigresult.html#cfn-cloudfront-anycastiplist-ipamcidrconfigresult-cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cidr { get; set; }
            /// <summary>
            /// IpamPoolArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-ipamcidrconfigresult.html#cfn-cloudfront-anycastiplist-ipamcidrconfigresult-ipampoolarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpamPoolArn { get; set; }
        }

        public class Tags : Humidifier.Base.BaseSubResource, IHaveTagListOfItems
        {
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-anycastiplist-tags.html#cfn-cloudfront-anycastiplist-tags-items
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Items { get; set; }
        }
    }
}