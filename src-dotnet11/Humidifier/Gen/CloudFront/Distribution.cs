namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using DistributionTypes;

    public class Distribution : Humidifier.Base.BaseResource, IHaveTags, IHaveCloudFrontDistributionTypesDistributionConfigDistributionConfig
    {
        public class Attributes
        {
            public static string DomainName =  "DomainName" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.Distribution; }

        /// <summary>
        /// DistributionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-distribution.html#cfn-cloudfront-distribution-distributionconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DistributionConfig
        /// </summary>
        [Required]
        public Union<Humidifier.CloudFront.DistributionTypes.DistributionConfig, BaseFunction>? DistributionConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-distribution.html#cfn-cloudfront-distribution-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DistributionTypes
    {
        public class CacheBehavior : Humidifier.Base.BaseSubResource, IHaveCompress_Boolean, IHaveListOfCloudFrontDistributionTypesFunctionAssociationFunctionAssociations, IHaveListOfCloudFrontDistributionTypesLambdaFunctionAssociationLambdaFunctionAssociations, IHaveTargetOriginId, IHaveViewerProtocolPolicy, IHaveResponseHeadersPolicyId, IHaveCloudFrontDistributionTypesGrpcConfigGrpcConfig, IHaveRealtimeLogConfigArn, IHaveStringListOfTrustedSigners, IHaveDefaultTTL_Double, IHaveFieldLevelEncryptionId, IHaveStringListOfTrustedKeyGroups, IHaveStringListOfAllowedMethods, IHavePathPattern, IHaveStringListOfCachedMethods, IHaveSmoothStreaming_Boolean, IHaveCloudFrontDistributionTypesForwardedValuesForwardedValues, IHaveOriginRequestPolicyId, IHaveMinTTL_Double, IHaveCachePolicyId, IHaveMaxTTL_Double
        {
            /// <summary>
            /// Compress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-compress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Compress { get; set; }
            /// <summary>
            /// FunctionAssociations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-functionassociations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FunctionAssociation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFront.DistributionTypes.FunctionAssociation>, IReadOnlyList<Union<Humidifier.CloudFront.DistributionTypes.FunctionAssociation, BaseFunction>>, BaseFunction>? FunctionAssociations { get; set; }
            /// <summary>
            /// LambdaFunctionAssociations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-lambdafunctionassociations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LambdaFunctionAssociation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFront.DistributionTypes.LambdaFunctionAssociation>, IReadOnlyList<Union<Humidifier.CloudFront.DistributionTypes.LambdaFunctionAssociation, BaseFunction>>, BaseFunction>? LambdaFunctionAssociations { get; set; }
            /// <summary>
            /// TargetOriginId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-targetoriginid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetOriginId { get; set; }
            /// <summary>
            /// ViewerProtocolPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-viewerprotocolpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ViewerProtocolPolicy { get; set; }
            /// <summary>
            /// ResponseHeadersPolicyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-responseheaderspolicyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResponseHeadersPolicyId { get; set; }
            /// <summary>
            /// GrpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-grpcconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrpcConfig
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.GrpcConfig, BaseFunction>? GrpcConfig { get; set; }
            /// <summary>
            /// RealtimeLogConfigArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-realtimelogconfigarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RealtimeLogConfigArn { get; set; }
            /// <summary>
            /// TrustedSigners
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-trustedsigners
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TrustedSigners { get; set; }
            /// <summary>
            /// DefaultTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-defaultttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DefaultTTL { get; set; }
            /// <summary>
            /// FieldLevelEncryptionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-fieldlevelencryptionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldLevelEncryptionId { get; set; }
            /// <summary>
            /// TrustedKeyGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-trustedkeygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TrustedKeyGroups { get; set; }
            /// <summary>
            /// AllowedMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-allowedmethods
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedMethods { get; set; }
            /// <summary>
            /// PathPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-pathpattern
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PathPattern { get; set; }
            /// <summary>
            /// CachedMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-cachedmethods
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CachedMethods { get; set; }
            /// <summary>
            /// SmoothStreaming
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-smoothstreaming
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SmoothStreaming { get; set; }
            /// <summary>
            /// ForwardedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-forwardedvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForwardedValues
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.ForwardedValues, BaseFunction>? ForwardedValues { get; set; }
            /// <summary>
            /// OriginRequestPolicyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-originrequestpolicyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OriginRequestPolicyId { get; set; }
            /// <summary>
            /// MinTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-minttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinTTL { get; set; }
            /// <summary>
            /// CachePolicyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-cachepolicyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CachePolicyId { get; set; }
            /// <summary>
            /// MaxTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-maxttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxTTL { get; set; }
        }

        public class CacheTagConfig : Humidifier.Base.BaseSubResource, IHaveHeaderName
        {
            /// <summary>
            /// HeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachetagconfig.html#cfn-cloudfront-distribution-cachetagconfig-headername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HeaderName { get; set; }
        }

        public class ConnectionFunctionAssociation : Humidifier.Base.BaseSubResource, IHaveId
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-connectionfunctionassociation.html#cfn-cloudfront-distribution-connectionfunctionassociation-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class Cookies : Humidifier.Base.BaseSubResource, IHaveStringListOfWhitelistedNames, IHaveForward
        {
            /// <summary>
            /// WhitelistedNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cookies.html#cfn-cloudfront-distribution-cookies-whitelistednames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? WhitelistedNames { get; set; }
            /// <summary>
            /// Forward
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cookies.html#cfn-cloudfront-distribution-cookies-forward
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Forward { get; set; }
        }

        public class CustomErrorResponse : Humidifier.Base.BaseSubResource, IHaveResponseCode_Integer, IHaveErrorCachingMinTTL_Double, IHaveErrorCode_Integer, IHaveResponsePagePath
        {
            /// <summary>
            /// ResponseCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customerrorresponse.html#cfn-cloudfront-distribution-customerrorresponse-responsecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ResponseCode { get; set; }
            /// <summary>
            /// ErrorCachingMinTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customerrorresponse.html#cfn-cloudfront-distribution-customerrorresponse-errorcachingminttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ErrorCachingMinTTL { get; set; }
            /// <summary>
            /// ErrorCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customerrorresponse.html#cfn-cloudfront-distribution-customerrorresponse-errorcode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ErrorCode { get; set; }
            /// <summary>
            /// ResponsePagePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customerrorresponse.html#cfn-cloudfront-distribution-customerrorresponse-responsepagepath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResponsePagePath { get; set; }
        }

        public class CustomOriginConfig : Humidifier.Base.BaseSubResource, IHaveIpAddressType, IHaveOriginReadTimeout_Integer, IHaveHTTPSPort_Integer, IHaveCloudFrontDistributionTypesOriginMtlsConfigOriginMtlsConfig, IHaveOriginKeepaliveTimeout_Integer, IHaveStringListOfOriginSSLProtocols, IHaveHTTPPort_Integer, IHaveOriginProtocolPolicy
        {
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customoriginconfig.html#cfn-cloudfront-distribution-customoriginconfig-ipaddresstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddressType { get; set; }
            /// <summary>
            /// OriginReadTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customoriginconfig.html#cfn-cloudfront-distribution-customoriginconfig-originreadtimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OriginReadTimeout { get; set; }
            /// <summary>
            /// HTTPSPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customoriginconfig.html#cfn-cloudfront-distribution-customoriginconfig-httpsport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HTTPSPort { get; set; }
            /// <summary>
            /// OriginMtlsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customoriginconfig.html#cfn-cloudfront-distribution-customoriginconfig-originmtlsconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OriginMtlsConfig
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.OriginMtlsConfig, BaseFunction>? OriginMtlsConfig { get; set; }
            /// <summary>
            /// OriginKeepaliveTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customoriginconfig.html#cfn-cloudfront-distribution-customoriginconfig-originkeepalivetimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OriginKeepaliveTimeout { get; set; }
            /// <summary>
            /// OriginSSLProtocols
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customoriginconfig.html#cfn-cloudfront-distribution-customoriginconfig-originsslprotocols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OriginSSLProtocols { get; set; }
            /// <summary>
            /// HTTPPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customoriginconfig.html#cfn-cloudfront-distribution-customoriginconfig-httpport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HTTPPort { get; set; }
            /// <summary>
            /// OriginProtocolPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customoriginconfig.html#cfn-cloudfront-distribution-customoriginconfig-originprotocolpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OriginProtocolPolicy { get; set; }
        }

        public class DefaultCacheBehavior : Humidifier.Base.BaseSubResource, IHaveCompress_Boolean, IHaveListOfCloudFrontDistributionTypesFunctionAssociationFunctionAssociations, IHaveListOfCloudFrontDistributionTypesLambdaFunctionAssociationLambdaFunctionAssociations, IHaveTargetOriginId, IHaveViewerProtocolPolicy, IHaveResponseHeadersPolicyId, IHaveCloudFrontDistributionTypesGrpcConfigGrpcConfig, IHaveRealtimeLogConfigArn, IHaveStringListOfTrustedSigners, IHaveDefaultTTL_Double, IHaveFieldLevelEncryptionId, IHaveStringListOfTrustedKeyGroups, IHaveStringListOfAllowedMethods, IHaveStringListOfCachedMethods, IHaveSmoothStreaming_Boolean, IHaveCloudFrontDistributionTypesForwardedValuesForwardedValues, IHaveOriginRequestPolicyId, IHaveMinTTL_Double, IHaveCachePolicyId, IHaveMaxTTL_Double
        {
            /// <summary>
            /// Compress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-compress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Compress { get; set; }
            /// <summary>
            /// FunctionAssociations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-functionassociations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FunctionAssociation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFront.DistributionTypes.FunctionAssociation>, IReadOnlyList<Union<Humidifier.CloudFront.DistributionTypes.FunctionAssociation, BaseFunction>>, BaseFunction>? FunctionAssociations { get; set; }
            /// <summary>
            /// LambdaFunctionAssociations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-lambdafunctionassociations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LambdaFunctionAssociation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFront.DistributionTypes.LambdaFunctionAssociation>, IReadOnlyList<Union<Humidifier.CloudFront.DistributionTypes.LambdaFunctionAssociation, BaseFunction>>, BaseFunction>? LambdaFunctionAssociations { get; set; }
            /// <summary>
            /// TargetOriginId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-targetoriginid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetOriginId { get; set; }
            /// <summary>
            /// ViewerProtocolPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-viewerprotocolpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ViewerProtocolPolicy { get; set; }
            /// <summary>
            /// ResponseHeadersPolicyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-responseheaderspolicyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResponseHeadersPolicyId { get; set; }
            /// <summary>
            /// GrpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-grpcconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrpcConfig
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.GrpcConfig, BaseFunction>? GrpcConfig { get; set; }
            /// <summary>
            /// RealtimeLogConfigArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-realtimelogconfigarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RealtimeLogConfigArn { get; set; }
            /// <summary>
            /// TrustedSigners
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-trustedsigners
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TrustedSigners { get; set; }
            /// <summary>
            /// DefaultTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-defaultttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DefaultTTL { get; set; }
            /// <summary>
            /// FieldLevelEncryptionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-fieldlevelencryptionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldLevelEncryptionId { get; set; }
            /// <summary>
            /// TrustedKeyGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-trustedkeygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TrustedKeyGroups { get; set; }
            /// <summary>
            /// AllowedMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-allowedmethods
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedMethods { get; set; }
            /// <summary>
            /// CachedMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-cachedmethods
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CachedMethods { get; set; }
            /// <summary>
            /// SmoothStreaming
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-smoothstreaming
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SmoothStreaming { get; set; }
            /// <summary>
            /// ForwardedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-forwardedvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForwardedValues
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.ForwardedValues, BaseFunction>? ForwardedValues { get; set; }
            /// <summary>
            /// OriginRequestPolicyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-originrequestpolicyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OriginRequestPolicyId { get; set; }
            /// <summary>
            /// MinTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-minttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinTTL { get; set; }
            /// <summary>
            /// CachePolicyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-cachepolicyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CachePolicyId { get; set; }
            /// <summary>
            /// MaxTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-maxttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxTTL { get; set; }
        }

        public class Definition : Humidifier.Base.BaseSubResource, IHaveCloudFrontDistributionTypesStringSchemaStringSchema
        {
            /// <summary>
            /// StringSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-definition.html#cfn-cloudfront-distribution-definition-stringschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringSchema
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.StringSchema, BaseFunction>? StringSchema { get; set; }
        }

        public class DistributionConfig : Humidifier.Base.BaseSubResource, IHavePriceClass, IHaveStaging_Boolean, IHaveListOfCloudFrontDistributionTypesCustomErrorResponseCustomErrorResponses, IHaveContinuousDeploymentPolicyId, IHaveCloudFrontDistributionTypesOriginGroupsOriginGroups, IHaveCloudFrontDistributionTypesConnectionFunctionAssociationConnectionFunctionAssociation, IHaveIPV6Enabled_Boolean, IHaveCloudFrontDistributionTypesTenantConfigTenantConfig, IHaveStringListOfCNAMEs, IHaveCloudFrontDistributionTypesViewerMtlsConfigViewerMtlsConfig, IHaveHttpVersion, IHaveCloudFrontDistributionTypesRestrictionsRestrictions, IHaveListOfCloudFrontDistributionTypesCacheBehaviorCacheBehaviors, IHaveCloudFrontDistributionTypesLoggingLogging, IHaveComment, IHaveDefaultRootObject, IHaveListOfCloudFrontDistributionTypesOriginOrigins, IHaveCloudFrontDistributionTypesViewerCertificateViewerCertificate, IHaveAnycastIpListId, IHaveCloudFrontDistributionTypesLegacyCustomOriginCustomOrigin, IHaveCloudFrontDistributionTypesLegacyS3OriginS3Origin, IHaveCloudFrontDistributionTypesDefaultCacheBehaviorDefaultCacheBehavior, IHaveEnabled_Boolean, IHaveCloudFrontDistributionTypesCacheTagConfigCacheTagConfig, IHaveStringListOfAliases, IHaveConnectionMode, IHaveWebACLId
        {
            /// <summary>
            /// PriceClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-priceclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PriceClass { get; set; }
            /// <summary>
            /// Staging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-staging
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Staging { get; set; }
            /// <summary>
            /// CustomErrorResponses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-customerrorresponses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomErrorResponse
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFront.DistributionTypes.CustomErrorResponse>, IReadOnlyList<Union<Humidifier.CloudFront.DistributionTypes.CustomErrorResponse, BaseFunction>>, BaseFunction>? CustomErrorResponses { get; set; }
            /// <summary>
            /// ContinuousDeploymentPolicyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-continuousdeploymentpolicyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContinuousDeploymentPolicyId { get; set; }
            /// <summary>
            /// OriginGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-origingroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OriginGroups
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.OriginGroups, BaseFunction>? OriginGroups { get; set; }
            /// <summary>
            /// ConnectionFunctionAssociation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-connectionfunctionassociation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectionFunctionAssociation
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.ConnectionFunctionAssociation, BaseFunction>? ConnectionFunctionAssociation { get; set; }
            /// <summary>
            /// IPV6Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-ipv6enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IPV6Enabled { get; set; }
            /// <summary>
            /// TenantConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-tenantconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TenantConfig
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.TenantConfig, BaseFunction>? TenantConfig { get; set; }
            /// <summary>
            /// CNAMEs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-cnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CNAMEs { get; set; }
            /// <summary>
            /// ViewerMtlsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-viewermtlsconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ViewerMtlsConfig
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.ViewerMtlsConfig, BaseFunction>? ViewerMtlsConfig { get; set; }
            /// <summary>
            /// HttpVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-httpversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpVersion { get; set; }
            /// <summary>
            /// Restrictions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-restrictions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Restrictions
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.Restrictions, BaseFunction>? Restrictions { get; set; }
            /// <summary>
            /// CacheBehaviors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-cachebehaviors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CacheBehavior
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFront.DistributionTypes.CacheBehavior>, IReadOnlyList<Union<Humidifier.CloudFront.DistributionTypes.CacheBehavior, BaseFunction>>, BaseFunction>? CacheBehaviors { get; set; }
            /// <summary>
            /// Logging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-logging
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Logging
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.Logging, BaseFunction>? Logging { get; set; }
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-comment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comment { get; set; }
            /// <summary>
            /// DefaultRootObject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-defaultrootobject
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultRootObject { get; set; }
            /// <summary>
            /// Origins
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-origins
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Origin
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFront.DistributionTypes.Origin>, IReadOnlyList<Union<Humidifier.CloudFront.DistributionTypes.Origin, BaseFunction>>, BaseFunction>? Origins { get; set; }
            /// <summary>
            /// ViewerCertificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-viewercertificate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ViewerCertificate
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.ViewerCertificate, BaseFunction>? ViewerCertificate { get; set; }
            /// <summary>
            /// AnycastIpListId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-anycastiplistid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AnycastIpListId { get; set; }
            /// <summary>
            /// CustomOrigin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-customorigin
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegacyCustomOrigin
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.LegacyCustomOrigin, BaseFunction>? CustomOrigin { get; set; }
            /// <summary>
            /// S3Origin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-s3origin
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegacyS3Origin
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.LegacyS3Origin, BaseFunction>? S3Origin { get; set; }
            /// <summary>
            /// DefaultCacheBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-defaultcachebehavior
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DefaultCacheBehavior
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.DefaultCacheBehavior, BaseFunction>? DefaultCacheBehavior { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// CacheTagConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-cachetagconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CacheTagConfig
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.CacheTagConfig, BaseFunction>? CacheTagConfig { get; set; }
            /// <summary>
            /// Aliases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-aliases
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Aliases { get; set; }
            /// <summary>
            /// ConnectionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-connectionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionMode { get; set; }
            /// <summary>
            /// WebACLId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html#cfn-cloudfront-distribution-distributionconfig-webaclid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WebACLId { get; set; }
        }

        public class ForwardedValues : Humidifier.Base.BaseSubResource, IHaveStringListOfQueryStringCacheKeys, IHaveCloudFrontDistributionTypesCookiesCookies, IHaveStringListOfHeaders, IHaveQueryString_Boolean
        {
            /// <summary>
            /// QueryStringCacheKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-forwardedvalues.html#cfn-cloudfront-distribution-forwardedvalues-querystringcachekeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? QueryStringCacheKeys { get; set; }
            /// <summary>
            /// Cookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-forwardedvalues.html#cfn-cloudfront-distribution-forwardedvalues-cookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Cookies
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.Cookies, BaseFunction>? Cookies { get; set; }
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-forwardedvalues.html#cfn-cloudfront-distribution-forwardedvalues-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Headers { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-forwardedvalues.html#cfn-cloudfront-distribution-forwardedvalues-querystring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? QueryString { get; set; }
        }

        public class FunctionAssociation : Humidifier.Base.BaseSubResource, IHaveFunctionARN, IHaveEventType
        {
            /// <summary>
            /// FunctionARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-functionassociation.html#cfn-cloudfront-distribution-functionassociation-functionarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionARN { get; set; }
            /// <summary>
            /// EventType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-functionassociation.html#cfn-cloudfront-distribution-functionassociation-eventtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventType { get; set; }
        }

        public class GeoRestriction : Humidifier.Base.BaseSubResource, IHaveStringListOfLocations, IHaveRestrictionType
        {
            /// <summary>
            /// Locations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-georestriction.html#cfn-cloudfront-distribution-georestriction-locations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Locations { get; set; }
            /// <summary>
            /// RestrictionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-georestriction.html#cfn-cloudfront-distribution-georestriction-restrictiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RestrictionType { get; set; }
        }

        public class GrpcConfig : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-grpcconfig.html#cfn-cloudfront-distribution-grpcconfig-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class LambdaFunctionAssociation : Humidifier.Base.BaseSubResource, IHaveEventType, IHaveIncludeBody_Boolean, IHaveLambdaFunctionARN
        {
            /// <summary>
            /// EventType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-lambdafunctionassociation.html#cfn-cloudfront-distribution-lambdafunctionassociation-eventtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventType { get; set; }
            /// <summary>
            /// IncludeBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-lambdafunctionassociation.html#cfn-cloudfront-distribution-lambdafunctionassociation-includebody
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeBody { get; set; }
            /// <summary>
            /// LambdaFunctionARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-lambdafunctionassociation.html#cfn-cloudfront-distribution-lambdafunctionassociation-lambdafunctionarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaFunctionARN { get; set; }
        }

        public class LegacyCustomOrigin : Humidifier.Base.BaseSubResource, IHaveHTTPSPort_Integer, IHaveStringListOfOriginSSLProtocols, IHaveDNSName, IHaveHTTPPort_Integer, IHaveOriginProtocolPolicy
        {
            /// <summary>
            /// HTTPSPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-legacycustomorigin.html#cfn-cloudfront-distribution-legacycustomorigin-httpsport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HTTPSPort { get; set; }
            /// <summary>
            /// OriginSSLProtocols
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-legacycustomorigin.html#cfn-cloudfront-distribution-legacycustomorigin-originsslprotocols
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OriginSSLProtocols { get; set; }
            /// <summary>
            /// DNSName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-legacycustomorigin.html#cfn-cloudfront-distribution-legacycustomorigin-dnsname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DNSName { get; set; }
            /// <summary>
            /// HTTPPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-legacycustomorigin.html#cfn-cloudfront-distribution-legacycustomorigin-httpport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HTTPPort { get; set; }
            /// <summary>
            /// OriginProtocolPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-legacycustomorigin.html#cfn-cloudfront-distribution-legacycustomorigin-originprotocolpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OriginProtocolPolicy { get; set; }
        }

        public class LegacyS3Origin : Humidifier.Base.BaseSubResource, IHaveOriginAccessIdentity, IHaveDNSName
        {
            /// <summary>
            /// OriginAccessIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-legacys3origin.html#cfn-cloudfront-distribution-legacys3origin-originaccessidentity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OriginAccessIdentity { get; set; }
            /// <summary>
            /// DNSName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-legacys3origin.html#cfn-cloudfront-distribution-legacys3origin-dnsname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DNSName { get; set; }
        }

        public class Logging : Humidifier.Base.BaseSubResource, IHaveIncludeCookies_Boolean, IHaveBucket, IHavePrefix
        {
            /// <summary>
            /// IncludeCookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-logging.html#cfn-cloudfront-distribution-logging-includecookies
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeCookies { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-logging.html#cfn-cloudfront-distribution-logging-bucket
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-logging.html#cfn-cloudfront-distribution-logging-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class Origin : Humidifier.Base.BaseSubResource, IHaveConnectionTimeout_Integer, IHaveOriginAccessControlId, IHaveConnectionAttempts_Integer, IHaveListOfCloudFrontDistributionTypesOriginCustomHeaderOriginCustomHeaders, IHaveDomainName, IHaveCloudFrontDistributionTypesOriginShieldOriginShield, IHaveCloudFrontDistributionTypesS3OriginConfigS3OriginConfig, IHaveCloudFrontDistributionTypesVpcOriginConfigVpcOriginConfig, IHaveOriginPath, IHaveResponseCompletionTimeout_Integer, IHaveId, IHaveCloudFrontDistributionTypesCustomOriginConfigCustomOriginConfig
        {
            /// <summary>
            /// ConnectionTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origin.html#cfn-cloudfront-distribution-origin-connectiontimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConnectionTimeout { get; set; }
            /// <summary>
            /// OriginAccessControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origin.html#cfn-cloudfront-distribution-origin-originaccesscontrolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OriginAccessControlId { get; set; }
            /// <summary>
            /// ConnectionAttempts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origin.html#cfn-cloudfront-distribution-origin-connectionattempts
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConnectionAttempts { get; set; }
            /// <summary>
            /// OriginCustomHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origin.html#cfn-cloudfront-distribution-origin-origincustomheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OriginCustomHeader
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFront.DistributionTypes.OriginCustomHeader>, IReadOnlyList<Union<Humidifier.CloudFront.DistributionTypes.OriginCustomHeader, BaseFunction>>, BaseFunction>? OriginCustomHeaders { get; set; }
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origin.html#cfn-cloudfront-distribution-origin-domainname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainName { get; set; }
            /// <summary>
            /// OriginShield
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origin.html#cfn-cloudfront-distribution-origin-originshield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OriginShield
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.OriginShield, BaseFunction>? OriginShield { get; set; }
            /// <summary>
            /// S3OriginConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origin.html#cfn-cloudfront-distribution-origin-s3originconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3OriginConfig
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.S3OriginConfig, BaseFunction>? S3OriginConfig { get; set; }
            /// <summary>
            /// VpcOriginConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origin.html#cfn-cloudfront-distribution-origin-vpcoriginconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcOriginConfig
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.VpcOriginConfig, BaseFunction>? VpcOriginConfig { get; set; }
            /// <summary>
            /// OriginPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origin.html#cfn-cloudfront-distribution-origin-originpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OriginPath { get; set; }
            /// <summary>
            /// ResponseCompletionTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origin.html#cfn-cloudfront-distribution-origin-responsecompletiontimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ResponseCompletionTimeout { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origin.html#cfn-cloudfront-distribution-origin-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// CustomOriginConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origin.html#cfn-cloudfront-distribution-origin-customoriginconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomOriginConfig
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.CustomOriginConfig, BaseFunction>? CustomOriginConfig { get; set; }
        }

        public class OriginCustomHeader : Humidifier.Base.BaseSubResource, IHaveHeaderValue, IHaveHeaderName
        {
            /// <summary>
            /// HeaderValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origincustomheader.html#cfn-cloudfront-distribution-origincustomheader-headervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HeaderValue { get; set; }
            /// <summary>
            /// HeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origincustomheader.html#cfn-cloudfront-distribution-origincustomheader-headername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HeaderName { get; set; }
        }

        public class OriginGroup : Humidifier.Base.BaseSubResource, IHaveSelectionCriteria, IHaveId, IHaveCloudFrontDistributionTypesOriginGroupFailoverCriteriaFailoverCriteria, IHaveCloudFrontDistributionTypesOriginGroupMembersMembers
        {
            /// <summary>
            /// SelectionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroup.html#cfn-cloudfront-distribution-origingroup-selectioncriteria
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SelectionCriteria { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroup.html#cfn-cloudfront-distribution-origingroup-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// FailoverCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroup.html#cfn-cloudfront-distribution-origingroup-failovercriteria
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OriginGroupFailoverCriteria
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.OriginGroupFailoverCriteria, BaseFunction>? FailoverCriteria { get; set; }
            /// <summary>
            /// Members
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroup.html#cfn-cloudfront-distribution-origingroup-members
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OriginGroupMembers
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.OriginGroupMembers, BaseFunction>? Members { get; set; }
        }

        public class OriginGroupFailoverCriteria : Humidifier.Base.BaseSubResource, IHaveCloudFrontDistributionTypesStatusCodesStatusCodes
        {
            /// <summary>
            /// StatusCodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroupfailovercriteria.html#cfn-cloudfront-distribution-origingroupfailovercriteria-statuscodes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: StatusCodes
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.StatusCodes, BaseFunction>? StatusCodes { get; set; }
        }

        public class OriginGroupMember : Humidifier.Base.BaseSubResource, IHaveOriginId
        {
            /// <summary>
            /// OriginId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroupmember.html#cfn-cloudfront-distribution-origingroupmember-originid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OriginId { get; set; }
        }

        public class OriginGroupMembers : Humidifier.Base.BaseSubResource, IHaveQuantity_Integer, IHaveListOfCloudFrontDistributionTypesOriginGroupMemberItems
        {
            /// <summary>
            /// Quantity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroupmembers.html#cfn-cloudfront-distribution-origingroupmembers-quantity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Quantity { get; set; }
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroupmembers.html#cfn-cloudfront-distribution-origingroupmembers-items
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OriginGroupMember
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFront.DistributionTypes.OriginGroupMember>, IReadOnlyList<Union<Humidifier.CloudFront.DistributionTypes.OriginGroupMember, BaseFunction>>, BaseFunction>? Items { get; set; }
        }

        public class OriginGroups : Humidifier.Base.BaseSubResource, IHaveQuantity_Integer, IHaveListOfCloudFrontDistributionTypesOriginGroupItems
        {
            /// <summary>
            /// Quantity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroups.html#cfn-cloudfront-distribution-origingroups-quantity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Quantity { get; set; }
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroups.html#cfn-cloudfront-distribution-origingroups-items
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OriginGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFront.DistributionTypes.OriginGroup>, IReadOnlyList<Union<Humidifier.CloudFront.DistributionTypes.OriginGroup, BaseFunction>>, BaseFunction>? Items { get; set; }
        }

        public class OriginMtlsConfig : Humidifier.Base.BaseSubResource, IHaveClientCertificateArn
        {
            /// <summary>
            /// ClientCertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-originmtlsconfig.html#cfn-cloudfront-distribution-originmtlsconfig-clientcertificatearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientCertificateArn { get; set; }
        }

        public class OriginShield : Humidifier.Base.BaseSubResource, IHaveOriginShieldRegion, IHaveEnabled_Boolean
        {
            /// <summary>
            /// OriginShieldRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-originshield.html#cfn-cloudfront-distribution-originshield-originshieldregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OriginShieldRegion { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-originshield.html#cfn-cloudfront-distribution-originshield-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class ParameterDefinition : Humidifier.Base.BaseSubResource, IHaveCloudFrontDistributionTypesDefinitionDefinition, IHaveName
        {
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-parameterdefinition.html#cfn-cloudfront-distribution-parameterdefinition-definition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Definition
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.Definition, BaseFunction>? Definition { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-parameterdefinition.html#cfn-cloudfront-distribution-parameterdefinition-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Restrictions : Humidifier.Base.BaseSubResource, IHaveCloudFrontDistributionTypesGeoRestrictionGeoRestriction
        {
            /// <summary>
            /// GeoRestriction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-restrictions.html#cfn-cloudfront-distribution-restrictions-georestriction
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GeoRestriction
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.GeoRestriction, BaseFunction>? GeoRestriction { get; set; }
        }

        public class S3OriginConfig : Humidifier.Base.BaseSubResource, IHaveOriginReadTimeout_Integer, IHaveOriginAccessIdentity
        {
            /// <summary>
            /// OriginReadTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-s3originconfig.html#cfn-cloudfront-distribution-s3originconfig-originreadtimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OriginReadTimeout { get; set; }
            /// <summary>
            /// OriginAccessIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-s3originconfig.html#cfn-cloudfront-distribution-s3originconfig-originaccessidentity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OriginAccessIdentity { get; set; }
        }

        public class StatusCodes : Humidifier.Base.BaseSubResource, IHaveQuantity_Integer, IHaveIntegerListOfItems
        {
            /// <summary>
            /// Quantity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-statuscodes.html#cfn-cloudfront-distribution-statuscodes-quantity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Quantity { get; set; }
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-statuscodes.html#cfn-cloudfront-distribution-statuscodes-items
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? Items { get; set; }
        }

        public class StringSchema : Humidifier.Base.BaseSubResource, IHaveComment, IHaveDefaultValue, IHaveRequired_Boolean
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-stringschema.html#cfn-cloudfront-distribution-stringschema-comment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comment { get; set; }
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-stringschema.html#cfn-cloudfront-distribution-stringschema-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-stringschema.html#cfn-cloudfront-distribution-stringschema-required
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Required { get; set; }
        }

        public class TenantConfig : Humidifier.Base.BaseSubResource, IHaveListOfCloudFrontDistributionTypesParameterDefinitionParameterDefinitions
        {
            /// <summary>
            /// ParameterDefinitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-tenantconfig.html#cfn-cloudfront-distribution-tenantconfig-parameterdefinitions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ParameterDefinition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFront.DistributionTypes.ParameterDefinition>, IReadOnlyList<Union<Humidifier.CloudFront.DistributionTypes.ParameterDefinition, BaseFunction>>, BaseFunction>? ParameterDefinitions { get; set; }
        }

        public class TrustStoreConfig : Humidifier.Base.BaseSubResource, IHaveTrustStoreId, IHaveIgnoreCertificateExpiry_Boolean, IHaveAdvertiseTrustStoreCaNames_Boolean
        {
            /// <summary>
            /// TrustStoreId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-truststoreconfig.html#cfn-cloudfront-distribution-truststoreconfig-truststoreid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrustStoreId { get; set; }
            /// <summary>
            /// IgnoreCertificateExpiry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-truststoreconfig.html#cfn-cloudfront-distribution-truststoreconfig-ignorecertificateexpiry
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IgnoreCertificateExpiry { get; set; }
            /// <summary>
            /// AdvertiseTrustStoreCaNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-truststoreconfig.html#cfn-cloudfront-distribution-truststoreconfig-advertisetruststorecanames
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AdvertiseTrustStoreCaNames { get; set; }
        }

        public class ViewerCertificate : Humidifier.Base.BaseSubResource, IHaveIamCertificateId, IHaveSslSupportMethod, IHaveMinimumProtocolVersion, IHaveCloudFrontDefaultCertificate_Boolean, IHaveAcmCertificateArn
        {
            /// <summary>
            /// IamCertificateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-viewercertificate.html#cfn-cloudfront-distribution-viewercertificate-iamcertificateid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IamCertificateId { get; set; }
            /// <summary>
            /// SslSupportMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-viewercertificate.html#cfn-cloudfront-distribution-viewercertificate-sslsupportmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SslSupportMethod { get; set; }
            /// <summary>
            /// MinimumProtocolVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-viewercertificate.html#cfn-cloudfront-distribution-viewercertificate-minimumprotocolversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MinimumProtocolVersion { get; set; }
            /// <summary>
            /// CloudFrontDefaultCertificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-viewercertificate.html#cfn-cloudfront-distribution-viewercertificate-cloudfrontdefaultcertificate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CloudFrontDefaultCertificate { get; set; }
            /// <summary>
            /// AcmCertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-viewercertificate.html#cfn-cloudfront-distribution-viewercertificate-acmcertificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AcmCertificateArn { get; set; }
        }

        public class ViewerMtlsConfig : Humidifier.Base.BaseSubResource, IHaveMode, IHaveCloudFrontDistributionTypesTrustStoreConfigTrustStoreConfig
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-viewermtlsconfig.html#cfn-cloudfront-distribution-viewermtlsconfig-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// TrustStoreConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-viewermtlsconfig.html#cfn-cloudfront-distribution-viewermtlsconfig-truststoreconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrustStoreConfig
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig, BaseFunction>? TrustStoreConfig { get; set; }
        }

        public class VpcOriginConfig : Humidifier.Base.BaseSubResource, IHaveOriginReadTimeout_Integer, IHaveVpcOriginId, IHaveOriginKeepaliveTimeout_Integer, IHaveOwnerAccountId
        {
            /// <summary>
            /// OriginReadTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-vpcoriginconfig.html#cfn-cloudfront-distribution-vpcoriginconfig-originreadtimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OriginReadTimeout { get; set; }
            /// <summary>
            /// VpcOriginId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-vpcoriginconfig.html#cfn-cloudfront-distribution-vpcoriginconfig-vpcoriginid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcOriginId { get; set; }
            /// <summary>
            /// OriginKeepaliveTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-vpcoriginconfig.html#cfn-cloudfront-distribution-vpcoriginconfig-originkeepalivetimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OriginKeepaliveTimeout { get; set; }
            /// <summary>
            /// OwnerAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-vpcoriginconfig.html#cfn-cloudfront-distribution-vpcoriginconfig-owneraccountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OwnerAccountId { get; set; }
        }
    }
}