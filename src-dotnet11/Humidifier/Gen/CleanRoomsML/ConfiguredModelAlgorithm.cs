namespace Humidifier.CleanRoomsML
{
    using global::System.Collections.Generic;
    using ConfiguredModelAlgorithmTypes;

    public class ConfiguredModelAlgorithm : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveKmsKeyArn, IHaveCleanRoomsMLConfiguredModelAlgorithmTypesInferenceContainerConfigInferenceContainerConfig, IHaveRoleArn, IHaveName, IHaveCleanRoomsMLConfiguredModelAlgorithmTypesContainerConfigTrainingContainerConfig
    {
        public class Attributes
        {
            public static string ConfiguredModelAlgorithmArn =  "ConfiguredModelAlgorithmArn" ;
        }

        public override string AWSTypeName { get => AWS.CleanRoomsML.ConfiguredModelAlgorithm; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-configuredmodelalgorithm.html#cfn-cleanroomsml-configuredmodelalgorithm-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-configuredmodelalgorithm.html#cfn-cleanroomsml-configuredmodelalgorithm-kmskeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        /// <summary>
        /// InferenceContainerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-configuredmodelalgorithm.html#cfn-cleanroomsml-configuredmodelalgorithm-inferencecontainerconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InferenceContainerConfig
        /// </summary>
        public Union<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmTypes.InferenceContainerConfig, BaseFunction>? InferenceContainerConfig { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-configuredmodelalgorithm.html#cfn-cleanroomsml-configuredmodelalgorithm-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-configuredmodelalgorithm.html#cfn-cleanroomsml-configuredmodelalgorithm-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// TrainingContainerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-configuredmodelalgorithm.html#cfn-cleanroomsml-configuredmodelalgorithm-trainingcontainerconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ContainerConfig
        /// </summary>
        public Union<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmTypes.ContainerConfig, BaseFunction>? TrainingContainerConfig { get; set; }
    }

    namespace ConfiguredModelAlgorithmTypes
    {
        public class ContainerConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfEntrypoint, IHaveStringListOfArguments, IHaveListOfCleanRoomsMLConfiguredModelAlgorithmTypesMetricDefinitionMetricDefinitions, IHaveImageUri
        {
            /// <summary>
            /// Entrypoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithm-containerconfig.html#cfn-cleanroomsml-configuredmodelalgorithm-containerconfig-entrypoint
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Entrypoint { get; set; }
            /// <summary>
            /// Arguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithm-containerconfig.html#cfn-cleanroomsml-configuredmodelalgorithm-containerconfig-arguments
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Arguments { get; set; }
            /// <summary>
            /// MetricDefinitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithm-containerconfig.html#cfn-cleanroomsml-configuredmodelalgorithm-containerconfig-metricdefinitions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MetricDefinition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmTypes.MetricDefinition>, IReadOnlyList<Union<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmTypes.MetricDefinition, BaseFunction>>, BaseFunction>? MetricDefinitions { get; set; }
            /// <summary>
            /// ImageUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithm-containerconfig.html#cfn-cleanroomsml-configuredmodelalgorithm-containerconfig-imageuri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageUri { get; set; }
        }

        public class InferenceContainerConfig : Humidifier.Base.BaseSubResource, IHaveImageUri
        {
            /// <summary>
            /// ImageUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithm-inferencecontainerconfig.html#cfn-cleanroomsml-configuredmodelalgorithm-inferencecontainerconfig-imageuri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageUri { get; set; }
        }

        public class MetricDefinition : Humidifier.Base.BaseSubResource, IHaveRegex, IHaveName
        {
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithm-metricdefinition.html#cfn-cleanroomsml-configuredmodelalgorithm-metricdefinition-regex
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Regex { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithm-metricdefinition.html#cfn-cleanroomsml-configuredmodelalgorithm-metricdefinition-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}