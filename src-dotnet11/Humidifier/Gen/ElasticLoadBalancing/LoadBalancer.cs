namespace Humidifier.ElasticLoadBalancing
{
    using global::System.Collections.Generic;
    using LoadBalancerTypes;

    public class LoadBalancer : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStringListOfSecurityGroups, IHaveElasticLoadBalancingLoadBalancerTypesConnectionDrainingPolicyConnectionDrainingPolicy, IHaveListOfElasticLoadBalancingLoadBalancerTypesPoliciesPolicies, IHaveScheme, IHaveStringListOfAvailabilityZones, IHaveElasticLoadBalancingLoadBalancerTypesHealthCheckHealthCheck, IHaveElasticLoadBalancingLoadBalancerTypesAccessLoggingPolicyAccessLoggingPolicy, IHaveStringListOfInstances, IHaveLoadBalancerName, IHaveListOfElasticLoadBalancingLoadBalancerTypesListenersListeners, IHaveStringListOfSubnets, IHaveCrossZone_Boolean, IHaveListOfElasticLoadBalancingLoadBalancerTypesAppCookieStickinessPolicyAppCookieStickinessPolicy, IHaveListOfElasticLoadBalancingLoadBalancerTypesLBCookieStickinessPolicyLBCookieStickinessPolicy, IHaveElasticLoadBalancingLoadBalancerTypesConnectionSettingsConnectionSettings
    {
        public class Attributes
        {
            public static string SourceSecurityGroup =  "SourceSecurityGroup" ;
            public static string CanonicalHostedZoneNameID =  "CanonicalHostedZoneNameID" ;
            public static string CanonicalHostedZoneName =  "CanonicalHostedZoneName" ;
            public static string DNSName =  "DNSName" ;
        }

        public override string AWSTypeName { get => AWS.ElasticLoadBalancing.LoadBalancer; }
        /// <summary>
        /// SecurityGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancing-loadbalancer.html#cfn-elasticloadbalancing-loadbalancer-securitygroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
        /// <summary>
        /// ConnectionDrainingPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancing-loadbalancer.html#cfn-elasticloadbalancing-loadbalancer-connectiondrainingpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ConnectionDrainingPolicy
        /// </summary>
        public Union<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.ConnectionDrainingPolicy, BaseFunction>? ConnectionDrainingPolicy { get; set; }
        /// <summary>
        /// Policies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancing-loadbalancer.html#cfn-elasticloadbalancing-loadbalancer-policies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Policies
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.Policies>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.Policies, BaseFunction>>, BaseFunction>? Policies { get; set; }
        /// <summary>
        /// Scheme
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancing-loadbalancer.html#cfn-elasticloadbalancing-loadbalancer-scheme
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Scheme { get; set; }
        /// <summary>
        /// AvailabilityZones
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancing-loadbalancer.html#cfn-elasticloadbalancing-loadbalancer-availabilityzones
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AvailabilityZones { get; set; }
        /// <summary>
        /// HealthCheck
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancing-loadbalancer.html#cfn-elasticloadbalancing-loadbalancer-healthcheck
        /// Required: False
        /// UpdateType: Conditional
        /// Type: HealthCheck
        /// </summary>
        public Union<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.HealthCheck, BaseFunction>? HealthCheck { get; set; }
        /// <summary>
        /// AccessLoggingPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancing-loadbalancer.html#cfn-elasticloadbalancing-loadbalancer-accessloggingpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccessLoggingPolicy
        /// </summary>
        public Union<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.AccessLoggingPolicy, BaseFunction>? AccessLoggingPolicy { get; set; }
        /// <summary>
        /// Instances
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancing-loadbalancer.html#cfn-elasticloadbalancing-loadbalancer-instances
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Instances { get; set; }
        public Union<string, BaseFunction>? LoadBalancerName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Listeners
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancing-loadbalancer.html#cfn-elasticloadbalancing-loadbalancer-listeners
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Listeners
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.Listeners>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.Listeners, BaseFunction>>, BaseFunction>? Listeners { get; set; }
        /// <summary>
        /// Subnets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancing-loadbalancer.html#cfn-elasticloadbalancing-loadbalancer-subnets
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
        /// <summary>
        /// CrossZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancing-loadbalancer.html#cfn-elasticloadbalancing-loadbalancer-crosszone
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? CrossZone { get; set; }
        /// <summary>
        /// AppCookieStickinessPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancing-loadbalancer.html#cfn-elasticloadbalancing-loadbalancer-appcookiestickinesspolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AppCookieStickinessPolicy
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.AppCookieStickinessPolicy>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.AppCookieStickinessPolicy, BaseFunction>>, BaseFunction>? AppCookieStickinessPolicy { get; set; }
        /// <summary>
        /// LBCookieStickinessPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancing-loadbalancer.html#cfn-elasticloadbalancing-loadbalancer-lbcookiestickinesspolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LBCookieStickinessPolicy
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.LBCookieStickinessPolicy>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.LBCookieStickinessPolicy, BaseFunction>>, BaseFunction>? LBCookieStickinessPolicy { get; set; }
        /// <summary>
        /// ConnectionSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancing-loadbalancer.html#cfn-elasticloadbalancing-loadbalancer-connectionsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ConnectionSettings
        /// </summary>
        public Union<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.ConnectionSettings, BaseFunction>? ConnectionSettings { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancing-loadbalancer.html#cfn-elasticloadbalancing-loadbalancer-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace LoadBalancerTypes
    {
        public class AccessLoggingPolicy : Humidifier.Base.BaseSubResource, IHaveEmitInterval_Integer, IHaveS3BucketPrefix, IHaveEnabled_Boolean, IHaveS3BucketName
        {
            /// <summary>
            /// EmitInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-accessloggingpolicy.html#cfn-elasticloadbalancing-loadbalancer-accessloggingpolicy-emitinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EmitInterval { get; set; }
            /// <summary>
            /// S3BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-accessloggingpolicy.html#cfn-elasticloadbalancing-loadbalancer-accessloggingpolicy-s3bucketprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketPrefix { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-accessloggingpolicy.html#cfn-elasticloadbalancing-loadbalancer-accessloggingpolicy-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-accessloggingpolicy.html#cfn-elasticloadbalancing-loadbalancer-accessloggingpolicy-s3bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketName { get; set; }
        }

        public class AppCookieStickinessPolicy : Humidifier.Base.BaseSubResource, IHavePolicyName, IHaveCookieName
        {
            /// <summary>
            /// PolicyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-appcookiestickinesspolicy.html#cfn-elasticloadbalancing-loadbalancer-appcookiestickinesspolicy-policyname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyName { get; set; }
            /// <summary>
            /// CookieName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-appcookiestickinesspolicy.html#cfn-elasticloadbalancing-loadbalancer-appcookiestickinesspolicy-cookiename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CookieName { get; set; }
        }

        public class ConnectionDrainingPolicy : Humidifier.Base.BaseSubResource, IHaveTimeout_Integer, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-connectiondrainingpolicy.html#cfn-elasticloadbalancing-loadbalancer-connectiondrainingpolicy-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Timeout { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-connectiondrainingpolicy.html#cfn-elasticloadbalancing-loadbalancer-connectiondrainingpolicy-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class ConnectionSettings : Humidifier.Base.BaseSubResource, IHaveIdleTimeout_Integer
        {
            /// <summary>
            /// IdleTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-connectionsettings.html#cfn-elasticloadbalancing-loadbalancer-connectionsettings-idletimeout
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IdleTimeout { get; set; }
        }

        public class HealthCheck : Humidifier.Base.BaseSubResource, IHaveTarget, IHaveUnhealthyThreshold, IHaveTimeout, IHaveHealthyThreshold, IHaveInterval
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-healthcheck.html#cfn-elasticloadbalancing-loadbalancer-healthcheck-target
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Target { get; set; }
            /// <summary>
            /// UnhealthyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-healthcheck.html#cfn-elasticloadbalancing-loadbalancer-healthcheck-unhealthythreshold
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnhealthyThreshold { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-healthcheck.html#cfn-elasticloadbalancing-loadbalancer-healthcheck-timeout
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Timeout { get; set; }
            /// <summary>
            /// HealthyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-healthcheck.html#cfn-elasticloadbalancing-loadbalancer-healthcheck-healthythreshold
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HealthyThreshold { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-healthcheck.html#cfn-elasticloadbalancing-loadbalancer-healthcheck-interval
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Interval { get; set; }
        }

        public class LBCookieStickinessPolicy : Humidifier.Base.BaseSubResource, IHaveCookieExpirationPeriod, IHavePolicyName
        {
            /// <summary>
            /// CookieExpirationPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-lbcookiestickinesspolicy.html#cfn-elasticloadbalancing-loadbalancer-lbcookiestickinesspolicy-cookieexpirationperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CookieExpirationPeriod { get; set; }
            /// <summary>
            /// PolicyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-lbcookiestickinesspolicy.html#cfn-elasticloadbalancing-loadbalancer-lbcookiestickinesspolicy-policyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyName { get; set; }
        }

        public class Listeners : Humidifier.Base.BaseSubResource, IHaveStringListOfPolicyNames, IHaveInstancePort, IHaveLoadBalancerPort, IHaveProtocol, IHaveSSLCertificateId, IHaveInstanceProtocol
        {
            /// <summary>
            /// PolicyNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-listeners.html#cfn-elasticloadbalancing-loadbalancer-listeners-policynames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PolicyNames { get; set; }
            /// <summary>
            /// InstancePort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-listeners.html#cfn-elasticloadbalancing-loadbalancer-listeners-instanceport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstancePort { get; set; }
            /// <summary>
            /// LoadBalancerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-listeners.html#cfn-elasticloadbalancing-loadbalancer-listeners-loadbalancerport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LoadBalancerPort { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-listeners.html#cfn-elasticloadbalancing-loadbalancer-listeners-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// SSLCertificateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-listeners.html#cfn-elasticloadbalancing-loadbalancer-listeners-sslcertificateid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SSLCertificateId { get; set; }
            /// <summary>
            /// InstanceProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-listeners.html#cfn-elasticloadbalancing-loadbalancer-listeners-instanceprotocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceProtocol { get; set; }
        }

        public class Policies : Humidifier.Base.BaseSubResource, IHavePolicyType, IHavePolicyName, IHaveListOfElasticLoadBalancingLoadBalancerTypesPolicyItemAttributes_, IHaveStringListOfLoadBalancerPorts, IHaveStringListOfInstancePorts
        {
            /// <summary>
            /// PolicyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-policies.html#cfn-elasticloadbalancing-loadbalancer-policies-policytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyType { get; set; }
            /// <summary>
            /// PolicyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-policies.html#cfn-elasticloadbalancing-loadbalancer-policies-policyname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyName { get; set; }
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-policies.html#cfn-elasticloadbalancing-loadbalancer-policies-attributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PolicyItem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.PolicyItem>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.PolicyItem, BaseFunction>>, BaseFunction>? Attributes_ { get; set; }
            /// <summary>
            /// LoadBalancerPorts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-policies.html#cfn-elasticloadbalancing-loadbalancer-policies-loadbalancerports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LoadBalancerPorts { get; set; }
            /// <summary>
            /// InstancePorts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-policies.html#cfn-elasticloadbalancing-loadbalancer-policies-instanceports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InstancePorts { get; set; }
        }

        public class PolicyItem : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-policyitem.html#cfn-elasticloadbalancing-loadbalancer-policyitem-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-policyitem.html#cfn-elasticloadbalancing-loadbalancer-policyitem-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SourceSecurityGroup : Humidifier.Base.BaseSubResource, IHaveGroupName, IHaveOwnerAlias
        {
            /// <summary>
            /// GroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-sourcesecuritygroup.html#cfn-elasticloadbalancing-loadbalancer-sourcesecuritygroup-groupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupName { get; set; }
            /// <summary>
            /// OwnerAlias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancing-loadbalancer-sourcesecuritygroup.html#cfn-elasticloadbalancing-loadbalancer-sourcesecuritygroup-owneralias
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OwnerAlias { get; set; }
        }
    }
}