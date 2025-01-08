namespace Humidifier.EMRContainers
{
    using System.Collections.Generic;
    using VirtualClusterTypes;

    public class VirtualCluster : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EMRContainers.VirtualCluster; }

        /// <summary>
        /// ContainerProvider
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-virtualcluster.html#cfn-emrcontainers-virtualcluster-containerprovider
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ContainerProvider
        /// </summary>
        [Required]
        public Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider ContainerProvider { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-virtualcluster.html#cfn-emrcontainers-virtualcluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace VirtualClusterTypes
    {
        public class ContainerInfo : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EksInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-virtualcluster-containerinfo.html#cfn-emrcontainers-virtualcluster-containerinfo-eksinfo
            /// Required: True
            /// UpdateType: Immutable
            /// Type: EksInfo
            /// </summary>
            public Humidifier.EMRContainers.VirtualClusterTypes.EksInfo EksInfo { get; set; }
        }

        public class ContainerProvider : Humidifier.Base.BaseSubResource, IHaveType, IHaveId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-virtualcluster-containerprovider.html#cfn-emrcontainers-virtualcluster-containerprovider-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-virtualcluster-containerprovider.html#cfn-emrcontainers-virtualcluster-containerprovider-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Info
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-virtualcluster-containerprovider.html#cfn-emrcontainers-virtualcluster-containerprovider-info
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ContainerInfo
            /// </summary>
            public Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo Info { get; set; }
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
            public dynamic Namespace_ { get; set; }
        }
    }
}