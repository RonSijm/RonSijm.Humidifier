namespace Humidifier.FSx
{
    using System.Collections.Generic;
    using DataRepositoryAssociationTypes;

    public class DataRepositoryAssociation : Humidifier.Base.BaseResource, IHaveTags, IHaveFileSystemId, IHaveFileSystemPath
    {
        public class Attributes
        {
            public static string ResourceARN =  "ResourceARN" ;
            public static string AssociationId =  "AssociationId" ;
        }

        public override string AWSTypeName { get => AWS.FSx.DataRepositoryAssociation; }

        /// <summary>
        /// FileSystemPath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-datarepositoryassociation.html#cfn-fsx-datarepositoryassociation-filesystempath
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FileSystemPath { get; set; }

        /// <summary>
        /// DataRepositoryPath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-datarepositoryassociation.html#cfn-fsx-datarepositoryassociation-datarepositorypath
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DataRepositoryPath { get; set; }
        /// <summary>
        /// BatchImportMetaDataOnCreate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-datarepositoryassociation.html#cfn-fsx-datarepositoryassociation-batchimportmetadataoncreate
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic BatchImportMetaDataOnCreate { get; set; }
        /// <summary>
        /// S3
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-datarepositoryassociation.html#cfn-fsx-datarepositoryassociation-s3
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3
        /// </summary>
        public Humidifier.FSx.DataRepositoryAssociationTypes.S3 S3 { get; set; }

        /// <summary>
        /// FileSystemId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-datarepositoryassociation.html#cfn-fsx-datarepositoryassociation-filesystemid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FileSystemId { get; set; }
        /// <summary>
        /// ImportedFileChunkSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-datarepositoryassociation.html#cfn-fsx-datarepositoryassociation-importedfilechunksize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ImportedFileChunkSize { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-datarepositoryassociation.html#cfn-fsx-datarepositoryassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace DataRepositoryAssociationTypes
    {
        public class AutoExportPolicy : Humidifier.Base.BaseSubResource, IHaveEvents
        {
            /// <summary>
            /// Events
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-datarepositoryassociation-autoexportpolicy.html#cfn-fsx-datarepositoryassociation-autoexportpolicy-events
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Events { get; set; }
        }

        public class AutoImportPolicy : Humidifier.Base.BaseSubResource, IHaveEvents
        {
            /// <summary>
            /// Events
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-datarepositoryassociation-autoimportpolicy.html#cfn-fsx-datarepositoryassociation-autoimportpolicy-events
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Events { get; set; }
        }

        public class S3 : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AutoImportPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-datarepositoryassociation-s3.html#cfn-fsx-datarepositoryassociation-s3-autoimportpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoImportPolicy
            /// </summary>
            public Humidifier.FSx.DataRepositoryAssociationTypes.AutoImportPolicy AutoImportPolicy { get; set; }
            /// <summary>
            /// AutoExportPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-datarepositoryassociation-s3.html#cfn-fsx-datarepositoryassociation-s3-autoexportpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoExportPolicy
            /// </summary>
            public Humidifier.FSx.DataRepositoryAssociationTypes.AutoExportPolicy AutoExportPolicy { get; set; }
        }
    }
}