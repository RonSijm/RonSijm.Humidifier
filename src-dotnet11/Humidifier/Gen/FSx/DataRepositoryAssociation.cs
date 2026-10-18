namespace Humidifier.FSx
{
    using global::System.Collections.Generic;
    using DataRepositoryAssociationTypes;

    public class DataRepositoryAssociation : Humidifier.Base.BaseResource, IHaveTags, IHaveFileSystemPath, IHaveDataRepositoryPath, IHaveBatchImportMetaDataOnCreate_Boolean, IHaveFSxDataRepositoryAssociationTypesS3S3, IHaveFileSystemId, IHaveImportedFileChunkSize_Integer
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
        public Union<string, BaseFunction>? FileSystemPath { get; set; }

        /// <summary>
        /// DataRepositoryPath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-datarepositoryassociation.html#cfn-fsx-datarepositoryassociation-datarepositorypath
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataRepositoryPath { get; set; }
        /// <summary>
        /// BatchImportMetaDataOnCreate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-datarepositoryassociation.html#cfn-fsx-datarepositoryassociation-batchimportmetadataoncreate
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? BatchImportMetaDataOnCreate { get; set; }
        /// <summary>
        /// S3
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-datarepositoryassociation.html#cfn-fsx-datarepositoryassociation-s3
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3
        /// </summary>
        public Union<Humidifier.FSx.DataRepositoryAssociationTypes.S3, BaseFunction>? S3 { get; set; }

        /// <summary>
        /// FileSystemId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-datarepositoryassociation.html#cfn-fsx-datarepositoryassociation-filesystemid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FileSystemId { get; set; }
        /// <summary>
        /// ImportedFileChunkSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-datarepositoryassociation.html#cfn-fsx-datarepositoryassociation-importedfilechunksize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ImportedFileChunkSize { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-datarepositoryassociation.html#cfn-fsx-datarepositoryassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DataRepositoryAssociationTypes
    {
        public class AutoExportPolicy : Humidifier.Base.BaseSubResource, IHaveStringListOfEvents
        {
            /// <summary>
            /// Events
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-datarepositoryassociation-autoexportpolicy.html#cfn-fsx-datarepositoryassociation-autoexportpolicy-events
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Events { get; set; }
        }

        public class AutoImportPolicy : Humidifier.Base.BaseSubResource, IHaveStringListOfEvents
        {
            /// <summary>
            /// Events
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-datarepositoryassociation-autoimportpolicy.html#cfn-fsx-datarepositoryassociation-autoimportpolicy-events
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Events { get; set; }
        }

        public class S3 : Humidifier.Base.BaseSubResource, IHaveFSxDataRepositoryAssociationTypesAutoImportPolicyAutoImportPolicy, IHaveFSxDataRepositoryAssociationTypesAutoExportPolicyAutoExportPolicy
        {
            /// <summary>
            /// AutoImportPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-datarepositoryassociation-s3.html#cfn-fsx-datarepositoryassociation-s3-autoimportpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoImportPolicy
            /// </summary>
            public Union<Humidifier.FSx.DataRepositoryAssociationTypes.AutoImportPolicy, BaseFunction>? AutoImportPolicy { get; set; }
            /// <summary>
            /// AutoExportPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-datarepositoryassociation-s3.html#cfn-fsx-datarepositoryassociation-s3-autoexportpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoExportPolicy
            /// </summary>
            public Union<Humidifier.FSx.DataRepositoryAssociationTypes.AutoExportPolicy, BaseFunction>? AutoExportPolicy { get; set; }
        }
    }
}