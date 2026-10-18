namespace Humidifier.CloudFormation
{
    using global::System.Collections.Generic;
    using GeneratedTemplateTypes;

    public class GeneratedTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveCloudFormationGeneratedTemplateTypesTemplateConfigurationTemplateConfiguration, IHaveGeneratedTemplateName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Progress =  "Progress" ;
            public static string CreationTime =  "CreationTime" ;
            public static string TotalWarnings =  "TotalWarnings" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string GeneratedTemplateId =  "GeneratedTemplateId" ;
        }

        public override string AWSTypeName { get => AWS.CloudFormation.GeneratedTemplate; }
        /// <summary>
        /// TemplateConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-generatedtemplate.html#cfn-cloudformation-generatedtemplate-templateconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TemplateConfiguration
        /// </summary>
        public Union<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration, BaseFunction>? TemplateConfiguration { get; set; }
        public Union<string, BaseFunction>? GeneratedTemplateName { get => GivenName; set => GivenName = value; }
    }

    namespace GeneratedTemplateTypes
    {
        public class TemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveDeletionPolicy, IHaveUpdateReplacePolicy
        {
            /// <summary>
            /// DeletionPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-generatedtemplate-templateconfiguration.html#cfn-cloudformation-generatedtemplate-templateconfiguration-deletionpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeletionPolicy { get; set; }
            /// <summary>
            /// UpdateReplacePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-generatedtemplate-templateconfiguration.html#cfn-cloudformation-generatedtemplate-templateconfiguration-updatereplacepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateReplacePolicy { get; set; }
        }

        public class TemplateProgress : Humidifier.Base.BaseSubResource, IHaveResourcesSucceeded_Integer, IHaveResourcesPending_Integer, IHaveResourcesFailed_Integer, IHaveResourcesProcessing_Integer
        {
            /// <summary>
            /// ResourcesSucceeded
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-generatedtemplate-templateprogress.html#cfn-cloudformation-generatedtemplate-templateprogress-resourcessucceeded
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ResourcesSucceeded { get; set; }
            /// <summary>
            /// ResourcesPending
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-generatedtemplate-templateprogress.html#cfn-cloudformation-generatedtemplate-templateprogress-resourcespending
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ResourcesPending { get; set; }
            /// <summary>
            /// ResourcesFailed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-generatedtemplate-templateprogress.html#cfn-cloudformation-generatedtemplate-templateprogress-resourcesfailed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ResourcesFailed { get; set; }
            /// <summary>
            /// ResourcesProcessing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-generatedtemplate-templateprogress.html#cfn-cloudformation-generatedtemplate-templateprogress-resourcesprocessing
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ResourcesProcessing { get; set; }
        }
    }
}