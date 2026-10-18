namespace Humidifier.Lightsail
{
    using global::System.Collections.Generic;
    using DistributionTypes;

    public class Distribution : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIpAddressType, IHaveLightsailDistributionTypesInputOriginOrigin, IHaveDistributionName, IHaveBundleId, IHaveLightsailDistributionTypesCacheBehaviorDefaultCacheBehavior, IHaveIsEnabled_Boolean, IHaveLightsailDistributionTypesCacheSettingsCacheBehaviorSettings, IHaveCertificateName, IHaveListOfLightsailDistributionTypesCacheBehaviorPerPathCacheBehaviors
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string DistributionArn =  "DistributionArn" ;
            public static string AbleToUpdateBundle =  "AbleToUpdateBundle" ;
        }

        public override string AWSTypeName { get => AWS.Lightsail.Distribution; }
        /// <summary>
        /// IpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-ipaddresstype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpAddressType { get; set; }

        /// <summary>
        /// Origin
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-origin
        /// Required: True
        /// UpdateType: Mutable
        /// Type: InputOrigin
        /// </summary>
        [Required]
        public Union<Humidifier.Lightsail.DistributionTypes.InputOrigin, BaseFunction>? Origin { get; set; }
        public Union<string, BaseFunction>? DistributionName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// BundleId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-bundleid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BundleId { get; set; }

        /// <summary>
        /// DefaultCacheBehavior
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-defaultcachebehavior
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CacheBehavior
        /// </summary>
        [Required]
        public Union<Humidifier.Lightsail.DistributionTypes.CacheBehavior, BaseFunction>? DefaultCacheBehavior { get; set; }
        /// <summary>
        /// IsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-isenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IsEnabled { get; set; }
        /// <summary>
        /// CacheBehaviorSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-cachebehaviorsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CacheSettings
        /// </summary>
        public Union<Humidifier.Lightsail.DistributionTypes.CacheSettings, BaseFunction>? CacheBehaviorSettings { get; set; }
        /// <summary>
        /// CertificateName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-certificatename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CertificateName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// CacheBehaviors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-cachebehaviors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CacheBehaviorPerPath
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Lightsail.DistributionTypes.CacheBehaviorPerPath>, IReadOnlyList<Union<Humidifier.Lightsail.DistributionTypes.CacheBehaviorPerPath, BaseFunction>>, BaseFunction>? CacheBehaviors { get; set; }
    }

    namespace DistributionTypes
    {
        public class CacheBehavior : Humidifier.Base.BaseSubResource, IHaveBehavior
        {
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachebehavior.html#cfn-lightsail-distribution-cachebehavior-behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Behavior { get; set; }
        }

        public class CacheBehaviorPerPath : Humidifier.Base.BaseSubResource, IHavePath, IHaveBehavior
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachebehaviorperpath.html#cfn-lightsail-distribution-cachebehaviorperpath-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachebehaviorperpath.html#cfn-lightsail-distribution-cachebehaviorperpath-behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Behavior { get; set; }
        }

        public class CacheSettings : Humidifier.Base.BaseSubResource, IHaveLightsailDistributionTypesCookieObjectForwardedCookies, IHaveMinimumTTL_Long, IHaveCachedHTTPMethods, IHaveAllowedHTTPMethods, IHaveMaximumTTL_Long, IHaveLightsailDistributionTypesHeaderObjectForwardedHeaders, IHaveDefaultTTL_Long, IHaveLightsailDistributionTypesQueryStringObjectForwardedQueryStrings
        {
            /// <summary>
            /// ForwardedCookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachesettings.html#cfn-lightsail-distribution-cachesettings-forwardedcookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CookieObject
            /// </summary>
            public Union<Humidifier.Lightsail.DistributionTypes.CookieObject, BaseFunction>? ForwardedCookies { get; set; }
            /// <summary>
            /// MinimumTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachesettings.html#cfn-lightsail-distribution-cachesettings-minimumttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? MinimumTTL { get; set; }
            /// <summary>
            /// CachedHTTPMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachesettings.html#cfn-lightsail-distribution-cachesettings-cachedhttpmethods
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CachedHTTPMethods { get; set; }
            /// <summary>
            /// AllowedHTTPMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachesettings.html#cfn-lightsail-distribution-cachesettings-allowedhttpmethods
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllowedHTTPMethods { get; set; }
            /// <summary>
            /// MaximumTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachesettings.html#cfn-lightsail-distribution-cachesettings-maximumttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? MaximumTTL { get; set; }
            /// <summary>
            /// ForwardedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachesettings.html#cfn-lightsail-distribution-cachesettings-forwardedheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeaderObject
            /// </summary>
            public Union<Humidifier.Lightsail.DistributionTypes.HeaderObject, BaseFunction>? ForwardedHeaders { get; set; }
            /// <summary>
            /// DefaultTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachesettings.html#cfn-lightsail-distribution-cachesettings-defaultttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? DefaultTTL { get; set; }
            /// <summary>
            /// ForwardedQueryStrings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachesettings.html#cfn-lightsail-distribution-cachesettings-forwardedquerystrings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QueryStringObject
            /// </summary>
            public Union<Humidifier.Lightsail.DistributionTypes.QueryStringObject, BaseFunction>? ForwardedQueryStrings { get; set; }
        }

        public class CookieObject : Humidifier.Base.BaseSubResource, IHaveStringListOfCookiesAllowList, IHaveOption
        {
            /// <summary>
            /// CookiesAllowList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cookieobject.html#cfn-lightsail-distribution-cookieobject-cookiesallowlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CookiesAllowList { get; set; }
            /// <summary>
            /// Option
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cookieobject.html#cfn-lightsail-distribution-cookieobject-option
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Option { get; set; }
        }

        public class HeaderObject : Humidifier.Base.BaseSubResource, IHaveStringListOfHeadersAllowList, IHaveOption
        {
            /// <summary>
            /// HeadersAllowList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-headerobject.html#cfn-lightsail-distribution-headerobject-headersallowlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? HeadersAllowList { get; set; }
            /// <summary>
            /// Option
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-headerobject.html#cfn-lightsail-distribution-headerobject-option
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Option { get; set; }
        }

        public class InputOrigin : Humidifier.Base.BaseSubResource, IHaveRegionName, IHaveProtocolPolicy, IHaveName
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-inputorigin.html#cfn-lightsail-distribution-inputorigin-regionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegionName { get; set; }
            /// <summary>
            /// ProtocolPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-inputorigin.html#cfn-lightsail-distribution-inputorigin-protocolpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProtocolPolicy { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-inputorigin.html#cfn-lightsail-distribution-inputorigin-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class QueryStringObject : Humidifier.Base.BaseSubResource, IHaveOption_Boolean, IHaveStringListOfQueryStringsAllowList
        {
            /// <summary>
            /// Option
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-querystringobject.html#cfn-lightsail-distribution-querystringobject-option
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Option { get; set; }
            /// <summary>
            /// QueryStringsAllowList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-querystringobject.html#cfn-lightsail-distribution-querystringobject-querystringsallowlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? QueryStringsAllowList { get; set; }
        }
    }
}