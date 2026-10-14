namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using RouterNetworkInterfaceTypes;

    public class RouterNetworkInterface : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveRegionName
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
        public Humidifier.MediaConnect.RouterNetworkInterfaceTypes.RouterNetworkInterfaceConfiguration Configuration { get; set; }
        /// <summary>
        /// RegionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routernetworkinterface.html#cfn-mediaconnect-routernetworkinterface-regionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RegionName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routernetworkinterface.html#cfn-mediaconnect-routernetworkinterface-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace RouterNetworkInterfaceTypes
    {
        public class PublicRouterNetworkInterfaceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AllowRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routernetworkinterface-publicrouternetworkinterfaceconfiguration.html#cfn-mediaconnect-routernetworkinterface-publicrouternetworkinterfaceconfiguration-allowrules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PublicRouterNetworkInterfaceRule
            /// </summary>
            public List<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.PublicRouterNetworkInterfaceRule> AllowRules { get; set; }
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
            public dynamic Cidr { get; set; }
        }

        public class RouterNetworkInterfaceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Vpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routernetworkinterface-routernetworkinterfaceconfiguration.html#cfn-mediaconnect-routernetworkinterface-routernetworkinterfaceconfiguration-vpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcRouterNetworkInterfaceConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterNetworkInterfaceTypes.VpcRouterNetworkInterfaceConfiguration Vpc { get; set; }
            /// <summary>
            /// Public
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routernetworkinterface-routernetworkinterfaceconfiguration.html#cfn-mediaconnect-routernetworkinterface-routernetworkinterfaceconfiguration-public
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PublicRouterNetworkInterfaceConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterNetworkInterfaceTypes.PublicRouterNetworkInterfaceConfiguration Public { get; set; }
        }

        public class VpcRouterNetworkInterfaceConfiguration : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetId
        {
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routernetworkinterface-vpcrouternetworkinterfaceconfiguration.html#cfn-mediaconnect-routernetworkinterface-vpcrouternetworkinterfaceconfiguration-subnetid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubnetId { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routernetworkinterface-vpcrouternetworkinterfaceconfiguration.html#cfn-mediaconnect-routernetworkinterface-vpcrouternetworkinterfaceconfiguration-securitygroupids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }
    }
}