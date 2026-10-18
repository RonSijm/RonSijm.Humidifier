namespace Humidifier.ElasticBeanstalk
{
    using global::System.Collections.Generic;
    using ApplicationVersionTypes;

    public class ApplicationVersion : Humidifier.Base.BaseResource, IHaveElasticBeanstalkApplicationVersionTypesBuildConfigurationBuildConfiguration, IHaveApplicationName, IHaveDescription, IHaveElasticBeanstalkApplicationVersionTypesImageConfigurationImageConfiguration, IHaveElasticBeanstalkApplicationVersionTypesSourceBundleSourceBundle, IHaveProcess_Boolean
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.ElasticBeanstalk.ApplicationVersion; }
        /// <summary>
        /// BuildConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-applicationversion.html#cfn-elasticbeanstalk-applicationversion-buildconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: BuildConfiguration
        /// </summary>
        public Union<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.BuildConfiguration, BaseFunction>? BuildConfiguration { get; set; }

        /// <summary>
        /// ApplicationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-applicationversion.html#cfn-elasticbeanstalk-applicationversion-applicationname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationName { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-applicationversion.html#cfn-elasticbeanstalk-applicationversion-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ImageConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-applicationversion.html#cfn-elasticbeanstalk-applicationversion-imageconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ImageConfiguration
        /// </summary>
        public Union<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.ImageConfiguration, BaseFunction>? ImageConfiguration { get; set; }
        /// <summary>
        /// SourceBundle
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-applicationversion.html#cfn-elasticbeanstalk-applicationversion-sourcebundle
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SourceBundle
        /// </summary>
        public Union<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle, BaseFunction>? SourceBundle { get; set; }
        /// <summary>
        /// Process
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-applicationversion.html#cfn-elasticbeanstalk-applicationversion-process
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Process { get; set; }
    }

    namespace ApplicationVersionTypes
    {
        public class BuildConfiguration : Humidifier.Base.BaseSubResource, IHaveCodeBuildServiceRole, IHaveArtifactName, IHaveImage, IHaveComputeType, IHaveTimeoutInMinutes_Integer
        {
            /// <summary>
            /// CodeBuildServiceRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-applicationversion-buildconfiguration.html#cfn-elasticbeanstalk-applicationversion-buildconfiguration-codebuildservicerole
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CodeBuildServiceRole { get; set; }
            /// <summary>
            /// ArtifactName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-applicationversion-buildconfiguration.html#cfn-elasticbeanstalk-applicationversion-buildconfiguration-artifactname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ArtifactName { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-applicationversion-buildconfiguration.html#cfn-elasticbeanstalk-applicationversion-buildconfiguration-image
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Image { get; set; }
            /// <summary>
            /// ComputeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-applicationversion-buildconfiguration.html#cfn-elasticbeanstalk-applicationversion-buildconfiguration-computetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComputeType { get; set; }
            /// <summary>
            /// TimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-applicationversion-buildconfiguration.html#cfn-elasticbeanstalk-applicationversion-buildconfiguration-timeoutinminutes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutInMinutes { get; set; }
        }

        public class ImageBuildConfiguration : Humidifier.Base.BaseSubResource, IHaveCodeBuildServiceRole, IHaveType, IHaveArchitecture, IHaveDockerfileLocation, IHaveBuildpack, IHaveComputeType, IHaveTimeoutInMinutes_Integer
        {
            /// <summary>
            /// CodeBuildServiceRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-applicationversion-imagebuildconfiguration.html#cfn-elasticbeanstalk-applicationversion-imagebuildconfiguration-codebuildservicerole
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CodeBuildServiceRole { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-applicationversion-imagebuildconfiguration.html#cfn-elasticbeanstalk-applicationversion-imagebuildconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Architecture
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-applicationversion-imagebuildconfiguration.html#cfn-elasticbeanstalk-applicationversion-imagebuildconfiguration-architecture
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Architecture { get; set; }
            /// <summary>
            /// DockerfileLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-applicationversion-imagebuildconfiguration.html#cfn-elasticbeanstalk-applicationversion-imagebuildconfiguration-dockerfilelocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DockerfileLocation { get; set; }
            /// <summary>
            /// Buildpack
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-applicationversion-imagebuildconfiguration.html#cfn-elasticbeanstalk-applicationversion-imagebuildconfiguration-buildpack
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Buildpack { get; set; }
            /// <summary>
            /// ComputeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-applicationversion-imagebuildconfiguration.html#cfn-elasticbeanstalk-applicationversion-imagebuildconfiguration-computetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComputeType { get; set; }
            /// <summary>
            /// TimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-applicationversion-imagebuildconfiguration.html#cfn-elasticbeanstalk-applicationversion-imagebuildconfiguration-timeoutinminutes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutInMinutes { get; set; }
        }

        public class ImageConfiguration : Humidifier.Base.BaseSubResource, IHaveElasticBeanstalkApplicationVersionTypesImageBuildConfigurationBuild, IHaveElasticBeanstalkApplicationVersionTypesImageSourceSource
        {
            /// <summary>
            /// Build
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-applicationversion-imageconfiguration.html#cfn-elasticbeanstalk-applicationversion-imageconfiguration-build
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ImageBuildConfiguration
            /// </summary>
            public Union<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.ImageBuildConfiguration, BaseFunction>? Build { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-applicationversion-imageconfiguration.html#cfn-elasticbeanstalk-applicationversion-imageconfiguration-source
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ImageSource
            /// </summary>
            public Union<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.ImageSource, BaseFunction>? Source { get; set; }
        }

        public class ImageSource : Humidifier.Base.BaseSubResource, IHaveUri
        {
            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-applicationversion-imagesource.html#cfn-elasticbeanstalk-applicationversion-imagesource-uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Uri { get; set; }
        }

        public class SourceBundle : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveS3Key
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-applicationversion-sourcebundle.html#cfn-elasticbeanstalk-applicationversion-sourcebundle-s3bucket
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-applicationversion-sourcebundle.html#cfn-elasticbeanstalk-applicationversion-sourcebundle-s3key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Key { get; set; }
        }
    }
}