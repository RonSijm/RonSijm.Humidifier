namespace Humidifier.Route53RecoveryReadiness
{
    using System.Collections.Generic;

    public class RecoveryGroup : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string RecoveryGroupArn =  "RecoveryGroupArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Route53RecoveryReadiness::RecoveryGroup";
            }
        }

        /// <summary>
        /// RecoveryGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-recoverygroup.html#cfn-route53recoveryreadiness-recoverygroup-recoverygroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RecoveryGroupName { get; set; }
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