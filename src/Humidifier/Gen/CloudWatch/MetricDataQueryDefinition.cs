namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;

    public class MetricDataQueryDefinition : Humidifier.Base.BaseResource, IHaveTags, IHaveType, IHaveExpression, IHavePath
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.CloudWatch.MetricDataQueryDefinition; }

        /// <summary>
        /// Path
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-metricdataquerydefinition.html#cfn-cloudwatch-metricdataquerydefinition-path
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Path { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-metricdataquerydefinition.html#cfn-cloudwatch-metricdataquerydefinition-type
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }

        /// <summary>
        /// Expression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-metricdataquerydefinition.html#cfn-cloudwatch-metricdataquerydefinition-expression
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Expression { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-metricdataquerydefinition.html#cfn-cloudwatch-metricdataquerydefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}