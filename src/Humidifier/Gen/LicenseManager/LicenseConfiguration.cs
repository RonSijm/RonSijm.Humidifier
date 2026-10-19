namespace Humidifier.LicenseManager
{
    using global::System.Collections.Generic;
    using LicenseConfigurationTypes;

    public class LicenseConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
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
        public dynamic LicenseCount { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseconfiguration.html#cfn-licensemanager-licenseconfiguration-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// DisassociateWhenNotFound
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseconfiguration.html#cfn-licensemanager-licenseconfiguration-disassociatewhennotfound
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DisassociateWhenNotFound { get; set; }
        /// <summary>
        /// LicenseRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseconfiguration.html#cfn-licensemanager-licenseconfiguration-licenserules
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic LicenseRules { get; set; }
        /// <summary>
        /// ProductInformationList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseconfiguration.html#cfn-licensemanager-licenseconfiguration-productinformationlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ProductInformation
        /// </summary>
        public List<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation> ProductInformationList { get; set; }
        /// <summary>
        /// LicenseCountHardLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseconfiguration.html#cfn-licensemanager-licenseconfiguration-licensecounthardlimit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic LicenseCountHardLimit { get; set; }
        /// <summary>
        /// LicenseExpiry
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseconfiguration.html#cfn-licensemanager-licenseconfiguration-licenseexpiry
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic LicenseExpiry { get; set; }

        /// <summary>
        /// LicenseCountingType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseconfiguration.html#cfn-licensemanager-licenseconfiguration-licensecountingtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LicenseCountingType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-licenseconfiguration.html#cfn-licensemanager-licenseconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace LicenseConfigurationTypes
    {
        public class ProductInformation : Humidifier.Base.BaseSubResource, IHaveResourceType
        {
            /// <summary>
            /// ProductInformationFilterList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseconfiguration-productinformation.html#cfn-licensemanager-licenseconfiguration-productinformation-productinformationfilterlist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ProductInformationFilter
            /// </summary>
            public List<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformationFilter> ProductInformationFilterList { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseconfiguration-productinformation.html#cfn-licensemanager-licenseconfiguration-productinformation-resourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceType { get; set; }
        }

        public class ProductInformationFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProductInformationFilterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseconfiguration-productinformationfilter.html#cfn-licensemanager-licenseconfiguration-productinformationfilter-productinformationfiltername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProductInformationFilterName { get; set; }
            /// <summary>
            /// ProductInformationFilterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseconfiguration-productinformationfilter.html#cfn-licensemanager-licenseconfiguration-productinformationfilter-productinformationfiltervalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ProductInformationFilterValue { get; set; }
            /// <summary>
            /// ProductInformationFilterComparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-licenseconfiguration-productinformationfilter.html#cfn-licensemanager-licenseconfiguration-productinformationfilter-productinformationfiltercomparator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProductInformationFilterComparator { get; set; }
        }
    }
}