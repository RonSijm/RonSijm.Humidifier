namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using ConfigurationBundleVersionTypes;

    public class ConfigurationBundleVersion : Humidifier.Base.BaseResource, IHaveBranchName
    {
        public class Attributes
        {
            public static string VersionId =  "VersionId" ;
            public static string VersionCreatedAt =  "VersionCreatedAt" ;
            public static string BundleId =  "BundleId" ;
            public static string ParentVersionIds =  "ParentVersionIds" ;
            public static string BundleArn =  "BundleArn" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.ConfigurationBundleVersion; }

        /// <summary>
        /// Components
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-configurationbundleversion.html#cfn-bedrockagentcore-configurationbundleversion-components
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Map
        /// ItemType: ComponentConfiguration
        /// </summary>
        [Required]
        public Dictionary<string, Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.ComponentConfiguration> Components { get; set; }
        /// <summary>
        /// CreatedBy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-configurationbundleversion.html#cfn-bedrockagentcore-configurationbundleversion-createdby
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VersionCreatedBySource
        /// </summary>
        public Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource CreatedBy { get; set; }
        /// <summary>
        /// CommitMessage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-configurationbundleversion.html#cfn-bedrockagentcore-configurationbundleversion-commitmessage
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CommitMessage { get; set; }
        /// <summary>
        /// BranchName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-configurationbundleversion.html#cfn-bedrockagentcore-configurationbundleversion-branchname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BranchName { get; set; }
    }

    namespace ConfigurationBundleVersionTypes
    {
        public class ComponentConfiguration : Humidifier.Base.BaseSubResource, IHaveConfiguration
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-configurationbundleversion-componentconfiguration.html#cfn-bedrockagentcore-configurationbundleversion-componentconfiguration-configuration
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Configuration { get; set; }
        }

        public class VersionCreatedBySource : Humidifier.Base.BaseSubResource, IHaveName, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-configurationbundleversion-versioncreatedbysource.html#cfn-bedrockagentcore-configurationbundleversion-versioncreatedbysource-arn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-configurationbundleversion-versioncreatedbysource.html#cfn-bedrockagentcore-configurationbundleversion-versioncreatedbysource-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}