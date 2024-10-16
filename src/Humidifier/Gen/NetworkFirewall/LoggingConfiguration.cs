namespace Humidifier.NetworkFirewall
{
    using System.Collections.Generic;
    using LoggingConfigurationTypes;

    public class LoggingConfiguration : Humidifier.Base.BaseResource
    {
        public override string AWSTypeName { get => AWS.NetworkFirewall.LoggingConfiguration; }
        /// <summary>
        /// FirewallName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-loggingconfiguration.html#cfn-networkfirewall-loggingconfiguration-firewallname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FirewallName { get; set; }

        /// <summary>
        /// FirewallArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-loggingconfiguration.html#cfn-networkfirewall-loggingconfiguration-firewallarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FirewallArn { get; set; }

        /// <summary>
        /// LoggingConfiguration_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-loggingconfiguration.html#cfn-networkfirewall-loggingconfiguration-loggingconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: LoggingConfiguration
        /// </summary>
        [Required]
        public Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration LoggingConfiguration_ { get; set; }
    }

    namespace LoggingConfigurationTypes
    {
        public class LogDestinationConfig : Humidifier.Base.BaseSubResource, IHaveLogType
        {
            /// <summary>
            /// LogType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-loggingconfiguration-logdestinationconfig.html#cfn-networkfirewall-loggingconfiguration-logdestinationconfig-logtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogType { get; set; }
            /// <summary>
            /// LogDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-loggingconfiguration-logdestinationconfig.html#cfn-networkfirewall-loggingconfiguration-logdestinationconfig-logdestination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> LogDestination { get; set; }
            /// <summary>
            /// LogDestinationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-loggingconfiguration-logdestinationconfig.html#cfn-networkfirewall-loggingconfiguration-logdestinationconfig-logdestinationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogDestinationType { get; set; }
        }

        public class LoggingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LogDestinationConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-loggingconfiguration-loggingconfiguration.html#cfn-networkfirewall-loggingconfiguration-loggingconfiguration-logdestinationconfigs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LogDestinationConfig
            /// </summary>
            public List<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig> LogDestinationConfigs { get; set; }
        }
    }
}