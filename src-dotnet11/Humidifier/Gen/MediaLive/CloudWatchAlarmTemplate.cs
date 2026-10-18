namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;

    public class CloudWatchAlarmTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTargetResourceType, IHaveComparisonOperator, IHaveTreatMissingData, IHaveDescription, IHavePeriod_Double, IHaveEvaluationPeriods_Double, IHaveGroupIdentifier, IHaveName, IHaveMetricName, IHaveStatistic, IHaveDatapointsToAlarm_Double, IHaveStringDictionaryOfTags, IHaveThreshold_Double
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string Identifier =  "Identifier" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string GroupId =  "GroupId" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.CloudWatchAlarmTemplate; }

        /// <summary>
        /// TargetResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-cloudwatchalarmtemplate.html#cfn-medialive-cloudwatchalarmtemplate-targetresourcetype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetResourceType { get; set; }

        /// <summary>
        /// ComparisonOperator
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-cloudwatchalarmtemplate.html#cfn-medialive-cloudwatchalarmtemplate-comparisonoperator
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ComparisonOperator { get; set; }

        /// <summary>
        /// TreatMissingData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-cloudwatchalarmtemplate.html#cfn-medialive-cloudwatchalarmtemplate-treatmissingdata
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TreatMissingData { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-cloudwatchalarmtemplate.html#cfn-medialive-cloudwatchalarmtemplate-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Period
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-cloudwatchalarmtemplate.html#cfn-medialive-cloudwatchalarmtemplate-period
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public Union<double, BaseFunction>? Period { get; set; }

        /// <summary>
        /// EvaluationPeriods
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-cloudwatchalarmtemplate.html#cfn-medialive-cloudwatchalarmtemplate-evaluationperiods
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public Union<double, BaseFunction>? EvaluationPeriods { get; set; }
        /// <summary>
        /// GroupIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-cloudwatchalarmtemplate.html#cfn-medialive-cloudwatchalarmtemplate-groupidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GroupIdentifier { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// MetricName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-cloudwatchalarmtemplate.html#cfn-medialive-cloudwatchalarmtemplate-metricname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MetricName { get; set; }

        /// <summary>
        /// Statistic
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-cloudwatchalarmtemplate.html#cfn-medialive-cloudwatchalarmtemplate-statistic
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Statistic { get; set; }
        /// <summary>
        /// DatapointsToAlarm
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-cloudwatchalarmtemplate.html#cfn-medialive-cloudwatchalarmtemplate-datapointstoalarm
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? DatapointsToAlarm { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-cloudwatchalarmtemplate.html#cfn-medialive-cloudwatchalarmtemplate-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// Threshold
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-cloudwatchalarmtemplate.html#cfn-medialive-cloudwatchalarmtemplate-threshold
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public Union<double, BaseFunction>? Threshold { get; set; }
    }
}