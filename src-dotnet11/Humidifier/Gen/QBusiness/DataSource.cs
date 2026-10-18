namespace Humidifier.QBusiness
{
    using global::System.Collections.Generic;
    using DataSourceTypes;

    public class DataSource : Humidifier.Base.BaseResource, IHaveTags, IHaveIndexId, IHaveDescription, IHaveConfiguration_Json, IHaveSyncSchedule, IHaveQBusinessDataSourceTypesDocumentEnrichmentConfigurationDocumentEnrichmentConfiguration, IHaveQBusinessDataSourceTypesMediaExtractionConfigurationMediaExtractionConfiguration, IHaveDisplayName, IHaveQBusinessDataSourceTypesDataSourceVpcConfigurationVpcConfiguration, IHaveApplicationId, IHaveRoleArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string DataSourceArn =  "DataSourceArn" ;
            public static string Type =  "Type" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string DataSourceId =  "DataSourceId" ;
        }

        public override string AWSTypeName { get => AWS.QBusiness.DataSource; }

        /// <summary>
        /// IndexId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-indexid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IndexId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// SyncSchedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-syncschedule
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SyncSchedule { get; set; }
        /// <summary>
        /// DocumentEnrichmentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-documentenrichmentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DocumentEnrichmentConfiguration
        /// </summary>
        public Union<Humidifier.QBusiness.DataSourceTypes.DocumentEnrichmentConfiguration, BaseFunction>? DocumentEnrichmentConfiguration { get; set; }
        /// <summary>
        /// MediaExtractionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-mediaextractionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MediaExtractionConfiguration
        /// </summary>
        public Union<Humidifier.QBusiness.DataSourceTypes.MediaExtractionConfiguration, BaseFunction>? MediaExtractionConfiguration { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// VpcConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-vpcconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSourceVpcConfiguration
        /// </summary>
        public Union<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration, BaseFunction>? VpcConfiguration { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationId { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DataSourceTypes
    {
        public class AudioExtractionConfiguration : Humidifier.Base.BaseSubResource, IHaveAudioExtractionStatus
        {
            /// <summary>
            /// AudioExtractionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-audioextractionconfiguration.html#cfn-qbusiness-datasource-audioextractionconfiguration-audioextractionstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioExtractionStatus { get; set; }
        }

        public class DataSourceVpcConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-datasourcevpcconfiguration.html#cfn-qbusiness-datasource-datasourcevpcconfiguration-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-datasourcevpcconfiguration.html#cfn-qbusiness-datasource-datasourcevpcconfiguration-securitygroupids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }

        public class DocumentAttributeCondition : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveQBusinessDataSourceTypesDocumentAttributeValueValue, IHaveKey
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributecondition.html#cfn-qbusiness-datasource-documentattributecondition-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributecondition.html#cfn-qbusiness-datasource-documentattributecondition-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeValue
            /// </summary>
            public Union<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributecondition.html#cfn-qbusiness-datasource-documentattributecondition-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class DocumentAttributeTarget : Humidifier.Base.BaseSubResource, IHaveQBusinessDataSourceTypesDocumentAttributeValueValue, IHaveAttributeValueOperator, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributetarget.html#cfn-qbusiness-datasource-documentattributetarget-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeValue
            /// </summary>
            public Union<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue, BaseFunction>? Value { get; set; }
            /// <summary>
            /// AttributeValueOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributetarget.html#cfn-qbusiness-datasource-documentattributetarget-attributevalueoperator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeValueOperator { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributetarget.html#cfn-qbusiness-datasource-documentattributetarget-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class DocumentAttributeValue : Humidifier.Base.BaseSubResource, IHaveLongValue_Double, IHaveStringValue, IHaveStringListOfStringListValue, IHaveDateValue
        {
            /// <summary>
            /// LongValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributevalue.html#cfn-qbusiness-datasource-documentattributevalue-longvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? LongValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributevalue.html#cfn-qbusiness-datasource-documentattributevalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StringValue { get; set; }
            /// <summary>
            /// StringListValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributevalue.html#cfn-qbusiness-datasource-documentattributevalue-stringlistvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StringListValue { get; set; }
            /// <summary>
            /// DateValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributevalue.html#cfn-qbusiness-datasource-documentattributevalue-datevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DateValue { get; set; }
        }

        public class DocumentEnrichmentConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfQBusinessDataSourceTypesInlineDocumentEnrichmentConfigurationInlineConfigurations, IHaveQBusinessDataSourceTypesHookConfigurationPreExtractionHookConfiguration, IHaveQBusinessDataSourceTypesHookConfigurationPostExtractionHookConfiguration
        {
            /// <summary>
            /// InlineConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentenrichmentconfiguration.html#cfn-qbusiness-datasource-documentenrichmentconfiguration-inlineconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InlineDocumentEnrichmentConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QBusiness.DataSourceTypes.InlineDocumentEnrichmentConfiguration>, IReadOnlyList<Union<Humidifier.QBusiness.DataSourceTypes.InlineDocumentEnrichmentConfiguration, BaseFunction>>, BaseFunction>? InlineConfigurations { get; set; }
            /// <summary>
            /// PreExtractionHookConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentenrichmentconfiguration.html#cfn-qbusiness-datasource-documentenrichmentconfiguration-preextractionhookconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HookConfiguration
            /// </summary>
            public Union<Humidifier.QBusiness.DataSourceTypes.HookConfiguration, BaseFunction>? PreExtractionHookConfiguration { get; set; }
            /// <summary>
            /// PostExtractionHookConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentenrichmentconfiguration.html#cfn-qbusiness-datasource-documentenrichmentconfiguration-postextractionhookconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HookConfiguration
            /// </summary>
            public Union<Humidifier.QBusiness.DataSourceTypes.HookConfiguration, BaseFunction>? PostExtractionHookConfiguration { get; set; }
        }

        public class HookConfiguration : Humidifier.Base.BaseSubResource, IHaveQBusinessDataSourceTypesDocumentAttributeConditionInvocationCondition, IHaveS3BucketName, IHaveLambdaArn, IHaveRoleArn
        {
            /// <summary>
            /// InvocationCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-hookconfiguration.html#cfn-qbusiness-datasource-hookconfiguration-invocationcondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeCondition
            /// </summary>
            public Union<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition, BaseFunction>? InvocationCondition { get; set; }
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-hookconfiguration.html#cfn-qbusiness-datasource-hookconfiguration-s3bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketName { get; set; }
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-hookconfiguration.html#cfn-qbusiness-datasource-hookconfiguration-lambdaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-hookconfiguration.html#cfn-qbusiness-datasource-hookconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class ImageExtractionConfiguration : Humidifier.Base.BaseSubResource, IHaveImageExtractionStatus
        {
            /// <summary>
            /// ImageExtractionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-imageextractionconfiguration.html#cfn-qbusiness-datasource-imageextractionconfiguration-imageextractionstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageExtractionStatus { get; set; }
        }

        public class InlineDocumentEnrichmentConfiguration : Humidifier.Base.BaseSubResource, IHaveQBusinessDataSourceTypesDocumentAttributeConditionCondition, IHaveQBusinessDataSourceTypesDocumentAttributeTargetTarget, IHaveDocumentContentOperator
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-inlinedocumentenrichmentconfiguration.html#cfn-qbusiness-datasource-inlinedocumentenrichmentconfiguration-condition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeCondition
            /// </summary>
            public Union<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-inlinedocumentenrichmentconfiguration.html#cfn-qbusiness-datasource-inlinedocumentenrichmentconfiguration-target
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeTarget
            /// </summary>
            public Union<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeTarget, BaseFunction>? Target { get; set; }
            /// <summary>
            /// DocumentContentOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-inlinedocumentenrichmentconfiguration.html#cfn-qbusiness-datasource-inlinedocumentenrichmentconfiguration-documentcontentoperator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentContentOperator { get; set; }
        }

        public class MediaExtractionConfiguration : Humidifier.Base.BaseSubResource, IHaveQBusinessDataSourceTypesVideoExtractionConfigurationVideoExtractionConfiguration, IHaveQBusinessDataSourceTypesAudioExtractionConfigurationAudioExtractionConfiguration, IHaveQBusinessDataSourceTypesImageExtractionConfigurationImageExtractionConfiguration
        {
            /// <summary>
            /// VideoExtractionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-mediaextractionconfiguration.html#cfn-qbusiness-datasource-mediaextractionconfiguration-videoextractionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoExtractionConfiguration
            /// </summary>
            public Union<Humidifier.QBusiness.DataSourceTypes.VideoExtractionConfiguration, BaseFunction>? VideoExtractionConfiguration { get; set; }
            /// <summary>
            /// AudioExtractionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-mediaextractionconfiguration.html#cfn-qbusiness-datasource-mediaextractionconfiguration-audioextractionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioExtractionConfiguration
            /// </summary>
            public Union<Humidifier.QBusiness.DataSourceTypes.AudioExtractionConfiguration, BaseFunction>? AudioExtractionConfiguration { get; set; }
            /// <summary>
            /// ImageExtractionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-mediaextractionconfiguration.html#cfn-qbusiness-datasource-mediaextractionconfiguration-imageextractionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageExtractionConfiguration
            /// </summary>
            public Union<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration, BaseFunction>? ImageExtractionConfiguration { get; set; }
        }

        public class VideoExtractionConfiguration : Humidifier.Base.BaseSubResource, IHaveVideoExtractionStatus
        {
            /// <summary>
            /// VideoExtractionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-videoextractionconfiguration.html#cfn-qbusiness-datasource-videoextractionconfiguration-videoextractionstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VideoExtractionStatus { get; set; }
        }
    }
}