namespace Humidifier.LookoutMetrics
{
    using System.Collections.Generic;
    using AlertTypes;

    public class Alert : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.LookoutMetrics.Alert; }
        /// <summary>
        /// AlertDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lookoutmetrics-alert.html#cfn-lookoutmetrics-alert-alertdescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AlertDescription { get; set; }

        [Ignore]
        public dynamic Description { get => AlertDescription; set => AlertDescription = value; }

        /// <summary>
        /// Action
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lookoutmetrics-alert.html#cfn-lookoutmetrics-alert-action
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Action
        /// </summary>
        [Required]
        public Humidifier.LookoutMetrics.AlertTypes.Action Action { get; set; }
        public dynamic AlertName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// AlertSensitivityThreshold
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lookoutmetrics-alert.html#cfn-lookoutmetrics-alert-alertsensitivitythreshold
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic AlertSensitivityThreshold { get; set; }

        /// <summary>
        /// AnomalyDetectorArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lookoutmetrics-alert.html#cfn-lookoutmetrics-alert-anomalydetectorarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AnomalyDetectorArn { get; set; }
    }

    namespace AlertTypes
    {
        public class Action : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LambdaConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-alert-action.html#cfn-lookoutmetrics-alert-action-lambdaconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LambdaConfiguration
            /// </summary>
            public Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration LambdaConfiguration { get; set; }
            /// <summary>
            /// SNSConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-alert-action.html#cfn-lookoutmetrics-alert-action-snsconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SNSConfiguration
            /// </summary>
            public Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration SNSConfiguration { get; set; }
        }

        public class LambdaConfiguration : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveLambdaArn
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-alert-lambdaconfiguration.html#cfn-lookoutmetrics-alert-lambdaconfiguration-lambdaarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-alert-lambdaconfiguration.html#cfn-lookoutmetrics-alert-lambdaconfiguration-rolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class SNSConfiguration : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveSnsTopicArn
        {
            /// <summary>
            /// SnsTopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-alert-snsconfiguration.html#cfn-lookoutmetrics-alert-snsconfiguration-snstopicarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnsTopicArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-alert-snsconfiguration.html#cfn-lookoutmetrics-alert-snsconfiguration-rolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }
    }
}