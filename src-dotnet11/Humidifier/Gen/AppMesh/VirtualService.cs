namespace Humidifier.AppMesh
{
    using global::System.Collections.Generic;
    using VirtualServiceTypes;

    public class VirtualService : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMeshName, IHaveMeshOwner, IHaveVirtualServiceName, IHaveAppMeshVirtualServiceTypesVirtualServiceSpecSpec
    {
        public class Attributes
        {
            public static string Uid =  "Uid" ;
            public static string MeshName =  "MeshName" ;
            public static string MeshOwner =  "MeshOwner" ;
            public static string ResourceOwner =  "ResourceOwner" ;
            public static string VirtualServiceName =  "VirtualServiceName" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AppMesh.VirtualService; }

        /// <summary>
        /// MeshName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualservice.html#cfn-appmesh-virtualservice-meshname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MeshName { get; set; }
        /// <summary>
        /// MeshOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualservice.html#cfn-appmesh-virtualservice-meshowner
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MeshOwner { get; set; }
        public Union<string, BaseFunction>? VirtualServiceName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Spec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualservice.html#cfn-appmesh-virtualservice-spec
        /// Required: True
        /// UpdateType: Mutable
        /// Type: VirtualServiceSpec
        /// </summary>
        [Required]
        public Union<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec, BaseFunction>? Spec { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualservice.html#cfn-appmesh-virtualservice-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace VirtualServiceTypes
    {
        public class VirtualNodeServiceProvider : Humidifier.Base.BaseSubResource, IHaveVirtualNodeName
        {
            /// <summary>
            /// VirtualNodeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualservice-virtualnodeserviceprovider.html#cfn-appmesh-virtualservice-virtualnodeserviceprovider-virtualnodename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VirtualNodeName { get; set; }
        }

        public class VirtualRouterServiceProvider : Humidifier.Base.BaseSubResource, IHaveVirtualRouterName
        {
            /// <summary>
            /// VirtualRouterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualservice-virtualrouterserviceprovider.html#cfn-appmesh-virtualservice-virtualrouterserviceprovider-virtualroutername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VirtualRouterName { get; set; }
        }

        public class VirtualServiceProvider : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualServiceTypesVirtualNodeServiceProviderVirtualNode, IHaveAppMeshVirtualServiceTypesVirtualRouterServiceProviderVirtualRouter
        {
            /// <summary>
            /// VirtualNode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualservice-virtualserviceprovider.html#cfn-appmesh-virtualservice-virtualserviceprovider-virtualnode
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualNodeServiceProvider
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualServiceTypes.VirtualNodeServiceProvider, BaseFunction>? VirtualNode { get; set; }
            /// <summary>
            /// VirtualRouter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualservice-virtualserviceprovider.html#cfn-appmesh-virtualservice-virtualserviceprovider-virtualrouter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualRouterServiceProvider
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualServiceTypes.VirtualRouterServiceProvider, BaseFunction>? VirtualRouter { get; set; }
        }

        public class VirtualServiceSpec : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualServiceTypesVirtualServiceProviderProvider
        {
            /// <summary>
            /// Provider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualservice-virtualservicespec.html#cfn-appmesh-virtualservice-virtualservicespec-provider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualServiceProvider
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceProvider, BaseFunction>? Provider { get; set; }
        }
    }
}