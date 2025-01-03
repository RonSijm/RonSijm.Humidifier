namespace Humidifier.WorkSpaces
{
    using System.Collections.Generic;
    using WorkspacesPoolTypes;

    public class WorkspacesPool : Humidifier.Base.BaseResource, IHaveDescription, IHaveBundleId, IHaveDirectoryId, IHavePoolName
    {
        public class Attributes
        {
            public static string PoolId =  "PoolId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string PoolArn =  "PoolArn" ;
        }

        public override string AWSTypeName { get => AWS.WorkSpaces.WorkspacesPool; }
        /// <summary>
        /// ApplicationSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspacespool.html#cfn-workspaces-workspacespool-applicationsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ApplicationSettings
        /// </summary>
        public Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings ApplicationSettings { get; set; }

        /// <summary>
        /// BundleId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspacespool.html#cfn-workspaces-workspacespool-bundleid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic BundleId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspacespool.html#cfn-workspaces-workspacespool-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// DirectoryId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspacespool.html#cfn-workspaces-workspacespool-directoryid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DirectoryId { get; set; }
        /// <summary>
        /// TimeoutSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspacespool.html#cfn-workspaces-workspacespool-timeoutsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TimeoutSettings
        /// </summary>
        public Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings TimeoutSettings { get; set; }

        /// <summary>
        /// Capacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspacespool.html#cfn-workspaces-workspacespool-capacity
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Capacity
        /// </summary>
        [Required]
        public Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity Capacity { get; set; }

        /// <summary>
        /// PoolName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspacespool.html#cfn-workspaces-workspacespool-poolname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PoolName { get; set; }
    }

    namespace WorkspacesPoolTypes
    {
        public class ApplicationSettings : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspacespool-applicationsettings.html#cfn-workspaces-workspacespool-applicationsettings-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// SettingsGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspacespool-applicationsettings.html#cfn-workspaces-workspacespool-applicationsettings-settingsgroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SettingsGroup { get; set; }
        }

        public class Capacity : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DesiredUserSessions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspacespool-capacity.html#cfn-workspaces-workspacespool-capacity-desiredusersessions
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DesiredUserSessions { get; set; }
        }

        public class TimeoutSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxUserDurationInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspacespool-timeoutsettings.html#cfn-workspaces-workspacespool-timeoutsettings-maxuserdurationinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxUserDurationInSeconds { get; set; }
            /// <summary>
            /// IdleDisconnectTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspacespool-timeoutsettings.html#cfn-workspaces-workspacespool-timeoutsettings-idledisconnecttimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IdleDisconnectTimeoutInSeconds { get; set; }
            /// <summary>
            /// DisconnectTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspacespool-timeoutsettings.html#cfn-workspaces-workspacespool-timeoutsettings-disconnecttimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DisconnectTimeoutInSeconds { get; set; }
        }
    }
}