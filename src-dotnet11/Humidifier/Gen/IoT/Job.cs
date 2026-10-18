namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using JobTypes;

    public class Job : Humidifier.Base.BaseResource, IHaveTags, IHaveIoTJobTypesTimeoutConfigTimeoutConfig, IHaveDescription, IHaveIoTJobTypesJobExecutionsRetryConfigJobExecutionsRetryConfig, IHaveStringListOfTargets, IHaveIoTJobTypesAbortConfigAbortConfig, IHaveDocument, IHaveStringListOfDestinationPackageVersions, IHaveIoTJobTypesJobExecutionsRolloutConfigJobExecutionsRolloutConfig, IHaveStringDictionaryOfDocumentParameters, IHaveDocumentSource, IHaveJobTemplateArn, IHaveIoTJobTypesSchedulingConfigSchedulingConfig, IHaveTargetSelection, IHaveJobId, IHaveIoTJobTypesPresignedUrlConfigPresignedUrlConfig
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
        public Union<Humidifier.IoT.JobTypes.TimeoutConfig, BaseFunction>? TimeoutConfig { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// JobExecutionsRetryConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-jobexecutionsretryconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: JobExecutionsRetryConfig
        /// </summary>
        public Union<Humidifier.IoT.JobTypes.JobExecutionsRetryConfig, BaseFunction>? JobExecutionsRetryConfig { get; set; }

        /// <summary>
        /// Targets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-targets
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Targets { get; set; }
        /// <summary>
        /// AbortConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-abortconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AbortConfig
        /// </summary>
        public Union<Humidifier.IoT.JobTypes.AbortConfig, BaseFunction>? AbortConfig { get; set; }
        /// <summary>
        /// Document
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-document
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Document { get; set; }
        /// <summary>
        /// DestinationPackageVersions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-destinationpackageversions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DestinationPackageVersions { get; set; }
        /// <summary>
        /// JobExecutionsRolloutConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-jobexecutionsrolloutconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: JobExecutionsRolloutConfig
        /// </summary>
        public Union<Humidifier.IoT.JobTypes.JobExecutionsRolloutConfig, BaseFunction>? JobExecutionsRolloutConfig { get; set; }
        /// <summary>
        /// DocumentParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-documentparameters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? DocumentParameters { get; set; }
        /// <summary>
        /// DocumentSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-documentsource
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DocumentSource { get; set; }
        /// <summary>
        /// JobTemplateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-jobtemplatearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobTemplateArn { get; set; }
        /// <summary>
        /// SchedulingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-schedulingconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SchedulingConfig
        /// </summary>
        public Union<Humidifier.IoT.JobTypes.SchedulingConfig, BaseFunction>? SchedulingConfig { get; set; }
        /// <summary>
        /// TargetSelection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-targetselection
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TargetSelection { get; set; }

        /// <summary>
        /// JobId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-jobid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? JobId { get; set; }
        /// <summary>
        /// PresignedUrlConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-presignedurlconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PresignedUrlConfig
        /// </summary>
        public Union<Humidifier.IoT.JobTypes.PresignedUrlConfig, BaseFunction>? PresignedUrlConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-job.html#cfn-iot-job-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace JobTypes
    {
        public class AbortConfig : Humidifier.Base.BaseSubResource, IHaveListOfIoTJobTypesAbortCriteriaCriteriaList
        {
            /// <summary>
            /// CriteriaList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-abortconfig.html#cfn-iot-job-abortconfig-criterialist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AbortCriteria
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoT.JobTypes.AbortCriteria>, IReadOnlyList<Union<Humidifier.IoT.JobTypes.AbortCriteria, BaseFunction>>, BaseFunction>? CriteriaList { get; set; }
        }

        public class AbortCriteria : Humidifier.Base.BaseSubResource, IHaveFailureType, IHaveAction, IHaveThresholdPercentage_Double, IHaveMinNumberOfExecutedThings_Integer
        {
            /// <summary>
            /// FailureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-abortcriteria.html#cfn-iot-job-abortcriteria-failuretype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FailureType { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-abortcriteria.html#cfn-iot-job-abortcriteria-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// ThresholdPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-abortcriteria.html#cfn-iot-job-abortcriteria-thresholdpercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ThresholdPercentage { get; set; }
            /// <summary>
            /// MinNumberOfExecutedThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-abortcriteria.html#cfn-iot-job-abortcriteria-minnumberofexecutedthings
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinNumberOfExecutedThings { get; set; }
        }

        public class ExponentialRolloutRate : Humidifier.Base.BaseSubResource, IHaveIoTJobTypesRateIncreaseCriteriaRateIncreaseCriteria, IHaveBaseRatePerMinute_Integer, IHaveIncrementFactor_Double
        {
            /// <summary>
            /// RateIncreaseCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-exponentialrolloutrate.html#cfn-iot-job-exponentialrolloutrate-rateincreasecriteria
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RateIncreaseCriteria
            /// </summary>
            public Union<Humidifier.IoT.JobTypes.RateIncreaseCriteria, BaseFunction>? RateIncreaseCriteria { get; set; }
            /// <summary>
            /// BaseRatePerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-exponentialrolloutrate.html#cfn-iot-job-exponentialrolloutrate-baserateperminute
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BaseRatePerMinute { get; set; }
            /// <summary>
            /// IncrementFactor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-exponentialrolloutrate.html#cfn-iot-job-exponentialrolloutrate-incrementfactor
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? IncrementFactor { get; set; }
        }

        public class JobExecutionsRetryConfig : Humidifier.Base.BaseSubResource, IHaveListOfIoTJobTypesRetryCriteriaCriteriaList
        {
            /// <summary>
            /// CriteriaList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-jobexecutionsretryconfig.html#cfn-iot-job-jobexecutionsretryconfig-criterialist
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: RetryCriteria
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoT.JobTypes.RetryCriteria>, IReadOnlyList<Union<Humidifier.IoT.JobTypes.RetryCriteria, BaseFunction>>, BaseFunction>? CriteriaList { get; set; }
        }

        public class JobExecutionsRolloutConfig : Humidifier.Base.BaseSubResource, IHaveMaximumPerMinute_Integer, IHaveIoTJobTypesExponentialRolloutRateExponentialRate
        {
            /// <summary>
            /// MaximumPerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-jobexecutionsrolloutconfig.html#cfn-iot-job-jobexecutionsrolloutconfig-maximumperminute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumPerMinute { get; set; }
            /// <summary>
            /// ExponentialRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-jobexecutionsrolloutconfig.html#cfn-iot-job-jobexecutionsrolloutconfig-exponentialrate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExponentialRolloutRate
            /// </summary>
            public Union<Humidifier.IoT.JobTypes.ExponentialRolloutRate, BaseFunction>? ExponentialRate { get; set; }
        }

        public class MaintenanceWindow : Humidifier.Base.BaseSubResource, IHaveDurationInMinutes_Integer, IHaveStartTime
        {
            /// <summary>
            /// DurationInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-maintenancewindow.html#cfn-iot-job-maintenancewindow-durationinminutes
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DurationInMinutes { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-maintenancewindow.html#cfn-iot-job-maintenancewindow-starttime
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
        }

        public class PresignedUrlConfig : Humidifier.Base.BaseSubResource, IHaveExpiresInSec_Integer, IHaveRoleArn
        {
            /// <summary>
            /// ExpiresInSec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-presignedurlconfig.html#cfn-iot-job-presignedurlconfig-expiresinsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ExpiresInSec { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-presignedurlconfig.html#cfn-iot-job-presignedurlconfig-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class RateIncreaseCriteria : Humidifier.Base.BaseSubResource, IHaveNumberOfSucceededThings_Integer, IHaveNumberOfNotifiedThings_Integer
        {
            /// <summary>
            /// NumberOfSucceededThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-rateincreasecriteria.html#cfn-iot-job-rateincreasecriteria-numberofsucceededthings
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfSucceededThings { get; set; }
            /// <summary>
            /// NumberOfNotifiedThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-rateincreasecriteria.html#cfn-iot-job-rateincreasecriteria-numberofnotifiedthings
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfNotifiedThings { get; set; }
        }

        public class RetryCriteria : Humidifier.Base.BaseSubResource, IHaveFailureType, IHaveNumberOfRetries_Integer
        {
            /// <summary>
            /// FailureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-retrycriteria.html#cfn-iot-job-retrycriteria-failuretype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FailureType { get; set; }
            /// <summary>
            /// NumberOfRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-retrycriteria.html#cfn-iot-job-retrycriteria-numberofretries
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfRetries { get; set; }
        }

        public class SchedulingConfig : Humidifier.Base.BaseSubResource, IHaveEndTime, IHaveStartTime, IHaveEndBehavior, IHaveListOfIoTJobTypesMaintenanceWindowMaintenanceWindows
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-schedulingconfig.html#cfn-iot-job-schedulingconfig-endtime
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-schedulingconfig.html#cfn-iot-job-schedulingconfig-starttime
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
            /// <summary>
            /// EndBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-schedulingconfig.html#cfn-iot-job-schedulingconfig-endbehavior
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndBehavior { get; set; }
            /// <summary>
            /// MaintenanceWindows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-schedulingconfig.html#cfn-iot-job-schedulingconfig-maintenancewindows
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MaintenanceWindow
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoT.JobTypes.MaintenanceWindow>, IReadOnlyList<Union<Humidifier.IoT.JobTypes.MaintenanceWindow, BaseFunction>>, BaseFunction>? MaintenanceWindows { get; set; }
        }

        public class TimeoutConfig : Humidifier.Base.BaseSubResource, IHaveInProgressTimeoutInMinutes_Integer
        {
            /// <summary>
            /// InProgressTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-job-timeoutconfig.html#cfn-iot-job-timeoutconfig-inprogresstimeoutinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InProgressTimeoutInMinutes { get; set; }
        }
    }
}