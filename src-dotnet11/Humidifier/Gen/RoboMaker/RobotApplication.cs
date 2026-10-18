namespace Humidifier.RoboMaker
{
    using global::System.Collections.Generic;
    using RobotApplicationTypes;

    public class RobotApplication : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveCurrentRevisionId, IHaveEnvironment, IHaveRoboMakerRobotApplicationTypesRobotSoftwareSuiteRobotSoftwareSuite, IHaveListOfRoboMakerRobotApplicationTypesSourceConfigSources, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string CurrentRevisionId =  "CurrentRevisionId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.RoboMaker.RobotApplication; }
        /// <summary>
        /// CurrentRevisionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplication.html#cfn-robomaker-robotapplication-currentrevisionid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CurrentRevisionId { get; set; }
        /// <summary>
        /// Environment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplication.html#cfn-robomaker-robotapplication-environment
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Environment { get; set; }

        /// <summary>
        /// RobotSoftwareSuite
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplication.html#cfn-robomaker-robotapplication-robotsoftwaresuite
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RobotSoftwareSuite
        /// </summary>
        [Required]
        public Union<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite, BaseFunction>? RobotSoftwareSuite { get; set; }
        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplication.html#cfn-robomaker-robotapplication-sources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SourceConfig
        /// </summary>
        public Union<IReadOnlyList<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig>, IReadOnlyList<Union<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig, BaseFunction>>, BaseFunction>? Sources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplication.html#cfn-robomaker-robotapplication-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RobotApplicationTypes
    {
        public class RobotSoftwareSuite : Humidifier.Base.BaseSubResource, IHaveVersion, IHaveName
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-robotapplication-robotsoftwaresuite.html#cfn-robomaker-robotapplication-robotsoftwaresuite-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-robotapplication-robotsoftwaresuite.html#cfn-robomaker-robotapplication-robotsoftwaresuite-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SourceConfig : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveArchitecture, IHaveS3Key
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-robotapplication-sourceconfig.html#cfn-robomaker-robotapplication-sourceconfig-s3bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// Architecture
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-robotapplication-sourceconfig.html#cfn-robomaker-robotapplication-sourceconfig-architecture
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Architecture { get; set; }
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-robotapplication-sourceconfig.html#cfn-robomaker-robotapplication-sourceconfig-s3key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Key { get; set; }
        }
    }
}