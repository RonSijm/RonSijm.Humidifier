namespace Humidifier.ApiGateway
{
    using global::System.Collections.Generic;

    public class DomainNameAccessAssociation : Humidifier.Base.BaseResource, IHaveTags, IHaveDomainNameArn, IHaveAccessAssociationSource, IHaveAccessAssociationSourceType
    {
        public class Attributes
        {
            public static string DomainNameAccessAssociationArn =  "DomainNameAccessAssociationArn" ;
        }

        public override string AWSTypeName { get => AWS.ApiGateway.DomainNameAccessAssociation; }

        /// <summary>
        /// DomainNameArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainnameaccessassociation.html#cfn-apigateway-domainnameaccessassociation-domainnamearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainNameArn { get; set; }

        /// <summary>
        /// AccessAssociationSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainnameaccessassociation.html#cfn-apigateway-domainnameaccessassociation-accessassociationsource
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AccessAssociationSource { get; set; }

        /// <summary>
        /// AccessAssociationSourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainnameaccessassociation.html#cfn-apigateway-domainnameaccessassociation-accessassociationsourcetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AccessAssociationSourceType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainnameaccessassociation.html#cfn-apigateway-domainnameaccessassociation-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}