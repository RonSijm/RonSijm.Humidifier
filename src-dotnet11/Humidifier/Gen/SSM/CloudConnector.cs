namespace Humidifier.SSM
{
    using global::System.Collections.Generic;
    using CloudConnectorTypes;

    public class CloudConnector : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveSSMCloudConnectorTypesCloudConnectorConfigurationConfiguration, IHaveDisplayName, IHaveConfigConnectorArn, IHaveRoleArn
    {
        public class Attributes
        {
            public static string CloudConnectorId =  "CloudConnectorId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string CloudConnectorArn =  "CloudConnectorArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.SSM.CloudConnector; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-cloudconnector.html#cfn-ssm-cloudconnector-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-cloudconnector.html#cfn-ssm-cloudconnector-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CloudConnectorConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration, BaseFunction>? Configuration { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-cloudconnector.html#cfn-ssm-cloudconnector-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DisplayName { get; set; }

        /// <summary>
        /// ConfigConnectorArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-cloudconnector.html#cfn-ssm-cloudconnector-configconnectorarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConfigConnectorArn { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-cloudconnector.html#cfn-ssm-cloudconnector-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-cloudconnector.html#cfn-ssm-cloudconnector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace CloudConnectorTypes
    {
        public class AzureConfiguration : Humidifier.Base.BaseSubResource, IHaveTenantId, IHaveApplicationDisplayName, IHaveTenantDisplayName, IHaveSSMCloudConnectorTypesConfigurationTargetsTargets, IHaveApplicationId
        {
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-azureconfiguration.html#cfn-ssm-cloudconnector-azureconfiguration-tenantid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TenantId { get; set; }
            /// <summary>
            /// ApplicationDisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-azureconfiguration.html#cfn-ssm-cloudconnector-azureconfiguration-applicationdisplayname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationDisplayName { get; set; }
            /// <summary>
            /// TenantDisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-azureconfiguration.html#cfn-ssm-cloudconnector-azureconfiguration-tenantdisplayname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TenantDisplayName { get; set; }
            /// <summary>
            /// Targets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-azureconfiguration.html#cfn-ssm-cloudconnector-azureconfiguration-targets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfigurationTargets
            /// </summary>
            public Union<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets, BaseFunction>? Targets { get; set; }
            /// <summary>
            /// ApplicationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-azureconfiguration.html#cfn-ssm-cloudconnector-azureconfiguration-applicationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationId { get; set; }
        }

        public class AzureSubscription : Humidifier.Base.BaseSubResource, IHaveDisplayName, IHaveId
        {
            /// <summary>
            /// DisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-azuresubscription.html#cfn-ssm-cloudconnector-azuresubscription-displayname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DisplayName { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-azuresubscription.html#cfn-ssm-cloudconnector-azuresubscription-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class CloudConnectorConfiguration : Humidifier.Base.BaseSubResource, IHaveSSMCloudConnectorTypesAzureConfigurationAzureConfiguration
        {
            /// <summary>
            /// AzureConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-cloudconnectorconfiguration.html#cfn-ssm-cloudconnector-cloudconnectorconfiguration-azureconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AzureConfiguration
            /// </summary>
            public Union<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration, BaseFunction>? AzureConfiguration { get; set; }
        }

        public class ConfigurationTargets : Humidifier.Base.BaseSubResource, IHaveListOfSSMCloudConnectorTypesAzureSubscriptionSubscriptions
        {
            /// <summary>
            /// Subscriptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-configurationtargets.html#cfn-ssm-cloudconnector-configurationtargets-subscriptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AzureSubscription
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SSM.CloudConnectorTypes.AzureSubscription>, IReadOnlyList<Union<Humidifier.SSM.CloudConnectorTypes.AzureSubscription, BaseFunction>>, BaseFunction>? Subscriptions { get; set; }
        }
    }
}