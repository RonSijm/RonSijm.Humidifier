namespace Humidifier.SSM
{
    using global::System.Collections.Generic;
    using PatchBaselineTypes;

    public class PatchBaseline : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveOperatingSystem, IHaveDescription, IHaveSSMPatchBaselineTypesRuleGroupApprovalRules, IHaveListOfSSMPatchBaselineTypesPatchSourceSources, IHaveName, IHaveStringListOfRejectedPatches, IHaveStringListOfApprovedPatches, IHaveRejectedPatchesAction, IHaveStringListOfPatchGroups, IHaveApprovedPatchesComplianceLevel, IHaveAvailableSecurityUpdatesComplianceStatus, IHaveApprovedPatchesEnableNonSecurity_Boolean, IHaveDefaultBaseline_Boolean, IHaveSSMPatchBaselineTypesPatchFilterGroupGlobalFilters
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.SSM.PatchBaseline; }
        /// <summary>
        /// OperatingSystem
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-operatingsystem
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OperatingSystem { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ApprovalRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-approvalrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RuleGroup
        /// </summary>
        public Union<Humidifier.SSM.PatchBaselineTypes.RuleGroup, BaseFunction>? ApprovalRules { get; set; }
        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-sources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PatchSource
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SSM.PatchBaselineTypes.PatchSource>, IReadOnlyList<Union<Humidifier.SSM.PatchBaselineTypes.PatchSource, BaseFunction>>, BaseFunction>? Sources { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// RejectedPatches
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-rejectedpatches
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RejectedPatches { get; set; }
        /// <summary>
        /// ApprovedPatches
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-approvedpatches
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ApprovedPatches { get; set; }
        /// <summary>
        /// RejectedPatchesAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-rejectedpatchesaction
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RejectedPatchesAction { get; set; }
        /// <summary>
        /// PatchGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-patchgroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PatchGroups { get; set; }
        /// <summary>
        /// ApprovedPatchesComplianceLevel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-approvedpatchescompliancelevel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ApprovedPatchesComplianceLevel { get; set; }
        /// <summary>
        /// AvailableSecurityUpdatesComplianceStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-availablesecurityupdatescompliancestatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailableSecurityUpdatesComplianceStatus { get; set; }
        /// <summary>
        /// ApprovedPatchesEnableNonSecurity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-approvedpatchesenablenonsecurity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ApprovedPatchesEnableNonSecurity { get; set; }
        /// <summary>
        /// DefaultBaseline
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-defaultbaseline
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DefaultBaseline { get; set; }
        /// <summary>
        /// GlobalFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-globalfilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PatchFilterGroup
        /// </summary>
        public Union<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup, BaseFunction>? GlobalFilters { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PatchBaselineTypes
    {
        public class PatchFilter : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveKey
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-patchfilter.html#cfn-ssm-patchbaseline-patchfilter-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-patchfilter.html#cfn-ssm-patchbaseline-patchfilter-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class PatchFilterGroup : Humidifier.Base.BaseSubResource, IHaveListOfSSMPatchBaselineTypesPatchFilterPatchFilters
        {
            /// <summary>
            /// PatchFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-patchfiltergroup.html#cfn-ssm-patchbaseline-patchfiltergroup-patchfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PatchFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SSM.PatchBaselineTypes.PatchFilter>, IReadOnlyList<Union<Humidifier.SSM.PatchBaselineTypes.PatchFilter, BaseFunction>>, BaseFunction>? PatchFilters { get; set; }
        }

        public class PatchSource : Humidifier.Base.BaseSubResource, IHaveStringListOfProducts, IHaveConfiguration, IHaveName
        {
            /// <summary>
            /// Products
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-patchsource.html#cfn-ssm-patchbaseline-patchsource-products
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Products { get; set; }
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-patchsource.html#cfn-ssm-patchbaseline-patchsource-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Configuration { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-patchsource.html#cfn-ssm-patchbaseline-patchsource-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveApproveUntilDate, IHaveEnableNonSecurity_Boolean, IHaveSSMPatchBaselineTypesPatchFilterGroupPatchFilterGroup, IHaveApproveAfterDays_Integer, IHaveComplianceLevel
        {
            /// <summary>
            /// ApproveUntilDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html#cfn-ssm-patchbaseline-rule-approveuntildate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApproveUntilDate { get; set; }
            /// <summary>
            /// EnableNonSecurity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html#cfn-ssm-patchbaseline-rule-enablenonsecurity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableNonSecurity { get; set; }
            /// <summary>
            /// PatchFilterGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html#cfn-ssm-patchbaseline-rule-patchfiltergroup
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PatchFilterGroup
            /// </summary>
            public Union<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup, BaseFunction>? PatchFilterGroup { get; set; }
            /// <summary>
            /// ApproveAfterDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html#cfn-ssm-patchbaseline-rule-approveafterdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ApproveAfterDays { get; set; }
            /// <summary>
            /// ComplianceLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html#cfn-ssm-patchbaseline-rule-compliancelevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComplianceLevel { get; set; }
        }

        public class RuleGroup : Humidifier.Base.BaseSubResource, IHaveListOfSSMPatchBaselineTypesRulePatchRules
        {
            /// <summary>
            /// PatchRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rulegroup.html#cfn-ssm-patchbaseline-rulegroup-patchrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Rule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SSM.PatchBaselineTypes.Rule>, IReadOnlyList<Union<Humidifier.SSM.PatchBaselineTypes.Rule, BaseFunction>>, BaseFunction>? PatchRules { get; set; }
        }
    }
}