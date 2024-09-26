namespace Humidifier.KinesisAnalyticsV2
{
    using System.Collections.Generic;
    using ApplicationOutputTypes;

    public class ApplicationOutput : Humidifier.Base.BaseResource, IHaveApplicationName
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
        public dynamic ApplicationName { get; set; }

        /// <summary>
        /// Output
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-applicationoutput.html#cfn-kinesisanalyticsv2-applicationoutput-output
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Output
        /// </summary>
        [Required]
        public Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.Output Output { get; set; }
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
            public dynamic RecordFormatType { get; set; }
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
            public dynamic ResourceARN { get; set; }
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
            public dynamic ResourceARN { get; set; }
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
            public dynamic ResourceARN { get; set; }
        }

        public class Output : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// DestinationSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-output.html#cfn-kinesisanalyticsv2-applicationoutput-output-destinationschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DestinationSchema
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.DestinationSchema DestinationSchema { get; set; }
            /// <summary>
            /// LambdaOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-output.html#cfn-kinesisanalyticsv2-applicationoutput-output-lambdaoutput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaOutput
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.LambdaOutput LambdaOutput { get; set; }
            /// <summary>
            /// KinesisFirehoseOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-output.html#cfn-kinesisanalyticsv2-applicationoutput-output-kinesisfirehoseoutput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisFirehoseOutput
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.KinesisFirehoseOutput KinesisFirehoseOutput { get; set; }
            /// <summary>
            /// KinesisStreamsOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-output.html#cfn-kinesisanalyticsv2-applicationoutput-output-kinesisstreamsoutput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisStreamsOutput
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.KinesisStreamsOutput KinesisStreamsOutput { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-output.html#cfn-kinesisanalyticsv2-applicationoutput-output-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}