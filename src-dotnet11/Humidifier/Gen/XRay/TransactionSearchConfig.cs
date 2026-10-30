namespace Humidifier.XRay
{
    using global::System.Collections.Generic;
    using TransactionSearchConfigTypes;

    public class TransactionSearchConfig : Humidifier.Base.BaseResource, IHaveIndexingPercentage_Double, IHaveXRayTransactionSearchConfigTypesCloudWatchLogsConfigurationCloudWatchLogsConfiguration
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
        }

        public override string AWSTypeName { get => AWS.XRay.TransactionSearchConfig; }
        /// <summary>
        /// IndexingPercentage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-xray-transactionsearchconfig.html#cfn-xray-transactionsearchconfig-indexingpercentage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? IndexingPercentage { get; set; }
        /// <summary>
        /// CloudWatchLogsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-xray-transactionsearchconfig.html#cfn-xray-transactionsearchconfig-cloudwatchlogsconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: CloudWatchLogsConfiguration
        /// </summary>
        public Union<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration, BaseFunction>? CloudWatchLogsConfiguration { get; set; }
    }

    namespace TransactionSearchConfigTypes
    {
        public class CloudWatchLogsConfiguration : Humidifier.Base.BaseSubResource, IHaveSpansLogGroupKmsKeyId
        {
            /// <summary>
            /// SpansLogGroupKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-xray-transactionsearchconfig-cloudwatchlogsconfiguration.html#cfn-xray-transactionsearchconfig-cloudwatchlogsconfiguration-spansloggroupkmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpansLogGroupKmsKeyId { get; set; }
        }
    }
}