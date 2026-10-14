namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using ModelInvocationJobTypes;

    public class ModelInvocationJob : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string OutputDataConfig =  "OutputDataConfig" ;
            public static string VpcConfig =  "VpcConfig" ;
            public static string JobName =  "JobName" ;
            public static string TimeoutDurationInHours =  "TimeoutDurationInHours" ;
            public static string InputDataConfig =  "InputDataConfig" ;
            public static string SubmitTime =  "SubmitTime" ;
            public static string RoleArn =  "RoleArn" ;
            public static string JobArn =  "JobArn" ;
            public static string JobExpirationTime =  "JobExpirationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string ModelId =  "ModelId" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.ModelInvocationJob; }
    }

    namespace ModelInvocationJobTypes
    {
        public class ModelInvocationJobInputDataConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3InputDataConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-modelinvocationjob-modelinvocationjobinputdataconfig.html#cfn-bedrock-modelinvocationjob-modelinvocationjobinputdataconfig-s3inputdataconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ModelInvocationJobS3InputDataConfig
            /// </summary>
            public Humidifier.Bedrock.ModelInvocationJobTypes.ModelInvocationJobS3InputDataConfig S3InputDataConfig { get; set; }
        }

        public class ModelInvocationJobOutputDataConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3OutputDataConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-modelinvocationjob-modelinvocationjoboutputdataconfig.html#cfn-bedrock-modelinvocationjob-modelinvocationjoboutputdataconfig-s3outputdataconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ModelInvocationJobS3OutputDataConfig
            /// </summary>
            public Humidifier.Bedrock.ModelInvocationJobTypes.ModelInvocationJobS3OutputDataConfig S3OutputDataConfig { get; set; }
        }

        public class ModelInvocationJobS3InputDataConfig : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-modelinvocationjob-modelinvocationjobs3inputdataconfig.html#cfn-bedrock-modelinvocationjob-modelinvocationjobs3inputdataconfig-s3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
            /// <summary>
            /// S3BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-modelinvocationjob-modelinvocationjobs3inputdataconfig.html#cfn-bedrock-modelinvocationjob-modelinvocationjobs3inputdataconfig-s3bucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketOwner { get; set; }
        }

        public class ModelInvocationJobS3OutputDataConfig : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-modelinvocationjob-modelinvocationjobs3outputdataconfig.html#cfn-bedrock-modelinvocationjob-modelinvocationjobs3outputdataconfig-s3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
            /// <summary>
            /// S3BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-modelinvocationjob-modelinvocationjobs3outputdataconfig.html#cfn-bedrock-modelinvocationjob-modelinvocationjobs3outputdataconfig-s3bucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketOwner { get; set; }
            /// <summary>
            /// S3EncryptionKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-modelinvocationjob-modelinvocationjobs3outputdataconfig.html#cfn-bedrock-modelinvocationjob-modelinvocationjobs3outputdataconfig-s3encryptionkeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3EncryptionKeyId { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds
        {
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-modelinvocationjob-vpcconfig.html#cfn-bedrock-modelinvocationjob-vpcconfig-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-modelinvocationjob-vpcconfig.html#cfn-bedrock-modelinvocationjob-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }
    }
}