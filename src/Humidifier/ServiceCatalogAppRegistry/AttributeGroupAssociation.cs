namespace Humidifier.ServiceCatalogAppRegistry
{
    using System.Collections.Generic;

    public class AttributeGroupAssociation : Humidifier.Resource
    {
        public class Attributes
        {
            public static string ApplicationArn =  "ApplicationArn" ;
            public static string AttributeGroupArn =  "AttributeGroupArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::ServiceCatalogAppRegistry::AttributeGroupAssociation";
            }
        }

        /// <summary>
        /// AttributeGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-attributegroupassociation.html#cfn-servicecatalogappregistry-attributegroupassociation-attributegroup
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AttributeGroup { get; set; }
        /// <summary>
        /// Application
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-attributegroupassociation.html#cfn-servicecatalogappregistry-attributegroupassociation-application
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Application { get; set; }
    }
}