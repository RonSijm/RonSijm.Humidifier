namespace Humidifier.RDS
{
    using global::System.Collections.Generic;

    public class DBParameterGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDBParameterGroupName, IHaveDescription, IHaveParameters_Json, IHaveFamily
    {
        public class Attributes
        {
            public static string DBParameterGroupName =  "DBParameterGroupName" ;
            public static string DBParameterGroupArn =  "DBParameterGroupArn" ;
        }

        public override string AWSTypeName { get => AWS.RDS.DBParameterGroup; }
        public Union<string, BaseFunction>? DBParameterGroupName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbparametergroup.html#cfn-rds-dbparametergroup-description
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbparametergroup.html#cfn-rds-dbparametergroup-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Parameters { get; set; }

        /// <summary>
        /// Family
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbparametergroup.html#cfn-rds-dbparametergroup-family
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Family { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbparametergroup.html#cfn-rds-dbparametergroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}