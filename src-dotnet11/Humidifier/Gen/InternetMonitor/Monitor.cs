namespace Humidifier.InternetMonitor
{
    using global::System.Collections.Generic;
    using MonitorTypes;

    public class Monitor : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStatus, IHaveLinkedAccountId, IHaveTrafficPercentageToMonitor_Integer, IHaveIncludeLinkedAccounts_Boolean, IHaveInternetMonitorMonitorTypesHealthEventsConfigHealthEventsConfig, IHaveStringListOfResourcesToAdd, IHaveInternetMonitorMonitorTypesInternetMeasurementsLogDeliveryInternetMeasurementsLogDelivery, IHaveMonitorName, IHaveStringListOfResourcesToRemove, IHaveStringListOfResources, IHaveMaxCityNetworksToMonitor_Integer
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string MonitorArn =  "MonitorArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ProcessingStatusInfo =  "ProcessingStatusInfo" ;
            public static string ProcessingStatus =  "ProcessingStatus" ;
        }

        public override string AWSTypeName { get => AWS.InternetMonitor.Monitor; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-internetmonitor-monitor.html#cfn-internetmonitor-monitor-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }
        /// <summary>
        /// LinkedAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-internetmonitor-monitor.html#cfn-internetmonitor-monitor-linkedaccountid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LinkedAccountId { get; set; }
        /// <summary>
        /// TrafficPercentageToMonitor
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-internetmonitor-monitor.html#cfn-internetmonitor-monitor-trafficpercentagetomonitor
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? TrafficPercentageToMonitor { get; set; }
        /// <summary>
        /// IncludeLinkedAccounts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-internetmonitor-monitor.html#cfn-internetmonitor-monitor-includelinkedaccounts
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IncludeLinkedAccounts { get; set; }
        /// <summary>
        /// HealthEventsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-internetmonitor-monitor.html#cfn-internetmonitor-monitor-healtheventsconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HealthEventsConfig
        /// </summary>
        public Union<Humidifier.InternetMonitor.MonitorTypes.HealthEventsConfig, BaseFunction>? HealthEventsConfig { get; set; }
        /// <summary>
        /// ResourcesToAdd
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-internetmonitor-monitor.html#cfn-internetmonitor-monitor-resourcestoadd
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourcesToAdd { get; set; }
        /// <summary>
        /// InternetMeasurementsLogDelivery
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-internetmonitor-monitor.html#cfn-internetmonitor-monitor-internetmeasurementslogdelivery
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InternetMeasurementsLogDelivery
        /// </summary>
        public Union<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery, BaseFunction>? InternetMeasurementsLogDelivery { get; set; }
        public Union<string, BaseFunction>? MonitorName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ResourcesToRemove
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-internetmonitor-monitor.html#cfn-internetmonitor-monitor-resourcestoremove
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourcesToRemove { get; set; }
        /// <summary>
        /// Resources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-internetmonitor-monitor.html#cfn-internetmonitor-monitor-resources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Resources { get; set; }
        /// <summary>
        /// MaxCityNetworksToMonitor
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-internetmonitor-monitor.html#cfn-internetmonitor-monitor-maxcitynetworkstomonitor
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxCityNetworksToMonitor { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-internetmonitor-monitor.html#cfn-internetmonitor-monitor-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace MonitorTypes
    {
        public class HealthEventsConfig : Humidifier.Base.BaseSubResource, IHaveInternetMonitorMonitorTypesLocalHealthEventsConfigAvailabilityLocalHealthEventsConfig, IHavePerformanceScoreThreshold_Double, IHaveInternetMonitorMonitorTypesLocalHealthEventsConfigPerformanceLocalHealthEventsConfig, IHaveAvailabilityScoreThreshold_Double
        {
            /// <summary>
            /// AvailabilityLocalHealthEventsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-monitor-healtheventsconfig.html#cfn-internetmonitor-monitor-healtheventsconfig-availabilitylocalhealtheventsconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LocalHealthEventsConfig
            /// </summary>
            public Union<Humidifier.InternetMonitor.MonitorTypes.LocalHealthEventsConfig, BaseFunction>? AvailabilityLocalHealthEventsConfig { get; set; }
            /// <summary>
            /// PerformanceScoreThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-monitor-healtheventsconfig.html#cfn-internetmonitor-monitor-healtheventsconfig-performancescorethreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? PerformanceScoreThreshold { get; set; }
            /// <summary>
            /// PerformanceLocalHealthEventsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-monitor-healtheventsconfig.html#cfn-internetmonitor-monitor-healtheventsconfig-performancelocalhealtheventsconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LocalHealthEventsConfig
            /// </summary>
            public Union<Humidifier.InternetMonitor.MonitorTypes.LocalHealthEventsConfig, BaseFunction>? PerformanceLocalHealthEventsConfig { get; set; }
            /// <summary>
            /// AvailabilityScoreThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-monitor-healtheventsconfig.html#cfn-internetmonitor-monitor-healtheventsconfig-availabilityscorethreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? AvailabilityScoreThreshold { get; set; }
        }

        public class InternetMeasurementsLogDelivery : Humidifier.Base.BaseSubResource, IHaveInternetMonitorMonitorTypesS3ConfigS3Config
        {
            /// <summary>
            /// S3Config
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-monitor-internetmeasurementslogdelivery.html#cfn-internetmonitor-monitor-internetmeasurementslogdelivery-s3config
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Config
            /// </summary>
            public Union<Humidifier.InternetMonitor.MonitorTypes.S3Config, BaseFunction>? S3Config { get; set; }
        }

        public class LocalHealthEventsConfig : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveHealthScoreThreshold_Double, IHaveMinTrafficImpact_Double
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-monitor-localhealtheventsconfig.html#cfn-internetmonitor-monitor-localhealtheventsconfig-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// HealthScoreThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-monitor-localhealtheventsconfig.html#cfn-internetmonitor-monitor-localhealtheventsconfig-healthscorethreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? HealthScoreThreshold { get; set; }
            /// <summary>
            /// MinTrafficImpact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-monitor-localhealtheventsconfig.html#cfn-internetmonitor-monitor-localhealtheventsconfig-mintrafficimpact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinTrafficImpact { get; set; }
        }

        public class S3Config : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveLogDeliveryStatus, IHaveBucketPrefix
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-monitor-s3config.html#cfn-internetmonitor-monitor-s3config-bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// LogDeliveryStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-monitor-s3config.html#cfn-internetmonitor-monitor-s3config-logdeliverystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogDeliveryStatus { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-monitor-s3config.html#cfn-internetmonitor-monitor-s3config-bucketprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketPrefix { get; set; }
        }
    }
}