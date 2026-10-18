namespace Humidifier.S3Tables
{
    using global::System.Collections.Generic;

    public class TablePolicy : Humidifier.Base.BaseResource, IHaveTableARN, IHaveResourcePolicy_Json
    {
        public class Attributes
        {
            public static string TableName =  "TableName" ;
            public static string TableBucketARN =  "TableBucketARN" ;
            public static string Namespace =  "Namespace" ;
        }

        public override string AWSTypeName { get => AWS.S3Tables.TablePolicy; }

        /// <summary>
        /// TableARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-tablepolicy.html#cfn-s3tables-tablepolicy-tablearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TableARN { get; set; }

        /// <summary>
        /// ResourcePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-tablepolicy.html#cfn-s3tables-tablepolicy-resourcepolicy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? ResourcePolicy { get; set; }
    }
}