namespace Humidifier.LicenseManager
{
    using global::System.Collections.Generic;
    using LicenseAssetRuleSetTypes;

    public class LicenseAssetRuleSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
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
        public dynamic Description { get; set; }

        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseassetruleset.html#cfn-licensemanager-licenseassetruleset-rules
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LicenseAssetRule
        /// </summary>
        [Required]
        public List<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule> Rules { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseassetruleset.html#cfn-licensemanager-licenseassetruleset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace LicenseAssetRuleSetTypes
    {
        public class AndRuleStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MatchingRuleStatements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-andrulestatement.html#cfn-licensemanager-licenseassetruleset-andrulestatement-matchingrulestatements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MatchingRuleStatement
            /// </summary>
            public List<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.MatchingRuleStatement> MatchingRuleStatements { get; set; }
        }

        public class InstanceRuleStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OrRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-instancerulestatement.html#cfn-licensemanager-licenseassetruleset-instancerulestatement-orrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OrRuleStatement
            /// </summary>
            public Humidifier.LicenseManager.LicenseAssetRuleSetTypes.OrRuleStatement OrRuleStatement { get; set; }
            /// <summary>
            /// MatchingRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-instancerulestatement.html#cfn-licensemanager-licenseassetruleset-instancerulestatement-matchingrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchingRuleStatement
            /// </summary>
            public Humidifier.LicenseManager.LicenseAssetRuleSetTypes.MatchingRuleStatement MatchingRuleStatement { get; set; }
            /// <summary>
            /// AndRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-instancerulestatement.html#cfn-licensemanager-licenseassetruleset-instancerulestatement-andrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AndRuleStatement
            /// </summary>
            public Humidifier.LicenseManager.LicenseAssetRuleSetTypes.AndRuleStatement AndRuleStatement { get; set; }
        }

        public class LicenseAssetRule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-licenseassetrule.html#cfn-licensemanager-licenseassetruleset-licenseassetrule-rulestatement
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RuleStatement
            /// </summary>
            public Humidifier.LicenseManager.LicenseAssetRuleSetTypes.RuleStatement RuleStatement { get; set; }
        }

        public class LicenseConfigurationRuleStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OrRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-licenseconfigurationrulestatement.html#cfn-licensemanager-licenseassetruleset-licenseconfigurationrulestatement-orrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OrRuleStatement
            /// </summary>
            public Humidifier.LicenseManager.LicenseAssetRuleSetTypes.OrRuleStatement OrRuleStatement { get; set; }
            /// <summary>
            /// MatchingRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-licenseconfigurationrulestatement.html#cfn-licensemanager-licenseassetruleset-licenseconfigurationrulestatement-matchingrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchingRuleStatement
            /// </summary>
            public Humidifier.LicenseManager.LicenseAssetRuleSetTypes.MatchingRuleStatement MatchingRuleStatement { get; set; }
            /// <summary>
            /// AndRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-licenseconfigurationrulestatement.html#cfn-licensemanager-licenseassetruleset-licenseconfigurationrulestatement-andrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AndRuleStatement
            /// </summary>
            public Humidifier.LicenseManager.LicenseAssetRuleSetTypes.AndRuleStatement AndRuleStatement { get; set; }
        }

        public class LicenseRuleStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OrRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-licenserulestatement.html#cfn-licensemanager-licenseassetruleset-licenserulestatement-orrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OrRuleStatement
            /// </summary>
            public Humidifier.LicenseManager.LicenseAssetRuleSetTypes.OrRuleStatement OrRuleStatement { get; set; }
            /// <summary>
            /// MatchingRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-licenserulestatement.html#cfn-licensemanager-licenseassetruleset-licenserulestatement-matchingrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchingRuleStatement
            /// </summary>
            public Humidifier.LicenseManager.LicenseAssetRuleSetTypes.MatchingRuleStatement MatchingRuleStatement { get; set; }
            /// <summary>
            /// AndRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-licenserulestatement.html#cfn-licensemanager-licenseassetruleset-licenserulestatement-andrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AndRuleStatement
            /// </summary>
            public Humidifier.LicenseManager.LicenseAssetRuleSetTypes.AndRuleStatement AndRuleStatement { get; set; }
        }

        public class MatchingRuleStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Constraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-matchingrulestatement.html#cfn-licensemanager-licenseassetruleset-matchingrulestatement-constraint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Constraint { get; set; }
            /// <summary>
            /// KeyToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-matchingrulestatement.html#cfn-licensemanager-licenseassetruleset-matchingrulestatement-keytomatch
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyToMatch { get; set; }
            /// <summary>
            /// ValueToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-matchingrulestatement.html#cfn-licensemanager-licenseassetruleset-matchingrulestatement-valuetomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ValueToMatch { get; set; }
        }

        public class OrRuleStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MatchingRuleStatements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-orrulestatement.html#cfn-licensemanager-licenseassetruleset-orrulestatement-matchingrulestatements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MatchingRuleStatement
            /// </summary>
            public List<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.MatchingRuleStatement> MatchingRuleStatements { get; set; }
        }

        public class RuleStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LicenseRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-rulestatement.html#cfn-licensemanager-licenseassetruleset-rulestatement-licenserulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LicenseRuleStatement
            /// </summary>
            public Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseRuleStatement LicenseRuleStatement { get; set; }
            /// <summary>
            /// InstanceRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-rulestatement.html#cfn-licensemanager-licenseassetruleset-rulestatement-instancerulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InstanceRuleStatement
            /// </summary>
            public Humidifier.LicenseManager.LicenseAssetRuleSetTypes.InstanceRuleStatement InstanceRuleStatement { get; set; }
            /// <summary>
            /// LicenseConfigurationRuleStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetruleset-rulestatement.html#cfn-licensemanager-licenseassetruleset-rulestatement-licenseconfigurationrulestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LicenseConfigurationRuleStatement
            /// </summary>
            public Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseConfigurationRuleStatement LicenseConfigurationRuleStatement { get; set; }
        }
    }
}