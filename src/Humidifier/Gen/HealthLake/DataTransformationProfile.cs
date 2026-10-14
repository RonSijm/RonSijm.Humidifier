namespace Humidifier.HealthLake
{
    using global::System.Collections.Generic;
    using DataTransformationProfileTypes;

    public class DataTransformationProfile : Humidifier.Base.BaseResource, IHaveTags, IHaveKmsKeyId, IHaveProfileName
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
        public dynamic KmsKeyId { get; set; }

        /// <summary>
        /// SourceFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-datatransformationprofile.html#cfn-healthlake-datatransformationprofile-sourceformat
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SourceFormat { get; set; }
        /// <summary>
        /// ProfileDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-datatransformationprofile.html#cfn-healthlake-datatransformationprofile-profiledescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProfileDescription { get; set; }

        /// <summary>
        /// ProfileName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-datatransformationprofile.html#cfn-healthlake-datatransformationprofile-profilename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ProfileName { get; set; }
        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-datatransformationprofile.html#cfn-healthlake-datatransformationprofile-source
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Source
        /// </summary>
        public Humidifier.HealthLake.DataTransformationProfileTypes.Source Source { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-datatransformationprofile.html#cfn-healthlake-datatransformationprofile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace DataTransformationProfileTypes
    {
        public class ExistingVersionedProfileSource : Humidifier.Base.BaseSubResource, IHaveVersion, IHaveProfileId
        {
            /// <summary>
            /// ProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-datatransformationprofile-existingversionedprofilesource.html#cfn-healthlake-datatransformationprofile-existingversionedprofilesource-profileid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProfileId { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-datatransformationprofile-existingversionedprofilesource.html#cfn-healthlake-datatransformationprofile-existingversionedprofilesource-version
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Version { get; set; }
        }

        public class ProfileMappingSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProfileMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-datatransformationprofile-profilemappingsource.html#cfn-healthlake-datatransformationprofile-profilemappingsource-profilemapping
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> ProfileMapping { get; set; }
        }

        public class Source : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProfileMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-datatransformationprofile-source.html#cfn-healthlake-datatransformationprofile-source-profilemapping
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileMappingSource
            /// </summary>
            public Humidifier.HealthLake.DataTransformationProfileTypes.ProfileMappingSource ProfileMapping { get; set; }
            /// <summary>
            /// StarterProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-datatransformationprofile-source.html#cfn-healthlake-datatransformationprofile-source-starterprofile
            /// Required: False
            /// UpdateType: Immutable
            /// Type: StarterProfileSource
            /// </summary>
            public Humidifier.HealthLake.DataTransformationProfileTypes.StarterProfileSource StarterProfile { get; set; }
            /// <summary>
            /// ExistingVersionedProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-datatransformationprofile-source.html#cfn-healthlake-datatransformationprofile-source-existingversionedprofileid
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ExistingVersionedProfileSource
            /// </summary>
            public Humidifier.HealthLake.DataTransformationProfileTypes.ExistingVersionedProfileSource ExistingVersionedProfileId { get; set; }
        }

        public class StarterProfileSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StarterProfileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-datatransformationprofile-starterprofilesource.html#cfn-healthlake-datatransformationprofile-starterprofilesource-starterprofilename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StarterProfileName { get; set; }
        }
    }
}