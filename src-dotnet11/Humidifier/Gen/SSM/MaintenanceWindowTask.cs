namespace Humidifier.SSM
{
    using global::System.Collections.Generic;
    using MaintenanceWindowTaskTypes;

    public class MaintenanceWindowTask : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveMaxErrors, IHaveDescription, IHaveServiceRoleArn, IHavePriority_Integer, IHaveMaxConcurrency, IHaveListOfSSMMaintenanceWindowTaskTypesTargetTargets, IHaveName, IHaveTaskArn, IHaveSSMMaintenanceWindowTaskTypesTaskInvocationParametersTaskInvocationParameters, IHaveWindowId, IHaveTaskParameters_Json, IHaveTaskType, IHaveCutoffBehavior, IHaveSSMMaintenanceWindowTaskTypesLoggingInfoLoggingInfo
    {
        public class Attributes
        {
            public static string WindowTaskId =  "WindowTaskId" ;
        }

        public override string AWSTypeName { get => AWS.SSM.MaintenanceWindowTask; }
        /// <summary>
        /// MaxErrors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtask.html#cfn-ssm-maintenancewindowtask-maxerrors
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MaxErrors { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtask.html#cfn-ssm-maintenancewindowtask-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ServiceRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtask.html#cfn-ssm-maintenancewindowtask-servicerolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServiceRoleArn { get; set; }

        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtask.html#cfn-ssm-maintenancewindowtask-priority
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Priority { get; set; }
        /// <summary>
        /// MaxConcurrency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtask.html#cfn-ssm-maintenancewindowtask-maxconcurrency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MaxConcurrency { get; set; }
        /// <summary>
        /// Targets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtask.html#cfn-ssm-maintenancewindowtask-targets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Target
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SSM.MaintenanceWindowTaskTypes.Target>, IReadOnlyList<Union<Humidifier.SSM.MaintenanceWindowTaskTypes.Target, BaseFunction>>, BaseFunction>? Targets { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// TaskArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtask.html#cfn-ssm-maintenancewindowtask-taskarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TaskArn { get; set; }
        /// <summary>
        /// TaskInvocationParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtask.html#cfn-ssm-maintenancewindowtask-taskinvocationparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TaskInvocationParameters
        /// </summary>
        public Union<Humidifier.SSM.MaintenanceWindowTaskTypes.TaskInvocationParameters, BaseFunction>? TaskInvocationParameters { get; set; }

        /// <summary>
        /// WindowId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtask.html#cfn-ssm-maintenancewindowtask-windowid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? WindowId { get; set; }
        /// <summary>
        /// TaskParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtask.html#cfn-ssm-maintenancewindowtask-taskparameters
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? TaskParameters { get; set; }

        /// <summary>
        /// TaskType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtask.html#cfn-ssm-maintenancewindowtask-tasktype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TaskType { get; set; }
        /// <summary>
        /// CutoffBehavior
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtask.html#cfn-ssm-maintenancewindowtask-cutoffbehavior
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CutoffBehavior { get; set; }
        /// <summary>
        /// LoggingInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtask.html#cfn-ssm-maintenancewindowtask-logginginfo
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoggingInfo
        /// </summary>
        public Union<Humidifier.SSM.MaintenanceWindowTaskTypes.LoggingInfo, BaseFunction>? LoggingInfo { get; set; }
    }

    namespace MaintenanceWindowTaskTypes
    {
        public class CloudWatchOutputConfig : Humidifier.Base.BaseSubResource, IHaveCloudWatchOutputEnabled_Boolean, IHaveCloudWatchLogGroupName
        {
            /// <summary>
            /// CloudWatchOutputEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-cloudwatchoutputconfig.html#cfn-ssm-maintenancewindowtask-cloudwatchoutputconfig-cloudwatchoutputenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CloudWatchOutputEnabled { get; set; }
            /// <summary>
            /// CloudWatchLogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-cloudwatchoutputconfig.html#cfn-ssm-maintenancewindowtask-cloudwatchoutputconfig-cloudwatchloggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CloudWatchLogGroupName { get; set; }
        }

        public class LoggingInfo : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveRegion, IHaveS3Prefix
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-logginginfo.html#cfn-ssm-maintenancewindowtask-logginginfo-s3bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-logginginfo.html#cfn-ssm-maintenancewindowtask-logginginfo-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// S3Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-logginginfo.html#cfn-ssm-maintenancewindowtask-logginginfo-s3prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Prefix { get; set; }
        }

        public class MaintenanceWindowAutomationParameters : Humidifier.Base.BaseSubResource, IHaveParameters_Json, IHaveDocumentVersion
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowautomationparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowautomationparameters-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// DocumentVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowautomationparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowautomationparameters-documentversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentVersion { get; set; }
        }

        public class MaintenanceWindowLambdaParameters : Humidifier.Base.BaseSubResource, IHaveClientContext, IHaveQualifier, IHavePayload
        {
            /// <summary>
            /// ClientContext
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowlambdaparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowlambdaparameters-clientcontext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientContext { get; set; }
            /// <summary>
            /// Qualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowlambdaparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowlambdaparameters-qualifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Qualifier { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowlambdaparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowlambdaparameters-payload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Payload { get; set; }
        }

        public class MaintenanceWindowRunCommandParameters : Humidifier.Base.BaseSubResource, IHaveTimeoutSeconds_Integer, IHaveComment, IHaveOutputS3KeyPrefix, IHaveParameters_Json, IHaveSSMMaintenanceWindowTaskTypesCloudWatchOutputConfigCloudWatchOutputConfig, IHaveDocumentHashType, IHaveServiceRoleArn, IHaveSSMMaintenanceWindowTaskTypesNotificationConfigNotificationConfig, IHaveDocumentVersion, IHaveOutputS3BucketName, IHaveDocumentHash
        {
            /// <summary>
            /// TimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowruncommandparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowruncommandparameters-timeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutSeconds { get; set; }
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowruncommandparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowruncommandparameters-comment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comment { get; set; }
            /// <summary>
            /// OutputS3KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowruncommandparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowruncommandparameters-outputs3keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputS3KeyPrefix { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowruncommandparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowruncommandparameters-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// CloudWatchOutputConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowruncommandparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowruncommandparameters-cloudwatchoutputconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchOutputConfig
            /// </summary>
            public Union<Humidifier.SSM.MaintenanceWindowTaskTypes.CloudWatchOutputConfig, BaseFunction>? CloudWatchOutputConfig { get; set; }
            /// <summary>
            /// DocumentHashType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowruncommandparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowruncommandparameters-documenthashtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentHashType { get; set; }
            /// <summary>
            /// ServiceRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowruncommandparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowruncommandparameters-servicerolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceRoleArn { get; set; }
            /// <summary>
            /// NotificationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowruncommandparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowruncommandparameters-notificationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotificationConfig
            /// </summary>
            public Union<Humidifier.SSM.MaintenanceWindowTaskTypes.NotificationConfig, BaseFunction>? NotificationConfig { get; set; }
            /// <summary>
            /// DocumentVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowruncommandparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowruncommandparameters-documentversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentVersion { get; set; }
            /// <summary>
            /// OutputS3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowruncommandparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowruncommandparameters-outputs3bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputS3BucketName { get; set; }
            /// <summary>
            /// DocumentHash
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowruncommandparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowruncommandparameters-documenthash
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentHash { get; set; }
        }

        public class MaintenanceWindowStepFunctionsParameters : Humidifier.Base.BaseSubResource, IHaveInput, IHaveName
        {
            /// <summary>
            /// Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowstepfunctionsparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowstepfunctionsparameters-input
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Input { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowstepfunctionsparameters.html#cfn-ssm-maintenancewindowtask-maintenancewindowstepfunctionsparameters-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class NotificationConfig : Humidifier.Base.BaseSubResource, IHaveNotificationArn, IHaveNotificationType, IHaveStringListOfNotificationEvents
        {
            /// <summary>
            /// NotificationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-notificationconfig.html#cfn-ssm-maintenancewindowtask-notificationconfig-notificationarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NotificationArn { get; set; }
            /// <summary>
            /// NotificationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-notificationconfig.html#cfn-ssm-maintenancewindowtask-notificationconfig-notificationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NotificationType { get; set; }
            /// <summary>
            /// NotificationEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-notificationconfig.html#cfn-ssm-maintenancewindowtask-notificationconfig-notificationevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotificationEvents { get; set; }
        }

        public class Target : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveKey
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-target.html#cfn-ssm-maintenancewindowtask-target-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-target.html#cfn-ssm-maintenancewindowtask-target-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class TaskInvocationParameters : Humidifier.Base.BaseSubResource, IHaveSSMMaintenanceWindowTaskTypesMaintenanceWindowRunCommandParametersMaintenanceWindowRunCommandParameters, IHaveSSMMaintenanceWindowTaskTypesMaintenanceWindowAutomationParametersMaintenanceWindowAutomationParameters, IHaveSSMMaintenanceWindowTaskTypesMaintenanceWindowStepFunctionsParametersMaintenanceWindowStepFunctionsParameters, IHaveSSMMaintenanceWindowTaskTypesMaintenanceWindowLambdaParametersMaintenanceWindowLambdaParameters
        {
            /// <summary>
            /// MaintenanceWindowRunCommandParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-taskinvocationparameters.html#cfn-ssm-maintenancewindowtask-taskinvocationparameters-maintenancewindowruncommandparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaintenanceWindowRunCommandParameters
            /// </summary>
            public Union<Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowRunCommandParameters, BaseFunction>? MaintenanceWindowRunCommandParameters { get; set; }
            /// <summary>
            /// MaintenanceWindowAutomationParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-taskinvocationparameters.html#cfn-ssm-maintenancewindowtask-taskinvocationparameters-maintenancewindowautomationparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaintenanceWindowAutomationParameters
            /// </summary>
            public Union<Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowAutomationParameters, BaseFunction>? MaintenanceWindowAutomationParameters { get; set; }
            /// <summary>
            /// MaintenanceWindowStepFunctionsParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-taskinvocationparameters.html#cfn-ssm-maintenancewindowtask-taskinvocationparameters-maintenancewindowstepfunctionsparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaintenanceWindowStepFunctionsParameters
            /// </summary>
            public Union<Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowStepFunctionsParameters, BaseFunction>? MaintenanceWindowStepFunctionsParameters { get; set; }
            /// <summary>
            /// MaintenanceWindowLambdaParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-taskinvocationparameters.html#cfn-ssm-maintenancewindowtask-taskinvocationparameters-maintenancewindowlambdaparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaintenanceWindowLambdaParameters
            /// </summary>
            public Union<Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowLambdaParameters, BaseFunction>? MaintenanceWindowLambdaParameters { get; set; }
        }
    }
}