namespace Humidifier.Omics
{
    using global::System.Collections.Generic;

    public class Task : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string TaskId =  "TaskId" ;
            public static string Memory =  "Memory" ;
            public static string Gpus =  "Gpus" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Cpus =  "Cpus" ;
            public static string LogStream =  "LogStream" ;
            public static string Arn =  "Arn" ;
            public static string InstanceType =  "InstanceType" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Omics.Task; }
        /// <summary>
        /// RunId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-task.html#cfn-omics-task-runid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RunId { get; set; }
    }
}