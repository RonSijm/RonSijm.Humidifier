namespace Humidifier.ElasticLoadBalancingV2
{
    using global::System.Collections.Generic;

    public class TrustStore : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCaCertificatesBundleS3Bucket, IHaveCaCertificatesBundleS3ObjectVersion, IHaveName, IHaveCaCertificatesBundleS3Key
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string TrustStoreArn =  "TrustStoreArn" ;
            public static string NumberOfCaCertificates =  "NumberOfCaCertificates" ;
        }

        public override string AWSTypeName { get => AWS.ElasticLoadBalancingV2.TrustStore; }
        /// <summary>
        /// CaCertificatesBundleS3Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-truststore.html#cfn-elasticloadbalancingv2-truststore-cacertificatesbundles3bucket
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CaCertificatesBundleS3Bucket { get; set; }
        /// <summary>
        /// CaCertificatesBundleS3ObjectVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-truststore.html#cfn-elasticloadbalancingv2-truststore-cacertificatesbundles3objectversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CaCertificatesBundleS3ObjectVersion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-truststore.html#cfn-elasticloadbalancingv2-truststore-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// CaCertificatesBundleS3Key
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-truststore.html#cfn-elasticloadbalancingv2-truststore-cacertificatesbundles3key
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CaCertificatesBundleS3Key { get; set; }
    }
}