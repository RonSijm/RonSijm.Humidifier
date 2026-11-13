namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;
    using AlertTypes;

    public class Alert : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveProfileId, IHaveNotificationsEnabled_Boolean, IHaveDescription, IHaveListOfCloudWatchAlertTypesNotificationRuleNotificationRules, IHaveSpaceId, IHaveCloudWatchAlertTypesRuleRule, IHaveName
    {
        public class Attributes
        {
            public static string AlertId =  "AlertId" ;
            public static string AccountId =  "AccountId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.CloudWatch.Alert; }

        /// <summary>
        /// ProfileId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alert.html#cfn-cloudwatch-alert-profileid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProfileId { get; set; }
        /// <summary>
        /// NotificationsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alert.html#cfn-cloudwatch-alert-notificationsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? NotificationsEnabled { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alert.html#cfn-cloudwatch-alert-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// NotificationRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alert.html#cfn-cloudwatch-alert-notificationrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: NotificationRule
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudWatch.AlertTypes.NotificationRule>, IReadOnlyList<Union<Humidifier.CloudWatch.AlertTypes.NotificationRule, BaseFunction>>, BaseFunction>? NotificationRules { get; set; }

        /// <summary>
        /// SpaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alert.html#cfn-cloudwatch-alert-spaceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SpaceId { get; set; }

        /// <summary>
        /// Rule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alert.html#cfn-cloudwatch-alert-rule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Rule
        /// </summary>
        [Required]
        public Union<Humidifier.CloudWatch.AlertTypes.Rule, BaseFunction>? Rule { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alert.html#cfn-cloudwatch-alert-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AlertTypes
    {
        public class Condition : Humidifier.Base.BaseSubResource, IHaveCriticalThreshold_Double, IHaveWarningThreshold_Double, IHaveThresholdMode, IHaveThresholdField, IHaveComparator
        {
            /// <summary>
            /// CriticalThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-condition.html#cfn-cloudwatch-alert-condition-criticalthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? CriticalThreshold { get; set; }
            /// <summary>
            /// WarningThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-condition.html#cfn-cloudwatch-alert-condition-warningthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? WarningThreshold { get; set; }
            /// <summary>
            /// ThresholdMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-condition.html#cfn-cloudwatch-alert-condition-thresholdmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ThresholdMode { get; set; }
            /// <summary>
            /// ThresholdField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-condition.html#cfn-cloudwatch-alert-condition-thresholdfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ThresholdField { get; set; }
            /// <summary>
            /// Comparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-condition.html#cfn-cloudwatch-alert-condition-comparator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comparator { get; set; }
        }

        public class Evaluation : Humidifier.Base.BaseSubResource, IHavePendingDurationSeconds_Integer, IHaveIntervalSeconds_Integer, IHaveRecoveryDurationSeconds_Integer
        {
            /// <summary>
            /// PendingDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-evaluation.html#cfn-cloudwatch-alert-evaluation-pendingdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PendingDurationSeconds { get; set; }
            /// <summary>
            /// IntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-evaluation.html#cfn-cloudwatch-alert-evaluation-intervalseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IntervalSeconds { get; set; }
            /// <summary>
            /// RecoveryDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-evaluation.html#cfn-cloudwatch-alert-evaluation-recoverydurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RecoveryDurationSeconds { get; set; }
        }

        public class NoData : Humidifier.Base.BaseSubResource, IHaveTreatAs
        {
            /// <summary>
            /// TreatAs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-nodata.html#cfn-cloudwatch-alert-nodata-treatas
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TreatAs { get; set; }
        }

        public class NotificationRule : Humidifier.Base.BaseSubResource, IHaveCloudWatchAlertTypesTargetTarget, IHaveCloudWatchAlertTypesTriggerTrigger
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-notificationrule.html#cfn-cloudwatch-alert-notificationrule-target
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Target
            /// </summary>
            public Union<Humidifier.CloudWatch.AlertTypes.Target, BaseFunction>? Target { get; set; }
            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-notificationrule.html#cfn-cloudwatch-alert-notificationrule-trigger
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Trigger
            /// </summary>
            public Union<Humidifier.CloudWatch.AlertTypes.Trigger, BaseFunction>? Trigger { get; set; }
        }

        public class Query : Humidifier.Base.BaseSubResource, IHaveLanguage, IHaveExpression
        {
            /// <summary>
            /// Language
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-query.html#cfn-cloudwatch-alert-query-language
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Language { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-query.html#cfn-cloudwatch-alert-query-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveCloudWatchAlertTypesTelemetryRuleTelemetryRule
        {
            /// <summary>
            /// TelemetryRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-rule.html#cfn-cloudwatch-alert-rule-telemetryrule
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TelemetryRule
            /// </summary>
            public Union<Humidifier.CloudWatch.AlertTypes.TelemetryRule, BaseFunction>? TelemetryRule { get; set; }
        }

        public class Target : Humidifier.Base.BaseSubResource, IHaveType, IHaveStringDictionaryOfMetadata, IHaveArn
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-target.html#cfn-cloudwatch-alert-target-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-target.html#cfn-cloudwatch-alert-target-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Metadata { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-target.html#cfn-cloudwatch-alert-target-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class TelemetryRule : Humidifier.Base.BaseSubResource, IHaveCloudWatchAlertTypesConditionCondition, IHaveCloudWatchAlertTypesEvaluationEvaluation, IHaveCloudWatchAlertTypesQueryQuery, IHaveCloudWatchAlertTypesNoDataNoData
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-telemetryrule.html#cfn-cloudwatch-alert-telemetryrule-condition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Condition
            /// </summary>
            public Union<Humidifier.CloudWatch.AlertTypes.Condition, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// Evaluation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-telemetryrule.html#cfn-cloudwatch-alert-telemetryrule-evaluation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Evaluation
            /// </summary>
            public Union<Humidifier.CloudWatch.AlertTypes.Evaluation, BaseFunction>? Evaluation { get; set; }
            /// <summary>
            /// Query
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-telemetryrule.html#cfn-cloudwatch-alert-telemetryrule-query
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Query
            /// </summary>
            public Union<Humidifier.CloudWatch.AlertTypes.Query, BaseFunction>? Query { get; set; }
            /// <summary>
            /// NoData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-telemetryrule.html#cfn-cloudwatch-alert-telemetryrule-nodata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NoData
            /// </summary>
            public Union<Humidifier.CloudWatch.AlertTypes.NoData, BaseFunction>? NoData { get; set; }
        }

        public class Trigger : Humidifier.Base.BaseSubResource, IHaveStringListOfStateValues
        {
            /// <summary>
            /// StateValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-trigger.html#cfn-cloudwatch-alert-trigger-statevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StateValues { get; set; }
        }
    }
}