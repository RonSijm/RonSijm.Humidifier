namespace Humidifier.XRay
{
    using System.Collections.Generic;
    using GroupTypes;

    public class Group : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string GroupARN =  "GroupARN" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::XRay::Group";
            }
        }

        /// <summary>
        /// GroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-xray-group.html#cfn-xray-group-groupname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GroupName { get; set; }
        /// <summary>
        /// InsightsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-xray-group.html#cfn-xray-group-insightsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InsightsConfiguration
        /// </summary>
        public InsightsConfiguration InsightsConfiguration { get; set; }
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
        public class InsightsConfiguration
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