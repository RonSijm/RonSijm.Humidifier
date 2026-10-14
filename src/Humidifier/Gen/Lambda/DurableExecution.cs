namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;

    public class DurableExecution : Humidifier.Base.BaseResource, IHaveFunctionName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string DurableExecutionName =  "DurableExecutionName" ;
            public static string FunctionArn =  "FunctionArn" ;
            public static string StartTimestamp =  "StartTimestamp" ;
            public static string Version =  "Version" ;
            public static string DurableExecutionArn =  "DurableExecutionArn" ;
            public static string EndTimestamp =  "EndTimestamp" ;
        }

        public override string AWSTypeName { get => AWS.Lambda.DurableExecution; }
        /// <summary>
        /// FunctionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-durableexecution.html#cfn-lambda-durableexecution-functionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FunctionName { get; set; }
    }
}