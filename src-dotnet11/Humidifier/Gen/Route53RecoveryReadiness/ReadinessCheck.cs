namespace Humidifier.Route53RecoveryReadiness
{
    using global::System.Collections.Generic;

    public class ReadinessCheck : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveResourceSetName, IHaveReadinessCheckName
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
        public Union<string, BaseFunction>? ResourceSetName { get; set; }
        public Union<string, BaseFunction>? ReadinessCheckName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-readinesscheck.html#cfn-route53recoveryreadiness-readinesscheck-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}