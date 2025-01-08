namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class KeyPair : Humidifier.Base.BaseResource, IHaveTags, IHaveKeyType, IHaveKeyName, IHavePublicKeyMaterial, IHaveKeyFormat
    {
        public class Attributes
        {
            public static string KeyPairId =  "KeyPairId" ;
            public static string KeyFingerprint =  "KeyFingerprint" ;
        }

        public override string AWSTypeName { get => AWS.EC2.KeyPair; }

        /// <summary>
        /// KeyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-keypair.html#cfn-ec2-keypair-keyname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic KeyName { get; set; }
        /// <summary>
        /// KeyType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-keypair.html#cfn-ec2-keypair-keytype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KeyType { get; set; }
        /// <summary>
        /// KeyFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-keypair.html#cfn-ec2-keypair-keyformat
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KeyFormat { get; set; }
        /// <summary>
        /// PublicKeyMaterial
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-keypair.html#cfn-ec2-keypair-publickeymaterial
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PublicKeyMaterial { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-keypair.html#cfn-ec2-keypair-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}