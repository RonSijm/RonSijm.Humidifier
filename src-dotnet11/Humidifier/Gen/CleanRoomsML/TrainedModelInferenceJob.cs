namespace Humidifier.CleanRoomsML
{
    using global::System.Collections.Generic;
    using TrainedModelInferenceJobTypes;

    public class TrainedModelInferenceJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMembershipIdentifier, IHaveDescription, IHaveCleanRoomsMLTrainedModelInferenceJobTypesInferenceOutputConfigurationOutputConfiguration, IHaveTrainedModelArn, IHaveCleanRoomsMLTrainedModelInferenceJobTypesInferenceResourceConfigResourceConfig, IHaveConfiguredModelAlgorithmAssociationArn, IHaveName, IHaveCleanRoomsMLTrainedModelInferenceJobTypesModelInferenceDataSourceDataSource
    {
        public class Attributes
        {
            public static string TrainedModelInferenceJobArn =  "TrainedModelInferenceJobArn" ;
            public static string Status =  "Status" ;
            public static string CreateTime =  "CreateTime" ;
            public static string UpdateTime =  "UpdateTime" ;
        }

        public override string AWSTypeName { get => AWS.CleanRoomsML.TrainedModelInferenceJob; }
        /// <summary>
        /// MembershipIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainedmodelinferencejob.html#cfn-cleanroomsml-trainedmodelinferencejob-membershipidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MembershipIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainedmodelinferencejob.html#cfn-cleanroomsml-trainedmodelinferencejob-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// OutputConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainedmodelinferencejob.html#cfn-cleanroomsml-trainedmodelinferencejob-outputconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InferenceOutputConfiguration
        /// </summary>
        public Union<Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.InferenceOutputConfiguration, BaseFunction>? OutputConfiguration { get; set; }
        /// <summary>
        /// TrainedModelArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainedmodelinferencejob.html#cfn-cleanroomsml-trainedmodelinferencejob-trainedmodelarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TrainedModelArn { get; set; }
        /// <summary>
        /// ResourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainedmodelinferencejob.html#cfn-cleanroomsml-trainedmodelinferencejob-resourceconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InferenceResourceConfig
        /// </summary>
        public Union<Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.InferenceResourceConfig, BaseFunction>? ResourceConfig { get; set; }
        /// <summary>
        /// ConfiguredModelAlgorithmAssociationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainedmodelinferencejob.html#cfn-cleanroomsml-trainedmodelinferencejob-configuredmodelalgorithmassociationarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConfiguredModelAlgorithmAssociationArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainedmodelinferencejob.html#cfn-cleanroomsml-trainedmodelinferencejob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DataSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainedmodelinferencejob.html#cfn-cleanroomsml-trainedmodelinferencejob-datasource
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ModelInferenceDataSource
        /// </summary>
        public Union<Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.ModelInferenceDataSource, BaseFunction>? DataSource { get; set; }
    }

    namespace TrainedModelInferenceJobTypes
    {
        public class InferenceOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveAccept, IHaveListOfCleanRoomsMLTrainedModelInferenceJobTypesInferenceReceiverMemberMembers
        {
            /// <summary>
            /// Accept
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodelinferencejob-inferenceoutputconfiguration.html#cfn-cleanroomsml-trainedmodelinferencejob-inferenceoutputconfiguration-accept
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Accept { get; set; }
            /// <summary>
            /// Members
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodelinferencejob-inferenceoutputconfiguration.html#cfn-cleanroomsml-trainedmodelinferencejob-inferenceoutputconfiguration-members
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: InferenceReceiverMember
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.InferenceReceiverMember>, IReadOnlyList<Union<Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.InferenceReceiverMember, BaseFunction>>, BaseFunction>? Members { get; set; }
        }

        public class InferenceReceiverMember : Humidifier.Base.BaseSubResource, IHaveAccountId
        {
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodelinferencejob-inferencereceivermember.html#cfn-cleanroomsml-trainedmodelinferencejob-inferencereceivermember-accountid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountId { get; set; }
        }

        public class InferenceResourceConfig : Humidifier.Base.BaseSubResource, IHaveInstanceCount_Integer, IHaveInstanceType
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodelinferencejob-inferenceresourceconfig.html#cfn-cleanroomsml-trainedmodelinferencejob-inferenceresourceconfig-instancecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstanceCount { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodelinferencejob-inferenceresourceconfig.html#cfn-cleanroomsml-trainedmodelinferencejob-inferenceresourceconfig-instancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class ModelInferenceDataSource : Humidifier.Base.BaseSubResource, IHaveMlInputChannelArn
        {
            /// <summary>
            /// MlInputChannelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodelinferencejob-modelinferencedatasource.html#cfn-cleanroomsml-trainedmodelinferencejob-modelinferencedatasource-mlinputchannelarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MlInputChannelArn { get; set; }
        }
    }
}