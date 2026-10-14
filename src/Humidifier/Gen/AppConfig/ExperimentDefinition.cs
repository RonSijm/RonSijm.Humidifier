namespace Humidifier.AppConfig
{
    using global::System.Collections.Generic;
    using ExperimentDefinitionTypes;

    public class ExperimentDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveEnvironmentIdentifier, IHaveApplicationIdentifier
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
        public dynamic ConfigurationProfileIdentifier { get; set; }

        /// <summary>
        /// Control
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-control
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Treatment
        /// </summary>
        [Required]
        public Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment Control { get; set; }

        /// <summary>
        /// EnvironmentIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-environmentidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EnvironmentIdentifier { get; set; }
        /// <summary>
        /// AudienceDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-audiencedescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AudienceDescription { get; set; }

        /// <summary>
        /// FlagKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-flagkey
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FlagKey { get; set; }
        /// <summary>
        /// LaunchCriteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-launchcriteria
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LaunchCriteria { get; set; }

        /// <summary>
        /// ApplicationIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-applicationidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ApplicationIdentifier { get; set; }

        /// <summary>
        /// AudienceRule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-audiencerule
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AudienceRule { get; set; }

        /// <summary>
        /// Treatments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-treatments
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Treatment
        /// </summary>
        [Required]
        public List<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> Treatments { get; set; }
        /// <summary>
        /// Hypothesis
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-hypothesis
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Hypothesis { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-experimentdefinition.html#cfn-appconfig-experimentdefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ExperimentDefinitionTypes
    {
        public class AttributeValue : Humidifier.Base.BaseSubResource, IHaveStringValue, IHaveBooleanValue
        {
            /// <summary>
            /// StringArray
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-attributevalue.html#cfn-appconfig-experimentdefinition-attributevalue-stringarray
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StringArray { get; set; }
            /// <summary>
            /// NumberValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-attributevalue.html#cfn-appconfig-experimentdefinition-attributevalue-numbervalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic NumberValue { get; set; }
            /// <summary>
            /// BooleanValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-attributevalue.html#cfn-appconfig-experimentdefinition-attributevalue-booleanvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic BooleanValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-attributevalue.html#cfn-appconfig-experimentdefinition-attributevalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StringValue { get; set; }
            /// <summary>
            /// NumberArray
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-attributevalue.html#cfn-appconfig-experimentdefinition-attributevalue-numberarray
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> NumberArray { get; set; }
        }

        public class Treatment : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveKey, IHaveEnabled, IHaveWeight
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-treatment.html#cfn-appconfig-experimentdefinition-treatment-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-treatment.html#cfn-appconfig-experimentdefinition-treatment-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-treatment.html#cfn-appconfig-experimentdefinition-treatment-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-treatment.html#cfn-appconfig-experimentdefinition-treatment-weight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Weight { get; set; }
            /// <summary>
            /// AttributeValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-experimentdefinition-treatment.html#cfn-appconfig-experimentdefinition-treatment-attributevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: AttributeValue
            /// </summary>
            public Dictionary<string, Humidifier.AppConfig.ExperimentDefinitionTypes.AttributeValue> AttributeValues { get; set; }
        }
    }
}