namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;

    public class WorkloadIdentity : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStringListOfAllowedResourceOauth2ReturnUrls, IHaveName
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string WorkloadIdentityArn =  "WorkloadIdentityArn" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.WorkloadIdentity; }
        /// <summary>
        /// AllowedResourceOauth2ReturnUrls
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-workloadidentity.html#cfn-bedrockagentcore-workloadidentity-allowedresourceoauth2returnurls
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedResourceOauth2ReturnUrls { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-workloadidentity.html#cfn-bedrockagentcore-workloadidentity-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}