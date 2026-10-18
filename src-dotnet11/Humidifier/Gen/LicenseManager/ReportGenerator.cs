namespace Humidifier.LicenseManager
{
    using global::System.Collections.Generic;
    using ReportGeneratorTypes;

    public class ReportGenerator : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveLicenseManagerReportGeneratorTypesReportContextReportContext, IHaveStringListOfReportType, IHaveLicenseManagerReportGeneratorTypesReportFrequencyReportFrequency, IHaveReportGeneratorName
    {
        public class Attributes
        {
            public static string CreateTime =  "CreateTime" ;
            public static string ReportCreatorAccount =  "ReportCreatorAccount" ;
            public static string Arn =  "Arn" ;
            public static string S3Location =  "S3Location" ;
        }

        public override string AWSTypeName { get => AWS.LicenseManager.ReportGenerator; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-reportgenerator.html#cfn-licensemanager-reportgenerator-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ReportContext
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-reportgenerator.html#cfn-licensemanager-reportgenerator-reportcontext
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ReportContext
        /// </summary>
        [Required]
        public Union<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext, BaseFunction>? ReportContext { get; set; }

        /// <summary>
        /// ReportType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-reportgenerator.html#cfn-licensemanager-reportgenerator-reporttype
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ReportType { get; set; }

        /// <summary>
        /// ReportFrequency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-reportgenerator.html#cfn-licensemanager-reportgenerator-reportfrequency
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ReportFrequency
        /// </summary>
        [Required]
        public Union<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency, BaseFunction>? ReportFrequency { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-reportgenerator.html#cfn-licensemanager-reportgenerator-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? ReportGeneratorName { get => GivenName; set => GivenName = value; }
    }

    namespace ReportGeneratorTypes
    {
        public class ReportContext : Humidifier.Base.BaseSubResource, IHaveStringListOfLicenseConfigurationArns, IHaveStringListOfLicenseAssetGroupArns, IHaveReportStartDate, IHaveReportEndDate
        {
            /// <summary>
            /// LicenseConfigurationArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-reportgenerator-reportcontext.html#cfn-licensemanager-reportgenerator-reportcontext-licenseconfigurationarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LicenseConfigurationArns { get; set; }
            /// <summary>
            /// LicenseAssetGroupArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-reportgenerator-reportcontext.html#cfn-licensemanager-reportgenerator-reportcontext-licenseassetgrouparns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LicenseAssetGroupArns { get; set; }
            /// <summary>
            /// ReportStartDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-reportgenerator-reportcontext.html#cfn-licensemanager-reportgenerator-reportcontext-reportstartdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReportStartDate { get; set; }
            /// <summary>
            /// ReportEndDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-reportgenerator-reportcontext.html#cfn-licensemanager-reportgenerator-reportcontext-reportenddate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReportEndDate { get; set; }
        }

        public class ReportFrequency : Humidifier.Base.BaseSubResource, IHaveValue_Integer, IHavePeriod
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-reportgenerator-reportfrequency.html#cfn-licensemanager-reportgenerator-reportfrequency-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-reportgenerator-reportfrequency.html#cfn-licensemanager-reportgenerator-reportfrequency-period
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Period { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveKeyPrefix
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-reportgenerator-s3location.html#cfn-licensemanager-reportgenerator-s3location-bucket
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-reportgenerator-s3location.html#cfn-licensemanager-reportgenerator-s3location-keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyPrefix { get; set; }
        }
    }
}