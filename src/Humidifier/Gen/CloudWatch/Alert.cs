namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;
    using AlertTypes;

    public class Alert : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveProfileId
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
        public dynamic ProfileId { get; set; }
        /// <summary>
        /// NotificationsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alert.html#cfn-cloudwatch-alert-notificationsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic NotificationsEnabled { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alert.html#cfn-cloudwatch-alert-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// NotificationRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alert.html#cfn-cloudwatch-alert-notificationrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: NotificationRule
        /// </summary>
        public List<Humidifier.CloudWatch.AlertTypes.NotificationRule> NotificationRules { get; set; }

        /// <summary>
        /// SpaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alert.html#cfn-cloudwatch-alert-spaceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SpaceId { get; set; }

        /// <summary>
        /// Rule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alert.html#cfn-cloudwatch-alert-rule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Rule
        /// </summary>
        [Required]
        public Humidifier.CloudWatch.AlertTypes.Rule Rule { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alert.html#cfn-cloudwatch-alert-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace AlertTypes
    {
        public class Condition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CriticalThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-condition.html#cfn-cloudwatch-alert-condition-criticalthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic CriticalThreshold { get; set; }
            /// <summary>
            /// WarningThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-condition.html#cfn-cloudwatch-alert-condition-warningthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic WarningThreshold { get; set; }
            /// <summary>
            /// ThresholdMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-condition.html#cfn-cloudwatch-alert-condition-thresholdmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ThresholdMode { get; set; }
            /// <summary>
            /// ThresholdField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-condition.html#cfn-cloudwatch-alert-condition-thresholdfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ThresholdField { get; set; }
            /// <summary>
            /// Comparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-condition.html#cfn-cloudwatch-alert-condition-comparator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comparator { get; set; }
        }

        public class Evaluation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PendingDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-evaluation.html#cfn-cloudwatch-alert-evaluation-pendingdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PendingDurationSeconds { get; set; }
            /// <summary>
            /// IntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-evaluation.html#cfn-cloudwatch-alert-evaluation-intervalseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IntervalSeconds { get; set; }
            /// <summary>
            /// RecoveryDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-evaluation.html#cfn-cloudwatch-alert-evaluation-recoverydurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RecoveryDurationSeconds { get; set; }
        }

        public class NoData : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TreatAs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-nodata.html#cfn-cloudwatch-alert-nodata-treatas
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TreatAs { get; set; }
        }

        public class NotificationRule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-notificationrule.html#cfn-cloudwatch-alert-notificationrule-target
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Target
            /// </summary>
            public Humidifier.CloudWatch.AlertTypes.Target Target { get; set; }
            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-notificationrule.html#cfn-cloudwatch-alert-notificationrule-trigger
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Trigger
            /// </summary>
            public Humidifier.CloudWatch.AlertTypes.Trigger Trigger { get; set; }
        }

        public class Query : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveLanguage
        {
            /// <summary>
            /// Language
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-query.html#cfn-cloudwatch-alert-query-language
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Language { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-query.html#cfn-cloudwatch-alert-query-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TelemetryRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-rule.html#cfn-cloudwatch-alert-rule-telemetryrule
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TelemetryRule
            /// </summary>
            public Humidifier.CloudWatch.AlertTypes.TelemetryRule TelemetryRule { get; set; }
        }

        public class Target : Humidifier.Base.BaseSubResource, IHaveType, IHaveArn
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-target.html#cfn-cloudwatch-alert-target-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-target.html#cfn-cloudwatch-alert-target-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Metadata { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-target.html#cfn-cloudwatch-alert-target-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class TelemetryRule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-telemetryrule.html#cfn-cloudwatch-alert-telemetryrule-condition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Condition
            /// </summary>
            public Humidifier.CloudWatch.AlertTypes.Condition Condition { get; set; }
            /// <summary>
            /// Evaluation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-telemetryrule.html#cfn-cloudwatch-alert-telemetryrule-evaluation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Evaluation
            /// </summary>
            public Humidifier.CloudWatch.AlertTypes.Evaluation Evaluation { get; set; }
            /// <summary>
            /// Query
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-telemetryrule.html#cfn-cloudwatch-alert-telemetryrule-query
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Query
            /// </summary>
            public Humidifier.CloudWatch.AlertTypes.Query Query { get; set; }
            /// <summary>
            /// NoData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-telemetryrule.html#cfn-cloudwatch-alert-telemetryrule-nodata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NoData
            /// </summary>
            public Humidifier.CloudWatch.AlertTypes.NoData NoData { get; set; }
        }

        public class Trigger : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StateValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alert-trigger.html#cfn-cloudwatch-alert-trigger-statevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StateValues { get; set; }
        }
    }
}