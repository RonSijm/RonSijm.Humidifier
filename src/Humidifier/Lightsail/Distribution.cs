namespace Humidifier.Lightsail
{
    using System.Collections.Generic;
    using DistributionTypes;

    public class Distribution : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string DistributionArn =  "DistributionArn" ;
            public static string AbleToUpdateBundle =  "AbleToUpdateBundle" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Lightsail::Distribution";
            }
        }

        /// <summary>
        /// IpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-ipaddresstype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IpAddressType { get; set; }
        /// <summary>
        /// Origin
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-origin
        /// Required: True
        /// UpdateType: Mutable
        /// Type: InputOrigin
        /// </summary>
        public InputOrigin Origin { get; set; }
        /// <summary>
        /// DistributionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-distributionname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DistributionName { get; set; }
        /// <summary>
        /// BundleId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-bundleid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BundleId { get; set; }
        /// <summary>
        /// DefaultCacheBehavior
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-defaultcachebehavior
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CacheBehavior
        /// </summary>
        public CacheBehavior DefaultCacheBehavior { get; set; }
        /// <summary>
        /// IsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-isenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic IsEnabled { get; set; }
        /// <summary>
        /// CacheBehaviorSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-cachebehaviorsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CacheSettings
        /// </summary>
        public CacheSettings CacheBehaviorSettings { get; set; }
        /// <summary>
        /// CertificateName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-certificatename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CertificateName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// CacheBehaviors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-distribution.html#cfn-lightsail-distribution-cachebehaviors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CacheBehaviorPerPath
        /// </summary>
        public List<CacheBehaviorPerPath> CacheBehaviors { get; set; }
    }

    namespace DistributionTypes
    {
        public class CacheBehavior
        {
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachebehavior.html#cfn-lightsail-distribution-cachebehavior-behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Behavior { get; set; }
        }

        public class CacheBehaviorPerPath
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachebehaviorperpath.html#cfn-lightsail-distribution-cachebehaviorperpath-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachebehaviorperpath.html#cfn-lightsail-distribution-cachebehaviorperpath-behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Behavior { get; set; }
        }

        public class CacheSettings
        {
            /// <summary>
            /// ForwardedCookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachesettings.html#cfn-lightsail-distribution-cachesettings-forwardedcookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CookieObject
            /// </summary>
            public CookieObject ForwardedCookies { get; set; }
            /// <summary>
            /// MinimumTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachesettings.html#cfn-lightsail-distribution-cachesettings-minimumttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumTTL { get; set; }
            /// <summary>
            /// CachedHTTPMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachesettings.html#cfn-lightsail-distribution-cachesettings-cachedhttpmethods
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CachedHTTPMethods { get; set; }
            /// <summary>
            /// AllowedHTTPMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachesettings.html#cfn-lightsail-distribution-cachesettings-allowedhttpmethods
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AllowedHTTPMethods { get; set; }
            /// <summary>
            /// MaximumTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachesettings.html#cfn-lightsail-distribution-cachesettings-maximumttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumTTL { get; set; }
            /// <summary>
            /// ForwardedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachesettings.html#cfn-lightsail-distribution-cachesettings-forwardedheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeaderObject
            /// </summary>
            public HeaderObject ForwardedHeaders { get; set; }
            /// <summary>
            /// DefaultTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachesettings.html#cfn-lightsail-distribution-cachesettings-defaultttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DefaultTTL { get; set; }
            /// <summary>
            /// ForwardedQueryStrings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cachesettings.html#cfn-lightsail-distribution-cachesettings-forwardedquerystrings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QueryStringObject
            /// </summary>
            public QueryStringObject ForwardedQueryStrings { get; set; }
        }

        public class CookieObject
        {
            /// <summary>
            /// CookiesAllowList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cookieobject.html#cfn-lightsail-distribution-cookieobject-cookiesallowlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CookiesAllowList { get; set; }
            /// <summary>
            /// Option
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-cookieobject.html#cfn-lightsail-distribution-cookieobject-option
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Option { get; set; }
        }

        public class HeaderObject
        {
            /// <summary>
            /// HeadersAllowList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-headerobject.html#cfn-lightsail-distribution-headerobject-headersallowlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic HeadersAllowList { get; set; }
            /// <summary>
            /// Option
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-headerobject.html#cfn-lightsail-distribution-headerobject-option
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Option { get; set; }
        }

        public class InputOrigin
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-inputorigin.html#cfn-lightsail-distribution-inputorigin-regionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegionName { get; set; }
            /// <summary>
            /// ProtocolPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-inputorigin.html#cfn-lightsail-distribution-inputorigin-protocolpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProtocolPolicy { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-inputorigin.html#cfn-lightsail-distribution-inputorigin-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class QueryStringObject
        {
            /// <summary>
            /// Option
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-querystringobject.html#cfn-lightsail-distribution-querystringobject-option
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Option { get; set; }
            /// <summary>
            /// QueryStringsAllowList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-distribution-querystringobject.html#cfn-lightsail-distribution-querystringobject-querystringsallowlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic QueryStringsAllowList { get; set; }
        }
    }
}