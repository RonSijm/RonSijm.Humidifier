namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using VerifiedAccessTrustProviderTypes;

    public class VerifiedAccessTrustProvider : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveDeviceTrustProviderType, IHaveTrustProviderType, IHaveUserTrustProviderType
    {
        public class Attributes
        {
            public static string VerifiedAccessTrustProviderId =  "VerifiedAccessTrustProviderId" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VerifiedAccessTrustProvider; }

        /// <summary>
        /// PolicyReferenceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccesstrustprovider-policyreferencename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PolicyReferenceName { get; set; }
        /// <summary>
        /// DeviceOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccesstrustprovider-deviceoptions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DeviceOptions
        /// </summary>
        public Humidifier.EC2.VerifiedAccessTrustProviderTypes.DeviceOptions DeviceOptions { get; set; }
        /// <summary>
        /// DeviceTrustProviderType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccesstrustprovider-devicetrustprovidertype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DeviceTrustProviderType { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccesstrustprovider-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// OidcOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccesstrustprovider-oidcoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OidcOptions
        /// </summary>
        public Humidifier.EC2.VerifiedAccessTrustProviderTypes.OidcOptions OidcOptions { get; set; }

        /// <summary>
        /// TrustProviderType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccesstrustprovider-trustprovidertype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TrustProviderType { get; set; }
        /// <summary>
        /// SseSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccesstrustprovider-ssespecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SseSpecification
        /// </summary>
        public Humidifier.EC2.VerifiedAccessTrustProviderTypes.SseSpecification SseSpecification { get; set; }
        /// <summary>
        /// UserTrustProviderType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccesstrustprovider-usertrustprovidertype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UserTrustProviderType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccesstrustprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace VerifiedAccessTrustProviderTypes
    {
        public class DeviceOptions : Humidifier.Base.BaseSubResource, IHaveTenantId
        {
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccesstrustprovider-deviceoptions.html#cfn-ec2-verifiedaccesstrustprovider-deviceoptions-tenantid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TenantId { get; set; }
            /// <summary>
            /// PublicSigningKeyUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccesstrustprovider-deviceoptions.html#cfn-ec2-verifiedaccesstrustprovider-deviceoptions-publicsigningkeyurl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PublicSigningKeyUrl { get; set; }
        }

        public class OidcOptions : Humidifier.Base.BaseSubResource, IHaveScope, IHaveClientId, IHaveClientSecret, IHaveIssuer, IHaveAuthorizationEndpoint, IHaveTokenEndpoint, IHaveUserInfoEndpoint
        {
            /// <summary>
            /// TokenEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccesstrustprovider-oidcoptions.html#cfn-ec2-verifiedaccesstrustprovider-oidcoptions-tokenendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TokenEndpoint { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccesstrustprovider-oidcoptions.html#cfn-ec2-verifiedaccesstrustprovider-oidcoptions-scope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scope { get; set; }
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccesstrustprovider-oidcoptions.html#cfn-ec2-verifiedaccesstrustprovider-oidcoptions-issuer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Issuer { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccesstrustprovider-oidcoptions.html#cfn-ec2-verifiedaccesstrustprovider-oidcoptions-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
            /// <summary>
            /// UserInfoEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccesstrustprovider-oidcoptions.html#cfn-ec2-verifiedaccesstrustprovider-oidcoptions-userinfoendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserInfoEndpoint { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccesstrustprovider-oidcoptions.html#cfn-ec2-verifiedaccesstrustprovider-oidcoptions-clientid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// AuthorizationEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccesstrustprovider-oidcoptions.html#cfn-ec2-verifiedaccesstrustprovider-oidcoptions-authorizationendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationEndpoint { get; set; }
        }

        public class SseSpecification : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveCustomerManagedKeyEnabled
        {
            /// <summary>
            /// CustomerManagedKeyEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccesstrustprovider-ssespecification.html#cfn-ec2-verifiedaccesstrustprovider-ssespecification-customermanagedkeyenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CustomerManagedKeyEnabled { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccesstrustprovider-ssespecification.html#cfn-ec2-verifiedaccesstrustprovider-ssespecification-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn { get; set; }
        }
    }
}