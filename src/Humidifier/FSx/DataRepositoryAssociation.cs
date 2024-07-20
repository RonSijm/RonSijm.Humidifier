namespace Humidifier.FSx
{
    using System.Collections.Generic;
    using DataRepositoryAssociationTypes;

    public class DataRepositoryAssociation : Humidifier.Resource
    {
        public class Attributes
        {
            public static string ResourceARN =  "ResourceARN" ;
            public static string AssociationId =  "AssociationId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::FSx::DataRepositoryAssociation";
            }
        }

        /// <summary>
        /// FileSystemPath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-datarepositoryassociation.html#cfn-fsx-datarepositoryassociation-filesystempath
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FileSystemPath { get; set; }
        /// <summary>
        /// DataRepositoryPath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-datarepositoryassociation.html#cfn-fsx-datarepositoryassociation-datarepositorypath
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
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
        public S3 S3 { get; set; }
        /// <summary>
        /// FileSystemId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-datarepositoryassociation.html#cfn-fsx-datarepositoryassociation-filesystemid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
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
        public class AutoExportPolicy
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

        public class AutoImportPolicy
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

        public class S3
        {
            /// <summary>
            /// AutoImportPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-datarepositoryassociation-s3.html#cfn-fsx-datarepositoryassociation-s3-autoimportpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoImportPolicy
            /// </summary>
            public AutoImportPolicy AutoImportPolicy { get; set; }
            /// <summary>
            /// AutoExportPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-datarepositoryassociation-s3.html#cfn-fsx-datarepositoryassociation-s3-autoexportpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoExportPolicy
            /// </summary>
            public AutoExportPolicy AutoExportPolicy { get; set; }
        }
    }
}