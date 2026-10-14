namespace Humidifier.Route53
{
    using global::System.Collections.Generic;

    public class TrafficPolicyInstance : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveHostedZoneId, IHaveTTL
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string TrafficPolicyType =  "TrafficPolicyType" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Route53.TrafficPolicyInstance; }

        /// <summary>
        /// TrafficPolicyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-trafficpolicyinstance.html#cfn-route53-trafficpolicyinstance-trafficpolicyid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TrafficPolicyId { get; set; }

        /// <summary>
        /// HostedZoneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-trafficpolicyinstance.html#cfn-route53-trafficpolicyinstance-hostedzoneid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic HostedZoneId { get; set; }

        /// <summary>
        /// TTL
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-trafficpolicyinstance.html#cfn-route53-trafficpolicyinstance-ttl
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic TTL { get; set; }

        /// <summary>
        /// TrafficPolicyVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-trafficpolicyinstance.html#cfn-route53-trafficpolicyinstance-trafficpolicyversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic TrafficPolicyVersion { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}