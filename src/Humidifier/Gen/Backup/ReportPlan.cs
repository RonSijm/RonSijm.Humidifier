namespace Humidifier.Backup
{
    using System.Collections.Generic;
    using ReportPlanTypes;

    public class ReportPlan : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription
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
        public Humidifier.Backup.ReportPlanTypes.ReportSetting ReportSetting { get; set; }
        /// <summary>
        /// ReportPlanDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-reportplan.html#cfn-backup-reportplan-reportplandescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ReportPlanDescription { get; set; }

        [Ignore]
        public dynamic Description { get => ReportPlanDescription; set => ReportPlanDescription = value; }
        public dynamic ReportPlanName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ReportDeliveryChannel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-reportplan.html#cfn-backup-reportplan-reportdeliverychannel
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ReportDeliveryChannel
        /// </summary>
        [Required]
        public Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel ReportDeliveryChannel { get; set; }
        /// <summary>
        /// ReportPlanTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-reportplan.html#cfn-backup-reportplan-reportplantags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> ReportPlanTags { get; set; }
    }

    namespace ReportPlanTypes
    {
        public class ReportDeliveryChannel : Humidifier.Base.BaseSubResource, IHaveS3BucketName, IHaveS3KeyPrefix
        {
            /// <summary>
            /// S3KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-reportplan-reportdeliverychannel.html#cfn-backup-reportplan-reportdeliverychannel-s3keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3KeyPrefix { get; set; }
            /// <summary>
            /// Formats
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-reportplan-reportdeliverychannel.html#cfn-backup-reportplan-reportdeliverychannel-formats
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Formats { get; set; }
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-reportplan-reportdeliverychannel.html#cfn-backup-reportplan-reportdeliverychannel-s3bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketName { get; set; }
        }

        public class ReportSetting : Humidifier.Base.BaseSubResource, IHaveRegions, IHaveAccounts
        {
            /// <summary>
            /// FrameworkArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-reportplan-reportsetting.html#cfn-backup-reportplan-reportsetting-frameworkarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic FrameworkArns { get; set; }
            /// <summary>
            /// ReportTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-reportplan-reportsetting.html#cfn-backup-reportplan-reportsetting-reporttemplate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReportTemplate { get; set; }
            /// <summary>
            /// OrganizationUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-reportplan-reportsetting.html#cfn-backup-reportplan-reportsetting-organizationunits
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic OrganizationUnits { get; set; }
            /// <summary>
            /// Regions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-reportplan-reportsetting.html#cfn-backup-reportplan-reportsetting-regions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Regions { get; set; }
            /// <summary>
            /// Accounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-reportplan-reportsetting.html#cfn-backup-reportplan-reportsetting-accounts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Accounts { get; set; }
        }
    }
}