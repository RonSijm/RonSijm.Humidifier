namespace Humidifier.KinesisAnalytics
{
    using global::System.Collections.Generic;
    using ApplicationReferenceDataSourceTypes;

    public class ApplicationReferenceDataSource : Humidifier.Base.BaseResource, IHaveApplicationName, IHaveKinesisAnalyticsApplicationReferenceDataSourceTypesReferenceDataSourceReferenceDataSource
    {
        public override string AWSTypeName { get => AWS.KinesisAnalytics.ApplicationReferenceDataSource; }

        /// <summary>
        /// ApplicationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-applicationreferencedatasource.html#cfn-kinesisanalytics-applicationreferencedatasource-applicationname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationName { get; set; }

        /// <summary>
        /// ReferenceDataSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-applicationreferencedatasource.html#cfn-kinesisanalytics-applicationreferencedatasource-referencedatasource
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ReferenceDataSource
        /// </summary>
        [Required]
        public Union<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceDataSource, BaseFunction>? ReferenceDataSource { get; set; }
    }

    namespace ApplicationReferenceDataSourceTypes
    {
        public class CSVMappingParameters : Humidifier.Base.BaseSubResource, IHaveRecordRowDelimiter, IHaveRecordColumnDelimiter
        {
            /// <summary>
            /// RecordRowDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-csvmappingparameters.html#cfn-kinesisanalytics-applicationreferencedatasource-csvmappingparameters-recordrowdelimiter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordRowDelimiter { get; set; }
            /// <summary>
            /// RecordColumnDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-csvmappingparameters.html#cfn-kinesisanalytics-applicationreferencedatasource-csvmappingparameters-recordcolumndelimiter
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-jsonmappingparameters.html#cfn-kinesisanalytics-applicationreferencedatasource-jsonmappingparameters-recordrowpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordRowPath { get; set; }
        }

        public class MappingParameters : Humidifier.Base.BaseSubResource, IHaveKinesisAnalyticsApplicationReferenceDataSourceTypesJSONMappingParametersJSONMappingParameters, IHaveKinesisAnalyticsApplicationReferenceDataSourceTypesCSVMappingParametersCSVMappingParameters
        {
            /// <summary>
            /// JSONMappingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-mappingparameters.html#cfn-kinesisanalytics-applicationreferencedatasource-mappingparameters-jsonmappingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JSONMappingParameters
            /// </summary>
            public Union<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.JSONMappingParameters, BaseFunction>? JSONMappingParameters { get; set; }
            /// <summary>
            /// CSVMappingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-mappingparameters.html#cfn-kinesisanalytics-applicationreferencedatasource-mappingparameters-csvmappingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CSVMappingParameters
            /// </summary>
            public Union<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.CSVMappingParameters, BaseFunction>? CSVMappingParameters { get; set; }
        }

        public class RecordColumn : Humidifier.Base.BaseSubResource, IHaveMapping, IHaveSqlType, IHaveName
        {
            /// <summary>
            /// Mapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-recordcolumn.html#cfn-kinesisanalytics-applicationreferencedatasource-recordcolumn-mapping
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mapping { get; set; }
            /// <summary>
            /// SqlType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-recordcolumn.html#cfn-kinesisanalytics-applicationreferencedatasource-recordcolumn-sqltype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SqlType { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-recordcolumn.html#cfn-kinesisanalytics-applicationreferencedatasource-recordcolumn-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RecordFormat : Humidifier.Base.BaseSubResource, IHaveKinesisAnalyticsApplicationReferenceDataSourceTypesMappingParametersMappingParameters, IHaveRecordFormatType
        {
            /// <summary>
            /// MappingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-recordformat.html#cfn-kinesisanalytics-applicationreferencedatasource-recordformat-mappingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MappingParameters
            /// </summary>
            public Union<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.MappingParameters, BaseFunction>? MappingParameters { get; set; }
            /// <summary>
            /// RecordFormatType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-recordformat.html#cfn-kinesisanalytics-applicationreferencedatasource-recordformat-recordformattype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordFormatType { get; set; }
        }

        public class ReferenceDataSource : Humidifier.Base.BaseSubResource, IHaveKinesisAnalyticsApplicationReferenceDataSourceTypesReferenceSchemaReferenceSchema, IHaveTableName, IHaveKinesisAnalyticsApplicationReferenceDataSourceTypesS3ReferenceDataSourceS3ReferenceDataSource
        {
            /// <summary>
            /// ReferenceSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-referencedatasource.html#cfn-kinesisanalytics-applicationreferencedatasource-referencedatasource-referenceschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ReferenceSchema
            /// </summary>
            public Union<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceSchema, BaseFunction>? ReferenceSchema { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-referencedatasource.html#cfn-kinesisanalytics-applicationreferencedatasource-referencedatasource-tablename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// S3ReferenceDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-referencedatasource.html#cfn-kinesisanalytics-applicationreferencedatasource-referencedatasource-s3referencedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3ReferenceDataSource
            /// </summary>
            public Union<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.S3ReferenceDataSource, BaseFunction>? S3ReferenceDataSource { get; set; }
        }

        public class ReferenceSchema : Humidifier.Base.BaseSubResource, IHaveRecordEncoding, IHaveListOfKinesisAnalyticsApplicationReferenceDataSourceTypesRecordColumnRecordColumns, IHaveKinesisAnalyticsApplicationReferenceDataSourceTypesRecordFormatRecordFormat
        {
            /// <summary>
            /// RecordEncoding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-referenceschema.html#cfn-kinesisanalytics-applicationreferencedatasource-referenceschema-recordencoding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordEncoding { get; set; }
            /// <summary>
            /// RecordColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-referenceschema.html#cfn-kinesisanalytics-applicationreferencedatasource-referenceschema-recordcolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RecordColumn
            /// </summary>
            public Union<IReadOnlyList<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordColumn>, IReadOnlyList<Union<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordColumn, BaseFunction>>, BaseFunction>? RecordColumns { get; set; }
            /// <summary>
            /// RecordFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-referenceschema.html#cfn-kinesisanalytics-applicationreferencedatasource-referenceschema-recordformat
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RecordFormat
            /// </summary>
            public Union<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordFormat, BaseFunction>? RecordFormat { get; set; }
        }

        public class S3ReferenceDataSource : Humidifier.Base.BaseSubResource, IHaveBucketARN, IHaveFileKey, IHaveReferenceRoleARN
        {
            /// <summary>
            /// BucketARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-s3referencedatasource.html#cfn-kinesisanalytics-applicationreferencedatasource-s3referencedatasource-bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketARN { get; set; }
            /// <summary>
            /// FileKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-s3referencedatasource.html#cfn-kinesisanalytics-applicationreferencedatasource-s3referencedatasource-filekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileKey { get; set; }
            /// <summary>
            /// ReferenceRoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-s3referencedatasource.html#cfn-kinesisanalytics-applicationreferencedatasource-s3referencedatasource-referencerolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReferenceRoleARN { get; set; }
        }
    }
}