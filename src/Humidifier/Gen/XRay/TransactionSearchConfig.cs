namespace Humidifier.XRay
{
    using global::System.Collections.Generic;
    using TransactionSearchConfigTypes;

    public class TransactionSearchConfig : Humidifier.Base.BaseResource
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
        public dynamic IndexingPercentage { get; set; }
        /// <summary>
        /// CloudWatchLogsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-xray-transactionsearchconfig.html#cfn-xray-transactionsearchconfig-cloudwatchlogsconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: CloudWatchLogsConfiguration
        /// </summary>
        public Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration CloudWatchLogsConfiguration { get; set; }
    }

    namespace TransactionSearchConfigTypes
    {
        public class CloudWatchLogsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SpansLogGroupKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-xray-transactionsearchconfig-cloudwatchlogsconfiguration.html#cfn-xray-transactionsearchconfig-cloudwatchlogsconfiguration-spansloggroupkmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SpansLogGroupKmsKeyId { get; set; }
        }
    }
}