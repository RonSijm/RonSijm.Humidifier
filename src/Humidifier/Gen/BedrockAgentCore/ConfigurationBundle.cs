namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using ConfigurationBundleTypes;

    public class ConfigurationBundle : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveKmsKeyArn, IHaveBranchName
    {
        public class Attributes
        {
            public static string VersionId =  "VersionId" ;
            public static string LineageMetadata =  "LineageMetadata" ;
            public static string BundleId =  "BundleId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string BundleArn =  "BundleArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.ConfigurationBundle; }

        /// <summary>
        /// Components
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-configurationbundle.html#cfn-bedrockagentcore-configurationbundle-components
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: ComponentConfiguration
        /// </summary>
        [Required]
        public Dictionary<string, Humidifier.BedrockAgentCore.ConfigurationBundleTypes.ComponentConfiguration> Components { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-configurationbundle.html#cfn-bedrockagentcore-configurationbundle-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// CreatedBy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-configurationbundle.html#cfn-bedrockagentcore-configurationbundle-createdby
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VersionCreatedBySource
        /// </summary>
        public Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource CreatedBy { get; set; }
        /// <summary>
        /// CommitMessage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-configurationbundle.html#cfn-bedrockagentcore-configurationbundle-commitmessage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CommitMessage { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-configurationbundle.html#cfn-bedrockagentcore-configurationbundle-kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyArn { get; set; }

        /// <summary>
        /// BundleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-configurationbundle.html#cfn-bedrockagentcore-configurationbundle-bundlename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic BundleName { get; set; }
        /// <summary>
        /// BranchName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-configurationbundle.html#cfn-bedrockagentcore-configurationbundle-branchname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BranchName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-configurationbundle.html#cfn-bedrockagentcore-configurationbundle-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ConfigurationBundleTypes
    {
        public class ComponentConfiguration : Humidifier.Base.BaseSubResource, IHaveConfiguration
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-configurationbundle-componentconfiguration.html#cfn-bedrockagentcore-configurationbundle-componentconfiguration-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Configuration { get; set; }
        }

        public class VersionCreatedBySource : Humidifier.Base.BaseSubResource, IHaveName, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-configurationbundle-versioncreatedbysource.html#cfn-bedrockagentcore-configurationbundle-versioncreatedbysource-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-configurationbundle-versioncreatedbysource.html#cfn-bedrockagentcore-configurationbundle-versioncreatedbysource-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class VersionLineageMetadata : Humidifier.Base.BaseSubResource, IHaveBranchName
        {
            /// <summary>
            /// CreatedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-configurationbundle-versionlineagemetadata.html#cfn-bedrockagentcore-configurationbundle-versionlineagemetadata-createdby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VersionCreatedBySource
            /// </summary>
            public Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource CreatedBy { get; set; }
            /// <summary>
            /// ParentVersionIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-configurationbundle-versionlineagemetadata.html#cfn-bedrockagentcore-configurationbundle-versionlineagemetadata-parentversionids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ParentVersionIds { get; set; }
            /// <summary>
            /// CommitMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-configurationbundle-versionlineagemetadata.html#cfn-bedrockagentcore-configurationbundle-versionlineagemetadata-commitmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMessage { get; set; }
            /// <summary>
            /// BranchName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-configurationbundle-versionlineagemetadata.html#cfn-bedrockagentcore-configurationbundle-versionlineagemetadata-branchname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BranchName { get; set; }
        }
    }
}