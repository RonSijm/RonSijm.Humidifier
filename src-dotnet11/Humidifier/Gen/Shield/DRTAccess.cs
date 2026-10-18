namespace Humidifier.Shield
{
    using global::System.Collections.Generic;

    public class DRTAccess : Humidifier.Base.BaseResource, IHaveStringListOfLogBucketList, IHaveRoleArn
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
        }

        public override string AWSTypeName { get => AWS.Shield.DRTAccess; }
        /// <summary>
        /// LogBucketList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-drtaccess.html#cfn-shield-drtaccess-logbucketlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LogBucketList { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-drtaccess.html#cfn-shield-drtaccess-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
    }
}