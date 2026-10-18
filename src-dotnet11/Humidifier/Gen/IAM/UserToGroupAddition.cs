namespace Humidifier.IAM
{
    using global::System.Collections.Generic;

    public class UserToGroupAddition : Humidifier.Base.BaseResource, IHaveGroupName, IHaveStringListOfUsers
    {
        public override string AWSTypeName { get => AWS.IAM.UserToGroupAddition; }

        /// <summary>
        /// GroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-addusertogroup.html#cfn-iam-addusertogroup-groupname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GroupName { get; set; }

        /// <summary>
        /// Users
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-addusertogroup.html#cfn-iam-addusertogroup-users
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Users { get; set; }
    }
}