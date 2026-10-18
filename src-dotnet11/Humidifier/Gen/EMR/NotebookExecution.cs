namespace Humidifier.EMR
{
    using global::System.Collections.Generic;
    using NotebookExecutionTypes;

    public class NotebookExecution : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveNotebookParams, IHaveEMRNotebookExecutionTypesExecutionEngineConfigExecutionEngine, IHaveEMRNotebookExecutionTypesNotebookS3LocationNotebookS3Location, IHaveStringDictionaryOfEnvironmentVariables, IHaveEMRNotebookExecutionTypesOutputNotebookS3LocationOutputNotebookS3Location, IHaveOutputNotebookFormat, IHaveNotebookExecutionName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string StartTime =  "StartTime" ;
            public static string Arn =  "Arn" ;
            public static string NotebookExecutionId =  "NotebookExecutionId" ;
        }

        public override string AWSTypeName { get => AWS.EMR.NotebookExecution; }
        /// <summary>
        /// NotebookParams
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-notebookexecution.html#cfn-emr-notebookexecution-notebookparams
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NotebookParams { get; set; }
        /// <summary>
        /// ExecutionEngine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-notebookexecution.html#cfn-emr-notebookexecution-executionengine
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ExecutionEngineConfig
        /// </summary>
        public Union<Humidifier.EMR.NotebookExecutionTypes.ExecutionEngineConfig, BaseFunction>? ExecutionEngine { get; set; }
        /// <summary>
        /// NotebookS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-notebookexecution.html#cfn-emr-notebookexecution-notebooks3location
        /// Required: False
        /// UpdateType: Immutable
        /// Type: NotebookS3Location
        /// </summary>
        public Union<Humidifier.EMR.NotebookExecutionTypes.NotebookS3Location, BaseFunction>? NotebookS3Location { get; set; }
        /// <summary>
        /// EnvironmentVariables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-notebookexecution.html#cfn-emr-notebookexecution-environmentvariables
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? EnvironmentVariables { get; set; }
        /// <summary>
        /// OutputNotebookS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-notebookexecution.html#cfn-emr-notebookexecution-outputnotebooks3location
        /// Required: False
        /// UpdateType: Immutable
        /// Type: OutputNotebookS3Location
        /// </summary>
        public Union<Humidifier.EMR.NotebookExecutionTypes.OutputNotebookS3Location, BaseFunction>? OutputNotebookS3Location { get; set; }
        /// <summary>
        /// OutputNotebookFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-notebookexecution.html#cfn-emr-notebookexecution-outputnotebookformat
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OutputNotebookFormat { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-notebookexecution.html#cfn-emr-notebookexecution-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? NotebookExecutionName { get => GivenName; set => GivenName = value; }
    }

    namespace NotebookExecutionTypes
    {
        public class ExecutionEngineConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-notebookexecution-executionengineconfig.html#cfn-emr-notebookexecution-executionengineconfig-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-notebookexecution-executionengineconfig.html#cfn-emr-notebookexecution-executionengineconfig-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class NotebookS3Location : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-notebookexecution-notebooks3location.html#cfn-emr-notebookexecution-notebooks3location-bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-notebookexecution-notebooks3location.html#cfn-emr-notebookexecution-notebooks3location-key
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class OutputNotebookS3Location : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-notebookexecution-outputnotebooks3location.html#cfn-emr-notebookexecution-outputnotebooks3location-bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-notebookexecution-outputnotebooks3location.html#cfn-emr-notebookexecution-outputnotebooks3location-key
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}