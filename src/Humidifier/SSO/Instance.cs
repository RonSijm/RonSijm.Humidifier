namespace Humidifier.SSO
{
    using System.Collections.Generic;

    public class Instance : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string InstanceArn =  "InstanceArn" ;
            public static string IdentityStoreId =  "IdentityStoreId" ;
            public static string OwnerAccountId =  "OwnerAccountId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SSO::Instance";
            }
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-instance.html#cfn-sso-instance-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-instance.html#cfn-sso-instance-name
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }
}