namespace Humidifier.QBusiness
{
    using global::System.Collections.Generic;
    using IndexTypes;

    public class Index : Humidifier.Base.BaseResource, IHaveTags, IHaveType, IHaveDescription, IHaveDisplayName, IHaveListOfQBusinessIndexTypesDocumentAttributeConfigurationDocumentAttributeConfigurations, IHaveApplicationId, IHaveQBusinessIndexTypesIndexCapacityConfigurationCapacityConfiguration
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string IndexStatistics =  "IndexStatistics" ;
            public static string IndexId =  "IndexId" ;
            public static string IndexArn =  "IndexArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.QBusiness.Index; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-index.html#cfn-qbusiness-index-type
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-index.html#cfn-qbusiness-index-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-index.html#cfn-qbusiness-index-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// DocumentAttributeConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-index.html#cfn-qbusiness-index-documentattributeconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DocumentAttributeConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration>, IReadOnlyList<Union<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration, BaseFunction>>, BaseFunction>? DocumentAttributeConfigurations { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-index.html#cfn-qbusiness-index-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-index.html#cfn-qbusiness-index-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// CapacityConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-index.html#cfn-qbusiness-index-capacityconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IndexCapacityConfiguration
        /// </summary>
        public Union<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration, BaseFunction>? CapacityConfiguration { get; set; }
    }

    namespace IndexTypes
    {
        public class DocumentAttributeConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveSearch, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-index-documentattributeconfiguration.html#cfn-qbusiness-index-documentattributeconfiguration-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Search
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-index-documentattributeconfiguration.html#cfn-qbusiness-index-documentattributeconfiguration-search
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Search { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-index-documentattributeconfiguration.html#cfn-qbusiness-index-documentattributeconfiguration-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class IndexCapacityConfiguration : Humidifier.Base.BaseSubResource, IHaveUnits_Double
        {
            /// <summary>
            /// Units
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-index-indexcapacityconfiguration.html#cfn-qbusiness-index-indexcapacityconfiguration-units
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Units { get; set; }
        }

        public class IndexStatistics : Humidifier.Base.BaseSubResource, IHaveQBusinessIndexTypesTextDocumentStatisticsTextDocumentStatistics
        {
            /// <summary>
            /// TextDocumentStatistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-index-indexstatistics.html#cfn-qbusiness-index-indexstatistics-textdocumentstatistics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextDocumentStatistics
            /// </summary>
            public Union<Humidifier.QBusiness.IndexTypes.TextDocumentStatistics, BaseFunction>? TextDocumentStatistics { get; set; }
        }

        public class TextDocumentStatistics : Humidifier.Base.BaseSubResource, IHaveIndexedTextBytes_Double, IHaveIndexedTextDocumentCount_Double
        {
            /// <summary>
            /// IndexedTextBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-index-textdocumentstatistics.html#cfn-qbusiness-index-textdocumentstatistics-indexedtextbytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? IndexedTextBytes { get; set; }
            /// <summary>
            /// IndexedTextDocumentCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-index-textdocumentstatistics.html#cfn-qbusiness-index-textdocumentstatistics-indexedtextdocumentcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? IndexedTextDocumentCount { get; set; }
        }
    }
}