namespace Humidifier.Location
{
    using global::System.Collections.Generic;

    public class Tracker : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveTrackerName, IHaveDescription, IHaveEventBridgeEnabled_Boolean, IHaveKmsKeyId, IHaveKmsKeyEnableGeospatialQueries_Boolean, IHavePositionFiltering
    {
        public class Attributes
        {
            public static string CreateTime =  "CreateTime" ;
            public static string UpdateTime =  "UpdateTime" ;
            public static string Arn =  "Arn" ;
            public static string TrackerArn =  "TrackerArn" ;
        }

        public override string AWSTypeName { get => AWS.Location.Tracker; }
        public Union<string, BaseFunction>? TrackerName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-tracker.html#cfn-location-tracker-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// EventBridgeEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-tracker.html#cfn-location-tracker-eventbridgeenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EventBridgeEnabled { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-tracker.html#cfn-location-tracker-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// KmsKeyEnableGeospatialQueries
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-tracker.html#cfn-location-tracker-kmskeyenablegeospatialqueries
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? KmsKeyEnableGeospatialQueries { get; set; }
        /// <summary>
        /// PositionFiltering
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-tracker.html#cfn-location-tracker-positionfiltering
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PositionFiltering { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-tracker.html#cfn-location-tracker-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}