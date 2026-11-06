namespace Humidifier.WorkSpaces
{
    using global::System.Collections.Generic;
    using WorkspaceImageTypes;

    public class WorkspaceImage : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
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
        public dynamic Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspaceimage.html#cfn-workspaces-workspaceimage-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
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
            public dynamic Type { get; set; }
        }

        public class UpdateResult : Humidifier.Base.BaseSubResource, IHaveDescription
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspaceimage-updateresult.html#cfn-workspaces-workspaceimage-updateresult-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// UpdateAvailable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspaceimage-updateresult.html#cfn-workspaces-workspaceimage-updateresult-updateavailable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic UpdateAvailable { get; set; }
        }
    }
}