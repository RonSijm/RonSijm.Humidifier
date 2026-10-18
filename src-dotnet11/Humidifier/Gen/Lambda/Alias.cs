namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using AliasTypes;

    public class Alias : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveFunctionName, IHaveLambdaAliasTypesProvisionedConcurrencyConfigurationProvisionedConcurrencyConfig, IHaveDescription, IHaveFunctionVersion, IHaveLambdaAliasTypesAliasRoutingConfigurationRoutingConfig, IHaveName
    {
        public class Attributes
        {
            public static string AliasArn =  "AliasArn" ;
        }

        public override string AWSTypeName { get => AWS.Lambda.Alias; }

        /// <summary>
        /// FunctionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-alias.html#cfn-lambda-alias-functionname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FunctionName { get; set; }
        /// <summary>
        /// ProvisionedConcurrencyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-alias.html#cfn-lambda-alias-provisionedconcurrencyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProvisionedConcurrencyConfiguration
        /// </summary>
        public Union<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration, BaseFunction>? ProvisionedConcurrencyConfig { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-alias.html#cfn-lambda-alias-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// FunctionVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-alias.html#cfn-lambda-alias-functionversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FunctionVersion { get; set; }
        /// <summary>
        /// RoutingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-alias.html#cfn-lambda-alias-routingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AliasRoutingConfiguration
        /// </summary>
        public Union<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration, BaseFunction>? RoutingConfig { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AliasTypes
    {
        public class AliasRoutingConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfLambdaAliasTypesVersionWeightAdditionalVersionWeights
        {
            /// <summary>
            /// AdditionalVersionWeights
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-alias-aliasroutingconfiguration.html#cfn-lambda-alias-aliasroutingconfiguration-additionalversionweights
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VersionWeight
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lambda.AliasTypes.VersionWeight>, IReadOnlyList<Union<Humidifier.Lambda.AliasTypes.VersionWeight, BaseFunction>>, BaseFunction>? AdditionalVersionWeights { get; set; }
        }

        public class ProvisionedConcurrencyConfiguration : Humidifier.Base.BaseSubResource, IHaveProvisionedConcurrentExecutions_Integer
        {
            /// <summary>
            /// ProvisionedConcurrentExecutions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-alias-provisionedconcurrencyconfiguration.html#cfn-lambda-alias-provisionedconcurrencyconfiguration-provisionedconcurrentexecutions
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProvisionedConcurrentExecutions { get; set; }
        }

        public class VersionWeight : Humidifier.Base.BaseSubResource, IHaveFunctionVersion, IHaveFunctionWeight_Double
        {
            /// <summary>
            /// FunctionVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-alias-versionweight.html#cfn-lambda-alias-versionweight-functionversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionVersion { get; set; }
            /// <summary>
            /// FunctionWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-alias-versionweight.html#cfn-lambda-alias-versionweight-functionweight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? FunctionWeight { get; set; }
        }
    }
}