namespace Humidifier.CodeConnections
{
    using global::System.Collections.Generic;
    using HostTypes;

    public class Host : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveProviderEndpoint, IHaveProviderType, IHaveCodeConnectionsHostTypesVpcConfigurationVpcConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string HostArn =  "HostArn" ;
            public static string HostId =  "HostId" ;
        }

        public override string AWSTypeName { get => AWS.CodeConnections.Host; }

        /// <summary>
        /// ProviderEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeconnections-host.html#cfn-codeconnections-host-providerendpoint
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProviderEndpoint { get; set; }

        /// <summary>
        /// ProviderType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeconnections-host.html#cfn-codeconnections-host-providertype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProviderType { get; set; }
        /// <summary>
        /// VpcConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeconnections-host.html#cfn-codeconnections-host-vpcconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcConfiguration
        /// </summary>
        public Union<Humidifier.CodeConnections.HostTypes.VpcConfiguration, BaseFunction>? VpcConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeconnections-host.html#cfn-codeconnections-host-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace HostTypes
    {
        public class VpcConfiguration : Humidifier.Base.BaseSubResource, IHaveVpcId, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds, IHaveTlsCertificate
        {
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeconnections-host-vpcconfiguration.html#cfn-codeconnections-host-vpcconfiguration-vpcid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeconnections-host-vpcconfiguration.html#cfn-codeconnections-host-vpcconfiguration-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeconnections-host-vpcconfiguration.html#cfn-codeconnections-host-vpcconfiguration-securitygroupids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// TlsCertificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeconnections-host-vpcconfiguration.html#cfn-codeconnections-host-vpcconfiguration-tlscertificate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TlsCertificate { get; set; }
        }
    }
}