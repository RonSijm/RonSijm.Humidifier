namespace Humidifier.Transfer
{
    using System.Collections.Generic;
    using ConnectorTypes;

    public class Connector : Humidifier.Base.BaseResource, IHaveTags, IHaveUrl, IHaveAccessRole, IHaveLoggingRole, IHaveSecurityPolicyName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string ServiceManagedEgressIpAddresses =  "ServiceManagedEgressIpAddresses" ;
            public static string ConnectorId =  "ConnectorId" ;
        }

        public override string AWSTypeName { get => AWS.Transfer.Connector; }
        /// <summary>
        /// As2Config
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-connector.html#cfn-transfer-connector-as2config
        /// Required: False
        /// UpdateType: Mutable
        /// Type: As2Config
        /// </summary>
        public Humidifier.Transfer.ConnectorTypes.As2Config As2Config { get; set; }
        /// <summary>
        /// LoggingRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-connector.html#cfn-transfer-connector-loggingrole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LoggingRole { get; set; }

        /// <summary>
        /// AccessRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-connector.html#cfn-transfer-connector-accessrole
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AccessRole { get; set; }
        /// <summary>
        /// SecurityPolicyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-connector.html#cfn-transfer-connector-securitypolicyname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SecurityPolicyName { get; set; }
        /// <summary>
        /// SftpConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-connector.html#cfn-transfer-connector-sftpconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SftpConfig
        /// </summary>
        public Humidifier.Transfer.ConnectorTypes.SftpConfig SftpConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-connector.html#cfn-transfer-connector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Url
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-connector.html#cfn-transfer-connector-url
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Url { get; set; }
    }

    namespace ConnectorTypes
    {
        public class As2Config : Humidifier.Base.BaseSubResource, IHaveCompression, IHaveSigningAlgorithm, IHavePartnerProfileId, IHaveLocalProfileId
        {
            /// <summary>
            /// Compression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-compression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Compression { get; set; }
            /// <summary>
            /// MessageSubject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-messagesubject
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MessageSubject { get; set; }
            /// <summary>
            /// BasicAuthSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-basicauthsecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BasicAuthSecretId { get; set; }
            /// <summary>
            /// PartnerProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-partnerprofileid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PartnerProfileId { get; set; }
            /// <summary>
            /// EncryptionAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-encryptionalgorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionAlgorithm { get; set; }
            /// <summary>
            /// SigningAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-signingalgorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SigningAlgorithm { get; set; }
            /// <summary>
            /// LocalProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-localprofileid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocalProfileId { get; set; }
            /// <summary>
            /// MdnResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-mdnresponse
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MdnResponse { get; set; }
            /// <summary>
            /// MdnSigningAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-mdnsigningalgorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MdnSigningAlgorithm { get; set; }
            /// <summary>
            /// PreserveContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-preservecontenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreserveContentType { get; set; }
        }

        public class SftpConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TrustedHostKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-sftpconfig.html#cfn-transfer-connector-sftpconfig-trustedhostkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TrustedHostKeys { get; set; }
            /// <summary>
            /// UserSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-sftpconfig.html#cfn-transfer-connector-sftpconfig-usersecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserSecretId { get; set; }
        }
    }
}