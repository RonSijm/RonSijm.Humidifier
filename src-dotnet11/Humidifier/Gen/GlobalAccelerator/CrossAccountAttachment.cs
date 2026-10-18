namespace Humidifier.GlobalAccelerator
{
    using global::System.Collections.Generic;
    using CrossAccountAttachmentTypes;

    public class CrossAccountAttachment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStringListOfPrincipals, IHaveListOfGlobalAcceleratorCrossAccountAttachmentTypesResourceResources, IHaveName
    {
        public class Attributes
        {
            public static string AttachmentArn =  "AttachmentArn" ;
        }

        public override string AWSTypeName { get => AWS.GlobalAccelerator.CrossAccountAttachment; }
        /// <summary>
        /// Principals
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-crossaccountattachment.html#cfn-globalaccelerator-crossaccountattachment-principals
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Principals { get; set; }
        /// <summary>
        /// Resources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-crossaccountattachment.html#cfn-globalaccelerator-crossaccountattachment-resources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Resource
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource>, IReadOnlyList<Union<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource, BaseFunction>>, BaseFunction>? Resources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-crossaccountattachment.html#cfn-globalaccelerator-crossaccountattachment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace CrossAccountAttachmentTypes
    {
        public class Resource : Humidifier.Base.BaseSubResource, IHaveCidr, IHaveEndpointId, IHaveRegion
        {
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-crossaccountattachment-resource.html#cfn-globalaccelerator-crossaccountattachment-resource-cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cidr { get; set; }
            /// <summary>
            /// EndpointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-crossaccountattachment-resource.html#cfn-globalaccelerator-crossaccountattachment-resource-endpointid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointId { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-crossaccountattachment-resource.html#cfn-globalaccelerator-crossaccountattachment-resource-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
        }
    }
}