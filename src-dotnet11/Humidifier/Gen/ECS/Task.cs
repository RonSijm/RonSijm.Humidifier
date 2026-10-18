namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using TaskTypes;

    public class Task : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string LastStatus =  "LastStatus" ;
            public static string Group =  "Group" ;
            public static string TaskId =  "TaskId" ;
            public static string Memory =  "Memory" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Cluster =  "Cluster" ;
            public static string Cpu =  "Cpu" ;
            public static string LaunchType =  "LaunchType" ;
            public static string TaskArn =  "TaskArn" ;
            public static string TaskDefinition =  "TaskDefinition" ;
            public static string StartedBy =  "StartedBy" ;
            public static string DesiredStatus =  "DesiredStatus" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.ECS.Task; }
    }

    namespace TaskTypes
    {
        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-task-tagsitems.html#cfn-ecs-task-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-task-tagsitems.html#cfn-ecs-task-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}