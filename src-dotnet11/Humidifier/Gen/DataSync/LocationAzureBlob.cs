namespace Humidifier.DataSync
{
    using global::System.Collections.Generic;
    using LocationAzureBlobTypes;

    public class LocationAzureBlob : Humidifier.Base.BaseResource, IHaveTags, IHaveDataSyncLocationAzureBlobTypesCmkSecretConfigCmkSecretConfig, IHaveDataSyncLocationAzureBlobTypesAzureFederatedIdentityConfigFederatedIdentity, IHaveAzureAccessTier, IHaveSubdirectory, IHaveDataSyncLocationAzureBlobTypesAzureBlobSasConfigurationAzureBlobSasConfiguration, IHaveAzureBlobType, IHaveAzureBlobContainerUrl, IHaveDataSyncLocationAzureBlobTypesCustomSecretConfigCustomSecretConfig, IHaveStringListOfAgentArns, IHaveAzureBlobAuthenticationType
    {
        public class Attributes
        {
            public static string ManagedSecretConfig =  "ManagedSecretConfig" ;
            public static string LocationUri =  "LocationUri" ;
            public static string LocationArn =  "LocationArn" ;
        }

        public override string AWSTypeName { get => AWS.DataSync.LocationAzureBlob; }
        /// <summary>
        /// CmkSecretConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationazureblob.html#cfn-datasync-locationazureblob-cmksecretconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CmkSecretConfig
        /// </summary>
        public Union<Humidifier.DataSync.LocationAzureBlobTypes.CmkSecretConfig, BaseFunction>? CmkSecretConfig { get; set; }
        /// <summary>
        /// FederatedIdentity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationazureblob.html#cfn-datasync-locationazureblob-federatedidentity
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AzureFederatedIdentityConfig
        /// </summary>
        public Union<Humidifier.DataSync.LocationAzureBlobTypes.AzureFederatedIdentityConfig, BaseFunction>? FederatedIdentity { get; set; }
        /// <summary>
        /// AzureAccessTier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationazureblob.html#cfn-datasync-locationazureblob-azureaccesstier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AzureAccessTier { get; set; }
        /// <summary>
        /// Subdirectory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationazureblob.html#cfn-datasync-locationazureblob-subdirectory
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Subdirectory { get; set; }
        /// <summary>
        /// AzureBlobSasConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationazureblob.html#cfn-datasync-locationazureblob-azureblobsasconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AzureBlobSasConfiguration
        /// </summary>
        public Union<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration, BaseFunction>? AzureBlobSasConfiguration { get; set; }
        /// <summary>
        /// AzureBlobType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationazureblob.html#cfn-datasync-locationazureblob-azureblobtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AzureBlobType { get; set; }
        /// <summary>
        /// AzureBlobContainerUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationazureblob.html#cfn-datasync-locationazureblob-azureblobcontainerurl
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AzureBlobContainerUrl { get; set; }
        /// <summary>
        /// CustomSecretConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationazureblob.html#cfn-datasync-locationazureblob-customsecretconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomSecretConfig
        /// </summary>
        public Union<Humidifier.DataSync.LocationAzureBlobTypes.CustomSecretConfig, BaseFunction>? CustomSecretConfig { get; set; }
        /// <summary>
        /// AgentArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationazureblob.html#cfn-datasync-locationazureblob-agentarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AgentArns { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationazureblob.html#cfn-datasync-locationazureblob-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// AzureBlobAuthenticationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationazureblob.html#cfn-datasync-locationazureblob-azureblobauthenticationtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AzureBlobAuthenticationType { get; set; }
    }

    namespace LocationAzureBlobTypes
    {
        public class AzureBlobSasConfiguration : Humidifier.Base.BaseSubResource, IHaveAzureBlobSasToken
        {
            /// <summary>
            /// AzureBlobSasToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationazureblob-azureblobsasconfiguration.html#cfn-datasync-locationazureblob-azureblobsasconfiguration-azureblobsastoken
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AzureBlobSasToken { get; set; }
        }

        public class AzureFederatedIdentityConfig : Humidifier.Base.BaseSubResource, IHaveDataSyncLocationAzureBlobTypesAzureOidcConfigAzureOidc, IHaveAwsIamRole
        {
            /// <summary>
            /// AzureOidc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationazureblob-azurefederatedidentityconfig.html#cfn-datasync-locationazureblob-azurefederatedidentityconfig-azureoidc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AzureOidcConfig
            /// </summary>
            public Union<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig, BaseFunction>? AzureOidc { get; set; }
            /// <summary>
            /// AwsIamRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationazureblob-azurefederatedidentityconfig.html#cfn-datasync-locationazureblob-azurefederatedidentityconfig-awsiamrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsIamRole { get; set; }
        }

        public class AzureOidcConfig : Humidifier.Base.BaseSubResource, IHaveTenantId, IHaveClientId
        {
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationazureblob-azureoidcconfig.html#cfn-datasync-locationazureblob-azureoidcconfig-tenantid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TenantId { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationazureblob-azureoidcconfig.html#cfn-datasync-locationazureblob-azureoidcconfig-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
        }

        public class CmkSecretConfig : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveKmsKeyArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationazureblob-cmksecretconfig.html#cfn-datasync-locationazureblob-cmksecretconfig-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationazureblob-cmksecretconfig.html#cfn-datasync-locationazureblob-cmksecretconfig-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        }

        public class CustomSecretConfig : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveSecretAccessRoleArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationazureblob-customsecretconfig.html#cfn-datasync-locationazureblob-customsecretconfig-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// SecretAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationazureblob-customsecretconfig.html#cfn-datasync-locationazureblob-customsecretconfig-secretaccessrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretAccessRoleArn { get; set; }
        }

        public class ManagedSecretConfig : Humidifier.Base.BaseSubResource, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationazureblob-managedsecretconfig.html#cfn-datasync-locationazureblob-managedsecretconfig-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
        }
    }
}