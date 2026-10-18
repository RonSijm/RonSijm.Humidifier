namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;

    public class AssetBundleExportJob : Humidifier.Base.BaseResource, IHaveIncludeFolderMembers, IHaveIncludeTags_Boolean, IHaveAssetBundleExportJobId, IHaveIncludePermissions_Boolean, IHaveIncludeAllDependencies_Boolean, IHaveIncludeFolderMemberships_Boolean, IHaveAwsAccountId, IHaveExportFormat, IHaveStringListOfResourceArns
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
        public Union<string, BaseFunction>? IncludeFolderMembers { get; set; }
        /// <summary>
        /// IncludeTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleexportjob.html#cfn-quicksight-assetbundleexportjob-includetags
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IncludeTags { get; set; }

        /// <summary>
        /// AssetBundleExportJobId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleexportjob.html#cfn-quicksight-assetbundleexportjob-assetbundleexportjobid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AssetBundleExportJobId { get; set; }
        /// <summary>
        /// IncludePermissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleexportjob.html#cfn-quicksight-assetbundleexportjob-includepermissions
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IncludePermissions { get; set; }
        /// <summary>
        /// IncludeAllDependencies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleexportjob.html#cfn-quicksight-assetbundleexportjob-includealldependencies
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IncludeAllDependencies { get; set; }
        /// <summary>
        /// IncludeFolderMemberships
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleexportjob.html#cfn-quicksight-assetbundleexportjob-includefoldermemberships
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IncludeFolderMemberships { get; set; }
        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleexportjob.html#cfn-quicksight-assetbundleexportjob-awsaccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AwsAccountId { get; set; }

        /// <summary>
        /// ExportFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleexportjob.html#cfn-quicksight-assetbundleexportjob-exportformat
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ExportFormat { get; set; }

        /// <summary>
        /// ResourceArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assetbundleexportjob.html#cfn-quicksight-assetbundleexportjob-resourcearns
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceArns { get; set; }
    }
}