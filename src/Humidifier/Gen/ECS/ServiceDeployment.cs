namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using ServiceDeploymentTypes;

    public class ServiceDeployment : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string ClusterArn =  "ClusterArn" ;
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Cluster =  "Cluster" ;
            public static string Service =  "Service" ;
            public static string ServiceArn =  "ServiceArn" ;
            public static string ServiceDeploymentArn =  "ServiceDeploymentArn" ;
            public static string TargetServiceRevision =  "TargetServiceRevision" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string ServiceDeploymentId =  "ServiceDeploymentId" ;
        }

        public override string AWSTypeName { get => AWS.ECS.ServiceDeployment; }
    }

    namespace ServiceDeploymentTypes
    {
        public class ServiceRevisionSummary : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// RequestedTaskCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicedeployment-servicerevisionsummary.html#cfn-ecs-servicedeployment-servicerevisionsummary-requestedtaskcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RequestedTaskCount { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicedeployment-servicerevisionsummary.html#cfn-ecs-servicedeployment-servicerevisionsummary-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// RunningTaskCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicedeployment-servicerevisionsummary.html#cfn-ecs-servicedeployment-servicerevisionsummary-runningtaskcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RunningTaskCount { get; set; }
            /// <summary>
            /// PendingTaskCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicedeployment-servicerevisionsummary.html#cfn-ecs-servicedeployment-servicerevisionsummary-pendingtaskcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PendingTaskCount { get; set; }
        }
    }
}