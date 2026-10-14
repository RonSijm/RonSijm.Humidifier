namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;

    public class BrowserProfile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription
    {
        public class Attributes
        {
            public static string ProfileId =  "ProfileId" ;
            public static string Status =  "Status" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ProfileArn =  "ProfileArn" ;
            public static string LastSavedAt =  "LastSavedAt" ;
            public static string LastSavedBrowserId =  "LastSavedBrowserId" ;
            public static string LastSavedBrowserSessionId =  "LastSavedBrowserSessionId" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.BrowserProfile; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-browserprofile.html#cfn-bedrockagentcore-browserprofile-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-browserprofile.html#cfn-bedrockagentcore-browserprofile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}