namespace Humidifier.MWAAServerless
{
    using global::System.Collections.Generic;
    using WorkflowTypes;

    public class Workflow : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveMWAAServerlessWorkflowTypesEncryptionConfigurationEncryptionConfiguration, IHaveMWAAServerlessWorkflowTypesLoggingConfigurationLoggingConfiguration, IHaveMWAAServerlessWorkflowTypesS3LocationDefinitionS3Location, IHaveMWAAServerlessWorkflowTypesNetworkConfigurationNetworkConfiguration, IHaveTriggerMode, IHaveMWAAServerlessWorkflowTypesCodeCode, IHaveRoleArn, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string ScheduleConfiguration =  "ScheduleConfiguration" ;
            public static string CodeSnapshottedAt =  "CodeSnapshottedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string WorkflowVersion =  "WorkflowVersion" ;
            public static string WorkflowArn =  "WorkflowArn" ;
            public static string WorkflowStatus =  "WorkflowStatus" ;
        }

        public override string AWSTypeName { get => AWS.MWAAServerless.Workflow; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaaserverless-workflow.html#cfn-mwaaserverless-workflow-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaaserverless-workflow.html#cfn-mwaaserverless-workflow-encryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Union<Humidifier.MWAAServerless.WorkflowTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        /// <summary>
        /// LoggingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaaserverless-workflow.html#cfn-mwaaserverless-workflow-loggingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoggingConfiguration
        /// </summary>
        public Union<Humidifier.MWAAServerless.WorkflowTypes.LoggingConfiguration, BaseFunction>? LoggingConfiguration { get; set; }

        /// <summary>
        /// DefinitionS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaaserverless-workflow.html#cfn-mwaaserverless-workflow-definitions3location
        /// Required: True
        /// UpdateType: Mutable
        /// Type: S3Location
        /// </summary>
        [Required]
        public Union<Humidifier.MWAAServerless.WorkflowTypes.S3Location, BaseFunction>? DefinitionS3Location { get; set; }
        /// <summary>
        /// NetworkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaaserverless-workflow.html#cfn-mwaaserverless-workflow-networkconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NetworkConfiguration
        /// </summary>
        public Union<Humidifier.MWAAServerless.WorkflowTypes.NetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
        /// <summary>
        /// TriggerMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaaserverless-workflow.html#cfn-mwaaserverless-workflow-triggermode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TriggerMode { get; set; }
        /// <summary>
        /// Code
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaaserverless-workflow.html#cfn-mwaaserverless-workflow-code
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Code
        /// </summary>
        public Union<Humidifier.MWAAServerless.WorkflowTypes.Code, BaseFunction>? Code { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaaserverless-workflow.html#cfn-mwaaserverless-workflow-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaaserverless-workflow.html#cfn-mwaaserverless-workflow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace WorkflowTypes
    {
        public class Code : Humidifier.Base.BaseSubResource, IHaveMWAAServerlessWorkflowTypesCodeS3LocationS3Location
        {
            /// <summary>
            /// S3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaaserverless-workflow-code.html#cfn-mwaaserverless-workflow-code-s3location
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CodeS3Location
            /// </summary>
            public Union<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location, BaseFunction>? S3Location { get; set; }
        }

        public class CodeS3Location : Humidifier.Base.BaseSubResource, IHaveVersionId, IHaveBucket, IHaveObjectKey
        {
            /// <summary>
            /// VersionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaaserverless-workflow-codes3location.html#cfn-mwaaserverless-workflow-codes3location-versionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VersionId { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaaserverless-workflow-codes3location.html#cfn-mwaaserverless-workflow-codes3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// ObjectKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaaserverless-workflow-codes3location.html#cfn-mwaaserverless-workflow-codes3location-objectkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectKey { get; set; }
        }

        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveKmsKeyId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaaserverless-workflow-encryptionconfiguration.html#cfn-mwaaserverless-workflow-encryptionconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaaserverless-workflow-encryptionconfiguration.html#cfn-mwaaserverless-workflow-encryptionconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
        }

        public class LoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveLogGroupName
        {
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaaserverless-workflow-loggingconfiguration.html#cfn-mwaaserverless-workflow-loggingconfiguration-loggroupname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupName { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaaserverless-workflow-networkconfiguration.html#cfn-mwaaserverless-workflow-networkconfiguration-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaaserverless-workflow-networkconfiguration.html#cfn-mwaaserverless-workflow-networkconfiguration-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveVersionId, IHaveBucket, IHaveObjectKey
        {
            /// <summary>
            /// VersionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaaserverless-workflow-s3location.html#cfn-mwaaserverless-workflow-s3location-versionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VersionId { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaaserverless-workflow-s3location.html#cfn-mwaaserverless-workflow-s3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// ObjectKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaaserverless-workflow-s3location.html#cfn-mwaaserverless-workflow-s3location-objectkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectKey { get; set; }
        }

        public class ScheduleConfiguration : Humidifier.Base.BaseSubResource, IHaveCronExpression
        {
            /// <summary>
            /// CronExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaaserverless-workflow-scheduleconfiguration.html#cfn-mwaaserverless-workflow-scheduleconfiguration-cronexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CronExpression { get; set; }
        }
    }
}