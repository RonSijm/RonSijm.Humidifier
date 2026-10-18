namespace Humidifier.SES
{
    using global::System.Collections.Generic;
    using MailManagerArchiveTypes;

    public class MailManagerArchive : Humidifier.Base.BaseResource, IHaveTags, IHaveKmsKeyArn, IHaveArchiveName, IHaveSESMailManagerArchiveTypesArchiveRetentionRetention
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
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        /// <summary>
        /// ArchiveName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagerarchive.html#cfn-ses-mailmanagerarchive-archivename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ArchiveName { get; set; }
        /// <summary>
        /// Retention
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagerarchive.html#cfn-ses-mailmanagerarchive-retention
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ArchiveRetention
        /// </summary>
        public Union<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention, BaseFunction>? Retention { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagerarchive.html#cfn-ses-mailmanagerarchive-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
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
            public Union<string, BaseFunction>? RetentionPeriod { get; set; }
        }
    }
}