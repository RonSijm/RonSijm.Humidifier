namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;
    using OTelEnrichmentTypes;

    public class OTelEnrichment : Humidifier.Base.BaseResource, IHaveListOfCloudWatchOTelEnrichmentTypesOTelEnrichmentMetricSelectorIncludeFilters, IHaveListOfCloudWatchOTelEnrichmentTypesOTelEnrichmentMetricSelectorExcludeFilters
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string AccountId =  "AccountId" ;
        }

        public override string AWSTypeName { get => AWS.CloudWatch.OTelEnrichment; }
        /// <summary>
        /// IncludeFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-otelenrichment.html#cfn-cloudwatch-otelenrichment-includefilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: OTelEnrichmentMetricSelector
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector>, IReadOnlyList<Union<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector, BaseFunction>>, BaseFunction>? IncludeFilters { get; set; }
        /// <summary>
        /// ExcludeFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-otelenrichment.html#cfn-cloudwatch-otelenrichment-excludefilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: OTelEnrichmentMetricSelector
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector>, IReadOnlyList<Union<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector, BaseFunction>>, BaseFunction>? ExcludeFilters { get; set; }
    }

    namespace OTelEnrichmentTypes
    {
        public class OTelEnrichmentMetricSelector : Humidifier.Base.BaseSubResource, IHaveStringListOfMetricNames, IHaveNamespace_
        {
            /// <summary>
            /// MetricNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-otelenrichment-otelenrichmentmetricselector.html#cfn-cloudwatch-otelenrichment-otelenrichmentmetricselector-metricnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MetricNames { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-otelenrichment-otelenrichmentmetricselector.html#cfn-cloudwatch-otelenrichment-otelenrichmentmetricselector-namespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }
    }
}