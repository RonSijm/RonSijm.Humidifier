namespace Humidifier.AppMesh
{
    using System.Collections.Generic;
    using MeshTypes;

    public class Mesh : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMeshName
    {
        public class Attributes
        {
            public static string Uid =  "Uid" ;
            public static string MeshName =  "MeshName" ;
            public static string MeshOwner =  "MeshOwner" ;
            public static string ResourceOwner =  "ResourceOwner" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AppMesh.Mesh; }
        public dynamic MeshName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Spec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-mesh.html#cfn-appmesh-mesh-spec
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MeshSpec
        /// </summary>
        public Humidifier.AppMesh.MeshTypes.MeshSpec Spec { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-mesh.html#cfn-appmesh-mesh-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace MeshTypes
    {
        public class EgressFilter : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-mesh-egressfilter.html#cfn-appmesh-mesh-egressfilter-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class MeshServiceDiscovery : Humidifier.Base.BaseSubResource, IHaveIpPreference
        {
            /// <summary>
            /// IpPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-mesh-meshservicediscovery.html#cfn-appmesh-mesh-meshservicediscovery-ippreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IpPreference { get; set; }
        }

        public class MeshSpec : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EgressFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-mesh-meshspec.html#cfn-appmesh-mesh-meshspec-egressfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EgressFilter
            /// </summary>
            public Humidifier.AppMesh.MeshTypes.EgressFilter EgressFilter { get; set; }
            /// <summary>
            /// ServiceDiscovery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-mesh-meshspec.html#cfn-appmesh-mesh-meshspec-servicediscovery
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeshServiceDiscovery
            /// </summary>
            public Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery ServiceDiscovery { get; set; }
        }
    }
}