namespace Humidifier.NetworkManager
{
    using global::System.Collections.Generic;

    public class ContextStore : Humidifier.Base.BaseResource, IHaveTags, IHaveGlobalNetworkId, IHaveDescription
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ContextStoreArn =  "ContextStoreArn" ;
            public static string ContextStoreId =  "ContextStoreId" ;
        }

        public override string AWSTypeName { get => AWS.NetworkManager.ContextStore; }
        /// <summary>
        /// GlobalNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-contextstore.html#cfn-networkmanager-contextstore-globalnetworkid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GlobalNetworkId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-contextstore.html#cfn-networkmanager-contextstore-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-contextstore.html#cfn-networkmanager-contextstore-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}