namespace Humidifier.ElasticLoadBalancingV2
{
    using System.Collections.Generic;
    using TrustStoreRevocationTypes;

    public class TrustStoreRevocation : Humidifier.Base.BaseResource, IHaveTrustStoreArn
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
        public List<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent> RevocationContents { get; set; }
        /// <summary>
        /// TrustStoreArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-truststorerevocation.html#cfn-elasticloadbalancingv2-truststorerevocation-truststorearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TrustStoreArn { get; set; }
    }

    namespace TrustStoreRevocationTypes
    {
        public class RevocationContent : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveS3Key, IHaveS3ObjectVersion, IHaveRevocationType
        {
            /// <summary>
            /// S3ObjectVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-truststorerevocation-revocationcontent.html#cfn-elasticloadbalancingv2-truststorerevocation-revocationcontent-s3objectversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3ObjectVersion { get; set; }
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-truststorerevocation-revocationcontent.html#cfn-elasticloadbalancingv2-truststorerevocation-revocationcontent-s3bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Bucket { get; set; }
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-truststorerevocation-revocationcontent.html#cfn-elasticloadbalancingv2-truststorerevocation-revocationcontent-s3key
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Key { get; set; }
            /// <summary>
            /// RevocationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-truststorerevocation-revocationcontent.html#cfn-elasticloadbalancingv2-truststorerevocation-revocationcontent-revocationtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RevocationType { get; set; }
        }

        public class TrustStoreRevocation : Humidifier.Base.BaseSubResource, IHaveTrustStoreArn, IHaveRevocationType
        {
            /// <summary>
            /// NumberOfRevokedEntries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-truststorerevocation-truststorerevocation.html#cfn-elasticloadbalancingv2-truststorerevocation-truststorerevocation-numberofrevokedentries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfRevokedEntries { get; set; }
            /// <summary>
            /// TrustStoreArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-truststorerevocation-truststorerevocation.html#cfn-elasticloadbalancingv2-truststorerevocation-truststorerevocation-truststorearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TrustStoreArn { get; set; }
            /// <summary>
            /// RevocationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-truststorerevocation-truststorerevocation.html#cfn-elasticloadbalancingv2-truststorerevocation-truststorerevocation-revocationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RevocationType { get; set; }
            /// <summary>
            /// RevocationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-truststorerevocation-truststorerevocation.html#cfn-elasticloadbalancingv2-truststorerevocation-truststorerevocation-revocationid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RevocationId { get; set; }
        }
    }
}