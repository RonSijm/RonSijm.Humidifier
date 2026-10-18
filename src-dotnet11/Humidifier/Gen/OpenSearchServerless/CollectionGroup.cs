namespace Humidifier.OpenSearchServerless
{
    using global::System.Collections.Generic;
    using CollectionGroupTypes;

    public class CollectionGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveGeneration, IHaveDescription, IHaveStandbyReplicas, IHaveOpenSearchServerlessCollectionGroupTypesCapacityLimitsCapacityLimits, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.OpenSearchServerless.CollectionGroup; }
        /// <summary>
        /// Generation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collectiongroup.html#cfn-opensearchserverless-collectiongroup-generation
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Generation { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collectiongroup.html#cfn-opensearchserverless-collectiongroup-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// StandbyReplicas
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collectiongroup.html#cfn-opensearchserverless-collectiongroup-standbyreplicas
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StandbyReplicas { get; set; }
        /// <summary>
        /// CapacityLimits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collectiongroup.html#cfn-opensearchserverless-collectiongroup-capacitylimits
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapacityLimits
        /// </summary>
        public Union<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits, BaseFunction>? CapacityLimits { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collectiongroup.html#cfn-opensearchserverless-collectiongroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace CollectionGroupTypes
    {
        public class CapacityLimits : Humidifier.Base.BaseSubResource, IHaveMaxSearchCapacityInOcu_Double, IHaveMinIndexingCapacityInOcu_Double, IHaveMaxIndexingCapacityInOcu_Double, IHaveMinSearchCapacityInOcu_Double
        {
            /// <summary>
            /// MaxSearchCapacityInOcu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collectiongroup-capacitylimits.html#cfn-opensearchserverless-collectiongroup-capacitylimits-maxsearchcapacityinocu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxSearchCapacityInOcu { get; set; }
            /// <summary>
            /// MinIndexingCapacityInOcu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collectiongroup-capacitylimits.html#cfn-opensearchserverless-collectiongroup-capacitylimits-minindexingcapacityinocu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinIndexingCapacityInOcu { get; set; }
            /// <summary>
            /// MaxIndexingCapacityInOcu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collectiongroup-capacitylimits.html#cfn-opensearchserverless-collectiongroup-capacitylimits-maxindexingcapacityinocu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxIndexingCapacityInOcu { get; set; }
            /// <summary>
            /// MinSearchCapacityInOcu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collectiongroup-capacitylimits.html#cfn-opensearchserverless-collectiongroup-capacitylimits-minsearchcapacityinocu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinSearchCapacityInOcu { get; set; }
        }
    }
}