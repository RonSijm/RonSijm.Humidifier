namespace Humidifier.NetworkManager
{
    using global::System.Collections.Generic;

    public class CoreNetworkPrefixListAssociation : Humidifier.Base.BaseResource, IHaveCoreNetworkId, IHavePrefixListArn, IHavePrefixListAlias
    {
        public override string AWSTypeName { get => AWS.NetworkManager.CoreNetworkPrefixListAssociation; }

        /// <summary>
        /// CoreNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-corenetworkprefixlistassociation.html#cfn-networkmanager-corenetworkprefixlistassociation-corenetworkid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CoreNetworkId { get; set; }

        /// <summary>
        /// PrefixListArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-corenetworkprefixlistassociation.html#cfn-networkmanager-corenetworkprefixlistassociation-prefixlistarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PrefixListArn { get; set; }

        /// <summary>
        /// PrefixListAlias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-corenetworkprefixlistassociation.html#cfn-networkmanager-corenetworkprefixlistassociation-prefixlistalias
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PrefixListAlias { get; set; }
    }
}