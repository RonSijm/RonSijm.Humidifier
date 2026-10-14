namespace Humidifier.StorageGateway
{
    using global::System.Collections.Generic;
    using CacheReportTypes;

    public class CacheReport : Humidifier.Base.BaseResource, IHaveTags, IHaveRole
    {
        public class Attributes
        {
            public static string CacheReportStatus =  "CacheReportStatus" ;
            public static string ReportName =  "ReportName" ;
            public static string EndTime =  "EndTime" ;
            public static string StartTime =  "StartTime" ;
            public static string ReportCompletionPercent =  "ReportCompletionPercent" ;
            public static string CacheReportARN =  "CacheReportARN" ;
        }

        public override string AWSTypeName { get => AWS.StorageGateway.CacheReport; }

        /// <summary>
        /// Role
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-cachereport.html#cfn-storagegateway-cachereport-role
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Role { get; set; }
        /// <summary>
        /// InclusionFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-cachereport.html#cfn-storagegateway-cachereport-inclusionfilters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: CacheReportFilter
        /// </summary>
        public List<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> InclusionFilters { get; set; }
        /// <summary>
        /// ExclusionFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-cachereport.html#cfn-storagegateway-cachereport-exclusionfilters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: CacheReportFilter
        /// </summary>
        public List<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> ExclusionFilters { get; set; }

        /// <summary>
        /// FileShareARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-cachereport.html#cfn-storagegateway-cachereport-filesharearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FileShareARN { get; set; }

        /// <summary>
        /// LocationARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-cachereport.html#cfn-storagegateway-cachereport-locationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LocationARN { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-cachereport.html#cfn-storagegateway-cachereport-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace CacheReportTypes
    {
        public class CacheReportFilter : Humidifier.Base.BaseSubResource, IHaveName, IHaveValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-cachereport-cachereportfilter.html#cfn-storagegateway-cachereport-cachereportfilter-values
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-cachereport-cachereportfilter.html#cfn-storagegateway-cachereport-cachereportfilter-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}