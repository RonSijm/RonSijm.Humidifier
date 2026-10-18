namespace Humidifier.NetworkFirewall
{
    using global::System.Collections.Generic;
    using VpcEndpointAssociationTypes;

    public class VpcEndpointAssociation : Humidifier.Base.BaseResource, IHaveTags, IHaveNetworkFirewallVpcEndpointAssociationTypesSubnetMappingSubnetMapping, IHaveDescription, IHaveVpcId, IHaveFirewallArn
    {
        public class Attributes
        {
            public static string VpcEndpointAssociationId =  "VpcEndpointAssociationId" ;
            public static string EndpointId =  "EndpointId" ;
            public static string VpcEndpointAssociationArn =  "VpcEndpointAssociationArn" ;
        }

        public override string AWSTypeName { get => AWS.NetworkFirewall.VpcEndpointAssociation; }

        /// <summary>
        /// SubnetMapping
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-vpcendpointassociation.html#cfn-networkfirewall-vpcendpointassociation-subnetmapping
        /// Required: True
        /// UpdateType: Immutable
        /// Type: SubnetMapping
        /// </summary>
        [Required]
        public Union<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping, BaseFunction>? SubnetMapping { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-vpcendpointassociation.html#cfn-networkfirewall-vpcendpointassociation-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-vpcendpointassociation.html#cfn-networkfirewall-vpcendpointassociation-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpcId { get; set; }

        /// <summary>
        /// FirewallArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-vpcendpointassociation.html#cfn-networkfirewall-vpcendpointassociation-firewallarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FirewallArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-vpcendpointassociation.html#cfn-networkfirewall-vpcendpointassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace VpcEndpointAssociationTypes
    {
        public class SubnetMapping : Humidifier.Base.BaseSubResource, IHaveIPAddressType, IHaveSubnetId
        {
            /// <summary>
            /// IPAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-vpcendpointassociation-subnetmapping.html#cfn-networkfirewall-vpcendpointassociation-subnetmapping-ipaddresstype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IPAddressType { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-vpcendpointassociation-subnetmapping.html#cfn-networkfirewall-vpcendpointassociation-subnetmapping-subnetid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
        }
    }
}