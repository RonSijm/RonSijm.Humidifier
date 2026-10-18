namespace Humidifier.Transfer
{
    using global::System.Collections.Generic;
    using WorkflowTypes;

    public class Workflow : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfTransferWorkflowTypesWorkflowStepSteps, IHaveDescription, IHaveListOfTransferWorkflowTypesWorkflowStepOnExceptionSteps
    {
        public class Attributes
        {
            public static string WorkflowId =  "WorkflowId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Transfer.Workflow; }

        /// <summary>
        /// Steps
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-workflow.html#cfn-transfer-workflow-steps
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: WorkflowStep
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Transfer.WorkflowTypes.WorkflowStep>, IReadOnlyList<Union<Humidifier.Transfer.WorkflowTypes.WorkflowStep, BaseFunction>>, BaseFunction>? Steps { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-workflow.html#cfn-transfer-workflow-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// OnExceptionSteps
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-workflow.html#cfn-transfer-workflow-onexceptionsteps
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: WorkflowStep
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Transfer.WorkflowTypes.WorkflowStep>, IReadOnlyList<Union<Humidifier.Transfer.WorkflowTypes.WorkflowStep, BaseFunction>>, BaseFunction>? OnExceptionSteps { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-workflow.html#cfn-transfer-workflow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace WorkflowTypes
    {
        public class CopyStepDetails : Humidifier.Base.BaseSubResource, IHaveTransferWorkflowTypesS3FileLocationDestinationFileLocation, IHaveSourceFileLocation, IHaveName, IHaveOverwriteExisting
        {
            /// <summary>
            /// DestinationFileLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-copystepdetails.html#cfn-transfer-workflow-copystepdetails-destinationfilelocation
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3FileLocation
            /// </summary>
            public Union<Humidifier.Transfer.WorkflowTypes.S3FileLocation, BaseFunction>? DestinationFileLocation { get; set; }
            /// <summary>
            /// SourceFileLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-copystepdetails.html#cfn-transfer-workflow-copystepdetails-sourcefilelocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceFileLocation { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-copystepdetails.html#cfn-transfer-workflow-copystepdetails-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// OverwriteExisting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-copystepdetails.html#cfn-transfer-workflow-copystepdetails-overwriteexisting
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OverwriteExisting { get; set; }
        }

        public class CustomStepDetails : Humidifier.Base.BaseSubResource, IHaveTimeoutSeconds_Integer, IHaveTarget, IHaveSourceFileLocation, IHaveName
        {
            /// <summary>
            /// TimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-customstepdetails.html#cfn-transfer-workflow-customstepdetails-timeoutseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutSeconds { get; set; }
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-customstepdetails.html#cfn-transfer-workflow-customstepdetails-target
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Target { get; set; }
            /// <summary>
            /// SourceFileLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-customstepdetails.html#cfn-transfer-workflow-customstepdetails-sourcefilelocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceFileLocation { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-customstepdetails.html#cfn-transfer-workflow-customstepdetails-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class DecryptStepDetails : Humidifier.Base.BaseSubResource, IHaveTransferWorkflowTypesInputFileLocationDestinationFileLocation, IHaveType, IHaveSourceFileLocation, IHaveName, IHaveOverwriteExisting
        {
            /// <summary>
            /// DestinationFileLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-decryptstepdetails.html#cfn-transfer-workflow-decryptstepdetails-destinationfilelocation
            /// Required: True
            /// UpdateType: Immutable
            /// Type: InputFileLocation
            /// </summary>
            public Union<Humidifier.Transfer.WorkflowTypes.InputFileLocation, BaseFunction>? DestinationFileLocation { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-decryptstepdetails.html#cfn-transfer-workflow-decryptstepdetails-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// SourceFileLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-decryptstepdetails.html#cfn-transfer-workflow-decryptstepdetails-sourcefilelocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceFileLocation { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-decryptstepdetails.html#cfn-transfer-workflow-decryptstepdetails-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// OverwriteExisting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-decryptstepdetails.html#cfn-transfer-workflow-decryptstepdetails-overwriteexisting
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OverwriteExisting { get; set; }
        }

        public class DeleteStepDetails : Humidifier.Base.BaseSubResource, IHaveSourceFileLocation, IHaveName
        {
            /// <summary>
            /// SourceFileLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-deletestepdetails.html#cfn-transfer-workflow-deletestepdetails-sourcefilelocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceFileLocation { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-deletestepdetails.html#cfn-transfer-workflow-deletestepdetails-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class EfsInputFileLocation : Humidifier.Base.BaseSubResource, IHavePath, IHaveFileSystemId
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-efsinputfilelocation.html#cfn-transfer-workflow-efsinputfilelocation-path
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// FileSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-efsinputfilelocation.html#cfn-transfer-workflow-efsinputfilelocation-filesystemid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemId { get; set; }
        }

        public class InputFileLocation : Humidifier.Base.BaseSubResource, IHaveTransferWorkflowTypesEfsInputFileLocationEfsFileLocation, IHaveTransferWorkflowTypesS3InputFileLocationS3FileLocation
        {
            /// <summary>
            /// EfsFileLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-inputfilelocation.html#cfn-transfer-workflow-inputfilelocation-efsfilelocation
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EfsInputFileLocation
            /// </summary>
            public Union<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation, BaseFunction>? EfsFileLocation { get; set; }
            /// <summary>
            /// S3FileLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-inputfilelocation.html#cfn-transfer-workflow-inputfilelocation-s3filelocation
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3InputFileLocation
            /// </summary>
            public Union<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation, BaseFunction>? S3FileLocation { get; set; }
        }

        public class S3FileLocation : Humidifier.Base.BaseSubResource, IHaveTransferWorkflowTypesS3InputFileLocationS3FileLocation_
        {
            /// <summary>
            /// S3FileLocation_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-s3filelocation.html#cfn-transfer-workflow-s3filelocation-s3filelocation
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3InputFileLocation
            /// </summary>
            public Union<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation, BaseFunction>? S3FileLocation_ { get; set; }
        }

        public class S3InputFileLocation : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-s3inputfilelocation.html#cfn-transfer-workflow-s3inputfilelocation-bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-s3inputfilelocation.html#cfn-transfer-workflow-s3inputfilelocation-key
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class S3Tag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-s3tag.html#cfn-transfer-workflow-s3tag-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-s3tag.html#cfn-transfer-workflow-s3tag-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class TagStepDetails : Humidifier.Base.BaseSubResource, IHaveSourceFileLocation, IHaveListOfTransferWorkflowTypesS3TagTags, IHaveName
        {
            /// <summary>
            /// SourceFileLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-tagstepdetails.html#cfn-transfer-workflow-tagstepdetails-sourcefilelocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceFileLocation { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-tagstepdetails.html#cfn-transfer-workflow-tagstepdetails-tags
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: S3Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Transfer.WorkflowTypes.S3Tag>, IReadOnlyList<Union<Humidifier.Transfer.WorkflowTypes.S3Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-tagstepdetails.html#cfn-transfer-workflow-tagstepdetails-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class WorkflowStep : Humidifier.Base.BaseSubResource, IHaveTransferWorkflowTypesCustomStepDetailsCustomStepDetails, IHaveTransferWorkflowTypesCopyStepDetailsCopyStepDetails, IHaveTransferWorkflowTypesDecryptStepDetailsDecryptStepDetails, IHaveType, IHaveTransferWorkflowTypesTagStepDetailsTagStepDetails, IHaveTransferWorkflowTypesDeleteStepDetailsDeleteStepDetails
        {
            /// <summary>
            /// CustomStepDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-workflowstep.html#cfn-transfer-workflow-workflowstep-customstepdetails
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CustomStepDetails
            /// </summary>
            public Union<Humidifier.Transfer.WorkflowTypes.CustomStepDetails, BaseFunction>? CustomStepDetails { get; set; }
            /// <summary>
            /// CopyStepDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-workflowstep.html#cfn-transfer-workflow-workflowstep-copystepdetails
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CopyStepDetails
            /// </summary>
            public Union<Humidifier.Transfer.WorkflowTypes.CopyStepDetails, BaseFunction>? CopyStepDetails { get; set; }
            /// <summary>
            /// DecryptStepDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-workflowstep.html#cfn-transfer-workflow-workflowstep-decryptstepdetails
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DecryptStepDetails
            /// </summary>
            public Union<Humidifier.Transfer.WorkflowTypes.DecryptStepDetails, BaseFunction>? DecryptStepDetails { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-workflowstep.html#cfn-transfer-workflow-workflowstep-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// TagStepDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-workflowstep.html#cfn-transfer-workflow-workflowstep-tagstepdetails
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TagStepDetails
            /// </summary>
            public Union<Humidifier.Transfer.WorkflowTypes.TagStepDetails, BaseFunction>? TagStepDetails { get; set; }
            /// <summary>
            /// DeleteStepDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-workflow-workflowstep.html#cfn-transfer-workflow-workflowstep-deletestepdetails
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DeleteStepDetails
            /// </summary>
            public Union<Humidifier.Transfer.WorkflowTypes.DeleteStepDetails, BaseFunction>? DeleteStepDetails { get; set; }
        }
    }
}