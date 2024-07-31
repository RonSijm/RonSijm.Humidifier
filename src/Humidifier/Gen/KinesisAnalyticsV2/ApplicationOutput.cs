namespace Humidifier.KinesisAnalyticsV2
{
    using System.Collections.Generic;
    using ApplicationOutputTypes;

    public class ApplicationOutput : Humidifier.Base.BaseResource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::KinesisAnalyticsV2::ApplicationOutput";
            }
        }

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
        public ApplicationOutputTypes.Output Output { get; set; }
    }

    namespace ApplicationOutputTypes
    {
        public class DestinationSchema : Humidifier.Base.BaseSubResource
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

        public class KinesisFirehoseOutput : Humidifier.Base.BaseSubResource
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

        public class KinesisStreamsOutput : Humidifier.Base.BaseSubResource
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

        public class LambdaOutput : Humidifier.Base.BaseSubResource
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

        public class Output : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DestinationSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-output.html#cfn-kinesisanalyticsv2-applicationoutput-output-destinationschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DestinationSchema
            /// </summary>
            public ApplicationOutputTypes.DestinationSchema DestinationSchema { get; set; }
            /// <summary>
            /// LambdaOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-output.html#cfn-kinesisanalyticsv2-applicationoutput-output-lambdaoutput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaOutput
            /// </summary>
            public ApplicationOutputTypes.LambdaOutput LambdaOutput { get; set; }
            /// <summary>
            /// KinesisFirehoseOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-output.html#cfn-kinesisanalyticsv2-applicationoutput-output-kinesisfirehoseoutput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisFirehoseOutput
            /// </summary>
            public ApplicationOutputTypes.KinesisFirehoseOutput KinesisFirehoseOutput { get; set; }
            /// <summary>
            /// KinesisStreamsOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-output.html#cfn-kinesisanalyticsv2-applicationoutput-output-kinesisstreamsoutput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisStreamsOutput
            /// </summary>
            public ApplicationOutputTypes.KinesisStreamsOutput KinesisStreamsOutput { get; set; }
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