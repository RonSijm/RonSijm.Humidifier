namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using MonitoringScheduleAlertTypes;

    public class MonitoringScheduleAlert : Humidifier.Base.BaseResource, IHaveMonitoringScheduleName
    {
        public class Attributes
        {
            public static string Actions =  "Actions" ;
            public static string AlertStatus =  "AlertStatus" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.MonitoringScheduleAlert; }

        /// <summary>
        /// DatapointsToAlert
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-monitoringschedulealert.html#cfn-sagemaker-monitoringschedulealert-datapointstoalert
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic DatapointsToAlert { get; set; }

        /// <summary>
        /// EvaluationPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-monitoringschedulealert.html#cfn-sagemaker-monitoringschedulealert-evaluationperiod
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic EvaluationPeriod { get; set; }

        /// <summary>
        /// MonitoringScheduleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-monitoringschedulealert.html#cfn-sagemaker-monitoringschedulealert-monitoringschedulename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic MonitoringScheduleName { get; set; }

        /// <summary>
        /// MonitoringAlertName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-monitoringschedulealert.html#cfn-sagemaker-monitoringschedulealert-monitoringalertname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic MonitoringAlertName { get; set; }
    }

    namespace MonitoringScheduleAlertTypes
    {
        public class ModelDashboardIndicatorAction : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedulealert-modeldashboardindicatoraction.html#cfn-sagemaker-monitoringschedulealert-modeldashboardindicatoraction-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class MonitoringAlertActions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ModelDashboardIndicator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedulealert-monitoringalertactions.html#cfn-sagemaker-monitoringschedulealert-monitoringalertactions-modeldashboardindicator
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModelDashboardIndicatorAction
            /// </summary>
            public Humidifier.SageMaker.MonitoringScheduleAlertTypes.ModelDashboardIndicatorAction ModelDashboardIndicator { get; set; }
        }
    }
}