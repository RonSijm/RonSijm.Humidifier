namespace Humidifier.ElasticBeanstalk
{
    using global::System.Collections.Generic;
    using ConfigurationTemplateTypes;

    public class ConfigurationTemplate : Humidifier.Base.BaseResource, IHaveEnvironmentId, IHavePlatformArn, IHaveApplicationName, IHaveDescription, IHaveListOfElasticBeanstalkConfigurationTemplateTypesConfigurationOptionSettingOptionSettings, IHaveElasticBeanstalkConfigurationTemplateTypesSourceConfigurationSourceConfiguration, IHaveSolutionStackName
    {
        public class Attributes
        {
            public static string TemplateName =  "TemplateName" ;
        }

        public override string AWSTypeName { get => AWS.ElasticBeanstalk.ConfigurationTemplate; }
        /// <summary>
        /// EnvironmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-environmentid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentId { get; set; }
        /// <summary>
        /// PlatformArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-platformarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PlatformArn { get; set; }

        /// <summary>
        /// ApplicationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-applicationname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationName { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// OptionSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-optionsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ConfigurationOptionSetting
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting>, IReadOnlyList<Union<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting, BaseFunction>>, BaseFunction>? OptionSettings { get; set; }
        /// <summary>
        /// SourceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-sourceconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SourceConfiguration
        /// </summary>
        public Union<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration, BaseFunction>? SourceConfiguration { get; set; }
        /// <summary>
        /// SolutionStackName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-solutionstackname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SolutionStackName { get; set; }
    }

    namespace ConfigurationTemplateTypes
    {
        public class ConfigurationOptionSetting : Humidifier.Base.BaseSubResource, IHaveResourceName, IHaveValue, IHaveNamespace_, IHaveOptionName
        {
            /// <summary>
            /// ResourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-configurationtemplate-configurationoptionsetting.html#cfn-elasticbeanstalk-configurationtemplate-configurationoptionsetting-resourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceName { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-configurationtemplate-configurationoptionsetting.html#cfn-elasticbeanstalk-configurationtemplate-configurationoptionsetting-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-configurationtemplate-configurationoptionsetting.html#cfn-elasticbeanstalk-configurationtemplate-configurationoptionsetting-namespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
            /// <summary>
            /// OptionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-configurationtemplate-configurationoptionsetting.html#cfn-elasticbeanstalk-configurationtemplate-configurationoptionsetting-optionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OptionName { get; set; }
        }

        public class SourceConfiguration : Humidifier.Base.BaseSubResource, IHaveApplicationName, IHaveTemplateName
        {
            /// <summary>
            /// ApplicationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-configurationtemplate-sourceconfiguration.html#cfn-elasticbeanstalk-configurationtemplate-sourceconfiguration-applicationname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationName { get; set; }
            /// <summary>
            /// TemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-configurationtemplate-sourceconfiguration.html#cfn-elasticbeanstalk-configurationtemplate-sourceconfiguration-templatename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemplateName { get; set; }
        }
    }
}