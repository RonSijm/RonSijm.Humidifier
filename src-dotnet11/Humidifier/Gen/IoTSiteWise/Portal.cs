namespace Humidifier.IoTSiteWise
{
    using global::System.Collections.Generic;
    using PortalTypes;

    public class Portal : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePortalName, IHavePortalAuthMode, IHaveNotificationSenderEmail, IHaveIoTSiteWisePortalTypesAlarmsAlarms, IHaveMapOfIoTSiteWisePortalTypesPortalTypeEntryPortalTypeConfiguration, IHavePortalContactEmail, IHaveRoleArn, IHavePortalType, IHavePortalDescription, IHaveDescription
    {
        public class Attributes
        {
            public static string PortalArn =  "PortalArn" ;
            public static string PortalStartUrl =  "PortalStartUrl" ;
            public static string PortalId =  "PortalId" ;
            public static string PortalClientId =  "PortalClientId" ;
        }

        public override string AWSTypeName { get => AWS.IoTSiteWise.Portal; }
        public Union<string, BaseFunction>? PortalName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// PortalAuthMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html#cfn-iotsitewise-portal-portalauthmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PortalAuthMode { get; set; }
        /// <summary>
        /// NotificationSenderEmail
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html#cfn-iotsitewise-portal-notificationsenderemail
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NotificationSenderEmail { get; set; }
        /// <summary>
        /// Alarms
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html#cfn-iotsitewise-portal-alarms
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Alarms
        /// </summary>
        public Union<Humidifier.IoTSiteWise.PortalTypes.Alarms, BaseFunction>? Alarms { get; set; }
        /// <summary>
        /// PortalTypeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html#cfn-iotsitewise-portal-portaltypeconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: PortalTypeEntry
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.IoTSiteWise.PortalTypes.PortalTypeEntry>, IReadOnlyDictionary<string, Union<Humidifier.IoTSiteWise.PortalTypes.PortalTypeEntry, BaseFunction>>, BaseFunction>? PortalTypeConfiguration { get; set; }

        /// <summary>
        /// PortalContactEmail
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html#cfn-iotsitewise-portal-portalcontactemail
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PortalContactEmail { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html#cfn-iotsitewise-portal-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// PortalType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html#cfn-iotsitewise-portal-portaltype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PortalType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html#cfn-iotsitewise-portal-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// PortalDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html#cfn-iotsitewise-portal-portaldescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PortalDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => PortalDescription; set => PortalDescription = value; }
    }

    namespace PortalTypes
    {
        public class Alarms : Humidifier.Base.BaseSubResource, IHaveNotificationLambdaArn, IHaveAlarmRoleArn
        {
            /// <summary>
            /// NotificationLambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-portal-alarms.html#cfn-iotsitewise-portal-alarms-notificationlambdaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NotificationLambdaArn { get; set; }
            /// <summary>
            /// AlarmRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-portal-alarms.html#cfn-iotsitewise-portal-alarms-alarmrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlarmRoleArn { get; set; }
        }

        public class PortalTypeEntry : Humidifier.Base.BaseSubResource, IHaveStringListOfPortalTools
        {
            /// <summary>
            /// PortalTools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-portal-portaltypeentry.html#cfn-iotsitewise-portal-portaltypeentry-portaltools
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PortalTools { get; set; }
        }
    }
}