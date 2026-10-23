namespace Humidifier.NetworkFirewall
{
    using global::System.Collections.Generic;
    using FirewallTypes;

    public class Firewall : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveFirewallPolicyArn, IHaveDescription, IHaveListOfNetworkFirewallFirewallTypesNatGatewayMappingNatGatewayMappings, IHaveNetworkFirewallFirewallTypesProxySettingsProxySettings, IHaveNoSourcePreservation_Boolean, IHaveSubnetChangeProtection_Boolean, IHaveTransitGatewayId, IHaveAvailabilityZoneChangeProtection_Boolean, IHaveNetworkFirewallFirewallTypesVpcEndpointVpcEndpoint, IHaveFirewallName, IHaveVpcId, IHaveDeleteProtection_Boolean, IHaveFirewallPolicyChangeProtection_Boolean, IHaveListOfNetworkFirewallFirewallTypesAvailabilityZoneMappingAvailabilityZoneMappings, IHaveStringListOfEnabledAnalysisTypes, IHaveListOfNetworkFirewallFirewallTypesSubnetMappingSubnetMappings
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
        public Union<string, BaseFunction>? FirewallPolicyArn { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// NatGatewayMappings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-natgatewaymappings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: NatGatewayMapping
        /// </summary>
        public Union<IReadOnlyList<Humidifier.NetworkFirewall.FirewallTypes.NatGatewayMapping>, IReadOnlyList<Union<Humidifier.NetworkFirewall.FirewallTypes.NatGatewayMapping, BaseFunction>>, BaseFunction>? NatGatewayMappings { get; set; }
        /// <summary>
        /// ProxySettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-proxysettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProxySettings
        /// </summary>
        public Union<Humidifier.NetworkFirewall.FirewallTypes.ProxySettings, BaseFunction>? ProxySettings { get; set; }
        /// <summary>
        /// NoSourcePreservation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-nosourcepreservation
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? NoSourcePreservation { get; set; }
        /// <summary>
        /// SubnetChangeProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-subnetchangeprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SubnetChangeProtection { get; set; }
        /// <summary>
        /// TransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-transitgatewayid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TransitGatewayId { get; set; }
        /// <summary>
        /// AvailabilityZoneChangeProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-availabilityzonechangeprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AvailabilityZoneChangeProtection { get; set; }
        /// <summary>
        /// VpcEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-vpcendpoint
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcEndpoint
        /// </summary>
        public Union<Humidifier.NetworkFirewall.FirewallTypes.VpcEndpoint, BaseFunction>? VpcEndpoint { get; set; }
        public Union<string, BaseFunction>? FirewallName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-vpcid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpcId { get; set; }
        /// <summary>
        /// DeleteProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-deleteprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeleteProtection { get; set; }
        /// <summary>
        /// FirewallPolicyChangeProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-firewallpolicychangeprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? FirewallPolicyChangeProtection { get; set; }
        /// <summary>
        /// AvailabilityZoneMappings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-availabilityzonemappings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AvailabilityZoneMapping
        /// </summary>
        public Union<IReadOnlyList<Humidifier.NetworkFirewall.FirewallTypes.AvailabilityZoneMapping>, IReadOnlyList<Union<Humidifier.NetworkFirewall.FirewallTypes.AvailabilityZoneMapping, BaseFunction>>, BaseFunction>? AvailabilityZoneMappings { get; set; }
        /// <summary>
        /// EnabledAnalysisTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-enabledanalysistypes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EnabledAnalysisTypes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// SubnetMappings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html#cfn-networkfirewall-firewall-subnetmappings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SubnetMapping
        /// </summary>
        public Union<IReadOnlyList<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping>, IReadOnlyList<Union<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping, BaseFunction>>, BaseFunction>? SubnetMappings { get; set; }
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
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        }

        public class ListenerProperty : Humidifier.Base.BaseSubResource, IHaveType, IHavePort_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewall-listenerproperty.html#cfn-networkfirewall-firewall-listenerproperty-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewall-listenerproperty.html#cfn-networkfirewall-firewall-listenerproperty-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
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
            public Union<string, BaseFunction>? NatGatewayId { get; set; }
        }

        public class ProxySettings : Humidifier.Base.BaseSubResource, IHaveListOfNetworkFirewallFirewallTypesListenerPropertyListenerProperties
        {
            /// <summary>
            /// ListenerProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewall-proxysettings.html#cfn-networkfirewall-firewall-proxysettings-listenerproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ListenerProperty
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.FirewallTypes.ListenerProperty>, IReadOnlyList<Union<Humidifier.NetworkFirewall.FirewallTypes.ListenerProperty, BaseFunction>>, BaseFunction>? ListenerProperties { get; set; }
        }

        public class SubnetMapping : Humidifier.Base.BaseSubResource, IHaveIPAddressType, IHaveSubnetId
        {
            /// <summary>
            /// IPAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewall-subnetmapping.html#cfn-networkfirewall-firewall-subnetmapping-ipaddresstype
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IPAddressType { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewall-subnetmapping.html#cfn-networkfirewall-firewall-subnetmapping-subnetid
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
        }

        public class VpcEndpoint : Humidifier.Base.BaseSubResource, IHaveVpcId, IHaveListOfNetworkFirewallFirewallTypesSubnetMappingSubnetMappings
        {
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewall-vpcendpoint.html#cfn-networkfirewall-firewall-vpcendpoint-vpcid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
            /// <summary>
            /// SubnetMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewall-vpcendpoint.html#cfn-networkfirewall-firewall-vpcendpoint-subnetmappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SubnetMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping>, IReadOnlyList<Union<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping, BaseFunction>>, BaseFunction>? SubnetMappings { get; set; }
        }
    }
}