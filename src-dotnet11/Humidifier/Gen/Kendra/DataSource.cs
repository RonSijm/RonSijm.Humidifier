namespace Humidifier.Kendra
{
    using global::System.Collections.Generic;
    using DataSourceTypes;

    public class DataSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveKendraDataSourceTypesCustomDocumentEnrichmentConfigurationCustomDocumentEnrichmentConfiguration, IHaveIndexId, IHaveLanguageCode, IHaveType, IHaveDescription, IHaveSchedule, IHaveKendraDataSourceTypesDataSourceConfigurationDataSourceConfiguration, IHaveRoleArn, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Kendra.DataSource; }
        /// <summary>
        /// CustomDocumentEnrichmentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-customdocumentenrichmentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomDocumentEnrichmentConfiguration
        /// </summary>
        public Union<Humidifier.Kendra.DataSourceTypes.CustomDocumentEnrichmentConfiguration, BaseFunction>? CustomDocumentEnrichmentConfiguration { get; set; }

        /// <summary>
        /// IndexId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-indexid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IndexId { get; set; }
        /// <summary>
        /// LanguageCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-languagecode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LanguageCode { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-schedule
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Schedule { get; set; }
        /// <summary>
        /// DataSourceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-datasourceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSourceConfiguration
        /// </summary>
        public Union<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration, BaseFunction>? DataSourceConfiguration { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DataSourceTypes
    {
        public class CustomDocumentEnrichmentConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfKendraDataSourceTypesInlineCustomDocumentEnrichmentConfigurationInlineConfigurations, IHaveKendraDataSourceTypesHookConfigurationPreExtractionHookConfiguration, IHaveKendraDataSourceTypesHookConfigurationPostExtractionHookConfiguration, IHaveRoleArn
        {
            /// <summary>
            /// InlineConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-customdocumentenrichmentconfiguration.html#cfn-kendra-datasource-customdocumentenrichmentconfiguration-inlineconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InlineCustomDocumentEnrichmentConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Kendra.DataSourceTypes.InlineCustomDocumentEnrichmentConfiguration>, IReadOnlyList<Union<Humidifier.Kendra.DataSourceTypes.InlineCustomDocumentEnrichmentConfiguration, BaseFunction>>, BaseFunction>? InlineConfigurations { get; set; }
            /// <summary>
            /// PreExtractionHookConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-customdocumentenrichmentconfiguration.html#cfn-kendra-datasource-customdocumentenrichmentconfiguration-preextractionhookconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HookConfiguration
            /// </summary>
            public Union<Humidifier.Kendra.DataSourceTypes.HookConfiguration, BaseFunction>? PreExtractionHookConfiguration { get; set; }
            /// <summary>
            /// PostExtractionHookConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-customdocumentenrichmentconfiguration.html#cfn-kendra-datasource-customdocumentenrichmentconfiguration-postextractionhookconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HookConfiguration
            /// </summary>
            public Union<Humidifier.Kendra.DataSourceTypes.HookConfiguration, BaseFunction>? PostExtractionHookConfiguration { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-customdocumentenrichmentconfiguration.html#cfn-kendra-datasource-customdocumentenrichmentconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class DataSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveKendraDataSourceTypesTemplateConfigurationTemplateConfiguration
        {
            /// <summary>
            /// TemplateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourceconfiguration.html#cfn-kendra-datasource-datasourceconfiguration-templateconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TemplateConfiguration
            /// </summary>
            public Union<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration, BaseFunction>? TemplateConfiguration { get; set; }
        }

        public class DocumentAttributeCondition : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveConditionDocumentAttributeKey, IHaveKendraDataSourceTypesDocumentAttributeValueConditionOnValue
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributecondition.html#cfn-kendra-datasource-documentattributecondition-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// ConditionDocumentAttributeKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributecondition.html#cfn-kendra-datasource-documentattributecondition-conditiondocumentattributekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConditionDocumentAttributeKey { get; set; }
            /// <summary>
            /// ConditionOnValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributecondition.html#cfn-kendra-datasource-documentattributecondition-conditiononvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeValue
            /// </summary>
            public Union<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue, BaseFunction>? ConditionOnValue { get; set; }
        }

        public class DocumentAttributeTarget : Humidifier.Base.BaseSubResource, IHaveTargetDocumentAttributeKey, IHaveTargetDocumentAttributeValueDeletion_Boolean, IHaveKendraDataSourceTypesDocumentAttributeValueTargetDocumentAttributeValue
        {
            /// <summary>
            /// TargetDocumentAttributeKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributetarget.html#cfn-kendra-datasource-documentattributetarget-targetdocumentattributekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetDocumentAttributeKey { get; set; }
            /// <summary>
            /// TargetDocumentAttributeValueDeletion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributetarget.html#cfn-kendra-datasource-documentattributetarget-targetdocumentattributevaluedeletion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? TargetDocumentAttributeValueDeletion { get; set; }
            /// <summary>
            /// TargetDocumentAttributeValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributetarget.html#cfn-kendra-datasource-documentattributetarget-targetdocumentattributevalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeValue
            /// </summary>
            public Union<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue, BaseFunction>? TargetDocumentAttributeValue { get; set; }
        }

        public class DocumentAttributeValue : Humidifier.Base.BaseSubResource, IHaveLongValue_Long, IHaveStringValue, IHaveStringListOfStringListValue, IHaveDateValue
        {
            /// <summary>
            /// LongValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributevalue.html#cfn-kendra-datasource-documentattributevalue-longvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? LongValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributevalue.html#cfn-kendra-datasource-documentattributevalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StringValue { get; set; }
            /// <summary>
            /// StringListValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributevalue.html#cfn-kendra-datasource-documentattributevalue-stringlistvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StringListValue { get; set; }
            /// <summary>
            /// DateValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentattributevalue.html#cfn-kendra-datasource-documentattributevalue-datevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DateValue { get; set; }
        }

        public class HookConfiguration : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveKendraDataSourceTypesDocumentAttributeConditionInvocationCondition, IHaveLambdaArn
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-hookconfiguration.html#cfn-kendra-datasource-hookconfiguration-s3bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// InvocationCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-hookconfiguration.html#cfn-kendra-datasource-hookconfiguration-invocationcondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeCondition
            /// </summary>
            public Union<Humidifier.Kendra.DataSourceTypes.DocumentAttributeCondition, BaseFunction>? InvocationCondition { get; set; }
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-hookconfiguration.html#cfn-kendra-datasource-hookconfiguration-lambdaarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaArn { get; set; }
        }

        public class InlineCustomDocumentEnrichmentConfiguration : Humidifier.Base.BaseSubResource, IHaveKendraDataSourceTypesDocumentAttributeConditionCondition, IHaveKendraDataSourceTypesDocumentAttributeTargetTarget, IHaveDocumentContentDeletion_Boolean
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-inlinecustomdocumentenrichmentconfiguration.html#cfn-kendra-datasource-inlinecustomdocumentenrichmentconfiguration-condition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeCondition
            /// </summary>
            public Union<Humidifier.Kendra.DataSourceTypes.DocumentAttributeCondition, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-inlinecustomdocumentenrichmentconfiguration.html#cfn-kendra-datasource-inlinecustomdocumentenrichmentconfiguration-target
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttributeTarget
            /// </summary>
            public Union<Humidifier.Kendra.DataSourceTypes.DocumentAttributeTarget, BaseFunction>? Target { get; set; }
            /// <summary>
            /// DocumentContentDeletion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-inlinecustomdocumentenrichmentconfiguration.html#cfn-kendra-datasource-inlinecustomdocumentenrichmentconfiguration-documentcontentdeletion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DocumentContentDeletion { get; set; }
        }

        public class TemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveTemplate_Json
        {
            /// <summary>
            /// Template
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-templateconfiguration.html#cfn-kendra-datasource-templateconfiguration-template
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Template { get; set; }
        }
    }
}