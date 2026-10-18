namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using RouterNetworkInterfaceTypes;

    public class RouterNetworkInterface : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMediaConnectRouterNetworkInterfaceTypesRouterNetworkInterfaceConfigurationConfiguration, IHaveRegionName, IHaveName
    {
        public class Attributes
        {
            public static string AssociatedInputCount =  "AssociatedInputCount" ;
            public static string AssociatedOutputCount =  "AssociatedOutputCount" ;
            public static string NetworkInterfaceType =  "NetworkInterfaceType" ;
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.MediaConnect.RouterNetworkInterface; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routernetworkinterface.html#cfn-mediaconnect-routernetworkinterface-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RouterNetworkInterfaceConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.RouterNetworkInterfaceConfiguration, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// RegionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routernetworkinterface.html#cfn-mediaconnect-routernetworkinterface-regionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RegionName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routernetworkinterface.html#cfn-mediaconnect-routernetworkinterface-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RouterNetworkInterfaceTypes
    {
        public class PublicRouterNetworkInterfaceConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfMediaConnectRouterNetworkInterfaceTypesPublicRouterNetworkInterfaceRuleAllowRules
        {
            /// <summary>
            /// AllowRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routernetworkinterface-publicrouternetworkinterfaceconfiguration.html#cfn-mediaconnect-routernetworkinterface-publicrouternetworkinterfaceconfiguration-allowrules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PublicRouterNetworkInterfaceRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.PublicRouterNetworkInterfaceRule>, IReadOnlyList<Union<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.PublicRouterNetworkInterfaceRule, BaseFunction>>, BaseFunction>? AllowRules { get; set; }
        }

        public class PublicRouterNetworkInterfaceRule : Humidifier.Base.BaseSubResource, IHaveCidr
        {
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routernetworkinterface-publicrouternetworkinterfacerule.html#cfn-mediaconnect-routernetworkinterface-publicrouternetworkinterfacerule-cidr
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cidr { get; set; }
        }

        public class RouterNetworkInterfaceConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterNetworkInterfaceTypesVpcRouterNetworkInterfaceConfigurationVpc, IHaveMediaConnectRouterNetworkInterfaceTypesPublicRouterNetworkInterfaceConfigurationPublic
        {
            /// <summary>
            /// Vpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routernetworkinterface-routernetworkinterfaceconfiguration.html#cfn-mediaconnect-routernetworkinterface-routernetworkinterfaceconfiguration-vpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcRouterNetworkInterfaceConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.VpcRouterNetworkInterfaceConfiguration, BaseFunction>? Vpc { get; set; }
            /// <summary>
            /// Public
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routernetworkinterface-routernetworkinterfaceconfiguration.html#cfn-mediaconnect-routernetworkinterface-routernetworkinterfaceconfiguration-public
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PublicRouterNetworkInterfaceConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.PublicRouterNetworkInterfaceConfiguration, BaseFunction>? Public { get; set; }
        }

        public class VpcRouterNetworkInterfaceConfiguration : Humidifier.Base.BaseSubResource, IHaveSubnetId, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routernetworkinterface-vpcrouternetworkinterfaceconfiguration.html#cfn-mediaconnect-routernetworkinterface-vpcrouternetworkinterfaceconfiguration-subnetid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routernetworkinterface-vpcrouternetworkinterfaceconfiguration.html#cfn-mediaconnect-routernetworkinterface-vpcrouternetworkinterfaceconfiguration-securitygroupids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}