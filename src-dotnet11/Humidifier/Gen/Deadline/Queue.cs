namespace Humidifier.Deadline
{
    using global::System.Collections.Generic;
    using QueueTypes;

    public class Queue : Humidifier.Base.BaseResource, IHaveTags, IHaveDeadlineQueueTypesJobRunAsUserJobRunAsUser, IHaveStringListOfAllowedStorageProfileIds, IHaveDescription, IHaveDeadlineQueueTypesJobAttachmentSettingsJobAttachmentSettings, IHaveDeadlineQueueTypesSchedulingConfigurationSchedulingConfiguration, IHaveStringListOfRequiredFileSystemLocationNames, IHaveDefaultBudgetAction, IHaveDisplayName, IHaveFarmId, IHaveRoleArn
    {
        public class Attributes
        {
            public static string QueueId =  "QueueId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Deadline.Queue; }
        /// <summary>
        /// JobRunAsUser
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queue.html#cfn-deadline-queue-jobrunasuser
        /// Required: False
        /// UpdateType: Mutable
        /// Type: JobRunAsUser
        /// </summary>
        public Union<Humidifier.Deadline.QueueTypes.JobRunAsUser, BaseFunction>? JobRunAsUser { get; set; }
        /// <summary>
        /// AllowedStorageProfileIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queue.html#cfn-deadline-queue-allowedstorageprofileids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedStorageProfileIds { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queue.html#cfn-deadline-queue-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// JobAttachmentSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queue.html#cfn-deadline-queue-jobattachmentsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: JobAttachmentSettings
        /// </summary>
        public Union<Humidifier.Deadline.QueueTypes.JobAttachmentSettings, BaseFunction>? JobAttachmentSettings { get; set; }
        /// <summary>
        /// SchedulingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queue.html#cfn-deadline-queue-schedulingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SchedulingConfiguration
        /// </summary>
        public Union<Humidifier.Deadline.QueueTypes.SchedulingConfiguration, BaseFunction>? SchedulingConfiguration { get; set; }
        /// <summary>
        /// RequiredFileSystemLocationNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queue.html#cfn-deadline-queue-requiredfilesystemlocationnames
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RequiredFileSystemLocationNames { get; set; }
        /// <summary>
        /// DefaultBudgetAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queue.html#cfn-deadline-queue-defaultbudgetaction
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultBudgetAction { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queue.html#cfn-deadline-queue-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DisplayName { get; set; }

        /// <summary>
        /// FarmId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queue.html#cfn-deadline-queue-farmid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FarmId { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queue.html#cfn-deadline-queue-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queue.html#cfn-deadline-queue-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace QueueTypes
    {
        public class JobAttachmentSettings : Humidifier.Base.BaseSubResource, IHaveRootPrefix, IHaveS3BucketName
        {
            /// <summary>
            /// RootPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-jobattachmentsettings.html#cfn-deadline-queue-jobattachmentsettings-rootprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RootPrefix { get; set; }
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-jobattachmentsettings.html#cfn-deadline-queue-jobattachmentsettings-s3bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketName { get; set; }
        }

        public class JobRunAsUser : Humidifier.Base.BaseSubResource, IHaveRunAs, IHaveDeadlineQueueTypesPosixUserPosix, IHaveDeadlineQueueTypesWindowsUserWindows
        {
            /// <summary>
            /// RunAs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-jobrunasuser.html#cfn-deadline-queue-jobrunasuser-runas
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RunAs { get; set; }
            /// <summary>
            /// Posix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-jobrunasuser.html#cfn-deadline-queue-jobrunasuser-posix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PosixUser
            /// </summary>
            public Union<Humidifier.Deadline.QueueTypes.PosixUser, BaseFunction>? Posix { get; set; }
            /// <summary>
            /// Windows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-jobrunasuser.html#cfn-deadline-queue-jobrunasuser-windows
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WindowsUser
            /// </summary>
            public Union<Humidifier.Deadline.QueueTypes.WindowsUser, BaseFunction>? Windows { get; set; }
        }

        public class PosixUser : Humidifier.Base.BaseSubResource, IHaveGroup, IHaveUser
        {
            /// <summary>
            /// Group
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-posixuser.html#cfn-deadline-queue-posixuser-group
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Group { get; set; }
            /// <summary>
            /// User
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-posixuser.html#cfn-deadline-queue-posixuser-user
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? User { get; set; }
        }

        public class PriorityBalancedSchedulingConfiguration : Humidifier.Base.BaseSubResource, IHaveRenderingTaskBuffer_Integer
        {
            /// <summary>
            /// RenderingTaskBuffer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-prioritybalancedschedulingconfiguration.html#cfn-deadline-queue-prioritybalancedschedulingconfiguration-renderingtaskbuffer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RenderingTaskBuffer { get; set; }
        }

        public class SchedulingConfiguration : Humidifier.Base.BaseSubResource, IHaveDeadlineQueueTypesPriorityBalancedSchedulingConfigurationPriorityBalanced, IHavePriorityFifo_Json, IHaveDeadlineQueueTypesWeightedBalancedSchedulingConfigurationWeightedBalanced
        {
            /// <summary>
            /// PriorityBalanced
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-schedulingconfiguration.html#cfn-deadline-queue-schedulingconfiguration-prioritybalanced
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PriorityBalancedSchedulingConfiguration
            /// </summary>
            public Union<Humidifier.Deadline.QueueTypes.PriorityBalancedSchedulingConfiguration, BaseFunction>? PriorityBalanced { get; set; }
            /// <summary>
            /// PriorityFifo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-schedulingconfiguration.html#cfn-deadline-queue-schedulingconfiguration-priorityfifo
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? PriorityFifo { get; set; }
            /// <summary>
            /// WeightedBalanced
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-schedulingconfiguration.html#cfn-deadline-queue-schedulingconfiguration-weightedbalanced
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WeightedBalancedSchedulingConfiguration
            /// </summary>
            public Union<Humidifier.Deadline.QueueTypes.WeightedBalancedSchedulingConfiguration, BaseFunction>? WeightedBalanced { get; set; }
        }

        public class SchedulingMaxPriorityOverride : Humidifier.Base.BaseSubResource, IHaveAlwaysScheduleFirst_Json
        {
            /// <summary>
            /// AlwaysScheduleFirst
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-schedulingmaxpriorityoverride.html#cfn-deadline-queue-schedulingmaxpriorityoverride-alwaysschedulefirst
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AlwaysScheduleFirst { get; set; }
        }

        public class SchedulingMinPriorityOverride : Humidifier.Base.BaseSubResource, IHaveAlwaysScheduleLast_Json
        {
            /// <summary>
            /// AlwaysScheduleLast
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-schedulingminpriorityoverride.html#cfn-deadline-queue-schedulingminpriorityoverride-alwaysschedulelast
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AlwaysScheduleLast { get; set; }
        }

        public class WeightedBalancedSchedulingConfiguration : Humidifier.Base.BaseSubResource, IHaveErrorWeight_Double, IHaveDeadlineQueueTypesSchedulingMaxPriorityOverrideMaxPriorityOverride, IHavePriorityWeight_Double, IHaveSubmissionTimeWeight_Double, IHaveDeadlineQueueTypesSchedulingMinPriorityOverrideMinPriorityOverride, IHaveRenderingTaskWeight_Double, IHaveRenderingTaskBuffer_Integer
        {
            /// <summary>
            /// ErrorWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-weightedbalancedschedulingconfiguration.html#cfn-deadline-queue-weightedbalancedschedulingconfiguration-errorweight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ErrorWeight { get; set; }
            /// <summary>
            /// MaxPriorityOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-weightedbalancedschedulingconfiguration.html#cfn-deadline-queue-weightedbalancedschedulingconfiguration-maxpriorityoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchedulingMaxPriorityOverride
            /// </summary>
            public Union<Humidifier.Deadline.QueueTypes.SchedulingMaxPriorityOverride, BaseFunction>? MaxPriorityOverride { get; set; }
            /// <summary>
            /// PriorityWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-weightedbalancedschedulingconfiguration.html#cfn-deadline-queue-weightedbalancedschedulingconfiguration-priorityweight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? PriorityWeight { get; set; }
            /// <summary>
            /// SubmissionTimeWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-weightedbalancedschedulingconfiguration.html#cfn-deadline-queue-weightedbalancedschedulingconfiguration-submissiontimeweight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? SubmissionTimeWeight { get; set; }
            /// <summary>
            /// MinPriorityOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-weightedbalancedschedulingconfiguration.html#cfn-deadline-queue-weightedbalancedschedulingconfiguration-minpriorityoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchedulingMinPriorityOverride
            /// </summary>
            public Union<Humidifier.Deadline.QueueTypes.SchedulingMinPriorityOverride, BaseFunction>? MinPriorityOverride { get; set; }
            /// <summary>
            /// RenderingTaskWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-weightedbalancedschedulingconfiguration.html#cfn-deadline-queue-weightedbalancedschedulingconfiguration-renderingtaskweight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? RenderingTaskWeight { get; set; }
            /// <summary>
            /// RenderingTaskBuffer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-weightedbalancedschedulingconfiguration.html#cfn-deadline-queue-weightedbalancedschedulingconfiguration-renderingtaskbuffer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RenderingTaskBuffer { get; set; }
        }

        public class WindowsUser : Humidifier.Base.BaseSubResource, IHaveUser, IHavePasswordArn
        {
            /// <summary>
            /// User
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-windowsuser.html#cfn-deadline-queue-windowsuser-user
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? User { get; set; }
            /// <summary>
            /// PasswordArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-queue-windowsuser.html#cfn-deadline-queue-windowsuser-passwordarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PasswordArn { get; set; }
        }
    }
}