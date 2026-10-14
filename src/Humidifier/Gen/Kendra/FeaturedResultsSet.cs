namespace Humidifier.Kendra
{
    using global::System.Collections.Generic;
    using FeaturedResultsSetTypes;

    public class FeaturedResultsSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveStatus, IHaveIndexId
    {
        public class Attributes
        {
            public static string FeaturedResultsSetId =  "FeaturedResultsSetId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Kendra.FeaturedResultsSet; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-featuredresultsset.html#cfn-kendra-featuredresultsset-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Status { get; set; }

        /// <summary>
        /// IndexId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-featuredresultsset.html#cfn-kendra-featuredresultsset-indexid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IndexId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-featuredresultsset.html#cfn-kendra-featuredresultsset-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// FeaturedDocuments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-featuredresultsset.html#cfn-kendra-featuredresultsset-featureddocuments
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FeaturedDocument
        /// </summary>
        public List<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument> FeaturedDocuments { get; set; }
        /// <summary>
        /// QueryTexts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-featuredresultsset.html#cfn-kendra-featuredresultsset-querytexts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic QueryTexts { get; set; }
        public dynamic FeaturedResultsSetName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-featuredresultsset.html#cfn-kendra-featuredresultsset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace FeaturedResultsSetTypes
    {
        public class FeaturedDocument : Humidifier.Base.BaseSubResource, IHaveId
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-featuredresultsset-featureddocument.html#cfn-kendra-featuredresultsset-featureddocument-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }
    }
}