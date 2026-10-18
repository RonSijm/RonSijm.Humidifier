namespace Humidifier.WorkSpacesWeb
{
    using global::System.Collections.Generic;

    public class Portal : Humidifier.Base.BaseResource, IHaveTags, IHaveTrustStoreArn, IHaveUserAccessLoggingSettingsArn, IHaveBrowserSettingsArn, IHaveIpAccessSettingsArn, IHaveNetworkSettingsArn, IHavePortalCustomDomain, IHaveCustomerManagedKey, IHaveStringDictionaryOfAdditionalEncryptionContext, IHaveDisplayName, IHaveUserSettingsArn, IHaveDataProtectionSettingsArn, IHaveInstanceType, IHaveSessionLoggerArn, IHaveMaxConcurrentSessions_Double, IHaveAuthenticationType
    {
        public class Attributes
        {
            public static string CreationDate =  "CreationDate" ;
            public static string BrowserType =  "BrowserType" ;
            public static string ServiceProviderSamlMetadata =  "ServiceProviderSamlMetadata" ;
            public static string StatusReason =  "StatusReason" ;
            public static string PortalArn =  "PortalArn" ;
            public static string PortalStatus =  "PortalStatus" ;
            public static string RendererType =  "RendererType" ;
            public static string PortalEndpoint =  "PortalEndpoint" ;
        }

        public override string AWSTypeName { get => AWS.WorkSpacesWeb.Portal; }
        /// <summary>
        /// TrustStoreArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-portal.html#cfn-workspacesweb-portal-truststorearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TrustStoreArn { get; set; }
        /// <summary>
        /// UserAccessLoggingSettingsArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-portal.html#cfn-workspacesweb-portal-useraccessloggingsettingsarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UserAccessLoggingSettingsArn { get; set; }
        /// <summary>
        /// BrowserSettingsArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-portal.html#cfn-workspacesweb-portal-browsersettingsarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BrowserSettingsArn { get; set; }
        /// <summary>
        /// IpAccessSettingsArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-portal.html#cfn-workspacesweb-portal-ipaccesssettingsarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpAccessSettingsArn { get; set; }
        /// <summary>
        /// NetworkSettingsArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-portal.html#cfn-workspacesweb-portal-networksettingsarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkSettingsArn { get; set; }
        /// <summary>
        /// PortalCustomDomain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-portal.html#cfn-workspacesweb-portal-portalcustomdomain
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PortalCustomDomain { get; set; }
        /// <summary>
        /// CustomerManagedKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-portal.html#cfn-workspacesweb-portal-customermanagedkey
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CustomerManagedKey { get; set; }
        /// <summary>
        /// AdditionalEncryptionContext
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-portal.html#cfn-workspacesweb-portal-additionalencryptioncontext
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AdditionalEncryptionContext { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-portal.html#cfn-workspacesweb-portal-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// UserSettingsArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-portal.html#cfn-workspacesweb-portal-usersettingsarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UserSettingsArn { get; set; }
        /// <summary>
        /// DataProtectionSettingsArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-portal.html#cfn-workspacesweb-portal-dataprotectionsettingsarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DataProtectionSettingsArn { get; set; }
        /// <summary>
        /// InstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-portal.html#cfn-workspacesweb-portal-instancetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceType { get; set; }
        /// <summary>
        /// SessionLoggerArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-portal.html#cfn-workspacesweb-portal-sessionloggerarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SessionLoggerArn { get; set; }
        /// <summary>
        /// MaxConcurrentSessions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-portal.html#cfn-workspacesweb-portal-maxconcurrentsessions
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? MaxConcurrentSessions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-portal.html#cfn-workspacesweb-portal-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AuthenticationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-portal.html#cfn-workspacesweb-portal-authenticationtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AuthenticationType { get; set; }
    }
}