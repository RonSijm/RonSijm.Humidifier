namespace Humidifier.FSx
{
    using global::System.Collections.Generic;

    public class Backup : Humidifier.Base.BaseResource, IHaveTags, IHaveFileSystemId
    {
        public class Attributes
        {
            public static string ResourceARN =  "ResourceARN" ;
            public static string Type =  "Type" ;
            public static string Lifecycle =  "Lifecycle" ;
            public static string CreationTime =  "CreationTime" ;
            public static string BackupId =  "BackupId" ;
        }

        public override string AWSTypeName { get => AWS.FSx.Backup; }

        /// <summary>
        /// FileSystemId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-backup.html#cfn-fsx-backup-filesystemid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FileSystemId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-backup.html#cfn-fsx-backup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}