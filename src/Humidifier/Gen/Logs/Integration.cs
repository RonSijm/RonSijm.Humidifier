namespace Humidifier.Logs
{
    using System.Collections.Generic;
    using IntegrationTypes;

    public class Integration : Humidifier.Base.BaseResource, IHaveImpliedResourceName
    {
        public class Attributes
        {
            public static string IntegrationStatus =  "IntegrationStatus" ;
        }

        public override string AWSTypeName { get => AWS.Logs.Integration; }
        public dynamic IntegrationName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ResourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-integration.html#cfn-logs-integration-resourceconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ResourceConfig
        /// </summary>
        [Required]
        public Humidifier.Logs.IntegrationTypes.ResourceConfig ResourceConfig { get; set; }

        /// <summary>
        /// IntegrationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-integration.html#cfn-logs-integration-integrationtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IntegrationType { get; set; }
    }

    namespace IntegrationTypes
    {
        public class OpenSearchResourceConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn
        {
            /// <summary>
            /// DashboardViewerPrincipals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-integration-opensearchresourceconfig.html#cfn-logs-integration-opensearchresourceconfig-dashboardviewerprincipals
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DashboardViewerPrincipals { get; set; }
            /// <summary>
            /// ApplicationARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-integration-opensearchresourceconfig.html#cfn-logs-integration-opensearchresourceconfig-applicationarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationARN { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-integration-opensearchresourceconfig.html#cfn-logs-integration-opensearchresourceconfig-kmskeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn { get; set; }
            /// <summary>
            /// RetentionDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-integration-opensearchresourceconfig.html#cfn-logs-integration-opensearchresourceconfig-retentiondays
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RetentionDays { get; set; }
            /// <summary>
            /// DataSourceRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-integration-opensearchresourceconfig.html#cfn-logs-integration-opensearchresourceconfig-datasourcerolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSourceRoleArn { get; set; }
        }

        public class ResourceConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OpenSearchResourceConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-integration-resourceconfig.html#cfn-logs-integration-resourceconfig-opensearchresourceconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OpenSearchResourceConfig
            /// </summary>
            public Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig OpenSearchResourceConfig { get; set; }
        }
    }
}