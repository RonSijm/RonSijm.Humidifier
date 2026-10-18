namespace Humidifier.DataSync
{
    using global::System.Collections.Generic;
    using LocationObjectStorageTypes;

    public class LocationObjectStorage : Humidifier.Base.BaseResource, IHaveTags, IHaveServerProtocol, IHaveServerCertificate, IHaveSecretKey, IHaveBucketName, IHaveDataSyncLocationObjectStorageTypesCmkSecretConfigCmkSecretConfig, IHaveDataSyncLocationObjectStorageTypesObjectStorageFederatedIdentityConfigFederatedIdentity, IHaveSubdirectory, IHaveServerHostname, IHaveAccessKey, IHaveDataSyncLocationObjectStorageTypesCustomSecretConfigCustomSecretConfig, IHaveStringListOfAgentArns, IHaveServerPort_Integer
    {
        public class Attributes
        {
            public static string ManagedSecretConfig =  "ManagedSecretConfig" ;
            public static string LocationUri =  "LocationUri" ;
            public static string LocationArn =  "LocationArn" ;
        }

        public override string AWSTypeName { get => AWS.DataSync.LocationObjectStorage; }
        /// <summary>
        /// ServerProtocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationobjectstorage.html#cfn-datasync-locationobjectstorage-serverprotocol
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServerProtocol { get; set; }
        /// <summary>
        /// ServerCertificate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationobjectstorage.html#cfn-datasync-locationobjectstorage-servercertificate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServerCertificate { get; set; }
        /// <summary>
        /// SecretKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationobjectstorage.html#cfn-datasync-locationobjectstorage-secretkey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SecretKey { get; set; }
        /// <summary>
        /// BucketName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationobjectstorage.html#cfn-datasync-locationobjectstorage-bucketname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BucketName { get; set; }
        /// <summary>
        /// CmkSecretConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationobjectstorage.html#cfn-datasync-locationobjectstorage-cmksecretconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CmkSecretConfig
        /// </summary>
        public Union<Humidifier.DataSync.LocationObjectStorageTypes.CmkSecretConfig, BaseFunction>? CmkSecretConfig { get; set; }
        /// <summary>
        /// FederatedIdentity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationobjectstorage.html#cfn-datasync-locationobjectstorage-federatedidentity
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ObjectStorageFederatedIdentityConfig
        /// </summary>
        public Union<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageFederatedIdentityConfig, BaseFunction>? FederatedIdentity { get; set; }
        /// <summary>
        /// Subdirectory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationobjectstorage.html#cfn-datasync-locationobjectstorage-subdirectory
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Subdirectory { get; set; }
        /// <summary>
        /// ServerHostname
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationobjectstorage.html#cfn-datasync-locationobjectstorage-serverhostname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServerHostname { get; set; }
        /// <summary>
        /// AccessKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationobjectstorage.html#cfn-datasync-locationobjectstorage-accesskey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AccessKey { get; set; }
        /// <summary>
        /// CustomSecretConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationobjectstorage.html#cfn-datasync-locationobjectstorage-customsecretconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomSecretConfig
        /// </summary>
        public Union<Humidifier.DataSync.LocationObjectStorageTypes.CustomSecretConfig, BaseFunction>? CustomSecretConfig { get; set; }
        /// <summary>
        /// AgentArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationobjectstorage.html#cfn-datasync-locationobjectstorage-agentarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AgentArns { get; set; }
        /// <summary>
        /// ServerPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationobjectstorage.html#cfn-datasync-locationobjectstorage-serverport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ServerPort { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationobjectstorage.html#cfn-datasync-locationobjectstorage-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace LocationObjectStorageTypes
    {
        public class CmkSecretConfig : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveKmsKeyArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationobjectstorage-cmksecretconfig.html#cfn-datasync-locationobjectstorage-cmksecretconfig-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationobjectstorage-cmksecretconfig.html#cfn-datasync-locationobjectstorage-cmksecretconfig-kmskeyarn
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationobjectstorage-customsecretconfig.html#cfn-datasync-locationobjectstorage-customsecretconfig-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// SecretAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationobjectstorage-customsecretconfig.html#cfn-datasync-locationobjectstorage-customsecretconfig-secretaccessrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretAccessRoleArn { get; set; }
        }

        public class GoogleOidcConfig : Humidifier.Base.BaseSubResource, IHaveProjectName, IHaveProjectNumber, IHaveIdentityProviderName, IHaveIdentityPoolName
        {
            /// <summary>
            /// ProjectName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationobjectstorage-googleoidcconfig.html#cfn-datasync-locationobjectstorage-googleoidcconfig-projectname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProjectName { get; set; }
            /// <summary>
            /// ProjectNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationobjectstorage-googleoidcconfig.html#cfn-datasync-locationobjectstorage-googleoidcconfig-projectnumber
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProjectNumber { get; set; }
            /// <summary>
            /// IdentityProviderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationobjectstorage-googleoidcconfig.html#cfn-datasync-locationobjectstorage-googleoidcconfig-identityprovidername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdentityProviderName { get; set; }
            /// <summary>
            /// IdentityPoolName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationobjectstorage-googleoidcconfig.html#cfn-datasync-locationobjectstorage-googleoidcconfig-identitypoolname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdentityPoolName { get; set; }
        }

        public class ManagedSecretConfig : Humidifier.Base.BaseSubResource, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationobjectstorage-managedsecretconfig.html#cfn-datasync-locationobjectstorage-managedsecretconfig-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
        }

        public class ObjectStorageExternalIdentityConfig : Humidifier.Base.BaseSubResource, IHaveDataSyncLocationObjectStorageTypesGoogleOidcConfigGoogleOidc
        {
            /// <summary>
            /// GoogleOidc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationobjectstorage-objectstorageexternalidentityconfig.html#cfn-datasync-locationobjectstorage-objectstorageexternalidentityconfig-googleoidc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GoogleOidcConfig
            /// </summary>
            public Union<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig, BaseFunction>? GoogleOidc { get; set; }
        }

        public class ObjectStorageFederatedIdentityConfig : Humidifier.Base.BaseSubResource, IHaveDataSyncLocationObjectStorageTypesObjectStorageExternalIdentityConfigExternalIdentity, IHaveAwsIamRole
        {
            /// <summary>
            /// ExternalIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationobjectstorage-objectstoragefederatedidentityconfig.html#cfn-datasync-locationobjectstorage-objectstoragefederatedidentityconfig-externalidentity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ObjectStorageExternalIdentityConfig
            /// </summary>
            public Union<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig, BaseFunction>? ExternalIdentity { get; set; }
            /// <summary>
            /// AwsIamRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationobjectstorage-objectstoragefederatedidentityconfig.html#cfn-datasync-locationobjectstorage-objectstoragefederatedidentityconfig-awsiamrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsIamRole { get; set; }
        }
    }
}