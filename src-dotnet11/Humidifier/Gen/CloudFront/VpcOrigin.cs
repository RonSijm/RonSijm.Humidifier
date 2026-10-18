namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using VpcOriginTypes;

    public class VpcOrigin : Humidifier.Base.BaseResource, IHaveTags, IHaveCloudFrontVpcOriginTypesVpcOriginEndpointConfigVpcOriginEndpointConfig
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string AccountId =  "AccountId" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.VpcOrigin; }

        /// <summary>
        /// VpcOriginEndpointConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-vpcorigin.html#cfn-cloudfront-vpcorigin-vpcoriginendpointconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: VpcOriginEndpointConfig
        /// </summary>
        [Required]
        public Union<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig, BaseFunction>? VpcOriginEndpointConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-vpcorigin.html#cfn-cloudfront-vpcorigin-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace VpcOriginTypes
    {
        public class VpcOriginEndpointConfig : Humidifier.Base.BaseSubResource, IHaveIpAddressType, IHaveHTTPSPort_Integer, IHaveStringListOfOriginSSLProtocols, IHaveArn, IHaveHTTPPort_Integer, IHaveName, IHaveOriginProtocolPolicy
        {
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-vpcorigin-vpcoriginendpointconfig.html#cfn-cloudfront-vpcorigin-vpcoriginendpointconfig-ipaddresstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddressType { get; set; }
            /// <summary>
            /// HTTPSPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-vpcorigin-vpcoriginendpointconfig.html#cfn-cloudfront-vpcorigin-vpcoriginendpointconfig-httpsport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HTTPSPort { get; set; }
            /// <summary>
            /// OriginSSLProtocols
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-vpcorigin-vpcoriginendpointconfig.html#cfn-cloudfront-vpcorigin-vpcoriginendpointconfig-originsslprotocols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OriginSSLProtocols { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-vpcorigin-vpcoriginendpointconfig.html#cfn-cloudfront-vpcorigin-vpcoriginendpointconfig-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// HTTPPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-vpcorigin-vpcoriginendpointconfig.html#cfn-cloudfront-vpcorigin-vpcoriginendpointconfig-httpport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HTTPPort { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-vpcorigin-vpcoriginendpointconfig.html#cfn-cloudfront-vpcorigin-vpcoriginendpointconfig-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// OriginProtocolPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-vpcorigin-vpcoriginendpointconfig.html#cfn-cloudfront-vpcorigin-vpcoriginendpointconfig-originprotocolpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OriginProtocolPolicy { get; set; }
        }
    }
}