namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using DistributionTenantTypes;

    public class DistributionTenant : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStringListOfDomains, IHaveListOfCloudFrontDistributionTenantTypesParameterParameters, IHaveCloudFrontDistributionTenantTypesCustomizationsCustomizations, IHaveEnabled_Boolean, IHaveCloudFrontDistributionTenantTypesManagedCertificateRequestManagedCertificateRequest, IHaveDistributionId, IHaveConnectionGroupId, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string ETag =  "ETag" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string DomainResults =  "DomainResults" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.DistributionTenant; }

        /// <summary>
        /// Domains
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-distributiontenant.html#cfn-cloudfront-distributiontenant-domains
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Domains { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-distributiontenant.html#cfn-cloudfront-distributiontenant-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Parameter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudFront.DistributionTenantTypes.Parameter>, IReadOnlyList<Union<Humidifier.CloudFront.DistributionTenantTypes.Parameter, BaseFunction>>, BaseFunction>? Parameters { get; set; }
        /// <summary>
        /// Customizations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-distributiontenant.html#cfn-cloudfront-distributiontenant-customizations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Customizations
        /// </summary>
        public Union<Humidifier.CloudFront.DistributionTenantTypes.Customizations, BaseFunction>? Customizations { get; set; }
        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-distributiontenant.html#cfn-cloudfront-distributiontenant-enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Enabled { get; set; }
        /// <summary>
        /// ManagedCertificateRequest
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-distributiontenant.html#cfn-cloudfront-distributiontenant-managedcertificaterequest
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ManagedCertificateRequest
        /// </summary>
        public Union<Humidifier.CloudFront.DistributionTenantTypes.ManagedCertificateRequest, BaseFunction>? ManagedCertificateRequest { get; set; }

        /// <summary>
        /// DistributionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-distributiontenant.html#cfn-cloudfront-distributiontenant-distributionid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DistributionId { get; set; }
        /// <summary>
        /// ConnectionGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-distributiontenant.html#cfn-cloudfront-distributiontenant-connectiongroupid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConnectionGroupId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-distributiontenant.html#cfn-cloudfront-distributiontenant-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DistributionTenantTypes
    {
        public class Certificate : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributiontenant-certificate.html#cfn-cloudfront-distributiontenant-certificate-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class Customizations : Humidifier.Base.BaseSubResource, IHaveCloudFrontDistributionTenantTypesWebAclCustomizationWebAcl, IHaveCloudFrontDistributionTenantTypesGeoRestrictionCustomizationGeoRestrictions, IHaveCloudFrontDistributionTenantTypesCertificateCertificate
        {
            /// <summary>
            /// WebAcl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributiontenant-customizations.html#cfn-cloudfront-distributiontenant-customizations-webacl
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WebAclCustomization
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTenantTypes.WebAclCustomization, BaseFunction>? WebAcl { get; set; }
            /// <summary>
            /// GeoRestrictions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributiontenant-customizations.html#cfn-cloudfront-distributiontenant-customizations-georestrictions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeoRestrictionCustomization
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTenantTypes.GeoRestrictionCustomization, BaseFunction>? GeoRestrictions { get; set; }
            /// <summary>
            /// Certificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributiontenant-customizations.html#cfn-cloudfront-distributiontenant-customizations-certificate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Certificate
            /// </summary>
            public Union<Humidifier.CloudFront.DistributionTenantTypes.Certificate, BaseFunction>? Certificate { get; set; }
        }

        public class DomainResult : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveDomain
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributiontenant-domainresult.html#cfn-cloudfront-distributiontenant-domainresult-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributiontenant-domainresult.html#cfn-cloudfront-distributiontenant-domainresult-domain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Domain { get; set; }
        }

        public class GeoRestrictionCustomization : Humidifier.Base.BaseSubResource, IHaveStringListOfLocations, IHaveRestrictionType
        {
            /// <summary>
            /// Locations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributiontenant-georestrictioncustomization.html#cfn-cloudfront-distributiontenant-georestrictioncustomization-locations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Locations { get; set; }
            /// <summary>
            /// RestrictionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributiontenant-georestrictioncustomization.html#cfn-cloudfront-distributiontenant-georestrictioncustomization-restrictiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RestrictionType { get; set; }
        }

        public class ManagedCertificateRequest : Humidifier.Base.BaseSubResource, IHaveCertificateTransparencyLoggingPreference, IHaveValidationTokenHost, IHavePrimaryDomainName
        {
            /// <summary>
            /// CertificateTransparencyLoggingPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributiontenant-managedcertificaterequest.html#cfn-cloudfront-distributiontenant-managedcertificaterequest-certificatetransparencyloggingpreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateTransparencyLoggingPreference { get; set; }
            /// <summary>
            /// ValidationTokenHost
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributiontenant-managedcertificaterequest.html#cfn-cloudfront-distributiontenant-managedcertificaterequest-validationtokenhost
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValidationTokenHost { get; set; }
            /// <summary>
            /// PrimaryDomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributiontenant-managedcertificaterequest.html#cfn-cloudfront-distributiontenant-managedcertificaterequest-primarydomainname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrimaryDomainName { get; set; }
        }

        public class Parameter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributiontenant-parameter.html#cfn-cloudfront-distributiontenant-parameter-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributiontenant-parameter.html#cfn-cloudfront-distributiontenant-parameter-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class WebAclCustomization : Humidifier.Base.BaseSubResource, IHaveAction, IHaveArn
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributiontenant-webaclcustomization.html#cfn-cloudfront-distributiontenant-webaclcustomization-action
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributiontenant-webaclcustomization.html#cfn-cloudfront-distributiontenant-webaclcustomization-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }
    }
}