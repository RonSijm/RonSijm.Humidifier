namespace Humidifier.DRS
{
    using global::System.Collections.Generic;
    using LaunchConfigurationTemplateTypes;

    public class LaunchConfigurationTemplate : Humidifier.Base.BaseResource, IHaveTags, IHaveCopyTags
    {
        public class Attributes
        {
            public static string LaunchConfigurationTemplateID =  "LaunchConfigurationTemplateID" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.DRS.LaunchConfigurationTemplate; }
        /// <summary>
        /// TargetInstanceTypeRightSizingMethod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-launchconfigurationtemplate.html#cfn-drs-launchconfigurationtemplate-targetinstancetyperightsizingmethod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetInstanceTypeRightSizingMethod { get; set; }
        /// <summary>
        /// LaunchIntoSourceInstance
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-launchconfigurationtemplate.html#cfn-drs-launchconfigurationtemplate-launchintosourceinstance
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic LaunchIntoSourceInstance { get; set; }
        /// <summary>
        /// CopyPrivateIp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-launchconfigurationtemplate.html#cfn-drs-launchconfigurationtemplate-copyprivateip
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic CopyPrivateIp { get; set; }
        /// <summary>
        /// LaunchDisposition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-launchconfigurationtemplate.html#cfn-drs-launchconfigurationtemplate-launchdisposition
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LaunchDisposition { get; set; }
        /// <summary>
        /// PostLaunchEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-launchconfigurationtemplate.html#cfn-drs-launchconfigurationtemplate-postlaunchenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic PostLaunchEnabled { get; set; }
        /// <summary>
        /// ExportBucketArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-launchconfigurationtemplate.html#cfn-drs-launchconfigurationtemplate-exportbucketarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExportBucketArn { get; set; }
        /// <summary>
        /// Licensing
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-launchconfigurationtemplate.html#cfn-drs-launchconfigurationtemplate-licensing
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Licensing
        /// </summary>
        public Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing Licensing { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-launchconfigurationtemplate.html#cfn-drs-launchconfigurationtemplate-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// CopyTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-launchconfigurationtemplate.html#cfn-drs-launchconfigurationtemplate-copytags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic CopyTags { get; set; }
    }

    namespace LaunchConfigurationTemplateTypes
    {
        public class Licensing : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OsByol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-launchconfigurationtemplate-licensing.html#cfn-drs-launchconfigurationtemplate-licensing-osbyol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic OsByol { get; set; }
        }
    }
}