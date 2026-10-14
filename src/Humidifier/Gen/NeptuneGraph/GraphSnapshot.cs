namespace Humidifier.NeptuneGraph
{
    using global::System.Collections.Generic;

    public class GraphSnapshot : Humidifier.Base.BaseResource, IHaveTags, IHaveSnapshotName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string SnapshotCreateTime =  "SnapshotCreateTime" ;
            public static string KmsKeyIdentifier =  "KmsKeyIdentifier" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.NeptuneGraph.GraphSnapshot; }

        /// <summary>
        /// GraphIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-graphsnapshot.html#cfn-neptunegraph-graphsnapshot-graphidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GraphIdentifier { get; set; }

        /// <summary>
        /// SnapshotName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-graphsnapshot.html#cfn-neptunegraph-graphsnapshot-snapshotname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SnapshotName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-graphsnapshot.html#cfn-neptunegraph-graphsnapshot-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}