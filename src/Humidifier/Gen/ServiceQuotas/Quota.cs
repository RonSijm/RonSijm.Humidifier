namespace Humidifier.ServiceQuotas
{
    using global::System.Collections.Generic;
    using QuotaTypes;

    public class Quota : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string QuotaContext =  "QuotaContext" ;
            public static string Description =  "Description" ;
            public static string QuotaAppliedAtLevel =  "QuotaAppliedAtLevel" ;
            public static string UsageMetric =  "UsageMetric" ;
            public static string GlobalQuota =  "GlobalQuota" ;
            public static string Period =  "Period" ;
            public static string Unit =  "Unit" ;
            public static string Adjustable =  "Adjustable" ;
            public static string QuotaName =  "QuotaName" ;
            public static string QuotaArn =  "QuotaArn" ;
            public static string ServiceName =  "ServiceName" ;
            public static string Value =  "Value" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.ServiceQuotas.Quota; }
        /// <summary>
        /// ServiceCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicequotas-quota.html#cfn-servicequotas-quota-servicecode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServiceCode { get; set; }
        /// <summary>
        /// QuotaCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicequotas-quota.html#cfn-servicequotas-quota-quotacode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic QuotaCode { get; set; }
    }

    namespace QuotaTypes
    {
        public class MetricInfo : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveMetricNamespace
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicequotas-quota-metricinfo.html#cfn-servicequotas-quota-metricinfo-metricname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricName { get; set; }
            /// <summary>
            /// MetricStatisticRecommendation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicequotas-quota-metricinfo.html#cfn-servicequotas-quota-metricinfo-metricstatisticrecommendation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricStatisticRecommendation { get; set; }
            /// <summary>
            /// MetricDimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicequotas-quota-metricinfo.html#cfn-servicequotas-quota-metricinfo-metricdimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> MetricDimensions { get; set; }
            /// <summary>
            /// MetricNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicequotas-quota-metricinfo.html#cfn-servicequotas-quota-metricinfo-metricnamespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricNamespace { get; set; }
        }

        public class QuotaContextInfo : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContextScopeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicequotas-quota-quotacontextinfo.html#cfn-servicequotas-quota-quotacontextinfo-contextscopetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContextScopeType { get; set; }
            /// <summary>
            /// ContextScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicequotas-quota-quotacontextinfo.html#cfn-servicequotas-quota-quotacontextinfo-contextscope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContextScope { get; set; }
            /// <summary>
            /// ContextId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicequotas-quota-quotacontextinfo.html#cfn-servicequotas-quota-quotacontextinfo-contextid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContextId { get; set; }
        }

        public class QuotaPeriod : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PeriodValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicequotas-quota-quotaperiod.html#cfn-servicequotas-quota-quotaperiod-periodvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PeriodValue { get; set; }
            /// <summary>
            /// PeriodUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicequotas-quota-quotaperiod.html#cfn-servicequotas-quota-quotaperiod-periodunit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PeriodUnit { get; set; }
        }
    }
}