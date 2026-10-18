namespace Humidifier.VoiceID
{
    using global::System.Collections.Generic;
    using DomainTypes;

    public class Domain : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveVoiceIDDomainTypesServerSideEncryptionConfigurationServerSideEncryptionConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string DomainId =  "DomainId" ;
        }

        public override string AWSTypeName { get => AWS.VoiceID.Domain; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-voiceid-domain.html#cfn-voiceid-domain-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ServerSideEncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-voiceid-domain.html#cfn-voiceid-domain-serversideencryptionconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ServerSideEncryptionConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration, BaseFunction>? ServerSideEncryptionConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-voiceid-domain.html#cfn-voiceid-domain-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DomainTypes
    {
        public class ServerSideEncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyId
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-voiceid-domain-serversideencryptionconfiguration.html#cfn-voiceid-domain-serversideencryptionconfiguration-kmskeyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
        }
    }
}