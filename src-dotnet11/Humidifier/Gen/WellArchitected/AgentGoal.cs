namespace Humidifier.WellArchitected
{
    using global::System.Collections.Generic;

    public class AgentGoal : Humidifier.Base.BaseResource, IHaveDescription, IHaveTitle, IHaveStringListOfPillars, IHaveProfileArn
    {
        public class Attributes
        {
            public static string LastModifiedBy =  "LastModifiedBy" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string LastModifiedAt =  "LastModifiedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.WellArchitected.AgentGoal; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentgoal.html#cfn-wellarchitected-agentgoal-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Title
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentgoal.html#cfn-wellarchitected-agentgoal-title
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Title { get; set; }

        /// <summary>
        /// Pillars
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentgoal.html#cfn-wellarchitected-agentgoal-pillars
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Pillars { get; set; }

        /// <summary>
        /// ProfileArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentgoal.html#cfn-wellarchitected-agentgoal-profilearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProfileArn { get; set; }
    }
}