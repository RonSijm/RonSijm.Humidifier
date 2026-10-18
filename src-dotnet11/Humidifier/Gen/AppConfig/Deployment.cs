namespace Humidifier.AppConfig
{
    using global::System.Collections.Generic;
    using DeploymentTypes;

    public class Deployment : Humidifier.Base.BaseResource, IHaveTags, IHaveDeploymentStrategyId, IHaveConfigurationProfileId, IHaveEnvironmentId, IHaveKmsKeyIdentifier, IHaveDescription, IHaveConfigurationVersion, IHaveApplicationId, IHaveListOfAppConfigDeploymentTypesDynamicExtensionParametersDynamicExtensionParameters
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string DeploymentNumber =  "DeploymentNumber" ;
        }

        public override string AWSTypeName { get => AWS.AppConfig.Deployment; }

        /// <summary>
        /// DeploymentStrategyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-deploymentstrategyid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DeploymentStrategyId { get; set; }

        /// <summary>
        /// ConfigurationProfileId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-configurationprofileid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConfigurationProfileId { get; set; }

        /// <summary>
        /// EnvironmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-environmentid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EnvironmentId { get; set; }
        /// <summary>
        /// KmsKeyIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-kmskeyidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ConfigurationVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-configurationversion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConfigurationVersion { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationId { get; set; }
        /// <summary>
        /// DynamicExtensionParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-dynamicextensionparameters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: DynamicExtensionParameters
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters>, IReadOnlyList<Union<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters, BaseFunction>>, BaseFunction>? DynamicExtensionParameters { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DeploymentTypes
    {
        public class DynamicExtensionParameters : Humidifier.Base.BaseSubResource, IHaveParameterValue, IHaveExtensionReference, IHaveParameterName
        {
            /// <summary>
            /// ParameterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-deployment-dynamicextensionparameters.html#cfn-appconfig-deployment-dynamicextensionparameters-parametervalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterValue { get; set; }
            /// <summary>
            /// ExtensionReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-deployment-dynamicextensionparameters.html#cfn-appconfig-deployment-dynamicextensionparameters-extensionreference
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExtensionReference { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-deployment-dynamicextensionparameters.html#cfn-appconfig-deployment-dynamicextensionparameters-parametername
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterName { get; set; }
        }
    }
}