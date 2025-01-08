namespace Humidifier.IoT
{
    using System.Collections.Generic;
    using JobTemplateTypes;

    public class JobTemplate : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription
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
        public Humidifier.IoT.JobTemplateTypes.TimeoutConfig TimeoutConfig { get; set; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-description
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Description { get; set; }
        /// <summary>
        /// JobExecutionsRetryConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-jobexecutionsretryconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: JobExecutionsRetryConfig
        /// </summary>
        public Humidifier.IoT.JobTemplateTypes.JobExecutionsRetryConfig JobExecutionsRetryConfig { get; set; }
        /// <summary>
        /// AbortConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-abortconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AbortConfig
        /// </summary>
        public Humidifier.IoT.JobTemplateTypes.AbortConfig AbortConfig { get; set; }

        /// <summary>
        /// JobTemplateId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-jobtemplateid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic JobTemplateId { get; set; }
        /// <summary>
        /// Document
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-document
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Document { get; set; }
        /// <summary>
        /// DestinationPackageVersions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-destinationpackageversions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic DestinationPackageVersions { get; set; }
        /// <summary>
        /// JobArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-jobarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic JobArn { get; set; }
        /// <summary>
        /// JobExecutionsRolloutConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-jobexecutionsrolloutconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: JobExecutionsRolloutConfig
        /// </summary>
        public Humidifier.IoT.JobTemplateTypes.JobExecutionsRolloutConfig JobExecutionsRolloutConfig { get; set; }
        /// <summary>
        /// DocumentSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-documentsource
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DocumentSource { get; set; }
        /// <summary>
        /// MaintenanceWindows
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-maintenancewindows
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: MaintenanceWindow
        /// </summary>
        public List<Humidifier.IoT.JobTemplateTypes.MaintenanceWindow> MaintenanceWindows { get; set; }
        /// <summary>
        /// PresignedUrlConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-presignedurlconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PresignedUrlConfig
        /// </summary>
        public Humidifier.IoT.JobTemplateTypes.PresignedUrlConfig PresignedUrlConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-jobtemplate.html#cfn-iot-jobtemplate-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace JobTemplateTypes
    {
        public class AbortConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CriteriaList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-abortconfig.html#cfn-iot-jobtemplate-abortconfig-criterialist
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AbortCriteria
            /// </summary>
            public List<Humidifier.IoT.JobTemplateTypes.AbortCriteria> CriteriaList { get; set; }
        }

        public class AbortCriteria : Humidifier.Base.BaseSubResource, IHaveAction, IHaveFailureType, IHaveThresholdPercentage, IHaveMinNumberOfExecutedThings
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-abortcriteria.html#cfn-iot-jobtemplate-abortcriteria-action
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// FailureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-abortcriteria.html#cfn-iot-jobtemplate-abortcriteria-failuretype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FailureType { get; set; }
            /// <summary>
            /// ThresholdPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-abortcriteria.html#cfn-iot-jobtemplate-abortcriteria-thresholdpercentage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ThresholdPercentage { get; set; }
            /// <summary>
            /// MinNumberOfExecutedThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-abortcriteria.html#cfn-iot-jobtemplate-abortcriteria-minnumberofexecutedthings
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinNumberOfExecutedThings { get; set; }
        }

        public class ExponentialRolloutRate : Humidifier.Base.BaseSubResource, IHaveBaseRatePerMinute, IHaveIncrementFactor
        {
            /// <summary>
            /// RateIncreaseCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-exponentialrolloutrate.html#cfn-iot-jobtemplate-exponentialrolloutrate-rateincreasecriteria
            /// Required: True
            /// UpdateType: Immutable
            /// Type: RateIncreaseCriteria
            /// </summary>
            public Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria RateIncreaseCriteria { get; set; }
            /// <summary>
            /// BaseRatePerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-exponentialrolloutrate.html#cfn-iot-jobtemplate-exponentialrolloutrate-baserateperminute
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BaseRatePerMinute { get; set; }
            /// <summary>
            /// IncrementFactor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-exponentialrolloutrate.html#cfn-iot-jobtemplate-exponentialrolloutrate-incrementfactor
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic IncrementFactor { get; set; }
        }

        public class JobExecutionsRetryConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RetryCriteriaList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-jobexecutionsretryconfig.html#cfn-iot-jobtemplate-jobexecutionsretryconfig-retrycriterialist
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: RetryCriteria
            /// </summary>
            public List<Humidifier.IoT.JobTemplateTypes.RetryCriteria> RetryCriteriaList { get; set; }
        }

        public class JobExecutionsRolloutConfig : Humidifier.Base.BaseSubResource, IHaveMaximumPerMinute
        {
            /// <summary>
            /// MaximumPerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-jobexecutionsrolloutconfig.html#cfn-iot-jobtemplate-jobexecutionsrolloutconfig-maximumperminute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumPerMinute { get; set; }
            /// <summary>
            /// ExponentialRolloutRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-jobexecutionsrolloutconfig.html#cfn-iot-jobtemplate-jobexecutionsrolloutconfig-exponentialrolloutrate
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ExponentialRolloutRate
            /// </summary>
            public Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate ExponentialRolloutRate { get; set; }
        }

        public class MaintenanceWindow : Humidifier.Base.BaseSubResource, IHaveStartTime, IHaveDurationInMinutes
        {
            /// <summary>
            /// DurationInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-maintenancewindow.html#cfn-iot-jobtemplate-maintenancewindow-durationinminutes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DurationInMinutes { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-maintenancewindow.html#cfn-iot-jobtemplate-maintenancewindow-starttime
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartTime { get; set; }
        }

        public class PresignedUrlConfig : Humidifier.Base.BaseSubResource, IHaveRoleArn
        {
            /// <summary>
            /// ExpiresInSec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-presignedurlconfig.html#cfn-iot-jobtemplate-presignedurlconfig-expiresinsec
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ExpiresInSec { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-presignedurlconfig.html#cfn-iot-jobtemplate-presignedurlconfig-rolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class RateIncreaseCriteria : Humidifier.Base.BaseSubResource, IHaveNumberOfSucceededThings, IHaveNumberOfNotifiedThings
        {
            /// <summary>
            /// NumberOfSucceededThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-rateincreasecriteria.html#cfn-iot-jobtemplate-rateincreasecriteria-numberofsucceededthings
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfSucceededThings { get; set; }
            /// <summary>
            /// NumberOfNotifiedThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-rateincreasecriteria.html#cfn-iot-jobtemplate-rateincreasecriteria-numberofnotifiedthings
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfNotifiedThings { get; set; }
        }

        public class RetryCriteria : Humidifier.Base.BaseSubResource, IHaveFailureType
        {
            /// <summary>
            /// FailureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-retrycriteria.html#cfn-iot-jobtemplate-retrycriteria-failuretype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FailureType { get; set; }
            /// <summary>
            /// NumberOfRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-retrycriteria.html#cfn-iot-jobtemplate-retrycriteria-numberofretries
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfRetries { get; set; }
        }

        public class TimeoutConfig : Humidifier.Base.BaseSubResource, IHaveInProgressTimeoutInMinutes
        {
            /// <summary>
            /// InProgressTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-jobtemplate-timeoutconfig.html#cfn-iot-jobtemplate-timeoutconfig-inprogresstimeoutinminutes
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InProgressTimeoutInMinutes { get; set; }
        }
    }
}