namespace Humidifier.AppIntegrations
{
    using System.Collections.Generic;
    using DataIntegrationTypes;

    public class DataIntegration : Humidifier.Resource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string DataIntegrationArn =  "DataIntegrationArn" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::AppIntegrations::DataIntegration";
            }
        }

        /// <summary>
        /// ScheduleConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-dataintegration.html#cfn-appintegrations-dataintegration-scheduleconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ScheduleConfig
        /// </summary>
        public ScheduleConfig ScheduleConfig { get; set; }
        /// <summary>
        /// FileConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-dataintegration.html#cfn-appintegrations-dataintegration-fileconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FileConfiguration
        /// </summary>
        public FileConfiguration FileConfiguration { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-dataintegration.html#cfn-appintegrations-dataintegration-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// SourceURI
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-dataintegration.html#cfn-appintegrations-dataintegration-sourceuri
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SourceURI { get; set; }
        /// <summary>
        /// ObjectConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-dataintegration.html#cfn-appintegrations-dataintegration-objectconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic ObjectConfiguration { get; set; }
        /// <summary>
        /// KmsKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-dataintegration.html#cfn-appintegrations-dataintegration-kmskey
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKey { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-dataintegration.html#cfn-appintegrations-dataintegration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-dataintegration.html#cfn-appintegrations-dataintegration-name
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace DataIntegrationTypes
    {
        public class FileConfiguration
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-dataintegration-fileconfiguration.html#cfn-appintegrations-dataintegration-fileconfiguration-filters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Filters { get; set; }
            /// <summary>
            /// Folders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-dataintegration-fileconfiguration.html#cfn-appintegrations-dataintegration-fileconfiguration-folders
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Folders { get; set; }
        }

        public class ScheduleConfig
        {
            /// <summary>
            /// FirstExecutionFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-dataintegration-scheduleconfig.html#cfn-appintegrations-dataintegration-scheduleconfig-firstexecutionfrom
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FirstExecutionFrom { get; set; }
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-dataintegration-scheduleconfig.html#cfn-appintegrations-dataintegration-scheduleconfig-scheduleexpression
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScheduleExpression { get; set; }
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-dataintegration-scheduleconfig.html#cfn-appintegrations-dataintegration-scheduleconfig-object
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Object { get; set; }
        }
    }
}