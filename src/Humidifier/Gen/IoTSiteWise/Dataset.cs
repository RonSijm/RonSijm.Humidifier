namespace Humidifier.IoTSiteWise
{
    using global::System.Collections.Generic;
    using DatasetTypes;

    public class Dataset : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDatasetName, IHaveDatasetType, IHaveDescription
    {
        public class Attributes
        {
            public static string DatasetArn =  "DatasetArn" ;
            public static string DatasetId =  "DatasetId" ;
        }

        public override string AWSTypeName { get => AWS.IoTSiteWise.Dataset; }
        /// <summary>
        /// DatasetConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dataset.html#cfn-iotsitewise-dataset-datasetconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DatasetConfig
        /// </summary>
        public Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig DatasetConfig { get; set; }
        public dynamic DatasetName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// WorkspaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dataset.html#cfn-iotsitewise-dataset-workspacename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic WorkspaceName { get; set; }
        /// <summary>
        /// DatasetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dataset.html#cfn-iotsitewise-dataset-datasettype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DatasetType { get; set; }
        /// <summary>
        /// DatasetSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dataset.html#cfn-iotsitewise-dataset-datasetsource
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DatasetSource
        /// </summary>
        public Humidifier.IoTSiteWise.DatasetTypes.DatasetSource DatasetSource { get; set; }
        /// <summary>
        /// DatasetDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dataset.html#cfn-iotsitewise-dataset-datasetdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DatasetDescription { get; set; }

        [Ignore]
        public dynamic Description { get => DatasetDescription; set => DatasetDescription = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dataset.html#cfn-iotsitewise-dataset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace DatasetTypes
    {
        public class DatasetConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Session
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-datasetconfig.html#cfn-iotsitewise-dataset-datasetconfig-session
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SessionConfig
            /// </summary>
            public Humidifier.IoTSiteWise.DatasetTypes.SessionConfig Session { get; set; }
        }

        public class DatasetSource : Humidifier.Base.BaseSubResource, IHaveSourceType
        {
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-datasetsource.html#cfn-iotsitewise-dataset-datasetsource-sourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceType { get; set; }
            /// <summary>
            /// SourceFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-datasetsource.html#cfn-iotsitewise-dataset-datasetsource-sourceformat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFormat { get; set; }
            /// <summary>
            /// SourceDetail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-datasetsource.html#cfn-iotsitewise-dataset-datasetsource-sourcedetail
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourceDetail
            /// </summary>
            public Humidifier.IoTSiteWise.DatasetTypes.SourceDetail SourceDetail { get; set; }
        }

        public class KendraSourceDetail : Humidifier.Base.BaseSubResource, IHaveRoleArn
        {
            /// <summary>
            /// KnowledgeBaseArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-kendrasourcedetail.html#cfn-iotsitewise-dataset-kendrasourcedetail-knowledgebasearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KnowledgeBaseArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-kendrasourcedetail.html#cfn-iotsitewise-dataset-kendrasourcedetail-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class SessionConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SessionStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-sessionconfig.html#cfn-iotsitewise-dataset-sessionconfig-sessionstarttime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SessionStartTime { get; set; }
            /// <summary>
            /// SessionEndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-sessionconfig.html#cfn-iotsitewise-dataset-sessionconfig-sessionendtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SessionEndTime { get; set; }
        }

        public class SourceDetail : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Kendra
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-sourcedetail.html#cfn-iotsitewise-dataset-sourcedetail-kendra
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KendraSourceDetail
            /// </summary>
            public Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail Kendra { get; set; }
        }
    }
}