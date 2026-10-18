namespace Humidifier.ECR
{
    using global::System.Collections.Generic;
    using SigningConfigurationTypes;

    public class SigningConfiguration : Humidifier.Base.BaseResource, IHaveListOfECRSigningConfigurationTypesRuleRules
    {
        public class Attributes
        {
            public static string RegistryId =  "RegistryId" ;
        }

        public override string AWSTypeName { get => AWS.ECR.SigningConfiguration; }

        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-signingconfiguration.html#cfn-ecr-signingconfiguration-rules
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Rule
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.ECR.SigningConfigurationTypes.Rule>, IReadOnlyList<Union<Humidifier.ECR.SigningConfigurationTypes.Rule, BaseFunction>>, BaseFunction>? Rules { get; set; }
    }

    namespace SigningConfigurationTypes
    {
        public class RepositoryFilter : Humidifier.Base.BaseSubResource, IHaveFilterType, IHaveFilter
        {
            /// <summary>
            /// FilterType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-signingconfiguration-repositoryfilter.html#cfn-ecr-signingconfiguration-repositoryfilter-filtertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilterType { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-signingconfiguration-repositoryfilter.html#cfn-ecr-signingconfiguration-repositoryfilter-filter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Filter { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveListOfECRSigningConfigurationTypesRepositoryFilterRepositoryFilters, IHaveSigningProfileArn
        {
            /// <summary>
            /// RepositoryFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-signingconfiguration-rule.html#cfn-ecr-signingconfiguration-rule-repositoryfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RepositoryFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECR.SigningConfigurationTypes.RepositoryFilter>, IReadOnlyList<Union<Humidifier.ECR.SigningConfigurationTypes.RepositoryFilter, BaseFunction>>, BaseFunction>? RepositoryFilters { get; set; }
            /// <summary>
            /// SigningProfileArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-signingconfiguration-rule.html#cfn-ecr-signingconfiguration-rule-signingprofilearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SigningProfileArn { get; set; }
        }
    }
}