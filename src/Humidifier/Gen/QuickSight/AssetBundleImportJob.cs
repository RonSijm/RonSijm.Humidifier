namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using AssetBundleImportJobTypes;

    public class AssetBundleImportJob : Humidifier.Base.BaseResource, IHaveAwsAccountId
    {
        public class Attributes
        {
            public static string JobStatus =  "JobStatus" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.AssetBundleImportJob; }
        /// <summary>
        /// FailureAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleimportjob.html#cfn-quicksight-assetbundleimportjob-failureaction
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FailureAction { get; set; }
        /// <summary>
        /// AssetBundleImportSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleimportjob.html#cfn-quicksight-assetbundleimportjob-assetbundleimportsource
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AssetBundleImportSourceDescription
        /// </summary>
        public Humidifier.QuickSight.AssetBundleImportJobTypes.AssetBundleImportSourceDescription AssetBundleImportSource { get; set; }
        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleimportjob.html#cfn-quicksight-assetbundleimportjob-awsaccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AwsAccountId { get; set; }

        /// <summary>
        /// AssetBundleImportJobId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleimportjob.html#cfn-quicksight-assetbundleimportjob-assetbundleimportjobid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AssetBundleImportJobId { get; set; }
        /// <summary>
        /// OverrideValidationStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleimportjob.html#cfn-quicksight-assetbundleimportjob-overridevalidationstrategy
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AssetBundleImportJobOverrideValidationStrategy
        /// </summary>
        public Humidifier.QuickSight.AssetBundleImportJobTypes.AssetBundleImportJobOverrideValidationStrategy OverrideValidationStrategy { get; set; }
    }

    namespace AssetBundleImportJobTypes
    {
        public class AssetBundleImportJobOverrideValidationStrategy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StrictModeForAllResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-assetbundleimportjob-assetbundleimportjoboverridevalidationstrategy.html#cfn-quicksight-assetbundleimportjob-assetbundleimportjoboverridevalidationstrategy-strictmodeforallresources
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic StrictModeForAllResources { get; set; }
        }

        public class AssetBundleImportSourceDescription : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-assetbundleimportjob-assetbundleimportsourcedescription.html#cfn-quicksight-assetbundleimportjob-assetbundleimportsourcedescription-s3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
        }
    }
}