namespace Humidifier.ASK
{
    using global::System.Collections.Generic;
    using SkillTypes;

    public class Skill : Humidifier.Base.BaseResource, IHaveASKSkillTypesAuthenticationConfigurationAuthenticationConfiguration, IHaveVendorId, IHaveASKSkillTypesSkillPackageSkillPackage
    {
        public override string AWSTypeName { get => Alexa.ASK.Skill; }

        /// <summary>
        /// AuthenticationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ask-skill.html#cfn-ask-skill-authenticationconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AuthenticationConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.ASK.SkillTypes.AuthenticationConfiguration, BaseFunction>? AuthenticationConfiguration { get; set; }

        /// <summary>
        /// VendorId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ask-skill.html#cfn-ask-skill-vendorid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VendorId { get; set; }

        /// <summary>
        /// SkillPackage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ask-skill.html#cfn-ask-skill-skillpackage
        /// Required: True
        /// UpdateType: Mutable
        /// Type: SkillPackage
        /// </summary>
        [Required]
        public Union<Humidifier.ASK.SkillTypes.SkillPackage, BaseFunction>? SkillPackage { get; set; }
    }

    namespace SkillTypes
    {
        public class AuthenticationConfiguration : Humidifier.Base.BaseSubResource, IHaveRefreshToken, IHaveClientSecret, IHaveClientId
        {
            /// <summary>
            /// RefreshToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-authenticationconfiguration.html#cfn-ask-skill-authenticationconfiguration-refreshtoken
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefreshToken { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-authenticationconfiguration.html#cfn-ask-skill-authenticationconfiguration-clientsecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-authenticationconfiguration.html#cfn-ask-skill-authenticationconfiguration-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
        }

        public class Overrides : Humidifier.Base.BaseSubResource, IHaveManifest_Json
        {
            /// <summary>
            /// Manifest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-overrides.html#cfn-ask-skill-overrides-manifest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Manifest { get; set; }
        }

        public class SkillPackage : Humidifier.Base.BaseSubResource, IHaveS3BucketRole, IHaveS3ObjectVersion, IHaveS3Bucket, IHaveS3Key, IHaveASKSkillTypesOverridesOverrides
        {
            /// <summary>
            /// S3BucketRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-skillpackage.html#cfn-ask-skill-skillpackage-s3bucketrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketRole { get; set; }
            /// <summary>
            /// S3ObjectVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-skillpackage.html#cfn-ask-skill-skillpackage-s3objectversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3ObjectVersion { get; set; }
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-skillpackage.html#cfn-ask-skill-skillpackage-s3bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-skillpackage.html#cfn-ask-skill-skillpackage-s3key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Key { get; set; }
            /// <summary>
            /// Overrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-skillpackage.html#cfn-ask-skill-skillpackage-overrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Overrides
            /// </summary>
            public Union<Humidifier.ASK.SkillTypes.Overrides, BaseFunction>? Overrides { get; set; }
        }
    }
}