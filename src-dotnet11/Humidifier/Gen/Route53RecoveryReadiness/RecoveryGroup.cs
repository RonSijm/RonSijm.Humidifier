namespace Humidifier.Route53RecoveryReadiness
{
    using global::System.Collections.Generic;

    public class RecoveryGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRecoveryGroupName, IHaveStringListOfCells
    {
        public class Attributes
        {
            public static string RecoveryGroupArn =  "RecoveryGroupArn" ;
        }

        public override string AWSTypeName { get => AWS.Route53RecoveryReadiness.RecoveryGroup; }
        public Union<string, BaseFunction>? RecoveryGroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Cells
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-recoverygroup.html#cfn-route53recoveryreadiness-recoverygroup-cells
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Cells { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-recoverygroup.html#cfn-route53recoveryreadiness-recoverygroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}