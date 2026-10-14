namespace Humidifier.ImageBuilder
{
    using global::System.Collections.Generic;
    using AllImageBuildVersionsTypes;

    public class AllImageBuildVersions : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Platform =  "Platform" ;
            public static string OsVersion =  "OsVersion" ;
            public static string DateCreated =  "DateCreated" ;
            public static string Name =  "Name" ;
            public static string Type =  "Type" ;
            public static string BuildNumber =  "BuildNumber" ;
            public static string ImageVersionArn =  "ImageVersionArn" ;
            public static string Version =  "Version" ;
            public static string State =  "State" ;
            public static string BuildType =  "BuildType" ;
            public static string ImageTestsConfiguration =  "ImageTestsConfiguration" ;
            public static string Arn =  "Arn" ;
            public static string EnhancedImageMetadataEnabled =  "EnhancedImageMetadataEnabled" ;
            public static string ExecutionRole =  "ExecutionRole" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.ImageBuilder.AllImageBuildVersions; }
    }

    namespace AllImageBuildVersionsTypes
    {
        public class ImageTestsConfiguration : Humidifier.Base.BaseSubResource, IHaveTimeoutMinutes, IHaveImageTestsEnabled
        {
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-allimagebuildversions-imagetestsconfiguration.html#cfn-imagebuilder-allimagebuildversions-imagetestsconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// ImageTestsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-allimagebuildversions-imagetestsconfiguration.html#cfn-imagebuilder-allimagebuildversions-imagetestsconfiguration-imagetestsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ImageTestsEnabled { get; set; }
        }

        public class State : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-allimagebuildversions-state.html#cfn-imagebuilder-allimagebuildversions-state-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-allimagebuildversions-tagsitems.html#cfn-imagebuilder-allimagebuildversions-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-allimagebuildversions-tagsitems.html#cfn-imagebuilder-allimagebuildversions-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}