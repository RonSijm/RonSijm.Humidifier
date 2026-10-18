namespace Humidifier.Route53Profiles
{
    using global::System.Collections.Generic;

    public class Profile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveName
    {
        public class Attributes
        {
            public static string ShareStatus =  "ShareStatus" ;
            public static string Id =  "Id" ;
            public static string ClientToken =  "ClientToken" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Route53Profiles.Profile; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53profiles-profile.html#cfn-route53profiles-profile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}