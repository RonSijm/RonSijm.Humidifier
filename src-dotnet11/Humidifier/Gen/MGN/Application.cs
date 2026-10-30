namespace Humidifier.MGN
{
    using global::System.Collections.Generic;

    public class Application : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveName
    {
        public class Attributes
        {
            public static string IsArchived =  "IsArchived" ;
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string LastModifiedDateTime =  "LastModifiedDateTime" ;
            public static string ApplicationID =  "ApplicationID" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MGN.Application; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-application.html#cfn-mgn-application-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-application.html#cfn-mgn-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}