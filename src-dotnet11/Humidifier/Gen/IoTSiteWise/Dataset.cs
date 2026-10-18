namespace Humidifier.IoTSiteWise
{
    using global::System.Collections.Generic;
    using DatasetTypes;

    public class Dataset : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIoTSiteWiseDatasetTypesDatasetConfigDatasetConfig, IHaveDatasetName, IHaveWorkspaceName, IHaveDatasetType, IHaveIoTSiteWiseDatasetTypesDatasetSourceDatasetSource, IHaveDatasetDescription, IHaveDescription
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
        public Union<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig, BaseFunction>? DatasetConfig { get; set; }
        public Union<string, BaseFunction>? DatasetName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// WorkspaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dataset.html#cfn-iotsitewise-dataset-workspacename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WorkspaceName { get; set; }
        /// <summary>
        /// DatasetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dataset.html#cfn-iotsitewise-dataset-datasettype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DatasetType { get; set; }
        /// <summary>
        /// DatasetSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dataset.html#cfn-iotsitewise-dataset-datasetsource
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DatasetSource
        /// </summary>
        public Union<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource, BaseFunction>? DatasetSource { get; set; }
        /// <summary>
        /// DatasetDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dataset.html#cfn-iotsitewise-dataset-datasetdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DatasetDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => DatasetDescription; set => DatasetDescription = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dataset.html#cfn-iotsitewise-dataset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DatasetTypes
    {
        public class DatasetConfig : Humidifier.Base.BaseSubResource, IHaveIoTSiteWiseDatasetTypesSessionConfigSession
        {
            /// <summary>
            /// Session
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-datasetconfig.html#cfn-iotsitewise-dataset-datasetconfig-session
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SessionConfig
            /// </summary>
            public Union<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig, BaseFunction>? Session { get; set; }
        }

        public class DatasetSource : Humidifier.Base.BaseSubResource, IHaveSourceType, IHaveSourceFormat, IHaveIoTSiteWiseDatasetTypesSourceDetailSourceDetail
        {
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-datasetsource.html#cfn-iotsitewise-dataset-datasetsource-sourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceType { get; set; }
            /// <summary>
            /// SourceFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-datasetsource.html#cfn-iotsitewise-dataset-datasetsource-sourceformat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceFormat { get; set; }
            /// <summary>
            /// SourceDetail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-datasetsource.html#cfn-iotsitewise-dataset-datasetsource-sourcedetail
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourceDetail
            /// </summary>
            public Union<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail, BaseFunction>? SourceDetail { get; set; }
        }

        public class KendraSourceDetail : Humidifier.Base.BaseSubResource, IHaveKnowledgeBaseArn, IHaveRoleArn
        {
            /// <summary>
            /// KnowledgeBaseArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-kendrasourcedetail.html#cfn-iotsitewise-dataset-kendrasourcedetail-knowledgebasearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KnowledgeBaseArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-kendrasourcedetail.html#cfn-iotsitewise-dataset-kendrasourcedetail-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class SessionConfig : Humidifier.Base.BaseSubResource, IHaveSessionStartTime, IHaveSessionEndTime
        {
            /// <summary>
            /// SessionStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-sessionconfig.html#cfn-iotsitewise-dataset-sessionconfig-sessionstarttime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SessionStartTime { get; set; }
            /// <summary>
            /// SessionEndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-sessionconfig.html#cfn-iotsitewise-dataset-sessionconfig-sessionendtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SessionEndTime { get; set; }
        }

        public class SourceDetail : Humidifier.Base.BaseSubResource, IHaveIoTSiteWiseDatasetTypesKendraSourceDetailKendra
        {
            /// <summary>
            /// Kendra
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-dataset-sourcedetail.html#cfn-iotsitewise-dataset-sourcedetail-kendra
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KendraSourceDetail
            /// </summary>
            public Union<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail, BaseFunction>? Kendra { get; set; }
        }
    }
}