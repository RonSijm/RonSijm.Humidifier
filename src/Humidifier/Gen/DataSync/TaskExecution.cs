namespace Humidifier.DataSync
{
    using global::System.Collections.Generic;
    using TaskExecutionTypes;

    public class TaskExecution : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string EstimatedFilesToTransfer =  "EstimatedFilesToTransfer" ;
            public static string EstimatedFilesToDelete =  "EstimatedFilesToDelete" ;
            public static string BytesTransferred =  "BytesTransferred" ;
            public static string TaskExecutionArn =  "TaskExecutionArn" ;
            public static string TaskMode =  "TaskMode" ;
            public static string FilesPrepared =  "FilesPrepared" ;
            public static string BytesCompressed =  "BytesCompressed" ;
            public static string BytesWritten =  "BytesWritten" ;
            public static string OverrideOptions =  "OverrideOptions" ;
            public static string Status =  "Status" ;
            public static string FilesVerified =  "FilesVerified" ;
            public static string FilesSkipped =  "FilesSkipped" ;
            public static string FilesDeleted =  "FilesDeleted" ;
            public static string StartTime =  "StartTime" ;
            public static string FilesTransferred =  "FilesTransferred" ;
            public static string EstimatedBytesToTransfer =  "EstimatedBytesToTransfer" ;
        }

        public override string AWSTypeName { get => AWS.DataSync.TaskExecution; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-taskexecution.html#cfn-datasync-taskexecution-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// TaskArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-taskexecution.html#cfn-datasync-taskexecution-taskarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TaskArn { get; set; }
    }

    namespace TaskExecutionTypes
    {
        public class Options : Humidifier.Base.BaseSubResource, IHaveLogLevel, IHaveGid, IHaveUid
        {
            /// <summary>
            /// VerifyMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-taskexecution-options.html#cfn-datasync-taskexecution-options-verifymode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VerifyMode { get; set; }
            /// <summary>
            /// Gid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-taskexecution-options.html#cfn-datasync-taskexecution-options-gid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Gid { get; set; }
            /// <summary>
            /// Atime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-taskexecution-options.html#cfn-datasync-taskexecution-options-atime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Atime { get; set; }
            /// <summary>
            /// OverwriteMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-taskexecution-options.html#cfn-datasync-taskexecution-options-overwritemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OverwriteMode { get; set; }
            /// <summary>
            /// PreserveDevices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-taskexecution-options.html#cfn-datasync-taskexecution-options-preservedevices
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreserveDevices { get; set; }
            /// <summary>
            /// Mtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-taskexecution-options.html#cfn-datasync-taskexecution-options-mtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mtime { get; set; }
            /// <summary>
            /// TaskQueueing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-taskexecution-options.html#cfn-datasync-taskexecution-options-taskqueueing
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TaskQueueing { get; set; }
            /// <summary>
            /// TransferMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-taskexecution-options.html#cfn-datasync-taskexecution-options-transfermode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TransferMode { get; set; }
            /// <summary>
            /// LogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-taskexecution-options.html#cfn-datasync-taskexecution-options-loglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogLevel { get; set; }
            /// <summary>
            /// ObjectTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-taskexecution-options.html#cfn-datasync-taskexecution-options-objecttags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectTags { get; set; }
            /// <summary>
            /// Uid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-taskexecution-options.html#cfn-datasync-taskexecution-options-uid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Uid { get; set; }
            /// <summary>
            /// BytesPerSecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-taskexecution-options.html#cfn-datasync-taskexecution-options-bytespersecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BytesPerSecond { get; set; }
            /// <summary>
            /// PosixPermissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-taskexecution-options.html#cfn-datasync-taskexecution-options-posixpermissions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PosixPermissions { get; set; }
            /// <summary>
            /// PreserveDeletedFiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-taskexecution-options.html#cfn-datasync-taskexecution-options-preservedeletedfiles
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreserveDeletedFiles { get; set; }
            /// <summary>
            /// SecurityDescriptorCopyFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-taskexecution-options.html#cfn-datasync-taskexecution-options-securitydescriptorcopyflags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecurityDescriptorCopyFlags { get; set; }
        }
    }
}