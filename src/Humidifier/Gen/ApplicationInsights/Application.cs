namespace Humidifier.ApplicationInsights
{
    using System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string ApplicationARN =  "ApplicationARN" ;
        }

        public override string AWSTypeName { get => AWS.ApplicationInsights.Application; }
        /// <summary>
        /// AutoConfigurationEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-autoconfigurationenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AutoConfigurationEnabled { get; set; }
        /// <summary>
        /// OpsItemSNSTopicArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-opsitemsnstopicarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OpsItemSNSTopicArn { get; set; }
        /// <summary>
        /// OpsCenterEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-opscenterenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic OpsCenterEnabled { get; set; }
        /// <summary>
        /// CustomComponents
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-customcomponents
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CustomComponent
        /// </summary>
        public List<Humidifier.ApplicationInsights.ApplicationTypes.CustomComponent> CustomComponents { get; set; }
        /// <summary>
        /// SNSNotificationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-snsnotificationarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SNSNotificationArn { get; set; }
        /// <summary>
        /// AttachMissingPermission
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-attachmissingpermission
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AttachMissingPermission { get; set; }
        /// <summary>
        /// LogPatternSets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-logpatternsets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LogPatternSet
        /// </summary>
        public List<Humidifier.ApplicationInsights.ApplicationTypes.LogPatternSet> LogPatternSets { get; set; }
        /// <summary>
        /// GroupingType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-groupingtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GroupingType { get; set; }
        /// <summary>
        /// ComponentMonitoringSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-componentmonitoringsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ComponentMonitoringSetting
        /// </summary>
        public List<Humidifier.ApplicationInsights.ApplicationTypes.ComponentMonitoringSetting> ComponentMonitoringSettings { get; set; }
        /// <summary>
        /// CWEMonitorEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-cwemonitorenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic CWEMonitorEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// ResourceGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-resourcegroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceGroupName { get; set; }
    }

    namespace ApplicationTypes
    {
        public class Alarm : Humidifier.Base.BaseSubResource, IHaveAlarmName, IHaveSeverity
        {
            /// <summary>
            /// AlarmName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-alarm.html#cfn-applicationinsights-application-alarm-alarmname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlarmName { get; set; }
            /// <summary>
            /// Severity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-alarm.html#cfn-applicationinsights-application-alarm-severity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Severity { get; set; }
        }

        public class AlarmMetric : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AlarmMetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-alarmmetric.html#cfn-applicationinsights-application-alarmmetric-alarmmetricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlarmMetricName { get; set; }
        }

        public class ComponentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SubComponentTypeConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentconfiguration.html#cfn-applicationinsights-application-componentconfiguration-subcomponenttypeconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SubComponentTypeConfiguration
            /// </summary>
            public List<Humidifier.ApplicationInsights.ApplicationTypes.SubComponentTypeConfiguration> SubComponentTypeConfigurations { get; set; }
            /// <summary>
            /// ConfigurationDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentconfiguration.html#cfn-applicationinsights-application-componentconfiguration-configurationdetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfigurationDetails
            /// </summary>
            public Humidifier.ApplicationInsights.ApplicationTypes.ConfigurationDetails ConfigurationDetails { get; set; }
        }

        public class ComponentMonitoringSetting : Humidifier.Base.BaseSubResource, IHaveComponentName, IHaveTier
        {
            /// <summary>
            /// CustomComponentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentmonitoringsetting.html#cfn-applicationinsights-application-componentmonitoringsetting-customcomponentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentConfiguration
            /// </summary>
            public Humidifier.ApplicationInsights.ApplicationTypes.ComponentConfiguration CustomComponentConfiguration { get; set; }
            /// <summary>
            /// Tier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentmonitoringsetting.html#cfn-applicationinsights-application-componentmonitoringsetting-tier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Tier { get; set; }
            /// <summary>
            /// ComponentConfigurationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentmonitoringsetting.html#cfn-applicationinsights-application-componentmonitoringsetting-componentconfigurationmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComponentConfigurationMode { get; set; }
            /// <summary>
            /// DefaultOverwriteComponentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentmonitoringsetting.html#cfn-applicationinsights-application-componentmonitoringsetting-defaultoverwritecomponentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentConfiguration
            /// </summary>
            public Humidifier.ApplicationInsights.ApplicationTypes.ComponentConfiguration DefaultOverwriteComponentConfiguration { get; set; }
            /// <summary>
            /// ComponentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentmonitoringsetting.html#cfn-applicationinsights-application-componentmonitoringsetting-componentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComponentName { get; set; }
            /// <summary>
            /// ComponentARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentmonitoringsetting.html#cfn-applicationinsights-application-componentmonitoringsetting-componentarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComponentARN { get; set; }
        }

        public class ConfigurationDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NetWeaverPrometheusExporter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-netweaverprometheusexporter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetWeaverPrometheusExporter
            /// </summary>
            public Humidifier.ApplicationInsights.ApplicationTypes.NetWeaverPrometheusExporter NetWeaverPrometheusExporter { get; set; }
            /// <summary>
            /// WindowsEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-windowsevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WindowsEvent
            /// </summary>
            public List<Humidifier.ApplicationInsights.ApplicationTypes.WindowsEvent> WindowsEvents { get; set; }
            /// <summary>
            /// AlarmMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-alarmmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AlarmMetric
            /// </summary>
            public List<Humidifier.ApplicationInsights.ApplicationTypes.AlarmMetric> AlarmMetrics { get; set; }
            /// <summary>
            /// Alarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-alarms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Alarm
            /// </summary>
            public List<Humidifier.ApplicationInsights.ApplicationTypes.Alarm> Alarms { get; set; }
            /// <summary>
            /// SQLServerPrometheusExporter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-sqlserverprometheusexporter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SQLServerPrometheusExporter
            /// </summary>
            public Humidifier.ApplicationInsights.ApplicationTypes.SQLServerPrometheusExporter SQLServerPrometheusExporter { get; set; }
            /// <summary>
            /// HAClusterPrometheusExporter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-haclusterprometheusexporter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HAClusterPrometheusExporter
            /// </summary>
            public Humidifier.ApplicationInsights.ApplicationTypes.HAClusterPrometheusExporter HAClusterPrometheusExporter { get; set; }
            /// <summary>
            /// HANAPrometheusExporter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-hanaprometheusexporter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HANAPrometheusExporter
            /// </summary>
            public Humidifier.ApplicationInsights.ApplicationTypes.HANAPrometheusExporter HANAPrometheusExporter { get; set; }
            /// <summary>
            /// Logs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-logs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Log
            /// </summary>
            public List<Humidifier.ApplicationInsights.ApplicationTypes.Log> Logs { get; set; }
            /// <summary>
            /// Processes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-processes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Process
            /// </summary>
            public List<Humidifier.ApplicationInsights.ApplicationTypes.Process> Processes { get; set; }
            /// <summary>
            /// JMXPrometheusExporter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-jmxprometheusexporter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JMXPrometheusExporter
            /// </summary>
            public Humidifier.ApplicationInsights.ApplicationTypes.JMXPrometheusExporter JMXPrometheusExporter { get; set; }
        }

        public class CustomComponent : Humidifier.Base.BaseSubResource, IHaveComponentName
        {
            /// <summary>
            /// ResourceList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-customcomponent.html#cfn-applicationinsights-application-customcomponent-resourcelist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ResourceList { get; set; }
            /// <summary>
            /// ComponentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-customcomponent.html#cfn-applicationinsights-application-customcomponent-componentname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComponentName { get; set; }
        }

        public class HAClusterPrometheusExporter : Humidifier.Base.BaseSubResource, IHavePrometheusPort
        {
            /// <summary>
            /// PrometheusPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-haclusterprometheusexporter.html#cfn-applicationinsights-application-haclusterprometheusexporter-prometheusport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrometheusPort { get; set; }
        }

        public class HANAPrometheusExporter : Humidifier.Base.BaseSubResource, IHavePrometheusPort
        {
            /// <summary>
            /// HANAPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-hanaprometheusexporter.html#cfn-applicationinsights-application-hanaprometheusexporter-hanaport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HANAPort { get; set; }
            /// <summary>
            /// PrometheusPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-hanaprometheusexporter.html#cfn-applicationinsights-application-hanaprometheusexporter-prometheusport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrometheusPort { get; set; }
            /// <summary>
            /// HANASecretName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-hanaprometheusexporter.html#cfn-applicationinsights-application-hanaprometheusexporter-hanasecretname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HANASecretName { get; set; }
            /// <summary>
            /// HANASID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-hanaprometheusexporter.html#cfn-applicationinsights-application-hanaprometheusexporter-hanasid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HANASID { get; set; }
            /// <summary>
            /// AgreeToInstallHANADBClient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-hanaprometheusexporter.html#cfn-applicationinsights-application-hanaprometheusexporter-agreetoinstallhanadbclient
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AgreeToInstallHANADBClient { get; set; }
        }

        public class JMXPrometheusExporter : Humidifier.Base.BaseSubResource, IHavePrometheusPort
        {
            /// <summary>
            /// PrometheusPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-jmxprometheusexporter.html#cfn-applicationinsights-application-jmxprometheusexporter-prometheusport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrometheusPort { get; set; }
            /// <summary>
            /// JMXURL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-jmxprometheusexporter.html#cfn-applicationinsights-application-jmxprometheusexporter-jmxurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JMXURL { get; set; }
            /// <summary>
            /// HostPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-jmxprometheusexporter.html#cfn-applicationinsights-application-jmxprometheusexporter-hostport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostPort { get; set; }
        }

        public class Log : Humidifier.Base.BaseSubResource, IHaveLogGroupName, IHaveLogType
        {
            /// <summary>
            /// LogType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-log.html#cfn-applicationinsights-application-log-logtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogType { get; set; }
            /// <summary>
            /// Encoding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-log.html#cfn-applicationinsights-application-log-encoding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Encoding { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-log.html#cfn-applicationinsights-application-log-loggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroupName { get; set; }
            /// <summary>
            /// LogPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-log.html#cfn-applicationinsights-application-log-logpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogPath { get; set; }
            /// <summary>
            /// PatternSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-log.html#cfn-applicationinsights-application-log-patternset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PatternSet { get; set; }
        }

        public class LogPattern : Humidifier.Base.BaseSubResource, IHavePattern
        {
            /// <summary>
            /// Pattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-logpattern.html#cfn-applicationinsights-application-logpattern-pattern
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Pattern { get; set; }
            /// <summary>
            /// Rank
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-logpattern.html#cfn-applicationinsights-application-logpattern-rank
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Rank { get; set; }
            /// <summary>
            /// PatternName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-logpattern.html#cfn-applicationinsights-application-logpattern-patternname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PatternName { get; set; }
        }

        public class LogPatternSet : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PatternSetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-logpatternset.html#cfn-applicationinsights-application-logpatternset-patternsetname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PatternSetName { get; set; }
            /// <summary>
            /// LogPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-logpatternset.html#cfn-applicationinsights-application-logpatternset-logpatterns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LogPattern
            /// </summary>
            public List<Humidifier.ApplicationInsights.ApplicationTypes.LogPattern> LogPatterns { get; set; }
        }

        public class NetWeaverPrometheusExporter : Humidifier.Base.BaseSubResource, IHavePrometheusPort
        {
            /// <summary>
            /// PrometheusPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-netweaverprometheusexporter.html#cfn-applicationinsights-application-netweaverprometheusexporter-prometheusport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrometheusPort { get; set; }
            /// <summary>
            /// InstanceNumbers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-netweaverprometheusexporter.html#cfn-applicationinsights-application-netweaverprometheusexporter-instancenumbers
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InstanceNumbers { get; set; }
            /// <summary>
            /// SAPSID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-netweaverprometheusexporter.html#cfn-applicationinsights-application-netweaverprometheusexporter-sapsid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SAPSID { get; set; }
        }

        public class Process : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProcessName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-process.html#cfn-applicationinsights-application-process-processname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProcessName { get; set; }
            /// <summary>
            /// AlarmMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-process.html#cfn-applicationinsights-application-process-alarmmetrics
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AlarmMetric
            /// </summary>
            public List<Humidifier.ApplicationInsights.ApplicationTypes.AlarmMetric> AlarmMetrics { get; set; }
        }

        public class SQLServerPrometheusExporter : Humidifier.Base.BaseSubResource, IHavePrometheusPort
        {
            /// <summary>
            /// PrometheusPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-sqlserverprometheusexporter.html#cfn-applicationinsights-application-sqlserverprometheusexporter-prometheusport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrometheusPort { get; set; }
            /// <summary>
            /// SQLSecretName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-sqlserverprometheusexporter.html#cfn-applicationinsights-application-sqlserverprometheusexporter-sqlsecretname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SQLSecretName { get; set; }
        }

        public class SubComponentConfigurationDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WindowsEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponentconfigurationdetails.html#cfn-applicationinsights-application-subcomponentconfigurationdetails-windowsevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WindowsEvent
            /// </summary>
            public List<Humidifier.ApplicationInsights.ApplicationTypes.WindowsEvent> WindowsEvents { get; set; }
            /// <summary>
            /// AlarmMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponentconfigurationdetails.html#cfn-applicationinsights-application-subcomponentconfigurationdetails-alarmmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AlarmMetric
            /// </summary>
            public List<Humidifier.ApplicationInsights.ApplicationTypes.AlarmMetric> AlarmMetrics { get; set; }
            /// <summary>
            /// Logs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponentconfigurationdetails.html#cfn-applicationinsights-application-subcomponentconfigurationdetails-logs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Log
            /// </summary>
            public List<Humidifier.ApplicationInsights.ApplicationTypes.Log> Logs { get; set; }
            /// <summary>
            /// Processes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponentconfigurationdetails.html#cfn-applicationinsights-application-subcomponentconfigurationdetails-processes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Process
            /// </summary>
            public List<Humidifier.ApplicationInsights.ApplicationTypes.Process> Processes { get; set; }
        }

        public class SubComponentTypeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SubComponentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponenttypeconfiguration.html#cfn-applicationinsights-application-subcomponenttypeconfiguration-subcomponenttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubComponentType { get; set; }
            /// <summary>
            /// SubComponentConfigurationDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponenttypeconfiguration.html#cfn-applicationinsights-application-subcomponenttypeconfiguration-subcomponentconfigurationdetails
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SubComponentConfigurationDetails
            /// </summary>
            public Humidifier.ApplicationInsights.ApplicationTypes.SubComponentConfigurationDetails SubComponentConfigurationDetails { get; set; }
        }

        public class WindowsEvent : Humidifier.Base.BaseSubResource, IHaveLogGroupName, IHaveEventName
        {
            /// <summary>
            /// EventLevels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-windowsevent.html#cfn-applicationinsights-application-windowsevent-eventlevels
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic EventLevels { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-windowsevent.html#cfn-applicationinsights-application-windowsevent-loggroupname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroupName { get; set; }
            /// <summary>
            /// EventName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-windowsevent.html#cfn-applicationinsights-application-windowsevent-eventname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventName { get; set; }
            /// <summary>
            /// PatternSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-windowsevent.html#cfn-applicationinsights-application-windowsevent-patternset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PatternSet { get; set; }
        }
    }
}