namespace Humidifier.EVS
{
    using global::System.Collections.Generic;
    using EnvironmentTypes;

    public class Environment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveKmsKeyId, IHaveVpcId, IHaveEnvironmentName, IHaveSiteId
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
        public Humidifier.EVS.EnvironmentTypes.LicenseInfo LicenseInfo { get; set; }
        /// <summary>
        /// Hosts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-hosts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HostInfoForCreate
        /// </summary>
        public List<Humidifier.EVS.EnvironmentTypes.HostInfoForCreate> Hosts { get; set; }
        /// <summary>
        /// SiteId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-siteid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SiteId { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyId { get; set; }
        public dynamic EnvironmentName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ConnectivityInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-connectivityinfo
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ConnectivityInfo
        /// </summary>
        public Humidifier.EVS.EnvironmentTypes.ConnectivityInfo ConnectivityInfo { get; set; }
        /// <summary>
        /// InitialVlans
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-initialvlans
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InitialVlans
        /// </summary>
        public Humidifier.EVS.EnvironmentTypes.InitialVlans InitialVlans { get; set; }
        /// <summary>
        /// ServiceAccessSecurityGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-serviceaccesssecuritygroups
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ServiceAccessSecurityGroups
        /// </summary>
        public Humidifier.EVS.EnvironmentTypes.ServiceAccessSecurityGroups ServiceAccessSecurityGroups { get; set; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic VpcId { get; set; }

        /// <summary>
        /// TermsAccepted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-termsaccepted
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public dynamic TermsAccepted { get; set; }

        /// <summary>
        /// VcfVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-vcfversion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic VcfVersion { get; set; }
        /// <summary>
        /// VcfHostnames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-vcfhostnames
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VcfHostnames
        /// </summary>
        public Humidifier.EVS.EnvironmentTypes.VcfHostnames VcfHostnames { get; set; }

        /// <summary>
        /// ServiceAccessSubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-serviceaccesssubnetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ServiceAccessSubnetId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evs-environment.html#cfn-evs-environment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace EnvironmentTypes
    {
        public class Check : Humidifier.Base.BaseSubResource, IHaveType, IHaveResult
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-check.html#cfn-evs-environment-check-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// ImpairedSince
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-check.html#cfn-evs-environment-check-impairedsince
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImpairedSince { get; set; }
            /// <summary>
            /// Result
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-check.html#cfn-evs-environment-check-result
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Result { get; set; }
        }

        public class ConnectivityInfo : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PrivateRouteServerPeerings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-connectivityinfo.html#cfn-evs-environment-connectivityinfo-privaterouteserverpeerings
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PrivateRouteServerPeerings { get; set; }
        }

        public class HostInfoForCreate : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHaveKeyName, IHaveHostName
        {
            /// <summary>
            /// KeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-hostinfoforcreate.html#cfn-evs-environment-hostinfoforcreate-keyname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyName { get; set; }
            /// <summary>
            /// DedicatedHostId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-hostinfoforcreate.html#cfn-evs-environment-hostinfoforcreate-dedicatedhostid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DedicatedHostId { get; set; }
            /// <summary>
            /// PlacementGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-hostinfoforcreate.html#cfn-evs-environment-hostinfoforcreate-placementgroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PlacementGroupId { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-hostinfoforcreate.html#cfn-evs-environment-hostinfoforcreate-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
            /// <summary>
            /// HostName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-hostinfoforcreate.html#cfn-evs-environment-hostinfoforcreate-hostname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostName { get; set; }
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
            public dynamic Cidr { get; set; }
        }

        public class InitialVlans : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VmkManagement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-vmkmanagement
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Humidifier.EVS.EnvironmentTypes.InitialVlanInfo VmkManagement { get; set; }
            /// <summary>
            /// VTep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-vtep
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Humidifier.EVS.EnvironmentTypes.InitialVlanInfo VTep { get; set; }
            /// <summary>
            /// ExpansionVlan2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-expansionvlan2
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Humidifier.EVS.EnvironmentTypes.InitialVlanInfo ExpansionVlan2 { get; set; }
            /// <summary>
            /// VSan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-vsan
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Humidifier.EVS.EnvironmentTypes.InitialVlanInfo VSan { get; set; }
            /// <summary>
            /// VMotion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-vmotion
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Humidifier.EVS.EnvironmentTypes.InitialVlanInfo VMotion { get; set; }
            /// <summary>
            /// IsHcxPublic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-ishcxpublic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsHcxPublic { get; set; }
            /// <summary>
            /// Hcx
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-hcx
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Humidifier.EVS.EnvironmentTypes.InitialVlanInfo Hcx { get; set; }
            /// <summary>
            /// EdgeVTep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-edgevtep
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Humidifier.EVS.EnvironmentTypes.InitialVlanInfo EdgeVTep { get; set; }
            /// <summary>
            /// HcxNetworkAclId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-hcxnetworkaclid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HcxNetworkAclId { get; set; }
            /// <summary>
            /// ExpansionVlan1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-expansionvlan1
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Humidifier.EVS.EnvironmentTypes.InitialVlanInfo ExpansionVlan1 { get; set; }
            /// <summary>
            /// VmManagement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-vmmanagement
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Humidifier.EVS.EnvironmentTypes.InitialVlanInfo VmManagement { get; set; }
            /// <summary>
            /// NsxUpLink
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-initialvlans.html#cfn-evs-environment-initialvlans-nsxuplink
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InitialVlanInfo
            /// </summary>
            public Humidifier.EVS.EnvironmentTypes.InitialVlanInfo NsxUpLink { get; set; }
        }

        public class LicenseInfo : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SolutionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-licenseinfo.html#cfn-evs-environment-licenseinfo-solutionkey
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SolutionKey { get; set; }
            /// <summary>
            /// VsanKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-licenseinfo.html#cfn-evs-environment-licenseinfo-vsankey
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VsanKey { get; set; }
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
            public dynamic SecretArn { get; set; }
        }

        public class ServiceAccessSecurityGroups : Humidifier.Base.BaseSubResource, IHaveSecurityGroups
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-serviceaccesssecuritygroups.html#cfn-evs-environment-serviceaccesssecuritygroups-securitygroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroups { get; set; }
        }

        public class VcfHostnames : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Nsx
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-nsx
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Nsx { get; set; }
            /// <summary>
            /// VCenter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-vcenter
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VCenter { get; set; }
            /// <summary>
            /// NsxManager1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-nsxmanager1
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NsxManager1 { get; set; }
            /// <summary>
            /// NsxEdge1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-nsxedge1
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NsxEdge1 { get; set; }
            /// <summary>
            /// NsxManager3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-nsxmanager3
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NsxManager3 { get; set; }
            /// <summary>
            /// SddcManager
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-sddcmanager
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SddcManager { get; set; }
            /// <summary>
            /// NsxManager2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-nsxmanager2
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NsxManager2 { get; set; }
            /// <summary>
            /// NsxEdge2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-nsxedge2
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NsxEdge2 { get; set; }
            /// <summary>
            /// CloudBuilder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evs-environment-vcfhostnames.html#cfn-evs-environment-vcfhostnames-cloudbuilder
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CloudBuilder { get; set; }
        }
    }
}