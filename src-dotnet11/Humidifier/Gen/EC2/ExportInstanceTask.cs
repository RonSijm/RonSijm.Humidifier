namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using ExportInstanceTaskTypes;

    public class ExportInstanceTask : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveInstanceId, IHaveTargetEnvironment, IHaveEC2ExportInstanceTaskTypesExportToS3TaskExportToS3Task
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string ExportTaskId =  "ExportTaskId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.ExportInstanceTask; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-exportinstancetask.html#cfn-ec2-exportinstancetask-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-exportinstancetask.html#cfn-ec2-exportinstancetask-instanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceId { get; set; }

        /// <summary>
        /// TargetEnvironment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-exportinstancetask.html#cfn-ec2-exportinstancetask-targetenvironment
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetEnvironment { get; set; }
        /// <summary>
        /// ExportToS3Task
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-exportinstancetask.html#cfn-ec2-exportinstancetask-exporttos3task
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ExportToS3Task
        /// </summary>
        public Union<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task, BaseFunction>? ExportToS3Task { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-exportinstancetask.html#cfn-ec2-exportinstancetask-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ExportInstanceTaskTypes
    {
        public class ExportToS3Task : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveS3Key, IHaveContainerFormat, IHaveDiskImageFormat
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-exportinstancetask-exporttos3task.html#cfn-ec2-exportinstancetask-exporttos3task-s3bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-exportinstancetask-exporttos3task.html#cfn-ec2-exportinstancetask-exporttos3task-s3key
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Key { get; set; }
            /// <summary>
            /// ContainerFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-exportinstancetask-exporttos3task.html#cfn-ec2-exportinstancetask-exporttos3task-containerformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerFormat { get; set; }
            /// <summary>
            /// DiskImageFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-exportinstancetask-exporttos3task.html#cfn-ec2-exportinstancetask-exporttos3task-diskimageformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DiskImageFormat { get; set; }
        }
    }
}