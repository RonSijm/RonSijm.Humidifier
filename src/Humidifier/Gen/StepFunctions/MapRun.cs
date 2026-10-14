namespace Humidifier.StepFunctions
{
    using global::System.Collections.Generic;
    using MapRunTypes;

    public class MapRun : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string ExecutionCounts =  "ExecutionCounts" ;
            public static string ToleratedFailureCount =  "ToleratedFailureCount" ;
            public static string StartDate =  "StartDate" ;
            public static string ToleratedFailurePercentage =  "ToleratedFailurePercentage" ;
            public static string MapRunArn =  "MapRunArn" ;
            public static string Status =  "Status" ;
            public static string MaxConcurrency =  "MaxConcurrency" ;
            public static string ItemCounts =  "ItemCounts" ;
            public static string StopDate =  "StopDate" ;
        }

        public override string AWSTypeName { get => AWS.StepFunctions.MapRun; }
        /// <summary>
        /// ExecutionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-maprun.html#cfn-stepfunctions-maprun-executionarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExecutionArn { get; set; }
    }

    namespace MapRunTypes
    {
        public class MapRunExecutionCounts : Humidifier.Base.BaseSubResource, IHaveTotal
        {
            /// <summary>
            /// Succeeded
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunexecutioncounts.html#cfn-stepfunctions-maprun-maprunexecutioncounts-succeeded
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Succeeded { get; set; }
            /// <summary>
            /// Failed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunexecutioncounts.html#cfn-stepfunctions-maprun-maprunexecutioncounts-failed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Failed { get; set; }
            /// <summary>
            /// Total
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunexecutioncounts.html#cfn-stepfunctions-maprun-maprunexecutioncounts-total
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Total { get; set; }
            /// <summary>
            /// Running
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunexecutioncounts.html#cfn-stepfunctions-maprun-maprunexecutioncounts-running
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Running { get; set; }
            /// <summary>
            /// TimedOut
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunexecutioncounts.html#cfn-stepfunctions-maprun-maprunexecutioncounts-timedout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimedOut { get; set; }
            /// <summary>
            /// ResultsWritten
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunexecutioncounts.html#cfn-stepfunctions-maprun-maprunexecutioncounts-resultswritten
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ResultsWritten { get; set; }
            /// <summary>
            /// FailuresNotRedrivable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunexecutioncounts.html#cfn-stepfunctions-maprun-maprunexecutioncounts-failuresnotredrivable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FailuresNotRedrivable { get; set; }
            /// <summary>
            /// PendingRedrive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunexecutioncounts.html#cfn-stepfunctions-maprun-maprunexecutioncounts-pendingredrive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PendingRedrive { get; set; }
            /// <summary>
            /// Pending
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunexecutioncounts.html#cfn-stepfunctions-maprun-maprunexecutioncounts-pending
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Pending { get; set; }
            /// <summary>
            /// Aborted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunexecutioncounts.html#cfn-stepfunctions-maprun-maprunexecutioncounts-aborted
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Aborted { get; set; }
        }

        public class MapRunItemCounts : Humidifier.Base.BaseSubResource, IHaveTotal
        {
            /// <summary>
            /// Succeeded
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunitemcounts.html#cfn-stepfunctions-maprun-maprunitemcounts-succeeded
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Succeeded { get; set; }
            /// <summary>
            /// Failed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunitemcounts.html#cfn-stepfunctions-maprun-maprunitemcounts-failed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Failed { get; set; }
            /// <summary>
            /// Total
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunitemcounts.html#cfn-stepfunctions-maprun-maprunitemcounts-total
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Total { get; set; }
            /// <summary>
            /// Running
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunitemcounts.html#cfn-stepfunctions-maprun-maprunitemcounts-running
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Running { get; set; }
            /// <summary>
            /// TimedOut
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunitemcounts.html#cfn-stepfunctions-maprun-maprunitemcounts-timedout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimedOut { get; set; }
            /// <summary>
            /// ResultsWritten
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunitemcounts.html#cfn-stepfunctions-maprun-maprunitemcounts-resultswritten
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ResultsWritten { get; set; }
            /// <summary>
            /// FailuresNotRedrivable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunitemcounts.html#cfn-stepfunctions-maprun-maprunitemcounts-failuresnotredrivable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FailuresNotRedrivable { get; set; }
            /// <summary>
            /// PendingRedrive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunitemcounts.html#cfn-stepfunctions-maprun-maprunitemcounts-pendingredrive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PendingRedrive { get; set; }
            /// <summary>
            /// Pending
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunitemcounts.html#cfn-stepfunctions-maprun-maprunitemcounts-pending
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Pending { get; set; }
            /// <summary>
            /// Aborted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-maprun-maprunitemcounts.html#cfn-stepfunctions-maprun-maprunitemcounts-aborted
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Aborted { get; set; }
        }
    }
}