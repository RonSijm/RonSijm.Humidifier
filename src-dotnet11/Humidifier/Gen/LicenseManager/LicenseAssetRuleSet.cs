namespace Humidifier.LicenseManager
{
    using global::System.Collections.Generic;
    using LicenseAssetRuleSetTypes;

    public class LicenseAssetRuleSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveListOfLicenseManagerLicenseAssetRuleSetTypesLicenseAssetRuleRules, IHaveName
    {
        public class Attributes
        {
            public static string LicenseAssetRulesetArn =  "LicenseAssetRulesetArn" ;
        }

        public override string AWSTypeName { get => AWS.LicenseManager.LicenseAssetRuleSet; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseassetruleset.html#cfn-licensemanager-licenseassetruleset-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseassetruleset.html#cfn-licensemanager-licenseassetruleset-rules
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LicenseAssetRule
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule>, IReadOnlyList<Union<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseassetruleset.html#cfn-licensemanager-licenseassetruleset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace LicenseAssetRuleSetTypes
    {
        public class AndRuleStatement : Humidifier.Base.BaseSubResource, IHaveListOfLicenseManagerLicenseAssetRuleSetTypesMatchingRuleStatementMatchingRuleStatements
        {
            /// <summary>
            /// MatchingRuleStatements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-andrulestatement.html#cfn-licensemanager-licenseassetruleset-andrulestatement-matchingrulestatements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MatchingRuleStatement
            /// </summary>
            public Union<IReadOnlyList<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.MatchingRuleStatement>, IReadOnlyList<Union<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.MatchingRuleStatement, BaseFunction>>, BaseFunction>? MatchingRuleStatements { get; set; }
        }

        public class InstanceRuleStatement : Humidifier.Base.BaseSubResource, IHaveLicenseManagerLicenseAssetRuleSetTypesOrRuleStatementOrRuleStatement, IHaveLicenseManagerLicenseAssetRuleSetTypesMatchingRuleStatementMatchingRuleStatement, IHaveLicenseManagerLicenseAssetRuleSetTypesAndRuleStatementAndRuleStatement
        {
            /// <summary>
            /// OrRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-instancerulestatement.html#cfn-licensemanager-licenseassetruleset-instancerulestatement-orrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OrRuleStatement
            /// </summary>
            public Union<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.OrRuleStatement, BaseFunction>? OrRuleStatement { get; set; }
            /// <summary>
            /// MatchingRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-instancerulestatement.html#cfn-licensemanager-licenseassetruleset-instancerulestatement-matchingrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchingRuleStatement
            /// </summary>
            public Union<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.MatchingRuleStatement, BaseFunction>? MatchingRuleStatement { get; set; }
            /// <summary>
            /// AndRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-instancerulestatement.html#cfn-licensemanager-licenseassetruleset-instancerulestatement-andrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AndRuleStatement
            /// </summary>
            public Union<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.AndRuleStatement, BaseFunction>? AndRuleStatement { get; set; }
        }

        public class LicenseAssetRule : Humidifier.Base.BaseSubResource, IHaveLicenseManagerLicenseAssetRuleSetTypesRuleStatementRuleStatement
        {
            /// <summary>
            /// RuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-licenseassetrule.html#cfn-licensemanager-licenseassetruleset-licenseassetrule-rulestatement
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RuleStatement
            /// </summary>
            public Union<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.RuleStatement, BaseFunction>? RuleStatement { get; set; }
        }

        public class LicenseConfigurationRuleStatement : Humidifier.Base.BaseSubResource, IHaveLicenseManagerLicenseAssetRuleSetTypesOrRuleStatementOrRuleStatement, IHaveLicenseManagerLicenseAssetRuleSetTypesMatchingRuleStatementMatchingRuleStatement, IHaveLicenseManagerLicenseAssetRuleSetTypesAndRuleStatementAndRuleStatement
        {
            /// <summary>
            /// OrRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-licenseconfigurationrulestatement.html#cfn-licensemanager-licenseassetruleset-licenseconfigurationrulestatement-orrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OrRuleStatement
            /// </summary>
            public Union<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.OrRuleStatement, BaseFunction>? OrRuleStatement { get; set; }
            /// <summary>
            /// MatchingRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-licenseconfigurationrulestatement.html#cfn-licensemanager-licenseassetruleset-licenseconfigurationrulestatement-matchingrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchingRuleStatement
            /// </summary>
            public Union<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.MatchingRuleStatement, BaseFunction>? MatchingRuleStatement { get; set; }
            /// <summary>
            /// AndRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-licenseconfigurationrulestatement.html#cfn-licensemanager-licenseassetruleset-licenseconfigurationrulestatement-andrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AndRuleStatement
            /// </summary>
            public Union<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.AndRuleStatement, BaseFunction>? AndRuleStatement { get; set; }
        }

        public class LicenseRuleStatement : Humidifier.Base.BaseSubResource, IHaveLicenseManagerLicenseAssetRuleSetTypesOrRuleStatementOrRuleStatement, IHaveLicenseManagerLicenseAssetRuleSetTypesMatchingRuleStatementMatchingRuleStatement, IHaveLicenseManagerLicenseAssetRuleSetTypesAndRuleStatementAndRuleStatement
        {
            /// <summary>
            /// OrRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-licenserulestatement.html#cfn-licensemanager-licenseassetruleset-licenserulestatement-orrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OrRuleStatement
            /// </summary>
            public Union<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.OrRuleStatement, BaseFunction>? OrRuleStatement { get; set; }
            /// <summary>
            /// MatchingRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-licenserulestatement.html#cfn-licensemanager-licenseassetruleset-licenserulestatement-matchingrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchingRuleStatement
            /// </summary>
            public Union<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.MatchingRuleStatement, BaseFunction>? MatchingRuleStatement { get; set; }
            /// <summary>
            /// AndRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-licenserulestatement.html#cfn-licensemanager-licenseassetruleset-licenserulestatement-andrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AndRuleStatement
            /// </summary>
            public Union<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.AndRuleStatement, BaseFunction>? AndRuleStatement { get; set; }
        }

        public class MatchingRuleStatement : Humidifier.Base.BaseSubResource, IHaveConstraint, IHaveKeyToMatch, IHaveStringListOfValueToMatch
        {
            /// <summary>
            /// Constraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-matchingrulestatement.html#cfn-licensemanager-licenseassetruleset-matchingrulestatement-constraint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Constraint { get; set; }
            /// <summary>
            /// KeyToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-matchingrulestatement.html#cfn-licensemanager-licenseassetruleset-matchingrulestatement-keytomatch
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyToMatch { get; set; }
            /// <summary>
            /// ValueToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-matchingrulestatement.html#cfn-licensemanager-licenseassetruleset-matchingrulestatement-valuetomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ValueToMatch { get; set; }
        }

        public class OrRuleStatement : Humidifier.Base.BaseSubResource, IHaveListOfLicenseManagerLicenseAssetRuleSetTypesMatchingRuleStatementMatchingRuleStatements
        {
            /// <summary>
            /// MatchingRuleStatements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-orrulestatement.html#cfn-licensemanager-licenseassetruleset-orrulestatement-matchingrulestatements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MatchingRuleStatement
            /// </summary>
            public Union<IReadOnlyList<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.MatchingRuleStatement>, IReadOnlyList<Union<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.MatchingRuleStatement, BaseFunction>>, BaseFunction>? MatchingRuleStatements { get; set; }
        }

        public class RuleStatement : Humidifier.Base.BaseSubResource, IHaveLicenseManagerLicenseAssetRuleSetTypesLicenseRuleStatementLicenseRuleStatement, IHaveLicenseManagerLicenseAssetRuleSetTypesInstanceRuleStatementInstanceRuleStatement, IHaveLicenseManagerLicenseAssetRuleSetTypesLicenseConfigurationRuleStatementLicenseConfigurationRuleStatement
        {
            /// <summary>
            /// LicenseRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-rulestatement.html#cfn-licensemanager-licenseassetruleset-rulestatement-licenserulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LicenseRuleStatement
            /// </summary>
            public Union<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseRuleStatement, BaseFunction>? LicenseRuleStatement { get; set; }
            /// <summary>
            /// InstanceRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-rulestatement.html#cfn-licensemanager-licenseassetruleset-rulestatement-instancerulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InstanceRuleStatement
            /// </summary>
            public Union<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.InstanceRuleStatement, BaseFunction>? InstanceRuleStatement { get; set; }
            /// <summary>
            /// LicenseConfigurationRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-rulestatement.html#cfn-licensemanager-licenseassetruleset-rulestatement-licenseconfigurationrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LicenseConfigurationRuleStatement
            /// </summary>
            public Union<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseConfigurationRuleStatement, BaseFunction>? LicenseConfigurationRuleStatement { get; set; }
        }
    }
}