namespace Humidifier.XRay
{
    using System.Collections.Generic;
    using GroupTypes;

    public class Group : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveGroupName, IHaveFilterExpression
    {
        public class Attributes
        {
            public static string GroupARN =  "GroupARN" ;
        }

        public override string AWSTypeName { get => AWS.XRay.Group; }
        public dynamic GroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// InsightsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-xray-group.html#cfn-xray-group-insightsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InsightsConfiguration
        /// </summary>
        public Humidifier.XRay.GroupTypes.InsightsConfiguration InsightsConfiguration { get; set; }
        /// <summary>
        /// FilterExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-xray-group.html#cfn-xray-group-filterexpression
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FilterExpression { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-xray-group.html#cfn-xray-group-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace GroupTypes
    {
        public class InsightsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NotificationsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-xray-group-insightsconfiguration.html#cfn-xray-group-insightsconfiguration-notificationsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic NotificationsEnabled { get; set; }
            /// <summary>
            /// InsightsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-xray-group-insightsconfiguration.html#cfn-xray-group-insightsconfiguration-insightsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic InsightsEnabled { get; set; }
        }
    }
}