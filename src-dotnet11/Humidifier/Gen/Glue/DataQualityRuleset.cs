namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using DataQualityRulesetTypes;

    public class DataQualityRuleset : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveRuleset, IHaveDescription, IHaveGlueDataQualityRulesetTypesDataQualityTargetTableTargetTable, IHaveClientToken, IHaveStringDictionaryOfTags, IHaveName
    {
        public override string AWSTypeName { get => AWS.Glue.DataQualityRuleset; }
        /// <summary>
        /// Ruleset
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-dataqualityruleset.html#cfn-glue-dataqualityruleset-ruleset
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Ruleset { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-dataqualityruleset.html#cfn-glue-dataqualityruleset-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// TargetTable
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-dataqualityruleset.html#cfn-glue-dataqualityruleset-targettable
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataQualityTargetTable
        /// </summary>
        public Union<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable, BaseFunction>? TargetTable { get; set; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-dataqualityruleset.html#cfn-glue-dataqualityruleset-clienttoken
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientToken { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-dataqualityruleset.html#cfn-glue-dataqualityruleset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DataQualityRulesetTypes
    {
        public class DataQualityTargetTable : Humidifier.Base.BaseSubResource, IHaveTableName, IHaveDatabaseName
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-dataqualityruleset-dataqualitytargettable.html#cfn-glue-dataqualityruleset-dataqualitytargettable-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-dataqualityruleset-dataqualitytargettable.html#cfn-glue-dataqualityruleset-dataqualitytargettable-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
        }
    }
}