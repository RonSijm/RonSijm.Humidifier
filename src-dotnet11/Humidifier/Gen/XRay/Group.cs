namespace Humidifier.XRay
{
    using global::System.Collections.Generic;
    using GroupTypes;

    public class Group : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveGroupName, IHaveXRayGroupTypesInsightsConfigurationInsightsConfiguration, IHaveFilterExpression
    {
        public class Attributes
        {
            public static string GroupARN =  "GroupARN" ;
        }

        public override string AWSTypeName { get => AWS.XRay.Group; }
        public Union<string, BaseFunction>? GroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// InsightsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-xray-group.html#cfn-xray-group-insightsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InsightsConfiguration
        /// </summary>
        public Union<Humidifier.XRay.GroupTypes.InsightsConfiguration, BaseFunction>? InsightsConfiguration { get; set; }
        /// <summary>
        /// FilterExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-xray-group.html#cfn-xray-group-filterexpression
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FilterExpression { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-xray-group.html#cfn-xray-group-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace GroupTypes
    {
        public class InsightsConfiguration : Humidifier.Base.BaseSubResource, IHaveNotificationsEnabled_Boolean, IHaveInsightsEnabled_Boolean
        {
            /// <summary>
            /// NotificationsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-xray-group-insightsconfiguration.html#cfn-xray-group-insightsconfiguration-notificationsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? NotificationsEnabled { get; set; }
            /// <summary>
            /// InsightsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-xray-group-insightsconfiguration.html#cfn-xray-group-insightsconfiguration-insightsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InsightsEnabled { get; set; }
        }
    }
}