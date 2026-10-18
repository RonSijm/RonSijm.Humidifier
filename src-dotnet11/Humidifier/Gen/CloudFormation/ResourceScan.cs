namespace Humidifier.CloudFormation
{
    using global::System.Collections.Generic;
    using ResourceScanTypes;

    public class ResourceScan : Humidifier.Base.BaseResource, IHaveListOfCloudFormationResourceScanTypesScanFilterScanFilters
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
        public Union<IReadOnlyList<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter>, IReadOnlyList<Union<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter, BaseFunction>>, BaseFunction>? ScanFilters { get; set; }
    }

    namespace ResourceScanTypes
    {
        public class ScanFilter : Humidifier.Base.BaseSubResource, IHaveStringListOfTypes
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-resourcescan-scanfilter.html#cfn-cloudformation-resourcescan-scanfilter-types
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Types { get; set; }
        }
    }
}