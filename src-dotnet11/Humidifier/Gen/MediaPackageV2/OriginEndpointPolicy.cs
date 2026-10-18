namespace Humidifier.MediaPackageV2
{
    using global::System.Collections.Generic;
    using OriginEndpointPolicyTypes;

    public class OriginEndpointPolicy : Humidifier.Base.BaseResource, IHavePolicy_Json, IHaveChannelName, IHaveOriginEndpointName, IHaveChannelGroupName, IHaveMediaPackageV2OriginEndpointPolicyTypesCdnAuthConfigurationCdnAuthConfiguration
    {
        public override string AWSTypeName { get => AWS.MediaPackageV2.OriginEndpointPolicy; }

        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpointpolicy.html#cfn-mediapackagev2-originendpointpolicy-policy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? Policy { get; set; }

        /// <summary>
        /// ChannelName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpointpolicy.html#cfn-mediapackagev2-originendpointpolicy-channelname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ChannelName { get; set; }

        /// <summary>
        /// OriginEndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpointpolicy.html#cfn-mediapackagev2-originendpointpolicy-originendpointname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OriginEndpointName { get; set; }

        /// <summary>
        /// ChannelGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpointpolicy.html#cfn-mediapackagev2-originendpointpolicy-channelgroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ChannelGroupName { get; set; }
        /// <summary>
        /// CdnAuthConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpointpolicy.html#cfn-mediapackagev2-originendpointpolicy-cdnauthconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CdnAuthConfiguration
        /// </summary>
        public Union<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration, BaseFunction>? CdnAuthConfiguration { get; set; }
    }

    namespace OriginEndpointPolicyTypes
    {
        public class CdnAuthConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretsRoleArn, IHaveStringListOfCdnIdentifierSecretArns
        {
            /// <summary>
            /// SecretsRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpointpolicy-cdnauthconfiguration.html#cfn-mediapackagev2-originendpointpolicy-cdnauthconfiguration-secretsrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsRoleArn { get; set; }
            /// <summary>
            /// CdnIdentifierSecretArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpointpolicy-cdnauthconfiguration.html#cfn-mediapackagev2-originendpointpolicy-cdnauthconfiguration-cdnidentifiersecretarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CdnIdentifierSecretArns { get; set; }
        }
    }
}