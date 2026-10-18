namespace Humidifier.RoboMaker
{
    using global::System.Collections.Generic;
    using SimulationApplicationTypes;

    public class SimulationApplication : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveRoboMakerSimulationApplicationTypesRenderingEngineRenderingEngine, IHaveRoboMakerSimulationApplicationTypesSimulationSoftwareSuiteSimulationSoftwareSuite, IHaveCurrentRevisionId, IHaveEnvironment, IHaveRoboMakerSimulationApplicationTypesRobotSoftwareSuiteRobotSoftwareSuite, IHaveListOfRoboMakerSimulationApplicationTypesSourceConfigSources, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string CurrentRevisionId =  "CurrentRevisionId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.RoboMaker.SimulationApplication; }
        /// <summary>
        /// RenderingEngine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-simulationapplication.html#cfn-robomaker-simulationapplication-renderingengine
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RenderingEngine
        /// </summary>
        public Union<Humidifier.RoboMaker.SimulationApplicationTypes.RenderingEngine, BaseFunction>? RenderingEngine { get; set; }

        /// <summary>
        /// SimulationSoftwareSuite
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-simulationapplication.html#cfn-robomaker-simulationapplication-simulationsoftwaresuite
        /// Required: True
        /// UpdateType: Mutable
        /// Type: SimulationSoftwareSuite
        /// </summary>
        [Required]
        public Union<Humidifier.RoboMaker.SimulationApplicationTypes.SimulationSoftwareSuite, BaseFunction>? SimulationSoftwareSuite { get; set; }
        /// <summary>
        /// CurrentRevisionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-simulationapplication.html#cfn-robomaker-simulationapplication-currentrevisionid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CurrentRevisionId { get; set; }
        /// <summary>
        /// Environment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-simulationapplication.html#cfn-robomaker-simulationapplication-environment
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Environment { get; set; }

        /// <summary>
        /// RobotSoftwareSuite
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-simulationapplication.html#cfn-robomaker-simulationapplication-robotsoftwaresuite
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RobotSoftwareSuite
        /// </summary>
        [Required]
        public Union<Humidifier.RoboMaker.SimulationApplicationTypes.RobotSoftwareSuite, BaseFunction>? RobotSoftwareSuite { get; set; }
        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-simulationapplication.html#cfn-robomaker-simulationapplication-sources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SourceConfig
        /// </summary>
        public Union<IReadOnlyList<Humidifier.RoboMaker.SimulationApplicationTypes.SourceConfig>, IReadOnlyList<Union<Humidifier.RoboMaker.SimulationApplicationTypes.SourceConfig, BaseFunction>>, BaseFunction>? Sources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-simulationapplication.html#cfn-robomaker-simulationapplication-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SimulationApplicationTypes
    {
        public class RenderingEngine : Humidifier.Base.BaseSubResource, IHaveVersion, IHaveName
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-simulationapplication-renderingengine.html#cfn-robomaker-simulationapplication-renderingengine-version
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-simulationapplication-renderingengine.html#cfn-robomaker-simulationapplication-renderingengine-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RobotSoftwareSuite : Humidifier.Base.BaseSubResource, IHaveVersion, IHaveName
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-simulationapplication-robotsoftwaresuite.html#cfn-robomaker-simulationapplication-robotsoftwaresuite-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-simulationapplication-robotsoftwaresuite.html#cfn-robomaker-simulationapplication-robotsoftwaresuite-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SimulationSoftwareSuite : Humidifier.Base.BaseSubResource, IHaveVersion, IHaveName
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-simulationapplication-simulationsoftwaresuite.html#cfn-robomaker-simulationapplication-simulationsoftwaresuite-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-simulationapplication-simulationsoftwaresuite.html#cfn-robomaker-simulationapplication-simulationsoftwaresuite-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-simulationapplication-sourceconfig.html#cfn-robomaker-simulationapplication-sourceconfig-s3bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// Architecture
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-simulationapplication-sourceconfig.html#cfn-robomaker-simulationapplication-sourceconfig-architecture
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Architecture { get; set; }
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-simulationapplication-sourceconfig.html#cfn-robomaker-simulationapplication-sourceconfig-s3key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Key { get; set; }
        }
    }
}