namespace Humidifier.Cases
{
    using global::System.Collections.Generic;
    using TemplateTypes;

    public class Template : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStatus, IHaveCasesTemplateTypesLayoutConfigurationLayoutConfiguration, IHaveDomainId, IHaveDescription, IHaveListOfCasesTemplateTypesRequiredFieldRequiredFields, IHaveListOfCasesTemplateTypesTemplateRuleRules, IHaveName
    {
        public class Attributes
        {
            public static string TemplateArn =  "TemplateArn" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string TemplateId =  "TemplateId" ;
        }

        public override string AWSTypeName { get => AWS.Cases.Template; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-template.html#cfn-cases-template-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }
        /// <summary>
        /// LayoutConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-template.html#cfn-cases-template-layoutconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LayoutConfiguration
        /// </summary>
        public Union<Humidifier.Cases.TemplateTypes.LayoutConfiguration, BaseFunction>? LayoutConfiguration { get; set; }
        /// <summary>
        /// DomainId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-template.html#cfn-cases-template-domainid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DomainId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-template.html#cfn-cases-template-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// RequiredFields
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-template.html#cfn-cases-template-requiredfields
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: RequiredField
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Cases.TemplateTypes.RequiredField>, IReadOnlyList<Union<Humidifier.Cases.TemplateTypes.RequiredField, BaseFunction>>, BaseFunction>? RequiredFields { get; set; }
        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-template.html#cfn-cases-template-rules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TemplateRule
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Cases.TemplateTypes.TemplateRule>, IReadOnlyList<Union<Humidifier.Cases.TemplateTypes.TemplateRule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-template.html#cfn-cases-template-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace TemplateTypes
    {
        public class LayoutConfiguration : Humidifier.Base.BaseSubResource, IHaveDefaultLayout
        {
            /// <summary>
            /// DefaultLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-template-layoutconfiguration.html#cfn-cases-template-layoutconfiguration-defaultlayout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultLayout { get; set; }
        }

        public class RequiredField : Humidifier.Base.BaseSubResource, IHaveFieldId
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-template-requiredfield.html#cfn-cases-template-requiredfield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldId { get; set; }
        }

        public class TemplateRule : Humidifier.Base.BaseSubResource, IHaveCaseRuleId, IHaveFieldId
        {
            /// <summary>
            /// CaseRuleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-template-templaterule.html#cfn-cases-template-templaterule-caseruleid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CaseRuleId { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-template-templaterule.html#cfn-cases-template-templaterule-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldId { get; set; }
        }
    }
}