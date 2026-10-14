namespace Humidifier.CleanRoomsML
{
    using global::System.Collections.Generic;
    using ConfiguredModelAlgorithmAssociationTypes;

    public class ConfiguredModelAlgorithmAssociation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveMembershipIdentifier
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
        public dynamic MembershipIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-configuredmodelalgorithmassociation.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// PrivacyConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-configuredmodelalgorithmassociation.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-privacyconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PrivacyConfiguration
        /// </summary>
        public Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration PrivacyConfiguration { get; set; }

        /// <summary>
        /// ConfiguredModelAlgorithmArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-configuredmodelalgorithmassociation.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-configuredmodelalgorithmarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ConfiguredModelAlgorithmArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-configuredmodelalgorithmassociation.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConfiguredModelAlgorithmAssociationTypes
    {
        public class CustomEntityConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomDataIdentifiers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-customentityconfig.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-customentityconfig-customdataidentifiers
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CustomDataIdentifiers { get; set; }
        }

        public class LogRedactionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomEntityConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-logredactionconfiguration.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-logredactionconfiguration-customentityconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CustomEntityConfig
            /// </summary>
            public Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.CustomEntityConfig CustomEntityConfig { get; set; }
            /// <summary>
            /// EntitiesToRedact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-logredactionconfiguration.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-logredactionconfiguration-entitiestoredact
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic EntitiesToRedact { get; set; }
        }

        public class LogsConfigurationPolicy : Humidifier.Base.BaseSubResource, IHaveLogType, IHaveFilterPattern
        {
            /// <summary>
            /// LogType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-logsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-logsconfigurationpolicy-logtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogType { get; set; }
            /// <summary>
            /// FilterPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-logsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-logsconfigurationpolicy-filterpattern
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterPattern { get; set; }
            /// <summary>
            /// AllowedAccountIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-logsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-logsconfigurationpolicy-allowedaccountids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedAccountIds { get; set; }
            /// <summary>
            /// LogRedactionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-logsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-logsconfigurationpolicy-logredactionconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LogRedactionConfiguration
            /// </summary>
            public Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.LogRedactionConfiguration LogRedactionConfiguration { get; set; }
        }

        public class MetricsConfigurationPolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NoiseLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-metricsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-metricsconfigurationpolicy-noiselevel
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NoiseLevel { get; set; }
        }

        public class PrivacyConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Policies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-privacyconfiguration.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-privacyconfiguration-policies
            /// Required: True
            /// UpdateType: Immutable
            /// Type: PrivacyConfigurationPolicies
            /// </summary>
            public Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfigurationPolicies Policies { get; set; }
        }

        public class PrivacyConfigurationPolicies : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TrainedModelExports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-privacyconfigurationpolicies.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-privacyconfigurationpolicies-trainedmodelexports
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TrainedModelExportsConfigurationPolicy
            /// </summary>
            public Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsConfigurationPolicy TrainedModelExports { get; set; }
            /// <summary>
            /// TrainedModelInferenceJobs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-privacyconfigurationpolicies.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-privacyconfigurationpolicies-trainedmodelinferencejobs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TrainedModelInferenceJobsConfigurationPolicy
            /// </summary>
            public Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelInferenceJobsConfigurationPolicy TrainedModelInferenceJobs { get; set; }
            /// <summary>
            /// TrainedModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-privacyconfigurationpolicies.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-privacyconfigurationpolicies-trainedmodels
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TrainedModelsConfigurationPolicy
            /// </summary>
            public Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelsConfigurationPolicy TrainedModels { get; set; }
        }

        public class TrainedModelArtifactMaxSize : Humidifier.Base.BaseSubResource, IHaveValue, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelartifactmaxsize.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelartifactmaxsize-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelartifactmaxsize.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelartifactmaxsize-unit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }

        public class TrainedModelExportsConfigurationPolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FilesToExport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelexportsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelexportsconfigurationpolicy-filestoexport
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic FilesToExport { get; set; }
            /// <summary>
            /// MaxSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelexportsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelexportsconfigurationpolicy-maxsize
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TrainedModelExportsMaxSize
            /// </summary>
            public Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize MaxSize { get; set; }
        }

        public class TrainedModelExportsMaxSize : Humidifier.Base.BaseSubResource, IHaveValue, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelexportsmaxsize.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelexportsmaxsize-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelexportsmaxsize.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelexportsmaxsize-unit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }

        public class TrainedModelInferenceJobsConfigurationPolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxOutputSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelinferencejobsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelinferencejobsconfigurationpolicy-maxoutputsize
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TrainedModelInferenceMaxOutputSize
            /// </summary>
            public Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelInferenceMaxOutputSize MaxOutputSize { get; set; }
            /// <summary>
            /// ContainerLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelinferencejobsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelinferencejobsconfigurationpolicy-containerlogs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: LogsConfigurationPolicy
            /// </summary>
            public List<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.LogsConfigurationPolicy> ContainerLogs { get; set; }
        }

        public class TrainedModelInferenceMaxOutputSize : Humidifier.Base.BaseSubResource, IHaveValue, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelinferencemaxoutputsize.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelinferencemaxoutputsize-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelinferencemaxoutputsize.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelinferencemaxoutputsize-unit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }

        public class TrainedModelsConfigurationPolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContainerLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelsconfigurationpolicy-containerlogs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: LogsConfigurationPolicy
            /// </summary>
            public List<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.LogsConfigurationPolicy> ContainerLogs { get; set; }
            /// <summary>
            /// MaxArtifactSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelsconfigurationpolicy-maxartifactsize
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TrainedModelArtifactMaxSize
            /// </summary>
            public Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelArtifactMaxSize MaxArtifactSize { get; set; }
            /// <summary>
            /// ContainerMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelsconfigurationpolicy.html#cfn-cleanroomsml-configuredmodelalgorithmassociation-trainedmodelsconfigurationpolicy-containermetrics
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricsConfigurationPolicy
            /// </summary>
            public Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.MetricsConfigurationPolicy ContainerMetrics { get; set; }
        }
    }
}