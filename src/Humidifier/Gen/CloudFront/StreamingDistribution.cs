namespace Humidifier.CloudFront
{
    using System.Collections.Generic;
    using StreamingDistributionTypes;

    public class StreamingDistribution : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string DomainName =  "DomainName" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.StreamingDistribution; }

        /// <summary>
        /// StreamingDistributionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-streamingdistribution.html#cfn-cloudfront-streamingdistribution-streamingdistributionconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: StreamingDistributionConfig
        /// </summary>
        [Required]
        public Humidifier.CloudFront.StreamingDistributionTypes.StreamingDistributionConfig StreamingDistributionConfig { get; set; }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-streamingdistribution.html#cfn-cloudfront-streamingdistribution-tags
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        [Required]
        public List<Tag> Tags { get; set; }
    }

    namespace StreamingDistributionTypes
    {
        public class Logging : Humidifier.Base.BaseSubResource, IHaveEnabled, IHavePrefix, IHaveBucket
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-logging.html#cfn-cloudfront-streamingdistribution-logging-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-logging.html#cfn-cloudfront-streamingdistribution-logging-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-logging.html#cfn-cloudfront-streamingdistribution-logging-prefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class S3Origin : Humidifier.Base.BaseSubResource, IHaveDomainName, IHaveOriginAccessIdentity
        {
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-s3origin.html#cfn-cloudfront-streamingdistribution-s3origin-domainname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DomainName { get; set; }
            /// <summary>
            /// OriginAccessIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-s3origin.html#cfn-cloudfront-streamingdistribution-s3origin-originaccessidentity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OriginAccessIdentity { get; set; }
        }

        public class StreamingDistributionConfig : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveComment, IHaveAliases, IHavePriceClass
        {
            /// <summary>
            /// Logging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-streamingdistributionconfig.html#cfn-cloudfront-streamingdistribution-streamingdistributionconfig-logging
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Logging
            /// </summary>
            public Humidifier.CloudFront.StreamingDistributionTypes.Logging Logging { get; set; }
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-streamingdistributionconfig.html#cfn-cloudfront-streamingdistribution-streamingdistributionconfig-comment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comment { get; set; }
            /// <summary>
            /// PriceClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-streamingdistributionconfig.html#cfn-cloudfront-streamingdistribution-streamingdistributionconfig-priceclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PriceClass { get; set; }
            /// <summary>
            /// S3Origin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-streamingdistributionconfig.html#cfn-cloudfront-streamingdistribution-streamingdistributionconfig-s3origin
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3Origin
            /// </summary>
            public Humidifier.CloudFront.StreamingDistributionTypes.S3Origin S3Origin { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-streamingdistributionconfig.html#cfn-cloudfront-streamingdistribution-streamingdistributionconfig-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// Aliases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-streamingdistributionconfig.html#cfn-cloudfront-streamingdistribution-streamingdistributionconfig-aliases
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Aliases { get; set; }
            /// <summary>
            /// TrustedSigners
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-streamingdistributionconfig.html#cfn-cloudfront-streamingdistribution-streamingdistributionconfig-trustedsigners
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TrustedSigners
            /// </summary>
            public Humidifier.CloudFront.StreamingDistributionTypes.TrustedSigners TrustedSigners { get; set; }
        }

        public class TrustedSigners : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-trustedsigners.html#cfn-cloudfront-streamingdistribution-trustedsigners-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// AwsAccountNumbers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-trustedsigners.html#cfn-cloudfront-streamingdistribution-trustedsigners-awsaccountnumbers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AwsAccountNumbers { get; set; }
        }
    }
}