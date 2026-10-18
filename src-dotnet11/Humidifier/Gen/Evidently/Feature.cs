namespace Humidifier.Evidently
{
    using global::System.Collections.Generic;
    using FeatureTypes;

    public class Feature : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveProject, IHaveDescription, IHaveEvaluationStrategy, IHaveDefaultVariation, IHaveListOfEvidentlyFeatureTypesEntityOverrideEntityOverrides, IHaveListOfEvidentlyFeatureTypesVariationObjectVariations, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Evidently.Feature; }

        /// <summary>
        /// Project
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-feature.html#cfn-evidently-feature-project
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Project { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-feature.html#cfn-evidently-feature-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// EvaluationStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-feature.html#cfn-evidently-feature-evaluationstrategy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EvaluationStrategy { get; set; }
        /// <summary>
        /// DefaultVariation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-feature.html#cfn-evidently-feature-defaultvariation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultVariation { get; set; }
        /// <summary>
        /// EntityOverrides
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-feature.html#cfn-evidently-feature-entityoverrides
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EntityOverride
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Evidently.FeatureTypes.EntityOverride>, IReadOnlyList<Union<Humidifier.Evidently.FeatureTypes.EntityOverride, BaseFunction>>, BaseFunction>? EntityOverrides { get; set; }

        /// <summary>
        /// Variations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-feature.html#cfn-evidently-feature-variations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: VariationObject
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Evidently.FeatureTypes.VariationObject>, IReadOnlyList<Union<Humidifier.Evidently.FeatureTypes.VariationObject, BaseFunction>>, BaseFunction>? Variations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-feature.html#cfn-evidently-feature-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace FeatureTypes
    {
        public class EntityOverride : Humidifier.Base.BaseSubResource, IHaveEntityId, IHaveVariation
        {
            /// <summary>
            /// EntityId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-feature-entityoverride.html#cfn-evidently-feature-entityoverride-entityid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntityId { get; set; }
            /// <summary>
            /// Variation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-feature-entityoverride.html#cfn-evidently-feature-entityoverride-variation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Variation { get; set; }
        }

        public class VariationObject : Humidifier.Base.BaseSubResource, IHaveVariationName, IHaveDoubleValue_Double, IHaveBooleanValue_Boolean, IHaveLongValue_Double, IHaveStringValue
        {
            /// <summary>
            /// VariationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-feature-variationobject.html#cfn-evidently-feature-variationobject-variationname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VariationName { get; set; }
            /// <summary>
            /// DoubleValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-feature-variationobject.html#cfn-evidently-feature-variationobject-doublevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DoubleValue { get; set; }
            /// <summary>
            /// BooleanValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-feature-variationobject.html#cfn-evidently-feature-variationobject-booleanvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BooleanValue { get; set; }
            /// <summary>
            /// LongValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-feature-variationobject.html#cfn-evidently-feature-variationobject-longvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? LongValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-feature-variationobject.html#cfn-evidently-feature-variationobject-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StringValue { get; set; }
        }
    }
}