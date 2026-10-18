namespace Humidifier.ServiceCatalog
{
    using global::System.Collections.Generic;

    public class TagOptionAssociation : Humidifier.Base.BaseResource, IHaveTagOptionId, IHaveResourceId
    {
        public override string AWSTypeName { get => AWS.ServiceCatalog.TagOptionAssociation; }
        /// <summary>
        /// TagOptionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-tagoptionassociation.html#cfn-servicecatalog-tagoptionassociation-tagoptionid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TagOptionId { get; set; }
        /// <summary>
        /// ResourceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-tagoptionassociation.html#cfn-servicecatalog-tagoptionassociation-resourceid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceId { get; set; }
    }
}