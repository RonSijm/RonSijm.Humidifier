namespace Humidifier.ServiceCatalogAppRegistry
{
    using global::System.Collections.Generic;

    public class ResourceAssociation : Humidifier.Base.BaseResource, IHaveResource, IHaveResourceType, IHaveApplication
    {
        public class Attributes
        {
            public static string ResourceArn =  "ResourceArn" ;
            public static string ApplicationArn =  "ApplicationArn" ;
        }

        public override string AWSTypeName { get => AWS.ServiceCatalogAppRegistry.ResourceAssociation; }

        /// <summary>
        /// Resource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-resourceassociation.html#cfn-servicecatalogappregistry-resourceassociation-resource
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Resource { get; set; }

        /// <summary>
        /// ResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-resourceassociation.html#cfn-servicecatalogappregistry-resourceassociation-resourcetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceType { get; set; }

        /// <summary>
        /// Application
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-resourceassociation.html#cfn-servicecatalogappregistry-resourceassociation-application
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Application { get; set; }
    }
}