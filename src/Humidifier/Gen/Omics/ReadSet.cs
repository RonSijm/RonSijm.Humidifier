namespace Humidifier.Omics
{
    using global::System.Collections.Generic;
    using ReadSetTypes;

    public class ReadSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveReferenceArn, IHaveFileType
    {
        public class Attributes
        {
            public static string CreationType =  "CreationType" ;
            public static string Etag =  "Etag" ;
            public static string CreationJobId =  "CreationJobId" ;
            public static string SequenceInformation =  "SequenceInformation" ;
            public static string Files =  "Files" ;
            public static string Tags =  "Tags" ;
            public static string Status =  "Status" ;
            public static string ReadSetId =  "ReadSetId" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Omics.ReadSet; }
        /// <summary>
        /// SequenceStoreId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-readset.html#cfn-omics-readset-sequencestoreid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SequenceStoreId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-readset.html#cfn-omics-readset-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// ReferenceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-readset.html#cfn-omics-readset-referencearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ReferenceArn { get; set; }
        /// <summary>
        /// FileType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-readset.html#cfn-omics-readset-filetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FileType { get; set; }
        /// <summary>
        /// SubjectId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-readset.html#cfn-omics-readset-subjectid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SubjectId { get; set; }
        /// <summary>
        /// SampleId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-readset.html#cfn-omics-readset-sampleid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SampleId { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ReadSetTypes
    {
        public class ETag : Humidifier.Base.BaseSubResource, IHaveAlgorithm
        {
            /// <summary>
            /// Source2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-readset-etag.html#cfn-omics-readset-etag-source2
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source2 { get; set; }
            /// <summary>
            /// Source1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-readset-etag.html#cfn-omics-readset-etag-source1
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source1 { get; set; }
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-readset-etag.html#cfn-omics-readset-etag-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Algorithm { get; set; }
        }

        public class FileInformation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PartSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-readset-fileinformation.html#cfn-omics-readset-fileinformation-partsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PartSize { get; set; }
            /// <summary>
            /// ContentLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-readset-fileinformation.html#cfn-omics-readset-fileinformation-contentlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ContentLength { get; set; }
            /// <summary>
            /// TotalParts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-readset-fileinformation.html#cfn-omics-readset-fileinformation-totalparts
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TotalParts { get; set; }
            /// <summary>
            /// S3Access
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-readset-fileinformation.html#cfn-omics-readset-fileinformation-s3access
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReadSetS3Access
            /// </summary>
            public Humidifier.Omics.ReadSetTypes.ReadSetS3Access S3Access { get; set; }
        }

        public class ReadSetFiles : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Source2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-readset-readsetfiles.html#cfn-omics-readset-readsetfiles-source2
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FileInformation
            /// </summary>
            public Humidifier.Omics.ReadSetTypes.FileInformation Source2 { get; set; }
            /// <summary>
            /// Source1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-readset-readsetfiles.html#cfn-omics-readset-readsetfiles-source1
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FileInformation
            /// </summary>
            public Humidifier.Omics.ReadSetTypes.FileInformation Source1 { get; set; }
            /// <summary>
            /// Index
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-readset-readsetfiles.html#cfn-omics-readset-readsetfiles-index
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FileInformation
            /// </summary>
            public Humidifier.Omics.ReadSetTypes.FileInformation Index { get; set; }
        }

        public class ReadSetS3Access : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-readset-readsets3access.html#cfn-omics-readset-readsets3access-s3uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
        }

        public class SequenceInformation : Humidifier.Base.BaseSubResource, IHaveAlignment
        {
            /// <summary>
            /// Alignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-readset-sequenceinformation.html#cfn-omics-readset-sequenceinformation-alignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alignment { get; set; }
            /// <summary>
            /// TotalBaseCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-readset-sequenceinformation.html#cfn-omics-readset-sequenceinformation-totalbasecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TotalBaseCount { get; set; }
            /// <summary>
            /// TotalReadCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-readset-sequenceinformation.html#cfn-omics-readset-sequenceinformation-totalreadcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TotalReadCount { get; set; }
            /// <summary>
            /// GeneratedFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-readset-sequenceinformation.html#cfn-omics-readset-sequenceinformation-generatedfrom
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GeneratedFrom { get; set; }
        }
    }
}