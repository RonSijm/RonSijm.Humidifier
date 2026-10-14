namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;

    public class AssetBundleExportJob : Humidifier.Base.BaseResource, IHaveAwsAccountId, IHaveResourceArns
    {
        public class Attributes
        {
            public static string JobStatus =  "JobStatus" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.AssetBundleExportJob; }
        /// <summary>
        /// IncludeFolderMembers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleexportjob.html#cfn-quicksight-assetbundleexportjob-includefoldermembers
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IncludeFolderMembers { get; set; }
        /// <summary>
        /// IncludeTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleexportjob.html#cfn-quicksight-assetbundleexportjob-includetags
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic IncludeTags { get; set; }

        /// <summary>
        /// AssetBundleExportJobId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleexportjob.html#cfn-quicksight-assetbundleexportjob-assetbundleexportjobid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AssetBundleExportJobId { get; set; }
        /// <summary>
        /// IncludePermissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleexportjob.html#cfn-quicksight-assetbundleexportjob-includepermissions
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic IncludePermissions { get; set; }
        /// <summary>
        /// IncludeAllDependencies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleexportjob.html#cfn-quicksight-assetbundleexportjob-includealldependencies
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic IncludeAllDependencies { get; set; }
        /// <summary>
        /// IncludeFolderMemberships
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleexportjob.html#cfn-quicksight-assetbundleexportjob-includefoldermemberships
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic IncludeFolderMemberships { get; set; }
        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleexportjob.html#cfn-quicksight-assetbundleexportjob-awsaccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AwsAccountId { get; set; }

        /// <summary>
        /// ExportFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleexportjob.html#cfn-quicksight-assetbundleexportjob-exportformat
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ExportFormat { get; set; }

        /// <summary>
        /// ResourceArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleexportjob.html#cfn-quicksight-assetbundleexportjob-resourcearns
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic ResourceArns { get; set; }
    }
}