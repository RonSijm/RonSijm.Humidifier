namespace Humidifier.SSM
{
    using global::System.Collections.Generic;
    using ResourceDataSyncTypes;

    public class ResourceDataSync : Humidifier.Base.BaseResource, IHaveSSMResourceDataSyncTypesS3DestinationS3Destination, IHaveKMSKeyArn, IHaveSSMResourceDataSyncTypesSyncSourceSyncSource, IHaveBucketName, IHaveBucketRegion, IHaveSyncFormat, IHaveSyncName, IHaveSyncType, IHaveBucketPrefix
    {
        public override string AWSTypeName { get => AWS.SSM.ResourceDataSync; }
        /// <summary>
        /// S3Destination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcedatasync.html#cfn-ssm-resourcedatasync-s3destination
        /// Required: False
        /// UpdateType: Immutable
        /// Type: S3Destination
        /// </summary>
        public Union<Humidifier.SSM.ResourceDataSyncTypes.S3Destination, BaseFunction>? S3Destination { get; set; }
        /// <summary>
        /// KMSKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcedatasync.html#cfn-ssm-resourcedatasync-kmskeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KMSKeyArn { get; set; }
        /// <summary>
        /// SyncSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcedatasync.html#cfn-ssm-resourcedatasync-syncsource
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SyncSource
        /// </summary>
        public Union<Humidifier.SSM.ResourceDataSyncTypes.SyncSource, BaseFunction>? SyncSource { get; set; }
        /// <summary>
        /// BucketName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcedatasync.html#cfn-ssm-resourcedatasync-bucketname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BucketName { get; set; }
        /// <summary>
        /// BucketRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcedatasync.html#cfn-ssm-resourcedatasync-bucketregion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BucketRegion { get; set; }
        /// <summary>
        /// SyncFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcedatasync.html#cfn-ssm-resourcedatasync-syncformat
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SyncFormat { get; set; }

        /// <summary>
        /// SyncName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcedatasync.html#cfn-ssm-resourcedatasync-syncname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SyncName { get; set; }
        /// <summary>
        /// SyncType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcedatasync.html#cfn-ssm-resourcedatasync-synctype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SyncType { get; set; }
        /// <summary>
        /// BucketPrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcedatasync.html#cfn-ssm-resourcedatasync-bucketprefix
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BucketPrefix { get; set; }
    }

    namespace ResourceDataSyncTypes
    {
        public class AwsOrganizationsSource : Humidifier.Base.BaseSubResource, IHaveOrganizationSourceType, IHaveStringListOfOrganizationalUnits
        {
            /// <summary>
            /// OrganizationSourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-resourcedatasync-awsorganizationssource.html#cfn-ssm-resourcedatasync-awsorganizationssource-organizationsourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrganizationSourceType { get; set; }
            /// <summary>
            /// OrganizationalUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-resourcedatasync-awsorganizationssource.html#cfn-ssm-resourcedatasync-awsorganizationssource-organizationalunits
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OrganizationalUnits { get; set; }
        }

        public class S3Destination : Humidifier.Base.BaseSubResource, IHaveKMSKeyArn, IHaveBucketName, IHaveBucketRegion, IHaveSyncFormat, IHaveBucketPrefix
        {
            /// <summary>
            /// KMSKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-resourcedatasync-s3destination.html#cfn-ssm-resourcedatasync-s3destination-kmskeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KMSKeyArn { get; set; }
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-resourcedatasync-s3destination.html#cfn-ssm-resourcedatasync-s3destination-bucketname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// BucketRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-resourcedatasync-s3destination.html#cfn-ssm-resourcedatasync-s3destination-bucketregion
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketRegion { get; set; }
            /// <summary>
            /// SyncFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-resourcedatasync-s3destination.html#cfn-ssm-resourcedatasync-s3destination-syncformat
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SyncFormat { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-resourcedatasync-s3destination.html#cfn-ssm-resourcedatasync-s3destination-bucketprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketPrefix { get; set; }
        }

        public class SyncSource : Humidifier.Base.BaseSubResource, IHaveSourceType, IHaveSSMResourceDataSyncTypesAwsOrganizationsSourceAwsOrganizationsSource, IHaveIncludeFutureRegions_Boolean, IHaveStringListOfSourceRegions
        {
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-resourcedatasync-syncsource.html#cfn-ssm-resourcedatasync-syncsource-sourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceType { get; set; }
            /// <summary>
            /// AwsOrganizationsSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-resourcedatasync-syncsource.html#cfn-ssm-resourcedatasync-syncsource-awsorganizationssource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsOrganizationsSource
            /// </summary>
            public Union<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource, BaseFunction>? AwsOrganizationsSource { get; set; }
            /// <summary>
            /// IncludeFutureRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-resourcedatasync-syncsource.html#cfn-ssm-resourcedatasync-syncsource-includefutureregions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeFutureRegions { get; set; }
            /// <summary>
            /// SourceRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-resourcedatasync-syncsource.html#cfn-ssm-resourcedatasync-syncsource-sourceregions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SourceRegions { get; set; }
        }
    }
}