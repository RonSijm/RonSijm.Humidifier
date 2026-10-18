namespace Humidifier.S3Outposts
{
    using global::System.Collections.Generic;
    using BucketTypes;

    public class Bucket : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveOutpostId, IHaveBucketName, IHaveS3OutpostsBucketTypesLifecycleConfigurationLifecycleConfiguration
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.S3Outposts.Bucket; }

        /// <summary>
        /// OutpostId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3outposts-bucket.html#cfn-s3outposts-bucket-outpostid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OutpostId { get; set; }
        public Union<string, BaseFunction>? BucketName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// LifecycleConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3outposts-bucket.html#cfn-s3outposts-bucket-lifecycleconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LifecycleConfiguration
        /// </summary>
        public Union<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration, BaseFunction>? LifecycleConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3outposts-bucket.html#cfn-s3outposts-bucket-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace BucketTypes
    {
        public class AbortIncompleteMultipartUpload : Humidifier.Base.BaseSubResource, IHaveDaysAfterInitiation_Integer
        {
            /// <summary>
            /// DaysAfterInitiation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-abortincompletemultipartupload.html#cfn-s3outposts-bucket-abortincompletemultipartupload-daysafterinitiation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DaysAfterInitiation { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource, IHaveS3OutpostsBucketTypesFilterAndOperatorAndOperator, IHavePrefix, IHaveS3OutpostsBucketTypesFilterTagTag
        {
            /// <summary>
            /// AndOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-filter.html#cfn-s3outposts-bucket-filter-andoperator
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterAndOperator
            /// </summary>
            public Union<Humidifier.S3Outposts.BucketTypes.FilterAndOperator, BaseFunction>? AndOperator { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-filter.html#cfn-s3outposts-bucket-filter-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
            /// <summary>
            /// Tag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-filter.html#cfn-s3outposts-bucket-filter-tag
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterTag
            /// </summary>
            public Union<Humidifier.S3Outposts.BucketTypes.FilterTag, BaseFunction>? Tag { get; set; }
        }

        public class FilterAndOperator : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveListOfS3OutpostsBucketTypesFilterTagTags
        {
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-filterandoperator.html#cfn-s3outposts-bucket-filterandoperator-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-filterandoperator.html#cfn-s3outposts-bucket-filterandoperator-tags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterTag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3Outposts.BucketTypes.FilterTag>, IReadOnlyList<Union<Humidifier.S3Outposts.BucketTypes.FilterTag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class FilterTag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-filtertag.html#cfn-s3outposts-bucket-filtertag-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-filtertag.html#cfn-s3outposts-bucket-filtertag-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class LifecycleConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfS3OutpostsBucketTypesRuleRules
        {
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-lifecycleconfiguration.html#cfn-s3outposts-bucket-lifecycleconfiguration-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Rule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3Outposts.BucketTypes.Rule>, IReadOnlyList<Union<Humidifier.S3Outposts.BucketTypes.Rule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveExpirationDate, IHaveS3OutpostsBucketTypesFilterFilter, IHaveExpirationInDays_Integer, IHaveId, IHaveS3OutpostsBucketTypesAbortIncompleteMultipartUploadAbortIncompleteMultipartUpload
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-rule.html#cfn-s3outposts-bucket-rule-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// ExpirationDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-rule.html#cfn-s3outposts-bucket-rule-expirationdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExpirationDate { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-rule.html#cfn-s3outposts-bucket-rule-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Filter
            /// </summary>
            public Union<Humidifier.S3Outposts.BucketTypes.Filter, BaseFunction>? Filter { get; set; }
            /// <summary>
            /// ExpirationInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-rule.html#cfn-s3outposts-bucket-rule-expirationindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ExpirationInDays { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-rule.html#cfn-s3outposts-bucket-rule-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// AbortIncompleteMultipartUpload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-rule.html#cfn-s3outposts-bucket-rule-abortincompletemultipartupload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AbortIncompleteMultipartUpload
            /// </summary>
            public Union<Humidifier.S3Outposts.BucketTypes.AbortIncompleteMultipartUpload, BaseFunction>? AbortIncompleteMultipartUpload { get; set; }
        }
    }
}