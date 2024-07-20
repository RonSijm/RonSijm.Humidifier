namespace Humidifier.IdentityStore
{
    using System.Collections.Generic;
    using GroupMembershipTypes;

    public class GroupMembership : Humidifier.Resource
    {
        public class Attributes
        {
            public static string MembershipId =  "MembershipId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::IdentityStore::GroupMembership";
            }
        }

        /// <summary>
        /// MemberId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-groupmembership.html#cfn-identitystore-groupmembership-memberid
        /// Required: True
        /// UpdateType: Immutable
        /// Type: MemberId
        /// </summary>
        public MemberId MemberId { get; set; }
        /// <summary>
        /// IdentityStoreId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-groupmembership.html#cfn-identitystore-groupmembership-identitystoreid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IdentityStoreId { get; set; }
        /// <summary>
        /// GroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-groupmembership.html#cfn-identitystore-groupmembership-groupid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GroupId { get; set; }
    }

    namespace GroupMembershipTypes
    {
        public class MemberId
        {
            /// <summary>
            /// UserId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-groupmembership-memberid.html#cfn-identitystore-groupmembership-memberid-userid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserId { get; set; }
        }
    }
}