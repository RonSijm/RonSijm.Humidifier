namespace Humidifier.NeptuneGraph
{
    using global::System.Collections.Generic;

    public class ImportTask : Humidifier.Base.BaseResource, IHaveRoleArn, IHaveSource, IHaveFormat
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string TaskId =  "TaskId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.NeptuneGraph.ImportTask; }
        /// <summary>
        /// Format
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-importtask.html#cfn-neptunegraph-importtask-format
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Format { get; set; }

        /// <summary>
        /// GraphIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-importtask.html#cfn-neptunegraph-importtask-graphidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GraphIdentifier { get; set; }
        /// <summary>
        /// ParquetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-importtask.html#cfn-neptunegraph-importtask-parquettype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ParquetType { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-importtask.html#cfn-neptunegraph-importtask-source
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Source { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-importtask.html#cfn-neptunegraph-importtask-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
    }
}