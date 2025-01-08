namespace Humidifier.DMS
{
    using System.Collections.Generic;
    using MigrationProjectTypes;

    public class MigrationProject : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveInstanceProfileName, IHaveMigrationProjectIdentifier, IHaveInstanceProfileIdentifier, IHaveInstanceProfileArn
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
        public List<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> TargetDataProviderDescriptors { get; set; }
        public dynamic MigrationProjectName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// InstanceProfileName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-instanceprofilename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceProfileName { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// MigrationProjectIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-migrationprojectidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MigrationProjectIdentifier { get; set; }
        /// <summary>
        /// SourceDataProviderDescriptors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-sourcedataproviderdescriptors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DataProviderDescriptor
        /// </summary>
        public List<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> SourceDataProviderDescriptors { get; set; }
        /// <summary>
        /// TransformationRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-transformationrules
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TransformationRules { get; set; }
        /// <summary>
        /// SchemaConversionApplicationAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-schemaconversionapplicationattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SchemaConversionApplicationAttributes
        /// </summary>
        public Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes SchemaConversionApplicationAttributes { get; set; }
        /// <summary>
        /// InstanceProfileArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-instanceprofilearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceProfileArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// InstanceProfileIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-migrationproject.html#cfn-dms-migrationproject-instanceprofileidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceProfileIdentifier { get; set; }
    }

    namespace MigrationProjectTypes
    {
        public class DataProviderDescriptor : Humidifier.Base.BaseSubResource, IHaveSecretsManagerSecretId, IHaveSecretsManagerAccessRoleArn, IHaveDataProviderName, IHaveDataProviderIdentifier
        {
            /// <summary>
            /// DataProviderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-migrationproject-dataproviderdescriptor.html#cfn-dms-migrationproject-dataproviderdescriptor-dataprovidername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataProviderName { get; set; }
            /// <summary>
            /// DataProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-migrationproject-dataproviderdescriptor.html#cfn-dms-migrationproject-dataproviderdescriptor-dataproviderarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataProviderArn { get; set; }
            /// <summary>
            /// SecretsManagerSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-migrationproject-dataproviderdescriptor.html#cfn-dms-migrationproject-dataproviderdescriptor-secretsmanagersecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretsManagerSecretId { get; set; }
            /// <summary>
            /// SecretsManagerAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-migrationproject-dataproviderdescriptor.html#cfn-dms-migrationproject-dataproviderdescriptor-secretsmanageraccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretsManagerAccessRoleArn { get; set; }
            /// <summary>
            /// DataProviderIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-migrationproject-dataproviderdescriptor.html#cfn-dms-migrationproject-dataproviderdescriptor-dataprovideridentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataProviderIdentifier { get; set; }
        }

        public class SchemaConversionApplicationAttributes : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3BucketPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-migrationproject-schemaconversionapplicationattributes.html#cfn-dms-migrationproject-schemaconversionapplicationattributes-s3bucketpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketPath { get; set; }
            /// <summary>
            /// S3BucketRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-migrationproject-schemaconversionapplicationattributes.html#cfn-dms-migrationproject-schemaconversionapplicationattributes-s3bucketrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketRoleArn { get; set; }
        }
    }
}