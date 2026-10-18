namespace Humidifier.Comprehend
{
    using global::System.Collections.Generic;
    using PiiEntitiesDetectionJobTypes;

    public class PiiEntitiesDetectionJob : Humidifier.Base.BaseResource, IHaveLanguageCode, IHaveDataAccessRoleArn, IHaveMode, IHaveJobName, IHaveComprehendPiiEntitiesDetectionJobTypesRedactionConfigRedactionConfig, IHaveComprehendPiiEntitiesDetectionJobTypesInputDataConfigInputDataConfig, IHaveListOfComprehendPiiEntitiesDetectionJobTypesTagsItemsTags
    {
        public class Attributes
        {
            public static string JobArn =  "JobArn" ;
            public static string JobStatus =  "JobStatus" ;
            public static string OutputDataConfig =  "OutputDataConfig" ;
            public static string SubmitTime =  "SubmitTime" ;
            public static string JobId =  "JobId" ;
        }

        public override string AWSTypeName { get => AWS.Comprehend.PiiEntitiesDetectionJob; }

        /// <summary>
        /// LanguageCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-piientitiesdetectionjob.html#cfn-comprehend-piientitiesdetectionjob-languagecode
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LanguageCode { get; set; }

        /// <summary>
        /// DataAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-piientitiesdetectionjob.html#cfn-comprehend-piientitiesdetectionjob-dataaccessrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataAccessRoleArn { get; set; }

        /// <summary>
        /// Mode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-piientitiesdetectionjob.html#cfn-comprehend-piientitiesdetectionjob-mode
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Mode { get; set; }
        /// <summary>
        /// JobName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-piientitiesdetectionjob.html#cfn-comprehend-piientitiesdetectionjob-jobname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobName { get; set; }
        /// <summary>
        /// RedactionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-piientitiesdetectionjob.html#cfn-comprehend-piientitiesdetectionjob-redactionconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RedactionConfig
        /// </summary>
        public Union<Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.RedactionConfig, BaseFunction>? RedactionConfig { get; set; }

        /// <summary>
        /// InputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-piientitiesdetectionjob.html#cfn-comprehend-piientitiesdetectionjob-inputdataconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: InputDataConfig
        /// </summary>
        [Required]
        public Union<Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.InputDataConfig, BaseFunction>? InputDataConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-piientitiesdetectionjob.html#cfn-comprehend-piientitiesdetectionjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.TagsItems>, IReadOnlyList<Union<Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PiiEntitiesDetectionJobTypes
    {
        public class InputDataConfig : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveInputFormat
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-piientitiesdetectionjob-inputdataconfig.html#cfn-comprehend-piientitiesdetectionjob-inputdataconfig-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// InputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-piientitiesdetectionjob-inputdataconfig.html#cfn-comprehend-piientitiesdetectionjob-inputdataconfig-inputformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputFormat { get; set; }
        }

        public class OutputDataConfig : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-piientitiesdetectionjob-outputdataconfig.html#cfn-comprehend-piientitiesdetectionjob-outputdataconfig-s3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class RedactionConfig : Humidifier.Base.BaseSubResource, IHaveMaskMode, IHaveMaskCharacter, IHaveStringListOfPiiEntityTypes
        {
            /// <summary>
            /// MaskMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-piientitiesdetectionjob-redactionconfig.html#cfn-comprehend-piientitiesdetectionjob-redactionconfig-maskmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaskMode { get; set; }
            /// <summary>
            /// MaskCharacter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-piientitiesdetectionjob-redactionconfig.html#cfn-comprehend-piientitiesdetectionjob-redactionconfig-maskcharacter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaskCharacter { get; set; }
            /// <summary>
            /// PiiEntityTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-piientitiesdetectionjob-redactionconfig.html#cfn-comprehend-piientitiesdetectionjob-redactionconfig-piientitytypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PiiEntityTypes { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-piientitiesdetectionjob-tagsitems.html#cfn-comprehend-piientitiesdetectionjob-tagsitems-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-piientitiesdetectionjob-tagsitems.html#cfn-comprehend-piientitiesdetectionjob-tagsitems-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}