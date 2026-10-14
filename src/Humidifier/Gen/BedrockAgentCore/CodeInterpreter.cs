namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;

    public class CodeInterpreter : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CodeInterpreterArn =  "CodeInterpreterArn" ;
            public static string CodeInterpreterId =  "CodeInterpreterId" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.CodeInterpreter; }
    }
}