namespace Humidifier.S3
{
    using global::System.Collections.Generic;
    using StorageLensGroupTypes;

    public class StorageLensGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveS3StorageLensGroupTypesFilterFilter, IHaveName
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
        public Union<Humidifier.S3.StorageLensGroupTypes.Filter, BaseFunction>? Filter { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-storagelensgroup.html#cfn-s3-storagelensgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace StorageLensGroupTypes
    {
        public class And : Humidifier.Base.BaseSubResource, IHaveMatchAnyTag, IHaveS3StorageLensGroupTypesMatchObjectAgeMatchObjectAge, IHaveStringListOfMatchAnyPrefix, IHaveStringListOfMatchAnySuffix, IHaveS3StorageLensGroupTypesMatchObjectSizeMatchObjectSize
        {
            /// <summary>
            /// MatchObjectAge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-and.html#cfn-s3-storagelensgroup-and-matchobjectage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchObjectAge
            /// </summary>
            public Union<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge, BaseFunction>? MatchObjectAge { get; set; }
            /// <summary>
            /// MatchAnyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-and.html#cfn-s3-storagelensgroup-and-matchanyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchAnyPrefix { get; set; }
            /// <summary>
            /// MatchAnyTag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-and.html#cfn-s3-storagelensgroup-and-matchanytag
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? MatchAnyTag { get; set; }
            /// <summary>
            /// MatchAnySuffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-and.html#cfn-s3-storagelensgroup-and-matchanysuffix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchAnySuffix { get; set; }
            /// <summary>
            /// MatchObjectSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-and.html#cfn-s3-storagelensgroup-and-matchobjectsize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchObjectSize
            /// </summary>
            public Union<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize, BaseFunction>? MatchObjectSize { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource, IHaveMatchAnyTag, IHaveS3StorageLensGroupTypesMatchObjectAgeMatchObjectAge, IHaveS3StorageLensGroupTypesOrOr, IHaveS3StorageLensGroupTypesAndAnd, IHaveStringListOfMatchAnyPrefix, IHaveStringListOfMatchAnySuffix, IHaveS3StorageLensGroupTypesMatchObjectSizeMatchObjectSize
        {
            /// <summary>
            /// MatchObjectAge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-filter.html#cfn-s3-storagelensgroup-filter-matchobjectage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchObjectAge
            /// </summary>
            public Union<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge, BaseFunction>? MatchObjectAge { get; set; }
            /// <summary>
            /// Or
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-filter.html#cfn-s3-storagelensgroup-filter-or
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Or
            /// </summary>
            public Union<Humidifier.S3.StorageLensGroupTypes.Or, BaseFunction>? Or { get; set; }
            /// <summary>
            /// And
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-filter.html#cfn-s3-storagelensgroup-filter-and
            /// Required: False
            /// UpdateType: Mutable
            /// Type: And
            /// </summary>
            public Union<Humidifier.S3.StorageLensGroupTypes.And, BaseFunction>? And { get; set; }
            /// <summary>
            /// MatchAnyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-filter.html#cfn-s3-storagelensgroup-filter-matchanyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchAnyPrefix { get; set; }
            /// <summary>
            /// MatchAnyTag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-filter.html#cfn-s3-storagelensgroup-filter-matchanytag
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? MatchAnyTag { get; set; }
            /// <summary>
            /// MatchAnySuffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-filter.html#cfn-s3-storagelensgroup-filter-matchanysuffix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchAnySuffix { get; set; }
            /// <summary>
            /// MatchObjectSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-filter.html#cfn-s3-storagelensgroup-filter-matchobjectsize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchObjectSize
            /// </summary>
            public Union<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize, BaseFunction>? MatchObjectSize { get; set; }
        }

        public class MatchObjectAge : Humidifier.Base.BaseSubResource, IHaveDaysLessThan_Integer, IHaveDaysGreaterThan_Integer
        {
            /// <summary>
            /// DaysLessThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-matchobjectage.html#cfn-s3-storagelensgroup-matchobjectage-dayslessthan
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DaysLessThan { get; set; }
            /// <summary>
            /// DaysGreaterThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-matchobjectage.html#cfn-s3-storagelensgroup-matchobjectage-daysgreaterthan
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DaysGreaterThan { get; set; }
        }

        public class MatchObjectSize : Humidifier.Base.BaseSubResource, IHaveBytesGreaterThan_Long, IHaveBytesLessThan_Long
        {
            /// <summary>
            /// BytesGreaterThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-matchobjectsize.html#cfn-s3-storagelensgroup-matchobjectsize-bytesgreaterthan
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? BytesGreaterThan { get; set; }
            /// <summary>
            /// BytesLessThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-matchobjectsize.html#cfn-s3-storagelensgroup-matchobjectsize-byteslessthan
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? BytesLessThan { get; set; }
        }

        public class Or : Humidifier.Base.BaseSubResource, IHaveMatchAnyTag, IHaveS3StorageLensGroupTypesMatchObjectAgeMatchObjectAge, IHaveStringListOfMatchAnyPrefix, IHaveStringListOfMatchAnySuffix, IHaveS3StorageLensGroupTypesMatchObjectSizeMatchObjectSize
        {
            /// <summary>
            /// MatchObjectAge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-or.html#cfn-s3-storagelensgroup-or-matchobjectage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchObjectAge
            /// </summary>
            public Union<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge, BaseFunction>? MatchObjectAge { get; set; }
            /// <summary>
            /// MatchAnyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-or.html#cfn-s3-storagelensgroup-or-matchanyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchAnyPrefix { get; set; }
            /// <summary>
            /// MatchAnyTag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-or.html#cfn-s3-storagelensgroup-or-matchanytag
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? MatchAnyTag { get; set; }
            /// <summary>
            /// MatchAnySuffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-or.html#cfn-s3-storagelensgroup-or-matchanysuffix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchAnySuffix { get; set; }
            /// <summary>
            /// MatchObjectSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelensgroup-or.html#cfn-s3-storagelensgroup-or-matchobjectsize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchObjectSize
            /// </summary>
            public Union<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize, BaseFunction>? MatchObjectSize { get; set; }
        }
    }
}