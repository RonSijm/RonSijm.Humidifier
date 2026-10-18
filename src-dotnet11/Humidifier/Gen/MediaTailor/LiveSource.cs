namespace Humidifier.MediaTailor
{
    using global::System.Collections.Generic;
    using LiveSourceTypes;

    public class LiveSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveLiveSourceName, IHaveSourceLocationName, IHaveListOfMediaTailorLiveSourceTypesHttpPackageConfigurationHttpPackageConfigurations
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaTailor.LiveSource; }
        public Union<string, BaseFunction>? LiveSourceName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// SourceLocationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-livesource.html#cfn-mediatailor-livesource-sourcelocationname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SourceLocationName { get; set; }

        /// <summary>
        /// HttpPackageConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-livesource.html#cfn-mediatailor-livesource-httppackageconfigurations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HttpPackageConfiguration
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration>, IReadOnlyList<Union<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration, BaseFunction>>, BaseFunction>? HttpPackageConfigurations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-livesource.html#cfn-mediatailor-livesource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace LiveSourceTypes
    {
        public class HttpPackageConfiguration : Humidifier.Base.BaseSubResource, IHavePath, IHaveType, IHaveSourceGroup
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-livesource-httppackageconfiguration.html#cfn-mediatailor-livesource-httppackageconfiguration-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-livesource-httppackageconfiguration.html#cfn-mediatailor-livesource-httppackageconfiguration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// SourceGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-livesource-httppackageconfiguration.html#cfn-mediatailor-livesource-httppackageconfiguration-sourcegroup
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceGroup { get; set; }
        }
    }
}