namespace Humidifier.GameLift
{
    using global::System.Collections.Generic;
    using ScriptTypes;

    public class Script : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveNodeJsVersion, IHaveVersion, IHaveGameLiftScriptTypesS3LocationStorageLocation, IHaveName
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string SizeOnDisk =  "SizeOnDisk" ;
        }

        public override string AWSTypeName { get => AWS.GameLift.Script; }
        /// <summary>
        /// NodeJsVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-script.html#cfn-gamelift-script-nodejsversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NodeJsVersion { get; set; }
        /// <summary>
        /// Version
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-script.html#cfn-gamelift-script-version
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Version { get; set; }

        /// <summary>
        /// StorageLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-script.html#cfn-gamelift-script-storagelocation
        /// Required: True
        /// UpdateType: Mutable
        /// Type: S3Location
        /// </summary>
        [Required]
        public Union<Humidifier.GameLift.ScriptTypes.S3Location, BaseFunction>? StorageLocation { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-script.html#cfn-gamelift-script-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ScriptTypes
    {
        public class S3Location : Humidifier.Base.BaseSubResource, IHaveObjectVersion, IHaveBucket, IHaveKey, IHaveRoleArn
        {
            /// <summary>
            /// ObjectVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-script-s3location.html#cfn-gamelift-script-s3location-objectversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectVersion { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-script-s3location.html#cfn-gamelift-script-s3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-script-s3location.html#cfn-gamelift-script-s3location-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-script-s3location.html#cfn-gamelift-script-s3location-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }
    }
}