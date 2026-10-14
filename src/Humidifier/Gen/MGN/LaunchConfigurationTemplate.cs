namespace Humidifier.MGN
{
    using global::System.Collections.Generic;
    using LaunchConfigurationTemplateTypes;

    public class LaunchConfigurationTemplate : Humidifier.Base.BaseResource, IHaveTags, IHaveAssociatePublicIpAddress, IHaveCopyTags
    {
        public class Attributes
        {
            public static string LaunchConfigurationTemplateID =  "LaunchConfigurationTemplateID" ;
            public static string Ec2LaunchTemplateID =  "Ec2LaunchTemplateID" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MGN.LaunchConfigurationTemplate; }
        /// <summary>
        /// LargeVolumeConf
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-largevolumeconf
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LaunchTemplateDiskConf
        /// </summary>
        public Humidifier.MGN.LaunchConfigurationTemplateTypes.LaunchTemplateDiskConf LargeVolumeConf { get; set; }
        /// <summary>
        /// SmallVolumeConf
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-smallvolumeconf
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LaunchTemplateDiskConf
        /// </summary>
        public Humidifier.MGN.LaunchConfigurationTemplateTypes.LaunchTemplateDiskConf SmallVolumeConf { get; set; }
        /// <summary>
        /// CopyPrivateIp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-copyprivateip
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic CopyPrivateIp { get; set; }
        /// <summary>
        /// SmallVolumeMaxSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-smallvolumemaxsize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic SmallVolumeMaxSize { get; set; }
        /// <summary>
        /// BootMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-bootmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BootMode { get; set; }
        /// <summary>
        /// MapAutoTaggingMpeID
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-mapautotaggingmpeid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MapAutoTaggingMpeID { get; set; }
        /// <summary>
        /// EnableMapAutoTagging
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-enablemapautotagging
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableMapAutoTagging { get; set; }
        /// <summary>
        /// LaunchDisposition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-launchdisposition
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LaunchDisposition { get; set; }
        /// <summary>
        /// AssociatePublicIpAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-associatepublicipaddress
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AssociatePublicIpAddress { get; set; }
        /// <summary>
        /// Licensing
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-licensing
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Licensing
        /// </summary>
        public Humidifier.MGN.LaunchConfigurationTemplateTypes.Licensing Licensing { get; set; }
        /// <summary>
        /// EnableParametersEncryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-enableparametersencryption
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableParametersEncryption { get; set; }
        /// <summary>
        /// TargetInstanceTypeRightSizingMethod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-targetinstancetyperightsizingmethod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetInstanceTypeRightSizingMethod { get; set; }
        /// <summary>
        /// PostLaunchActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-postlaunchactions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PostLaunchActions
        /// </summary>
        public Humidifier.MGN.LaunchConfigurationTemplateTypes.PostLaunchActions PostLaunchActions { get; set; }
        /// <summary>
        /// ParametersEncryptionKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-parametersencryptionkey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ParametersEncryptionKey { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// CopyTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-copytags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic CopyTags { get; set; }
    }

    namespace LaunchConfigurationTemplateTypes
    {
        public class LaunchTemplateDiskConf : Humidifier.Base.BaseSubResource, IHaveIops, IHaveVolumeType, IHaveThroughput
        {
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-launchtemplatediskconf.html#cfn-mgn-launchconfigurationtemplate-launchtemplatediskconf-throughput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Throughput { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-launchtemplatediskconf.html#cfn-mgn-launchconfigurationtemplate-launchtemplatediskconf-volumetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeType { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-launchtemplatediskconf.html#cfn-mgn-launchconfigurationtemplate-launchtemplatediskconf-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Iops { get; set; }
        }

        public class Licensing : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OsByol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-licensing.html#cfn-mgn-launchconfigurationtemplate-licensing-osbyol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic OsByol { get; set; }
        }

        public class PostLaunchActions : Humidifier.Base.BaseSubResource, IHaveCloudWatchLogGroupName
        {
            /// <summary>
            /// SsmDocuments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-postlaunchactions.html#cfn-mgn-launchconfigurationtemplate-postlaunchactions-ssmdocuments
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SsmDocument
            /// </summary>
            public List<Humidifier.MGN.LaunchConfigurationTemplateTypes.SsmDocument> SsmDocuments { get; set; }
            /// <summary>
            /// S3LogBucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-postlaunchactions.html#cfn-mgn-launchconfigurationtemplate-postlaunchactions-s3logbucket
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3LogBucket { get; set; }
            /// <summary>
            /// CloudWatchLogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-postlaunchactions.html#cfn-mgn-launchconfigurationtemplate-postlaunchactions-cloudwatchloggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CloudWatchLogGroupName { get; set; }
            /// <summary>
            /// S3OutputKeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-postlaunchactions.html#cfn-mgn-launchconfigurationtemplate-postlaunchactions-s3outputkeyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3OutputKeyPrefix { get; set; }
            /// <summary>
            /// Deployment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-postlaunchactions.html#cfn-mgn-launchconfigurationtemplate-postlaunchactions-deployment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Deployment { get; set; }
        }

        public class SsmDocument : Humidifier.Base.BaseSubResource, IHaveParameters, IHaveActionName, IHaveTimeoutSeconds
        {
            /// <summary>
            /// TimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-ssmdocument.html#cfn-mgn-launchconfigurationtemplate-ssmdocument-timeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutSeconds { get; set; }
            /// <summary>
            /// ActionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-ssmdocument.html#cfn-mgn-launchconfigurationtemplate-ssmdocument-actionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionName { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-ssmdocument.html#cfn-mgn-launchconfigurationtemplate-ssmdocument-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Parameters { get; set; }
            /// <summary>
            /// SsmDocumentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-ssmdocument.html#cfn-mgn-launchconfigurationtemplate-ssmdocument-ssmdocumentname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SsmDocumentName { get; set; }
            /// <summary>
            /// ExternalParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-ssmdocument.html#cfn-mgn-launchconfigurationtemplate-ssmdocument-externalparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: SsmExternalParameter
            /// </summary>
            public Dictionary<string, Humidifier.MGN.LaunchConfigurationTemplateTypes.SsmExternalParameter> ExternalParameters { get; set; }
            /// <summary>
            /// MustSucceedForCutover
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-ssmdocument.html#cfn-mgn-launchconfigurationtemplate-ssmdocument-mustsucceedforcutover
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic MustSucceedForCutover { get; set; }
        }

        public class SsmExternalParameter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DynamicPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-ssmexternalparameter.html#cfn-mgn-launchconfigurationtemplate-ssmexternalparameter-dynamicpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DynamicPath { get; set; }
        }
    }
}