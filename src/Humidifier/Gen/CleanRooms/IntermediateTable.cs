namespace Humidifier.CleanRooms
{
    using global::System.Collections.Generic;
    using IntermediateTableTypes;

    public class IntermediateTable : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveKmsKeyArn, IHaveMembershipIdentifier
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CollaborationIdentifier =  "CollaborationIdentifier" ;
            public static string IntermediateTableIdentifier =  "IntermediateTableIdentifier" ;
            public static string MembershipArn =  "MembershipArn" ;
            public static string Arn =  "Arn" ;
            public static string CollaborationArn =  "CollaborationArn" ;
        }

        public override string AWSTypeName { get => AWS.CleanRooms.IntermediateTable; }

        /// <summary>
        /// MembershipIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-intermediatetable.html#cfn-cleanrooms-intermediatetable-membershipidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic MembershipIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-intermediatetable.html#cfn-cleanrooms-intermediatetable-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-intermediatetable.html#cfn-cleanrooms-intermediatetable-kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyArn { get; set; }
        /// <summary>
        /// AnalysisRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-intermediatetable.html#cfn-cleanrooms-intermediatetable-analysisrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IntermediateTableAnalysisRule
        /// </summary>
        public List<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule> AnalysisRules { get; set; }

        /// <summary>
        /// PopulationAnalysisConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-intermediatetable.html#cfn-cleanrooms-intermediatetable-populationanalysisconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: PopulationAnalysisConfiguration
        /// </summary>
        [Required]
        public Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration PopulationAnalysisConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-intermediatetable.html#cfn-cleanrooms-intermediatetable-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace IntermediateTableTypes
    {
        public class AggregationThreshold : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// IdentityColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-aggregationthreshold.html#cfn-cleanrooms-intermediatetable-aggregationthreshold-identitycolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IdentityColumns { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-aggregationthreshold.html#cfn-cleanrooms-intermediatetable-aggregationthreshold-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// MinimumIdentityCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-aggregationthreshold.html#cfn-cleanrooms-intermediatetable-aggregationthreshold-minimumidentitycount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumIdentityCount { get; set; }
            /// <summary>
            /// OutputColumnThresholds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-aggregationthreshold.html#cfn-cleanrooms-intermediatetable-aggregationthreshold-outputcolumnthresholds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OutputColumnThreshold
            /// </summary>
            public List<Humidifier.CleanRooms.IntermediateTableTypes.OutputColumnThreshold> OutputColumnThresholds { get; set; }
            /// <summary>
            /// AllowedAggregateExpressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-aggregationthreshold.html#cfn-cleanrooms-intermediatetable-aggregationthreshold-allowedaggregateexpressiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AllowedAggregateExpressionType { get; set; }
        }

        public class ComparisonControls : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AllowedLiteralComparisonColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-comparisoncontrols.html#cfn-cleanrooms-intermediatetable-comparisoncontrols-allowedliteralcomparisoncolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedLiteralComparisonColumns { get; set; }
            /// <summary>
            /// AllowedColumnComparisonColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-comparisoncontrols.html#cfn-cleanrooms-intermediatetable-comparisoncontrols-allowedcolumncomparisoncolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedColumnComparisonColumns { get; set; }
        }

        public class DifferentialPrivacy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-differentialprivacy.html#cfn-cleanrooms-intermediatetable-differentialprivacy-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DifferentialPrivacyColumn
            /// </summary>
            public List<Humidifier.CleanRooms.IntermediateTableTypes.DifferentialPrivacyColumn> Columns { get; set; }
        }

        public class DifferentialPrivacyColumn : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-differentialprivacycolumn.html#cfn-cleanrooms-intermediatetable-differentialprivacycolumn-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class IntermediateTableAnalysisRule : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Policy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrule.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrule-policy
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IntermediateTableAnalysisRulePolicy
            /// </summary>
            public Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy Policy { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrule.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrule-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class IntermediateTableAnalysisRuleCustom : Humidifier.Base.BaseSubResource, IHaveAdditionalAnalyses, IHaveAllowedResultReceivers
        {
            /// <summary>
            /// AllowedResultReceivers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom-allowedresultreceivers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedResultReceivers { get; set; }
            /// <summary>
            /// AdditionalAnalyses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom-additionalanalyses
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AdditionalAnalyses { get; set; }
            /// <summary>
            /// ComparisonControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom-comparisoncontrols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComparisonControls
            /// </summary>
            public Humidifier.CleanRooms.IntermediateTableTypes.ComparisonControls ComparisonControls { get; set; }
            /// <summary>
            /// AllowedAnalysisProviders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom-allowedanalysisproviders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedAnalysisProviders { get; set; }
            /// <summary>
            /// DifferentialPrivacy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom-differentialprivacy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DifferentialPrivacy
            /// </summary>
            public Humidifier.CleanRooms.IntermediateTableTypes.DifferentialPrivacy DifferentialPrivacy { get; set; }
            /// <summary>
            /// AllowedAnalyses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom-allowedanalyses
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedAnalyses { get; set; }
            /// <summary>
            /// DisallowedOutputColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom-disallowedoutputcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DisallowedOutputColumns { get; set; }
            /// <summary>
            /// AggregationThresholds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom-aggregationthresholds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AggregationThreshold
            /// </summary>
            public List<Humidifier.CleanRooms.IntermediateTableTypes.AggregationThreshold> AggregationThresholds { get; set; }
        }

        public class IntermediateTableAnalysisRulePolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// V1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulepolicy.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulepolicy-v1
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IntermediateTableAnalysisRulePolicyV1
            /// </summary>
            public Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1 V1 { get; set; }
        }

        public class IntermediateTableAnalysisRulePolicyV1 : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Custom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulepolicyv1.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulepolicyv1-custom
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IntermediateTableAnalysisRuleCustom
            /// </summary>
            public Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRuleCustom Custom { get; set; }
        }

        public class OutputColumnThreshold : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MinimumIdentityCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-outputcolumnthreshold.html#cfn-cleanrooms-intermediatetable-outputcolumnthreshold-minimumidentitycount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumIdentityCount { get; set; }
            /// <summary>
            /// OutputColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-outputcolumnthreshold.html#cfn-cleanrooms-intermediatetable-outputcolumnthreshold-outputcolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputColumnName { get; set; }
        }

        public class PopulationAnalysisConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SqlParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-populationanalysisconfiguration.html#cfn-cleanrooms-intermediatetable-populationanalysisconfiguration-sqlparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PopulationAnalysisSqlParameters
            /// </summary>
            public Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters SqlParameters { get; set; }
        }

        public class PopulationAnalysisSqlParameters : Humidifier.Base.BaseSubResource, IHaveQueryString
        {
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-populationanalysissqlparameters.html#cfn-cleanrooms-intermediatetable-populationanalysissqlparameters-querystring
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueryString { get; set; }
            /// <summary>
            /// AnalysisTemplateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-populationanalysissqlparameters.html#cfn-cleanrooms-intermediatetable-populationanalysissqlparameters-analysistemplatearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AnalysisTemplateArn { get; set; }
        }
    }
}