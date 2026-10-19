namespace Humidifier.LicenseManager
{
    using global::System.Collections.Generic;
    using LicenseConfigurationTypes;

    public class LicenseConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveLicenseCount_Integer, IHaveDescription, IHaveDisassociateWhenNotFound_Boolean, IHaveStringListOfLicenseRules, IHaveListOfLicenseManagerLicenseConfigurationTypesProductInformationProductInformationList, IHaveLicenseCountHardLimit_Boolean, IHaveLicenseExpiry_Integer, IHaveLicenseCountingType, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LicenseConfigurationId =  "LicenseConfigurationId" ;
            public static string LicenseConfigurationArn =  "LicenseConfigurationArn" ;
            public static string OwnerAccountId =  "OwnerAccountId" ;
        }

        public override string AWSTypeName { get => AWS.LicenseManager.LicenseConfiguration; }
        /// <summary>
        /// LicenseCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseconfiguration.html#cfn-licensemanager-licenseconfiguration-licensecount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? LicenseCount { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseconfiguration.html#cfn-licensemanager-licenseconfiguration-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// DisassociateWhenNotFound
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseconfiguration.html#cfn-licensemanager-licenseconfiguration-disassociatewhennotfound
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DisassociateWhenNotFound { get; set; }
        /// <summary>
        /// LicenseRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseconfiguration.html#cfn-licensemanager-licenseconfiguration-licenserules
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LicenseRules { get; set; }
        /// <summary>
        /// ProductInformationList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseconfiguration.html#cfn-licensemanager-licenseconfiguration-productinformationlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ProductInformation
        /// </summary>
        public Union<IReadOnlyList<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation>, IReadOnlyList<Union<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation, BaseFunction>>, BaseFunction>? ProductInformationList { get; set; }
        /// <summary>
        /// LicenseCountHardLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseconfiguration.html#cfn-licensemanager-licenseconfiguration-licensecounthardlimit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? LicenseCountHardLimit { get; set; }
        /// <summary>
        /// LicenseExpiry
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseconfiguration.html#cfn-licensemanager-licenseconfiguration-licenseexpiry
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? LicenseExpiry { get; set; }

        /// <summary>
        /// LicenseCountingType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseconfiguration.html#cfn-licensemanager-licenseconfiguration-licensecountingtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LicenseCountingType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseconfiguration.html#cfn-licensemanager-licenseconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace LicenseConfigurationTypes
    {
        public class ProductInformation : Humidifier.Base.BaseSubResource, IHaveListOfLicenseManagerLicenseConfigurationTypesProductInformationFilterProductInformationFilterList, IHaveResourceType
        {
            /// <summary>
            /// ProductInformationFilterList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseconfiguration-productinformation.html#cfn-licensemanager-licenseconfiguration-productinformation-productinformationfilterlist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ProductInformationFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformationFilter>, IReadOnlyList<Union<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformationFilter, BaseFunction>>, BaseFunction>? ProductInformationFilterList { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseconfiguration-productinformation.html#cfn-licensemanager-licenseconfiguration-productinformation-resourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
        }

        public class ProductInformationFilter : Humidifier.Base.BaseSubResource, IHaveProductInformationFilterName, IHaveStringListOfProductInformationFilterValue, IHaveProductInformationFilterComparator
        {
            /// <summary>
            /// ProductInformationFilterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseconfiguration-productinformationfilter.html#cfn-licensemanager-licenseconfiguration-productinformationfilter-productinformationfiltername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProductInformationFilterName { get; set; }
            /// <summary>
            /// ProductInformationFilterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseconfiguration-productinformationfilter.html#cfn-licensemanager-licenseconfiguration-productinformationfilter-productinformationfiltervalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ProductInformationFilterValue { get; set; }
            /// <summary>
            /// ProductInformationFilterComparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseconfiguration-productinformationfilter.html#cfn-licensemanager-licenseconfiguration-productinformationfilter-productinformationfiltercomparator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProductInformationFilterComparator { get; set; }
        }
    }
}