namespace Humidifier.ElementalInference
{
    using global::System.Collections.Generic;
    using FeedTypes;

    public class Feed : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName
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
        public dynamic AccessRoleArn { get; set; }

        /// <summary>
        /// Outputs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elementalinference-feed.html#cfn-elementalinference-feed-outputs
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GetOutput
        /// </summary>
        [Required]
        public List<Humidifier.ElementalInference.FeedTypes.GetOutput> Outputs { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elementalinference-feed.html#cfn-elementalinference-feed-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace FeedTypes
    {
        public class AspectRatio : Humidifier.Base.BaseSubResource, IHaveHeight, IHaveWidth
        {
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-aspectratio.html#cfn-elementalinference-feed-aspectratio-height
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Height { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-aspectratio.html#cfn-elementalinference-feed-aspectratio-width
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Width { get; set; }
        }

        public class ClippingConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DataSourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-clippingconfig.html#cfn-elementalinference-feed-clippingconfig-datasourceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSourceConfiguration
            /// </summary>
            public Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration DataSourceConfiguration { get; set; }
            /// <summary>
            /// CallbackMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-clippingconfig.html#cfn-elementalinference-feed-clippingconfig-callbackmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CallbackMetadata { get; set; }
        }

        public class CroppingConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TemplateGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-croppingconfig.html#cfn-elementalinference-feed-croppingconfig-templategroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TemplateGroup
            /// </summary>
            public List<Humidifier.ElementalInference.FeedTypes.TemplateGroup> TemplateGroups { get; set; }
        }

        public class DataSourceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FixtureId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-datasourceconfiguration.html#cfn-elementalinference-feed-datasourceconfiguration-fixtureid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FixtureId { get; set; }
        }

        public class GetOutput : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-getoutput.html#cfn-elementalinference-feed-getoutput-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// OutputConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-getoutput.html#cfn-elementalinference-feed-getoutput-outputconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OutputConfig
            /// </summary>
            public Humidifier.ElementalInference.FeedTypes.OutputConfig OutputConfig { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-getoutput.html#cfn-elementalinference-feed-getoutput-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-getoutput.html#cfn-elementalinference-feed-getoutput-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class OutputConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Clipping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-outputconfig.html#cfn-elementalinference-feed-outputconfig-clipping
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClippingConfig
            /// </summary>
            public Humidifier.ElementalInference.FeedTypes.ClippingConfig Clipping { get; set; }
            /// <summary>
            /// Subtitling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-outputconfig.html#cfn-elementalinference-feed-outputconfig-subtitling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubtitlingConfig
            /// </summary>
            public Humidifier.ElementalInference.FeedTypes.SubtitlingConfig Subtitling { get; set; }
            /// <summary>
            /// Cropping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-outputconfig.html#cfn-elementalinference-feed-outputconfig-cropping
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CroppingConfig
            /// </summary>
            public Humidifier.ElementalInference.FeedTypes.CroppingConfig Cropping { get; set; }
        }

        public class SubtitlingConfig : Humidifier.Base.BaseSubResource, IHaveLanguage
        {
            /// <summary>
            /// AspectRatio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-subtitlingconfig.html#cfn-elementalinference-feed-subtitlingconfig-aspectratio
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AspectRatio
            /// </summary>
            public Humidifier.ElementalInference.FeedTypes.AspectRatio AspectRatio { get; set; }
            /// <summary>
            /// Dictionary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-subtitlingconfig.html#cfn-elementalinference-feed-subtitlingconfig-dictionary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Dictionary { get; set; }
            /// <summary>
            /// Language
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-subtitlingconfig.html#cfn-elementalinference-feed-subtitlingconfig-language
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Language { get; set; }
            /// <summary>
            /// ProfanityFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-subtitlingconfig.html#cfn-elementalinference-feed-subtitlingconfig-profanityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProfanityFilter { get; set; }
        }

        public class TemplateGroup : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// TemplateUris
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-templategroup.html#cfn-elementalinference-feed-templategroup-templateuris
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TemplateUris { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elementalinference-feed-templategroup.html#cfn-elementalinference-feed-templategroup-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}