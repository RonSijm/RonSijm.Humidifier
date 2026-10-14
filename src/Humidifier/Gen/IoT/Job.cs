namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using JobTypes;

    public class Job : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoT.Job; }
        /// <summary>
        /// TimeoutConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-timeoutconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TimeoutConfig
        /// </summary>
        public Humidifier.IoT.JobTypes.TimeoutConfig TimeoutConfig { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// JobExecutionsRetryConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-jobexecutionsretryconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: JobExecutionsRetryConfig
        /// </summary>
        public Humidifier.IoT.JobTypes.JobExecutionsRetryConfig JobExecutionsRetryConfig { get; set; }

        /// <summary>
        /// Targets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-targets
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic Targets { get; set; }
        /// <summary>
        /// AbortConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-abortconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AbortConfig
        /// </summary>
        public Humidifier.IoT.JobTypes.AbortConfig AbortConfig { get; set; }
        /// <summary>
        /// Document
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-document
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Document { get; set; }
        /// <summary>
        /// DestinationPackageVersions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-destinationpackageversions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic DestinationPackageVersions { get; set; }
        /// <summary>
        /// JobExecutionsRolloutConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-jobexecutionsrolloutconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: JobExecutionsRolloutConfig
        /// </summary>
        public Humidifier.IoT.JobTypes.JobExecutionsRolloutConfig JobExecutionsRolloutConfig { get; set; }
        /// <summary>
        /// DocumentParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-documentparameters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> DocumentParameters { get; set; }
        /// <summary>
        /// DocumentSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-documentsource
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DocumentSource { get; set; }
        /// <summary>
        /// JobTemplateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-jobtemplatearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic JobTemplateArn { get; set; }
        /// <summary>
        /// SchedulingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-schedulingconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SchedulingConfig
        /// </summary>
        public Humidifier.IoT.JobTypes.SchedulingConfig SchedulingConfig { get; set; }
        /// <summary>
        /// TargetSelection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-targetselection
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetSelection { get; set; }

        /// <summary>
        /// JobId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-jobid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic JobId { get; set; }
        /// <summary>
        /// PresignedUrlConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-presignedurlconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PresignedUrlConfig
        /// </summary>
        public Humidifier.IoT.JobTypes.PresignedUrlConfig PresignedUrlConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace JobTypes
    {
        public class AbortConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CriteriaList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-abortconfig.html#cfn-iot-job-abortconfig-criterialist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AbortCriteria
            /// </summary>
            public List<Humidifier.IoT.JobTypes.AbortCriteria> CriteriaList { get; set; }
        }

        public class AbortCriteria : Humidifier.Base.BaseSubResource, IHaveAction, IHaveFailureType, IHaveThresholdPercentage, IHaveMinNumberOfExecutedThings
        {
            /// <summary>
            /// FailureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-abortcriteria.html#cfn-iot-job-abortcriteria-failuretype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FailureType { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-abortcriteria.html#cfn-iot-job-abortcriteria-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// ThresholdPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-abortcriteria.html#cfn-iot-job-abortcriteria-thresholdpercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ThresholdPercentage { get; set; }
            /// <summary>
            /// MinNumberOfExecutedThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-abortcriteria.html#cfn-iot-job-abortcriteria-minnumberofexecutedthings
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinNumberOfExecutedThings { get; set; }
        }

        public class ExponentialRolloutRate : Humidifier.Base.BaseSubResource, IHaveBaseRatePerMinute, IHaveIncrementFactor
        {
            /// <summary>
            /// RateIncreaseCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-exponentialrolloutrate.html#cfn-iot-job-exponentialrolloutrate-rateincreasecriteria
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RateIncreaseCriteria
            /// </summary>
            public Humidifier.IoT.JobTypes.RateIncreaseCriteria RateIncreaseCriteria { get; set; }
            /// <summary>
            /// BaseRatePerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-exponentialrolloutrate.html#cfn-iot-job-exponentialrolloutrate-baserateperminute
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BaseRatePerMinute { get; set; }
            /// <summary>
            /// IncrementFactor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-exponentialrolloutrate.html#cfn-iot-job-exponentialrolloutrate-incrementfactor
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic IncrementFactor { get; set; }
        }

        public class JobExecutionsRetryConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CriteriaList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-jobexecutionsretryconfig.html#cfn-iot-job-jobexecutionsretryconfig-criterialist
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: RetryCriteria
            /// </summary>
            public List<Humidifier.IoT.JobTypes.RetryCriteria> CriteriaList { get; set; }
        }

        public class JobExecutionsRolloutConfig : Humidifier.Base.BaseSubResource, IHaveMaximumPerMinute
        {
            /// <summary>
            /// MaximumPerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-jobexecutionsrolloutconfig.html#cfn-iot-job-jobexecutionsrolloutconfig-maximumperminute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumPerMinute { get; set; }
            /// <summary>
            /// ExponentialRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-jobexecutionsrolloutconfig.html#cfn-iot-job-jobexecutionsrolloutconfig-exponentialrate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExponentialRolloutRate
            /// </summary>
            public Humidifier.IoT.JobTypes.ExponentialRolloutRate ExponentialRate { get; set; }
        }

        public class MaintenanceWindow : Humidifier.Base.BaseSubResource, IHaveStartTime, IHaveDurationInMinutes
        {
            /// <summary>
            /// DurationInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-maintenancewindow.html#cfn-iot-job-maintenancewindow-durationinminutes
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DurationInMinutes { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-maintenancewindow.html#cfn-iot-job-maintenancewindow-starttime
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartTime { get; set; }
        }

        public class PresignedUrlConfig : Humidifier.Base.BaseSubResource, IHaveRoleArn
        {
            /// <summary>
            /// ExpiresInSec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-presignedurlconfig.html#cfn-iot-job-presignedurlconfig-expiresinsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ExpiresInSec { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-presignedurlconfig.html#cfn-iot-job-presignedurlconfig-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class RateIncreaseCriteria : Humidifier.Base.BaseSubResource, IHaveNumberOfSucceededThings, IHaveNumberOfNotifiedThings
        {
            /// <summary>
            /// NumberOfSucceededThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-rateincreasecriteria.html#cfn-iot-job-rateincreasecriteria-numberofsucceededthings
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfSucceededThings { get; set; }
            /// <summary>
            /// NumberOfNotifiedThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-rateincreasecriteria.html#cfn-iot-job-rateincreasecriteria-numberofnotifiedthings
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfNotifiedThings { get; set; }
        }

        public class RetryCriteria : Humidifier.Base.BaseSubResource, IHaveFailureType
        {
            /// <summary>
            /// FailureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-retrycriteria.html#cfn-iot-job-retrycriteria-failuretype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FailureType { get; set; }
            /// <summary>
            /// NumberOfRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-retrycriteria.html#cfn-iot-job-retrycriteria-numberofretries
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfRetries { get; set; }
        }

        public class SchedulingConfig : Humidifier.Base.BaseSubResource, IHaveStartTime, IHaveEndTime
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-schedulingconfig.html#cfn-iot-job-schedulingconfig-endtime
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-schedulingconfig.html#cfn-iot-job-schedulingconfig-starttime
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartTime { get; set; }
            /// <summary>
            /// EndBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-schedulingconfig.html#cfn-iot-job-schedulingconfig-endbehavior
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndBehavior { get; set; }
            /// <summary>
            /// MaintenanceWindows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-schedulingconfig.html#cfn-iot-job-schedulingconfig-maintenancewindows
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MaintenanceWindow
            /// </summary>
            public List<Humidifier.IoT.JobTypes.MaintenanceWindow> MaintenanceWindows { get; set; }
        }

        public class TimeoutConfig : Humidifier.Base.BaseSubResource, IHaveInProgressTimeoutInMinutes
        {
            /// <summary>
            /// InProgressTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-timeoutconfig.html#cfn-iot-job-timeoutconfig-inprogresstimeoutinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InProgressTimeoutInMinutes { get; set; }
        }
    }
}