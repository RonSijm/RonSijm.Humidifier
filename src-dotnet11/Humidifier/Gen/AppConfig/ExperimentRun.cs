namespace Humidifier.AppConfig
{
    using global::System.Collections.Generic;
    using ExperimentRunTypes;

    public class ExperimentRun : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveAppConfigExperimentRunTypesTreatmentOverridesTreatmentOverrides, IHaveApplicationIdentifier, IHaveExperimentDefinitionIdentifier, IHaveExposurePercentage_Double
    {
        public class Attributes
        {
            public static string ExperimentDefinitionId =  "ExperimentDefinitionId" ;
            public static string Status =  "Status" ;
            public static string Run =  "Run" ;
            public static string StartedAt =  "StartedAt" ;
            public static string ApplicationId =  "ApplicationId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.AppConfig.ExperimentRun; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentrun.html#cfn-appconfig-experimentrun-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// TreatmentOverrides
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentrun.html#cfn-appconfig-experimentrun-treatmentoverrides
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TreatmentOverrides
        /// </summary>
        public Union<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides, BaseFunction>? TreatmentOverrides { get; set; }

        /// <summary>
        /// ApplicationIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentrun.html#cfn-appconfig-experimentrun-applicationidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationIdentifier { get; set; }

        /// <summary>
        /// ExperimentDefinitionIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentrun.html#cfn-appconfig-experimentrun-experimentdefinitionidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ExperimentDefinitionIdentifier { get; set; }

        /// <summary>
        /// ExposurePercentage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentrun.html#cfn-appconfig-experimentrun-exposurepercentage
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public Union<double, BaseFunction>? ExposurePercentage { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentrun.html#cfn-appconfig-experimentrun-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ExperimentRunTypes
    {
        public class TreatmentOverrides : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfInline
        {
            /// <summary>
            /// Inline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentrun-treatmentoverrides.html#cfn-appconfig-experimentrun-treatmentoverrides-inline
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Inline { get; set; }
        }
    }
}