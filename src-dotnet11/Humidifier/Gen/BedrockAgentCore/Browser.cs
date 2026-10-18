namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;

    public class Browser : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string BrowserId =  "BrowserId" ;
            public static string Status =  "Status" ;
            public static string BrowserArn =  "BrowserArn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.Browser; }
    }
}