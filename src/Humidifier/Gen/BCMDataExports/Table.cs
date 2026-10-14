namespace Humidifier.BCMDataExports
{
    using global::System.Collections.Generic;
    using TableTypes;

    public class Table : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTableName
    {
        public class Attributes
        {
            public static string Description =  "Description" ;
            public static string Schema =  "Schema" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.BCMDataExports.Table; }
        public dynamic TableName { get => GivenName; set => GivenName = value; }
    }

    namespace TableTypes
    {
        public class Column : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-table-column.html#cfn-bcmdataexports-table-column-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-table-column.html#cfn-bcmdataexports-table-column-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-table-column.html#cfn-bcmdataexports-table-column-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}