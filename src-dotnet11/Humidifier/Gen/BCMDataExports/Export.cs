namespace Humidifier.BCMDataExports
{
    using global::System.Collections.Generic;
    using ExportTypes;

    public class Export : Humidifier.Base.BaseResource, IHaveBCMDataExportsExportTypesExportExport_, IHaveListOfBCMDataExportsExportTypesResourceTagTags
    {
        public class Attributes
        {
            public static string ExportArn =  "ExportArn" ;
        }

        public override string AWSTypeName { get => AWS.BCMDataExports.Export; }

        /// <summary>
        /// Export_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcmdataexports-export.html#cfn-bcmdataexports-export-export
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Export
        /// </summary>
        [Required]
        public Union<Humidifier.BCMDataExports.ExportTypes.Export, BaseFunction>? Export_ { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcmdataexports-export.html#cfn-bcmdataexports-export-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BCMDataExports.ExportTypes.ResourceTag>, IReadOnlyList<Union<Humidifier.BCMDataExports.ExportTypes.ResourceTag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ExportTypes
    {
        public class DataQuery : Humidifier.Base.BaseSubResource, IHaveTableConfigurations_Json, IHaveQueryStatement
        {
            /// <summary>
            /// TableConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-dataquery.html#cfn-bcmdataexports-export-dataquery-tableconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? TableConfigurations { get; set; }
            /// <summary>
            /// QueryStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-dataquery.html#cfn-bcmdataexports-export-dataquery-querystatement
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueryStatement { get; set; }
        }

        public class DestinationConfigurations : Humidifier.Base.BaseSubResource, IHaveBCMDataExportsExportTypesS3DestinationS3Destination
        {
            /// <summary>
            /// S3Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-destinationconfigurations.html#cfn-bcmdataexports-export-destinationconfigurations-s3destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3Destination
            /// </summary>
            public Union<Humidifier.BCMDataExports.ExportTypes.S3Destination, BaseFunction>? S3Destination { get; set; }
        }

        public class Export : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveBCMDataExportsExportTypesRefreshCadenceRefreshCadence, IHaveExportArn, IHaveBCMDataExportsExportTypesDataQueryDataQuery, IHaveBCMDataExportsExportTypesDestinationConfigurationsDestinationConfigurations, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-export.html#cfn-bcmdataexports-export-export-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// RefreshCadence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-export.html#cfn-bcmdataexports-export-export-refreshcadence
            /// Required: True
            /// UpdateType: Immutable
            /// Type: RefreshCadence
            /// </summary>
            public Union<Humidifier.BCMDataExports.ExportTypes.RefreshCadence, BaseFunction>? RefreshCadence { get; set; }
            /// <summary>
            /// ExportArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-export.html#cfn-bcmdataexports-export-export-exportarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExportArn { get; set; }
            /// <summary>
            /// DataQuery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-export.html#cfn-bcmdataexports-export-export-dataquery
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DataQuery
            /// </summary>
            public Union<Humidifier.BCMDataExports.ExportTypes.DataQuery, BaseFunction>? DataQuery { get; set; }
            /// <summary>
            /// DestinationConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-export.html#cfn-bcmdataexports-export-export-destinationconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DestinationConfigurations
            /// </summary>
            public Union<Humidifier.BCMDataExports.ExportTypes.DestinationConfigurations, BaseFunction>? DestinationConfigurations { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-export.html#cfn-bcmdataexports-export-export-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RefreshCadence : Humidifier.Base.BaseSubResource, IHaveFrequency
        {
            /// <summary>
            /// Frequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-refreshcadence.html#cfn-bcmdataexports-export-refreshcadence-frequency
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Frequency { get; set; }
        }

        public class ResourceTag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-resourcetag.html#cfn-bcmdataexports-export-resourcetag-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-resourcetag.html#cfn-bcmdataexports-export-resourcetag-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class S3Destination : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveBCMDataExportsExportTypesS3OutputConfigurationsS3OutputConfigurations, IHaveS3Region, IHaveS3BucketOwner, IHaveS3Prefix
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-s3destination.html#cfn-bcmdataexports-export-s3destination-s3bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// S3OutputConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-s3destination.html#cfn-bcmdataexports-export-s3destination-s3outputconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3OutputConfigurations
            /// </summary>
            public Union<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations, BaseFunction>? S3OutputConfigurations { get; set; }
            /// <summary>
            /// S3Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-s3destination.html#cfn-bcmdataexports-export-s3destination-s3region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Region { get; set; }
            /// <summary>
            /// S3BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-s3destination.html#cfn-bcmdataexports-export-s3destination-s3bucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketOwner { get; set; }
            /// <summary>
            /// S3Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-s3destination.html#cfn-bcmdataexports-export-s3destination-s3prefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Prefix { get; set; }
        }

        public class S3OutputConfigurations : Humidifier.Base.BaseSubResource, IHaveCompression, IHaveOverwrite, IHaveFormat, IHaveOutputType
        {
            /// <summary>
            /// Compression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-s3outputconfigurations.html#cfn-bcmdataexports-export-s3outputconfigurations-compression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Compression { get; set; }
            /// <summary>
            /// Overwrite
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-s3outputconfigurations.html#cfn-bcmdataexports-export-s3outputconfigurations-overwrite
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Overwrite { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-s3outputconfigurations.html#cfn-bcmdataexports-export-s3outputconfigurations-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// OutputType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmdataexports-export-s3outputconfigurations.html#cfn-bcmdataexports-export-s3outputconfigurations-outputtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputType { get; set; }
        }
    }
}