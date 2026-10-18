namespace Humidifier.AppStream
{
    using global::System.Collections.Generic;
    using AppBlockTypes;

    public class AppBlock : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAppStreamAppBlockTypesScriptDetailsSetupScriptDetails, IHaveDescription, IHaveAppStreamAppBlockTypesScriptDetailsPostSetupScriptDetails, IHaveDisplayName, IHaveAppStreamAppBlockTypesS3LocationSourceS3Location, IHavePackagingType, IHaveName
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AppStream.AppBlock; }
        /// <summary>
        /// SetupScriptDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblock.html#cfn-appstream-appblock-setupscriptdetails
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ScriptDetails
        /// </summary>
        public Union<Humidifier.AppStream.AppBlockTypes.ScriptDetails, BaseFunction>? SetupScriptDetails { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblock.html#cfn-appstream-appblock-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// PostSetupScriptDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblock.html#cfn-appstream-appblock-postsetupscriptdetails
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ScriptDetails
        /// </summary>
        public Union<Humidifier.AppStream.AppBlockTypes.ScriptDetails, BaseFunction>? PostSetupScriptDetails { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblock.html#cfn-appstream-appblock-displayname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }

        /// <summary>
        /// SourceS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblock.html#cfn-appstream-appblock-sources3location
        /// Required: True
        /// UpdateType: Immutable
        /// Type: S3Location
        /// </summary>
        [Required]
        public Union<Humidifier.AppStream.AppBlockTypes.S3Location, BaseFunction>? SourceS3Location { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblock.html#cfn-appstream-appblock-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// PackagingType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblock.html#cfn-appstream-appblock-packagingtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PackagingType { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AppBlockTypes
    {
        public class S3Location : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveS3Key
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-appblock-s3location.html#cfn-appstream-appblock-s3location-s3bucket
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-appblock-s3location.html#cfn-appstream-appblock-s3location-s3key
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Key { get; set; }
        }

        public class ScriptDetails : Humidifier.Base.BaseSubResource, IHaveTimeoutInSeconds_Integer, IHaveAppStreamAppBlockTypesS3LocationScriptS3Location, IHaveExecutablePath, IHaveExecutableParameters
        {
            /// <summary>
            /// TimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-appblock-scriptdetails.html#cfn-appstream-appblock-scriptdetails-timeoutinseconds
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutInSeconds { get; set; }
            /// <summary>
            /// ScriptS3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-appblock-scriptdetails.html#cfn-appstream-appblock-scriptdetails-scripts3location
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.AppStream.AppBlockTypes.S3Location, BaseFunction>? ScriptS3Location { get; set; }
            /// <summary>
            /// ExecutablePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-appblock-scriptdetails.html#cfn-appstream-appblock-scriptdetails-executablepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutablePath { get; set; }
            /// <summary>
            /// ExecutableParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-appblock-scriptdetails.html#cfn-appstream-appblock-scriptdetails-executableparameters
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutableParameters { get; set; }
        }
    }
}