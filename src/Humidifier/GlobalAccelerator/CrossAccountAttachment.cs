namespace Humidifier.GlobalAccelerator
{
    using System.Collections.Generic;
    using CrossAccountAttachmentTypes;

    public class CrossAccountAttachment : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string AttachmentArn =  "AttachmentArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::GlobalAccelerator::CrossAccountAttachment";
            }
        }

        /// <summary>
        /// Principals
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-crossaccountattachment.html#cfn-globalaccelerator-crossaccountattachment-principals
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Principals { get; set; }
        /// <summary>
        /// Resources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-crossaccountattachment.html#cfn-globalaccelerator-crossaccountattachment-resources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Resource
        /// </summary>
        public List<Resource> Resources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-crossaccountattachment.html#cfn-globalaccelerator-crossaccountattachment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-crossaccountattachment.html#cfn-globalaccelerator-crossaccountattachment-name
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace CrossAccountAttachmentTypes
    {
        public class Resource
        {
            /// <summary>
            /// EndpointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-crossaccountattachment-resource.html#cfn-globalaccelerator-crossaccountattachment-resource-endpointid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndpointId { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-crossaccountattachment-resource.html#cfn-globalaccelerator-crossaccountattachment-resource-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
        }
    }
}