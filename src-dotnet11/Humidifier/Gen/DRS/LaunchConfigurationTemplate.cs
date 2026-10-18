namespace Humidifier.DRS
{
    using global::System.Collections.Generic;
    using LaunchConfigurationTemplateTypes;

    public class LaunchConfigurationTemplate : Humidifier.Base.BaseResource, IHaveTags, IHaveTargetInstanceTypeRightSizingMethod, IHaveLaunchIntoSourceInstance_Boolean, IHaveCopyPrivateIp_Boolean, IHaveLaunchDisposition, IHavePostLaunchEnabled_Boolean, IHaveExportBucketArn, IHaveDRSLaunchConfigurationTemplateTypesLicensingLicensing, IHaveCopyTags_Boolean
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
        public Union<string, BaseFunction>? TargetInstanceTypeRightSizingMethod { get; set; }
        /// <summary>
        /// LaunchIntoSourceInstance
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-launchconfigurationtemplate.html#cfn-drs-launchconfigurationtemplate-launchintosourceinstance
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? LaunchIntoSourceInstance { get; set; }
        /// <summary>
        /// CopyPrivateIp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-launchconfigurationtemplate.html#cfn-drs-launchconfigurationtemplate-copyprivateip
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? CopyPrivateIp { get; set; }
        /// <summary>
        /// LaunchDisposition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-launchconfigurationtemplate.html#cfn-drs-launchconfigurationtemplate-launchdisposition
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LaunchDisposition { get; set; }
        /// <summary>
        /// PostLaunchEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-launchconfigurationtemplate.html#cfn-drs-launchconfigurationtemplate-postlaunchenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PostLaunchEnabled { get; set; }
        /// <summary>
        /// ExportBucketArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-launchconfigurationtemplate.html#cfn-drs-launchconfigurationtemplate-exportbucketarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExportBucketArn { get; set; }
        /// <summary>
        /// Licensing
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-launchconfigurationtemplate.html#cfn-drs-launchconfigurationtemplate-licensing
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Licensing
        /// </summary>
        public Union<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing, BaseFunction>? Licensing { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-launchconfigurationtemplate.html#cfn-drs-launchconfigurationtemplate-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// CopyTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-launchconfigurationtemplate.html#cfn-drs-launchconfigurationtemplate-copytags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? CopyTags { get; set; }
    }

    namespace LaunchConfigurationTemplateTypes
    {
        public class Licensing : Humidifier.Base.BaseSubResource, IHaveOsByol_Boolean
        {
            /// <summary>
            /// OsByol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-launchconfigurationtemplate-licensing.html#cfn-drs-launchconfigurationtemplate-licensing-osbyol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OsByol { get; set; }
        }
    }
}