namespace Humidifier.Chime
{
    using global::System.Collections.Generic;

    public class AppInstance : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveMetadata
    {
        public class Attributes
        {
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string LastUpdatedTimestamp =  "LastUpdatedTimestamp" ;
            public static string AppInstanceArn =  "AppInstanceArn" ;
        }

        public override string AWSTypeName { get => AWS.Chime.AppInstance; }
        /// <summary>
        /// Metadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-appinstance.html#cfn-chime-appinstance-metadata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Metadata { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-appinstance.html#cfn-chime-appinstance-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}