namespace Humidifier.MediaTailor
{
    using global::System.Collections.Generic;
    using VodSourceTypes;

    public class VodSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveVodSourceName, IHaveSourceLocationName, IHaveListOfMediaTailorVodSourceTypesHttpPackageConfigurationHttpPackageConfigurations
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaTailor.VodSource; }
        public Union<string, BaseFunction>? VodSourceName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// SourceLocationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-vodsource.html#cfn-mediatailor-vodsource-sourcelocationname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SourceLocationName { get; set; }

        /// <summary>
        /// HttpPackageConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-vodsource.html#cfn-mediatailor-vodsource-httppackageconfigurations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HttpPackageConfiguration
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration>, IReadOnlyList<Union<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration, BaseFunction>>, BaseFunction>? HttpPackageConfigurations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-vodsource.html#cfn-mediatailor-vodsource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace VodSourceTypes
    {
        public class HttpPackageConfiguration : Humidifier.Base.BaseSubResource, IHavePath, IHaveType, IHaveSourceGroup
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-vodsource-httppackageconfiguration.html#cfn-mediatailor-vodsource-httppackageconfiguration-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-vodsource-httppackageconfiguration.html#cfn-mediatailor-vodsource-httppackageconfiguration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// SourceGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-vodsource-httppackageconfiguration.html#cfn-mediatailor-vodsource-httppackageconfiguration-sourcegroup
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceGroup { get; set; }
        }
    }
}