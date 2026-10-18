namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using RealtimeLogConfigTypes;

    public class RealtimeLogConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveStringListOfFields, IHaveListOfCloudFrontRealtimeLogConfigTypesEndPointEndPoints, IHaveSamplingRate_Double, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.RealtimeLogConfig; }

        /// <summary>
        /// Fields
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-realtimelogconfig.html#cfn-cloudfront-realtimelogconfig-fields
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Fields { get; set; }

        /// <summary>
        /// EndPoints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-realtimelogconfig.html#cfn-cloudfront-realtimelogconfig-endpoints
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EndPoint
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint>, IReadOnlyList<Union<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint, BaseFunction>>, BaseFunction>? EndPoints { get; set; }

        /// <summary>
        /// SamplingRate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-realtimelogconfig.html#cfn-cloudfront-realtimelogconfig-samplingrate
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public Union<double, BaseFunction>? SamplingRate { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RealtimeLogConfigTypes
    {
        public class EndPoint : Humidifier.Base.BaseSubResource, IHaveCloudFrontRealtimeLogConfigTypesKinesisStreamConfigKinesisStreamConfig, IHaveStreamType
        {
            /// <summary>
            /// KinesisStreamConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-realtimelogconfig-endpoint.html#cfn-cloudfront-realtimelogconfig-endpoint-kinesisstreamconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KinesisStreamConfig
            /// </summary>
            public Union<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig, BaseFunction>? KinesisStreamConfig { get; set; }
            /// <summary>
            /// StreamType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-realtimelogconfig-endpoint.html#cfn-cloudfront-realtimelogconfig-endpoint-streamtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamType { get; set; }
        }

        public class KinesisStreamConfig : Humidifier.Base.BaseSubResource, IHaveStreamArn, IHaveRoleArn
        {
            /// <summary>
            /// StreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-realtimelogconfig-kinesisstreamconfig.html#cfn-cloudfront-realtimelogconfig-kinesisstreamconfig-streamarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-realtimelogconfig-kinesisstreamconfig.html#cfn-cloudfront-realtimelogconfig-kinesisstreamconfig-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }
    }
}