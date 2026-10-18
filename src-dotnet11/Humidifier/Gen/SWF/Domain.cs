namespace Humidifier.SWF
{
    using global::System.Collections.Generic;

    public class Domain : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Description =  "Description" ;
            public static string Arn =  "Arn" ;
            public static string WorkflowExecutionRetentionPeriodInDays =  "WorkflowExecutionRetentionPeriodInDays" ;
            public static string Tags =  "Tags" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.SWF.Domain; }
    }
}