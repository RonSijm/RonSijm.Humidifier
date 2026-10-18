namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using JobTemplateTypes;

    public class JobTemplate : Humidifier.Base.BaseResource, IHaveTags, IHaveIoTJobTemplateTypesTimeoutConfigTimeoutConfig, IHaveDescription, IHaveIoTJobTemplateTypesJobExecutionsRetryConfigJobExecutionsRetryConfig, IHaveIoTJobTemplateTypesAbortConfigAbortConfig, IHaveJobTemplateId, IHaveDocument, IHaveStringListOfDestinationPackageVersions, IHaveJobArn, IHaveIoTJobTemplateTypesJobExecutionsRolloutConfigJobExecutionsRolloutConfig, IHaveDocumentSource, IHaveListOfIoTJobTemplateTypesMaintenanceWindowMaintenanceWindows, IHaveIoTJobTemplateTypesPresignedUrlConfigPresignedUrlConfig
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoT.JobTemplate; }
        /// <summary>
        /// TimeoutConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-timeoutconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: TimeoutConfig
        /// </summary>
        public Union<Humidifier.IoT.JobTemplateTypes.TimeoutConfig, BaseFunction>? TimeoutConfig { get; set; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-description
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// JobExecutionsRetryConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-jobexecutionsretryconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: JobExecutionsRetryConfig
        /// </summary>
        public Union<Humidifier.IoT.JobTemplateTypes.JobExecutionsRetryConfig, BaseFunction>? JobExecutionsRetryConfig { get; set; }
        /// <summary>
        /// AbortConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-abortconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AbortConfig
        /// </summary>
        public Union<Humidifier.IoT.JobTemplateTypes.AbortConfig, BaseFunction>? AbortConfig { get; set; }

        /// <summary>
        /// JobTemplateId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-jobtemplateid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? JobTemplateId { get; set; }
        /// <summary>
        /// Document
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-document
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Document { get; set; }
        /// <summary>
        /// DestinationPackageVersions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-destinationpackageversions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DestinationPackageVersions { get; set; }
        /// <summary>
        /// JobArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-jobarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobArn { get; set; }
        /// <summary>
        /// JobExecutionsRolloutConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-jobexecutionsrolloutconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: JobExecutionsRolloutConfig
        /// </summary>
        public Union<Humidifier.IoT.JobTemplateTypes.JobExecutionsRolloutConfig, BaseFunction>? JobExecutionsRolloutConfig { get; set; }
        /// <summary>
        /// DocumentSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-documentsource
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DocumentSource { get; set; }
        /// <summary>
        /// MaintenanceWindows
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-maintenancewindows
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: MaintenanceWindow
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoT.JobTemplateTypes.MaintenanceWindow>, IReadOnlyList<Union<Humidifier.IoT.JobTemplateTypes.MaintenanceWindow, BaseFunction>>, BaseFunction>? MaintenanceWindows { get; set; }
        /// <summary>
        /// PresignedUrlConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-presignedurlconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PresignedUrlConfig
        /// </summary>
        public Union<Humidifier.IoT.JobTemplateTypes.PresignedUrlConfig, BaseFunction>? PresignedUrlConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace JobTemplateTypes
    {
        public class AbortConfig : Humidifier.Base.BaseSubResource, IHaveListOfIoTJobTemplateTypesAbortCriteriaCriteriaList
        {
            /// <summary>
            /// CriteriaList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-abortconfig.html#cfn-iot-jobtemplate-abortconfig-criterialist
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AbortCriteria
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoT.JobTemplateTypes.AbortCriteria>, IReadOnlyList<Union<Humidifier.IoT.JobTemplateTypes.AbortCriteria, BaseFunction>>, BaseFunction>? CriteriaList { get; set; }
        }

        public class AbortCriteria : Humidifier.Base.BaseSubResource, IHaveAction, IHaveFailureType, IHaveThresholdPercentage_Double, IHaveMinNumberOfExecutedThings_Integer
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-abortcriteria.html#cfn-iot-jobtemplate-abortcriteria-action
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// FailureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-abortcriteria.html#cfn-iot-jobtemplate-abortcriteria-failuretype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FailureType { get; set; }
            /// <summary>
            /// ThresholdPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-abortcriteria.html#cfn-iot-jobtemplate-abortcriteria-thresholdpercentage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ThresholdPercentage { get; set; }
            /// <summary>
            /// MinNumberOfExecutedThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-abortcriteria.html#cfn-iot-jobtemplate-abortcriteria-minnumberofexecutedthings
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinNumberOfExecutedThings { get; set; }
        }

        public class ExponentialRolloutRate : Humidifier.Base.BaseSubResource, IHaveIoTJobTemplateTypesRateIncreaseCriteriaRateIncreaseCriteria, IHaveBaseRatePerMinute_Integer, IHaveIncrementFactor_Double
        {
            /// <summary>
            /// RateIncreaseCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-exponentialrolloutrate.html#cfn-iot-jobtemplate-exponentialrolloutrate-rateincreasecriteria
            /// Required: True
            /// UpdateType: Immutable
            /// Type: RateIncreaseCriteria
            /// </summary>
            public Union<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria, BaseFunction>? RateIncreaseCriteria { get; set; }
            /// <summary>
            /// BaseRatePerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-exponentialrolloutrate.html#cfn-iot-jobtemplate-exponentialrolloutrate-baserateperminute
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BaseRatePerMinute { get; set; }
            /// <summary>
            /// IncrementFactor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-exponentialrolloutrate.html#cfn-iot-jobtemplate-exponentialrolloutrate-incrementfactor
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? IncrementFactor { get; set; }
        }

        public class JobExecutionsRetryConfig : Humidifier.Base.BaseSubResource, IHaveListOfIoTJobTemplateTypesRetryCriteriaRetryCriteriaList
        {
            /// <summary>
            /// RetryCriteriaList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-jobexecutionsretryconfig.html#cfn-iot-jobtemplate-jobexecutionsretryconfig-retrycriterialist
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: RetryCriteria
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoT.JobTemplateTypes.RetryCriteria>, IReadOnlyList<Union<Humidifier.IoT.JobTemplateTypes.RetryCriteria, BaseFunction>>, BaseFunction>? RetryCriteriaList { get; set; }
        }

        public class JobExecutionsRolloutConfig : Humidifier.Base.BaseSubResource, IHaveMaximumPerMinute_Integer, IHaveIoTJobTemplateTypesExponentialRolloutRateExponentialRolloutRate
        {
            /// <summary>
            /// MaximumPerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-jobexecutionsrolloutconfig.html#cfn-iot-jobtemplate-jobexecutionsrolloutconfig-maximumperminute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumPerMinute { get; set; }
            /// <summary>
            /// ExponentialRolloutRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-jobexecutionsrolloutconfig.html#cfn-iot-jobtemplate-jobexecutionsrolloutconfig-exponentialrolloutrate
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ExponentialRolloutRate
            /// </summary>
            public Union<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate, BaseFunction>? ExponentialRolloutRate { get; set; }
        }

        public class MaintenanceWindow : Humidifier.Base.BaseSubResource, IHaveDurationInMinutes_Integer, IHaveStartTime
        {
            /// <summary>
            /// DurationInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-maintenancewindow.html#cfn-iot-jobtemplate-maintenancewindow-durationinminutes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DurationInMinutes { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-maintenancewindow.html#cfn-iot-jobtemplate-maintenancewindow-starttime
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
        }

        public class PresignedUrlConfig : Humidifier.Base.BaseSubResource, IHaveExpiresInSec_Integer, IHaveRoleArn
        {
            /// <summary>
            /// ExpiresInSec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-presignedurlconfig.html#cfn-iot-jobtemplate-presignedurlconfig-expiresinsec
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ExpiresInSec { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-presignedurlconfig.html#cfn-iot-jobtemplate-presignedurlconfig-rolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class RateIncreaseCriteria : Humidifier.Base.BaseSubResource, IHaveNumberOfSucceededThings_Integer, IHaveNumberOfNotifiedThings_Integer
        {
            /// <summary>
            /// NumberOfSucceededThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-rateincreasecriteria.html#cfn-iot-jobtemplate-rateincreasecriteria-numberofsucceededthings
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfSucceededThings { get; set; }
            /// <summary>
            /// NumberOfNotifiedThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-rateincreasecriteria.html#cfn-iot-jobtemplate-rateincreasecriteria-numberofnotifiedthings
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfNotifiedThings { get; set; }
        }

        public class RetryCriteria : Humidifier.Base.BaseSubResource, IHaveFailureType, IHaveNumberOfRetries_Integer
        {
            /// <summary>
            /// FailureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-retrycriteria.html#cfn-iot-jobtemplate-retrycriteria-failuretype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FailureType { get; set; }
            /// <summary>
            /// NumberOfRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-retrycriteria.html#cfn-iot-jobtemplate-retrycriteria-numberofretries
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfRetries { get; set; }
        }

        public class TimeoutConfig : Humidifier.Base.BaseSubResource, IHaveInProgressTimeoutInMinutes_Integer
        {
            /// <summary>
            /// InProgressTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-timeoutconfig.html#cfn-iot-jobtemplate-timeoutconfig-inprogresstimeoutinminutes
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InProgressTimeoutInMinutes { get; set; }
        }
    }
}