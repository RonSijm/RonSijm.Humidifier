namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;

    public class HarnessEndpoint : Humidifier.Base.BaseResource, IHaveTags, IHaveTargetVersion, IHaveDescription, IHaveEndpointName, IHaveHarnessId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string HarnessName =  "HarnessName" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string LiveVersion =  "LiveVersion" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.HarnessEndpoint; }
        /// <summary>
        /// TargetVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harnessendpoint.html#cfn-bedrockagentcore-harnessendpoint-targetversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TargetVersion { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harnessendpoint.html#cfn-bedrockagentcore-harnessendpoint-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// EndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harnessendpoint.html#cfn-bedrockagentcore-harnessendpoint-endpointname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EndpointName { get; set; }

        /// <summary>
        /// HarnessId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harnessendpoint.html#cfn-bedrockagentcore-harnessendpoint-harnessid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? HarnessId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harnessendpoint.html#cfn-bedrockagentcore-harnessendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}