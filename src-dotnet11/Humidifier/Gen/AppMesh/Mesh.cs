namespace Humidifier.AppMesh
{
    using global::System.Collections.Generic;
    using MeshTypes;

    public class Mesh : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMeshName, IHaveAppMeshMeshTypesMeshSpecSpec
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
        public Union<string, BaseFunction>? MeshName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Spec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-mesh.html#cfn-appmesh-mesh-spec
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MeshSpec
        /// </summary>
        public Union<Humidifier.AppMesh.MeshTypes.MeshSpec, BaseFunction>? Spec { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-mesh.html#cfn-appmesh-mesh-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
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
            public Union<string, BaseFunction>? Type { get; set; }
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
            public Union<string, BaseFunction>? IpPreference { get; set; }
        }

        public class MeshSpec : Humidifier.Base.BaseSubResource, IHaveAppMeshMeshTypesEgressFilterEgressFilter, IHaveAppMeshMeshTypesMeshServiceDiscoveryServiceDiscovery
        {
            /// <summary>
            /// EgressFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-mesh-meshspec.html#cfn-appmesh-mesh-meshspec-egressfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EgressFilter
            /// </summary>
            public Union<Humidifier.AppMesh.MeshTypes.EgressFilter, BaseFunction>? EgressFilter { get; set; }
            /// <summary>
            /// ServiceDiscovery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-mesh-meshspec.html#cfn-appmesh-mesh-meshspec-servicediscovery
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeshServiceDiscovery
            /// </summary>
            public Union<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery, BaseFunction>? ServiceDiscovery { get; set; }
        }
    }
}