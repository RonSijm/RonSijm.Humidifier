namespace Humidifier.ECR
{
    using global::System.Collections.Generic;
    using RegistryScanningConfigurationTypes;

    public class RegistryScanningConfiguration : Humidifier.Base.BaseResource, IHaveScanType
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
        public dynamic ScanType { get; set; }

        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-registryscanningconfiguration.html#cfn-ecr-registryscanningconfiguration-rules
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ScanningRule
        /// </summary>
        [Required]
        public List<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule> Rules { get; set; }
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
            public dynamic FilterType { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-registryscanningconfiguration-repositoryfilter.html#cfn-ecr-registryscanningconfiguration-repositoryfilter-filter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Filter { get; set; }
        }

        public class ScanningRule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RepositoryFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-registryscanningconfiguration-scanningrule.html#cfn-ecr-registryscanningconfiguration-scanningrule-repositoryfilters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RepositoryFilter
            /// </summary>
            public List<Humidifier.ECR.RegistryScanningConfigurationTypes.RepositoryFilter> RepositoryFilters { get; set; }
            /// <summary>
            /// ScanFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-registryscanningconfiguration-scanningrule.html#cfn-ecr-registryscanningconfiguration-scanningrule-scanfrequency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScanFrequency { get; set; }
        }
    }
}