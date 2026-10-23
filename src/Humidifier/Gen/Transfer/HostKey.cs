namespace Humidifier.Transfer
{
    using global::System.Collections.Generic;

    public class HostKey : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveKmsKey, IHaveStorageType, IHaveServerId
    {
        public class Attributes
        {
            public static string Type =  "Type" ;
            public static string HostKeyId =  "HostKeyId" ;
            public static string HostKeyFingerprint =  "HostKeyFingerprint" ;
            public static string SecretId =  "SecretId" ;
            public static string Arn =  "Arn" ;
            public static string DateImported =  "DateImported" ;
        }

        public override string AWSTypeName { get => AWS.Transfer.HostKey; }

        /// <summary>
        /// ServerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-hostkey.html#cfn-transfer-hostkey-serverid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ServerId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-hostkey.html#cfn-transfer-hostkey-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// StorageType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-hostkey.html#cfn-transfer-hostkey-storagetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StorageType { get; set; }
        /// <summary>
        /// KmsKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-hostkey.html#cfn-transfer-hostkey-kmskey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKey { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-hostkey.html#cfn-transfer-hostkey-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// HostKeyBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-hostkey.html#cfn-transfer-hostkey-hostkeybody
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HostKeyBody { get; set; }
    }
}