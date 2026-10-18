namespace Humidifier.QBusiness
{
    using global::System.Collections.Generic;
    using PluginTypes;

    public class Plugin : Humidifier.Base.BaseResource, IHaveTags, IHaveServerUrl, IHaveQBusinessPluginTypesCustomPluginConfigurationCustomPluginConfiguration, IHaveType, IHaveState, IHaveDisplayName, IHaveQBusinessPluginTypesPluginAuthConfigurationAuthConfiguration, IHaveApplicationId
    {
        public class Attributes
        {
            public static string PluginArn =  "PluginArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string BuildStatus =  "BuildStatus" ;
            public static string PluginId =  "PluginId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.QBusiness.Plugin; }
        /// <summary>
        /// ServerUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-plugin.html#cfn-qbusiness-plugin-serverurl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServerUrl { get; set; }
        /// <summary>
        /// CustomPluginConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-plugin.html#cfn-qbusiness-plugin-custompluginconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomPluginConfiguration
        /// </summary>
        public Union<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration, BaseFunction>? CustomPluginConfiguration { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-plugin.html#cfn-qbusiness-plugin-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-plugin.html#cfn-qbusiness-plugin-state
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? State { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-plugin.html#cfn-qbusiness-plugin-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DisplayName { get; set; }

        /// <summary>
        /// AuthConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-plugin.html#cfn-qbusiness-plugin-authconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: PluginAuthConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.QBusiness.PluginTypes.PluginAuthConfiguration, BaseFunction>? AuthConfiguration { get; set; }
        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-plugin.html#cfn-qbusiness-plugin-applicationid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ApplicationId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-plugin.html#cfn-qbusiness-plugin-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PluginTypes
    {
        public class APISchema : Humidifier.Base.BaseSubResource, IHaveQBusinessPluginTypesS3S3, IHavePayload
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-plugin-apischema.html#cfn-qbusiness-plugin-apischema-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3
            /// </summary>
            public Union<Humidifier.QBusiness.PluginTypes.S3, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-plugin-apischema.html#cfn-qbusiness-plugin-apischema-payload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Payload { get; set; }
        }

        public class BasicAuthConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveRoleArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-plugin-basicauthconfiguration.html#cfn-qbusiness-plugin-basicauthconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-plugin-basicauthconfiguration.html#cfn-qbusiness-plugin-basicauthconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class CustomPluginConfiguration : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveQBusinessPluginTypesAPISchemaApiSchema, IHaveApiSchemaType
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-plugin-custompluginconfiguration.html#cfn-qbusiness-plugin-custompluginconfiguration-description
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// ApiSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-plugin-custompluginconfiguration.html#cfn-qbusiness-plugin-custompluginconfiguration-apischema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: APISchema
            /// </summary>
            public Union<Humidifier.QBusiness.PluginTypes.APISchema, BaseFunction>? ApiSchema { get; set; }
            /// <summary>
            /// ApiSchemaType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-plugin-custompluginconfiguration.html#cfn-qbusiness-plugin-custompluginconfiguration-apischematype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiSchemaType { get; set; }
        }

        public class OAuth2ClientCredentialConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveAuthorizationUrl, IHaveTokenUrl, IHaveRoleArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-plugin-oauth2clientcredentialconfiguration.html#cfn-qbusiness-plugin-oauth2clientcredentialconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// AuthorizationUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-plugin-oauth2clientcredentialconfiguration.html#cfn-qbusiness-plugin-oauth2clientcredentialconfiguration-authorizationurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationUrl { get; set; }
            /// <summary>
            /// TokenUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-plugin-oauth2clientcredentialconfiguration.html#cfn-qbusiness-plugin-oauth2clientcredentialconfiguration-tokenurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenUrl { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-plugin-oauth2clientcredentialconfiguration.html#cfn-qbusiness-plugin-oauth2clientcredentialconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class PluginAuthConfiguration : Humidifier.Base.BaseSubResource, IHaveNoAuthConfiguration_Json, IHaveQBusinessPluginTypesBasicAuthConfigurationBasicAuthConfiguration, IHaveQBusinessPluginTypesOAuth2ClientCredentialConfigurationOAuth2ClientCredentialConfiguration
        {
            /// <summary>
            /// NoAuthConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-plugin-pluginauthconfiguration.html#cfn-qbusiness-plugin-pluginauthconfiguration-noauthconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? NoAuthConfiguration { get; set; }
            /// <summary>
            /// BasicAuthConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-plugin-pluginauthconfiguration.html#cfn-qbusiness-plugin-pluginauthconfiguration-basicauthconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BasicAuthConfiguration
            /// </summary>
            public Union<Humidifier.QBusiness.PluginTypes.BasicAuthConfiguration, BaseFunction>? BasicAuthConfiguration { get; set; }
            /// <summary>
            /// OAuth2ClientCredentialConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-plugin-pluginauthconfiguration.html#cfn-qbusiness-plugin-pluginauthconfiguration-oauth2clientcredentialconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuth2ClientCredentialConfiguration
            /// </summary>
            public Union<Humidifier.QBusiness.PluginTypes.OAuth2ClientCredentialConfiguration, BaseFunction>? OAuth2ClientCredentialConfiguration { get; set; }
        }

        public class S3 : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-plugin-s3.html#cfn-qbusiness-plugin-s3-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-plugin-s3.html#cfn-qbusiness-plugin-s3-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}