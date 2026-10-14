namespace Humidifier.WellArchitected
{
    using global::System.Collections.Generic;

    public class AgentContext : Humidifier.Base.BaseResource, IHaveTitle, IHaveContent
    {
        public class Attributes
        {
            public static string ApplicationType =  "ApplicationType" ;
            public static string LastModifiedBy =  "LastModifiedBy" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string LastModifiedAt =  "LastModifiedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string Criticality =  "Criticality" ;
        }

        public override string AWSTypeName { get => AWS.WellArchitected.AgentContext; }

        /// <summary>
        /// ContextType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentcontext.html#cfn-wellarchitected-agentcontext-contexttype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ContextType { get; set; }

        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentcontext.html#cfn-wellarchitected-agentcontext-content
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public dynamic Content { get; set; }

        /// <summary>
        /// Title
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentcontext.html#cfn-wellarchitected-agentcontext-title
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Title { get; set; }

        /// <summary>
        /// ProfileArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentcontext.html#cfn-wellarchitected-agentcontext-profilearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ProfileArn { get; set; }
    }
}