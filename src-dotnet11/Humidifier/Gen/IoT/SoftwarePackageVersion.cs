namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using SoftwarePackageVersionTypes;

    public class SoftwarePackageVersion : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHavePackageName, IHaveRecipe, IHaveStringDictionaryOfAttributes_, IHaveIoTSoftwarePackageVersionTypesSbomSbom, IHaveVersionName, IHaveIoTSoftwarePackageVersionTypesPackageVersionArtifactArtifact
    {
        public class Attributes
        {
            public static string PackageVersionArn =  "PackageVersionArn" ;
            public static string Status =  "Status" ;
            public static string SbomValidationStatus =  "SbomValidationStatus" ;
            public static string ErrorReason =  "ErrorReason" ;
        }

        public override string AWSTypeName { get => AWS.IoT.SoftwarePackageVersion; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-softwarepackageversion.html#cfn-iot-softwarepackageversion-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// PackageName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-softwarepackageversion.html#cfn-iot-softwarepackageversion-packagename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PackageName { get; set; }
        /// <summary>
        /// Recipe
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-softwarepackageversion.html#cfn-iot-softwarepackageversion-recipe
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Recipe { get; set; }
        /// <summary>
        /// Attributes_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-softwarepackageversion.html#cfn-iot-softwarepackageversion-attributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Attributes_ { get; set; }
        /// <summary>
        /// Sbom
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-softwarepackageversion.html#cfn-iot-softwarepackageversion-sbom
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Sbom
        /// </summary>
        public Union<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom, BaseFunction>? Sbom { get; set; }
        /// <summary>
        /// VersionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-softwarepackageversion.html#cfn-iot-softwarepackageversion-versionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VersionName { get; set; }
        /// <summary>
        /// Artifact
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-softwarepackageversion.html#cfn-iot-softwarepackageversion-artifact
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PackageVersionArtifact
        /// </summary>
        public Union<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact, BaseFunction>? Artifact { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-softwarepackageversion.html#cfn-iot-softwarepackageversion-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace SoftwarePackageVersionTypes
    {
        public class PackageVersionArtifact : Humidifier.Base.BaseSubResource, IHaveIoTSoftwarePackageVersionTypesS3LocationS3Location
        {
            /// <summary>
            /// S3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-softwarepackageversion-packageversionartifact.html#cfn-iot-softwarepackageversion-packageversionartifact-s3location
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location, BaseFunction>? S3Location { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveVersion, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-softwarepackageversion-s3location.html#cfn-iot-softwarepackageversion-s3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-softwarepackageversion-s3location.html#cfn-iot-softwarepackageversion-s3location-version
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-softwarepackageversion-s3location.html#cfn-iot-softwarepackageversion-s3location-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class Sbom : Humidifier.Base.BaseSubResource, IHaveIoTSoftwarePackageVersionTypesS3LocationS3Location
        {
            /// <summary>
            /// S3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-softwarepackageversion-sbom.html#cfn-iot-softwarepackageversion-sbom-s3location
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location, BaseFunction>? S3Location { get; set; }
        }
    }
}