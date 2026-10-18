namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using FolderTypes;

    public class Folder : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSharingModel, IHaveAwsAccountId, IHaveListOfQuickSightFolderTypesResourcePermissionPermissions, IHaveFolderId, IHaveParentFolderArn, IHaveFolderType, IHaveName
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.Folder; }
        /// <summary>
        /// SharingModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-folder.html#cfn-quicksight-folder-sharingmodel
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SharingModel { get; set; }
        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-folder.html#cfn-quicksight-folder-awsaccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AwsAccountId { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-folder.html#cfn-quicksight-folder-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QuickSight.FolderTypes.ResourcePermission>, IReadOnlyList<Union<Humidifier.QuickSight.FolderTypes.ResourcePermission, BaseFunction>>, BaseFunction>? Permissions { get; set; }
        /// <summary>
        /// FolderId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-folder.html#cfn-quicksight-folder-folderid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FolderId { get; set; }
        /// <summary>
        /// ParentFolderArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-folder.html#cfn-quicksight-folder-parentfolderarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ParentFolderArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-folder.html#cfn-quicksight-folder-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// FolderType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-folder.html#cfn-quicksight-folder-foldertype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FolderType { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace FolderTypes
    {
        public class ResourcePermission : Humidifier.Base.BaseSubResource, IHaveStringListOfActions, IHavePrincipal
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-folder-resourcepermission.html#cfn-quicksight-folder-resourcepermission-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-folder-resourcepermission.html#cfn-quicksight-folder-resourcepermission-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Principal { get; set; }
        }
    }
}