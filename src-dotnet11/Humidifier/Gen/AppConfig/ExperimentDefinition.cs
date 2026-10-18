namespace Humidifier.AppConfig
{
    using global::System.Collections.Generic;
    using ExperimentDefinitionTypes;

    public class ExperimentDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveConfigurationProfileIdentifier, IHaveAppConfigExperimentDefinitionTypesTreatmentControl, IHaveEnvironmentIdentifier, IHaveAudienceDescription, IHaveFlagKey, IHaveLaunchCriteria, IHaveApplicationIdentifier, IHaveAudienceRule, IHaveListOfAppConfigExperimentDefinitionTypesTreatmentTreatments, IHaveHypothesis, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string ApplicationId =  "ApplicationId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.AppConfig.ExperimentDefinition; }

        /// <summary>
        /// ConfigurationProfileIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-configurationprofileidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConfigurationProfileIdentifier { get; set; }

        /// <summary>
        /// Control
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-control
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Treatment
        /// </summary>
        [Required]
        public Union<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment, BaseFunction>? Control { get; set; }

        /// <summary>
        /// EnvironmentIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-environmentidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EnvironmentIdentifier { get; set; }
        /// <summary>
        /// AudienceDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-audiencedescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AudienceDescription { get; set; }

        /// <summary>
        /// FlagKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-flagkey
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FlagKey { get; set; }
        /// <summary>
        /// LaunchCriteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-launchcriteria
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LaunchCriteria { get; set; }

        /// <summary>
        /// ApplicationIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-applicationidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationIdentifier { get; set; }

        /// <summary>
        /// AudienceRule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-audiencerule
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AudienceRule { get; set; }

        /// <summary>
        /// Treatments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-treatments
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Treatment
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment>, IReadOnlyList<Union<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment, BaseFunction>>, BaseFunction>? Treatments { get; set; }
        /// <summary>
        /// Hypothesis
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-hypothesis
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Hypothesis { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ExperimentDefinitionTypes
    {
        public class AttributeValue : Humidifier.Base.BaseSubResource, IHaveStringListOfStringArray, IHaveNumberValue_Double, IHaveBooleanValue_Boolean, IHaveStringValue, IHaveDoubleListOfNumberArray
        {
            /// <summary>
            /// StringArray
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-attributevalue.html#cfn-appconfig-experimentdefinition-attributevalue-stringarray
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StringArray { get; set; }
            /// <summary>
            /// NumberValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-attributevalue.html#cfn-appconfig-experimentdefinition-attributevalue-numbervalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? NumberValue { get; set; }
            /// <summary>
            /// BooleanValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-attributevalue.html#cfn-appconfig-experimentdefinition-attributevalue-booleanvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BooleanValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-attributevalue.html#cfn-appconfig-experimentdefinition-attributevalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StringValue { get; set; }
            /// <summary>
            /// NumberArray
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-attributevalue.html#cfn-appconfig-experimentdefinition-attributevalue-numberarray
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public Union<IReadOnlyList<double>, IReadOnlyList<Union<double, BaseFunction>>, BaseFunction>? NumberArray { get; set; }
        }

        public class Treatment : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveDescription, IHaveKey, IHaveWeight_Double, IHaveMapOfAppConfigExperimentDefinitionTypesAttributeValueAttributeValues
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-treatment.html#cfn-appconfig-experimentdefinition-treatment-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-treatment.html#cfn-appconfig-experimentdefinition-treatment-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-treatment.html#cfn-appconfig-experimentdefinition-treatment-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-treatment.html#cfn-appconfig-experimentdefinition-treatment-weight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Weight { get; set; }
            /// <summary>
            /// AttributeValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-treatment.html#cfn-appconfig-experimentdefinition-treatment-attributevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: AttributeValue
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.AppConfig.ExperimentDefinitionTypes.AttributeValue>, IReadOnlyDictionary<string, Union<Humidifier.AppConfig.ExperimentDefinitionTypes.AttributeValue, BaseFunction>>, BaseFunction>? AttributeValues { get; set; }
        }
    }
}