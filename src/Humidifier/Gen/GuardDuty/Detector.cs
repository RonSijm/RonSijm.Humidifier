namespace Humidifier.GuardDuty
{
    using System.Collections.Generic;
    using DetectorTypes;

    public class Detector : Humidifier.Base.BaseResource, IHaveEnable
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.GuardDuty.Detector; }
        /// <summary>
        /// FindingPublishingFrequency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-detector.html#cfn-guardduty-detector-findingpublishingfrequency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FindingPublishingFrequency { get; set; }
        /// <summary>
        /// DataSources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-detector.html#cfn-guardduty-detector-datasources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CFNDataSourceConfigurations
        /// </summary>
        public Humidifier.GuardDuty.DetectorTypes.CFNDataSourceConfigurations DataSources { get; set; }

        /// <summary>
        /// Enable
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-detector.html#cfn-guardduty-detector-enable
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public dynamic Enable { get; set; }
        /// <summary>
        /// Features
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-detector.html#cfn-guardduty-detector-features
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CFNFeatureConfiguration
        /// </summary>
        public List<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration> Features { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-detector.html#cfn-guardduty-detector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagItem
        /// </summary>
        public List<Humidifier.GuardDuty.DetectorTypes.TagItem> Tags { get; set; }
    }

    namespace DetectorTypes
    {
        public class CFNDataSourceConfigurations : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MalwareProtection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-detector-cfndatasourceconfigurations.html#cfn-guardduty-detector-cfndatasourceconfigurations-malwareprotection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CFNMalwareProtectionConfiguration
            /// </summary>
            public Humidifier.GuardDuty.DetectorTypes.CFNMalwareProtectionConfiguration MalwareProtection { get; set; }
            /// <summary>
            /// S3Logs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-detector-cfndatasourceconfigurations.html#cfn-guardduty-detector-cfndatasourceconfigurations-s3logs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CFNS3LogsConfiguration
            /// </summary>
            public Humidifier.GuardDuty.DetectorTypes.CFNS3LogsConfiguration S3Logs { get; set; }
            /// <summary>
            /// Kubernetes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-detector-cfndatasourceconfigurations.html#cfn-guardduty-detector-cfndatasourceconfigurations-kubernetes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CFNKubernetesConfiguration
            /// </summary>
            public Humidifier.GuardDuty.DetectorTypes.CFNKubernetesConfiguration Kubernetes { get; set; }
        }

        public class CFNFeatureAdditionalConfiguration : Humidifier.Base.BaseSubResource, IHaveName, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-detector-cfnfeatureadditionalconfiguration.html#cfn-guardduty-detector-cfnfeatureadditionalconfiguration-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-detector-cfnfeatureadditionalconfiguration.html#cfn-guardduty-detector-cfnfeatureadditionalconfiguration-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class CFNFeatureConfiguration : Humidifier.Base.BaseSubResource, IHaveName, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-detector-cfnfeatureconfiguration.html#cfn-guardduty-detector-cfnfeatureconfiguration-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// AdditionalConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-detector-cfnfeatureconfiguration.html#cfn-guardduty-detector-cfnfeatureconfiguration-additionalconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CFNFeatureAdditionalConfiguration
            /// </summary>
            public List<Humidifier.GuardDuty.DetectorTypes.CFNFeatureAdditionalConfiguration> AdditionalConfiguration { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-detector-cfnfeatureconfiguration.html#cfn-guardduty-detector-cfnfeatureconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class CFNKubernetesAuditLogsConfiguration : Humidifier.Base.BaseSubResource, IHaveEnable
        {
            /// <summary>
            /// Enable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-detector-cfnkubernetesauditlogsconfiguration.html#cfn-guardduty-detector-cfnkubernetesauditlogsconfiguration-enable
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enable { get; set; }
        }

        public class CFNKubernetesConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuditLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-detector-cfnkubernetesconfiguration.html#cfn-guardduty-detector-cfnkubernetesconfiguration-auditlogs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CFNKubernetesAuditLogsConfiguration
            /// </summary>
            public Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration AuditLogs { get; set; }
        }

        public class CFNMalwareProtectionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScanEc2InstanceWithFindings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-detector-cfnmalwareprotectionconfiguration.html#cfn-guardduty-detector-cfnmalwareprotectionconfiguration-scanec2instancewithfindings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CFNScanEc2InstanceWithFindingsConfiguration
            /// </summary>
            public Humidifier.GuardDuty.DetectorTypes.CFNScanEc2InstanceWithFindingsConfiguration ScanEc2InstanceWithFindings { get; set; }
        }

        public class CFNS3LogsConfiguration : Humidifier.Base.BaseSubResource, IHaveEnable
        {
            /// <summary>
            /// Enable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-detector-cfns3logsconfiguration.html#cfn-guardduty-detector-cfns3logsconfiguration-enable
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enable { get; set; }
        }

        public class CFNScanEc2InstanceWithFindingsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EbsVolumes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-detector-cfnscanec2instancewithfindingsconfiguration.html#cfn-guardduty-detector-cfnscanec2instancewithfindingsconfiguration-ebsvolumes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EbsVolumes { get; set; }
        }

        public class TagItem : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-detector-tagitem.html#cfn-guardduty-detector-tagitem-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-detector-tagitem.html#cfn-guardduty-detector-tagitem-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}