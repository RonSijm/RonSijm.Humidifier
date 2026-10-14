namespace Humidifier.IdentityStore
{
    using global::System.Collections.Generic;
    using AllGroupMembershipsTypes;

    public class AllGroupMemberships : Humidifier.Base.BaseResource, IHaveGroupId, IHaveIdentityStoreId
    {
        public class Attributes
        {
            public static string UpdatedBy =  "UpdatedBy" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string MembershipId =  "MembershipId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.IdentityStore.AllGroupMemberships; }
        /// <summary>
        /// MemberId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-allgroupmemberships.html#cfn-identitystore-allgroupmemberships-memberid
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MemberId
        /// </summary>
        public Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId MemberId { get; set; }
        /// <summary>
        /// IdentityStoreId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-allgroupmemberships.html#cfn-identitystore-allgroupmemberships-identitystoreid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IdentityStoreId { get; set; }
        /// <summary>
        /// GroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-allgroupmemberships.html#cfn-identitystore-allgroupmemberships-groupid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GroupId { get; set; }
    }

    namespace AllGroupMembershipsTypes
    {
        public class MemberId : Humidifier.Base.BaseSubResource, IHaveUserId
        {
            /// <summary>
            /// UserId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-allgroupmemberships-memberid.html#cfn-identitystore-allgroupmemberships-memberid-userid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserId { get; set; }
        }
    }
}