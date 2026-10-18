namespace Humidifier.GameLift
{
    using global::System.Collections.Generic;

    public class MatchmakingRuleSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRuleSetBody, IHaveName
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.GameLift.MatchmakingRuleSet; }

        /// <summary>
        /// RuleSetBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-matchmakingruleset.html#cfn-gamelift-matchmakingruleset-rulesetbody
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuleSetBody { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-matchmakingruleset.html#cfn-gamelift-matchmakingruleset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}