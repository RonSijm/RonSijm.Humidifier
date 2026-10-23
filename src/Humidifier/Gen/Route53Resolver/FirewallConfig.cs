namespace Humidifier.Route53Resolver
{
    using global::System.Collections.Generic;

    public class FirewallConfig : Humidifier.Base.BaseResource, IHaveResourceId
    {
        public class Attributes
        {
            public static string OwnerId =  "OwnerId" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Route53Resolver.FirewallConfig; }

        /// <summary>
        /// ResourceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallconfig.html#cfn-route53resolver-firewallconfig-resourceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceId { get; set; }

        /// <summary>
        /// FirewallFailOpen
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallconfig.html#cfn-route53resolver-firewallconfig-firewallfailopen
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FirewallFailOpen { get; set; }
    }
}