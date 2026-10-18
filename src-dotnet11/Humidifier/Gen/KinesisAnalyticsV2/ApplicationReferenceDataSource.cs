namespace Humidifier.KinesisAnalyticsV2
{
    using global::System.Collections.Generic;
    using ApplicationReferenceDataSourceTypes;

    public class ApplicationReferenceDataSource : Humidifier.Base.BaseResource, IHaveApplicationName, IHaveKinesisAnalyticsV2ApplicationReferenceDataSourceTypesReferenceDataSourceReferenceDataSource
    {
        public override string AWSTypeName { get => AWS.KinesisAnalyticsV2.ApplicationReferenceDataSource; }

        /// <summary>
        /// ApplicationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-applicationreferencedatasource.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-applicationname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationName { get; set; }

        /// <summary>
        /// ReferenceDataSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-applicationreferencedatasource.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-referencedatasource
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ReferenceDataSource
        /// </summary>
        [Required]
        public Union<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.ReferenceDataSource, BaseFunction>? ReferenceDataSource { get; set; }
    }

    namespace ApplicationReferenceDataSourceTypes
    {
        public class CSVMappingParameters : Humidifier.Base.BaseSubResource, IHaveRecordRowDelimiter, IHaveRecordColumnDelimiter
        {
            /// <summary>
            /// RecordRowDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-csvmappingparameters.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-csvmappingparameters-recordrowdelimiter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordRowDelimiter { get; set; }
            /// <summary>
            /// RecordColumnDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-csvmappingparameters.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-csvmappingparameters-recordcolumndelimiter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordColumnDelimiter { get; set; }
        }

        public class JSONMappingParameters : Humidifier.Base.BaseSubResource, IHaveRecordRowPath
        {
            /// <summary>
            /// RecordRowPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-jsonmappingparameters.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-jsonmappingparameters-recordrowpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordRowPath { get; set; }
        }

        public class MappingParameters : Humidifier.Base.BaseSubResource, IHaveKinesisAnalyticsV2ApplicationReferenceDataSourceTypesJSONMappingParametersJSONMappingParameters, IHaveKinesisAnalyticsV2ApplicationReferenceDataSourceTypesCSVMappingParametersCSVMappingParameters
        {
            /// <summary>
            /// JSONMappingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-mappingparameters.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-mappingparameters-jsonmappingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JSONMappingParameters
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.JSONMappingParameters, BaseFunction>? JSONMappingParameters { get; set; }
            /// <summary>
            /// CSVMappingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-mappingparameters.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-mappingparameters-csvmappingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CSVMappingParameters
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.CSVMappingParameters, BaseFunction>? CSVMappingParameters { get; set; }
        }

        public class RecordColumn : Humidifier.Base.BaseSubResource, IHaveMapping, IHaveSqlType, IHaveName
        {
            /// <summary>
            /// Mapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-recordcolumn.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-recordcolumn-mapping
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mapping { get; set; }
            /// <summary>
            /// SqlType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-recordcolumn.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-recordcolumn-sqltype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SqlType { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-recordcolumn.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-recordcolumn-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RecordFormat : Humidifier.Base.BaseSubResource, IHaveKinesisAnalyticsV2ApplicationReferenceDataSourceTypesMappingParametersMappingParameters, IHaveRecordFormatType
        {
            /// <summary>
            /// MappingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-recordformat.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-recordformat-mappingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MappingParameters
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.MappingParameters, BaseFunction>? MappingParameters { get; set; }
            /// <summary>
            /// RecordFormatType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-recordformat.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-recordformat-recordformattype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordFormatType { get; set; }
        }

        public class ReferenceDataSource : Humidifier.Base.BaseSubResource, IHaveKinesisAnalyticsV2ApplicationReferenceDataSourceTypesReferenceSchemaReferenceSchema, IHaveTableName, IHaveKinesisAnalyticsV2ApplicationReferenceDataSourceTypesS3ReferenceDataSourceS3ReferenceDataSource
        {
            /// <summary>
            /// ReferenceSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-referencedatasource.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-referencedatasource-referenceschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ReferenceSchema
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.ReferenceSchema, BaseFunction>? ReferenceSchema { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-referencedatasource.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-referencedatasource-tablename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// S3ReferenceDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-referencedatasource.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-referencedatasource-s3referencedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3ReferenceDataSource
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.S3ReferenceDataSource, BaseFunction>? S3ReferenceDataSource { get; set; }
        }

        public class ReferenceSchema : Humidifier.Base.BaseSubResource, IHaveRecordEncoding, IHaveListOfKinesisAnalyticsV2ApplicationReferenceDataSourceTypesRecordColumnRecordColumns, IHaveKinesisAnalyticsV2ApplicationReferenceDataSourceTypesRecordFormatRecordFormat
        {
            /// <summary>
            /// RecordEncoding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-referenceschema.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-referenceschema-recordencoding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordEncoding { get; set; }
            /// <summary>
            /// RecordColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-referenceschema.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-referenceschema-recordcolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RecordColumn
            /// </summary>
            public Union<IReadOnlyList<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.RecordColumn>, IReadOnlyList<Union<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.RecordColumn, BaseFunction>>, BaseFunction>? RecordColumns { get; set; }
            /// <summary>
            /// RecordFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-referenceschema.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-referenceschema-recordformat
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RecordFormat
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.RecordFormat, BaseFunction>? RecordFormat { get; set; }
        }

        public class S3ReferenceDataSource : Humidifier.Base.BaseSubResource, IHaveBucketARN, IHaveFileKey
        {
            /// <summary>
            /// BucketARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-s3referencedatasource.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-s3referencedatasource-bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketARN { get; set; }
            /// <summary>
            /// FileKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-s3referencedatasource.html#cfn-kinesisanalyticsv2-applicationreferencedatasource-s3referencedatasource-filekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileKey { get; set; }
        }
    }
}