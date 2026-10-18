namespace Humidifier.Logs
{
    using global::System.Collections.Generic;

    public class LogAnomalyDetector : Humidifier.Base.BaseResource, IHaveAnomalyVisibilityTime_Double, IHaveFilterPattern, IHaveAccountId, IHaveKmsKeyId, IHaveStringListOfLogGroupArnList, IHaveEvaluationFrequency, IHaveDetectorName
    {
        public class Attributes
        {
            public static string CreationTimeStamp =  "CreationTimeStamp" ;
            public static string AnomalyDetectorStatus =  "AnomalyDetectorStatus" ;
            public static string AnomalyDetectorArn =  "AnomalyDetectorArn" ;
            public static string LastModifiedTimeStamp =  "LastModifiedTimeStamp" ;
        }

        public override string AWSTypeName { get => AWS.Logs.LogAnomalyDetector; }
        /// <summary>
        /// AnomalyVisibilityTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loganomalydetector.html#cfn-logs-loganomalydetector-anomalyvisibilitytime
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? AnomalyVisibilityTime { get; set; }
        /// <summary>
        /// FilterPattern
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loganomalydetector.html#cfn-logs-loganomalydetector-filterpattern
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FilterPattern { get; set; }
        /// <summary>
        /// AccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loganomalydetector.html#cfn-logs-loganomalydetector-accountid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AccountId { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loganomalydetector.html#cfn-logs-loganomalydetector-kmskeyid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// LogGroupArnList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loganomalydetector.html#cfn-logs-loganomalydetector-loggrouparnlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LogGroupArnList { get; set; }
        /// <summary>
        /// EvaluationFrequency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loganomalydetector.html#cfn-logs-loganomalydetector-evaluationfrequency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EvaluationFrequency { get; set; }
        /// <summary>
        /// DetectorName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loganomalydetector.html#cfn-logs-loganomalydetector-detectorname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DetectorName { get; set; }
    }
}