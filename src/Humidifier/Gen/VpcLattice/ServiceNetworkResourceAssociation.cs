namespace Humidifier.VpcLattice
{
    using System.Collections.Generic;

    public class ServiceNetworkResourceAssociation : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.VpcLattice.ServiceNetworkResourceAssociation; }
        /// <summary>
        /// ResourceConfigurationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkresourceassociation.html#cfn-vpclattice-servicenetworkresourceassociation-resourceconfigurationid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceConfigurationId { get; set; }
        /// <summary>
        /// ServiceNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkresourceassociation.html#cfn-vpclattice-servicenetworkresourceassociation-servicenetworkid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServiceNetworkId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkresourceassociation.html#cfn-vpclattice-servicenetworkresourceassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}