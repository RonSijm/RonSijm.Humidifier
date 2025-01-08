namespace Humidifier.Bedrock
{
    using System.Collections.Generic;
    using ApplicationInferenceProfileTypes;

    public class ApplicationInferenceProfile : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Type =  "Type" ;
            public static string InferenceProfileArn =  "InferenceProfileArn" ;
            public static string InferenceProfileIdentifier =  "InferenceProfileIdentifier" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Models =  "Models" ;
            public static string InferenceProfileId =  "InferenceProfileId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.ApplicationInferenceProfile; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-applicationinferenceprofile.html#cfn-bedrock-applicationinferenceprofile-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// InferenceProfileName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-applicationinferenceprofile.html#cfn-bedrock-applicationinferenceprofile-inferenceprofilename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InferenceProfileName { get; set; }
        /// <summary>
        /// ModelSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-applicationinferenceprofile.html#cfn-bedrock-applicationinferenceprofile-modelsource
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InferenceProfileModelSource
        /// </summary>
        public Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource ModelSource { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-applicationinferenceprofile.html#cfn-bedrock-applicationinferenceprofile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ApplicationInferenceProfileTypes
    {
        public class InferenceProfileModel : Humidifier.Base.BaseSubResource, IHaveModelArn
        {
            /// <summary>
            /// ModelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-applicationinferenceprofile-inferenceprofilemodel.html#cfn-bedrock-applicationinferenceprofile-inferenceprofilemodel-modelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelArn { get; set; }
        }

        public class InferenceProfileModelSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CopyFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-applicationinferenceprofile-inferenceprofilemodelsource.html#cfn-bedrock-applicationinferenceprofile-inferenceprofilemodelsource-copyfrom
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CopyFrom { get; set; }
        }
    }
}