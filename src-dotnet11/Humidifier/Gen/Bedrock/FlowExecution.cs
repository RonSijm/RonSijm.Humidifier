namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;

    public class FlowExecution : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveFlowAliasIdentifier, IHaveFlowIdentifier, IHaveFlowExecutionName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string FlowVersion =  "FlowVersion" ;
            public static string ExecutionArn =  "ExecutionArn" ;
            public static string StartedAt =  "StartedAt" ;
            public static string EndedAt =  "EndedAt" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.FlowExecution; }
        /// <summary>
        /// FlowAliasIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flowexecution.html#cfn-bedrock-flowexecution-flowaliasidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FlowAliasIdentifier { get; set; }
        /// <summary>
        /// FlowIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-flowexecution.html#cfn-bedrock-flowexecution-flowidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FlowIdentifier { get; set; }
        public Union<string, BaseFunction>? FlowExecutionName { get => GivenName; set => GivenName = value; }
    }
}