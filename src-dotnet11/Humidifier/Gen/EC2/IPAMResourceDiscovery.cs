namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using IPAMResourceDiscoveryTypes;

    public class IPAMResourceDiscovery : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfEC2IPAMResourceDiscoveryTypesIpamResourceDiscoveryOrganizationalUnitExclusionOrganizationalUnitExclusions, IHaveDescription, IHaveListOfEC2IPAMResourceDiscoveryTypesIpamOperatingRegionOperatingRegions
    {
        public class Attributes
        {
            public static string IsDefault =  "IsDefault" ;
            public static string OwnerId =  "OwnerId" ;
            public static string State =  "State" ;
            public static string IpamResourceDiscoveryRegion =  "IpamResourceDiscoveryRegion" ;
            public static string IpamResourceDiscoveryArn =  "IpamResourceDiscoveryArn" ;
            public static string IpamResourceDiscoveryId =  "IpamResourceDiscoveryId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.IPAMResourceDiscovery; }
        /// <summary>
        /// OrganizationalUnitExclusions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamresourcediscovery.html#cfn-ec2-ipamresourcediscovery-organizationalunitexclusions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IpamResourceDiscoveryOrganizationalUnitExclusion
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamResourceDiscoveryOrganizationalUnitExclusion>, IReadOnlyList<Union<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamResourceDiscoveryOrganizationalUnitExclusion, BaseFunction>>, BaseFunction>? OrganizationalUnitExclusions { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamresourcediscovery.html#cfn-ec2-ipamresourcediscovery-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamresourcediscovery.html#cfn-ec2-ipamresourcediscovery-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// OperatingRegions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamresourcediscovery.html#cfn-ec2-ipamresourcediscovery-operatingregions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IpamOperatingRegion
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion>, IReadOnlyList<Union<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion, BaseFunction>>, BaseFunction>? OperatingRegions { get; set; }
    }

    namespace IPAMResourceDiscoveryTypes
    {
        public class IpamOperatingRegion : Humidifier.Base.BaseSubResource, IHaveRegionName
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipamresourcediscovery-ipamoperatingregion.html#cfn-ec2-ipamresourcediscovery-ipamoperatingregion-regionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegionName { get; set; }
        }

        public class IpamResourceDiscoveryOrganizationalUnitExclusion : Humidifier.Base.BaseSubResource, IHaveOrganizationsEntityPath
        {
            /// <summary>
            /// OrganizationsEntityPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipamresourcediscovery-ipamresourcediscoveryorganizationalunitexclusion.html#cfn-ec2-ipamresourcediscovery-ipamresourcediscoveryorganizationalunitexclusion-organizationsentitypath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrganizationsEntityPath { get; set; }
        }
    }
}