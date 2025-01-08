namespace Humidifier.Route53RecoveryReadiness
{
    using System.Collections.Generic;

    public class ReadinessCheck : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveResourceSetName
    {
        public class Attributes
        {
            public static string ReadinessCheckArn =  "ReadinessCheckArn" ;
        }

        public override string AWSTypeName { get => AWS.Route53RecoveryReadiness.ReadinessCheck; }
        /// <summary>
        /// ResourceSetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-readinesscheck.html#cfn-route53recoveryreadiness-readinesscheck-resourcesetname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceSetName { get; set; }
        public dynamic ReadinessCheckName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-readinesscheck.html#cfn-route53recoveryreadiness-readinesscheck-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}