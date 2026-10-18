namespace Humidifier.CodeBuild
{
    using global::System.Collections.Generic;
    using ReportTypes;

    public class Report : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string CodeCoverageSummary =  "CodeCoverageSummary" ;
            public static string Name =  "Name" ;
            public static string ReportGroupArn =  "ReportGroupArn" ;
            public static string Created =  "Created" ;
            public static string ExportConfig =  "ExportConfig" ;
            public static string Truncated =  "Truncated" ;
            public static string TestSummary =  "TestSummary" ;
            public static string Status =  "Status" ;
            public static string Expired =  "Expired" ;
            public static string Type =  "Type" ;
            public static string Arn =  "Arn" ;
            public static string ExecutionId =  "ExecutionId" ;
        }

        public override string AWSTypeName { get => AWS.CodeBuild.Report; }
    }

    namespace ReportTypes
    {
        public class CodeCoverageReportSummary : Humidifier.Base.BaseSubResource, IHaveBranchesCovered_Integer, IHaveLineCoveragePercentage_Double, IHaveLinesMissed_Integer, IHaveBranchCoveragePercentage_Double, IHaveLinesCovered_Integer, IHaveBranchesMissed_Integer
        {
            /// <summary>
            /// BranchesCovered
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-report-codecoveragereportsummary.html#cfn-codebuild-report-codecoveragereportsummary-branchescovered
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BranchesCovered { get; set; }
            /// <summary>
            /// LineCoveragePercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-report-codecoveragereportsummary.html#cfn-codebuild-report-codecoveragereportsummary-linecoveragepercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? LineCoveragePercentage { get; set; }
            /// <summary>
            /// LinesMissed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-report-codecoveragereportsummary.html#cfn-codebuild-report-codecoveragereportsummary-linesmissed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LinesMissed { get; set; }
            /// <summary>
            /// BranchCoveragePercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-report-codecoveragereportsummary.html#cfn-codebuild-report-codecoveragereportsummary-branchcoveragepercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? BranchCoveragePercentage { get; set; }
            /// <summary>
            /// LinesCovered
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-report-codecoveragereportsummary.html#cfn-codebuild-report-codecoveragereportsummary-linescovered
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LinesCovered { get; set; }
            /// <summary>
            /// BranchesMissed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-report-codecoveragereportsummary.html#cfn-codebuild-report-codecoveragereportsummary-branchesmissed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BranchesMissed { get; set; }
        }

        public class ReportExportConfig : Humidifier.Base.BaseSubResource, IHaveCodeBuildReportTypesS3ReportExportConfigS3Destination, IHaveExportConfigType
        {
            /// <summary>
            /// S3Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-report-reportexportconfig.html#cfn-codebuild-report-reportexportconfig-s3destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3ReportExportConfig
            /// </summary>
            public Union<Humidifier.CodeBuild.ReportTypes.S3ReportExportConfig, BaseFunction>? S3Destination { get; set; }
            /// <summary>
            /// ExportConfigType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-report-reportexportconfig.html#cfn-codebuild-report-reportexportconfig-exportconfigtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExportConfigType { get; set; }
        }

        public class S3ReportExportConfig : Humidifier.Base.BaseSubResource, IHavePath, IHaveBucket, IHavePackaging, IHaveEncryptionKey, IHaveBucketOwner, IHaveEncryptionDisabled_Boolean
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-report-s3reportexportconfig.html#cfn-codebuild-report-s3reportexportconfig-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-report-s3reportexportconfig.html#cfn-codebuild-report-s3reportexportconfig-bucket
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Packaging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-report-s3reportexportconfig.html#cfn-codebuild-report-s3reportexportconfig-packaging
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Packaging { get; set; }
            /// <summary>
            /// EncryptionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-report-s3reportexportconfig.html#cfn-codebuild-report-s3reportexportconfig-encryptionkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKey { get; set; }
            /// <summary>
            /// BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-report-s3reportexportconfig.html#cfn-codebuild-report-s3reportexportconfig-bucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketOwner { get; set; }
            /// <summary>
            /// EncryptionDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-report-s3reportexportconfig.html#cfn-codebuild-report-s3reportexportconfig-encryptiondisabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EncryptionDisabled { get; set; }
        }

        public class TestReportSummary : Humidifier.Base.BaseSubResource, IHaveTotal_Integer, IHaveIntegerDictionaryOfStatusCounts, IHaveDurationInNanoSeconds_Integer
        {
            /// <summary>
            /// Total
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-report-testreportsummary.html#cfn-codebuild-report-testreportsummary-total
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Total { get; set; }
            /// <summary>
            /// StatusCounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-report-testreportsummary.html#cfn-codebuild-report-testreportsummary-statuscounts
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyDictionary<string, int>, IReadOnlyDictionary<string, Union<int, BaseFunction>>, BaseFunction>? StatusCounts { get; set; }
            /// <summary>
            /// DurationInNanoSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-report-testreportsummary.html#cfn-codebuild-report-testreportsummary-durationinnanoseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DurationInNanoSeconds { get; set; }
        }
    }
}