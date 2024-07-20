namespace Humidifier.DevOpsGuru
{
    using System.Collections.Generic;
    using ResourceCollectionTypes;

    public class ResourceCollection : Humidifier.Resource
    {
        public class Attributes
        {
            public static string ResourceCollectionType =  "ResourceCollectionType" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::DevOpsGuru::ResourceCollection";
            }
        }

        /// <summary>
        /// ResourceCollectionFilter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsguru-resourcecollection.html#cfn-devopsguru-resourcecollection-resourcecollectionfilter
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ResourceCollectionFilter
        /// </summary>
        public ResourceCollectionFilter ResourceCollectionFilter { get; set; }
    }

    namespace ResourceCollectionTypes
    {
        public class CloudFormationCollectionFilter
        {
            /// <summary>
            /// StackNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-resourcecollection-cloudformationcollectionfilter.html#cfn-devopsguru-resourcecollection-cloudformationcollectionfilter-stacknames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StackNames { get; set; }
        }

        public class ResourceCollectionFilter
        {
            /// <summary>
            /// CloudFormation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-resourcecollection-resourcecollectionfilter.html#cfn-devopsguru-resourcecollection-resourcecollectionfilter-cloudformation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudFormationCollectionFilter
            /// </summary>
            public CloudFormationCollectionFilter CloudFormation { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-resourcecollection-resourcecollectionfilter.html#cfn-devopsguru-resourcecollection-resourcecollectionfilter-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagCollection
            /// </summary>
            public List<TagCollection> Tags { get; set; }
        }

        public class TagCollection
        {
            /// <summary>
            /// AppBoundaryKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-resourcecollection-tagcollection.html#cfn-devopsguru-resourcecollection-tagcollection-appboundarykey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppBoundaryKey { get; set; }
            /// <summary>
            /// TagValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-resourcecollection-tagcollection.html#cfn-devopsguru-resourcecollection-tagcollection-tagvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TagValues { get; set; }
        }
    }
}