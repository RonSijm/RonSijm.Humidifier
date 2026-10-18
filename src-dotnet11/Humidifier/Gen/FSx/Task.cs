namespace Humidifier.FSx
{
    using global::System.Collections.Generic;
    using TaskTypes;

    public class Task : Humidifier.Base.BaseResource, IHaveTags, IHaveType, IHaveFSxTaskTypesCompletionReportReport, IHaveFSxTaskTypesReleaseConfigurationReleaseConfiguration, IHaveFileSystemId, IHaveStringListOfPaths
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
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Report
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-task.html#cfn-fsx-task-report
        /// Required: False
        /// UpdateType: Immutable
        /// Type: CompletionReport
        /// </summary>
        public Union<Humidifier.FSx.TaskTypes.CompletionReport, BaseFunction>? Report { get; set; }
        /// <summary>
        /// ReleaseConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-task.html#cfn-fsx-task-releaseconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ReleaseConfiguration
        /// </summary>
        public Union<Humidifier.FSx.TaskTypes.ReleaseConfiguration, BaseFunction>? ReleaseConfiguration { get; set; }
        /// <summary>
        /// FileSystemId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-task.html#cfn-fsx-task-filesystemid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FileSystemId { get; set; }
        /// <summary>
        /// Paths
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-task.html#cfn-fsx-task-paths
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Paths { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-task.html#cfn-fsx-task-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TaskTypes
    {
        public class CompletionReport : Humidifier.Base.BaseSubResource, IHavePath, IHaveFormat, IHaveScope, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-task-completionreport.html#cfn-fsx-task-completionreport-path
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-task-completionreport.html#cfn-fsx-task-completionreport-format
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-task-completionreport.html#cfn-fsx-task-completionreport-scope
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scope { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-task-completionreport.html#cfn-fsx-task-completionreport-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class DurationSinceLastAccess : Humidifier.Base.BaseSubResource, IHaveValue_Integer, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-task-durationsincelastaccess.html#cfn-fsx-task-durationsincelastaccess-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-task-durationsincelastaccess.html#cfn-fsx-task-durationsincelastaccess-unit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class ReleaseConfiguration : Humidifier.Base.BaseSubResource, IHaveFSxTaskTypesDurationSinceLastAccessDurationSinceLastAccess
        {
            /// <summary>
            /// DurationSinceLastAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-task-releaseconfiguration.html#cfn-fsx-task-releaseconfiguration-durationsincelastaccess
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DurationSinceLastAccess
            /// </summary>
            public Union<Humidifier.FSx.TaskTypes.DurationSinceLastAccess, BaseFunction>? DurationSinceLastAccess { get; set; }
        }
    }
}