namespace Humidifier.FSx
{
    using global::System.Collections.Generic;
    using TaskTypes;

    public class Task : Humidifier.Base.BaseResource, IHaveTags, IHaveType, IHaveFileSystemId
    {
        public class Attributes
        {
            public static string ResourceARN =  "ResourceARN" ;
            public static string TaskId =  "TaskId" ;
            public static string Lifecycle =  "Lifecycle" ;
            public static string FileCacheId =  "FileCacheId" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.FSx.Task; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-task.html#cfn-fsx-task-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }
        /// <summary>
        /// Report
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-task.html#cfn-fsx-task-report
        /// Required: False
        /// UpdateType: Immutable
        /// Type: CompletionReport
        /// </summary>
        public Humidifier.FSx.TaskTypes.CompletionReport Report { get; set; }
        /// <summary>
        /// ReleaseConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-task.html#cfn-fsx-task-releaseconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ReleaseConfiguration
        /// </summary>
        public Humidifier.FSx.TaskTypes.ReleaseConfiguration ReleaseConfiguration { get; set; }
        /// <summary>
        /// FileSystemId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-task.html#cfn-fsx-task-filesystemid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FileSystemId { get; set; }
        /// <summary>
        /// Paths
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-task.html#cfn-fsx-task-paths
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Paths { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-task.html#cfn-fsx-task-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace TaskTypes
    {
        public class CompletionReport : Humidifier.Base.BaseSubResource, IHaveEnabled, IHavePath, IHaveScope, IHaveFormat
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-task-completionreport.html#cfn-fsx-task-completionreport-path
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-task-completionreport.html#cfn-fsx-task-completionreport-format
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-task-completionreport.html#cfn-fsx-task-completionreport-scope
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scope { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-task-completionreport.html#cfn-fsx-task-completionreport-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class DurationSinceLastAccess : Humidifier.Base.BaseSubResource, IHaveValue, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-task-durationsincelastaccess.html#cfn-fsx-task-durationsincelastaccess-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-task-durationsincelastaccess.html#cfn-fsx-task-durationsincelastaccess-unit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }

        public class ReleaseConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DurationSinceLastAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-task-releaseconfiguration.html#cfn-fsx-task-releaseconfiguration-durationsincelastaccess
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DurationSinceLastAccess
            /// </summary>
            public Humidifier.FSx.TaskTypes.DurationSinceLastAccess DurationSinceLastAccess { get; set; }
        }
    }
}