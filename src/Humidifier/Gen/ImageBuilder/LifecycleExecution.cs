namespace Humidifier.ImageBuilder
{
    using global::System.Collections.Generic;
    using LifecycleExecutionTypes;

    public class LifecycleExecution : Humidifier.Base.BaseResource, IHaveResourceArn
    {
        public class Attributes
        {
            public static string EndTime =  "EndTime" ;
            public static string State =  "State" ;
            public static string LifecycleExecutionId =  "LifecycleExecutionId" ;
            public static string StartTime =  "StartTime" ;
            public static string Arn =  "Arn" ;
            public static string ResourcesImpactedSummary =  "ResourcesImpactedSummary" ;
        }

        public override string AWSTypeName { get => AWS.ImageBuilder.LifecycleExecution; }
        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-lifecycleexecution.html#cfn-imagebuilder-lifecycleexecution-resourcearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceArn { get; set; }
    }

    namespace LifecycleExecutionTypes
    {
        public class LifecycleExecutionResourcesImpactedSummary : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HasImpactedResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-lifecycleexecution-lifecycleexecutionresourcesimpactedsummary.html#cfn-imagebuilder-lifecycleexecution-lifecycleexecutionresourcesimpactedsummary-hasimpactedresources
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic HasImpactedResources { get; set; }
        }

        public class LifecycleExecutionState : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-lifecycleexecution-lifecycleexecutionstate.html#cfn-imagebuilder-lifecycleexecution-lifecycleexecutionstate-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
        }
    }
}