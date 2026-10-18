namespace Humidifier.GuardDuty
{
    using global::System.Collections.Generic;
    using CustomDetectionRuleAssociationTypes;

    public class CustomDetectionRuleAssociation : Humidifier.Base.BaseResource, IHaveRuleId, IHaveMode, IHaveListOfGuardDutyCustomDetectionRuleAssociationTypesTagItemTags
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string AssociationId =  "AssociationId" ;
        }

        public override string AWSTypeName { get => AWS.GuardDuty.CustomDetectionRuleAssociation; }

        /// <summary>
        /// RuleId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-customdetectionruleassociation.html#cfn-guardduty-customdetectionruleassociation-ruleid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuleId { get; set; }

        /// <summary>
        /// Mode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-customdetectionruleassociation.html#cfn-guardduty-customdetectionruleassociation-mode
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Mode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-customdetectionruleassociation.html#cfn-guardduty-customdetectionruleassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagItem
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem>, IReadOnlyList<Union<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace CustomDetectionRuleAssociationTypes
    {
        public class TagItem : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-customdetectionruleassociation-tagitem.html#cfn-guardduty-customdetectionruleassociation-tagitem-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-customdetectionruleassociation-tagitem.html#cfn-guardduty-customdetectionruleassociation-tagitem-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}