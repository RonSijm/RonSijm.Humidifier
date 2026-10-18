namespace Humidifier.Glue
{
    using global::System.Collections.Generic;

    public class TableVersion : Humidifier.Base.BaseResource, IHaveTableName, IHaveDatabaseName
    {
        public class Attributes
        {
            public static string VersionId =  "VersionId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Glue.TableVersion; }
        /// <summary>
        /// TableName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-tableversion.html#cfn-glue-tableversion-tablename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TableName { get; set; }
        /// <summary>
        /// DatabaseName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-tableversion.html#cfn-glue-tableversion-databasename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DatabaseName { get; set; }
    }
}