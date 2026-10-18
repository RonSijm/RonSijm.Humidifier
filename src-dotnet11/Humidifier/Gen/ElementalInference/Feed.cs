namespace Humidifier.ElementalInference
{
    using global::System.Collections.Generic;
    using FeedTypes;

    public class Feed : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveAccessRoleArn, IHaveListOfElementalInferenceFeedTypesGetOutputOutputs, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string DataEndpoints =  "DataEndpoints" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ElementalInference.Feed; }
        /// <summary>
        /// AccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elementalinference-feed.html#cfn-elementalinference-feed-accessrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AccessRoleArn { get; set; }

        /// <summary>
        /// Outputs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elementalinference-feed.html#cfn-elementalinference-feed-outputs
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GetOutput
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.ElementalInference.FeedTypes.GetOutput>, IReadOnlyList<Union<Humidifier.ElementalInference.FeedTypes.GetOutput, BaseFunction>>, BaseFunction>? Outputs { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elementalinference-feed.html#cfn-elementalinference-feed-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace FeedTypes
    {
        public class AspectRatio : Humidifier.Base.BaseSubResource, IHaveHeight_Integer, IHaveWidth_Integer
        {
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-aspectratio.html#cfn-elementalinference-feed-aspectratio-height
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Height { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-aspectratio.html#cfn-elementalinference-feed-aspectratio-width
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Width { get; set; }
        }

        public class ClippingConfig : Humidifier.Base.BaseSubResource, IHaveElementalInferenceFeedTypesDataSourceConfigurationDataSourceConfiguration, IHaveCallbackMetadata
        {
            /// <summary>
            /// DataSourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-clippingconfig.html#cfn-elementalinference-feed-clippingconfig-datasourceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSourceConfiguration
            /// </summary>
            public Union<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration, BaseFunction>? DataSourceConfiguration { get; set; }
            /// <summary>
            /// CallbackMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-clippingconfig.html#cfn-elementalinference-feed-clippingconfig-callbackmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CallbackMetadata { get; set; }
        }

        public class CroppingConfig : Humidifier.Base.BaseSubResource, IHaveListOfElementalInferenceFeedTypesTemplateGroupTemplateGroups
        {
            /// <summary>
            /// TemplateGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-croppingconfig.html#cfn-elementalinference-feed-croppingconfig-templategroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TemplateGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ElementalInference.FeedTypes.TemplateGroup>, IReadOnlyList<Union<Humidifier.ElementalInference.FeedTypes.TemplateGroup, BaseFunction>>, BaseFunction>? TemplateGroups { get; set; }
        }

        public class DataSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveFixtureId
        {
            /// <summary>
            /// FixtureId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-datasourceconfiguration.html#cfn-elementalinference-feed-datasourceconfiguration-fixtureid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FixtureId { get; set; }
        }

        public class GetOutput : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveElementalInferenceFeedTypesOutputConfigOutputConfig, IHaveDescription, IHaveName
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-getoutput.html#cfn-elementalinference-feed-getoutput-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// OutputConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-getoutput.html#cfn-elementalinference-feed-getoutput-outputconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OutputConfig
            /// </summary>
            public Union<Humidifier.ElementalInference.FeedTypes.OutputConfig, BaseFunction>? OutputConfig { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-getoutput.html#cfn-elementalinference-feed-getoutput-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-getoutput.html#cfn-elementalinference-feed-getoutput-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class OutputConfig : Humidifier.Base.BaseSubResource, IHaveElementalInferenceFeedTypesClippingConfigClipping, IHaveElementalInferenceFeedTypesSubtitlingConfigSubtitling, IHaveElementalInferenceFeedTypesCroppingConfigCropping
        {
            /// <summary>
            /// Clipping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-outputconfig.html#cfn-elementalinference-feed-outputconfig-clipping
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClippingConfig
            /// </summary>
            public Union<Humidifier.ElementalInference.FeedTypes.ClippingConfig, BaseFunction>? Clipping { get; set; }
            /// <summary>
            /// Subtitling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-outputconfig.html#cfn-elementalinference-feed-outputconfig-subtitling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubtitlingConfig
            /// </summary>
            public Union<Humidifier.ElementalInference.FeedTypes.SubtitlingConfig, BaseFunction>? Subtitling { get; set; }
            /// <summary>
            /// Cropping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-outputconfig.html#cfn-elementalinference-feed-outputconfig-cropping
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CroppingConfig
            /// </summary>
            public Union<Humidifier.ElementalInference.FeedTypes.CroppingConfig, BaseFunction>? Cropping { get; set; }
        }

        public class SubtitlingConfig : Humidifier.Base.BaseSubResource, IHaveElementalInferenceFeedTypesAspectRatioAspectRatio, IHaveDictionary, IHaveLanguage, IHaveProfanityFilter
        {
            /// <summary>
            /// AspectRatio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-subtitlingconfig.html#cfn-elementalinference-feed-subtitlingconfig-aspectratio
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AspectRatio
            /// </summary>
            public Union<Humidifier.ElementalInference.FeedTypes.AspectRatio, BaseFunction>? AspectRatio { get; set; }
            /// <summary>
            /// Dictionary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-subtitlingconfig.html#cfn-elementalinference-feed-subtitlingconfig-dictionary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Dictionary { get; set; }
            /// <summary>
            /// Language
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-subtitlingconfig.html#cfn-elementalinference-feed-subtitlingconfig-language
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Language { get; set; }
            /// <summary>
            /// ProfanityFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-subtitlingconfig.html#cfn-elementalinference-feed-subtitlingconfig-profanityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProfanityFilter { get; set; }
        }

        public class TemplateGroup : Humidifier.Base.BaseSubResource, IHaveStringListOfTemplateUris, IHaveName
        {
            /// <summary>
            /// TemplateUris
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-templategroup.html#cfn-elementalinference-feed-templategroup-templateuris
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TemplateUris { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-templategroup.html#cfn-elementalinference-feed-templategroup-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}