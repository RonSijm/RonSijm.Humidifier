namespace Humidifier.EVS
{
    using global::System.Collections.Generic;
    using EnvironmentTypes;

    public class Environment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveEVSEnvironmentTypesLicenseInfoLicenseInfo, IHaveListOfEVSEnvironmentTypesHostInfoForCreateHosts, IHaveSiteId, IHaveKmsKeyId, IHaveEnvironmentName, IHaveEVSEnvironmentTypesConnectivityInfoConnectivityInfo, IHaveEVSEnvironmentTypesInitialVlansInitialVlans, IHaveEVSEnvironmentTypesServiceAccessSecurityGroupsServiceAccessSecurityGroups, IHaveVpcId, IHaveTermsAccepted_Boolean, IHaveVcfVersion, IHaveEVSEnvironmentTypesVcfHostnamesVcfHostnames, IHaveServiceAccessSubnetId
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string EnvironmentId =  "EnvironmentId" ;
            public static string EnvironmentArn =  "EnvironmentArn" ;
            public static string Checks =  "Checks" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string EnvironmentState =  "EnvironmentState" ;
            public static string StateDetails =  "StateDetails" ;
            public static string Credentials =  "Credentials" ;
        }

        public override string AWSTypeName { get => AWS.EVS.Environment; }
        /// <summary>
        /// LicenseInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-licenseinfo
        /// Required: False
        /// UpdateType: Immutable
        /// Type: LicenseInfo
        /// </summary>
        public Union<Humidifier.EVS.EnvironmentTypes.LicenseInfo, BaseFunction>? LicenseInfo { get; set; }
        /// <summary>
        /// Hosts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-hosts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HostInfoForCreate
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EVS.EnvironmentTypes.HostInfoForCreate>, IReadOnlyList<Union<Humidifier.EVS.EnvironmentTypes.HostInfoForCreate, BaseFunction>>, BaseFunction>? Hosts { get; set; }
        /// <summary>
        /// SiteId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-siteid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SiteId { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        public Union<string, BaseFunction>? EnvironmentName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ConnectivityInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-connectivityinfo
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ConnectivityInfo
        /// </summary>
        public Union<Humidifier.EVS.EnvironmentTypes.ConnectivityInfo, BaseFunction>? ConnectivityInfo { get; set; }
        /// <summary>
        /// InitialVlans
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-initialvlans
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InitialVlans
        /// </summary>
        public Union<Humidifier.EVS.EnvironmentTypes.InitialVlans, BaseFunction>? InitialVlans { get; set; }
        /// <summary>
        /// ServiceAccessSecurityGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-serviceaccesssecuritygroups
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ServiceAccessSecurityGroups
        /// </summary>
        public Union<Humidifier.EVS.EnvironmentTypes.ServiceAccessSecurityGroups, BaseFunction>? ServiceAccessSecurityGroups { get; set; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpcId { get; set; }

        /// <summary>
        /// TermsAccepted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-termsaccepted
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public Union<bool, BaseFunction>? TermsAccepted { get; set; }

        /// <summary>
        /// VcfVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-vcfversion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VcfVersion { get; set; }
        /// <summary>
        /// VcfHostnames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-vcfhostnames
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VcfHostnames
        /// </summary>
        public Union<Humidifier.EVS.EnvironmentTypes.VcfHostnames, BaseFunction>? VcfHostnames { get; set; }

        /// <summary>
        /// ServiceAccessSubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-serviceaccesssubnetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceAccessSubnetId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace EnvironmentTypes
    {
        public class Check : Humidifier.Base.BaseSubResource, IHaveType, IHaveImpairedSince, IHaveResult
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-check.html#cfn-evs-environment-check-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// ImpairedSince
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-check.html#cfn-evs-environment-check-impairedsince
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImpairedSince { get; set; }
            /// <summary>
            /// Result
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-check.html#cfn-evs-environment-check-result
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Result { get; set; }
        }

        public class ConnectivityInfo : Humidifier.Base.BaseSubResource, IHaveStringListOfPrivateRouteServerPeerings
        {
            /// <summary>
            /// PrivateRouteServerPeerings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-connectivityinfo.html#cfn-evs-environment-connectivityinfo-privaterouteserverpeerings
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PrivateRouteServerPeerings { get; set; }
        }

        public class HostInfoForCreate : Humidifier.Base.BaseSubResource, IHaveKeyName, IHaveDedicatedHostId, IHavePlacementGroupId, IHaveInstanceType, IHaveHostName
        {
            /// <summary>
            /// KeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-hostinfoforcreate.html#cfn-evs-environment-hostinfoforcreate-keyname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyName { get; set; }
            /// <summary>
            /// DedicatedHostId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-hostinfoforcreate.html#cfn-evs-environment-hostinfoforcreate-dedicatedhostid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DedicatedHostId { get; set; }
            /// <summary>
            /// PlacementGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-hostinfoforcreate.html#cfn-evs-environment-hostinfoforcreate-placementgroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PlacementGroupId { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-hostinfoforcreate.html#cfn-evs-environment-hostinfoforcreate-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
            /// <summary>
            /// HostName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-hostinfoforcreate.html#cfn-evs-environment-hostinfoforcreate-hostname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostName { get; set; }
        }

        public class InitialVlanInfo : Humidifier.Base.BaseSubResource, IHaveCidr
        {
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlaninfo.html#cfn-evs-environment-initialvlaninfo-cidr
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cidr { get; set; }
        }

        public class InitialVlans : Humidifier.Base.BaseSubResource, IHaveEVSEnvironmentTypesInitialVlanInfoVmkManagement, IHaveEVSEnvironmentTypesInitialVlanInfoVTep, IHaveEVSEnvironmentTypesInitialVlanInfoExpansionVlan2, IHaveEVSEnvironmentTypesInitialVlanInfoVSan, IHaveEVSEnvironmentTypesInitialVlanInfoVMotion, IHaveIsHcxPublic_Boolean, IHaveEVSEnvironmentTypesInitialVlanInfoHcx, IHaveEVSEnvironmentTypesInitialVlanInfoEdgeVTep, IHaveHcxNetworkAclId, IHaveEVSEnvironmentTypesInitialVlanInfoExpansionVlan1, IHaveEVSEnvironmentTypesInitialVlanInfoVmManagement, IHaveEVSEnvironmentTypesInitialVlanInfoNsxUpLink
        {
            /// <summary>
            /// VmkManagement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-vmkmanagement
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Union<Humidifier.EVS.EnvironmentTypes.InitialVlanInfo, BaseFunction>? VmkManagement { get; set; }
            /// <summary>
            /// VTep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-vtep
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Union<Humidifier.EVS.EnvironmentTypes.InitialVlanInfo, BaseFunction>? VTep { get; set; }
            /// <summary>
            /// ExpansionVlan2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-expansionvlan2
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Union<Humidifier.EVS.EnvironmentTypes.InitialVlanInfo, BaseFunction>? ExpansionVlan2 { get; set; }
            /// <summary>
            /// VSan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-vsan
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Union<Humidifier.EVS.EnvironmentTypes.InitialVlanInfo, BaseFunction>? VSan { get; set; }
            /// <summary>
            /// VMotion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-vmotion
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Union<Humidifier.EVS.EnvironmentTypes.InitialVlanInfo, BaseFunction>? VMotion { get; set; }
            /// <summary>
            /// IsHcxPublic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-ishcxpublic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsHcxPublic { get; set; }
            /// <summary>
            /// Hcx
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-hcx
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Union<Humidifier.EVS.EnvironmentTypes.InitialVlanInfo, BaseFunction>? Hcx { get; set; }
            /// <summary>
            /// EdgeVTep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-edgevtep
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Union<Humidifier.EVS.EnvironmentTypes.InitialVlanInfo, BaseFunction>? EdgeVTep { get; set; }
            /// <summary>
            /// HcxNetworkAclId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-hcxnetworkaclid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HcxNetworkAclId { get; set; }
            /// <summary>
            /// ExpansionVlan1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-expansionvlan1
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Union<Humidifier.EVS.EnvironmentTypes.InitialVlanInfo, BaseFunction>? ExpansionVlan1 { get; set; }
            /// <summary>
            /// VmManagement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-vmmanagement
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Union<Humidifier.EVS.EnvironmentTypes.InitialVlanInfo, BaseFunction>? VmManagement { get; set; }
            /// <summary>
            /// NsxUpLink
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-nsxuplink
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Union<Humidifier.EVS.EnvironmentTypes.InitialVlanInfo, BaseFunction>? NsxUpLink { get; set; }
        }

        public class LicenseInfo : Humidifier.Base.BaseSubResource, IHaveSolutionKey, IHaveVsanKey
        {
            /// <summary>
            /// SolutionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-licenseinfo.html#cfn-evs-environment-licenseinfo-solutionkey
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SolutionKey { get; set; }
            /// <summary>
            /// VsanKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-licenseinfo.html#cfn-evs-environment-licenseinfo-vsankey
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VsanKey { get; set; }
        }

        public class Secret : Humidifier.Base.BaseSubResource, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-secret.html#cfn-evs-environment-secret-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
        }

        public class ServiceAccessSecurityGroups : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-serviceaccesssecuritygroups.html#cfn-evs-environment-serviceaccesssecuritygroups-securitygroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
        }

        public class VcfHostnames : Humidifier.Base.BaseSubResource, IHaveNsx, IHaveVCenter, IHaveNsxManager1, IHaveNsxEdge1, IHaveNsxManager3, IHaveSddcManager, IHaveNsxManager2, IHaveNsxEdge2, IHaveCloudBuilder
        {
            /// <summary>
            /// Nsx
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-nsx
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Nsx { get; set; }
            /// <summary>
            /// VCenter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-vcenter
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VCenter { get; set; }
            /// <summary>
            /// NsxManager1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-nsxmanager1
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NsxManager1 { get; set; }
            /// <summary>
            /// NsxEdge1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-nsxedge1
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NsxEdge1 { get; set; }
            /// <summary>
            /// NsxManager3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-nsxmanager3
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NsxManager3 { get; set; }
            /// <summary>
            /// SddcManager
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-sddcmanager
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SddcManager { get; set; }
            /// <summary>
            /// NsxManager2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-nsxmanager2
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NsxManager2 { get; set; }
            /// <summary>
            /// NsxEdge2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-nsxedge2
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NsxEdge2 { get; set; }
            /// <summary>
            /// CloudBuilder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-cloudbuilder
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CloudBuilder { get; set; }
        }
    }
}