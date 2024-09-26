namespace Humidifier.Lambda
{
    using System.Collections.Generic;
    using AliasTypes;

    public class Alias : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveFunctionName, IHaveFunctionVersion
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
        public dynamic FunctionName { get; set; }
        /// <summary>
        /// ProvisionedConcurrencyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-alias.html#cfn-lambda-alias-provisionedconcurrencyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProvisionedConcurrencyConfiguration
        /// </summary>
        public Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration ProvisionedConcurrencyConfig { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-alias.html#cfn-lambda-alias-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// FunctionVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-alias.html#cfn-lambda-alias-functionversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FunctionVersion { get; set; }
        /// <summary>
        /// RoutingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-alias.html#cfn-lambda-alias-routingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AliasRoutingConfiguration
        /// </summary>
        public Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration RoutingConfig { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace AliasTypes
    {
        public class AliasRoutingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AdditionalVersionWeights
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-alias-aliasroutingconfiguration.html#cfn-lambda-alias-aliasroutingconfiguration-additionalversionweights
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VersionWeight
            /// </summary>
            public List<Humidifier.Lambda.AliasTypes.VersionWeight> AdditionalVersionWeights { get; set; }
        }

        public class ProvisionedConcurrencyConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProvisionedConcurrentExecutions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-alias-provisionedconcurrencyconfiguration.html#cfn-lambda-alias-provisionedconcurrencyconfiguration-provisionedconcurrentexecutions
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ProvisionedConcurrentExecutions { get; set; }
        }

        public class VersionWeight : Humidifier.Base.BaseSubResource, IHaveFunctionVersion
        {
            /// <summary>
            /// FunctionVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-alias-versionweight.html#cfn-lambda-alias-versionweight-functionversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FunctionVersion { get; set; }
            /// <summary>
            /// FunctionWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-alias-versionweight.html#cfn-lambda-alias-versionweight-functionweight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic FunctionWeight { get; set; }
        }
    }
}