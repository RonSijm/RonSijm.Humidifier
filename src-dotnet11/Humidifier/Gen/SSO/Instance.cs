namespace Humidifier.SSO
{
    using global::System.Collections.Generic;

    public class Instance : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string InstanceArn =  "InstanceArn" ;
            public static string IdentityStoreId =  "IdentityStoreId" ;
            public static string OwnerAccountId =  "OwnerAccountId" ;
        }

        public override string AWSTypeName { get => AWS.SSO.Instance; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-instance.html#cfn-sso-instance-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}