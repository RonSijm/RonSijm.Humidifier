namespace Humidifier.MediaPackage
{
    using global::System.Collections.Generic;
    using PackagingConfigurationTypes;

    public class PackagingConfiguration : Humidifier.Base.BaseResource, IHaveTags, IHaveMediaPackagePackagingConfigurationTypesMssPackageMssPackage, IHaveMediaPackagePackagingConfigurationTypesCmafPackageCmafPackage, IHaveId, IHaveMediaPackagePackagingConfigurationTypesHlsPackageHlsPackage, IHavePackagingGroupId, IHaveMediaPackagePackagingConfigurationTypesDashPackageDashPackage
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaPackage.PackagingConfiguration; }
        /// <summary>
        /// MssPackage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-packagingconfiguration.html#cfn-mediapackage-packagingconfiguration-msspackage
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MssPackage
        /// </summary>
        public Union<Humidifier.MediaPackage.PackagingConfigurationTypes.MssPackage, BaseFunction>? MssPackage { get; set; }
        /// <summary>
        /// CmafPackage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-packagingconfiguration.html#cfn-mediapackage-packagingconfiguration-cmafpackage
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CmafPackage
        /// </summary>
        public Union<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafPackage, BaseFunction>? CmafPackage { get; set; }

        /// <summary>
        /// Id
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-packagingconfiguration.html#cfn-mediapackage-packagingconfiguration-id
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Id { get; set; }
        /// <summary>
        /// HlsPackage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-packagingconfiguration.html#cfn-mediapackage-packagingconfiguration-hlspackage
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HlsPackage
        /// </summary>
        public Union<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsPackage, BaseFunction>? HlsPackage { get; set; }

        /// <summary>
        /// PackagingGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-packagingconfiguration.html#cfn-mediapackage-packagingconfiguration-packaginggroupid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PackagingGroupId { get; set; }
        /// <summary>
        /// DashPackage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-packagingconfiguration.html#cfn-mediapackage-packagingconfiguration-dashpackage
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DashPackage
        /// </summary>
        public Union<Humidifier.MediaPackage.PackagingConfigurationTypes.DashPackage, BaseFunction>? DashPackage { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-packagingconfiguration.html#cfn-mediapackage-packagingconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PackagingConfigurationTypes
    {
        public class CmafEncryption : Humidifier.Base.BaseSubResource, IHaveMediaPackagePackagingConfigurationTypesSpekeKeyProviderSpekeKeyProvider
        {
            /// <summary>
            /// SpekeKeyProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-cmafencryption.html#cfn-mediapackage-packagingconfiguration-cmafencryption-spekekeyprovider
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SpekeKeyProvider
            /// </summary>
            public Union<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider, BaseFunction>? SpekeKeyProvider { get; set; }
        }

        public class CmafPackage : Humidifier.Base.BaseSubResource, IHaveSegmentDurationSeconds_Integer, IHaveMediaPackagePackagingConfigurationTypesCmafEncryptionEncryption, IHaveListOfMediaPackagePackagingConfigurationTypesHlsManifestHlsManifests, IHaveIncludeEncoderConfigurationInSegments_Boolean
        {
            /// <summary>
            /// SegmentDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-cmafpackage.html#cfn-mediapackage-packagingconfiguration-cmafpackage-segmentdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentDurationSeconds { get; set; }
            /// <summary>
            /// Encryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-cmafpackage.html#cfn-mediapackage-packagingconfiguration-cmafpackage-encryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CmafEncryption
            /// </summary>
            public Union<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption, BaseFunction>? Encryption { get; set; }
            /// <summary>
            /// HlsManifests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-cmafpackage.html#cfn-mediapackage-packagingconfiguration-cmafpackage-hlsmanifests
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HlsManifest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsManifest>, IReadOnlyList<Union<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsManifest, BaseFunction>>, BaseFunction>? HlsManifests { get; set; }
            /// <summary>
            /// IncludeEncoderConfigurationInSegments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-cmafpackage.html#cfn-mediapackage-packagingconfiguration-cmafpackage-includeencoderconfigurationinsegments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeEncoderConfigurationInSegments { get; set; }
        }

        public class DashEncryption : Humidifier.Base.BaseSubResource, IHaveMediaPackagePackagingConfigurationTypesSpekeKeyProviderSpekeKeyProvider
        {
            /// <summary>
            /// SpekeKeyProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-dashencryption.html#cfn-mediapackage-packagingconfiguration-dashencryption-spekekeyprovider
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SpekeKeyProvider
            /// </summary>
            public Union<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider, BaseFunction>? SpekeKeyProvider { get; set; }
        }

        public class DashManifest : Humidifier.Base.BaseSubResource, IHaveScteMarkersSource, IHaveManifestName, IHaveManifestLayout, IHaveMediaPackagePackagingConfigurationTypesStreamSelectionStreamSelection, IHaveMinBufferTimeSeconds_Integer, IHaveProfile
        {
            /// <summary>
            /// ScteMarkersSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-dashmanifest.html#cfn-mediapackage-packagingconfiguration-dashmanifest-sctemarkerssource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScteMarkersSource { get; set; }
            /// <summary>
            /// ManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-dashmanifest.html#cfn-mediapackage-packagingconfiguration-dashmanifest-manifestname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestName { get; set; }
            /// <summary>
            /// ManifestLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-dashmanifest.html#cfn-mediapackage-packagingconfiguration-dashmanifest-manifestlayout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestLayout { get; set; }
            /// <summary>
            /// StreamSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-dashmanifest.html#cfn-mediapackage-packagingconfiguration-dashmanifest-streamselection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StreamSelection
            /// </summary>
            public Union<Humidifier.MediaPackage.PackagingConfigurationTypes.StreamSelection, BaseFunction>? StreamSelection { get; set; }
            /// <summary>
            /// MinBufferTimeSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-dashmanifest.html#cfn-mediapackage-packagingconfiguration-dashmanifest-minbuffertimeseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinBufferTimeSeconds { get; set; }
            /// <summary>
            /// Profile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-dashmanifest.html#cfn-mediapackage-packagingconfiguration-dashmanifest-profile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Profile { get; set; }
        }

        public class DashPackage : Humidifier.Base.BaseSubResource, IHaveStringListOfPeriodTriggers, IHaveIncludeIframeOnlyStream_Boolean, IHaveSegmentDurationSeconds_Integer, IHaveMediaPackagePackagingConfigurationTypesDashEncryptionEncryption, IHaveSegmentTemplateFormat, IHaveIncludeEncoderConfigurationInSegments_Boolean, IHaveListOfMediaPackagePackagingConfigurationTypesDashManifestDashManifests
        {
            /// <summary>
            /// PeriodTriggers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-dashpackage.html#cfn-mediapackage-packagingconfiguration-dashpackage-periodtriggers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PeriodTriggers { get; set; }
            /// <summary>
            /// IncludeIframeOnlyStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-dashpackage.html#cfn-mediapackage-packagingconfiguration-dashpackage-includeiframeonlystream
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeIframeOnlyStream { get; set; }
            /// <summary>
            /// SegmentDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-dashpackage.html#cfn-mediapackage-packagingconfiguration-dashpackage-segmentdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentDurationSeconds { get; set; }
            /// <summary>
            /// Encryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-dashpackage.html#cfn-mediapackage-packagingconfiguration-dashpackage-encryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashEncryption
            /// </summary>
            public Union<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption, BaseFunction>? Encryption { get; set; }
            /// <summary>
            /// SegmentTemplateFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-dashpackage.html#cfn-mediapackage-packagingconfiguration-dashpackage-segmenttemplateformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentTemplateFormat { get; set; }
            /// <summary>
            /// IncludeEncoderConfigurationInSegments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-dashpackage.html#cfn-mediapackage-packagingconfiguration-dashpackage-includeencoderconfigurationinsegments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeEncoderConfigurationInSegments { get; set; }
            /// <summary>
            /// DashManifests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-dashpackage.html#cfn-mediapackage-packagingconfiguration-dashpackage-dashmanifests
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DashManifest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaPackage.PackagingConfigurationTypes.DashManifest>, IReadOnlyList<Union<Humidifier.MediaPackage.PackagingConfigurationTypes.DashManifest, BaseFunction>>, BaseFunction>? DashManifests { get; set; }
        }

        public class EncryptionContractConfiguration : Humidifier.Base.BaseSubResource, IHavePresetSpeke20Audio, IHavePresetSpeke20Video
        {
            /// <summary>
            /// PresetSpeke20Audio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-encryptioncontractconfiguration.html#cfn-mediapackage-packagingconfiguration-encryptioncontractconfiguration-presetspeke20audio
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PresetSpeke20Audio { get; set; }
            /// <summary>
            /// PresetSpeke20Video
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-encryptioncontractconfiguration.html#cfn-mediapackage-packagingconfiguration-encryptioncontractconfiguration-presetspeke20video
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PresetSpeke20Video { get; set; }
        }

        public class HlsEncryption : Humidifier.Base.BaseSubResource, IHaveConstantInitializationVector, IHaveMediaPackagePackagingConfigurationTypesSpekeKeyProviderSpekeKeyProvider, IHaveEncryptionMethod
        {
            /// <summary>
            /// ConstantInitializationVector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-hlsencryption.html#cfn-mediapackage-packagingconfiguration-hlsencryption-constantinitializationvector
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConstantInitializationVector { get; set; }
            /// <summary>
            /// SpekeKeyProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-hlsencryption.html#cfn-mediapackage-packagingconfiguration-hlsencryption-spekekeyprovider
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SpekeKeyProvider
            /// </summary>
            public Union<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider, BaseFunction>? SpekeKeyProvider { get; set; }
            /// <summary>
            /// EncryptionMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-hlsencryption.html#cfn-mediapackage-packagingconfiguration-hlsencryption-encryptionmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionMethod { get; set; }
        }

        public class HlsManifest : Humidifier.Base.BaseSubResource, IHaveIncludeIframeOnlyStream_Boolean, IHaveAdMarkers, IHaveManifestName, IHaveProgramDateTimeIntervalSeconds_Integer, IHaveMediaPackagePackagingConfigurationTypesStreamSelectionStreamSelection, IHaveRepeatExtXKey_Boolean
        {
            /// <summary>
            /// IncludeIframeOnlyStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-hlsmanifest.html#cfn-mediapackage-packagingconfiguration-hlsmanifest-includeiframeonlystream
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeIframeOnlyStream { get; set; }
            /// <summary>
            /// AdMarkers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-hlsmanifest.html#cfn-mediapackage-packagingconfiguration-hlsmanifest-admarkers
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdMarkers { get; set; }
            /// <summary>
            /// ManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-hlsmanifest.html#cfn-mediapackage-packagingconfiguration-hlsmanifest-manifestname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestName { get; set; }
            /// <summary>
            /// ProgramDateTimeIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-hlsmanifest.html#cfn-mediapackage-packagingconfiguration-hlsmanifest-programdatetimeintervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProgramDateTimeIntervalSeconds { get; set; }
            /// <summary>
            /// StreamSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-hlsmanifest.html#cfn-mediapackage-packagingconfiguration-hlsmanifest-streamselection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StreamSelection
            /// </summary>
            public Union<Humidifier.MediaPackage.PackagingConfigurationTypes.StreamSelection, BaseFunction>? StreamSelection { get; set; }
            /// <summary>
            /// RepeatExtXKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-hlsmanifest.html#cfn-mediapackage-packagingconfiguration-hlsmanifest-repeatextxkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RepeatExtXKey { get; set; }
        }

        public class HlsPackage : Humidifier.Base.BaseSubResource, IHaveUseAudioRenditionGroup_Boolean, IHaveSegmentDurationSeconds_Integer, IHaveMediaPackagePackagingConfigurationTypesHlsEncryptionEncryption, IHaveListOfMediaPackagePackagingConfigurationTypesHlsManifestHlsManifests, IHaveIncludeDvbSubtitles_Boolean
        {
            /// <summary>
            /// UseAudioRenditionGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-hlspackage.html#cfn-mediapackage-packagingconfiguration-hlspackage-useaudiorenditiongroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseAudioRenditionGroup { get; set; }
            /// <summary>
            /// SegmentDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-hlspackage.html#cfn-mediapackage-packagingconfiguration-hlspackage-segmentdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentDurationSeconds { get; set; }
            /// <summary>
            /// Encryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-hlspackage.html#cfn-mediapackage-packagingconfiguration-hlspackage-encryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsEncryption
            /// </summary>
            public Union<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption, BaseFunction>? Encryption { get; set; }
            /// <summary>
            /// HlsManifests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-hlspackage.html#cfn-mediapackage-packagingconfiguration-hlspackage-hlsmanifests
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HlsManifest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsManifest>, IReadOnlyList<Union<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsManifest, BaseFunction>>, BaseFunction>? HlsManifests { get; set; }
            /// <summary>
            /// IncludeDvbSubtitles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-hlspackage.html#cfn-mediapackage-packagingconfiguration-hlspackage-includedvbsubtitles
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeDvbSubtitles { get; set; }
        }

        public class MssEncryption : Humidifier.Base.BaseSubResource, IHaveMediaPackagePackagingConfigurationTypesSpekeKeyProviderSpekeKeyProvider
        {
            /// <summary>
            /// SpekeKeyProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-mssencryption.html#cfn-mediapackage-packagingconfiguration-mssencryption-spekekeyprovider
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SpekeKeyProvider
            /// </summary>
            public Union<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider, BaseFunction>? SpekeKeyProvider { get; set; }
        }

        public class MssManifest : Humidifier.Base.BaseSubResource, IHaveManifestName, IHaveMediaPackagePackagingConfigurationTypesStreamSelectionStreamSelection
        {
            /// <summary>
            /// ManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-mssmanifest.html#cfn-mediapackage-packagingconfiguration-mssmanifest-manifestname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestName { get; set; }
            /// <summary>
            /// StreamSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-mssmanifest.html#cfn-mediapackage-packagingconfiguration-mssmanifest-streamselection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StreamSelection
            /// </summary>
            public Union<Humidifier.MediaPackage.PackagingConfigurationTypes.StreamSelection, BaseFunction>? StreamSelection { get; set; }
        }

        public class MssPackage : Humidifier.Base.BaseSubResource, IHaveListOfMediaPackagePackagingConfigurationTypesMssManifestMssManifests, IHaveSegmentDurationSeconds_Integer, IHaveMediaPackagePackagingConfigurationTypesMssEncryptionEncryption
        {
            /// <summary>
            /// MssManifests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-msspackage.html#cfn-mediapackage-packagingconfiguration-msspackage-mssmanifests
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MssManifest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaPackage.PackagingConfigurationTypes.MssManifest>, IReadOnlyList<Union<Humidifier.MediaPackage.PackagingConfigurationTypes.MssManifest, BaseFunction>>, BaseFunction>? MssManifests { get; set; }
            /// <summary>
            /// SegmentDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-msspackage.html#cfn-mediapackage-packagingconfiguration-msspackage-segmentdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentDurationSeconds { get; set; }
            /// <summary>
            /// Encryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-msspackage.html#cfn-mediapackage-packagingconfiguration-msspackage-encryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MssEncryption
            /// </summary>
            public Union<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption, BaseFunction>? Encryption { get; set; }
        }

        public class SpekeKeyProvider : Humidifier.Base.BaseSubResource, IHaveMediaPackagePackagingConfigurationTypesEncryptionContractConfigurationEncryptionContractConfiguration, IHaveRoleArn, IHaveUrl, IHaveStringListOfSystemIds
        {
            /// <summary>
            /// EncryptionContractConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-spekekeyprovider.html#cfn-mediapackage-packagingconfiguration-spekekeyprovider-encryptioncontractconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EncryptionContractConfiguration
            /// </summary>
            public Union<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration, BaseFunction>? EncryptionContractConfiguration { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-spekekeyprovider.html#cfn-mediapackage-packagingconfiguration-spekekeyprovider-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-spekekeyprovider.html#cfn-mediapackage-packagingconfiguration-spekekeyprovider-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
            /// <summary>
            /// SystemIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-spekekeyprovider.html#cfn-mediapackage-packagingconfiguration-spekekeyprovider-systemids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SystemIds { get; set; }
        }

        public class StreamSelection : Humidifier.Base.BaseSubResource, IHaveMaxVideoBitsPerSecond_Integer, IHaveMinVideoBitsPerSecond_Integer, IHaveStreamOrder
        {
            /// <summary>
            /// MaxVideoBitsPerSecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-streamselection.html#cfn-mediapackage-packagingconfiguration-streamselection-maxvideobitspersecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxVideoBitsPerSecond { get; set; }
            /// <summary>
            /// MinVideoBitsPerSecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-streamselection.html#cfn-mediapackage-packagingconfiguration-streamselection-minvideobitspersecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinVideoBitsPerSecond { get; set; }
            /// <summary>
            /// StreamOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-streamselection.html#cfn-mediapackage-packagingconfiguration-streamselection-streamorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamOrder { get; set; }
        }
    }
}