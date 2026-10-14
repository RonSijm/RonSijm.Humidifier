namespace Humidifier.CloudFormation
{
    using global::System.Collections.Generic;
    using ResourceScanTypes;

    public class ResourceScan : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string PercentageCompleted =  "PercentageCompleted" ;
            public static string StartTime =  "StartTime" ;
            public static string ScanId =  "ScanId" ;
            public static string ResourceScanId =  "ResourceScanId" ;
        }

        public override string AWSTypeName { get => AWS.CloudFormation.ResourceScan; }
        /// <summary>
        /// ScanFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-resourcescan.html#cfn-cloudformation-resourcescan-scanfilters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ScanFilter
        /// </summary>
        public List<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter> ScanFilters { get; set; }
    }

    namespace ResourceScanTypes
    {
        public class ScanFilter : Humidifier.Base.BaseSubResource, IHaveTypes
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-resourcescan-scanfilter.html#cfn-cloudformation-resourcescan-scanfilter-types
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Types { get; set; }
        }
    }
}