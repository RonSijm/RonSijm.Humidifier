namespace Humidifier.MediaPackage
{
    using global::System.Collections.Generic;
    using OriginEndpointTypes;

    public class OriginEndpoint : Humidifier.Base.BaseResource, IHaveTags, IHaveMediaPackageOriginEndpointTypesMssPackageMssPackage, IHaveDescription, IHaveChannelId, IHaveTimeDelaySeconds_Integer, IHaveOrigination, IHaveMediaPackageOriginEndpointTypesAuthorizationAuthorization, IHaveManifestName, IHaveMediaPackageOriginEndpointTypesCmafPackageCmafPackage, IHaveStringListOfWhitelist, IHaveId, IHaveMediaPackageOriginEndpointTypesHlsPackageHlsPackage, IHaveMediaPackageOriginEndpointTypesDashPackageDashPackage, IHaveStartoverWindowSeconds_Integer
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string Url =  "Url" ;
        }

        public override string AWSTypeName { get => AWS.MediaPackage.OriginEndpoint; }
        /// <summary>
        /// MssPackage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-originendpoint.html#cfn-mediapackage-originendpoint-msspackage
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MssPackage
        /// </summary>
        public Union<Humidifier.MediaPackage.OriginEndpointTypes.MssPackage, BaseFunction>? MssPackage { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-originendpoint.html#cfn-mediapackage-originendpoint-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ChannelId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-originendpoint.html#cfn-mediapackage-originendpoint-channelid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ChannelId { get; set; }
        /// <summary>
        /// TimeDelaySeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-originendpoint.html#cfn-mediapackage-originendpoint-timedelayseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? TimeDelaySeconds { get; set; }
        /// <summary>
        /// Origination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-originendpoint.html#cfn-mediapackage-originendpoint-origination
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Origination { get; set; }
        /// <summary>
        /// Authorization
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-originendpoint.html#cfn-mediapackage-originendpoint-authorization
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Authorization
        /// </summary>
        public Union<Humidifier.MediaPackage.OriginEndpointTypes.Authorization, BaseFunction>? Authorization { get; set; }
        /// <summary>
        /// ManifestName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-originendpoint.html#cfn-mediapackage-originendpoint-manifestname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ManifestName { get; set; }
        /// <summary>
        /// CmafPackage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-originendpoint.html#cfn-mediapackage-originendpoint-cmafpackage
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CmafPackage
        /// </summary>
        public Union<Humidifier.MediaPackage.OriginEndpointTypes.CmafPackage, BaseFunction>? CmafPackage { get; set; }
        /// <summary>
        /// Whitelist
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-originendpoint.html#cfn-mediapackage-originendpoint-whitelist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Whitelist { get; set; }

        /// <summary>
        /// Id
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-originendpoint.html#cfn-mediapackage-originendpoint-id
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Id { get; set; }
        /// <summary>
        /// HlsPackage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-originendpoint.html#cfn-mediapackage-originendpoint-hlspackage
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HlsPackage
        /// </summary>
        public Union<Humidifier.MediaPackage.OriginEndpointTypes.HlsPackage, BaseFunction>? HlsPackage { get; set; }
        /// <summary>
        /// DashPackage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-originendpoint.html#cfn-mediapackage-originendpoint-dashpackage
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DashPackage
        /// </summary>
        public Union<Humidifier.MediaPackage.OriginEndpointTypes.DashPackage, BaseFunction>? DashPackage { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-originendpoint.html#cfn-mediapackage-originendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// StartoverWindowSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-originendpoint.html#cfn-mediapackage-originendpoint-startoverwindowseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? StartoverWindowSeconds { get; set; }
    }

    namespace OriginEndpointTypes
    {
        public class Authorization : Humidifier.Base.BaseSubResource, IHaveSecretsRoleArn, IHaveCdnIdentifierSecret
        {
            /// <summary>
            /// SecretsRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-authorization.html#cfn-mediapackage-originendpoint-authorization-secretsrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsRoleArn { get; set; }
            /// <summary>
            /// CdnIdentifierSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-authorization.html#cfn-mediapackage-originendpoint-authorization-cdnidentifiersecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CdnIdentifierSecret { get; set; }
        }

        public class CmafEncryption : Humidifier.Base.BaseSubResource, IHaveKeyRotationIntervalSeconds_Integer, IHaveMediaPackageOriginEndpointTypesSpekeKeyProviderSpekeKeyProvider, IHaveConstantInitializationVector, IHaveEncryptionMethod
        {
            /// <summary>
            /// KeyRotationIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-cmafencryption.html#cfn-mediapackage-originendpoint-cmafencryption-keyrotationintervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? KeyRotationIntervalSeconds { get; set; }
            /// <summary>
            /// SpekeKeyProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-cmafencryption.html#cfn-mediapackage-originendpoint-cmafencryption-spekekeyprovider
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SpekeKeyProvider
            /// </summary>
            public Union<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider, BaseFunction>? SpekeKeyProvider { get; set; }
            /// <summary>
            /// ConstantInitializationVector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-cmafencryption.html#cfn-mediapackage-originendpoint-cmafencryption-constantinitializationvector
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConstantInitializationVector { get; set; }
            /// <summary>
            /// EncryptionMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-cmafencryption.html#cfn-mediapackage-originendpoint-cmafencryption-encryptionmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionMethod { get; set; }
        }

        public class CmafPackage : Humidifier.Base.BaseSubResource, IHaveSegmentPrefix, IHaveMediaPackageOriginEndpointTypesStreamSelectionStreamSelection, IHaveSegmentDurationSeconds_Integer, IHaveMediaPackageOriginEndpointTypesCmafEncryptionEncryption, IHaveListOfMediaPackageOriginEndpointTypesHlsManifestHlsManifests
        {
            /// <summary>
            /// SegmentPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-cmafpackage.html#cfn-mediapackage-originendpoint-cmafpackage-segmentprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentPrefix { get; set; }
            /// <summary>
            /// StreamSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-cmafpackage.html#cfn-mediapackage-originendpoint-cmafpackage-streamselection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StreamSelection
            /// </summary>
            public Union<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection, BaseFunction>? StreamSelection { get; set; }
            /// <summary>
            /// SegmentDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-cmafpackage.html#cfn-mediapackage-originendpoint-cmafpackage-segmentdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentDurationSeconds { get; set; }
            /// <summary>
            /// Encryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-cmafpackage.html#cfn-mediapackage-originendpoint-cmafpackage-encryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CmafEncryption
            /// </summary>
            public Union<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption, BaseFunction>? Encryption { get; set; }
            /// <summary>
            /// HlsManifests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-cmafpackage.html#cfn-mediapackage-originendpoint-cmafpackage-hlsmanifests
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HlsManifest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaPackage.OriginEndpointTypes.HlsManifest>, IReadOnlyList<Union<Humidifier.MediaPackage.OriginEndpointTypes.HlsManifest, BaseFunction>>, BaseFunction>? HlsManifests { get; set; }
        }

        public class DashEncryption : Humidifier.Base.BaseSubResource, IHaveKeyRotationIntervalSeconds_Integer, IHaveMediaPackageOriginEndpointTypesSpekeKeyProviderSpekeKeyProvider
        {
            /// <summary>
            /// KeyRotationIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashencryption.html#cfn-mediapackage-originendpoint-dashencryption-keyrotationintervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? KeyRotationIntervalSeconds { get; set; }
            /// <summary>
            /// SpekeKeyProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashencryption.html#cfn-mediapackage-originendpoint-dashencryption-spekekeyprovider
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SpekeKeyProvider
            /// </summary>
            public Union<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider, BaseFunction>? SpekeKeyProvider { get; set; }
        }

        public class DashPackage : Humidifier.Base.BaseSubResource, IHaveManifestWindowSeconds_Integer, IHaveAdsOnDeliveryRestrictions, IHaveManifestLayout, IHaveMediaPackageOriginEndpointTypesStreamSelectionStreamSelection, IHaveIncludeIframeOnlyStream_Boolean, IHaveSegmentTemplateFormat, IHaveMediaPackageOriginEndpointTypesDashEncryptionEncryption, IHaveStringListOfAdTriggers, IHaveProfile, IHaveStringListOfPeriodTriggers, IHaveSuggestedPresentationDelaySeconds_Integer, IHaveUtcTiming, IHaveMinBufferTimeSeconds_Integer, IHaveSegmentDurationSeconds_Integer, IHaveMinUpdatePeriodSeconds_Integer, IHaveUtcTimingUri
        {
            /// <summary>
            /// ManifestWindowSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashpackage.html#cfn-mediapackage-originendpoint-dashpackage-manifestwindowseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ManifestWindowSeconds { get; set; }
            /// <summary>
            /// AdsOnDeliveryRestrictions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashpackage.html#cfn-mediapackage-originendpoint-dashpackage-adsondeliveryrestrictions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdsOnDeliveryRestrictions { get; set; }
            /// <summary>
            /// ManifestLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashpackage.html#cfn-mediapackage-originendpoint-dashpackage-manifestlayout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestLayout { get; set; }
            /// <summary>
            /// StreamSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashpackage.html#cfn-mediapackage-originendpoint-dashpackage-streamselection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StreamSelection
            /// </summary>
            public Union<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection, BaseFunction>? StreamSelection { get; set; }
            /// <summary>
            /// IncludeIframeOnlyStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashpackage.html#cfn-mediapackage-originendpoint-dashpackage-includeiframeonlystream
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeIframeOnlyStream { get; set; }
            /// <summary>
            /// SegmentTemplateFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashpackage.html#cfn-mediapackage-originendpoint-dashpackage-segmenttemplateformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentTemplateFormat { get; set; }
            /// <summary>
            /// Encryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashpackage.html#cfn-mediapackage-originendpoint-dashpackage-encryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashEncryption
            /// </summary>
            public Union<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption, BaseFunction>? Encryption { get; set; }
            /// <summary>
            /// AdTriggers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashpackage.html#cfn-mediapackage-originendpoint-dashpackage-adtriggers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdTriggers { get; set; }
            /// <summary>
            /// Profile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashpackage.html#cfn-mediapackage-originendpoint-dashpackage-profile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Profile { get; set; }
            /// <summary>
            /// PeriodTriggers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashpackage.html#cfn-mediapackage-originendpoint-dashpackage-periodtriggers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PeriodTriggers { get; set; }
            /// <summary>
            /// SuggestedPresentationDelaySeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashpackage.html#cfn-mediapackage-originendpoint-dashpackage-suggestedpresentationdelayseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SuggestedPresentationDelaySeconds { get; set; }
            /// <summary>
            /// UtcTiming
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashpackage.html#cfn-mediapackage-originendpoint-dashpackage-utctiming
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UtcTiming { get; set; }
            /// <summary>
            /// MinBufferTimeSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashpackage.html#cfn-mediapackage-originendpoint-dashpackage-minbuffertimeseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinBufferTimeSeconds { get; set; }
            /// <summary>
            /// SegmentDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashpackage.html#cfn-mediapackage-originendpoint-dashpackage-segmentdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentDurationSeconds { get; set; }
            /// <summary>
            /// MinUpdatePeriodSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashpackage.html#cfn-mediapackage-originendpoint-dashpackage-minupdateperiodseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinUpdatePeriodSeconds { get; set; }
            /// <summary>
            /// UtcTimingUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashpackage.html#cfn-mediapackage-originendpoint-dashpackage-utctiminguri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UtcTimingUri { get; set; }
        }

        public class EncryptionContractConfiguration : Humidifier.Base.BaseSubResource
        {
        }

        public class HlsEncryption : Humidifier.Base.BaseSubResource, IHaveKeyRotationIntervalSeconds_Integer, IHaveRepeatExtXKey_Boolean, IHaveConstantInitializationVector, IHaveMediaPackageOriginEndpointTypesSpekeKeyProviderSpekeKeyProvider, IHaveEncryptionMethod
        {
            /// <summary>
            /// KeyRotationIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlsencryption.html#cfn-mediapackage-originendpoint-hlsencryption-keyrotationintervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? KeyRotationIntervalSeconds { get; set; }
            /// <summary>
            /// RepeatExtXKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlsencryption.html#cfn-mediapackage-originendpoint-hlsencryption-repeatextxkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RepeatExtXKey { get; set; }
            /// <summary>
            /// ConstantInitializationVector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlsencryption.html#cfn-mediapackage-originendpoint-hlsencryption-constantinitializationvector
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConstantInitializationVector { get; set; }
            /// <summary>
            /// SpekeKeyProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlsencryption.html#cfn-mediapackage-originendpoint-hlsencryption-spekekeyprovider
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SpekeKeyProvider
            /// </summary>
            public Union<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider, BaseFunction>? SpekeKeyProvider { get; set; }
            /// <summary>
            /// EncryptionMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlsencryption.html#cfn-mediapackage-originendpoint-hlsencryption-encryptionmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionMethod { get; set; }
        }

        public class HlsManifest : Humidifier.Base.BaseSubResource, IHaveAdsOnDeliveryRestrictions, IHaveManifestName, IHaveAdMarkers, IHaveProgramDateTimeIntervalSeconds_Integer, IHavePlaylistWindowSeconds_Integer, IHaveIncludeIframeOnlyStream_Boolean, IHaveId, IHavePlaylistType, IHaveStringListOfAdTriggers, IHaveUrl
        {
            /// <summary>
            /// AdsOnDeliveryRestrictions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlsmanifest.html#cfn-mediapackage-originendpoint-hlsmanifest-adsondeliveryrestrictions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdsOnDeliveryRestrictions { get; set; }
            /// <summary>
            /// ManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlsmanifest.html#cfn-mediapackage-originendpoint-hlsmanifest-manifestname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestName { get; set; }
            /// <summary>
            /// AdMarkers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlsmanifest.html#cfn-mediapackage-originendpoint-hlsmanifest-admarkers
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdMarkers { get; set; }
            /// <summary>
            /// ProgramDateTimeIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlsmanifest.html#cfn-mediapackage-originendpoint-hlsmanifest-programdatetimeintervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProgramDateTimeIntervalSeconds { get; set; }
            /// <summary>
            /// PlaylistWindowSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlsmanifest.html#cfn-mediapackage-originendpoint-hlsmanifest-playlistwindowseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PlaylistWindowSeconds { get; set; }
            /// <summary>
            /// IncludeIframeOnlyStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlsmanifest.html#cfn-mediapackage-originendpoint-hlsmanifest-includeiframeonlystream
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeIframeOnlyStream { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlsmanifest.html#cfn-mediapackage-originendpoint-hlsmanifest-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// PlaylistType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlsmanifest.html#cfn-mediapackage-originendpoint-hlsmanifest-playlisttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PlaylistType { get; set; }
            /// <summary>
            /// AdTriggers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlsmanifest.html#cfn-mediapackage-originendpoint-hlsmanifest-adtriggers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdTriggers { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlsmanifest.html#cfn-mediapackage-originendpoint-hlsmanifest-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class HlsPackage : Humidifier.Base.BaseSubResource, IHaveAdsOnDeliveryRestrictions, IHaveAdMarkers, IHaveProgramDateTimeIntervalSeconds_Integer, IHaveMediaPackageOriginEndpointTypesStreamSelectionStreamSelection, IHavePlaylistWindowSeconds_Integer, IHaveIncludeIframeOnlyStream_Boolean, IHaveUseAudioRenditionGroup_Boolean, IHaveSegmentDurationSeconds_Integer, IHaveMediaPackageOriginEndpointTypesHlsEncryptionEncryption, IHavePlaylistType, IHaveStringListOfAdTriggers, IHaveIncludeDvbSubtitles_Boolean
        {
            /// <summary>
            /// AdsOnDeliveryRestrictions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlspackage.html#cfn-mediapackage-originendpoint-hlspackage-adsondeliveryrestrictions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdsOnDeliveryRestrictions { get; set; }
            /// <summary>
            /// AdMarkers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlspackage.html#cfn-mediapackage-originendpoint-hlspackage-admarkers
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdMarkers { get; set; }
            /// <summary>
            /// ProgramDateTimeIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlspackage.html#cfn-mediapackage-originendpoint-hlspackage-programdatetimeintervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProgramDateTimeIntervalSeconds { get; set; }
            /// <summary>
            /// StreamSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlspackage.html#cfn-mediapackage-originendpoint-hlspackage-streamselection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StreamSelection
            /// </summary>
            public Union<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection, BaseFunction>? StreamSelection { get; set; }
            /// <summary>
            /// PlaylistWindowSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlspackage.html#cfn-mediapackage-originendpoint-hlspackage-playlistwindowseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PlaylistWindowSeconds { get; set; }
            /// <summary>
            /// IncludeIframeOnlyStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlspackage.html#cfn-mediapackage-originendpoint-hlspackage-includeiframeonlystream
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeIframeOnlyStream { get; set; }
            /// <summary>
            /// UseAudioRenditionGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlspackage.html#cfn-mediapackage-originendpoint-hlspackage-useaudiorenditiongroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseAudioRenditionGroup { get; set; }
            /// <summary>
            /// SegmentDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlspackage.html#cfn-mediapackage-originendpoint-hlspackage-segmentdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentDurationSeconds { get; set; }
            /// <summary>
            /// Encryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlspackage.html#cfn-mediapackage-originendpoint-hlspackage-encryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsEncryption
            /// </summary>
            public Union<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption, BaseFunction>? Encryption { get; set; }
            /// <summary>
            /// PlaylistType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlspackage.html#cfn-mediapackage-originendpoint-hlspackage-playlisttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PlaylistType { get; set; }
            /// <summary>
            /// AdTriggers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlspackage.html#cfn-mediapackage-originendpoint-hlspackage-adtriggers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdTriggers { get; set; }
            /// <summary>
            /// IncludeDvbSubtitles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlspackage.html#cfn-mediapackage-originendpoint-hlspackage-includedvbsubtitles
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeDvbSubtitles { get; set; }
        }

        public class MssEncryption : Humidifier.Base.BaseSubResource, IHaveMediaPackageOriginEndpointTypesSpekeKeyProviderSpekeKeyProvider
        {
            /// <summary>
            /// SpekeKeyProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-mssencryption.html#cfn-mediapackage-originendpoint-mssencryption-spekekeyprovider
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SpekeKeyProvider
            /// </summary>
            public Union<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider, BaseFunction>? SpekeKeyProvider { get; set; }
        }

        public class MssPackage : Humidifier.Base.BaseSubResource, IHaveManifestWindowSeconds_Integer, IHaveMediaPackageOriginEndpointTypesStreamSelectionStreamSelection, IHaveSegmentDurationSeconds_Integer, IHaveMediaPackageOriginEndpointTypesMssEncryptionEncryption
        {
            /// <summary>
            /// ManifestWindowSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-msspackage.html#cfn-mediapackage-originendpoint-msspackage-manifestwindowseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ManifestWindowSeconds { get; set; }
            /// <summary>
            /// StreamSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-msspackage.html#cfn-mediapackage-originendpoint-msspackage-streamselection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StreamSelection
            /// </summary>
            public Union<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection, BaseFunction>? StreamSelection { get; set; }
            /// <summary>
            /// SegmentDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-msspackage.html#cfn-mediapackage-originendpoint-msspackage-segmentdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentDurationSeconds { get; set; }
            /// <summary>
            /// Encryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-msspackage.html#cfn-mediapackage-originendpoint-msspackage-encryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MssEncryption
            /// </summary>
            public Union<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption, BaseFunction>? Encryption { get; set; }
        }

        public class SpekeKeyProvider : Humidifier.Base.BaseSubResource, IHaveMediaPackageOriginEndpointTypesEncryptionContractConfigurationEncryptionContractConfiguration, IHaveResourceId, IHaveUrl, IHaveRoleArn, IHaveStringListOfSystemIds, IHaveCertificateArn
        {
            /// <summary>
            /// EncryptionContractConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-spekekeyprovider.html#cfn-mediapackage-originendpoint-spekekeyprovider-encryptioncontractconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EncryptionContractConfiguration
            /// </summary>
            public Union<Humidifier.MediaPackage.OriginEndpointTypes.EncryptionContractConfiguration, BaseFunction>? EncryptionContractConfiguration { get; set; }
            /// <summary>
            /// ResourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-spekekeyprovider.html#cfn-mediapackage-originendpoint-spekekeyprovider-resourceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceId { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-spekekeyprovider.html#cfn-mediapackage-originendpoint-spekekeyprovider-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-spekekeyprovider.html#cfn-mediapackage-originendpoint-spekekeyprovider-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// SystemIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-spekekeyprovider.html#cfn-mediapackage-originendpoint-spekekeyprovider-systemids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SystemIds { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-spekekeyprovider.html#cfn-mediapackage-originendpoint-spekekeyprovider-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class StreamSelection : Humidifier.Base.BaseSubResource, IHaveMaxVideoBitsPerSecond_Integer, IHaveMinVideoBitsPerSecond_Integer, IHaveStreamOrder
        {
            /// <summary>
            /// MaxVideoBitsPerSecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-streamselection.html#cfn-mediapackage-originendpoint-streamselection-maxvideobitspersecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxVideoBitsPerSecond { get; set; }
            /// <summary>
            /// MinVideoBitsPerSecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-streamselection.html#cfn-mediapackage-originendpoint-streamselection-minvideobitspersecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinVideoBitsPerSecond { get; set; }
            /// <summary>
            /// StreamOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-streamselection.html#cfn-mediapackage-originendpoint-streamselection-streamorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamOrder { get; set; }
        }
    }
}