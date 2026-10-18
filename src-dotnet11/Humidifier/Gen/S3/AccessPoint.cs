namespace Humidifier.S3
{
    using global::System.Collections.Generic;
    using AccessPointTypes;

    public class AccessPoint : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePolicy_Json, IHaveS3AccessPointTypesPublicAccessBlockConfigurationPublicAccessBlockConfiguration, IHaveBucket, IHaveBucketAccountId, IHaveS3AccessPointTypesVpcConfigurationVpcConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string Alias =  "Alias" ;
            public static string Arn =  "Arn" ;
            public static string NetworkOrigin =  "NetworkOrigin" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.S3.AccessPoint; }
        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accesspoint.html#cfn-s3-accesspoint-policy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Policy { get; set; }
        /// <summary>
        /// PublicAccessBlockConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accesspoint.html#cfn-s3-accesspoint-publicaccessblockconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PublicAccessBlockConfiguration
        /// </summary>
        public Union<Humidifier.S3.AccessPointTypes.PublicAccessBlockConfiguration, BaseFunction>? PublicAccessBlockConfiguration { get; set; }

        /// <summary>
        /// Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accesspoint.html#cfn-s3-accesspoint-bucket
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Bucket { get; set; }
        /// <summary>
        /// BucketAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accesspoint.html#cfn-s3-accesspoint-bucketaccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BucketAccountId { get; set; }
        /// <summary>
        /// VpcConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accesspoint.html#cfn-s3-accesspoint-vpcconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcConfiguration
        /// </summary>
        public Union<Humidifier.S3.AccessPointTypes.VpcConfiguration, BaseFunction>? VpcConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accesspoint.html#cfn-s3-accesspoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AccessPointTypes
    {
        public class PublicAccessBlockConfiguration : Humidifier.Base.BaseSubResource, IHaveRestrictPublicBuckets_Boolean, IHaveBlockPublicPolicy_Boolean, IHaveBlockPublicAcls_Boolean, IHaveIgnorePublicAcls_Boolean
        {
            /// <summary>
            /// RestrictPublicBuckets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-accesspoint-publicaccessblockconfiguration.html#cfn-s3-accesspoint-publicaccessblockconfiguration-restrictpublicbuckets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RestrictPublicBuckets { get; set; }
            /// <summary>
            /// BlockPublicPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-accesspoint-publicaccessblockconfiguration.html#cfn-s3-accesspoint-publicaccessblockconfiguration-blockpublicpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BlockPublicPolicy { get; set; }
            /// <summary>
            /// BlockPublicAcls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-accesspoint-publicaccessblockconfiguration.html#cfn-s3-accesspoint-publicaccessblockconfiguration-blockpublicacls
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BlockPublicAcls { get; set; }
            /// <summary>
            /// IgnorePublicAcls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-accesspoint-publicaccessblockconfiguration.html#cfn-s3-accesspoint-publicaccessblockconfiguration-ignorepublicacls
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IgnorePublicAcls { get; set; }
        }

        public class VpcConfiguration : Humidifier.Base.BaseSubResource, IHaveVpcId
        {
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-accesspoint-vpcconfiguration.html#cfn-s3-accesspoint-vpcconfiguration-vpcid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
        }
    }
}