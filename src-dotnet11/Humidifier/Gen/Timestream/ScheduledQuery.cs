namespace Humidifier.Timestream
{
    using global::System.Collections.Generic;
    using ScheduledQueryTypes;

    public class ScheduledQuery : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveScheduledQueryExecutionRoleArn, IHaveTimestreamScheduledQueryTypesErrorReportConfigurationErrorReportConfiguration, IHaveTimestreamScheduledQueryTypesScheduleConfigurationScheduleConfiguration, IHaveTimestreamScheduledQueryTypesTargetConfigurationTargetConfiguration, IHaveKmsKeyId, IHaveQueryString, IHaveTimestreamScheduledQueryTypesNotificationConfigurationNotificationConfiguration, IHaveScheduledQueryName, IHaveClientToken
    {
        public class Attributes
        {
            public static string SQScheduleConfiguration =  "SQScheduleConfiguration" ;
            public static string SQNotificationConfiguration =  "SQNotificationConfiguration" ;
            public static string SQErrorReportConfiguration =  "SQErrorReportConfiguration" ;
            public static string SQKmsKeyId =  "SQKmsKeyId" ;
            public static string SQQueryString =  "SQQueryString" ;
            public static string SQTargetConfiguration =  "SQTargetConfiguration" ;
            public static string SQName =  "SQName" ;
            public static string Arn =  "Arn" ;
            public static string SQScheduledQueryExecutionRoleArn =  "SQScheduledQueryExecutionRoleArn" ;
        }

        public override string AWSTypeName { get => AWS.Timestream.ScheduledQuery; }

        /// <summary>
        /// ScheduledQueryExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-scheduledquery.html#cfn-timestream-scheduledquery-scheduledqueryexecutionrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ScheduledQueryExecutionRoleArn { get; set; }

        /// <summary>
        /// ErrorReportConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-scheduledquery.html#cfn-timestream-scheduledquery-errorreportconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ErrorReportConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.Timestream.ScheduledQueryTypes.ErrorReportConfiguration, BaseFunction>? ErrorReportConfiguration { get; set; }

        /// <summary>
        /// ScheduleConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-scheduledquery.html#cfn-timestream-scheduledquery-scheduleconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ScheduleConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.Timestream.ScheduledQueryTypes.ScheduleConfiguration, BaseFunction>? ScheduleConfiguration { get; set; }
        /// <summary>
        /// TargetConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-scheduledquery.html#cfn-timestream-scheduledquery-targetconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: TargetConfiguration
        /// </summary>
        public Union<Humidifier.Timestream.ScheduledQueryTypes.TargetConfiguration, BaseFunction>? TargetConfiguration { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-scheduledquery.html#cfn-timestream-scheduledquery-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }

        /// <summary>
        /// QueryString
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-scheduledquery.html#cfn-timestream-scheduledquery-querystring
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? QueryString { get; set; }

        /// <summary>
        /// NotificationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-scheduledquery.html#cfn-timestream-scheduledquery-notificationconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: NotificationConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.Timestream.ScheduledQueryTypes.NotificationConfiguration, BaseFunction>? NotificationConfiguration { get; set; }
        public Union<string, BaseFunction>? ScheduledQueryName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-scheduledquery.html#cfn-timestream-scheduledquery-clienttoken
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientToken { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-scheduledquery.html#cfn-timestream-scheduledquery-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ScheduledQueryTypes
    {
        public class DimensionMapping : Humidifier.Base.BaseSubResource, IHaveDimensionValueType, IHaveName
        {
            /// <summary>
            /// DimensionValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-dimensionmapping.html#cfn-timestream-scheduledquery-dimensionmapping-dimensionvaluetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DimensionValueType { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-dimensionmapping.html#cfn-timestream-scheduledquery-dimensionmapping-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ErrorReportConfiguration : Humidifier.Base.BaseSubResource, IHaveTimestreamScheduledQueryTypesS3ConfigurationS3Configuration
        {
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-errorreportconfiguration.html#cfn-timestream-scheduledquery-errorreportconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3Configuration
            /// </summary>
            public Union<Humidifier.Timestream.ScheduledQueryTypes.S3Configuration, BaseFunction>? S3Configuration { get; set; }
        }

        public class MixedMeasureMapping : Humidifier.Base.BaseSubResource, IHaveMeasureName, IHaveSourceColumn, IHaveTargetMeasureName, IHaveMeasureValueType, IHaveListOfTimestreamScheduledQueryTypesMultiMeasureAttributeMappingMultiMeasureAttributeMappings
        {
            /// <summary>
            /// MeasureName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-mixedmeasuremapping.html#cfn-timestream-scheduledquery-mixedmeasuremapping-measurename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MeasureName { get; set; }
            /// <summary>
            /// SourceColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-mixedmeasuremapping.html#cfn-timestream-scheduledquery-mixedmeasuremapping-sourcecolumn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceColumn { get; set; }
            /// <summary>
            /// TargetMeasureName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-mixedmeasuremapping.html#cfn-timestream-scheduledquery-mixedmeasuremapping-targetmeasurename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetMeasureName { get; set; }
            /// <summary>
            /// MeasureValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-mixedmeasuremapping.html#cfn-timestream-scheduledquery-mixedmeasuremapping-measurevaluetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MeasureValueType { get; set; }
            /// <summary>
            /// MultiMeasureAttributeMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-mixedmeasuremapping.html#cfn-timestream-scheduledquery-mixedmeasuremapping-multimeasureattributemappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MultiMeasureAttributeMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureAttributeMapping>, IReadOnlyList<Union<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureAttributeMapping, BaseFunction>>, BaseFunction>? MultiMeasureAttributeMappings { get; set; }
        }

        public class MultiMeasureAttributeMapping : Humidifier.Base.BaseSubResource, IHaveSourceColumn, IHaveTargetMultiMeasureAttributeName, IHaveMeasureValueType
        {
            /// <summary>
            /// SourceColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-multimeasureattributemapping.html#cfn-timestream-scheduledquery-multimeasureattributemapping-sourcecolumn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceColumn { get; set; }
            /// <summary>
            /// TargetMultiMeasureAttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-multimeasureattributemapping.html#cfn-timestream-scheduledquery-multimeasureattributemapping-targetmultimeasureattributename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetMultiMeasureAttributeName { get; set; }
            /// <summary>
            /// MeasureValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-multimeasureattributemapping.html#cfn-timestream-scheduledquery-multimeasureattributemapping-measurevaluetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MeasureValueType { get; set; }
        }

        public class MultiMeasureMappings : Humidifier.Base.BaseSubResource, IHaveTargetMultiMeasureName, IHaveListOfTimestreamScheduledQueryTypesMultiMeasureAttributeMappingMultiMeasureAttributeMappings
        {
            /// <summary>
            /// TargetMultiMeasureName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-multimeasuremappings.html#cfn-timestream-scheduledquery-multimeasuremappings-targetmultimeasurename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetMultiMeasureName { get; set; }
            /// <summary>
            /// MultiMeasureAttributeMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-multimeasuremappings.html#cfn-timestream-scheduledquery-multimeasuremappings-multimeasureattributemappings
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MultiMeasureAttributeMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureAttributeMapping>, IReadOnlyList<Union<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureAttributeMapping, BaseFunction>>, BaseFunction>? MultiMeasureAttributeMappings { get; set; }
        }

        public class NotificationConfiguration : Humidifier.Base.BaseSubResource, IHaveTimestreamScheduledQueryTypesSnsConfigurationSnsConfiguration
        {
            /// <summary>
            /// SnsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-notificationconfiguration.html#cfn-timestream-scheduledquery-notificationconfiguration-snsconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: SnsConfiguration
            /// </summary>
            public Union<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration, BaseFunction>? SnsConfiguration { get; set; }
        }

        public class S3Configuration : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveObjectKeyPrefix, IHaveEncryptionOption
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-s3configuration.html#cfn-timestream-scheduledquery-s3configuration-bucketname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// ObjectKeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-s3configuration.html#cfn-timestream-scheduledquery-s3configuration-objectkeyprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectKeyPrefix { get; set; }
            /// <summary>
            /// EncryptionOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-s3configuration.html#cfn-timestream-scheduledquery-s3configuration-encryptionoption
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionOption { get; set; }
        }

        public class ScheduleConfiguration : Humidifier.Base.BaseSubResource, IHaveScheduleExpression
        {
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-scheduleconfiguration.html#cfn-timestream-scheduledquery-scheduleconfiguration-scheduleexpression
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleExpression { get; set; }
        }

        public class SnsConfiguration : Humidifier.Base.BaseSubResource, IHaveTopicArn
        {
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-snsconfiguration.html#cfn-timestream-scheduledquery-snsconfiguration-topicarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TopicArn { get; set; }
        }

        public class TargetConfiguration : Humidifier.Base.BaseSubResource, IHaveTimestreamScheduledQueryTypesTimestreamConfigurationTimestreamConfiguration
        {
            /// <summary>
            /// TimestreamConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-targetconfiguration.html#cfn-timestream-scheduledquery-targetconfiguration-timestreamconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TimestreamConfiguration
            /// </summary>
            public Union<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration, BaseFunction>? TimestreamConfiguration { get; set; }
        }

        public class TimestreamConfiguration : Humidifier.Base.BaseSubResource, IHaveTimeColumn, IHaveTableName, IHaveListOfTimestreamScheduledQueryTypesDimensionMappingDimensionMappings, IHaveListOfTimestreamScheduledQueryTypesMixedMeasureMappingMixedMeasureMappings, IHaveMeasureNameColumn, IHaveDatabaseName, IHaveTimestreamScheduledQueryTypesMultiMeasureMappingsMultiMeasureMappings
        {
            /// <summary>
            /// TimeColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-timestreamconfiguration.html#cfn-timestream-scheduledquery-timestreamconfiguration-timecolumn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeColumn { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-timestreamconfiguration.html#cfn-timestream-scheduledquery-timestreamconfiguration-tablename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// DimensionMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-timestreamconfiguration.html#cfn-timestream-scheduledquery-timestreamconfiguration-dimensionmappings
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: DimensionMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Timestream.ScheduledQueryTypes.DimensionMapping>, IReadOnlyList<Union<Humidifier.Timestream.ScheduledQueryTypes.DimensionMapping, BaseFunction>>, BaseFunction>? DimensionMappings { get; set; }
            /// <summary>
            /// MixedMeasureMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-timestreamconfiguration.html#cfn-timestream-scheduledquery-timestreamconfiguration-mixedmeasuremappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MixedMeasureMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Timestream.ScheduledQueryTypes.MixedMeasureMapping>, IReadOnlyList<Union<Humidifier.Timestream.ScheduledQueryTypes.MixedMeasureMapping, BaseFunction>>, BaseFunction>? MixedMeasureMappings { get; set; }
            /// <summary>
            /// MeasureNameColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-timestreamconfiguration.html#cfn-timestream-scheduledquery-timestreamconfiguration-measurenamecolumn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MeasureNameColumn { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-timestreamconfiguration.html#cfn-timestream-scheduledquery-timestreamconfiguration-databasename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// MultiMeasureMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-timestreamconfiguration.html#cfn-timestream-scheduledquery-timestreamconfiguration-multimeasuremappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MultiMeasureMappings
            /// </summary>
            public Union<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings, BaseFunction>? MultiMeasureMappings { get; set; }
        }
    }
}