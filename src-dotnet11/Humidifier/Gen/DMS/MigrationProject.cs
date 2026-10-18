namespace Humidifier.DMS
{
    using global::System.Collections.Generic;
    using MigrationProjectTypes;

    public class MigrationProject : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfDMSMigrationProjectTypesDataProviderDescriptorTargetDataProviderDescriptors, IHaveMigrationProjectName, IHaveInstanceProfileName, IHaveDescription, IHaveMigrationProjectIdentifier, IHaveListOfDMSMigrationProjectTypesDataProviderDescriptorSourceDataProviderDescriptors, IHaveTransformationRules, IHaveDMSMigrationProjectTypesSchemaConversionApplicationAttributesSchemaConversionApplicationAttributes, IHaveInstanceProfileArn, IHaveInstanceProfileIdentifier
    {
        public class Attributes
        {
            public static string MigrationProjectArn =  "MigrationProjectArn" ;
        }

        public override string AWSTypeName { get => AWS.DMS.MigrationProject; }
        /// <summary>
        /// TargetDataProviderDescriptors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-targetdataproviderdescriptors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DataProviderDescriptor
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor>, IReadOnlyList<Union<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor, BaseFunction>>, BaseFunction>? TargetDataProviderDescriptors { get; set; }
        public Union<string, BaseFunction>? MigrationProjectName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// InstanceProfileName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-instanceprofilename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceProfileName { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// MigrationProjectIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-migrationprojectidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MigrationProjectIdentifier { get; set; }
        /// <summary>
        /// SourceDataProviderDescriptors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-sourcedataproviderdescriptors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DataProviderDescriptor
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor>, IReadOnlyList<Union<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor, BaseFunction>>, BaseFunction>? SourceDataProviderDescriptors { get; set; }
        /// <summary>
        /// TransformationRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-transformationrules
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TransformationRules { get; set; }
        /// <summary>
        /// SchemaConversionApplicationAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-schemaconversionapplicationattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SchemaConversionApplicationAttributes
        /// </summary>
        public Union<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes, BaseFunction>? SchemaConversionApplicationAttributes { get; set; }
        /// <summary>
        /// InstanceProfileArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-instanceprofilearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceProfileArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// InstanceProfileIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-instanceprofileidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceProfileIdentifier { get; set; }
    }

    namespace MigrationProjectTypes
    {
        public class DataProviderDescriptor : Humidifier.Base.BaseSubResource, IHaveDataProviderArn, IHaveDataProviderName, IHaveSecretsManagerSecretId, IHaveSecretsManagerAccessRoleArn, IHaveDataProviderIdentifier
        {
            /// <summary>
            /// DataProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-migrationproject-dataproviderdescriptor.html#cfn-dms-migrationproject-dataproviderdescriptor-dataproviderarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataProviderArn { get; set; }
            /// <summary>
            /// DataProviderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-migrationproject-dataproviderdescriptor.html#cfn-dms-migrationproject-dataproviderdescriptor-dataprovidername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataProviderName { get; set; }
            /// <summary>
            /// SecretsManagerSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-migrationproject-dataproviderdescriptor.html#cfn-dms-migrationproject-dataproviderdescriptor-secretsmanagersecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerSecretId { get; set; }
            /// <summary>
            /// SecretsManagerAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-migrationproject-dataproviderdescriptor.html#cfn-dms-migrationproject-dataproviderdescriptor-secretsmanageraccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerAccessRoleArn { get; set; }
            /// <summary>
            /// DataProviderIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-migrationproject-dataproviderdescriptor.html#cfn-dms-migrationproject-dataproviderdescriptor-dataprovideridentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataProviderIdentifier { get; set; }
        }

        public class SchemaConversionApplicationAttributes : Humidifier.Base.BaseSubResource, IHaveS3BucketPath, IHaveS3BucketRoleArn
        {
            /// <summary>
            /// S3BucketPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-migrationproject-schemaconversionapplicationattributes.html#cfn-dms-migrationproject-schemaconversionapplicationattributes-s3bucketpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketPath { get; set; }
            /// <summary>
            /// S3BucketRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-migrationproject-schemaconversionapplicationattributes.html#cfn-dms-migrationproject-schemaconversionapplicationattributes-s3bucketrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketRoleArn { get; set; }
        }
    }
}