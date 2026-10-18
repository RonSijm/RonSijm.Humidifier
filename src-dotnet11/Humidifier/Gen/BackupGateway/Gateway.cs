namespace Humidifier.BackupGateway
{
    using global::System.Collections.Generic;
    using GatewayTypes;

    public class Gateway : Humidifier.Base.BaseResource, IHaveGatewayType, IHaveGatewayDisplayName, IHaveListOfBackupGatewayGatewayTypesTagsItemsTags
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
        public Union<string, BaseFunction>? GatewayType { get; set; }
        /// <summary>
        /// GatewayDisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backupgateway-gateway.html#cfn-backupgateway-gateway-gatewaydisplayname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GatewayDisplayName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backupgateway-gateway.html#cfn-backupgateway-gateway-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BackupGateway.GatewayTypes.TagsItems>, IReadOnlyList<Union<Humidifier.BackupGateway.GatewayTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace GatewayTypes
    {
        public class MaintenanceStartTime : Humidifier.Base.BaseSubResource, IHaveDayOfWeek_Integer, IHaveMinuteOfHour_Integer, IHaveDayOfMonth_Integer, IHaveHourOfDay_Integer
        {
            /// <summary>
            /// DayOfWeek
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupgateway-gateway-maintenancestarttime.html#cfn-backupgateway-gateway-maintenancestarttime-dayofweek
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DayOfWeek { get; set; }
            /// <summary>
            /// MinuteOfHour
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupgateway-gateway-maintenancestarttime.html#cfn-backupgateway-gateway-maintenancestarttime-minuteofhour
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinuteOfHour { get; set; }
            /// <summary>
            /// DayOfMonth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupgateway-gateway-maintenancestarttime.html#cfn-backupgateway-gateway-maintenancestarttime-dayofmonth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DayOfMonth { get; set; }
            /// <summary>
            /// HourOfDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupgateway-gateway-maintenancestarttime.html#cfn-backupgateway-gateway-maintenancestarttime-hourofday
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HourOfDay { get; set; }
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
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupgateway-gateway-tagsitems.html#cfn-backupgateway-gateway-tagsitems-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}