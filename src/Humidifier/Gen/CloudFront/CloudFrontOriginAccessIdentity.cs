namespace Humidifier.CloudFront
{
    using System.Collections.Generic;
    using CloudFrontOriginAccessIdentityTypes;

    public class CloudFrontOriginAccessIdentity : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string S3CanonicalUserId =  "S3CanonicalUserId" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.CloudFrontOriginAccessIdentity; }

        /// <summary>
        /// CloudFrontOriginAccessIdentityConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-cloudfrontoriginaccessidentity.html#cfn-cloudfront-cloudfrontoriginaccessidentity-cloudfrontoriginaccessidentityconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CloudFrontOriginAccessIdentityConfig
        /// </summary>
        [Required]
        public Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig CloudFrontOriginAccessIdentityConfig { get; set; }
    }

    namespace CloudFrontOriginAccessIdentityTypes
    {
        public class CloudFrontOriginAccessIdentityConfig : Humidifier.Base.BaseSubResource, IHaveComment
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cloudfrontoriginaccessidentity-cloudfrontoriginaccessidentityconfig.html#cfn-cloudfront-cloudfrontoriginaccessidentity-cloudfrontoriginaccessidentityconfig-comment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comment { get; set; }
        }
    }
}