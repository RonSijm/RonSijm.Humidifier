namespace Humidifier.Organizations
{
    using global::System.Collections.Generic;

    public class Account : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRoleName, IHaveEmail, IHaveStringListOfParentIds, IHaveAccountName
    {
        public class Attributes
        {
            public static string JoinedMethod =  "JoinedMethod" ;
            public static string Status =  "Status" ;
            public static string JoinedTimestamp =  "JoinedTimestamp" ;
            public static string AccountId =  "AccountId" ;
            public static string State =  "State" ;
            public static string Paths =  "Paths" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Organizations.Account; }
        /// <summary>
        /// RoleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-organizations-account.html#cfn-organizations-account-rolename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleName { get; set; }

        /// <summary>
        /// Email
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-organizations-account.html#cfn-organizations-account-email
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Email { get; set; }
        /// <summary>
        /// ParentIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-organizations-account.html#cfn-organizations-account-parentids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ParentIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-organizations-account.html#cfn-organizations-account-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? AccountName { get => GivenName; set => GivenName = value; }
    }
}