namespace Humidifier.VpcLattice
{
    using global::System.Collections.Generic;

    public class ServiceNetworkResourceAssociation : Humidifier.Base.BaseResource, IHaveTags, IHavePrivateDnsEnabled_Boolean, IHaveResourceConfigurationId, IHaveServiceNetworkId
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.VpcLattice.ServiceNetworkResourceAssociation; }
        /// <summary>
        /// PrivateDnsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkresourceassociation.html#cfn-vpclattice-servicenetworkresourceassociation-privatednsenabled
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PrivateDnsEnabled { get; set; }
        /// <summary>
        /// ResourceConfigurationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkresourceassociation.html#cfn-vpclattice-servicenetworkresourceassociation-resourceconfigurationid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceConfigurationId { get; set; }
        /// <summary>
        /// ServiceNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkresourceassociation.html#cfn-vpclattice-servicenetworkresourceassociation-servicenetworkid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServiceNetworkId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkresourceassociation.html#cfn-vpclattice-servicenetworkresourceassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}