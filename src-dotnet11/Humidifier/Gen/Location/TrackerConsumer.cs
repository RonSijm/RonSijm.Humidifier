namespace Humidifier.Location
{
    using global::System.Collections.Generic;

    public class TrackerConsumer : Humidifier.Base.BaseResource, IHaveTrackerName, IHaveConsumerArn
    {
        public override string AWSTypeName { get => AWS.Location.TrackerConsumer; }

        /// <summary>
        /// TrackerName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-trackerconsumer.html#cfn-location-trackerconsumer-trackername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TrackerName { get; set; }

        /// <summary>
        /// ConsumerArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-trackerconsumer.html#cfn-location-trackerconsumer-consumerarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConsumerArn { get; set; }
    }
}