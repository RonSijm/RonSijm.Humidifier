namespace Humidifier.CloudTrail
{
    using System.Collections.Generic;
    using DashboardTypes;

    public class Dashboard : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveTerminationProtectionEnabled
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string UpdatedTimestamp =  "UpdatedTimestamp" ;
            public static string Type =  "Type" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string DashboardArn =  "DashboardArn" ;
        }

        public override string AWSTypeName { get => AWS.CloudTrail.Dashboard; }
        /// <summary>
        /// Widgets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-dashboard.html#cfn-cloudtrail-dashboard-widgets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Widget
        /// </summary>
        public List<Humidifier.CloudTrail.DashboardTypes.Widget> Widgets { get; set; }
        /// <summary>
        /// TerminationProtectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-dashboard.html#cfn-cloudtrail-dashboard-terminationprotectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic TerminationProtectionEnabled { get; set; }
        /// <summary>
        /// RefreshSchedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-dashboard.html#cfn-cloudtrail-dashboard-refreshschedule
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RefreshSchedule
        /// </summary>
        public Humidifier.CloudTrail.DashboardTypes.RefreshSchedule RefreshSchedule { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-dashboard.html#cfn-cloudtrail-dashboard-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace DashboardTypes
    {
        public class Frequency : Humidifier.Base.BaseSubResource, IHaveValue, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-dashboard-frequency.html#cfn-cloudtrail-dashboard-frequency-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-dashboard-frequency.html#cfn-cloudtrail-dashboard-frequency-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }

        public class RefreshSchedule : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveTimeOfDay
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-dashboard-refreshschedule.html#cfn-cloudtrail-dashboard-refreshschedule-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// TimeOfDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-dashboard-refreshschedule.html#cfn-cloudtrail-dashboard-refreshschedule-timeofday
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeOfDay { get; set; }
            /// <summary>
            /// Frequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-dashboard-refreshschedule.html#cfn-cloudtrail-dashboard-refreshschedule-frequency
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Frequency
            /// </summary>
            public Humidifier.CloudTrail.DashboardTypes.Frequency Frequency { get; set; }
        }

        public class Widget : Humidifier.Base.BaseSubResource, IHaveQueryStatement
        {
            /// <summary>
            /// QueryStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-dashboard-widget.html#cfn-cloudtrail-dashboard-widget-querystatement
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueryStatement { get; set; }
            /// <summary>
            /// QueryParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-dashboard-widget.html#cfn-cloudtrail-dashboard-widget-queryparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic QueryParameters { get; set; }
            /// <summary>
            /// ViewProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-dashboard-widget.html#cfn-cloudtrail-dashboard-widget-viewproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> ViewProperties { get; set; }
        }
    }
}