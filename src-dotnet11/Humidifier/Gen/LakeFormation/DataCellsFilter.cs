namespace Humidifier.LakeFormation
{
    using global::System.Collections.Generic;
    using DataCellsFilterTypes;

    public class DataCellsFilter : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTableName, IHaveStringListOfColumnNames, IHaveLakeFormationDataCellsFilterTypesRowFilterRowFilter, IHaveDatabaseName, IHaveTableCatalogId, IHaveName, IHaveLakeFormationDataCellsFilterTypesColumnWildcardColumnWildcard
    {
        public override string AWSTypeName { get => AWS.LakeFormation.DataCellsFilter; }

        /// <summary>
        /// TableName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datacellsfilter.html#cfn-lakeformation-datacellsfilter-tablename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TableName { get; set; }
        /// <summary>
        /// ColumnNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datacellsfilter.html#cfn-lakeformation-datacellsfilter-columnnames
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ColumnNames { get; set; }
        /// <summary>
        /// RowFilter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datacellsfilter.html#cfn-lakeformation-datacellsfilter-rowfilter
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RowFilter
        /// </summary>
        public Union<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter, BaseFunction>? RowFilter { get; set; }

        /// <summary>
        /// DatabaseName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datacellsfilter.html#cfn-lakeformation-datacellsfilter-databasename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DatabaseName { get; set; }

        /// <summary>
        /// TableCatalogId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datacellsfilter.html#cfn-lakeformation-datacellsfilter-tablecatalogid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TableCatalogId { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ColumnWildcard
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datacellsfilter.html#cfn-lakeformation-datacellsfilter-columnwildcard
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ColumnWildcard
        /// </summary>
        public Union<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard, BaseFunction>? ColumnWildcard { get; set; }
    }

    namespace DataCellsFilterTypes
    {
        public class ColumnWildcard : Humidifier.Base.BaseSubResource, IHaveStringListOfExcludedColumnNames
        {
            /// <summary>
            /// ExcludedColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-datacellsfilter-columnwildcard.html#cfn-lakeformation-datacellsfilter-columnwildcard-excludedcolumnnames
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludedColumnNames { get; set; }
        }

        public class RowFilter : Humidifier.Base.BaseSubResource, IHaveAllRowsWildcard_Json, IHaveFilterExpression
        {
            /// <summary>
            /// AllRowsWildcard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-datacellsfilter-rowfilter.html#cfn-lakeformation-datacellsfilter-rowfilter-allrowswildcard
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AllRowsWildcard { get; set; }
            /// <summary>
            /// FilterExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-datacellsfilter-rowfilter.html#cfn-lakeformation-datacellsfilter-rowfilter-filterexpression
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilterExpression { get; set; }
        }
    }
}