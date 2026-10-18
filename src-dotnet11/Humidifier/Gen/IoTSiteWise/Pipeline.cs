namespace Humidifier.IoTSiteWise
{
    using global::System.Collections.Generic;
    using PipelineTypes;

    public class Pipeline : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveStringDictionaryOfEnvironmentVariables, IHavePipelineName, IHaveListOfIoTSiteWisePipelineTypesComputeNodeComputations, IHaveWorkspaceName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string PipelineArn =  "PipelineArn" ;
        }

        public override string AWSTypeName { get => AWS.IoTSiteWise.Pipeline; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-pipeline.html#cfn-iotsitewise-pipeline-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// EnvironmentVariables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-pipeline.html#cfn-iotsitewise-pipeline-environmentvariables
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? EnvironmentVariables { get; set; }
        public Union<string, BaseFunction>? PipelineName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Computations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-pipeline.html#cfn-iotsitewise-pipeline-computations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ComputeNode
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode>, IReadOnlyList<Union<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode, BaseFunction>>, BaseFunction>? Computations { get; set; }

        /// <summary>
        /// WorkspaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-pipeline.html#cfn-iotsitewise-pipeline-workspacename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? WorkspaceName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-pipeline.html#cfn-iotsitewise-pipeline-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PipelineTypes
    {
        public class ComputeNode : Humidifier.Base.BaseSubResource, IHaveStringListOfDependsOn, IHaveStringDictionaryOfEnvironmentVariables, IHaveTaskName, IHaveComputeNodeName
        {
            /// <summary>
            /// DependsOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-pipeline-computenode.html#cfn-iotsitewise-pipeline-computenode-dependson
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DependsOn { get; set; }
            /// <summary>
            /// EnvironmentVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-pipeline-computenode.html#cfn-iotsitewise-pipeline-computenode-environmentvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? EnvironmentVariables { get; set; }
            /// <summary>
            /// TaskName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-pipeline-computenode.html#cfn-iotsitewise-pipeline-computenode-taskname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TaskName { get; set; }
            /// <summary>
            /// ComputeNodeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-pipeline-computenode.html#cfn-iotsitewise-pipeline-computenode-computenodename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComputeNodeName { get; set; }
        }
    }
}