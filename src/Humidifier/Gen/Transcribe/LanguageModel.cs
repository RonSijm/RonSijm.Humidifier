namespace Humidifier.Transcribe
{
    using global::System.Collections.Generic;
    using LanguageModelTypes;

    public class LanguageModel : Humidifier.Base.BaseResource, IHaveTags, IHaveLanguageCode, IHaveModelName
    {
        public class Attributes
        {
            public static string UpgradeAvailability =  "UpgradeAvailability" ;
            public static string CreateTime =  "CreateTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Arn =  "Arn" ;
            public static string ModelStatus =  "ModelStatus" ;
        }

        public override string AWSTypeName { get => AWS.Transcribe.LanguageModel; }
        /// <summary>
        /// LanguageCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-languagemodel.html#cfn-transcribe-languagemodel-languagecode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LanguageCode { get; set; }
        /// <summary>
        /// ModelName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-languagemodel.html#cfn-transcribe-languagemodel-modelname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ModelName { get; set; }
        /// <summary>
        /// BaseModelName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-languagemodel.html#cfn-transcribe-languagemodel-basemodelname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BaseModelName { get; set; }
        /// <summary>
        /// InputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-languagemodel.html#cfn-transcribe-languagemodel-inputdataconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InputDataConfig
        /// </summary>
        public Humidifier.Transcribe.LanguageModelTypes.InputDataConfig InputDataConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-languagemodel.html#cfn-transcribe-languagemodel-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace LanguageModelTypes
    {
        public class InputDataConfig : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveDataAccessRoleArn
        {
            /// <summary>
            /// DataAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-languagemodel-inputdataconfig.html#cfn-transcribe-languagemodel-inputdataconfig-dataaccessrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataAccessRoleArn { get; set; }
            /// <summary>
            /// TuningDataS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-languagemodel-inputdataconfig.html#cfn-transcribe-languagemodel-inputdataconfig-tuningdatas3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TuningDataS3Uri { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-languagemodel-inputdataconfig.html#cfn-transcribe-languagemodel-inputdataconfig-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
        }
    }
}