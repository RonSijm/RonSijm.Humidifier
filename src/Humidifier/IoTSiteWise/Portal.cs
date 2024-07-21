namespace Humidifier.IoTSiteWise
{
    using System.Collections.Generic;
    using PortalTypes;

    public class Portal : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string PortalArn =  "PortalArn" ;
            public static string PortalStartUrl =  "PortalStartUrl" ;
            public static string PortalId =  "PortalId" ;
            public static string PortalClientId =  "PortalClientId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::IoTSiteWise::Portal";
            }
        }

        /// <summary>
        /// PortalName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html#cfn-iotsitewise-portal-portalname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PortalName { get; set; }
        /// <summary>
        /// PortalAuthMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html#cfn-iotsitewise-portal-portalauthmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PortalAuthMode { get; set; }
        /// <summary>
        /// NotificationSenderEmail
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html#cfn-iotsitewise-portal-notificationsenderemail
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NotificationSenderEmail { get; set; }
        /// <summary>
        /// Alarms
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html#cfn-iotsitewise-portal-alarms
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Alarms
        /// </summary>
        public Alarms Alarms { get; set; }
        /// <summary>
        /// PortalContactEmail
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html#cfn-iotsitewise-portal-portalcontactemail
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PortalContactEmail { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html#cfn-iotsitewise-portal-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html#cfn-iotsitewise-portal-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// PortalDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html#cfn-iotsitewise-portal-portaldescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PortalDescription { get; set; }
    }

    namespace PortalTypes
    {
        public class Alarms
        {
            /// <summary>
            /// NotificationLambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-portal-alarms.html#cfn-iotsitewise-portal-alarms-notificationlambdaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NotificationLambdaArn { get; set; }
            /// <summary>
            /// AlarmRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-portal-alarms.html#cfn-iotsitewise-portal-alarms-alarmrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlarmRoleArn { get; set; }
        }
    }
}