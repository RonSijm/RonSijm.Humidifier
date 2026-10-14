namespace Humidifier.OpenSearchServerless
{
    using global::System.Collections.Generic;
    using IndexTypes;

    public class Index : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveIndexName
    {
        public class Attributes
        {
            public static string Uuid =  "Uuid" ;
        }

        public override string AWSTypeName { get => AWS.OpenSearchServerless.Index; }
        public dynamic IndexName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Mappings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-index.html#cfn-opensearchserverless-index-mappings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Mappings
        /// </summary>
        public Humidifier.OpenSearchServerless.IndexTypes.Mappings Mappings { get; set; }

        /// <summary>
        /// CollectionEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-index.html#cfn-opensearchserverless-index-collectionendpoint
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CollectionEndpoint { get; set; }
        /// <summary>
        /// Settings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-index.html#cfn-opensearchserverless-index-settings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IndexSettings
        /// </summary>
        public Humidifier.OpenSearchServerless.IndexTypes.IndexSettings Settings { get; set; }
    }

    namespace IndexTypes
    {
        public class Analysis : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Analyzer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-analysis.html#cfn-opensearchserverless-index-analysis-analyzer
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// ItemType: AnalyzerItems
            /// </summary>
            public Dictionary<string, Humidifier.OpenSearchServerless.IndexTypes.AnalyzerItems> Analyzer { get; set; }
        }

        public class AnalyzerItems : Humidifier.Base.BaseSubResource, IHaveType, IHaveFilter
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-analyzeritems.html#cfn-opensearchserverless-index-analyzeritems-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-analyzeritems.html#cfn-opensearchserverless-index-analyzeritems-filter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Filter { get; set; }
            /// <summary>
            /// CharFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-analyzeritems.html#cfn-opensearchserverless-index-analyzeritems-charfilter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CharFilter { get; set; }
            /// <summary>
            /// Tokenizer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-analyzeritems.html#cfn-opensearchserverless-index-analyzeritems-tokenizer
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Tokenizer { get; set; }
        }

        public class Index : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KnnAlgoParamEfSearch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-index.html#cfn-opensearchserverless-index-index-knnalgoparamefsearch
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic KnnAlgoParamEfSearch { get; set; }
            /// <summary>
            /// RefreshInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-index.html#cfn-opensearchserverless-index-index-refreshinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RefreshInterval { get; set; }
            /// <summary>
            /// Knn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-index.html#cfn-opensearchserverless-index-index-knn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Knn { get; set; }
        }

        public class IndexSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Analysis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-indexsettings.html#cfn-opensearchserverless-index-indexsettings-analysis
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Analysis
            /// </summary>
            public Humidifier.OpenSearchServerless.IndexTypes.Analysis Analysis { get; set; }
            /// <summary>
            /// Index
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-indexsettings.html#cfn-opensearchserverless-index-indexsettings-index
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Index
            /// </summary>
            public Humidifier.OpenSearchServerless.IndexTypes.Index Index { get; set; }
        }

        public class Mappings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-mappings.html#cfn-opensearchserverless-index-mappings-properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: PropertyMapping
            /// </summary>
            public Dictionary<string, Humidifier.OpenSearchServerless.IndexTypes.PropertyMapping> Properties { get; set; }
        }

        public class Method : Humidifier.Base.BaseSubResource, IHaveName, IHaveEngine
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-method.html#cfn-opensearchserverless-index-method-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Parameters
            /// </summary>
            public Humidifier.OpenSearchServerless.IndexTypes.Parameters Parameters { get; set; }
            /// <summary>
            /// SpaceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-method.html#cfn-opensearchserverless-index-method-spacetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SpaceType { get; set; }
            /// <summary>
            /// Engine
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-method.html#cfn-opensearchserverless-index-method-engine
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Engine { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-method.html#cfn-opensearchserverless-index-method-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class Parameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EfConstruction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-parameters.html#cfn-opensearchserverless-index-parameters-efconstruction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EfConstruction { get; set; }
            /// <summary>
            /// M
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-parameters.html#cfn-opensearchserverless-index-parameters-m
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic M { get; set; }
        }

        public class PropertyMapping : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue, IHaveDataType, IHaveIndex, IHaveAnalyzer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// SpaceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-spacetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SpaceType { get; set; }
            /// <summary>
            /// CompressionLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-compressionlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CompressionLevel { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-datatype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataType { get; set; }
            /// <summary>
            /// Index
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-index
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Index { get; set; }
            /// <summary>
            /// Dimension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-dimension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Dimension { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-method
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Method
            /// </summary>
            public Humidifier.OpenSearchServerless.IndexTypes.Method Method { get; set; }
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: PropertyMapping
            /// </summary>
            public Dictionary<string, Humidifier.OpenSearchServerless.IndexTypes.PropertyMapping> Properties { get; set; }
            /// <summary>
            /// Analyzer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-analyzer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Analyzer { get; set; }
        }
    }
}