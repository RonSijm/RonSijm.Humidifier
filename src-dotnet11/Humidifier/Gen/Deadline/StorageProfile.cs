namespace Humidifier.Deadline
{
    using global::System.Collections.Generic;
    using StorageProfileTypes;

    public class StorageProfile : Humidifier.Base.BaseResource, IHaveDisplayName, IHaveListOfDeadlineStorageProfileTypesFileSystemLocationFileSystemLocations, IHaveFarmId, IHaveOsFamily
    {
        public class Attributes
        {
            public static string StorageProfileId =  "StorageProfileId" ;
        }

        public override string AWSTypeName { get => AWS.Deadline.StorageProfile; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-storageprofile.html#cfn-deadline-storageprofile-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// FileSystemLocations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-storageprofile.html#cfn-deadline-storageprofile-filesystemlocations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FileSystemLocation
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation>, IReadOnlyList<Union<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation, BaseFunction>>, BaseFunction>? FileSystemLocations { get; set; }

        /// <summary>
        /// FarmId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-storageprofile.html#cfn-deadline-storageprofile-farmid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FarmId { get; set; }

        /// <summary>
        /// OsFamily
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-storageprofile.html#cfn-deadline-storageprofile-osfamily
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OsFamily { get; set; }
    }

    namespace StorageProfileTypes
    {
        public class FileSystemLocation : Humidifier.Base.BaseSubResource, IHavePath, IHaveType, IHaveName
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-storageprofile-filesystemlocation.html#cfn-deadline-storageprofile-filesystemlocation-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-storageprofile-filesystemlocation.html#cfn-deadline-storageprofile-filesystemlocation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-storageprofile-filesystemlocation.html#cfn-deadline-storageprofile-filesystemlocation-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}