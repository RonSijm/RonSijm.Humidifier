namespace Humidifier.CleanRooms
{
    using global::System.Collections.Generic;
    using ConfiguredTableAssociationTypes;

    public class ConfiguredTableAssociation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMembershipIdentifier, IHaveDescription, IHaveListOfCleanRoomsConfiguredTableAssociationTypesConfiguredTableAssociationAnalysisRuleConfiguredTableAssociationAnalysisRules, IHaveConfiguredTableIdentifier, IHaveRoleArn, IHaveName
    {
        public class Attributes
        {
            public static string ConfiguredTableAssociationIdentifier =  "ConfiguredTableAssociationIdentifier" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CleanRooms.ConfiguredTableAssociation; }

        /// <summary>
        /// MembershipIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-configuredtableassociation.html#cfn-cleanrooms-configuredtableassociation-membershipidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MembershipIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-configuredtableassociation.html#cfn-cleanrooms-configuredtableassociation-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ConfiguredTableAssociationAnalysisRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-configuredtableassociation.html#cfn-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ConfiguredTableAssociationAnalysisRule
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule>, IReadOnlyList<Union<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule, BaseFunction>>, BaseFunction>? ConfiguredTableAssociationAnalysisRules { get; set; }

        /// <summary>
        /// ConfiguredTableIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-configuredtableassociation.html#cfn-cleanrooms-configuredtableassociation-configuredtableidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConfiguredTableIdentifier { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-configuredtableassociation.html#cfn-cleanrooms-configuredtableassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-configuredtableassociation.html#cfn-cleanrooms-configuredtableassociation-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConfiguredTableAssociationTypes
    {
        public class ConfiguredTableAssociationAnalysisRule : Humidifier.Base.BaseSubResource, IHaveCleanRoomsConfiguredTableAssociationTypesConfiguredTableAssociationAnalysisRulePolicyPolicy, IHaveType
        {
            /// <summary>
            /// Policy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrule.html#cfn-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrule-policy
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConfiguredTableAssociationAnalysisRulePolicy
            /// </summary>
            public Union<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy, BaseFunction>? Policy { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrule.html#cfn-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrule-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class ConfiguredTableAssociationAnalysisRuleAggregation : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedResultReceivers, IHaveStringListOfAllowedAdditionalAnalyses
        {
            /// <summary>
            /// AllowedResultReceivers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtableassociation-configuredtableassociationanalysisruleaggregation.html#cfn-cleanrooms-configuredtableassociation-configuredtableassociationanalysisruleaggregation-allowedresultreceivers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedResultReceivers { get; set; }
            /// <summary>
            /// AllowedAdditionalAnalyses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtableassociation-configuredtableassociationanalysisruleaggregation.html#cfn-cleanrooms-configuredtableassociation-configuredtableassociationanalysisruleaggregation-allowedadditionalanalyses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedAdditionalAnalyses { get; set; }
        }

        public class ConfiguredTableAssociationAnalysisRuleCustom : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedResultReceivers, IHaveStringListOfAllowedAdditionalAnalyses
        {
            /// <summary>
            /// AllowedResultReceivers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrulecustom.html#cfn-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrulecustom-allowedresultreceivers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedResultReceivers { get; set; }
            /// <summary>
            /// AllowedAdditionalAnalyses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrulecustom.html#cfn-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrulecustom-allowedadditionalanalyses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedAdditionalAnalyses { get; set; }
        }

        public class ConfiguredTableAssociationAnalysisRuleList : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedResultReceivers, IHaveStringListOfAllowedAdditionalAnalyses
        {
            /// <summary>
            /// AllowedResultReceivers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrulelist.html#cfn-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrulelist-allowedresultreceivers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedResultReceivers { get; set; }
            /// <summary>
            /// AllowedAdditionalAnalyses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrulelist.html#cfn-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrulelist-allowedadditionalanalyses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedAdditionalAnalyses { get; set; }
        }

        public class ConfiguredTableAssociationAnalysisRulePolicy : Humidifier.Base.BaseSubResource, IHaveCleanRoomsConfiguredTableAssociationTypesConfiguredTableAssociationAnalysisRulePolicyV1V1
        {
            /// <summary>
            /// V1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrulepolicy.html#cfn-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrulepolicy-v1
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConfiguredTableAssociationAnalysisRulePolicyV1
            /// </summary>
            public Union<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicyV1, BaseFunction>? V1 { get; set; }
        }

        public class ConfiguredTableAssociationAnalysisRulePolicyV1 : Humidifier.Base.BaseSubResource, IHaveCleanRoomsConfiguredTableAssociationTypesConfiguredTableAssociationAnalysisRuleAggregationAggregation, IHaveCleanRoomsConfiguredTableAssociationTypesConfiguredTableAssociationAnalysisRuleListList, IHaveCleanRoomsConfiguredTableAssociationTypesConfiguredTableAssociationAnalysisRuleCustomCustom
        {
            /// <summary>
            /// Aggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrulepolicyv1.html#cfn-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrulepolicyv1-aggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfiguredTableAssociationAnalysisRuleAggregation
            /// </summary>
            public Union<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleAggregation, BaseFunction>? Aggregation { get; set; }
            /// <summary>
            /// List
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrulepolicyv1.html#cfn-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrulepolicyv1-list
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfiguredTableAssociationAnalysisRuleList
            /// </summary>
            public Union<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleList, BaseFunction>? List { get; set; }
            /// <summary>
            /// Custom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrulepolicyv1.html#cfn-cleanrooms-configuredtableassociation-configuredtableassociationanalysisrulepolicyv1-custom
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfiguredTableAssociationAnalysisRuleCustom
            /// </summary>
            public Union<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleCustom, BaseFunction>? Custom { get; set; }
        }
    }
}