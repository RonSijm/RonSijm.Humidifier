namespace Humidifier.BackupGateway
{
    using global::System.Collections.Generic;
    using GatewayTypes;

    public class Gateway : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string GatewayId =  "GatewayId" ;
            public static string MaintenanceStartTime =  "MaintenanceStartTime" ;
            public static string GatewayArn =  "GatewayArn" ;
            public static string VpcEndpoint =  "VpcEndpoint" ;
            public static string SoftwareVersion =  "SoftwareVersion" ;
            public static string LastSeenTime =  "LastSeenTime" ;
            public static string DeprecationDate =  "DeprecationDate" ;
            public static string HypervisorId =  "HypervisorId" ;
            public static string NextUpdateAvailabilityTime =  "NextUpdateAvailabilityTime" ;
        }

        public override string AWSTypeName { get => AWS.BackupGateway.Gateway; }
        /// <summary>
        /// GatewayType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backupgateway-gateway.html#cfn-backupgateway-gateway-gatewaytype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GatewayType { get; set; }
        /// <summary>
        /// GatewayDisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backupgateway-gateway.html#cfn-backupgateway-gateway-gatewaydisplayname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GatewayDisplayName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backupgateway-gateway.html#cfn-backupgateway-gateway-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public List<Humidifier.BackupGateway.GatewayTypes.TagsItems> Tags { get; set; }
    }

    namespace GatewayTypes
    {
        public class MaintenanceStartTime : Humidifier.Base.BaseSubResource, IHaveDayOfWeek, IHaveDayOfMonth
        {
            /// <summary>
            /// DayOfWeek
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupgateway-gateway-maintenancestarttime.html#cfn-backupgateway-gateway-maintenancestarttime-dayofweek
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DayOfWeek { get; set; }
            /// <summary>
            /// MinuteOfHour
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupgateway-gateway-maintenancestarttime.html#cfn-backupgateway-gateway-maintenancestarttime-minuteofhour
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinuteOfHour { get; set; }
            /// <summary>
            /// DayOfMonth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupgateway-gateway-maintenancestarttime.html#cfn-backupgateway-gateway-maintenancestarttime-dayofmonth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DayOfMonth { get; set; }
            /// <summary>
            /// HourOfDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupgateway-gateway-maintenancestarttime.html#cfn-backupgateway-gateway-maintenancestarttime-hourofday
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic HourOfDay { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupgateway-gateway-tagsitems.html#cfn-backupgateway-gateway-tagsitems-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupgateway-gateway-tagsitems.html#cfn-backupgateway-gateway-tagsitems-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}