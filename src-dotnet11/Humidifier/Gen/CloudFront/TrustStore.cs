namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using TrustStoreTypes;

    public class TrustStore : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCloudFrontTrustStoreTypesCaCertificatesBundleSourceCaCertificatesBundleSource, IHaveUseClientCertificateOCSPEndpoint_Boolean, IHaveName
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
        public Union<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource, BaseFunction>? CaCertificatesBundleSource { get; set; }
        /// <summary>
        /// UseClientCertificateOCSPEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-truststore.html#cfn-cloudfront-truststore-useclientcertificateocspendpoint
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? UseClientCertificateOCSPEndpoint { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-truststore.html#cfn-cloudfront-truststore-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace TrustStoreTypes
    {
        public class CaCertificatesBundleS3Location : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveVersion, IHaveRegion, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-truststore-cacertificatesbundles3location.html#cfn-cloudfront-truststore-cacertificatesbundles3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-truststore-cacertificatesbundles3location.html#cfn-cloudfront-truststore-cacertificatesbundles3location-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-truststore-cacertificatesbundles3location.html#cfn-cloudfront-truststore-cacertificatesbundles3location-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-truststore-cacertificatesbundles3location.html#cfn-cloudfront-truststore-cacertificatesbundles3location-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class CaCertificatesBundleSource : Humidifier.Base.BaseSubResource, IHaveCloudFrontTrustStoreTypesCaCertificatesBundleS3LocationCaCertificatesBundleS3Location
        {
            /// <summary>
            /// CaCertificatesBundleS3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-truststore-cacertificatesbundlesource.html#cfn-cloudfront-truststore-cacertificatesbundlesource-cacertificatesbundles3location
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CaCertificatesBundleS3Location
            /// </summary>
            public Union<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location, BaseFunction>? CaCertificatesBundleS3Location { get; set; }
        }
    }
}