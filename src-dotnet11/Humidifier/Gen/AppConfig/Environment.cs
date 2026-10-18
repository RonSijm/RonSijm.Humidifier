namespace Humidifier.AppConfig
{
    using global::System.Collections.Generic;
    using EnvironmentTypes;

    public class Environment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveListOfAppConfigEnvironmentTypesMonitorMonitors, IHaveDeletionProtectionCheck, IHaveApplicationId, IHaveName
    {
        public class Attributes
        {
            public static string EnvironmentId =  "EnvironmentId" ;
        }

        public override string AWSTypeName { get => AWS.AppConfig.Environment; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-environment.html#cfn-appconfig-environment-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Monitors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-environment.html#cfn-appconfig-environment-monitors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Monitor
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AppConfig.EnvironmentTypes.Monitor>, IReadOnlyList<Union<Humidifier.AppConfig.EnvironmentTypes.Monitor, BaseFunction>>, BaseFunction>? Monitors { get; set; }
        /// <summary>
        /// DeletionProtectionCheck
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-environment.html#cfn-appconfig-environment-deletionprotectioncheck
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeletionProtectionCheck { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-environment.html#cfn-appconfig-environment-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-environment.html#cfn-appconfig-environment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace EnvironmentTypes
    {
        public class Monitor : Humidifier.Base.BaseSubResource, IHaveAlarmArn, IHaveAlarmRoleArn
        {
            /// <summary>
            /// AlarmArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-environment-monitor.html#cfn-appconfig-environment-monitor-alarmarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlarmArn { get; set; }
            /// <summary>
            /// AlarmRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-environment-monitor.html#cfn-appconfig-environment-monitor-alarmrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlarmRoleArn { get; set; }
        }
    }
}