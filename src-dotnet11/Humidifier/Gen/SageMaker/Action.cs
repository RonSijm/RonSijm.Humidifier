namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using ActionTypes;

    public class Action : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStatus, IHaveActionName, IHaveActionType, IHaveDescription, IHaveStringDictionaryOfProperties, IHaveSageMakerActionTypesMetadataPropertiesMetadataProperties, IHaveSageMakerActionTypesActionSourceSource
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Action; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-action.html#cfn-sagemaker-action-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }
        public Union<string, BaseFunction>? ActionName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ActionType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-action.html#cfn-sagemaker-action-actiontype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ActionType { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-action.html#cfn-sagemaker-action-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Properties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-action.html#cfn-sagemaker-action-properties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Properties { get; set; }
        /// <summary>
        /// MetadataProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-action.html#cfn-sagemaker-action-metadataproperties
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MetadataProperties
        /// </summary>
        public Union<Humidifier.SageMaker.ActionTypes.MetadataProperties, BaseFunction>? MetadataProperties { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-action.html#cfn-sagemaker-action-source
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ActionSource
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.ActionTypes.ActionSource, BaseFunction>? Source { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-action.html#cfn-sagemaker-action-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ActionTypes
    {
        public class ActionSource : Humidifier.Base.BaseSubResource, IHaveSourceUri, IHaveSourceType, IHaveSourceId
        {
            /// <summary>
            /// SourceUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-action-actionsource.html#cfn-sagemaker-action-actionsource-sourceuri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceUri { get; set; }
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-action-actionsource.html#cfn-sagemaker-action-actionsource-sourcetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceType { get; set; }
            /// <summary>
            /// SourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-action-actionsource.html#cfn-sagemaker-action-actionsource-sourceid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceId { get; set; }
        }

        public class MetadataProperties : Humidifier.Base.BaseSubResource, IHaveRepository, IHaveGeneratedBy, IHaveCommitId, IHaveProjectId
        {
            /// <summary>
            /// Repository
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-action-metadataproperties.html#cfn-sagemaker-action-metadataproperties-repository
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Repository { get; set; }
            /// <summary>
            /// GeneratedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-action-metadataproperties.html#cfn-sagemaker-action-metadataproperties-generatedby
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GeneratedBy { get; set; }
            /// <summary>
            /// CommitId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-action-metadataproperties.html#cfn-sagemaker-action-metadataproperties-commitid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CommitId { get; set; }
            /// <summary>
            /// ProjectId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-action-metadataproperties.html#cfn-sagemaker-action-metadataproperties-projectid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProjectId { get; set; }
        }
    }
}