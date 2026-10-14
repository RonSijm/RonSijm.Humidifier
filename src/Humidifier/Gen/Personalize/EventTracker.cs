namespace Humidifier.Personalize
{
    using global::System.Collections.Generic;

    public class EventTracker : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDatasetGroupArn
    {
        public class Attributes
        {
            public static string EventTrackerArn =  "EventTrackerArn" ;
            public static string TrackingId =  "TrackingId" ;
        }

        public override string AWSTypeName { get => AWS.Personalize.EventTracker; }

        /// <summary>
        /// DatasetGroupArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-eventtracker.html#cfn-personalize-eventtracker-datasetgrouparn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DatasetGroupArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-eventtracker.html#cfn-personalize-eventtracker-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}