namespace Humidifier.SSM
{
    using global::System.Collections.Generic;
    using CloudConnectorTypes;

    public class CloudConnector : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveRoleArn, IHaveDisplayName
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
        public dynamic Description { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-cloudconnector.html#cfn-ssm-cloudconnector-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CloudConnectorConfiguration
        /// </summary>
        [Required]
        public Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration Configuration { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-cloudconnector.html#cfn-ssm-cloudconnector-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DisplayName { get; set; }

        /// <summary>
        /// ConfigConnectorArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-cloudconnector.html#cfn-ssm-cloudconnector-configconnectorarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ConfigConnectorArn { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-cloudconnector.html#cfn-ssm-cloudconnector-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-cloudconnector.html#cfn-ssm-cloudconnector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace CloudConnectorTypes
    {
        public class AzureConfiguration : Humidifier.Base.BaseSubResource, IHaveApplicationId, IHaveTenantId
        {
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-azureconfiguration.html#cfn-ssm-cloudconnector-azureconfiguration-tenantid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TenantId { get; set; }
            /// <summary>
            /// ApplicationDisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-azureconfiguration.html#cfn-ssm-cloudconnector-azureconfiguration-applicationdisplayname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationDisplayName { get; set; }
            /// <summary>
            /// TenantDisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-azureconfiguration.html#cfn-ssm-cloudconnector-azureconfiguration-tenantdisplayname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TenantDisplayName { get; set; }
            /// <summary>
            /// Targets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-azureconfiguration.html#cfn-ssm-cloudconnector-azureconfiguration-targets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfigurationTargets
            /// </summary>
            public Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets Targets { get; set; }
            /// <summary>
            /// ApplicationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-azureconfiguration.html#cfn-ssm-cloudconnector-azureconfiguration-applicationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationId { get; set; }
        }

        public class AzureSubscription : Humidifier.Base.BaseSubResource, IHaveId, IHaveDisplayName
        {
            /// <summary>
            /// DisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-azuresubscription.html#cfn-ssm-cloudconnector-azuresubscription-displayname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DisplayName { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-azuresubscription.html#cfn-ssm-cloudconnector-azuresubscription-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }

        public class CloudConnectorConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AzureConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-cloudconnectorconfiguration.html#cfn-ssm-cloudconnector-cloudconnectorconfiguration-azureconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AzureConfiguration
            /// </summary>
            public Humidifier.SSM.CloudConnectorTypes.AzureConfiguration AzureConfiguration { get; set; }
        }

        public class ConfigurationTargets : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Subscriptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-cloudconnector-configurationtargets.html#cfn-ssm-cloudconnector-configurationtargets-subscriptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AzureSubscription
            /// </summary>
            public List<Humidifier.SSM.CloudConnectorTypes.AzureSubscription> Subscriptions { get; set; }
        }
    }
}