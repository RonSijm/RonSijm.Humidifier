namespace Humidifier.ElasticLoadBalancingV2
{
    using global::System.Collections.Generic;
    using TrustStoreRevocationTypes;

    public class TrustStoreRevocation : Humidifier.Base.BaseResource, IHaveListOfElasticLoadBalancingV2TrustStoreRevocationTypesRevocationContentRevocationContents, IHaveTrustStoreArn
    {
        public class Attributes
        {
            public static string TrustStoreRevocations =  "TrustStoreRevocations" ;
            public static string RevocationId =  "RevocationId" ;
        }

        public override string AWSTypeName { get => AWS.ElasticLoadBalancingV2.TrustStoreRevocation; }
        /// <summary>
        /// RevocationContents
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-truststorerevocation.html#cfn-elasticloadbalancingv2-truststorerevocation-revocationcontents
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: RevocationContent
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent, BaseFunction>>, BaseFunction>? RevocationContents { get; set; }
        /// <summary>
        /// TrustStoreArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-truststorerevocation.html#cfn-elasticloadbalancingv2-truststorerevocation-truststorearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TrustStoreArn { get; set; }
    }

    namespace TrustStoreRevocationTypes
    {
        public class RevocationContent : Humidifier.Base.BaseSubResource, IHaveS3ObjectVersion, IHaveS3Bucket, IHaveS3Key, IHaveRevocationType
        {
            /// <summary>
            /// S3ObjectVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-truststorerevocation-revocationcontent.html#cfn-elasticloadbalancingv2-truststorerevocation-revocationcontent-s3objectversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3ObjectVersion { get; set; }
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-truststorerevocation-revocationcontent.html#cfn-elasticloadbalancingv2-truststorerevocation-revocationcontent-s3bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-truststorerevocation-revocationcontent.html#cfn-elasticloadbalancingv2-truststorerevocation-revocationcontent-s3key
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Key { get; set; }
            /// <summary>
            /// RevocationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-truststorerevocation-revocationcontent.html#cfn-elasticloadbalancingv2-truststorerevocation-revocationcontent-revocationtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RevocationType { get; set; }
        }

        public class TrustStoreRevocation : Humidifier.Base.BaseSubResource, IHaveNumberOfRevokedEntries_Long, IHaveTrustStoreArn, IHaveRevocationType, IHaveRevocationId
        {
            /// <summary>
            /// NumberOfRevokedEntries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-truststorerevocation-truststorerevocation.html#cfn-elasticloadbalancingv2-truststorerevocation-truststorerevocation-numberofrevokedentries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? NumberOfRevokedEntries { get; set; }
            /// <summary>
            /// TrustStoreArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-truststorerevocation-truststorerevocation.html#cfn-elasticloadbalancingv2-truststorerevocation-truststorerevocation-truststorearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrustStoreArn { get; set; }
            /// <summary>
            /// RevocationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-truststorerevocation-truststorerevocation.html#cfn-elasticloadbalancingv2-truststorerevocation-truststorerevocation-revocationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RevocationType { get; set; }
            /// <summary>
            /// RevocationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-truststorerevocation-truststorerevocation.html#cfn-elasticloadbalancingv2-truststorerevocation-truststorerevocation-revocationid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RevocationId { get; set; }
        }
    }
}