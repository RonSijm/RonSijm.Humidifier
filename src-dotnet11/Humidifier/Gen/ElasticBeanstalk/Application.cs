namespace Humidifier.ElasticBeanstalk
{
    using global::System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveApplicationName, IHaveDescription, IHaveElasticBeanstalkApplicationTypesApplicationResourceLifecycleConfigResourceLifecycleConfig
    {
        public override string AWSTypeName { get => AWS.ElasticBeanstalk.Application; }
        public Union<string, BaseFunction>? ApplicationName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-application.html#cfn-elasticbeanstalk-application-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ResourceLifecycleConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-application.html#cfn-elasticbeanstalk-application-resourcelifecycleconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ApplicationResourceLifecycleConfig
        /// </summary>
        public Union<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig, BaseFunction>? ResourceLifecycleConfig { get; set; }
    }

    namespace ApplicationTypes
    {
        public class ApplicationResourceLifecycleConfig : Humidifier.Base.BaseSubResource, IHaveServiceRole, IHaveElasticBeanstalkApplicationTypesApplicationVersionLifecycleConfigVersionLifecycleConfig
        {
            /// <summary>
            /// ServiceRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationresourcelifecycleconfig.html#cfn-elasticbeanstalk-application-applicationresourcelifecycleconfig-servicerole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceRole { get; set; }
            /// <summary>
            /// VersionLifecycleConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationresourcelifecycleconfig.html#cfn-elasticbeanstalk-application-applicationresourcelifecycleconfig-versionlifecycleconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApplicationVersionLifecycleConfig
            /// </summary>
            public Union<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationVersionLifecycleConfig, BaseFunction>? VersionLifecycleConfig { get; set; }
        }

        public class ApplicationVersionLifecycleConfig : Humidifier.Base.BaseSubResource, IHaveElasticBeanstalkApplicationTypesMaxCountRuleMaxCountRule, IHaveElasticBeanstalkApplicationTypesMaxAgeRuleMaxAgeRule
        {
            /// <summary>
            /// MaxCountRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationversionlifecycleconfig.html#cfn-elasticbeanstalk-application-applicationversionlifecycleconfig-maxcountrule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaxCountRule
            /// </summary>
            public Union<Humidifier.ElasticBeanstalk.ApplicationTypes.MaxCountRule, BaseFunction>? MaxCountRule { get; set; }
            /// <summary>
            /// MaxAgeRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationversionlifecycleconfig.html#cfn-elasticbeanstalk-application-applicationversionlifecycleconfig-maxagerule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaxAgeRule
            /// </summary>
            public Union<Humidifier.ElasticBeanstalk.ApplicationTypes.MaxAgeRule, BaseFunction>? MaxAgeRule { get; set; }
        }

        public class MaxAgeRule : Humidifier.Base.BaseSubResource, IHaveDeleteSourceFromS3_Boolean, IHaveMaxAgeInDays_Integer, IHaveEnabled_Boolean
        {
            /// <summary>
            /// DeleteSourceFromS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxagerule.html#cfn-elasticbeanstalk-application-maxagerule-deletesourcefroms3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeleteSourceFromS3 { get; set; }
            /// <summary>
            /// MaxAgeInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxagerule.html#cfn-elasticbeanstalk-application-maxagerule-maxageindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxAgeInDays { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxagerule.html#cfn-elasticbeanstalk-application-maxagerule-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class MaxCountRule : Humidifier.Base.BaseSubResource, IHaveDeleteSourceFromS3_Boolean, IHaveEnabled_Boolean, IHaveMaxCount_Integer
        {
            /// <summary>
            /// DeleteSourceFromS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxcountrule.html#cfn-elasticbeanstalk-application-maxcountrule-deletesourcefroms3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeleteSourceFromS3 { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxcountrule.html#cfn-elasticbeanstalk-application-maxcountrule-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// MaxCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxcountrule.html#cfn-elasticbeanstalk-application-maxcountrule-maxcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCount { get; set; }
        }
    }
}