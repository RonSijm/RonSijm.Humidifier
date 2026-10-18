namespace Humidifier.IdentityStore
{
    using global::System.Collections.Generic;

    public class Group : Humidifier.Base.BaseResource, IHaveDescription, IHaveDisplayName, IHaveIdentityStoreId
    {
        public class Attributes
        {
            public static string GroupId =  "GroupId" ;
        }

        public override string AWSTypeName { get => AWS.IdentityStore.Group; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-group.html#cfn-identitystore-group-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-group.html#cfn-identitystore-group-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DisplayName { get; set; }

        /// <summary>
        /// IdentityStoreId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-group.html#cfn-identitystore-group-identitystoreid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IdentityStoreId { get; set; }
    }
}