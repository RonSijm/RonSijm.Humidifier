namespace Humidifier.Macie
{
    using System.Collections.Generic;
    using AllowListTypes;

    public class AllowList : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Macie.AllowList; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-allowlist.html#cfn-macie-allowlist-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Criteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-allowlist.html#cfn-macie-allowlist-criteria
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Criteria
        /// </summary>
        [Required]
        public Humidifier.Macie.AllowListTypes.Criteria Criteria { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-allowlist.html#cfn-macie-allowlist-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace AllowListTypes
    {
        public class Criteria : Humidifier.Base.BaseSubResource, IHaveRegex
        {
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-macie-allowlist-criteria.html#cfn-macie-allowlist-criteria-regex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Regex { get; set; }
            /// <summary>
            /// S3WordsList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-macie-allowlist-criteria.html#cfn-macie-allowlist-criteria-s3wordslist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3WordsList
            /// </summary>
            public Humidifier.Macie.AllowListTypes.S3WordsList S3WordsList { get; set; }
        }

        public class S3WordsList : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveObjectKey
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-macie-allowlist-s3wordslist.html#cfn-macie-allowlist-s3wordslist-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// ObjectKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-macie-allowlist-s3wordslist.html#cfn-macie-allowlist-s3wordslist-objectkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectKey { get; set; }
        }
    }
}