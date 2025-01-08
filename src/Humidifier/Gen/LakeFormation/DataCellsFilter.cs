namespace Humidifier.LakeFormation
{
    using System.Collections.Generic;
    using DataCellsFilterTypes;

    public class DataCellsFilter : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDatabaseName, IHaveTableName, IHaveColumnNames, IHaveTableCatalogId
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
        public dynamic TableName { get; set; }
        /// <summary>
        /// ColumnNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datacellsfilter.html#cfn-lakeformation-datacellsfilter-columnnames
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic ColumnNames { get; set; }
        /// <summary>
        /// RowFilter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datacellsfilter.html#cfn-lakeformation-datacellsfilter-rowfilter
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RowFilter
        /// </summary>
        public Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter RowFilter { get; set; }

        /// <summary>
        /// DatabaseName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datacellsfilter.html#cfn-lakeformation-datacellsfilter-databasename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DatabaseName { get; set; }

        /// <summary>
        /// TableCatalogId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datacellsfilter.html#cfn-lakeformation-datacellsfilter-tablecatalogid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TableCatalogId { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ColumnWildcard
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datacellsfilter.html#cfn-lakeformation-datacellsfilter-columnwildcard
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ColumnWildcard
        /// </summary>
        public Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard ColumnWildcard { get; set; }
    }

    namespace DataCellsFilterTypes
    {
        public class ColumnWildcard : Humidifier.Base.BaseSubResource, IHaveExcludedColumnNames
        {
            /// <summary>
            /// ExcludedColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-datacellsfilter-columnwildcard.html#cfn-lakeformation-datacellsfilter-columnwildcard-excludedcolumnnames
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludedColumnNames { get; set; }
        }

        public class RowFilter : Humidifier.Base.BaseSubResource, IHaveFilterExpression
        {
            /// <summary>
            /// AllRowsWildcard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-datacellsfilter-rowfilter.html#cfn-lakeformation-datacellsfilter-rowfilter-allrowswildcard
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AllRowsWildcard { get; set; }
            /// <summary>
            /// FilterExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-datacellsfilter-rowfilter.html#cfn-lakeformation-datacellsfilter-rowfilter-filterexpression
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterExpression { get; set; }
        }
    }
}