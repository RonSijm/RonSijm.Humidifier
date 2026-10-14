namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using TrustStoreTypes;

    public class TrustStore : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ETag =  "ETag" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Id =  "Id" ;
            public static string NumberOfCaCertificates =  "NumberOfCaCertificates" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.TrustStore; }
        /// <summary>
        /// CaCertificatesBundleSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-truststore.html#cfn-cloudfront-truststore-cacertificatesbundlesource
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CaCertificatesBundleSource
        /// </summary>
        public Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource CaCertificatesBundleSource { get; set; }
        /// <summary>
        /// UseClientCertificateOCSPEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-truststore.html#cfn-cloudfront-truststore-useclientcertificateocspendpoint
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic UseClientCertificateOCSPEndpoint { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-truststore.html#cfn-cloudfront-truststore-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace TrustStoreTypes
    {
        public class CaCertificatesBundleS3Location : Humidifier.Base.BaseSubResource, IHaveKey, IHaveVersion, IHaveBucket, IHaveRegion
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-truststore-cacertificatesbundles3location.html#cfn-cloudfront-truststore-cacertificatesbundles3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-truststore-cacertificatesbundles3location.html#cfn-cloudfront-truststore-cacertificatesbundles3location-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Version { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-truststore-cacertificatesbundles3location.html#cfn-cloudfront-truststore-cacertificatesbundles3location-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-truststore-cacertificatesbundles3location.html#cfn-cloudfront-truststore-cacertificatesbundles3location-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class CaCertificatesBundleSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CaCertificatesBundleS3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-truststore-cacertificatesbundlesource.html#cfn-cloudfront-truststore-cacertificatesbundlesource-cacertificatesbundles3location
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CaCertificatesBundleS3Location
            /// </summary>
            public Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location CaCertificatesBundleS3Location { get; set; }
        }
    }
}