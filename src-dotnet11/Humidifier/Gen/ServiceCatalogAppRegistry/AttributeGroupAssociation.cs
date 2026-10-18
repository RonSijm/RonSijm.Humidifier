namespace Humidifier.ServiceCatalogAppRegistry
{
    using global::System.Collections.Generic;

    public class AttributeGroupAssociation : Humidifier.Base.BaseResource, IHaveAttributeGroup, IHaveApplication
    {
        public class Attributes
        {
            public static string ApplicationArn =  "ApplicationArn" ;
            public static string AttributeGroupArn =  "AttributeGroupArn" ;
        }

        public override string AWSTypeName { get => AWS.ServiceCatalogAppRegistry.AttributeGroupAssociation; }

        /// <summary>
        /// AttributeGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-attributegroupassociation.html#cfn-servicecatalogappregistry-attributegroupassociation-attributegroup
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AttributeGroup { get; set; }

        /// <summary>
        /// Application
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-attributegroupassociation.html#cfn-servicecatalogappregistry-attributegroupassociation-application
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Application { get; set; }
    }
}