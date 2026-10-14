namespace Humidifier.IoTSiteWise
{
    using global::System.Collections.Generic;
    using PipelineTypes;

    public class Pipeline : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHavePipelineName
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
        public dynamic Description { get; set; }
        /// <summary>
        /// EnvironmentVariables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-pipeline.html#cfn-iotsitewise-pipeline-environmentvariables
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> EnvironmentVariables { get; set; }
        public dynamic PipelineName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Computations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-pipeline.html#cfn-iotsitewise-pipeline-computations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ComputeNode
        /// </summary>
        [Required]
        public List<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode> Computations { get; set; }

        /// <summary>
        /// WorkspaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-pipeline.html#cfn-iotsitewise-pipeline-workspacename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic WorkspaceName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-pipeline.html#cfn-iotsitewise-pipeline-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace PipelineTypes
    {
        public class ComputeNode : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DependsOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-pipeline-computenode.html#cfn-iotsitewise-pipeline-computenode-dependson
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DependsOn { get; set; }
            /// <summary>
            /// EnvironmentVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-pipeline-computenode.html#cfn-iotsitewise-pipeline-computenode-environmentvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> EnvironmentVariables { get; set; }
            /// <summary>
            /// TaskName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-pipeline-computenode.html#cfn-iotsitewise-pipeline-computenode-taskname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TaskName { get; set; }
            /// <summary>
            /// ComputeNodeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-pipeline-computenode.html#cfn-iotsitewise-pipeline-computenode-computenodename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputeNodeName { get; set; }
        }
    }
}