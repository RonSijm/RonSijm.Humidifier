namespace Humidifier.Backup
{
    using global::System.Collections.Generic;
    using ReportPlanTypes;

    public class ReportPlan : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveBackupReportPlanTypesReportSettingReportSetting, IHaveReportPlanDescription, IHaveReportPlanName, IHaveBackupReportPlanTypesReportDeliveryChannelReportDeliveryChannel, IHaveTagListOfReportPlanTags, IHaveDescription
    {
        public class Attributes
        {
            public static string ReportPlanArn =  "ReportPlanArn" ;
        }

        public override string AWSTypeName { get => AWS.Backup.ReportPlan; }

        /// <summary>
        /// ReportSetting
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-reportplan.html#cfn-backup-reportplan-reportsetting
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ReportSetting
        /// </summary>
        [Required]
        public Union<Humidifier.Backup.ReportPlanTypes.ReportSetting, BaseFunction>? ReportSetting { get; set; }
        /// <summary>
        /// ReportPlanDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-reportplan.html#cfn-backup-reportplan-reportplandescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ReportPlanDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => ReportPlanDescription; set => ReportPlanDescription = value; }
        public Union<string, BaseFunction>? ReportPlanName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ReportDeliveryChannel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-reportplan.html#cfn-backup-reportplan-reportdeliverychannel
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ReportDeliveryChannel
        /// </summary>
        [Required]
        public Union<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel, BaseFunction>? ReportDeliveryChannel { get; set; }
        /// <summary>
        /// ReportPlanTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-reportplan.html#cfn-backup-reportplan-reportplantags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? ReportPlanTags { get; set; }
    }

    namespace ReportPlanTypes
    {
        public class ReportDeliveryChannel : Humidifier.Base.BaseSubResource, IHaveS3KeyPrefix, IHaveStringListOfFormats, IHaveS3BucketName
        {
            /// <summary>
            /// S3KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-reportplan-reportdeliverychannel.html#cfn-backup-reportplan-reportdeliverychannel-s3keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3KeyPrefix { get; set; }
            /// <summary>
            /// Formats
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-reportplan-reportdeliverychannel.html#cfn-backup-reportplan-reportdeliverychannel-formats
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Formats { get; set; }
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-reportplan-reportdeliverychannel.html#cfn-backup-reportplan-reportdeliverychannel-s3bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketName { get; set; }
        }

        public class ReportSetting : Humidifier.Base.BaseSubResource, IHaveStringListOfFrameworkArns, IHaveReportTemplate, IHaveStringListOfOrganizationUnits, IHaveStringListOfRegions, IHaveStringListOfAccounts
        {
            /// <summary>
            /// FrameworkArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-reportplan-reportsetting.html#cfn-backup-reportplan-reportsetting-frameworkarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FrameworkArns { get; set; }
            /// <summary>
            /// ReportTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-reportplan-reportsetting.html#cfn-backup-reportplan-reportsetting-reporttemplate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReportTemplate { get; set; }
            /// <summary>
            /// OrganizationUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-reportplan-reportsetting.html#cfn-backup-reportplan-reportsetting-organizationunits
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OrganizationUnits { get; set; }
            /// <summary>
            /// Regions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-reportplan-reportsetting.html#cfn-backup-reportplan-reportsetting-regions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Regions { get; set; }
            /// <summary>
            /// Accounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-reportplan-reportsetting.html#cfn-backup-reportplan-reportsetting-accounts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Accounts { get; set; }
        }
    }
}