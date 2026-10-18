namespace Humidifier.Omics
{
    using global::System.Collections.Generic;
    using RunBatchTypes;

    public class RunBatch : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveOmicsRunBatchTypesDefaultRunSettingDefaultRunSetting, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string TotalRuns =  "TotalRuns" ;
            public static string SubmissionSummary =  "SubmissionSummary" ;
            public static string SubmittedTime =  "SubmittedTime" ;
            public static string Uuid =  "Uuid" ;
            public static string RunSummary =  "RunSummary" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Omics.RunBatch; }
        /// <summary>
        /// DefaultRunSetting
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-runbatch.html#cfn-omics-runbatch-defaultrunsetting
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DefaultRunSetting
        /// </summary>
        public Union<Humidifier.Omics.RunBatchTypes.DefaultRunSetting, BaseFunction>? DefaultRunSetting { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-runbatch.html#cfn-omics-runbatch-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RunBatchTypes
    {
        public class DefaultRunSetting : Humidifier.Base.BaseSubResource, IHaveRetentionMode, IHaveNetworkingMode, IHaveParameters_Json, IHaveStorageType, IHaveEngineSettings_Json, IHaveStorageCapacity_Integer, IHavePriority_Integer, IHaveRunGroupId, IHaveOutputUri, IHaveWorkflowId, IHaveOutputBucketOwnerId, IHaveConfigurationName, IHaveWorkflowOwnerId, IHaveRoleArn, IHaveLogLevel, IHaveName, IHaveWorkflowType, IHaveCacheId, IHaveScratchStorageMode, IHaveWorkflowVersionName, IHaveCacheBehavior, IHaveStringDictionaryOfRunTags
        {
            /// <summary>
            /// RetentionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-retentionmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RetentionMode { get; set; }
            /// <summary>
            /// NetworkingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-networkingmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkingMode { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-parameters
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// StorageType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-storagetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageType { get; set; }
            /// <summary>
            /// EngineSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-enginesettings
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? EngineSettings { get; set; }
            /// <summary>
            /// StorageCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-storagecapacity
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageCapacity { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-priority
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// RunGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-rungroupid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RunGroupId { get; set; }
            /// <summary>
            /// OutputUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-outputuri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputUri { get; set; }
            /// <summary>
            /// WorkflowId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-workflowid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkflowId { get; set; }
            /// <summary>
            /// OutputBucketOwnerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-outputbucketownerid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputBucketOwnerId { get; set; }
            /// <summary>
            /// ConfigurationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-configurationname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfigurationName { get; set; }
            /// <summary>
            /// WorkflowOwnerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-workflowownerid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkflowOwnerId { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-rolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// LogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-loglevel
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogLevel { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// WorkflowType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-workflowtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkflowType { get; set; }
            /// <summary>
            /// CacheId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-cacheid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CacheId { get; set; }
            /// <summary>
            /// ScratchStorageMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-scratchstoragemode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScratchStorageMode { get; set; }
            /// <summary>
            /// WorkflowVersionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-workflowversionname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkflowVersionName { get; set; }
            /// <summary>
            /// CacheBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-cachebehavior
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CacheBehavior { get; set; }
            /// <summary>
            /// RunTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-defaultrunsetting.html#cfn-omics-runbatch-defaultrunsetting-runtags
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? RunTags { get; set; }
        }

        public class RunSummary : Humidifier.Base.BaseSubResource, IHavePendingRunCount_Integer, IHaveCompletedRunCount_Integer, IHaveDeletedRunCount_Integer, IHaveCancelledRunCount_Integer, IHaveStartingRunCount_Integer, IHaveFailedRunCount_Integer, IHaveStoppingRunCount_Integer, IHaveRunningRunCount_Integer
        {
            /// <summary>
            /// PendingRunCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-runsummary.html#cfn-omics-runbatch-runsummary-pendingruncount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PendingRunCount { get; set; }
            /// <summary>
            /// CompletedRunCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-runsummary.html#cfn-omics-runbatch-runsummary-completedruncount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CompletedRunCount { get; set; }
            /// <summary>
            /// DeletedRunCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-runsummary.html#cfn-omics-runbatch-runsummary-deletedruncount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DeletedRunCount { get; set; }
            /// <summary>
            /// CancelledRunCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-runsummary.html#cfn-omics-runbatch-runsummary-cancelledruncount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CancelledRunCount { get; set; }
            /// <summary>
            /// StartingRunCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-runsummary.html#cfn-omics-runbatch-runsummary-startingruncount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StartingRunCount { get; set; }
            /// <summary>
            /// FailedRunCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-runsummary.html#cfn-omics-runbatch-runsummary-failedruncount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FailedRunCount { get; set; }
            /// <summary>
            /// StoppingRunCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-runsummary.html#cfn-omics-runbatch-runsummary-stoppingruncount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StoppingRunCount { get; set; }
            /// <summary>
            /// RunningRunCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-runsummary.html#cfn-omics-runbatch-runsummary-runningruncount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RunningRunCount { get; set; }
        }

        public class SubmissionSummary : Humidifier.Base.BaseSubResource, IHaveSuccessfulDeleteSubmissionCount_Integer, IHaveSuccessfulStartSubmissionCount_Integer, IHaveFailedStartSubmissionCount_Integer, IHaveSuccessfulCancelSubmissionCount_Integer, IHaveFailedCancelSubmissionCount_Integer, IHaveFailedDeleteSubmissionCount_Integer, IHavePendingStartSubmissionCount_Integer
        {
            /// <summary>
            /// SuccessfulDeleteSubmissionCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-submissionsummary.html#cfn-omics-runbatch-submissionsummary-successfuldeletesubmissioncount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SuccessfulDeleteSubmissionCount { get; set; }
            /// <summary>
            /// SuccessfulStartSubmissionCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-submissionsummary.html#cfn-omics-runbatch-submissionsummary-successfulstartsubmissioncount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SuccessfulStartSubmissionCount { get; set; }
            /// <summary>
            /// FailedStartSubmissionCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-submissionsummary.html#cfn-omics-runbatch-submissionsummary-failedstartsubmissioncount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FailedStartSubmissionCount { get; set; }
            /// <summary>
            /// SuccessfulCancelSubmissionCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-submissionsummary.html#cfn-omics-runbatch-submissionsummary-successfulcancelsubmissioncount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SuccessfulCancelSubmissionCount { get; set; }
            /// <summary>
            /// FailedCancelSubmissionCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-submissionsummary.html#cfn-omics-runbatch-submissionsummary-failedcancelsubmissioncount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FailedCancelSubmissionCount { get; set; }
            /// <summary>
            /// FailedDeleteSubmissionCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-submissionsummary.html#cfn-omics-runbatch-submissionsummary-faileddeletesubmissioncount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FailedDeleteSubmissionCount { get; set; }
            /// <summary>
            /// PendingStartSubmissionCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-runbatch-submissionsummary.html#cfn-omics-runbatch-submissionsummary-pendingstartsubmissioncount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PendingStartSubmissionCount { get; set; }
        }
    }
}