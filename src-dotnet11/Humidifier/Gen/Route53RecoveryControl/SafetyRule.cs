namespace Humidifier.Route53RecoveryControl
{
    using global::System.Collections.Generic;
    using SafetyRuleTypes;

    public class SafetyRule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveControlPanelArn, IHaveRoute53RecoveryControlSafetyRuleTypesAssertionRuleAssertionRule, IHaveRoute53RecoveryControlSafetyRuleTypesRuleConfigRuleConfig, IHaveRoute53RecoveryControlSafetyRuleTypesGatingRuleGatingRule, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string SafetyRuleArn =  "SafetyRuleArn" ;
        }

        public override string AWSTypeName { get => AWS.Route53RecoveryControl.SafetyRule; }

        /// <summary>
        /// ControlPanelArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoverycontrol-safetyrule.html#cfn-route53recoverycontrol-safetyrule-controlpanelarn
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ControlPanelArn { get; set; }
        /// <summary>
        /// AssertionRule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoverycontrol-safetyrule.html#cfn-route53recoverycontrol-safetyrule-assertionrule
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AssertionRule
        /// </summary>
        public Union<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule, BaseFunction>? AssertionRule { get; set; }

        /// <summary>
        /// RuleConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoverycontrol-safetyrule.html#cfn-route53recoverycontrol-safetyrule-ruleconfig
        /// Required: True
        /// UpdateType: Conditional
        /// Type: RuleConfig
        /// </summary>
        [Required]
        public Union<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig, BaseFunction>? RuleConfig { get; set; }
        /// <summary>
        /// GatingRule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoverycontrol-safetyrule.html#cfn-route53recoverycontrol-safetyrule-gatingrule
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GatingRule
        /// </summary>
        public Union<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule, BaseFunction>? GatingRule { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoverycontrol-safetyrule.html#cfn-route53recoverycontrol-safetyrule-tags
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SafetyRuleTypes
    {
        public class AssertionRule : Humidifier.Base.BaseSubResource, IHaveStringListOfAssertedControls, IHaveWaitPeriodMs_Integer
        {
            /// <summary>
            /// AssertedControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoverycontrol-safetyrule-assertionrule.html#cfn-route53recoverycontrol-safetyrule-assertionrule-assertedcontrols
            /// Required: True
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AssertedControls { get; set; }
            /// <summary>
            /// WaitPeriodMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoverycontrol-safetyrule-assertionrule.html#cfn-route53recoverycontrol-safetyrule-assertionrule-waitperiodms
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WaitPeriodMs { get; set; }
        }

        public class GatingRule : Humidifier.Base.BaseSubResource, IHaveStringListOfTargetControls, IHaveStringListOfGatingControls, IHaveWaitPeriodMs_Integer
        {
            /// <summary>
            /// TargetControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoverycontrol-safetyrule-gatingrule.html#cfn-route53recoverycontrol-safetyrule-gatingrule-targetcontrols
            /// Required: True
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TargetControls { get; set; }
            /// <summary>
            /// GatingControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoverycontrol-safetyrule-gatingrule.html#cfn-route53recoverycontrol-safetyrule-gatingrule-gatingcontrols
            /// Required: True
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? GatingControls { get; set; }
            /// <summary>
            /// WaitPeriodMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoverycontrol-safetyrule-gatingrule.html#cfn-route53recoverycontrol-safetyrule-gatingrule-waitperiodms
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WaitPeriodMs { get; set; }
        }

        public class RuleConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveInverted_Boolean, IHaveThreshold_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoverycontrol-safetyrule-ruleconfig.html#cfn-route53recoverycontrol-safetyrule-ruleconfig-type
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Inverted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoverycontrol-safetyrule-ruleconfig.html#cfn-route53recoverycontrol-safetyrule-ruleconfig-inverted
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Inverted { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoverycontrol-safetyrule-ruleconfig.html#cfn-route53recoverycontrol-safetyrule-ruleconfig-threshold
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Threshold { get; set; }
        }
    }
}