namespace Humidifier.AppTest
{
    using System.Collections.Generic;
    using TestCaseTypes;

    public class TestCase : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LastUpdateTime =  "LastUpdateTime" ;
            public static string LatestVersion =  "LatestVersion" ;
            public static string CreationTime =  "CreationTime" ;
            public static string TestCaseId =  "TestCaseId" ;
            public static string TestCaseVersion =  "TestCaseVersion" ;
            public static string TestCaseArn =  "TestCaseArn" ;
        }

        public override string AWSTypeName { get => AWS.AppTest.TestCase; }

        /// <summary>
        /// Steps
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apptest-testcase.html#cfn-apptest-testcase-steps
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Step
        /// </summary>
        [Required]
        public List<Humidifier.AppTest.TestCaseTypes.Step> Steps { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apptest-testcase.html#cfn-apptest-testcase-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apptest-testcase.html#cfn-apptest-testcase-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace TestCaseTypes
    {
        public class Batch : Humidifier.Base.BaseSubResource, IHaveExportDataSetNames
        {
            /// <summary>
            /// BatchJobName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-batch.html#cfn-apptest-testcase-batch-batchjobname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BatchJobName { get; set; }
            /// <summary>
            /// ExportDataSetNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-batch.html#cfn-apptest-testcase-batch-exportdatasetnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExportDataSetNames { get; set; }
            /// <summary>
            /// BatchJobParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-batch.html#cfn-apptest-testcase-batch-batchjobparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> BatchJobParameters { get; set; }
        }

        public class CloudFormationAction : Humidifier.Base.BaseSubResource, IHaveResource, IHaveActionType
        {
            /// <summary>
            /// ActionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-cloudformationaction.html#cfn-apptest-testcase-cloudformationaction-actiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionType { get; set; }
            /// <summary>
            /// Resource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-cloudformationaction.html#cfn-apptest-testcase-cloudformationaction-resource
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Resource { get; set; }
        }

        public class CompareAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-compareaction.html#cfn-apptest-testcase-compareaction-input
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Input
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.Input Input { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-compareaction.html#cfn-apptest-testcase-compareaction-output
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Output
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.Output Output { get; set; }
        }

        public class DataSet : Humidifier.Base.BaseSubResource, IHaveName, IHaveType, IHaveFormat, IHaveLength
        {
            /// <summary>
            /// Ccsid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-dataset.html#cfn-apptest-testcase-dataset-ccsid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ccsid { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-dataset.html#cfn-apptest-testcase-dataset-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-dataset.html#cfn-apptest-testcase-dataset-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// Length
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-dataset.html#cfn-apptest-testcase-dataset-length
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Length { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-dataset.html#cfn-apptest-testcase-dataset-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class DatabaseCDC : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-databasecdc.html#cfn-apptest-testcase-databasecdc-sourcemetadata
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SourceDatabaseMetadata
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata SourceMetadata { get; set; }
            /// <summary>
            /// TargetMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-databasecdc.html#cfn-apptest-testcase-databasecdc-targetmetadata
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TargetDatabaseMetadata
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata TargetMetadata { get; set; }
        }

        public class FileMetadata : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DatabaseCDC
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-filemetadata.html#cfn-apptest-testcase-filemetadata-databasecdc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatabaseCDC
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.DatabaseCDC DatabaseCDC { get; set; }
            /// <summary>
            /// DataSets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-filemetadata.html#cfn-apptest-testcase-filemetadata-datasets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSet
            /// </summary>
            public List<Humidifier.AppTest.TestCaseTypes.DataSet> DataSets { get; set; }
        }

        public class Input : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-input.html#cfn-apptest-testcase-input-file
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InputFile
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.InputFile File { get; set; }
        }

        public class InputFile : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-inputfile.html#cfn-apptest-testcase-inputfile-sourcelocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceLocation { get; set; }
            /// <summary>
            /// TargetLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-inputfile.html#cfn-apptest-testcase-inputfile-targetlocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetLocation { get; set; }
            /// <summary>
            /// FileMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-inputfile.html#cfn-apptest-testcase-inputfile-filemetadata
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FileMetadata
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.FileMetadata FileMetadata { get; set; }
        }

        public class M2ManagedActionProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ImportDataSetLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-m2managedactionproperties.html#cfn-apptest-testcase-m2managedactionproperties-importdatasetlocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImportDataSetLocation { get; set; }
            /// <summary>
            /// ForceStop
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-m2managedactionproperties.html#cfn-apptest-testcase-m2managedactionproperties-forcestop
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ForceStop { get; set; }
        }

        public class M2ManagedApplicationAction : Humidifier.Base.BaseSubResource, IHaveResource, IHaveActionType
        {
            /// <summary>
            /// ActionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-m2managedapplicationaction.html#cfn-apptest-testcase-m2managedapplicationaction-actiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionType { get; set; }
            /// <summary>
            /// Resource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-m2managedapplicationaction.html#cfn-apptest-testcase-m2managedapplicationaction-resource
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Resource { get; set; }
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-m2managedapplicationaction.html#cfn-apptest-testcase-m2managedapplicationaction-properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: M2ManagedActionProperties
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties Properties { get; set; }
        }

        public class M2NonManagedApplicationAction : Humidifier.Base.BaseSubResource, IHaveResource, IHaveActionType
        {
            /// <summary>
            /// ActionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-m2nonmanagedapplicationaction.html#cfn-apptest-testcase-m2nonmanagedapplicationaction-actiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionType { get; set; }
            /// <summary>
            /// Resource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-m2nonmanagedapplicationaction.html#cfn-apptest-testcase-m2nonmanagedapplicationaction-resource
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Resource { get; set; }
        }

        public class MainframeAction : Humidifier.Base.BaseSubResource, IHaveResource
        {
            /// <summary>
            /// ActionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-mainframeaction.html#cfn-apptest-testcase-mainframeaction-actiontype
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MainframeActionType
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.MainframeActionType ActionType { get; set; }
            /// <summary>
            /// Resource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-mainframeaction.html#cfn-apptest-testcase-mainframeaction-resource
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Resource { get; set; }
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-mainframeaction.html#cfn-apptest-testcase-mainframeaction-properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MainframeActionProperties
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.MainframeActionProperties Properties { get; set; }
        }

        public class MainframeActionProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DmsTaskArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-mainframeactionproperties.html#cfn-apptest-testcase-mainframeactionproperties-dmstaskarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DmsTaskArn { get; set; }
        }

        public class MainframeActionType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Batch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-mainframeactiontype.html#cfn-apptest-testcase-mainframeactiontype-batch
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Batch
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.Batch Batch { get; set; }
            /// <summary>
            /// Tn3270
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-mainframeactiontype.html#cfn-apptest-testcase-mainframeactiontype-tn3270
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TN3270
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.TN3270 Tn3270 { get; set; }
        }

        public class Output : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-output.html#cfn-apptest-testcase-output-file
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OutputFile
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.OutputFile File { get; set; }
        }

        public class OutputFile : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FileLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-outputfile.html#cfn-apptest-testcase-outputfile-filelocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileLocation { get; set; }
        }

        public class ResourceAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CloudFormationAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-resourceaction.html#cfn-apptest-testcase-resourceaction-cloudformationaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudFormationAction
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.CloudFormationAction CloudFormationAction { get; set; }
            /// <summary>
            /// M2ManagedApplicationAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-resourceaction.html#cfn-apptest-testcase-resourceaction-m2managedapplicationaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: M2ManagedApplicationAction
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.M2ManagedApplicationAction M2ManagedApplicationAction { get; set; }
            /// <summary>
            /// M2NonManagedApplicationAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-resourceaction.html#cfn-apptest-testcase-resourceaction-m2nonmanagedapplicationaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: M2NonManagedApplicationAction
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.M2NonManagedApplicationAction M2NonManagedApplicationAction { get; set; }
        }

        public class Script : Humidifier.Base.BaseSubResource, IHaveType, IHaveScriptLocation
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-script.html#cfn-apptest-testcase-script-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// ScriptLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-script.html#cfn-apptest-testcase-script-scriptlocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScriptLocation { get; set; }
        }

        public class SourceDatabaseMetadata : Humidifier.Base.BaseSubResource, IHaveType, IHaveCaptureTool
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-sourcedatabasemetadata.html#cfn-apptest-testcase-sourcedatabasemetadata-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// CaptureTool
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-sourcedatabasemetadata.html#cfn-apptest-testcase-sourcedatabasemetadata-capturetool
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CaptureTool { get; set; }
        }

        public class Step : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-step.html#cfn-apptest-testcase-step-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: StepAction
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.StepAction Action { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-step.html#cfn-apptest-testcase-step-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-step.html#cfn-apptest-testcase-step-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class StepAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CompareAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-stepaction.html#cfn-apptest-testcase-stepaction-compareaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CompareAction
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.CompareAction CompareAction { get; set; }
            /// <summary>
            /// MainframeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-stepaction.html#cfn-apptest-testcase-stepaction-mainframeaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MainframeAction
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.MainframeAction MainframeAction { get; set; }
            /// <summary>
            /// ResourceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-stepaction.html#cfn-apptest-testcase-stepaction-resourceaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceAction
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.ResourceAction ResourceAction { get; set; }
        }

        public class TN3270 : Humidifier.Base.BaseSubResource, IHaveExportDataSetNames
        {
            /// <summary>
            /// Script
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-tn3270.html#cfn-apptest-testcase-tn3270-script
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Script
            /// </summary>
            public Humidifier.AppTest.TestCaseTypes.Script Script { get; set; }
            /// <summary>
            /// ExportDataSetNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-tn3270.html#cfn-apptest-testcase-tn3270-exportdatasetnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExportDataSetNames { get; set; }
        }

        public class TargetDatabaseMetadata : Humidifier.Base.BaseSubResource, IHaveType, IHaveCaptureTool
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-targetdatabasemetadata.html#cfn-apptest-testcase-targetdatabasemetadata-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// CaptureTool
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-targetdatabasemetadata.html#cfn-apptest-testcase-targetdatabasemetadata-capturetool
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CaptureTool { get; set; }
        }

        public class TestCaseLatestVersion : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveVersion
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-testcaselatestversion.html#cfn-apptest-testcase-testcaselatestversion-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apptest-testcase-testcaselatestversion.html#cfn-apptest-testcase-testcaselatestversion-version
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Version { get; set; }
        }
    }
}