namespace Humidifier.Rbin
{
    using global::System.Collections.Generic;
    using RuleTypes;

    public class Rule : Humidifier.Base.BaseResource, IHaveTags, IHaveStatus, IHaveDescription, IHaveListOfRbinRuleTypesResourceTagResourceTags, IHaveRbinRuleTypesUnlockDelayLockConfiguration, IHaveListOfRbinRuleTypesResourceTagExcludeResourceTags, IHaveResourceType, IHaveRbinRuleTypesRetentionPeriodRetentionPeriod
    {
        public class Attributes
        {
            public static string Identifier =  "Identifier" ;
            public static string Arn =  "Arn" ;
            public static string LockState =  "LockState" ;
        }

        public override string AWSTypeName { get => AWS.Rbin.Rule; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rbin-rule.html#cfn-rbin-rule-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rbin-rule.html#cfn-rbin-rule-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ResourceTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rbin-rule.html#cfn-rbin-rule-resourcetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Rbin.RuleTypes.ResourceTag>, IReadOnlyList<Union<Humidifier.Rbin.RuleTypes.ResourceTag, BaseFunction>>, BaseFunction>? ResourceTags { get; set; }
        /// <summary>
        /// LockConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rbin-rule.html#cfn-rbin-rule-lockconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UnlockDelay
        /// </summary>
        public Union<Humidifier.Rbin.RuleTypes.UnlockDelay, BaseFunction>? LockConfiguration { get; set; }
        /// <summary>
        /// ExcludeResourceTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rbin-rule.html#cfn-rbin-rule-excluderesourcetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Rbin.RuleTypes.ResourceTag>, IReadOnlyList<Union<Humidifier.Rbin.RuleTypes.ResourceTag, BaseFunction>>, BaseFunction>? ExcludeResourceTags { get; set; }

        /// <summary>
        /// ResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rbin-rule.html#cfn-rbin-rule-resourcetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceType { get; set; }

        /// <summary>
        /// RetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rbin-rule.html#cfn-rbin-rule-retentionperiod
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RetentionPeriod
        /// </summary>
        [Required]
        public Union<Humidifier.Rbin.RuleTypes.RetentionPeriod, BaseFunction>? RetentionPeriod { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rbin-rule.html#cfn-rbin-rule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace RuleTypes
    {
        public class ResourceTag : Humidifier.Base.BaseSubResource, IHaveResourceTagValue, IHaveResourceTagKey
        {
            /// <summary>
            /// ResourceTagValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rbin-rule-resourcetag.html#cfn-rbin-rule-resourcetag-resourcetagvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceTagValue { get; set; }
            /// <summary>
            /// ResourceTagKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rbin-rule-resourcetag.html#cfn-rbin-rule-resourcetag-resourcetagkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceTagKey { get; set; }
        }

        public class RetentionPeriod : Humidifier.Base.BaseSubResource, IHaveRetentionPeriodUnit, IHaveRetentionPeriodValue_Integer
        {
            /// <summary>
            /// RetentionPeriodUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rbin-rule-retentionperiod.html#cfn-rbin-rule-retentionperiod-retentionperiodunit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RetentionPeriodUnit { get; set; }
            /// <summary>
            /// RetentionPeriodValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rbin-rule-retentionperiod.html#cfn-rbin-rule-retentionperiod-retentionperiodvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RetentionPeriodValue { get; set; }
        }

        public class UnlockDelay : Humidifier.Base.BaseSubResource, IHaveUnlockDelayValue_Integer, IHaveUnlockDelayUnit
        {
            /// <summary>
            /// UnlockDelayValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rbin-rule-unlockdelay.html#cfn-rbin-rule-unlockdelay-unlockdelayvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UnlockDelayValue { get; set; }
            /// <summary>
            /// UnlockDelayUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rbin-rule-unlockdelay.html#cfn-rbin-rule-unlockdelay-unlockdelayunit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnlockDelayUnit { get; set; }
        }
    }
}