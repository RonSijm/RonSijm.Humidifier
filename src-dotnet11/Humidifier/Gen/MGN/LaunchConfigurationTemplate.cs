namespace Humidifier.MGN
{
    using global::System.Collections.Generic;
    using LaunchConfigurationTemplateTypes;

    public class LaunchConfigurationTemplate : Humidifier.Base.BaseResource, IHaveTags, IHaveMGNLaunchConfigurationTemplateTypesLaunchTemplateDiskConfLargeVolumeConf, IHaveMGNLaunchConfigurationTemplateTypesLaunchTemplateDiskConfSmallVolumeConf, IHaveCopyPrivateIp_Boolean, IHaveSmallVolumeMaxSize_Integer, IHaveBootMode, IHaveMapAutoTaggingMpeID, IHaveEnableMapAutoTagging_Boolean, IHaveLaunchDisposition, IHaveAssociatePublicIpAddress_Boolean, IHaveMGNLaunchConfigurationTemplateTypesLicensingLicensing, IHaveEnableParametersEncryption_Boolean, IHaveTargetInstanceTypeRightSizingMethod, IHaveMGNLaunchConfigurationTemplateTypesPostLaunchActionsPostLaunchActions, IHaveParametersEncryptionKey, IHaveCopyTags_Boolean
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
        public Union<Humidifier.MGN.LaunchConfigurationTemplateTypes.LaunchTemplateDiskConf, BaseFunction>? LargeVolumeConf { get; set; }
        /// <summary>
        /// SmallVolumeConf
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-smallvolumeconf
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LaunchTemplateDiskConf
        /// </summary>
        public Union<Humidifier.MGN.LaunchConfigurationTemplateTypes.LaunchTemplateDiskConf, BaseFunction>? SmallVolumeConf { get; set; }
        /// <summary>
        /// CopyPrivateIp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-copyprivateip
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? CopyPrivateIp { get; set; }
        /// <summary>
        /// SmallVolumeMaxSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-smallvolumemaxsize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? SmallVolumeMaxSize { get; set; }
        /// <summary>
        /// BootMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-bootmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BootMode { get; set; }
        /// <summary>
        /// MapAutoTaggingMpeID
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-mapautotaggingmpeid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MapAutoTaggingMpeID { get; set; }
        /// <summary>
        /// EnableMapAutoTagging
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-enablemapautotagging
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableMapAutoTagging { get; set; }
        /// <summary>
        /// LaunchDisposition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-launchdisposition
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LaunchDisposition { get; set; }
        /// <summary>
        /// AssociatePublicIpAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-associatepublicipaddress
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AssociatePublicIpAddress { get; set; }
        /// <summary>
        /// Licensing
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-licensing
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Licensing
        /// </summary>
        public Union<Humidifier.MGN.LaunchConfigurationTemplateTypes.Licensing, BaseFunction>? Licensing { get; set; }
        /// <summary>
        /// EnableParametersEncryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-enableparametersencryption
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableParametersEncryption { get; set; }
        /// <summary>
        /// TargetInstanceTypeRightSizingMethod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-targetinstancetyperightsizingmethod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TargetInstanceTypeRightSizingMethod { get; set; }
        /// <summary>
        /// PostLaunchActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-postlaunchactions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PostLaunchActions
        /// </summary>
        public Union<Humidifier.MGN.LaunchConfigurationTemplateTypes.PostLaunchActions, BaseFunction>? PostLaunchActions { get; set; }
        /// <summary>
        /// ParametersEncryptionKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-parametersencryptionkey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ParametersEncryptionKey { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// CopyTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-launchconfigurationtemplate.html#cfn-mgn-launchconfigurationtemplate-copytags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? CopyTags { get; set; }
    }

    namespace LaunchConfigurationTemplateTypes
    {
        public class LaunchTemplateDiskConf : Humidifier.Base.BaseSubResource, IHaveThroughput_Integer, IHaveVolumeType, IHaveIops_Integer
        {
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-launchtemplatediskconf.html#cfn-mgn-launchconfigurationtemplate-launchtemplatediskconf-throughput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Throughput { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-launchtemplatediskconf.html#cfn-mgn-launchconfigurationtemplate-launchtemplatediskconf-volumetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-launchtemplatediskconf.html#cfn-mgn-launchconfigurationtemplate-launchtemplatediskconf-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
        }

        public class Licensing : Humidifier.Base.BaseSubResource, IHaveOsByol_Boolean
        {
            /// <summary>
            /// OsByol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-licensing.html#cfn-mgn-launchconfigurationtemplate-licensing-osbyol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OsByol { get; set; }
        }

        public class PostLaunchActions : Humidifier.Base.BaseSubResource, IHaveListOfMGNLaunchConfigurationTemplateTypesSsmDocumentSsmDocuments, IHaveS3LogBucket, IHaveCloudWatchLogGroupName, IHaveS3OutputKeyPrefix, IHaveDeployment
        {
            /// <summary>
            /// SsmDocuments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-postlaunchactions.html#cfn-mgn-launchconfigurationtemplate-postlaunchactions-ssmdocuments
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SsmDocument
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MGN.LaunchConfigurationTemplateTypes.SsmDocument>, IReadOnlyList<Union<Humidifier.MGN.LaunchConfigurationTemplateTypes.SsmDocument, BaseFunction>>, BaseFunction>? SsmDocuments { get; set; }
            /// <summary>
            /// S3LogBucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-postlaunchactions.html#cfn-mgn-launchconfigurationtemplate-postlaunchactions-s3logbucket
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3LogBucket { get; set; }
            /// <summary>
            /// CloudWatchLogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-postlaunchactions.html#cfn-mgn-launchconfigurationtemplate-postlaunchactions-cloudwatchloggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CloudWatchLogGroupName { get; set; }
            /// <summary>
            /// S3OutputKeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-postlaunchactions.html#cfn-mgn-launchconfigurationtemplate-postlaunchactions-s3outputkeyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3OutputKeyPrefix { get; set; }
            /// <summary>
            /// Deployment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-postlaunchactions.html#cfn-mgn-launchconfigurationtemplate-postlaunchactions-deployment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Deployment { get; set; }
        }

        public class SsmDocument : Humidifier.Base.BaseSubResource, IHaveTimeoutSeconds_Integer, IHaveActionName, IHaveParameters_Json, IHaveSsmDocumentName, IHaveMapOfMGNLaunchConfigurationTemplateTypesSsmExternalParameterExternalParameters, IHaveMustSucceedForCutover_Boolean
        {
            /// <summary>
            /// TimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-ssmdocument.html#cfn-mgn-launchconfigurationtemplate-ssmdocument-timeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutSeconds { get; set; }
            /// <summary>
            /// ActionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-ssmdocument.html#cfn-mgn-launchconfigurationtemplate-ssmdocument-actionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionName { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-ssmdocument.html#cfn-mgn-launchconfigurationtemplate-ssmdocument-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// SsmDocumentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-ssmdocument.html#cfn-mgn-launchconfigurationtemplate-ssmdocument-ssmdocumentname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SsmDocumentName { get; set; }
            /// <summary>
            /// ExternalParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-ssmdocument.html#cfn-mgn-launchconfigurationtemplate-ssmdocument-externalparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: SsmExternalParameter
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.MGN.LaunchConfigurationTemplateTypes.SsmExternalParameter>, IReadOnlyDictionary<string, Union<Humidifier.MGN.LaunchConfigurationTemplateTypes.SsmExternalParameter, BaseFunction>>, BaseFunction>? ExternalParameters { get; set; }
            /// <summary>
            /// MustSucceedForCutover
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-ssmdocument.html#cfn-mgn-launchconfigurationtemplate-ssmdocument-mustsucceedforcutover
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MustSucceedForCutover { get; set; }
        }

        public class SsmExternalParameter : Humidifier.Base.BaseSubResource, IHaveDynamicPath
        {
            /// <summary>
            /// DynamicPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-launchconfigurationtemplate-ssmexternalparameter.html#cfn-mgn-launchconfigurationtemplate-ssmexternalparameter-dynamicpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DynamicPath { get; set; }
        }
    }
}