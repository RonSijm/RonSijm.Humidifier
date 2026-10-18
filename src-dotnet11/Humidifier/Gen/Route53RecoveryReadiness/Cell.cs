namespace Humidifier.Route53RecoveryReadiness
{
    using global::System.Collections.Generic;

    public class Cell : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCellName, IHaveStringListOfCells
    {
        public class Attributes
        {
            public static string ParentReadinessScopes =  "ParentReadinessScopes" ;
            public static string CellArn =  "CellArn" ;
        }

        public override string AWSTypeName { get => AWS.Route53RecoveryReadiness.Cell; }
        public Union<string, BaseFunction>? CellName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Cells
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-cell.html#cfn-route53recoveryreadiness-cell-cells
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Cells { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-cell.html#cfn-route53recoveryreadiness-cell-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}