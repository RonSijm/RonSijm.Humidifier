namespace Humidifier.IdentityStore
{
    using global::System.Collections.Generic;
    using GroupMembershipTypes;

    public class GroupMembership : Humidifier.Base.BaseResource, IHaveIdentityStoreGroupMembershipTypesMemberIdMemberId, IHaveIdentityStoreId, IHaveGroupId
    {
        public class Attributes
        {
            public static string MembershipId =  "MembershipId" ;
        }

        public override string AWSTypeName { get => AWS.IdentityStore.GroupMembership; }

        /// <summary>
        /// MemberId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-groupmembership.html#cfn-identitystore-groupmembership-memberid
        /// Required: True
        /// UpdateType: Immutable
        /// Type: MemberId
        /// </summary>
        [Required]
        public Union<Humidifier.IdentityStore.GroupMembershipTypes.MemberId, BaseFunction>? MemberId { get; set; }

        /// <summary>
        /// IdentityStoreId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-groupmembership.html#cfn-identitystore-groupmembership-identitystoreid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IdentityStoreId { get; set; }

        /// <summary>
        /// GroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-groupmembership.html#cfn-identitystore-groupmembership-groupid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GroupId { get; set; }
    }

    namespace GroupMembershipTypes
    {
        public class MemberId : Humidifier.Base.BaseSubResource, IHaveUserId
        {
            /// <summary>
            /// UserId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-groupmembership-memberid.html#cfn-identitystore-groupmembership-memberid-userid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserId { get; set; }
        }
    }
}