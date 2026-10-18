namespace Humidifier.RDS
{
    using global::System.Collections.Generic;

    public class CustomDBEngineVersion : Humidifier.Base.BaseResource, IHaveTags, IHaveStatus, IHaveDescription, IHaveEngineVersion, IHaveKMSKeyId, IHaveDatabaseInstallationFilesS3Prefix, IHaveManifest, IHaveStringListOfDatabaseInstallationFiles, IHaveDatabaseInstallationFilesS3BucketName, IHaveUseAwsProvidedLatestImage_Boolean, IHaveImageId, IHaveSourceCustomDbEngineVersionIdentifier, IHaveEngine
    {
        public class Attributes
        {
            public static string DBEngineVersionArn =  "DBEngineVersionArn" ;
        }

        public override string AWSTypeName { get => AWS.RDS.CustomDBEngineVersion; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-customdbengineversion.html#cfn-rds-customdbengineversion-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-customdbengineversion.html#cfn-rds-customdbengineversion-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// EngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-customdbengineversion.html#cfn-rds-customdbengineversion-engineversion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EngineVersion { get; set; }
        /// <summary>
        /// KMSKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-customdbengineversion.html#cfn-rds-customdbengineversion-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KMSKeyId { get; set; }
        /// <summary>
        /// DatabaseInstallationFilesS3Prefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-customdbengineversion.html#cfn-rds-customdbengineversion-databaseinstallationfiless3prefix
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DatabaseInstallationFilesS3Prefix { get; set; }
        /// <summary>
        /// Manifest
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-customdbengineversion.html#cfn-rds-customdbengineversion-manifest
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Manifest { get; set; }
        /// <summary>
        /// DatabaseInstallationFiles
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-customdbengineversion.html#cfn-rds-customdbengineversion-databaseinstallationfiles
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DatabaseInstallationFiles { get; set; }
        /// <summary>
        /// DatabaseInstallationFilesS3BucketName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-customdbengineversion.html#cfn-rds-customdbengineversion-databaseinstallationfiless3bucketname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DatabaseInstallationFilesS3BucketName { get; set; }
        /// <summary>
        /// UseAwsProvidedLatestImage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-customdbengineversion.html#cfn-rds-customdbengineversion-useawsprovidedlatestimage
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? UseAwsProvidedLatestImage { get; set; }
        /// <summary>
        /// ImageId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-customdbengineversion.html#cfn-rds-customdbengineversion-imageid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImageId { get; set; }
        /// <summary>
        /// SourceCustomDbEngineVersionIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-customdbengineversion.html#cfn-rds-customdbengineversion-sourcecustomdbengineversionidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceCustomDbEngineVersionIdentifier { get; set; }

        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-customdbengineversion.html#cfn-rds-customdbengineversion-engine
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Engine { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-customdbengineversion.html#cfn-rds-customdbengineversion-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}