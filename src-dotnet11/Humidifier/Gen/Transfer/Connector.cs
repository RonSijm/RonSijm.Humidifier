namespace Humidifier.Transfer
{
    using global::System.Collections.Generic;
    using ConnectorTypes;

    public class Connector : Humidifier.Base.BaseResource, IHaveTags, IHaveIpAddressType, IHaveTransferConnectorTypesAs2ConfigAs2Config, IHaveLoggingRole, IHaveAccessRole, IHaveEgressType, IHaveTransferConnectorTypesConnectorEgressConfigEgressConfig, IHaveSecurityPolicyName, IHaveTransferConnectorTypesSftpConfigSftpConfig, IHaveUrl
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Arn =  "Arn" ;
            public static string ErrorMessage =  "ErrorMessage" ;
            public static string ServiceManagedEgressIpAddresses =  "ServiceManagedEgressIpAddresses" ;
            public static string ConnectorId =  "ConnectorId" ;
        }

        public override string AWSTypeName { get => AWS.Transfer.Connector; }
        /// <summary>
        /// IpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-connector.html#cfn-transfer-connector-ipaddresstype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpAddressType { get; set; }
        /// <summary>
        /// As2Config
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-connector.html#cfn-transfer-connector-as2config
        /// Required: False
        /// UpdateType: Mutable
        /// Type: As2Config
        /// </summary>
        public Union<Humidifier.Transfer.ConnectorTypes.As2Config, BaseFunction>? As2Config { get; set; }
        /// <summary>
        /// LoggingRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-connector.html#cfn-transfer-connector-loggingrole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LoggingRole { get; set; }

        /// <summary>
        /// AccessRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-connector.html#cfn-transfer-connector-accessrole
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AccessRole { get; set; }
        /// <summary>
        /// EgressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-connector.html#cfn-transfer-connector-egresstype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EgressType { get; set; }
        /// <summary>
        /// EgressConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-connector.html#cfn-transfer-connector-egressconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ConnectorEgressConfig
        /// </summary>
        public Union<Humidifier.Transfer.ConnectorTypes.ConnectorEgressConfig, BaseFunction>? EgressConfig { get; set; }
        /// <summary>
        /// SecurityPolicyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-connector.html#cfn-transfer-connector-securitypolicyname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SecurityPolicyName { get; set; }
        /// <summary>
        /// SftpConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-connector.html#cfn-transfer-connector-sftpconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SftpConfig
        /// </summary>
        public Union<Humidifier.Transfer.ConnectorTypes.SftpConfig, BaseFunction>? SftpConfig { get; set; }
        /// <summary>
        /// Url
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-connector.html#cfn-transfer-connector-url
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Url { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-connector.html#cfn-transfer-connector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ConnectorTypes
    {
        public class As2Config : Humidifier.Base.BaseSubResource, IHaveCompression, IHaveMessageSubject, IHaveTransferConnectorTypesConnectorAsyncMdnConfigAsyncMdnConfig, IHaveBasicAuthSecretId, IHavePartnerProfileId, IHaveEncryptionAlgorithm, IHaveSigningAlgorithm, IHaveLocalProfileId, IHaveMdnResponse, IHaveMdnSigningAlgorithm, IHavePreserveContentType
        {
            /// <summary>
            /// Compression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-compression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Compression { get; set; }
            /// <summary>
            /// MessageSubject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-messagesubject
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageSubject { get; set; }
            /// <summary>
            /// AsyncMdnConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-asyncmdnconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectorAsyncMdnConfig
            /// </summary>
            public Union<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig, BaseFunction>? AsyncMdnConfig { get; set; }
            /// <summary>
            /// BasicAuthSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-basicauthsecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BasicAuthSecretId { get; set; }
            /// <summary>
            /// PartnerProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-partnerprofileid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PartnerProfileId { get; set; }
            /// <summary>
            /// EncryptionAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-encryptionalgorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionAlgorithm { get; set; }
            /// <summary>
            /// SigningAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-signingalgorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SigningAlgorithm { get; set; }
            /// <summary>
            /// LocalProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-localprofileid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalProfileId { get; set; }
            /// <summary>
            /// MdnResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-mdnresponse
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MdnResponse { get; set; }
            /// <summary>
            /// MdnSigningAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-mdnsigningalgorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MdnSigningAlgorithm { get; set; }
            /// <summary>
            /// PreserveContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-as2config.html#cfn-transfer-connector-as2config-preservecontenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PreserveContentType { get; set; }
        }

        public class ConnectorAsyncMdnConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfServerIds, IHaveUrl
        {
            /// <summary>
            /// ServerIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-connectorasyncmdnconfig.html#cfn-transfer-connector-connectorasyncmdnconfig-serverids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ServerIds { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-connectorasyncmdnconfig.html#cfn-transfer-connector-connectorasyncmdnconfig-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class ConnectorEgressConfig : Humidifier.Base.BaseSubResource, IHaveTransferConnectorTypesConnectorVpcLatticeEgressConfigVpcLattice
        {
            /// <summary>
            /// VpcLattice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-connectoregressconfig.html#cfn-transfer-connector-connectoregressconfig-vpclattice
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConnectorVpcLatticeEgressConfig
            /// </summary>
            public Union<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig, BaseFunction>? VpcLattice { get; set; }
        }

        public class ConnectorVpcLatticeEgressConfig : Humidifier.Base.BaseSubResource, IHaveResourceConfigurationArn, IHavePortNumber_Integer
        {
            /// <summary>
            /// ResourceConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-connectorvpclatticeegressconfig.html#cfn-transfer-connector-connectorvpclatticeegressconfig-resourceconfigurationarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceConfigurationArn { get; set; }
            /// <summary>
            /// PortNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-connectorvpclatticeegressconfig.html#cfn-transfer-connector-connectorvpclatticeegressconfig-portnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PortNumber { get; set; }
        }

        public class SftpConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfTrustedHostKeys, IHaveUserSecretId, IHaveStringListOfOrderedUserSecretVersionStages, IHaveMaxConcurrentConnections_Integer
        {
            /// <summary>
            /// TrustedHostKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-sftpconfig.html#cfn-transfer-connector-sftpconfig-trustedhostkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TrustedHostKeys { get; set; }
            /// <summary>
            /// UserSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-sftpconfig.html#cfn-transfer-connector-sftpconfig-usersecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserSecretId { get; set; }
            /// <summary>
            /// OrderedUserSecretVersionStages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-sftpconfig.html#cfn-transfer-connector-sftpconfig-orderedusersecretversionstages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OrderedUserSecretVersionStages { get; set; }
            /// <summary>
            /// MaxConcurrentConnections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-connector-sftpconfig.html#cfn-transfer-connector-sftpconfig-maxconcurrentconnections
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxConcurrentConnections { get; set; }
        }
    }
}