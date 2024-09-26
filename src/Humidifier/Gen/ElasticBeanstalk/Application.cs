namespace Humidifier.ElasticBeanstalk
{
    using System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveApplicationName
    {
        public override string AWSTypeName { get => AWS.ElasticBeanstalk.Application; }
        public dynamic ApplicationName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-application.html#cfn-elasticbeanstalk-application-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// ResourceLifecycleConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-application.html#cfn-elasticbeanstalk-application-resourcelifecycleconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ApplicationResourceLifecycleConfig
        /// </summary>
        public Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig ResourceLifecycleConfig { get; set; }
    }

    namespace ApplicationTypes
    {
        public class ApplicationResourceLifecycleConfig : Humidifier.Base.BaseSubResource, IHaveServiceRole
        {
            /// <summary>
            /// ServiceRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationresourcelifecycleconfig.html#cfn-elasticbeanstalk-application-applicationresourcelifecycleconfig-servicerole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceRole { get; set; }
            /// <summary>
            /// VersionLifecycleConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationresourcelifecycleconfig.html#cfn-elasticbeanstalk-application-applicationresourcelifecycleconfig-versionlifecycleconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApplicationVersionLifecycleConfig
            /// </summary>
            public Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationVersionLifecycleConfig VersionLifecycleConfig { get; set; }
        }

        public class ApplicationVersionLifecycleConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxCountRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationversionlifecycleconfig.html#cfn-elasticbeanstalk-application-applicationversionlifecycleconfig-maxcountrule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaxCountRule
            /// </summary>
            public Humidifier.ElasticBeanstalk.ApplicationTypes.MaxCountRule MaxCountRule { get; set; }
            /// <summary>
            /// MaxAgeRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationversionlifecycleconfig.html#cfn-elasticbeanstalk-application-applicationversionlifecycleconfig-maxagerule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaxAgeRule
            /// </summary>
            public Humidifier.ElasticBeanstalk.ApplicationTypes.MaxAgeRule MaxAgeRule { get; set; }
        }

        public class MaxAgeRule : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// DeleteSourceFromS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxagerule.html#cfn-elasticbeanstalk-application-maxagerule-deletesourcefroms3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DeleteSourceFromS3 { get; set; }
            /// <summary>
            /// MaxAgeInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxagerule.html#cfn-elasticbeanstalk-application-maxagerule-maxageindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxAgeInDays { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxagerule.html#cfn-elasticbeanstalk-application-maxagerule-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class MaxCountRule : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// DeleteSourceFromS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxcountrule.html#cfn-elasticbeanstalk-application-maxcountrule-deletesourcefroms3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DeleteSourceFromS3 { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxcountrule.html#cfn-elasticbeanstalk-application-maxcountrule-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// MaxCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxcountrule.html#cfn-elasticbeanstalk-application-maxcountrule-maxcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxCount { get; set; }
        }
    }
}