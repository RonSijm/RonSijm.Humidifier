namespace Humidifier.Macie
{
    using global::System.Collections.Generic;
    using FindingsFilterTypes;

    public class FindingsFilter : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAction, IHaveDescription, IHavePosition_Integer, IHaveMacieFindingsFilterTypesFindingCriteriaFindingCriteria, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Macie.FindingsFilter; }
        /// <summary>
        /// Action
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-findingsfilter.html#cfn-macie-findingsfilter-action
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Action { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-findingsfilter.html#cfn-macie-findingsfilter-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Position
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-findingsfilter.html#cfn-macie-findingsfilter-position
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Position { get; set; }

        /// <summary>
        /// FindingCriteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-findingsfilter.html#cfn-macie-findingsfilter-findingcriteria
        /// Required: True
        /// UpdateType: Mutable
        /// Type: FindingCriteria
        /// </summary>
        [Required]
        public Union<Humidifier.Macie.FindingsFilterTypes.FindingCriteria, BaseFunction>? FindingCriteria { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-findingsfilter.html#cfn-macie-findingsfilter-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace FindingsFilterTypes
    {
        public class CriterionAdditionalProperties : Humidifier.Base.BaseSubResource, IHavelt_Long, IHavegte_Long, IHaveStringListOfneq, IHavelte_Long, IHaveStringListOfeq, IHavegt_Long
        {
            /// <summary>
            /// lt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-macie-findingsfilter-criterionadditionalproperties.html#cfn-macie-findingsfilter-criterionadditionalproperties-lt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? lt { get; set; }
            /// <summary>
            /// gte
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-macie-findingsfilter-criterionadditionalproperties.html#cfn-macie-findingsfilter-criterionadditionalproperties-gte
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? gte { get; set; }
            /// <summary>
            /// neq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-macie-findingsfilter-criterionadditionalproperties.html#cfn-macie-findingsfilter-criterionadditionalproperties-neq
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? neq { get; set; }
            /// <summary>
            /// lte
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-macie-findingsfilter-criterionadditionalproperties.html#cfn-macie-findingsfilter-criterionadditionalproperties-lte
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? lte { get; set; }
            /// <summary>
            /// eq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-macie-findingsfilter-criterionadditionalproperties.html#cfn-macie-findingsfilter-criterionadditionalproperties-eq
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? eq { get; set; }
            /// <summary>
            /// gt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-macie-findingsfilter-criterionadditionalproperties.html#cfn-macie-findingsfilter-criterionadditionalproperties-gt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? gt { get; set; }
        }

        public class FindingCriteria : Humidifier.Base.BaseSubResource, IHaveMapOfMacieFindingsFilterTypesCriterionAdditionalPropertiesCriterion
        {
            /// <summary>
            /// Criterion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-macie-findingsfilter-findingcriteria.html#cfn-macie-findingsfilter-findingcriteria-criterion
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: CriterionAdditionalProperties
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.Macie.FindingsFilterTypes.CriterionAdditionalProperties>, IReadOnlyDictionary<string, Union<Humidifier.Macie.FindingsFilterTypes.CriterionAdditionalProperties, BaseFunction>>, BaseFunction>? Criterion { get; set; }
        }
    }
}