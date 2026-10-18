namespace Humidifier.LicenseManager
{
    using global::System.Collections.Generic;
    using LicenseTypes;

    public class License : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveProductSKU, IHaveStatus, IHaveLicenseManagerLicenseTypesConsumptionConfigurationConsumptionConfiguration, IHaveLicenseManagerLicenseTypesValidityDateFormatValidity, IHaveProductName, IHaveLicenseManagerLicenseTypesIssuerDataIssuer, IHaveHomeRegion, IHaveListOfLicenseManagerLicenseTypesEntitlementEntitlements, IHaveListOfLicenseManagerLicenseTypesMetadataLicenseMetadata, IHaveLicenseName, IHaveBeneficiary
    {
        public class Attributes
        {
            public static string Version =  "Version" ;
            public static string LicenseArn =  "LicenseArn" ;
        }

        public override string AWSTypeName { get => AWS.LicenseManager.License; }

        /// <summary>
        /// ProductSKU
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-license.html#cfn-licensemanager-license-productsku
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProductSKU { get; set; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-license.html#cfn-licensemanager-license-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }

        /// <summary>
        /// ConsumptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-license.html#cfn-licensemanager-license-consumptionconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ConsumptionConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.LicenseManager.LicenseTypes.ConsumptionConfiguration, BaseFunction>? ConsumptionConfiguration { get; set; }

        /// <summary>
        /// Validity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-license.html#cfn-licensemanager-license-validity
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ValidityDateFormat
        /// </summary>
        [Required]
        public Union<Humidifier.LicenseManager.LicenseTypes.ValidityDateFormat, BaseFunction>? Validity { get; set; }

        /// <summary>
        /// ProductName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-license.html#cfn-licensemanager-license-productname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProductName { get; set; }

        /// <summary>
        /// Issuer
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-license.html#cfn-licensemanager-license-issuer
        /// Required: True
        /// UpdateType: Mutable
        /// Type: IssuerData
        /// </summary>
        [Required]
        public Union<Humidifier.LicenseManager.LicenseTypes.IssuerData, BaseFunction>? Issuer { get; set; }

        /// <summary>
        /// HomeRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-license.html#cfn-licensemanager-license-homeregion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? HomeRegion { get; set; }

        /// <summary>
        /// Entitlements
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-license.html#cfn-licensemanager-license-entitlements
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Entitlement
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.LicenseManager.LicenseTypes.Entitlement>, IReadOnlyList<Union<Humidifier.LicenseManager.LicenseTypes.Entitlement, BaseFunction>>, BaseFunction>? Entitlements { get; set; }
        /// <summary>
        /// LicenseMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-license.html#cfn-licensemanager-license-licensemetadata
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Metadata
        /// </summary>
        public Union<IReadOnlyList<Humidifier.LicenseManager.LicenseTypes.Metadata>, IReadOnlyList<Union<Humidifier.LicenseManager.LicenseTypes.Metadata, BaseFunction>>, BaseFunction>? LicenseMetadata { get; set; }
        public Union<string, BaseFunction>? LicenseName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-license.html#cfn-licensemanager-license-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// Beneficiary
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-license.html#cfn-licensemanager-license-beneficiary
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Beneficiary { get; set; }
    }

    namespace LicenseTypes
    {
        public class BorrowConfiguration : Humidifier.Base.BaseSubResource, IHaveAllowEarlyCheckIn_Boolean, IHaveMaxTimeToLiveInMinutes_Integer
        {
            /// <summary>
            /// AllowEarlyCheckIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-borrowconfiguration.html#cfn-licensemanager-license-borrowconfiguration-allowearlycheckin
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowEarlyCheckIn { get; set; }
            /// <summary>
            /// MaxTimeToLiveInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-borrowconfiguration.html#cfn-licensemanager-license-borrowconfiguration-maxtimetoliveinminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxTimeToLiveInMinutes { get; set; }
        }

        public class ConsumptionConfiguration : Humidifier.Base.BaseSubResource, IHaveLicenseManagerLicenseTypesBorrowConfigurationBorrowConfiguration, IHaveRenewType, IHaveLicenseManagerLicenseTypesProvisionalConfigurationProvisionalConfiguration
        {
            /// <summary>
            /// BorrowConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-consumptionconfiguration.html#cfn-licensemanager-license-consumptionconfiguration-borrowconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BorrowConfiguration
            /// </summary>
            public Union<Humidifier.LicenseManager.LicenseTypes.BorrowConfiguration, BaseFunction>? BorrowConfiguration { get; set; }
            /// <summary>
            /// RenewType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-consumptionconfiguration.html#cfn-licensemanager-license-consumptionconfiguration-renewtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RenewType { get; set; }
            /// <summary>
            /// ProvisionalConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-consumptionconfiguration.html#cfn-licensemanager-license-consumptionconfiguration-provisionalconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProvisionalConfiguration
            /// </summary>
            public Union<Humidifier.LicenseManager.LicenseTypes.ProvisionalConfiguration, BaseFunction>? ProvisionalConfiguration { get; set; }
        }

        public class Entitlement : Humidifier.Base.BaseSubResource, IHaveAllowCheckIn_Boolean, IHaveOverage_Boolean, IHaveValue, IHaveMaxCount_Integer, IHaveUnit, IHaveName
        {
            /// <summary>
            /// AllowCheckIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-entitlement.html#cfn-licensemanager-license-entitlement-allowcheckin
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowCheckIn { get; set; }
            /// <summary>
            /// Overage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-entitlement.html#cfn-licensemanager-license-entitlement-overage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Overage { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-entitlement.html#cfn-licensemanager-license-entitlement-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// MaxCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-entitlement.html#cfn-licensemanager-license-entitlement-maxcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCount { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-entitlement.html#cfn-licensemanager-license-entitlement-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-entitlement.html#cfn-licensemanager-license-entitlement-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class IssuerData : Humidifier.Base.BaseSubResource, IHaveSignKey, IHaveName
        {
            /// <summary>
            /// SignKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-issuerdata.html#cfn-licensemanager-license-issuerdata-signkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SignKey { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-issuerdata.html#cfn-licensemanager-license-issuerdata-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Metadata : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-metadata.html#cfn-licensemanager-license-metadata-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-metadata.html#cfn-licensemanager-license-metadata-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ProvisionalConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxTimeToLiveInMinutes_Integer
        {
            /// <summary>
            /// MaxTimeToLiveInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-provisionalconfiguration.html#cfn-licensemanager-license-provisionalconfiguration-maxtimetoliveinminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxTimeToLiveInMinutes { get; set; }
        }

        public class ValidityDateFormat : Humidifier.Base.BaseSubResource, IHaveBegin, IHaveEnd
        {
            /// <summary>
            /// Begin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-validitydateformat.html#cfn-licensemanager-license-validitydateformat-begin
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Begin { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-validitydateformat.html#cfn-licensemanager-license-validitydateformat-end
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? End { get; set; }
        }
    }
}