namespace Humidifier.Timestream
{
    using System.Collections.Generic;
    using ScheduledQueryTypes;

    public class ScheduledQuery : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveKmsKeyId, IHaveQueryString, IHaveClientToken
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
        public dynamic ScheduledQueryExecutionRoleArn { get; set; }

        /// <summary>
        /// ErrorReportConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-scheduledquery.html#cfn-timestream-scheduledquery-errorreportconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ErrorReportConfiguration
        /// </summary>
        [Required]
        public Humidifier.Timestream.ScheduledQueryTypes.ErrorReportConfiguration ErrorReportConfiguration { get; set; }

        /// <summary>
        /// ScheduleConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-scheduledquery.html#cfn-timestream-scheduledquery-scheduleconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ScheduleConfiguration
        /// </summary>
        [Required]
        public Humidifier.Timestream.ScheduledQueryTypes.ScheduleConfiguration ScheduleConfiguration { get; set; }
        /// <summary>
        /// TargetConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-scheduledquery.html#cfn-timestream-scheduledquery-targetconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: TargetConfiguration
        /// </summary>
        public Humidifier.Timestream.ScheduledQueryTypes.TargetConfiguration TargetConfiguration { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-scheduledquery.html#cfn-timestream-scheduledquery-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyId { get; set; }

        /// <summary>
        /// QueryString
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-scheduledquery.html#cfn-timestream-scheduledquery-querystring
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic QueryString { get; set; }

        /// <summary>
        /// NotificationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-scheduledquery.html#cfn-timestream-scheduledquery-notificationconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: NotificationConfiguration
        /// </summary>
        [Required]
        public Humidifier.Timestream.ScheduledQueryTypes.NotificationConfiguration NotificationConfiguration { get; set; }
        public dynamic ScheduledQueryName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-scheduledquery.html#cfn-timestream-scheduledquery-clienttoken
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClientToken { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-scheduledquery.html#cfn-timestream-scheduledquery-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ScheduledQueryTypes
    {
        public class DimensionMapping : Humidifier.Base.BaseSubResource, IHaveName, IHaveDimensionValueType
        {
            /// <summary>
            /// DimensionValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-dimensionmapping.html#cfn-timestream-scheduledquery-dimensionmapping-dimensionvaluetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DimensionValueType { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-dimensionmapping.html#cfn-timestream-scheduledquery-dimensionmapping-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ErrorReportConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-errorreportconfiguration.html#cfn-timestream-scheduledquery-errorreportconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3Configuration
            /// </summary>
            public Humidifier.Timestream.ScheduledQueryTypes.S3Configuration S3Configuration { get; set; }
        }

        public class MixedMeasureMapping : Humidifier.Base.BaseSubResource, IHaveMeasureValueType, IHaveSourceColumn, IHaveMeasureName
        {
            /// <summary>
            /// MeasureName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-mixedmeasuremapping.html#cfn-timestream-scheduledquery-mixedmeasuremapping-measurename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MeasureName { get; set; }
            /// <summary>
            /// SourceColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-mixedmeasuremapping.html#cfn-timestream-scheduledquery-mixedmeasuremapping-sourcecolumn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceColumn { get; set; }
            /// <summary>
            /// TargetMeasureName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-mixedmeasuremapping.html#cfn-timestream-scheduledquery-mixedmeasuremapping-targetmeasurename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetMeasureName { get; set; }
            /// <summary>
            /// MeasureValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-mixedmeasuremapping.html#cfn-timestream-scheduledquery-mixedmeasuremapping-measurevaluetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MeasureValueType { get; set; }
            /// <summary>
            /// MultiMeasureAttributeMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-mixedmeasuremapping.html#cfn-timestream-scheduledquery-mixedmeasuremapping-multimeasureattributemappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MultiMeasureAttributeMapping
            /// </summary>
            public List<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureAttributeMapping> MultiMeasureAttributeMappings { get; set; }
        }

        public class MultiMeasureAttributeMapping : Humidifier.Base.BaseSubResource, IHaveMeasureValueType, IHaveSourceColumn
        {
            /// <summary>
            /// SourceColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-multimeasureattributemapping.html#cfn-timestream-scheduledquery-multimeasureattributemapping-sourcecolumn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceColumn { get; set; }
            /// <summary>
            /// TargetMultiMeasureAttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-multimeasureattributemapping.html#cfn-timestream-scheduledquery-multimeasureattributemapping-targetmultimeasureattributename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetMultiMeasureAttributeName { get; set; }
            /// <summary>
            /// MeasureValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-multimeasureattributemapping.html#cfn-timestream-scheduledquery-multimeasureattributemapping-measurevaluetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MeasureValueType { get; set; }
        }

        public class MultiMeasureMappings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetMultiMeasureName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-multimeasuremappings.html#cfn-timestream-scheduledquery-multimeasuremappings-targetmultimeasurename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetMultiMeasureName { get; set; }
            /// <summary>
            /// MultiMeasureAttributeMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-multimeasuremappings.html#cfn-timestream-scheduledquery-multimeasuremappings-multimeasureattributemappings
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MultiMeasureAttributeMapping
            /// </summary>
            public List<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureAttributeMapping> MultiMeasureAttributeMappings { get; set; }
        }

        public class NotificationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SnsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-notificationconfiguration.html#cfn-timestream-scheduledquery-notificationconfiguration-snsconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: SnsConfiguration
            /// </summary>
            public Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration SnsConfiguration { get; set; }
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
            public dynamic BucketName { get; set; }
            /// <summary>
            /// ObjectKeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-s3configuration.html#cfn-timestream-scheduledquery-s3configuration-objectkeyprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectKeyPrefix { get; set; }
            /// <summary>
            /// EncryptionOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-s3configuration.html#cfn-timestream-scheduledquery-s3configuration-encryptionoption
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionOption { get; set; }
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
            public dynamic ScheduleExpression { get; set; }
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
            public dynamic TopicArn { get; set; }
        }

        public class TargetConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TimestreamConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-targetconfiguration.html#cfn-timestream-scheduledquery-targetconfiguration-timestreamconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TimestreamConfiguration
            /// </summary>
            public Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration TimestreamConfiguration { get; set; }
        }

        public class TimestreamConfiguration : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveTableName
        {
            /// <summary>
            /// TimeColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-timestreamconfiguration.html#cfn-timestream-scheduledquery-timestreamconfiguration-timecolumn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeColumn { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-timestreamconfiguration.html#cfn-timestream-scheduledquery-timestreamconfiguration-tablename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableName { get; set; }
            /// <summary>
            /// DimensionMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-timestreamconfiguration.html#cfn-timestream-scheduledquery-timestreamconfiguration-dimensionmappings
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: DimensionMapping
            /// </summary>
            public List<Humidifier.Timestream.ScheduledQueryTypes.DimensionMapping> DimensionMappings { get; set; }
            /// <summary>
            /// MixedMeasureMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-timestreamconfiguration.html#cfn-timestream-scheduledquery-timestreamconfiguration-mixedmeasuremappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MixedMeasureMapping
            /// </summary>
            public List<Humidifier.Timestream.ScheduledQueryTypes.MixedMeasureMapping> MixedMeasureMappings { get; set; }
            /// <summary>
            /// MeasureNameColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-timestreamconfiguration.html#cfn-timestream-scheduledquery-timestreamconfiguration-measurenamecolumn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MeasureNameColumn { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-timestreamconfiguration.html#cfn-timestream-scheduledquery-timestreamconfiguration-databasename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// MultiMeasureMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-scheduledquery-timestreamconfiguration.html#cfn-timestream-scheduledquery-timestreamconfiguration-multimeasuremappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MultiMeasureMappings
            /// </summary>
            public Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings MultiMeasureMappings { get; set; }
        }
    }
}