namespace Humidifier.OpenSearchServerless
{
    using global::System.Collections.Generic;
    using IndexTypes;

    public class Index : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveIndexName, IHaveOpenSearchServerlessIndexTypesMappingsMappings, IHaveCollectionEndpoint, IHaveOpenSearchServerlessIndexTypesIndexSettingsSettings
    {
        public class Attributes
        {
            public static string Uuid =  "Uuid" ;
        }

        public override string AWSTypeName { get => AWS.OpenSearchServerless.Index; }
        public Union<string, BaseFunction>? IndexName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Mappings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-index.html#cfn-opensearchserverless-index-mappings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Mappings
        /// </summary>
        public Union<Humidifier.OpenSearchServerless.IndexTypes.Mappings, BaseFunction>? Mappings { get; set; }

        /// <summary>
        /// CollectionEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-index.html#cfn-opensearchserverless-index-collectionendpoint
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CollectionEndpoint { get; set; }
        /// <summary>
        /// Settings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-index.html#cfn-opensearchserverless-index-settings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IndexSettings
        /// </summary>
        public Union<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings, BaseFunction>? Settings { get; set; }
    }

    namespace IndexTypes
    {
        public class Analysis : Humidifier.Base.BaseSubResource, IHaveMapOfOpenSearchServerlessIndexTypesAnalyzerItemsAnalyzer
        {
            /// <summary>
            /// Analyzer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-analysis.html#cfn-opensearchserverless-index-analysis-analyzer
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// ItemType: AnalyzerItems
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.OpenSearchServerless.IndexTypes.AnalyzerItems>, IReadOnlyDictionary<string, Union<Humidifier.OpenSearchServerless.IndexTypes.AnalyzerItems, BaseFunction>>, BaseFunction>? Analyzer { get; set; }
        }

        public class AnalyzerItems : Humidifier.Base.BaseSubResource, IHaveType, IHaveStringListOfFilter, IHaveStringListOfCharFilter, IHaveTokenizer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-analyzeritems.html#cfn-opensearchserverless-index-analyzeritems-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-analyzeritems.html#cfn-opensearchserverless-index-analyzeritems-filter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Filter { get; set; }
            /// <summary>
            /// CharFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-analyzeritems.html#cfn-opensearchserverless-index-analyzeritems-charfilter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CharFilter { get; set; }
            /// <summary>
            /// Tokenizer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-analyzeritems.html#cfn-opensearchserverless-index-analyzeritems-tokenizer
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Tokenizer { get; set; }
        }

        public class Index : Humidifier.Base.BaseSubResource, IHaveKnnAlgoParamEfSearch_Integer, IHaveRefreshInterval, IHaveKnn_Boolean
        {
            /// <summary>
            /// KnnAlgoParamEfSearch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-index.html#cfn-opensearchserverless-index-index-knnalgoparamefsearch
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? KnnAlgoParamEfSearch { get; set; }
            /// <summary>
            /// RefreshInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-index.html#cfn-opensearchserverless-index-index-refreshinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefreshInterval { get; set; }
            /// <summary>
            /// Knn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-index.html#cfn-opensearchserverless-index-index-knn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Knn { get; set; }
        }

        public class IndexSettings : Humidifier.Base.BaseSubResource, IHaveOpenSearchServerlessIndexTypesAnalysisAnalysis, IHaveOpenSearchServerlessIndexTypesIndexIndex
        {
            /// <summary>
            /// Analysis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-indexsettings.html#cfn-opensearchserverless-index-indexsettings-analysis
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Analysis
            /// </summary>
            public Union<Humidifier.OpenSearchServerless.IndexTypes.Analysis, BaseFunction>? Analysis { get; set; }
            /// <summary>
            /// Index
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-indexsettings.html#cfn-opensearchserverless-index-indexsettings-index
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Index
            /// </summary>
            public Union<Humidifier.OpenSearchServerless.IndexTypes.Index, BaseFunction>? Index { get; set; }
        }

        public class Mappings : Humidifier.Base.BaseSubResource, IHaveMapOfOpenSearchServerlessIndexTypesPropertyMappingProperties
        {
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-mappings.html#cfn-opensearchserverless-index-mappings-properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: PropertyMapping
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.OpenSearchServerless.IndexTypes.PropertyMapping>, IReadOnlyDictionary<string, Union<Humidifier.OpenSearchServerless.IndexTypes.PropertyMapping, BaseFunction>>, BaseFunction>? Properties { get; set; }
        }

        public class Method : Humidifier.Base.BaseSubResource, IHaveOpenSearchServerlessIndexTypesParametersParameters, IHaveSpaceType, IHaveEngine, IHaveName
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-method.html#cfn-opensearchserverless-index-method-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Parameters
            /// </summary>
            public Union<Humidifier.OpenSearchServerless.IndexTypes.Parameters, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// SpaceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-method.html#cfn-opensearchserverless-index-method-spacetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpaceType { get; set; }
            /// <summary>
            /// Engine
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-method.html#cfn-opensearchserverless-index-method-engine
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Engine { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-method.html#cfn-opensearchserverless-index-method-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Parameters : Humidifier.Base.BaseSubResource, IHaveEfConstruction_Integer, IHaveM_Integer
        {
            /// <summary>
            /// EfConstruction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-parameters.html#cfn-opensearchserverless-index-parameters-efconstruction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EfConstruction { get; set; }
            /// <summary>
            /// M
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-parameters.html#cfn-opensearchserverless-index-parameters-m
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? M { get; set; }
        }

        public class PropertyMapping : Humidifier.Base.BaseSubResource, IHaveType, IHaveSpaceType, IHaveCompressionLevel, IHaveValue, IHaveDataType, IHaveIndex_Boolean, IHaveDimension_Integer, IHaveOpenSearchServerlessIndexTypesMethodMethod, IHaveMapOfOpenSearchServerlessIndexTypesPropertyMappingProperties, IHaveAnalyzer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// SpaceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-spacetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpaceType { get; set; }
            /// <summary>
            /// CompressionLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-compressionlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CompressionLevel { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-datatype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataType { get; set; }
            /// <summary>
            /// Index
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-index
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Index { get; set; }
            /// <summary>
            /// Dimension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-dimension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Dimension { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-method
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Method
            /// </summary>
            public Union<Humidifier.OpenSearchServerless.IndexTypes.Method, BaseFunction>? Method { get; set; }
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: PropertyMapping
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.OpenSearchServerless.IndexTypes.PropertyMapping>, IReadOnlyDictionary<string, Union<Humidifier.OpenSearchServerless.IndexTypes.PropertyMapping, BaseFunction>>, BaseFunction>? Properties { get; set; }
            /// <summary>
            /// Analyzer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-index-propertymapping.html#cfn-opensearchserverless-index-propertymapping-analyzer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Analyzer { get; set; }
        }
    }
}