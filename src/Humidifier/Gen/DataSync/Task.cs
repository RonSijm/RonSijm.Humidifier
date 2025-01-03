namespace Humidifier.DataSync
{
    using System.Collections.Generic;
    using TaskTypes;

    public class Task : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveCloudWatchLogGroupArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string SourceNetworkInterfaceArns =  "SourceNetworkInterfaceArns" ;
            public static string DestinationNetworkInterfaceArns =  "DestinationNetworkInterfaceArns" ;
            public static string TaskArn =  "TaskArn" ;
        }

        public override string AWSTypeName { get => AWS.DataSync.Task; }
        /// <summary>
        /// Includes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-task.html#cfn-datasync-task-includes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FilterRule
        /// </summary>
        public List<Humidifier.DataSync.TaskTypes.FilterRule> Includes { get; set; }

        /// <summary>
        /// DestinationLocationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-task.html#cfn-datasync-task-destinationlocationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DestinationLocationArn { get; set; }
        /// <summary>
        /// Options
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-task.html#cfn-datasync-task-options
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Options
        /// </summary>
        public Humidifier.DataSync.TaskTypes.Options Options { get; set; }
        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-task.html#cfn-datasync-task-schedule
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TaskSchedule
        /// </summary>
        public Humidifier.DataSync.TaskTypes.TaskSchedule Schedule { get; set; }
        /// <summary>
        /// CloudWatchLogGroupArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-task.html#cfn-datasync-task-cloudwatchloggrouparn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CloudWatchLogGroupArn { get; set; }

        /// <summary>
        /// SourceLocationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-task.html#cfn-datasync-task-sourcelocationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SourceLocationArn { get; set; }
        /// <summary>
        /// TaskReportConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-task.html#cfn-datasync-task-taskreportconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TaskReportConfig
        /// </summary>
        public Humidifier.DataSync.TaskTypes.TaskReportConfig TaskReportConfig { get; set; }
        /// <summary>
        /// Excludes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-task.html#cfn-datasync-task-excludes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FilterRule
        /// </summary>
        public List<Humidifier.DataSync.TaskTypes.FilterRule> Excludes { get; set; }
        /// <summary>
        /// TaskMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-task.html#cfn-datasync-task-taskmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TaskMode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-task.html#cfn-datasync-task-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ManifestConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-task.html#cfn-datasync-task-manifestconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ManifestConfig
        /// </summary>
        public Humidifier.DataSync.TaskTypes.ManifestConfig ManifestConfig { get; set; }
    }

    namespace TaskTypes
    {
        public class Deleted : Humidifier.Base.BaseSubResource, IHaveReportLevel
        {
            /// <summary>
            /// ReportLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-deleted.html#cfn-datasync-task-deleted-reportlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReportLevel { get; set; }
        }

        public class Destination : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-destination.html#cfn-datasync-task-destination-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TaskReportConfigDestinationS3
            /// </summary>
            public Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3 S3 { get; set; }
        }

        public class FilterRule : Humidifier.Base.BaseSubResource, IHaveValue, IHaveFilterType
        {
            /// <summary>
            /// FilterType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-filterrule.html#cfn-datasync-task-filterrule-filtertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterType { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-filterrule.html#cfn-datasync-task-filterrule-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class ManifestConfig : Humidifier.Base.BaseSubResource, IHaveAction, IHaveFormat
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-manifestconfig.html#cfn-datasync-task-manifestconfig-action
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-manifestconfig.html#cfn-datasync-task-manifestconfig-format
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-manifestconfig.html#cfn-datasync-task-manifestconfig-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Source
            /// </summary>
            public Humidifier.DataSync.TaskTypes.Source Source { get; set; }
        }

        public class ManifestConfigSourceS3 : Humidifier.Base.BaseSubResource, IHaveS3BucketArn, IHaveBucketAccessRoleArn
        {
            /// <summary>
            /// S3BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-manifestconfigsources3.html#cfn-datasync-task-manifestconfigsources3-s3bucketarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketArn { get; set; }
            /// <summary>
            /// BucketAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-manifestconfigsources3.html#cfn-datasync-task-manifestconfigsources3-bucketaccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketAccessRoleArn { get; set; }
            /// <summary>
            /// ManifestObjectVersionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-manifestconfigsources3.html#cfn-datasync-task-manifestconfigsources3-manifestobjectversionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestObjectVersionId { get; set; }
            /// <summary>
            /// ManifestObjectPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-manifestconfigsources3.html#cfn-datasync-task-manifestconfigsources3-manifestobjectpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestObjectPath { get; set; }
        }

        public class Options : Humidifier.Base.BaseSubResource, IHaveLogLevel, IHaveGid, IHaveUid
        {
            /// <summary>
            /// VerifyMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-options.html#cfn-datasync-task-options-verifymode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VerifyMode { get; set; }
            /// <summary>
            /// Gid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-options.html#cfn-datasync-task-options-gid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Gid { get; set; }
            /// <summary>
            /// Atime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-options.html#cfn-datasync-task-options-atime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Atime { get; set; }
            /// <summary>
            /// OverwriteMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-options.html#cfn-datasync-task-options-overwritemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OverwriteMode { get; set; }
            /// <summary>
            /// PreserveDevices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-options.html#cfn-datasync-task-options-preservedevices
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreserveDevices { get; set; }
            /// <summary>
            /// Mtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-options.html#cfn-datasync-task-options-mtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mtime { get; set; }
            /// <summary>
            /// TaskQueueing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-options.html#cfn-datasync-task-options-taskqueueing
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TaskQueueing { get; set; }
            /// <summary>
            /// TransferMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-options.html#cfn-datasync-task-options-transfermode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TransferMode { get; set; }
            /// <summary>
            /// LogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-options.html#cfn-datasync-task-options-loglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogLevel { get; set; }
            /// <summary>
            /// ObjectTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-options.html#cfn-datasync-task-options-objecttags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectTags { get; set; }
            /// <summary>
            /// Uid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-options.html#cfn-datasync-task-options-uid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Uid { get; set; }
            /// <summary>
            /// BytesPerSecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-options.html#cfn-datasync-task-options-bytespersecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BytesPerSecond { get; set; }
            /// <summary>
            /// PosixPermissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-options.html#cfn-datasync-task-options-posixpermissions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PosixPermissions { get; set; }
            /// <summary>
            /// PreserveDeletedFiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-options.html#cfn-datasync-task-options-preservedeletedfiles
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreserveDeletedFiles { get; set; }
            /// <summary>
            /// SecurityDescriptorCopyFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-options.html#cfn-datasync-task-options-securitydescriptorcopyflags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecurityDescriptorCopyFlags { get; set; }
        }

        public class Overrides : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Verified
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-overrides.html#cfn-datasync-task-overrides-verified
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Verified
            /// </summary>
            public Humidifier.DataSync.TaskTypes.Verified Verified { get; set; }
            /// <summary>
            /// Skipped
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-overrides.html#cfn-datasync-task-overrides-skipped
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Skipped
            /// </summary>
            public Humidifier.DataSync.TaskTypes.Skipped Skipped { get; set; }
            /// <summary>
            /// Transferred
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-overrides.html#cfn-datasync-task-overrides-transferred
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Transferred
            /// </summary>
            public Humidifier.DataSync.TaskTypes.Transferred Transferred { get; set; }
            /// <summary>
            /// Deleted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-overrides.html#cfn-datasync-task-overrides-deleted
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Deleted
            /// </summary>
            public Humidifier.DataSync.TaskTypes.Deleted Deleted { get; set; }
        }

        public class Skipped : Humidifier.Base.BaseSubResource, IHaveReportLevel
        {
            /// <summary>
            /// ReportLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-skipped.html#cfn-datasync-task-skipped-reportlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReportLevel { get; set; }
        }

        public class Source : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-source.html#cfn-datasync-task-source-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManifestConfigSourceS3
            /// </summary>
            public Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3 S3 { get; set; }
        }

        public class TaskReportConfig : Humidifier.Base.BaseSubResource, IHaveReportLevel
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-taskreportconfig.html#cfn-datasync-task-taskreportconfig-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Destination
            /// </summary>
            public Humidifier.DataSync.TaskTypes.Destination Destination { get; set; }
            /// <summary>
            /// ReportLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-taskreportconfig.html#cfn-datasync-task-taskreportconfig-reportlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReportLevel { get; set; }
            /// <summary>
            /// ObjectVersionIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-taskreportconfig.html#cfn-datasync-task-taskreportconfig-objectversionids
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectVersionIds { get; set; }
            /// <summary>
            /// Overrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-taskreportconfig.html#cfn-datasync-task-taskreportconfig-overrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Overrides
            /// </summary>
            public Humidifier.DataSync.TaskTypes.Overrides Overrides { get; set; }
            /// <summary>
            /// OutputType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-taskreportconfig.html#cfn-datasync-task-taskreportconfig-outputtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputType { get; set; }
        }

        public class TaskReportConfigDestinationS3 : Humidifier.Base.BaseSubResource, IHaveSubdirectory, IHaveS3BucketArn, IHaveBucketAccessRoleArn
        {
            /// <summary>
            /// Subdirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-taskreportconfigdestinations3.html#cfn-datasync-task-taskreportconfigdestinations3-subdirectory
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Subdirectory { get; set; }
            /// <summary>
            /// S3BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-taskreportconfigdestinations3.html#cfn-datasync-task-taskreportconfigdestinations3-s3bucketarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketArn { get; set; }
            /// <summary>
            /// BucketAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-taskreportconfigdestinations3.html#cfn-datasync-task-taskreportconfigdestinations3-bucketaccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketAccessRoleArn { get; set; }
        }

        public class TaskSchedule : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveScheduleExpression
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-taskschedule.html#cfn-datasync-task-taskschedule-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-taskschedule.html#cfn-datasync-task-taskschedule-scheduleexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScheduleExpression { get; set; }
        }

        public class Transferred : Humidifier.Base.BaseSubResource, IHaveReportLevel
        {
            /// <summary>
            /// ReportLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-transferred.html#cfn-datasync-task-transferred-reportlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReportLevel { get; set; }
        }

        public class Verified : Humidifier.Base.BaseSubResource, IHaveReportLevel
        {
            /// <summary>
            /// ReportLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-verified.html#cfn-datasync-task-verified-reportlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReportLevel { get; set; }
        }
    }
}