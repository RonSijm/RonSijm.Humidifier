namespace Humidifier.Route53Resolver
{
    using global::System.Collections.Generic;
    using ResolverRuleTypes;

    public class ResolverRule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveResolverEndpointId, IHaveDomainName, IHaveRuleType, IHaveDelegationRecord, IHaveListOfRoute53ResolverResolverRuleTypesTargetAddressTargetIps, IHaveName
    {
        public class Attributes
        {
            public static string ResolverEndpointId =  "ResolverEndpointId" ;
            public static string DomainName =  "DomainName" ;
            public static string ResolverRuleId =  "ResolverRuleId" ;
            public static string Arn =  "Arn" ;
            public static string TargetIps =  "TargetIps" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Route53Resolver.ResolverRule; }
        /// <summary>
        /// ResolverEndpointId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverrule.html#cfn-route53resolver-resolverrule-resolverendpointid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResolverEndpointId { get; set; }
        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverrule.html#cfn-route53resolver-resolverrule-domainname
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DomainName { get; set; }

        /// <summary>
        /// RuleType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverrule.html#cfn-route53resolver-resolverrule-ruletype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuleType { get; set; }
        /// <summary>
        /// DelegationRecord
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverrule.html#cfn-route53resolver-resolverrule-delegationrecord
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DelegationRecord { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverrule.html#cfn-route53resolver-resolverrule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// TargetIps
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverrule.html#cfn-route53resolver-resolverrule-targetips
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TargetAddress
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress>, IReadOnlyList<Union<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress, BaseFunction>>, BaseFunction>? TargetIps { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ResolverRuleTypes
    {
        public class TargetAddress : Humidifier.Base.BaseSubResource, IHaveIpv6, IHaveIp, IHavePort, IHaveProtocol, IHaveServerNameIndication
        {
            /// <summary>
            /// Ipv6
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-resolverrule-targetaddress.html#cfn-route53resolver-resolverrule-targetaddress-ipv6
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ipv6 { get; set; }
            /// <summary>
            /// Ip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-resolverrule-targetaddress.html#cfn-route53resolver-resolverrule-targetaddress-ip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ip { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-resolverrule-targetaddress.html#cfn-route53resolver-resolverrule-targetaddress-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-resolverrule-targetaddress.html#cfn-route53resolver-resolverrule-targetaddress-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// ServerNameIndication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-resolverrule-targetaddress.html#cfn-route53resolver-resolverrule-targetaddress-servernameindication
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerNameIndication { get; set; }
        }
    }
}