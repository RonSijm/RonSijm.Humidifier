namespace Humidifier.ECR
{
    using global::System.Collections.Generic;
    using RegistryScanningConfigurationTypes;

    public class RegistryScanningConfiguration : Humidifier.Base.BaseResource, IHaveScanType, IHaveListOfECRRegistryScanningConfigurationTypesScanningRuleRules
    {
        public class Attributes
        {
            public static string RegistryId =  "RegistryId" ;
        }

        public override string AWSTypeName { get => AWS.ECR.RegistryScanningConfiguration; }

        /// <summary>
        /// ScanType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-registryscanningconfiguration.html#cfn-ecr-registryscanningconfiguration-scantype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ScanType { get; set; }

        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-registryscanningconfiguration.html#cfn-ecr-registryscanningconfiguration-rules
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ScanningRule
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule>, IReadOnlyList<Union<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule, BaseFunction>>, BaseFunction>? Rules { get; set; }
    }

    namespace RegistryScanningConfigurationTypes
    {
        public class RepositoryFilter : Humidifier.Base.BaseSubResource, IHaveFilterType, IHaveFilter
        {
            /// <summary>
            /// FilterType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-registryscanningconfiguration-repositoryfilter.html#cfn-ecr-registryscanningconfiguration-repositoryfilter-filtertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilterType { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-registryscanningconfiguration-repositoryfilter.html#cfn-ecr-registryscanningconfiguration-repositoryfilter-filter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Filter { get; set; }
        }

        public class ScanningRule : Humidifier.Base.BaseSubResource, IHaveListOfECRRegistryScanningConfigurationTypesRepositoryFilterRepositoryFilters, IHaveScanFrequency
        {
            /// <summary>
            /// RepositoryFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-registryscanningconfiguration-scanningrule.html#cfn-ecr-registryscanningconfiguration-scanningrule-repositoryfilters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RepositoryFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECR.RegistryScanningConfigurationTypes.RepositoryFilter>, IReadOnlyList<Union<Humidifier.ECR.RegistryScanningConfigurationTypes.RepositoryFilter, BaseFunction>>, BaseFunction>? RepositoryFilters { get; set; }
            /// <summary>
            /// ScanFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-registryscanningconfiguration-scanningrule.html#cfn-ecr-registryscanningconfiguration-scanningrule-scanfrequency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScanFrequency { get; set; }
        }
    }
}