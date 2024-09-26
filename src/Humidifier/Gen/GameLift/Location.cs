namespace Humidifier.GameLift
{
    using System.Collections.Generic;

    public class Location : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveLocationName
    {
        public class Attributes
        {
            public static string LocationArn =  "LocationArn" ;
        }

        public override string AWSTypeName { get => AWS.GameLift.Location; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-location.html#cfn-gamelift-location-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic LocationName { get => GivenName; set => GivenName = value; }
    }
}