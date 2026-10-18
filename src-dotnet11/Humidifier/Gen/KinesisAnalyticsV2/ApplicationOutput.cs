namespace Humidifier.KinesisAnalyticsV2
{
    using global::System.Collections.Generic;
    using ApplicationOutputTypes;

    public class ApplicationOutput : Humidifier.Base.BaseResource, IHaveApplicationName, IHaveKinesisAnalyticsV2ApplicationOutputTypesOutputOutput
    {
        public override string AWSTypeName { get => AWS.KinesisAnalyticsV2.ApplicationOutput; }

        /// <summary>
        /// ApplicationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-applicationoutput.html#cfn-kinesisanalyticsv2-applicationoutput-applicationname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationName { get; set; }

        /// <summary>
        /// Output
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-applicationoutput.html#cfn-kinesisanalyticsv2-applicationoutput-output
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Output
        /// </summary>
        [Required]
        public Union<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.Output, BaseFunction>? Output { get; set; }
    }

    namespace ApplicationOutputTypes
    {
        public class DestinationSchema : Humidifier.Base.BaseSubResource, IHaveRecordFormatType
        {
            /// <summary>
            /// RecordFormatType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-destinationschema.html#cfn-kinesisanalyticsv2-applicationoutput-destinationschema-recordformattype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordFormatType { get; set; }
        }

        public class KinesisFirehoseOutput : Humidifier.Base.BaseSubResource, IHaveResourceARN
        {
            /// <summary>
            /// ResourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-kinesisfirehoseoutput.html#cfn-kinesisanalyticsv2-applicationoutput-kinesisfirehoseoutput-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceARN { get; set; }
        }

        public class KinesisStreamsOutput : Humidifier.Base.BaseSubResource, IHaveResourceARN
        {
            /// <summary>
            /// ResourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-kinesisstreamsoutput.html#cfn-kinesisanalyticsv2-applicationoutput-kinesisstreamsoutput-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceARN { get; set; }
        }

        public class LambdaOutput : Humidifier.Base.BaseSubResource, IHaveResourceARN
        {
            /// <summary>
            /// ResourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-lambdaoutput.html#cfn-kinesisanalyticsv2-applicationoutput-lambdaoutput-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceARN { get; set; }
        }

        public class Output : Humidifier.Base.BaseSubResource, IHaveKinesisAnalyticsV2ApplicationOutputTypesDestinationSchemaDestinationSchema, IHaveKinesisAnalyticsV2ApplicationOutputTypesLambdaOutputLambdaOutput, IHaveKinesisAnalyticsV2ApplicationOutputTypesKinesisFirehoseOutputKinesisFirehoseOutput, IHaveKinesisAnalyticsV2ApplicationOutputTypesKinesisStreamsOutputKinesisStreamsOutput, IHaveName
        {
            /// <summary>
            /// DestinationSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-output.html#cfn-kinesisanalyticsv2-applicationoutput-output-destinationschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DestinationSchema
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.DestinationSchema, BaseFunction>? DestinationSchema { get; set; }
            /// <summary>
            /// LambdaOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-output.html#cfn-kinesisanalyticsv2-applicationoutput-output-lambdaoutput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaOutput
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.LambdaOutput, BaseFunction>? LambdaOutput { get; set; }
            /// <summary>
            /// KinesisFirehoseOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-output.html#cfn-kinesisanalyticsv2-applicationoutput-output-kinesisfirehoseoutput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisFirehoseOutput
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.KinesisFirehoseOutput, BaseFunction>? KinesisFirehoseOutput { get; set; }
            /// <summary>
            /// KinesisStreamsOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-output.html#cfn-kinesisanalyticsv2-applicationoutput-output-kinesisstreamsoutput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisStreamsOutput
            /// </summary>
            public Union<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.KinesisStreamsOutput, BaseFunction>? KinesisStreamsOutput { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-output.html#cfn-kinesisanalyticsv2-applicationoutput-output-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}