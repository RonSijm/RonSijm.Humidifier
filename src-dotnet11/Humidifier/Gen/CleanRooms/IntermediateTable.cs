namespace Humidifier.CleanRooms
{
    using global::System.Collections.Generic;
    using IntermediateTableTypes;

    public class IntermediateTable : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMembershipIdentifier, IHaveDescription, IHaveKmsKeyArn, IHaveListOfCleanRoomsIntermediateTableTypesIntermediateTableAnalysisRuleAnalysisRules, IHaveCleanRoomsIntermediateTableTypesPopulationAnalysisConfigurationPopulationAnalysisConfiguration, IHaveName
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
        public Union<string, BaseFunction>? MembershipIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-intermediatetable.html#cfn-cleanrooms-intermediatetable-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-intermediatetable.html#cfn-cleanrooms-intermediatetable-kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        /// <summary>
        /// AnalysisRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-intermediatetable.html#cfn-cleanrooms-intermediatetable-analysisrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IntermediateTableAnalysisRule
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule>, IReadOnlyList<Union<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule, BaseFunction>>, BaseFunction>? AnalysisRules { get; set; }

        /// <summary>
        /// PopulationAnalysisConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-intermediatetable.html#cfn-cleanrooms-intermediatetable-populationanalysisconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: PopulationAnalysisConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration, BaseFunction>? PopulationAnalysisConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-intermediatetable.html#cfn-cleanrooms-intermediatetable-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace IntermediateTableTypes
    {
        public class AggregationThreshold : Humidifier.Base.BaseSubResource, IHaveStringListOfIdentityColumns, IHaveType, IHaveMinimumIdentityCount_Integer, IHaveListOfCleanRoomsIntermediateTableTypesOutputColumnThresholdOutputColumnThresholds, IHaveAllowedAggregateExpressionType
        {
            /// <summary>
            /// IdentityColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-aggregationthreshold.html#cfn-cleanrooms-intermediatetable-aggregationthreshold-identitycolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IdentityColumns { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-aggregationthreshold.html#cfn-cleanrooms-intermediatetable-aggregationthreshold-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// MinimumIdentityCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-aggregationthreshold.html#cfn-cleanrooms-intermediatetable-aggregationthreshold-minimumidentitycount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumIdentityCount { get; set; }
            /// <summary>
            /// OutputColumnThresholds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-aggregationthreshold.html#cfn-cleanrooms-intermediatetable-aggregationthreshold-outputcolumnthresholds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OutputColumnThreshold
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRooms.IntermediateTableTypes.OutputColumnThreshold>, IReadOnlyList<Union<Humidifier.CleanRooms.IntermediateTableTypes.OutputColumnThreshold, BaseFunction>>, BaseFunction>? OutputColumnThresholds { get; set; }
            /// <summary>
            /// AllowedAggregateExpressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-aggregationthreshold.html#cfn-cleanrooms-intermediatetable-aggregationthreshold-allowedaggregateexpressiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllowedAggregateExpressionType { get; set; }
        }

        public class ComparisonControls : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedLiteralComparisonColumns, IHaveStringListOfAllowedColumnComparisonColumns
        {
            /// <summary>
            /// AllowedLiteralComparisonColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-comparisoncontrols.html#cfn-cleanrooms-intermediatetable-comparisoncontrols-allowedliteralcomparisoncolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedLiteralComparisonColumns { get; set; }
            /// <summary>
            /// AllowedColumnComparisonColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-comparisoncontrols.html#cfn-cleanrooms-intermediatetable-comparisoncontrols-allowedcolumncomparisoncolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedColumnComparisonColumns { get; set; }
        }

        public class DifferentialPrivacy : Humidifier.Base.BaseSubResource, IHaveListOfCleanRoomsIntermediateTableTypesDifferentialPrivacyColumnColumns
        {
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-differentialprivacy.html#cfn-cleanrooms-intermediatetable-differentialprivacy-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DifferentialPrivacyColumn
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRooms.IntermediateTableTypes.DifferentialPrivacyColumn>, IReadOnlyList<Union<Humidifier.CleanRooms.IntermediateTableTypes.DifferentialPrivacyColumn, BaseFunction>>, BaseFunction>? Columns { get; set; }
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
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class IntermediateTableAnalysisRule : Humidifier.Base.BaseSubResource, IHaveCleanRoomsIntermediateTableTypesIntermediateTableAnalysisRulePolicyPolicy, IHaveType
        {
            /// <summary>
            /// Policy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrule.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrule-policy
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IntermediateTableAnalysisRulePolicy
            /// </summary>
            public Union<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy, BaseFunction>? Policy { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrule.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrule-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class IntermediateTableAnalysisRuleCustom : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedResultReceivers, IHaveAdditionalAnalyses, IHaveCleanRoomsIntermediateTableTypesComparisonControlsComparisonControls, IHaveStringListOfAllowedAnalysisProviders, IHaveCleanRoomsIntermediateTableTypesDifferentialPrivacyDifferentialPrivacy, IHaveStringListOfAllowedAnalyses, IHaveStringListOfDisallowedOutputColumns, IHaveListOfCleanRoomsIntermediateTableTypesAggregationThresholdAggregationThresholds
        {
            /// <summary>
            /// AllowedResultReceivers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom-allowedresultreceivers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedResultReceivers { get; set; }
            /// <summary>
            /// AdditionalAnalyses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom-additionalanalyses
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdditionalAnalyses { get; set; }
            /// <summary>
            /// ComparisonControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom-comparisoncontrols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComparisonControls
            /// </summary>
            public Union<Humidifier.CleanRooms.IntermediateTableTypes.ComparisonControls, BaseFunction>? ComparisonControls { get; set; }
            /// <summary>
            /// AllowedAnalysisProviders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom-allowedanalysisproviders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedAnalysisProviders { get; set; }
            /// <summary>
            /// DifferentialPrivacy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom-differentialprivacy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DifferentialPrivacy
            /// </summary>
            public Union<Humidifier.CleanRooms.IntermediateTableTypes.DifferentialPrivacy, BaseFunction>? DifferentialPrivacy { get; set; }
            /// <summary>
            /// AllowedAnalyses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom-allowedanalyses
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedAnalyses { get; set; }
            /// <summary>
            /// DisallowedOutputColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom-disallowedoutputcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DisallowedOutputColumns { get; set; }
            /// <summary>
            /// AggregationThresholds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulecustom-aggregationthresholds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AggregationThreshold
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRooms.IntermediateTableTypes.AggregationThreshold>, IReadOnlyList<Union<Humidifier.CleanRooms.IntermediateTableTypes.AggregationThreshold, BaseFunction>>, BaseFunction>? AggregationThresholds { get; set; }
        }

        public class IntermediateTableAnalysisRulePolicy : Humidifier.Base.BaseSubResource, IHaveCleanRoomsIntermediateTableTypesIntermediateTableAnalysisRulePolicyV1V1
        {
            /// <summary>
            /// V1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulepolicy.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulepolicy-v1
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IntermediateTableAnalysisRulePolicyV1
            /// </summary>
            public Union<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1, BaseFunction>? V1 { get; set; }
        }

        public class IntermediateTableAnalysisRulePolicyV1 : Humidifier.Base.BaseSubResource, IHaveCleanRoomsIntermediateTableTypesIntermediateTableAnalysisRuleCustomCustom
        {
            /// <summary>
            /// Custom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-intermediatetableanalysisrulepolicyv1.html#cfn-cleanrooms-intermediatetable-intermediatetableanalysisrulepolicyv1-custom
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IntermediateTableAnalysisRuleCustom
            /// </summary>
            public Union<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRuleCustom, BaseFunction>? Custom { get; set; }
        }

        public class OutputColumnThreshold : Humidifier.Base.BaseSubResource, IHaveMinimumIdentityCount_Integer, IHaveOutputColumnName
        {
            /// <summary>
            /// MinimumIdentityCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-outputcolumnthreshold.html#cfn-cleanrooms-intermediatetable-outputcolumnthreshold-minimumidentitycount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumIdentityCount { get; set; }
            /// <summary>
            /// OutputColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-outputcolumnthreshold.html#cfn-cleanrooms-intermediatetable-outputcolumnthreshold-outputcolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputColumnName { get; set; }
        }

        public class PopulationAnalysisConfiguration : Humidifier.Base.BaseSubResource, IHaveCleanRoomsIntermediateTableTypesPopulationAnalysisSqlParametersSqlParameters
        {
            /// <summary>
            /// SqlParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-populationanalysisconfiguration.html#cfn-cleanrooms-intermediatetable-populationanalysisconfiguration-sqlparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PopulationAnalysisSqlParameters
            /// </summary>
            public Union<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters, BaseFunction>? SqlParameters { get; set; }
        }

        public class PopulationAnalysisSqlParameters : Humidifier.Base.BaseSubResource, IHaveQueryString, IHaveAnalysisTemplateArn
        {
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-populationanalysissqlparameters.html#cfn-cleanrooms-intermediatetable-populationanalysissqlparameters-querystring
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueryString { get; set; }
            /// <summary>
            /// AnalysisTemplateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-intermediatetable-populationanalysissqlparameters.html#cfn-cleanrooms-intermediatetable-populationanalysissqlparameters-analysistemplatearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AnalysisTemplateArn { get; set; }
        }
    }
}