namespace Humidifier.OpenSearchServerless
{
    using global::System.Collections.Generic;
    using CollectionGroupTypes;

    public class CollectionGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
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
        public dynamic Generation { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collectiongroup.html#cfn-opensearchserverless-collectiongroup-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// StandbyReplicas
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collectiongroup.html#cfn-opensearchserverless-collectiongroup-standbyreplicas
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic StandbyReplicas { get; set; }
        /// <summary>
        /// CapacityLimits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collectiongroup.html#cfn-opensearchserverless-collectiongroup-capacitylimits
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapacityLimits
        /// </summary>
        public Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits CapacityLimits { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collectiongroup.html#cfn-opensearchserverless-collectiongroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace CollectionGroupTypes
    {
        public class CapacityLimits : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxSearchCapacityInOcu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collectiongroup-capacitylimits.html#cfn-opensearchserverless-collectiongroup-capacitylimits-maxsearchcapacityinocu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxSearchCapacityInOcu { get; set; }
            /// <summary>
            /// MinIndexingCapacityInOcu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collectiongroup-capacitylimits.html#cfn-opensearchserverless-collectiongroup-capacitylimits-minindexingcapacityinocu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinIndexingCapacityInOcu { get; set; }
            /// <summary>
            /// MaxIndexingCapacityInOcu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collectiongroup-capacitylimits.html#cfn-opensearchserverless-collectiongroup-capacitylimits-maxindexingcapacityinocu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxIndexingCapacityInOcu { get; set; }
            /// <summary>
            /// MinSearchCapacityInOcu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collectiongroup-capacitylimits.html#cfn-opensearchserverless-collectiongroup-capacitylimits-minsearchcapacityinocu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinSearchCapacityInOcu { get; set; }
        }
    }
}