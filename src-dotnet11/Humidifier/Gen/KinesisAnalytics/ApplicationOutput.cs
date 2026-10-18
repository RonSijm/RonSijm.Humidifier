namespace Humidifier.KinesisAnalytics
{
    using global::System.Collections.Generic;
    using ApplicationOutputTypes;

    public class ApplicationOutput : Humidifier.Base.BaseResource, IHaveApplicationName, IHaveKinesisAnalyticsApplicationOutputTypesOutputOutput
    {
        public override string AWSTypeName { get => AWS.KinesisAnalytics.ApplicationOutput; }

        /// <summary>
        /// ApplicationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-applicationoutput.html#cfn-kinesisanalytics-applicationoutput-applicationname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationName { get; set; }

        /// <summary>
        /// Output
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-applicationoutput.html#cfn-kinesisanalytics-applicationoutput-output
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Output
        /// </summary>
        [Required]
        public Union<Humidifier.KinesisAnalytics.ApplicationOutputTypes.Output, BaseFunction>? Output { get; set; }
    }

    namespace ApplicationOutputTypes
    {
        public class DestinationSchema : Humidifier.Base.BaseSubResource, IHaveRecordFormatType
        {
            /// <summary>
            /// RecordFormatType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-destinationschema.html#cfn-kinesisanalytics-applicationoutput-destinationschema-recordformattype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordFormatType { get; set; }
        }

        public class KinesisFirehoseOutput : Humidifier.Base.BaseSubResource, IHaveResourceARN, IHaveRoleARN
        {
            /// <summary>
            /// ResourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-kinesisfirehoseoutput.html#cfn-kinesisanalytics-applicationoutput-kinesisfirehoseoutput-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceARN { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-kinesisfirehoseoutput.html#cfn-kinesisanalytics-applicationoutput-kinesisfirehoseoutput-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleARN { get; set; }
        }

        public class KinesisStreamsOutput : Humidifier.Base.BaseSubResource, IHaveResourceARN, IHaveRoleARN
        {
            /// <summary>
            /// ResourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-kinesisstreamsoutput.html#cfn-kinesisanalytics-applicationoutput-kinesisstreamsoutput-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceARN { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-kinesisstreamsoutput.html#cfn-kinesisanalytics-applicationoutput-kinesisstreamsoutput-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleARN { get; set; }
        }

        public class LambdaOutput : Humidifier.Base.BaseSubResource, IHaveResourceARN, IHaveRoleARN
        {
            /// <summary>
            /// ResourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-lambdaoutput.html#cfn-kinesisanalytics-applicationoutput-lambdaoutput-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceARN { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-lambdaoutput.html#cfn-kinesisanalytics-applicationoutput-lambdaoutput-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleARN { get; set; }
        }

        public class Output : Humidifier.Base.BaseSubResource, IHaveKinesisAnalyticsApplicationOutputTypesDestinationSchemaDestinationSchema, IHaveKinesisAnalyticsApplicationOutputTypesLambdaOutputLambdaOutput, IHaveKinesisAnalyticsApplicationOutputTypesKinesisFirehoseOutputKinesisFirehoseOutput, IHaveKinesisAnalyticsApplicationOutputTypesKinesisStreamsOutputKinesisStreamsOutput, IHaveName
        {
            /// <summary>
            /// DestinationSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-output.html#cfn-kinesisanalytics-applicationoutput-output-destinationschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DestinationSchema
            /// </summary>
            public Union<Humidifier.KinesisAnalytics.ApplicationOutputTypes.DestinationSchema, BaseFunction>? DestinationSchema { get; set; }
            /// <summary>
            /// LambdaOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-output.html#cfn-kinesisanalytics-applicationoutput-output-lambdaoutput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaOutput
            /// </summary>
            public Union<Humidifier.KinesisAnalytics.ApplicationOutputTypes.LambdaOutput, BaseFunction>? LambdaOutput { get; set; }
            /// <summary>
            /// KinesisFirehoseOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-output.html#cfn-kinesisanalytics-applicationoutput-output-kinesisfirehoseoutput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisFirehoseOutput
            /// </summary>
            public Union<Humidifier.KinesisAnalytics.ApplicationOutputTypes.KinesisFirehoseOutput, BaseFunction>? KinesisFirehoseOutput { get; set; }
            /// <summary>
            /// KinesisStreamsOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-output.html#cfn-kinesisanalytics-applicationoutput-output-kinesisstreamsoutput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisStreamsOutput
            /// </summary>
            public Union<Humidifier.KinesisAnalytics.ApplicationOutputTypes.KinesisStreamsOutput, BaseFunction>? KinesisStreamsOutput { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-output.html#cfn-kinesisanalytics-applicationoutput-output-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}