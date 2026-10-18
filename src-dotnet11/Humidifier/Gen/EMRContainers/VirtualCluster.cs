namespace Humidifier.EMRContainers
{
    using global::System.Collections.Generic;
    using VirtualClusterTypes;

    public class VirtualCluster : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSecurityConfigurationId, IHaveEMRContainersVirtualClusterTypesContainerProviderContainerProvider, IHaveSessionEnabled_Boolean, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EMRContainers.VirtualCluster; }
        /// <summary>
        /// SecurityConfigurationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-virtualcluster.html#cfn-emrcontainers-virtualcluster-securityconfigurationid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SecurityConfigurationId { get; set; }

        /// <summary>
        /// ContainerProvider
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-virtualcluster.html#cfn-emrcontainers-virtualcluster-containerprovider
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ContainerProvider
        /// </summary>
        [Required]
        public Union<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider, BaseFunction>? ContainerProvider { get; set; }
        /// <summary>
        /// SessionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-virtualcluster.html#cfn-emrcontainers-virtualcluster-sessionenabled
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SessionEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-virtualcluster.html#cfn-emrcontainers-virtualcluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace VirtualClusterTypes
    {
        public class ContainerInfo : Humidifier.Base.BaseSubResource, IHaveEMRContainersVirtualClusterTypesEksInfoEksInfo
        {
            /// <summary>
            /// EksInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-virtualcluster-containerinfo.html#cfn-emrcontainers-virtualcluster-containerinfo-eksinfo
            /// Required: True
            /// UpdateType: Immutable
            /// Type: EksInfo
            /// </summary>
            public Union<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo, BaseFunction>? EksInfo { get; set; }
        }

        public class ContainerProvider : Humidifier.Base.BaseSubResource, IHaveType, IHaveId, IHaveEMRContainersVirtualClusterTypesContainerInfoInfo
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-virtualcluster-containerprovider.html#cfn-emrcontainers-virtualcluster-containerprovider-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-virtualcluster-containerprovider.html#cfn-emrcontainers-virtualcluster-containerprovider-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Info
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-virtualcluster-containerprovider.html#cfn-emrcontainers-virtualcluster-containerprovider-info
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ContainerInfo
            /// </summary>
            public Union<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo, BaseFunction>? Info { get; set; }
        }

        public class EksInfo : Humidifier.Base.BaseSubResource, IHaveNamespace_
        {
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-virtualcluster-eksinfo.html#cfn-emrcontainers-virtualcluster-eksinfo-namespace
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }
    }
}