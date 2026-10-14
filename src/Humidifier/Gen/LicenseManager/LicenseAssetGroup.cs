namespace Humidifier.LicenseManager
{
    using global::System.Collections.Generic;
    using LicenseAssetGroupTypes;

    public class LicenseAssetGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
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
        public dynamic Description { get; set; }

        /// <summary>
        /// AssociatedLicenseAssetRulesetARNs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseassetgroup.html#cfn-licensemanager-licenseassetgroup-associatedlicenseassetrulesetarns
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic AssociatedLicenseAssetRulesetARNs { get; set; }

        /// <summary>
        /// LicenseAssetGroupConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseassetgroup.html#cfn-licensemanager-licenseassetgroup-licenseassetgroupconfigurations
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: LicenseAssetGroupConfiguration
        /// </summary>
        [Required]
        public List<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration> LicenseAssetGroupConfigurations { get; set; }
        /// <summary>
        /// Properties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseassetgroup.html#cfn-licensemanager-licenseassetgroup-properties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LicenseAssetGroupProperty
        /// </summary>
        public List<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty> Properties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseassetgroup.html#cfn-licensemanager-licenseassetgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace LicenseAssetGroupTypes
    {
        public class LicenseAssetGroupConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UsageDimension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetgroup-licenseassetgroupconfiguration.html#cfn-licensemanager-licenseassetgroup-licenseassetgroupconfiguration-usagedimension
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UsageDimension { get; set; }
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
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseassetgroup-licenseassetgroupproperty.html#cfn-licensemanager-licenseassetgroup-licenseassetgroupproperty-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}