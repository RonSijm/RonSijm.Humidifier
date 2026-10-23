namespace Humidifier.NetworkFirewall
{
    using global::System.Collections.Generic;
    using FirewallTypes;

    public class Firewall : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveVpcId, IHaveTransitGatewayId, IHaveFirewallName
    {
        public class Attributes
        {
            public static string NumberOfAssociations =  "NumberOfAssociations" ;
            public static string FirewallArn =  "FirewallArn" ;
            public static string EndpointIds =  "EndpointIds" ;
            public static string FirewallId =  "FirewallId" ;
            public static string TransitGatewayAttachmentId =  "TransitGatewayAttachmentId" ;
        }

        public override string AWSTypeName { get => AWS.NetworkFirewall.Firewall; }

        /// <summary>
        /// FirewallPolicyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-firewallpolicyarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FirewallPolicyArn { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// NatGatewayMappings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-natgatewaymappings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: NatGatewayMapping
        /// </summary>
        public List<Humidifier.NetworkFirewall.FirewallTypes.NatGatewayMapping> NatGatewayMappings { get; set; }
        /// <summary>
        /// ProxySettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-proxysettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProxySettings
        /// </summary>
        public Humidifier.NetworkFirewall.FirewallTypes.ProxySettings ProxySettings { get; set; }
        /// <summary>
        /// NoSourcePreservation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-nosourcepreservation
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic NoSourcePreservation { get; set; }
        /// <summary>
        /// SubnetChangeProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-subnetchangeprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic SubnetChangeProtection { get; set; }
        /// <summary>
        /// TransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-transitgatewayid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TransitGatewayId { get; set; }
        /// <summary>
        /// AvailabilityZoneChangeProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-availabilityzonechangeprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AvailabilityZoneChangeProtection { get; set; }
        /// <summary>
        /// VpcEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-vpcendpoint
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcEndpoint
        /// </summary>
        public Humidifier.NetworkFirewall.FirewallTypes.VpcEndpoint VpcEndpoint { get; set; }
        public dynamic FirewallName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-vpcid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VpcId { get; set; }
        /// <summary>
        /// DeleteProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-deleteprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DeleteProtection { get; set; }
        /// <summary>
        /// FirewallPolicyChangeProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-firewallpolicychangeprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic FirewallPolicyChangeProtection { get; set; }
        /// <summary>
        /// AvailabilityZoneMappings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-availabilityzonemappings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AvailabilityZoneMapping
        /// </summary>
        public List<Humidifier.NetworkFirewall.FirewallTypes.AvailabilityZoneMapping> AvailabilityZoneMappings { get; set; }
        /// <summary>
        /// EnabledAnalysisTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-enabledanalysistypes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic EnabledAnalysisTypes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// SubnetMappings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-subnetmappings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SubnetMapping
        /// </summary>
        public List<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> SubnetMappings { get; set; }
    }

    namespace FirewallTypes
    {
        public class AvailabilityZoneMapping : Humidifier.Base.BaseSubResource, IHaveAvailabilityZone
        {
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewall-availabilityzonemapping.html#cfn-networkfirewall-firewall-availabilityzonemapping-availabilityzone
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityZone { get; set; }
        }

        public class ListenerProperty : Humidifier.Base.BaseSubResource, IHaveType, IHavePort
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewall-listenerproperty.html#cfn-networkfirewall-firewall-listenerproperty-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewall-listenerproperty.html#cfn-networkfirewall-firewall-listenerproperty-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
        }

        public class NatGatewayMapping : Humidifier.Base.BaseSubResource, IHaveNatGatewayId
        {
            /// <summary>
            /// NatGatewayId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewall-natgatewaymapping.html#cfn-networkfirewall-firewall-natgatewaymapping-natgatewayid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NatGatewayId { get; set; }
        }

        public class ProxySettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ListenerProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewall-proxysettings.html#cfn-networkfirewall-firewall-proxysettings-listenerproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ListenerProperty
            /// </summary>
            public List<Humidifier.NetworkFirewall.FirewallTypes.ListenerProperty> ListenerProperties { get; set; }
        }

        public class SubnetMapping : Humidifier.Base.BaseSubResource, IHaveSubnetId, IHaveIPAddressType
        {
            /// <summary>
            /// IPAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewall-subnetmapping.html#cfn-networkfirewall-firewall-subnetmapping-ipaddresstype
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic IPAddressType { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewall-subnetmapping.html#cfn-networkfirewall-firewall-subnetmapping-subnetid
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubnetId { get; set; }
        }

        public class VpcEndpoint : Humidifier.Base.BaseSubResource, IHaveVpcId
        {
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewall-vpcendpoint.html#cfn-networkfirewall-firewall-vpcendpoint-vpcid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcId { get; set; }
            /// <summary>
            /// SubnetMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewall-vpcendpoint.html#cfn-networkfirewall-firewall-vpcendpoint-subnetmappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SubnetMapping
            /// </summary>
            public List<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> SubnetMappings { get; set; }
        }
    }
}