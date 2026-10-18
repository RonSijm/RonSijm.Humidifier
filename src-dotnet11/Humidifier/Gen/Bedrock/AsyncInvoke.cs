namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using AsyncInvokeTypes;

    public class AsyncInvoke : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string ModelArn =  "ModelArn" ;
            public static string Status =  "Status" ;
            public static string InvocationArn =  "InvocationArn" ;
            public static string EndTime =  "EndTime" ;
            public static string OutputDataConfig =  "OutputDataConfig" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string InvocationId =  "InvocationId" ;
            public static string SubmitTime =  "SubmitTime" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.AsyncInvoke; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-asyncinvoke.html#cfn-bedrock-asyncinvoke-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace AsyncInvokeTypes
    {
        public class AsyncInvokeOutputDataConfig : Humidifier.Base.BaseSubResource, IHaveBedrockAsyncInvokeTypesAsyncInvokeS3OutputDataConfigS3OutputDataConfig
        {
            /// <summary>
            /// S3OutputDataConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-asyncinvoke-asyncinvokeoutputdataconfig.html#cfn-bedrock-asyncinvoke-asyncinvokeoutputdataconfig-s3outputdataconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AsyncInvokeS3OutputDataConfig
            /// </summary>
            public Union<Humidifier.Bedrock.AsyncInvokeTypes.AsyncInvokeS3OutputDataConfig, BaseFunction>? S3OutputDataConfig { get; set; }
        }

        public class AsyncInvokeS3OutputDataConfig : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-asyncinvoke-asyncinvokes3outputdataconfig.html#cfn-bedrock-asyncinvoke-asyncinvokes3outputdataconfig-s3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }
    }
}