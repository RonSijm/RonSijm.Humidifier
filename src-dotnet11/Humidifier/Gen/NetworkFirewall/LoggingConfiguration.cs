namespace Humidifier.NetworkFirewall
{
    using global::System.Collections.Generic;
    using LoggingConfigurationTypes;

    public class LoggingConfiguration : Humidifier.Base.BaseResource, IHaveEnableMonitoringDashboard_Boolean, IHaveFirewallName, IHaveFirewallArn, IHaveNetworkFirewallLoggingConfigurationTypesLoggingConfigurationLoggingConfiguration_
    {
        public override string AWSTypeName { get => AWS.NetworkFirewall.LoggingConfiguration; }
        /// <summary>
        /// EnableMonitoringDashboard
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-loggingconfiguration.html#cfn-networkfirewall-loggingconfiguration-enablemonitoringdashboard
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableMonitoringDashboard { get; set; }
        /// <summary>
        /// FirewallName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-loggingconfiguration.html#cfn-networkfirewall-loggingconfiguration-firewallname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FirewallName { get; set; }

        /// <summary>
        /// FirewallArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-loggingconfiguration.html#cfn-networkfirewall-loggingconfiguration-firewallarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FirewallArn { get; set; }

        /// <summary>
        /// LoggingConfiguration_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-loggingconfiguration.html#cfn-networkfirewall-loggingconfiguration-loggingconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: LoggingConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration, BaseFunction>? LoggingConfiguration_ { get; set; }
    }

    namespace LoggingConfigurationTypes
    {
        public class LogDestinationConfig : Humidifier.Base.BaseSubResource, IHaveLogType, IHaveStringDictionaryOfLogDestination, IHaveLogDestinationType
        {
            /// <summary>
            /// LogType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-loggingconfiguration-logdestinationconfig.html#cfn-networkfirewall-loggingconfiguration-logdestinationconfig-logtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogType { get; set; }
            /// <summary>
            /// LogDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-loggingconfiguration-logdestinationconfig.html#cfn-networkfirewall-loggingconfiguration-logdestinationconfig-logdestination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? LogDestination { get; set; }
            /// <summary>
            /// LogDestinationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-loggingconfiguration-logdestinationconfig.html#cfn-networkfirewall-loggingconfiguration-logdestinationconfig-logdestinationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogDestinationType { get; set; }
        }

        public class LoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfNetworkFirewallLoggingConfigurationTypesLogDestinationConfigLogDestinationConfigs
        {
            /// <summary>
            /// LogDestinationConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-loggingconfiguration-loggingconfiguration.html#cfn-networkfirewall-loggingconfiguration-loggingconfiguration-logdestinationconfigs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LogDestinationConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig>, IReadOnlyList<Union<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig, BaseFunction>>, BaseFunction>? LogDestinationConfigs { get; set; }
        }
    }
}