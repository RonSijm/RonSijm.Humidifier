namespace Humidifier.CleanRoomsML
{
    using global::System.Collections.Generic;
    using ConfiguredModelAlgorithmAssociationTypes;

    public class ConfiguredModelAlgorithmAssociation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMembershipIdentifier, IHaveDescription, IHaveCleanRoomsMLConfiguredModelAlgorithmAssociationTypesPrivacyConfigurationPrivacyConfiguration, IHaveConfiguredModelAlgorithmArn, IHaveName
    {
        public class Attributes
        {
            public static string CollaborationIdentifier =  "CollaborationIdentifier" ;
            public static string ConfiguredModelAlgorithmAssociationArn =  "ConfiguredModelAlgorithmAssociationArn" ;
        }

        public override string AWSTypeName { get => AWS.CleanRoomsML.ConfiguredModelAlgorithmAssociation; }

        /// <summary>
        /// MembershipIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-configuredmodelalgorithmassociation.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-membershipidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MembershipIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-configuredmodelalgorithmassociation.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// PrivacyConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-configuredmodelalgorithmassociation.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-privacyconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PrivacyConfiguration
        /// </summary>
        public Union<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration, BaseFunction>? PrivacyConfiguration { get; set; }

        /// <summary>
        /// ConfiguredModelAlgorithmArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-configuredmodelalgorithmassociation.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-configuredmodelalgorithmarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConfiguredModelAlgorithmArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-configuredmodelalgorithmassociation.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConfiguredModelAlgorithmAssociationTypes
    {
        public class CustomEntityConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfCustomDataIdentifiers
        {
            /// <summary>
            /// CustomDataIdentifiers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-customentityconfig.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-customentityconfig-customdataidentifiers
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CustomDataIdentifiers { get; set; }
        }

        public class LogRedactionConfiguration : Humidifier.Base.BaseSubResource, IHaveCleanRoomsMLConfiguredModelAlgorithmAssociationTypesCustomEntityConfigCustomEntityConfig, IHaveStringListOfEntitiesToRedact
        {
            /// <summary>
            /// CustomEntityConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-logredactionconfiguration.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-logredactionconfiguration-customentityconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CustomEntityConfig
            /// </summary>
            public Union<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.CustomEntityConfig, BaseFunction>? CustomEntityConfig { get; set; }
            /// <summary>
            /// EntitiesToRedact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-logredactionconfiguration.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-logredactionconfiguration-entitiestoredact
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EntitiesToRedact { get; set; }
        }

        public class LogsConfigurationPolicy : Humidifier.Base.BaseSubResource, IHaveLogType, IHaveFilterPattern, IHaveStringListOfAllowedAccountIds, IHaveCleanRoomsMLConfiguredModelAlgorithmAssociationTypesLogRedactionConfigurationLogRedactionConfiguration
        {
            /// <summary>
            /// LogType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-logsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-logsconfigurationpolicy-logtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogType { get; set; }
            /// <summary>
            /// FilterPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-logsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-logsconfigurationpolicy-filterpattern
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilterPattern { get; set; }
            /// <summary>
            /// AllowedAccountIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-logsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-logsconfigurationpolicy-allowedaccountids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedAccountIds { get; set; }
            /// <summary>
            /// LogRedactionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-logsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-logsconfigurationpolicy-logredactionconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LogRedactionConfiguration
            /// </summary>
            public Union<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.LogRedactionConfiguration, BaseFunction>? LogRedactionConfiguration { get; set; }
        }

        public class MetricsConfigurationPolicy : Humidifier.Base.BaseSubResource, IHaveNoiseLevel
        {
            /// <summary>
            /// NoiseLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-metricsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-metricsconfigurationpolicy-noiselevel
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NoiseLevel { get; set; }
        }

        public class PrivacyConfiguration : Humidifier.Base.BaseSubResource, IHaveCleanRoomsMLConfiguredModelAlgorithmAssociationTypesPrivacyConfigurationPoliciesPolicies
        {
            /// <summary>
            /// Policies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-privacyconfiguration.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-privacyconfiguration-policies
            /// Required: True
            /// UpdateType: Immutable
            /// Type: PrivacyConfigurationPolicies
            /// </summary>
            public Union<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfigurationPolicies, BaseFunction>? Policies { get; set; }
        }

        public class PrivacyConfigurationPolicies : Humidifier.Base.BaseSubResource, IHaveCleanRoomsMLConfiguredModelAlgorithmAssociationTypesTrainedModelExportsConfigurationPolicyTrainedModelExports, IHaveCleanRoomsMLConfiguredModelAlgorithmAssociationTypesTrainedModelInferenceJobsConfigurationPolicyTrainedModelInferenceJobs, IHaveCleanRoomsMLConfiguredModelAlgorithmAssociationTypesTrainedModelsConfigurationPolicyTrainedModels
        {
            /// <summary>
            /// TrainedModelExports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-privacyconfigurationpolicies.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-privacyconfigurationpolicies-trainedmodelexports
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TrainedModelExportsConfigurationPolicy
            /// </summary>
            public Union<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsConfigurationPolicy, BaseFunction>? TrainedModelExports { get; set; }
            /// <summary>
            /// TrainedModelInferenceJobs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-privacyconfigurationpolicies.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-privacyconfigurationpolicies-trainedmodelinferencejobs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TrainedModelInferenceJobsConfigurationPolicy
            /// </summary>
            public Union<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelInferenceJobsConfigurationPolicy, BaseFunction>? TrainedModelInferenceJobs { get; set; }
            /// <summary>
            /// TrainedModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-privacyconfigurationpolicies.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-privacyconfigurationpolicies-trainedmodels
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TrainedModelsConfigurationPolicy
            /// </summary>
            public Union<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelsConfigurationPolicy, BaseFunction>? TrainedModels { get; set; }
        }

        public class TrainedModelArtifactMaxSize : Humidifier.Base.BaseSubResource, IHaveValue_Double, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelartifactmaxsize.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelartifactmaxsize-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelartifactmaxsize.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelartifactmaxsize-unit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class TrainedModelExportsConfigurationPolicy : Humidifier.Base.BaseSubResource, IHaveStringListOfFilesToExport, IHaveCleanRoomsMLConfiguredModelAlgorithmAssociationTypesTrainedModelExportsMaxSizeMaxSize
        {
            /// <summary>
            /// FilesToExport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelexportsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelexportsconfigurationpolicy-filestoexport
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FilesToExport { get; set; }
            /// <summary>
            /// MaxSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelexportsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelexportsconfigurationpolicy-maxsize
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TrainedModelExportsMaxSize
            /// </summary>
            public Union<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize, BaseFunction>? MaxSize { get; set; }
        }

        public class TrainedModelExportsMaxSize : Humidifier.Base.BaseSubResource, IHaveValue_Double, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelexportsmaxsize.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelexportsmaxsize-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelexportsmaxsize.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelexportsmaxsize-unit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class TrainedModelInferenceJobsConfigurationPolicy : Humidifier.Base.BaseSubResource, IHaveCleanRoomsMLConfiguredModelAlgorithmAssociationTypesTrainedModelInferenceMaxOutputSizeMaxOutputSize, IHaveListOfCleanRoomsMLConfiguredModelAlgorithmAssociationTypesLogsConfigurationPolicyContainerLogs
        {
            /// <summary>
            /// MaxOutputSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelinferencejobsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelinferencejobsconfigurationpolicy-maxoutputsize
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TrainedModelInferenceMaxOutputSize
            /// </summary>
            public Union<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelInferenceMaxOutputSize, BaseFunction>? MaxOutputSize { get; set; }
            /// <summary>
            /// ContainerLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelinferencejobsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelinferencejobsconfigurationpolicy-containerlogs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: LogsConfigurationPolicy
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.LogsConfigurationPolicy>, IReadOnlyList<Union<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.LogsConfigurationPolicy, BaseFunction>>, BaseFunction>? ContainerLogs { get; set; }
        }

        public class TrainedModelInferenceMaxOutputSize : Humidifier.Base.BaseSubResource, IHaveValue_Double, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelinferencemaxoutputsize.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelinferencemaxoutputsize-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelinferencemaxoutputsize.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelinferencemaxoutputsize-unit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class TrainedModelsConfigurationPolicy : Humidifier.Base.BaseSubResource, IHaveListOfCleanRoomsMLConfiguredModelAlgorithmAssociationTypesLogsConfigurationPolicyContainerLogs, IHaveCleanRoomsMLConfiguredModelAlgorithmAssociationTypesTrainedModelArtifactMaxSizeMaxArtifactSize, IHaveCleanRoomsMLConfiguredModelAlgorithmAssociationTypesMetricsConfigurationPolicyContainerMetrics
        {
            /// <summary>
            /// ContainerLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelsconfigurationpolicy-containerlogs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: LogsConfigurationPolicy
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.LogsConfigurationPolicy>, IReadOnlyList<Union<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.LogsConfigurationPolicy, BaseFunction>>, BaseFunction>? ContainerLogs { get; set; }
            /// <summary>
            /// MaxArtifactSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelsconfigurationpolicy-maxartifactsize
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TrainedModelArtifactMaxSize
            /// </summary>
            public Union<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelArtifactMaxSize, BaseFunction>? MaxArtifactSize { get; set; }
            /// <summary>
            /// ContainerMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelsconfigurationpolicy-containermetrics
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsConfigurationPolicy
            /// </summary>
            public Union<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.MetricsConfigurationPolicy, BaseFunction>? ContainerMetrics { get; set; }
        }
    }
}