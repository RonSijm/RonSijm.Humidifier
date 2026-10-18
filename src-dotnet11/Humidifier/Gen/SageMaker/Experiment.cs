namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using ExperimentTypes;

    public class Experiment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveExperimentName, IHaveDisplayName, IHaveListOfSageMakerExperimentTypesTagsItemsTags
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Experiment; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-experiment.html#cfn-sagemaker-experiment-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        public Union<string, BaseFunction>? ExperimentName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-experiment.html#cfn-sagemaker-experiment-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-experiment.html#cfn-sagemaker-experiment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SageMaker.ExperimentTypes.TagsItems>, IReadOnlyList<Union<Humidifier.SageMaker.ExperimentTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ExperimentTypes
    {
        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-experiment-tagsitems.html#cfn-sagemaker-experiment-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-experiment-tagsitems.html#cfn-sagemaker-experiment-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}