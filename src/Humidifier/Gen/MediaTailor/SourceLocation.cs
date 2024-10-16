namespace Humidifier.MediaTailor
{
    using System.Collections.Generic;
    using SourceLocationTypes;

    public class SourceLocation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSourceLocationName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaTailor.SourceLocation; }
        public dynamic SourceLocationName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DefaultSegmentDeliveryConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-sourcelocation.html#cfn-mediatailor-sourcelocation-defaultsegmentdeliveryconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DefaultSegmentDeliveryConfiguration
        /// </summary>
        public Humidifier.MediaTailor.SourceLocationTypes.DefaultSegmentDeliveryConfiguration DefaultSegmentDeliveryConfiguration { get; set; }
        /// <summary>
        /// SegmentDeliveryConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-sourcelocation.html#cfn-mediatailor-sourcelocation-segmentdeliveryconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SegmentDeliveryConfiguration
        /// </summary>
        public List<Humidifier.MediaTailor.SourceLocationTypes.SegmentDeliveryConfiguration> SegmentDeliveryConfigurations { get; set; }

        /// <summary>
        /// HttpConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-sourcelocation.html#cfn-mediatailor-sourcelocation-httpconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: HttpConfiguration
        /// </summary>
        [Required]
        public Humidifier.MediaTailor.SourceLocationTypes.HttpConfiguration HttpConfiguration { get; set; }
        /// <summary>
        /// AccessConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-sourcelocation.html#cfn-mediatailor-sourcelocation-accessconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccessConfiguration
        /// </summary>
        public Humidifier.MediaTailor.SourceLocationTypes.AccessConfiguration AccessConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-sourcelocation.html#cfn-mediatailor-sourcelocation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace SourceLocationTypes
    {
        public class AccessConfiguration : Humidifier.Base.BaseSubResource, IHaveAccessType
        {
            /// <summary>
            /// SecretsManagerAccessTokenConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-sourcelocation-accessconfiguration.html#cfn-mediatailor-sourcelocation-accessconfiguration-secretsmanageraccesstokenconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretsManagerAccessTokenConfiguration
            /// </summary>
            public Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration SecretsManagerAccessTokenConfiguration { get; set; }
            /// <summary>
            /// AccessType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-sourcelocation-accessconfiguration.html#cfn-mediatailor-sourcelocation-accessconfiguration-accesstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccessType { get; set; }
        }

        public class DefaultSegmentDeliveryConfiguration : Humidifier.Base.BaseSubResource, IHaveBaseUrl
        {
            /// <summary>
            /// BaseUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-sourcelocation-defaultsegmentdeliveryconfiguration.html#cfn-mediatailor-sourcelocation-defaultsegmentdeliveryconfiguration-baseurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseUrl { get; set; }
        }

        public class HttpConfiguration : Humidifier.Base.BaseSubResource, IHaveBaseUrl
        {
            /// <summary>
            /// BaseUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-sourcelocation-httpconfiguration.html#cfn-mediatailor-sourcelocation-httpconfiguration-baseurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseUrl { get; set; }
        }

        public class SecretsManagerAccessTokenConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveHeaderName
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-sourcelocation-secretsmanageraccesstokenconfiguration.html#cfn-mediatailor-sourcelocation-secretsmanageraccesstokenconfiguration-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// HeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-sourcelocation-secretsmanageraccesstokenconfiguration.html#cfn-mediatailor-sourcelocation-secretsmanageraccesstokenconfiguration-headername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HeaderName { get; set; }
            /// <summary>
            /// SecretStringKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-sourcelocation-secretsmanageraccesstokenconfiguration.html#cfn-mediatailor-sourcelocation-secretsmanageraccesstokenconfiguration-secretstringkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretStringKey { get; set; }
        }

        public class SegmentDeliveryConfiguration : Humidifier.Base.BaseSubResource, IHaveName, IHaveBaseUrl
        {
            /// <summary>
            /// BaseUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-sourcelocation-segmentdeliveryconfiguration.html#cfn-mediatailor-sourcelocation-segmentdeliveryconfiguration-baseurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseUrl { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-sourcelocation-segmentdeliveryconfiguration.html#cfn-mediatailor-sourcelocation-segmentdeliveryconfiguration-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}