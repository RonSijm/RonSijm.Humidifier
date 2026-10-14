namespace Humidifier.AppStream
{
    using global::System.Collections.Generic;
    using ImageTypes;

    public class Image : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Description =  "Description" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string Platform =  "Platform" ;
            public static string Applications =  "Applications" ;
            public static string LatestAppstreamAgentVersion =  "LatestAppstreamAgentVersion" ;
            public static string ImageBuilderSupported =  "ImageBuilderSupported" ;
            public static string AppstreamAgentVersion =  "AppstreamAgentVersion" ;
            public static string ImageSharedWithOthers =  "ImageSharedWithOthers" ;
            public static string ManagedSoftwareIncluded =  "ManagedSoftwareIncluded" ;
            public static string Name =  "Name" ;
            public static string ImageType =  "ImageType" ;
            public static string State =  "State" ;
            public static string DisplayName =  "DisplayName" ;
            public static string Visibility =  "Visibility" ;
            public static string Arn =  "Arn" ;
            public static string SupportedInstanceFamilies =  "SupportedInstanceFamilies" ;
            public static string DynamicAppProvidersEnabled =  "DynamicAppProvidersEnabled" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.AppStream.Image; }
    }

    namespace ImageTypes
    {
        public class Application : Humidifier.Base.BaseSubResource, IHaveName, IHaveEnabled, IHaveDisplayName, IHaveLaunchPath
        {
            /// <summary>
            /// DisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-image-application.html#cfn-appstream-image-application-displayname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DisplayName { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-image-application.html#cfn-appstream-image-application-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Metadata { get; set; }
            /// <summary>
            /// LaunchPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-image-application.html#cfn-appstream-image-application-launchpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LaunchPath { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-image-application.html#cfn-appstream-image-application-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// LaunchParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-image-application.html#cfn-appstream-image-application-launchparameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LaunchParameters { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-image-application.html#cfn-appstream-image-application-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}