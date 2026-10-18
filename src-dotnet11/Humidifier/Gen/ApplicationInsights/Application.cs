namespace Humidifier.ApplicationInsights
{
    using global::System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveTags, IHaveAutoConfigurationEnabled_Boolean, IHaveOpsItemSNSTopicArn, IHaveOpsCenterEnabled_Boolean, IHaveListOfApplicationInsightsApplicationTypesCustomComponentCustomComponents, IHaveSNSNotificationArn, IHaveAttachMissingPermission_Boolean, IHaveListOfApplicationInsightsApplicationTypesLogPatternSetLogPatternSets, IHaveGroupingType, IHaveListOfApplicationInsightsApplicationTypesComponentMonitoringSettingComponentMonitoringSettings, IHaveCWEMonitorEnabled_Boolean, IHaveResourceGroupName
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
        public Union<bool, BaseFunction>? AutoConfigurationEnabled { get; set; }
        /// <summary>
        /// OpsItemSNSTopicArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-opsitemsnstopicarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OpsItemSNSTopicArn { get; set; }
        /// <summary>
        /// OpsCenterEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-opscenterenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? OpsCenterEnabled { get; set; }
        /// <summary>
        /// CustomComponents
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-customcomponents
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CustomComponent
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ApplicationInsights.ApplicationTypes.CustomComponent>, IReadOnlyList<Union<Humidifier.ApplicationInsights.ApplicationTypes.CustomComponent, BaseFunction>>, BaseFunction>? CustomComponents { get; set; }
        /// <summary>
        /// SNSNotificationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-snsnotificationarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SNSNotificationArn { get; set; }
        /// <summary>
        /// AttachMissingPermission
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-attachmissingpermission
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AttachMissingPermission { get; set; }
        /// <summary>
        /// LogPatternSets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-logpatternsets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LogPatternSet
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ApplicationInsights.ApplicationTypes.LogPatternSet>, IReadOnlyList<Union<Humidifier.ApplicationInsights.ApplicationTypes.LogPatternSet, BaseFunction>>, BaseFunction>? LogPatternSets { get; set; }
        /// <summary>
        /// GroupingType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-groupingtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GroupingType { get; set; }
        /// <summary>
        /// ComponentMonitoringSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-componentmonitoringsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ComponentMonitoringSetting
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ApplicationInsights.ApplicationTypes.ComponentMonitoringSetting>, IReadOnlyList<Union<Humidifier.ApplicationInsights.ApplicationTypes.ComponentMonitoringSetting, BaseFunction>>, BaseFunction>? ComponentMonitoringSettings { get; set; }
        /// <summary>
        /// CWEMonitorEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-cwemonitorenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? CWEMonitorEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// ResourceGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html#cfn-applicationinsights-application-resourcegroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceGroupName { get; set; }
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
            public Union<string, BaseFunction>? AlarmName { get; set; }
            /// <summary>
            /// Severity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-alarm.html#cfn-applicationinsights-application-alarm-severity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Severity { get; set; }
        }

        public class AlarmMetric : Humidifier.Base.BaseSubResource, IHaveAlarmMetricName
        {
            /// <summary>
            /// AlarmMetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-alarmmetric.html#cfn-applicationinsights-application-alarmmetric-alarmmetricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlarmMetricName { get; set; }
        }

        public class ComponentConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfApplicationInsightsApplicationTypesSubComponentTypeConfigurationSubComponentTypeConfigurations, IHaveApplicationInsightsApplicationTypesConfigurationDetailsConfigurationDetails
        {
            /// <summary>
            /// SubComponentTypeConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentconfiguration.html#cfn-applicationinsights-application-componentconfiguration-subcomponenttypeconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SubComponentTypeConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationInsights.ApplicationTypes.SubComponentTypeConfiguration>, IReadOnlyList<Union<Humidifier.ApplicationInsights.ApplicationTypes.SubComponentTypeConfiguration, BaseFunction>>, BaseFunction>? SubComponentTypeConfigurations { get; set; }
            /// <summary>
            /// ConfigurationDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentconfiguration.html#cfn-applicationinsights-application-componentconfiguration-configurationdetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfigurationDetails
            /// </summary>
            public Union<Humidifier.ApplicationInsights.ApplicationTypes.ConfigurationDetails, BaseFunction>? ConfigurationDetails { get; set; }
        }

        public class ComponentMonitoringSetting : Humidifier.Base.BaseSubResource, IHaveApplicationInsightsApplicationTypesComponentConfigurationCustomComponentConfiguration, IHaveTier, IHaveComponentConfigurationMode, IHaveApplicationInsightsApplicationTypesComponentConfigurationDefaultOverwriteComponentConfiguration, IHaveComponentName, IHaveComponentARN
        {
            /// <summary>
            /// CustomComponentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentmonitoringsetting.html#cfn-applicationinsights-application-componentmonitoringsetting-customcomponentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentConfiguration
            /// </summary>
            public Union<Humidifier.ApplicationInsights.ApplicationTypes.ComponentConfiguration, BaseFunction>? CustomComponentConfiguration { get; set; }
            /// <summary>
            /// Tier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentmonitoringsetting.html#cfn-applicationinsights-application-componentmonitoringsetting-tier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Tier { get; set; }
            /// <summary>
            /// ComponentConfigurationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentmonitoringsetting.html#cfn-applicationinsights-application-componentmonitoringsetting-componentconfigurationmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentConfigurationMode { get; set; }
            /// <summary>
            /// DefaultOverwriteComponentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentmonitoringsetting.html#cfn-applicationinsights-application-componentmonitoringsetting-defaultoverwritecomponentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentConfiguration
            /// </summary>
            public Union<Humidifier.ApplicationInsights.ApplicationTypes.ComponentConfiguration, BaseFunction>? DefaultOverwriteComponentConfiguration { get; set; }
            /// <summary>
            /// ComponentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentmonitoringsetting.html#cfn-applicationinsights-application-componentmonitoringsetting-componentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentName { get; set; }
            /// <summary>
            /// ComponentARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentmonitoringsetting.html#cfn-applicationinsights-application-componentmonitoringsetting-componentarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentARN { get; set; }
        }

        public class ConfigurationDetails : Humidifier.Base.BaseSubResource, IHaveApplicationInsightsApplicationTypesNetWeaverPrometheusExporterNetWeaverPrometheusExporter, IHaveListOfApplicationInsightsApplicationTypesWindowsEventWindowsEvents, IHaveListOfApplicationInsightsApplicationTypesAlarmMetricAlarmMetrics, IHaveListOfApplicationInsightsApplicationTypesAlarmAlarms, IHaveApplicationInsightsApplicationTypesSQLServerPrometheusExporterSQLServerPrometheusExporter, IHaveApplicationInsightsApplicationTypesHAClusterPrometheusExporterHAClusterPrometheusExporter, IHaveApplicationInsightsApplicationTypesHANAPrometheusExporterHANAPrometheusExporter, IHaveListOfApplicationInsightsApplicationTypesLogLogs, IHaveListOfApplicationInsightsApplicationTypesProcessProcesses, IHaveApplicationInsightsApplicationTypesJMXPrometheusExporterJMXPrometheusExporter
        {
            /// <summary>
            /// NetWeaverPrometheusExporter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-netweaverprometheusexporter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetWeaverPrometheusExporter
            /// </summary>
            public Union<Humidifier.ApplicationInsights.ApplicationTypes.NetWeaverPrometheusExporter, BaseFunction>? NetWeaverPrometheusExporter { get; set; }
            /// <summary>
            /// WindowsEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-windowsevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WindowsEvent
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationInsights.ApplicationTypes.WindowsEvent>, IReadOnlyList<Union<Humidifier.ApplicationInsights.ApplicationTypes.WindowsEvent, BaseFunction>>, BaseFunction>? WindowsEvents { get; set; }
            /// <summary>
            /// AlarmMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-alarmmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AlarmMetric
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationInsights.ApplicationTypes.AlarmMetric>, IReadOnlyList<Union<Humidifier.ApplicationInsights.ApplicationTypes.AlarmMetric, BaseFunction>>, BaseFunction>? AlarmMetrics { get; set; }
            /// <summary>
            /// Alarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-alarms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Alarm
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationInsights.ApplicationTypes.Alarm>, IReadOnlyList<Union<Humidifier.ApplicationInsights.ApplicationTypes.Alarm, BaseFunction>>, BaseFunction>? Alarms { get; set; }
            /// <summary>
            /// SQLServerPrometheusExporter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-sqlserverprometheusexporter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SQLServerPrometheusExporter
            /// </summary>
            public Union<Humidifier.ApplicationInsights.ApplicationTypes.SQLServerPrometheusExporter, BaseFunction>? SQLServerPrometheusExporter { get; set; }
            /// <summary>
            /// HAClusterPrometheusExporter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-haclusterprometheusexporter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HAClusterPrometheusExporter
            /// </summary>
            public Union<Humidifier.ApplicationInsights.ApplicationTypes.HAClusterPrometheusExporter, BaseFunction>? HAClusterPrometheusExporter { get; set; }
            /// <summary>
            /// HANAPrometheusExporter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-hanaprometheusexporter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HANAPrometheusExporter
            /// </summary>
            public Union<Humidifier.ApplicationInsights.ApplicationTypes.HANAPrometheusExporter, BaseFunction>? HANAPrometheusExporter { get; set; }
            /// <summary>
            /// Logs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-logs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Log
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationInsights.ApplicationTypes.Log>, IReadOnlyList<Union<Humidifier.ApplicationInsights.ApplicationTypes.Log, BaseFunction>>, BaseFunction>? Logs { get; set; }
            /// <summary>
            /// Processes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-processes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Process
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationInsights.ApplicationTypes.Process>, IReadOnlyList<Union<Humidifier.ApplicationInsights.ApplicationTypes.Process, BaseFunction>>, BaseFunction>? Processes { get; set; }
            /// <summary>
            /// JMXPrometheusExporter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html#cfn-applicationinsights-application-configurationdetails-jmxprometheusexporter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JMXPrometheusExporter
            /// </summary>
            public Union<Humidifier.ApplicationInsights.ApplicationTypes.JMXPrometheusExporter, BaseFunction>? JMXPrometheusExporter { get; set; }
        }

        public class CustomComponent : Humidifier.Base.BaseSubResource, IHaveStringListOfResourceList, IHaveComponentName
        {
            /// <summary>
            /// ResourceList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-customcomponent.html#cfn-applicationinsights-application-customcomponent-resourcelist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceList { get; set; }
            /// <summary>
            /// ComponentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-customcomponent.html#cfn-applicationinsights-application-customcomponent-componentname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentName { get; set; }
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
            public Union<string, BaseFunction>? PrometheusPort { get; set; }
        }

        public class HANAPrometheusExporter : Humidifier.Base.BaseSubResource, IHaveHANAPort, IHavePrometheusPort, IHaveHANASecretName, IHaveHANASID, IHaveAgreeToInstallHANADBClient_Boolean
        {
            /// <summary>
            /// HANAPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-hanaprometheusexporter.html#cfn-applicationinsights-application-hanaprometheusexporter-hanaport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HANAPort { get; set; }
            /// <summary>
            /// PrometheusPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-hanaprometheusexporter.html#cfn-applicationinsights-application-hanaprometheusexporter-prometheusport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrometheusPort { get; set; }
            /// <summary>
            /// HANASecretName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-hanaprometheusexporter.html#cfn-applicationinsights-application-hanaprometheusexporter-hanasecretname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HANASecretName { get; set; }
            /// <summary>
            /// HANASID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-hanaprometheusexporter.html#cfn-applicationinsights-application-hanaprometheusexporter-hanasid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HANASID { get; set; }
            /// <summary>
            /// AgreeToInstallHANADBClient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-hanaprometheusexporter.html#cfn-applicationinsights-application-hanaprometheusexporter-agreetoinstallhanadbclient
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AgreeToInstallHANADBClient { get; set; }
        }

        public class JMXPrometheusExporter : Humidifier.Base.BaseSubResource, IHavePrometheusPort, IHaveJMXURL, IHaveHostPort
        {
            /// <summary>
            /// PrometheusPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-jmxprometheusexporter.html#cfn-applicationinsights-application-jmxprometheusexporter-prometheusport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrometheusPort { get; set; }
            /// <summary>
            /// JMXURL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-jmxprometheusexporter.html#cfn-applicationinsights-application-jmxprometheusexporter-jmxurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JMXURL { get; set; }
            /// <summary>
            /// HostPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-jmxprometheusexporter.html#cfn-applicationinsights-application-jmxprometheusexporter-hostport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostPort { get; set; }
        }

        public class Log : Humidifier.Base.BaseSubResource, IHaveLogType, IHaveEncoding, IHaveLogGroupName, IHaveLogPath, IHavePatternSet
        {
            /// <summary>
            /// LogType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-log.html#cfn-applicationinsights-application-log-logtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogType { get; set; }
            /// <summary>
            /// Encoding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-log.html#cfn-applicationinsights-application-log-encoding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Encoding { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-log.html#cfn-applicationinsights-application-log-loggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupName { get; set; }
            /// <summary>
            /// LogPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-log.html#cfn-applicationinsights-application-log-logpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogPath { get; set; }
            /// <summary>
            /// PatternSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-log.html#cfn-applicationinsights-application-log-patternset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PatternSet { get; set; }
        }

        public class LogPattern : Humidifier.Base.BaseSubResource, IHavePattern, IHaveRank_Integer, IHavePatternName
        {
            /// <summary>
            /// Pattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-logpattern.html#cfn-applicationinsights-application-logpattern-pattern
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Pattern { get; set; }
            /// <summary>
            /// Rank
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-logpattern.html#cfn-applicationinsights-application-logpattern-rank
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Rank { get; set; }
            /// <summary>
            /// PatternName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-logpattern.html#cfn-applicationinsights-application-logpattern-patternname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PatternName { get; set; }
        }

        public class LogPatternSet : Humidifier.Base.BaseSubResource, IHavePatternSetName, IHaveListOfApplicationInsightsApplicationTypesLogPatternLogPatterns
        {
            /// <summary>
            /// PatternSetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-logpatternset.html#cfn-applicationinsights-application-logpatternset-patternsetname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PatternSetName { get; set; }
            /// <summary>
            /// LogPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-logpatternset.html#cfn-applicationinsights-application-logpatternset-logpatterns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LogPattern
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationInsights.ApplicationTypes.LogPattern>, IReadOnlyList<Union<Humidifier.ApplicationInsights.ApplicationTypes.LogPattern, BaseFunction>>, BaseFunction>? LogPatterns { get; set; }
        }

        public class NetWeaverPrometheusExporter : Humidifier.Base.BaseSubResource, IHavePrometheusPort, IHaveStringListOfInstanceNumbers, IHaveSAPSID
        {
            /// <summary>
            /// PrometheusPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-netweaverprometheusexporter.html#cfn-applicationinsights-application-netweaverprometheusexporter-prometheusport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrometheusPort { get; set; }
            /// <summary>
            /// InstanceNumbers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-netweaverprometheusexporter.html#cfn-applicationinsights-application-netweaverprometheusexporter-instancenumbers
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InstanceNumbers { get; set; }
            /// <summary>
            /// SAPSID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-netweaverprometheusexporter.html#cfn-applicationinsights-application-netweaverprometheusexporter-sapsid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SAPSID { get; set; }
        }

        public class Process : Humidifier.Base.BaseSubResource, IHaveProcessName, IHaveListOfApplicationInsightsApplicationTypesAlarmMetricAlarmMetrics
        {
            /// <summary>
            /// ProcessName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-process.html#cfn-applicationinsights-application-process-processname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProcessName { get; set; }
            /// <summary>
            /// AlarmMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-process.html#cfn-applicationinsights-application-process-alarmmetrics
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AlarmMetric
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationInsights.ApplicationTypes.AlarmMetric>, IReadOnlyList<Union<Humidifier.ApplicationInsights.ApplicationTypes.AlarmMetric, BaseFunction>>, BaseFunction>? AlarmMetrics { get; set; }
        }

        public class SQLServerPrometheusExporter : Humidifier.Base.BaseSubResource, IHavePrometheusPort, IHaveSQLSecretName
        {
            /// <summary>
            /// PrometheusPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-sqlserverprometheusexporter.html#cfn-applicationinsights-application-sqlserverprometheusexporter-prometheusport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrometheusPort { get; set; }
            /// <summary>
            /// SQLSecretName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-sqlserverprometheusexporter.html#cfn-applicationinsights-application-sqlserverprometheusexporter-sqlsecretname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SQLSecretName { get; set; }
        }

        public class SubComponentConfigurationDetails : Humidifier.Base.BaseSubResource, IHaveListOfApplicationInsightsApplicationTypesWindowsEventWindowsEvents, IHaveListOfApplicationInsightsApplicationTypesAlarmMetricAlarmMetrics, IHaveListOfApplicationInsightsApplicationTypesLogLogs, IHaveListOfApplicationInsightsApplicationTypesProcessProcesses
        {
            /// <summary>
            /// WindowsEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponentconfigurationdetails.html#cfn-applicationinsights-application-subcomponentconfigurationdetails-windowsevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WindowsEvent
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationInsights.ApplicationTypes.WindowsEvent>, IReadOnlyList<Union<Humidifier.ApplicationInsights.ApplicationTypes.WindowsEvent, BaseFunction>>, BaseFunction>? WindowsEvents { get; set; }
            /// <summary>
            /// AlarmMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponentconfigurationdetails.html#cfn-applicationinsights-application-subcomponentconfigurationdetails-alarmmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AlarmMetric
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationInsights.ApplicationTypes.AlarmMetric>, IReadOnlyList<Union<Humidifier.ApplicationInsights.ApplicationTypes.AlarmMetric, BaseFunction>>, BaseFunction>? AlarmMetrics { get; set; }
            /// <summary>
            /// Logs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponentconfigurationdetails.html#cfn-applicationinsights-application-subcomponentconfigurationdetails-logs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Log
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationInsights.ApplicationTypes.Log>, IReadOnlyList<Union<Humidifier.ApplicationInsights.ApplicationTypes.Log, BaseFunction>>, BaseFunction>? Logs { get; set; }
            /// <summary>
            /// Processes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponentconfigurationdetails.html#cfn-applicationinsights-application-subcomponentconfigurationdetails-processes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Process
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationInsights.ApplicationTypes.Process>, IReadOnlyList<Union<Humidifier.ApplicationInsights.ApplicationTypes.Process, BaseFunction>>, BaseFunction>? Processes { get; set; }
        }

        public class SubComponentTypeConfiguration : Humidifier.Base.BaseSubResource, IHaveSubComponentType, IHaveApplicationInsightsApplicationTypesSubComponentConfigurationDetailsSubComponentConfigurationDetails
        {
            /// <summary>
            /// SubComponentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponenttypeconfiguration.html#cfn-applicationinsights-application-subcomponenttypeconfiguration-subcomponenttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubComponentType { get; set; }
            /// <summary>
            /// SubComponentConfigurationDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponenttypeconfiguration.html#cfn-applicationinsights-application-subcomponenttypeconfiguration-subcomponentconfigurationdetails
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SubComponentConfigurationDetails
            /// </summary>
            public Union<Humidifier.ApplicationInsights.ApplicationTypes.SubComponentConfigurationDetails, BaseFunction>? SubComponentConfigurationDetails { get; set; }
        }

        public class WindowsEvent : Humidifier.Base.BaseSubResource, IHaveStringListOfEventLevels, IHaveLogGroupName, IHaveEventName, IHavePatternSet
        {
            /// <summary>
            /// EventLevels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-windowsevent.html#cfn-applicationinsights-application-windowsevent-eventlevels
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EventLevels { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-windowsevent.html#cfn-applicationinsights-application-windowsevent-loggroupname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupName { get; set; }
            /// <summary>
            /// EventName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-windowsevent.html#cfn-applicationinsights-application-windowsevent-eventname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventName { get; set; }
            /// <summary>
            /// PatternSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-windowsevent.html#cfn-applicationinsights-application-windowsevent-patternset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PatternSet { get; set; }
        }
    }
}