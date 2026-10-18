namespace Humidifier.MediaTailor
{
    using global::System.Collections.Generic;
    using SourceLocationTypes;

    public class SourceLocation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSourceLocationName, IHaveMediaTailorSourceLocationTypesDefaultSegmentDeliveryConfigurationDefaultSegmentDeliveryConfiguration, IHaveListOfMediaTailorSourceLocationTypesSegmentDeliveryConfigurationSegmentDeliveryConfigurations, IHaveMediaTailorSourceLocationTypesHttpConfigurationHttpConfiguration, IHaveMediaTailorSourceLocationTypesAccessConfigurationAccessConfiguration
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaTailor.SourceLocation; }
        public Union<string, BaseFunction>? SourceLocationName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DefaultSegmentDeliveryConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-sourcelocation.html#cfn-mediatailor-sourcelocation-defaultsegmentdeliveryconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DefaultSegmentDeliveryConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.SourceLocationTypes.DefaultSegmentDeliveryConfiguration, BaseFunction>? DefaultSegmentDeliveryConfiguration { get; set; }
        /// <summary>
        /// SegmentDeliveryConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-sourcelocation.html#cfn-mediatailor-sourcelocation-segmentdeliveryconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SegmentDeliveryConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaTailor.SourceLocationTypes.SegmentDeliveryConfiguration>, IReadOnlyList<Union<Humidifier.MediaTailor.SourceLocationTypes.SegmentDeliveryConfiguration, BaseFunction>>, BaseFunction>? SegmentDeliveryConfigurations { get; set; }

        /// <summary>
        /// HttpConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-sourcelocation.html#cfn-mediatailor-sourcelocation-httpconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: HttpConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.MediaTailor.SourceLocationTypes.HttpConfiguration, BaseFunction>? HttpConfiguration { get; set; }
        /// <summary>
        /// AccessConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-sourcelocation.html#cfn-mediatailor-sourcelocation-accessconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccessConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.SourceLocationTypes.AccessConfiguration, BaseFunction>? AccessConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-sourcelocation.html#cfn-mediatailor-sourcelocation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace SourceLocationTypes
    {
        public class AccessConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaTailorSourceLocationTypesSecretsManagerAccessTokenConfigurationSecretsManagerAccessTokenConfiguration, IHaveAccessType
        {
            /// <summary>
            /// SecretsManagerAccessTokenConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-sourcelocation-accessconfiguration.html#cfn-mediatailor-sourcelocation-accessconfiguration-secretsmanageraccesstokenconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretsManagerAccessTokenConfiguration
            /// </summary>
            public Union<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration, BaseFunction>? SecretsManagerAccessTokenConfiguration { get; set; }
            /// <summary>
            /// AccessType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-sourcelocation-accessconfiguration.html#cfn-mediatailor-sourcelocation-accessconfiguration-accesstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessType { get; set; }
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
            public Union<string, BaseFunction>? BaseUrl { get; set; }
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
            public Union<string, BaseFunction>? BaseUrl { get; set; }
        }

        public class SecretsManagerAccessTokenConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveHeaderName, IHaveSecretStringKey
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-sourcelocation-secretsmanageraccesstokenconfiguration.html#cfn-mediatailor-sourcelocation-secretsmanageraccesstokenconfiguration-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// HeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-sourcelocation-secretsmanageraccesstokenconfiguration.html#cfn-mediatailor-sourcelocation-secretsmanageraccesstokenconfiguration-headername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HeaderName { get; set; }
            /// <summary>
            /// SecretStringKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-sourcelocation-secretsmanageraccesstokenconfiguration.html#cfn-mediatailor-sourcelocation-secretsmanageraccesstokenconfiguration-secretstringkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretStringKey { get; set; }
        }

        public class SegmentDeliveryConfiguration : Humidifier.Base.BaseSubResource, IHaveBaseUrl, IHaveName
        {
            /// <summary>
            /// BaseUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-sourcelocation-segmentdeliveryconfiguration.html#cfn-mediatailor-sourcelocation-segmentdeliveryconfiguration-baseurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseUrl { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-sourcelocation-segmentdeliveryconfiguration.html#cfn-mediatailor-sourcelocation-segmentdeliveryconfiguration-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}