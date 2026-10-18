namespace Humidifier.Location
{
    using global::System.Collections.Generic;
    using APIKeyTypes;

    public class APIKey : Humidifier.Base.BaseResource, IHaveTags, IHaveKeyName, IHaveDescription, IHaveNoExpiry_Boolean, IHaveForceDelete_Boolean, IHaveExpireTime, IHaveForceUpdate_Boolean, IHaveLocationAPIKeyTypesApiKeyRestrictionsRestrictions
    {
        public class Attributes
        {
            public static string CreateTime =  "CreateTime" ;
            public static string UpdateTime =  "UpdateTime" ;
            public static string KeyArn =  "KeyArn" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Location.APIKey; }

        /// <summary>
        /// KeyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-apikey.html#cfn-location-apikey-keyname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? KeyName { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-apikey.html#cfn-location-apikey-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// NoExpiry
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-apikey.html#cfn-location-apikey-noexpiry
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? NoExpiry { get; set; }
        /// <summary>
        /// ForceDelete
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-apikey.html#cfn-location-apikey-forcedelete
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ForceDelete { get; set; }
        /// <summary>
        /// ExpireTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-apikey.html#cfn-location-apikey-expiretime
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExpireTime { get; set; }
        /// <summary>
        /// ForceUpdate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-apikey.html#cfn-location-apikey-forceupdate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ForceUpdate { get; set; }

        /// <summary>
        /// Restrictions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-apikey.html#cfn-location-apikey-restrictions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ApiKeyRestrictions
        /// </summary>
        [Required]
        public Union<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions, BaseFunction>? Restrictions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-apikey.html#cfn-location-apikey-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace APIKeyTypes
    {
        public class AndroidApp : Humidifier.Base.BaseSubResource, IHaveCertificateFingerprint, IHavePackage
        {
            /// <summary>
            /// CertificateFingerprint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-apikey-androidapp.html#cfn-location-apikey-androidapp-certificatefingerprint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateFingerprint { get; set; }
            /// <summary>
            /// Package
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-apikey-androidapp.html#cfn-location-apikey-androidapp-package
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Package { get; set; }
        }

        public class ApiKeyRestrictions : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowActions, IHaveStringListOfAllowResources, IHaveListOfLocationAPIKeyTypesAndroidAppAllowAndroidApps, IHaveStringListOfAllowReferers, IHaveListOfLocationAPIKeyTypesAppleAppAllowAppleApps
        {
            /// <summary>
            /// AllowActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-apikey-apikeyrestrictions.html#cfn-location-apikey-apikeyrestrictions-allowactions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowActions { get; set; }
            /// <summary>
            /// AllowResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-apikey-apikeyrestrictions.html#cfn-location-apikey-apikeyrestrictions-allowresources
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowResources { get; set; }
            /// <summary>
            /// AllowAndroidApps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-apikey-apikeyrestrictions.html#cfn-location-apikey-apikeyrestrictions-allowandroidapps
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AndroidApp
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Location.APIKeyTypes.AndroidApp>, IReadOnlyList<Union<Humidifier.Location.APIKeyTypes.AndroidApp, BaseFunction>>, BaseFunction>? AllowAndroidApps { get; set; }
            /// <summary>
            /// AllowReferers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-apikey-apikeyrestrictions.html#cfn-location-apikey-apikeyrestrictions-allowreferers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowReferers { get; set; }
            /// <summary>
            /// AllowAppleApps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-apikey-apikeyrestrictions.html#cfn-location-apikey-apikeyrestrictions-allowappleapps
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AppleApp
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Location.APIKeyTypes.AppleApp>, IReadOnlyList<Union<Humidifier.Location.APIKeyTypes.AppleApp, BaseFunction>>, BaseFunction>? AllowAppleApps { get; set; }
        }

        public class AppleApp : Humidifier.Base.BaseSubResource, IHaveBundleId
        {
            /// <summary>
            /// BundleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-apikey-appleapp.html#cfn-location-apikey-appleapp-bundleid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BundleId { get; set; }
        }
    }
}