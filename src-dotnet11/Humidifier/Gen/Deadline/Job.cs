namespace Humidifier.Deadline
{
    using global::System.Collections.Generic;

    public class Job : Humidifier.Base.BaseResource, IHaveTags, IHaveMaxFailedTasksCount_Integer, IHavePriority_Integer, IHaveMaxWorkerCount_Integer, IHaveQueueId, IHaveMaxRetriesPerTask_Integer, IHaveFarmId
    {
        public class Attributes
        {
            public static string CreatedBy =  "CreatedBy" ;
            public static string LifecycleStatusMessage =  "LifecycleStatusMessage" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string LifecycleStatus =  "LifecycleStatus" ;
            public static string TaskRunStatus =  "TaskRunStatus" ;
            public static string Arn =  "Arn" ;
            public static string JobId =  "JobId" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Deadline.Job; }
        /// <summary>
        /// MaxFailedTasksCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-job.html#cfn-deadline-job-maxfailedtaskscount
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxFailedTasksCount { get; set; }
        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-job.html#cfn-deadline-job-priority
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Priority { get; set; }
        /// <summary>
        /// MaxWorkerCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-job.html#cfn-deadline-job-maxworkercount
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxWorkerCount { get; set; }
        /// <summary>
        /// QueueId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-job.html#cfn-deadline-job-queueid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? QueueId { get; set; }
        /// <summary>
        /// MaxRetriesPerTask
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-job.html#cfn-deadline-job-maxretriespertask
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxRetriesPerTask { get; set; }
        /// <summary>
        /// FarmId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-job.html#cfn-deadline-job-farmid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FarmId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-job.html#cfn-deadline-job-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}