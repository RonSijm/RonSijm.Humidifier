namespace Humidifier.Signer
{
    using global::System.Collections.Generic;
    using SigningJobTypes;

    public class SigningJob : Humidifier.Base.BaseResource, IHaveProfileName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string JobOwner =  "JobOwner" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Source =  "Source" ;
            public static string PlatformDisplayName =  "PlatformDisplayName" ;
            public static string JobInvoker =  "JobInvoker" ;
            public static string PlatformId =  "PlatformId" ;
            public static string CompletedAt =  "CompletedAt" ;
            public static string SignatureExpiresAt =  "SignatureExpiresAt" ;
            public static string RequestedBy =  "RequestedBy" ;
            public static string Arn =  "Arn" ;
            public static string JobId =  "JobId" ;
            public static string SignedObject =  "SignedObject" ;
            public static string ProfileVersion =  "ProfileVersion" ;
        }

        public override string AWSTypeName { get => AWS.Signer.SigningJob; }

        /// <summary>
        /// ProfileName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-signer-signingjob.html#cfn-signer-signingjob-profilename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProfileName { get; set; }
    }

    namespace SigningJobTypes
    {
        public class S3SignedObject : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveKey
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-signer-signingjob-s3signedobject.html#cfn-signer-signingjob-s3signedobject-bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-signer-signingjob-s3signedobject.html#cfn-signer-signingjob-s3signedobject-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class S3Source : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveVersion, IHaveKey
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-signer-signingjob-s3source.html#cfn-signer-signingjob-s3source-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-signer-signingjob-s3source.html#cfn-signer-signingjob-s3source-version
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-signer-signingjob-s3source.html#cfn-signer-signingjob-s3source-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class SignedObject : Humidifier.Base.BaseSubResource, IHaveSignerSigningJobTypesS3SignedObjectS3
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-signer-signingjob-signedobject.html#cfn-signer-signingjob-signedobject-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3SignedObject
            /// </summary>
            public Union<Humidifier.Signer.SigningJobTypes.S3SignedObject, BaseFunction>? S3 { get; set; }
        }

        public class Source : Humidifier.Base.BaseSubResource, IHaveSignerSigningJobTypesS3SourceS3
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-signer-signingjob-source.html#cfn-signer-signingjob-source-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Source
            /// </summary>
            public Union<Humidifier.Signer.SigningJobTypes.S3Source, BaseFunction>? S3 { get; set; }
        }
    }
}