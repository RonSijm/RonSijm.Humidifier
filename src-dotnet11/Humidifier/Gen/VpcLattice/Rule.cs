namespace Humidifier.VpcLattice
{
    using global::System.Collections.Generic;
    using RuleTypes;

    public class Rule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveVpcLatticeRuleTypesActionAction, IHavePriority_Integer, IHaveServiceIdentifier, IHaveListenerIdentifier, IHaveVpcLatticeRuleTypesMatchMatch, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.VpcLattice.Rule; }

        /// <summary>
        /// Action
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-rule.html#cfn-vpclattice-rule-action
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Action
        /// </summary>
        [Required]
        public Union<Humidifier.VpcLattice.RuleTypes.Action, BaseFunction>? Action { get; set; }

        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-rule.html#cfn-vpclattice-rule-priority
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Priority { get; set; }
        /// <summary>
        /// ServiceIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-rule.html#cfn-vpclattice-rule-serviceidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServiceIdentifier { get; set; }
        /// <summary>
        /// ListenerIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-rule.html#cfn-vpclattice-rule-listeneridentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ListenerIdentifier { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-rule.html#cfn-vpclattice-rule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// Match
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-rule.html#cfn-vpclattice-rule-match
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Match
        /// </summary>
        [Required]
        public Union<Humidifier.VpcLattice.RuleTypes.Match, BaseFunction>? Match { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RuleTypes
    {
        public class Action : Humidifier.Base.BaseSubResource, IHaveVpcLatticeRuleTypesForwardForward, IHaveVpcLatticeRuleTypesFixedResponseFixedResponse
        {
            /// <summary>
            /// Forward
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-action.html#cfn-vpclattice-rule-action-forward
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Forward
            /// </summary>
            public Union<Humidifier.VpcLattice.RuleTypes.Forward, BaseFunction>? Forward { get; set; }
            /// <summary>
            /// FixedResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-action.html#cfn-vpclattice-rule-action-fixedresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FixedResponse
            /// </summary>
            public Union<Humidifier.VpcLattice.RuleTypes.FixedResponse, BaseFunction>? FixedResponse { get; set; }
        }

        public class FixedResponse : Humidifier.Base.BaseSubResource, IHaveStatusCode_Integer
        {
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-fixedresponse.html#cfn-vpclattice-rule-fixedresponse-statuscode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StatusCode { get; set; }
        }

        public class Forward : Humidifier.Base.BaseSubResource, IHaveListOfVpcLatticeRuleTypesWeightedTargetGroupTargetGroups
        {
            /// <summary>
            /// TargetGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-forward.html#cfn-vpclattice-rule-forward-targetgroups
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WeightedTargetGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.VpcLattice.RuleTypes.WeightedTargetGroup>, IReadOnlyList<Union<Humidifier.VpcLattice.RuleTypes.WeightedTargetGroup, BaseFunction>>, BaseFunction>? TargetGroups { get; set; }
        }

        public class HeaderMatch : Humidifier.Base.BaseSubResource, IHaveCaseSensitive_Boolean, IHaveName, IHaveVpcLatticeRuleTypesHeaderMatchTypeMatch
        {
            /// <summary>
            /// CaseSensitive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-headermatch.html#cfn-vpclattice-rule-headermatch-casesensitive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CaseSensitive { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-headermatch.html#cfn-vpclattice-rule-headermatch-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-headermatch.html#cfn-vpclattice-rule-headermatch-match
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HeaderMatchType
            /// </summary>
            public Union<Humidifier.VpcLattice.RuleTypes.HeaderMatchType, BaseFunction>? Match { get; set; }
        }

        public class HeaderMatchType : Humidifier.Base.BaseSubResource, IHaveContains, IHaveExact, IHavePrefix
        {
            /// <summary>
            /// Contains
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-headermatchtype.html#cfn-vpclattice-rule-headermatchtype-contains
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Contains { get; set; }
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-headermatchtype.html#cfn-vpclattice-rule-headermatchtype-exact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Exact { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-headermatchtype.html#cfn-vpclattice-rule-headermatchtype-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class HttpMatch : Humidifier.Base.BaseSubResource, IHaveListOfVpcLatticeRuleTypesHeaderMatchHeaderMatches, IHaveVpcLatticeRuleTypesPathMatchPathMatch, IHaveMethod
        {
            /// <summary>
            /// HeaderMatches
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-httpmatch.html#cfn-vpclattice-rule-httpmatch-headermatches
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HeaderMatch
            /// </summary>
            public Union<IReadOnlyList<Humidifier.VpcLattice.RuleTypes.HeaderMatch>, IReadOnlyList<Union<Humidifier.VpcLattice.RuleTypes.HeaderMatch, BaseFunction>>, BaseFunction>? HeaderMatches { get; set; }
            /// <summary>
            /// PathMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-httpmatch.html#cfn-vpclattice-rule-httpmatch-pathmatch
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PathMatch
            /// </summary>
            public Union<Humidifier.VpcLattice.RuleTypes.PathMatch, BaseFunction>? PathMatch { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-httpmatch.html#cfn-vpclattice-rule-httpmatch-method
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Method { get; set; }
        }

        public class Match : Humidifier.Base.BaseSubResource, IHaveVpcLatticeRuleTypesHttpMatchHttpMatch
        {
            /// <summary>
            /// HttpMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-match.html#cfn-vpclattice-rule-match-httpmatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HttpMatch
            /// </summary>
            public Union<Humidifier.VpcLattice.RuleTypes.HttpMatch, BaseFunction>? HttpMatch { get; set; }
        }

        public class PathMatch : Humidifier.Base.BaseSubResource, IHaveCaseSensitive_Boolean, IHaveVpcLatticeRuleTypesPathMatchTypeMatch
        {
            /// <summary>
            /// CaseSensitive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-pathmatch.html#cfn-vpclattice-rule-pathmatch-casesensitive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CaseSensitive { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-pathmatch.html#cfn-vpclattice-rule-pathmatch-match
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PathMatchType
            /// </summary>
            public Union<Humidifier.VpcLattice.RuleTypes.PathMatchType, BaseFunction>? Match { get; set; }
        }

        public class PathMatchType : Humidifier.Base.BaseSubResource, IHaveExact, IHavePrefix
        {
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-pathmatchtype.html#cfn-vpclattice-rule-pathmatchtype-exact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Exact { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-pathmatchtype.html#cfn-vpclattice-rule-pathmatchtype-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class WeightedTargetGroup : Humidifier.Base.BaseSubResource, IHaveWeight_Integer, IHaveTargetGroupIdentifier
        {
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-weightedtargetgroup.html#cfn-vpclattice-rule-weightedtargetgroup-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
            /// <summary>
            /// TargetGroupIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-rule-weightedtargetgroup.html#cfn-vpclattice-rule-weightedtargetgroup-targetgroupidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetGroupIdentifier { get; set; }
        }
    }
}