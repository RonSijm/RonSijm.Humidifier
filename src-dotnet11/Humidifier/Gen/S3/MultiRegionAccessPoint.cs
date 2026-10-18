namespace Humidifier.S3
{
    using global::System.Collections.Generic;
    using MultiRegionAccessPointTypes;

    public class MultiRegionAccessPoint : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveS3MultiRegionAccessPointTypesPublicAccessBlockConfigurationPublicAccessBlockConfiguration, IHaveListOfS3MultiRegionAccessPointTypesRegionRegions, IHaveName
    {
        public class Attributes
        {
            public static string Alias =  "Alias" ;
            public static string CreatedAt =  "CreatedAt" ;
        }

        public override string AWSTypeName { get => AWS.S3.MultiRegionAccessPoint; }
        /// <summary>
        /// PublicAccessBlockConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-multiregionaccesspoint.html#cfn-s3-multiregionaccesspoint-publicaccessblockconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PublicAccessBlockConfiguration
        /// </summary>
        public Union<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration, BaseFunction>? PublicAccessBlockConfiguration { get; set; }

        /// <summary>
        /// Regions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-multiregionaccesspoint.html#cfn-s3-multiregionaccesspoint-regions
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Region
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.S3.MultiRegionAccessPointTypes.Region>, IReadOnlyList<Union<Humidifier.S3.MultiRegionAccessPointTypes.Region, BaseFunction>>, BaseFunction>? Regions { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace MultiRegionAccessPointTypes
    {
        public class PublicAccessBlockConfiguration : Humidifier.Base.BaseSubResource, IHaveRestrictPublicBuckets_Boolean, IHaveBlockPublicPolicy_Boolean, IHaveBlockPublicAcls_Boolean, IHaveIgnorePublicAcls_Boolean
        {
            /// <summary>
            /// RestrictPublicBuckets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-multiregionaccesspoint-publicaccessblockconfiguration.html#cfn-s3-multiregionaccesspoint-publicaccessblockconfiguration-restrictpublicbuckets
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RestrictPublicBuckets { get; set; }
            /// <summary>
            /// BlockPublicPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-multiregionaccesspoint-publicaccessblockconfiguration.html#cfn-s3-multiregionaccesspoint-publicaccessblockconfiguration-blockpublicpolicy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BlockPublicPolicy { get; set; }
            /// <summary>
            /// BlockPublicAcls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-multiregionaccesspoint-publicaccessblockconfiguration.html#cfn-s3-multiregionaccesspoint-publicaccessblockconfiguration-blockpublicacls
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BlockPublicAcls { get; set; }
            /// <summary>
            /// IgnorePublicAcls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-multiregionaccesspoint-publicaccessblockconfiguration.html#cfn-s3-multiregionaccesspoint-publicaccessblockconfiguration-ignorepublicacls
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IgnorePublicAcls { get; set; }
        }

        public class Region : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveBucketAccountId
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-multiregionaccesspoint-region.html#cfn-s3-multiregionaccesspoint-region-bucket
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// BucketAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-multiregionaccesspoint-region.html#cfn-s3-multiregionaccesspoint-region-bucketaccountid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketAccountId { get; set; }
        }
    }
}