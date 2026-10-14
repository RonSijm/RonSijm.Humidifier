namespace Humidifier.CleanRoomsML
{
    using global::System.Collections.Generic;
    using TrainedModelInferenceJobTypes;

    public class TrainedModelInferenceJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveMembershipIdentifier
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
        public dynamic MembershipIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainedmodelinferencejob.html#cfn-cleanroomsml-trainedmodelinferencejob-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// OutputConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainedmodelinferencejob.html#cfn-cleanroomsml-trainedmodelinferencejob-outputconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InferenceOutputConfiguration
        /// </summary>
        public Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.InferenceOutputConfiguration OutputConfiguration { get; set; }
        /// <summary>
        /// TrainedModelArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainedmodelinferencejob.html#cfn-cleanroomsml-trainedmodelinferencejob-trainedmodelarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TrainedModelArn { get; set; }
        /// <summary>
        /// ResourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainedmodelinferencejob.html#cfn-cleanroomsml-trainedmodelinferencejob-resourceconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InferenceResourceConfig
        /// </summary>
        public Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.InferenceResourceConfig ResourceConfig { get; set; }
        /// <summary>
        /// ConfiguredModelAlgorithmAssociationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainedmodelinferencejob.html#cfn-cleanroomsml-trainedmodelinferencejob-configuredmodelalgorithmassociationarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ConfiguredModelAlgorithmAssociationArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainedmodelinferencejob.html#cfn-cleanroomsml-trainedmodelinferencejob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DataSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainedmodelinferencejob.html#cfn-cleanroomsml-trainedmodelinferencejob-datasource
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ModelInferenceDataSource
        /// </summary>
        public Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.ModelInferenceDataSource DataSource { get; set; }
    }

    namespace TrainedModelInferenceJobTypes
    {
        public class InferenceOutputConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Accept
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodelinferencejob-inferenceoutputconfiguration.html#cfn-cleanroomsml-trainedmodelinferencejob-inferenceoutputconfiguration-accept
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Accept { get; set; }
            /// <summary>
            /// Members
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodelinferencejob-inferenceoutputconfiguration.html#cfn-cleanroomsml-trainedmodelinferencejob-inferenceoutputconfiguration-members
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: InferenceReceiverMember
            /// </summary>
            public List<Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.InferenceReceiverMember> Members { get; set; }
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
            public dynamic AccountId { get; set; }
        }

        public class InferenceResourceConfig : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHaveInstanceCount
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodelinferencejob-inferenceresourceconfig.html#cfn-cleanroomsml-trainedmodelinferencejob-inferenceresourceconfig-instancecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InstanceCount { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodelinferencejob-inferenceresourceconfig.html#cfn-cleanroomsml-trainedmodelinferencejob-inferenceresourceconfig-instancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
        }

        public class ModelInferenceDataSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MlInputChannelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainedmodelinferencejob-modelinferencedatasource.html#cfn-cleanroomsml-trainedmodelinferencejob-modelinferencedatasource-mlinputchannelarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MlInputChannelArn { get; set; }
        }
    }
}