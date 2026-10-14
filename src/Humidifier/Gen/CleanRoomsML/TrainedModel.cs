namespace Humidifier.CleanRoomsML
{
    using global::System.Collections.Generic;
    using TrainedModelTypes;

    public class TrainedModel : Humidifier.Base.BaseResource, IHaveMembershipIdentifier
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CollaborationIdentifier =  "CollaborationIdentifier" ;
            public static string Description =  "Description" ;
            public static string TrainedModelId =  "TrainedModelId" ;
            public static string TrainingInputMode =  "TrainingInputMode" ;
            public static string CreateTime =  "CreateTime" ;
            public static string TrainedModelArn =  "TrainedModelArn" ;
            public static string Name =  "Name" ;
            public static string TrainingContainerImageDigest =  "TrainingContainerImageDigest" ;
            public static string DataChannels =  "DataChannels" ;
            public static string Hyperparameters =  "Hyperparameters" ;
            public static string StoppingCondition =  "StoppingCondition" ;
            public static string KmsKeyArn =  "KmsKeyArn" ;
            public static string UpdateTime =  "UpdateTime" ;
            public static string Environment =  "Environment" ;
            public static string ResourceConfig =  "ResourceConfig" ;
            public static string ConfiguredModelAlgorithmAssociationArn =  "ConfiguredModelAlgorithmAssociationArn" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.CleanRoomsML.TrainedModel; }
        /// <summary>
        /// MembershipIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainedmodel.html#cfn-cleanroomsml-trainedmodel-membershipidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MembershipIdentifier { get; set; }
    }

    namespace TrainedModelTypes
    {
        public class ModelTrainingDataChannel : Humidifier.Base.BaseSubResource, IHaveChannelName, IHaveS3DataDistributionType
        {
            /// <summary>
            /// S3DataDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodel-modeltrainingdatachannel.html#cfn-cleanroomsml-trainedmodel-modeltrainingdatachannel-s3datadistributiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3DataDistributionType { get; set; }
            /// <summary>
            /// ChannelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodel-modeltrainingdatachannel.html#cfn-cleanroomsml-trainedmodel-modeltrainingdatachannel-channelname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChannelName { get; set; }
            /// <summary>
            /// MlInputChannelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodel-modeltrainingdatachannel.html#cfn-cleanroomsml-trainedmodel-modeltrainingdatachannel-mlinputchannelarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MlInputChannelArn { get; set; }
        }

        public class ResourceConfig : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHaveInstanceCount, IHaveVolumeSizeInGB
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodel-resourceconfig.html#cfn-cleanroomsml-trainedmodel-resourceconfig-instancecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InstanceCount { get; set; }
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodel-resourceconfig.html#cfn-cleanroomsml-trainedmodel-resourceconfig-volumesizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeSizeInGB { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodel-resourceconfig.html#cfn-cleanroomsml-trainedmodel-resourceconfig-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
        }

        public class StoppingCondition : Humidifier.Base.BaseSubResource, IHaveMaxRuntimeInSeconds
        {
            /// <summary>
            /// MaxRuntimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodel-stoppingcondition.html#cfn-cleanroomsml-trainedmodel-stoppingcondition-maxruntimeinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRuntimeInSeconds { get; set; }
        }
    }
}