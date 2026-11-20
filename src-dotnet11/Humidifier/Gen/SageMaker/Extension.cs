namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using ExtensionTypes;

    public class Extension : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveClusterArn, IHaveExtensionName, IHaveExtensionVersion, IHaveConfigurationValues
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string NodeSummary =  "NodeSummary" ;
            public static string ExtensionArn =  "ExtensionArn" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Extension; }

        /// <summary>
        /// ClusterArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-extension.html#cfn-sagemaker-extension-clusterarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterArn { get; set; }
        public Union<string, BaseFunction>? ExtensionName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ExtensionVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-extension.html#cfn-sagemaker-extension-extensionversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExtensionVersion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-extension.html#cfn-sagemaker-extension-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// ConfigurationValues
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-extension.html#cfn-sagemaker-extension-configurationvalues
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConfigurationValues { get; set; }
    }

    namespace ExtensionTypes
    {
        public class ExtensionNodeSummary : Humidifier.Base.BaseSubResource, IHaveTotalCount_Integer, IHaveActiveCount_Integer
        {
            /// <summary>
            /// TotalCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-extension-extensionnodesummary.html#cfn-sagemaker-extension-extensionnodesummary-totalcount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TotalCount { get; set; }
            /// <summary>
            /// ActiveCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-extension-extensionnodesummary.html#cfn-sagemaker-extension-extensionnodesummary-activecount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ActiveCount { get; set; }
        }
    }
}