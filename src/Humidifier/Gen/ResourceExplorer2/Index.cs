namespace Humidifier.ResourceExplorer2
{
    using System.Collections.Generic;

    public class Index : Humidifier.Base.BaseResource, IHaveType
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string IndexState =  "IndexState" ;
        }

        public override string AWSTypeName { get => AWS.ResourceExplorer2.Index; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourceexplorer2-index.html#cfn-resourceexplorer2-index-type
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourceexplorer2-index.html#cfn-resourceexplorer2-index-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }
}