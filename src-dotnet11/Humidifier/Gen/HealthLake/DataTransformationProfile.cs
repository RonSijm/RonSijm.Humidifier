namespace Humidifier.HealthLake
{
    using global::System.Collections.Generic;
    using DataTransformationProfileTypes;

    public class DataTransformationProfile : Humidifier.Base.BaseResource, IHaveTags, IHaveKmsKeyId, IHaveSourceFormat, IHaveProfileDescription, IHaveProfileName, IHaveHealthLakeDataTransformationProfileTypesSourceSource
    {
        public class Attributes
        {
            public static string ProfileId =  "ProfileId" ;
            public static string TargetFormat =  "TargetFormat" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.HealthLake.DataTransformationProfile; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-datatransformationprofile.html#cfn-healthlake-datatransformationprofile-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }

        /// <summary>
        /// SourceFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-datatransformationprofile.html#cfn-healthlake-datatransformationprofile-sourceformat
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SourceFormat { get; set; }
        /// <summary>
        /// ProfileDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-datatransformationprofile.html#cfn-healthlake-datatransformationprofile-profiledescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProfileDescription { get; set; }

        /// <summary>
        /// ProfileName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-datatransformationprofile.html#cfn-healthlake-datatransformationprofile-profilename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProfileName { get; set; }
        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-datatransformationprofile.html#cfn-healthlake-datatransformationprofile-source
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Source
        /// </summary>
        public Union<Humidifier.HealthLake.DataTransformationProfileTypes.Source, BaseFunction>? Source { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-datatransformationprofile.html#cfn-healthlake-datatransformationprofile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DataTransformationProfileTypes
    {
        public class ExistingVersionedProfileSource : Humidifier.Base.BaseSubResource, IHaveProfileId, IHaveVersion_Integer
        {
            /// <summary>
            /// ProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-datatransformationprofile-existingversionedprofilesource.html#cfn-healthlake-datatransformationprofile-existingversionedprofilesource-profileid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProfileId { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-datatransformationprofile-existingversionedprofilesource.html#cfn-healthlake-datatransformationprofile-existingversionedprofilesource-version
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Version { get; set; }
        }

        public class ProfileMappingSource : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfProfileMapping
        {
            /// <summary>
            /// ProfileMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-datatransformationprofile-profilemappingsource.html#cfn-healthlake-datatransformationprofile-profilemappingsource-profilemapping
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ProfileMapping { get; set; }
        }

        public class Source : Humidifier.Base.BaseSubResource, IHaveHealthLakeDataTransformationProfileTypesProfileMappingSourceProfileMapping, IHaveHealthLakeDataTransformationProfileTypesStarterProfileSourceStarterProfile, IHaveHealthLakeDataTransformationProfileTypesExistingVersionedProfileSourceExistingVersionedProfileId
        {
            /// <summary>
            /// ProfileMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-datatransformationprofile-source.html#cfn-healthlake-datatransformationprofile-source-profilemapping
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileMappingSource
            /// </summary>
            public Union<Humidifier.HealthLake.DataTransformationProfileTypes.ProfileMappingSource, BaseFunction>? ProfileMapping { get; set; }
            /// <summary>
            /// StarterProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-datatransformationprofile-source.html#cfn-healthlake-datatransformationprofile-source-starterprofile
            /// Required: False
            /// UpdateType: Immutable
            /// Type: StarterProfileSource
            /// </summary>
            public Union<Humidifier.HealthLake.DataTransformationProfileTypes.StarterProfileSource, BaseFunction>? StarterProfile { get; set; }
            /// <summary>
            /// ExistingVersionedProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-datatransformationprofile-source.html#cfn-healthlake-datatransformationprofile-source-existingversionedprofileid
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ExistingVersionedProfileSource
            /// </summary>
            public Union<Humidifier.HealthLake.DataTransformationProfileTypes.ExistingVersionedProfileSource, BaseFunction>? ExistingVersionedProfileId { get; set; }
        }

        public class StarterProfileSource : Humidifier.Base.BaseSubResource, IHaveStarterProfileName
        {
            /// <summary>
            /// StarterProfileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-datatransformationprofile-starterprofilesource.html#cfn-healthlake-datatransformationprofile-starterprofilesource-starterprofilename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StarterProfileName { get; set; }
        }
    }
}