namespace Humidifier.AppFabric
{
    using global::System.Collections.Generic;
    using AppAuthorizationTypes;

    public class AppAuthorization : Humidifier.Base.BaseResource, IHaveTags, IHaveAuthType
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string AppAuthorizationIdentifier =  "AppAuthorizationIdentifier" ;
            public static string AppBundleArn =  "AppBundleArn" ;
            public static string Persona =  "Persona" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string AppAuthorizationArn =  "AppAuthorizationArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.AppFabric.AppAuthorization; }

        /// <summary>
        /// App
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-appauthorization.html#cfn-appfabric-appauthorization-app
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic App { get; set; }
        /// <summary>
        /// Credential
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-appauthorization.html#cfn-appfabric-appauthorization-credential
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Credential
        /// </summary>
        public Humidifier.AppFabric.AppAuthorizationTypes.Credential Credential { get; set; }

        /// <summary>
        /// Tenant
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-appauthorization.html#cfn-appfabric-appauthorization-tenant
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Tenant
        /// </summary>
        [Required]
        public Humidifier.AppFabric.AppAuthorizationTypes.Tenant Tenant { get; set; }

        /// <summary>
        /// AppBundleIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-appauthorization.html#cfn-appfabric-appauthorization-appbundleidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AppBundleIdentifier { get; set; }

        /// <summary>
        /// AuthType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-appauthorization.html#cfn-appfabric-appauthorization-authtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AuthType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-appauthorization.html#cfn-appfabric-appauthorization-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace AppAuthorizationTypes
    {
        public class ApiKeyCredential : Humidifier.Base.BaseSubResource, IHaveApiKey
        {
            /// <summary>
            /// ApiKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-appauthorization-apikeycredential.html#cfn-appfabric-appauthorization-apikeycredential-apikey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKey { get; set; }
        }

        public class Credential : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ApiKeyCredential
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-appauthorization-credential.html#cfn-appfabric-appauthorization-credential-apikeycredential
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApiKeyCredential
            /// </summary>
            public Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential ApiKeyCredential { get; set; }
            /// <summary>
            /// Oauth2Credential
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-appauthorization-credential.html#cfn-appfabric-appauthorization-credential-oauth2credential
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Oauth2Credential
            /// </summary>
            public Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential Oauth2Credential { get; set; }
        }

        public class Oauth2Credential : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveClientSecret
        {
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-appauthorization-oauth2credential.html#cfn-appfabric-appauthorization-oauth2credential-clientsecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-appauthorization-oauth2credential.html#cfn-appfabric-appauthorization-oauth2credential-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
        }

        public class Tenant : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TenantIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-appauthorization-tenant.html#cfn-appfabric-appauthorization-tenant-tenantidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TenantIdentifier { get; set; }
            /// <summary>
            /// TenantDisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-appauthorization-tenant.html#cfn-appfabric-appauthorization-tenant-tenantdisplayname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TenantDisplayName { get; set; }
        }
    }
}