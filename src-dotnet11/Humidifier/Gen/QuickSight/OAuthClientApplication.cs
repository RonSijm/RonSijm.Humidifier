namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using OAuthClientApplicationTypes;

    public class OAuthClientApplication : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveOAuthClientApplicationId, IHaveClientSecret, IHaveOAuthClientAuthenticationType, IHaveDataSourceType, IHaveClientId, IHaveQuickSightOAuthClientApplicationTypesIdentityProviderVpcConnectionPropertiesIdentityProviderVpcConnectionProperties, IHaveOAuthAuthorizationEndpointUrl, IHaveOAuthTokenEndpointUrl, IHaveName, IHaveOAuthScopes
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.OAuthClientApplication; }

        /// <summary>
        /// OAuthClientApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-oauthclientapplication.html#cfn-quicksight-oauthclientapplication-oauthclientapplicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OAuthClientApplicationId { get; set; }
        /// <summary>
        /// ClientSecret
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-oauthclientapplication.html#cfn-quicksight-oauthclientapplication-clientsecret
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientSecret { get; set; }

        /// <summary>
        /// OAuthClientAuthenticationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-oauthclientapplication.html#cfn-quicksight-oauthclientapplication-oauthclientauthenticationtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OAuthClientAuthenticationType { get; set; }
        /// <summary>
        /// DataSourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-oauthclientapplication.html#cfn-quicksight-oauthclientapplication-datasourcetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DataSourceType { get; set; }
        /// <summary>
        /// ClientId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-oauthclientapplication.html#cfn-quicksight-oauthclientapplication-clientid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientId { get; set; }
        /// <summary>
        /// IdentityProviderVpcConnectionProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-oauthclientapplication.html#cfn-quicksight-oauthclientapplication-identityprovidervpcconnectionproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IdentityProviderVpcConnectionProperties
        /// </summary>
        public Union<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties, BaseFunction>? IdentityProviderVpcConnectionProperties { get; set; }
        /// <summary>
        /// OAuthAuthorizationEndpointUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-oauthclientapplication.html#cfn-quicksight-oauthclientapplication-oauthauthorizationendpointurl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OAuthAuthorizationEndpointUrl { get; set; }

        /// <summary>
        /// OAuthTokenEndpointUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-oauthclientapplication.html#cfn-quicksight-oauthclientapplication-oauthtokenendpointurl
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OAuthTokenEndpointUrl { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-oauthclientapplication.html#cfn-quicksight-oauthclientapplication-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// OAuthScopes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-oauthclientapplication.html#cfn-quicksight-oauthclientapplication-oauthscopes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OAuthScopes { get; set; }
    }

    namespace OAuthClientApplicationTypes
    {
        public class IdentityProviderVpcConnectionProperties : Humidifier.Base.BaseSubResource, IHaveVpcConnectionArn
        {
            /// <summary>
            /// VpcConnectionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-oauthclientapplication-identityprovidervpcconnectionproperties.html#cfn-quicksight-oauthclientapplication-identityprovidervpcconnectionproperties-vpcconnectionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcConnectionArn { get; set; }
        }
    }
}