namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using IPAMTypes;

    public class IPAM : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfEC2IPAMTypesIpamOrganizationalUnitExclusionDefaultResourceDiscoveryOrganizationalUnitExclusions, IHaveDescription, IHaveMeteredAccount, IHaveTier, IHaveEnablePrivateGua_Boolean, IHaveListOfEC2IPAMTypesIpamOperatingRegionOperatingRegions
    {
        public class Attributes
        {
            public static string DefaultResourceDiscoveryAssociationId =  "DefaultResourceDiscoveryAssociationId" ;
            public static string DefaultResourceDiscoveryId =  "DefaultResourceDiscoveryId" ;
            public static string IpamId =  "IpamId" ;
            public static string ResourceDiscoveryAssociationCount =  "ResourceDiscoveryAssociationCount" ;
            public static string ScopeCount =  "ScopeCount" ;
            public static string Arn =  "Arn" ;
            public static string PrivateDefaultScopeId =  "PrivateDefaultScopeId" ;
            public static string PublicDefaultScopeId =  "PublicDefaultScopeId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.IPAM; }
        /// <summary>
        /// DefaultResourceDiscoveryOrganizationalUnitExclusions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipam.html#cfn-ec2-ipam-defaultresourcediscoveryorganizationalunitexclusions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IpamOrganizationalUnitExclusion
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion>, IReadOnlyList<Union<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion, BaseFunction>>, BaseFunction>? DefaultResourceDiscoveryOrganizationalUnitExclusions { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipam.html#cfn-ec2-ipam-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// MeteredAccount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipam.html#cfn-ec2-ipam-meteredaccount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MeteredAccount { get; set; }
        /// <summary>
        /// Tier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipam.html#cfn-ec2-ipam-tier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Tier { get; set; }
        /// <summary>
        /// EnablePrivateGua
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipam.html#cfn-ec2-ipam-enableprivategua
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnablePrivateGua { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipam.html#cfn-ec2-ipam-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// OperatingRegions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipam.html#cfn-ec2-ipam-operatingregions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IpamOperatingRegion
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.IPAMTypes.IpamOperatingRegion>, IReadOnlyList<Union<Humidifier.EC2.IPAMTypes.IpamOperatingRegion, BaseFunction>>, BaseFunction>? OperatingRegions { get; set; }
    }

    namespace IPAMTypes
    {
        public class IpamOperatingRegion : Humidifier.Base.BaseSubResource, IHaveRegionName
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipam-ipamoperatingregion.html#cfn-ec2-ipam-ipamoperatingregion-regionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegionName { get; set; }
        }

        public class IpamOrganizationalUnitExclusion : Humidifier.Base.BaseSubResource, IHaveOrganizationsEntityPath
        {
            /// <summary>
            /// OrganizationsEntityPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipam-ipamorganizationalunitexclusion.html#cfn-ec2-ipam-ipamorganizationalunitexclusion-organizationsentitypath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrganizationsEntityPath { get; set; }
        }
    }
}