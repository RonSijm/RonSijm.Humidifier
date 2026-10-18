namespace Humidifier.CodePipeline
{
    using global::System.Collections.Generic;
    using CustomActionTypeTypes;

    public class CustomActionType : Humidifier.Base.BaseResource, IHaveTags, IHaveCategory, IHaveCodePipelineCustomActionTypeTypesArtifactDetailsInputArtifactDetails, IHaveVersion, IHaveCodePipelineCustomActionTypeTypesArtifactDetailsOutputArtifactDetails, IHaveListOfCodePipelineCustomActionTypeTypesConfigurationPropertiesConfigurationProperties, IHaveCodePipelineCustomActionTypeTypesSettingsSettings, IHaveProvider
    {
        public override string AWSTypeName { get => AWS.CodePipeline.CustomActionType; }

        /// <summary>
        /// Category
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html#cfn-codepipeline-customactiontype-category
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Category { get; set; }

        /// <summary>
        /// InputArtifactDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html#cfn-codepipeline-customactiontype-inputartifactdetails
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ArtifactDetails
        /// </summary>
        [Required]
        public Union<Humidifier.CodePipeline.CustomActionTypeTypes.ArtifactDetails, BaseFunction>? InputArtifactDetails { get; set; }

        /// <summary>
        /// Version
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html#cfn-codepipeline-customactiontype-version
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Version { get; set; }

        /// <summary>
        /// OutputArtifactDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html#cfn-codepipeline-customactiontype-outputartifactdetails
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ArtifactDetails
        /// </summary>
        [Required]
        public Union<Humidifier.CodePipeline.CustomActionTypeTypes.ArtifactDetails, BaseFunction>? OutputArtifactDetails { get; set; }
        /// <summary>
        /// ConfigurationProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html#cfn-codepipeline-customactiontype-configurationproperties
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ConfigurationProperties
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CodePipeline.CustomActionTypeTypes.ConfigurationProperties>, IReadOnlyList<Union<Humidifier.CodePipeline.CustomActionTypeTypes.ConfigurationProperties, BaseFunction>>, BaseFunction>? ConfigurationProperties { get; set; }
        /// <summary>
        /// Settings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html#cfn-codepipeline-customactiontype-settings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Settings
        /// </summary>
        public Union<Humidifier.CodePipeline.CustomActionTypeTypes.Settings, BaseFunction>? Settings { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html#cfn-codepipeline-customactiontype-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// Provider
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html#cfn-codepipeline-customactiontype-provider
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Provider { get; set; }
    }

    namespace CustomActionTypeTypes
    {
        public class ArtifactDetails : Humidifier.Base.BaseSubResource, IHaveMinimumCount_Integer, IHaveMaximumCount_Integer
        {
            /// <summary>
            /// MinimumCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-artifactdetails.html#cfn-codepipeline-customactiontype-artifactdetails-minimumcount
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumCount { get; set; }
            /// <summary>
            /// MaximumCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-artifactdetails.html#cfn-codepipeline-customactiontype-artifactdetails-maximumcount
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumCount { get; set; }
        }

        public class ConfigurationProperties : Humidifier.Base.BaseSubResource, IHaveSecret_Boolean, IHaveType, IHaveDescription, IHaveRequired_Boolean, IHaveQueryable_Boolean, IHaveKey_Boolean, IHaveName
        {
            /// <summary>
            /// Secret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-configurationproperties.html#cfn-codepipeline-customactiontype-configurationproperties-secret
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Secret { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-configurationproperties.html#cfn-codepipeline-customactiontype-configurationproperties-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-configurationproperties.html#cfn-codepipeline-customactiontype-configurationproperties-description
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-configurationproperties.html#cfn-codepipeline-customactiontype-configurationproperties-required
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Required { get; set; }
            /// <summary>
            /// Queryable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-configurationproperties.html#cfn-codepipeline-customactiontype-configurationproperties-queryable
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Queryable { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-configurationproperties.html#cfn-codepipeline-customactiontype-configurationproperties-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Key { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-configurationproperties.html#cfn-codepipeline-customactiontype-configurationproperties-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Settings : Humidifier.Base.BaseSubResource, IHaveEntityUrlTemplate, IHaveExecutionUrlTemplate, IHaveRevisionUrlTemplate, IHaveThirdPartyConfigurationUrl
        {
            /// <summary>
            /// EntityUrlTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-settings.html#cfn-codepipeline-customactiontype-settings-entityurltemplate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntityUrlTemplate { get; set; }
            /// <summary>
            /// ExecutionUrlTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-settings.html#cfn-codepipeline-customactiontype-settings-executionurltemplate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionUrlTemplate { get; set; }
            /// <summary>
            /// RevisionUrlTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-settings.html#cfn-codepipeline-customactiontype-settings-revisionurltemplate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RevisionUrlTemplate { get; set; }
            /// <summary>
            /// ThirdPartyConfigurationUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-settings.html#cfn-codepipeline-customactiontype-settings-thirdpartyconfigurationurl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ThirdPartyConfigurationUrl { get; set; }
        }
    }
}