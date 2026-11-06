namespace Humidifier.WorkSpaces
{
    using global::System.Collections.Generic;
    using WorkspaceImageTypes;

    public class WorkspaceImage : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveName
    {
        public class Attributes
        {
            public static string OperatingSystem =  "OperatingSystem" ;
            public static string Updates =  "Updates" ;
            public static string State =  "State" ;
            public static string RequiredTenancy =  "RequiredTenancy" ;
            public static string ImageId =  "ImageId" ;
            public static string Arn =  "Arn" ;
            public static string OwnerAccountId =  "OwnerAccountId" ;
            public static string Created =  "Created" ;
        }

        public override string AWSTypeName { get => AWS.WorkSpaces.WorkspaceImage; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspaceimage.html#cfn-workspaces-workspaceimage-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspaceimage.html#cfn-workspaces-workspaceimage-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace WorkspaceImageTypes
    {
        public class OperatingSystem : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspaceimage-operatingsystem.html#cfn-workspaces-workspaceimage-operatingsystem-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class UpdateResult : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveUpdateAvailable_Boolean
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspaceimage-updateresult.html#cfn-workspaces-workspaceimage-updateresult-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// UpdateAvailable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspaceimage-updateresult.html#cfn-workspaces-workspaceimage-updateresult-updateavailable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UpdateAvailable { get; set; }
        }
    }
}