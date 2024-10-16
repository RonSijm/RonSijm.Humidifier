namespace Humidifier.CloudFront
{
    using System.Collections.Generic;
    using RealtimeLogConfigTypes;

    public class RealtimeLogConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveSamplingRate
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
        public dynamic Fields { get; set; }

        /// <summary>
        /// EndPoints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-realtimelogconfig.html#cfn-cloudfront-realtimelogconfig-endpoints
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EndPoint
        /// </summary>
        [Required]
        public List<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint> EndPoints { get; set; }

        /// <summary>
        /// SamplingRate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-realtimelogconfig.html#cfn-cloudfront-realtimelogconfig-samplingrate
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public dynamic SamplingRate { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace RealtimeLogConfigTypes
    {
        public class EndPoint : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KinesisStreamConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-realtimelogconfig-endpoint.html#cfn-cloudfront-realtimelogconfig-endpoint-kinesisstreamconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KinesisStreamConfig
            /// </summary>
            public Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig KinesisStreamConfig { get; set; }
            /// <summary>
            /// StreamType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-realtimelogconfig-endpoint.html#cfn-cloudfront-realtimelogconfig-endpoint-streamtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamType { get; set; }
        }

        public class KinesisStreamConfig : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveStreamArn
        {
            /// <summary>
            /// StreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-realtimelogconfig-kinesisstreamconfig.html#cfn-cloudfront-realtimelogconfig-kinesisstreamconfig-streamarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-realtimelogconfig-kinesisstreamconfig.html#cfn-cloudfront-realtimelogconfig-kinesisstreamconfig-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }
    }
}