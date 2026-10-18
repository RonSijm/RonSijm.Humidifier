namespace Humidifier.CUR
{
    using global::System.Collections.Generic;

    public class ReportDefinition : Humidifier.Base.BaseResource, IHaveTags, IHaveCompression, IHaveRefreshClosedReports_Boolean, IHaveReportVersioning, IHaveS3Prefix, IHaveStringListOfAdditionalSchemaElements, IHaveStringListOfAdditionalArtifacts, IHaveReportName, IHaveFormat, IHaveS3Bucket, IHaveS3Region, IHaveTimeUnit, IHaveBillingViewArn
    {
        public override string AWSTypeName { get => AWS.CUR.ReportDefinition; }

        /// <summary>
        /// Compression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cur-reportdefinition.html#cfn-cur-reportdefinition-compression
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Compression { get; set; }

        /// <summary>
        /// RefreshClosedReports
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cur-reportdefinition.html#cfn-cur-reportdefinition-refreshclosedreports
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public Union<bool, BaseFunction>? RefreshClosedReports { get; set; }

        /// <summary>
        /// ReportVersioning
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cur-reportdefinition.html#cfn-cur-reportdefinition-reportversioning
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ReportVersioning { get; set; }

        /// <summary>
        /// S3Prefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cur-reportdefinition.html#cfn-cur-reportdefinition-s3prefix
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? S3Prefix { get; set; }
        /// <summary>
        /// AdditionalSchemaElements
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cur-reportdefinition.html#cfn-cur-reportdefinition-additionalschemaelements
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdditionalSchemaElements { get; set; }
        /// <summary>
        /// AdditionalArtifacts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cur-reportdefinition.html#cfn-cur-reportdefinition-additionalartifacts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdditionalArtifacts { get; set; }

        /// <summary>
        /// ReportName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cur-reportdefinition.html#cfn-cur-reportdefinition-reportname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ReportName { get; set; }

        /// <summary>
        /// Format
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cur-reportdefinition.html#cfn-cur-reportdefinition-format
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Format { get; set; }

        /// <summary>
        /// S3Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cur-reportdefinition.html#cfn-cur-reportdefinition-s3bucket
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? S3Bucket { get; set; }

        /// <summary>
        /// S3Region
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cur-reportdefinition.html#cfn-cur-reportdefinition-s3region
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? S3Region { get; set; }

        /// <summary>
        /// TimeUnit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cur-reportdefinition.html#cfn-cur-reportdefinition-timeunit
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TimeUnit { get; set; }
        /// <summary>
        /// BillingViewArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cur-reportdefinition.html#cfn-cur-reportdefinition-billingviewarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BillingViewArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cur-reportdefinition.html#cfn-cur-reportdefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}