namespace Humidifier.States
{
    using global::System.Collections.Generic;

    public class Execution : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveInput, IHaveStateMachineArn, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string StartDate =  "StartDate" ;
            public static string RedriveStatus =  "RedriveStatus" ;
            public static string ExecutionArn =  "ExecutionArn" ;
            public static string RedriveCount =  "RedriveCount" ;
            public static string StateMachineName =  "StateMachineName" ;
        }

        public override string AWSTypeName { get => AWS.States.Execution; }
        /// <summary>
        /// Input
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-states-execution.html#cfn-states-execution-input
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Input { get; set; }

        /// <summary>
        /// StateMachineArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-states-execution.html#cfn-states-execution-statemachinearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StateMachineArn { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}