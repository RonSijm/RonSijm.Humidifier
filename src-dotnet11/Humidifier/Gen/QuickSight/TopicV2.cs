namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using TopicV2Types;

    public class TopicV2 : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveQuickSightTopicV2TypesCustomInstructionsCustomInstructions, IHaveListOfQuickSightTopicV2TypesDataSetRelationDataSetRelations, IHaveDescription, IHaveListOfQuickSightTopicV2TypesDataSetReferenceDataSets, IHaveAwsAccountId, IHaveListOfQuickSightTopicV2TypesResourcePermissionPermissions, IHaveStringListOfFolderArns, IHaveTopicId, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.TopicV2; }
        /// <summary>
        /// CustomInstructions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topicv2.html#cfn-quicksight-topicv2-custominstructions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomInstructions
        /// </summary>
        public Union<Humidifier.QuickSight.TopicV2Types.CustomInstructions, BaseFunction>? CustomInstructions { get; set; }
        /// <summary>
        /// DataSetRelations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topicv2.html#cfn-quicksight-topicv2-datasetrelations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DataSetRelation
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QuickSight.TopicV2Types.DataSetRelation>, IReadOnlyList<Union<Humidifier.QuickSight.TopicV2Types.DataSetRelation, BaseFunction>>, BaseFunction>? DataSetRelations { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topicv2.html#cfn-quicksight-topicv2-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// DataSets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topicv2.html#cfn-quicksight-topicv2-datasets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DataSetReference
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QuickSight.TopicV2Types.DataSetReference>, IReadOnlyList<Union<Humidifier.QuickSight.TopicV2Types.DataSetReference, BaseFunction>>, BaseFunction>? DataSets { get; set; }
        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topicv2.html#cfn-quicksight-topicv2-awsaccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AwsAccountId { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topicv2.html#cfn-quicksight-topicv2-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QuickSight.TopicV2Types.ResourcePermission>, IReadOnlyList<Union<Humidifier.QuickSight.TopicV2Types.ResourcePermission, BaseFunction>>, BaseFunction>? Permissions { get; set; }
        /// <summary>
        /// FolderArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topicv2.html#cfn-quicksight-topicv2-folderarns
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FolderArns { get; set; }
        /// <summary>
        /// TopicId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topicv2.html#cfn-quicksight-topicv2-topicid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TopicId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topicv2.html#cfn-quicksight-topicv2-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace TopicV2Types
    {
        public class CustomInstructions : Humidifier.Base.BaseSubResource, IHaveCustomInstructionsString
        {
            /// <summary>
            /// CustomInstructionsString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-custominstructions.html#cfn-quicksight-topicv2-custominstructions-custominstructionsstring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomInstructionsString { get; set; }
        }

        public class DataSetReference : Humidifier.Base.BaseSubResource, IHaveDataSetArn, IHaveDataSetName
        {
            /// <summary>
            /// DataSetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-datasetreference.html#cfn-quicksight-topicv2-datasetreference-datasetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSetArn { get; set; }
            /// <summary>
            /// DataSetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-datasetreference.html#cfn-quicksight-topicv2-datasetreference-datasetname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSetName { get; set; }
        }

        public class DataSetRelation : Humidifier.Base.BaseSubResource, IHaveQuickSightTopicV2TypesDataSetRelationEndpointLeft, IHaveQuickSightTopicV2TypesDataSetRelationEndpointRight
        {
            /// <summary>
            /// Left
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-datasetrelation.html#cfn-quicksight-topicv2-datasetrelation-left
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DataSetRelationEndpoint
            /// </summary>
            public Union<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint, BaseFunction>? Left { get; set; }
            /// <summary>
            /// Right
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-datasetrelation.html#cfn-quicksight-topicv2-datasetrelation-right
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DataSetRelationEndpoint
            /// </summary>
            public Union<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint, BaseFunction>? Right { get; set; }
        }

        public class DataSetRelationEndpoint : Humidifier.Base.BaseSubResource, IHaveDataSetArn, IHaveStringListOfColumnNames
        {
            /// <summary>
            /// DataSetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-datasetrelationendpoint.html#cfn-quicksight-topicv2-datasetrelationendpoint-datasetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSetArn { get; set; }
            /// <summary>
            /// ColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-datasetrelationendpoint.html#cfn-quicksight-topicv2-datasetrelationendpoint-columnnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ColumnNames { get; set; }
        }

        public class ResourcePermission : Humidifier.Base.BaseSubResource, IHaveStringListOfActions, IHavePrincipal
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-resourcepermission.html#cfn-quicksight-topicv2-resourcepermission-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-resourcepermission.html#cfn-quicksight-topicv2-resourcepermission-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Principal { get; set; }
        }
    }
}