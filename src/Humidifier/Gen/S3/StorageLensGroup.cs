namespace Humidifier.S3
{
    using System.Collections.Generic;
    using StorageLensGroupTypes;

    public class StorageLensGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
    {
        public class Attributes
        {
            public static string StorageLensGroupArn =  "StorageLensGroupArn" ;
        }

        public override string AWSTypeName { get => AWS.S3.StorageLensGroup; }

        /// <summary>
        /// Filter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-storagelensgroup.html#cfn-s3-storagelensgroup-filter
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Filter
        /// </summary>
        [Required]
        public Humidifier.S3.StorageLensGroupTypes.Filter Filter { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-storagelensgroup.html#cfn-s3-storagelensgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace StorageLensGroupTypes
    {
        public class And : Humidifier.Base.BaseSubResource, IHaveS3StorageLensGroupTypesMatchObjectAgeMatchObjectAge, IHaveMatchAnyPrefix, IHaveMatchAnySuffix, IHaveS3StorageLensGroupTypesMatchObjectSizeMatchObjectSize
        {
            /// <summary>
            /// MatchObjectAge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-and.html#cfn-s3-storagelensgroup-and-matchobjectage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchObjectAge
            /// </summary>
            public Humidifier.S3.StorageLensGroupTypes.MatchObjectAge MatchObjectAge { get; set; }
            /// <summary>
            /// MatchAnyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-and.html#cfn-s3-storagelensgroup-and-matchanyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchAnyPrefix { get; set; }
            /// <summary>
            /// MatchAnyTag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-and.html#cfn-s3-storagelensgroup-and-matchanytag
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Tag> MatchAnyTag { get; set; }
            /// <summary>
            /// MatchAnySuffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-and.html#cfn-s3-storagelensgroup-and-matchanysuffix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchAnySuffix { get; set; }
            /// <summary>
            /// MatchObjectSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-and.html#cfn-s3-storagelensgroup-and-matchobjectsize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchObjectSize
            /// </summary>
            public Humidifier.S3.StorageLensGroupTypes.MatchObjectSize MatchObjectSize { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource, IHaveS3StorageLensGroupTypesMatchObjectAgeMatchObjectAge, IHaveMatchAnyPrefix, IHaveMatchAnySuffix, IHaveS3StorageLensGroupTypesMatchObjectSizeMatchObjectSize
        {
            /// <summary>
            /// MatchObjectAge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-filter.html#cfn-s3-storagelensgroup-filter-matchobjectage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchObjectAge
            /// </summary>
            public Humidifier.S3.StorageLensGroupTypes.MatchObjectAge MatchObjectAge { get; set; }
            /// <summary>
            /// Or
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-filter.html#cfn-s3-storagelensgroup-filter-or
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Or
            /// </summary>
            public Humidifier.S3.StorageLensGroupTypes.Or Or { get; set; }
            /// <summary>
            /// And
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-filter.html#cfn-s3-storagelensgroup-filter-and
            /// Required: False
            /// UpdateType: Mutable
            /// Type: And
            /// </summary>
            public Humidifier.S3.StorageLensGroupTypes.And And { get; set; }
            /// <summary>
            /// MatchAnyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-filter.html#cfn-s3-storagelensgroup-filter-matchanyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchAnyPrefix { get; set; }
            /// <summary>
            /// MatchAnyTag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-filter.html#cfn-s3-storagelensgroup-filter-matchanytag
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Tag> MatchAnyTag { get; set; }
            /// <summary>
            /// MatchAnySuffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-filter.html#cfn-s3-storagelensgroup-filter-matchanysuffix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchAnySuffix { get; set; }
            /// <summary>
            /// MatchObjectSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-filter.html#cfn-s3-storagelensgroup-filter-matchobjectsize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchObjectSize
            /// </summary>
            public Humidifier.S3.StorageLensGroupTypes.MatchObjectSize MatchObjectSize { get; set; }
        }

        public class MatchObjectAge : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DaysLessThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-matchobjectage.html#cfn-s3-storagelensgroup-matchobjectage-dayslessthan
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DaysLessThan { get; set; }
            /// <summary>
            /// DaysGreaterThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-matchobjectage.html#cfn-s3-storagelensgroup-matchobjectage-daysgreaterthan
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DaysGreaterThan { get; set; }
        }

        public class MatchObjectSize : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BytesLessThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-matchobjectsize.html#cfn-s3-storagelensgroup-matchobjectsize-byteslessthan
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BytesLessThan { get; set; }
            /// <summary>
            /// BytesGreaterThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-matchobjectsize.html#cfn-s3-storagelensgroup-matchobjectsize-bytesgreaterthan
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BytesGreaterThan { get; set; }
        }

        public class Or : Humidifier.Base.BaseSubResource, IHaveS3StorageLensGroupTypesMatchObjectAgeMatchObjectAge, IHaveMatchAnyPrefix, IHaveMatchAnySuffix, IHaveS3StorageLensGroupTypesMatchObjectSizeMatchObjectSize
        {
            /// <summary>
            /// MatchObjectAge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-or.html#cfn-s3-storagelensgroup-or-matchobjectage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchObjectAge
            /// </summary>
            public Humidifier.S3.StorageLensGroupTypes.MatchObjectAge MatchObjectAge { get; set; }
            /// <summary>
            /// MatchAnyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-or.html#cfn-s3-storagelensgroup-or-matchanyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchAnyPrefix { get; set; }
            /// <summary>
            /// MatchAnyTag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-or.html#cfn-s3-storagelensgroup-or-matchanytag
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Tag> MatchAnyTag { get; set; }
            /// <summary>
            /// MatchAnySuffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-or.html#cfn-s3-storagelensgroup-or-matchanysuffix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchAnySuffix { get; set; }
            /// <summary>
            /// MatchObjectSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-or.html#cfn-s3-storagelensgroup-or-matchobjectsize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchObjectSize
            /// </summary>
            public Humidifier.S3.StorageLensGroupTypes.MatchObjectSize MatchObjectSize { get; set; }
        }
    }
}