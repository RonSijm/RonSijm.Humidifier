namespace Humidifier.CleanRooms
{
    using global::System.Collections.Generic;
    using ConfiguredTableTypes;

    public class ConfiguredTable : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStringListOfSelectedAnalysisMethods, IHaveAnalysisMethod, IHaveCleanRoomsConfiguredTableTypesTableReferenceTableReference, IHaveDescription, IHaveListOfCleanRoomsConfiguredTableTypesAnalysisRuleAnalysisRules, IHaveStringListOfAllowedColumns, IHaveName
    {
        public class Attributes
        {
            public static string ConfiguredTableIdentifier =  "ConfiguredTableIdentifier" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CleanRooms.ConfiguredTable; }
        /// <summary>
        /// SelectedAnalysisMethods
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-configuredtable.html#cfn-cleanrooms-configuredtable-selectedanalysismethods
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SelectedAnalysisMethods { get; set; }

        /// <summary>
        /// AnalysisMethod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-configuredtable.html#cfn-cleanrooms-configuredtable-analysismethod
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AnalysisMethod { get; set; }

        /// <summary>
        /// TableReference
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-configuredtable.html#cfn-cleanrooms-configuredtable-tablereference
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TableReference
        /// </summary>
        [Required]
        public Union<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference, BaseFunction>? TableReference { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-configuredtable.html#cfn-cleanrooms-configuredtable-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// AnalysisRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-configuredtable.html#cfn-cleanrooms-configuredtable-analysisrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AnalysisRule
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule>, IReadOnlyList<Union<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule, BaseFunction>>, BaseFunction>? AnalysisRules { get; set; }

        /// <summary>
        /// AllowedColumns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-configuredtable.html#cfn-cleanrooms-configuredtable-allowedcolumns
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedColumns { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-configuredtable.html#cfn-cleanrooms-configuredtable-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConfiguredTableTypes
    {
        public class AggregateColumn : Humidifier.Base.BaseSubResource, IHaveFunction, IHaveStringListOfColumnNames
        {
            /// <summary>
            /// Function
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-aggregatecolumn.html#cfn-cleanrooms-configuredtable-aggregatecolumn-function
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Function { get; set; }
            /// <summary>
            /// ColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-aggregatecolumn.html#cfn-cleanrooms-configuredtable-aggregatecolumn-columnnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ColumnNames { get; set; }
        }

        public class AggregationConstraint : Humidifier.Base.BaseSubResource, IHaveColumnName, IHaveMinimum_Double, IHaveType
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-aggregationconstraint.html#cfn-cleanrooms-configuredtable-aggregationconstraint-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnName { get; set; }
            /// <summary>
            /// Minimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-aggregationconstraint.html#cfn-cleanrooms-configuredtable-aggregationconstraint-minimum
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Minimum { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-aggregationconstraint.html#cfn-cleanrooms-configuredtable-aggregationconstraint-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class AggregationThreshold : Humidifier.Base.BaseSubResource, IHaveStringListOfIdentityColumns, IHaveType, IHaveMinimumIdentityCount_Integer, IHaveListOfCleanRoomsConfiguredTableTypesOutputColumnThresholdOutputColumnThresholds, IHaveAllowedAggregateExpressionType
        {
            /// <summary>
            /// IdentityColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-aggregationthreshold.html#cfn-cleanrooms-configuredtable-aggregationthreshold-identitycolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IdentityColumns { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-aggregationthreshold.html#cfn-cleanrooms-configuredtable-aggregationthreshold-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// MinimumIdentityCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-aggregationthreshold.html#cfn-cleanrooms-configuredtable-aggregationthreshold-minimumidentitycount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumIdentityCount { get; set; }
            /// <summary>
            /// OutputColumnThresholds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-aggregationthreshold.html#cfn-cleanrooms-configuredtable-aggregationthreshold-outputcolumnthresholds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OutputColumnThreshold
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRooms.ConfiguredTableTypes.OutputColumnThreshold>, IReadOnlyList<Union<Humidifier.CleanRooms.ConfiguredTableTypes.OutputColumnThreshold, BaseFunction>>, BaseFunction>? OutputColumnThresholds { get; set; }
            /// <summary>
            /// AllowedAggregateExpressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-aggregationthreshold.html#cfn-cleanrooms-configuredtable-aggregationthreshold-allowedaggregateexpressiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllowedAggregateExpressionType { get; set; }
        }

        public class AnalysisRule : Humidifier.Base.BaseSubResource, IHaveCleanRoomsConfiguredTableTypesConfiguredTableAnalysisRulePolicyPolicy, IHaveType
        {
            /// <summary>
            /// Policy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisrule.html#cfn-cleanrooms-configuredtable-analysisrule-policy
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConfiguredTableAnalysisRulePolicy
            /// </summary>
            public Union<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy, BaseFunction>? Policy { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisrule.html#cfn-cleanrooms-configuredtable-analysisrule-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class AnalysisRuleAggregation : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedJoinOperators, IHaveStringListOfScalarFunctions, IHaveAdditionalAnalyses, IHaveListOfCleanRoomsConfiguredTableTypesAggregationConstraintOutputConstraints, IHaveStringListOfDimensionColumns, IHaveStringListOfJoinColumns, IHaveJoinRequired, IHaveListOfCleanRoomsConfiguredTableTypesAggregateColumnAggregateColumns
        {
            /// <summary>
            /// AllowedJoinOperators
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisruleaggregation.html#cfn-cleanrooms-configuredtable-analysisruleaggregation-allowedjoinoperators
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedJoinOperators { get; set; }
            /// <summary>
            /// ScalarFunctions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisruleaggregation.html#cfn-cleanrooms-configuredtable-analysisruleaggregation-scalarfunctions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ScalarFunctions { get; set; }
            /// <summary>
            /// AdditionalAnalyses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisruleaggregation.html#cfn-cleanrooms-configuredtable-analysisruleaggregation-additionalanalyses
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdditionalAnalyses { get; set; }
            /// <summary>
            /// OutputConstraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisruleaggregation.html#cfn-cleanrooms-configuredtable-analysisruleaggregation-outputconstraints
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AggregationConstraint
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRooms.ConfiguredTableTypes.AggregationConstraint>, IReadOnlyList<Union<Humidifier.CleanRooms.ConfiguredTableTypes.AggregationConstraint, BaseFunction>>, BaseFunction>? OutputConstraints { get; set; }
            /// <summary>
            /// DimensionColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisruleaggregation.html#cfn-cleanrooms-configuredtable-analysisruleaggregation-dimensioncolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DimensionColumns { get; set; }
            /// <summary>
            /// JoinColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisruleaggregation.html#cfn-cleanrooms-configuredtable-analysisruleaggregation-joincolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? JoinColumns { get; set; }
            /// <summary>
            /// JoinRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisruleaggregation.html#cfn-cleanrooms-configuredtable-analysisruleaggregation-joinrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JoinRequired { get; set; }
            /// <summary>
            /// AggregateColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisruleaggregation.html#cfn-cleanrooms-configuredtable-analysisruleaggregation-aggregatecolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AggregateColumn
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRooms.ConfiguredTableTypes.AggregateColumn>, IReadOnlyList<Union<Humidifier.CleanRooms.ConfiguredTableTypes.AggregateColumn, BaseFunction>>, BaseFunction>? AggregateColumns { get; set; }
        }

        public class AnalysisRuleCustom : Humidifier.Base.BaseSubResource, IHaveAdditionalAnalyses, IHaveCleanRoomsConfiguredTableTypesComparisonControlsComparisonControls, IHaveStringListOfAllowedAnalysisProviders, IHaveCleanRoomsConfiguredTableTypesDifferentialPrivacyDifferentialPrivacy, IHaveStringListOfAllowedAnalyses, IHaveStringListOfDisallowedOutputColumns, IHaveListOfCleanRoomsConfiguredTableTypesAggregationThresholdAggregationThresholds
        {
            /// <summary>
            /// AdditionalAnalyses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisrulecustom.html#cfn-cleanrooms-configuredtable-analysisrulecustom-additionalanalyses
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdditionalAnalyses { get; set; }
            /// <summary>
            /// ComparisonControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisrulecustom.html#cfn-cleanrooms-configuredtable-analysisrulecustom-comparisoncontrols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComparisonControls
            /// </summary>
            public Union<Humidifier.CleanRooms.ConfiguredTableTypes.ComparisonControls, BaseFunction>? ComparisonControls { get; set; }
            /// <summary>
            /// AllowedAnalysisProviders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisrulecustom.html#cfn-cleanrooms-configuredtable-analysisrulecustom-allowedanalysisproviders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedAnalysisProviders { get; set; }
            /// <summary>
            /// DifferentialPrivacy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisrulecustom.html#cfn-cleanrooms-configuredtable-analysisrulecustom-differentialprivacy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DifferentialPrivacy
            /// </summary>
            public Union<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy, BaseFunction>? DifferentialPrivacy { get; set; }
            /// <summary>
            /// AllowedAnalyses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisrulecustom.html#cfn-cleanrooms-configuredtable-analysisrulecustom-allowedanalyses
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedAnalyses { get; set; }
            /// <summary>
            /// DisallowedOutputColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisrulecustom.html#cfn-cleanrooms-configuredtable-analysisrulecustom-disallowedoutputcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DisallowedOutputColumns { get; set; }
            /// <summary>
            /// AggregationThresholds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisrulecustom.html#cfn-cleanrooms-configuredtable-analysisrulecustom-aggregationthresholds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AggregationThreshold
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRooms.ConfiguredTableTypes.AggregationThreshold>, IReadOnlyList<Union<Humidifier.CleanRooms.ConfiguredTableTypes.AggregationThreshold, BaseFunction>>, BaseFunction>? AggregationThresholds { get; set; }
        }

        public class AnalysisRuleList : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedJoinOperators, IHaveStringListOfListColumns, IHaveAdditionalAnalyses, IHaveStringListOfJoinColumns
        {
            /// <summary>
            /// AllowedJoinOperators
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisrulelist.html#cfn-cleanrooms-configuredtable-analysisrulelist-allowedjoinoperators
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedJoinOperators { get; set; }
            /// <summary>
            /// ListColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisrulelist.html#cfn-cleanrooms-configuredtable-analysisrulelist-listcolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ListColumns { get; set; }
            /// <summary>
            /// AdditionalAnalyses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisrulelist.html#cfn-cleanrooms-configuredtable-analysisrulelist-additionalanalyses
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdditionalAnalyses { get; set; }
            /// <summary>
            /// JoinColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-analysisrulelist.html#cfn-cleanrooms-configuredtable-analysisrulelist-joincolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? JoinColumns { get; set; }
        }

        public class AthenaTableReference : Humidifier.Base.BaseSubResource, IHaveWorkGroup, IHaveTableName, IHaveDatabaseName, IHaveRegion, IHaveCatalogName, IHaveOutputLocation
        {
            /// <summary>
            /// WorkGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-athenatablereference.html#cfn-cleanrooms-configuredtable-athenatablereference-workgroup
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkGroup { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-athenatablereference.html#cfn-cleanrooms-configuredtable-athenatablereference-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-athenatablereference.html#cfn-cleanrooms-configuredtable-athenatablereference-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-athenatablereference.html#cfn-cleanrooms-configuredtable-athenatablereference-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// CatalogName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-athenatablereference.html#cfn-cleanrooms-configuredtable-athenatablereference-catalogname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogName { get; set; }
            /// <summary>
            /// OutputLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-athenatablereference.html#cfn-cleanrooms-configuredtable-athenatablereference-outputlocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputLocation { get; set; }
        }

        public class ComparisonControls : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedLiteralComparisonColumns, IHaveStringListOfAllowedColumnComparisonColumns
        {
            /// <summary>
            /// AllowedLiteralComparisonColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-comparisoncontrols.html#cfn-cleanrooms-configuredtable-comparisoncontrols-allowedliteralcomparisoncolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedLiteralComparisonColumns { get; set; }
            /// <summary>
            /// AllowedColumnComparisonColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-comparisoncontrols.html#cfn-cleanrooms-configuredtable-comparisoncontrols-allowedcolumncomparisoncolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedColumnComparisonColumns { get; set; }
        }

        public class ConfiguredTableAnalysisRulePolicy : Humidifier.Base.BaseSubResource, IHaveCleanRoomsConfiguredTableTypesConfiguredTableAnalysisRulePolicyV1V1
        {
            /// <summary>
            /// V1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-configuredtableanalysisrulepolicy.html#cfn-cleanrooms-configuredtable-configuredtableanalysisrulepolicy-v1
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConfiguredTableAnalysisRulePolicyV1
            /// </summary>
            public Union<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicyV1, BaseFunction>? V1 { get; set; }
        }

        public class ConfiguredTableAnalysisRulePolicyV1 : Humidifier.Base.BaseSubResource, IHaveCleanRoomsConfiguredTableTypesAnalysisRuleAggregationAggregation, IHaveCleanRoomsConfiguredTableTypesAnalysisRuleListList, IHaveCleanRoomsConfiguredTableTypesAnalysisRuleCustomCustom
        {
            /// <summary>
            /// Aggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-configuredtableanalysisrulepolicyv1.html#cfn-cleanrooms-configuredtable-configuredtableanalysisrulepolicyv1-aggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisRuleAggregation
            /// </summary>
            public Union<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleAggregation, BaseFunction>? Aggregation { get; set; }
            /// <summary>
            /// List
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-configuredtableanalysisrulepolicyv1.html#cfn-cleanrooms-configuredtable-configuredtableanalysisrulepolicyv1-list
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisRuleList
            /// </summary>
            public Union<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleList, BaseFunction>? List { get; set; }
            /// <summary>
            /// Custom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-configuredtableanalysisrulepolicyv1.html#cfn-cleanrooms-configuredtable-configuredtableanalysisrulepolicyv1-custom
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisRuleCustom
            /// </summary>
            public Union<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleCustom, BaseFunction>? Custom { get; set; }
        }

        public class DifferentialPrivacy : Humidifier.Base.BaseSubResource, IHaveListOfCleanRoomsConfiguredTableTypesDifferentialPrivacyColumnColumns
        {
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-differentialprivacy.html#cfn-cleanrooms-configuredtable-differentialprivacy-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DifferentialPrivacyColumn
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacyColumn>, IReadOnlyList<Union<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacyColumn, BaseFunction>>, BaseFunction>? Columns { get; set; }
        }

        public class DifferentialPrivacyColumn : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-differentialprivacycolumn.html#cfn-cleanrooms-configuredtable-differentialprivacycolumn-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class GlueTableReference : Humidifier.Base.BaseSubResource, IHaveTableName, IHaveDatabaseName, IHaveRegion
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-gluetablereference.html#cfn-cleanrooms-configuredtable-gluetablereference-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-gluetablereference.html#cfn-cleanrooms-configuredtable-gluetablereference-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-gluetablereference.html#cfn-cleanrooms-configuredtable-gluetablereference-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
        }

        public class OutputColumnThreshold : Humidifier.Base.BaseSubResource, IHaveMinimumIdentityCount_Integer, IHaveOutputColumnName
        {
            /// <summary>
            /// MinimumIdentityCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-outputcolumnthreshold.html#cfn-cleanrooms-configuredtable-outputcolumnthreshold-minimumidentitycount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumIdentityCount { get; set; }
            /// <summary>
            /// OutputColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-outputcolumnthreshold.html#cfn-cleanrooms-configuredtable-outputcolumnthreshold-outputcolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputColumnName { get; set; }
        }

        public class SnowflakeTableReference : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveTableName, IHaveCleanRoomsConfiguredTableTypesSnowflakeTableSchemaTableSchema, IHaveAccountIdentifier, IHaveDatabaseName, IHaveSchemaName
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-snowflaketablereference.html#cfn-cleanrooms-configuredtable-snowflaketablereference-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-snowflaketablereference.html#cfn-cleanrooms-configuredtable-snowflaketablereference-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// TableSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-snowflaketablereference.html#cfn-cleanrooms-configuredtable-snowflaketablereference-tableschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SnowflakeTableSchema
            /// </summary>
            public Union<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema, BaseFunction>? TableSchema { get; set; }
            /// <summary>
            /// AccountIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-snowflaketablereference.html#cfn-cleanrooms-configuredtable-snowflaketablereference-accountidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountIdentifier { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-snowflaketablereference.html#cfn-cleanrooms-configuredtable-snowflaketablereference-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// SchemaName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-snowflaketablereference.html#cfn-cleanrooms-configuredtable-snowflaketablereference-schemaname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SchemaName { get; set; }
        }

        public class SnowflakeTableSchema : Humidifier.Base.BaseSubResource, IHaveListOfCleanRoomsConfiguredTableTypesSnowflakeTableSchemaV1V1
        {
            /// <summary>
            /// V1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-snowflaketableschema.html#cfn-cleanrooms-configuredtable-snowflaketableschema-v1
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SnowflakeTableSchemaV1
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchemaV1>, IReadOnlyList<Union<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchemaV1, BaseFunction>>, BaseFunction>? V1 { get; set; }
        }

        public class SnowflakeTableSchemaV1 : Humidifier.Base.BaseSubResource, IHaveColumnName, IHaveColumnType
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-snowflaketableschemav1.html#cfn-cleanrooms-configuredtable-snowflaketableschemav1-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnName { get; set; }
            /// <summary>
            /// ColumnType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-snowflaketableschemav1.html#cfn-cleanrooms-configuredtable-snowflaketableschemav1-columntype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnType { get; set; }
        }

        public class TableReference : Humidifier.Base.BaseSubResource, IHaveCleanRoomsConfiguredTableTypesGlueTableReferenceGlue, IHaveCleanRoomsConfiguredTableTypesSnowflakeTableReferenceSnowflake, IHaveCleanRoomsConfiguredTableTypesAthenaTableReferenceAthena
        {
            /// <summary>
            /// Glue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-tablereference.html#cfn-cleanrooms-configuredtable-tablereference-glue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlueTableReference
            /// </summary>
            public Union<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference, BaseFunction>? Glue { get; set; }
            /// <summary>
            /// Snowflake
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-tablereference.html#cfn-cleanrooms-configuredtable-tablereference-snowflake
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnowflakeTableReference
            /// </summary>
            public Union<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableReference, BaseFunction>? Snowflake { get; set; }
            /// <summary>
            /// Athena
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-configuredtable-tablereference.html#cfn-cleanrooms-configuredtable-tablereference-athena
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AthenaTableReference
            /// </summary>
            public Union<Humidifier.CleanRooms.ConfiguredTableTypes.AthenaTableReference, BaseFunction>? Athena { get; set; }
        }
    }
}