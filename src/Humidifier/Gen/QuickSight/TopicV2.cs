namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using TopicV2Types;

    public class TopicV2 : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveAwsAccountId, IHaveFolderArns
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
        public Humidifier.QuickSight.TopicV2Types.CustomInstructions CustomInstructions { get; set; }
        /// <summary>
        /// DataSetRelations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topicv2.html#cfn-quicksight-topicv2-datasetrelations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DataSetRelation
        /// </summary>
        public List<Humidifier.QuickSight.TopicV2Types.DataSetRelation> DataSetRelations { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topicv2.html#cfn-quicksight-topicv2-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// DataSets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topicv2.html#cfn-quicksight-topicv2-datasets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DataSetReference
        /// </summary>
        public List<Humidifier.QuickSight.TopicV2Types.DataSetReference> DataSets { get; set; }
        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topicv2.html#cfn-quicksight-topicv2-awsaccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AwsAccountId { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topicv2.html#cfn-quicksight-topicv2-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public List<Humidifier.QuickSight.TopicV2Types.ResourcePermission> Permissions { get; set; }
        /// <summary>
        /// FolderArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topicv2.html#cfn-quicksight-topicv2-folderarns
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic FolderArns { get; set; }
        /// <summary>
        /// TopicId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topicv2.html#cfn-quicksight-topicv2-topicid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TopicId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topicv2.html#cfn-quicksight-topicv2-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace TopicV2Types
    {
        public class CustomInstructions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomInstructionsString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-custominstructions.html#cfn-quicksight-topicv2-custominstructions-custominstructionsstring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomInstructionsString { get; set; }
        }

        public class DataSetReference : Humidifier.Base.BaseSubResource, IHaveDataSetArn
        {
            /// <summary>
            /// DataSetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-datasetreference.html#cfn-quicksight-topicv2-datasetreference-datasetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetArn { get; set; }
            /// <summary>
            /// DataSetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-datasetreference.html#cfn-quicksight-topicv2-datasetreference-datasetname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetName { get; set; }
        }

        public class DataSetRelation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Left
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-datasetrelation.html#cfn-quicksight-topicv2-datasetrelation-left
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DataSetRelationEndpoint
            /// </summary>
            public Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint Left { get; set; }
            /// <summary>
            /// Right
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-datasetrelation.html#cfn-quicksight-topicv2-datasetrelation-right
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DataSetRelationEndpoint
            /// </summary>
            public Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint Right { get; set; }
        }

        public class DataSetRelationEndpoint : Humidifier.Base.BaseSubResource, IHaveColumnNames, IHaveDataSetArn
        {
            /// <summary>
            /// DataSetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-datasetrelationendpoint.html#cfn-quicksight-topicv2-datasetrelationendpoint-datasetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetArn { get; set; }
            /// <summary>
            /// ColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-datasetrelationendpoint.html#cfn-quicksight-topicv2-datasetrelationendpoint-columnnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ColumnNames { get; set; }
        }

        public class ResourcePermission : Humidifier.Base.BaseSubResource, IHavePrincipal, IHaveActions
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-resourcepermission.html#cfn-quicksight-topicv2-resourcepermission-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Actions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topicv2-resourcepermission.html#cfn-quicksight-topicv2-resourcepermission-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Principal { get; set; }
        }
    }
}