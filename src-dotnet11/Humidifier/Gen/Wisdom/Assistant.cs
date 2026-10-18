namespace Humidifier.Wisdom
{
    using global::System.Collections.Generic;
    using AssistantTypes;

    public class Assistant : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveType, IHaveDescription, IHaveWisdomAssistantTypesServerSideEncryptionConfigurationServerSideEncryptionConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string AssistantArn =  "AssistantArn" ;
            public static string AssistantId =  "AssistantId" ;
        }

        public override string AWSTypeName { get => AWS.Wisdom.Assistant; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-assistant.html#cfn-wisdom-assistant-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-assistant.html#cfn-wisdom-assistant-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ServerSideEncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-assistant.html#cfn-wisdom-assistant-serversideencryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ServerSideEncryptionConfiguration
        /// </summary>
        public Union<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration, BaseFunction>? ServerSideEncryptionConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-assistant.html#cfn-wisdom-assistant-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AssistantTypes
    {
        public class ServerSideEncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyId
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-assistant-serversideencryptionconfiguration.html#cfn-wisdom-assistant-serversideencryptionconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
        }
    }
}