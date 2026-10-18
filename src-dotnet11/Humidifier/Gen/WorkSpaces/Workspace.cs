namespace Humidifier.WorkSpaces
{
    using global::System.Collections.Generic;
    using WorkspaceTypes;

    public class Workspace : Humidifier.Base.BaseResource, IHaveTags, IHaveUserVolumeEncryptionEnabled_Boolean, IHaveBundleId, IHaveDirectoryId, IHaveUserName, IHaveRootVolumeEncryptionEnabled_Boolean, IHaveVolumeEncryptionKey, IHaveWorkSpacesWorkspaceTypesWorkspacePropertiesWorkspaceProperties
    {
        public class Attributes
        {
            public static string WorkspaceId =  "WorkspaceId" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.WorkSpaces.Workspace; }
        /// <summary>
        /// UserVolumeEncryptionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-uservolumeencryptionenabled
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? UserVolumeEncryptionEnabled { get; set; }

        /// <summary>
        /// BundleId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-bundleid
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BundleId { get; set; }

        /// <summary>
        /// DirectoryId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-directoryid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DirectoryId { get; set; }

        /// <summary>
        /// UserName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-username
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UserName { get; set; }
        /// <summary>
        /// RootVolumeEncryptionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-rootvolumeencryptionenabled
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? RootVolumeEncryptionEnabled { get; set; }
        /// <summary>
        /// VolumeEncryptionKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-volumeencryptionkey
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VolumeEncryptionKey { get; set; }
        /// <summary>
        /// WorkspaceProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-workspaceproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WorkspaceProperties
        /// </summary>
        public Union<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties, BaseFunction>? WorkspaceProperties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace WorkspaceTypes
    {
        public class WorkspaceProperties : Humidifier.Base.BaseSubResource, IHaveRootVolumeSizeGib_Integer, IHaveComputeTypeName, IHaveUserVolumeSizeGib_Integer, IHaveRunningModeAutoStopTimeoutInMinutes_Integer, IHaveRunningMode
        {
            /// <summary>
            /// RootVolumeSizeGib
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspace-workspaceproperties.html#cfn-workspaces-workspace-workspaceproperties-rootvolumesizegib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RootVolumeSizeGib { get; set; }
            /// <summary>
            /// ComputeTypeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspace-workspaceproperties.html#cfn-workspaces-workspace-workspaceproperties-computetypename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComputeTypeName { get; set; }
            /// <summary>
            /// UserVolumeSizeGib
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspace-workspaceproperties.html#cfn-workspaces-workspace-workspaceproperties-uservolumesizegib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UserVolumeSizeGib { get; set; }
            /// <summary>
            /// RunningModeAutoStopTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspace-workspaceproperties.html#cfn-workspaces-workspace-workspaceproperties-runningmodeautostoptimeoutinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RunningModeAutoStopTimeoutInMinutes { get; set; }
            /// <summary>
            /// RunningMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspace-workspaceproperties.html#cfn-workspaces-workspace-workspaceproperties-runningmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RunningMode { get; set; }
        }
    }
}