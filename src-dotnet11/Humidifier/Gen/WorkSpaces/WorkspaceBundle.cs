namespace Humidifier.WorkSpaces
{
    using global::System.Collections.Generic;
    using WorkspaceBundleTypes;

    public class WorkspaceBundle : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveImageId, IHaveWorkSpacesWorkspaceBundleTypesUserStorageUserStorage, IHaveWorkSpacesWorkspaceBundleTypesComputeTypeComputeType, IHaveName, IHaveWorkSpacesWorkspaceBundleTypesRootStorageRootStorage
    {
        public class Attributes
        {
            public static string Owner =  "Owner" ;
            public static string BundleId =  "BundleId" ;
            public static string BundleType =  "BundleType" ;
            public static string State =  "State" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.WorkSpaces.WorkspaceBundle; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspacebundle.html#cfn-workspaces-workspacebundle-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ImageId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspacebundle.html#cfn-workspaces-workspacebundle-imageid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImageId { get; set; }
        /// <summary>
        /// UserStorage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspacebundle.html#cfn-workspaces-workspacebundle-userstorage
        /// Required: False
        /// UpdateType: Immutable
        /// Type: UserStorage
        /// </summary>
        public Union<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage, BaseFunction>? UserStorage { get; set; }
        /// <summary>
        /// ComputeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspacebundle.html#cfn-workspaces-workspacebundle-computetype
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ComputeType
        /// </summary>
        public Union<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType, BaseFunction>? ComputeType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspacebundle.html#cfn-workspaces-workspacebundle-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// RootStorage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspacebundle.html#cfn-workspaces-workspacebundle-rootstorage
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RootStorage
        /// </summary>
        public Union<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage, BaseFunction>? RootStorage { get; set; }
    }

    namespace WorkspaceBundleTypes
    {
        public class ComputeType : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspacebundle-computetype.html#cfn-workspaces-workspacebundle-computetype-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RootStorage : Humidifier.Base.BaseSubResource, IHaveCapacity
        {
            /// <summary>
            /// Capacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspacebundle-rootstorage.html#cfn-workspaces-workspacebundle-rootstorage-capacity
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Capacity { get; set; }
        }

        public class UserStorage : Humidifier.Base.BaseSubResource, IHaveCapacity
        {
            /// <summary>
            /// Capacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspacebundle-userstorage.html#cfn-workspaces-workspacebundle-userstorage-capacity
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Capacity { get; set; }
        }
    }
}