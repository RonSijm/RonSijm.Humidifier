namespace Humidifier.GameLift
{
    using System.Collections.Generic;

    public class Location : Humidifier.Resource
    {
        public class Attributes
        {
            public static string LocationArn =  "LocationArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::GameLift::Location";
            }
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-location.html#cfn-gamelift-location-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// LocationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-location.html#cfn-gamelift-location-locationname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LocationName { get; set; }
    }
}