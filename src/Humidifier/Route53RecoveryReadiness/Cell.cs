namespace Humidifier.Route53RecoveryReadiness
{
    using System.Collections.Generic;

    public class Cell : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string ParentReadinessScopes =  "ParentReadinessScopes" ;
            public static string CellArn =  "CellArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Route53RecoveryReadiness::Cell";
            }
        }

        /// <summary>
        /// CellName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-cell.html#cfn-route53recoveryreadiness-cell-cellname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CellName { get; set; }
        /// <summary>
        /// Cells
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-cell.html#cfn-route53recoveryreadiness-cell-cells
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Cells { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-cell.html#cfn-route53recoveryreadiness-cell-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}