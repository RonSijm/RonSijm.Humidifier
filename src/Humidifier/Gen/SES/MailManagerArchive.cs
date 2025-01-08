namespace Humidifier.SES
{
    using System.Collections.Generic;
    using MailManagerArchiveTypes;

    public class MailManagerArchive : Humidifier.Base.BaseResource, IHaveTags, IHaveKmsKeyArn, IHaveArchiveName
    {
        public class Attributes
        {
            public static string ArchiveId =  "ArchiveId" ;
            public static string ArchiveArn =  "ArchiveArn" ;
            public static string ArchiveState =  "ArchiveState" ;
        }

        public override string AWSTypeName { get => AWS.SES.MailManagerArchive; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagerarchive.html#cfn-ses-mailmanagerarchive-kmskeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyArn { get; set; }
        /// <summary>
        /// ArchiveName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagerarchive.html#cfn-ses-mailmanagerarchive-archivename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ArchiveName { get; set; }
        /// <summary>
        /// Retention
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagerarchive.html#cfn-ses-mailmanagerarchive-retention
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ArchiveRetention
        /// </summary>
        public Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention Retention { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagerarchive.html#cfn-ses-mailmanagerarchive-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace MailManagerArchiveTypes
    {
        public class ArchiveRetention : Humidifier.Base.BaseSubResource, IHaveRetentionPeriod
        {
            /// <summary>
            /// RetentionPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerarchive-archiveretention.html#cfn-ses-mailmanagerarchive-archiveretention-retentionperiod
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RetentionPeriod { get; set; }
        }
    }
}