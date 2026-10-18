namespace Humidifier.LicenseManager
{
    using global::System.Collections.Generic;
    using LicenseAssetGroupTypes;

    public class LicenseAssetGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveStringListOfAssociatedLicenseAssetRulesetARNs, IHaveListOfLicenseManagerLicenseAssetGroupTypesLicenseAssetGroupConfigurationLicenseAssetGroupConfigurations, IHaveListOfLicenseManagerLicenseAssetGroupTypesLicenseAssetGroupPropertyProperties, IHaveName
    {
        public class Attributes
        {
            public static string LicenseAssetGroupArn =  "LicenseAssetGroupArn" ;
        }

        public override string AWSTypeName { get => AWS.LicenseManager.LicenseAssetGroup; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseassetgroup.html#cfn-licensemanager-licenseassetgroup-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// AssociatedLicenseAssetRulesetARNs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseassetgroup.html#cfn-licensemanager-licenseassetgroup-associatedlicenseassetrulesetarns
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AssociatedLicenseAssetRulesetARNs { get; set; }

        /// <summary>
        /// LicenseAssetGroupConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseassetgroup.html#cfn-licensemanager-licenseassetgroup-licenseassetgroupconfigurations
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: LicenseAssetGroupConfiguration
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration>, IReadOnlyList<Union<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration, BaseFunction>>, BaseFunction>? LicenseAssetGroupConfigurations { get; set; }
        /// <summary>
        /// Properties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseassetgroup.html#cfn-licensemanager-licenseassetgroup-properties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LicenseAssetGroupProperty
        /// </summary>
        public Union<IReadOnlyList<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty>, IReadOnlyList<Union<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty, BaseFunction>>, BaseFunction>? Properties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseassetgroup.html#cfn-licensemanager-licenseassetgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace LicenseAssetGroupTypes
    {
        public class LicenseAssetGroupConfiguration : Humidifier.Base.BaseSubResource, IHaveUsageDimension
        {
            /// <summary>
            /// UsageDimension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetgroup-licenseassetgroupconfiguration.html#cfn-licensemanager-licenseassetgroup-licenseassetgroupconfiguration-usagedimension
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UsageDimension { get; set; }
        }

        public class LicenseAssetGroupProperty : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetgroup-licenseassetgroupproperty.html#cfn-licensemanager-licenseassetgroup-licenseassetgroupproperty-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetgroup-licenseassetgroupproperty.html#cfn-licensemanager-licenseassetgroup-licenseassetgroupproperty-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}