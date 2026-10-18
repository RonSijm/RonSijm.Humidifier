namespace Humidifier.ServiceCatalog
{
    using global::System.Collections.Generic;

    public class ServiceActionAssociation : Humidifier.Base.BaseResource, IHaveServiceActionId, IHaveProductId, IHaveProvisioningArtifactId
    {
        public override string AWSTypeName { get => AWS.ServiceCatalog.ServiceActionAssociation; }

        /// <summary>
        /// ServiceActionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-serviceactionassociation.html#cfn-servicecatalog-serviceactionassociation-serviceactionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceActionId { get; set; }

        /// <summary>
        /// ProductId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-serviceactionassociation.html#cfn-servicecatalog-serviceactionassociation-productid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProductId { get; set; }

        /// <summary>
        /// ProvisioningArtifactId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-serviceactionassociation.html#cfn-servicecatalog-serviceactionassociation-provisioningartifactid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProvisioningArtifactId { get; set; }
    }
}