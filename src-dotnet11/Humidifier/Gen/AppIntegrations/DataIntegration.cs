namespace Humidifier.AppIntegrations
{
    using global::System.Collections.Generic;
    using DataIntegrationTypes;

    public class DataIntegration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAppIntegrationsDataIntegrationTypesScheduleConfigScheduleConfig, IHaveAppIntegrationsDataIntegrationTypesFileConfigurationFileConfiguration, IHaveDescription, IHaveSourceURI, IHaveObjectConfiguration_Json, IHaveKmsKey, IHaveName
    {
        public class Attributes
        {
            public static string DataIntegrationArn =  "DataIntegrationArn" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.AppIntegrations.DataIntegration; }
        /// <summary>
        /// ScheduleConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-dataintegration.html#cfn-appintegrations-dataintegration-scheduleconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ScheduleConfig
        /// </summary>
        public Union<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig, BaseFunction>? ScheduleConfig { get; set; }
        /// <summary>
        /// FileConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-dataintegration.html#cfn-appintegrations-dataintegration-fileconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FileConfiguration
        /// </summary>
        public Union<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration, BaseFunction>? FileConfiguration { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-dataintegration.html#cfn-appintegrations-dataintegration-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// SourceURI
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-dataintegration.html#cfn-appintegrations-dataintegration-sourceuri
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SourceURI { get; set; }
        /// <summary>
        /// ObjectConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-dataintegration.html#cfn-appintegrations-dataintegration-objectconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? ObjectConfiguration { get; set; }

        /// <summary>
        /// KmsKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-dataintegration.html#cfn-appintegrations-dataintegration-kmskey
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? KmsKey { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-dataintegration.html#cfn-appintegrations-dataintegration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DataIntegrationTypes
    {
        public class FileConfiguration : Humidifier.Base.BaseSubResource, IHaveFilters_Json, IHaveStringListOfFolders
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-dataintegration-fileconfiguration.html#cfn-appintegrations-dataintegration-fileconfiguration-filters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Filters { get; set; }
            /// <summary>
            /// Folders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-dataintegration-fileconfiguration.html#cfn-appintegrations-dataintegration-fileconfiguration-folders
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Folders { get; set; }
        }

        public class ScheduleConfig : Humidifier.Base.BaseSubResource, IHaveFirstExecutionFrom, IHaveScheduleExpression, IHaveObject
        {
            /// <summary>
            /// FirstExecutionFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-dataintegration-scheduleconfig.html#cfn-appintegrations-dataintegration-scheduleconfig-firstexecutionfrom
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FirstExecutionFrom { get; set; }
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-dataintegration-scheduleconfig.html#cfn-appintegrations-dataintegration-scheduleconfig-scheduleexpression
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleExpression { get; set; }
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-dataintegration-scheduleconfig.html#cfn-appintegrations-dataintegration-scheduleconfig-object
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
        }
    }
}