namespace Humidifier.AppMesh
{
    using global::System.Collections.Generic;
    using VirtualRouterTypes;

    public class VirtualRouter : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMeshName, IHaveVirtualRouterName, IHaveMeshOwner, IHaveAppMeshVirtualRouterTypesVirtualRouterSpecSpec
    {
        public class Attributes
        {
            public static string Uid =  "Uid" ;
            public static string MeshName =  "MeshName" ;
            public static string VirtualRouterName =  "VirtualRouterName" ;
            public static string MeshOwner =  "MeshOwner" ;
            public static string ResourceOwner =  "ResourceOwner" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AppMesh.VirtualRouter; }

        /// <summary>
        /// MeshName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualrouter.html#cfn-appmesh-virtualrouter-meshname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MeshName { get; set; }
        public Union<string, BaseFunction>? VirtualRouterName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// MeshOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualrouter.html#cfn-appmesh-virtualrouter-meshowner
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MeshOwner { get; set; }

        /// <summary>
        /// Spec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualrouter.html#cfn-appmesh-virtualrouter-spec
        /// Required: True
        /// UpdateType: Mutable
        /// Type: VirtualRouterSpec
        /// </summary>
        [Required]
        public Union<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec, BaseFunction>? Spec { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualrouter.html#cfn-appmesh-virtualrouter-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace VirtualRouterTypes
    {
        public class PortMapping : Humidifier.Base.BaseSubResource, IHavePort_Integer, IHaveProtocol
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualrouter-portmapping.html#cfn-appmesh-virtualrouter-portmapping-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualrouter-portmapping.html#cfn-appmesh-virtualrouter-portmapping-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
        }

        public class VirtualRouterListener : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualRouterTypesPortMappingPortMapping
        {
            /// <summary>
            /// PortMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualrouter-virtualrouterlistener.html#cfn-appmesh-virtualrouter-virtualrouterlistener-portmapping
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PortMapping
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualRouterTypes.PortMapping, BaseFunction>? PortMapping { get; set; }
        }

        public class VirtualRouterSpec : Humidifier.Base.BaseSubResource, IHaveListOfAppMeshVirtualRouterTypesVirtualRouterListenerListeners
        {
            /// <summary>
            /// Listeners
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualrouter-virtualrouterspec.html#cfn-appmesh-virtualrouter-virtualrouterspec-listeners
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VirtualRouterListener
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterListener>, IReadOnlyList<Union<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterListener, BaseFunction>>, BaseFunction>? Listeners { get; set; }
        }
    }
}