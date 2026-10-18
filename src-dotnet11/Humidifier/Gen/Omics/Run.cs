namespace Humidifier.Omics
{
    using global::System.Collections.Generic;

    public class Run : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRetentionMode, IHaveNetworkingMode, IHaveStorageType, IHaveStorageCapacity_Integer, IHavePriority_Integer, IHaveRunGroupId, IHaveOutputUri, IHaveWorkflowId, IHaveWorkflowOwnerId, IHaveRoleArn, IHaveLogLevel, IHaveName, IHaveWorkflowType, IHaveCacheId, IHaveCacheBehavior
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Uuid =  "Uuid" ;
            public static string StartedBy =  "StartedBy" ;
            public static string StartTime =  "StartTime" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Id =  "Id" ;
            public static string RunOutputUri =  "RunOutputUri" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Omics.Run; }
        /// <summary>
        /// RetentionMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-run.html#cfn-omics-run-retentionmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RetentionMode { get; set; }
        /// <summary>
        /// NetworkingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-run.html#cfn-omics-run-networkingmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkingMode { get; set; }
        /// <summary>
        /// StorageType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-run.html#cfn-omics-run-storagetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StorageType { get; set; }
        /// <summary>
        /// StorageCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-run.html#cfn-omics-run-storagecapacity
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? StorageCapacity { get; set; }
        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-run.html#cfn-omics-run-priority
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Priority { get; set; }
        /// <summary>
        /// RunGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-run.html#cfn-omics-run-rungroupid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RunGroupId { get; set; }

        /// <summary>
        /// OutputUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-run.html#cfn-omics-run-outputuri
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OutputUri { get; set; }
        /// <summary>
        /// WorkflowId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-run.html#cfn-omics-run-workflowid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WorkflowId { get; set; }
        /// <summary>
        /// WorkflowOwnerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-run.html#cfn-omics-run-workflowownerid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WorkflowOwnerId { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-run.html#cfn-omics-run-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// LogLevel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-run.html#cfn-omics-run-loglevel
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LogLevel { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// WorkflowType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-run.html#cfn-omics-run-workflowtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WorkflowType { get; set; }
        /// <summary>
        /// CacheId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-run.html#cfn-omics-run-cacheid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CacheId { get; set; }
        /// <summary>
        /// CacheBehavior
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-run.html#cfn-omics-run-cachebehavior
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CacheBehavior { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-run.html#cfn-omics-run-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}