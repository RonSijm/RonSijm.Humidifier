namespace Humidifier.QBusiness
{
    using System.Collections.Generic;
    using DataSourceTypes;

    public class DataSource : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveRoleArn, IHaveDisplayName, IHaveApplicationId, IHaveConfiguration, IHaveIndexId
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
        public dynamic IndexId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public dynamic Configuration { get; set; }
        /// <summary>
        /// SyncSchedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-syncschedule
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SyncSchedule { get; set; }
        /// <summary>
        /// DocumentEnrichmentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-documentenrichmentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DocumentEnrichmentConfiguration
        /// </summary>
        public Humidifier.QBusiness.DataSourceTypes.DocumentEnrichmentConfiguration DocumentEnrichmentConfiguration { get; set; }
        /// <summary>
        /// MediaExtractionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-mediaextractionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MediaExtractionConfiguration
        /// </summary>
        public Humidifier.QBusiness.DataSourceTypes.MediaExtractionConfiguration MediaExtractionConfiguration { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// VpcConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-vpcconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSourceVpcConfiguration
        /// </summary>
        public Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ApplicationId { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-datasource.html#cfn-qbusiness-datasource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace DataSourceTypes
    {
        public class DataSourceVpcConfiguration : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds
        {
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-datasourcevpcconfiguration.html#cfn-qbusiness-datasource-datasourcevpcconfiguration-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-datasourcevpcconfiguration.html#cfn-qbusiness-datasource-datasourcevpcconfiguration-securitygroupids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }

        public class DocumentAttributeCondition : Humidifier.Base.BaseSubResource, IHaveKey, IHaveOperator, IHaveQBusinessDataSourceTypesDocumentAttributeValueValue
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributecondition.html#cfn-qbusiness-datasource-documentattributecondition-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributecondition.html#cfn-qbusiness-datasource-documentattributecondition-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeValue
            /// </summary>
            public Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributecondition.html#cfn-qbusiness-datasource-documentattributecondition-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class DocumentAttributeTarget : Humidifier.Base.BaseSubResource, IHaveKey, IHaveQBusinessDataSourceTypesDocumentAttributeValueValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributetarget.html#cfn-qbusiness-datasource-documentattributetarget-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeValue
            /// </summary>
            public Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue Value { get; set; }
            /// <summary>
            /// AttributeValueOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributetarget.html#cfn-qbusiness-datasource-documentattributetarget-attributevalueoperator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeValueOperator { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributetarget.html#cfn-qbusiness-datasource-documentattributetarget-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class DocumentAttributeValue : Humidifier.Base.BaseSubResource, IHaveStringValue, IHaveLongValue, IHaveDateValue, IHaveStringListValue
        {
            /// <summary>
            /// DateValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributevalue.html#cfn-qbusiness-datasource-documentattributevalue-datevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateValue { get; set; }
            /// <summary>
            /// LongValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributevalue.html#cfn-qbusiness-datasource-documentattributevalue-longvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic LongValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributevalue.html#cfn-qbusiness-datasource-documentattributevalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StringValue { get; set; }
            /// <summary>
            /// StringListValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentattributevalue.html#cfn-qbusiness-datasource-documentattributevalue-stringlistvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StringListValue { get; set; }
        }

        public class DocumentEnrichmentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InlineConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentenrichmentconfiguration.html#cfn-qbusiness-datasource-documentenrichmentconfiguration-inlineconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InlineDocumentEnrichmentConfiguration
            /// </summary>
            public List<Humidifier.QBusiness.DataSourceTypes.InlineDocumentEnrichmentConfiguration> InlineConfigurations { get; set; }
            /// <summary>
            /// PreExtractionHookConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentenrichmentconfiguration.html#cfn-qbusiness-datasource-documentenrichmentconfiguration-preextractionhookconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HookConfiguration
            /// </summary>
            public Humidifier.QBusiness.DataSourceTypes.HookConfiguration PreExtractionHookConfiguration { get; set; }
            /// <summary>
            /// PostExtractionHookConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-documentenrichmentconfiguration.html#cfn-qbusiness-datasource-documentenrichmentconfiguration-postextractionhookconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HookConfiguration
            /// </summary>
            public Humidifier.QBusiness.DataSourceTypes.HookConfiguration PostExtractionHookConfiguration { get; set; }
        }

        public class HookConfiguration : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveS3BucketName, IHaveLambdaArn
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-hookconfiguration.html#cfn-qbusiness-datasource-hookconfiguration-lambdaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaArn { get; set; }
            /// <summary>
            /// InvocationCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-hookconfiguration.html#cfn-qbusiness-datasource-hookconfiguration-invocationcondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeCondition
            /// </summary>
            public Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition InvocationCondition { get; set; }
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-hookconfiguration.html#cfn-qbusiness-datasource-hookconfiguration-s3bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketName { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-hookconfiguration.html#cfn-qbusiness-datasource-hookconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class ImageExtractionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ImageExtractionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-imageextractionconfiguration.html#cfn-qbusiness-datasource-imageextractionconfiguration-imageextractionstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageExtractionStatus { get; set; }
        }

        public class InlineDocumentEnrichmentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-inlinedocumentenrichmentconfiguration.html#cfn-qbusiness-datasource-inlinedocumentenrichmentconfiguration-condition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeCondition
            /// </summary>
            public Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition Condition { get; set; }
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-inlinedocumentenrichmentconfiguration.html#cfn-qbusiness-datasource-inlinedocumentenrichmentconfiguration-target
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeTarget
            /// </summary>
            public Humidifier.QBusiness.DataSourceTypes.DocumentAttributeTarget Target { get; set; }
            /// <summary>
            /// DocumentContentOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-inlinedocumentenrichmentconfiguration.html#cfn-qbusiness-datasource-inlinedocumentenrichmentconfiguration-documentcontentoperator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentContentOperator { get; set; }
        }

        public class MediaExtractionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ImageExtractionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-datasource-mediaextractionconfiguration.html#cfn-qbusiness-datasource-mediaextractionconfiguration-imageextractionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageExtractionConfiguration
            /// </summary>
            public Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration ImageExtractionConfiguration { get; set; }
        }
    }
}