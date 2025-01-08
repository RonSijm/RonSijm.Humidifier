namespace Humidifier.Route53RecoveryReadiness
{
    using System.Collections.Generic;

    public class RecoveryGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCells
    {
        public class Attributes
        {
            public static string RecoveryGroupArn =  "RecoveryGroupArn" ;
        }

        public override string AWSTypeName { get => AWS.Route53RecoveryReadiness.RecoveryGroup; }
        public dynamic RecoveryGroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Cells
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-recoverygroup.html#cfn-route53recoveryreadiness-recoverygroup-cells
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Cells { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-recoverygroup.html#cfn-route53recoveryreadiness-recoverygroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}