namespace Humidifier.WAF
{
    using global::System.Collections.Generic;
    using SqlInjectionMatchSetTypes;

    public class SqlInjectionMatchSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveListOfWAFSqlInjectionMatchSetTypesSqlInjectionMatchTupleSqlInjectionMatchTuples
    {
        public override string AWSTypeName { get => AWS.WAF.SqlInjectionMatchSet; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// SqlInjectionMatchTuples
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sqlinjectionmatchset.html#cfn-waf-sqlinjectionmatchset-sqlinjectionmatchtuples
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SqlInjectionMatchTuple
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WAF.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple>, IReadOnlyList<Union<Humidifier.WAF.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple, BaseFunction>>, BaseFunction>? SqlInjectionMatchTuples { get; set; }
    }

    namespace SqlInjectionMatchSetTypes
    {
        public class FieldToMatch : Humidifier.Base.BaseSubResource, IHaveData, IHaveType
        {
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples-fieldtomatch.html#cfn-waf-sizeconstraintset-sizeconstraint-fieldtomatch-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Data { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples-fieldtomatch.html#cfn-waf-sizeconstraintset-sizeconstraint-fieldtomatch-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class SqlInjectionMatchTuple : Humidifier.Base.BaseSubResource, IHaveWAFSqlInjectionMatchSetTypesFieldToMatchFieldToMatch, IHaveTextTransformation
        {
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-sqlinjectionmatchset-sqlinjectionmatchtuples.html#cfn-waf-sqlinjectionmatchset-sqlinjectionmatchtuples-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAF.SqlInjectionMatchSetTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
            /// <summary>
            /// TextTransformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-sqlinjectionmatchset-sqlinjectionmatchtuples.html#cfn-waf-sqlinjectionmatchset-sqlinjectionmatchtuples-texttransformation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextTransformation { get; set; }
        }
    }
}