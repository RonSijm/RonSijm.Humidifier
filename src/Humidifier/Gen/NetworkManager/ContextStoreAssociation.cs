namespace Humidifier.NetworkManager
{
    using global::System.Collections.Generic;

    public class ContextStoreAssociation : Humidifier.Base.BaseResource, IHaveResourceArn
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
        }

        public override string AWSTypeName { get => AWS.NetworkManager.ContextStoreAssociation; }

        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-contextstoreassociation.html#cfn-networkmanager-contextstoreassociation-resourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceArn { get; set; }

        /// <summary>
        /// ContextStoreId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-contextstoreassociation.html#cfn-networkmanager-contextstoreassociation-contextstoreid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ContextStoreId { get; set; }
    }
}