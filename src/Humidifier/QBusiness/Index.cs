namespace Humidifier.QBusiness
{
    using System.Collections.Generic;
    using IndexTypes;

    public class Index : Humidifier.Resource, IHaveTags, IHaveDescription
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

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::QBusiness::Index";
            }
        }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-index.html#cfn-qbusiness-index-type
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-index.html#cfn-qbusiness-index-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-index.html#cfn-qbusiness-index-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// DocumentAttributeConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-index.html#cfn-qbusiness-index-documentattributeconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DocumentAttributeConfiguration
        /// </summary>
        public List<DocumentAttributeConfiguration> DocumentAttributeConfigurations { get; set; }
        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-index.html#cfn-qbusiness-index-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-index.html#cfn-qbusiness-index-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// CapacityConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-index.html#cfn-qbusiness-index-capacityconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IndexCapacityConfiguration
        /// </summary>
        public IndexCapacityConfiguration CapacityConfiguration { get; set; }
    }

    namespace IndexTypes
    {
        public class DocumentAttributeConfiguration
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-index-documentattributeconfiguration.html#cfn-qbusiness-index-documentattributeconfiguration-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Search
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-index-documentattributeconfiguration.html#cfn-qbusiness-index-documentattributeconfiguration-search
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Search { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-index-documentattributeconfiguration.html#cfn-qbusiness-index-documentattributeconfiguration-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class IndexCapacityConfiguration
        {
            /// <summary>
            /// Units
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-index-indexcapacityconfiguration.html#cfn-qbusiness-index-indexcapacityconfiguration-units
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Units { get; set; }
        }

        public class IndexStatistics
        {
            /// <summary>
            /// TextDocumentStatistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-index-indexstatistics.html#cfn-qbusiness-index-indexstatistics-textdocumentstatistics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextDocumentStatistics
            /// </summary>
            public TextDocumentStatistics TextDocumentStatistics { get; set; }
        }

        public class TextDocumentStatistics
        {
            /// <summary>
            /// IndexedTextBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-index-textdocumentstatistics.html#cfn-qbusiness-index-textdocumentstatistics-indexedtextbytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic IndexedTextBytes { get; set; }
            /// <summary>
            /// IndexedTextDocumentCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-index-textdocumentstatistics.html#cfn-qbusiness-index-textdocumentstatistics-indexedtextdocumentcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic IndexedTextDocumentCount { get; set; }
        }
    }
}