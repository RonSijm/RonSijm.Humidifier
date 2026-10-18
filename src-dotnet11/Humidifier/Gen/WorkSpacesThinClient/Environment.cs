namespace Humidifier.WorkSpacesThinClient
{
    using global::System.Collections.Generic;
    using EnvironmentTypes;

    public class Environment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDesiredSoftwareSetId, IHaveKmsKeyArn, IHaveDesktopArn, IHaveTagListOfDeviceCreationTags, IHaveSoftwareSetUpdateMode, IHaveSoftwareSetUpdateSchedule, IHaveWorkSpacesThinClientEnvironmentTypesMaintenanceWindowMaintenanceWindow, IHaveDesktopEndpoint, IHaveName
    {
        public class Attributes
        {
            public static string DesktopType =  "DesktopType" ;
            public static string RegisteredDevicesCount =  "RegisteredDevicesCount" ;
            public static string PendingSoftwareSetId =  "PendingSoftwareSetId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string PendingSoftwareSetVersion =  "PendingSoftwareSetVersion" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string ActivationCode =  "ActivationCode" ;
            public static string SoftwareSetComplianceStatus =  "SoftwareSetComplianceStatus" ;
        }

        public override string AWSTypeName { get => AWS.WorkSpacesThinClient.Environment; }
        /// <summary>
        /// DesiredSoftwareSetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesthinclient-environment.html#cfn-workspacesthinclient-environment-desiredsoftwaresetid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DesiredSoftwareSetId { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesthinclient-environment.html#cfn-workspacesthinclient-environment-kmskeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }

        /// <summary>
        /// DesktopArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesthinclient-environment.html#cfn-workspacesthinclient-environment-desktoparn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DesktopArn { get; set; }
        /// <summary>
        /// DeviceCreationTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesthinclient-environment.html#cfn-workspacesthinclient-environment-devicecreationtags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? DeviceCreationTags { get; set; }
        /// <summary>
        /// SoftwareSetUpdateMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesthinclient-environment.html#cfn-workspacesthinclient-environment-softwaresetupdatemode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SoftwareSetUpdateMode { get; set; }
        /// <summary>
        /// SoftwareSetUpdateSchedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesthinclient-environment.html#cfn-workspacesthinclient-environment-softwaresetupdateschedule
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SoftwareSetUpdateSchedule { get; set; }
        /// <summary>
        /// MaintenanceWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesthinclient-environment.html#cfn-workspacesthinclient-environment-maintenancewindow
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MaintenanceWindow
        /// </summary>
        public Union<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow, BaseFunction>? MaintenanceWindow { get; set; }
        /// <summary>
        /// DesktopEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesthinclient-environment.html#cfn-workspacesthinclient-environment-desktopendpoint
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DesktopEndpoint { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesthinclient-environment.html#cfn-workspacesthinclient-environment-tags
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
        public class MaintenanceWindow : Humidifier.Base.BaseSubResource, IHaveEndTimeMinute_Integer, IHaveType, IHaveStringListOfDaysOfTheWeek, IHaveApplyTimeOf, IHaveStartTimeMinute_Integer, IHaveStartTimeHour_Integer, IHaveEndTimeHour_Integer
        {
            /// <summary>
            /// EndTimeMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesthinclient-environment-maintenancewindow.html#cfn-workspacesthinclient-environment-maintenancewindow-endtimeminute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EndTimeMinute { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesthinclient-environment-maintenancewindow.html#cfn-workspacesthinclient-environment-maintenancewindow-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// DaysOfTheWeek
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesthinclient-environment-maintenancewindow.html#cfn-workspacesthinclient-environment-maintenancewindow-daysoftheweek
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DaysOfTheWeek { get; set; }
            /// <summary>
            /// ApplyTimeOf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesthinclient-environment-maintenancewindow.html#cfn-workspacesthinclient-environment-maintenancewindow-applytimeof
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplyTimeOf { get; set; }
            /// <summary>
            /// StartTimeMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesthinclient-environment-maintenancewindow.html#cfn-workspacesthinclient-environment-maintenancewindow-starttimeminute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StartTimeMinute { get; set; }
            /// <summary>
            /// StartTimeHour
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesthinclient-environment-maintenancewindow.html#cfn-workspacesthinclient-environment-maintenancewindow-starttimehour
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StartTimeHour { get; set; }
            /// <summary>
            /// EndTimeHour
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesthinclient-environment-maintenancewindow.html#cfn-workspacesthinclient-environment-maintenancewindow-endtimehour
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EndTimeHour { get; set; }
        }
    }
}