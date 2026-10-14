namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using DataAutomationLibraryTypes;

    public class DataAutomationLibrary : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string EntityTypes =  "EntityTypes" ;
            public static string Status =  "Status" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LibraryArn =  "LibraryArn" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.DataAutomationLibrary; }
        /// <summary>
        /// LibraryDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationlibrary.html#cfn-bedrock-dataautomationlibrary-librarydescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LibraryDescription { get; set; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationlibrary.html#cfn-bedrock-dataautomationlibrary-encryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// LibraryName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationlibrary.html#cfn-bedrock-dataautomationlibrary-libraryname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LibraryName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationlibrary.html#cfn-bedrock-dataautomationlibrary-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace DataAutomationLibraryTypes
    {
        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyId
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationlibrary-encryptionconfiguration.html#cfn-bedrock-dataautomationlibrary-encryptionconfiguration-kmskeyid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// KmsEncryptionContext
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationlibrary-encryptionconfiguration.html#cfn-bedrock-dataautomationlibrary-encryptionconfiguration-kmsencryptioncontext
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> KmsEncryptionContext { get; set; }
        }

        public class EntityTypeInfo : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EntityType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationlibrary-entitytypeinfo.html#cfn-bedrock-dataautomationlibrary-entitytypeinfo-entitytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntityType { get; set; }
            /// <summary>
            /// EntityMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationlibrary-entitytypeinfo.html#cfn-bedrock-dataautomationlibrary-entitytypeinfo-entitymetadata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntityMetadata { get; set; }
        }
    }
}